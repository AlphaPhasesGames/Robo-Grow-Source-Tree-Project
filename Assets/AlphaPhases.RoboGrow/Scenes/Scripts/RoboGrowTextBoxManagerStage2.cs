using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using LoLSDK;
namespace Alpha.Phases.Robo.Grow
{
    // This is the text manager for stage 1 of RoboGrow

    public class RoboGrowTextBoxManagerStage2 : MonoBehaviour
    {
        public RoboGrowMain rgMainData;
        public GameObject textPanalToHide;

        public GameObject robotToHide;
        public GameObject playerRobotToShow;

        public RobotController robotControl;
        public CameraFollowPlayer camFollow;
        //public CameraFollowPlayerStage2 camFollowStage2;
        public GameObject seedPrompt;
        public Animator seedPromptAnim;

        public GameObject besSeedButton;
        public GameObject limaSeedButton;
        public GameObject daisySeedButton;
        public GameObject radishSeedButton;

        public GameObject stage2Objects;

        public Button help;
        public Button tasks;

        public Animator camZoomOutAnim;
        public Animator robotAnim;
        public Animator doorAnim;
        public GameObject seedButton;
        public BoxCollider susan1plantBoxToDisable;
        public BoxCollider susan2plantBoxToDisable;
        public BoxCollider limaBean1plantBoxToDisable;
        public BoxCollider limaBean2plantBoxToDisable;
        public BoxCollider daisy1plantBoxToDisable;
        public BoxCollider daisy2plantBoxToDisable;
        public BoxCollider radish1plantBoxToDisable;
        public BoxCollider radish2plantBoxToDisable;

        public GameObject hint6;

        public Button resetplants;

        public Button forwardButtonToDisable;
        public GameObject setPeicesToDisable;
        public bool introReadyToBeCompleted;
        public Camera maincameraToDisable;
        public GameObject playerCameraToEnable;

        //public Camera robotPlayerCam;
        //public Camera camToDisable;

        public BoxCollider stage2EndToDisable;

        public bool text1Read1;
        public bool text1Read2;
        public bool text1Read3;
        public bool text1Read4;
        public bool text1Read5;
        public bool text1Read6;
        public bool text1Read7;
        public bool text1Read8;
        public bool text1Read9;
        public bool text1Read10;
        public bool text1Read11;
        public bool text1Read12;
        public bool text1Read13;
        public bool text1Read14;
        public bool text1Read15;
        public bool text1Read16;
        public bool text1Read17;
        public bool text1Read18;




        public bool textBeenRead;
        public bool progressTextIsShowing;

        public Button TTSJobot1;
        public Button TTSJobot2;
      //  public Button TTSJobot3;
        public Button TTSJobot4;
        public Button TTSJobot5;
      //  public Button TTSJobot6;
        public Button TTSJobot7;
        public Button TTSJobot8;
        public Button TTSJobot9;
        public Button TTSJobot10;
        public Button TTSJobotPlantSeed1;
        public Button TTSJobotPlantSeed2;
        public Button TTSJobotPlantSeed3;
     //   public Button TTSJobotPlantSeed4;
     //   public Button TTSJobotPlantSeed5;
        public Button TTSJobotPlantSeed6;
        public Button TTSSeedsComplete;
        public Button TTSseedsWateredComplete;
        public Button TTSStage2Complete;

        public TextMeshProUGUI jobotIntroStage1Section1;
        public TextMeshProUGUI jobotIntroStage1Section1a;
       // public TextMeshProUGUI jobotIntroStage1Section1b;
        public TextMeshProUGUI jobotIntroStage1Section1c;
        public TextMeshProUGUI jobotIntroStage1Section1d;
      //  public TextMeshProUGUI jobotIntroStage1Section1e;
        public TextMeshProUGUI jobotIntroStage1Section1f;
        public TextMeshProUGUI jobotIntroStage1Section1g;
        public TextMeshProUGUI jobotIntroStage1Section1h;
        public TextMeshProUGUI jobotIntroStage1Section1i;
        public TextMeshProUGUI jobotStage2PlantSeed;
        public TextMeshProUGUI jobotStage2PlantSeeda;
        public TextMeshProUGUI jobotStage2PlantSeedb;
      //  public TextMeshProUGUI jobotStage2PlantSeedc;
      //  public TextMeshProUGUI jobotStage2PlantSeedd;
        public TextMeshProUGUI jobotStage2PlantSeede;
        public TextMeshProUGUI jobotSeedsPlanted;
        public TextMeshProUGUI jobotSeedsWatered;
        public TextMeshProUGUI stage2Complete;

