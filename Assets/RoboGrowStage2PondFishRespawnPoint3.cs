using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LoLSDK;
using SimpleJSON;
using TMPro;
using UnityEngine.UI;

namespace Alpha.Phases.Robo.Grow
{
    public class RoboGrowStage2PondFishRespawnPoint3 : MonoBehaviour
    {
        public AudioSource deathSFX;
        public GameObject tadPoleplayer;
        public Transform playerRespawnLocation;
        public TadpoleController tadCont;
        public RoboGrowStartMiniGame2 rgMG2;
        public bool hasPlayerBeenEatenBefore;
        public RoboGrowMain rgMain;
        public GameObject inGameCanvas;

        // Start is called before the first frame update
        void Start()
        {

        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("TadPole"))
            {
                deathSFX.Play();
                tadCont.enabled = false;
                tadPoleplayer.transform.position = playerRespawnLocation.transform.position;
                tadPoleplayer.transform.eulerAngles = new Vector3(0, -2, 0);
                Debug.Log("The Fall trigge works");
               // rgMain.task1TextUITick2.SetActive(true);
                ShowTextForSetTime();
                //catControl.enabled = true;

            }
        }

        public void ShowTextForSetTime()
        {
            rgMG2.EatenByEnemy();

        }
    }
}
