using System.Collections;
using UnityEngine;
using LoLSDK;
using UnityEngine.UI;
using TMPro;
using UnityEngine.AI;

namespace Alpha.Phases.Robo.Grow
{
    public class RoboGrowStage1MiniGameStart : MonoBehaviour
    {
        public GameObject stage1MGLevel;
        public Camera cataCam;
        public Camera playerCam;
        public GameObject UICanvasToHide;
        public GameObject overWorldMGToHide;
        public CatapillerController catControl;
        public RoboGrowMain rgMain;
        public RobotController robCont;
        public GameObject robotNavMeshAgentToStop;
        public CameraFollowPlayer cameraFollow;
        public RoboGrowEggBreakerScript rgEggScript;
        public Canvas mgCanvastoShow;
        public GameObject inGameCanvas;
       // public bool startMG;
        public bool startCamera;
        public bool removeDeathText1;
        public bool removeDeathText2;
        public bool runStartOnce;
        public bool playerGuessedIncorrectAlready;
        bool moveTextAlong;
        //Text elements
        public GameObject textPanal;
        public GameObject mgTextPanal;
        public Button TTSJobotTree1;
        public Button TTSJobotTree1a;
        public Button TTSJobotTree1b;
        public Button TTSJobotTree1c;
        public Button TTSJobotTree1d;
        public Button TTSJobotTree1e;
        public Button TTSJobotTree1f;
      //  public Button TTSJobotTree1g;//
      //  public Button TTSJobotTree1ga;//
      //  public Button TTSJobotTree1h;//
     //   public Button TTSJobotTree1ha;
     //   public Button TTSJobotTree1i;//
        public Button TTSJobotTree1j;
        public Button TTSJobotTree1Proceed;

        public TextMeshProUGUI jobotIntroStage1Tree;
        public TextMeshProUGUI jobotIntroStage1Tree1a;
        public TextMeshProUGUI jobotIntroStage1Tree1b;
        public TextMeshProUGUI jobotIntroStage1Tree1c;
        public TextMeshProUGUI jobotIntroStage1Tree1d;
        public TextMeshProUGUI jobotIntroStage1Tree1e;
        public TextMeshProUGUI jobotIntroStage1Tree1f;
   //     public TextMeshProUGUI jobotIntroStage1Tree1g;
  //      public TextMeshProUGUI jobotIntroStage1Tree1ga;
  //      public TextMeshProUGUI jobotIntroStage1Tree1h;
      //  public TextMeshProUGUI jobotIntroStage1Tree1ha;
  //      public TextMeshProUGUI jobotIntroStage1Tree1i;
        public TextMeshProUGUI jobotIntroStage1Tree1j;
        public TextMeshProUGUI jobotIntroStage1Tree1Proceed;

        public Button TTSIncorrectGuessPanal;

        public TextMeshProUGUI IncorrectGuessPanal;

        public Button progressText;
         public Button progressTextBack;

        public bool textBeenRead;
        public bool progressTextIsShowing;

        public bool showProceedText;

        public bool textBeenReadSection2;
        public bool progressTextIsShowingSection2;

        public Button progressTextPanel2;
        public Button progressTextBackPanel2;

        public int currentStage1TreeText;

        // Start is called before the first frame update
        void Start()
        {
            startCamera = false;
            //sendTextToStage = false;
            currentStage1TreeText = 0;
            progressText.onClick.AddListener(OnClick);
            progressTextBack.onClick.AddListener(OnClickBack);

            progressTextPanel2.onClick.AddListener(OnClickPanel2);
            progressTextBackPanel2.onClick.AddListener(OnClickBackPanal2);

            TTSJobotTree1.onClick.AddListener(JobotStage1Tree1);
            TTSJobotTree1a.onClick.AddListener(JobotStage1Tree2);
            TTSJobotTree1b.onClick.AddListener(JobotStage1Tree3);
            TTSJobotTree1c.onClick.AddListener(JobotStage1Tree4);
            TTSJobotTree1d.onClick.AddListener(JobotStage1Tree5);
            TTSJobotTree1e.onClick.AddListener(JobotStage1Tree6);
            TTSJobotTree1f.onClick.AddListener(JobotStage1Tree7);
        // /   TTSJobotTree1g.onClick.AddListener(JobotStage1Tree8);
         //   TTSJobotTree1ga.onClick.AddListener(JobotStage1Tree8A);
        //    TTSJobotTree1h.onClick.AddListener(JobotStage1Tree9);
         //   TTSJobotTree1ha.onClick.AddListener(JobotStage1Tree9A);
        //   TTSJobotTree1i.onClick.AddListener(JobotStage1Tree10);
            TTSJobotTree1j.onClick.AddListener(JobotStage1Tree11);

            TTSJobotTree1Proceed.onClick.AddListener(JobotStage1Tree1Proceed);

            // cataCam.gameObject.SetActive(false);
            stage1MGLevel.SetActive(false);
        }