        public Button progressText;
        public Button progressTextBack;

        public int currentStageOfText;

        private void Awake()
        {
            currentStageOfText = 0;
            progressText.onClick.AddListener(OnClick);
            progressTextBack.onClick.AddListener(OnClickBack);
            TTSJobot1.onClick.AddListener(JobotStage2Section1);
            TTSJobot2.onClick.AddListener(JobotStage2Section1a);
         //   TTSJobot3.onClick.AddListener(JobotStage2Section1b);
            TTSJobot4.onClick.AddListener(JobotStage2Section1c);
            TTSJobot5.onClick.AddListener(JobotStage2Section1d);
          //  TTSJobot6.onClick.AddListener(JobotStage2Section1e);
            TTSJobot7.onClick.AddListener(JobotStage2Section1f);
            TTSJobot8.onClick.AddListener(JobotStage2Section1g);
            TTSJobot9.onClick.AddListener(JobotStage2Section1h);
            TTSJobot10.onClick.AddListener(JobotStage2Section1i);
            TTSJobotPlantSeed1.onClick.AddListener(JobotStage2Section2);
            TTSJobotPlantSeed2.onClick.AddListener(JobotStage2Section2a);
            TTSJobotPlantSeed3.onClick.AddListener(JobotStage2Section2b);
         //   TTSJobotPlantSeed4.onClick.AddListener(JobotStage2Section2c);
         //   TTSJobotPlantSeed5.onClick.AddListener(JobotStage2Section2d);
            TTSJobotPlantSeed6.onClick.AddListener(JobotStage2Section2e);
            TTSSeedsComplete.onClick.AddListener(JobotSeedsAllPlanted);
            TTSseedsWateredComplete.onClick.AddListener(JobotSeedsAllWatered);
            TTSStage2Complete.onClick.AddListener(JobotStage2Complete);
        }
        // Start is called before the first frame update
        void Start()
        {
                
                robotControl.enabled = false;

            stage2Complete.gameObject.SetActive(false);

        }

