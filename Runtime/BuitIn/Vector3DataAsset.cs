using System;

using UnityEngine;

namespace Freyja.DataAsset
{
    [Serializable]
    public class Vector3Data : IReset
    {
        #region Fields

        [SerializeField]
        public Vector3 m_Value;

        #endregion

        #region Properties

        public Vector3 Value
        {
            get => m_Value;
        }

        #endregion

        #region Methods

        public void Reset()
        {
            throw new NotImplementedException();
        }

        #endregion
    }

    [CreateAssetMenu(menuName = "Freyja/Data Asset/Vector3 Data", fileName = "Vector3Data_")]
    public class Vector3DataAsset : DataAsset<Vector3Data>
    {
        #region Methods

        private void Reset()
        {
            #if UNITY_EDITOR

            if (m_Value == null)
            {
                m_Value = new Vector3Data();

                Value.Reset();
            }

            #endif
        }

        #endregion
    }
}