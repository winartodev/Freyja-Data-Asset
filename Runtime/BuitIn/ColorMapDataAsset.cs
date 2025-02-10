using System.Collections.Generic;

using UnityEngine;
#if UNITY_EDITOR && ODIN_INSPECTOR
using Sirenix.Serialization;
#endif

namespace Freyja.DataAsset
{
    public class ColorMapData : IReset
    {
        #region Fields

        #if UNITY_EDITOR && ODIN_INSPECTOR
        [OdinSerialize]
        #endif
        private Dictionary<string, Color> m_Values = new Dictionary<string, Color>();

        #endregion

        #region Properties

        public Dictionary<string, Color> Values
        {
            get => m_Values;
        }

        #endregion

        #region Methods

        public void Reset()
        {
            m_Values = new Dictionary<string, Color>();
        }

        #endregion
    }

    [CreateAssetMenu(menuName = "Freyja/Data Asset/Color Map Data", fileName = "ColorMapData_")]
    public class ColorMapDataAsset : DataAsset<ColorMapData>
    {
        #region Methods

        private void Reset()
        {
            #if UNITY_EDITOR

            if (m_Value == null)
            {
                m_Value = new ColorMapData();
            }

            Value.Reset();

            #endif
        }

        #endregion
    }
}