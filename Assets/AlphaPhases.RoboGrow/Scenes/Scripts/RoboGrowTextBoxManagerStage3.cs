using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using LoLSDK;
namespace Alpha.Phases.Robo.Grow
{
    // This is the text manager for stage 1 of RoboGro
    public class RoboGrowTextBoxManagerStage3 : MonoBehaviour
    {
        public RoboGrowMain rgMainData; // declare access to RoboGrowMain
        public GameObject textPanalToHide; // the start text panal to show and hide on start and finish of text section
        public GameObject robotToHide;
        public GameObject playerRobotToShow;
        public RobotController robotControl;
        public RoboGrowEndOfStage3 rgEndOfStage;
        // public CameraFollowPlayer camFollow;

        public Button help;
        public Button tasks;

        public bool saveOnce;

        public Animator camZoomOutAnim;
        public Animator robotAnim;
        public Animator doorAnim;
        public Button forwardButtonToDisable;

        public bool introReadyToBeCompleted;
        public Camera mainCameraToDisable;
        public GameObject playerCameraToEnable;

        //public Camera robotPlayerCam;
        //public Camera camToDisable;

        public bool textBeenRead;
        public bool progressTextIsShowing;

        public BoxCollider stage3EndToDisable;


        public bool textRead1;
        public bool textRead2;
        public bool textRead3;
        public bool textRead4;
        public bool textRead5;
        public bool textRead6;
        public bool textRead7;
        public bool textRead8;
        public bool textRead9;
        public bool textRead10;
        public bool textRead11;
        public bool textRead12;
        public bool textRead13;
        public bool textRead14;


        public Button TTSJobot1;
      //  public Button TTSJobot2;
        public Button TTSJobot3;
        public Button TTSJobot4;
        public Button TTSJobot5;
        public Button TTSJobot6;
        public Button TTSJobot7;
        public Button TTSJobot8;
        public Button TTSJobot9;
        public Button TTSJobot10;
      //  public Button TTSJobot11;
        public Button TTSJobot12;
       // public Button TTSJobot13;
        public Button TTSJobot14;
        public Button TTSJobot15;
        public Button TTSJobot16;

        public TextMeshProUGUI jobotIntroStage1Section1;
     //   public TextMeshProUGUI jobotIntroStage1Section1a;
        public TextMeshProUGUI jobotIntroStage1Section1b;
        public TextMeshProUGUI jobotIntroStage1Section1c;
        public TextMeshProUGUI jobotIntroStage1Section1d;
        public TextMeshProUGUI jobotIntroStage1Section1e;
        public TextMeshProUGUI jobotIntroStage1Section1f;
        public TextMeshProUGUI jobotIntroStage1Section1g;
        public TextMeshProUGUI jobotIntroStage1Section1h;
        public TextMeshProUGUI jobotIntroStage1Section1i;
    //    public TextMeshProUGUI jobotIntroStage1Section1j;
        public TextMeshProUGUI jobotIntroStage1Section1k;
     //   public TextMeshProUGUI jobotIntroStage1Section1l;
        public TextMeshProUGUI jobotIntroStage1Section1m;
        public TextMeshProUGUI jobotFlowersWatered;
       // public TextMeshProUGUI stageComplete;
        //public TextMeshProUGUI jobotSeedsWatered;

        public Button progressText;
        public Button progressTextBack;

        public int currentStageOfText;

        private void Awake()
        {
            currentStageOfText = 0;
            progressText.onClick.AddListener(OnClick);
            progressTextBack.onClick.AddListener(OnClickBack);
            TTSJobot1.onClick.AddListener(JobotStage1Section1);
         //   TTSJobot2.onClick.AddListener(JobotStage1Section1a);
            TTSJobot3.onClick.AddListener(JobotStage1Section1b);
            TTSJobot4.onClick.AddListener(JobotStage1Section1c);
            TTSJobot5.onClick.AddListener(JobotStage1Section1d);
            TTSJobot6.onClick.AddListener(JobotStage1Section1e);
            TTSJobot7.onClick.AddListener(JobotStage1Section1f);
            TTSJobot8.onClick.AddListener(JobotStage1Section1g);
            TTSJobot9.onClick.AddListener(JobotStage1Section1h);
            TTSJobot10.onClick.AddListener(JobotStage1Section1i);
         //   TTSJobot11.onClick.AddListener(JobotStage1Section1j);
            TTSJobot12.onClick.AddListener(JobotStage1Section1k);
         //   TTSJobot13.onClick.AddListener(JobotStage1Section1l);
            TTSJobot14.onClick.AddListener(JobotStage1Section1m);
            TTSJobot15.onClick.AddListener(JobotFloweresWatered);
            TTSJobot16.onClick.AddListener(JobotStageComplete);
        }

