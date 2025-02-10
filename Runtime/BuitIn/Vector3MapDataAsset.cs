using System.Collections.Generic;

using UnityEngine;
#if UNITY_EDITOR && ODIN_INSPECTOR
using Sirenix.Serialization;
#endif

namespace Freyja.DataAsset
{
    public class Vector3MapData : IReset
    {
        #region Fields

        #if UNITY_EDITOR && ODIN_INSPECTOR
        [OdinSerialize]
        #endif
        private Dictionary<string, Vector3> m_Values = new Dictionary<string, Vector3>();

        #endregion

        #region Properties

        public Dictionary<string, Vector3> Values
        {
            get => m_Values;
        }

        #endregion

        #region Methods

        public void Reset()
        {
            m_Values = new Dictionary<string, Vector3>();
        }

        #endregion
    }

    [CreateAssetMenu(menuName = "Freyja/Data Asset/Vector3 Map Data", fileName = "Vector3MapData_")]
    public class Vector3MapDataAsset : DataAsset<Vector3MapData>
    {
        #region Methods

        private void Reset()
        {
            #if UNITY_EDITOR

            if (m_Value == null)
            {
                m_Value = new Vector3MapData();

                Value.Reset();
            }

            #endif
        }

        #endregion
    }
}