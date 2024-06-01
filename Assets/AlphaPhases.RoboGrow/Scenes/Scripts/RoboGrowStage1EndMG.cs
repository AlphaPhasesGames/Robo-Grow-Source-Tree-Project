using System.Collections;
using UnityEngine;
using LoLSDK;
using UnityEngine.UI;
using UnityEngine.AI;
using TMPro;

namespace Alpha.Phases.Robo.Grow
{
    public class RoboGrowStage1EndMG : MonoBehaviour
    {
        public RoboGrowMain rgMain; // declare access to RoboGroMain
        public RoboGrowStage1MiniGameStart rgMiniStart;
        //public RobotController robControl;
        public GameObject minigGameLevelToDisable; // Declare gameobject to hide the minigame world when the level is complete -to save on space
        public GameObject overworldMGToShow; // declare gameobject to hold the overworld MG to show when MG is over. This give the feeling that the mini game is there even though its not 
        public GameObject UICanvasToHide; // declare gameobject to hold the camvas to hide when we 
        public GameObject UICanvasToshow;
        public GameObject forceCanvasClosed;


        public GameObject stageLabels;

        public Button eggItemButton;
        public Button larvaItemButton;
        public Button pupaItemButton;
        public Button adultItemButton;


        public bool hasSlot1FilledAlready;
        public bool hasSlot2FilledAlready;
        public bool hasSlot3FilledAlready;
        public bool hasSlot4FilledAlready;

        public bool eggInCorrectPlace;
        public bool larvaInCorrectPlace;
        public bool pupaInCorrectPlace;
        public bool adultInCorrectPlace;

        public bool eggIncorrect;
        public bool larvaIncorrect;
        public bool pupaIncorrect;
        public bool adultIncorrect;

        public bool runWrongAnswerOnce;

        public bool levelComplete;

        public BoxCollider miniGameBoxToDisable;
        public Camera playerCamToEnable;
        public Camera catapillerCamToDisable;
        public CatapillerController catControl;
        public GameObject catapillerPlayerObject;
        public CameraFollowPlayer camFollow;
        public Camera cocoonCam;
        public bool miniGameComplete;
        public bool saveGameOnce;
        public Transform cocoonPosition;
        public Animator cocoonToAppearAniml;

        public RobotController robCont;
        public GameObject robotNavMeshAgentToStop;
        public GameObject textPanalToHide;

       // public AudioSource hoorayAudioSFX:

        public Button TTSMGEndTextButton1;
        public Button TTSMGEndTextButton1a;
        public Button TTSMGEndTextButton1b;
        public Button TTSMGEndTextButtonNotBigEnough;
        public Button TTSMGAssesmentButton;

      
        public bool textBeenRead;
        public bool progressTextIsShowing;

        public TextMeshProUGUI MGEndText;
        public TextMeshProUGUI MGEndText1;
        public TextMeshProUGUI MGEndText2;
        public TextMeshProUGUI MGNotBigEnough;
        public TextMeshProUGUI MGAssesment;

        public bool text1Read;
        public bool text2Read;
        public bool text3Read;
        public bool text4Read;
        public bool text5Read;
        public bool textRead6;
        public Button progressText;
        public Button progressTextBack;

        public int currentStage1TreeText;

        // Start is called before the first frame update
        void Start()
        {
            currentStage1TreeText = 0;
            progressText.onClick.AddListener(OnClick);
            progressTextBack.onClick.AddListener(OnClickBack);

            hasSlot2FilledAlready = true;
            hasSlot3FilledAlready = true;
            hasSlot4FilledAlready = true;
            TTSMGEndTextButton1.onClick.AddListener(JobotStage1EndTree1);
            TTSMGEndTextButton1a.onClick.AddListener(JobotStage1EndTree2);
            TTSMGEndTextButton1b.onClick.AddListener(JobotStage1EndTree3);
            TTSMGEndTextButtonNotBigEnough.onClick.AddListener(JobotStage1EndNotBigEnough);
            TTSMGAssesmentButton.onClick.AddListener(JobotStage1Assess);

            eggItemButton.onClick.AddListener(MoveClickeditemToCorrectplace1);
            larvaItemButton.onClick.AddListener(MoveClickeditem2ToCorrectplace);
            pupaItemButton.onClick.AddListener(MoveClickeditem3ToCorrectplace);
            adultItemButton.onClick.AddListener(MoveClickeditem4ToCorrectplace);

            // HEY ADD IN THE CLIKERS FOR THE NEW STAGES BUTTONS HERE --IMPORTANT! IT WONT WORK IF YOU DONT, YOU TOOL

        }