        private void Start()
        {
            if (rgMainData.currentGameStage == 3)
            {
                robotControl.enabled = false;
                //textPanalToHide.SetActive(false);
            }
        }


        private void Update()
        {
            if (rgMainData.currentGameStage == 3)
            {
                //  jobotIntroStage1
                if (currentStageOfText == 1)
                {
                    if (!textRead1)
                    {
                        if (!textBeenRead)
                        {
                            progressText.gameObject.SetActive(false);
                        }
                        textPanalToHide.SetActive(true);
                        progressTextBack.gameObject.SetActive(false);

                        jobotIntroStage1Section1.gameObject.SetActive(true);
                        jobotIntroStage1Section1b.gameObject.SetActive(false);

                        if (!progressTextIsShowing)
                        { // 3 second delay
                            StartCoroutine(DelayProgressButtonVar1());
                            progressTextIsShowing = true;
                        }
                        textRead1 = true;
                    }
                    

                }
         
                if (currentStageOfText == 2)
                {
                    if (!textRead2)
                    {
                        if (!textBeenRead)
                        {
                            progressText.gameObject.SetActive(false);
                        }
                        progressTextBack.gameObject.SetActive(true);
                        //  jobotIntroStage1b
                        jobotIntroStage1Section1.gameObject.SetActive(false);
                        //  jobotIntroStage1Section1a.enabled = false;
                        jobotIntroStage1Section1b.gameObject.SetActive(true);
                        jobotIntroStage1Section1c.gameObject.SetActive(false);
                        if (!progressTextIsShowing)
                        { // 3 second delay
                            StartCoroutine(DelayProgressButtonVar1());
                            progressTextIsShowing = true;
                        }

                        textRead2 = true;
                    }
                    

                }

                if (currentStageOfText == 3)
                {
                    if (!textRead3)
                    {
                        if (!textBeenRead)
                        {
                            progressText.gameObject.SetActive(false);
                        }
                        //  jobotIntroStage1c

                        jobotIntroStage1Section1b.gameObject.SetActive(false);
                        jobotIntroStage1Section1c.gameObject.SetActive(true);
                        jobotIntroStage1Section1d.gameObject.SetActive(false);

                        if (!progressTextIsShowing)
                        { // 3 second delay
                            StartCoroutine(DelayProgressButtonVar1());
                            progressTextIsShowing = true;
                        }
                        textRead3 = true;
                    }
                 

                }

                if (currentStageOfText == 4)
                {
                    if (!textRead4)
                    {
                        if (!textBeenRead)
                        {
                            progressText.gameObject.SetActive(false);
                        }
                        //  jobotIntroStage1d

                        jobotIntroStage1Section1c.gameObject.SetActive(false);
                        jobotIntroStage1Section1d.gameObject.SetActive(true);
                        jobotIntroStage1Section1e.gameObject.SetActive(false);

                        if (!progressTextIsShowing)
                        { // 3 second delay
                            StartCoroutine(DelayProgressButtonVar2());
                            progressTextIsShowing = true;
                        }
                        textRead4 = true;
                    }
  

                }

                if (currentStageOfText == 5)
                {
                    //  jobotIntroStage1e
                    if (!textRead5)
                    {
                        if (!textBeenRead)
                        {
                            progressText.gameObject.SetActive(false);
                        }

                        jobotIntroStage1Section1d.gameObject.SetActive(false);
                        jobotIntroStage1Section1e.gameObject.SetActive(true);
                        jobotIntroStage1Section1f.gameObject.SetActive(false);

                        if (!progressTextIsShowing)
                        { // 3 second delay
                            StartCoroutine(DelayProgressButtonVar2());
                            progressTextIsShowing = true;
                        }
                        textRead5 = true;
                    }
 
                }

                if (currentStageOfText == 6)
                {
                    if (!textRead6)
                    {
                        //  jobotIntroStage1f
                        if (!textBeenRead)
                        {
                            progressText.gameObject.SetActive(false);
                        }

                        jobotIntroStage1Section1e.gameObject.SetActive(false);
                        jobotIntroStage1Section1f.gameObject.SetActive(true);
                        jobotIntroStage1Section1g.gameObject.SetActive(false);

                        // taskPanal.SetActive(false);
                        if (!progressTextIsShowing)
                        { // 3 second delay
                            StartCoroutine(DelayProgressButtonVar2());
                            progressTextIsShowing = true;
                        }
                        textRead6 = true;
                    }
              
                }

                if (currentStageOfText == 7)
                {
                    if (!textRead7)
                    {
                        //  jobotIntroStage1g
                        if (!textBeenRead)
                        {
                            progressText.gameObject.SetActive(false);
                        }

                        jobotIntroStage1Section1f.gameObject.SetActive(false);
                        jobotIntroStage1Section1g.gameObject.SetActive(true);
                        jobotIntroStage1Section1h.gameObject.SetActive(false);

                        if (!progressTextIsShowing)
                        { // 3 second delay
                            StartCoroutine(DelayProgressButtonVar2());
                            progressTextIsShowing = true;
                        }
                        textRead7 = true;
                    }
                  
                }

                if (currentStageOfText == 8)
                {
                    if (!textRead8)
                    {
                        //  jobotIntroStage1h
                        if (!textBeenRead)
                        {
                            progressText.gameObject.SetActive(false);
                        }

                        jobotIntroStage1Section1g.gameObject.SetActive(false);
                        jobotIntroStage1Section1h.gameObject.SetActive(true);
                        jobotIntroStage1Section1i.gameObject.SetActive(false);

                        if (!progressTextIsShowing)
                        { // 3 second delay
                            StartCoroutine(DelayProgressButtonVar1());
                            progressTextIsShowing = true;
                        }
                        textRead8 = true;
                    }
  
                }

                if (currentStageOfText == 9)
                { //  jobotIntroStage1i
                    if (!textRead9)
                    {
                        if (!textBeenRead)
                        {
                            progressText.gameObject.SetActive(false);
                        }

                        jobotIntroStage1Section1h.gameObject.SetActive(false);
                        jobotIntroStage1Section1i.gameObject.SetActive(true);
                        //     jobotIntroStage1Section1j.enabled = false;
                        jobotIntroStage1Section1k.gameObject.SetActive(false);

                        if (!progressTextIsShowing)
                        { // 3 second delay
                            StartCoroutine(DelayProgressButtonVar2());
                            progressTextIsShowing = true;
                        }

                        textRead9 = true;
                    } 
                }

                if (currentStageOfText == 10)
                {
                    if (!textRead10)
                    {
                        // Jobotintrostage1k
                        if (!textBeenRead)
                        {
                            progressText.gameObject.SetActive(false);
                        }
                 
                        jobotIntroStage1Section1i.gameObject.SetActive(false);
                        jobotIntroStage1Section1k.gameObject.SetActive(true);
                        jobotIntroStage1Section1m.gameObject.SetActive(false);

                        doorAnim.SetBool("doorNeedsToBeOpen", false);
                        doorAnim.SetBool("closeDoor", false);
                        doorAnim.SetTrigger("resetDoorValues");
                        if (!progressTextIsShowing)
                        { // 3 second delay
                            StartCoroutine(DelayProgressButtonVar2());
                            progressTextIsShowing = true;
                        }
                        textRead10 = true;
                    }
 
                }
                if (currentStageOfText == 11)
                {
                    if (!textRead11)
                    {
                        jobotIntroStage1Section1k.gameObject.SetActive(false);
                        //       jobotIntroStage1Section1l.enabled = false;
                        jobotIntroStage1Section1m.gameObject.SetActive(true);
                        jobotFlowersWatered.gameObject.SetActive(false);


                        help.enabled = true;
                        tasks.enabled = true;
                        camZoomOutAnim.SetBool("startStage1PlayerCamZoomOut", true);
                        //   rgMainData.SavePlayerPos();
                        playerCameraToEnable.SetActive(true);
                        rgEndOfStage.enabled = false;
                        mainCameraToDisable.enabled = false;
                        stage3EndToDisable.enabled = false;
                        //  StartCoroutine(CloseText());
                        playerRobotToShow.SetActive(true);
                        robotToHide.SetActive(false);
                        robotControl.enabled = true;
                        robotAnim.keepAnimatorControllerStateOnDisable = false;
                        robotAnim.enabled = false;
                        if (!saveOnce)
                        {
                            rgMainData.Stage3IntoComplete();
                            saveOnce = true;
                        }
                        StartCoroutine(DisableAllAnims());
                        StartCoroutine(ResetDoor());
                        StartCoroutine(CloseText());

                        textRead11 = true;
                    }
                }

                if (currentStageOfText == 15)
                {
                    if (!textRead12)
                    {
                        // Jobotintrostage1n
                        textPanalToHide.SetActive(false);
                        jobotIntroStage1Section1.gameObject.SetActive(false);
                        //       jobotIntroStage1Section1a.enabled = false;
                        jobotIntroStage1Section1b.gameObject.SetActive(false);
                        jobotIntroStage1Section1c.gameObject.SetActive(false);
                        jobotIntroStage1Section1d.gameObject.SetActive(false);
                        jobotIntroStage1Section1e.gameObject.SetActive(false);
                        jobotIntroStage1Section1f.gameObject.SetActive(false);
                        jobotIntroStage1Section1g.gameObject.SetActive(false);
                        jobotIntroStage1Section1h.gameObject.SetActive(false);
                        jobotIntroStage1Section1i.gameObject.SetActive(false);
                        //        jobotIntroStage1Section1j.enabled = false;
                        jobotIntroStage1Section1k.gameObject.SetActive(false);
                        //       jobotIntroStage1Section1l.enabled = false;
                        jobotIntroStage1Section1m.gameObject.SetActive(false);
                        jobotFlowersWatered.gameObject.SetActive(false);

                       
                        textRead12 = true;
                    }
                   
                }


                if (currentStageOfText == 16)
                {
                    if (!textRead13)
                    {
                        // Jobotintrostage1l
                        textPanalToHide.SetActive(true);

                        jobotIntroStage1Section1m.gameObject.SetActive(false);
                        jobotFlowersWatered.gameObject.SetActive(true);

                        StartCoroutine(MoveToBlankText());
                        progressText.gameObject.SetActive(false);
                        textRead13 = true;
                    }                   

                }

            }


        }