        // Update is called once per frame
        void Update()
        {
            if (currentStage1TreeText == 1)
            {
                if (!textBeenRead)
                {
                    progressText.gameObject.SetActive(false);
                }
                rgMain.EnableStage1Hint5();
                progressTextBack.gameObject.SetActive(false);
                textPanal.SetActive(true);
                jobotIntroStage1Tree.enabled = true;
                jobotIntroStage1Tree1a.enabled = false;
                jobotIntroStage1Tree1b.enabled = false;
                jobotIntroStage1Tree1c.enabled = false;
                jobotIntroStage1Tree1d.enabled = false;
                jobotIntroStage1Tree1e.enabled = false;
                jobotIntroStage1Tree1f.enabled = false;
            //    jobotIntroStage1Tree1g.enabled = false;
            //    jobotIntroStage1Tree1ga.enabled = false;
            //    jobotIntroStage1Tree1h.enabled = false;
            ///    jobotIntroStage1Tree1ha.enabled = false;
            //    jobotIntroStage1Tree1i.enabled = false;
                jobotIntroStage1Tree1j.enabled = false;



                TTSJobotTree1.gameObject.SetActive(true);
                TTSJobotTree1a.gameObject.SetActive(false);
                TTSJobotTree1b.gameObject.SetActive(false);
                TTSJobotTree1c.gameObject.SetActive(false);
                TTSJobotTree1d.gameObject.SetActive(false);
                TTSJobotTree1e.gameObject.SetActive(false);
                TTSJobotTree1f.gameObject.SetActive(false);
           //     TTSJobotTree1g.gameObject.SetActive(false);
            //    TTSJobotTree1ga.gameObject.SetActive(false);
            //    TTSJobotTree1h.gameObject.SetActive(false);
             //   TTSJobotTree1ha.gameObject.SetActive(false);
            //    TTSJobotTree1i.gameObject.SetActive(false);
                TTSJobotTree1j.gameObject.SetActive(false);

                TTSJobotTree1Proceed.gameObject.SetActive(false);
                jobotIntroStage1Tree1Proceed.enabled = false;
                TTSIncorrectGuessPanal.gameObject.SetActive(false);
                IncorrectGuessPanal.gameObject.SetActive(false);
                if (!progressTextIsShowing)
                { // 3 second delay
                    StartCoroutine(DelayProgressButtonVar1());
                    progressTextIsShowing = true;
                }

            }

            if (currentStage1TreeText == 2)
            {
                if (!textBeenRead)
                {
                    progressText.gameObject.SetActive(false);
                }
                progressTextBack.gameObject.SetActive(true);
                jobotIntroStage1Tree.enabled = false;
                jobotIntroStage1Tree1a.enabled = true;
                jobotIntroStage1Tree1b.enabled = false;
                jobotIntroStage1Tree1c.enabled = false;
                jobotIntroStage1Tree1d.enabled = false;
                jobotIntroStage1Tree1e.enabled = false;
                jobotIntroStage1Tree1f.enabled = false;
            //    jobotIntroStage1Tree1g.enabled = false;
            //    jobotIntroStage1Tree1ga.enabled = false;
            //    jobotIntroStage1Tree1h.enabled = false;
             //   jobotIntroStage1Tree1ha.enabled = false;
             //   jobotIntroStage1Tree1i.enabled = false;
                jobotIntroStage1Tree1j.enabled = false;


                TTSJobotTree1.gameObject.SetActive(false);
                TTSJobotTree1a.gameObject.SetActive(true);
                TTSJobotTree1b.gameObject.SetActive(false);
                TTSJobotTree1c.gameObject.SetActive(false);
                TTSJobotTree1d.gameObject.SetActive(false);
                TTSJobotTree1e.gameObject.SetActive(false);
                TTSJobotTree1f.gameObject.SetActive(false);
           //     TTSJobotTree1g.gameObject.SetActive(false);
            ////    TTSJobotTree1ga.gameObject.SetActive(false);
            //    TTSJobotTree1h.gameObject.SetActive(false);
            //    TTSJobotTree1ha.gameObject.SetActive(false);
            //    TTSJobotTree1i.gameObject.SetActive(false);
                TTSJobotTree1j.gameObject.SetActive(false);

                TTSJobotTree1Proceed.gameObject.SetActive(false);
                jobotIntroStage1Tree1Proceed.enabled = false;
                TTSIncorrectGuessPanal.gameObject.SetActive(false);
                IncorrectGuessPanal.gameObject.SetActive(false);
                if (!progressTextIsShowing)
                { // 3 second delay
                    StartCoroutine(DelayProgressButtonVar1());
                    progressTextIsShowing = true;
                }
            }

            if (currentStage1TreeText == 3)
            {
                if (!textBeenRead)
                {
                    progressText.gameObject.SetActive(false);
                }
                jobotIntroStage1Tree.enabled = false;
                jobotIntroStage1Tree1a.enabled = false;
                jobotIntroStage1Tree1b.enabled = true;
                jobotIntroStage1Tree1c.enabled = false;
                jobotIntroStage1Tree1d.enabled = false;
                jobotIntroStage1Tree1e.enabled = false;
                jobotIntroStage1Tree1f.enabled = false;
           //     jobotIntroStage1Tree1g.enabled = false;
           //     jobotIntroStage1Tree1ga.enabled = false;
           //     jobotIntroStage1Tree1h.enabled = false;
            //    jobotIntroStage1Tree1ha.enabled = false;
          //      jobotIntroStage1Tree1i.enabled = false;
                jobotIntroStage1Tree1j.enabled = false;


                TTSJobotTree1.gameObject.SetActive(false);
                TTSJobotTree1a.gameObject.SetActive(false);
                TTSJobotTree1b.gameObject.SetActive(true);
                TTSJobotTree1c.gameObject.SetActive(false);
                TTSJobotTree1d.gameObject.SetActive(false);
                TTSJobotTree1e.gameObject.SetActive(false);
                TTSJobotTree1f.gameObject.SetActive(false);
         ////       TTSJobotTree1g.gameObject.SetActive(false);
         //       TTSJobotTree1ga.gameObject.SetActive(false);
         //       TTSJobotTree1h.gameObject.SetActive(false);
            //    TTSJobotTree1ha.gameObject.SetActive(false);
                //TTSJobotTree1i.gameObject.SetActive(false);
                TTSJobotTree1j.gameObject.SetActive(false);

                TTSJobotTree1Proceed.gameObject.SetActive(false);
                jobotIntroStage1Tree1Proceed.enabled = false;
                TTSIncorrectGuessPanal.gameObject.SetActive(false);
                IncorrectGuessPanal.gameObject.SetActive(false);
                if (!progressTextIsShowing)
                { // 3 second delay
                    StartCoroutine(DelayProgressButton());
                    progressTextIsShowing = true;
                }
            }

            if (currentStage1TreeText == 4)
            {
                if (!textBeenRead)
                {
                    progressText.gameObject.SetActive(false);
                }
                jobotIntroStage1Tree.enabled = false;
                jobotIntroStage1Tree1a.enabled = false;
                jobotIntroStage1Tree1b.enabled = false;
                jobotIntroStage1Tree1c.enabled = true;
                jobotIntroStage1Tree1d.enabled = false;
                jobotIntroStage1Tree1e.enabled = false;
                jobotIntroStage1Tree1f.enabled = false;
           //     jobotIntroStage1Tree1g.enabled = false;
           //     jobotIntroStage1Tree1ga.enabled = false;
          //      jobotIntroStage1Tree1h.enabled = false;
             //   jobotIntroStage1Tree1ha.enabled = false;
          //      jobotIntroStage1Tree1i.enabled = false;
                jobotIntroStage1Tree1j.enabled = false;


                TTSJobotTree1.gameObject.SetActive(false);
                TTSJobotTree1a.gameObject.SetActive(false);
                TTSJobotTree1b.gameObject.SetActive(false);
                TTSJobotTree1c.gameObject.SetActive(true);
                TTSJobotTree1d.gameObject.SetActive(false);
                TTSJobotTree1e.gameObject.SetActive(false);
                TTSJobotTree1f.gameObject.SetActive(false);
           //     TTSJobotTree1g.gameObject.SetActive(false);
          //      TTSJobotTree1ga.gameObject.SetActive(false);
               // TTSJobotTree1h.gameObject.SetActive(false);
                // TTSJobotTree1ha.gameObject.SetActive(false);
               // TTSJobotTree1i.gameObject.SetActive(false);
                TTSJobotTree1j.gameObject.SetActive(false);

                TTSJobotTree1Proceed.gameObject.SetActive(false);
                jobotIntroStage1Tree1Proceed.enabled = false;
                TTSIncorrectGuessPanal.gameObject.SetActive(false);
                IncorrectGuessPanal.gameObject.SetActive(false);
                if (!progressTextIsShowing)
                { // 3 second delay
                    StartCoroutine(DelayProgressButtonVar2());
                    progressTextIsShowing = true;
                }
            }

            if (currentStage1TreeText == 5)
            {
                if (!textBeenRead)
                {
                    progressText.gameObject.SetActive(false);
                }
                jobotIntroStage1Tree.enabled = false;
                jobotIntroStage1Tree1a.enabled = false;
                jobotIntroStage1Tree1b.enabled = false;
                jobotIntroStage1Tree1c.enabled = false;
                jobotIntroStage1Tree1d.enabled = true;
                jobotIntroStage1Tree1e.enabled = false;
                jobotIntroStage1Tree1f.enabled = false;
             //   jobotIntroStage1Tree1g.enabled = false;
             //   jobotIntroStage1Tree1ga.enabled = false;
             //   jobotIntroStage1Tree1h.enabled = false;
            //    jobotIntroStage1Tree1ha.enabled = false;
            //    jobotIntroStage1Tree1i.enabled = false;
                jobotIntroStage1Tree1j.enabled = false;


                TTSJobotTree1.gameObject.SetActive(false);
                TTSJobotTree1a.gameObject.SetActive(false);
                TTSJobotTree1b.gameObject.SetActive(false);
                TTSJobotTree1c.gameObject.SetActive(false);
                TTSJobotTree1d.gameObject.SetActive(true);
                TTSJobotTree1e.gameObject.SetActive(false);
                TTSJobotTree1f.gameObject.SetActive(false);
            //    TTSJobotTree1g.gameObject.SetActive(false);
            //    TTSJobotTree1ga.gameObject.SetActive(false);
             //   TTSJobotTree1h.gameObject.SetActive(false);
            //    TTSJobotTree1ha.gameObject.SetActive(false);
          //      TTSJobotTree1i.gameObject.SetActive(false);
                TTSJobotTree1j.gameObject.SetActive(false);
                progressText.gameObject.SetActive(false);
                TTSIncorrectGuessPanal.gameObject.SetActive(false);
                IncorrectGuessPanal.gameObject.SetActive(false);
                TTSJobotTree1Proceed.gameObject.SetActive(false);
                jobotIntroStage1Tree1Proceed.enabled = false;
            }


            if (currentStage1TreeText == 6)
            {
                // Time.timeScale = 0f;
                //  jobotIntroStage1e
                if (!textBeenReadSection2)
                {
                    progressTextPanel2.gameObject.SetActive(false);
                }
                progressTextBackPanel2.gameObject.SetActive(false);
                mgTextPanal.SetActive(true);
                StartCoroutine(DelayCatController());
                jobotIntroStage1Tree.enabled = false;
                jobotIntroStage1Tree1a.enabled = false;
                jobotIntroStage1Tree1b.enabled = false;
                jobotIntroStage1Tree1c.enabled = false;
                jobotIntroStage1Tree1d.enabled = false;
                jobotIntroStage1Tree1e.gameObject.SetActive(true);
                jobotIntroStage1Tree1e.enabled = true;
                jobotIntroStage1Tree1f.enabled = false;
            //    jobotIntroStage1Tree1g.enabled = false;
            //    jobotIntroStage1Tree1ga.enabled = false;
            //    jobotIntroStage1Tree1h.enabled = false;
             //   jobotIntroStage1Tree1ha.enabled = false;
            //    jobotIntroStage1Tree1i.enabled = false;
                jobotIntroStage1Tree1j.enabled = false;


                TTSJobotTree1.gameObject.SetActive(false);
                TTSJobotTree1a.gameObject.SetActive(false);
                TTSJobotTree1b.gameObject.SetActive(false);
                TTSJobotTree1c.gameObject.SetActive(false);
                TTSJobotTree1d.gameObject.SetActive(false);
                TTSJobotTree1e.gameObject.SetActive(true);
                TTSJobotTree1f.gameObject.SetActive(false);
            //    TTSJobotTree1g.gameObject.SetActive(false);
           //     TTSJobotTree1ga.gameObject.SetActive(false);
            //    TTSJobotTree1h.gameObject.SetActive(false);
             //   TTSJobotTree1ha.gameObject.SetActive(false);
           //     TTSJobotTree1i.gameObject.SetActive(false);
                TTSJobotTree1j.gameObject.SetActive(false);
                TTSIncorrectGuessPanal.gameObject.SetActive(false);
                IncorrectGuessPanal.gameObject.SetActive(false);
                TTSJobotTree1Proceed.gameObject.SetActive(false);
                jobotIntroStage1Tree1Proceed.enabled = false;

                if (!progressTextIsShowingSection2)
                { // 3 second delay
                    StartCoroutine(DelayProgressButtonVar2Section2());
                    progressTextIsShowingSection2 = true;
                }

            }

            if (currentStage1TreeText == 7)
            {
                // Time.timeScale = 0f;

                //  jobotIntroStage1e
                // if (!textBeenReadSection2)
                // {
                //      progressTextPanel2.gameObject.SetActive(false);
                //  }
                progressTextPanel2.gameObject.SetActive(false);
                progressTextBackPanel2.gameObject.SetActive(true);
                jobotIntroStage1Tree.enabled = false;
                jobotIntroStage1Tree1a.enabled = false;
                jobotIntroStage1Tree1b.enabled = false;
                jobotIntroStage1Tree1c.enabled = false;
                jobotIntroStage1Tree1d.enabled = false;
                jobotIntroStage1Tree1e.enabled = false;
                jobotIntroStage1Tree1f.gameObject.SetActive(true);
                jobotIntroStage1Tree1f.enabled = true;
            //    jobotIntroStage1Tree1g.enabled = false;
            //    jobotIntroStage1Tree1ga.enabled = false;
            //    jobotIntroStage1Tree1h.enabled = false;
            //    jobotIntroStage1Tree1ha.enabled = false;
            //    jobotIntroStage1Tree1i.enabled = false;
                jobotIntroStage1Tree1j.enabled = false;


                TTSJobotTree1.gameObject.SetActive(false);
                TTSJobotTree1a.gameObject.SetActive(false);
                TTSJobotTree1b.gameObject.SetActive(false);
                TTSJobotTree1c.gameObject.SetActive(false);
                TTSJobotTree1d.gameObject.SetActive(false);
                TTSJobotTree1e.gameObject.SetActive(false);
                TTSJobotTree1f.gameObject.SetActive(true);
            //    TTSJobotTree1g.gameObject.SetActive(false);
            //    TTSJobotTree1ga.gameObject.SetActive(false);
           //     TTSJobotTree1h.gameObject.SetActive(false);
            //    TTSJobotTree1ha.gameObject.SetActive(false);
            //    TTSJobotTree1i.gameObject.SetActive(false);
                TTSJobotTree1j.gameObject.SetActive(false);
                TTSIncorrectGuessPanal.gameObject.SetActive(false);
                IncorrectGuessPanal.gameObject.SetActive(false);
                TTSJobotTree1Proceed.gameObject.SetActive(false);
                jobotIntroStage1Tree1Proceed.enabled = false;

                if (!progressTextIsShowingSection2)
                { // 3 second delay
                    StartCoroutine(DelayProgressButtonSection2());
                    progressTextIsShowingSection2 = true;
                }
                progressTextPanel2.gameObject.SetActive(false);

                if (!startCamera)
                {

                    StartCoroutine(MiniGameTextDoneWith());
                    startCamera = true;
                }
            }

            /*
            if (currentStage1TreeText == 8)
            {
                //Time.timeScale = 1f;

                //  jobotIntroStage1e
                if (!textBeenReadSection2)
                {
                    progressTextPanel2.gameObject.SetActive(false);
                }
                jobotIntroStage1Tree.enabled = false;
                jobotIntroStage1Tree1a.enabled = false;
                jobotIntroStage1Tree1b.enabled = false;
                jobotIntroStage1Tree1c.enabled = false;
                jobotIntroStage1Tree1d.enabled = false;
                jobotIntroStage1Tree1e.enabled = false;
                jobotIntroStage1Tree1f.enabled = false;
                jobotIntroStage1Tree1g.gameObject.SetActive(true);
                jobotIntroStage1Tree1g.enabled = true;
                jobotIntroStage1Tree1ga.enabled = false;
                jobotIntroStage1Tree1h.enabled = false;
            //    jobotIntroStage1Tree1ha.enabled = false;
                jobotIntroStage1Tree1i.enabled = false;
                jobotIntroStage1Tree1j.enabled = false;


                TTSJobotTree1.gameObject.SetActive(false);
                TTSJobotTree1a.gameObject.SetActive(false);
                TTSJobotTree1b.gameObject.SetActive(false);
                TTSJobotTree1c.gameObject.SetActive(false);
                TTSJobotTree1d.gameObject.SetActive(false);
                TTSJobotTree1e.gameObject.SetActive(false);
                TTSJobotTree1f.gameObject.SetActive(false);
                TTSJobotTree1g.gameObject.SetActive(true);
                TTSJobotTree1ga.gameObject.SetActive(false);
                TTSJobotTree1h.gameObject.SetActive(false);
            //    TTSJobotTree1ha.gameObject.SetActive(false);
                TTSJobotTree1i.gameObject.SetActive(false);
                TTSJobotTree1j.gameObject.SetActive(false);
                TTSIncorrectGuessPanal.gameObject.SetActive(false);
                IncorrectGuessPanal.gameObject.SetActive(false);
                TTSJobotTree1Proceed.gameObject.SetActive(false);
                jobotIntroStage1Tree1Proceed.enabled = false;

                if (!progressTextIsShowingSection2)
                { // 3 second delay
                    StartCoroutine(DelayProgressButtonVar1Section2());
                    progressTextIsShowingSection2 = true;
                }

            }

            if (currentStage1TreeText == 9)
            {
                //Time.timeScale = 1f;

                //  jobotIntroStage1e
                if (!textBeenReadSection2)
                {
                    progressTextPanel2.gameObject.SetActive(false);
                }
                jobotIntroStage1Tree.enabled = false;
                jobotIntroStage1Tree1a.enabled = false;
                jobotIntroStage1Tree1b.enabled = false;
                jobotIntroStage1Tree1c.enabled = false;
                jobotIntroStage1Tree1d.enabled = false;
                jobotIntroStage1Tree1e.enabled = false;
                jobotIntroStage1Tree1f.enabled = false;
                jobotIntroStage1Tree1g.enabled = false;
                jobotIntroStage1Tree1ga.enabled = true;
                jobotIntroStage1Tree1ga.gameObject.SetActive(true);
                jobotIntroStage1Tree1h.enabled = false;
           //     jobotIntroStage1Tree1ha.enabled = false;
                jobotIntroStage1Tree1i.enabled = false;
                jobotIntroStage1Tree1j.enabled = false;


                TTSJobotTree1.gameObject.SetActive(false);
                TTSJobotTree1a.gameObject.SetActive(false);
                TTSJobotTree1b.gameObject.SetActive(false);
                TTSJobotTree1c.gameObject.SetActive(false);
                TTSJobotTree1d.gameObject.SetActive(false);
                TTSJobotTree1e.gameObject.SetActive(false);
                TTSJobotTree1f.gameObject.SetActive(false);
                TTSJobotTree1g.gameObject.SetActive(false);
                TTSJobotTree1ga.gameObject.SetActive(true);
                TTSJobotTree1h.gameObject.SetActive(false);
            //    TTSJobotTree1ha.gameObject.SetActive(false);
                TTSJobotTree1i.gameObject.SetActive(false);
                TTSJobotTree1j.gameObject.SetActive(false);
                TTSIncorrectGuessPanal.gameObject.SetActive(false);
                IncorrectGuessPanal.gameObject.SetActive(false);
                TTSJobotTree1Proceed.gameObject.SetActive(false);
                jobotIntroStage1Tree1Proceed.enabled = false;

                if (!progressTextIsShowingSection2)
                { // 3 second delay
                    StartCoroutine(DelayProgressButtonVar1Section2());
                    progressTextIsShowingSection2 = true;
                }
            }

            if (currentStage1TreeText == 10)
            {
                //Time.timeScale = 0f;

                //  jobotIntroStage1e
                if (!textBeenReadSection2)
                {
                    progressTextPanel2.gameObject.SetActive(false);
                }
                jobotIntroStage1Tree.enabled = false;
                jobotIntroStage1Tree1a.enabled = false;
                jobotIntroStage1Tree1b.enabled = false;
                jobotIntroStage1Tree1c.enabled = false;
                jobotIntroStage1Tree1d.enabled = false;
                jobotIntroStage1Tree1e.enabled = false;
                jobotIntroStage1Tree1f.enabled = false;
                jobotIntroStage1Tree1g.enabled = false;
                jobotIntroStage1Tree1ga.enabled = false;
                jobotIntroStage1Tree1h.enabled = true;
                jobotIntroStage1Tree1h.gameObject.SetActive(true);
           //     jobotIntroStage1Tree1ha.enabled = false;
                jobotIntroStage1Tree1i.enabled = false;
                jobotIntroStage1Tree1j.enabled = false;


                TTSJobotTree1.gameObject.SetActive(false);
                TTSJobotTree1a.gameObject.SetActive(false);
                TTSJobotTree1b.gameObject.SetActive(false);
                TTSJobotTree1c.gameObject.SetActive(false);
                TTSJobotTree1d.gameObject.SetActive(false);
                TTSJobotTree1e.gameObject.SetActive(false);
                TTSJobotTree1f.gameObject.SetActive(false);
                TTSJobotTree1g.gameObject.SetActive(false);
                TTSJobotTree1ga.gameObject.SetActive(false);
                TTSJobotTree1h.gameObject.SetActive(true);
           //     TTSJobotTree1ha.gameObject.SetActive(false);
                TTSJobotTree1i.gameObject.SetActive(false);
                TTSJobotTree1j.gameObject.SetActive(false);
                TTSIncorrectGuessPanal.gameObject.SetActive(false);
                IncorrectGuessPanal.gameObject.SetActive(false);
                TTSJobotTree1Proceed.gameObject.SetActive(false);
                jobotIntroStage1Tree1Proceed.enabled = false;

               

            }
            /*
                        if (currentStage1TreeText == 11)
                        {
                            //Time.timeScale = 0f;

                            //  jobotIntroStage1e
                            jobotIntroStage1Tree.enabled = false;
                            jobotIntroStage1Tree1a.enabled = false;
                            jobotIntroStage1Tree1b.enabled = false;
                            jobotIntroStage1Tree1c.enabled = false;
                            jobotIntroStage1Tree1d.enabled = false;
                            jobotIntroStage1Tree1e.enabled = false;
                            jobotIntroStage1Tree1f.enabled = false;
                            jobotIntroStage1Tree1g.enabled = false;
                            jobotIntroStage1Tree1ga.enabled = false;
                            jobotIntroStage1Tree1h.enabled = false;
                            jobotIntroStage1Tree1ha.enabled = true;
                            jobotIntroStage1Tree1ha.gameObject.SetActive(true);
                            jobotIntroStage1Tree1i.enabled = false;
                            jobotIntroStage1Tree1j.enabled = false;


                            TTSJobotTree1.gameObject.SetActive(false);
                            TTSJobotTree1a.gameObject.SetActive(false);
                            TTSJobotTree1b.gameObject.SetActive(false);
                            TTSJobotTree1c.gameObject.SetActive(false);
                            TTSJobotTree1d.gameObject.SetActive(false);
                            TTSJobotTree1e.gameObject.SetActive(false);
                            TTSJobotTree1f.gameObject.SetActive(false);
                            TTSJobotTree1g.gameObject.SetActive(false);
                            TTSJobotTree1ga.gameObject.SetActive(false);
                            TTSJobotTree1h.gameObject.SetActive(false);
                            TTSJobotTree1ha.gameObject.SetActive(true);
                            TTSJobotTree1i.gameObject.SetActive(false);
                            TTSJobotTree1j.gameObject.SetActive(false);

                        }

            

            if (currentStage1TreeText == 11)
            {

                //  jobotIntroStage1e
                progressTextPanel2.gameObject.SetActive(false);
                jobotIntroStage1Tree.enabled = false;
                jobotIntroStage1Tree1a.enabled = false;
                jobotIntroStage1Tree1b.enabled = false;
                jobotIntroStage1Tree1c.enabled = false;
                jobotIntroStage1Tree1d.enabled = false;
                jobotIntroStage1Tree1e.enabled = false;
                jobotIntroStage1Tree1f.enabled = false;
                jobotIntroStage1Tree1g.enabled = false;
                jobotIntroStage1Tree1ga.enabled = false;
                jobotIntroStage1Tree1h.enabled = false;
              //  jobotIntroStage1Tree1ha.enabled = false;
                jobotIntroStage1Tree1i.gameObject.SetActive(true);
                jobotIntroStage1Tree1i.enabled = true;
                jobotIntroStage1Tree1j.enabled = false;


                TTSJobotTree1.gameObject.SetActive(false);
                TTSJobotTree1a.gameObject.SetActive(false);
                TTSJobotTree1b.gameObject.SetActive(false);
                TTSJobotTree1c.gameObject.SetActive(false);
                TTSJobotTree1d.gameObject.SetActive(false);
                TTSJobotTree1e.gameObject.SetActive(false);
                TTSJobotTree1f.gameObject.SetActive(false);
                TTSJobotTree1g.gameObject.SetActive(false);
                TTSJobotTree1ga.gameObject.SetActive(false);
                TTSJobotTree1h.gameObject.SetActive(false);
           //     TTSJobotTree1ha.gameObject.SetActive(false);
                TTSJobotTree1i.gameObject.SetActive(true);
                TTSJobotTree1j.gameObject.SetActive(false);
                TTSIncorrectGuessPanal.gameObject.SetActive(false);
                IncorrectGuessPanal.gameObject.SetActive(false);
                TTSJobotTree1Proceed.gameObject.SetActive(false);
                jobotIntroStage1Tree1Proceed.enabled = false;

            }
            */
            if (currentStage1TreeText == 12)
            {
                progressTextPanel2.gameObject.SetActive(false);
                //  jobotIntroStage1e
                jobotIntroStage1Tree.enabled = false;
                jobotIntroStage1Tree1a.enabled = false;
                jobotIntroStage1Tree1b.enabled = false;
                jobotIntroStage1Tree1c.enabled = false;
                jobotIntroStage1Tree1d.enabled = false;
                jobotIntroStage1Tree1e.enabled = false;
                jobotIntroStage1Tree1f.enabled = false;
              //  jobotIntroStage1Tree1g.enabled = false;
             //   jobotIntroStage1Tree1ga.enabled = false;
             //   jobotIntroStage1Tree1h.enabled = false;
             //   jobotIntroStage1Tree1ha.enabled = false;
            //    jobotIntroStage1Tree1i.enabled = false;
                jobotIntroStage1Tree1j.gameObject.SetActive(true);
                jobotIntroStage1Tree1j.enabled = true;


                TTSJobotTree1.gameObject.SetActive(false);
                TTSJobotTree1a.gameObject.SetActive(false);
                TTSJobotTree1b.gameObject.SetActive(false);
                TTSJobotTree1c.gameObject.SetActive(false);
                TTSJobotTree1d.gameObject.SetActive(false);
                TTSJobotTree1e.gameObject.SetActive(false);
                TTSJobotTree1f.gameObject.SetActive(false);
              //  TTSJobotTree1g.gameObject.SetActive(false);
              //  TTSJobotTree1ga.gameObject.SetActive(false);
             //   TTSJobotTree1h.gameObject.SetActive(false);
              //  TTSJobotTree1ha.gameObject.SetActive(false);
              //  TTSJobotTree1i.gameObject.SetActive(false);
                TTSJobotTree1j.gameObject.SetActive(true);
                TTSIncorrectGuessPanal.gameObject.SetActive(false);
                IncorrectGuessPanal.gameObject.SetActive(false);
                TTSJobotTree1Proceed.gameObject.SetActive(false);
                jobotIntroStage1Tree1Proceed.enabled = false;
            }

            if (currentStage1TreeText == 13)
            {
                if (!showProceedText)
                {
                    progressTextBackPanel2.gameObject.SetActive(false);
                    progressTextPanel2.gameObject.SetActive(false);
                    //  jobotIntroStage1e
                    jobotIntroStage1Tree.enabled = false;
                    jobotIntroStage1Tree1a.enabled = false;
                    jobotIntroStage1Tree1b.enabled = false;
                    jobotIntroStage1Tree1c.enabled = false;
                    jobotIntroStage1Tree1d.enabled = false;
                    jobotIntroStage1Tree1e.enabled = false;
                    jobotIntroStage1Tree1f.enabled = false;
                //    jobotIntroStage1Tree1g.enabled = false;
                //    jobotIntroStage1Tree1ga.enabled = false;
                //    jobotIntroStage1Tree1h.enabled = false;
                    //   jobotIntroStage1Tree1ha.enabled = false;
                //    jobotIntroStage1Tree1i.enabled = false;
                    jobotIntroStage1Tree1j.enabled = false;


                    TTSJobotTree1.gameObject.SetActive(false);
                    TTSJobotTree1a.gameObject.SetActive(false);
                    TTSJobotTree1b.gameObject.SetActive(false);
                    TTSJobotTree1c.gameObject.SetActive(false);
                    TTSJobotTree1d.gameObject.SetActive(false);
                    TTSJobotTree1e.gameObject.SetActive(false);
                    TTSJobotTree1f.gameObject.SetActive(false);
              //      TTSJobotTree1g.gameObject.SetActive(false);
             //       TTSJobotTree1ga.gameObject.SetActive(false);
             //       TTSJobotTree1h.gameObject.SetActive(false);
              //      //  TTSJobotTree1ha.gameObject.SetActive(false);
             //       TTSJobotTree1i.gameObject.SetActive(false);
                    TTSJobotTree1j.gameObject.SetActive(false);
                    StartCoroutine(Proceed());
                    TTSJobotTree1Proceed.gameObject.SetActive(true);
                    jobotIntroStage1Tree1Proceed.gameObject.SetActive(true);
                    jobotIntroStage1Tree1Proceed.enabled = true;
                    TTSIncorrectGuessPanal.gameObject.SetActive(false);
                    IncorrectGuessPanal.gameObject.SetActive(false);
                    showProceedText = true;
                }
             
            }

            if (currentStage1TreeText == 14)
            {
                if (!playerGuessedIncorrectAlready) 
                {
                    //inGameCanvas.gameObject.SetActive(true);
                    // inGameCanvas.SetActive(true);
                progressTextBackPanel2.gameObject.SetActive(false);
                    progressTextPanel2.gameObject.SetActive(false);
                    //  jobotIntroStage1e
                    jobotIntroStage1Tree.enabled = false;
                    jobotIntroStage1Tree1a.enabled = false;
                    jobotIntroStage1Tree1b.enabled = false;
                    jobotIntroStage1Tree1c.enabled = false;
                    jobotIntroStage1Tree1d.enabled = false;
                    jobotIntroStage1Tree1e.enabled = false;
                    jobotIntroStage1Tree1f.enabled = false;
              //      jobotIntroStage1Tree1g.enabled = false;
              //      jobotIntroStage1Tree1ga.enabled = false;
              //      jobotIntroStage1Tree1h.enabled = false;
                    //   jobotIntroStage1Tree1ha.enabled = false;
            //        jobotIntroStage1Tree1i.enabled = false;
                    jobotIntroStage1Tree1j.enabled = false;


                    TTSJobotTree1.gameObject.SetActive(false);
                    TTSJobotTree1a.gameObject.SetActive(false);
                    TTSJobotTree1b.gameObject.SetActive(false);
                    TTSJobotTree1c.gameObject.SetActive(false);
                    TTSJobotTree1d.gameObject.SetActive(false);
                    TTSJobotTree1e.gameObject.SetActive(false);
                    TTSJobotTree1f.gameObject.SetActive(false);
             //       TTSJobotTree1g.gameObject.SetActive(false);
            //        TTSJobotTree1ga.gameObject.SetActive(false);
           //         TTSJobotTree1h.gameObject.SetActive(false);
                    //  TTSJobotTree1ha.gameObject.SetActive(false);
          //          TTSJobotTree1i.gameObject.SetActive(false);
                    TTSJobotTree1j.gameObject.SetActive(false);
                
                    TTSJobotTree1Proceed.gameObject.SetActive(false);
                    jobotIntroStage1Tree1Proceed.enabled = false;

                    TTSIncorrectGuessPanal.gameObject.SetActive(true);
                    IncorrectGuessPanal.gameObject.SetActive(true);
                     IncorrectGuessPanal.enabled = true;
                    playerGuessedIncorrectAlready = true;
                    StartCoroutine(IncorrectGuess());
                }
            }

            if (rgEggScript.eggClickCounter >= 2)
                {
                    if (!runStartOnce)
                    {
                       StartCoroutine(WaitForCamera());
                       StartCoroutine(HideMiniGameCanvasTemporarley());
                       runStartOnce = true;
                       robCont.NewNavmeshStop();
                    }
                }

          //  if (Input.GetKeyDown(KeyCode.T))
          //  {
          //      StartCoroutine(EatenByEnemy());
          //  }

           

        }


