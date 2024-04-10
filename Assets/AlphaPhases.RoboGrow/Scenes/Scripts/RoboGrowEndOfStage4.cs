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
    public class RoboGrowEndOfStage4 : MonoBehaviour
    {
        public float xAngle;
        public float yAngle;
        public float zAngle;
        public BoxCollider colliderToDisable;
        public BoxCollider stage4StartColliderToEnable;
       // public GameObject seedButtonToEnable;
        public bool playOnlyOnce;
        public bool movePlayerOnce;
        // public Button speakEndOFLevel1Text;
        // public TextMeshProUGUI endOFGameText;
         public GameObject mainCamToEnable;
        public Camera mainCameraCamera;
        public Camera playerCanToDisable;
        // public GameObject textPanalToHide;
        public GameObject playerStage1Robot;
        public GameObject playerStage4Robot;
        public GameObject stage4ItemsTohide;
        public GameObject stage5ItemsToShow;

        public Renderer susanArrowToReset;
        public Renderer susan2ArrowToReset;
        public Renderer limaArrowToReset;
        public Renderer lima2ArrowToReset;
        public Renderer daisyArrowToReset;
        public Renderer daisy2ArrowToReset;
        public Renderer radishArrowToReset;
        public Renderer radish2ArrowToReset;

        public GameObject susan1ArrowObject;
        public GameObject susan2ArrowObject;
        public GameObject lima1ArrowObject;
        public GameObject lima2ArrowObject;
        public GameObject daisy1ArrowObject;
        public GameObject daisy2ArrowObject;
        public GameObject radish1ArrowObject;
        public GameObject radish2ArrowObject;

        public BoxCollider susan1BoxObject;
        public BoxCollider susan2BoxObject;
        public BoxCollider lima1BoxObject;
        public BoxCollider lima2BoxObject;
        public BoxCollider daisy1BoxObject;
        public BoxCollider daisy2BoxObject;
        public BoxCollider radish1BoxObject;
        public BoxCollider radish2BoxObject;

        public Material notWatered;

        public Button help;
        public Button tasks;

        public Transform startpoSitionOfPlayer;
        public RobotController robCont;
        public RoboGrowMain rgMain;
        public Animator closeDoor;
        //  public Button progressText;
        //  public Button progressTextBack;
        public BoxCollider boxToDisable;
        public Animator lightToAnim;
        public Animator roboGrowLogoFade;
        public Animator startGameAnim;
        public Animator doorOpenAnim;
        public Animator stage2IntroLogo;
        // Start is called before the first frame update
        void Start()
        {
           
            boxToDisable.enabled = false;
        }

        // Update is called once per frame
        void Update()
        {
            if (rgMain.stage4FrogMiniGameComplete && rgMain.stage4FlowersWatered && rgMain.stage4ButterflyMiniGameComplete)
            {

                if (!playOnlyOnce)
                {
                 
                    boxToDisable.enabled = true;
                    playOnlyOnce = true;
                }

            }
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                if (!movePlayerOnce)
                {
                    rgMain.amountofPlantsWateredStage2 = 0;
                    doorOpenAnim.enabled = true;
                    startGameAnim.enabled = true;
                    boxToDisable.enabled = false;
                    //seedButtonToEnable.SetActive(false);
                    rgMain.MoveToLevel5();
                    // textPanalToHide.SetActive(false);
                    robCont.enabled = false;
                    // playerCanToDisable.enabled = false;
                    playerStage1Robot.transform.position = startpoSitionOfPlayer.transform.position;
                    mainCameraCamera.gameObject.SetActive(true);
                    mainCameraCamera.enabled = true;
                 //   mainCamToEnable.gameObject.SetActive(false);
                    playerCanToDisable.enabled = false;
                    stage4ItemsTohide.SetActive(false);
                    //mainCameraCamera.gameObject.SetActive(true);
                    StartCoroutine(StartStage4());
                    // textPanalToHide.SetActive(false);
                    playerStage1Robot.SetActive(false);
                    playerStage4Robot.SetActive(true);
                    // playerStage1Robot.gameObject.SetActive(false);
                    //playerStage2Robot.gameObject.SetActive(true);
                    rgMain.task1TextUITick1.gameObject.SetActive(false);
                    rgMain.task1TextUITick2.gameObject.SetActive(false);
                    rgMain.task1TextUITick3.gameObject.SetActive(false);
                    movePlayerOnce = true;
                    LOLSDK.Instance.SubmitProgress(0, 80, 100);

                    help.enabled = false;
                    tasks.enabled = false;

                    susanArrowToReset.material = notWatered;
                    susan2ArrowToReset.material = notWatered;
                    limaArrowToReset.material = notWatered;
                    lima2ArrowToReset.material = notWatered;
                    daisyArrowToReset.material = notWatered;
                    daisy2ArrowToReset.material = notWatered;
                    radishArrowToReset.material = notWatered;
                    radish2ArrowToReset.material = notWatered;

                    susan1ArrowObject.gameObject.SetActive(true);
                    susan2ArrowObject.gameObject.SetActive(true);
                    lima1ArrowObject.gameObject.SetActive(true);
                    lima2ArrowObject.gameObject.SetActive(true);
                    daisy1ArrowObject.gameObject.SetActive(true);
                    daisy2ArrowObject.gameObject.SetActive(true);
                    radish1ArrowObject.gameObject.SetActive(true);
                    radish2ArrowObject.gameObject.SetActive(true);

                    susan1BoxObject.enabled = true;
                    susan2BoxObject.enabled = true;
                    lima1BoxObject.enabled = true;
                    lima2BoxObject.enabled = true;
                    daisy1BoxObject.enabled = true;
                    daisy2BoxObject.enabled = true;
                    radish1BoxObject.enabled = true;
                    radish2BoxObject.enabled = true;


                    closeDoor.SetBool("closeDoor", true);
                    stage5ItemsToShow.SetActive(true);
                    StartCoroutine(StartStage4());
                    StartCoroutine(ResetDoor());

                }




            }
        }

        void stage1Complete()
        {
            LOLSDK.Instance.SpeakText("stage1Complete");
        }

        public IEnumerator StartStage4()
        {

            lightToAnim.SetBool("endOfLevelBool", true);
            yield return new WaitForSeconds(2);
            roboGrowLogoFade.SetBool("logoFadeTrue", true);
            startGameAnim.SetBool("gameStarted", true);
            stage2IntroLogo.SetBool("stage5Intro", true);
            yield return new WaitForSeconds(2);
            doorOpenAnim.SetBool("stage5Robot", true);




        }

        public IEnumerator ResetDoor()
        {
            yield return new WaitForSeconds(0.1f);
            lightToAnim.SetTrigger("endOfLevelLight");
            closeDoor.SetBool("doorNeedsToBeOpen", false);
            closeDoor.SetBool("closeDoor", false);
            closeDoor.SetTrigger("resetDoorValues");

        }
    }
}

