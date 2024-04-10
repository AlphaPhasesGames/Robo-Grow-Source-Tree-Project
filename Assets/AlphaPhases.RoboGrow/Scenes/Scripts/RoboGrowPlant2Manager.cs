using System.Collections;
using UnityEngine;
using LoLSDK;
using UnityEngine.UI;
using TMPro;
using UnityEngine.AI;
namespace Alpha.Phases.Robo.Grow
{
    public class RoboGrowPlant2Manager : MonoBehaviour
    {
        public GameObject textPanal;

        public RoboGrowResetAsses1 rgResetAss;

        public bool hasSaveHappened;
        public bool waterSusanOnce;


        // public Button returnToPlayeCam;
        //   public Button collectSeeds;
        public Button removeDeadPlants;

        public Button TTSJobotFlower1LimaBean1;
        public Button TTSJobotFlower1LimaBean2;
        public Button TTSJobotFlower1LimaBean3;

        public bool saveOnce;

        public float amountOfGuesses;

        public TextMeshProUGUI jobotIntroStage1FlowerLimaBean1;
        public TextMeshProUGUI jobotIntroStage1FlowerLimaBean2;
        public TextMeshProUGUI jobotIntroStage1FlowerLimaBean3;

        public Button TTSJobotFlowerAssesmentAnswerCorrect;
        public Button TTSJobotFlowerAssesmentAnswerIncorrect;

        public TextMeshProUGUI jobotFlowerAssesmentAnswerCorrect;
        public TextMeshProUGUI jobotFlowerAssesmentAnswerIncorrect;

        public Button wrongAnswer;
        public Button wrongAnswer2;

        public Renderer arrowRend;
        public GameObject robotToStopNavmesh;
        public GameObject plantToHide;
        public RobotController robCont;
        public RoboGrowMain rgMain;

        public MeshRenderer susanArrowToEnableAfterGettingWrong;
        public MeshRenderer limaArrowToEnableAfterGettingWrong;
        public MeshRenderer daisyArrowToEnableAfterGettingWrong;
        public MeshRenderer radishArrowToEnableAfterGettingWrong;

        public GameObject plantscanvasTohide;

        public GameObject stage1FlowerArrow1;
        public GameObject stage1FlowerArrow2;
        public GameObject stage1FlowerArrow3;

        public RoboGrowPlantManager rgPlantMan;

        // public Camera flowerCam;
        public Camera playerCam;

        public Button progressText;
        public Button progressTextBack;

        public GameObject triggerArrow;

    //    public BoxCollider plant1Box;
    //    public BoxCollider plant2Box;
    //    public BoxCollider plant3Box;

        public bool hasTextBeenSpoken;

        public bool textBeenRead;
        public bool progressTextIsShowing;

        public int currentStage1FlowerLimaBeanText;

        private void Awake()
        {
            // Awke is called before the scene loads, before the first frame update
            TTSJobotFlower1LimaBean1.onClick.AddListener(JobotStage1LimaBeanVoiceCommand1);
            TTSJobotFlower1LimaBean2.onClick.AddListener(JobotStage1LimaBeanVoiceCommand2);
            TTSJobotFlower1LimaBean3.onClick.AddListener(JobotStage1LimaBeanVoiceCommand3);
            TTSJobotFlowerAssesmentAnswerCorrect.onClick.AddListener(JobotStage1LimaVoiceCommandCorrect);
            TTSJobotFlowerAssesmentAnswerIncorrect.onClick.AddListener(JobotStage1LimaVoiceCommandIncorrect);


            progressText.onClick.AddListener(OnClick);
            progressTextBack.onClick.AddListener(OnClickBack);

            hasTextBeenSpoken = false;
            //  Debug.Log("All TTS added to buttons as listeners" + hasTextBeenSpoken);
        }
        // Start is called before the first frame update
        void Start()
        {
            //   returnToPlayeCam.gameObject.SetActive(false);
            //  collectSeeds.gameObject.SetActive(false);
            removeDeadPlants.gameObject.SetActive(false);
            jobotIntroStage1FlowerLimaBean1.enabled = false;
            jobotIntroStage1FlowerLimaBean2.enabled = false;
            jobotIntroStage1FlowerLimaBean3.enabled = false;
            jobotFlowerAssesmentAnswerCorrect.enabled = false;
            jobotFlowerAssesmentAnswerIncorrect.enabled = false;

            //    flowerCam.enabled = false;
        }

