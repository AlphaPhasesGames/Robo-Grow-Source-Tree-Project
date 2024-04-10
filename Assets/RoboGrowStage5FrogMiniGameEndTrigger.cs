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
    public class RoboGrowStage5FrogMiniGameEndTrigger : MonoBehaviour
    {
        public RoboGrowStage5FrogMinigameStart rgFrogMG;
        public bool playerInTrigger;
        public bool playerActivatedTriggerBefore;
        public Animator frogHoppingAnim;
        private void Update()
        {
            if (playerInTrigger)
            {

                if (!playerActivatedTriggerBefore)
                {
                    rgFrogMG.textPanal.gameObject.SetActive(true);
                    rgFrogMG.currentStage3FrogText = 7;
                    playerActivatedTriggerBefore = true;
                    frogHoppingAnim.enabled = false;
                }

            }
        }


        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("FrogPlayer"))
            {

                playerInTrigger = true;
                Debug.Log("Trigger for fake frog triggered");
            }
        }


    }
}

