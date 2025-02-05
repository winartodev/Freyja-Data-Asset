using UnityEngine;
#if UNITY_EDITOR && ODIN_INSPECTOR
using Sirenix.OdinInspector;
#endif

namespace Freyja.DataAsset
{
    public abstract class DataAsset<T> :
        #if UNITY_EDITOR && ODIN_INSPECTOR
        SerializedScriptableObject
    #else
        ScriptableObject
    #endif
    {
        #region Fields

        #if UNITY_EDITOR && ODIN_INSPECTOR
        [HideLabel]
        [HideReferenceObjectPicker]
        #endif
        [SerializeField]
        protected T m_Value;

        #endregion

        #region Properties

        /// <summary>
        /// Gets the value of this data asset.
        /// </summary>
        public T Value
        {
            get => m_Value;
        }

        #endregion
    }
}