        // Update is called once per frame
        void Update()
        {

            if (currentStage1FlowerLimaBeanText == 1)
            {
                if (!hasTextBeenSpoken) // this stops the text panal showing forever
                {

                    textPanal.SetActive(true); // this is nestled here to stop it force showing.
                    hasTextBeenSpoken = true;

                }
                if (!textBeenRead)
                {
                    progressText.gameObject.SetActive(false);
                }
                robCont.enabled = false;
                jobotIntroStage1FlowerLimaBean1.enabled = true;
                jobotIntroStage1FlowerLimaBean2.enabled = false;
                jobotIntroStage1FlowerLimaBean3.enabled = false;
                TTSJobotFlower1LimaBean1.gameObject.SetActive(true);
                TTSJobotFlower1LimaBean2.gameObject.SetActive(false);
                TTSJobotFlower1LimaBean3.gameObject.SetActive(false);

                jobotFlowerAssesmentAnswerCorrect.gameObject.SetActive(false);
                jobotFlowerAssesmentAnswerIncorrect.gameObject.SetActive(false);

                TTSJobotFlowerAssesmentAnswerCorrect.gameObject.SetActive(false);
                TTSJobotFlowerAssesmentAnswerIncorrect.gameObject.SetActive(false);

                removeDeadPlants.gameObject.SetActive(false);
                if (!progressTextIsShowing)
                { // 3 second delay
                    StartCoroutine(DelayProgressButtonVar1());
                    progressTextIsShowing = true;
                }
            }

            if (currentStage1FlowerLimaBeanText == 2)
            {
                if (!textBeenRead)
                {
                    progressText.gameObject.SetActive(false);
                }
                jobotIntroStage1FlowerLimaBean1.enabled = false;
                jobotIntroStage1FlowerLimaBean2.enabled = true;
                jobotIntroStage1FlowerLimaBean3.enabled = false;

                TTSJobotFlower1LimaBean1.gameObject.SetActive(false);
                TTSJobotFlower1LimaBean2.gameObject.SetActive(true);
                TTSJobotFlower1LimaBean3.gameObject.SetActive(false);

                jobotFlowerAssesmentAnswerCorrect.gameObject.SetActive(false);
                jobotFlowerAssesmentAnswerIncorrect.gameObject.SetActive(false);

                TTSJobotFlowerAssesmentAnswerCorrect.gameObject.SetActive(false);
                TTSJobotFlowerAssesmentAnswerIncorrect.gameObject.SetActive(false);

                if (!progressTextIsShowing)
                { // 3 second delay
                    StartCoroutine(DelayProgressButtonVar2());
                    progressTextIsShowing = true;
                }
            }

            if (currentStage1FlowerLimaBeanText == 3)
            {

                if (!textBeenRead)
                {
                    progressText.gameObject.SetActive(false);
                }
                jobotIntroStage1FlowerLimaBean1.enabled = false;
                jobotIntroStage1FlowerLimaBean2.enabled = false;
                jobotIntroStage1FlowerLimaBean3.enabled = true;
                robCont.NewNavmeshStop();
                TTSJobotFlower1LimaBean1.gameObject.SetActive(false);
                TTSJobotFlower1LimaBean2.gameObject.SetActive(false);
                TTSJobotFlower1LimaBean3.gameObject.SetActive(true);

                jobotFlowerAssesmentAnswerCorrect.gameObject.SetActive(false);
                jobotFlowerAssesmentAnswerIncorrect.gameObject.SetActive(false);

                removeDeadPlants.onClick.AddListener(RemoveDeadPlants2);
                wrongAnswer.onClick.AddListener(WrongAsnwer);
                wrongAnswer2.onClick.AddListener(WrongAsnwer);

                TTSJobotFlowerAssesmentAnswerCorrect.gameObject.SetActive(false);
                TTSJobotFlowerAssesmentAnswerIncorrect.gameObject.SetActive(false);

                progressText.gameObject.SetActive(false);
                robotToStopNavmesh.GetComponent<NavMeshAgent>().isStopped = false;
                removeDeadPlants.gameObject.SetActive(true);

            }
            if (currentStage1FlowerLimaBeanText == 4)
            {
                if (!textBeenRead)
                {
                    progressText.gameObject.SetActive(false);
                }
                textPanal.gameObject.SetActive(true);
                jobotIntroStage1FlowerLimaBean1.enabled = false;
                jobotIntroStage1FlowerLimaBean2.enabled = false;
                jobotIntroStage1FlowerLimaBean3.enabled = false;
                robCont.NewNavmeshStop();
                TTSJobotFlower1LimaBean1.gameObject.SetActive(false);
                TTSJobotFlower1LimaBean2.gameObject.SetActive(false);
                TTSJobotFlower1LimaBean3.gameObject.SetActive(false);

                jobotFlowerAssesmentAnswerCorrect.gameObject.SetActive(true);
                jobotFlowerAssesmentAnswerCorrect.enabled = true;
                jobotFlowerAssesmentAnswerIncorrect.gameObject.SetActive(false);

                TTSJobotFlowerAssesmentAnswerCorrect.gameObject.SetActive(true);
                TTSJobotFlowerAssesmentAnswerIncorrect.gameObject.SetActive(false);
              
                robotToStopNavmesh.GetComponent<NavMeshAgent>().isStopped = false;

                if (!progressTextIsShowing)
                { // 3 second delay
                    StartCoroutine(DelayProgressButtonVar2());
                    progressTextIsShowing = true;
                }

             //   if (!hasSaveHappened)
             //   {
             //       StartCoroutine(CloseBox());
              //      hasSaveHappened = true;
              //  }

            }

           

            if (currentStage1FlowerLimaBeanText == 5)
            {
                textPanal.gameObject.SetActive(false);

                jobotIntroStage1FlowerLimaBean1.enabled = false;
                jobotIntroStage1FlowerLimaBean2.enabled = false;
                jobotIntroStage1FlowerLimaBean3.enabled = false;
                robCont.NewNavmeshStop();
                TTSJobotFlower1LimaBean1.gameObject.SetActive(false);
                TTSJobotFlower1LimaBean2.gameObject.SetActive(false);
                TTSJobotFlower1LimaBean3.gameObject.SetActive(false);

                jobotFlowerAssesmentAnswerCorrect.gameObject.SetActive(false);
                jobotFlowerAssesmentAnswerIncorrect.enabled = false;
                jobotFlowerAssesmentAnswerIncorrect.gameObject.SetActive(false);

                TTSJobotFlowerAssesmentAnswerCorrect.gameObject.SetActive(false);
                TTSJobotFlowerAssesmentAnswerIncorrect.gameObject.SetActive(false);
                progressText.gameObject.SetActive(false);
                progressTextBack.gameObject.SetActive(false);
                robotToStopNavmesh.GetComponent<NavMeshAgent>().isStopped = false;
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

            if (currentStage1FlowerLimaBeanText == 7)
            {
                textPanal.gameObject.SetActive(true);
                jobotIntroStage1FlowerLimaBean1.enabled = false;
                jobotIntroStage1FlowerLimaBean2.enabled = false;
                jobotIntroStage1FlowerLimaBean3.enabled = false;
                robCont.NewNavmeshStop();
                TTSJobotFlower1LimaBean1.gameObject.SetActive(false);
                TTSJobotFlower1LimaBean2.gameObject.SetActive(false);
                TTSJobotFlower1LimaBean3.gameObject.SetActive(false);

                jobotFlowerAssesmentAnswerCorrect.gameObject.SetActive(false);
                jobotFlowerAssesmentAnswerIncorrect.enabled = true;
                jobotFlowerAssesmentAnswerIncorrect.gameObject.SetActive(true);

                TTSJobotFlowerAssesmentAnswerCorrect.gameObject.SetActive(false);
                TTSJobotFlowerAssesmentAnswerIncorrect.gameObject.SetActive(true);
                progressText.gameObject.SetActive(false);
                progressTextBack.gameObject.SetActive(false);
                robotToStopNavmesh.GetComponent<NavMeshAgent>().isStopped = false;
                StartCoroutine(CloseBoxWrong());
            }
        }


        void OnMouseDown()
        {

            //  returnToPlayeCam.onClick.AddListener(ReturnToPlayerCam);
            //  collectSeeds.onClick.AddListener(CollectSeeds2);
            removeDeadPlants.onClick.AddListener(RemoveDeadPlants2);
            wrongAnswer.onClick.AddListener(WrongAsnwer);
            wrongAnswer2.onClick.AddListener(WrongAsnwer);
            playerCam.enabled = false;
            rgMain.MoveCameraToOrganic1LimaPosition();
            robCont.enabled = false;
            robCont.NewNavmeshStop();
            //  returnToPlayeCam.gameObject.SetActive(true);
            //  collectSeeds.gameObject.SetActive(true);
            removeDeadPlants.gameObject.SetActive(true);
            Debug.Log("Mouse Clicked");
            textPanal.SetActive(true);
            currentStage1FlowerLimaBeanText = 1;
            robotToStopNavmesh.GetComponent<NavMeshAgent>().isStopped = true;
        }

        public void ReturnToPlayerCam()
        {
            // robCont.enabled = true;
            //   returnToPlayeCam.gameObject.SetActive(false);
            playerCam.enabled = true;
            rgMain.HideCamera();
            textPanal.SetActive(false);
            robCont.enabled = true;
        }

        void OnClick()
        {
            currentStage1FlowerLimaBeanText++;
            textBeenRead = false;
            progressTextIsShowing = false;
        }

        void OnClickBack()
        {
            currentStage1FlowerLimaBeanText--;
        }

        public void WrongAsnwer()
        {

            robCont.enabled = true;
            // plantToHide.SetActive(false);
            removeDeadPlants.gameObject.SetActive(false);
            playerCam.enabled = true;
            rgMain.HideCamera();
            robotToStopNavmesh.GetComponent<NavMeshAgent>().isStopped = false;
            //     collectSeeds.onClick.RemoveListener(CollectSeeds);
            removeDeadPlants.onClick.RemoveListener(RemoveDeadPlants2);
            wrongAnswer.onClick.RemoveListener(WrongAsnwer);
            wrongAnswer2.onClick.RemoveListener(WrongAsnwer);
            //    collectSeeds.gameObject.SetActive(false);
            wrongAnswer.gameObject.SetActive(false);
            //   returnToPlayeCam.gameObject.SetActive(false);
            // rgPlantMan.removedFlowers++;
            // CollectSeeds();
            currentStage1FlowerLimaBeanText = 7;
            amountOfGuesses++;


            //  catControl.enabled = true;
        }


        public void RemoveDeadPlants2()
        {
            if (!waterSusanOnce)
            {
                hasTextBeenSpoken = false;
                progressTextIsShowing = false;
                robCont.enabled = true;
                // plantToHide.SetActive(false);
                removeDeadPlants.gameObject.SetActive(false);
                playerCam.enabled = true;
                rgMain.HideCamera();
                robotToStopNavmesh.GetComponent<NavMeshAgent>().isStopped = false;
                //     collectSeeds.onClick.RemoveListener(CollectSeeds);
                removeDeadPlants.onClick.RemoveListener(RemoveDeadPlants2);
                //    collectSeeds.gameObject.SetActive(false);
                removeDeadPlants.gameObject.SetActive(false);
                //   returnToPlayeCam.gameObject.SetActive(false);
                rgPlantMan.removedFlowers++;
                // CollectSeeds();

                currentStage1FlowerLimaBeanText = 4;
                waterSusanOnce = true;
            }

           
        }

        public void CollectSeeds2()
        {
            rgMain.SaveSeeds();
            //   collectSeeds.gameObject.SetActive(false);
        }

        void JobotStage1LimaBeanVoiceCommand1()
        {
            LOLSDK.Instance.SpeakText("stage1Plant3LimaBText1");
        }

        void JobotStage1LimaBeanVoiceCommand2()
        {
            LOLSDK.Instance.SpeakText("stage1Plant3LimaBText1a");
        }

        void JobotStage1LimaBeanVoiceCommand3()
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
            plantscanvasTohide.gameObject.SetActive(false);
            currentStage1FlowerLimaBeanText = 0;
           
                   

        }
        public IEnumerator CloseBoxWrong()
        {
            susanArrowToEnableAfterGettingWrong.enabled = true;
            limaArrowToEnableAfterGettingWrong.enabled = true;
            daisyArrowToEnableAfterGettingWrong.enabled = true;
            radishArrowToEnableAfterGettingWrong.enabled = true;
            arrowRend.enabled = false;
         //   plant1Box.enabled = false;
         //   plant2Box.enabled = false;
         //   plant3Box.enabled = false;
            yield return new WaitForSeconds(3);
            triggerArrow.gameObject.SetActive(false);
            textPanal.gameObject.SetActive(false);
            plantscanvasTohide.gameObject.SetActive(false);
         //   plant1Box.enabled = true;
         //   plant2Box.enabled = true;
        //    plant3Box.enabled = true;
            currentStage1FlowerLimaBeanText = 0;
           

        }
    }
}
