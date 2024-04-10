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
    public class RoboGrowStage5ButtIncorrectAnswer : MonoBehaviour
    {
        public AudioSource deathSFX;
        public GameObject buttPlayer;
        public Transform playerRespawnLocation;
        public ButterFlyPlayerController buttCont;
        public RoboGrowStage5MiniGame2Tree buttMinigame;
       // public GameObject buttlevelItems;
        // Start is called before the first frame update
        void Start()
        {

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
                buttPlayer.transform.position = playerRespawnLocation.transform.position;
                buttPlayer.transform.eulerAngles = new Vector3(0, -140, 0);
                buttCont.enabled = false;
                Debug.Log("The Fall trigge works");
                buttMinigame.currentStage5TreeText = 7;
               // buttlevelItems.gameObject.SetActive(false);
            }


        }
    }
}
