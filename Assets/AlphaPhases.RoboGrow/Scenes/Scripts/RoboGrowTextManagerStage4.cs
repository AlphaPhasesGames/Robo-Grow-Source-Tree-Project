using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using LoLSDK;
namespace Alpha.Phases.Robo.Grow
{
    public class RoboGrowTextManagerStage4 : MonoBehaviour
    {

        public RoboGrowMain rgMainData; // declare access to RoboGrowMain
        public GameObject textPanalToHide; // the start text panal to show and hide on start and finish of text section
        public GameObject robotToHide;
        public GameObject playerRobotToShow;
        public RobotController robotControl;
        // public CameraFollowPlayer camFollow;

        public GameObject hint11;
        public GameObject hint12;

        public Animator camZoomOutAnim;
        public Animator robotAnim;
        public Animator doorAnim;
        public Button forwardButtonToDisable;

        public bool introReadyToBeCompleted;
        public bool hasLevelSavedAlready;
        public Camera mainCameraToDisable;
        public Camera playerCameraToEnableCamera;
        public GameObject playerCameraToEnable;

        public Button help;
        public Button tasks;
        //public Camera robotPlayerCam;
        //public Camera camToDisable;

        public BoxCollider stage3EndToDisable;
        public BoxCollider stage2EndToDisable;

        public BoxCollider susan1Box;
        public BoxCollider susan2Box;
        public BoxCollider lima1Box;
        public BoxCollider lima2Box;
        public BoxCollider daisy1Box;
        public BoxCollider daisy2Box;
        public BoxCollider radish1Box;
        public BoxCollider radish2Box;


        public Button TTSJobot1;
        public Button TTSJobot2;
        public Button TTSJobot3;
        public Button TTSJobot4;
        public Button TTSJobot5;
      //  public Button TTSJobot6;
        public Button TTSJobot7;
     //   public Button TTSJobot8;
     //   public Button TTSJobot9;
        public Button TTSJobot10;
        public Button TTSJobot11FlowerWatered1;
        public Button TTSJobot12FlowerWatered2;
        public Button TTSJobot13StageComplete;

        public TextMeshProUGUI jobotIntroStage1Section1;
        public TextMeshProUGUI jobotIntroStage1Section1a;
        public TextMeshProUGUI jobotIntroStage1Section1b;
        public TextMeshProUGUI jobotIntroStage1Section1c;
        public TextMeshProUGUI jobotIntroStage1Section1d;
      //  public TextMeshProUGUI jobotIntroStage1Section1e;
        public TextMeshProUGUI jobotIntroStage1Section1f;
      //  public TextMeshProUGUI jobotIntroStage1Section1g;
     //   public TextMeshProUGUI jobotIntroStage1Section1h;
        public TextMeshProUGUI jobotIntroStage1Section1i;
        public TextMeshProUGUI jobotIntroStagejobotStage4PlantWatered1;
        public TextMeshProUGUI jobotIntroStagejobotStage4PlantWatered2;
        public TextMeshProUGUI jobotStageComplete;

        public bool hasFLoweresBeenWatered;

        public bool textBeenRead;
        public bool progressTextIsShowing;

        public Button progressText;
        public Button progressTextBack;

        public int currentStageOfText;

