using System;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.Experimental.U2D.Common;
using Unity.Entities;

namespace UnityEngine.Experimental.U2D.Animation
{
    [Preserve]
    public class SpriteSkinEntity : GameObjectEntity
    {
#if UNITY_EDITOR
        static bool assemblyReload = false;
#endif

        SpriteSkin m_SpriteSkin;
        SpriteSkin spriteSkin
        {
            get
            {
                if (m_SpriteSkin == null)
                    m_SpriteSkin = GetComponent<SpriteSkin>();
                return m_SpriteSkin;
            }
        }

        protected override void OnEnable()
        {
            base.OnEnable();
            SetupEntity();
            SetupSpriteSkin();

#if UNITY_EDITOR
            UnityEditor.AssemblyReloadEvents.afterAssemblyReload += OnAfterAssemblyReload;
            UnityEditor.AssemblyReloadEvents.beforeAssemblyReload += OnBeforeAssemblyReload;
#endif
        }

#if UNITY_EDITOR
        public void OnBeforeAssemblyReload()
        {
            assemblyReload = true;
        }

        public void OnAfterAssemblyReload()
        {
            assemblyReload = false;
        }
#endif

        protected override void OnDisable()
        {
            DeactivateSkinning();
#if UNITY_EDITOR
            if (!assemblyReload)
#endif
            base.OnDisable();
        }

        private void SetupEntity()
        {
            if (EntityManager == null)
                return;

            EntityManager.AddBuffer<Vertex>(Entity);
            EntityManager.AddBuffer<BoneTransform>(Entity);
            EntityManager.AddComponent(Entity, typeof(WorldToLocal));
            EntityManager.AddSharedComponentData(Entity, new SpriteComponent() { Value = null });
        }

        private void SetupSpriteSkin()
        {
            if (spriteSkin != null)
            {
                spriteSkin.ForceSkinning = true;
                
                if (spriteSkin.bounds.extents != Vector3.zero) //Maybe log a warning?
                    InternalEngineBridge.SetLocalAABB(spriteSkin.spriteRenderer, spriteSkin.bounds);
            }
        }

        private void DeactivateSkinning()
        {
            if (spriteSkin != null)
                spriteSkin.DeactivateSkinning();
        }
    } 
}
