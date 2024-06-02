using System.Collections;
using UnityEngine;
using LoLSDK;
using UnityEngine.UI;
using UnityEngine.AI;
using TMPro;

namespace Alpha.Phases.Robo.Grow
{
    public class RoboGrowPlant1Manager : MonoBehaviour
    {
        public GameObject textPanal;
        public RoboGrowResetAsses1 rgResetAss;
        public Button TTSJobotFlower1BlackEyedSusan1;
        public Button TTSJobotFlower1BlackEyedSusan2;
        public Button TTSJobotFlower1BlackEyedSusan3;

        public float amountOfGuesses;
        public bool waterSusanOnce;
        public TextMeshProUGUI jobotIntroStage1FlowerBlackEyedSusan1;
        public TextMeshProUGUI jobotIntroStage1FlowerBlackEyedSusan2;
        public TextMeshProUGUI jobotIntroStage1FlowerBlackEyedSusan3;

        public Button TTSJobotFlowerAssesmentAnswerCorrect;
        public Button TTSJobotFlowerAssesmentAnswerIncorrect;

        public TextMeshProUGUI jobotFlowerAssesmentAnswerCorrect;
        public TextMeshProUGUI jobotFlowerAssesmentAnswerIncorrect;

        public Button wrongAnswer;
        public Button wrongAnswer2;

        public bool text1Read;
        public bool text2Read;
        public bool text3Read;
        public bool text4Read;
        public bool text5Read;
        public bool text6Read;


        //  public Button returnToPlayeCam;

        public Button removeDeadPlants;

    //    public BoxCollider plant1Box;
    //    public BoxCollider plant2Box;
    //    public BoxCollider plant3Box;

        public GameObject plantToHide;
        public GameObject seedEtcPanal;

        public GameObject plantscanvasTohide;

        public GameObject robotToStopNavmesh;
        public RobotController robCont;
        public RoboGrowPlantManager rgPlantMan;
        public RoboGrowMain rgMain;

        public Renderer arrowRend;

        public bool hasTextBeenSpoken;
        public bool hasSaveHappened;
        public bool textBeenRead;
        public bool progressTextIsShowing;

        public MeshRenderer susanArrowToEnableAfterGettingWrong;
        public MeshRenderer limaArrowToEnableAfterGettingWrong;
        public MeshRenderer daisyArrowToEnableAfterGettingWrong;
        public MeshRenderer radishArrowToEnableAfterGettingWrong;

        public GameObject triggerArrow;
        public GameObject stage1FlowerArrow1;
        public GameObject stage1FlowerArrow2;
        public GameObject stage1FlowerArrow3;
        //  public Camera flowerCam;
        public Camera playerCam;

        public Button progressText;
        public Button progressTextBack;
        public bool savceOnce;

        public int currentStage1FlowerBlackEyedSusanText;

        private void Awake()
        {
            TTSJobotFlower1BlackEyedSusan1.onClick.AddListener(JobotStage1BlackEyedSusanVoiceCommand1);
            TTSJobotFlower1BlackEyedSusan2.onClick.AddListener(JobotStage1BlackEyedSusanVoiceCommand2);
            TTSJobotFlower1BlackEyedSusan3.onClick.AddListener(JobotStage1BlackEyedSusanVoiceCommand3);
            TTSJobotFlowerAssesmentAnswerCorrect.onClick.AddListener(JobotStage1BlackEyedSusanVoiceCommandCorrect);
            TTSJobotFlowerAssesmentAnswerIncorrect.onClick.AddListener(JobotStage1BlackEyedSusanVoiceCommandIncorrect);
            //  currentStage1FlowerBlackEyedSusanText = 0;
            // collectSeeds.onClick.AddListener(RemoveDeadPlants);
            progressText.onClick.AddListener(OnClick);
            progressTextBack.onClick.AddListener(OnClickBack);
        }
        // Start is called before the first frame update
        void Start()
        {
          
            hasTextBeenSpoken = false;
        //    returnToPlayeCam.gameObject.SetActive(false);
        //    collectSeeds.gameObject.SetActive(false);
            removeDeadPlants.gameObject.SetActive(false);

       
            //   flowerCam.enabled = false;
        }