        // Update is called once per frame
        void Update()
        {

        
            //  jobotIntroStage1
            if (currentStageOfText == 1)
            {
                if (!text1Read1)
                {
                    if (!textBeenRead)
                    {
                        progressText.gameObject.SetActive(false);
                    }
                    stage2Objects.gameObject.SetActive(true);
                    textPanalToHide.SetActive(true);
                    jobotIntroStage1Section1.gameObject.SetActive(true);
                    jobotIntroStage1Section1a.gameObject.SetActive(false);

                    LOLSDK.Instance.SpeakText("jobotIntroStage2");


                    progressTextBack.gameObject.SetActive(false);
                    jobotStage2PlantSeede.enabled = false;
                    jobotSeedsPlanted.enabled = false;
                    jobotSeedsWatered.enabled = false;
                    hint6.gameObject.SetActive(true);
                    setPeicesToDisable.SetActive(false);
                    seedButton.gameObject.SetActive(true);
                    susan1plantBoxToDisable.enabled = true;
                    susan2plantBoxToDisable.enabled = true;
                    limaBean1plantBoxToDisable.enabled = true;
                    limaBean2plantBoxToDisable.enabled = true;
                    daisy1plantBoxToDisable.enabled = true;
                    daisy2plantBoxToDisable.enabled = true;
                    radish1plantBoxToDisable.enabled = true;
                    radish2plantBoxToDisable.enabled = true;

                    if (!progressTextIsShowing)
                    { // 3 second delay
                        StartCoroutine(DelayProgressButtonVar1());
                        progressTextIsShowing = true;
                    }
                    text1Read1 = true;
                }
               

            }

            if (currentStageOfText == 2)
            {
                if (!text1Read2)
                {
                    //  jobotIntroStage1a
                    if (!textBeenRead)
                    {
                        progressText.gameObject.SetActive(false);
                    }
                    progressTextBack.gameObject.SetActive(true);

                    LOLSDK.Instance.SpeakText("jobotIntroStage2a");


                    jobotIntroStage1Section1.gameObject.SetActive(false);
                    jobotIntroStage1Section1a.gameObject.SetActive(true);
                    jobotIntroStage1Section1c.gameObject.SetActive(false);

                    doorAnim.SetBool("closeDoor", true);
                    progressTextBack.gameObject.SetActive(true);
                    if (!progressTextIsShowing)
                    { // 3 second delay
                        StartCoroutine(DelayProgressButton());
                        progressTextIsShowing = true;
                    }
                    text1Read2 = true;
                }
            }
            
           
            if (currentStageOfText == 3)
            {
                if (!text1Read3)
                {
                    if (!textBeenRead)
                    {
                        progressText.gameObject.SetActive(false);
                    }
                    LOLSDK.Instance.SpeakText("jobotIntroStage2c");

                    jobotIntroStage1Section1a.gameObject.SetActive(false);
                    jobotIntroStage1Section1c.gameObject.SetActive(true);
                    jobotIntroStage1Section1d.gameObject.SetActive(false);

                    if (!progressTextIsShowing)
                    { // 3 second delay
                        StartCoroutine(DelayProgressButtonVar2());
                        progressTextIsShowing = true;
                    }
                    text1Read3 = true;
                }
              
            }

            if (currentStageOfText == 4)
            {
                if (!text1Read4)
                {
                    if (!textBeenRead)
                    {
                        progressText.gameObject.SetActive(false);
                    }
                    LOLSDK.Instance.SpeakText("jobotIntroStage2d");

                    jobotIntroStage1Section1c.gameObject.SetActive(false);
                    jobotIntroStage1Section1d.gameObject.SetActive(true);
                    jobotIntroStage1Section1f.gameObject.SetActive(false);
                    if (!progressTextIsShowing)
                    { // 3 second delay
                        StartCoroutine(DelayProgressButtonVar2());
                        progressTextIsShowing = true;
                    }
                    text1Read4 = true;
                }
              
            }
          
            if (currentStageOfText == 5)
            {
                if (!text1Read5)
                {
                    if (!textBeenRead)
                    {
                        progressText.gameObject.SetActive(false);
                    }
                    LOLSDK.Instance.SpeakText("jobotIntroStage2f");

                    jobotIntroStage1Section1d.gameObject.SetActive(false);
                    jobotIntroStage1Section1f.gameObject.SetActive(true);
                    jobotIntroStage1Section1g.gameObject.SetActive(false);
                    if (!progressTextIsShowing)
                    { // 3 second delay
                        StartCoroutine(DelayProgressButtonVar2());
                        progressTextIsShowing = true;
                    }
                    text1Read5 = true;
                }
            }


            if (currentStageOfText == 6)
            {
                if (!text1Read6)
                {
                    if (!textBeenRead)
                    {
                        progressText.gameObject.SetActive(false);
                    }
                    LOLSDK.Instance.SpeakText("jobotIntroStage2g");

                    jobotIntroStage1Section1f.gameObject.SetActive(false);
                    jobotIntroStage1Section1g.gameObject.SetActive(true);
                    jobotIntroStage1Section1h.gameObject.SetActive(false);
                    if (!progressTextIsShowing)
                    { // 3 second delay
                        StartCoroutine(DelayProgressButtonVar1());
                        progressTextIsShowing = true;
                    }
                    text1Read6 = true;
                }
            }

            if (currentStageOfText == 7)
            {
                if (!text1Read7)
                {
                    if (!textBeenRead)
                    {
                        progressText.gameObject.SetActive(false);
                    }
                    LOLSDK.Instance.SpeakText("jobotIntroStage2h");

                    jobotIntroStage1Section1g.gameObject.SetActive(false);
                    jobotIntroStage1Section1h.gameObject.SetActive(true);
                    jobotIntroStage1Section1i.gameObject.SetActive(false);
                    if (!progressTextIsShowing)
                    { // 3 second delay
                        StartCoroutine(DelayProgressButton());
                        progressTextIsShowing = true;
                    }
                    text1Read7 = true;
                }
            }
            

            if (currentStageOfText == 8)
            { //  jobotIntroStage1i
                if (!text1Read8)
                {
                    if (!textBeenRead)
                    {
                        progressText.gameObject.SetActive(false);
                    }
                    LOLSDK.Instance.SpeakText("jobotIntroStage2i");

                    jobotIntroStage1Section1h.gameObject.SetActive(false);
                    jobotIntroStage1Section1i.gameObject.SetActive(true);
                    jobotStage2PlantSeed.gameObject.SetActive(false);

                    doorAnim.SetBool("doorNeedsToBeOpen", false);
                    doorAnim.SetBool("closeDoor", false);
                    doorAnim.SetTrigger("resetDoorValues");
                    if (!progressTextIsShowing)
                    { // 3 second delay
                        StartCoroutine(DelayProgressButtonVar1());
                        progressTextIsShowing = true;
                    }
                    text1Read8 = true;
                }
     
            }


            if (currentStageOfText == 9)
            { //  jobotIntroStage1i
              // cameraToEnable.SetActive(false);
                if (!text1Read9)
                {
                    if (!textBeenRead)
                    {
                        progressText.gameObject.SetActive(false);
                    }
               
                    jobotIntroStage1Section1h.gameObject.SetActive(false);
                    jobotIntroStage1Section1i.gameObject.SetActive(true);
                    jobotStage2PlantSeed.gameObject.SetActive(false);

                    camZoomOutAnim.keepAnimatorControllerStateOnDisable = false;
                    // camZoomOutAnim.enabled = false;
                    if (!progressTextIsShowing)
                    { // 3 second delay
                        StartCoroutine(DelayProgressButtonVar2());
                        progressTextIsShowing = true;
                    }
                    text1Read9 = true;
                }


            }

            if (currentStageOfText == 10)
            { //  jobotIntroStage1i
                if (!text1Read10)
                {
                    textPanalToHide.SetActive(true);
                    if (!textBeenRead)
                    {
                        progressText.gameObject.SetActive(false);
                    }
                    // camZoomOutAnim.enabled = true;
                    resetplants.gameObject.SetActive(true);
                    LOLSDK.Instance.SpeakText("jobotStage2PlantSeed");

                    jobotIntroStage1Section1i.gameObject.SetActive(false);
                    jobotStage2PlantSeed.gameObject.SetActive(true);
                    jobotStage2PlantSeeda.gameObject.SetActive(false);

                    camZoomOutAnim.SetBool("startStage1PlayerCamZoomOut", true);
                    StartCoroutine(DisableAllAnims());
                    robotControl.StartPlayerMoving();
                    seedPrompt.SetActive(true);
                    seedPromptAnim.SetTrigger("seedPrompt");

                    if (!progressTextIsShowing)
                    { // 3 second delay
                        StartCoroutine(DelayProgressButtonVar1());
                        progressTextIsShowing = true;
                    }
                    text1Read10 = true;
                }
              
            }

            if (currentStageOfText == 11)
            { //  jobotIntroStage1i
                if (!text1Read11)
                {
                    if (!textBeenRead)
                    {
                        progressText.gameObject.SetActive(false);
                    }
                    LOLSDK.Instance.SpeakText("jobotStage2PlantSeeda");

                    jobotStage2PlantSeed.gameObject.SetActive(false);
                    jobotStage2PlantSeeda.gameObject.SetActive(true);
                    jobotStage2PlantSeedb.gameObject.SetActive(false);

                    if (!progressTextIsShowing)
                    { // 3 second delay
                        StartCoroutine(DelayProgressButton());
                        progressTextIsShowing = true;
                    }
                    text1Read11 = true;
                }
            }
            

            if (currentStageOfText == 12)
            { //  jobotIntroStage1i

                if (!text1Read12)
                {
                    if (!textBeenRead)
                    {
                        progressText.gameObject.SetActive(false);
                    }
                    LOLSDK.Instance.SpeakText("jobotStage2PlantSeedb");

                    jobotStage2PlantSeeda.gameObject.SetActive(false);
                    jobotStage2PlantSeedb.gameObject.SetActive(true);
                    jobotStage2PlantSeede.gameObject.SetActive(false);
                    if (!progressTextIsShowing)
                    { // 3 second delay
                        StartCoroutine(DelayProgressButtonVar1());
                        progressTextIsShowing = true;
                    }
                    text1Read12 = true;
                }
            }
         
            if (currentStageOfText == 13)
            { //  jobotIntroStage1i
                if (!text1Read13)
                {
                    if (!textBeenRead)
                    {
                        progressText.gameObject.SetActive(false);
                    }
                    LOLSDK.Instance.SpeakText("jobotStage2PlantSeedf");

                    jobotStage2PlantSeedb.gameObject.SetActive(false);
                    jobotStage2PlantSeede.gameObject.SetActive(true);
                    jobotStage2PlantSeede.enabled = true;

                    jobotSeedsPlanted.gameObject.SetActive(false);

                    if (!progressTextIsShowing)
                    { // 3 second delay
                        StartCoroutine(DelayProgressButtonVar2());
                        progressTextIsShowing = true;
                    }
                    text1Read13 = true;
                }
  
            }
            if (currentStageOfText == 14)
            { //  jobotIntroStage1i
                if (!text1Read14)
                {
                    if (!textBeenRead)
                    {
                        progressText.gameObject.SetActive(false);
                    }
                    textPanalToHide.SetActive(false);
                    help.enabled = true;
                    tasks.enabled = true;
                    robotControl.enabled = true;
                   // LOLSDK.Instance.SpeakText("jobotStage2PlantSeed");

                    if (!progressTextIsShowing)
                    { // 3 second delay
                        StartCoroutine(DelayProgressButtonVar1());
                        progressTextIsShowing = true;
                    }
                    text1Read14 = true;
                }                
            }

            if (currentStageOfText == 15)
            { //  jobotIntroStage1i
                if (!text1Read15)
                {
                    if (!textBeenRead)
                    {
                        progressText.gameObject.SetActive(false);
                    }
                    textPanalToHide.SetActive(true);

                    LOLSDK.Instance.SpeakText("jobotStage2PlantSeedComplete");

                    TTSJobotPlantSeed6.gameObject.SetActive(false);
                    TTSSeedsComplete.gameObject.SetActive(true);

                    help.enabled = true;
                    tasks.enabled = true;
                    setPeicesToDisable.SetActive(true);

                    robotControl.enabled = true;
                    playerRobotToShow.SetActive(true);
                    robotAnim.keepAnimatorControllerStateOnDisable = false;
                    robotAnim.enabled = false;
                    robotToHide.SetActive(false);
                    robotControl.enabled = true;

                    //    TTSStage2Complete.gameObject.SetActive(false);
                    //   stage2Complete.gameObject.SetActive(false);
                    text1Read15 = true;
                } 
            }
            if (currentStageOfText == 16)
            { //  jobotIntroStage1i
                if (!text1Read16)
                {
                    textPanalToHide.SetActive(false);
                    if (!textBeenRead)
                    {
                        progressText.gameObject.SetActive(false);
                    }
                           
                    robotControl.enabled = true;
                    text1Read16 = true;
                }
            }

            if (currentStageOfText == 17)
            { //  jobotIntroStage1i
                if (!text1Read17)
                {
                    if (!textBeenRead)
                    {
                        progressText.gameObject.SetActive(false);
                    }
                    textPanalToHide.SetActive(true);
                    LOLSDK.Instance.SpeakText("jobotStage2PlantSeedExamineWaterplantComplete");

                    TTSSeedsComplete.gameObject.SetActive(false);
                    TTSseedsWateredComplete.gameObject.SetActive(true);
                    robotControl.enabled = true;
                    StartCoroutine(HideText());
                    StartCoroutine(ResetDoor());
                    help.enabled = true;
                    tasks.enabled = true;
                    progressText.gameObject.SetActive(false);

                    text1Read17 = true;

                }

            }

            if (currentStageOfText == 18)
            { //  jobotIntroStage1i
                if (!text1Read18)
                {
                    textPanalToHide.SetActive(true);
                    //robotAnim.enabled = true;
                    LOLSDK.Instance.SpeakText("jobotStage2Completeb");

                    TTSStage2Complete.gameObject.SetActive(true);
                    jobotStage2PlantSeed.gameObject.SetActive(false);
                    jobotStage2PlantSeeda.gameObject.SetActive(false);
                    jobotStage2PlantSeedb.gameObject.SetActive(false);
                    jobotStage2PlantSeede.gameObject.SetActive(false);
                    stage2Complete.gameObject.SetActive(true);
                    StartCoroutine(HideText());
                }
              
            }
        }

        
           

