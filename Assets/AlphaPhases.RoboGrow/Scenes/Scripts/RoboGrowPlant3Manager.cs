using System.Collections;
using UnityEngine;
using LoLSDK;
using UnityEngine.UI;
using TMPro;
using UnityEngine.AI;

namespace Alpha.Phases.Robo.Grow
{
    public class RoboGrowPlant3Manager : MonoBehaviour
    {
        public GameObject textPanal;

        public RoboGrowResetAsses1 rgResetAss;

        public bool hasSaveHappened;
        public bool waterDaisyOnce;


        public Button TTSJobotFlower3DaisyPlant1;
        public Button TTSJobotFlower3DaisyPlant2;
        public Button TTSJobotFlower3DaisyPlant3;

        public float amountOfGuesses;

        public TextMeshProUGUI jobotIntroStage1Flower3DaisyPlant1;
        public TextMeshProUGUI jobotIntroStage1Flower3DaisyPlant2;
        public TextMeshProUGUI jobotIntroStage1Flower3DaisyPlant3;

        public Button TTSJobotFlowerAssesmentAnswerCorrect;
        public Button TTSJobotFlowerAssesmentAnswerIncorrect;

        public TextMeshProUGUI jobotFlowerAssesmentAnswerCorrect;
        public TextMeshProUGUI jobotFlowerAssesmentAnswerIncorrect;
        public bool saveOnce;

        public Button wrongAnswer;
        public Button wrongAnswer2;

        public bool waterPlantsOnceBool;

        public Renderer arrowRend;

      //  public BoxCollider plant1Box;
     //   public BoxCollider plant2Box;
     //   public BoxCollider plant3Box;

        public MeshRenderer susanArrowToEnableAfterGettingWrong;
        public MeshRenderer limaArrowToEnableAfterGettingWrong;
        public MeshRenderer daisyArrowToEnableAfterGettingWrong;
        public MeshRenderer radishArrowToEnableAfterGettingWrong;

        public GameObject plantscanvasTohide;

        public GameObject triggerArrow;

        public GameObject stage1FlowerArrow1;
        public GameObject stage1FlowerArrow2;
        public GameObject stage1FlowerArrow3;

        //    public Button returnToPlayeCam;
        //   public Button collectSeeds;
        public Button removeDeadPlants;
        public GameObject plantToHide;

        public GameObject robotNavMeshAgentToStop;
        public RobotController robCont;
        public RoboGrowPlantManager rgPlantMan;
        public RoboGrowMain rgMain;

        public bool hasTextBeenSpoken;

     //   public Camera flowerCam;
        public Camera playerCam;
        public bool textBeenRead;
        public bool progressTextIsShowing;
        public Button progressText;
        public Button progressTextBack;


        public int currentStage1FlowerDaisyPlantText;

        private void Awake()
        {
            TTSJobotFlower3DaisyPlant1.onClick.AddListener(JobotStage1DaisyPlantVoiceCommand1);
            TTSJobotFlower3DaisyPlant2.onClick.AddListener(JobotStage1DaisyPlantVoiceCommand2);
            TTSJobotFlower3DaisyPlant3.onClick.AddListener(JobotStage1DaisyPlantVoiceCommand3);

            TTSJobotFlowerAssesmentAnswerCorrect.onClick.AddListener(JobotStage1LimaVoiceCommandCorrect);
            TTSJobotFlowerAssesmentAnswerIncorrect.onClick.AddListener(JobotStage1LimaVoiceCommandIncorrect);

            progressText.onClick.AddListener(OnClick);
            progressTextBack.onClick.AddListener(OnClickBack);
        }
        // Start is called before the first frame update
        void Start()
        {

            hasTextBeenSpoken = false;
         //   returnToPlayeCam.gameObject.SetActive(false);
       //     collectSeeds.gameObject.SetActive(false);
            removeDeadPlants.gameObject.SetActive(false);

            jobotIntroStage1Flower3DaisyPlant1.enabled = false;
            jobotIntroStage1Flower3DaisyPlant2.enabled = false;
            jobotIntroStage1Flower3DaisyPlant3.enabled = false;
            jobotFlowerAssesmentAnswerCorrect.enabled = false;
            jobotFlowerAssesmentAnswerIncorrect.enabled = false;
            //    flowerCam.enabled = false;
        }

