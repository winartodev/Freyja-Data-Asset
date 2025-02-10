using System;
using System.Collections.Generic;

using UnityEngine;

namespace Freyja.DataAsset
{
    [Serializable]
    public class NumberListData : IReset
    {
        #region Fields

        [SerializeField]
        private List<double> m_Values = new List<double>();

        #endregion

        #region Properties

        public List<double> Values
        {
            get => m_Values;
        }

        #endregion

        #region Methods

        public void Reset()
        {
            m_Values = new List<double>();
        }

        #endregion
    }

    [CreateAssetMenu(menuName = "Freyja/Data Asset/Number List Data", fileName = "NumberListData_")]
    public class NumberListDataAsset : DataAsset<NumberListData>
    {
        #region Methods

        public void Reset()
        {
            #if UNITY_EDITOR

            if (m_Value == null)
            {
                m_Value = new NumberListData();
            }

            Value.Reset();

            #endif
        }

        #endregion
    }
}