        void OnMouseDown()
        {

            robCont.NewNavmeshStop();
            if (rgMain.currentGameStage == 1)
            {
                Debug.Log("Mouse Clicked");
                cameraFollow.camFollowTree = true;
                currentStage1TreeText = 1;
                robCont.NewNavmeshStop();
                robotNavMeshAgentToStop.GetComponent<NavMeshAgent>().isStopped = true;               
            }

        }

       
        
        public IEnumerator WaitForCamera()
        {
            yield return new WaitForSeconds(1);
          
            mgCanvastoShow.enabled = true;
            UICanvasToHide.SetActive(false);
            stage1MGLevel.SetActive(true);
            overWorldMGToHide.SetActive(false);
            playerCam.enabled = false;
            catControl.enabled = true;
            cataCam.enabled = true;
           

        }

        public IEnumerator HideMiniGameCanvasTemporarley()
        {
            yield return new WaitForSeconds(2);
            textPanal.SetActive(true);
           

        }

        public IEnumerator MiniGameTextDoneWith()
        {
            yield return new WaitForSeconds(9);
            mgTextPanal.SetActive(false);
            catControl.enabled = true;


        }


        public IEnumerator DelayCatController()
        {
            yield return new WaitForSeconds(0.2f);
            catControl.enabled = false;


        }

