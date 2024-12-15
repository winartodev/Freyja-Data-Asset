using System.Collections.Generic;

using UnityEngine;
#if ODIN_INSPECTOR
using Sirenix.OdinInspector;
#endif

namespace Freyja.DataAsset
{
    public class DataAssetPersistence : MonoBehaviour
    {
        #region Static

        private static DataAssetPersistence _instance;

        public static DataAssetPersistence Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new GameObject(nameof(DataAssetPersistence)).AddComponent<DataAssetPersistence>();
                    DontDestroyOnLoad(_instance);
                }

                return _instance;
            }
        }

        #endregion

        #region Private

    #if ODIN_INSPECTOR && UNITY_EDITOR
        [ShowInInspector]
        [ListDrawerSettings(IsReadOnly = true, ShowFoldout = true)]
    #endif
        private List<object> _references = new List<object>();

        #endregion

        #region Properties

        /// <summary>
        /// Gets the list of references to data assets.
        /// </summary>
        public List<object> References
        {
            get
            {
                if (_references == null)
                {
                    _references = new List<object>();
                }

                return _references;
            }
        }

        #endregion

        #region Methods

        /// <summary>
        /// Adds a reference to a data asset.
        /// </summary>
        /// <param name="reference">The reference to add.</param>
        public static void AddReference(object reference)
        {
            if (Instance.References.Contains(reference))
            {
                return;
            }

            Instance.References.Add(reference);
        }

        /// <summary>
        /// Removes a reference to a data asset.
        /// </summary>
        /// <param name="reference">The reference to remove.</param>
        public static void RemoveReference(object reference)
        {
            if (Instance.References.Contains(reference))
            {
                Instance.References.Remove(reference);
            }
        }

        /// <summary>
        /// Removes all null references from the list.
        /// </summary>
        public static void ClearEmpty()
        {
            Instance.References.RemoveAll(reference => reference == null);
        }

        #endregion
    }
}