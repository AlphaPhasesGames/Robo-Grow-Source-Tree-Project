using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using LoLSDK;
using SimpleJSON;
using System.IO;
using UnityEngine.UI;
using TMPro;

namespace Alpha.Phases.Robo.Grow
{
    public class RoboGrowStage5TreeMinigameEnd : MonoBehaviour
    {
        public RoboGrowStage5MiniGame2Tree rgFrogMG;
        public bool playerInTrigger;
        public bool playerActivatedTriggerBefore;

        public Camera buttEndCam;
        public Camera playerCam;
      //  public GameObject frogArrowTohide;
        public GameObject butterFlyObject;
        public GameObject butteflyPlayerCharacter;
        

        private void Update()
        {
            if (playerInTrigger)
            {

                if (!playerActivatedTriggerBefore)
                {

                    rgFrogMG.textPanal.gameObject.SetActive(true);
                    rgFrogMG.currentStage5TreeText = 8;
                    playerActivatedTriggerBefore = true;
                    butteflyPlayerCharacter.gameObject.SetActive(false);
                    butterFlyObject.gameObject.SetActive(true);
                    buttEndCam.enabled = true;
                    playerCam.enabled = false;
                    Debug.Log("Player triggers the end of game");
                 //   frogArrowTohide.gameObject.SetActive(true);
                }

            }
        }


        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                rgFrogMG.currentStage5TreeText = 8;
                playerInTrigger = true;
                Debug.Log("Trigger for fake frog triggered");
            }
        }
    }
}
