using System;
using System.Collections.Generic;

using UnityEngine;

namespace Freyja.DataAsset
{
    [Serializable]
    public class Vector3ListData : IReset
    {
        #region Fields

        [SerializeField]
        private List<Vector3> m_Values = new List<Vector3>();

        #endregion

        #region Properties

        public List<Vector3> Values
        {
            get => m_Values;
        }

        #endregion

        #region Methods

        public void Reset()
        {
            throw new NotImplementedException();
        }

        #endregion
    }

    [CreateAssetMenu(menuName = "Freyja/Data Asset/Vector3 List Data", fileName = "Vector3ListData_")]
    public class Vector3ListDataAsset : DataAsset<Vector3ListData>
    {
        #region Methods

        private void Reset()
        {
            #if UNITY_EDITOR

            if (m_Value == null)
            {
                m_Value = new Vector3ListData();

                Value.Reset();
            }

            #endif
        }

        #endregion
    }
}