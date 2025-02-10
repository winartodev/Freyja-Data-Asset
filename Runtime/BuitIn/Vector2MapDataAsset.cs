using System.Collections.Generic;

using UnityEngine;
#if UNITY_EDITOR && ODIN_INSPECTOR
using Sirenix.Serialization;
#endif

namespace Freyja.DataAsset
{
    public class Vector2MapData : IReset
    {
        #region Fields

        #if UNITY_EDITOR && ODIN_INSPECTOR
        [OdinSerialize]
        #endif
        private Dictionary<string, Vector2> m_Values = new Dictionary<string, Vector2>();

        #endregion

        #region Properties

        public Dictionary<string, Vector2> Values
        {
            get => m_Values;
        }

        #endregion

        #region Methods

        public void Reset()
        {
            m_Values = new Dictionary<string, Vector2>();
        }

        #endregion
    }

    [CreateAssetMenu(menuName = "Freyja/Data Asset/Vector2 Map Data", fileName = "Vector2MapData_")]
    public class Vector2MapDataAsset : DataAsset<Vector2MapData>
    {
        #region Methods

        private void Reset()
        {
            #if UNITY_EDITOR

            if (m_Value == null)
            {
                m_Value = new Vector2MapData();

                Value.Reset();
            }

            #endif
        }

        #endregion
    }
}