        // Update is called once per frame
        void Update()
        {
            if (currentStage1TreeText == 1)
            {
                if (!text1Read)
                {
                    stageLabels.gameObject.SetActive(false);
                    LOLSDK.Instance.SpeakText("stage1MiniGameAssesmentSection");

                    eggItemButton.gameObject.SetActive(true);
                    larvaItemButton.gameObject.SetActive(true);
                    pupaItemButton.gameObject.SetActive(true);
                    adultItemButton.gameObject.SetActive(true);


                    progressTextBack.gameObject.SetActive(false);
                    progressText.gameObject.SetActive(false);
                    textPanalToHide.SetActive(true);
                    MGEndText.gameObject.SetActive(false);
                    MGEndText1.gameObject.SetActive(false);
                    MGEndText2.gameObject.SetActive(false);
                    MGAssesment.gameObject.SetActive(true);
                    MGAssesment.enabled = true;

                    TTSMGEndTextButton1.gameObject.SetActive(false);
                    TTSMGEndTextButton1a.gameObject.SetActive(false);
                    TTSMGEndTextButton1b.gameObject.SetActive(false);
                    TTSMGAssesmentButton.gameObject.SetActive(true);
                    MGNotBigEnough.enabled = false;
                    TTSMGEndTextButtonNotBigEnough.gameObject.SetActive(false);
                    text1Read = true;
                }
            }

             if (currentStage1TreeText == 2)
            { 
                if (!text2Read)
                {
                    if (!textBeenRead)
                    {
                        progressText.gameObject.SetActive(false);
                    }
                    LOLSDK.Instance.SpeakText("stage1MiniGameCompleteInfo");

                    progressTextBack.gameObject.SetActive(false);
                    textPanalToHide.SetActive(true);
                    MGEndText.gameObject.SetActive(true);
                    MGEndText1.gameObject.SetActive(false);
                    MGAssesment.gameObject.SetActive(false);

                    TTSMGAssesmentButton.gameObject.SetActive(false);
                    TTSMGEndTextButton1.gameObject.SetActive(true);
                    TTSMGEndTextButton1a.gameObject.SetActive(false);
                    TTSMGEndTextButton1b.gameObject.SetActive(false);
                    cocoonToAppearAniml.SetBool("mg1LevelOver", true);
;

                    MGNotBigEnough.enabled = false;
                    TTSMGEndTextButtonNotBigEnough.gameObject.SetActive(false);
                    if (!progressTextIsShowing)
                    { // 3 second delay
                        StartCoroutine(DelayProgressButtonVar1());
                        progressTextIsShowing = true;
                    }
                    text2Read = true;
                }
            }

            if (currentStage1TreeText == 3)
            {
                if (!text3Read)
                {
                    if (!textBeenRead)
                    {
                        progressText.gameObject.SetActive(false);
                    }
                    progressTextBack.gameObject.SetActive(true);
                    LOLSDK.Instance.SpeakText("stage1MiniGameCompleteInfoa");

                    MGAssesment.enabled = false;
                    TTSMGAssesmentButton.gameObject.SetActive(false);
                    MGEndText.gameObject.SetActive(false);
                    MGEndText1.gameObject.SetActive(true);
                    MGEndText2.gameObject.SetActive(false);

                    TTSMGEndTextButton1.gameObject.SetActive(false);
                    TTSMGEndTextButton1a.gameObject.SetActive(true);
                    TTSMGEndTextButton1b.gameObject.SetActive(false);

                    MGNotBigEnough.enabled = false;
                    TTSMGEndTextButtonNotBigEnough.gameObject.SetActive(false);
                    if (!progressTextIsShowing)
                    { // 3 second delay
                        StartCoroutine(DelayProgressButtonVar2());
                        progressTextIsShowing = true;
                    }

                    text3Read = true;
                }
             
            }

            if (currentStage1TreeText == 4)
            {
                if (!text4Read)
                {
                    if (!textBeenRead)
                    {
                        progressText.gameObject.SetActive(false);
                    }
                    LOLSDK.Instance.SpeakText("stage1MiniGameCompleteInfob");

                    MGAssesment.enabled = false;
                    TTSMGAssesmentButton.gameObject.SetActive(false);
                    MGAssesment.gameObject.SetActive(false);
                    MGEndText.gameObject.SetActive(false);
                    MGEndText1.gameObject.SetActive(false);
                    MGEndText2.gameObject.SetActive(true);

                    TTSMGEndTextButton1.gameObject.SetActive(false);
                    TTSMGEndTextButton1a.gameObject.SetActive(false);
                    TTSMGEndTextButton1b.gameObject.SetActive(true);

                    MGNotBigEnough.enabled = false;
                    TTSMGEndTextButtonNotBigEnough.gameObject.SetActive(false);
                    progressText.gameObject.SetActive(false);
                    StartCoroutine(ShowCocoonGrowing());
                    if (!progressTextIsShowing)
                    { // 3 second delay
                        StartCoroutine(DelayProgressButtonVar1());
                        progressTextIsShowing = true;
                    }
                    text4Read = true;
                }
  
            }

            if (currentStage1TreeText == 5)
            {
                if (!text5Read)
                {
                    if (!textBeenRead)
                    {
                        progressText.gameObject.SetActive(false);
                    }




                    textPanalToHide.gameObject.SetActive(false);
                    MGAssesment.enabled = false;
                    TTSMGAssesmentButton.gameObject.SetActive(false);
                    MGAssesment.gameObject.SetActive(false);
                    textPanalToHide.SetActive(false);
                    MGEndText.gameObject.SetActive(false);
                    MGEndText1.gameObject.SetActive(false);
                    MGEndText2.gameObject.SetActive(false);

                    TTSMGEndTextButton1.gameObject.SetActive(false);
                    TTSMGEndTextButton1a.gameObject.SetActive(false);
                    TTSMGEndTextButton1b.gameObject.SetActive(false);
                    textPanalToHide.SetActive(false);

                    MGNotBigEnough.enabled = false;
                    TTSMGEndTextButtonNotBigEnough.gameObject.SetActive(false);

                    // progressText.gameObject.SetActive(true);
                    text5Read = true; 
                }
            }

            if (currentStage1TreeText == 6)
            {
                if (!textRead6)
                {
                    MGAssesment.enabled = false;
                    TTSMGAssesmentButton.gameObject.SetActive(false);
                    MGAssesment.gameObject.SetActive(false);
                    textPanalToHide.SetActive(true);
                    MGEndText.gameObject.SetActive(false);
                    MGEndText1.gameObject.SetActive(false);
                    MGEndText2.gameObject.SetActive(false);
                    LOLSDK.Instance.SpeakText("stage1MiniGameInfoNotBigEnough");



                    TTSMGEndTextButton1.gameObject.SetActive(false);
                    TTSMGEndTextButton1a.gameObject.SetActive(false);
                    TTSMGEndTextButton1b.gameObject.SetActive(false);

                    MGNotBigEnough.enabled = true;
                    TTSMGEndTextButtonNotBigEnough.gameObject.SetActive(true);
                    StartCoroutine(MoveTextOn());

                    textRead6 = true;
                }
               


            }


           


            if (!levelComplete)
            {
                if(eggInCorrectPlace && larvaInCorrectPlace && pupaInCorrectPlace && adultInCorrectPlace)
                {
                    currentStage1TreeText = 2;
                    levelComplete = true;
                }
            }
            /*
                        if(hasSlot1FilledAlready && eggInCorrectPlace)
                        {
                            eggInCorrectPlace = true;
                        }

                        if(!hasSlot2FilledAlready && !larvaInCorrectPlace)
                        {
                            larvaIncorrect = true;
                        }

                        if(!hasSlot3FilledAlready && !pupaInCorrectPlace)
                        {
                            pupaIncorrect = true;

                        }

                        if(!hasSlot4FilledAlready && !adultInCorrectPlace)
                        {
                            adultIncorrect = true;
                        }
                        if (!runWrongAnswerOnce) 
                        { 

                        }
            */
            if (eggIncorrect)
                {
                    catapillerCamToDisable.enabled = true;
                    cocoonCam.enabled = false;
                // UICanvasToHide.gameObject.SetActive(false);
               StartCoroutine(rgMiniStart.IncorrectGuess());
                rgMiniStart.playerGuessedIncorrectAlready = false;
                   currentStage1TreeText = 6;
                eggIncorrect = false;
                    catControl.enabled = false;
                    catapillerPlayerObject.transform.localPosition = new Vector3(1.31335f, 0.1498f, 0.73617f);
                    runWrongAnswerOnce = true;
                    eggItemButton.transform.localPosition = new Vector3(551, -681.624939f, 0);
                    larvaItemButton.transform.localPosition = new Vector3(171.434708f, -681.624939f, 0);
                    pupaItemButton.transform.localPosition = new Vector3(-208.673553f, -681.624939f, 0);
                    adultItemButton.transform.localPosition = new Vector3(-597.355652f, -681.624939f, 0);
                    eggInCorrectPlace = false;
                    larvaInCorrectPlace = false;
                    pupaInCorrectPlace = false;
                    adultInCorrectPlace = false;
                    hasSlot1FilledAlready = false;
                    hasSlot2FilledAlready = true;
                    hasSlot3FilledAlready = true;
                    hasSlot4FilledAlready = true;
                }
        
                if (larvaIncorrect)
                {
                    catapillerCamToDisable.enabled = true;
                    cocoonCam.enabled = false;
                // UICanvasToHide.gameObject.SetActive(false);
                StartCoroutine(rgMiniStart.IncorrectGuess());
                rgMiniStart.playerGuessedIncorrectAlready = false;
                currentStage1TreeText = 6;
                    larvaIncorrect = false;
                    catControl.enabled = false;
                    catapillerPlayerObject.transform.localPosition = new Vector3(1.31335f, 0.1498f, 0.73617f);
                    runWrongAnswerOnce = true;
                eggItemButton.transform.localPosition = new Vector3(551, -681.624939f, 0);
                larvaItemButton.transform.localPosition = new Vector3(171.434708f, -681.624939f, 0);
                pupaItemButton.transform.localPosition = new Vector3(-208.673553f, -681.624939f, 0);
                adultItemButton.transform.localPosition = new Vector3(-597.355652f, -681.624939f, 0);
                eggInCorrectPlace = false;
                    larvaInCorrectPlace = false;
                    pupaInCorrectPlace = false;
                    adultInCorrectPlace = false;
                    hasSlot1FilledAlready = false;
                    hasSlot2FilledAlready = true;
                    hasSlot3FilledAlready = true;
                    hasSlot4FilledAlready = true;
                }

                else if(pupaIncorrect)
                {
                    catapillerCamToDisable.enabled = true;
                    cocoonCam.enabled = false;
                // UICanvasToHide.gameObject.SetActive(false);
                StartCoroutine(rgMiniStart.IncorrectGuess());
                rgMiniStart.playerGuessedIncorrectAlready = false;
                currentStage1TreeText = 6;
                pupaIncorrect = false;
                    catControl.enabled = false;
                    catapillerPlayerObject.transform.localPosition = new Vector3(1.31335f, 0.1498f, 0.73617f);
                    runWrongAnswerOnce = true;
                eggItemButton.transform.localPosition = new Vector3(551, -681.624939f, 0);
                larvaItemButton.transform.localPosition = new Vector3(171.434708f, -681.624939f, 0);
                pupaItemButton.transform.localPosition = new Vector3(-208.673553f, -681.624939f, 0);
                adultItemButton.transform.localPosition = new Vector3(-597.355652f, -681.624939f, 0);
                eggInCorrectPlace = false;
                    larvaInCorrectPlace = false;
                    pupaInCorrectPlace = false;
                    adultInCorrectPlace = false;
                    hasSlot1FilledAlready = false;
                    hasSlot2FilledAlready = true;
                    hasSlot3FilledAlready = true;
                    hasSlot4FilledAlready = true;
                }

                else  if (adultIncorrect)
                {
                    catapillerCamToDisable.enabled = true;
                    cocoonCam.enabled = false;
                    UICanvasToHide.gameObject.SetActive(false);
                StartCoroutine(rgMiniStart.IncorrectGuess());
                rgMiniStart.playerGuessedIncorrectAlready = false;
                currentStage1TreeText = 6;
                adultIncorrect = false;
                    catControl.enabled = false;
                    catapillerPlayerObject.transform.localPosition = new Vector3(1.31335f, 0.1498f, 0.73617f);
                    runWrongAnswerOnce = true;
                eggItemButton.transform.localPosition = new Vector3(551, -681.624939f, 0);
                larvaItemButton.transform.localPosition = new Vector3(171.434708f, -681.624939f, 0);
                pupaItemButton.transform.localPosition = new Vector3(-208.673553f, -681.624939f, 0);
                adultItemButton.transform.localPosition = new Vector3(-597.355652f, -681.624939f, 0);
                eggInCorrectPlace = false;
                    larvaInCorrectPlace = false;
                    pupaInCorrectPlace = false;
                    adultInCorrectPlace = false;
                    hasSlot1FilledAlready = false;
                    hasSlot2FilledAlready = true;
                    hasSlot3FilledAlready = true;
                    hasSlot4FilledAlready = true;
                }
            }

             
              
            
            

