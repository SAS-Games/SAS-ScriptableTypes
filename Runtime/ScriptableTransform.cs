using System;
using UnityEngine;

namespace SAS.ScriptableTypes
{
    [CreateAssetMenu(menuName = "Scriptables/Variables/Transform")]
    public class ScriptableTransform : ScriptableObject, IProperty
    {
        [HideInInspector] public Transform value { get; set; }

        public void Set(Transform transform) 
        {
            value = transform;
        }

        public void Clear()
        {
            value = null;
        }
    }
}