        // Update is called once per frame
        void Update()
        {

            if (currentStage1FlowerDaisyPlantText == 1)
            {
                progressTextBack.gameObject.SetActive(true);
                if (!hasTextBeenSpoken)
                {
                    textPanal.SetActive(true);
                    hasTextBeenSpoken = true;
                  
                }
                removeDeadPlants.gameObject.SetActive(false);
                if (!textBeenRead)
                {
                    progressText.gameObject.SetActive(false);
                }
                LOLSDK.Instance.SpeakText("stage1Plant2DaisyText1");

                robCont.enabled = false;
                jobotIntroStage1Flower3DaisyPlant1.enabled = true;
                jobotIntroStage1Flower3DaisyPlant2.enabled = false;
                jobotIntroStage1Flower3DaisyPlant3.enabled = false;
                TTSJobotFlower3DaisyPlant1.gameObject.SetActive(true);
                TTSJobotFlower3DaisyPlant2.gameObject.SetActive(false);
                TTSJobotFlower3DaisyPlant3.gameObject.SetActive(false);

                jobotFlowerAssesmentAnswerCorrect.gameObject.SetActive(false);
                jobotFlowerAssesmentAnswerIncorrect.gameObject.SetActive(false);

                TTSJobotFlowerAssesmentAnswerCorrect.gameObject.SetActive(false);
                TTSJobotFlowerAssesmentAnswerIncorrect.gameObject.SetActive(false);

                if (!progressTextIsShowing)
                { // 3 second delay
                    StartCoroutine(DelayProgressButtonVar1());
                    progressTextIsShowing = true;
                }
            }

            if (currentStage1FlowerDaisyPlantText == 2)
            {
                if (!textBeenRead)
                {
                    progressText.gameObject.SetActive(false);
                }
                LOLSDK.Instance.SpeakText("stage1Plant2DaisyText1a");

                progressTextBack.gameObject.SetActive(true);
                jobotIntroStage1Flower3DaisyPlant1.enabled = false;
                jobotIntroStage1Flower3DaisyPlant2.enabled = true;
                jobotIntroStage1Flower3DaisyPlant3.enabled = false;
                TTSJobotFlower3DaisyPlant1.gameObject.SetActive(false);
                TTSJobotFlower3DaisyPlant2.gameObject.SetActive(true);
                TTSJobotFlower3DaisyPlant3.gameObject.SetActive(false);

                jobotFlowerAssesmentAnswerCorrect.gameObject.SetActive(false);
                jobotFlowerAssesmentAnswerIncorrect.gameObject.SetActive(false);

                TTSJobotFlowerAssesmentAnswerCorrect.gameObject.SetActive(false);
                TTSJobotFlowerAssesmentAnswerIncorrect.gameObject.SetActive(false);

                robCont.NewNavmeshStop();
               
                robotNavMeshAgentToStop.GetComponent<NavMeshAgent>().isStopped = false;
                if (!progressTextIsShowing)
                { // 3 second delay
                    StartCoroutine(DelayProgressButtonVar2());
                    progressTextIsShowing = true;
                }
            }


            if (currentStage1FlowerDaisyPlantText == 3)
            {

                LOLSDK.Instance.SpeakText("stage1Plant2DaisyTextb");

                jobotIntroStage1Flower3DaisyPlant1.enabled = false;
                jobotIntroStage1Flower3DaisyPlant2.enabled = false;
                jobotIntroStage1Flower3DaisyPlant3.enabled = true;
                TTSJobotFlower3DaisyPlant1.gameObject.SetActive(false);
                TTSJobotFlower3DaisyPlant2.gameObject.SetActive(false);
                TTSJobotFlower3DaisyPlant3.gameObject.SetActive(true);

                jobotFlowerAssesmentAnswerCorrect.gameObject.SetActive(false);
                jobotFlowerAssesmentAnswerIncorrect.gameObject.SetActive(false);

                TTSJobotFlowerAssesmentAnswerCorrect.gameObject.SetActive(false);
                TTSJobotFlowerAssesmentAnswerIncorrect.gameObject.SetActive(false);
                removeDeadPlants.onClick.AddListener(RemoveDeadPlants);
                wrongAnswer.onClick.AddListener(WrongAsnwer);
                wrongAnswer2.onClick.AddListener(WrongAsnwer);
                robCont.NewNavmeshStop();
                progressText.gameObject.SetActive(false);
                robotNavMeshAgentToStop.GetComponent<NavMeshAgent>().isStopped = false;
                removeDeadPlants.gameObject.SetActive(true);

            }
            if (currentStage1FlowerDaisyPlantText == 4)
            {
                if (!textBeenRead)
                {
                    progressText.gameObject.SetActive(false);
                }
                textPanal.gameObject.SetActive(true);
                jobotIntroStage1Flower3DaisyPlant1.enabled = false;
                jobotIntroStage1Flower3DaisyPlant2.enabled = false;
                jobotIntroStage1Flower3DaisyPlant3.enabled = false;
                TTSJobotFlower3DaisyPlant1.gameObject.SetActive(false);
                TTSJobotFlower3DaisyPlant2.gameObject.SetActive(false);
                TTSJobotFlower3DaisyPlant3.gameObject.SetActive(false);
                LOLSDK.Instance.SpeakText("assesmentSection1AnswerCorrect");

                jobotFlowerAssesmentAnswerCorrect.gameObject.SetActive(true);
                jobotFlowerAssesmentAnswerIncorrect.gameObject.SetActive(false);
                jobotFlowerAssesmentAnswerCorrect.enabled = true;
                TTSJobotFlowerAssesmentAnswerCorrect.gameObject.SetActive(true);
                TTSJobotFlowerAssesmentAnswerIncorrect.gameObject.SetActive(false);
                robCont.NewNavmeshStop();
              
                robotNavMeshAgentToStop.GetComponent<NavMeshAgent>().isStopped = false;
                if (!progressTextIsShowing)
                { // 3 second delay
                    StartCoroutine(DelayProgressButtonVar2());
                    progressTextIsShowing = true;
                }

            }

            

            if (currentStage1FlowerDaisyPlantText == 5)
            {
                textPanal.gameObject.SetActive(false);
                jobotIntroStage1Flower3DaisyPlant1.enabled = false;
                jobotIntroStage1Flower3DaisyPlant2.enabled = false;
                jobotIntroStage1Flower3DaisyPlant3.enabled = false;
                TTSJobotFlower3DaisyPlant1.gameObject.SetActive(false);
                TTSJobotFlower3DaisyPlant2.gameObject.SetActive(false);

                jobotFlowerAssesmentAnswerCorrect.gameObject.SetActive(false);
                jobotFlowerAssesmentAnswerIncorrect.enabled = false;
                jobotFlowerAssesmentAnswerIncorrect.gameObject.SetActive(false);

                TTSJobotFlowerAssesmentAnswerCorrect.gameObject.SetActive(false);
                TTSJobotFlowerAssesmentAnswerIncorrect.gameObject.SetActive(false);
                progressText.gameObject.SetActive(false);
                progressTextBack.gameObject.SetActive(false);
                robotNavMeshAgentToStop.GetComponent<NavMeshAgent>().isStopped = false;
                rgResetAss.enabled = false;
                Destroy(triggerArrow);
                Destroy(stage1FlowerArrow1);
                Destroy(stage1FlowerArrow2);
                Destroy(stage1FlowerArrow3);
                if (!saveOnce)
                {
                    CloseBox();
                    saveOnce = true;
                }
              

            }

            if (currentStage1FlowerDaisyPlantText == 7)
            {
                textPanal.gameObject.SetActive(true);
                jobotIntroStage1Flower3DaisyPlant1.enabled = false;
                jobotIntroStage1Flower3DaisyPlant2.enabled = false;
                jobotIntroStage1Flower3DaisyPlant3.enabled = false;
                TTSJobotFlower3DaisyPlant1.gameObject.SetActive(false);
                TTSJobotFlower3DaisyPlant2.gameObject.SetActive(false);
                TTSJobotFlower3DaisyPlant3.gameObject.SetActive(false);
                LOLSDK.Instance.SpeakText("assesmentSection1AnswerIncorrect");

                jobotFlowerAssesmentAnswerCorrect.gameObject.SetActive(false);
                jobotFlowerAssesmentAnswerIncorrect.gameObject.SetActive(true);
                jobotFlowerAssesmentAnswerIncorrect.enabled = true;
                TTSJobotFlowerAssesmentAnswerCorrect.gameObject.SetActive(false);
                TTSJobotFlowerAssesmentAnswerIncorrect.gameObject.SetActive(true);
                robCont.NewNavmeshStop();
                progressText.gameObject.SetActive(false);
                progressTextBack.gameObject.SetActive(false);
                robotNavMeshAgentToStop.GetComponent<NavMeshAgent>().isStopped = false;
                StartCoroutine(CloseBoxWrong());
            }

        }


