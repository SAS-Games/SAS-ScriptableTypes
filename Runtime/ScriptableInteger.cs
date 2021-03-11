using UnityEngine;
using System;

namespace SAS.ScriptableTypes
{
    [CreateAssetMenu(menuName = "SAS/ScriptableTypes/Float")]
    public class ScriptableInteger : ScriptableObject, ISerializationCallbackReceiver
    {
        [SerializeField] private int m_InitialValue = default;
        [NonSerialized] public int runtimeValue;

        void ISerializationCallbackReceiver.OnBeforeSerialize()
        {

        }

        void ISerializationCallbackReceiver.OnAfterDeserialize()
        {
            runtimeValue = m_InitialValue;
        }
    }
}
