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
                textPanalToHide.SetActive(false);
                jobotIntroStage1Section1.enabled = false;
           //     jobotIntroStage1Section1a.enabled = false;
                jobotIntroStage1Section1b.enabled = false;
                jobotIntroStage1Section1c.enabled = false;
                jobotIntroStage1Section1d.enabled = false;
                jobotIntroStage1Section1e.enabled = false;
                jobotIntroStage1Section1f.enabled = false;
                jobotIntroStage1Section1g.enabled = false;
                jobotIntroStage1Section1h.enabled = false;
                jobotIntroStage1Section1i.enabled = false;
           //     jobotIntroStage1Section1j.enabled = false;
                jobotIntroStage1Section1k.enabled = false;
          //      jobotIntroStage1Section1l.enabled = false;
                jobotIntroStage1Section1m.enabled = false;
                jobotFlowersWatered.enabled = false;

                TTSJobot1.gameObject.SetActive(false);
          //      TTSJobot2.gameObject.SetActive(false);
                TTSJobot3.gameObject.SetActive(false);
                TTSJobot4.gameObject.SetActive(false);
                TTSJobot5.gameObject.SetActive(false);
                TTSJobot6.gameObject.SetActive(false);
                TTSJobot7.gameObject.SetActive(false);
                TTSJobot8.gameObject.SetActive(false);
                TTSJobot9.gameObject.SetActive(false);
                TTSJobot10.gameObject.SetActive(false);
           //     TTSJobot11.gameObject.SetActive(false);
                TTSJobot12.gameObject.SetActive(false);
           ////     TTSJobot13.gameObject.SetActive(false);
                TTSJobot14.gameObject.SetActive(false);
                TTSJobot15.gameObject.SetActive(false);

         //       stageComplete.enabled = false;
                TTSJobot16.gameObject.SetActive(false);
            }
        }


        private void Update()
        {
            if (rgMainData.currentGameStage == 3)
            {
                //  jobotIntroStage1
                if (currentStageOfText == 1)
                {
                    if (!textBeenRead)
                    {
                        progressText.gameObject.SetActive(false);
                    }
                    textPanalToHide.SetActive(true);
                    progressTextBack.gameObject.SetActive(false);
                    jobotIntroStage1Section1.enabled = true;
               //     jobotIntroStage1Section1a.enabled = false;
                    jobotIntroStage1Section1b.enabled = false;
                    jobotIntroStage1Section1c.enabled = false;
                    jobotIntroStage1Section1d.enabled = false;
                    jobotIntroStage1Section1e.enabled = false;
                    jobotIntroStage1Section1f.enabled = false;
                    jobotIntroStage1Section1g.enabled = false;
                    jobotIntroStage1Section1h.enabled = false;
                    jobotIntroStage1Section1i.enabled = false;
                //    jobotIntroStage1Section1j.enabled = false;
                    jobotIntroStage1Section1k.enabled = false;
                //    jobotIntroStage1Section1l.enabled = false;
                    jobotIntroStage1Section1m.enabled = false;
                    jobotFlowersWatered.enabled = false;


                    TTSJobot1.gameObject.SetActive(true);
                //    TTSJobot2.gameObject.SetActive(false);
                    TTSJobot3.gameObject.SetActive(false);
                    TTSJobot4.gameObject.SetActive(false);
                    TTSJobot5.gameObject.SetActive(false);
                    TTSJobot6.gameObject.SetActive(false);
                    TTSJobot7.gameObject.SetActive(false);
                    TTSJobot8.gameObject.SetActive(false);
                    TTSJobot9.gameObject.SetActive(false);
                    TTSJobot10.gameObject.SetActive(false);
              //     TTSJobot11.gameObject.SetActive(false);
                    TTSJobot12.gameObject.SetActive(false);
              //      TTSJobot13.gameObject.SetActive(false);
                    TTSJobot14.gameObject.SetActive(false);
                    TTSJobot15.gameObject.SetActive(false);
                    doorAnim.SetBool("closeDoor", true);
           //         stageComplete.enabled = false;
    
                    TTSJobot16.gameObject.SetActive(false);
                    if (!progressTextIsShowing)
                    { // 3 second delay
                        StartCoroutine(DelayProgressButtonVar1());
                        progressTextIsShowing = true;
                    }

                }
                /*
                if (currentStageOfText == 2)
                {
                    if (!textBeenRead)
                    {
                        progressText.gameObject.SetActive(false);
                    }
                    progressTextBack.gameObject.SetActive(true);
                    //  jobotIntroStage1a
                    jobotIntroStage1Section1.enabled = false;
                    jobotIntroStage1Section1a.enabled = true;
                    jobotIntroStage1Section1b.enabled = false;
                    jobotIntroStage1Section1c.enabled = false;
                    jobotIntroStage1Section1d.enabled = false;
                    jobotIntroStage1Section1e.enabled = false;
                    jobotIntroStage1Section1f.enabled = false;
                    jobotIntroStage1Section1g.enabled = false;
                    jobotIntroStage1Section1h.enabled = false;
                    jobotIntroStage1Section1i.enabled = false;
                    jobotIntroStage1Section1j.enabled = false;
                    jobotIntroStage1Section1k.enabled = false;
                    jobotIntroStage1Section1l.enabled = false;
                    jobotIntroStage1Section1m.enabled = false;
                    jobotFlowersWatered.enabled = false;

                    TTSJobot1.gameObject.SetActive(false);
                    TTSJobot2.gameObject.SetActive(true);
                    TTSJobot3.gameObject.SetActive(false);
                    TTSJobot4.gameObject.SetActive(false);
                    TTSJobot5.gameObject.SetActive(false);
                    TTSJobot6.gameObject.SetActive(false);
                    TTSJobot7.gameObject.SetActive(false);
                    TTSJobot8.gameObject.SetActive(false);
                    TTSJobot9.gameObject.SetActive(false);
                    TTSJobot10.gameObject.SetActive(false);
                    TTSJobot11.gameObject.SetActive(false);
                    TTSJobot12.gameObject.SetActive(false);
                    TTSJobot13.gameObject.SetActive(false);
                    TTSJobot14.gameObject.SetActive(false);
                    TTSJobot15.gameObject.SetActive(false);
                    stageComplete.enabled = false;
                    TTSJobot16.gameObject.SetActive(false);
                    if (!progressTextIsShowing)
                    { // 3 second delay
                        StartCoroutine(DelayProgressButtonVar1());
                        progressTextIsShowing = true;
                    }

                }
                */
                if (currentStageOfText == 2)
                {
                    if (!textBeenRead)
                    {
                        progressText.gameObject.SetActive(false);
                    }
                    progressTextBack.gameObject.SetActive(true);
                    //  jobotIntroStage1b
                    jobotIntroStage1Section1.enabled = false;
                  //  jobotIntroStage1Section1a.enabled = false;
                    jobotIntroStage1Section1b.enabled = true;
                    jobotIntroStage1Section1c.enabled = false;
                    jobotIntroStage1Section1d.enabled = false;
                    jobotIntroStage1Section1e.enabled = false;
                    jobotIntroStage1Section1f.enabled = false;
                    jobotIntroStage1Section1g.enabled = false;
                    jobotIntroStage1Section1h.enabled = false;
                    jobotIntroStage1Section1i.enabled = false;
               //     jobotIntroStage1Section1j.enabled = false;
                    jobotIntroStage1Section1k.enabled = false;
               //     jobotIntroStage1Section1l.enabled = false;
                    jobotIntroStage1Section1m.enabled = false;
                    jobotFlowersWatered.enabled = false;

                    TTSJobot1.gameObject.SetActive(false);
               //     TTSJobot2.gameObject.SetActive(false);
                    TTSJobot3.gameObject.SetActive(true);
                    TTSJobot4.gameObject.SetActive(false);
                    TTSJobot5.gameObject.SetActive(false);
                    TTSJobot6.gameObject.SetActive(false);
                    TTSJobot7.gameObject.SetActive(false);
                    TTSJobot8.gameObject.SetActive(false);
                    TTSJobot9.gameObject.SetActive(false);
                    TTSJobot10.gameObject.SetActive(false);
              //      TTSJobot11.gameObject.SetActive(false);
                    TTSJobot12.gameObject.SetActive(false);
              //      TTSJobot13.gameObject.SetActive(false);
                    TTSJobot14.gameObject.SetActive(false);
                    TTSJobot15.gameObject.SetActive(false);

            //        stageComplete.enabled = false;
                    TTSJobot16.gameObject.SetActive(false);
                    if (!progressTextIsShowing)
                    { // 3 second delay
                        StartCoroutine(DelayProgressButtonVar1());
                        progressTextIsShowing = true;
                    }

                }

                if (currentStageOfText == 3)
                {
                    if (!textBeenRead)
                    {
                        progressText.gameObject.SetActive(false);
                    }
                    //  jobotIntroStage1c
                    jobotIntroStage1Section1.enabled = false;
               //     jobotIntroStage1Section1a.enabled = false;
                    jobotIntroStage1Section1b.enabled = false;
                    jobotIntroStage1Section1c.enabled = true;
                    jobotIntroStage1Section1d.enabled = false;
                    jobotIntroStage1Section1e.enabled = false;
                    jobotIntroStage1Section1f.enabled = false;
                    jobotIntroStage1Section1g.enabled = false;
                    jobotIntroStage1Section1h.enabled = false;
                    jobotIntroStage1Section1i.enabled = false;
               //     jobotIntroStage1Section1j.enabled = false;
                    jobotIntroStage1Section1k.enabled = false;
               //     jobotIntroStage1Section1l.enabled = false;
                    jobotIntroStage1Section1m.enabled = false;
                    jobotFlowersWatered.enabled = false;

                    TTSJobot1.gameObject.SetActive(false);
               //     TTSJobot2.gameObject.SetActive(false);
                    TTSJobot3.gameObject.SetActive(false);
                    TTSJobot4.gameObject.SetActive(true);
                    TTSJobot5.gameObject.SetActive(false);
                    TTSJobot6.gameObject.SetActive(false);
                    TTSJobot7.gameObject.SetActive(false);
                    TTSJobot8.gameObject.SetActive(false);
                    TTSJobot9.gameObject.SetActive(false);
                    TTSJobot10.gameObject.SetActive(false);
              //      TTSJobot11.gameObject.SetActive(false);
                    TTSJobot12.gameObject.SetActive(false);
               //     TTSJobot13.gameObject.SetActive(false);
                    TTSJobot14.gameObject.SetActive(false);
                    TTSJobot15.gameObject.SetActive(false);

             //       stageComplete.enabled = false;
                    TTSJobot16.gameObject.SetActive(false);
                    if (!progressTextIsShowing)
                    { // 3 second delay
                        StartCoroutine(DelayProgressButtonVar1());
                        progressTextIsShowing = true;
                    }

                }

                if (currentStageOfText == 4)
                {
                    if (!textBeenRead)
                    {
                        progressText.gameObject.SetActive(false);
                    }
                    //  jobotIntroStage1d
                    jobotIntroStage1Section1.enabled = false;
              //      jobotIntroStage1Section1a.enabled = false;
                    jobotIntroStage1Section1b.enabled = false;
                    jobotIntroStage1Section1c.enabled = false;
                    jobotIntroStage1Section1d.enabled = true;
                    jobotIntroStage1Section1e.enabled = false;
                    jobotIntroStage1Section1f.enabled = false;
                    jobotIntroStage1Section1g.enabled = false;
                    jobotIntroStage1Section1h.enabled = false;
                    jobotIntroStage1Section1i.enabled = false;
               //     jobotIntroStage1Section1j.enabled = false;
                    jobotIntroStage1Section1k.enabled = false;
              //      jobotIntroStage1Section1l.enabled = false;
                    jobotIntroStage1Section1m.enabled = false;
                    jobotFlowersWatered.enabled = false;

                    TTSJobot1.gameObject.SetActive(false);
               //     TTSJobot2.gameObject.SetActive(false);
                    TTSJobot3.gameObject.SetActive(false);
                    TTSJobot4.gameObject.SetActive(false);
                    TTSJobot5.gameObject.SetActive(true);
                    TTSJobot6.gameObject.SetActive(false);
                    TTSJobot7.gameObject.SetActive(false);
                    TTSJobot8.gameObject.SetActive(false);
                    TTSJobot9.gameObject.SetActive(false);
                    TTSJobot10.gameObject.SetActive(false);
             //       TTSJobot11.gameObject.SetActive(false);
                    TTSJobot12.gameObject.SetActive(false);
             //       TTSJobot13.gameObject.SetActive(false);
                    TTSJobot14.gameObject.SetActive(false);
                    TTSJobot15.gameObject.SetActive(false);

              //      stageComplete.enabled = false;
                    TTSJobot16.gameObject.SetActive(false);
                    if (!progressTextIsShowing)
                    { // 3 second delay
                        StartCoroutine(DelayProgressButtonVar2());
                        progressTextIsShowing = true;
                    }

                }

                if (currentStageOfText == 5)
                {
                    //  jobotIntroStage1e

                    if (!textBeenRead)
                    {
                        progressText.gameObject.SetActive(false);
                    }
                    jobotIntroStage1Section1.enabled = false;
             //       jobotIntroStage1Section1a.enabled = false;
                    jobotIntroStage1Section1b.enabled = false;
                    jobotIntroStage1Section1c.enabled = false;
                    jobotIntroStage1Section1d.enabled = false;
                    jobotIntroStage1Section1e.enabled = true;
                    jobotIntroStage1Section1f.enabled = false;
                    jobotIntroStage1Section1g.enabled = false;
                    jobotIntroStage1Section1h.enabled = false;
                    jobotIntroStage1Section1i.enabled = false;
             //       jobotIntroStage1Section1j.enabled = false;
                    jobotIntroStage1Section1k.enabled = false;
             //       jobotIntroStage1Section1l.enabled = false;
                    jobotIntroStage1Section1m.enabled = false;
                    jobotFlowersWatered.enabled = false;

                    TTSJobot1.gameObject.SetActive(false);
            //        TTSJobot2.gameObject.SetActive(false);
                    TTSJobot3.gameObject.SetActive(false);
                    TTSJobot4.gameObject.SetActive(false);
                    TTSJobot5.gameObject.SetActive(false);
                    TTSJobot6.gameObject.SetActive(true);
                    TTSJobot7.gameObject.SetActive(false);
                    TTSJobot8.gameObject.SetActive(false);
                    TTSJobot9.gameObject.SetActive(false);
                    TTSJobot10.gameObject.SetActive(false);
           //         TTSJobot11.gameObject.SetActive(false);
                    TTSJobot12.gameObject.SetActive(false);
           //         TTSJobot13.gameObject.SetActive(false);
                    TTSJobot14.gameObject.SetActive(false);
                    TTSJobot15.gameObject.SetActive(false);
            //        stageComplete.enabled = false;
                    TTSJobot16.gameObject.SetActive(false);
                    if (!progressTextIsShowing)
                    { // 3 second delay
                        StartCoroutine(DelayProgressButtonVar2());
                        progressTextIsShowing = true;
                    }
                }

                if (currentStageOfText == 6)
                {
                    //  jobotIntroStage1f
                    if (!textBeenRead)
                    {
                        progressText.gameObject.SetActive(false);
                    }
                    jobotIntroStage1Section1.enabled = false;
           //         jobotIntroStage1Section1a.enabled = false;
                    jobotIntroStage1Section1b.enabled = false;
                    jobotIntroStage1Section1c.enabled = false;
                    jobotIntroStage1Section1d.enabled = false;
                    jobotIntroStage1Section1e.enabled = false;
                    jobotIntroStage1Section1f.enabled = true;
                    jobotIntroStage1Section1g.enabled = false;
                    jobotIntroStage1Section1h.enabled = false;
                    jobotIntroStage1Section1i.enabled = false;
            //        jobotIntroStage1Section1j.enabled = false;
                    jobotIntroStage1Section1k.enabled = false;
            //        jobotIntroStage1Section1l.enabled = false;
                    jobotIntroStage1Section1m.enabled = false;
                    jobotFlowersWatered.enabled = false;

                    TTSJobot1.gameObject.SetActive(false);
           //         TTSJobot2.gameObject.SetActive(false);
                    TTSJobot3.gameObject.SetActive(false);
                    TTSJobot4.gameObject.SetActive(false);
                    TTSJobot5.gameObject.SetActive(false);
                    TTSJobot6.gameObject.SetActive(false);
                    TTSJobot7.gameObject.SetActive(true);
                    TTSJobot8.gameObject.SetActive(false);
                    TTSJobot9.gameObject.SetActive(false);
                    TTSJobot10.gameObject.SetActive(false);
          //          TTSJobot11.gameObject.SetActive(false);
                    TTSJobot12.gameObject.SetActive(false);
          //          TTSJobot13.gameObject.SetActive(false);
                    TTSJobot14.gameObject.SetActive(false);
                    TTSJobot15.gameObject.SetActive(false);
           //         stageComplete.enabled = false;
                    TTSJobot16.gameObject.SetActive(false);
                    // taskPanal.SetActive(false);
                    if (!progressTextIsShowing)
                    { // 3 second delay
                        StartCoroutine(DelayProgressButtonVar2());
                        progressTextIsShowing = true;
                    }
                }

                if (currentStageOfText == 7)
                {
                    //  jobotIntroStage1g
                    if (!textBeenRead)
                    {
                        progressText.gameObject.SetActive(false);
                    }
                    jobotIntroStage1Section1.enabled = false;
           //         jobotIntroStage1Section1a.enabled = false;
                    jobotIntroStage1Section1b.enabled = false;
                    jobotIntroStage1Section1c.enabled = false;
                    jobotIntroStage1Section1d.enabled = false;
                    jobotIntroStage1Section1e.enabled = false;
                    jobotIntroStage1Section1f.enabled = false;
                    jobotIntroStage1Section1g.enabled = true;
                    jobotIntroStage1Section1h.enabled = false;
                    jobotIntroStage1Section1i.enabled = false;
           //         jobotIntroStage1Section1j.enabled = false;
                    jobotIntroStage1Section1k.enabled = false;
           //         jobotIntroStage1Section1l.enabled = false;
                    jobotIntroStage1Section1m.enabled = false;
                    jobotFlowersWatered.enabled = false;

                    TTSJobot1.gameObject.SetActive(false);
         //           TTSJobot2.gameObject.SetActive(false);
                    TTSJobot3.gameObject.SetActive(false);
                    TTSJobot4.gameObject.SetActive(false);
                    TTSJobot5.gameObject.SetActive(false);
                    TTSJobot6.gameObject.SetActive(false);
                    TTSJobot7.gameObject.SetActive(false);
                    TTSJobot8.gameObject.SetActive(true);
                    TTSJobot9.gameObject.SetActive(false);
                    TTSJobot10.gameObject.SetActive(false);
         //           TTSJobot11.gameObject.SetActive(false);
                    TTSJobot12.gameObject.SetActive(false);
         //           TTSJobot13.gameObject.SetActive(false);
                    TTSJobot14.gameObject.SetActive(false);
                    TTSJobot15.gameObject.SetActive(false);
          //          stageComplete.enabled = false;
                    TTSJobot16.gameObject.SetActive(false);
                    if (!progressTextIsShowing)
                    { // 3 second delay
                        StartCoroutine(DelayProgressButtonVar2());
                        progressTextIsShowing = true;
                    }
                }

                if (currentStageOfText == 8)
                {
                    //  jobotIntroStage1h
                    if (!textBeenRead)
                    {
                        progressText.gameObject.SetActive(false);
                    }
                    jobotIntroStage1Section1.enabled = false;
         ///           jobotIntroStage1Section1a.enabled = false;
                    jobotIntroStage1Section1b.enabled = false;
                    jobotIntroStage1Section1c.enabled = false;
                    jobotIntroStage1Section1d.enabled = false;
                    jobotIntroStage1Section1e.enabled = false;
                    jobotIntroStage1Section1f.enabled = false;
                    jobotIntroStage1Section1g.enabled = false;
                    jobotIntroStage1Section1h.enabled = true;
                    jobotIntroStage1Section1i.enabled = false;
        //            jobotIntroStage1Section1j.enabled = false;
                    jobotIntroStage1Section1k.enabled = false;
       //             jobotIntroStage1Section1l.enabled = false;
                    jobotIntroStage1Section1m.enabled = false;
                    jobotFlowersWatered.enabled = false;

                    TTSJobot1.gameObject.SetActive(false);
         //           TTSJobot2.gameObject.SetActive(false);
                    TTSJobot3.gameObject.SetActive(false);
                    TTSJobot4.gameObject.SetActive(false);
                    TTSJobot5.gameObject.SetActive(false);
                    TTSJobot6.gameObject.SetActive(false);
                    TTSJobot7.gameObject.SetActive(false);
                    TTSJobot8.gameObject.SetActive(false);
                    TTSJobot9.gameObject.SetActive(true);
                    TTSJobot10.gameObject.SetActive(false);
          //          TTSJobot11.gameObject.SetActive(false);
                    TTSJobot12.gameObject.SetActive(false);
          //          TTSJobot13.gameObject.SetActive(false);
                    TTSJobot14.gameObject.SetActive(false);
                    TTSJobot15.gameObject.SetActive(false);
             //       stageComplete.enabled = false;
                    TTSJobot16.gameObject.SetActive(false);
                    if (!progressTextIsShowing)
                    { // 3 second delay
                        StartCoroutine(DelayProgressButtonVar1());
                        progressTextIsShowing = true;
                    }
                }

                if (currentStageOfText == 9)
                { //  jobotIntroStage1i
                    if (!textBeenRead)
                    {
                        progressText.gameObject.SetActive(false);
                    }
                    jobotIntroStage1Section1.enabled = false;
               //     jobotIntroStage1Section1a.enabled = false;
                    jobotIntroStage1Section1b.enabled = false;
                    jobotIntroStage1Section1c.enabled = false;
                    jobotIntroStage1Section1d.enabled = false;
                    jobotIntroStage1Section1e.enabled = false;
                    jobotIntroStage1Section1f.enabled = false;
                    jobotIntroStage1Section1g.enabled = false;
                    jobotIntroStage1Section1h.enabled = false;
                    jobotIntroStage1Section1i.enabled = true;
               //     jobotIntroStage1Section1j.enabled = false;
                    jobotIntroStage1Section1k.enabled = false;
               //     jobotIntroStage1Section1l.enabled = false;
                    jobotIntroStage1Section1m.enabled = false;
                    jobotFlowersWatered.enabled = false;

                    TTSJobot1.gameObject.SetActive(false);
             //       TTSJobot2.gameObject.SetActive(false);
                    TTSJobot3.gameObject.SetActive(false);
                    TTSJobot4.gameObject.SetActive(false);
                    TTSJobot5.gameObject.SetActive(false);
                    TTSJobot6.gameObject.SetActive(false);
                    TTSJobot7.gameObject.SetActive(false);
                    TTSJobot8.gameObject.SetActive(false);
                    TTSJobot9.gameObject.SetActive(false);
                    TTSJobot10.gameObject.SetActive(true);
              //      TTSJobot11.gameObject.SetActive(false);
                    TTSJobot12.gameObject.SetActive(false);
              //      TTSJobot13.gameObject.SetActive(false);
                    TTSJobot14.gameObject.SetActive(false);
                    TTSJobot15.gameObject.SetActive(false);
             //       stageComplete.enabled = false;
                    TTSJobot16.gameObject.SetActive(false);
                    if (!progressTextIsShowing)
                    { // 3 second delay
                        StartCoroutine(DelayProgressButtonVar2());
                        progressTextIsShowing = true;
                    }
                }
/*
                if (currentStageOfText == 11)
                {

                    // Jobotintrostage1j
                    if (!textBeenRead)
                    {
                        progressText.gameObject.SetActive(false);
                    }
                    jobotIntroStage1Section1.enabled = false;
              //      jobotIntroStage1Section1a.enabled = false;
                    jobotIntroStage1Section1b.enabled = false;
                    jobotIntroStage1Section1c.enabled = false;
                    jobotIntroStage1Section1d.enabled = false;
                    jobotIntroStage1Section1e.enabled = false;
                    jobotIntroStage1Section1f.enabled = false;
                    jobotIntroStage1Section1g.enabled = false;
                    jobotIntroStage1Section1h.enabled = false;
                    jobotIntroStage1Section1i.enabled = false;
              ///      jobotIntroStage1Section1j.enabled = true;
                    jobotIntroStage1Section1k.enabled = false;
             //       jobotIntroStage1Section1l.enabled = false;
                    jobotIntroStage1Section1m.enabled = false;
                    jobotFlowersWatered.enabled = false;

                    TTSJobot1.gameObject.SetActive(false);
             //       TTSJobot2.gameObject.SetActive(false);
                    TTSJobot3.gameObject.SetActive(false);
                    TTSJobot4.gameObject.SetActive(false);
                    TTSJobot5.gameObject.SetActive(false);
                    TTSJobot6.gameObject.SetActive(false);
                    TTSJobot7.gameObject.SetActive(false);
                    TTSJobot8.gameObject.SetActive(false);
                    TTSJobot9.gameObject.SetActive(false);
                    TTSJobot10.gameObject.SetActive(false);
                //    TTSJobot11.gameObject.SetActive(true);
                    TTSJobot12.gameObject.SetActive(false);
              //      TTSJobot13.gameObject.SetActive(false);
                    TTSJobot14.gameObject.SetActive(false);
                    TTSJobot15.gameObject.SetActive(false);
                    stageComplete.enabled = false;
                    TTSJobot16.gameObject.SetActive(false);
                    if (!progressTextIsShowing)
                    { // 3 second delay
                        StartCoroutine(DelayProgressButtonVar2());
                        progressTextIsShowing = true;
                    }
                }
*/
                if (currentStageOfText == 10)
                {
                    // Jobotintrostage1k
                    if (!textBeenRead)
                    {
                        progressText.gameObject.SetActive(false);
                    }
                    jobotIntroStage1Section1.enabled = false;
            //        jobotIntroStage1Section1a.enabled = false;
                    jobotIntroStage1Section1b.enabled = false;
                    jobotIntroStage1Section1c.enabled = false;
                    jobotIntroStage1Section1d.enabled = false;
                    jobotIntroStage1Section1e.enabled = false;
                    jobotIntroStage1Section1f.enabled = false;
                    jobotIntroStage1Section1g.enabled = false;
                    jobotIntroStage1Section1h.enabled = false;
                    jobotIntroStage1Section1i.enabled = false;
              ///      jobotIntroStage1Section1j.enabled = false;
                    jobotIntroStage1Section1k.enabled = true;
            //        jobotIntroStage1Section1l.enabled = false;
                    jobotIntroStage1Section1m.enabled = false;
                    jobotFlowersWatered.enabled = false;

                    TTSJobot1.gameObject.SetActive(false);
              //      TTSJobot2.gameObject.SetActive(false);
                    TTSJobot3.gameObject.SetActive(false);
                    TTSJobot4.gameObject.SetActive(false);
                    TTSJobot5.gameObject.SetActive(false);
                    TTSJobot6.gameObject.SetActive(false);
                    TTSJobot7.gameObject.SetActive(false);
                    TTSJobot8.gameObject.SetActive(false);
                    TTSJobot9.gameObject.SetActive(false);
                    TTSJobot10.gameObject.SetActive(false);
             //       TTSJobot11.gameObject.SetActive(false);
                    TTSJobot12.gameObject.SetActive(true);
              //      TTSJobot13.gameObject.SetActive(false);
                    TTSJobot14.gameObject.SetActive(false);
                    TTSJobot15.gameObject.SetActive(false);
             //       stageComplete.enabled = false;
                    TTSJobot16.gameObject.SetActive(false);
                    doorAnim.SetBool("doorNeedsToBeOpen", false);
                    doorAnim.SetBool("closeDoor", false);
                    doorAnim.SetTrigger("resetDoorValues");
                    if (!progressTextIsShowing)
                    { // 3 second delay
                        StartCoroutine(DelayProgressButtonVar2());
                        progressTextIsShowing = true;
                    }
                }
                /*
                if (currentStageOfText == 13)
                {
                    // Jobotintrostage1l
                    if (!textBeenRead)
                    {
                        progressText.gameObject.SetActive(false);
                    }
                    jobotIntroStage1Section1.enabled = false;
             //       jobotIntroStage1Section1a.enabled = false;
                    jobotIntroStage1Section1b.enabled = false;
                    jobotIntroStage1Section1c.enabled = false;
                    jobotIntroStage1Section1d.enabled = false;
                    jobotIntroStage1Section1e.enabled = false;
                    jobotIntroStage1Section1f.enabled = false;
                    jobotIntroStage1Section1g.enabled = false;
                    jobotIntroStage1Section1h.enabled = false;
                    jobotIntroStage1Section1i.enabled = false;
              //      jobotIntroStage1Section1j.enabled = false;
                    jobotIntroStage1Section1k.enabled = false;
             //       jobotIntroStage1Section1l.enabled = true;
                    jobotIntroStage1Section1m.enabled = false;
                    jobotFlowersWatered.enabled = false;

                    TTSJobot1.gameObject.SetActive(false);
             //       TTSJobot2.gameObject.SetActive(false);
                    TTSJobot3.gameObject.SetActive(false);
                    TTSJobot4.gameObject.SetActive(false);
                    TTSJobot5.gameObject.SetActive(false);
                    TTSJobot6.gameObject.SetActive(false);
                    TTSJobot7.gameObject.SetActive(false);
                    TTSJobot8.gameObject.SetActive(false);
                    TTSJobot9.gameObject.SetActive(false);
                    TTSJobot10.gameObject.SetActive(false);
             //       TTSJobot11.gameObject.SetActive(false);
                    TTSJobot12.gameObject.SetActive(false);
            //        TTSJobot13.gameObject.SetActive(true);
                    TTSJobot14.gameObject.SetActive(false);
                    TTSJobot15.gameObject.SetActive(false);
                    stageComplete.enabled = false;
                    TTSJobot16.gameObject.SetActive(false);
                    if (!progressTextIsShowing)
                    { // 3 second delay
                        StartCoroutine(DelayProgressButtonVar1());
                        progressTextIsShowing = true;
                    }

                }
                */
                if (currentStageOfText == 11)
                {
                   
                    jobotIntroStage1Section1.enabled = false;
            //        jobotIntroStage1Section1a.enabled = false;
                    jobotIntroStage1Section1b.enabled = false;
                    jobotIntroStage1Section1c.enabled = false;
                    jobotIntroStage1Section1d.enabled = false;
                    jobotIntroStage1Section1e.enabled = false;
                    jobotIntroStage1Section1f.enabled = false;
                    jobotIntroStage1Section1g.enabled = false;
                    jobotIntroStage1Section1h.enabled = false;
                    jobotIntroStage1Section1i.enabled = false;
            //        jobotIntroStage1Section1j.enabled = false;
                    jobotIntroStage1Section1k.enabled = false;
             //       jobotIntroStage1Section1l.enabled = false;
                    jobotIntroStage1Section1m.enabled = true;
                    jobotFlowersWatered.enabled = false;

                    TTSJobot1.gameObject.SetActive(false);
            //        TTSJobot2.gameObject.SetActive(false);
                    TTSJobot3.gameObject.SetActive(false);
                    TTSJobot4.gameObject.SetActive(false);
                    TTSJobot5.gameObject.SetActive(false);
                    TTSJobot6.gameObject.SetActive(false);
                    TTSJobot7.gameObject.SetActive(false);
                    TTSJobot8.gameObject.SetActive(false);
                    TTSJobot9.gameObject.SetActive(false);
                    TTSJobot10.gameObject.SetActive(false);
           //         TTSJobot11.gameObject.SetActive(false);
                    TTSJobot12.gameObject.SetActive(false);
           //         TTSJobot13.gameObject.SetActive(false);
                    TTSJobot14.gameObject.SetActive(true);
                    TTSJobot15.gameObject.SetActive(false);

             //       stageComplete.enabled = false;
                    TTSJobot16.gameObject.SetActive(false);

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
                 

                }

                if (currentStageOfText == 15)
                {
                    // Jobotintrostage1n
                    textPanalToHide.SetActive(false);
                    jobotIntroStage1Section1.enabled = false;
             //       jobotIntroStage1Section1a.enabled = false;
                    jobotIntroStage1Section1b.enabled = false;
                    jobotIntroStage1Section1c.enabled = false;
                    jobotIntroStage1Section1d.enabled = false;
                    jobotIntroStage1Section1e.enabled = false;
                    jobotIntroStage1Section1f.enabled = false;
                    jobotIntroStage1Section1g.enabled = false;
                    jobotIntroStage1Section1h.enabled = false;
                    jobotIntroStage1Section1i.enabled = false;
            //        jobotIntroStage1Section1j.enabled = false;
                    jobotIntroStage1Section1k.enabled = false;
             //       jobotIntroStage1Section1l.enabled = false;
                    jobotIntroStage1Section1m.enabled = false;
                    jobotFlowersWatered.enabled = false;

                    TTSJobot1.gameObject.SetActive(false);
            //        TTSJobot2.gameObject.SetActive(false);
                    TTSJobot3.gameObject.SetActive(false);
                    TTSJobot4.gameObject.SetActive(false);
                    TTSJobot5.gameObject.SetActive(false);
                    TTSJobot6.gameObject.SetActive(false);
                    TTSJobot7.gameObject.SetActive(false);
                    TTSJobot8.gameObject.SetActive(false);
                    TTSJobot9.gameObject.SetActive(false);
                    TTSJobot10.gameObject.SetActive(false);
            //        TTSJobot11.gameObject.SetActive(false);
                    TTSJobot12.gameObject.SetActive(false);
            //        TTSJobot13.gameObject.SetActive(false);
                    TTSJobot14.gameObject.SetActive(false);
                    TTSJobot15.gameObject.SetActive(false);

             //       stageComplete.enabled = false;
                    TTSJobot16.gameObject.SetActive(false);
                }


                if (currentStageOfText == 16)
                {
                    // Jobotintrostage1l
                    textPanalToHide.SetActive(true);
                    jobotIntroStage1Section1.enabled = false;
          //          jobotIntroStage1Section1a.enabled = false;
                    jobotIntroStage1Section1b.enabled = false;
                    jobotIntroStage1Section1c.enabled = false;
                    jobotIntroStage1Section1d.enabled = false;
                    jobotIntroStage1Section1e.enabled = false;
                    jobotIntroStage1Section1f.enabled = false;
                    jobotIntroStage1Section1g.enabled = false;
                    jobotIntroStage1Section1h.enabled = false;
                    jobotIntroStage1Section1i.enabled = false;
           //         jobotIntroStage1Section1j.enabled = false;
                    jobotIntroStage1Section1k.enabled = false;
           //         jobotIntroStage1Section1l.enabled = false;
                    jobotIntroStage1Section1m.enabled = false;
                    jobotFlowersWatered.enabled = true;

                    TTSJobot1.gameObject.SetActive(false);
          //          TTSJobot2.gameObject.SetActive(false);
                    TTSJobot3.gameObject.SetActive(false);
                    TTSJobot4.gameObject.SetActive(false);
                    TTSJobot5.gameObject.SetActive(false);
                    TTSJobot6.gameObject.SetActive(false);
                    TTSJobot7.gameObject.SetActive(false);
                    TTSJobot8.gameObject.SetActive(false);
                    TTSJobot9.gameObject.SetActive(false);
                    TTSJobot10.gameObject.SetActive(false);
         //           TTSJobot11.gameObject.SetActive(false);
                    TTSJobot12.gameObject.SetActive(false);
        //            TTSJobot13.gameObject.SetActive(false);
                    TTSJobot14.gameObject.SetActive(false);
                    TTSJobot15.gameObject.SetActive(false);
            //        stageComplete.enabled = false;
                    StartCoroutine(MoveToBlankText());
                    progressText.gameObject.SetActive(false);

                }
                /*
                                if (currentStageOfText == 17)
                                {
                                    // Jobotintrostage1l
                                    textPanalToHide.SetActive(true);
                                    jobotIntroStage1Section1.enabled = false;
                             //       jobotIntroStage1Section1a.enabled = false;
                                    jobotIntroStage1Section1b.enabled = false;
                                    jobotIntroStage1Section1c.enabled = false;
                                    jobotIntroStage1Section1d.enabled = false;
                                    jobotIntroStage1Section1e.enabled = false;
                                    jobotIntroStage1Section1f.enabled = false;
                                    jobotIntroStage1Section1g.enabled = false;
                                    jobotIntroStage1Section1h.enabled = false;
                                    jobotIntroStage1Section1i.enabled = false;
                            //        jobotIntroStage1Section1j.enabled = false;
                                    jobotIntroStage1Section1k.enabled = false;
                             //       jobotIntroStage1Section1l.enabled = false;
                                    jobotIntroStage1Section1m.enabled = false;
                                    jobotFlowersWatered.enabled = false;

                                    TTSJobot1.gameObject.SetActive(false);
                             //       TTSJobot2.gameObject.SetActive(false);
                                    TTSJobot3.gameObject.SetActive(false);
                                    TTSJobot4.gameObject.SetActive(false);
                                    TTSJobot5.gameObject.SetActive(false);
                                    TTSJobot6.gameObject.SetActive(false);
                                    TTSJobot7.gameObject.SetActive(false);
                                    TTSJobot8.gameObject.SetActive(false);
                                    TTSJobot9.gameObject.SetActive(false);
                                    TTSJobot10.gameObject.SetActive(false);
                            //        TTSJobot11.gameObject.SetActive(false);
                                    TTSJobot12.gameObject.SetActive(false);
                            //        TTSJobot13.gameObject.SetActive(false);
                                    TTSJobot14.gameObject.SetActive(false);
                                    TTSJobot15.gameObject.SetActive(false);


                         //           stageComplete.enabled = true;
                                    TTSJobot16.gameObject.SetActive(true);

                                  //  StartCoroutine(MoveToBlankText());

                                }
                */
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
            currentStageOfText = 15;
        }

        public IEnumerator MoveTEnd()
        {
            yield return new WaitForSeconds(3);
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
