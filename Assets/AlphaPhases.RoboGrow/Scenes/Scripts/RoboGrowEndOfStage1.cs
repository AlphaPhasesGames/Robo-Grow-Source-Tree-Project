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
    public class RoboGrowEndOfStage1 : MonoBehaviour
    {
        public float xAngle;
        public float yAngle;
        public float zAngle;
        public BoxCollider colliderToDisable;
        public RoboGrowTextBoxManager rgTextMan1;
        public GameObject seedButtonToEnable;
        public bool playOnlyOnce;
        public bool runOnce;
        public Button speakEndOFLevel1Text;
        public TextMeshProUGUI endOFGameText;

        public Button help;
        public Button tasks;

       // public GameObject mainCamToEnable;
        public Camera mainCameraCamera;
        public GameObject playerCanToDisable;
        public GameObject textPanalToHide;
        public GameObject playerStage1Robot;
        public GameObject playerStage2Robot;
        public GameObject stage1ItemsTohide;
      //  public GameObject stage2ItemsToShow;
        public Transform startpoSitionOfPlayer;
        public RobotController robCont;
        public RoboGrowMain rgMain;
        public Animator closeDoor;
       // public Button progressText;
       // public Button progressTextBack;
        public BoxCollider boxToDisable;
        public Animator lightToAnim;
        public Animator roboGrowLogoFade;
        public Animator startGameAnim;
        public Animator doorOpenAnim;
        public Animator robotAnims;
        public Animator stage2IntroLogo;
        // Start is called before the first frame update
        void Start()
        {
            textPanalToHide.SetActive(false);
            speakEndOFLevel1Text.onClick.AddListener(stage1Complete);
          //  progressText.gameObject.SetActive(false);
         //   progressTextBack.gameObject.SetActive(false);
            boxToDisable.enabled = false;
        }

        // Update is called once per frame

        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                if (!runOnce)
                {
                    stage1ItemsTohide.SetActive(false);
                    robotAnims.enabled = true;
                    startGameAnim.enabled = true;
                    boxToDisable.enabled = false;
                    rgMain.MoveToLevel2();
                    textPanalToHide.SetActive(false);
                    robCont.enabled = false;
                    playerCanToDisable.SetActive(false);
                    mainCameraCamera.enabled = true;
                    mainCameraCamera.gameObject.SetActive(true);

                    textPanalToHide.SetActive(false);
                    playerStage1Robot.gameObject.SetActive(false);
                    playerStage2Robot.gameObject.SetActive(true);
                    rgMain.task1TextUITick1.gameObject.SetActive(false);
                    rgMain.task1TextUITick2.gameObject.SetActive(false);
                    rgMain.task1TextUITick3.gameObject.SetActive(false);
                    playerStage1Robot.transform.position = startpoSitionOfPlayer.transform.position;
                    //     stage2ItemsToShow.SetActive(true);
                    doorOpenAnim.SetBool("closeDoor", true);
                    doorOpenAnim.SetBool("doorNeedsToBeOpen", false);
                    StartCoroutine(StartStage2());
                    help.enabled = false;
                    tasks.enabled = false;
                    //StartCoroutine(ResetDoor());
                    if (!playOnlyOnce)
                    {
                        LOLSDK.Instance.SubmitProgress(0, 20, 100);
                        textPanalToHide.SetActive(true);
                        playOnlyOnce = true;

                    }
                    runOnce = true;
                }
  


            }
        }

        void stage1Complete()
        {
            LOLSDK.Instance.SpeakText("stage1Complete");
        }

        public IEnumerator StartStage2()
        {

            lightToAnim.SetBool("endOfLevelBool", true);
            yield return new WaitForSeconds(2);
            roboGrowLogoFade.SetBool("logoFadeTrue", true);
            startGameAnim.SetBool("gameStarted", true);
            stage2IntroLogo.SetBool("stage2Start", true);
            yield return new WaitForSeconds(2);
            lightToAnim.SetTrigger("endOfLevelLight");
            lightToAnim.SetBool("endOfLevelBool", false);
            robotAnims.SetBool("stage2Start", true);
            doorOpenAnim.SetBool("doorNeedsToBeOpen", false);
            doorOpenAnim.SetBool("closeDoor", false);



        }

        public IEnumerator ResetDoor()
        {

            yield return new WaitForSeconds(0.1f);
          
           
        }
          
    }
}