        // Update is called once per frame
        void Update()
        {

            if (currentStage1FlowerBlackEyedSusanText == 1)
            {
                if (!text1Read)
                {
                    //robCont.enabled = true;
                    if (!hasTextBeenSpoken)
                    {

                        textPanal.SetActive(true);
                        hasTextBeenSpoken = true;
                    }
                    if (!textBeenRead)
                    {
                        progressText.gameObject.SetActive(false);
                    }
                    LOLSDK.Instance.SpeakText("stage1Plant1SusanText1");

                    // robCont.enabled = false;
                    jobotIntroStage1FlowerBlackEyedSusan1.gameObject.SetActive(true);
                    jobotIntroStage1FlowerBlackEyedSusan1.enabled = true;
                    jobotIntroStage1FlowerBlackEyedSusan2.gameObject.SetActive(false);
                    jobotIntroStage1FlowerBlackEyedSusan3.gameObject.SetActive(false);
                    jobotFlowerAssesmentAnswerIncorrect.gameObject.SetActive(false);


                    /*
                                        TTSJobotFlower1BlackEyedSusan1.gameObject.SetActive(true);
                                        TTSJobotFlower1BlackEyedSusan2.gameObject.SetActive(false);
                                        TTSJobotFlower1BlackEyedSusan3.gameObject.SetActive(false);

                                        jobotFlowerAssesmentAnswerCorrect.gameObject.SetActive(false);
                                        jobotFlowerAssesmentAnswerIncorrect.gameObject.SetActive(false);

                                        TTSJobotFlowerAssesmentAnswerCorrect.gameObject.SetActive(false);
                                        TTSJobotFlowerAssesmentAnswerIncorrect.gameObject.SetActive(false);
                    */
                    removeDeadPlants.gameObject.SetActive(false);
                    if (!progressTextIsShowing)
                    { // 3 second delay
                        StartCoroutine(DelayProgressButtonVar2());
                        progressTextIsShowing = true;
                    }
                    text1Read = true;
                }
             
            }

            if (currentStage1FlowerBlackEyedSusanText == 2)
            {
                if (!text2Read)
                {
                    if (!textBeenRead)
                    {
                        progressText.gameObject.SetActive(false);
                    }
                    //  pondFrogspawnIntro2
                    // robCont.enabled = false;
                    jobotIntroStage1FlowerBlackEyedSusan1.gameObject.SetActive(false);
                    jobotIntroStage1FlowerBlackEyedSusan2.gameObject.SetActive(true);
                    jobotIntroStage1FlowerBlackEyedSusan2.enabled = true;
                    jobotIntroStage1FlowerBlackEyedSusan3.gameObject.SetActive(false);
                    LOLSDK.Instance.SpeakText("stage1Plant1SusanText1a");

                    // robCont.enabled = false;
                    robCont.NewNavmeshStop();
                
                    // robCont.enabled = true;
                    progressTextBack.gameObject.SetActive(true);
                    robotToStopNavmesh.GetComponent<NavMeshAgent>().isStopped = false;

                    if (!progressTextIsShowing)
                    { // 3 second delay
                        StartCoroutine(DelayProgressButtonVar2());
                        progressTextIsShowing = true;
                    }
                    text2Read = true;
                }
               
            }
            if (currentStage1FlowerBlackEyedSusanText == 3)
            {
                if (!text3Read)
                {
                    //  pondFrogspawnIntro2
                    // robCont.enabled = false;
                    removeDeadPlants.onClick.AddListener(RemoveDeadPlants);
                    wrongAnswer.onClick.AddListener(WrongAsnwer);
                    wrongAnswer2.onClick.AddListener(WrongAsnwer);
                    jobotIntroStage1FlowerBlackEyedSusan1.gameObject.SetActive(false);
                    jobotIntroStage1FlowerBlackEyedSusan2.gameObject.SetActive(false);
                    jobotIntroStage1FlowerBlackEyedSusan3.gameObject.SetActive(true);
                    jobotIntroStage1FlowerBlackEyedSusan3.enabled = true;
                    // robCont.enabled = false;
                    robCont.NewNavmeshStop();
                   
                    LOLSDK.Instance.SpeakText("stage1Plant1SusanText1b");

                    
                    // robCont.enabled = true;
                    progressText.gameObject.SetActive(false);
                    progressTextBack.gameObject.SetActive(true);
                    removeDeadPlants.gameObject.SetActive(true);
                    robotToStopNavmesh.GetComponent<NavMeshAgent>().isStopped = false;
                    text3Read = true;
                }
                
            }
            if (currentStage1FlowerBlackEyedSusanText == 4)
            {
                if (!text4Read)
                {
                    if (!textBeenRead)
                    {
                        progressText.gameObject.SetActive(false);
                    }
                    LOLSDK.Instance.SpeakText("assesmentSection1AnswerCorrect");
                    textPanal.gameObject.SetActive(true);
                    jobotIntroStage1FlowerBlackEyedSusan3.gameObject.SetActive(false);


                    // robCont.enabled = false;
                    robCont.NewNavmeshStop();
                  

                    jobotFlowerAssesmentAnswerCorrect.gameObject.SetActive(true);
                    jobotFlowerAssesmentAnswerCorrect.enabled = true;
                    jobotFlowerAssesmentAnswerIncorrect.gameObject.SetActive(false);

        
                    // progressText.gameObject.SetActive(false);
                    //  progressTextBack.gameObject.SetActive(false);
                    robotToStopNavmesh.GetComponent<NavMeshAgent>().isStopped = false;
                    //   if (!hasSaveHappened)
                    //   {
                    //      StartCoroutine(CloseBox());
                    //       hasSaveHappened = true;
                    //  }

                    if (!progressTextIsShowing)
                    { // 3 second delay
                        StartCoroutine(DelayProgressButtonVar2());
                        progressTextIsShowing = true;
                    }
                    text4Read = true;
                }
              

            }

          

            if (currentStage1FlowerBlackEyedSusanText == 5)
            {
                if (!text5Read)
                {
                    textPanal.gameObject.SetActive(false);

                    jobotIntroStage1FlowerBlackEyedSusan1.gameObject.SetActive(false);
                    jobotIntroStage1FlowerBlackEyedSusan2.gameObject.SetActive(false);
                    jobotIntroStage1FlowerBlackEyedSusan3.gameObject.SetActive(false);

                    // robCont.enabled = false;
                    // robCont.NewNavmeshStop();
                    TTSJobotFlower1BlackEyedSusan1.gameObject.SetActive(false);
                    TTSJobotFlower1BlackEyedSusan2.gameObject.SetActive(false);
                    TTSJobotFlower1BlackEyedSusan3.gameObject.SetActive(false);
                    LOLSDK.Instance.SpeakText("stage1Plant1SusanText1d");

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
                    if (!savceOnce)
                    {
                        CloseBox();
                        savceOnce = true;
                    }
                    text5Read = true;
                }
              
               
            }

            if (currentStage1FlowerBlackEyedSusanText == 7)
            {
                if (!text6Read)
                {
                    textPanal.gameObject.SetActive(true);

                    LOLSDK.Instance.SpeakText("assesmentSection1AnswerIncorrect");

                    // robCont.enabled = false;
                    //robCont.NewNavmeshStop();

                    jobotIntroStage1FlowerBlackEyedSusan3.gameObject.SetActive(false);
                    jobotFlowerAssesmentAnswerIncorrect.enabled = true;
                    jobotFlowerAssesmentAnswerIncorrect.gameObject.SetActive(true);

                    progressText.gameObject.SetActive(false);
                    progressTextBack.gameObject.SetActive(false);
                    robotToStopNavmesh.GetComponent<NavMeshAgent>().isStopped = false;
                    StartCoroutine(CloseBoxWrong());
                    text6Read = true;
                }
              
            }
        }


