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
    public class RoboGrowEndOfStage3 : MonoBehaviour
    {
        public float xAngle;
        public float yAngle;
        public float zAngle;
        public BoxCollider colliderToDisable;
        public BoxCollider stage3StartColliderToEnable;
        public GameObject seedButtonToEnable;
        public RoboGrowTextBoxManagerStage3 rgTextMan3;
        public bool playOnlyOnce;
        public bool movePlayerOnce;
        // public Button speakEndOFLevel1Text;
        // public TextMeshProUGUI endOFGameText;
        // public GameObject mainCamToEnable;

        public Button help;
        public Button tasks;
        public GameObject textPanalToHideFromStage3;
        public Camera mainCameraCamera;
        public Camera playerCanToDisable;
        // public GameObject textPanalToHide;
        public GameObject playerStage1Robot;
        public GameObject playerStage4Robot;
        public GameObject stage3ItemsTohide;
        public GameObject stage4ItemsToShow;
        public GameObject wholeStage3TextPanalTohide;
        public Animator susan1WaterToReset;
     

        public GameObject susan1ArrowObject;
        public GameObject susan2ArrowObject;
        public GameObject lima1ArrowObject;
        public GameObject lima2ArrowObject;
        public GameObject daisy1ArrowObject;
        public GameObject daisy2ArrowObject;
        public GameObject radish1ArrowObject;
        public GameObject radish2ArrowObject;

        public Renderer susanArrowToReset;
        public Renderer susan2ArrowToReset;
        public Renderer limaArrowToReset;
        public Renderer lima2ArrowToReset;
        public Renderer daisyArrowToReset;
        public Renderer daisy2ArrowToReset;
        public Renderer radishArrowToReset;
        public Renderer radish2ArrowToReset;

        public Material notWatered;

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
            // textPanalToHide.SetActive(false);
            //speakEndOFLevel1Text.onClick.AddListener(stage1Complete);
            // progressText.gameObject.SetActive(false);
            // progressTextBack.gameObject.SetActive(false);
            boxToDisable.enabled = false;
        }

        // Update is called once per frame
        void Update()
        {
            if (rgMain.stage3FlowersWatered && rgMain.stage3PondExamined && rgMain.stage3TreeminigGameComplete)
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

                rgMain.amountofPlantsWateredStage2 = 0;
                doorOpenAnim.enabled = true;
                startGameAnim.enabled = true;
                boxToDisable.enabled = false;
                seedButtonToEnable.SetActive(false);
                textPanalToHideFromStage3.gameObject.SetActive(false);
                robCont.enabled = false;
                // playerCanToDisable.enabled = false;
                playerStage1Robot.transform.position = startpoSitionOfPlayer.transform.position;
                mainCameraCamera.gameObject.SetActive(true);
                mainCameraCamera.enabled = true;
                playerCanToDisable.enabled = false;
                stage3ItemsTohide.SetActive(false);
                playerStage1Robot.SetActive(false);
                playerStage4Robot.SetActive(true);
              

                susan1WaterToReset.ResetTrigger("waterSusans");
                susan1WaterToReset.SetTrigger("resetSusan");
              


                susan1ArrowObject.gameObject.SetActive(true);
                susan2ArrowObject.gameObject.SetActive(true);
                lima1ArrowObject.gameObject.SetActive(true);
                lima2ArrowObject.gameObject.SetActive(true);
                daisy1ArrowObject.gameObject.SetActive(true);
                daisy2ArrowObject.gameObject.SetActive(true);
                radish1ArrowObject.gameObject.SetActive(true);
                radish2ArrowObject.gameObject.SetActive(true);

                susanArrowToReset.material = notWatered;
                susan2ArrowToReset.material = notWatered;
                limaArrowToReset.material = notWatered;
                lima2ArrowToReset.material = notWatered;
                daisyArrowToReset.material = notWatered;
                daisy2ArrowToReset.material = notWatered;
                radishArrowToReset.material = notWatered;
                radish2ArrowToReset.material = notWatered;
                closeDoor.SetBool("closeDoor", true);
                if (!movePlayerOnce)
                {
                    
                    stage4ItemsToShow.SetActive(true);
                    rgMain.MoveToLevel4();
                    movePlayerOnce = true;
                    rgTextMan3.currentStageOfText = 15;
                    wholeStage3TextPanalTohide.gameObject.SetActive(false);
                    StartCoroutine(StartStage4());
                    StartCoroutine(ResetDoor());

                    help.enabled = false;
                    tasks.enabled = false;
                    LOLSDK.Instance.SubmitProgress(0, 60, 100);
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
            stage2IntroLogo.SetBool("stage4Intro", true);
            yield return new WaitForSeconds(2);
            doorOpenAnim.SetBool("stage4Robot", true);
            



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
