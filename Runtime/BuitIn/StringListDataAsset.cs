using System;
using System.Collections.Generic;

using UnityEngine;

namespace Freyja.DataAsset
{
    [Serializable]
    public class StringListData : IReset
    {
        #region Fields

        [SerializeField]
        private List<string> m_Values = new List<string>();

        #endregion

        #region Properties

        public List<string> Values
        {
            get => m_Values;
        }

        #endregion

        #region Methods

        public void Reset()
        {
            m_Values = new List<string>();
        }

        #endregion
    }

    [CreateAssetMenu(menuName = "Freyja/Data Asset/String List Data", fileName = "StringListData_")]
    public class StringListDataAsset : DataAsset<StringListData>
    {
        #region Methods

        private void Reset()
        {
            #if UNITY_EDITOR

            if (m_Value == null)
            {
                m_Value = new StringListData();

                Value.Reset();
            }

            #endif
        }

        #endregion
    }
}