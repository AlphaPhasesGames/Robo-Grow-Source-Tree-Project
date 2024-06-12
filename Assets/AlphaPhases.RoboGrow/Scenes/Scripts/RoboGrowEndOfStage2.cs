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
    public class RoboGrowEndOfStage2 : MonoBehaviour
    {
        public float xAngle;
        public float yAngle;
        public float zAngle;
        public BoxCollider colliderToDisable;
        public BoxCollider stage3StartColliderToEnable;
        public GameObject seedButtonToEnable;
        public bool playOnlyOnce;
        public bool movePlayerOnce;
        public Button speakEndOFLevel1Text;
        public TextMeshProUGUI endOFGameText;
        // public GameObject mainCamToEnable;
        public Camera mainCameraCamera;
        public Camera playerCanToDisable;

        public Button help;
        public Button tasks;

        public Renderer susanArrowToReset;
        public Renderer susan2ArrowToReset;
        public Renderer limaArrowToReset;
        public Renderer lima2ArrowToReset;
        public Renderer daisyArrowToReset;
        public Renderer daisy2ArrowToReset;
        public Renderer radishArrowToReset;
        public Renderer radish2ArrowToReset;

        public Material notWatered;

        public Animator susan1WaterToReset;
     //   public Animator susan2WaterToReset;
     //   public Animator lima1WaterToReset;
    //    public Animator lima2WaterToReset;
    //    public Animator daisy1WaterToReset;
    //    public Animator daisy2WaterToReset;
    //    public Animator radish1WaterToReset;
    //    public Animator radish2WaterToReset;

        public GameObject susanArrowToDisable;
        public GameObject susan2ArrowToDisable;
        public GameObject limaArrowToDisable;
        public GameObject lima2ArrowToDisable;
        public GameObject daisyArrowToDisable;
        public GameObject daisy2ArrowToDisable;
        public GameObject radishArrowToDisable;
        public GameObject radish2ArrowToDisable;

        public GameObject textPanalToHide;
        public GameObject playerStage1Robot;
        public GameObject playerStage2Robot;
        public GameObject stage2ItemsTohide;
        public GameObject stage3ItemsToShow;
        public Transform startpoSitionOfPlayer;
        public RobotController robCont;
        public RoboGrowMain rgMain;
        public Animator closeDoor;
       // public Button progressText;
      //  public Button progressTextBack;
        public BoxCollider boxToDisable;
        public Animator lightToAnim;
        public Animator roboGrowLogoFade;
        public Animator startGameAnim;
        public Animator doorOpenAnim;
        public Animator stage2IntroLogo;
        public Animator robotAnim;

        public BoxCollider susan1plantBoxToDisable;
        public BoxCollider susan2plantBoxToDisable;
        public BoxCollider limaBean1plantBoxToDisable;
        public BoxCollider limaBean2plantBoxToDisable;
        public BoxCollider daisy1plantBoxToDisable;
        public BoxCollider daisy2plantBoxToDisable;
        public BoxCollider radish1plantBoxToDisable;
        public BoxCollider radish2plantBoxToDisable;

        // Start is called before the first frame update
        void Start()
        {
            textPanalToHide.SetActive(false);
            speakEndOFLevel1Text.onClick.AddListener(stage1Complete);
          //  progressText.gameObject.SetActive(false);
            //progressTextBack.gameObject.SetActive(false);
            boxToDisable.enabled = false;
        }

        // Update is called once per frame
        void Update()
        {
            if (rgMain.stage2TreeExamindComplete && rgMain.stage2AllSeedWateredStage2 && rgMain.stage2MiniGameComplete)
            {
                if (!playOnlyOnce)
                {
                    // mainCameraCamera.enabled = true;
                    boxToDisable.enabled = false;
                    roboGrowLogoFade.gameObject.SetActive(false);
                    textPanalToHide.SetActive(true);
                    boxToDisable.enabled = true;
                    playOnlyOnce = true;
                    roboGrowLogoFade.gameObject.SetActive(true);
                    rgMain.stage2TreeExamindComplete = false;
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
                    rgMain.MoveToLevel3();
                    textPanalToHide.SetActive(false);
                    robCont.enabled = false;
                    // playerCanToDisable.enabled = false;
                    mainCameraCamera.enabled = true;
                    stage2ItemsTohide.SetActive(false);
                    stage3ItemsToShow.SetActive(true);
                    mainCameraCamera.gameObject.SetActive(true);
                    mainCameraCamera.enabled = true;
                    playerStage1Robot.transform.position = startpoSitionOfPlayer.transform.position;
                    textPanalToHide.SetActive(false);
                    playerStage1Robot.SetActive(false);
                    playerStage2Robot.SetActive(true);

                    help.enabled = false;
                    tasks.enabled = false;

                    susanArrowToDisable.gameObject.SetActive(true);
                    susan2ArrowToDisable.gameObject.SetActive(true);
                    limaArrowToDisable.gameObject.SetActive(true);
                    lima2ArrowToDisable.gameObject.SetActive(true);
                    daisyArrowToDisable.gameObject.SetActive(true);
                    daisy2ArrowToDisable.gameObject.SetActive(true);
                    radishArrowToDisable.gameObject.SetActive(true);
                    radish2ArrowToDisable.gameObject.SetActive(true);

                    // playerStage1Robot.gameObject.SetActive(false);
                    //playerStage2Robot.gameObject.SetActive(true);
                    rgMain.task1TextUITick1.gameObject.SetActive(false);
                    rgMain.task1TextUITick2.gameObject.SetActive(false);
                    rgMain.task1TextUITick3.gameObject.SetActive(false);
                    movePlayerOnce = true;
                    LOLSDK.Instance.SubmitProgress(0, 40, 100);
                    susan1WaterToReset.ResetTrigger("waterSusans");
                    susan1WaterToReset.SetTrigger("resetSusan");
                //    susan2WaterToReset.ResetTrigger("waterSusanTwo");
                //    susan2WaterToReset.SetTrigger("resetSusanTwo");
                //    lima1WaterToReset.ResetTrigger("waterLima1");
                //    lima1WaterToReset.SetTrigger("resetLima1");
                //    lima2WaterToReset.ResetTrigger("waterLima2");
                //    lima2WaterToReset.SetTrigger("resetLima2");
               //     daisy1WaterToReset.ResetTrigger("waterDaisy1");
               //     daisy1WaterToReset.SetTrigger("resetDaisy1");
              //      daisy2WaterToReset.ResetTrigger("waterDaisy2");
               //     daisy2WaterToReset.SetTrigger("resetDaisy2");
              //      radish1WaterToReset.ResetTrigger("waterRadish");
              //      radish1WaterToReset.SetTrigger("resetRadish");
             //       radish2WaterToReset.ResetTrigger("waterRadish2");
             //       radish2WaterToReset.SetTrigger("resetRadish2");

                    susanArrowToReset.material = notWatered;
                    susan2ArrowToReset.material = notWatered;
                    limaArrowToReset.material = notWatered;
                    lima2ArrowToReset.material = notWatered;
                    daisyArrowToReset.material = notWatered;
                    daisy2ArrowToReset.material = notWatered;
                    radishArrowToReset.material = notWatered;
                    radish2ArrowToReset.material = notWatered;

                    susan1plantBoxToDisable.enabled = true;
                    susan2plantBoxToDisable.enabled = true;
                    limaBean1plantBoxToDisable.enabled = true;
                    limaBean2plantBoxToDisable.enabled = true;
                    daisy1plantBoxToDisable.enabled = true;
                    daisy2plantBoxToDisable.enabled = true;
                    radish1plantBoxToDisable.enabled = true;
                    radish2plantBoxToDisable.enabled = true;

                    doorOpenAnim.SetBool("closeDoor", true);
                    stage3ItemsToShow.SetActive(true);
                    StartCoroutine(StartStage3());
                    StartCoroutine(ResetDoor());
                }




            }
        }

        void stage1Complete()
        {
            LOLSDK.Instance.SpeakText("jobotStage2Completeb");
        }

        public IEnumerator StartStage3()
        {

            lightToAnim.SetBool("endOfLevelBool", true);
          //  lightToAnim.SetTrigger("endOfLevelLight");

           
            yield return new WaitForSeconds(2);
            roboGrowLogoFade.SetBool("logoFadeTrue", true);
            startGameAnim.SetBool("gameStarted", true);
            stage2IntroLogo.SetBool("stage3Start", true);
            yield return new WaitForSeconds(2);
            lightToAnim.SetBool("endOfLevelBool", false);
            lightToAnim.SetTrigger("endOfLevelLight");
            doorOpenAnim.SetBool("doorNeedsToBeOpen", true);
            robotAnim.SetBool("stage3Start", true);

        }

       

        

        public IEnumerator ResetDoor()
        {
            yield return new WaitForSeconds(0.1f);
            doorOpenAnim.SetBool("doorNeedsToBeOpen", false);
            doorOpenAnim.SetBool("closeDoor", false);
            closeDoor.SetTrigger("resetDoorValues");

        }

    }
}

