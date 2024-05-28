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

        public bool textRead1;
        public bool textRead2;
        public bool textRead3;
        public bool textRead4;
        public bool textRead5;
        public bool textRead6;
        public bool textRead7;
        public bool textRead8;
        public bool textRead9;

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


        public bool plantRemovalTextRead1;
        public bool plantRemovalTextRead2;
        public bool plantRemovalTextRead3;
        public bool plantRemovalTextRead4;
        public bool plantRemovalTextRead5;
        public bool plantRemovalTextRead6;


        public TextMeshProUGUI jobotIntroStage5PlantRemovalComplete1;
        public TextMeshProUGUI jobotIntroStage5PlantRemovalComplete1a;
        public TextMeshProUGUI jobotIntroStage5PlantRemovalComplete1b;
        public TextMeshProUGUI jobotIntroStage5PlantRemovalComplete1c;
        //  public TextMeshProUGUI jobotIntroStage5PlantRemovalComplete1d;

        public Button TTSAllTaskCompleteStage5;
        public TextMeshProUGUI stage5AllTasksComplete;

        public bool endOfGameReadText1;
        public bool endOfGameReadText2;
        public bool endOfGameReadText3;
        public bool endOfGameReadText4;
        public bool endOfGameReadText5;
        public bool endOfGameReadText6;
        public bool endOfGameReadText7;
        public bool endOfGameReadText8;
        public bool endOfGameReadText9;


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



            // This is the text for the removal of the flowers on stage 5
      //      jobotIntroStage5PlantRemovalComplete1.gameObject.SetActive(false);
      //      jobotIntroStage5PlantRemovalComplete1a.gameObject.SetActive(false);
      //     jobotIntroStage5PlantRemovalComplete1b.gameObject.SetActive(false);
      //      jobotIntroStage5PlantRemovalComplete1c.gameObject.SetActive(false);
            //    jobotIntroStage5PlantRemovalComplete1d.gameObject.SetActive(false);

       
         //   stage5AllTasksComplete.gameObject.SetActive(false);


     //       jobotEndOFGame1.gameObject.SetActive(false);
    //        jobotEndOFGame1a.gameObject.SetActive(false);
     //       jobotEndOFGame1b.gameObject.SetActive(false);
     //       jobotEndOFGame1c.gameObject.SetActive(false);
    //        jobotEndOFGame1d.gameObject.SetActive(false);
    //        jobotEndOFGame1e.gameObject.SetActive(false);
     //       jobotEndOFGame1f.gameObject.SetActive(false);


        }

        // Update is called once per frame
        void Update()
        {
            if (rgMainData.currentGameStage == 5)
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
                        progressTextBack.gameObject.SetActive(false);
                        robotControl.enabled = false;
                        textPanalToHide.SetActive(true);

                        jobotIntroStage5Section1.gameObject.SetActive(true);
                        jobotIntroStage5Section1b.gameObject.SetActive(false);

                        closeDoor.SetBool("closeDoor", true);

                        if (!progressTextIsShowing)
                        { // 3 second delay
                            StartCoroutine(DelayProgressButtonVar1());
                            progressTextIsShowing = true;
                        }
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
                        jobotIntroStage5Section1.gameObject.SetActive(false);
                        jobotIntroStage5Section1b.gameObject.SetActive(true);
                        jobotIntroStage5Section1e.gameObject.SetActive(false);

                        closeDoor.SetBool("doorNeedsToBeOpen", false);
                        closeDoor.SetBool("closeDoor", false);
                        closeDoor.SetTrigger("resetDoorValues");
                        if (!progressTextIsShowing)
                        { // 3 second delay
                            StartCoroutine(DelayProgressButtonVar2());
                            progressTextIsShowing = true;
                        }
                        textRead2 = true;
                    }
             
                }

                if (currentStageOfText == 3)
                {
                    if (textRead3)
                    {
                        if (!textBeenRead)
                        {
                            progressText.gameObject.SetActive(false);
                        }

                        jobotIntroStage5Section1b.gameObject.SetActive(false);
                        jobotIntroStage5Section1e.gameObject.SetActive(true);
                        jobotIntroStage5Section1g.gameObject.SetActive(false);

                        if (!progressTextIsShowing)
                        { // 3 second delay
                            StartCoroutine(DelayProgressButtonVar2());
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

                        jobotIntroStage5Section1e.gameObject.SetActive(false);
                        //     jobotIntroStage5Section1f.enabled = false;
                        jobotIntroStage5Section1g.gameObject.SetActive(true);
                        jobotIntroStage5Section1h.gameObject.SetActive(false);
                        if (!progressTextIsShowing)
                        { // 3 second delay
                            StartCoroutine(DelayProgressButtonVar1());
                            progressTextIsShowing = true;
                        }
                        textRead4 = true;
                    }
                 

                }

                if (currentStageOfText == 5)
                {
                    if (!textRead5)
                    {
                        if (!textBeenRead)
                        {
                            progressText.gameObject.SetActive(false);
                        }

                        jobotIntroStage5Section1g.gameObject.SetActive(false);
                        jobotIntroStage5Section1h.gameObject.SetActive(true);
                        //          jobotIntroStage5Section1i.enabled = false;
                        jobotIntroStage5Section1j.enabled = false;
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
                        if (!textBeenRead)
                        {
                            progressText.gameObject.SetActive(false);
                        }

                        jobotIntroStage5Section1h.gameObject.SetActive(false);
                        jobotIntroStage5Section1j.gameObject.SetActive(true);
                        jobotIntroStage5Section1n.gameObject.SetActive(false);

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
                        jobotIntroStage5Section1j.gameObject.SetActive(false);
                        jobotIntroStage5Section1n.gameObject.SetActive(true);


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
                        textRead7 = true;
                        // This is the text for the removal of the flowers on stage 5
                    }


                }

                if (currentStageOfText == 16)
                {
                    textPanalToHide.SetActive(false);
                    jobotIntroStage5Section1.gameObject.SetActive(false);
                    //  jobotIntroStage5Section1a.enabled = false;
                    jobotIntroStage5Section1b.gameObject.SetActive(false);
                    //   jobotIntroStage5Section1c.enabled = false;
                    //   jobotIntroStage5Section1d.enabled = false;
                    jobotIntroStage5Section1e.gameObject.SetActive(false);
                    //   jobotIntroStage5Section1f.enabled = false;
                    jobotIntroStage5Section1g.gameObject.SetActive(false);
                    jobotIntroStage5Section1h.gameObject.SetActive(false);
                    //    jobotIntroStage5Section1i.enabled = false;
                    jobotIntroStage5Section1j.gameObject.SetActive(false);
                    //   jobotIntroStage5Section1k.enabled = false;
                    //   jobotIntroStage5Section1l.enabled = false;
                    ///   jobotIntroStage5Section1m.enabled = false;
                    jobotIntroStage5Section1n.gameObject.SetActive(false);



                


                    // This is the text for the removal of the flowers on stage 5
                    jobotIntroStage5PlantRemovalComplete1.gameObject.SetActive(false);
                    jobotIntroStage5PlantRemovalComplete1a.gameObject.SetActive(false);
                    jobotIntroStage5PlantRemovalComplete1b.gameObject.SetActive(false);
                    jobotIntroStage5PlantRemovalComplete1c.gameObject.SetActive(false);
                    //    jobotIntroStage5PlantRemovalComplete1d.gameObject.SetActive(false);

               


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
                   
                    if (!plantRemovalTextRead1)
                    {
                        if (!textBeenRead)
                        {
                            progressText.gameObject.SetActive(false);
                        }

                        taskPanal.SetActive(true);

                        jobotIntroStage5Section1n.enabled = false;


                        // This is the text for the removal of the flowers on stage 5
                        jobotIntroStage5PlantRemovalComplete1.gameObject.SetActive(true);
                        jobotIntroStage5PlantRemovalComplete1a.gameObject.SetActive(false);

                        progressText.gameObject.SetActive(true);

                        if (!progressTextIsShowing)
                        { // 3 second delay
                            StartCoroutine(DelayProgressButtonVar1());
                            progressTextIsShowing = true;
                        }

                        plantRemovalTextRead1 = true;
                    }

                  
                }

                if (currentStageOfText == 20)
                {
                    if (!plantRemovalTextRead2)
                    {
                        if (!textBeenRead)
                        {
                            progressText.gameObject.SetActive(false);
                        }

                        // This is the text for the removal of the flowers on stage 5
                        jobotIntroStage5PlantRemovalComplete1.gameObject.SetActive(false);
                        jobotIntroStage5PlantRemovalComplete1a.gameObject.SetActive(true);
                        jobotIntroStage5PlantRemovalComplete1b.gameObject.SetActive(false);


                        if (!progressTextIsShowing)
                        { // 3 second delay
                            StartCoroutine(DelayProgressButtonVar2());
                            progressTextIsShowing = true;
                        }
                        plantRemovalTextRead2 = true;
                    }
                  
                }

                if (currentStageOfText == 21)
                {
                    if (!plantRemovalTextRead3)
                    {
                        if (!textBeenRead)
                        {
                            progressText.gameObject.SetActive(false);
                        }

                        jobotIntroStage5PlantRemovalComplete1a.gameObject.SetActive(false);
                        jobotIntroStage5PlantRemovalComplete1b.gameObject.SetActive(true);
                        jobotIntroStage5PlantRemovalComplete1c.gameObject.SetActive(false);

                        if (!progressTextIsShowing)
                        { // 3 second delay
                            StartCoroutine(DelayProgressButton());
                            progressTextIsShowing = true;
                        }
                        plantRemovalTextRead3 = true;
                    }
                   
                }


                if (currentStageOfText == 22)
                {
                    if (!plantRemovalTextRead4)
                    {
                        if (!textBeenRead)
                        {
                            progressText.gameObject.SetActive(false);
                        }

                        jobotIntroStage5PlantRemovalComplete1b.gameObject.SetActive(false);
                        jobotIntroStage5PlantRemovalComplete1c.gameObject.SetActive(true);
                        //      jobotIntroStage5PlantRemovalComplete1d.gameObject.SetActive(false);


                        StartCoroutine(CloseTextPanal());
                        plantRemovalTextRead4 = true;
                    }
                }
             

                if (currentStageOfText == 24)
                {
                    if (!runOnce)
                    {
                        textPanalToHide.SetActive(true);

                        TTSStage5PlantRemovalComplete1c.gameObject.SetActive(false);

                        stage5AllTasksComplete.gameObject.SetActive(true);
                        // StartCoroutine(CloseTextPanal());
                        progressText.gameObject.SetActive(false);
                        runOnce = true;
                    }
                    
                }


                if (currentStageOfText == 25)
                {
                    if (!endOfGameReadText1)
                    {
                        if (!textBeenRead)
                        {
                            progressText.gameObject.SetActive(false);
                        }
                        textPanalToHide.gameObject.SetActive(true);
                        textPanalToHide.SetActive(true);

                        stage5AllTasksComplete.gameObject.SetActive(false);

                        jobotEndOFGame1.gameObject.SetActive(true);
                        jobotEndOFGame1a.gameObject.SetActive(false);

                        progressText.gameObject.SetActive(true);
                        if (!progressTextIsShowing)
                        { // 3 second delay
                            StartCoroutine(DelayProgressButtonVar1());
                            progressTextIsShowing = true;
                        }
                        endOfGameReadText1 = true;
                    }
                  
                }

                if (currentStageOfText == 26)
                {
                    if (!endOfGameReadText2)
                    {
                        if (!textBeenRead)
                        {
                            progressText.gameObject.SetActive(false);
                        }
                        //     textPanalToHide.SetActive(true);
                        jobotEndOFGame1.gameObject.SetActive(false);
                        jobotEndOFGame1a.gameObject.SetActive(true);
                        jobotEndOFGame1b.gameObject.SetActive(false);
                        rgEnd.endRobotAnim.SetTrigger("endOfGameEnterRobot");
                        progressText.gameObject.SetActive(true);
                        if (!progressTextIsShowing)
                        { // 3 second delay
                            StartCoroutine(DelayProgressButtonVar1());
                            progressTextIsShowing = true;
                        }
                        endOfGameReadText2 = true;
                    }
                   
                }

                if (currentStageOfText == 27)
                {
                    if (!endOfGameReadText3)
                    {
                        if (!textBeenRead)
                        {
                            progressText.gameObject.SetActive(false);
                        }

                        jobotEndOFGame1a.gameObject.SetActive(false);
                        jobotEndOFGame1b.gameObject.SetActive(true);
                        jobotEndOFGame1c.gameObject.SetActive(false);

                        progressText.gameObject.SetActive(true);
                        if (!progressTextIsShowing)
                        { // 3 second delay
                            StartCoroutine(DelayProgressButtonVar2());
                            progressTextIsShowing = true;
                        }
                        endOfGameReadText3 = true;
                    }
                   
                }

                if (currentStageOfText == 28)
                {
                    if (!endOfGameReadText4)
                    {
                        if (!textBeenRead)
                        {
                            progressText.gameObject.SetActive(false);
                        }

                        jobotEndOFGame1b.gameObject.SetActive(false);
                        jobotEndOFGame1c.gameObject.SetActive(true);
                        jobotEndOFGame1d.gameObject.SetActive(false);

                        progressText.gameObject.SetActive(true);
                        if (!progressTextIsShowing)
                        { // 3 second delay
                            StartCoroutine(DelayProgressButtonVar2());
                            progressTextIsShowing = true;
                        }
                        endOfGameReadText4 = true;
                    }
                  
                }

                if (currentStageOfText == 29)
                {
                    if (!endOfGameReadText5)
                    {
                        if (!textBeenRead)
                        {
                            progressText.gameObject.SetActive(false);
                        }

                        jobotEndOFGame1c.gameObject.SetActive(false);
                        jobotEndOFGame1d.gameObject.SetActive(true);
                        jobotEndOFGame1e.gameObject.SetActive(false);

                        progressText.gameObject.SetActive(true);
                        if (!progressTextIsShowing)
                        { // 3 second delay
                            StartCoroutine(DelayProgressButtonVar1());
                            progressTextIsShowing = true;
                        }
                        endOfGameReadText5 = true;
                    }

                    
                }

                if (currentStageOfText == 30)
                {
                    if (!endOfGameReadText6)
                    {

                    }
                    if (!textBeenRead)
                    {
                        progressText.gameObject.SetActive(false);
                    }
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
                    if (!textRead7)
                    {
                        if (!textBeenRead)
                        {
                            progressText.gameObject.SetActive(false);
                        }

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
                        textRead7 = true;
                    }
                  

                }

                if (currentStageOfText == 32)
                {
                    if (!endOfGameReadText8)
                    {
                        textPanalToHide.SetActive(false);

                        jobotEndOFGame1e.gameObject.SetActive(false);
                        jobotEndOFGame1f.gameObject.SetActive(false);

                        progressText.gameObject.SetActive(true);
                        endOfGameReadText8 = true;
                    }
                    /*
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
                     */
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

            plantRemovalTextRead1 = false;
            plantRemovalTextRead2 = false;
            plantRemovalTextRead3 = false;
            plantRemovalTextRead4 = false;
            plantRemovalTextRead5 = false;
            plantRemovalTextRead6 = false;

            endOfGameReadText1 = false;
            endOfGameReadText2 = false;
            endOfGameReadText3 = false;
            endOfGameReadText4 = false;
            endOfGameReadText5 = false;
            endOfGameReadText6 = false;
            endOfGameReadText7 = false;
            endOfGameReadText8 = false;


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