            /* if(eggIncorrect && larvaIncorrect&& pupaIncorrect && adultIncorrect)
             {
                 catapillerCamToDisable.enabled = true;
                 cocoonCam.enabled = false;
                 eggIncorrect = false;
                 larvaIncorrect = false;
                 pupaIncorrect = false;
                 adultIncorrect = false;
                 textPanalToHide.gameObject.SetActive(false);
           }*/

        
        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Catapiller"))
            {
                if(catControl.allCollectablesCollected)
                {
                    catapillerCamToDisable.enabled = false;
                   
                    currentStage1TreeText = 1;
                    text1Read = false;
                    text2Read = false;
                    cocoonCam.enabled = true;
                    runWrongAnswerOnce = false;
                }

                if (!catControl.allCollectablesCollected)
                {
                   
                    currentStage1TreeText = 5;

                }

            }
        }

        public IEnumerator ShowCocoonGrowing()
        {
           // robControl.enabled = true;
            yield return new WaitForSeconds(5);
            UICanvasToHide.SetActive(false); // this hides the minigame canvas
            UICanvasToshow.SetActive(true); // this enables the main game canvas
            cocoonCam.enabled = false; // disable the cocoon cam
            rgMain.task1TextUITick2.SetActive(true); // show tick on UI task list
            playerCamToEnable.enabled = true; // enable the player cam so we can move on with the level
             catControl.enabled = false; // disable the catapiller controller - might not be needed as the whole level is disables at this point
           
            catapillerCamToDisable.enabled = false; // disable the catapoller cam

            minigGameLevelToDisable.gameObject.SetActive(false); // disaable minigame level in main overworld
            overworldMGToShow.SetActive(true); // show the faux minigame level on the main overworld
          
            miniGameBoxToDisable.enabled = false; // disable minigame trigger box to stop player playing again
            camFollow.camFollowTree = false; // set cam to follow as false in camera controller
            forceCanvasClosed.SetActive(false);
            if (!saveGameOnce)
            {
                rgMain.stage1MinigameComplete = true; // set stage1MinigameComplete value in robogrowmain to true 
                rgMain.SaveStage1MiniGameComplete(); // call save minigaem complete function
                saveGameOnce = true;
                robotNavMeshAgentToStop.GetComponent<NavMeshAgent>().isStopped = false;
                // hoorayAudioSFX.Play();
            }

        }