            //rgPond.enabled = false;
        

        void OnClick()
        {
            currentStageOfText++;
            textBeenRead = false;
            progressTextIsShowing = false;
        }

        void OnClickBack()
        {
            currentStageOfText--;
            text1Read1 = false;
            text1Read2 = false;
            text1Read3 = false;
            text1Read4 = false;
            text1Read5 = false;
            text1Read6 = false;
            text1Read7 = false;
            text1Read8 = false;
            text1Read9 = false;
            text1Read10 = false;
            text1Read11 = false;
            text1Read12 = false;
            text1Read13 = false;
            text1Read14 = false;
            text1Read15 = false;
            text1Read16 = false;
            text1Read17 = false;
            text1Read18 = false;
        }

        void JobotStage2Section1()
        {
            LOLSDK.Instance.SpeakText("jobotIntroStage2");
        }

        void JobotStage2Section1a()
        {
            LOLSDK.Instance.SpeakText("jobotIntroStage2a");
        }

        void JobotStage2Section1b()
        {
            LOLSDK.Instance.SpeakText("jobotIntroStage2b");
        }

        void JobotStage2Section1c()
        {
            LOLSDK.Instance.SpeakText("jobotIntroStage2c");
        }

        void JobotStage2Section1d()
        {
            LOLSDK.Instance.SpeakText("jobotIntroStage2d");
        }