        void OnMouseDown()
        {
            robotToStopNavmesh.GetComponent<NavMeshAgent>().isStopped = true;
            robCont.NewNavmeshStop();
            rgMain.MoveCameraToOrganic1SusanPosition();
            //   flowerCam.enabled = true;
            //   returnToPlayeCam.onClick.AddListener(ReturnToPlayerCam);
            //     collectSeeds.onClick.AddListener(CollectSeeds);
            removeDeadPlants.onClick.AddListener(RemoveDeadPlants);
            wrongAnswer.onClick.AddListener(WrongAsnwer);
            wrongAnswer2.onClick.AddListener(WrongAsnwer);
            playerCam.enabled = false;
            robCont.enabled = false;
           // returnToPlayeCam.gameObject.SetActive(true);
       //     collectSeeds.gameObject.SetActive(true);
           // removeDeadPlants.gameObject.SetActive(true);
            Debug.Log("Mouse Clicked");
            textPanal.SetActive(true);
         
            currentStage1FlowerBlackEyedSusanText = 1;
        }

        public void ReturnToPlayerCam()
        {
            robCont.enabled = true;
            //  returnToPlayeCam.gameObject.SetActive(false);
            playerCam.enabled = true;
            rgMain.HideCamera();
            textPanal.gameObject.SetActive(false);
            seedEtcPanal.gameObject.SetActive(false);
        //    collectSeeds.gameObject.SetActive(false);
            removeDeadPlants.gameObject.SetActive(false);
        }

