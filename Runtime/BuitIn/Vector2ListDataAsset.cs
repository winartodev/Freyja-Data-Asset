using System;
using System.Collections.Generic;

using UnityEngine;

namespace Freyja.DataAsset
{
    [Serializable]
    public class Vector2ListData : IReset
    {
        #region Fields

        [SerializeField]
        private List<Vector2> m_Values = new List<Vector2>();

        #endregion

        #region Properties

        public List<Vector2> Values
        {
            get => m_Values;
        }

        #endregion

        #region Methods

        public void Reset()
        {
            m_Values = new List<Vector2>();
        }

        #endregion
    }

    [CreateAssetMenu(menuName = "Freyja/Data Asset/Vector2 List Data", fileName = "Vector2ListData_")]
    public class Vector2ListDataAsset : DataAsset<Vector2ListData>
    {
        #region Methods

        private void Reset()
        {
            #if UNITY_EDITOR

            if (m_Value == null)
            {
                m_Value = new Vector2ListData();

                Value.Reset();
            }

            #endif
        }

        #endregion
    }
}