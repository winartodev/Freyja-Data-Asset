using System;

using UnityEngine;

namespace Freyja.DataAsset
{
    [Serializable]
    public class Vector2Data : IReset
    {
        #region Fields

        [SerializeField]
        public Vector2 m_Value;

        #endregion

        #region Properties

        public Vector2 Value
        {
            get => m_Value;
        }

        #endregion

        #region Methods

        public void Reset()
        {
            m_Value = Vector2.zero;
        }

        #endregion
    }

    [CreateAssetMenu(menuName = "Freyja/Data Asset/Vector2 Data", fileName = "Vector2Data_")]
    public class Vector2DataAsset : DataAsset<Vector2Data>
    {
        #region Methods

        private void Reset()
        {
            #if UNITY_EDITOR

            if (m_Value == null)
            {
                m_Value = new Vector2Data();

                Value.Reset();
            }

            #endif
        }

        #endregion
    }
}