using System.Collections.Generic;

using UnityEngine;
#if UNITY_EDITOR && ODIN_INSPECTOR
using Sirenix.Serialization;
#endif

namespace Freyja.DataAsset
{
    public class StringMapData : IReset
    {
        #region Fields

        #if UNITY_EDITOR && ODIN_INSPECTOR
        [OdinSerialize]
        #endif
        private Dictionary<string, string> m_Values = new Dictionary<string, string>();

        #endregion

        #region Properties

        public Dictionary<string, string> Values
        {
            get => m_Values;
        }

        #endregion

        #region Methods

        public void Reset()
        {
            m_Values = new Dictionary<string, string>();
        }

        #endregion
    }

    [CreateAssetMenu(menuName = "Freyja/Data Asset/String Map Data", fileName = "StringMapData_")]
    public class StringMapDataAsset : DataAsset<StringMapData>
    {
        #region Methods

        private void Reset()
        {
            #if UNITY_EDITOR

            if (m_Value == null)
            {
                m_Value = new StringMapData();

                Value.Reset();
            }

            #endif
        }

        #endregion
    }
}