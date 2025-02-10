using System;

using UnityEngine;

namespace Freyja.DataAsset
{
    [Serializable]
    public class StringData : IReset
    {
        #region Fields

        [SerializeField]
        public string m_Value;

        #endregion

        #region Properties

        public string Value
        {
            get => m_Value;
        }

        #endregion

        #region Methods

        public void Reset()
        {
            m_Value = string.Empty;
        }

        #endregion
    }

    [CreateAssetMenu(menuName = "Freyja/Data Asset/String Data", fileName = "StringData_")]
    public class StringDataAsset : DataAsset<StringData>
    {
        #region Methods

        public void Reset()
        {
            #if UNITY_EDITOR

            if (m_Value == null)
            {
                m_Value = new StringData();
            }

            Value.Reset();

            #endif
        }

        #endregion
    }
}