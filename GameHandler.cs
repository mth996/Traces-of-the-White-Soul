using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameHandler : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("GameHandler.Start");

        PlayerData playerData = new PlayerData();
        playerData.position =  new Vector2(5, 0);
        playerData.soulAmount = 80; 

        string json = JsonUtility.ToJson(playerData);
        Debug.Log(json);

        File.WriteAllText(Application.dataPath + "saveFile.json", json);
        Debug.Log(Application.dataPath);
        

        /*
        string json = File.ReadAllText(Application.dataPath + "/saveFile.json");
        PlayerData loadedPlayerData = JsonUtility.FromJson<PlayerData>(json);
        Debug.Log("position: "+loadedPlayerData.position);
        Debug.Log("position: "+loadedPlayerData.soulAmount);
        */

    }
    private class PlayerData{
        public Vector2 position;
        public int soulAmount;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
