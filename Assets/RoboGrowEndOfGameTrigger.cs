using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using LoLSDK;
namespace Alpha.Phases.Robo.Grow
{
    public class RoboGrowEndOfGameTrigger : MonoBehaviour
    {
        public RoboGrowMain rgMain;
        public RoboGrowStage5TextBoxManager rgTextman5;
        public Camera endCamera;
        public Camera playerCanToDisable;
        public AudioSource hooraySFX;
        public GameObject playerRobot;
        public GameObject endOfGameRobot;
        public GameObject textPanalToShow;
        public GameObject hintsButton;
        public GameObject tasksButton;
        public Animator endRobotAnim;

        public bool endOfGameBool;
   
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
                if (rgMain.currentGameStage == 5)
                {
                    hintsButton.gameObject.SetActive(false);
                    tasksButton.gameObject.SetActive(false);
                    //textPanalToShow.SetActive(true);
                    endCamera.gameObject.SetActive(true);
                    playerCanToDisable.gameObject.SetActive(false);
                    playerRobot.gameObject.SetActive(false);
                    endOfGameRobot.gameObject.SetActive(true);
                    if (!endOfGameBool)
                    {
                        endRobotAnim.SetTrigger("endOfGameEnterRobot");
                        rgTextman5.currentStageOfText = 25;
                        LOLSDK.Instance.SubmitProgress(0, 100, 100);
                        endOfGameBool = true;
                        hooraySFX.Play();
                       
                    }
                }
            }
        }



        public IEnumerator EndOfGameTimer()
        {
            endRobotAnim.SetTrigger("endOfGameLeaveRobot");
            yield return new WaitForSeconds(5);
            LOLSDK.Instance.CompleteGame();
        }
    }
}