        void OnClick()
        {
            currentStage1FlowerBlackEyedSusanText++;
            hasTextBeenSpoken = false;
            progressTextIsShowing = false;
        }

        void OnClickBack()
        {
            currentStage1FlowerBlackEyedSusanText--;
            text1Read = false;
            text2Read = false;
            text3Read = false;
            text4Read = false;
            text5Read = false;
            text6Read = false;
        }

        public void RemoveDeadPlants()
        {
            hasTextBeenSpoken = false;
            progressTextIsShowing = false;
            if (!waterSusanOnce)
            {
                robCont.enabled = true;
           // plantToHide.SetActive(false);
            removeDeadPlants.gameObject.SetActive(false);
            playerCam.enabled = true;
            rgMain.HideCamera();
            robotToStopNavmesh.GetComponent<NavMeshAgent>().isStopped = false;
            //     collectSeeds.onClick.RemoveListener(CollectSeeds);
            removeDeadPlants.onClick.RemoveListener(RemoveDeadPlants);
        //    collectSeeds.gameObject.SetActive(false);
            removeDeadPlants.gameObject.SetActive(false);
         //   returnToPlayeCam.gameObject.SetActive(false);
            rgPlantMan.removedFlowers++;
            // CollectSeeds();
            currentStage1FlowerBlackEyedSusanText = 4;

                waterSusanOnce = true;
            }

            //  catControl.enabled = true;
        }
        public void WrongAsnwer()
        {
          
                robCont.enabled = true;
                // plantToHide.SetActive(false);
                removeDeadPlants.gameObject.SetActive(false);
                playerCam.enabled = true;
                rgMain.HideCamera();
                removeDeadPlants.onClick.RemoveListener(RemoveDeadPlants);
                wrongAnswer.onClick.RemoveListener(WrongAsnwer);
                wrongAnswer2.onClick.RemoveListener(WrongAsnwer);
                robotToStopNavmesh.GetComponent<NavMeshAgent>().isStopped = false;
                //     collectSeeds.onClick.RemoveListener(CollectSeeds);
                wrongAnswer.onClick.RemoveListener(WrongAsnwer);
                //    collectSeeds.gameObject.SetActive(false);
                wrongAnswer.gameObject.SetActive(false);
                //   returnToPlayeCam.gameObject.SetActive(false);
                // rgPlantMan.removedFlowers++;
                // CollectSeeds();
                currentStage1FlowerBlackEyedSusanText = 7;
                amountOfGuesses++;
            text1Read = false;
            text2Read = false;
            text3Read = false;
            text4Read = false;
            text5Read = false;
            text6Read = false;



            //  catControl.enabled = true;
        }