        public IEnumerator EatenByEnemy()
        {
            currentStage1TreeText = 11;
            // inGameCanvas.SetActive(true);
            inGameCanvas.SetActive(true);
            yield return new WaitForSeconds(3);
            inGameCanvas.SetActive(false);


        }

        public IEnumerator EatenByEnemy2()
        {
            currentStage1TreeText = 12;
            inGameCanvas.SetActive(true);
            yield return new WaitForSeconds(3);
            inGameCanvas.SetActive(false);


        }

        public IEnumerator Proceed()
        {
            currentStage1TreeText = 13;
            inGameCanvas.SetActive(true);
            yield return new WaitForSeconds(5);
            inGameCanvas.SetActive(false);


        }

        public IEnumerator IncorrectGuess()
        {
            currentStage1TreeText = 14;
            inGameCanvas.SetActive(true);
            yield return new WaitForSeconds(5);
            inGameCanvas.SetActive(false);


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

        }

        void OnClickPanel2()
        {
            currentStage1TreeText++;
            Debug.Log("ButtonPressed");
            textBeenReadSection2 = false;
            progressTextIsShowingSection2 = false;
        }

        void OnClickBackPanal2()
        {
            currentStage1TreeText--;
        }

        void JobotStage1Tree1()
        {
            LOLSDK.Instance.SpeakText("stage1MiniGameInfo");
        }

