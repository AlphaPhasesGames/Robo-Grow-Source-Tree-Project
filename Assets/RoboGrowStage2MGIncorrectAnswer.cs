using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LoLSDK;
using SimpleJSON;
using TMPro;
using UnityEngine.UI;

namespace Alpha.Phases.Robo.Grow
{
    public class RoboGrowStage2MGIncorrectAnswer : MonoBehaviour
    {
        public AudioSource deathSFX;
        public GameObject tadPoleplayer;
        public Transform playerRespawnLocation;
        public TadpoleController tadCont;
        public RoboGrowStartMiniGame2 rgMG2;
        public bool hasPlayerBeenEatenBefore;
        public RoboGrowMain rgMain;
       // public GameObject inGameCanvas;

        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("TadPole"))
            {
                deathSFX.Play();
                tadCont.enabled = false;
                tadPoleplayer.transform.position = playerRespawnLocation.transform.position;
                tadPoleplayer.transform.eulerAngles = new Vector3(0, -33, 0);
                Debug.Log("Wrong");
                rgMG2.currentStage2PondText = 11;
               // rgMain.task1TextUITick2.SetActive(true);
               // ShowTextForSetTime();
                //catControl.enabled = true;

            }
        }

        public void ShowTextForSetTime()
        {
            rgMG2.EatenByEnemy();

        }
    }
}