        public IEnumerator MoveTextOn()
        {
            yield return new WaitForSeconds(3);
            currentStage1TreeText = 6;
            textRead6 = false;
        }

        void OnClick()
        {
            currentStage1TreeText++;
            textBeenRead = false;
            progressTextIsShowing = false;
        }

        void OnClickBack()
        {
            currentStage1TreeText--;
            text1Read = false;
            text2Read = false;
            text3Read = false;
            text4Read = false;
            text5Read = false;

        }

        void JobotStage1EndTree1()
        {
            LOLSDK.Instance.SpeakText("stage1MiniGameCompleteInfo");
        }

        void JobotStage1EndTree2()
        {
            LOLSDK.Instance.SpeakText("stage1MiniGameCompleteInfoa");
        }

        void JobotStage1EndTree3()
        {
            LOLSDK.Instance.SpeakText("stage1MiniGameCompleteInfob");
        }

        void JobotStage1EndNotBigEnough()
        {
            LOLSDK.Instance.SpeakText("stage1MiniGameInfoNotBigEnough");
        }

        void JobotStage1Assess()
        {
            LOLSDK.Instance.SpeakText("stage1MiniGameAssesmentSection");
        }
        
        void MoveClickeditemToCorrectplace1()
        {
            if (!hasSlot1FilledAlready)
            {
                eggItemButton.transform.localPosition = new Vector2(-597, -495);
                hasSlot1FilledAlready = true;
                hasSlot2FilledAlready = false;
                eggInCorrectPlace = true;
               // eggIncorrect = false;
                Debug.Log("Egg is in the right place");
            }

            else if (!hasSlot2FilledAlready)
            {
                eggItemButton.transform.localPosition = new Vector2(-211, -495);
                hasSlot2FilledAlready = true;
                hasSlot3FilledAlready = false;
                eggIncorrect = true;
            }

            else if (!hasSlot3FilledAlready)
            {
                eggItemButton.transform.localPosition = new Vector2(165, -495);
                hasSlot3FilledAlready = true;
                hasSlot4FilledAlready = false;
                eggIncorrect = true;
            }

            else if (!hasSlot4FilledAlready)
            {
                eggItemButton.transform.localPosition = new Vector2(554, -495);
                hasSlot4FilledAlready = true;
                eggIncorrect = true;
            }
        }