        void JobotStage1Tree2()
        {
            LOLSDK.Instance.SpeakText("stage1MiniGameInfoa");
        }

        void JobotStage1Tree3()
        {
            LOLSDK.Instance.SpeakText("stage1MiniGameInfob");
        }
        void JobotStage1Tree4()
        {
            LOLSDK.Instance.SpeakText("stage1MiniGameInfoc");
        }

        void JobotStage1Tree5()
        {
            LOLSDK.Instance.SpeakText("stage1MiniGameInfod");
        }

        void JobotStage1Tree6()
        {
            LOLSDK.Instance.SpeakText("stage1MiniGameInfoe");

        }

        void JobotStage1Tree7()
        {
            LOLSDK.Instance.SpeakText("stage1MiniGameInfof");
        }
     

        void JobotStage1Tree11()
        {
            LOLSDK.Instance.SpeakText("stage1MiniGameInfoPlayerEatena");

        }

        void JobotStage1Tree1Proceed()
        {
            LOLSDK.Instance.SpeakText("stage1MiniGameInfoProceedToEnd");

        }

        public void StartTextProcessStage1()
        {
            currentStage1TreeText = 1;
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


        public IEnumerator DelayProgressButtonSection2()
        {
            yield return new WaitForSeconds(3);
            progressTextPanel2.gameObject.SetActive(true);
            textBeenReadSection2 = true;

        }

        public IEnumerator DelayProgressButtonVar2Section2()
        {
            yield return new WaitForSeconds(2);
            progressTextPanel2.gameObject.SetActive(true);
            textBeenReadSection2 = true;

        }

        public IEnumerator DelayProgressButtonVar1Section2()
        {
            yield return new WaitForSeconds(1);
            progressTextPanel2.gameObject.SetActive(true);
            textBeenReadSection2 = true;

        }
    }
}

