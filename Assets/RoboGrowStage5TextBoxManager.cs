using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using LoLSDK;
namespace Alpha.Phases.Robo.Grow
{
    public class RoboGrowStage5TextBoxManager : MonoBehaviour
    {
        public RoboGrowMain rgMainData;
        public GameObject textPanalToHide;
        public GameObject maincamera;
        public RobotController robotControl;
        public RoboGrowEndOfGameTrigger rgEnd;
        public Animator camZoomOutAnim;
        public Animator closeDoor;

        public Button help;
        public Button tasks;
        public bool runOnce;

        public GameObject robotPlayer;
        public GameObject introRobotStage5;
        public bool saveGameOnce;

        public Camera mainCamerToDisable;
        public Camera robotCamToEnable;
        public Button forwardButtonToDisable;
        public GameObject taskPanal;
        public GameObject setPeicesToDisable;
        public bool introReadyToBeCompleted;

        public bool textBeenRead;
        public bool progressTextIsShowing;

        public Button TTSStage5Jobot1;
        // public Button TTSStage5Jobot2;
        public Button TTSStage5Jobot3;
        //  public Button TTSStage5Jobot4;
        //  public Button TTSStage5Jobot5;
        public Button TTSStage5Jobot6;
        //public Button TTSStage5Jobot7;
        public Button TTSStage5Jobot8;
        public Button TTSStage5Jobot9;
        //  public Button TTSStage5Jobot10;
        public Button TTSStage5Jobot11;
        // public Button TTSStage5Jobot12;
        // public Button TTSStage5Jobot13;
        // public Button TTSStage5Jobot14;
        public Button TTSStage5Jobot15;

        public Button TTSStage5PlantRemovalComplete1;
        public Button TTSStage5PlantRemovalComplete1a;
        public Button TTSStage5PlantRemovalComplete1b;
        public Button TTSStage5PlantRemovalComplete1c;
        //  public Button TTSStage5PlantRemovalComplete1d;

        public TextMeshProUGUI jobotIntroStage5Section1;
        //  public TextMeshProUGUI jobotIntroStage5Section1a;
        public TextMeshProUGUI jobotIntroStage5Section1b;
        //   public TextMeshProUGUI jobotIntroStage5Section1c;
        //   public TextMeshProUGUI jobotIntroStage5Section1d;
        public TextMeshProUGUI jobotIntroStage5Section1e;
        //    public TextMeshProUGUI jobotIntroStage5Section1f;
        public TextMeshProUGUI jobotIntroStage5Section1g;
        public TextMeshProUGUI jobotIntroStage5Section1h;
        //    public TextMeshProUGUI jobotIntroStage5Section1i;
        public TextMeshProUGUI jobotIntroStage5Section1j;
        //     public TextMeshProUGUI jobotIntroStage5Section1k;
        //     public TextMeshProUGUI jobotIntroStage5Section1l;
        //      public TextMeshProUGUI jobotIntroStage5Section1m;
        public TextMeshProUGUI jobotIntroStage5Section1n;

        public TextMeshProUGUI jobotIntroStage5PlantRemovalComplete1;
        public TextMeshProUGUI jobotIntroStage5PlantRemovalComplete1a;
        public TextMeshProUGUI jobotIntroStage5PlantRemovalComplete1b;
        public TextMeshProUGUI jobotIntroStage5PlantRemovalComplete1c;
        //  public TextMeshProUGUI jobotIntroStage5PlantRemovalComplete1d;

        public Button TTSAllTaskCompleteStage5;
        public TextMeshProUGUI stage5AllTasksComplete;


        public TextMeshProUGUI jobotEndOFGame1;
        public TextMeshProUGUI jobotEndOFGame1a;
        public TextMeshProUGUI jobotEndOFGame1b;
        public TextMeshProUGUI jobotEndOFGame1c;
        public TextMeshProUGUI jobotEndOFGame1d;
        public TextMeshProUGUI jobotEndOFGame1e;
        public TextMeshProUGUI jobotEndOFGame1f;

        public Button TTSStage5EndOFGame1;
        public Button TTSStage5EndOFGame2;
        public Button TTSStage5EndOFGame3;
        public Button TTSStage5EndOFGame4;
        public Button TTSStage5EndOFGame5;
        public Button TTSStage5EndOFGame6;
        public Button TTSStage5EndOFGame7;


        public Button progressText;
        public Button progressTextBack;

        public int currentStageOfText;

        private void Awake()
        {
            currentStageOfText = 0;
            progressText.onClick.AddListener(OnClick);
            progressTextBack.onClick.AddListener(OnClickBack);
            TTSStage5Jobot1.onClick.AddListener(JobotStage5Section1);
            //    TTSStage5Jobot2.onClick.AddListener(JobotStage5Section1a);
            TTSStage5Jobot3.onClick.AddListener(JobotStage5Section1b);
            //    TTSStage5Jobot4.onClick.AddListener(JobotStage5Section1c);
            //    TTSStage5Jobot5.onClick.AddListener(JobotStage5Section1d);
            TTSStage5Jobot6.onClick.AddListener(JobotStage5Section1e);
            //    TTSStage5Jobot7.onClick.AddListener(JobotStage5Section1f);
            TTSStage5Jobot8.onClick.AddListener(JobotStage5Section1g);
            TTSStage5Jobot9.onClick.AddListener(JobotStage5Section1h);
            //    TTSStage5Jobot10.onClick.AddListener(JobotStage5Section1i);
            TTSStage5Jobot11.onClick.AddListener(JobotStage5Section1j);
            //    TTSStage5Jobot12.onClick.AddListener(JobotStage5Section1k);
            //    TTSStage5Jobot13.onClick.AddListener(JobotStage5Section1l);
            //    TTSStage5Jobot14.onClick.AddListener(JobotStage5Section1m);
            TTSStage5Jobot15.onClick.AddListener(JobotStage5Section1n);

            TTSStage5PlantRemovalComplete1.onClick.AddListener(JobotStage5PlantsRemoved1);
            TTSStage5PlantRemovalComplete1a.onClick.AddListener(JobotStage5PlantsRemoved1a);
            TTSStage5PlantRemovalComplete1b.onClick.AddListener(JobotStage5PlantsRemoved1b);
            TTSStage5PlantRemovalComplete1c.onClick.AddListener(JobotStage5PlantsRemoved1c);
            // TTSStage5PlantRemovalComplete1d.onClick.AddListener(JobotStage5PlantsRemoved1d);

            TTSAllTaskCompleteStage5.onClick.AddListener(JobotStage5AllTasksComplete);

            TTSStage5EndOFGame1.onClick.AddListener(JobotStage5EndOFGame1);
            TTSStage5EndOFGame2.onClick.AddListener(JobotStage5EndOFGame1a);
            TTSStage5EndOFGame3.onClick.AddListener(JobotStage5EndOFGame1b);
            TTSStage5EndOFGame4.onClick.AddListener(JobotStage5EndOFGame1c);
            TTSStage5EndOFGame5.onClick.AddListener(JobotStage5EndOFGame1d);
            TTSStage5EndOFGame6.onClick.AddListener(JobotStage5EndOFGame1e);
            TTSStage5EndOFGame7.onClick.AddListener(JobotStage5EndOFGame1f);

        }

        // Start is called before the first frame update
        void Start()
        {
            //  This is the text for the start intro for stage 5


            jobotIntroStage5Section1.enabled = false;
            //  jobotIntroStage5Section1a.enabled = false;
            jobotIntroStage5Section1b.enabled = false;
            //   jobotIntroStage5Section1c.enabled = false;
            //    jobotIntroStage5Section1d.enabled = false;
            jobotIntroStage5Section1e.enabled = false;
            //    jobotIntroStage5Section1f.enabled = false;
            jobotIntroStage5Section1g.enabled = false;
            jobotIntroStage5Section1h.enabled = false;
            //     jobotIntroStage5Section1i.enabled = false;
            jobotIntroStage5Section1j.enabled = false;
            //     jobotIntroStage5Section1k.enabled = false;
            //    jobotIntroStage5Section1l.enabled = false;
            //     jobotIntroStage5Section1m.enabled = false;
            jobotIntroStage5Section1n.enabled = false;


            TTSStage5Jobot1.gameObject.SetActive(false);
            //   TTSStage5Jobot2.gameObject.SetActive(false);
            TTSStage5Jobot3.gameObject.SetActive(false);
            //   TTSStage5Jobot4.gameObject.SetActive(false);
            //    TTSStage5Jobot5.gameObject.SetActive(false);
            TTSStage5Jobot6.gameObject.SetActive(false);
            //     TTSStage5Jobot7.gameObject.SetActive(false);
            TTSStage5Jobot8.gameObject.SetActive(false);
            TTSStage5Jobot9.gameObject.SetActive(false);
            //     TTSStage5Jobot10.gameObject.SetActive(false);
            TTSStage5Jobot11.gameObject.SetActive(false);
            //     TTSStage5Jobot12.gameObject.SetActive(false);
            //     TTSStage5Jobot13.gameObject.SetActive(false);
            //      TTSStage5Jobot14.gameObject.SetActive(false);
            TTSStage5Jobot15.gameObject.SetActive(false);


            // This is the text for the removal of the flowers on stage 5
            jobotIntroStage5PlantRemovalComplete1.gameObject.SetActive(false);
            jobotIntroStage5PlantRemovalComplete1a.gameObject.SetActive(false);
            jobotIntroStage5PlantRemovalComplete1b.gameObject.SetActive(false);
            jobotIntroStage5PlantRemovalComplete1c.gameObject.SetActive(false);
            //    jobotIntroStage5PlantRemovalComplete1d.gameObject.SetActive(false);

            TTSStage5PlantRemovalComplete1.gameObject.SetActive(false);
            TTSStage5PlantRemovalComplete1a.gameObject.SetActive(false);
            TTSStage5PlantRemovalComplete1b.gameObject.SetActive(false);
            TTSStage5PlantRemovalComplete1c.gameObject.SetActive(false);
            //   TTSStage5PlantRemovalComplete1d.gameObject.SetActive(false);

            TTSAllTaskCompleteStage5.gameObject.SetActive(false);
            stage5AllTasksComplete.gameObject.SetActive(false);

            TTSStage5EndOFGame1.gameObject.SetActive(false);
            TTSStage5EndOFGame2.gameObject.SetActive(false);
            TTSStage5EndOFGame3.gameObject.SetActive(false);
            TTSStage5EndOFGame4.gameObject.SetActive(false);
            TTSStage5EndOFGame5.gameObject.SetActive(false);
            TTSStage5EndOFGame6.gameObject.SetActive(false);
            TTSStage5EndOFGame7.gameObject.SetActive(false);

            jobotEndOFGame1.gameObject.SetActive(false);
            jobotEndOFGame1a.gameObject.SetActive(false);
            jobotEndOFGame1b.gameObject.SetActive(false);
            jobotEndOFGame1c.gameObject.SetActive(false);
            jobotEndOFGame1d.gameObject.SetActive(false);
            jobotEndOFGame1e.gameObject.SetActive(false);
            jobotEndOFGame1f.gameObject.SetActive(false);


        }