        private void Awake()
        {
            currentStageOfText = 0;
            progressText.onClick.AddListener(OnClick);
            progressTextBack.onClick.AddListener(OnClickBack);
            TTSJobot1.onClick.AddListener(JobotStage4Section1);
            TTSJobot2.onClick.AddListener(JobotStage4Section1a);
            TTSJobot3.onClick.AddListener(JobotStage4Section1b);
            TTSJobot4.onClick.AddListener(JobotStage4Section1c);
            TTSJobot5.onClick.AddListener(JobotStage4Section1d);
         //   TTSJobot6.onClick.AddListener(JobotStage4Section1e);
            TTSJobot7.onClick.AddListener(JobotStage4Section1f);
         //   TTSJobot8.onClick.AddListener(JobotStage4Section1g);
         //   TTSJobot9.onClick.AddListener(JobotStage4Section1h);
            TTSJobot10.onClick.AddListener(JobotStage4Section1i);
            TTSJobot11FlowerWatered1.onClick.AddListener(JobotStage4Section1Flowerwatered1);
            TTSJobot12FlowerWatered2.onClick.AddListener(JobotStage4Section1Flowerwatered2);
            TTSJobot13StageComplete.onClick.AddListener(JobotStage4Complete);
        }
        // Start is called before the first frame update
        void Start()
        {
            if (rgMainData.currentGameStage == 4)
            {
                robotControl.enabled = false;
                textPanalToHide.SetActive(false);
                jobotIntroStage1Section1.enabled = false;
                jobotIntroStage1Section1a.enabled = false;
                jobotIntroStage1Section1b.enabled = false;
                jobotIntroStage1Section1c.enabled = false;
                jobotIntroStage1Section1d.enabled = false;
           //     jobotIntroStage1Section1e.enabled = false;
                jobotIntroStage1Section1f.enabled = false;
          //      jobotIntroStage1Section1g.enabled = false;
          //      jobotIntroStage1Section1h.enabled = false;
                jobotIntroStage1Section1i.enabled = false;
                jobotIntroStagejobotStage4PlantWatered1.enabled = false;
                jobotIntroStagejobotStage4PlantWatered2.enabled = false;
                jobotStageComplete.enabled = false;

                TTSJobot1.gameObject.SetActive(false);
                TTSJobot2.gameObject.SetActive(false);
                TTSJobot3.gameObject.SetActive(false);
                TTSJobot4.gameObject.SetActive(false);
                TTSJobot5.gameObject.SetActive(false);
        //        TTSJobot6.gameObject.SetActive(false);
                TTSJobot7.gameObject.SetActive(false);
        //        TTSJobot8.gameObject.SetActive(false);
       //         TTSJobot9.gameObject.SetActive(false);
                TTSJobot10.gameObject.SetActive(false);


                TTSJobot11FlowerWatered1.gameObject.SetActive(false);
                TTSJobot12FlowerWatered2.gameObject.SetActive(false);

                TTSJobot13StageComplete.gameObject.SetActive(false);
            }
        }