        void OnMouseDown()
        {
            //  returnToPlayeCam.onClick.AddListener(ReturnToPlayerCam);
            //  collectSeeds.onClick.AddListener(CollectSeeds2);
            removeDeadPlants.onClick.AddListener(RemoveDeadPlants);
            wrongAnswer.onClick.AddListener(WrongAsnwer);
            wrongAnswer2.onClick.AddListener(WrongAsnwer);
            playerCam.enabled = false;
            rgMain.MoveCameraToOrganic1DaisyPosition();
            robCont.enabled = false;
            robCont.NewNavmeshStop();
            //  returnToPlayeCam.gameObject.SetActive(true);
            //  collectSeeds.gameObject.SetActive(true);
            removeDeadPlants.gameObject.SetActive(true);
            Debug.Log("Mouse Clicked");
            textPanal.SetActive(true);
            currentStage1FlowerDaisyPlantText = 1;
            robotNavMeshAgentToStop.GetComponent<NavMeshAgent>().isStopped = true;
        }

        public void ReturnToPlayerCam()
        {
            robCont.enabled = true;
        //    returnToPlayeCam.gameObject.SetActive(false);
            playerCam.enabled = true;
            rgMain.HideCamera();
            textPanal.SetActive(false);
        }

        void OnClick()
        {
            currentStage1FlowerDaisyPlantText++;
            textBeenRead = false;
            progressTextIsShowing = false;
        }