        // Update is called once per frame
        void Update()
        {
            if (rgMainData.currentGameStage == 5)
            {
                //  jobotIntroStage1
                if (currentStageOfText == 1)
                {
                    if (!textBeenRead)
                    {
                        progressText.gameObject.SetActive(false);
                    }
                    progressTextBack.gameObject.SetActive(false);
                    robotControl.enabled = false;
                    textPanalToHide.SetActive(true);
                    jobotIntroStage5Section1.enabled = true;
                    //       jobotIntroStage5Section1a.enabled = false;
                    jobotIntroStage5Section1b.enabled = false;
                    //       jobotIntroStage5Section1c.enabled = false;
                    //        jobotIntroStage5Section1d.enabled = false;
                    jobotIntroStage5Section1e.enabled = false;
                    //        jobotIntroStage5Section1f.enabled = false;
                    jobotIntroStage5Section1g.enabled = false;
                    jobotIntroStage5Section1h.enabled = false;
                    //        jobotIntroStage5Section1i.enabled = false;
                    jobotIntroStage5Section1j.enabled = false;
                    //        jobotIntroStage5Section1k.enabled = false;
                    //        jobotIntroStage5Section1l.enabled = false;
                    //         jobotIntroStage5Section1m.enabled = false;
                    jobotIntroStage5Section1n.enabled = false;



                    TTSStage5Jobot1.gameObject.SetActive(true);
                    //     TTSStage5Jobot2.gameObject.SetActive(false);
                    TTSStage5Jobot3.gameObject.SetActive(false);
                    //      TTSStage5Jobot4.gameObject.SetActive(false);
                    //       TTSStage5Jobot5.gameObject.SetActive(false);
                    TTSStage5Jobot6.gameObject.SetActive(false);
                    //       TTSStage5Jobot7.gameObject.SetActive(false);
                    TTSStage5Jobot8.gameObject.SetActive(false);
                    TTSStage5Jobot9.gameObject.SetActive(false);
                    //        TTSStage5Jobot10.gameObject.SetActive(false);
                    TTSStage5Jobot11.gameObject.SetActive(false);
                    //         TTSStage5Jobot12.gameObject.SetActive(false);
                    //         TTSStage5Jobot13.gameObject.SetActive(false);
                    //         TTSStage5Jobot14.gameObject.SetActive(false);
                    TTSStage5Jobot15.gameObject.SetActive(false);
                    closeDoor.SetBool("closeDoor", true);


                    jobotIntroStage5PlantRemovalComplete1.gameObject.SetActive(false);
                    jobotIntroStage5PlantRemovalComplete1a.gameObject.SetActive(false);
                    jobotIntroStage5PlantRemovalComplete1b.gameObject.SetActive(false);
                    jobotIntroStage5PlantRemovalComplete1c.gameObject.SetActive(false);
                    //        jobotIntroStage5PlantRemovalComplete1d.gameObject.SetActive(false);

                    TTSStage5PlantRemovalComplete1.gameObject.SetActive(false);
                    TTSStage5PlantRemovalComplete1a.gameObject.SetActive(false);
                    TTSStage5PlantRemovalComplete1b.gameObject.SetActive(false);
                    TTSStage5PlantRemovalComplete1c.gameObject.SetActive(false);
                    //     TTSStage5PlantRemovalComplete1d.gameObject.SetActive(false);

                    TTSAllTaskCompleteStage5.gameObject.SetActive(false);
                    stage5AllTasksComplete.gameObject.SetActive(false);


                    TTSStage5EndOFGame1.gameObject.SetActive(false);
                    TTSStage5EndOFGame2.gameObject.SetActive(false);
                    TTSStage5EndOFGame3.gameObject.SetActive(false);
                    TTSStage5EndOFGame4.gameObject.SetActive(false);
                    TTSStage5EndOFGame5.gameObject.SetActive(false);
                    TTSStage5EndOFGame6.gameObject.SetActive(false);
                    TTSStage5EndOFGame7.gameObject.SetActive(false);

                    jobotEndOFGame1.gameObject.SetActive(false);
                    jobotEndOFGame1a.gameObject.SetActive(false);
                    jobotEndOFGame1b.gameObject.SetActive(false);
                    jobotEndOFGame1c.gameObject.SetActive(false);
                    jobotEndOFGame1d.gameObject.SetActive(false);
                    jobotEndOFGame1e.gameObject.SetActive(false);
                    jobotEndOFGame1f.gameObject.SetActive(false);

                    if (!progressTextIsShowing)
                    { // 3 second delay
                        StartCoroutine(DelayProgressButtonVar1());
                        progressTextIsShowing = true;
                    }

                }
                /*
                //  jobotIntroStage1
                if (currentStageOfText == 2)
                {
                    if (!textBeenRead)
                    {
                        progressText.gameObject.SetActive(false);
                    }
                    progressTextBack.gameObject.SetActive(true);

                    jobotIntroStage5Section1.enabled = false;
              //      jobotIntroStage5Section1a.enabled = true;
                    jobotIntroStage5Section1b.enabled = false;
             //       jobotIntroStage5Section1c.enabled = false;
             //       jobotIntroStage5Section1d.enabled = false;
                    jobotIntroStage5Section1e.enabled = false;
             //       jobotIntroStage5Section1f.enabled = false;
                    jobotIntroStage5Section1g.enabled = false;
                    jobotIntroStage5Section1h.enabled = false;
            //        jobotIntroStage5Section1i.enabled = false;
                    jobotIntroStage5Section1j.enabled = false;
            //        jobotIntroStage5Section1k.enabled = false;
           //         jobotIntroStage5Section1l.enabled = false;
           //         jobotIntroStage5Section1m.enabled = false;
                    jobotIntroStage5Section1n.enabled = false;



                    TTSStage5Jobot1.gameObject.SetActive(false);
              //      TTSStage5Jobot2.gameObject.SetActive(true);
                    TTSStage5Jobot3.gameObject.SetActive(false);
            //        TTSStage5Jobot4.gameObject.SetActive(false);
            //        TTSStage5Jobot5.gameObject.SetActive(false);
                    TTSStage5Jobot6.gameObject.SetActive(false);
            //        TTSStage5Jobot7.gameObject.SetActive(false);
                    TTSStage5Jobot8.gameObject.SetActive(false);
                    TTSStage5Jobot9.gameObject.SetActive(false);
           //         TTSStage5Jobot10.gameObject.SetActive(false);
                    TTSStage5Jobot11.gameObject.SetActive(false);
           //         TTSStage5Jobot12.gameObject.SetActive(false);
           //         TTSStage5Jobot13.gameObject.SetActive(false);
           //         TTSStage5Jobot14.gameObject.SetActive(false);
                    TTSStage5Jobot15.gameObject.SetActive(false);


                    // This is the text for the removal of the flowers on stage 5
                    jobotIntroStage5PlantRemovalComplete1.gameObject.SetActive(false);
                    jobotIntroStage5PlantRemovalComplete1a.gameObject.SetActive(false);
                    jobotIntroStage5PlantRemovalComplete1b.gameObject.SetActive(false);
                    jobotIntroStage5PlantRemovalComplete1c.gameObject.SetActive(false);
            //        jobotIntroStage5PlantRemovalComplete1d.gameObject.SetActive(false);

                    TTSStage5PlantRemovalComplete1.gameObject.SetActive(false);
                    TTSStage5PlantRemovalComplete1a.gameObject.SetActive(false);
                    TTSStage5PlantRemovalComplete1b.gameObject.SetActive(false);
                    TTSStage5PlantRemovalComplete1c.gameObject.SetActive(false);
             //       TTSStage5PlantRemovalComplete1d.gameObject.SetActive(false);

                    TTSAllTaskCompleteStage5.gameObject.SetActive(false);
                    stage5AllTasksComplete.gameObject.SetActive(false);




                    TTSStage5EndOFGame1.gameObject.SetActive(false);
                    TTSStage5EndOFGame2.gameObject.SetActive(false);
                    TTSStage5EndOFGame3.gameObject.SetActive(false);
                    TTSStage5EndOFGame4.gameObject.SetActive(false);
                    TTSStage5EndOFGame5.gameObject.SetActive(false);
                    TTSStage5EndOFGame6.gameObject.SetActive(false);
                    TTSStage5EndOFGame7.gameObject.SetActive(false);

                    jobotEndOFGame1.gameObject.SetActive(false);
                    jobotEndOFGame1a.gameObject.SetActive(false);
                    jobotEndOFGame1b.gameObject.SetActive(false);
                    jobotEndOFGame1c.gameObject.SetActive(false);
                    jobotEndOFGame1d.gameObject.SetActive(false);
                    jobotEndOFGame1e.gameObject.SetActive(false);
                    jobotEndOFGame1f.gameObject.SetActive(false);
                    if (!progressTextIsShowing)
                    { // 3 second delay
                        StartCoroutine(DelayProgressButtonVar2());
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
                    jobotIntroStage5Section1.enabled = false;
                    //       jobotIntroStage5Section1a.enabled = false;
                    jobotIntroStage5Section1b.enabled = true;
                    //        jobotIntroStage5Section1c.enabled = false;
                    //        jobotIntroStage5Section1d.enabled = false;
                    jobotIntroStage5Section1e.enabled = false;
                    //        jobotIntroStage5Section1f.enabled = false;
                    jobotIntroStage5Section1g.enabled = false;
                    jobotIntroStage5Section1h.enabled = false;
                    //        jobotIntroStage5Section1i.enabled = false;
                    jobotIntroStage5Section1j.enabled = false;
                    //         jobotIntroStage5Section1k.enabled = false;
                    //         jobotIntroStage5Section1l.enabled = false;
                    //         jobotIntroStage5Section1m.enabled = false;
                    jobotIntroStage5Section1n.enabled = false;



                    TTSStage5Jobot1.gameObject.SetActive(false);
                    //       TTSStage5Jobot2.gameObject.SetActive(false);
                    TTSStage5Jobot3.gameObject.SetActive(true);
                    //       TTSStage5Jobot4.gameObject.SetActive(false);
                    //        TTSStage5Jobot5.gameObject.SetActive(false);
                    TTSStage5Jobot6.gameObject.SetActive(false);
                    //        TTSStage5Jobot7.gameObject.SetActive(false);
                    TTSStage5Jobot8.gameObject.SetActive(false);
                    TTSStage5Jobot9.gameObject.SetActive(false);
                    //         TTSStage5Jobot10.gameObject.SetActive(false);
                    TTSStage5Jobot11.gameObject.SetActive(false);
                    //         TTSStage5Jobot12.gameObject.SetActive(false);
                    //          TTSStage5Jobot13.gameObject.SetActive(false);
                    //          TTSStage5Jobot14.gameObject.SetActive(false);
                    TTSStage5Jobot15.gameObject.SetActive(false);


                    // This is the text for the removal of the flowers on stage 5
                    jobotIntroStage5PlantRemovalComplete1.gameObject.SetActive(false);
                    jobotIntroStage5PlantRemovalComplete1a.gameObject.SetActive(false);
                    jobotIntroStage5PlantRemovalComplete1b.gameObject.SetActive(false);
                    jobotIntroStage5PlantRemovalComplete1c.gameObject.SetActive(false);
                    //       jobotIntroStage5PlantRemovalComplete1d.gameObject.SetActive(false);

                    TTSStage5PlantRemovalComplete1.gameObject.SetActive(false);
                    TTSStage5PlantRemovalComplete1a.gameObject.SetActive(false);
                    TTSStage5PlantRemovalComplete1b.gameObject.SetActive(false);
                    TTSStage5PlantRemovalComplete1c.gameObject.SetActive(false);
                    //       TTSStage5PlantRemovalComplete1d.gameObject.SetActive(false);

                    TTSAllTaskCompleteStage5.gameObject.SetActive(false);
                    stage5AllTasksComplete.gameObject.SetActive(false);



                    TTSStage5EndOFGame1.gameObject.SetActive(false);
                    TTSStage5EndOFGame2.gameObject.SetActive(false);
                    TTSStage5EndOFGame3.gameObject.SetActive(false);
                    TTSStage5EndOFGame4.gameObject.SetActive(false);
                    TTSStage5EndOFGame5.gameObject.SetActive(false);
                    TTSStage5EndOFGame6.gameObject.SetActive(false);
                    TTSStage5EndOFGame7.gameObject.SetActive(false);

                    jobotEndOFGame1.gameObject.SetActive(false);
                    jobotEndOFGame1a.gameObject.SetActive(false);
                    jobotEndOFGame1b.gameObject.SetActive(false);
                    jobotEndOFGame1c.gameObject.SetActive(false);
                    jobotEndOFGame1d.gameObject.SetActive(false);
                    jobotEndOFGame1e.gameObject.SetActive(false);
                    jobotEndOFGame1f.gameObject.SetActive(false);

                    closeDoor.SetBool("doorNeedsToBeOpen", false);
                    closeDoor.SetBool("closeDoor", false);
                    closeDoor.SetTrigger("resetDoorValues");
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
                    jobotIntroStage5Section1.enabled = false;
                    //    jobotIntroStage5Section1a.enabled = false;
                    jobotIntroStage5Section1b.enabled = false;
                    //     jobotIntroStage5Section1c.enabled = false;
                    //      jobotIntroStage5Section1d.enabled = false;
                    jobotIntroStage5Section1e.enabled = true;
                    //      jobotIntroStage5Section1f.enabled = false;
                    jobotIntroStage5Section1g.enabled = false;
                    jobotIntroStage5Section1h.enabled = false;
                    //      jobotIntroStage5Section1i.enabled = false;
                    jobotIntroStage5Section1j.enabled = false;
                    //       jobotIntroStage5Section1k.enabled = false;
                    //       jobotIntroStage5Section1l.enabled = false;
                    //       jobotIntroStage5Section1m.enabled = false;
                    jobotIntroStage5Section1n.enabled = false;



                    TTSStage5Jobot1.gameObject.SetActive(false);
                    //     TTSStage5Jobot2.gameObject.SetActive(false);
                    TTSStage5Jobot3.gameObject.SetActive(false);
                    //     TTSStage5Jobot4.gameObject.SetActive(false);
                    //      TTSStage5Jobot5.gameObject.SetActive(false);
                    TTSStage5Jobot6.gameObject.SetActive(true);
                    //      TTSStage5Jobot7.gameObject.SetActive(false);
                    TTSStage5Jobot8.gameObject.SetActive(false);
                    TTSStage5Jobot9.gameObject.SetActive(false);
                    //      TTSStage5Jobot10.gameObject.SetActive(false);
                    TTSStage5Jobot11.gameObject.SetActive(false);
                    //      TTSStage5Jobot12.gameObject.SetActive(false);
                    //       TTSStage5Jobot13.gameObject.SetActive(false);
                    ///      TTSStage5Jobot14.gameObject.SetActive(false);
                    TTSStage5Jobot15.gameObject.SetActive(false);

                    // This is the text for the removal of the flowers on stage 5
                    jobotIntroStage5PlantRemovalComplete1.gameObject.SetActive(false);
                    jobotIntroStage5PlantRemovalComplete1a.gameObject.SetActive(false);
                    jobotIntroStage5PlantRemovalComplete1b.gameObject.SetActive(false);
                    jobotIntroStage5PlantRemovalComplete1c.gameObject.SetActive(false);
                    //      jobotIntroStage5PlantRemovalComplete1d.gameObject.SetActive(false);

                    TTSStage5PlantRemovalComplete1.gameObject.SetActive(false);
                    TTSStage5PlantRemovalComplete1a.gameObject.SetActive(false);
                    TTSStage5PlantRemovalComplete1b.gameObject.SetActive(false);
                    TTSStage5PlantRemovalComplete1c.gameObject.SetActive(false);
                    //      TTSStage5PlantRemovalComplete1d.gameObject.SetActive(false);


                    TTSAllTaskCompleteStage5.gameObject.SetActive(false);
                    stage5AllTasksComplete.gameObject.SetActive(false);


                    TTSStage5EndOFGame1.gameObject.SetActive(false);
                    TTSStage5EndOFGame2.gameObject.SetActive(false);
                    TTSStage5EndOFGame3.gameObject.SetActive(false);
                    TTSStage5EndOFGame4.gameObject.SetActive(false);
                    TTSStage5EndOFGame5.gameObject.SetActive(false);
                    TTSStage5EndOFGame6.gameObject.SetActive(false);
                    TTSStage5EndOFGame7.gameObject.SetActive(false);

                    jobotEndOFGame1.gameObject.SetActive(false);
                    jobotEndOFGame1a.gameObject.SetActive(false);
                    jobotEndOFGame1b.gameObject.SetActive(false);
                    jobotEndOFGame1c.gameObject.SetActive(false);
                    jobotEndOFGame1d.gameObject.SetActive(false);
                    jobotEndOFGame1e.gameObject.SetActive(false);
                    jobotEndOFGame1f.gameObject.SetActive(false);
                    if (!progressTextIsShowing)
                    { // 3 second delay
                        StartCoroutine(DelayProgressButtonVar2());
                        progressTextIsShowing = true;
                    }
                }
                /*
                if (currentStageOfText == 7)
                {
                    if (!textBeenRead)
                    {
                        progressText.gameObject.SetActive(false);
                    }
                    jobotIntroStage5Section1.enabled = false;
                //    jobotIntroStage5Section1a.enabled = false;
                    jobotIntroStage5Section1b.enabled = false;
               //     jobotIntroStage5Section1c.enabled = false;
              //      jobotIntroStage5Section1d.enabled = false;
                    jobotIntroStage5Section1e.enabled = false;
              //      jobotIntroStage5Section1f.enabled = true;
                    jobotIntroStage5Section1g.enabled = false;
                    jobotIntroStage5Section1h.enabled = false;
              //      jobotIntroStage5Section1i.enabled = false;
                    jobotIntroStage5Section1j.enabled = false;
              //      jobotIntroStage5Section1k.enabled = false;
              //      jobotIntroStage5Section1l.enabled = false;
               //     jobotIntroStage5Section1m.enabled = false;
                    jobotIntroStage5Section1n.enabled = false;



                    TTSStage5Jobot1.gameObject.SetActive(false);
                  //  TTSStage5Jobot2.gameObject.SetActive(false);
                    TTSStage5Jobot3.gameObject.SetActive(false);
                 //   TTSStage5Jobot4.gameObject.SetActive(false);
                 //   TTSStage5Jobot5.gameObject.SetActive(false);
                    TTSStage5Jobot6.gameObject.SetActive(false);
                 //   TTSStage5Jobot7.gameObject.SetActive(true);
                    TTSStage5Jobot8.gameObject.SetActive(false);
                    TTSStage5Jobot9.gameObject.SetActive(false);
                 //   TTSStage5Jobot10.gameObject.SetActive(false);
                    TTSStage5Jobot11.gameObject.SetActive(false);
                //    TTSStage5Jobot12.gameObject.SetActive(false);
               //     TTSStage5Jobot13.gameObject.SetActive(false);
               //     TTSStage5Jobot14.gameObject.SetActive(false);
                    TTSStage5Jobot15.gameObject.SetActive(false);

                    // This is the text for the removal of the flowers on stage 5
                    jobotIntroStage5PlantRemovalComplete1.gameObject.SetActive(false);
                    jobotIntroStage5PlantRemovalComplete1a.gameObject.SetActive(false);
                    jobotIntroStage5PlantRemovalComplete1b.gameObject.SetActive(false);
                    jobotIntroStage5PlantRemovalComplete1c.gameObject.SetActive(false);
                //    jobotIntroStage5PlantRemovalComplete1d.gameObject.SetActive(false);

                    TTSStage5PlantRemovalComplete1.gameObject.SetActive(false);
                    TTSStage5PlantRemovalComplete1a.gameObject.SetActive(false);
                    TTSStage5PlantRemovalComplete1b.gameObject.SetActive(false);
                    TTSStage5PlantRemovalComplete1c.gameObject.SetActive(false);
                //    TTSStage5PlantRemovalComplete1d.gameObject.SetActive(false);

                    TTSAllTaskCompleteStage5.gameObject.SetActive(false);
                    stage5AllTasksComplete.gameObject.SetActive(false);


                    TTSStage5EndOFGame1.gameObject.SetActive(false);
                    TTSStage5EndOFGame2.gameObject.SetActive(false);
                    TTSStage5EndOFGame3.gameObject.SetActive(false);
                    TTSStage5EndOFGame4.gameObject.SetActive(false);
                    TTSStage5EndOFGame5.gameObject.SetActive(false);
                    TTSStage5EndOFGame6.gameObject.SetActive(false);
                    TTSStage5EndOFGame7.gameObject.SetActive(false);

                    jobotEndOFGame1.gameObject.SetActive(false);
                    jobotEndOFGame1a.gameObject.SetActive(false);
                    jobotEndOFGame1b.gameObject.SetActive(false);
                    jobotEndOFGame1c.gameObject.SetActive(false);
                    jobotEndOFGame1d.gameObject.SetActive(false);
                    jobotEndOFGame1e.gameObject.SetActive(false);
                    jobotEndOFGame1f.gameObject.SetActive(false);
                    if (!progressTextIsShowing)
                    { // 3 second delay
                        StartCoroutine(DelayProgressButtonVar2());
                        progressTextIsShowing = true;
                    }
                }
                */
                if (currentStageOfText == 4)
                {
                    if (!textBeenRead)
                    {
                        progressText.gameObject.SetActive(false);
                    }
                    jobotIntroStage5Section1.enabled = false;
                    //    jobotIntroStage5Section1a.enabled = false;
                    jobotIntroStage5Section1b.enabled = false;
                    //    jobotIntroStage5Section1c.enabled = false;
                    //     jobotIntroStage5Section1d.enabled = false;
                    jobotIntroStage5Section1e.enabled = false;
                    //     jobotIntroStage5Section1f.enabled = false;
                    jobotIntroStage5Section1g.enabled = true;
                    jobotIntroStage5Section1h.enabled = false;
                    //      jobotIntroStage5Section1i.enabled = false;
                    jobotIntroStage5Section1j.enabled = false;
                    //      jobotIntroStage5Section1k.enabled = false;
                    //      jobotIntroStage5Section1l.enabled = false;
                    //      jobotIntroStage5Section1m.enabled = false;
                    jobotIntroStage5Section1n.enabled = false;



                    TTSStage5Jobot1.gameObject.SetActive(false);
                    //      TTSStage5Jobot2.gameObject.SetActive(false);
                    TTSStage5Jobot3.gameObject.SetActive(false);
                    //      TTSStage5Jobot4.gameObject.SetActive(false);
                    //       TTSStage5Jobot5.gameObject.SetActive(false);
                    TTSStage5Jobot6.gameObject.SetActive(false);
                    //       TTSStage5Jobot7.gameObject.SetActive(false);
                    TTSStage5Jobot8.gameObject.SetActive(true);
                    TTSStage5Jobot9.gameObject.SetActive(false);
                    //       TTSStage5Jobot10.gameObject.SetActive(false);
                    TTSStage5Jobot11.gameObject.SetActive(false);
                    //       TTSStage5Jobot12.gameObject.SetActive(false);
                    //        TTSStage5Jobot13.gameObject.SetActive(false);
                    //        TTSStage5Jobot14.gameObject.SetActive(false);
                    TTSStage5Jobot15.gameObject.SetActive(false);


                    // This is the text for the removal of the flowers on stage 5
                    jobotIntroStage5PlantRemovalComplete1.gameObject.SetActive(false);
                    jobotIntroStage5PlantRemovalComplete1a.gameObject.SetActive(false);
                    jobotIntroStage5PlantRemovalComplete1b.gameObject.SetActive(false);
                    jobotIntroStage5PlantRemovalComplete1c.gameObject.SetActive(false);
                    //      jobotIntroStage5PlantRemovalComplete1d.gameObject.SetActive(false);

                    TTSStage5PlantRemovalComplete1.gameObject.SetActive(false);
                    TTSStage5PlantRemovalComplete1a.gameObject.SetActive(false);
                    TTSStage5PlantRemovalComplete1b.gameObject.SetActive(false);
                    TTSStage5PlantRemovalComplete1c.gameObject.SetActive(false);
                    //      TTSStage5PlantRemovalComplete1d.gameObject.SetActive(false);

                    TTSAllTaskCompleteStage5.gameObject.SetActive(false);
                    stage5AllTasksComplete.gameObject.SetActive(false);


                    TTSStage5EndOFGame1.gameObject.SetActive(false);
                    TTSStage5EndOFGame2.gameObject.SetActive(false);
                    TTSStage5EndOFGame3.gameObject.SetActive(false);
                    TTSStage5EndOFGame4.gameObject.SetActive(false);
                    TTSStage5EndOFGame5.gameObject.SetActive(false);
                    TTSStage5EndOFGame6.gameObject.SetActive(false);
                    TTSStage5EndOFGame7.gameObject.SetActive(false);

                    jobotEndOFGame1.gameObject.SetActive(false);
                    jobotEndOFGame1a.gameObject.SetActive(false);
                    jobotEndOFGame1b.gameObject.SetActive(false);
                    jobotEndOFGame1c.gameObject.SetActive(false);
                    jobotEndOFGame1d.gameObject.SetActive(false);
                    jobotEndOFGame1e.gameObject.SetActive(false);
                    jobotEndOFGame1f.gameObject.SetActive(false);
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
                    jobotIntroStage5Section1.enabled = false;
                    //      jobotIntroStage5Section1a.enabled = false;
                    jobotIntroStage5Section1b.enabled = false;
                    //        jobotIntroStage5Section1c.enabled = false;
                    //       jobotIntroStage5Section1d.enabled = false;
                    jobotIntroStage5Section1e.enabled = false;
                    //         jobotIntroStage5Section1f.enabled = false;
                    jobotIntroStage5Section1g.enabled = false;
                    jobotIntroStage5Section1h.enabled = true;
                    //          jobotIntroStage5Section1i.enabled = false;
                    jobotIntroStage5Section1j.enabled = false;
                    //         jobotIntroStage5Section1k.enabled = false;
                    //          jobotIntroStage5Section1l.enabled = false;
                    //          jobotIntroStage5Section1m.enabled = false;
                    jobotIntroStage5Section1n.enabled = false;



                    TTSStage5Jobot1.gameObject.SetActive(false);
                    //         TTSStage5Jobot2.gameObject.SetActive(false);
                    TTSStage5Jobot3.gameObject.SetActive(false);
                    //          TTSStage5Jobot4.gameObject.SetActive(false);
                    //          TTSStage5Jobot5.gameObject.SetActive(false);
                    TTSStage5Jobot6.gameObject.SetActive(false);
                    //           TTSStage5Jobot7.gameObject.SetActive(false);
                    TTSStage5Jobot8.gameObject.SetActive(false);
                    TTSStage5Jobot9.gameObject.SetActive(true);
                    //            TTSStage5Jobot10.gameObject.SetActive(false);
                    TTSStage5Jobot11.gameObject.SetActive(false);
                    //            TTSStage5Jobot12.gameObject.SetActive(false);
                    //             TTSStage5Jobot13.gameObject.SetActive(false);
                    //             TTSStage5Jobot14.gameObject.SetActive(false);
                    TTSStage5Jobot15.gameObject.SetActive(false);


                    // This is the text for the removal of the flowers on stage 5
                    jobotIntroStage5PlantRemovalComplete1.gameObject.SetActive(false);
                    jobotIntroStage5PlantRemovalComplete1a.gameObject.SetActive(false);
                    jobotIntroStage5PlantRemovalComplete1b.gameObject.SetActive(false);
                    jobotIntroStage5PlantRemovalComplete1c.gameObject.SetActive(false);
                    //         jobotIntroStage5PlantRemovalComplete1d.gameObject.SetActive(false);

                    TTSStage5PlantRemovalComplete1.gameObject.SetActive(false);
                    TTSStage5PlantRemovalComplete1a.gameObject.SetActive(false);
                    TTSStage5PlantRemovalComplete1b.gameObject.SetActive(false);
                    TTSStage5PlantRemovalComplete1c.gameObject.SetActive(false);
                    //         TTSStage5PlantRemovalComplete1d.gameObject.SetActive(false);

                    TTSAllTaskCompleteStage5.gameObject.SetActive(false);
                    stage5AllTasksComplete.gameObject.SetActive(false);


                    TTSStage5EndOFGame1.gameObject.SetActive(false);
                    TTSStage5EndOFGame2.gameObject.SetActive(false);
                    TTSStage5EndOFGame3.gameObject.SetActive(false);
                    TTSStage5EndOFGame4.gameObject.SetActive(false);
                    TTSStage5EndOFGame5.gameObject.SetActive(false);
                    TTSStage5EndOFGame6.gameObject.SetActive(false);
                    TTSStage5EndOFGame7.gameObject.SetActive(false);

                    jobotEndOFGame1.gameObject.SetActive(false);
                    jobotEndOFGame1a.gameObject.SetActive(false);
                    jobotEndOFGame1b.gameObject.SetActive(false);
                    jobotEndOFGame1c.gameObject.SetActive(false);
                    jobotEndOFGame1d.gameObject.SetActive(false);
                    jobotEndOFGame1e.gameObject.SetActive(false);
                    jobotEndOFGame1f.gameObject.SetActive(false);

                    if (!progressTextIsShowing)
                    { // 3 second delay
                        StartCoroutine(DelayProgressButtonVar2());
                        progressTextIsShowing = true;
                    }

                }
                /*
                if (currentStageOfText == 10)
                {
                    if (!textBeenRead)
                    {
                        progressText.gameObject.SetActive(false);
                    }
                    jobotIntroStage5Section1.enabled = false;
               //     jobotIntroStage5Section1a.enabled = false;
                    jobotIntroStage5Section1b.enabled = false;
              //      jobotIntroStage5Section1c.enabled = false;
             //       jobotIntroStage5Section1d.enabled = false;
                    jobotIntroStage5Section1e.enabled = false;
             //       jobotIntroStage5Section1f.enabled = false;
                    jobotIntroStage5Section1g.enabled = false;
                    jobotIntroStage5Section1h.enabled = false;
            //        jobotIntroStage5Section1i.enabled = true;
                    jobotIntroStage5Section1j.enabled = false;
           //         jobotIntroStage5Section1k.enabled = false;
          //          jobotIntroStage5Section1l.enabled = false;
          //          jobotIntroStage5Section1m.enabled = false;
                    jobotIntroStage5Section1n.enabled = false;



                    TTSStage5Jobot1.gameObject.SetActive(false);
           //         TTSStage5Jobot2.gameObject.SetActive(false);
                    TTSStage5Jobot3.gameObject.SetActive(false);
           //         TTSStage5Jobot4.gameObject.SetActive(false);
           //         TTSStage5Jobot5.gameObject.SetActive(false);
                    TTSStage5Jobot6.gameObject.SetActive(false);
          //          TTSStage5Jobot7.gameObject.SetActive(false);
                    TTSStage5Jobot8.gameObject.SetActive(false);
                    TTSStage5Jobot9.gameObject.SetActive(false);
         //           TTSStage5Jobot10.gameObject.SetActive(true);
                    TTSStage5Jobot11.gameObject.SetActive(false);
        //            TTSStage5Jobot12.gameObject.SetActive(false);
        //            TTSStage5Jobot13.gameObject.SetActive(false);
        //            TTSStage5Jobot14.gameObject.SetActive(false);
                    TTSStage5Jobot15.gameObject.SetActive(false);

                    // This is the text for the removal of the flowers on stage 5
                    jobotIntroStage5PlantRemovalComplete1.gameObject.SetActive(false);
                    jobotIntroStage5PlantRemovalComplete1a.gameObject.SetActive(false);
                    jobotIntroStage5PlantRemovalComplete1b.gameObject.SetActive(false);
                    jobotIntroStage5PlantRemovalComplete1c.gameObject.SetActive(false);
         //           jobotIntroStage5PlantRemovalComplete1d.gameObject.SetActive(false);

                    TTSStage5PlantRemovalComplete1.gameObject.SetActive(false);
                    TTSStage5PlantRemovalComplete1a.gameObject.SetActive(false);
                    TTSStage5PlantRemovalComplete1b.gameObject.SetActive(false);
                    TTSStage5PlantRemovalComplete1c.gameObject.SetActive(false);
         //           TTSStage5PlantRemovalComplete1d.gameObject.SetActive(false);

                    TTSAllTaskCompleteStage5.gameObject.SetActive(false);
                    stage5AllTasksComplete.gameObject.SetActive(false);


                    TTSStage5EndOFGame1.gameObject.SetActive(false);
                    TTSStage5EndOFGame2.gameObject.SetActive(false);
                    TTSStage5EndOFGame3.gameObject.SetActive(false);
                    TTSStage5EndOFGame4.gameObject.SetActive(false);
                    TTSStage5EndOFGame5.gameObject.SetActive(false);
                    TTSStage5EndOFGame6.gameObject.SetActive(false);
                    TTSStage5EndOFGame7.gameObject.SetActive(false);

                    jobotEndOFGame1.gameObject.SetActive(false);
                    jobotEndOFGame1a.gameObject.SetActive(false);
                    jobotEndOFGame1b.gameObject.SetActive(false);
                    jobotEndOFGame1c.gameObject.SetActive(false);
                    jobotEndOFGame1d.gameObject.SetActive(false);
                    jobotEndOFGame1e.gameObject.SetActive(false);
                    jobotEndOFGame1f.gameObject.SetActive(false);
                    if (!progressTextIsShowing)
                    { // 3 second delay
                        StartCoroutine(DelayProgressButtonVar2());
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
                    jobotIntroStage5Section1.enabled = false;
                    //           jobotIntroStage5Section1a.enabled = false;
                    jobotIntroStage5Section1b.enabled = false;
                    //            jobotIntroStage5Section1c.enabled = false;
                    //              jobotIntroStage5Section1d.enabled = false;
                    jobotIntroStage5Section1e.enabled = false;
                    //               jobotIntroStage5Section1f.enabled = false;
                    jobotIntroStage5Section1g.enabled = false;
                    jobotIntroStage5Section1h.enabled = false;
                    //               jobotIntroStage5Section1i.enabled = false;
                    jobotIntroStage5Section1j.enabled = true;
                    //                jobotIntroStage5Section1k.enabled = false;
                    //          jobotIntroStage5Section1l.enabled = false;
                    //                jobotIntroStage5Section1m.enabled = false;
                    jobotIntroStage5Section1n.enabled = false;



                    TTSStage5Jobot1.gameObject.SetActive(false);
                    //        TTSStage5Jobot2.gameObject.SetActive(false);
                    TTSStage5Jobot3.gameObject.SetActive(false);
                    //       TTSStage5Jobot4.gameObject.SetActive(false);
                    //      TTSStage5Jobot5.gameObject.SetActive(false);
                    TTSStage5Jobot6.gameObject.SetActive(false);
                    //      TTSStage5Jobot7.gameObject.SetActive(false);
                    TTSStage5Jobot8.gameObject.SetActive(false);
                    TTSStage5Jobot9.gameObject.SetActive(false);
                    //      TTSStage5Jobot10.gameObject.SetActive(false);
                    TTSStage5Jobot11.gameObject.SetActive(true);
                    //     TTSStage5Jobot12.gameObject.SetActive(false);
                    //     TTSStage5Jobot13.gameObject.SetActive(false);
                    //     TTSStage5Jobot14.gameObject.SetActive(false);
                    TTSStage5Jobot15.gameObject.SetActive(false);



                    // This is the text for the removal of the flowers on stage 5
                    jobotIntroStage5PlantRemovalComplete1.gameObject.SetActive(false);
                    jobotIntroStage5PlantRemovalComplete1a.gameObject.SetActive(false);
                    jobotIntroStage5PlantRemovalComplete1b.gameObject.SetActive(false);
                    jobotIntroStage5PlantRemovalComplete1c.gameObject.SetActive(false);
                    //   jobotIntroStage5PlantRemovalComplete1d.gameObject.SetActive(false);

                    TTSStage5PlantRemovalComplete1.gameObject.SetActive(false);
                    TTSStage5PlantRemovalComplete1a.gameObject.SetActive(false);
                    TTSStage5PlantRemovalComplete1b.gameObject.SetActive(false);
                    TTSStage5PlantRemovalComplete1c.gameObject.SetActive(false);
                    //    TTSStage5PlantRemovalComplete1d.gameObject.SetActive(false);

                    TTSAllTaskCompleteStage5.gameObject.SetActive(false);
                    stage5AllTasksComplete.gameObject.SetActive(false);



                    TTSStage5EndOFGame1.gameObject.SetActive(false);
                    TTSStage5EndOFGame2.gameObject.SetActive(false);
                    TTSStage5EndOFGame3.gameObject.SetActive(false);
                    TTSStage5EndOFGame4.gameObject.SetActive(false);
                    TTSStage5EndOFGame5.gameObject.SetActive(false);
                    TTSStage5EndOFGame6.gameObject.SetActive(false);
                    TTSStage5EndOFGame7.gameObject.SetActive(false);

                    jobotEndOFGame1.gameObject.SetActive(false);
                    jobotEndOFGame1a.gameObject.SetActive(false);
                    jobotEndOFGame1b.gameObject.SetActive(false);
                    jobotEndOFGame1c.gameObject.SetActive(false);
                    jobotEndOFGame1d.gameObject.SetActive(false);
                    jobotEndOFGame1e.gameObject.SetActive(false);
                    jobotEndOFGame1f.gameObject.SetActive(false);
                    if (!progressTextIsShowing)
                    { // 3 second delay
                        StartCoroutine(DelayProgressButtonVar2());
                        progressTextIsShowing = true;
                    }
                }



                if (currentStageOfText == 7)
                {

                    jobotIntroStage5Section1.enabled = false;
                    //   jobotIntroStage5Section1a.enabled = false;
                    jobotIntroStage5Section1b.enabled = false;
                    //    jobotIntroStage5Section1c.enabled = false;
                    //    jobotIntroStage5Section1d.enabled = false;
                    jobotIntroStage5Section1e.enabled = false;
                    //    jobotIntroStage5Section1f.enabled = false;
                    jobotIntroStage5Section1g.enabled = false;
                    jobotIntroStage5Section1h.enabled = false;
                    //     jobotIntroStage5Section1i.enabled = false;
                    jobotIntroStage5Section1j.enabled = false;
                    //     jobotIntroStage5Section1k.enabled = false;
                    //    jobotIntroStage5Section1l.enabled = false;
                    //     jobotIntroStage5Section1m.enabled = false;
                    jobotIntroStage5Section1n.enabled = true;



                    TTSStage5Jobot1.gameObject.SetActive(false);
                    //   TTSStage5Jobot2.gameObject.SetActive(false);
                    TTSStage5Jobot3.gameObject.SetActive(false);
                    //      TTSStage5Jobot4.gameObject.SetActive(false);
                    //      TTSStage5Jobot5.gameObject.SetActive(false);
                    TTSStage5Jobot6.gameObject.SetActive(false);
                    //       TTSStage5Jobot7.gameObject.SetActive(false);
                    TTSStage5Jobot8.gameObject.SetActive(false);
                    TTSStage5Jobot9.gameObject.SetActive(false);
                    //      TTSStage5Jobot10.gameObject.SetActive(false);
                    TTSStage5Jobot11.gameObject.SetActive(false);
                    //        TTSStage5Jobot12.gameObject.SetActive(false);
                    //        TTSStage5Jobot13.gameObject.SetActive(false);
                    //       TTSStage5Jobot14.gameObject.SetActive(false);
                    TTSStage5Jobot15.gameObject.SetActive(true);
                    // mainCamerToDisable.enabled = false;

                    forwardButtonToDisable.gameObject.SetActive(false);
                    robotCamToEnable.enabled = true;
                    robotControl.enabled = true;
                    robotPlayer.SetActive(true);
                    introRobotStage5.SetActive(false);
                    closeDoor.SetBool("doorNeedsToBeOpen", false);
                    closeDoor.SetBool("closeDoor", false);
                    closeDoor.SetTrigger("resetDoorValues");
                    StartCoroutine(CloseTextPanal());
                    help.enabled = true;
                    tasks.enabled = true;
                    if (!introReadyToBeCompleted)
                    {
                        rgMainData.stage5IntroComplete = true;
                        rgMainData.SaveIntroCompleteStage5();
                        introReadyToBeCompleted = true;
                        Debug.Log("Intro Complete");

                        //  mainCamerToDisable.enabled = false;

                    }
                    mainCamerToDisable.gameObject.SetActive(false);

                    // This is the text for the removal of the flowers on stage 5
                    jobotIntroStage5PlantRemovalComplete1.gameObject.SetActive(false);
                    jobotIntroStage5PlantRemovalComplete1a.gameObject.SetActive(false);
                    jobotIntroStage5PlantRemovalComplete1b.gameObject.SetActive(false);
                    jobotIntroStage5PlantRemovalComplete1c.gameObject.SetActive(false);
                    //  jobotIntroStage5PlantRemovalComplete1d.gameObject.SetActive(false);

                    TTSStage5PlantRemovalComplete1.gameObject.SetActive(false);
                    TTSStage5PlantRemovalComplete1a.gameObject.SetActive(false);
                    TTSStage5PlantRemovalComplete1b.gameObject.SetActive(false);
                    TTSStage5PlantRemovalComplete1c.gameObject.SetActive(false);
                    //  TTSStage5PlantRemovalComplete1d.gameObject.SetActive(false);

                    TTSAllTaskCompleteStage5.gameObject.SetActive(false);
                    stage5AllTasksComplete.gameObject.SetActive(false);

                    TTSStage5EndOFGame1.gameObject.SetActive(false);
                    TTSStage5EndOFGame2.gameObject.SetActive(false);
                    TTSStage5EndOFGame3.gameObject.SetActive(false);
                    TTSStage5EndOFGame4.gameObject.SetActive(false);
                    TTSStage5EndOFGame5.gameObject.SetActive(false);
                    TTSStage5EndOFGame6.gameObject.SetActive(false);
                    TTSStage5EndOFGame7.gameObject.SetActive(false);

                    jobotEndOFGame1.gameObject.SetActive(false);
                    jobotEndOFGame1a.gameObject.SetActive(false);
                    jobotEndOFGame1b.gameObject.SetActive(false);
                    jobotEndOFGame1c.gameObject.SetActive(false);
                    jobotEndOFGame1d.gameObject.SetActive(false);
                    jobotEndOFGame1e.gameObject.SetActive(false);
                    jobotEndOFGame1f.gameObject.SetActive(false);
                }

                if (currentStageOfText == 16)
                {
                    textPanalToHide.SetActive(false);
                    jobotIntroStage5Section1.enabled = false;
                    //  jobotIntroStage5Section1a.enabled = false;
                    jobotIntroStage5Section1b.enabled = false;
                    //   jobotIntroStage5Section1c.enabled = false;
                    //   jobotIntroStage5Section1d.enabled = false;
                    jobotIntroStage5Section1e.enabled = false;
                    //   jobotIntroStage5Section1f.enabled = false;
                    jobotIntroStage5Section1g.enabled = false;
                    jobotIntroStage5Section1h.enabled = false;
                    //    jobotIntroStage5Section1i.enabled = false;
                    jobotIntroStage5Section1j.enabled = false;
                    //   jobotIntroStage5Section1k.enabled = false;
                    //   jobotIntroStage5Section1l.enabled = false;
                    ///   jobotIntroStage5Section1m.enabled = false;
                    jobotIntroStage5Section1n.enabled = false;



                    TTSStage5Jobot1.gameObject.SetActive(false);
                    //    TTSStage5Jobot2.gameObject.SetActive(false);
                    TTSStage5Jobot3.gameObject.SetActive(false);
                    //    TTSStage5Jobot4.gameObject.SetActive(false);
                    //     TTSStage5Jobot5.gameObject.SetActive(false);
                    TTSStage5Jobot6.gameObject.SetActive(false);
                    //    TTSStage5Jobot7.gameObject.SetActive(false);
                    TTSStage5Jobot8.gameObject.SetActive(false);
                    TTSStage5Jobot9.gameObject.SetActive(false);
                    //     TTSStage5Jobot10.gameObject.SetActive(false);
                    TTSStage5Jobot11.gameObject.SetActive(false);
                    //      TTSStage5Jobot12.gameObject.SetActive(false);
                    //     TTSStage5Jobot13.gameObject.SetActive(false);
                    //     TTSStage5Jobot14.gameObject.SetActive(false);
                    TTSStage5Jobot15.gameObject.SetActive(false);


                    // This is the text for the removal of the flowers on stage 5
                    jobotIntroStage5PlantRemovalComplete1.gameObject.SetActive(false);
                    jobotIntroStage5PlantRemovalComplete1a.gameObject.SetActive(false);
                    jobotIntroStage5PlantRemovalComplete1b.gameObject.SetActive(false);
                    jobotIntroStage5PlantRemovalComplete1c.gameObject.SetActive(false);
                    //    jobotIntroStage5PlantRemovalComplete1d.gameObject.SetActive(false);

                    TTSStage5PlantRemovalComplete1.gameObject.SetActive(false);
                    TTSStage5PlantRemovalComplete1a.gameObject.SetActive(false);
                    TTSStage5PlantRemovalComplete1b.gameObject.SetActive(false);
                    TTSStage5PlantRemovalComplete1c.gameObject.SetActive(false);
                    //     TTSStage5PlantRemovalComplete1d.gameObject.SetActive(false);

                    TTSAllTaskCompleteStage5.gameObject.SetActive(false);
                    stage5AllTasksComplete.gameObject.SetActive(false);

                    TTSStage5EndOFGame1.gameObject.SetActive(false);
                    TTSStage5EndOFGame2.gameObject.SetActive(false);
                    TTSStage5EndOFGame3.gameObject.SetActive(false);
                    TTSStage5EndOFGame4.gameObject.SetActive(false);
                    TTSStage5EndOFGame5.gameObject.SetActive(false);
                    TTSStage5EndOFGame6.gameObject.SetActive(false);
                    TTSStage5EndOFGame7.gameObject.SetActive(false);

                    jobotEndOFGame1.gameObject.SetActive(false);
                    jobotEndOFGame1a.gameObject.SetActive(false);
                    jobotEndOFGame1b.gameObject.SetActive(false);
                    jobotEndOFGame1c.gameObject.SetActive(false);
                    jobotEndOFGame1d.gameObject.SetActive(false);
                    jobotEndOFGame1e.gameObject.SetActive(false);
                    jobotEndOFGame1f.gameObject.SetActive(false);
                }

                if (currentStageOfText == 19)
                {
                    if (!textBeenRead)
                    {
                        progressText.gameObject.SetActive(false);
                    }
                    if (!runOnce)
                    {
                        taskPanal.SetActive(true);
                        jobotIntroStage5Section1.enabled = false;
                        jobotIntroStage5Section1b.enabled = false;
                        jobotIntroStage5Section1e.enabled = false;
                        jobotIntroStage5Section1g.enabled = false;
                        jobotIntroStage5Section1h.enabled = false;
                        jobotIntroStage5Section1j.enabled = false;
                        jobotIntroStage5Section1n.enabled = false;



                        TTSStage5Jobot1.gameObject.SetActive(false);
                        TTSStage5Jobot3.gameObject.SetActive(false);
                        TTSStage5Jobot6.gameObject.SetActive(false);
                        TTSStage5Jobot8.gameObject.SetActive(false);
                        TTSStage5Jobot9.gameObject.SetActive(false);
                        TTSStage5Jobot11.gameObject.SetActive(false);
                        TTSStage5Jobot15.gameObject.SetActive(false);


                        // This is the text for the removal of the flowers on stage 5
                        jobotIntroStage5PlantRemovalComplete1.gameObject.SetActive(true);
                        jobotIntroStage5PlantRemovalComplete1a.gameObject.SetActive(false);
                        jobotIntroStage5PlantRemovalComplete1b.gameObject.SetActive(false);
                        jobotIntroStage5PlantRemovalComplete1c.gameObject.SetActive(false);

                        TTSStage5PlantRemovalComplete1.gameObject.SetActive(true);
                        TTSStage5PlantRemovalComplete1a.gameObject.SetActive(false);
                        TTSStage5PlantRemovalComplete1b.gameObject.SetActive(false);
                        TTSStage5PlantRemovalComplete1c.gameObject.SetActive(false);

                        progressText.gameObject.SetActive(true);

                        TTSAllTaskCompleteStage5.gameObject.SetActive(false);
                        stage5AllTasksComplete.gameObject.SetActive(false);

                        TTSStage5EndOFGame1.gameObject.SetActive(false);
                        TTSStage5EndOFGame2.gameObject.SetActive(false);
                        TTSStage5EndOFGame3.gameObject.SetActive(false);
                        TTSStage5EndOFGame4.gameObject.SetActive(false);
                        TTSStage5EndOFGame5.gameObject.SetActive(false);
                        TTSStage5EndOFGame6.gameObject.SetActive(false);
                        TTSStage5EndOFGame7.gameObject.SetActive(false);

                        jobotEndOFGame1.gameObject.SetActive(false);
                        jobotEndOFGame1a.gameObject.SetActive(false);
                        jobotEndOFGame1b.gameObject.SetActive(false);
                        jobotEndOFGame1c.gameObject.SetActive(false);
                        jobotEndOFGame1d.gameObject.SetActive(false);
                        jobotEndOFGame1e.gameObject.SetActive(false);
                        jobotEndOFGame1f.gameObject.SetActive(false);
                        runOnce = true;
                    }

                    if (!progressTextIsShowing)
                    { // 3 second delay
                        StartCoroutine(DelayProgressButtonVar1());
                        progressTextIsShowing = true;
                    }
                }

                if (currentStageOfText == 20)
                {
                    if (!textBeenRead)
                    {
                        progressText.gameObject.SetActive(false);
                    }
                    jobotIntroStage5Section1.enabled = false;
                    //        jobotIntroStage5Section1a.enabled = false;
                    jobotIntroStage5Section1b.enabled = false;
                    //         jobotIntroStage5Section1c.enabled = false;
                    //         jobotIntroStage5Section1d.enabled = false;
                    jobotIntroStage5Section1e.enabled = false;
                    //         jobotIntroStage5Section1f.enabled = false;
                    jobotIntroStage5Section1g.enabled = false;
                    jobotIntroStage5Section1h.enabled = false;
                    //         jobotIntroStage5Section1i.enabled = false;
                    jobotIntroStage5Section1j.enabled = false;
                    //         jobotIntroStage5Section1k.enabled = false;
                    //         jobotIntroStage5Section1l.enabled = false;
                    //         jobotIntroStage5Section1m.enabled = false;
                    jobotIntroStage5Section1n.enabled = false;



                    TTSStage5Jobot1.gameObject.SetActive(false);
                    //          TTSStage5Jobot2.gameObject.SetActive(false);
                    TTSStage5Jobot3.gameObject.SetActive(false);
                    //          TTSStage5Jobot4.gameObject.SetActive(false);
                    //           TTSStage5Jobot5.gameObject.SetActive(false);
                    TTSStage5Jobot6.gameObject.SetActive(false);
                    //          TTSStage5Jobot7.gameObject.SetActive(false);
                    TTSStage5Jobot8.gameObject.SetActive(false);
                    TTSStage5Jobot9.gameObject.SetActive(false);
                    //         TTSStage5Jobot10.gameObject.SetActive(false);
                    TTSStage5Jobot11.gameObject.SetActive(false);
                    //           TTSStage5Jobot12.gameObject.SetActive(false);
                    //           TTSStage5Jobot13.gameObject.SetActive(false);
                    //           TTSStage5Jobot14.gameObject.SetActive(false);
                    TTSStage5Jobot15.gameObject.SetActive(false);


                    // This is the text for the removal of the flowers on stage 5
                    jobotIntroStage5PlantRemovalComplete1.gameObject.SetActive(false);
                    jobotIntroStage5PlantRemovalComplete1a.gameObject.SetActive(true);
                    jobotIntroStage5PlantRemovalComplete1b.gameObject.SetActive(false);
                    jobotIntroStage5PlantRemovalComplete1c.gameObject.SetActive(false);
                    //         jobotIntroStage5PlantRemovalComplete1d.gameObject.SetActive(false);

                    TTSStage5PlantRemovalComplete1.gameObject.SetActive(false);
                    TTSStage5PlantRemovalComplete1a.gameObject.SetActive(true);
                    TTSStage5PlantRemovalComplete1b.gameObject.SetActive(false);
                    TTSStage5PlantRemovalComplete1c.gameObject.SetActive(false);
                    //         TTSStage5PlantRemovalComplete1d.gameObject.SetActive(false);

                    TTSAllTaskCompleteStage5.gameObject.SetActive(false);
                    stage5AllTasksComplete.gameObject.SetActive(false);

                    TTSStage5EndOFGame1.gameObject.SetActive(false);
                    TTSStage5EndOFGame2.gameObject.SetActive(false);
                    TTSStage5EndOFGame3.gameObject.SetActive(false);
                    TTSStage5EndOFGame4.gameObject.SetActive(false);
                    TTSStage5EndOFGame5.gameObject.SetActive(false);
                    TTSStage5EndOFGame6.gameObject.SetActive(false);
                    TTSStage5EndOFGame7.gameObject.SetActive(false);

                    jobotEndOFGame1.gameObject.SetActive(false);
                    jobotEndOFGame1a.gameObject.SetActive(false);
                    jobotEndOFGame1b.gameObject.SetActive(false);
                    jobotEndOFGame1c.gameObject.SetActive(false);
                    jobotEndOFGame1d.gameObject.SetActive(false);
                    jobotEndOFGame1e.gameObject.SetActive(false);
                    jobotEndOFGame1f.gameObject.SetActive(false);

                    if (!progressTextIsShowing)
                    { // 3 second delay
                        StartCoroutine(DelayProgressButtonVar2());
                        progressTextIsShowing = true;
                    }
                }

                if (currentStageOfText == 21)
                {
                    if (!textBeenRead)
                    {
                        progressText.gameObject.SetActive(false);
                    }
                    jobotIntroStage5Section1.enabled = false;
                    //        jobotIntroStage5Section1a.enabled = false;
                    jobotIntroStage5Section1b.enabled = false;
                    //        jobotIntroStage5Section1c.enabled = false;
                    //        jobotIntroStage5Section1d.enabled = false;
                    jobotIntroStage5Section1e.enabled = false;
                    //        jobotIntroStage5Section1f.enabled = false;
                    jobotIntroStage5Section1g.enabled = false;
                    jobotIntroStage5Section1h.enabled = false;
                    //        jobotIntroStage5Section1i.enabled = false;
                    jobotIntroStage5Section1j.enabled = false;
                    //         jobotIntroStage5Section1k.enabled = false;
                    //         jobotIntroStage5Section1l.enabled = false;
                    //          jobotIntroStage5Section1m.enabled = false;
                    jobotIntroStage5Section1n.enabled = false;



                    TTSStage5Jobot1.gameObject.SetActive(false);
                    //         TTSStage5Jobot2.gameObject.SetActive(false);
                    TTSStage5Jobot3.gameObject.SetActive(false);
                    //         TTSStage5Jobot4.gameObject.SetActive(false);
                    //         TTSStage5Jobot5.gameObject.SetActive(false);
                    TTSStage5Jobot6.gameObject.SetActive(false);
                    //          TTSStage5Jobot7.gameObject.SetActive(false);
                    TTSStage5Jobot8.gameObject.SetActive(false);
                    TTSStage5Jobot9.gameObject.SetActive(false);
                    //          TTSStage5Jobot10.gameObject.SetActive(false);
                    TTSStage5Jobot11.gameObject.SetActive(false);
                    //          TTSStage5Jobot12.gameObject.SetActive(false);
                    //           TTSStage5Jobot13.gameObject.SetActive(false);
                    //          TTSStage5Jobot14.gameObject.SetActive(false);
                    TTSStage5Jobot15.gameObject.SetActive(false);


                    // This is the text for the removal of the flowers on stage 5
                    jobotIntroStage5PlantRemovalComplete1.gameObject.SetActive(false);
                    jobotIntroStage5PlantRemovalComplete1a.gameObject.SetActive(false);
                    jobotIntroStage5PlantRemovalComplete1b.gameObject.SetActive(true);
                    jobotIntroStage5PlantRemovalComplete1c.gameObject.SetActive(false);
                    //        jobotIntroStage5PlantRemovalComplete1d.gameObject.SetActive(false);

                    TTSStage5PlantRemovalComplete1.gameObject.SetActive(false);
                    TTSStage5PlantRemovalComplete1a.gameObject.SetActive(false);
                    TTSStage5PlantRemovalComplete1b.gameObject.SetActive(true);
                    TTSStage5PlantRemovalComplete1c.gameObject.SetActive(false);
                    //        TTSStage5PlantRemovalComplete1d.gameObject.SetActive(false);

                    TTSAllTaskCompleteStage5.gameObject.SetActive(false);
                    stage5AllTasksComplete.gameObject.SetActive(false);

                    TTSStage5EndOFGame1.gameObject.SetActive(false);
                    TTSStage5EndOFGame2.gameObject.SetActive(false);
                    TTSStage5EndOFGame3.gameObject.SetActive(false);
                    TTSStage5EndOFGame4.gameObject.SetActive(false);
                    TTSStage5EndOFGame5.gameObject.SetActive(false);
                    TTSStage5EndOFGame6.gameObject.SetActive(false);
                    TTSStage5EndOFGame7.gameObject.SetActive(false);

                    jobotEndOFGame1.gameObject.SetActive(false);
                    jobotEndOFGame1a.gameObject.SetActive(false);
                    jobotEndOFGame1b.gameObject.SetActive(false);
                    jobotEndOFGame1c.gameObject.SetActive(false);
                    jobotEndOFGame1d.gameObject.SetActive(false);
                    jobotEndOFGame1e.gameObject.SetActive(false);
                    jobotEndOFGame1f.gameObject.SetActive(false);

                    if (!progressTextIsShowing)
                    { // 3 second delay
                        StartCoroutine(DelayProgressButton());
                        progressTextIsShowing = true;
                    }
                }


                if (currentStageOfText == 22)
                {
                    if (!textBeenRead)
                    {
                        progressText.gameObject.SetActive(false);
                    }
                    jobotIntroStage5Section1.enabled = false;
                    //   jobotIntroStage5Section1a.enabled = false;
                    jobotIntroStage5Section1b.enabled = false;
                    //    jobotIntroStage5Section1c.enabled = false;
                    //    jobotIntroStage5Section1d.enabled = false;
                    jobotIntroStage5Section1e.enabled = false;
                    //    jobotIntroStage5Section1f.enabled = false;
                    jobotIntroStage5Section1g.enabled = false;
                    jobotIntroStage5Section1h.enabled = false;
                    //    jobotIntroStage5Section1i.enabled = false;
                    jobotIntroStage5Section1j.enabled = false;
                    //     jobotIntroStage5Section1k.enabled = false;
                    //     jobotIntroStage5Section1l.enabled = false;
                    //     jobotIntroStage5Section1m.enabled = false;
                    jobotIntroStage5Section1n.enabled = false;



                    TTSStage5Jobot1.gameObject.SetActive(false);
                    //     TTSStage5Jobot2.gameObject.SetActive(false);
                    TTSStage5Jobot3.gameObject.SetActive(false);
                    //     TTSStage5Jobot4.gameObject.SetActive(false);
                    //     TTSStage5Jobot5.gameObject.SetActive(false);
                    TTSStage5Jobot6.gameObject.SetActive(false);
                    //    TTSStage5Jobot7.gameObject.SetActive(false);
                    TTSStage5Jobot8.gameObject.SetActive(false);
                    TTSStage5Jobot9.gameObject.SetActive(false);
                    //      TTSStage5Jobot10.gameObject.SetActive(false);
                    TTSStage5Jobot11.gameObject.SetActive(false);
                    //      TTSStage5Jobot12.gameObject.SetActive(false);
                    //       TTSStage5Jobot13.gameObject.SetActive(false);
                    //       TTSStage5Jobot14.gameObject.SetActive(false);
                    TTSStage5Jobot15.gameObject.SetActive(false);


                    // This is the text for the removal of the flowers on stage 5
                    jobotIntroStage5PlantRemovalComplete1.gameObject.SetActive(false);
                    jobotIntroStage5PlantRemovalComplete1a.gameObject.SetActive(false);
                    jobotIntroStage5PlantRemovalComplete1b.gameObject.SetActive(false);
                    jobotIntroStage5PlantRemovalComplete1c.gameObject.SetActive(true);
                    //      jobotIntroStage5PlantRemovalComplete1d.gameObject.SetActive(false);

                    TTSStage5PlantRemovalComplete1.gameObject.SetActive(false);
                    TTSStage5PlantRemovalComplete1a.gameObject.SetActive(false);
                    TTSStage5PlantRemovalComplete1b.gameObject.SetActive(false);
                    TTSStage5PlantRemovalComplete1c.gameObject.SetActive(true);
                    //      TTSStage5PlantRemovalComplete1d.gameObject.SetActive(false);

                    TTSAllTaskCompleteStage5.gameObject.SetActive(false);
                    stage5AllTasksComplete.gameObject.SetActive(false);

                    TTSStage5EndOFGame1.gameObject.SetActive(false);
                    TTSStage5EndOFGame2.gameObject.SetActive(false);
                    TTSStage5EndOFGame3.gameObject.SetActive(false);
                    TTSStage5EndOFGame4.gameObject.SetActive(false);
                    TTSStage5EndOFGame5.gameObject.SetActive(false);
                    TTSStage5EndOFGame6.gameObject.SetActive(false);
                    TTSStage5EndOFGame7.gameObject.SetActive(false);

                    jobotEndOFGame1.gameObject.SetActive(false);
                    jobotEndOFGame1a.gameObject.SetActive(false);
                    jobotEndOFGame1b.gameObject.SetActive(false);
                    jobotEndOFGame1c.gameObject.SetActive(false);
                    jobotEndOFGame1d.gameObject.SetActive(false);
                    jobotEndOFGame1e.gameObject.SetActive(false);
                    jobotEndOFGame1f.gameObject.SetActive(false);
                    StartCoroutine(CloseTextPanal());


                }
                /*
                if (currentStageOfText == 23)
                {
                    if (!textBeenRead)
                    {
                        progressText.gameObject.SetActive(false);
                    }
                    jobotIntroStage5Section1.enabled = false;
                    jobotIntroStage5Section1a.enabled = false;
                    jobotIntroStage5Section1b.enabled = false;
                    jobotIntroStage5Section1c.enabled = false;
                    jobotIntroStage5Section1d.enabled = false;
                    jobotIntroStage5Section1e.enabled = false;
                    jobotIntroStage5Section1f.enabled = false;
                    jobotIntroStage5Section1g.enabled = false;
                    jobotIntroStage5Section1h.enabled = false;
                    jobotIntroStage5Section1i.enabled = false;
                    jobotIntroStage5Section1j.enabled = false;
                    jobotIntroStage5Section1k.enabled = false;
                    jobotIntroStage5Section1l.enabled = false;
                    jobotIntroStage5Section1m.enabled = false;
                    jobotIntroStage5Section1n.enabled = false;



                    TTSStage5Jobot1.gameObject.SetActive(false);
                    TTSStage5Jobot2.gameObject.SetActive(false);
                    TTSStage5Jobot3.gameObject.SetActive(false);
                    TTSStage5Jobot4.gameObject.SetActive(false);
                    TTSStage5Jobot5.gameObject.SetActive(false);
                    TTSStage5Jobot6.gameObject.SetActive(false);
                    TTSStage5Jobot7.gameObject.SetActive(false);
                    TTSStage5Jobot8.gameObject.SetActive(false);
                    TTSStage5Jobot9.gameObject.SetActive(false);
                    TTSStage5Jobot10.gameObject.SetActive(false);
                    TTSStage5Jobot11.gameObject.SetActive(false);
                    TTSStage5Jobot12.gameObject.SetActive(false);
                    TTSStage5Jobot13.gameObject.SetActive(false);
                    TTSStage5Jobot14.gameObject.SetActive(false);
                    TTSStage5Jobot15.gameObject.SetActive(false);


                    // This is the text for the removal of the flowers on stage 5
                    jobotIntroStage5PlantRemovalComplete1.gameObject.SetActive(false);
                    jobotIntroStage5PlantRemovalComplete1a.gameObject.SetActive(false);
                    jobotIntroStage5PlantRemovalComplete1b.gameObject.SetActive(false);
                    jobotIntroStage5PlantRemovalComplete1c.gameObject.SetActive(false);
                    jobotIntroStage5PlantRemovalComplete1d.gameObject.SetActive(true);

                    TTSStage5PlantRemovalComplete1.gameObject.SetActive(false);
                    TTSStage5PlantRemovalComplete1a.gameObject.SetActive(false);
                    TTSStage5PlantRemovalComplete1b.gameObject.SetActive(false);
                    TTSStage5PlantRemovalComplete1c.gameObject.SetActive(false);
                    TTSStage5PlantRemovalComplete1d.gameObject.SetActive(true);
                    StartCoroutine(CloseTextPanal());

                    TTSAllTaskCompleteStage5.gameObject.SetActive(false);
                    stage5AllTasksComplete.gameObject.SetActive(false);

                    TTSStage5EndOFGame1.gameObject.SetActive(false);
                    TTSStage5EndOFGame2.gameObject.SetActive(false);
                    TTSStage5EndOFGame3.gameObject.SetActive(false);
                    TTSStage5EndOFGame4.gameObject.SetActive(false);
                    TTSStage5EndOFGame5.gameObject.SetActive(false);
                    TTSStage5EndOFGame6.gameObject.SetActive(false);
                    TTSStage5EndOFGame7.gameObject.SetActive(false);

                    jobotEndOFGame1.gameObject.SetActive(false);
                    jobotEndOFGame1a.gameObject.SetActive(false);
                    jobotEndOFGame1b.gameObject.SetActive(false);
                    jobotEndOFGame1c.gameObject.SetActive(false);
                    jobotEndOFGame1d.gameObject.SetActive(false);
                    jobotEndOFGame1e.gameObject.SetActive(false);
                    jobotEndOFGame1f.gameObject.SetActive(false);
                    progressText.gameObject.SetActive(false);

                    if (!progressTextIsShowing)
                    { // 3 second delay
                        StartCoroutine(DelayProgressButtonVar1());
                        progressTextIsShowing = true;
                    }
                }
                */
                if (currentStageOfText == 24)
                {
                    textPanalToHide.SetActive(true);
                    jobotIntroStage5Section1.enabled = false;
                    //  jobotIntroStage5Section1a.enabled = false;
                    jobotIntroStage5Section1b.enabled = false;
                    //   jobotIntroStage5Section1c.enabled = false;
                    //   jobotIntroStage5Section1d.enabled = false;
                    jobotIntroStage5Section1e.enabled = false;
                    //   jobotIntroStage5Section1f.enabled = false;
                    jobotIntroStage5Section1g.enabled = false;
                    jobotIntroStage5Section1h.enabled = false;
                    //   jobotIntroStage5Section1i.enabled = false;
                    jobotIntroStage5Section1j.enabled = false;
                    //    jobotIntroStage5Section1k.enabled = false;
                    //    jobotIntroStage5Section1l.enabled = false;
                    //    jobotIntroStage5Section1m.enabled = false;
                    jobotIntroStage5Section1n.enabled = false;



                    TTSStage5Jobot1.gameObject.SetActive(false);
                    //    TTSStage5Jobot2.gameObject.SetActive(false);
                    TTSStage5Jobot3.gameObject.SetActive(false);
                    //     TTSStage5Jobot4.gameObject.SetActive(false);
                    //    TTSStage5Jobot5.gameObject.SetActive(false);
                    TTSStage5Jobot6.gameObject.SetActive(false);
                    //     TTSStage5Jobot7.gameObject.SetActive(false);
                    TTSStage5Jobot8.gameObject.SetActive(false);
                    TTSStage5Jobot9.gameObject.SetActive(false);
                    //      TTSStage5Jobot10.gameObject.SetActive(false);
                    TTSStage5Jobot11.gameObject.SetActive(false);
                    //      TTSStage5Jobot12.gameObject.SetActive(false);
                    //       TTSStage5Jobot13.gameObject.SetActive(false);
                    //      TTSStage5Jobot14.gameObject.SetActive(false);
                    TTSStage5Jobot15.gameObject.SetActive(false);


                    // This is the text for the removal of the flowers on stage 5
                    jobotIntroStage5PlantRemovalComplete1.gameObject.SetActive(false);
                    jobotIntroStage5PlantRemovalComplete1a.gameObject.SetActive(false);
                    jobotIntroStage5PlantRemovalComplete1b.gameObject.SetActive(false);
                    jobotIntroStage5PlantRemovalComplete1c.gameObject.SetActive(false);
                    //      jobotIntroStage5PlantRemovalComplete1d.gameObject.SetActive(false);

                    TTSStage5PlantRemovalComplete1.gameObject.SetActive(false);
                    TTSStage5PlantRemovalComplete1a.gameObject.SetActive(false);
                    TTSStage5PlantRemovalComplete1b.gameObject.SetActive(false);
                    TTSStage5PlantRemovalComplete1c.gameObject.SetActive(false);
                    //      TTSStage5PlantRemovalComplete1d.gameObject.SetActive(false);


                    TTSAllTaskCompleteStage5.gameObject.SetActive(true);
                    stage5AllTasksComplete.gameObject.SetActive(true);


                    TTSStage5EndOFGame1.gameObject.SetActive(false);
                    TTSStage5EndOFGame2.gameObject.SetActive(false);
                    TTSStage5EndOFGame3.gameObject.SetActive(false);
                    TTSStage5EndOFGame4.gameObject.SetActive(false);
                    TTSStage5EndOFGame5.gameObject.SetActive(false);
                    TTSStage5EndOFGame6.gameObject.SetActive(false);
                    TTSStage5EndOFGame7.gameObject.SetActive(false);

                    jobotEndOFGame1.gameObject.SetActive(false);
                    jobotEndOFGame1a.gameObject.SetActive(false);
                    jobotEndOFGame1b.gameObject.SetActive(false);
                    jobotEndOFGame1c.gameObject.SetActive(false);
                    jobotEndOFGame1d.gameObject.SetActive(false);
                    jobotEndOFGame1e.gameObject.SetActive(false);
                    jobotEndOFGame1f.gameObject.SetActive(false);

                    // StartCoroutine(CloseTextPanal());
                    progressText.gameObject.SetActive(false);
                }


                if (currentStageOfText == 25)
                {
                    if (!textBeenRead)
                    {
                        progressText.gameObject.SetActive(false);
                    }
                    textPanalToHide.gameObject.SetActive(true);
                    textPanalToHide.SetActive(true);
                    jobotIntroStage5Section1.enabled = false;
                    //     jobotIntroStage5Section1a.enabled = false;
                    jobotIntroStage5Section1b.enabled = false;
                    //     jobotIntroStage5Section1c.enabled = false;
                    //      jobotIntroStage5Section1d.enabled = false;
                    jobotIntroStage5Section1e.enabled = false;
                    //      jobotIntroStage5Section1f.enabled = false;
                    jobotIntroStage5Section1g.enabled = false;
                    jobotIntroStage5Section1h.enabled = false;
                    //      jobotIntroStage5Section1i.enabled = false;
                    jobotIntroStage5Section1j.enabled = false;
                    //       jobotIntroStage5Section1k.enabled = false;
                    //       jobotIntroStage5Section1l.enabled = false;
                    //        jobotIntroStage5Section1m.enabled = false;
                    jobotIntroStage5Section1n.enabled = false;



                    TTSStage5Jobot1.gameObject.SetActive(false);
                    //        TTSStage5Jobot2.gameObject.SetActive(false);
                    TTSStage5Jobot3.gameObject.SetActive(false);
                    //        TTSStage5Jobot4.gameObject.SetActive(false);
                    //         TTSStage5Jobot5.gameObject.SetActive(false);
                    TTSStage5Jobot6.gameObject.SetActive(false);
                    //         TTSStage5Jobot7.gameObject.SetActive(false);
                    TTSStage5Jobot8.gameObject.SetActive(false);
                    TTSStage5Jobot9.gameObject.SetActive(false);
                    //           TTSStage5Jobot10.gameObject.SetActive(false);
                    TTSStage5Jobot11.gameObject.SetActive(false);
                    //            TTSStage5Jobot12.gameObject.SetActive(false);
                    //           TTSStage5Jobot13.gameObject.SetActive(false);
                    //            TTSStage5Jobot14.gameObject.SetActive(false);
                    TTSStage5Jobot15.gameObject.SetActive(false);


                    // This is the text for the removal of the flowers on stage 5
                    jobotIntroStage5PlantRemovalComplete1.gameObject.SetActive(false);
                    jobotIntroStage5PlantRemovalComplete1a.gameObject.SetActive(false);
                    jobotIntroStage5PlantRemovalComplete1b.gameObject.SetActive(false);
                    jobotIntroStage5PlantRemovalComplete1c.gameObject.SetActive(false);
                    //         jobotIntroStage5PlantRemovalComplete1d.gameObject.SetActive(false);

                    TTSStage5PlantRemovalComplete1.gameObject.SetActive(false);
                    TTSStage5PlantRemovalComplete1a.gameObject.SetActive(false);
                    TTSStage5PlantRemovalComplete1b.gameObject.SetActive(false);
                    TTSStage5PlantRemovalComplete1c.gameObject.SetActive(false);
                    //         TTSStage5PlantRemovalComplete1d.gameObject.SetActive(false);


                    TTSAllTaskCompleteStage5.gameObject.SetActive(false);
                    stage5AllTasksComplete.gameObject.SetActive(false);


                    TTSStage5EndOFGame1.gameObject.SetActive(true);
                    TTSStage5EndOFGame2.gameObject.SetActive(false);
                    TTSStage5EndOFGame3.gameObject.SetActive(false);
                    TTSStage5EndOFGame4.gameObject.SetActive(false);
                    TTSStage5EndOFGame5.gameObject.SetActive(false);
                    TTSStage5EndOFGame6.gameObject.SetActive(false);
                    TTSStage5EndOFGame7.gameObject.SetActive(false);

                    jobotEndOFGame1.gameObject.SetActive(true);
                    jobotEndOFGame1a.gameObject.SetActive(false);
                    jobotEndOFGame1b.gameObject.SetActive(false);
                    jobotEndOFGame1c.gameObject.SetActive(false);
                    jobotEndOFGame1d.gameObject.SetActive(false);
                    jobotEndOFGame1e.gameObject.SetActive(false);
                    jobotEndOFGame1f.gameObject.SetActive(false);

                    progressText.gameObject.SetActive(true);
                    if (!progressTextIsShowing)
                    { // 3 second delay
                        StartCoroutine(DelayProgressButtonVar1());
                        progressTextIsShowing = true;
                    }
                }

                if (currentStageOfText == 26)
                {
                    if (!textBeenRead)
                    {
                        progressText.gameObject.SetActive(false);
                    }
                    textPanalToHide.SetActive(true);
                    jobotIntroStage5Section1.enabled = false;
                    //       jobotIntroStage5Section1a.enabled = false;
                    jobotIntroStage5Section1b.enabled = false;
                    //       jobotIntroStage5Section1c.enabled = false;
                    //       jobotIntroStage5Section1d.enabled = false;
                    jobotIntroStage5Section1e.enabled = false;
                    //       jobotIntroStage5Section1f.enabled = false;
                    jobotIntroStage5Section1g.enabled = false;
                    jobotIntroStage5Section1h.enabled = false;
                    //       jobotIntroStage5Section1i.enabled = false;
                    jobotIntroStage5Section1j.enabled = false;
                    //        jobotIntroStage5Section1k.enabled = false;
                    //        jobotIntroStage5Section1l.enabled = false;
                    //        jobotIntroStage5Section1m.enabled = false;
                    jobotIntroStage5Section1n.enabled = false;



                    TTSStage5Jobot1.gameObject.SetActive(false);
                    //         TTSStage5Jobot2.gameObject.SetActive(false);
                    TTSStage5Jobot3.gameObject.SetActive(false);
                    //         TTSStage5Jobot4.gameObject.SetActive(false);
                    //         TTSStage5Jobot5.gameObject.SetActive(false);
                    TTSStage5Jobot6.gameObject.SetActive(false);
                    //         TTSStage5Jobot7.gameObject.SetActive(false);
                    TTSStage5Jobot8.gameObject.SetActive(false);
                    TTSStage5Jobot9.gameObject.SetActive(false);
                    //         TTSStage5Jobot10.gameObject.SetActive(false);
                    TTSStage5Jobot11.gameObject.SetActive(false);
                    //         TTSStage5Jobot12.gameObject.SetActive(false);
                    //         TTSStage5Jobot13.gameObject.SetActive(false);
                    //          TTSStage5Jobot14.gameObject.SetActive(false);
                    TTSStage5Jobot15.gameObject.SetActive(false);


                    // This is the text for the removal of the flowers on stage 5
                    jobotIntroStage5PlantRemovalComplete1.gameObject.SetActive(false);
                    jobotIntroStage5PlantRemovalComplete1a.gameObject.SetActive(false);
                    jobotIntroStage5PlantRemovalComplete1b.gameObject.SetActive(false);
                    jobotIntroStage5PlantRemovalComplete1c.gameObject.SetActive(false);
                    //         jobotIntroStage5PlantRemovalComplete1d.gameObject.SetActive(false);

                    TTSStage5PlantRemovalComplete1.gameObject.SetActive(false);
                    TTSStage5PlantRemovalComplete1a.gameObject.SetActive(false);
                    TTSStage5PlantRemovalComplete1b.gameObject.SetActive(false);
                    TTSStage5PlantRemovalComplete1c.gameObject.SetActive(false);
                    //       TTSStage5PlantRemovalComplete1d.gameObject.SetActive(false);


                    TTSAllTaskCompleteStage5.gameObject.SetActive(false);
                    stage5AllTasksComplete.gameObject.SetActive(false);


                    TTSStage5EndOFGame1.gameObject.SetActive(false);
                    TTSStage5EndOFGame2.gameObject.SetActive(true);
                    TTSStage5EndOFGame3.gameObject.SetActive(false);
                    TTSStage5EndOFGame4.gameObject.SetActive(false);
                    TTSStage5EndOFGame5.gameObject.SetActive(false);
                    TTSStage5EndOFGame6.gameObject.SetActive(false);
                    TTSStage5EndOFGame7.gameObject.SetActive(false);

                    jobotEndOFGame1.gameObject.SetActive(false);
                    jobotEndOFGame1a.gameObject.SetActive(true);
                    jobotEndOFGame1b.gameObject.SetActive(false);
                    jobotEndOFGame1c.gameObject.SetActive(false);
                    jobotEndOFGame1d.gameObject.SetActive(false);
                    jobotEndOFGame1e.gameObject.SetActive(false);
                    jobotEndOFGame1f.gameObject.SetActive(false);
                    rgEnd.endRobotAnim.SetTrigger("endOfGameEnterRobot");
                    progressText.gameObject.SetActive(true);
                    if (!progressTextIsShowing)
                    { // 3 second delay
                        StartCoroutine(DelayProgressButtonVar1());
                        progressTextIsShowing = true;
                    }
                }

                if (currentStageOfText == 27)
                {
                    if (!textBeenRead)
                    {
                        progressText.gameObject.SetActive(false);
                    }
                    textPanalToHide.SetActive(true);
                    jobotIntroStage5Section1.enabled = false;
                    //   jobotIntroStage5Section1a.enabled = false;
                    jobotIntroStage5Section1b.enabled = false;
                    //   jobotIntroStage5Section1c.enabled = false;
                    //    jobotIntroStage5Section1d.enabled = false;
                    jobotIntroStage5Section1e.enabled = false;
                    //    jobotIntroStage5Section1f.enabled = false;
                    jobotIntroStage5Section1g.enabled = false;
                    jobotIntroStage5Section1h.enabled = false;
                    //    jobotIntroStage5Section1i.enabled = false;
                    jobotIntroStage5Section1j.enabled = false;
                    //    jobotIntroStage5Section1k.enabled = false;
                    //    jobotIntroStage5Section1l.enabled = false;
                    //    jobotIntroStage5Section1m.enabled = false;
                    jobotIntroStage5Section1n.enabled = false;



                    TTSStage5Jobot1.gameObject.SetActive(false);
                    //     TTSStage5Jobot2.gameObject.SetActive(false);
                    TTSStage5Jobot3.gameObject.SetActive(false);
                    //     TTSStage5Jobot4.gameObject.SetActive(false);
                    //      TTSStage5Jobot5.gameObject.SetActive(false);
                    TTSStage5Jobot6.gameObject.SetActive(false);
                    //     TTSStage5Jobot7.gameObject.SetActive(false);
                    TTSStage5Jobot8.gameObject.SetActive(false);
                    TTSStage5Jobot9.gameObject.SetActive(false);
                    //      TTSStage5Jobot10.gameObject.SetActive(false);
                    TTSStage5Jobot11.gameObject.SetActive(false);
                    //      TTSStage5Jobot12.gameObject.SetActive(false);
                    //       TTSStage5Jobot13.gameObject.SetActive(false);
                    //       TTSStage5Jobot14.gameObject.SetActive(false);
                    TTSStage5Jobot15.gameObject.SetActive(false);


                    // This is the text for the removal of the flowers on stage 5
                    jobotIntroStage5PlantRemovalComplete1.gameObject.SetActive(false);
                    jobotIntroStage5PlantRemovalComplete1a.gameObject.SetActive(false);
                    jobotIntroStage5PlantRemovalComplete1b.gameObject.SetActive(false);
                    jobotIntroStage5PlantRemovalComplete1c.gameObject.SetActive(false);
                    //       jobotIntroStage5PlantRemovalComplete1d.gameObject.SetActive(false);

                    TTSStage5PlantRemovalComplete1.gameObject.SetActive(false);
                    TTSStage5PlantRemovalComplete1a.gameObject.SetActive(false);
                    TTSStage5PlantRemovalComplete1b.gameObject.SetActive(false);
                    TTSStage5PlantRemovalComplete1c.gameObject.SetActive(false);
                    //       TTSStage5PlantRemovalComplete1d.gameObject.SetActive(false);


                    TTSAllTaskCompleteStage5.gameObject.SetActive(false);
                    stage5AllTasksComplete.gameObject.SetActive(false);


                    TTSStage5EndOFGame1.gameObject.SetActive(false);
                    TTSStage5EndOFGame2.gameObject.SetActive(false);
                    TTSStage5EndOFGame3.gameObject.SetActive(true);
                    TTSStage5EndOFGame4.gameObject.SetActive(false);
                    TTSStage5EndOFGame5.gameObject.SetActive(false);
                    TTSStage5EndOFGame6.gameObject.SetActive(false);
                    TTSStage5EndOFGame7.gameObject.SetActive(false);

                    jobotEndOFGame1.gameObject.SetActive(false);
                    jobotEndOFGame1a.gameObject.SetActive(false);
                    jobotEndOFGame1b.gameObject.SetActive(true);
                    jobotEndOFGame1c.gameObject.SetActive(false);
                    jobotEndOFGame1d.gameObject.SetActive(false);
                    jobotEndOFGame1e.gameObject.SetActive(false);
                    jobotEndOFGame1f.gameObject.SetActive(false);

                    progressText.gameObject.SetActive(true);
                    if (!progressTextIsShowing)
                    { // 3 second delay
                        StartCoroutine(DelayProgressButtonVar2());
                        progressTextIsShowing = true;
                    }
                }

                if (currentStageOfText == 28)
                {
                    if (!textBeenRead)
                    {
                        progressText.gameObject.SetActive(false);
                    }
                    textPanalToHide.SetActive(true);
                    jobotIntroStage5Section1.enabled = false;
                    //      jobotIntroStage5Section1a.enabled = false;
                    jobotIntroStage5Section1b.enabled = false;
                    //      jobotIntroStage5Section1c.enabled = false;
                    //      jobotIntroStage5Section1d.enabled = false;
                    jobotIntroStage5Section1e.enabled = false;
                    //      jobotIntroStage5Section1f.enabled = false;
                    jobotIntroStage5Section1g.enabled = false;
                    jobotIntroStage5Section1h.enabled = false;
                    //      jobotIntroStage5Section1i.enabled = false;
                    jobotIntroStage5Section1j.enabled = false;
                    //        jobotIntroStage5Section1k.enabled = false;
                    //       jobotIntroStage5Section1l.enabled = false;
                    //        jobotIntroStage5Section1m.enabled = false;
                    jobotIntroStage5Section1n.enabled = false;



                    TTSStage5Jobot1.gameObject.SetActive(false);
                    //         TTSStage5Jobot2.gameObject.SetActive(false);
                    TTSStage5Jobot3.gameObject.SetActive(false);
                    //        TTSStage5Jobot4.gameObject.SetActive(false);
                    //         TTSStage5Jobot5.gameObject.SetActive(false);
                    TTSStage5Jobot6.gameObject.SetActive(false);
                    //          TTSStage5Jobot7.gameObject.SetActive(false);
                    TTSStage5Jobot8.gameObject.SetActive(false);
                    TTSStage5Jobot9.gameObject.SetActive(false);
                    //           TTSStage5Jobot10.gameObject.SetActive(false);
                    TTSStage5Jobot11.gameObject.SetActive(false);
                    //           TTSStage5Jobot12.gameObject.SetActive(false);
                    //          TTSStage5Jobot13.gameObject.SetActive(false);
                    //           TTSStage5Jobot14.gameObject.SetActive(false);
                    TTSStage5Jobot15.gameObject.SetActive(false);


                    // This is the text for the removal of the flowers on stage 5
                    jobotIntroStage5PlantRemovalComplete1.gameObject.SetActive(false);
                    jobotIntroStage5PlantRemovalComplete1a.gameObject.SetActive(false);
                    jobotIntroStage5PlantRemovalComplete1b.gameObject.SetActive(false);
                    jobotIntroStage5PlantRemovalComplete1c.gameObject.SetActive(false);
                    //         jobotIntroStage5PlantRemovalComplete1d.gameObject.SetActive(false);

                    TTSStage5PlantRemovalComplete1.gameObject.SetActive(false);
                    TTSStage5PlantRemovalComplete1a.gameObject.SetActive(false);
                    TTSStage5PlantRemovalComplete1b.gameObject.SetActive(false);
                    TTSStage5PlantRemovalComplete1c.gameObject.SetActive(false);
                    //         TTSStage5PlantRemovalComplete1d.gameObject.SetActive(false);


                    TTSAllTaskCompleteStage5.gameObject.SetActive(false);
                    stage5AllTasksComplete.gameObject.SetActive(false);


                    TTSStage5EndOFGame1.gameObject.SetActive(false);
                    TTSStage5EndOFGame2.gameObject.SetActive(false);
                    TTSStage5EndOFGame3.gameObject.SetActive(false);
                    TTSStage5EndOFGame4.gameObject.SetActive(true);
                    TTSStage5EndOFGame5.gameObject.SetActive(false);
                    TTSStage5EndOFGame6.gameObject.SetActive(false);
                    TTSStage5EndOFGame7.gameObject.SetActive(false);

                    jobotEndOFGame1.gameObject.SetActive(false);
                    jobotEndOFGame1a.gameObject.SetActive(false);
                    jobotEndOFGame1b.gameObject.SetActive(false);
                    jobotEndOFGame1c.gameObject.SetActive(true);
                    jobotEndOFGame1d.gameObject.SetActive(false);
                    jobotEndOFGame1e.gameObject.SetActive(false);
                    jobotEndOFGame1f.gameObject.SetActive(false);

                    progressText.gameObject.SetActive(true);
                    if (!progressTextIsShowing)
                    { // 3 second delay
                        StartCoroutine(DelayProgressButtonVar2());
                        progressTextIsShowing = true;
                    }
                }

                if (currentStageOfText == 29)
                {
                    if (!textBeenRead)
                    {
                        progressText.gameObject.SetActive(false);
                    }
                    textPanalToHide.SetActive(true);
                    jobotIntroStage5Section1.enabled = false;
                    //         jobotIntroStage5Section1a.enabled = false;
                    jobotIntroStage5Section1b.enabled = false;
                    //          jobotIntroStage5Section1c.enabled = false;
                    //          jobotIntroStage5Section1d.enabled = false;
                    jobotIntroStage5Section1e.enabled = false;
                    //            jobotIntroStage5Section1f.enabled = false;
                    jobotIntroStage5Section1g.enabled = false;
                    jobotIntroStage5Section1h.enabled = false;
                    //           jobotIntroStage5Section1i.enabled = false;
                    jobotIntroStage5Section1j.enabled = false;
                    //           jobotIntroStage5Section1k.enabled = false;
                    //           jobotIntroStage5Section1l.enabled = false;
                    //           jobotIntroStage5Section1m.enabled = false;
                    jobotIntroStage5Section1n.enabled = false;



                    TTSStage5Jobot1.gameObject.SetActive(false);
                    //           TTSStage5Jobot2.gameObject.SetActive(false);
                    TTSStage5Jobot3.gameObject.SetActive(false);
                    //            TTSStage5Jobot4.gameObject.SetActive(false);
                    //           TTSStage5Jobot5.gameObject.SetActive(false);
                    TTSStage5Jobot6.gameObject.SetActive(false);
                    //            TTSStage5Jobot7.gameObject.SetActive(false);
                    TTSStage5Jobot8.gameObject.SetActive(false);
                    TTSStage5Jobot9.gameObject.SetActive(false);
                    //             TTSStage5Jobot10.gameObject.SetActive(false);
                    TTSStage5Jobot11.gameObject.SetActive(false);
                    //               TTSStage5Jobot12.gameObject.SetActive(false);
                    //              TTSStage5Jobot13.gameObject.SetActive(false);
                    //              TTSStage5Jobot14.gameObject.SetActive(false);
                    TTSStage5Jobot15.gameObject.SetActive(false);


                    // This is the text for the removal of the flowers on stage 5
                    jobotIntroStage5PlantRemovalComplete1.gameObject.SetActive(false);
                    jobotIntroStage5PlantRemovalComplete1a.gameObject.SetActive(false);
                    jobotIntroStage5PlantRemovalComplete1b.gameObject.SetActive(false);
                    jobotIntroStage5PlantRemovalComplete1c.gameObject.SetActive(false);
                    //         jobotIntroStage5PlantRemovalComplete1d.gameObject.SetActive(false);

                    TTSStage5PlantRemovalComplete1.gameObject.SetActive(false);
                    TTSStage5PlantRemovalComplete1a.gameObject.SetActive(false);
                    TTSStage5PlantRemovalComplete1b.gameObject.SetActive(false);
                    TTSStage5PlantRemovalComplete1c.gameObject.SetActive(false);
                    //         TTSStage5PlantRemovalComplete1d.gameObject.SetActive(false);


                    TTSAllTaskCompleteStage5.gameObject.SetActive(false);
                    stage5AllTasksComplete.gameObject.SetActive(false);


                    TTSStage5EndOFGame1.gameObject.SetActive(false);
                    TTSStage5EndOFGame2.gameObject.SetActive(false);
                    TTSStage5EndOFGame3.gameObject.SetActive(false);
                    TTSStage5EndOFGame4.gameObject.SetActive(false);
                    TTSStage5EndOFGame5.gameObject.SetActive(true);
                    TTSStage5EndOFGame6.gameObject.SetActive(false);
                    TTSStage5EndOFGame7.gameObject.SetActive(false);

                    jobotEndOFGame1.gameObject.SetActive(false);
                    jobotEndOFGame1a.gameObject.SetActive(false);
                    jobotEndOFGame1b.gameObject.SetActive(false);
                    jobotEndOFGame1c.gameObject.SetActive(false);
                    jobotEndOFGame1d.gameObject.SetActive(true);
                    jobotEndOFGame1e.gameObject.SetActive(false);
                    jobotEndOFGame1f.gameObject.SetActive(false);

                    progressText.gameObject.SetActive(true);
                    if (!progressTextIsShowing)
                    { // 3 second delay
                        StartCoroutine(DelayProgressButtonVar1());
                        progressTextIsShowing = true;
                    }
                }

                if (currentStageOfText == 30)
                {
                    if (!textBeenRead)
                    {
                        progressText.gameObject.SetActive(false);
                    }
                    textPanalToHide.SetActive(true);
                    jobotIntroStage5Section1.enabled = false;
                    //       jobotIntroStage5Section1a.enabled = false;
                    jobotIntroStage5Section1b.enabled = false;
                    //      jobotIntroStage5Section1c.enabled = false;
                    //       jobotIntroStage5Section1d.enabled = false;
                    jobotIntroStage5Section1e.enabled = false;
                    //       jobotIntroStage5Section1f.enabled = false;
                    jobotIntroStage5Section1g.enabled = false;
                    jobotIntroStage5Section1h.enabled = false;
                    //        jobotIntroStage5Section1i.enabled = false;
                    jobotIntroStage5Section1j.enabled = false;
                    //        jobotIntroStage5Section1k.enabled = false;
                    //        jobotIntroStage5Section1l.enabled = false;
                    //        jobotIntroStage5Section1m.enabled = false;
                    jobotIntroStage5Section1n.enabled = false;



                    TTSStage5Jobot1.gameObject.SetActive(false);
                    //         TTSStage5Jobot2.gameObject.SetActive(false);
                    TTSStage5Jobot3.gameObject.SetActive(false);
                    //         TTSStage5Jobot4.gameObject.SetActive(false);
                    //         TTSStage5Jobot5.gameObject.SetActive(false);
                    TTSStage5Jobot6.gameObject.SetActive(false);
                    //         TTSStage5Jobot7.gameObject.SetActive(false);
                    TTSStage5Jobot8.gameObject.SetActive(false);
                    TTSStage5Jobot9.gameObject.SetActive(false);
                    //         TTSStage5Jobot10.gameObject.SetActive(false);
                    TTSStage5Jobot11.gameObject.SetActive(false);
                    //         TTSStage5Jobot12.gameObject.SetActive(false);
                    //          TTSStage5Jobot13.gameObject.SetActive(false);
                    //          TTSStage5Jobot14.gameObject.SetActive(false);
                    TTSStage5Jobot15.gameObject.SetActive(false);


                    // This is the text for the removal of the flowers on stage 5
                    jobotIntroStage5PlantRemovalComplete1.gameObject.SetActive(false);
                    jobotIntroStage5PlantRemovalComplete1a.gameObject.SetActive(false);
                    jobotIntroStage5PlantRemovalComplete1b.gameObject.SetActive(false);
                    jobotIntroStage5PlantRemovalComplete1c.gameObject.SetActive(false);
                    //         jobotIntroStage5PlantRemovalComplete1d.gameObject.SetActive(false);

                    TTSStage5PlantRemovalComplete1.gameObject.SetActive(false);
                    TTSStage5PlantRemovalComplete1a.gameObject.SetActive(false);
                    TTSStage5PlantRemovalComplete1b.gameObject.SetActive(false);
                    TTSStage5PlantRemovalComplete1c.gameObject.SetActive(false);
                    //         TTSStage5PlantRemovalComplete1d.gameObject.SetActive(false);


                    TTSAllTaskCompleteStage5.gameObject.SetActive(false);
                    stage5AllTasksComplete.gameObject.SetActive(false);


                    TTSStage5EndOFGame1.gameObject.SetActive(false);
                    TTSStage5EndOFGame2.gameObject.SetActive(false);
                    TTSStage5EndOFGame3.gameObject.SetActive(false);
                    TTSStage5EndOFGame4.gameObject.SetActive(false);
                    TTSStage5EndOFGame5.gameObject.SetActive(false);
                    TTSStage5EndOFGame6.gameObject.SetActive(true);
                    TTSStage5EndOFGame7.gameObject.SetActive(false);

                    jobotEndOFGame1.gameObject.SetActive(false);
                    jobotEndOFGame1a.gameObject.SetActive(false);
                    jobotEndOFGame1b.gameObject.SetActive(false);
                    jobotEndOFGame1c.gameObject.SetActive(false);
                    jobotEndOFGame1d.gameObject.SetActive(false);
                    jobotEndOFGame1e.gameObject.SetActive(true);
                    jobotEndOFGame1f.gameObject.SetActive(false);

                    progressText.gameObject.SetActive(true);
                    if (!progressTextIsShowing)
                    { // 3 second delay
                        StartCoroutine(DelayProgressButtonVar1());
                        progressTextIsShowing = true;
                    }
                }

                if (currentStageOfText == 31)
                {
                    if (!textBeenRead)
                    {
                        progressText.gameObject.SetActive(false);
                    }
                    textPanalToHide.SetActive(true);
                    jobotIntroStage5Section1.enabled = false;
                    //        jobotIntroStage5Section1a.enabled = false;
                    jobotIntroStage5Section1b.enabled = false;
                    //         jobotIntroStage5Section1c.enabled = false;
                    //         jobotIntroStage5Section1d.enabled = false;
                    jobotIntroStage5Section1e.enabled = false;
                    //         jobotIntroStage5Section1f.enabled = false;
                    jobotIntroStage5Section1g.enabled = false;
                    jobotIntroStage5Section1h.enabled = false;
                    //          jobotIntroStage5Section1i.enabled = false;
                    jobotIntroStage5Section1j.enabled = false;
                    //           jobotIntroStage5Section1k.enabled = false;
                    //           jobotIntroStage5Section1l.enabled = false;
                    //           jobotIntroStage5Section1m.enabled = false;
                    jobotIntroStage5Section1n.enabled = false;



                    TTSStage5Jobot1.gameObject.SetActive(false);
                    //          TTSStage5Jobot2.gameObject.SetActive(false);
                    TTSStage5Jobot3.gameObject.SetActive(false);
                    //         TTSStage5Jobot4.gameObject.SetActive(false);
                    //          TTSStage5Jobot5.gameObject.SetActive(false);
                    TTSStage5Jobot6.gameObject.SetActive(false);
                    //           TTSStage5Jobot7.gameObject.SetActive(false);
                    TTSStage5Jobot8.gameObject.SetActive(false);
                    TTSStage5Jobot9.gameObject.SetActive(false);
                    //         TTSStage5Jobot10.gameObject.SetActive(false);
                    TTSStage5Jobot11.gameObject.SetActive(false);
                    //         TTSStage5Jobot12.gameObject.SetActive(false);
                    ///         TTSStage5Jobot13.gameObject.SetActive(false);
                    //         TTSStage5Jobot14.gameObject.SetActive(false);
                    TTSStage5Jobot15.gameObject.SetActive(false);


                    // This is the text for the removal of the flowers on stage 5
                    jobotIntroStage5PlantRemovalComplete1.gameObject.SetActive(false);
                    jobotIntroStage5PlantRemovalComplete1a.gameObject.SetActive(false);
                    jobotIntroStage5PlantRemovalComplete1b.gameObject.SetActive(false);
                    jobotIntroStage5PlantRemovalComplete1c.gameObject.SetActive(false);
                    //         jobotIntroStage5PlantRemovalComplete1d.gameObject.SetActive(false);

                    TTSStage5PlantRemovalComplete1.gameObject.SetActive(false);
                    TTSStage5PlantRemovalComplete1a.gameObject.SetActive(false);
                    TTSStage5PlantRemovalComplete1b.gameObject.SetActive(false);
                    TTSStage5PlantRemovalComplete1c.gameObject.SetActive(false);
                    //          TTSStage5PlantRemovalComplete1d.gameObject.SetActive(false);


                    TTSAllTaskCompleteStage5.gameObject.SetActive(false);
                    stage5AllTasksComplete.gameObject.SetActive(false);


                    TTSStage5EndOFGame1.gameObject.SetActive(false);
                    TTSStage5EndOFGame2.gameObject.SetActive(false);
                    TTSStage5EndOFGame3.gameObject.SetActive(false);
                    TTSStage5EndOFGame4.gameObject.SetActive(false);
                    TTSStage5EndOFGame5.gameObject.SetActive(false);
                    TTSStage5EndOFGame6.gameObject.SetActive(false);
                    TTSStage5EndOFGame7.gameObject.SetActive(true);

                    jobotEndOFGame1.gameObject.SetActive(false);
                    jobotEndOFGame1a.gameObject.SetActive(false);
                    jobotEndOFGame1b.gameObject.SetActive(false);
                    jobotEndOFGame1c.gameObject.SetActive(false);
                    jobotEndOFGame1d.gameObject.SetActive(false);
                    jobotEndOFGame1e.gameObject.SetActive(false);
                    jobotEndOFGame1f.gameObject.SetActive(true);
                    if (!progressTextIsShowing)
                    { // 3 second delay
                        StartCoroutine(DelayProgressButtonVar1());
                        progressTextIsShowing = true;
                    }
                    progressText.gameObject.SetActive(true);
                    if (!saveGameOnce)
                    {
                        StartCoroutine(rgEnd.EndOfGameTimer());
                        saveGameOnce = true;
                    }

                }

                if (currentStageOfText == 32)
                {
                    textPanalToHide.SetActive(false);
                    jobotIntroStage5Section1.enabled = false;
                    //          jobotIntroStage5Section1a.enabled = false;
                    jobotIntroStage5Section1b.enabled = false;
                    //         jobotIntroStage5Section1c.enabled = false;
                    //          jobotIntroStage5Section1d.enabled = false;
                    jobotIntroStage5Section1e.enabled = false;
                    //           jobotIntroStage5Section1f.enabled = false;
                    jobotIntroStage5Section1g.enabled = false;
                    jobotIntroStage5Section1h.enabled = false;
                    //            jobotIntroStage5Section1i.enabled = false;
                    jobotIntroStage5Section1j.enabled = false;
                    //            jobotIntroStage5Section1k.enabled = false;
                    //           jobotIntroStage5Section1l.enabled = false;
                    //           jobotIntroStage5Section1m.enabled = false;
                    jobotIntroStage5Section1n.enabled = false;



                    TTSStage5Jobot1.gameObject.SetActive(false);
                    //          TTSStage5Jobot2.gameObject.SetActive(false);
                    TTSStage5Jobot3.gameObject.SetActive(false);
                    //          TTSStage5Jobot4.gameObject.SetActive(false);
                    //           TTSStage5Jobot5.gameObject.SetActive(false);
                    TTSStage5Jobot6.gameObject.SetActive(false);
                    //          TTSStage5Jobot7.gameObject.SetActive(false);
                    TTSStage5Jobot8.gameObject.SetActive(false);
                    TTSStage5Jobot9.gameObject.SetActive(false);
                    //            TTSStage5Jobot10.gameObject.SetActive(false);
                    TTSStage5Jobot11.gameObject.SetActive(false);
                    //            TTSStage5Jobot12.gameObject.SetActive(false);
                    //            TTSStage5Jobot13.gameObject.SetActive(false);
                    //            TTSStage5Jobot14.gameObject.SetActive(false);
                    TTSStage5Jobot15.gameObject.SetActive(false);


                    // This is the text for the removal of the flowers on stage 5
                    jobotIntroStage5PlantRemovalComplete1.gameObject.SetActive(false);
                    jobotIntroStage5PlantRemovalComplete1a.gameObject.SetActive(false);
                    jobotIntroStage5PlantRemovalComplete1b.gameObject.SetActive(false);
                    jobotIntroStage5PlantRemovalComplete1c.gameObject.SetActive(false);
                    //           jobotIntroStage5PlantRemovalComplete1d.gameObject.SetActive(false);

                    TTSStage5PlantRemovalComplete1.gameObject.SetActive(false);
                    TTSStage5PlantRemovalComplete1a.gameObject.SetActive(false);
                    TTSStage5PlantRemovalComplete1b.gameObject.SetActive(false);
                    TTSStage5PlantRemovalComplete1c.gameObject.SetActive(false);
                    //           TTSStage5PlantRemovalComplete1d.gameObject.SetActive(false);


                    TTSAllTaskCompleteStage5.gameObject.SetActive(false);
                    stage5AllTasksComplete.gameObject.SetActive(false);


                    TTSStage5EndOFGame1.gameObject.SetActive(false);
                    TTSStage5EndOFGame2.gameObject.SetActive(false);
                    TTSStage5EndOFGame3.gameObject.SetActive(false);
                    TTSStage5EndOFGame4.gameObject.SetActive(false);
                    TTSStage5EndOFGame5.gameObject.SetActive(false);
                    TTSStage5EndOFGame6.gameObject.SetActive(false);
                    TTSStage5EndOFGame7.gameObject.SetActive(false);

                    jobotEndOFGame1.gameObject.SetActive(false);
                    jobotEndOFGame1a.gameObject.SetActive(false);
                    jobotEndOFGame1b.gameObject.SetActive(false);
                    jobotEndOFGame1c.gameObject.SetActive(false);
                    jobotEndOFGame1d.gameObject.SetActive(false);
                    jobotEndOFGame1e.gameObject.SetActive(false);
                    jobotEndOFGame1f.gameObject.SetActive(false);

                    progressText.gameObject.SetActive(true);

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

            void JobotStage5Section1()
            {
                LOLSDK.Instance.SpeakText("jobotStage5Intro1");
            }


            void JobotStage5Section1b()
            {
                LOLSDK.Instance.SpeakText("jobotStage5Intro1b");
            }


            void JobotStage5Section1e()
            {
                LOLSDK.Instance.SpeakText("jobotStage5Intro1e");
            }

            void JobotStage5Section1g()
            {
                LOLSDK.Instance.SpeakText("jobotStage5Intro1g");
            }

            void JobotStage5Section1h()
            {
                LOLSDK.Instance.SpeakText("jobotStage5Intro1h");
            }


            void JobotStage5Section1j()
            {
                LOLSDK.Instance.SpeakText("jobotStage5Intro1j");
            }


            void JobotStage5Section1n()
            {
                LOLSDK.Instance.SpeakText("jobotStage5Intro1n");
            }


            void JobotStage5PlantsRemoved1()
            {
                LOLSDK.Instance.SpeakText("jobotStage5PlantComplete1");
            }

            void JobotStage5PlantsRemoved1a()
            {
                LOLSDK.Instance.SpeakText("jobotStage5PlantComplete1a");
            }

            void JobotStage5PlantsRemoved1b()
            {
                LOLSDK.Instance.SpeakText("jobotStage5PlantComplete1b");
            }

            void JobotStage5PlantsRemoved1c()
            {
                LOLSDK.Instance.SpeakText("jobotStage5PlantComplete1c");
            }



            void JobotStage5AllTasksComplete()
            {
                LOLSDK.Instance.SpeakText("jobotStage5StageCompleteMessage");
            }

            void JobotStage5EndOFGame1()
            {
                LOLSDK.Instance.SpeakText("jobotStage5EndOfGameText");
            }

            void JobotStage5EndOFGame1a()
            {
                LOLSDK.Instance.SpeakText("jobotStage5EndOfGameTexta");
            }


            void JobotStage5EndOFGame1b()
            {
                LOLSDK.Instance.SpeakText("jobotStage5EndOfGameTextb");
            }

            void JobotStage5EndOFGame1c()
            {
                LOLSDK.Instance.SpeakText("jobotStage5EndOfGameTextc");
            }

            void JobotStage5EndOFGame1d()
            {
                LOLSDK.Instance.SpeakText("jobotStage5EndOfGameTextd");
            }

            void JobotStage5EndOFGame1e()
            {
                LOLSDK.Instance.SpeakText("jobotStage5EndOfGameTexte");
            }

            void JobotStage5EndOFGame1f()
            {
                LOLSDK.Instance.SpeakText("jobotStage5EndOfGameTextf");
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

            public IEnumerator CloseTextPanal()
            {
                yield return new WaitForSeconds(2);
                currentStageOfText = 16;
            }
        }
    } 
