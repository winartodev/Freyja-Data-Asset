using System.Collections.Generic;

using UnityEngine;
#if UNITY_EDITOR && ODIN_INSPECTOR
using Sirenix.Serialization;
#endif

namespace Freyja.DataAsset
{
    public class NumberMapData : IReset
    {
        #region Fields

        #if UNITY_EDITOR && ODIN_INSPECTOR
        [OdinSerialize]
        #endif
        private Dictionary<string, double> m_Values = new Dictionary<string, double>();

        #endregion

        #region Properties

        public Dictionary<string, double> Values
        {
            get => m_Values;
        }

        #endregion

        #region Methods

        public void Reset()
        {
            m_Values = new Dictionary<string, double>();
        }

        #endregion
    }

    [CreateAssetMenu(menuName = "Freyja/Data Asset/Number Map Data", fileName = "NumberMapData_")]
    public class NumberMapDataAsset : DataAsset<NumberMapData>
    {
        #region Methods

        private void Reset()
        {
            #if UNITY_EDITOR

            if (m_Value == null)
            {
                m_Value = new NumberMapData();
            }

            Value.Reset();

            #endif
        }

        #endregion
    }
}