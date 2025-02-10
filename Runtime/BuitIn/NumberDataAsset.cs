using System;

using UnityEngine;

namespace Freyja.DataAsset
{
    [Serializable]
    public class NumberData : IReset
    {
        #region Fields

        [SerializeField]
        public double m_Value;

        #endregion

        #region Properties

        public double Value
        {
            get => m_Value;
        }

        #endregion

        #region Methods

        public void Reset()
        {
            m_Value = 0;
        }

        #endregion
    }

    [CreateAssetMenu(menuName = "Freyja/Data Asset/Number Data", fileName = "NumberData_")]
    public class NumberDataAsset : DataAsset<NumberData>
    {
        #region Methods

        private void Reset()
        {
            #if UNITY_EDITOR

            if (m_Value == null)
            {
                m_Value = new NumberData();
            }

            Value.Reset();

            #endif
        }

        #endregion
    }
}