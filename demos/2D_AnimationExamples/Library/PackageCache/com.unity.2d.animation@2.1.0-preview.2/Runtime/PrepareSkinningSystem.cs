using System.Collections.Generic;
using Unity.Collections;
using Unity.Entities;
using Unity.Mathematics;
using UnityEngine.Experimental.U2D.Common;
using UnityEngine.Scripting;

namespace UnityEngine.Experimental.U2D.Animation
{
    [Preserve]
    [UnityEngine.ExecuteAlways]
    [UpdateInGroup(typeof(PresentationSystemGroup))]
    public class PrepareSkinningSystem : ComponentSystem
    {
        ComponentGroup m_ComponentGroup;

        protected override void OnCreateManager()
        {
            m_ComponentGroup = GetComponentGroup(typeof(SpriteSkin), typeof(WorldToLocal), typeof(SpriteComponent), typeof(Vertex), typeof(BoneTransform));
        }

        protected override void OnUpdate()
        {
            var entities = m_ComponentGroup.ToEntityArray(Allocator.TempJob);
            List<SpriteSkin> spriteSkinComponents = new List<SpriteSkin>();
            List<SpriteComponent> spriteComponents = new List<SpriteComponent>();
            Entities.ForEach((SpriteSkin spriteSkin) => { spriteSkinComponents.Add(spriteSkin); });
            Entities.ForEach((SpriteComponent sprite) => { spriteComponents.Add(sprite); });
            var worldToLocalComponents = m_ComponentGroup.ToComponentDataArray<WorldToLocal>(Allocator.TempJob);

            for (var i = 0; i < entities.Length; ++i)
            {
                var vertexBuffer = EntityManager.GetBuffer<Vertex>(entities[i]);
                var boneTransformBuffer = EntityManager.GetBuffer<BoneTransform>(entities[i]);
                var currentSprite = spriteComponents[i].Value;
                var currentWorldToLocal = worldToLocalComponents[i];
                Sprite sprite = null;
                var entity = entities[i];
                var spriteSkin = spriteSkinComponents[i];
                
                if (spriteSkin == null)
                    continue;
                    
                var spriteRenderer = spriteSkin.spriteRenderer;
                var isValid = spriteRenderer.enabled && spriteSkin.isValid;
                var isVisible = spriteRenderer.isVisible || spriteSkin.ForceSkinning;

                if (!isValid)
                    SpriteRendererDataAccessExtensions.DeactivateDeformableBuffer(spriteRenderer);
                else if (isVisible)
                {
                    spriteSkin.ForceSkinning = false;
                    sprite = spriteRenderer.sprite;
                    float4x4 worldToLocal = spriteSkin.transform.worldToLocalMatrix;

                    if (vertexBuffer.Length != sprite.GetVertexCount())
                    {
                        vertexBuffer = PostUpdateCommands.SetBuffer<Vertex>(entity);
                        vertexBuffer.ResizeUninitialized(sprite.GetVertexCount());
                    }

                    InternalEngineBridge.SetDeformableBuffer(spriteRenderer, vertexBuffer.Reinterpret<Vector3>().AsNativeArray());

                    if (boneTransformBuffer.Length != spriteSkin.boneTransforms.Length)
                    {
                        boneTransformBuffer = PostUpdateCommands.SetBuffer<BoneTransform>(entity);
                        boneTransformBuffer.ResizeUninitialized(spriteSkin.boneTransforms.Length);
                    }

                    for (var j = 0; j < boneTransformBuffer.Length; ++j)
                        boneTransformBuffer[j] = new BoneTransform() { Value = spriteSkin.boneTransforms[j].localToWorldMatrix };

                    PostUpdateCommands.SetComponent<WorldToLocal>(entity, new WorldToLocal() { Value = worldToLocal });
                }

                if (currentSprite != sprite)
                    PostUpdateCommands.SetSharedComponent<SpriteComponent>(entity, new SpriteComponent() { Value = sprite });

                if (!spriteRenderer.enabled)
                    spriteSkin.ForceSkinning = true;
            }

            entities.Dispose();
            worldToLocalComponents.Dispose();
        }
    }
}