        // Update is called once per frame
        void Update()
        {
            if (rgMainData.currentGameStage == 4)
            {
                if(rgMainData.amountOfStage4FlowersWatered == 8)
                {
                    if (!hasFLoweresBeenWatered)
                    {
                        rgMainData.SaveStage4FlowersWatered();
                        rgMainData.SavePlayerPos();
                        currentStageOfText = 12;
                        hasFLoweresBeenWatered = true;
                    }
                   
                }

                //  jobotIntroStage1
                if (currentStageOfText == 1)
                {
                    if (!textBeenRead)
                    {
                        progressText.gameObject.SetActive(false);
                    }
                    progressTextBack.gameObject.SetActive(false);
                    textPanalToHide.SetActive(true);
                    jobotIntroStage1Section1.enabled = true;
                    jobotIntroStage1Section1a.enabled = false;
                    jobotIntroStage1Section1b.enabled = false;
                    jobotIntroStage1Section1c.enabled = false;
                    jobotIntroStage1Section1d.enabled = false;
              //      jobotIntroStage1Section1e.enabled = false;
                    jobotIntroStage1Section1f.enabled = false;
              //      jobotIntroStage1Section1g.enabled = false;
               //     jobotIntroStage1Section1h.enabled = false;
                    jobotIntroStage1Section1i.enabled = false;
                    jobotIntroStagejobotStage4PlantWatered1.enabled = false;
                    jobotIntroStagejobotStage4PlantWatered2.enabled = false;
                    rgMainData.amountOfStage4FlowersWatered = 0;

                    doorAnim.SetBool("closeDoor", true);
                    TTSJobot1.gameObject.SetActive(true);
                    TTSJobot2.gameObject.SetActive(false);
                    TTSJobot3.gameObject.SetActive(false);
                    TTSJobot4.gameObject.SetActive(false);
                    TTSJobot5.gameObject.SetActive(false);
             //       TTSJobot6.gameObject.SetActive(false);
                    TTSJobot7.gameObject.SetActive(false);
             //       TTSJobot8.gameObject.SetActive(false);
             //       TTSJobot9.gameObject.SetActive(false);
                    TTSJobot10.gameObject.SetActive(false);
                    TTSJobot11FlowerWatered1.gameObject.SetActive(false);
                    TTSJobot12FlowerWatered2.gameObject.SetActive(false);

                    TTSJobot13StageComplete.gameObject.SetActive(false);
                    jobotStageComplete.enabled = false;

                    if (!progressTextIsShowing)
                    { // 3 second delay
                        StartCoroutine(DelayProgressButtonVar1());
                        progressTextIsShowing = true;
                    }

                }

                if (currentStageOfText == 2)
                {
                    if (!textBeenRead)
                    {
                        progressText.gameObject.SetActive(false);
                    }
                    //  jobotIntroStage1a
                    progressTextBack.gameObject.SetActive(true);
                    jobotIntroStage1Section1.enabled = false;
                    jobotIntroStage1Section1a.enabled = true;
                    jobotIntroStage1Section1b.enabled = false;
                    jobotIntroStage1Section1c.enabled = false;
                    jobotIntroStage1Section1d.enabled = false;
               //     jobotIntroStage1Section1e.enabled = false;
                    jobotIntroStage1Section1f.enabled = false;
               //     jobotIntroStage1Section1g.enabled = false;
               //     jobotIntroStage1Section1h.enabled = false;
                    jobotIntroStage1Section1i.enabled = false;
                    jobotIntroStagejobotStage4PlantWatered1.enabled = false;
                    jobotIntroStagejobotStage4PlantWatered2.enabled = false;



                    TTSJobot1.gameObject.SetActive(false);
                    TTSJobot2.gameObject.SetActive(true);
                    TTSJobot3.gameObject.SetActive(false);
                    TTSJobot4.gameObject.SetActive(false);
                    TTSJobot5.gameObject.SetActive(false);
              //      TTSJobot6.gameObject.SetActive(false);
                    TTSJobot7.gameObject.SetActive(false);
              //      TTSJobot8.gameObject.SetActive(false);
              //      TTSJobot9.gameObject.SetActive(false);
                    TTSJobot10.gameObject.SetActive(false);
                    TTSJobot11FlowerWatered1.gameObject.SetActive(false);
                    TTSJobot12FlowerWatered2.gameObject.SetActive(false);

                    TTSJobot13StageComplete.gameObject.SetActive(false);
                    jobotStageComplete.enabled = false;
                    if (!progressTextIsShowing)
                    { // 3 second delay
                        StartCoroutine(DelayProgressButtonVar2());
                        progressTextIsShowing = true;
                    }
                }

                if (currentStageOfText == 3)
                {
                    if (!textBeenRead)
                    {
                        progressText.gameObject.SetActive(false);
                    }
                    //  jobotIntroStage1b
                    jobotIntroStage1Section1.enabled = false;
                    jobotIntroStage1Section1a.enabled = false;
                    jobotIntroStage1Section1b.enabled = true;
                    jobotIntroStage1Section1c.enabled = false;
                    jobotIntroStage1Section1d.enabled = false;
              //      jobotIntroStage1Section1e.enabled = false;
                    jobotIntroStage1Section1f.enabled = false;
             //       jobotIntroStage1Section1g.enabled = false;
             //       jobotIntroStage1Section1h.enabled = false;
                    jobotIntroStage1Section1i.enabled = false;
                    jobotIntroStagejobotStage4PlantWatered1.enabled = false;
                    jobotIntroStagejobotStage4PlantWatered2.enabled = false;



                    TTSJobot1.gameObject.SetActive(false);
                    TTSJobot2.gameObject.SetActive(false);
                    TTSJobot3.gameObject.SetActive(true);
                    TTSJobot4.gameObject.SetActive(false);
                    TTSJobot5.gameObject.SetActive(false);
            //        TTSJobot6.gameObject.SetActive(false);
                    TTSJobot7.gameObject.SetActive(false);
            //        TTSJobot8.gameObject.SetActive(false);
           //         TTSJobot9.gameObject.SetActive(false);
                    TTSJobot10.gameObject.SetActive(false);
                    TTSJobot11FlowerWatered1.gameObject.SetActive(false);
                    TTSJobot12FlowerWatered2.gameObject.SetActive(false);

                    TTSJobot13StageComplete.gameObject.SetActive(false);
                    jobotStageComplete.enabled = false;
                    if (!progressTextIsShowing)
                    { // 3 second delay
                        StartCoroutine(DelayProgressButton());
                        progressTextIsShowing = true;
                    }
                }

                if (currentStageOfText == 4)
                {
                    if (!textBeenRead)
                    {
                        progressText.gameObject.SetActive(false);
                    }
                    //  jobotIntroStage1c
                    jobotIntroStage1Section1.enabled = false;
                    jobotIntroStage1Section1a.enabled = false;
                    jobotIntroStage1Section1b.enabled = false;
                    jobotIntroStage1Section1c.enabled = true;
                    jobotIntroStage1Section1d.enabled = false;
            //        jobotIntroStage1Section1e.enabled = false;
                    jobotIntroStage1Section1f.enabled = false;
             //       jobotIntroStage1Section1g.enabled = false;
             //       jobotIntroStage1Section1h.enabled = false;
                    jobotIntroStage1Section1i.enabled = false;
                    jobotIntroStagejobotStage4PlantWatered1.enabled = false;
                    jobotIntroStagejobotStage4PlantWatered2.enabled = false;
                    hint11.gameObject.SetActive(true);

                    TTSJobot1.gameObject.SetActive(false);
                    TTSJobot2.gameObject.SetActive(false);
                    TTSJobot3.gameObject.SetActive(false);
                    TTSJobot4.gameObject.SetActive(true);
                    TTSJobot5.gameObject.SetActive(false);
            //        TTSJobot6.gameObject.SetActive(false);
                    TTSJobot7.gameObject.SetActive(false);
            //        TTSJobot8.gameObject.SetActive(false);
           //         TTSJobot9.gameObject.SetActive(false);
                    TTSJobot10.gameObject.SetActive(false);
                    TTSJobot11FlowerWatered1.gameObject.SetActive(false);
                    TTSJobot12FlowerWatered2.gameObject.SetActive(false);

                    TTSJobot13StageComplete.gameObject.SetActive(false);
                    jobotStageComplete.enabled = false;
                    if (!progressTextIsShowing)
                    { // 3 second delay
                        StartCoroutine(DelayProgressButtonVar1());
                        progressTextIsShowing = true;
                    }
                }

                if (currentStageOfText == 5)
                {
                    if (!textBeenRead)
                    {
                        progressText.gameObject.SetActive(false);
                    }
                    //  jobotIntroStage1d
                    jobotIntroStage1Section1.enabled = false;
                    jobotIntroStage1Section1a.enabled = false;
                    jobotIntroStage1Section1b.enabled = false;
                    jobotIntroStage1Section1c.enabled = false;
                    jobotIntroStage1Section1d.enabled = true;
              //      jobotIntroStage1Section1e.enabled = false;
                    jobotIntroStage1Section1f.enabled = false;
             //       jobotIntroStage1Section1g.enabled = false;
            //       jobotIntroStage1Section1h.enabled = false;
                    jobotIntroStage1Section1i.enabled = false;
                    jobotIntroStagejobotStage4PlantWatered1.enabled = false;
                    jobotIntroStagejobotStage4PlantWatered2.enabled = false;


                    TTSJobot1.gameObject.SetActive(false);
                    TTSJobot2.gameObject.SetActive(false);
                    TTSJobot3.gameObject.SetActive(false);
                    TTSJobot4.gameObject.SetActive(false);
                    TTSJobot5.gameObject.SetActive(true);
             //       TTSJobot6.gameObject.SetActive(false);
                    TTSJobot7.gameObject.SetActive(false);
             //       TTSJobot8.gameObject.SetActive(false);
             //       TTSJobot9.gameObject.SetActive(false);
                    TTSJobot10.gameObject.SetActive(false);
                    TTSJobot11FlowerWatered1.gameObject.SetActive(false);
                    TTSJobot12FlowerWatered2.gameObject.SetActive(false);

                    TTSJobot13StageComplete.gameObject.SetActive(false);
                    jobotStageComplete.enabled = false;
                    if (!progressTextIsShowing)
                    { // 3 second delay
                        StartCoroutine(DelayProgressButtonVar2());
                        progressTextIsShowing = true;
                    }
                }
                /*
                if (currentStageOfText == 6)
                {
                    if (!textBeenRead)
                    {
                        progressText.gameObject.SetActive(false);
                    }
                    //  jobotIntroStage1e

                    jobotIntroStage1Section1.enabled = false;
                    jobotIntroStage1Section1a.enabled = false;
                    jobotIntroStage1Section1b.enabled = false;
                    jobotIntroStage1Section1c.enabled = false;
                    jobotIntroStage1Section1d.enabled = false;
                    jobotIntroStage1Section1e.enabled = true;
                    jobotIntroStage1Section1f.enabled = false;
                    jobotIntroStage1Section1g.enabled = false;
                    jobotIntroStage1Section1h.enabled = false;
                    jobotIntroStage1Section1i.enabled = false;
                    jobotIntroStagejobotStage4PlantWatered1.enabled = false;
                    jobotIntroStagejobotStage4PlantWatered2.enabled = false;



                    TTSJobot1.gameObject.SetActive(false);
                    TTSJobot2.gameObject.SetActive(false);
                    TTSJobot3.gameObject.SetActive(false);
                    TTSJobot4.gameObject.SetActive(false);
                    TTSJobot5.gameObject.SetActive(false);
                    TTSJobot6.gameObject.SetActive(true);
                    TTSJobot7.gameObject.SetActive(false);
                    TTSJobot8.gameObject.SetActive(false);
                    TTSJobot9.gameObject.SetActive(false);
                    TTSJobot10.gameObject.SetActive(false);
                    TTSJobot11FlowerWatered1.gameObject.SetActive(false);
                    TTSJobot12FlowerWatered2.gameObject.SetActive(false);

                    TTSJobot13StageComplete.gameObject.SetActive(false);
                    jobotStageComplete.enabled = false;
                    if (!progressTextIsShowing)
                    { // 3 second delay
                        StartCoroutine(DelayProgressButtonVar1());
                        progressTextIsShowing = true;
                    }
                }
                */
                if (currentStageOfText == 6)
                {
                    if (!textBeenRead)
                    {
                        progressText.gameObject.SetActive(false);
                    }
                    //  jobotIntroStage1f
                    jobotIntroStage1Section1.enabled = false;
                    jobotIntroStage1Section1a.enabled = false;
                    jobotIntroStage1Section1b.enabled = false;
                    jobotIntroStage1Section1c.enabled = false;
                    jobotIntroStage1Section1d.enabled = false;
                //    jobotIntroStage1Section1e.enabled = false;
                    jobotIntroStage1Section1f.enabled = true;
               //     jobotIntroStage1Section1g.enabled = false;
               //     jobotIntroStage1Section1h.enabled = false;
                    jobotIntroStage1Section1i.enabled = false;
                    jobotIntroStagejobotStage4PlantWatered1.enabled = false;
                    jobotIntroStagejobotStage4PlantWatered2.enabled = false;


                    TTSJobot1.gameObject.SetActive(false);
                    TTSJobot2.gameObject.SetActive(false);
                    TTSJobot3.gameObject.SetActive(false);
                    TTSJobot4.gameObject.SetActive(false);
                    TTSJobot5.gameObject.SetActive(false);
             //       TTSJobot6.gameObject.SetActive(false);
                    TTSJobot7.gameObject.SetActive(true);
             //       TTSJobot8.gameObject.SetActive(false);
             //       TTSJobot9.gameObject.SetActive(false);
                    TTSJobot10.gameObject.SetActive(false);
                    TTSJobot11FlowerWatered1.gameObject.SetActive(false);
                    TTSJobot12FlowerWatered2.gameObject.SetActive(false);

                    TTSJobot13StageComplete.gameObject.SetActive(false);
                    jobotStageComplete.enabled = false;
                    if (!progressTextIsShowing)
                    { // 3 second delay
                        StartCoroutine(DelayProgressButtonVar2());
                        progressTextIsShowing = true;
                    }
                }
/*
                if (currentStageOfText == 8)
                {
                    if (!textBeenRead)
                    {
                        progressText.gameObject.SetActive(false);
                    }
                    //  jobotIntroStage1g
                    jobotIntroStage1Section1.enabled = false;
                    jobotIntroStage1Section1a.enabled = false;
                    jobotIntroStage1Section1b.enabled = false;
                    jobotIntroStage1Section1c.enabled = false;
                    jobotIntroStage1Section1d.enabled = false;
             //       jobotIntroStage1Section1e.enabled = false;
                    jobotIntroStage1Section1f.enabled = false;
             //       jobotIntroStage1Section1g.enabled = true;
            //        jobotIntroStage1Section1h.enabled = false;
                    jobotIntroStage1Section1i.enabled = false;
                    jobotIntroStagejobotStage4PlantWatered1.enabled = false;
                    jobotIntroStagejobotStage4PlantWatered2.enabled = false;


                    TTSJobot1.gameObject.SetActive(false);
                    TTSJobot2.gameObject.SetActive(false);
                    TTSJobot3.gameObject.SetActive(false);
                    TTSJobot4.gameObject.SetActive(false);
                    TTSJobot5.gameObject.SetActive(false);
                    TTSJobot6.gameObject.SetActive(false);
                    TTSJobot7.gameObject.SetActive(false);
                    TTSJobot8.gameObject.SetActive(true);
                    TTSJobot9.gameObject.SetActive(false);
                    TTSJobot10.gameObject.SetActive(false);
                    TTSJobot11FlowerWatered1.gameObject.SetActive(false);
                    TTSJobot12FlowerWatered2.gameObject.SetActive(false);

                    TTSJobot13StageComplete.gameObject.SetActive(false);
                    jobotStageComplete.enabled = false;
                                        if (!progressTextIsShowing)
                    { // 3 second delay
                        StartCoroutine(DelayProgressButtonVar1());
                        progressTextIsShowing = true;
                    }
                }

                if (currentStageOfText == 9)
                {
                    if (!textBeenRead)
                    {
                        progressText.gameObject.SetActive(false);
                    }
                    //  jobotIntroStage1h
                    jobotIntroStage1Section1.enabled = false;
                    jobotIntroStage1Section1a.enabled = false;
                    jobotIntroStage1Section1b.enabled = false;
                    jobotIntroStage1Section1c.enabled = false;
                    jobotIntroStage1Section1d.enabled = false;
                    jobotIntroStage1Section1e.enabled = false;
                    jobotIntroStage1Section1f.enabled = false;
                    jobotIntroStage1Section1g.enabled = false;
                    jobotIntroStage1Section1h.enabled = true;
                    jobotIntroStage1Section1i.enabled = false;
                    jobotIntroStagejobotStage4PlantWatered1.enabled = false;
                    jobotIntroStagejobotStage4PlantWatered2.enabled = false;


                    TTSJobot1.gameObject.SetActive(false);
                    TTSJobot2.gameObject.SetActive(false);
                    TTSJobot3.gameObject.SetActive(false);
                    TTSJobot4.gameObject.SetActive(false);
                    TTSJobot5.gameObject.SetActive(false);
                    TTSJobot6.gameObject.SetActive(false);
                    TTSJobot7.gameObject.SetActive(false);
                    TTSJobot8.gameObject.SetActive(false);
                    TTSJobot9.gameObject.SetActive(true);
                    TTSJobot10.gameObject.SetActive(false);
                    TTSJobot11FlowerWatered1.gameObject.SetActive(false);
                    TTSJobot12FlowerWatered2.gameObject.SetActive(false);
                    hint12.gameObject.SetActive(true);
                    TTSJobot13StageComplete.gameObject.SetActive(false);
                    jobotStageComplete.enabled = false;
                    doorAnim.SetBool("doorNeedsToBeOpen", false);
                    doorAnim.SetBool("closeDoor", false);
                    doorAnim.SetTrigger("resetDoorValues");
                    if (!progressTextIsShowing)
                    { // 3 second delay
                        StartCoroutine(DelayProgressButtonVar1());
                        progressTextIsShowing = true;
                    }
                }
*/
                if (currentStageOfText == 7)
                { //  jobotIntroStage1i
                    if (!textBeenRead)
                    {
                        progressText.gameObject.SetActive(false);
                    }
                    jobotIntroStage1Section1.enabled = false;
                    jobotIntroStage1Section1a.enabled = false;
                    jobotIntroStage1Section1b.enabled = false;
                    jobotIntroStage1Section1c.enabled = false;
                    jobotIntroStage1Section1d.enabled = false;
                //    jobotIntroStage1Section1e.enabled = false;
                    jobotIntroStage1Section1f.enabled = false;
               //     jobotIntroStage1Section1g.enabled = false;
                //    jobotIntroStage1Section1h.enabled = false;
                    jobotIntroStage1Section1i.enabled = true;
                    jobotIntroStagejobotStage4PlantWatered1.enabled = false;
                    jobotIntroStagejobotStage4PlantWatered2.enabled = false;


                    TTSJobot1.gameObject.SetActive(false);
                    TTSJobot2.gameObject.SetActive(false);
                    TTSJobot3.gameObject.SetActive(false);
                    TTSJobot4.gameObject.SetActive(false);
                    TTSJobot5.gameObject.SetActive(false);
               //     TTSJobot6.gameObject.SetActive(false);
                    TTSJobot7.gameObject.SetActive(false);
               //     TTSJobot8.gameObject.SetActive(false);
               //     TTSJobot9.gameObject.SetActive(false);
                    TTSJobot10.gameObject.SetActive(true);
                    TTSJobot11FlowerWatered1.gameObject.SetActive(false);
                    TTSJobot12FlowerWatered2.gameObject.SetActive(false);

                    TTSJobot13StageComplete.gameObject.SetActive(false);
                    jobotStageComplete.enabled = false;

                    camZoomOutAnim.SetBool("startStage1PlayerCamZoomOut", true);
                    //   rgMainData.SavePlayerPos();
                   // playerCameraToEnable.SetActive(true);
                    playerCameraToEnableCamera.enabled = true;
                    mainCameraToDisable.enabled = false;
                    stage3EndToDisable.enabled = false;
                    stage2EndToDisable.enabled = false;
                    //  StartCoroutine(CloseText());
                    playerRobotToShow.SetActive(true);
                    robotToHide.SetActive(false);
                    robotControl.enabled = true;
                    robotAnim.keepAnimatorControllerStateOnDisable = false;
                    robotAnim.enabled = false;

                    help.enabled = true;
                    tasks.enabled = true;

                    if (!hasLevelSavedAlready)
                    {
                        rgMainData.MoveToLevel4();
                        rgMainData.introStage4Complete = true;
                        rgMainData.SaveIntroCompleteStage4();
                        susan1Box.enabled = true;
                        susan2Box.enabled = true;
                        lima1Box.enabled = true;
                        lima2Box.enabled = true;
                        daisy1Box.enabled = true;
                        daisy2Box.enabled = true;
                        radish1Box.enabled = true;
                        radish2Box.enabled = true;

                        hasLevelSavedAlready = true;
                    }

                    progressText.gameObject.SetActive(false);
                    StartCoroutine(DisableAllAnims());
                    StartCoroutine(ResetDoor());
                    StartCoroutine(CloseText());
                }

                // off

                if (currentStageOfText == 11)
                {
                    //  jobotIntroStage1h
                    textPanalToHide.SetActive(false);
                    jobotIntroStage1Section1.enabled = false;
                    jobotIntroStage1Section1a.enabled = false;
                    jobotIntroStage1Section1b.enabled = false;
                    jobotIntroStage1Section1c.enabled = false;
                    jobotIntroStage1Section1d.enabled = false;
             //       jobotIntroStage1Section1e.enabled = false;
                    jobotIntroStage1Section1f.enabled = false;
             //       jobotIntroStage1Section1g.enabled = false;
             //       jobotIntroStage1Section1h.enabled = false;
                    jobotIntroStage1Section1i.enabled = false;
                    jobotIntroStagejobotStage4PlantWatered1.enabled = false;
                    jobotIntroStagejobotStage4PlantWatered2.enabled = false;


                    TTSJobot1.gameObject.SetActive(false);
                    TTSJobot2.gameObject.SetActive(false);
                    TTSJobot3.gameObject.SetActive(false);
                    TTSJobot4.gameObject.SetActive(false);
                    TTSJobot5.gameObject.SetActive(false);
          //          TTSJobot6.gameObject.SetActive(false);
                    TTSJobot7.gameObject.SetActive(false);
          //          TTSJobot8.gameObject.SetActive(false);
          //          TTSJobot9.gameObject.SetActive(false);
                    TTSJobot10.gameObject.SetActive(false);
                    TTSJobot11FlowerWatered1.gameObject.SetActive(false);
                    TTSJobot12FlowerWatered2.gameObject.SetActive(false);

                    TTSJobot13StageComplete.gameObject.SetActive(false);
                    jobotStageComplete.enabled = false;
                }

                if (currentStageOfText == 12)
                {
                    textPanalToHide.SetActive(true);
                    jobotIntroStage1Section1.enabled = false;
                    jobotIntroStage1Section1a.enabled = false;
                    jobotIntroStage1Section1b.enabled = false;
                    jobotIntroStage1Section1c.enabled = false;
                    jobotIntroStage1Section1d.enabled = false;
         //           jobotIntroStage1Section1e.enabled = false;
                    jobotIntroStage1Section1f.enabled = false;
          //          jobotIntroStage1Section1g.enabled = false;
        //            jobotIntroStage1Section1h.enabled = false;
                    jobotIntroStage1Section1i.enabled = false;
                    jobotIntroStagejobotStage4PlantWatered1.enabled = true;
                    jobotIntroStagejobotStage4PlantWatered2.enabled = false;


                    TTSJobot1.gameObject.SetActive(false);
                    TTSJobot2.gameObject.SetActive(false);
                    TTSJobot3.gameObject.SetActive(false);
                    TTSJobot4.gameObject.SetActive(false);
                    TTSJobot5.gameObject.SetActive(false);
           //         TTSJobot6.gameObject.SetActive(false);
                    TTSJobot7.gameObject.SetActive(false);
           //         TTSJobot8.gameObject.SetActive(false);
           //         TTSJobot9.gameObject.SetActive(false);
                    TTSJobot10.gameObject.SetActive(false);
                    TTSJobot11FlowerWatered1.gameObject.SetActive(true);
                    TTSJobot12FlowerWatered2.gameObject.SetActive(false);

                    TTSJobot13StageComplete.gameObject.SetActive(false);
                    jobotStageComplete.enabled = false;
                    StartCoroutine(CloseText());
                }

                if (currentStageOfText == 13)
                {
                    textPanalToHide.SetActive(true);
                    progressText.gameObject.SetActive(false);
                    jobotIntroStage1Section1.enabled = false;
                    jobotIntroStage1Section1a.enabled = false;
                    jobotIntroStage1Section1b.enabled = false;
                    jobotIntroStage1Section1c.enabled = false;
                    jobotIntroStage1Section1d.enabled = false;
            //        jobotIntroStage1Section1e.enabled = false;
                    jobotIntroStage1Section1f.enabled = false;
            //        jobotIntroStage1Section1g.enabled = false;
            //        jobotIntroStage1Section1h.enabled = false;
                    jobotIntroStage1Section1i.enabled = false;
                    jobotIntroStagejobotStage4PlantWatered1.enabled = false;
                    jobotIntroStagejobotStage4PlantWatered2.enabled = true;


                    TTSJobot1.gameObject.SetActive(false);
                    TTSJobot2.gameObject.SetActive(false);
                    TTSJobot3.gameObject.SetActive(false);
                    TTSJobot4.gameObject.SetActive(false);
                    TTSJobot5.gameObject.SetActive(false);
          //          TTSJobot6.gameObject.SetActive(false);
                    TTSJobot7.gameObject.SetActive(false);
           //         TTSJobot8.gameObject.SetActive(false);
           //         TTSJobot9.gameObject.SetActive(false);
                    TTSJobot10.gameObject.SetActive(false);
                    TTSJobot11FlowerWatered1.gameObject.SetActive(false);
                    TTSJobot12FlowerWatered2.gameObject.SetActive(true);
                    StartCoroutine(CloseText());
                }

                if (currentStageOfText == 14)
                {
                    textPanalToHide.SetActive(true);
                    progressText.gameObject.SetActive(false);
                    progressTextBack.gameObject.SetActive(false);
                    jobotIntroStage1Section1.enabled = false;
                    jobotIntroStage1Section1a.enabled = false;
                    jobotIntroStage1Section1b.enabled = false;
                    jobotIntroStage1Section1c.enabled = false;
                    jobotIntroStage1Section1d.enabled = false;
           //         jobotIntroStage1Section1e.enabled = false;
                    jobotIntroStage1Section1f.enabled = false;
          //          jobotIntroStage1Section1g.enabled = false;
          //          jobotIntroStage1Section1h.enabled = false;
                    jobotIntroStage1Section1i.enabled = false;
                    jobotIntroStagejobotStage4PlantWatered1.enabled = false;
                    jobotIntroStagejobotStage4PlantWatered2.enabled = false;


                    TTSJobot1.gameObject.SetActive(false);
                    TTSJobot2.gameObject.SetActive(false);
                    TTSJobot3.gameObject.SetActive(false);
                    TTSJobot4.gameObject.SetActive(false);
                    TTSJobot5.gameObject.SetActive(false);
         //           TTSJobot6.gameObject.SetActive(false);
                    TTSJobot7.gameObject.SetActive(false);
         //           TTSJobot8.gameObject.SetActive(false);
         //           TTSJobot9.gameObject.SetActive(false);
                    TTSJobot10.gameObject.SetActive(false);
                    TTSJobot11FlowerWatered1.gameObject.SetActive(false);
                    TTSJobot12FlowerWatered2.gameObject.SetActive(false);

                    TTSJobot13StageComplete.gameObject.SetActive(true);
                    jobotStageComplete.enabled = true;

                    StartCoroutine(CloseText());
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
        }

        void JobotStage4Section1()
        {
            LOLSDK.Instance.SpeakText("jobotStage4IntroText1");
        }

        void JobotStage4Section1a()
        {
            LOLSDK.Instance.SpeakText("jobotStage4IntroText1a");
        }

        void JobotStage4Section1b()
        {
            LOLSDK.Instance.SpeakText("jobotStage4IntroText1b");
        }

        void JobotStage4Section1c()
        {
            LOLSDK.Instance.SpeakText("jobotStage4IntroText1c");
        }

        void JobotStage4Section1d()
        {
            LOLSDK.Instance.SpeakText("jobotStage4IntroText1d");
        }

        void JobotStage4Section1e()
        {
            LOLSDK.Instance.SpeakText("jobotStage4IntroText1e");
        }

        void JobotStage4Section1f()
        {
            LOLSDK.Instance.SpeakText("jobotStage4IntroText1f");
        }

        void JobotStage4Section1g()
        {
            LOLSDK.Instance.SpeakText("jobotStage4IntroText1g");
        }

        void JobotStage4Section1h()
        {
            LOLSDK.Instance.SpeakText("jobotStage4IntroText1h");
        }
        void JobotStage4Section1i()
        {
            LOLSDK.Instance.SpeakText("jobotStage4IntroText1i");
        }

        void JobotStage4Section1Flowerwatered1()
        {
            LOLSDK.Instance.SpeakText("jobotStage4PlantWatered");
        }
        void JobotStage4Section1Flowerwatered2()
        {
            LOLSDK.Instance.SpeakText("jobotStage4PlantWatereda");
        }

        void JobotStage4Complete()
        {
            LOLSDK.Instance.SpeakText("jobotStage4TasksComplete");
        }


        public IEnumerator CloseText()
        {
            yield return new WaitForSeconds(4);
            currentStageOfText = 11;
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