        void JobotStage2Section1e()
        {
            LOLSDK.Instance.SpeakText("jobotIntroStage2e");
        }

        void JobotStage2Section1f()
        {
            LOLSDK.Instance.SpeakText("jobotIntroStage2f");
        }

        void JobotStage2Section1g()
        {
            LOLSDK.Instance.SpeakText("jobotIntroStage2g");
        }

        void JobotStage2Section1h()
        {
            LOLSDK.Instance.SpeakText("jobotIntroStage2h");
        }
        void JobotStage2Section1i()
        {
            LOLSDK.Instance.SpeakText("jobotIntroStage2i");
        }

        void JobotStage2Section2()
        {
            LOLSDK.Instance.SpeakText("jobotStage2PlantSeed");
        }

        void JobotStage2Section2a()
        {
            LOLSDK.Instance.SpeakText("jobotStage2PlantSeeda");
        }

        void JobotStage2Section2b()
        {
            LOLSDK.Instance.SpeakText("jobotStage2PlantSeedb");
        }

        void JobotStage2Section2c()
        {
            LOLSDK.Instance.SpeakText("jobotStage2PlantSeedc");
        }
        void JobotStage2Section2d()
        {
            LOLSDK.Instance.SpeakText("jobotStage2PlantSeedd");
        }

