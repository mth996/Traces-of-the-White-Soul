using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SavingMushroom : MonoBehaviour
{
    [SerializeField] private bool isCamp = false;
    [SerializeField] private GameObject currentSavedMushroom; // The mushroom that turn yellow. [Yellow]
    [SerializeField] private GameObject previousSavedMushroom; // The mushroom that turned yellow before.

    //[SerializeField] private GameObject SavedMushroomLightEffect; 

    [SerializeField] private GameObject mushroomParticleSprite;
    [SerializeField] private GameObject savedParticleEffect;

    private bool isParticlePlayed = false;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {             
            
            
            if(currentSavedMushroom.activeSelf) // If there is a new mushroom turned yellow: (Saving)
            {

                SaveManager.Instance.SavePlayerPosition(this.gameObject.transform, previousSavedMushroom);                 

                // Save the player position at this current mushroom.
                return;
            }

            previousSavedMushroom = SaveManager.Instance.previousSavePosition;
            // Previous save mushroom to the previous save position.

            if(!isCamp)
            {
                currentSavedMushroom.SetActive(true);
            }

            if(!isCamp)
            {
                if(!isParticlePlayed)
                {
                    savedParticleEffect.SetActive(true);
                    mushroomParticleSprite.SetActive(true);
                    AudioManager.instance.PlaySound("Checkpoint");
                    isParticlePlayed = true;
                }   
            }
         

            // Activate this current save mushroom.

            if(previousSavedMushroom != null) // if there is a previous save file.
            {
                if(!isCamp)
                {
                    previousSavedMushroom.SetActive(false); 
                }
                // The previous save mushroom will be activated until player hit a new Save Mushroom.
            }            
            previousSavedMushroom = currentSavedMushroom;
            // After setting up everthing from above, previous save mushroom equals to this save mushroom.

            SaveManager.Instance.SavePlayerPosition(this.gameObject.transform, previousSavedMushroom);
            // Save the player current position to the newest save mushroom.



            //StartCoroutine(DeactivateMushroomEffect());

        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if(!isCamp)
        {
            savedParticleEffect.SetActive(false);
            //mushroomParticleSprite.SetActive(false);
            isParticlePlayed = false;
        }
    }
}
