using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LoLSDK;
using SimpleJSON;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Alpha.Phases.Robo.Grow
{

    public class RoboGrowS1MGCheckPoint1 : MonoBehaviour
    {
        public GameObject player;
        public Transform playerRespawnLocationCheckPoint1;
        public CatapillerController catControl;
        public RoboGrowFallTrigger rgFallTriggerScript;
        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Catapiller"))
            {
                catControl.enabled = false;
                rgFallTriggerScript.playerRespawnLocation = playerRespawnLocationCheckPoint1;
                Debug.Log("The Fall trigge works");
                catControl.enabled = true;
               // Destroy(this.gameObject);

            }
        }
    }
}
