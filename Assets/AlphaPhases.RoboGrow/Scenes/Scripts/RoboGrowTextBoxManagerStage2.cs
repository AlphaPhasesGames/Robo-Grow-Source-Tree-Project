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
                textPanalToHide.SetActive(false);
                jobotIntroStage1Section1.enabled = false;
                jobotIntroStage1Section1a.enabled = false;
          //      jobotIntroStage1Section1b.enabled = false;
                jobotIntroStage1Section1c.enabled = false;
                jobotIntroStage1Section1d.enabled = false;
           //     jobotIntroStage1Section1e.enabled = false;
                jobotIntroStage1Section1f.enabled = false;
                jobotIntroStage1Section1g.enabled = false;
                jobotIntroStage1Section1h.enabled = false;
                jobotIntroStage1Section1i.enabled = false;
                jobotStage2PlantSeed.enabled = false;
                jobotStage2PlantSeeda.enabled = false;
                jobotStage2PlantSeedb.enabled = false;
            //    jobotStage2PlantSeedc.enabled = false;
           //     jobotStage2PlantSeedd.enabled = false;
                jobotStage2PlantSeede.enabled = false;
                jobotSeedsPlanted.enabled = false;
            jobotSeedsWatered.enabled = false;
            /* jobotIntroStage1Section1j.enabled = false;
             jobotIntroStage1Section1k.enabled = false;
             jobotIntroStage1Section1l.enabled = false;
             jobotIntroStage1Section1m.enabled = false;
             jobotIntroStage1Section1n.enabled = false;
             jobotIntroStage1Section1o.enabled = false;
             jobotIntroStage1Section1p.enabled = false;
             jobotIntroStage1Section1q.enabled = false;
             jobotIntroStage1Section1r.enabled = false;
            */

                TTSJobot1.gameObject.SetActive(false);
                TTSJobot2.gameObject.SetActive(false);
           //     TTSJobot3.gameObject.SetActive(false);
                TTSJobot4.gameObject.SetActive(false);
                TTSJobot5.gameObject.SetActive(false);
            //    TTSJobot6.gameObject.SetActive(false);
                TTSJobot7.gameObject.SetActive(false);
                TTSJobot8.gameObject.SetActive(false);
                TTSJobot9.gameObject.SetActive(false);
                TTSJobot10.gameObject.SetActive(false);
                TTSJobotPlantSeed1.gameObject.SetActive(false);
                TTSJobotPlantSeed2.gameObject.SetActive(false);
                TTSJobotPlantSeed3.gameObject.SetActive(false);
           //     TTSJobotPlantSeed4.gameObject.SetActive(false);
            //    TTSJobotPlantSeed5.gameObject.SetActive(false);
                TTSJobotPlantSeed6.gameObject.SetActive(false);
            TTSSeedsComplete.gameObject.SetActive(false);
            TTSseedsWateredComplete.gameObject.SetActive(false);
            /*TTSJobot11.gameObject.SetActive(false);
            TTSJobot12.gameObject.SetActive(false);
            TTSJobot13.gameObject.SetActive(false);
            TTSJobot14.gameObject.SetActive(false);
            TTSJobot15.gameObject.SetActive(false);
            TTSJobot16.gameObject.SetActive(false);
            TTSJobot17.gameObject.SetActive(false);
            TTSJobot18.gameObject.SetActive(false);
            TTSJobot19.gameObject.SetActive(false);*/

            TTSStage2Complete.gameObject.SetActive(false);
            stage2Complete.gameObject.SetActive(false);

        }

        // Update is called once per frame
        void Update()
        {

        
            //  jobotIntroStage1
            if (currentStageOfText == 1)
            {
                if (!textBeenRead)
                {
                    progressText.gameObject.SetActive(false);
                }
                stage2Objects.gameObject.SetActive(true);
                textPanalToHide.SetActive(true);
                jobotIntroStage1Section1.enabled = true;
                jobotIntroStage1Section1a.enabled = false;
            //    jobotIntroStage1Section1b.enabled = false;
                jobotIntroStage1Section1c.enabled = false;
                jobotIntroStage1Section1d.enabled = false;
             //   jobotIntroStage1Section1e.enabled = false;
                jobotIntroStage1Section1f.enabled = false;
                jobotIntroStage1Section1g.enabled = false;
                jobotIntroStage1Section1h.enabled = false;
                jobotIntroStage1Section1i.enabled = false;
                jobotStage2PlantSeed.enabled = false;
                jobotStage2PlantSeeda.enabled = false;
                jobotStage2PlantSeedb.enabled = false;
            //    jobotStage2PlantSeedc.enabled = false;
            //    jobotStage2PlantSeedd.enabled = false;
                jobotStage2PlantSeede.enabled = false;
                jobotSeedsPlanted.enabled = false;
                jobotSeedsWatered.enabled = false;
                setPeicesToDisable.SetActive(false);
                seedButton.gameObject.SetActive(true);
                TTSJobot1.gameObject.SetActive(true);
                TTSJobot2.gameObject.SetActive(false);
            //    TTSJobot3.gameObject.SetActive(false);
                TTSJobot4.gameObject.SetActive(false);
                TTSJobot5.gameObject.SetActive(false);
            //    TTSJobot6.gameObject.SetActive(false);
                TTSJobot7.gameObject.SetActive(false);
                TTSJobot8.gameObject.SetActive(false);
                TTSJobot9.gameObject.SetActive(false);
                TTSJobot10.gameObject.SetActive(false);
                TTSJobotPlantSeed1.gameObject.SetActive(false);
                TTSJobotPlantSeed2.gameObject.SetActive(false);
                TTSJobotPlantSeed3.gameObject.SetActive(false);
             //   TTSJobotPlantSeed4.gameObject.SetActive(false);
             //   TTSJobotPlantSeed5.gameObject.SetActive(false);
                TTSJobotPlantSeed6.gameObject.SetActive(false);

                TTSStage2Complete.gameObject.SetActive(false);
                stage2Complete.gameObject.SetActive(false);
                hint6.gameObject.SetActive(true);
                TTSSeedsComplete.gameObject.SetActive(false);
                TTSseedsWateredComplete.gameObject.SetActive(false);
                progressTextBack.gameObject.SetActive(false);
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

            }

            if (currentStageOfText == 2)
            {
                //  jobotIntroStage1a
                if (!textBeenRead)
                {
                    progressText.gameObject.SetActive(false);
                }
                progressTextBack.gameObject.SetActive(true);

                jobotIntroStage1Section1.enabled = false;
                jobotIntroStage1Section1a.enabled = true;
             //   jobotIntroStage1Section1b.enabled = false;
                jobotIntroStage1Section1c.enabled = false;
                jobotIntroStage1Section1d.enabled = false;
              //  jobotIntroStage1Section1e.enabled = false;
                jobotIntroStage1Section1f.enabled = false;
                jobotIntroStage1Section1g.enabled = false;
                jobotIntroStage1Section1h.enabled = false;
                jobotIntroStage1Section1i.enabled = false;
                jobotStage2PlantSeed.enabled = false;
                jobotStage2PlantSeeda.enabled = false;
                jobotStage2PlantSeedb.enabled = false;
              //  jobotStage2PlantSeedc.enabled = false;
              //  jobotStage2PlantSeedd.enabled = false;
                jobotStage2PlantSeede.enabled = false;
                jobotSeedsPlanted.enabled = false;
                jobotSeedsWatered.enabled = false;

                TTSJobot1.gameObject.SetActive(false);
                TTSJobot2.gameObject.SetActive(true);
             //   TTSJobot3.gameObject.SetActive(false);
                TTSJobot4.gameObject.SetActive(false);
                TTSJobot5.gameObject.SetActive(false);
             //   TTSJobot6.gameObject.SetActive(false);
                TTSJobot7.gameObject.SetActive(false);
                TTSJobot8.gameObject.SetActive(false);
                TTSJobot9.gameObject.SetActive(false);
                TTSJobot10.gameObject.SetActive(false);
                TTSJobotPlantSeed1.gameObject.SetActive(false);
                TTSJobotPlantSeed2.gameObject.SetActive(false);
                TTSJobotPlantSeed3.gameObject.SetActive(false);
             //   TTSJobotPlantSeed4.gameObject.SetActive(false);
             //   TTSJobotPlantSeed5.gameObject.SetActive(false);
                TTSJobotPlantSeed6.gameObject.SetActive(false);
                TTSSeedsComplete.gameObject.SetActive(false);
                TTSseedsWateredComplete.gameObject.SetActive(false);
                //StartCoroutine(ResetDoor());
                doorAnim.SetBool("closeDoor", true);
                TTSStage2Complete.gameObject.SetActive(false);
                stage2Complete.gameObject.SetActive(false);
                progressTextBack.gameObject.SetActive(true);
                if (!progressTextIsShowing)
                { // 3 second delay
                    StartCoroutine(DelayProgressButton());
                    progressTextIsShowing = true;
                }
            }
            /*
            if (currentStageOfText == 3)
            {
                if (!textBeenRead)
                {
                    progressText.gameObject.SetActive(false);
                }
                //  jobotIntroStage1b
                jobotIntroStage1Section1.enabled = false;
                jobotIntroStage1Section1a.enabled = false;
            //    jobotIntroStage1Section1b.enabled = true;
                jobotIntroStage1Section1c.enabled = false;
                jobotIntroStage1Section1d.enabled = false;
            //    jobotIntroStage1Section1e.enabled = false;
                jobotIntroStage1Section1f.enabled = false;
                jobotIntroStage1Section1g.enabled = false;
                jobotIntroStage1Section1h.enabled = false;
                jobotIntroStage1Section1i.enabled = false;
                jobotStage2PlantSeed.enabled = false;
                jobotStage2PlantSeeda.enabled = false;
                jobotStage2PlantSeedb.enabled = false;
            //    jobotStage2PlantSeedc.enabled = false;
            //    jobotStage2PlantSeedd.enabled = false;
                jobotStage2PlantSeede.enabled = false;
                jobotSeedsPlanted.enabled = false;
                jobotSeedsWatered.enabled = false;

                TTSJobot1.gameObject.SetActive(false);
                TTSJobot2.gameObject.SetActive(false);
           //     TTSJobot3.gameObject.SetActive(true);
                TTSJobot4.gameObject.SetActive(false);
                TTSJobot5.gameObject.SetActive(false);
          //      TTSJobot6.gameObject.SetActive(false);
                TTSJobot7.gameObject.SetActive(false);
                TTSJobot8.gameObject.SetActive(false);
                TTSJobot9.gameObject.SetActive(false);
                TTSJobot10.gameObject.SetActive(false);
                TTSJobotPlantSeed1.gameObject.SetActive(false);
                TTSJobotPlantSeed2.gameObject.SetActive(false);
                TTSJobotPlantSeed3.gameObject.SetActive(false);
           //     TTSJobotPlantSeed4.gameObject.SetActive(false);
            //    TTSJobotPlantSeed5.gameObject.SetActive(false);
                TTSJobotPlantSeed6.gameObject.SetActive(false);
                TTSSeedsComplete.gameObject.SetActive(false);
                TTSseedsWateredComplete.gameObject.SetActive(false);

                TTSStage2Complete.gameObject.SetActive(false);
                stage2Complete.gameObject.SetActive(false);
                if (!progressTextIsShowing)
                { // 3 second delay
                    StartCoroutine(DelayProgressButtonVar2());
                    progressTextIsShowing = true;
                }
            }
            */
            if (currentStageOfText == 3)
            {
                if (!textBeenRead)
                {
                    progressText.gameObject.SetActive(false);
                }
                //  jobotIntroStage1c
                jobotIntroStage1Section1.enabled = false;
                jobotIntroStage1Section1a.enabled = false;
             //   jobotIntroStage1Section1b.enabled = false;
                jobotIntroStage1Section1c.enabled = true;
                jobotIntroStage1Section1d.enabled = false;
             //   jobotIntroStage1Section1e.enabled = false;
                jobotIntroStage1Section1f.enabled = false;
                jobotIntroStage1Section1g.enabled = false;
                jobotIntroStage1Section1h.enabled = false;
                jobotIntroStage1Section1i.enabled = false;
                jobotStage2PlantSeed.enabled = false;
                jobotStage2PlantSeeda.enabled = false;
                jobotStage2PlantSeedb.enabled = false;
             //   jobotStage2PlantSeedc.enabled = false;
             //   jobotStage2PlantSeedd.enabled = false;
                jobotStage2PlantSeede.enabled = false;
                jobotSeedsPlanted.enabled = false;
                jobotSeedsWatered.enabled = false;

                TTSJobot1.gameObject.SetActive(false);
                TTSJobot2.gameObject.SetActive(false);
            //    TTSJobot3.gameObject.SetActive(false);
                TTSJobot4.gameObject.SetActive(true);
                TTSJobot5.gameObject.SetActive(false);
             //   TTSJobot6.gameObject.SetActive(false);
                TTSJobot7.gameObject.SetActive(false);
                TTSJobot8.gameObject.SetActive(false);
                TTSJobot9.gameObject.SetActive(false);
                TTSJobot10.gameObject.SetActive(false);
                TTSJobotPlantSeed1.gameObject.SetActive(false);
                TTSJobotPlantSeed2.gameObject.SetActive(false);
                TTSJobotPlantSeed3.gameObject.SetActive(false);
            //    TTSJobotPlantSeed4.gameObject.SetActive(false);
            //    TTSJobotPlantSeed5.gameObject.SetActive(false);
                TTSJobotPlantSeed6.gameObject.SetActive(false);
                TTSSeedsComplete.gameObject.SetActive(false);
                TTSseedsWateredComplete.gameObject.SetActive(false);

                TTSStage2Complete.gameObject.SetActive(false);
                stage2Complete.gameObject.SetActive(false);
                if (!progressTextIsShowing)
                { // 3 second delay
                    StartCoroutine(DelayProgressButtonVar2());
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
                jobotIntroStage1Section1a.enabled = false;
            //    jobotIntroStage1Section1b.enabled = false;
                jobotIntroStage1Section1c.enabled = false;
                jobotIntroStage1Section1d.enabled = true;
            //    jobotIntroStage1Section1e.enabled = false;
                jobotIntroStage1Section1f.enabled = false;
                jobotIntroStage1Section1g.enabled = false;
                jobotIntroStage1Section1h.enabled = false;
                jobotIntroStage1Section1i.enabled = false;
                jobotStage2PlantSeed.enabled = false;
                jobotStage2PlantSeeda.enabled = false;
                jobotStage2PlantSeedb.enabled = false;
            //    jobotStage2PlantSeedc.enabled = false;
            //    jobotStage2PlantSeedd.enabled = false;
                jobotStage2PlantSeede.enabled = false;
                jobotSeedsPlanted.enabled = false;
                jobotSeedsWatered.enabled = false;

                TTSJobot1.gameObject.SetActive(false);
                TTSJobot2.gameObject.SetActive(false);
            //    TTSJobot3.gameObject.SetActive(false);
                TTSJobot4.gameObject.SetActive(false);
                TTSJobot5.gameObject.SetActive(true);
            //    TTSJobot6.gameObject.SetActive(false);
                TTSJobot7.gameObject.SetActive(false);
                TTSJobot8.gameObject.SetActive(false);
                TTSJobot9.gameObject.SetActive(false);
                TTSJobot10.gameObject.SetActive(false);
                TTSJobotPlantSeed1.gameObject.SetActive(false);
                TTSJobotPlantSeed2.gameObject.SetActive(false);
                TTSJobotPlantSeed3.gameObject.SetActive(false);
            //    TTSJobotPlantSeed4.gameObject.SetActive(false);
            //    TTSJobotPlantSeed5.gameObject.SetActive(false);
                TTSJobotPlantSeed6.gameObject.SetActive(false);
                TTSSeedsComplete.gameObject.SetActive(false);
                TTSseedsWateredComplete.gameObject.SetActive(false);

                TTSStage2Complete.gameObject.SetActive(false);
                stage2Complete.gameObject.SetActive(false);
                if (!progressTextIsShowing)
                { // 3 second delay
                    StartCoroutine(DelayProgressButtonVar2());
                    progressTextIsShowing = true;
                }
            }
            /*
            if (currentStageOfText == 5)
            {
                //  jobotIntroStage1e
                if (!textBeenRead)
                {
                    progressText.gameObject.SetActive(false);
                }
                jobotIntroStage1Section1.enabled = false;
                jobotIntroStage1Section1a.enabled = false;
           //     jobotIntroStage1Section1b.enabled = false;
                jobotIntroStage1Section1c.enabled = false;
                jobotIntroStage1Section1d.enabled = false;
           //     jobotIntroStage1Section1e.enabled = true;
                jobotIntroStage1Section1f.enabled = false;
                jobotIntroStage1Section1g.enabled = false;
                jobotIntroStage1Section1h.enabled = false;
                jobotIntroStage1Section1i.enabled = false;
                jobotStage2PlantSeed.enabled = false;
                jobotStage2PlantSeeda.enabled = false;
                jobotStage2PlantSeedb.enabled = false;
          //      jobotStage2PlantSeedc.enabled = false;
           //     jobotStage2PlantSeedd.enabled = false;
                jobotStage2PlantSeede.enabled = false;
                jobotSeedsPlanted.enabled = false;
                jobotSeedsWatered.enabled = false;

                TTSJobot1.gameObject.SetActive(false);
                TTSJobot2.gameObject.SetActive(false);
          //      TTSJobot3.gameObject.SetActive(false);
                TTSJobot4.gameObject.SetActive(false);
                TTSJobot5.gameObject.SetActive(false);
         //       TTSJobot6.gameObject.SetActive(true);
                TTSJobot7.gameObject.SetActive(false);
                TTSJobot8.gameObject.SetActive(false);
                TTSJobot9.gameObject.SetActive(false);
                TTSJobot10.gameObject.SetActive(false);
                TTSJobotPlantSeed1.gameObject.SetActive(false);
                TTSJobotPlantSeed2.gameObject.SetActive(false);
                TTSJobotPlantSeed3.gameObject.SetActive(false);
          //      TTSJobotPlantSeed4.gameObject.SetActive(false);
         //       TTSJobotPlantSeed5.gameObject.SetActive(false);
                TTSJobotPlantSeed6.gameObject.SetActive(false);
                TTSSeedsComplete.gameObject.SetActive(false);
                TTSseedsWateredComplete.gameObject.SetActive(false);

                TTSStage2Complete.gameObject.SetActive(false);
                stage2Complete.gameObject.SetActive(false);
                if (!progressTextIsShowing)
                { // 3 second delay
                    StartCoroutine(DelayProgressButtonVar1());
                    progressTextIsShowing = true;
                }
            }
*/
            if (currentStageOfText == 5)
            {
                if (!textBeenRead)
                {
                    progressText.gameObject.SetActive(false);
                }
                //  jobotIntroStage1f
                jobotIntroStage1Section1.enabled = false;
                jobotIntroStage1Section1a.enabled = false;
         //       jobotIntroStage1Section1b.enabled = false;
                jobotIntroStage1Section1c.enabled = false;
                jobotIntroStage1Section1d.enabled = false;
         //       jobotIntroStage1Section1e.enabled = false;
                jobotIntroStage1Section1f.enabled = true;
                jobotIntroStage1Section1g.enabled = false;
                jobotIntroStage1Section1h.enabled = false;
                jobotIntroStage1Section1i.enabled = false;
                jobotStage2PlantSeed.enabled = false;
                jobotStage2PlantSeeda.enabled = false;
                jobotStage2PlantSeedb.enabled = false;
          //      jobotStage2PlantSeedc.enabled = false;
         //      jobotStage2PlantSeedd.enabled = false;
                jobotStage2PlantSeede.enabled = false;
                jobotSeedsPlanted.enabled = false;
                jobotSeedsWatered.enabled = false;


                TTSJobot1.gameObject.SetActive(false);
                TTSJobot2.gameObject.SetActive(false);
         //       TTSJobot3.gameObject.SetActive(false);
                TTSJobot4.gameObject.SetActive(false);
                TTSJobot5.gameObject.SetActive(false);
         //       TTSJobot6.gameObject.SetActive(false);
                TTSJobot7.gameObject.SetActive(true);
                TTSJobot8.gameObject.SetActive(false);
                TTSJobot9.gameObject.SetActive(false);
                TTSJobot10.gameObject.SetActive(false);
                TTSJobotPlantSeed1.gameObject.SetActive(false);
                TTSJobotPlantSeed2.gameObject.SetActive(false);
                TTSJobotPlantSeed3.gameObject.SetActive(false);
          //      TTSJobotPlantSeed4.gameObject.SetActive(false);
         //       TTSJobotPlantSeed5.gameObject.SetActive(false);
                TTSJobotPlantSeed6.gameObject.SetActive(false);
                TTSSeedsComplete.gameObject.SetActive(false);
                TTSseedsWateredComplete.gameObject.SetActive(false);
                // taskPanal.SetActive(false);

                TTSStage2Complete.gameObject.SetActive(false);
                stage2Complete.gameObject.SetActive(false);
                if (!progressTextIsShowing)
                { // 3 second delay
                    StartCoroutine(DelayProgressButtonVar2());
                    progressTextIsShowing = true;
                }
            }

            if (currentStageOfText == 6)
            {
                if (!textBeenRead)
                {
                    progressText.gameObject.SetActive(false);
                }
                //  jobotIntroStage1g
                jobotIntroStage1Section1.enabled = false;
                jobotIntroStage1Section1a.enabled = false;
         //       jobotIntroStage1Section1b.enabled = false;
                jobotIntroStage1Section1c.enabled = false;
                jobotIntroStage1Section1d.enabled = false;
          //      jobotIntroStage1Section1e.enabled = false;
                jobotIntroStage1Section1f.enabled = false;
                jobotIntroStage1Section1g.enabled = true;
                jobotIntroStage1Section1h.enabled = false;
                jobotIntroStage1Section1i.enabled = false;
                jobotStage2PlantSeed.enabled = false;
                jobotStage2PlantSeeda.enabled = false;
                jobotStage2PlantSeedb.enabled = false;
          //      jobotStage2PlantSeedc.enabled = false;
          //      jobotStage2PlantSeedd.enabled = false;
                jobotStage2PlantSeede.enabled = false;
                jobotSeedsPlanted.enabled = false;
                jobotSeedsWatered.enabled = false;


                TTSJobot1.gameObject.SetActive(false);
                TTSJobot2.gameObject.SetActive(false);
         //       TTSJobot3.gameObject.SetActive(false);
                TTSJobot4.gameObject.SetActive(false);
                TTSJobot5.gameObject.SetActive(false);
         //       TTSJobot6.gameObject.SetActive(false);
                TTSJobot7.gameObject.SetActive(false);
                TTSJobot8.gameObject.SetActive(true);
                TTSJobot9.gameObject.SetActive(false);
                TTSJobot10.gameObject.SetActive(false);
                TTSJobotPlantSeed1.gameObject.SetActive(false);
                TTSJobotPlantSeed2.gameObject.SetActive(false);
                TTSJobotPlantSeed3.gameObject.SetActive(false);
           //      TTSJobotPlantSeed5.gameObject.SetActive(false);
          //      TTSJobotPlantSeed6.gameObject.SetActive(false);
                TTSSeedsComplete.gameObject.SetActive(false);
                TTSseedsWateredComplete.gameObject.SetActive(false);

                TTSStage2Complete.gameObject.SetActive(false);
                stage2Complete.gameObject.SetActive(false);
                if (!progressTextIsShowing)
                { // 3 second delay
                    StartCoroutine(DelayProgressButtonVar1());
                    progressTextIsShowing = true;
                }

            }

            if (currentStageOfText == 7)
            {
                if (!textBeenRead)
                {
                    progressText.gameObject.SetActive(false);
                }
                //  jobotIntroStage1h
                jobotIntroStage1Section1.enabled = false;
                jobotIntroStage1Section1a.enabled = false;
           //     jobotIntroStage1Section1b.enabled = false;
                jobotIntroStage1Section1c.enabled = false;
                jobotIntroStage1Section1d.enabled = false;
           //     jobotIntroStage1Section1e.enabled = false;
                jobotIntroStage1Section1f.enabled = false;
                jobotIntroStage1Section1g.enabled = false;
                jobotIntroStage1Section1h.enabled = true;
                jobotIntroStage1Section1i.enabled = false;
                jobotStage2PlantSeed.enabled = false;
                jobotStage2PlantSeeda.enabled = false;
                jobotStage2PlantSeedb.enabled = false;
           //     jobotStage2PlantSeedc.enabled = false;
            //    jobotStage2PlantSeedd.enabled = false;
                jobotStage2PlantSeede.enabled = false;
                jobotSeedsPlanted.enabled = false;
                jobotSeedsWatered.enabled = false;


                TTSJobot1.gameObject.SetActive(false);
                TTSJobot2.gameObject.SetActive(false);
            //    TTSJobot3.gameObject.SetActive(false);
                TTSJobot4.gameObject.SetActive(false);
                TTSJobot5.gameObject.SetActive(false);
            //    TTSJobot6.gameObject.SetActive(false);
                TTSJobot7.gameObject.SetActive(false);
                TTSJobot8.gameObject.SetActive(false);
                TTSJobot9.gameObject.SetActive(true);
                TTSJobot10.gameObject.SetActive(false);
                TTSJobotPlantSeed1.gameObject.SetActive(false);
                TTSJobotPlantSeed2.gameObject.SetActive(false);
                TTSJobotPlantSeed3.gameObject.SetActive(false);
          //      TTSJobotPlantSeed4.gameObject.SetActive(false);
          //      TTSJobotPlantSeed5.gameObject.SetActive(false);
                TTSJobotPlantSeed6.gameObject.SetActive(false);
                TTSSeedsComplete.gameObject.SetActive(false);
                TTSseedsWateredComplete.gameObject.SetActive(false);

                TTSStage2Complete.gameObject.SetActive(false);
                stage2Complete.gameObject.SetActive(false);
                if (!progressTextIsShowing)
                { // 3 second delay
                    StartCoroutine(DelayProgressButton());
                    progressTextIsShowing = true;
                }
            }

            if (currentStageOfText == 8)
            { //  jobotIntroStage1i
                if (!textBeenRead)
                {
                    progressText.gameObject.SetActive(false);
                }
                jobotIntroStage1Section1.enabled = false;
                jobotIntroStage1Section1a.enabled = false;
          //      jobotIntroStage1Section1b.enabled = false;
                jobotIntroStage1Section1c.enabled = false;
                jobotIntroStage1Section1d.enabled = false;
         //       jobotIntroStage1Section1e.enabled = false;
                jobotIntroStage1Section1f.enabled = false;
                jobotIntroStage1Section1g.enabled = false;
                jobotIntroStage1Section1h.enabled = false;
                jobotIntroStage1Section1i.enabled = true;
                jobotStage2PlantSeed.enabled = false;
                jobotStage2PlantSeeda.enabled = false;
                jobotStage2PlantSeedb.enabled = false;
            //    jobotStage2PlantSeedc.enabled = false;
            //    jobotStage2PlantSeedd.enabled = false;
                jobotStage2PlantSeede.enabled = false;
                jobotSeedsPlanted.enabled = false;
                jobotSeedsWatered.enabled = false;

                TTSJobot1.gameObject.SetActive(false);
                TTSJobot2.gameObject.SetActive(false);
            //    TTSJobot3.gameObject.SetActive(false);
                TTSJobot4.gameObject.SetActive(false);
                TTSJobot5.gameObject.SetActive(false);
          //      TTSJobot6.gameObject.SetActive(false);
                TTSJobot7.gameObject.SetActive(false);
                TTSJobot8.gameObject.SetActive(false);
                TTSJobot9.gameObject.SetActive(false);
                TTSJobot10.gameObject.SetActive(true);
                TTSJobotPlantSeed1.gameObject.SetActive(false);
                TTSJobotPlantSeed2.gameObject.SetActive(false);
                TTSJobotPlantSeed3.gameObject.SetActive(false);
            //    TTSJobotPlantSeed4.gameObject.SetActive(false);
             //   TTSJobotPlantSeed5.gameObject.SetActive(false);
                TTSJobotPlantSeed6.gameObject.SetActive(false);
                TTSSeedsComplete.gameObject.SetActive(false);
                TTSseedsWateredComplete.gameObject.SetActive(false);

                TTSStage2Complete.gameObject.SetActive(false);
                stage2Complete.gameObject.SetActive(false);
                doorAnim.SetBool("doorNeedsToBeOpen", false);
                doorAnim.SetBool("closeDoor", false);
                doorAnim.SetTrigger("resetDoorValues");
                if (!progressTextIsShowing)
                { // 3 second delay
                    StartCoroutine(DelayProgressButtonVar1());
                    progressTextIsShowing = true;
                }
            }


            if (currentStageOfText == 9)
            { //  jobotIntroStage1i
              // cameraToEnable.SetActive(false);
                if (!textBeenRead)
                {
                    progressText.gameObject.SetActive(false);
                }
                jobotIntroStage1Section1.enabled = false;
                jobotIntroStage1Section1a.enabled = false;
            //    jobotIntroStage1Section1b.enabled = false;
                jobotIntroStage1Section1c.enabled = false;
                jobotIntroStage1Section1d.enabled = false;
            //    jobotIntroStage1Section1e.enabled = false;
                jobotIntroStage1Section1f.enabled = false;
                jobotIntroStage1Section1g.enabled = false;
                jobotIntroStage1Section1h.enabled = false;
                jobotIntroStage1Section1i.enabled = true;
                jobotStage2PlantSeed.enabled = false;
                jobotStage2PlantSeeda.enabled = false;
                jobotStage2PlantSeedb.enabled = false;
             //   jobotStage2PlantSeedc.enabled = false;
             //   jobotStage2PlantSeedd.enabled = false;
                jobotStage2PlantSeede.enabled = false;
                jobotSeedsPlanted.enabled = false;
                jobotSeedsWatered.enabled = false;

                TTSJobot1.gameObject.SetActive(false);
                TTSJobot2.gameObject.SetActive(false);
            //    TTSJobot3.gameObject.SetActive(false);
                TTSJobot4.gameObject.SetActive(false);
                TTSJobot5.gameObject.SetActive(false);
            //    TTSJobot6.gameObject.SetActive(false);
                TTSJobot7.gameObject.SetActive(false);
                TTSJobot8.gameObject.SetActive(false);
                TTSJobot9.gameObject.SetActive(false);
                TTSJobot10.gameObject.SetActive(true);
                TTSJobotPlantSeed1.gameObject.SetActive(false);
                TTSJobotPlantSeed2.gameObject.SetActive(false);
                TTSJobotPlantSeed3.gameObject.SetActive(false);
             //   TTSJobotPlantSeed4.gameObject.SetActive(false);
            //    TTSJobotPlantSeed5.gameObject.SetActive(false);
                TTSJobotPlantSeed6.gameObject.SetActive(false);
                TTSSeedsComplete.gameObject.SetActive(false);
                TTSseedsWateredComplete.gameObject.SetActive(false);

                camZoomOutAnim.keepAnimatorControllerStateOnDisable = false;
                TTSStage2Complete.gameObject.SetActive(false);
                stage2Complete.gameObject.SetActive(false);
                // camZoomOutAnim.enabled = false;
                if (!progressTextIsShowing)
                { // 3 second delay
                    StartCoroutine(DelayProgressButtonVar2());
                    progressTextIsShowing = true;
                }

               
            }

            if (currentStageOfText == 10)
            { //  jobotIntroStage1i
                textPanalToHide.SetActive(true);
                if (!textBeenRead)
                {
                    progressText.gameObject.SetActive(false);
                }
                // camZoomOutAnim.enabled = true;
                resetplants.gameObject.SetActive(true);
                jobotIntroStage1Section1.enabled = false;
                jobotIntroStage1Section1a.enabled = false;
           //     jobotIntroStage1Section1b.enabled = false;
                jobotIntroStage1Section1c.enabled = false;
                jobotIntroStage1Section1d.enabled = false;
            //    jobotIntroStage1Section1e.enabled = false;
                jobotIntroStage1Section1f.enabled = false;
                jobotIntroStage1Section1g.enabled = false;
                jobotIntroStage1Section1h.enabled = false;
                jobotIntroStage1Section1i.enabled = false;
                jobotStage2PlantSeed.enabled = true;
                jobotStage2PlantSeeda.enabled = false;
                jobotStage2PlantSeedb.enabled = false;
            //    jobotStage2PlantSeedc.enabled = false;
            //    jobotStage2PlantSeedd.enabled = false;
                jobotStage2PlantSeede.enabled = false;
                jobotSeedsPlanted.enabled = false;
                jobotSeedsWatered.enabled = false;


                TTSJobot1.gameObject.SetActive(false);
                TTSJobot2.gameObject.SetActive(false);
            //    TTSJobot3.gameObject.SetActive(false);
                TTSJobot4.gameObject.SetActive(false);
                TTSJobot5.gameObject.SetActive(false);
            //    TTSJobot6.gameObject.SetActive(false);
                TTSJobot7.gameObject.SetActive(false);
                TTSJobot8.gameObject.SetActive(false);
                TTSJobot9.gameObject.SetActive(false);
                TTSJobot10.gameObject.SetActive(false);
                TTSJobotPlantSeed1.gameObject.SetActive(true);
                TTSJobotPlantSeed2.gameObject.SetActive(false);
               TTSJobotPlantSeed3.gameObject.SetActive(false);
             //   TTSJobotPlantSeed4.gameObject.SetActive(false);
            //    TTSJobotPlantSeed5.gameObject.SetActive(false);
                TTSJobotPlantSeed6.gameObject.SetActive(false);
                TTSSeedsComplete.gameObject.SetActive(false);
                TTSseedsWateredComplete.gameObject.SetActive(false);
                camZoomOutAnim.SetBool("startStage1PlayerCamZoomOut", true);
                StartCoroutine(DisableAllAnims());
                robotControl.StartPlayerMoving();
                seedPrompt.SetActive(true);
                seedPromptAnim.SetTrigger("seedPrompt");

               

                TTSStage2Complete.gameObject.SetActive(false);
                stage2Complete.gameObject.SetActive(false);
                if (!progressTextIsShowing)
                { // 3 second delay
                    StartCoroutine(DelayProgressButtonVar1());
                    progressTextIsShowing = true;
                }
            }

            if (currentStageOfText == 11)
            { //  jobotIntroStage1i

                if (!textBeenRead)
                {
                    progressText.gameObject.SetActive(false);
                }
                jobotIntroStage1Section1.enabled = false;
                jobotIntroStage1Section1a.enabled = false;
            //    jobotIntroStage1Section1b.enabled = false;
                jobotIntroStage1Section1c.enabled = false;
                jobotIntroStage1Section1d.enabled = false;
            //    jobotIntroStage1Section1e.enabled = false;
                jobotIntroStage1Section1f.enabled = false;
                jobotIntroStage1Section1g.enabled = false;
                jobotIntroStage1Section1h.enabled = false;
                jobotIntroStage1Section1i.enabled = false;
                jobotStage2PlantSeed.enabled = false;
                jobotStage2PlantSeeda.enabled = true;
                jobotStage2PlantSeedb.enabled = false;
            //    jobotStage2PlantSeedc.enabled = false;
            //    jobotStage2PlantSeedd.enabled = false;
                jobotStage2PlantSeede.enabled = false;
                jobotSeedsPlanted.enabled = false;
                jobotSeedsWatered.enabled = false;

                TTSJobot1.gameObject.SetActive(false);
                TTSJobot2.gameObject.SetActive(false);
            //    TTSJobot3.gameObject.SetActive(false);
                TTSJobot4.gameObject.SetActive(false);
                TTSJobot5.gameObject.SetActive(false);
            //    TTSJobot6.gameObject.SetActive(false);
                TTSJobot7.gameObject.SetActive(false);
                TTSJobot8.gameObject.SetActive(false);
                TTSJobot9.gameObject.SetActive(false);
                TTSJobot10.gameObject.SetActive(false);
                TTSJobotPlantSeed1.gameObject.SetActive(false);
                TTSJobotPlantSeed2.gameObject.SetActive(true);
                TTSJobotPlantSeed3.gameObject.SetActive(false);
            //    TTSJobotPlantSeed4.gameObject.SetActive(false);
            //    TTSJobotPlantSeed5.gameObject.SetActive(false);
                TTSJobotPlantSeed6.gameObject.SetActive(false);
                TTSSeedsComplete.gameObject.SetActive(false);
                TTSseedsWateredComplete.gameObject.SetActive(false);

                TTSStage2Complete.gameObject.SetActive(false);
                stage2Complete.gameObject.SetActive(false);
                if (!progressTextIsShowing)
                { // 3 second delay
                    StartCoroutine(DelayProgressButton());
                    progressTextIsShowing = true;
                }
            }

            if (currentStageOfText == 12)
            { //  jobotIntroStage1i

                if (!textBeenRead)
                {
                    progressText.gameObject.SetActive(false);
                }
                jobotIntroStage1Section1.enabled = false;
                jobotIntroStage1Section1a.enabled = false;
          //    jobotIntroStage1Section1b.enabled = false;
                jobotIntroStage1Section1c.enabled = false;
               jobotIntroStage1Section1d.enabled = false;
           //   jobotIntroStage1Section1e.enabled = false;
                jobotIntroStage1Section1f.enabled = false;
                jobotIntroStage1Section1g.enabled = false;
                jobotIntroStage1Section1h.enabled = false;
                jobotIntroStage1Section1i.enabled = false;
                jobotStage2PlantSeed.enabled = false;
                jobotStage2PlantSeeda.enabled = false;
                jobotStage2PlantSeedb.enabled = true;
          //    jobotStage2PlantSeedc.enabled = false;
          //      jobotStage2PlantSeedd.enabled = false;
                jobotStage2PlantSeede.enabled = false;
                jobotSeedsPlanted.enabled = false;
                jobotSeedsWatered.enabled = false;

                TTSJobot1.gameObject.SetActive(false);
                TTSJobot2.gameObject.SetActive(false);
                //TTSJobot3.gameObject.SetActive(false);
                TTSJobot4.gameObject.SetActive(false);
                TTSJobot5.gameObject.SetActive(false);
                //TTSJobot6.gameObject.SetActive(false);
                TTSJobot7.gameObject.SetActive(false);
                TTSJobot8.gameObject.SetActive(false);
                TTSJobot9.gameObject.SetActive(false);
                TTSJobot10.gameObject.SetActive(false);
                TTSJobotPlantSeed1.gameObject.SetActive(false);
                TTSJobotPlantSeed2.gameObject.SetActive(false);
                TTSJobotPlantSeed3.gameObject.SetActive(true);
                //TTSJobotPlantSeed4.gameObject.SetActive(false);
                // TTSJobotPlantSeed5.gameObject.SetActive(false);
                TTSJobotPlantSeed6.gameObject.SetActive(false);
                TTSSeedsComplete.gameObject.SetActive(false);
                jobotSeedsPlanted.enabled = false;
                TTSseedsWateredComplete.gameObject.SetActive(false);

                TTSStage2Complete.gameObject.SetActive(false);
                stage2Complete.gameObject.SetActive(false);
                if (!progressTextIsShowing)
                { // 3 second delay
                    StartCoroutine(DelayProgressButtonVar1());
                    progressTextIsShowing = true;
                }
            }
            /*
            if (currentStageOfText == 15)
            { //  jobotIntroStage1i

                if (!textBeenRead)
                {
                    progressText.gameObject.SetActive(false);
                }
                jobotIntroStage1Section1.enabled = false;
                jobotIntroStage1Section1a.enabled = false;
                // jobotIntroStage1Section1b.enabled = false;
                jobotIntroStage1Section1c.enabled = false;
                jobotIntroStage1Section1d.enabled = false;
                // jobotIntroStage1Section1e.enabled = false;
                jobotIntroStage1Section1f.enabled = false;
                jobotIntroStage1Section1g.enabled = false;
                jobotIntroStage1Section1h.enabled = false;
                jobotIntroStage1Section1i.enabled = false;
                jobotStage2PlantSeed.enabled = false;
                jobotStage2PlantSeeda.enabled = false;
                jobotStage2PlantSeedb.enabled = false;
                // jobotStage2PlantSeedc.enabled = true;
                //jobotStage2PlantSeedd.enabled = false;
                jobotStage2PlantSeede.enabled = false;
                jobotSeedsPlanted.enabled = false;
                jobotSeedsWatered.enabled = false;

                TTSJobot1.gameObject.SetActive(false);
                TTSJobot2.gameObject.SetActive(false);
                //  TTSJobot3.gameObject.SetActive(false);
                TTSJobot4.gameObject.SetActive(false);
                TTSJobot5.gameObject.SetActive(false);
                // TTSJobot6.gameObject.SetActive(false);
                TTSJobot7.gameObject.SetActive(false);
                TTSJobot8.gameObject.SetActive(false);
                TTSJobot9.gameObject.SetActive(false);
                TTSJobot10.gameObject.SetActive(false);
                TTSJobotPlantSeed1.gameObject.SetActive(false);
                TTSJobotPlantSeed2.gameObject.SetActive(false);
                TTSJobotPlantSeed3.gameObject.SetActive(false);
                // TTSJobotPlantSeed4.gameObject.SetActive(true);
                // TTSJobotPlantSeed5.gameObject.SetActive(false);
                TTSJobotPlantSeed6.gameObject.SetActive(false);
                TTSSeedsComplete.gameObject.SetActive(false);
                TTSseedsWateredComplete.gameObject.SetActive(false);

                TTSStage2Complete.gameObject.SetActive(false);
                stage2Complete.gameObject.SetActive(false);
                if (!progressTextIsShowing)
                { // 3 second delay
                    StartCoroutine(DelayProgressButtonVar2());
                    progressTextIsShowing = true;
                }
            }


            if (currentStageOfText == 16)
            { //  jobotIntroStage1i
                if (!textBeenRead)
                {
                    progressText.gameObject.SetActive(false);
                }
                jobotIntroStage1Section1.enabled = false;
                jobotIntroStage1Section1a.enabled = false;
                //  jobotIntroStage1Section1b.enabled = false;
                jobotIntroStage1Section1c.enabled = false;
                jobotIntroStage1Section1d.enabled = false;
                //  jobotIntroStage1Section1e.enabled = false;
                jobotIntroStage1Section1f.enabled = false;
                jobotIntroStage1Section1g.enabled = false;
                jobotIntroStage1Section1h.enabled = false;
                jobotIntroStage1Section1i.enabled = false;
                jobotStage2PlantSeed.enabled = false;
                jobotStage2PlantSeeda.enabled = false;
                jobotStage2PlantSeedb.enabled = false;
                //   jobotStage2PlantSeedc.enabled = false;
                //   jobotStage2PlantSeedd.enabled = true;
                jobotStage2PlantSeede.enabled = false;
                jobotSeedsPlanted.enabled = false;
                jobotSeedsWatered.enabled = false;

                TTSJobot1.gameObject.SetActive(false);
                TTSJobot2.gameObject.SetActive(false);
                //    TTSJobot3.gameObject.SetActive(false);
                TTSJobot4.gameObject.SetActive(false);
                TTSJobot5.gameObject.SetActive(false);
                //    TTSJobot6.gameObject.SetActive(false);
                TTSJobot7.gameObject.SetActive(false);
                TTSJobot8.gameObject.SetActive(false);
                TTSJobot9.gameObject.SetActive(false);
                TTSJobot10.gameObject.SetActive(false);
                TTSJobotPlantSeed1.gameObject.SetActive(false);
                TTSJobotPlantSeed2.gameObject.SetActive(false);
                TTSJobotPlantSeed3.gameObject.SetActive(false);
                //    TTSJobotPlantSeed4.gameObject.SetActive(false);
                //     TTSJobotPlantSeed5.gameObject.SetActive(true);
                TTSJobotPlantSeed6.gameObject.SetActive(false);
                TTSSeedsComplete.gameObject.SetActive(false);
                TTSseedsWateredComplete.gameObject.SetActive(false);

                TTSStage2Complete.gameObject.SetActive(false);
                stage2Complete.gameObject.SetActive(false);
                if (!progressTextIsShowing)
                { // 3 second delay
                    StartCoroutine(DelayProgressButtonVar1());
                    progressTextIsShowing = true;
                }
            }
            */
            if (currentStageOfText == 13)
            { //  jobotIntroStage1i
                if (!textBeenRead)
                {
                    progressText.gameObject.SetActive(false);
                }
                jobotIntroStage1Section1.enabled = false;
                jobotIntroStage1Section1a.enabled = false;
                //   jobotIntroStage1Section1b.enabled = false;
                jobotIntroStage1Section1c.enabled = false;
                jobotIntroStage1Section1d.enabled = false;
                //    jobotIntroStage1Section1e.enabled = false;
                jobotIntroStage1Section1f.enabled = false;
                jobotIntroStage1Section1g.enabled = false;
                jobotIntroStage1Section1h.enabled = false;
                jobotIntroStage1Section1i.enabled = false;
                jobotStage2PlantSeed.enabled = false;
                jobotStage2PlantSeeda.enabled = false;
                jobotStage2PlantSeedb.enabled = false;
                //  jobotStage2PlantSeedc.enabled = false;
                //  jobotStage2PlantSeedd.enabled = false;
                jobotStage2PlantSeede.enabled = true;
                jobotSeedsPlanted.enabled = false;
                jobotSeedsWatered.enabled = false;


                TTSJobot1.gameObject.SetActive(false);
                TTSJobot2.gameObject.SetActive(false);
                //   TTSJobot3.gameObject.SetActive(false);
                TTSJobot4.gameObject.SetActive(false);
                TTSJobot5.gameObject.SetActive(false);
                //   TTSJobot6.gameObject.SetActive(false);
                TTSJobot7.gameObject.SetActive(false);
                TTSJobot8.gameObject.SetActive(false);
                TTSJobot9.gameObject.SetActive(false);
                TTSJobot10.gameObject.SetActive(false);
                TTSJobotPlantSeed1.gameObject.SetActive(false);
                TTSJobotPlantSeed2.gameObject.SetActive(false);
                TTSJobotPlantSeed3.gameObject.SetActive(false);
                //   TTSJobotPlantSeed4.gameObject.SetActive(false);
                //   TTSJobotPlantSeed5.gameObject.SetActive(false);
                TTSJobotPlantSeed6.gameObject.SetActive(true);
                TTSSeedsComplete.gameObject.SetActive(false);
                TTSseedsWateredComplete.gameObject.SetActive(false);

                TTSStage2Complete.gameObject.SetActive(false);
                stage2Complete.gameObject.SetActive(false);
               // help.enabled = true;
               // tasks.enabled = true;
                if (!progressTextIsShowing)
                { // 3 second delay
                    StartCoroutine(DelayProgressButtonVar2());
                    progressTextIsShowing = true;
                }
            }
            if (currentStageOfText == 14)
            { //  jobotIntroStage1i
                if (!textBeenRead)
                {
                    progressText.gameObject.SetActive(false);
                }
                jobotIntroStage1Section1.enabled = false;
                jobotIntroStage1Section1a.enabled = false;
                //   jobotIntroStage1Section1b.enabled = false;
                jobotIntroStage1Section1c.enabled = false;
                jobotIntroStage1Section1d.enabled = false;
                //    jobotIntroStage1Section1e.enabled = false;
                jobotIntroStage1Section1f.enabled = false;
                jobotIntroStage1Section1g.enabled = false;
                jobotIntroStage1Section1h.enabled = false;
                jobotIntroStage1Section1i.enabled = false;
                jobotStage2PlantSeed.enabled = false;
                jobotStage2PlantSeeda.enabled = false;
                jobotStage2PlantSeedb.enabled = false;
                //    jobotStage2PlantSeedc.enabled = false;
                //     jobotStage2PlantSeedd.enabled = false;
                jobotStage2PlantSeede.enabled = false;
                jobotSeedsPlanted.enabled = false;
                jobotSeedsWatered.enabled = false;

                TTSJobot1.gameObject.SetActive(false);
                TTSJobot2.gameObject.SetActive(false);
                //     TTSJobot3.gameObject.SetActive(false);
                TTSJobot4.gameObject.SetActive(false);
                TTSJobot5.gameObject.SetActive(false);
                //     TTSJobot6.gameObject.SetActive(false);
                TTSJobot7.gameObject.SetActive(false);
                TTSJobot8.gameObject.SetActive(false);
                TTSJobot9.gameObject.SetActive(false);
                TTSJobot10.gameObject.SetActive(false);
                TTSJobotPlantSeed1.gameObject.SetActive(false);
                TTSJobotPlantSeed2.gameObject.SetActive(false);
                TTSJobotPlantSeed3.gameObject.SetActive(false);
                //     TTSJobotPlantSeed4.gameObject.SetActive(false);
                //     TTSJobotPlantSeed5.gameObject.SetActive(false);
                TTSJobotPlantSeed6.gameObject.SetActive(false);
                textPanalToHide.SetActive(false);
                help.enabled = true;
                tasks.enabled = true;
                robotControl.enabled = true;
                TTSSeedsComplete.gameObject.SetActive(false);
                TTSseedsWateredComplete.gameObject.SetActive(false);

                TTSStage2Complete.gameObject.SetActive(false);
                stage2Complete.gameObject.SetActive(false);
                if (!progressTextIsShowing)
                { // 3 second delay
                    StartCoroutine(DelayProgressButtonVar1());
                    progressTextIsShowing = true;
                }
            }

            if (currentStageOfText == 15)
            { //  jobotIntroStage1i
                if (!textBeenRead)
                {
                    progressText.gameObject.SetActive(false);
                }
                textPanalToHide.SetActive(true);
                jobotIntroStage1Section1.enabled = false;
                jobotIntroStage1Section1a.enabled = false;
                //     jobotIntroStage1Section1b.enabled = false;
                jobotIntroStage1Section1c.enabled = false;
                jobotIntroStage1Section1d.enabled = false;
                //    jobotIntroStage1Section1e.enabled = false;
                jobotIntroStage1Section1f.enabled = false;
                jobotIntroStage1Section1g.enabled = false;
                jobotIntroStage1Section1h.enabled = false;
                jobotIntroStage1Section1i.enabled = false;
                jobotStage2PlantSeed.enabled = false;
                jobotStage2PlantSeeda.enabled = false;
                jobotStage2PlantSeedb.enabled = false;
                //     jobotStage2PlantSeedc.enabled = false;
                //     jobotStage2PlantSeedd.enabled = false;
                jobotStage2PlantSeede.enabled = false;
                jobotSeedsPlanted.enabled = true;
                jobotSeedsWatered.enabled = false;

                TTSJobot1.gameObject.SetActive(false);
                TTSJobot2.gameObject.SetActive(false);
                //         TTSJobot3.gameObject.SetActive(false);
                TTSJobot4.gameObject.SetActive(false);
                TTSJobot5.gameObject.SetActive(false);
                //         TTSJobot6.gameObject.SetActive(false);
                TTSJobot7.gameObject.SetActive(false);
                TTSJobot8.gameObject.SetActive(false);
                TTSJobot9.gameObject.SetActive(false);
                TTSJobot10.gameObject.SetActive(false);
                TTSJobotPlantSeed1.gameObject.SetActive(false);
                TTSJobotPlantSeed2.gameObject.SetActive(false);
                TTSJobotPlantSeed3.gameObject.SetActive(false);
                //              TTSJobotPlantSeed4.gameObject.SetActive(false);
                //             TTSJobotPlantSeed5.gameObject.SetActive(false);
                TTSJobotPlantSeed6.gameObject.SetActive(false);
                TTSSeedsComplete.gameObject.SetActive(true);

                help.enabled = true;
                tasks.enabled = true;
                setPeicesToDisable.SetActive(true);
                TTSseedsWateredComplete.gameObject.SetActive(false);
                robotControl.enabled = true;
                playerRobotToShow.SetActive(true);
                robotAnim.keepAnimatorControllerStateOnDisable = false;
                robotAnim.enabled = false;
                robotToHide.SetActive(false);
                robotControl.enabled = true;

                TTSStage2Complete.gameObject.SetActive(false);
                stage2Complete.gameObject.SetActive(false);
            }
            if (currentStageOfText == 16)
            { //  jobotIntroStage1i
                textPanalToHide.SetActive(false);
                if (!textBeenRead)
                {
                    progressText.gameObject.SetActive(false);
                }
                //robotAnim.enabled = true;
                jobotIntroStage1Section1.enabled = false;
                jobotIntroStage1Section1a.enabled = false;
                //      jobotIntroStage1Section1b.enabled = false;
                jobotIntroStage1Section1c.enabled = false;
                jobotIntroStage1Section1d.enabled = false;
                //      jobotIntroStage1Section1e.enabled = false;
                jobotIntroStage1Section1f.enabled = false;
                jobotIntroStage1Section1g.enabled = false;
                jobotIntroStage1Section1h.enabled = false;
                jobotIntroStage1Section1i.enabled = false;
                jobotStage2PlantSeed.enabled = false;
                jobotStage2PlantSeeda.enabled = false;
                jobotStage2PlantSeedb.enabled = false;
                //       jobotStage2PlantSeedc.enabled = false;
                //       jobotStage2PlantSeedd.enabled = false;
                jobotStage2PlantSeede.enabled = false;
                jobotSeedsPlanted.enabled = false;
                jobotSeedsWatered.enabled = false;

                TTSJobot1.gameObject.SetActive(false);
                TTSJobot2.gameObject.SetActive(false);
                //    TTSJobot3.gameObject.SetActive(false);
                TTSJobot4.gameObject.SetActive(false);
                TTSJobot5.gameObject.SetActive(false);
                //    TTSJobot6.gameObject.SetActive(false);
                TTSJobot7.gameObject.SetActive(false);
                TTSJobot8.gameObject.SetActive(false);
                TTSJobot9.gameObject.SetActive(false);
                TTSJobot10.gameObject.SetActive(false);
                TTSJobotPlantSeed1.gameObject.SetActive(false);
                TTSJobotPlantSeed2.gameObject.SetActive(false);
                TTSJobotPlantSeed3.gameObject.SetActive(false);
                //     TTSJobotPlantSeed4.gameObject.SetActive(false);
                //     TTSJobotPlantSeed5.gameObject.SetActive(false);
                TTSJobotPlantSeed6.gameObject.SetActive(false);
                TTSSeedsComplete.gameObject.SetActive(false);
                TTSseedsWateredComplete.gameObject.SetActive(false);
                robotControl.enabled = true;

                TTSStage2Complete.gameObject.SetActive(false);
                stage2Complete.gameObject.SetActive(false);

            }

            if (currentStageOfText == 17)
            { //  jobotIntroStage1i
                if (!textBeenRead)
                {
                    progressText.gameObject.SetActive(false);
                }
                textPanalToHide.SetActive(true);
                jobotIntroStage1Section1.enabled = false;
                jobotIntroStage1Section1a.enabled = false;
                //     jobotIntroStage1Section1b.enabled = false;
                jobotIntroStage1Section1c.enabled = false;
                jobotIntroStage1Section1d.enabled = false;
                //   jobotIntroStage1Section1e.enabled = false;
                jobotIntroStage1Section1f.enabled = false;
                jobotIntroStage1Section1g.enabled = false;
                jobotIntroStage1Section1h.enabled = false;
                jobotIntroStage1Section1i.enabled = false;
                jobotStage2PlantSeed.enabled = false;
                jobotStage2PlantSeeda.enabled = false;
                jobotStage2PlantSeedb.enabled = false;
                //    jobotStage2PlantSeedc.enabled = false;
                //    jobotStage2PlantSeedd.enabled = false;
                jobotStage2PlantSeede.enabled = false;
                jobotSeedsPlanted.enabled = false;
                jobotSeedsWatered.enabled = true;

                TTSJobot1.gameObject.SetActive(false);
                TTSJobot2.gameObject.SetActive(false);
                //    TTSJobot3.gameObject.SetActive(false);
                TTSJobot4.gameObject.SetActive(false);
                TTSJobot5.gameObject.SetActive(false);
                //    TTSJobot6.gameObject.SetActive(false);
                TTSJobot7.gameObject.SetActive(false);
                TTSJobot8.gameObject.SetActive(false);
                TTSJobot9.gameObject.SetActive(false);
                TTSJobot10.gameObject.SetActive(false);
                TTSJobotPlantSeed1.gameObject.SetActive(false);
                TTSJobotPlantSeed2.gameObject.SetActive(false);
                TTSJobotPlantSeed3.gameObject.SetActive(false);
                //    TTSJobotPlantSeed4.gameObject.SetActive(false);
                //    TTSJobotPlantSeed5.gameObject.SetActive(false);
                TTSJobotPlantSeed6.gameObject.SetActive(false);
                TTSSeedsComplete.gameObject.SetActive(false);
                TTSseedsWateredComplete.gameObject.SetActive(true);
                robotControl.enabled = true;
                StartCoroutine(HideText());
                StartCoroutine(ResetDoor());
                help.enabled = true;
                tasks.enabled = true;
                progressText.gameObject.SetActive(false);
                TTSStage2Complete.gameObject.SetActive(false);
                stage2Complete.gameObject.SetActive(false);

            }

            if (currentStageOfText == 18)
            { //  jobotIntroStage1i
                textPanalToHide.SetActive(true);
                //robotAnim.enabled = true;

                jobotIntroStage1Section1.enabled = false;
                jobotIntroStage1Section1a.enabled = false;
                //     jobotIntroStage1Section1b.enabled = false;
                jobotIntroStage1Section1c.enabled = false;
                jobotIntroStage1Section1d.enabled = false;
                //     jobotIntroStage1Section1e.enabled = false;
                jobotIntroStage1Section1f.enabled = false;
                jobotIntroStage1Section1g.enabled = false;
                jobotIntroStage1Section1h.enabled = false;
                jobotIntroStage1Section1i.enabled = false;
                jobotStage2PlantSeed.enabled = false;
                jobotStage2PlantSeeda.enabled = false;
                jobotStage2PlantSeedb.enabled = false;
                //     jobotStage2PlantSeedc.enabled = false;
                //     jobotStage2PlantSeedd.enabled = false;
                jobotStage2PlantSeede.enabled = false;
                jobotSeedsPlanted.enabled = false;
                jobotSeedsWatered.enabled = false;
                TTSJobot1.gameObject.SetActive(false);
                TTSJobot2.gameObject.SetActive(false);
                //       TTSJobot3.gameObject.SetActive(false);
                TTSJobot4.gameObject.SetActive(false);
                TTSJobot5.gameObject.SetActive(false);
                //       TTSJobot6.gameObject.SetActive(false);
                TTSJobot7.gameObject.SetActive(false);
                TTSJobot8.gameObject.SetActive(false);
                TTSJobot9.gameObject.SetActive(false);
                TTSJobot10.gameObject.SetActive(false);
                TTSJobotPlantSeed1.gameObject.SetActive(false);
                TTSJobotPlantSeed2.gameObject.SetActive(false);
                TTSJobotPlantSeed3.gameObject.SetActive(false);
                //         TTSJobotPlantSeed4.gameObject.SetActive(false);
                //         TTSJobotPlantSeed5.gameObject.SetActive(false);
                TTSJobotPlantSeed6.gameObject.SetActive(false);
                TTSSeedsComplete.gameObject.SetActive(false);
                TTSseedsWateredComplete.gameObject.SetActive(false);
                robotControl.enabled = false;
         
                TTSStage2Complete.gameObject.SetActive(true);
                stage2Complete.gameObject.SetActive(true);
                StartCoroutine(HideText());
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