        void OnClickBack()
        {
            currentStage1FlowerDaisyPlantText--;
        }

        public void WrongAsnwer()
        {

            robCont.enabled = true;
            // plantToHide.SetActive(false);
            removeDeadPlants.gameObject.SetActive(false);
            playerCam.enabled = true;
            rgMain.HideCamera();
            robotNavMeshAgentToStop.GetComponent<NavMeshAgent>().isStopped = false;
            //     collectSeeds.onClick.RemoveListener(CollectSeeds);
            wrongAnswer.onClick.RemoveListener(WrongAsnwer);
            //    collectSeeds.gameObject.SetActive(false);
            wrongAnswer.gameObject.SetActive(false);
            //   returnToPlayeCam.gameObject.SetActive(false);
            // rgPlantMan.removedFlowers++;
            // CollectSeeds();
            currentStage1FlowerDaisyPlantText = 7;
            removeDeadPlants.onClick.RemoveListener(RemoveDeadPlants);
            wrongAnswer.onClick.RemoveListener(WrongAsnwer);
            wrongAnswer2.onClick.RemoveListener(WrongAsnwer);
            amountOfGuesses++;

            //  catControl.enabled = true;
        }


        public void RemoveDeadPlants()
        {
            hasTextBeenSpoken = false;
            progressTextIsShowing = false;
            if (!waterDaisyOnce)
            {
                robCont.enabled = true;
                // plantToHide.SetActive(false);
                removeDeadPlants.gameObject.SetActive(false);
                playerCam.enabled = true;
                rgMain.HideCamera();
                robotNavMeshAgentToStop.GetComponent<NavMeshAgent>().isStopped = false;
                //     collectSeeds.onClick.RemoveListener(CollectSeeds);
                removeDeadPlants.onClick.RemoveListener(RemoveDeadPlants);
                //    collectSeeds.gameObject.SetActive(false);
                removeDeadPlants.gameObject.SetActive(false);
                //   returnToPlayeCam.gameObject.SetActive(false);
                rgPlantMan.removedFlowers++;
                // CollectSeeds();
                currentStage1FlowerDaisyPlantText = 4;
                waterDaisyOnce = true;
            }
          
        }


