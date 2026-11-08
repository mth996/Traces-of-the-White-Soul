using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPrefManager : MonoBehaviour
{
    private float savedPlayerPositionX;
    private float savedPlayerPositionY;
    private int savedSoulAmount;

     public void Start ()
   {
       if(PlayerPrefs.HasKey("savedPlayerPositionX") && PlayerPrefs.HasKey("savedPlayerPositionY"))
       {
            savedPlayerPositionX = PlayerPrefs.GetFloat("savedPlayerPositionX");
            savedPlayerPositionY = PlayerPrefs.GetFloat("savedPlayerPositionY");
       }

       if(PlayerPrefs.HasKey("savedSoulAmount"))
       {
           savedSoulAmount = PlayerPrefs.GetInt("savedSoulAmount");
       }

   }

    private void Update()
    {
        if(SaveManager.Instance.savePosition != null)
        {
            savedPlayerPositionX = SaveManager.Instance.savePosition.transform.position.x;
            savedPlayerPositionY = SaveManager.Instance.savePosition.transform.position.y;
            PlayerPrefs.SetFloat("savedPlayerPositionX", savedPlayerPositionX);
            PlayerPrefs.SetFloat("savedPlayerPositionY", savedPlayerPositionY);
        }
        
        if(UIManager.Instance.soulValue != 0)
        {
            savedSoulAmount = UIManager.Instance.soulValue;
            PlayerPrefs.SetInt("savedSoulAmount", savedSoulAmount);
        }
    }
   
}
