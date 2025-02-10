using System;

using UnityEngine;

namespace Freyja.DataAsset
{
    [Serializable]
    public class ColorData : IReset
    {
        #region Fields

        [SerializeField]
        public Color m_Value = Color.white;

        #endregion

        #region Properties

        public Color Value
        {
            get => m_Value;
        }

        #endregion

        #region Methods

        public void Reset()
        {
            m_Value = Color.white;
        }

        #endregion
    }

    [CreateAssetMenu(menuName = "Freyja/Data Asset/Color Data", fileName = "ColorData_")]
    public class ColorDataAsset : DataAsset<ColorData>
    {
        #region Methods

        private void Reset()
        {
            #if UNITY_EDITOR

            if (m_Value == null)
            {
                m_Value = new ColorData();
            }

            Value.Reset();

            #endif
        }

        #endregion
    }
}