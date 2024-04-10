using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LoLSDK;
using SimpleJSON;
using TMPro;
using UnityEngine.UI;

namespace Alpha.Phases.Robo.Grow
{
    public class RoboGrowStage4ButterflyMGEnemy : MonoBehaviour
    {
        public AudioSource deathSFX;
        public GameObject player;
        public Transform playerRespawnLocation;
        public ButterFlyPlayerController buttControl;
        // public ro rgMiniGameScript;
        public bool hasPlayerBeenEatenBefore;
        public RoboGrowMain rgMain;
        // public GameObject inGameCanvas;
        // Start is called before the first frame update
        void Start()
        {
            // player.transform.position = playerRespawnLocation.transform.position;
        }

        // Update is called once per frame
        void Update()
        {

        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                deathSFX.Play();
                buttControl.enabled = false;
                player.transform.position = playerRespawnLocation.transform.position;
                Debug.Log("The Fall trigge works");
               // rgMain.task1TextUITick2.SetActive(true);


            }
        }
    }
}