            void OnClick()
        {
            currentStageOfText++;
            textBeenRead = false;
            progressTextIsShowing = false;
        }

        void OnClickBack()
        {
            currentStageOfText--;
            textRead1 = false;
            textRead2 = false;
            textRead3 = false;
            textRead4 = false;
            textRead5 = false;
            textRead6 = false;
            textRead7 = false;
            textRead8 = false;
            textRead9 = false;
            textRead10 = false;
            textRead11 = false;
            textRead12 = false;
            textRead13 = false;
            textRead14 = false;
        }

        void JobotStage1Section1()
        {
            LOLSDK.Instance.SpeakText("jobotIntroStage3");
        }

        void JobotStage1Section1a()
        {
            LOLSDK.Instance.SpeakText("jobotIntroStage3a");
        }

        void JobotStage1Section1b()
        {
            LOLSDK.Instance.SpeakText("jobotIntroStage3b");
        }

        void JobotStage1Section1c()
        {
            LOLSDK.Instance.SpeakText("jobotIntroStage3c");
        }

        void JobotStage1Section1d()
        {
            LOLSDK.Instance.SpeakText("jobotIntroStage3d");
        }

        void JobotStage1Section1e()
        {
            LOLSDK.Instance.SpeakText("jobotIntroStage3e");
        }

