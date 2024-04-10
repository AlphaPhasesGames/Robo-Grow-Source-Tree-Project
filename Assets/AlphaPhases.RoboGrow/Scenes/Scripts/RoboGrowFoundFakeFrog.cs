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
    public class RoboGrowFoundFakeFrog : MonoBehaviour
    {
        public RoboGrowStage4FrogMiniGame rgFrogMG;
        public bool playerInTrigger;
        public bool playerActivatedTriggerBefore;
        

        // Update is called once per frame
        void Update()
        {
            if (playerInTrigger)
            {
               
                 
               
            }
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("FrogPlayer"))
            {
                StartCoroutine(EatenByEnemy());
                playerInTrigger = true;
                Debug.Log("Trigger for fake frog triggered");
            }
        }

        private void OnTriggerExit(Collider other)
        {
            if (other.CompareTag("FrogPlayer"))
            {
               
                Debug.Log("Trigger for fake frog triggered");
            }
        }

        public IEnumerator EatenByEnemy()
        {
            rgFrogMG.currentStage3FrogText = 6;
            yield return new WaitForSeconds(3);
            rgFrogMG.currentStage3FrogText = 5;

        }
    }
}