        void JobotStage2Section2e()
        {
            LOLSDK.Instance.SpeakText("jobotStage2PlantSeede");
        }

        void JobotSeedsAllPlanted()
        {
            LOLSDK.Instance.SpeakText("jobotStage2PlantSeedComplete");
        }

        void JobotSeedsAllWatered()
        {
            LOLSDK.Instance.SpeakText("jobotStage2PlantSeedExamineWaterplantComplete");
        }

        void JobotStage2Complete()
        {
            LOLSDK.Instance.SpeakText("jobotStage2Completeb");
        }

        public void StartTextProcessStage1()
        {
            currentStageOfText = 1;
        }

        public IEnumerator HideText() 
        {
            yield return new WaitForSeconds(5);
            textPanalToHide.gameObject.SetActive(false);
            currentStageOfText = 16;
            robotControl.enabled = true;
        }


        public IEnumerator DisableAllAnims()
        {
            yield return new WaitForSeconds(0.5f);
            camFollow.enabled = true;
            // camFollowStage2.enabled = true;
            maincameraToDisable.enabled = false;
            playerCameraToEnable.SetActive(true);

            stage2EndToDisable.enabled = false;
            camZoomOutAnim.SetBool("gameStarted", false);
            camZoomOutAnim.SetBool("startStage1PlayerCamZoomOut", false);
            camZoomOutAnim.SetTrigger("triggerResetValues");

        }

        public IEnumerator ResetDoor()
        {
            yield return new WaitForSeconds(2);
            doorAnim.SetBool("doorNeedsToBeOpen", false);
            doorAnim.SetBool("closeDoor", false);
            doorAnim.SetTrigger("resetDoorValues");

        }


        public IEnumerator DelayProgressButton()
        {
            yield return new WaitForSeconds(4);
            progressText.gameObject.SetActive(true);
            textBeenRead = true;

        }

        public IEnumerator DelayProgressButtonVar2()
        {
            yield return new WaitForSeconds(3);
            progressText.gameObject.SetActive(true);
            textBeenRead = true;

        }

        public IEnumerator DelayProgressButtonVar1()
        {
            yield return new WaitForSeconds(2);
            progressText.gameObject.SetActive(true);
            textBeenRead = true;

        }
    }
}