        void MoveClickeditem2ToCorrectplace()
        {
            if (!hasSlot1FilledAlready)
            {
                larvaItemButton.transform.localPosition = new Vector2(-597, -495);
                hasSlot1FilledAlready = true;
                hasSlot2FilledAlready = false;
                larvaIncorrect = true;
            }

            else if (!hasSlot2FilledAlready)
            {
                larvaItemButton.transform.localPosition = new Vector2(-211, -495);
                hasSlot2FilledAlready = true;
                hasSlot3FilledAlready = false;
                larvaInCorrectPlace = true;
            }

            else if (!hasSlot3FilledAlready)
            {
                larvaItemButton.transform.localPosition = new Vector2(165, -495);
                hasSlot3FilledAlready = true;
                hasSlot4FilledAlready = false;
                larvaIncorrect = true;
                Debug.Log("larva is in the right place");
            }

            else if (!hasSlot4FilledAlready)
            {
                larvaItemButton.transform.localPosition = new Vector2(554, -495);
                hasSlot4FilledAlready = true;
                larvaIncorrect = true;
            }
        }

        void MoveClickeditem3ToCorrectplace()
        {
            if (!hasSlot1FilledAlready)
            {
                pupaItemButton.transform.localPosition = new Vector2(-597, -495);
                hasSlot1FilledAlready = true;
                hasSlot2FilledAlready = false;
                pupaIncorrect = true;
            }

            else if (!hasSlot2FilledAlready)
            {
                pupaItemButton.transform.localPosition = new Vector2(-211, -495);
                hasSlot2FilledAlready = true;
                hasSlot3FilledAlready = false;
                pupaIncorrect = true;
                Debug.Log("Pupa is in the right place");
            }

            else if (!hasSlot3FilledAlready)
            {
                pupaItemButton.transform.localPosition = new Vector2(165, -495);
                hasSlot3FilledAlready = true;
                hasSlot4FilledAlready = false;
                pupaInCorrectPlace = true;

            }

            else if (!hasSlot4FilledAlready)
            {
                pupaItemButton.transform.localPosition = new Vector2(554, -495);
                hasSlot4FilledAlready = true;
                pupaIncorrect = true;
            }
        }