        void JobotStage1Section1f()
        {
            LOLSDK.Instance.SpeakText("jobotIntroStage3f");
        }

        void JobotStage1Section1g()
        {
            LOLSDK.Instance.SpeakText("jobotIntroStage3g");
        }

        void JobotStage1Section1h()
        {
            LOLSDK.Instance.SpeakText("jobotIntroStage3h");
        }
        void JobotStage1Section1i()
        {
            LOLSDK.Instance.SpeakText("jobotIntroStage3i");
        }

        void JobotStage1Section1j()
        {
            LOLSDK.Instance.SpeakText("jobotIntroStage3j");
        }

        void JobotStage1Section1k()
        {
            LOLSDK.Instance.SpeakText("jobotIntroStage3k");
        }

        void JobotStage1Section1l()
        {
            LOLSDK.Instance.SpeakText("jobotIntroStage3l");
        }

        void JobotStage1Section1m()
        {
            LOLSDK.Instance.SpeakText("jobotIntroStage3m");
        }

        void JobotFloweresWatered()
        {
            LOLSDK.Instance.SpeakText("jobotIntroStage3PWatered");
        }
        void JobotStageComplete()
        {
            LOLSDK.Instance.SpeakText("jobotStage3CompletePanal");
        }

        public IEnumerator CloseText()
        {
            yield return new WaitForSeconds(4);
            textPanalToHide.SetActive(false);
        }

        public IEnumerator MoveToBlankText()
        {
            yield return new WaitForSeconds(4);
            textRead12 = false;
            currentStageOfText = 15;
        }

        public IEnumerator MoveTEnd()
        {
            yield return new WaitForSeconds(3);
            textRead12 = false;
            currentStageOfText = 15;
        }

        public IEnumerator DisableAllAnims()
        {
            yield return new WaitForSeconds(2);
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
