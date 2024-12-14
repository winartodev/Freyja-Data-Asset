using System;

using Sirenix.OdinInspector;

using UnityEngine;

namespace Freyja.DataAsset
{
#if ODIN_INSPECTOR
    [HideReferenceObjectPicker]
#endif
    [Serializable]
    public class DataReference<T> where T : class, new()
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="DataReference{T}"/> class.
        /// </summary>
        public DataReference()
        {
            m_Data = new T();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DataReference{T}"/> class with a specified value.
        /// </summary>
        /// <param name="value">The value to assign to the data reference.</param>
        public DataReference(T value)
        {
            m_UseReference = false;
            m_Data = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DataReference{T}"/> class with a reference to a data asset.
        /// </summary>
        /// <param name="value">The data asset to reference.</param>
        public DataReference(DataAsset<T> value)
        {
            m_UseReference = true;
            m_Reference = value;
        }

        #endregion

        #region Fields

        [SerializeField]
        private bool m_UseReference;

    #if ODIN_INSPECTOR
        [ShowIf(nameof(m_UseReference))]
    #endif
        [SerializeField]
        private bool m_SetPersistence;

    #if ODIN_INSPECTOR
        [HideIf(nameof(m_UseReference))]
        [HideReferenceObjectPicker]
        [HideLabel]
    #endif
        [SerializeField]
        private T m_Data;

    #if ODIN_INSPECTOR
        [ShowIf(nameof(m_UseReference))]
        [InlineEditor]
    #endif
        [SerializeField]
        private DataAsset<T> m_Reference;

        #endregion

        #region Private

        private bool _isRegisteredPersistence;

        #endregion

        #region Properties

        /// <summary>
        /// Gets a value indicating whether the data reference should be persisted.
        /// </summary>
        public bool SetPersistence
        {
            get => m_SetPersistence;
        }

        /// <summary>
        /// Gets the value of the data reference.
        /// </summary>
        public T Value
        {
            get
            {
                if (ShouldRegisterPersistence())
                {
                    DataAssetPersistence.AddReference(m_Reference);
                    _isRegisteredPersistence = true;
                }

                return m_UseReference ? m_Reference?.Value : m_Data;
            }
        }

        #endregion

        #region Methods

        /// <summary>
        /// Determines whether the data reference should be registered for persistence.
        /// </summary>
        /// <returns>True if the reference should be registered; otherwise, false.</returns>
        private bool ShouldRegisterPersistence()
        {
            return m_UseReference && m_Reference != null && m_SetPersistence && !_isRegisteredPersistence;
        }

        #endregion
    }
}