        void MoveClickeditem4ToCorrectplace()
        {
            if (!hasSlot1FilledAlready)
            {
                adultItemButton.transform.localPosition = new Vector2(-597, -495);
                hasSlot1FilledAlready = true;
                hasSlot2FilledAlready = false;
                adultIncorrect = true;
            }

            else if (!hasSlot2FilledAlready)
            {
                adultItemButton.transform.localPosition = new Vector2(-211, -495);
                hasSlot2FilledAlready = true;
                hasSlot3FilledAlready = false;
                adultIncorrect = true;
            }

            else if (!hasSlot3FilledAlready)
            {
                adultItemButton.transform.localPosition = new Vector2(165, -495);
                hasSlot3FilledAlready = true;
                hasSlot4FilledAlready = false;
                adultIncorrect = true;
            }

            else if (!hasSlot4FilledAlready)
            {
                adultItemButton.transform.localPosition = new Vector2(554, -495);
                hasSlot4FilledAlready = true;
                adultInCorrectPlace = true;
                Debug.Log("Adult is in the right place");
            }
        }

        public IEnumerator DelayProgressButton()
        {
            yield return new WaitForSeconds(3);
            progressText.gameObject.SetActive(true);
            textBeenRead = true;

        }

        public IEnumerator DelayProgressButtonVar2()
        {
            yield return new WaitForSeconds(2);
            progressText.gameObject.SetActive(true);
            textBeenRead = true;

        }

        public IEnumerator DelayProgressButtonVar1()
        {
            yield return new WaitForSeconds(1);
            progressText.gameObject.SetActive(true);
            textBeenRead = true;

        }
    }
}
