using System.Collections.Generic;
using Unity.Collections;
using Unity.Entities;
using Unity.Jobs;
using Unity.Mathematics;
using UnityEngine.Jobs;
using UnityEngine.Experimental.U2D.Common;
using UnityEngine.Scripting;

namespace UnityEngine.Experimental.U2D.Animation
{
    [Preserve]
    [UnityEngine.ExecuteAlways]
    [UpdateInGroup(typeof(PresentationSystemGroup))]
    [UpdateAfter(typeof(DeformSpriteSystem))]
    public class UpdateBoundsSystem : ComponentSystem
    {
        ComponentGroup m_ComponentGroup;

        protected override void OnCreateManager()
        {
            m_ComponentGroup = GetComponentGroup(typeof(SpriteSkin), typeof(SpriteComponent));
        }

        struct Bounds
        {
            public float4 center;
            public float4 extents;
        }

        struct CalculateBoundsJob : IJobParallelFor
        {
            [ReadOnly, DeallocateOnJobCompletion]
            public NativeArray<float4x4> worldToLocalArray;
            [ReadOnly, DeallocateOnJobCompletion]
            public NativeArray<float4x4> rootLocalToWorldArray;
            public NativeArray<Bounds> boundsArray;
            public void Execute(int i)
            {
                var matrix = math.mul(worldToLocalArray[i], rootLocalToWorldArray[i]);
                var center = boundsArray[i].center;
                var extents = boundsArray[i].extents;
                var p0 = math.mul(matrix, center + new float4(-extents.x, -extents.y, extents.z, extents.w));
                var p1 = math.mul(matrix, center + new float4(-extents.x, extents.y, extents.z, extents.w));
                var p2 = math.mul(matrix, center + extents);
                var p3 = math.mul(matrix, center + new float4(extents.x, -extents.y, extents.z, extents.w));
                var min = math.min(p0, math.min(p1, math.min(p2, p3)));
                var max = math.max(p0, math.max(p1, math.max(p2, p3)));
                extents = (max - min) * 0.5f;
                center = min + extents;
                boundsArray[i] = new Bounds()
                {
                    center = center,
                    extents = extents
                };
            }
        }

        protected override void OnUpdate()
        {
            List<SpriteSkin> spriteSkinComponents = new List<SpriteSkin>();
            List<SpriteComponent> spriteComponents = new List<SpriteComponent>();
            Entities.ForEach((SpriteSkin spriteSkin) => { spriteSkinComponents.Add(spriteSkin); });
            Entities.ForEach((SpriteComponent sprite) => { spriteComponents.Add(sprite); });
            var worldToLocalArray = new NativeArray<float4x4>(spriteSkinComponents.Count, Allocator.TempJob, NativeArrayOptions.UninitializedMemory);
            var rootLocalToWorldArray = new NativeArray<float4x4>(spriteSkinComponents.Count, Allocator.TempJob, NativeArrayOptions.UninitializedMemory);
            var boundsArray = new NativeArray<Bounds>(spriteSkinComponents.Count, Allocator.TempJob, NativeArrayOptions.UninitializedMemory);

            for (var i = 0; i < spriteSkinComponents.Count; ++i)
            {
                var spriteSkin = spriteSkinComponents[i];
                var sprite = spriteComponents[i].Value;

                if (spriteSkin == null || sprite == null)
                    continue;
                
                worldToLocalArray[i] = spriteSkin.transform.worldToLocalMatrix;
                rootLocalToWorldArray[i] = spriteSkin.rootBone.localToWorldMatrix;

                var unityBounds = spriteSkin.bounds;
                boundsArray[i] = new Bounds ()
                {
                    center = new float4(unityBounds.center, 1),
                    extents = new float4(unityBounds.extents, 0),
                };
            }

            var jobHandle = new CalculateBoundsJob()
            {
                worldToLocalArray = worldToLocalArray,
                rootLocalToWorldArray = rootLocalToWorldArray,
                boundsArray = boundsArray
            }.Schedule(spriteSkinComponents.Count, 32);
            
            jobHandle.Complete();

            for (var i = 0; i < spriteSkinComponents.Count; ++i)
            {
                var spriteSkin = spriteSkinComponents[i];
                var sprite = spriteComponents[i].Value;

                if (spriteSkin == null || sprite == null)
                    continue;
                
                var center = boundsArray[i].center;
                var extents = boundsArray[i].extents;
                var bounds = new UnityEngine.Bounds();
                bounds.center = new Vector3(center.x, center.y, center.z);
                bounds.extents = new Vector3(extents.x, extents.y, extents.z);
                InternalEngineBridge.SetLocalAABB(spriteSkin.spriteRenderer, bounds);
            }

            boundsArray.Dispose();
            return;
        }
    }
}
