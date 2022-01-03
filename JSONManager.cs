using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JSONManager : MonoBehaviour
{
    /*
    private class SaveObject
    {
        public int soulAmount;
        public Vector2 playerPosition;
    }

   

    private void Awake()
    {
        SaveObject saveObject = new SaveObject
        {
            soulAmount = 5,

        };

        string json = JsonUtility.ToJson(saveObject);
        Debug.Log(json);

        SaveObject loadedSaveObject = JsonUtility.FromJson<SaveObject>(json);
        Debug.Log(loadedSaveObject.soulAmount);

    }

    private void Save() 
    {
        Vector2 playerPosition = uint.GetPosition();
        int soulAmount = uint.GetAmount();

        SaveObject saveObject = new SaveObject{
            soulAmount = soulAmount,
            playerPosition = playerPosition
        };
        string json = JsonUtility.ToJson(saveObject);

        File.WriteAllText(Application.dataPath +"/save.txt",json);

    }
    */
}
