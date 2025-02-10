using System;
using System.Collections.Generic;

using Sirenix.OdinInspector;

using UnityEngine;

namespace Freyja.DataAsset
{
    [Serializable]
    public class ColorListData : IReset
    {
        #region Fields

        #if UNITY_EDITOR && ODIN_INSPECTOR
        [ListDrawerSettings(CustomAddFunction = nameof(OnAddColor))]
        #endif
        [SerializeField]
        private List<Color> m_Values = new List<Color>();

        #endregion

        #region Properties

        public List<Color> Values
        {
            get => m_Values;
        }

        #endregion

        #region Methods

        public void Reset()
        {
            m_Values = new List<Color>();
        }


        #if UNITY_EDITOR

        private void OnAddColor()
        {
            if (m_Values == null)
            {
                m_Values = new List<Color>();
            }

            m_Values.Add(Color.white);
        }

        #endif

        #endregion
    }

    [CreateAssetMenu(menuName = "Freyja/Data Asset/Color List Data", fileName = "ColorListData_")]
    public class ColorListDataAsset : DataAsset<ColorListData>
    {
        #region Methods

        private void Reset()
        {
            #if UNITY_EDITOR

            if (m_Value == null)
            {
                m_Value = new ColorListData();
            }

            Value.Reset();

            #endif
        }

        #endregion
    }
}