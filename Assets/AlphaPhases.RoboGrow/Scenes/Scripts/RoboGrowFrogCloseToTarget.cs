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
    public class RoboGrowFrogCloseToTarget : MonoBehaviour
    {

        public RoboGrowStage4FrogMiniGame rgFrogMG;
        public bool playerInTrigger;
        public bool playOnce;
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            if (playerInTrigger)
            {
                if (!playOnce)
                {
                    rgFrogMG.currentStage3FrogText = 7;
                    playOnce = true;
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

        private void OnTriggerExit(Collider other)
        {
            if (other.CompareTag("FrogPlayer"))
            {

                playerInTrigger = false;
                Debug.Log("Trigger for fake frog triggered");
            }
        }
    }
}