        void JobotStage1DaisyPlantVoiceCommand1()
        {
            LOLSDK.Instance.SpeakText("stage1Plant2DaisyText1");
        }

        void JobotStage1DaisyPlantVoiceCommand2()
        {
            LOLSDK.Instance.SpeakText("stage1Plant2DaisyText1a");
        }

        void JobotStage1DaisyPlantVoiceCommand3()
        {
            LOLSDK.Instance.SpeakText("stage1Plant1SusanText1b");
        }

        void JobotStage1LimaVoiceCommandCorrect()
        {
            LOLSDK.Instance.SpeakText("assesmentSection1AnswerCorrect");
        }

        void JobotStage1LimaVoiceCommandIncorrect()
        {
            LOLSDK.Instance.SpeakText("assesmentSection1AnswerIncorrect");
        }


        public IEnumerator DelayProgressButtonVar1()
        {
            yield return new WaitForSeconds(1);
            progressText.gameObject.SetActive(true);
            textBeenRead = true;
        }

        public IEnumerator DelayProgressButtonVar2()
        {
            yield return new WaitForSeconds(2f);
            progressText.gameObject.SetActive(true);
            textBeenRead = true;
        }

        public void CloseBox()
        {
            rgMain.stage1PlantRemovalComplete = true;
            rgMain.SaveStage1TasksComplete();
            rgMain.SaveSeeds();
            currentStage1FlowerDaisyPlantText = 0;
            plantscanvasTohide.gameObject.SetActive(false);
                   

        }
        public IEnumerator CloseBoxWrong()
        {

            robCont.enabled = true;
            arrowRend.enabled = false;
            susanArrowToEnableAfterGettingWrong.enabled = true;
            limaArrowToEnableAfterGettingWrong.enabled = true;
            daisyArrowToEnableAfterGettingWrong.enabled = true;
            radishArrowToEnableAfterGettingWrong.enabled = true;
        //    plant1Box.enabled = false;
       //     plant2Box.enabled = false;
        //    plant3Box.enabled = false;
            yield return new WaitForSeconds(3);
            triggerArrow.gameObject.SetActive(false);
            textPanal.gameObject.SetActive(false);
            plantscanvasTohide.gameObject.SetActive(false);
       //     plant1Box.enabled = true;
       //     plant2Box.enabled = true;
       //     plant3Box.enabled = true;
            currentStage1FlowerDaisyPlantText = 0;

        }
    }
}

