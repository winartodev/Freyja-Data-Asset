# Freyja Data Asset

provides a flexible and efficient way to manage data assets in Unity projects. It offers features such as:
* **Data Asset Definition:** Create custom data assets for various types of data.
* **Data Asset Persistence:** Persist data asset references and values across scenes.
* **Data Reference System:** Easily reference and use data assets in scripts.

**Requirements:**
* Unity 2021.3.22f1 or Later

**Dependencies:**
* None

**Example Usage:**
1. **Create Data Asset**
   ```csharp
   // SwordData.cs
    
   using System;
   
   [Serializable]
   public class SwordData
   {
        public int Damage;
        public int Strength;
   }
   ```
   
   ```csharp
   // SwordDataAsset.cs
   using Freyja.DataAsset;
   
   using UnityEngine;
   
   [CreateAssetMenu(menuName = "Test/Runtime/" + nameof(SwordDataAsset))]
   public class SwordDataAsset : DataAsset<SwordData>
   {
       
   }
   ```     
2. **Create Reference Data Asset**
   ```csharp   
   // PlayerData.cs
   
   using System;
   
   using Freyja.DataAsset;
   
   [Serializable]
   public class PlayerData
   {
       public string Name;
   
       public DataReference<SwordData> SwordDataReference;
   }
   ```    
   
   ```csharp
   // PlayerDataAsset.cs
   
   using Freyja.DataAsset;
   
   using UnityEngine;
   
   [CreateAssetMenu(menuName = "Test/Runtime/" + nameof(PlayerDataAsset))]
   public class PlayerDataAsset : DataAsset<PlayerData>
   {
     
   }
   ```
3. **Call The Asset && Data Asset Reference**
   ```csharp
   // DataAssetManager.cs
   
   using UnityEngine;
   
   public class DataAssetManager : MonoBehaviour
   {
       [SerializeField]
       private PlayerDataAsset m_playerdataasset;
   
       private void Start()
       {
           Debug.Log(m_playerdataasset.Value.Name);
           Debug.Log(m_playerdataasset.Value.SwordDataReference.Value.Strength);
       }
   }
   ```
