using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LoLSDK;
using SimpleJSON;
using TMPro;
using UnityEngine.UI;

namespace Alpha.Phases.Robo.Grow
{
    public class RoboGrowStage1MGEnemy : MonoBehaviour
    {
        public AudioSource deathSFX;
        public GameObject player;
        public Transform playerRespawnLocation;
        public CatapillerController catControl;
        public RoboGrowStage1MiniGameStart rgMiniGameScript;
        public bool hasPlayerBeenEatenBefore;
        public RoboGrowMain rgMain;
        public GameObject inGameCanvas;
        // Start is called before the first frame update

        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Catapiller"))
            {
                deathSFX.Play();
                catControl.enabled = false;
                player.transform.position = playerRespawnLocation.transform.position;
                player.transform.eulerAngles = new Vector3(0, 58, 0);
                Debug.Log("The Fall trigge works");
                rgMain.task1TextUITick2.SetActive(true);
               StartCoroutine(ShowTextForSetTime());
                //catControl.enabled = true;

            }
        }

        public IEnumerator ShowTextForSetTime()
        {
           StartCoroutine(rgMiniGameScript.EatenByEnemy());
            yield return new WaitForSeconds(10f);
        }
    }
}