        public void CollectSeeds()
        {
            currentStage1FlowerBlackEyedSusanText = 4;
           
        }

        void JobotStage1BlackEyedSusanVoiceCommand1()
        {
            LOLSDK.Instance.SpeakText("stage1Plant1SusanText1");
            Debug.Log("stage1Plant1SusanText1 is playing");
        }
       
        void JobotStage1BlackEyedSusanVoiceCommand2()
        {
            LOLSDK.Instance.SpeakText("stage1Plant1SusanText1a");
            Debug.Log("stage1Plant1SusanText1a is playing");
        }

        void JobotStage1BlackEyedSusanVoiceCommand3()
        {
            LOLSDK.Instance.SpeakText("stage1Plant1SusanText1b");
            Debug.Log("stage1Plant1SusanText1b is playing");
        }

        void JobotStage1BlackEyedSusanVoiceCommandCorrect()
        {
            LOLSDK.Instance.SpeakText("assesmentSection1AnswerCorrect");
            Debug.Log("assesmentSection1AnswerCorrect is playing");
        }

        void JobotStage1BlackEyedSusanVoiceCommandIncorrect()
        {
            LOLSDK.Instance.SpeakText("assesmentSection1AnswerIncorrect");
            Debug.Log("assesmentSection1AnswerIncorrect is playing");
        }

        public IEnumerator DelayProgressButtonVar2()
        {
            yield return new WaitForSeconds(2);
            progressText.gameObject.SetActive(true);
            textBeenRead = true;

        }
        public IEnumerator DelayProgressButtonVar1()
        {
            yield return new WaitForSeconds(2);
            progressText.gameObject.SetActive(true);
            textBeenRead = true;

        }

        public void CloseBox()
        {
           
                rgMain.stage1PlantRemovalComplete = true;
                rgMain.SaveStage1TasksComplete();
                rgMain.SaveSeeds();
                plantscanvasTohide.gameObject.SetActive(false);
                currentStage1FlowerBlackEyedSusanText = 0;
            // textPanal.gameObject.SetActive(false);


            //   currentStage1FlowerBlackEyedSusanText = 6;


        }
        public IEnumerator CloseBoxWrong()
        {
            robCont.enabled = true;
            arrowRend.enabled = false;
            susanArrowToEnableAfterGettingWrong.enabled = true;
            limaArrowToEnableAfterGettingWrong.enabled = true;
            daisyArrowToEnableAfterGettingWrong.enabled = true;
            radishArrowToEnableAfterGettingWrong.enabled = true;
           // plant1Box.enabled = false;
           // plant2Box.enabled = false;
          //  plant3Box.enabled = false;
            yield return new WaitForSeconds(3);
            triggerArrow.gameObject.SetActive(false);
            textPanal.gameObject.SetActive(false);
            plantscanvasTohide.gameObject.SetActive(false);
           // plant1Box.enabled = true;
           // plant2Box.enabled = true;
          //  plant3Box.enabled = true;
            currentStage1FlowerBlackEyedSusanText = 0;
            text1Read = false;
            text2Read = false;
            text3Read = false;
            text4Read = false;
            text5Read = false;
            text6Read = false;
        }


    }
   
}

