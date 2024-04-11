using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using LoLSDK;
using UnityEngine.AI;
namespace Alpha.Phases.Robo.Grow
{
    // This is the text manager for stage 1 of RoboGrow

    public class RoboGrowTextBoxManager : MonoBehaviour
    {
        public RoboGrowMain rgMainData;
        public RoboGrowTextBoxManager rgTextMan;
        public GameObject textPanalToHide;
        public RobotController robotControl;
        public Animator camZoomOutAnim;
        public Animator closeDoor;
        public GameObject camerToDisable;
        public Button forwardButtonToDisable;
        public GameObject taskPanal;
        public GameObject endStage1PanalToHide;
        public GameObject organicBoxesToHide;
        public GameObject setPeicesToDisable;
        public bool introReadyToBeCompleted;
        public bool textBeenRead;
        public bool progressTextIsShowing;
        public Camera robotPlayerCam;
        public Camera flowerCamera;
        public GameObject hint1ToEnable;
        public GameObject hint2ToEnable;
        //public GameObject seedButton;
        public GameObject taskButton;
        public Button TTSJobot1;
        public Button TTSJobot2;
        public Button TTSJobot3;
        public Button TTSJobot4;
        public Button TTSJobot5;
        public Button TTSJobot6;
        public Button TTSJobot7;
        public Button TTSJobot8;
        public Button TTSJobot9;
        public Button TTSJobot10;
        public Button TTSJobot11;
        public Button TTSJobot12;
        public Button TTSJobot13;
        public Button TTSJobot14;
        public Button TTSJobot15;
        public Button TTSJobot16;
        public Button TTSJobot17;
        public Button TTSJobot18;
        public Button TTSJobot19;

        public Button TTSJobotRock;
        //public Button TTSJobotGreenHouse;
        // public Button TTSJobotPond;
        public Button TTSJobotTree;

        public Button stage1CompleteButton;

        public TextMeshProUGUI jobotIntroStage1Section1;
        public TextMeshProUGUI jobotIntroStage1Section1a;
        public TextMeshProUGUI jobotIntroStage1Section1b;
        public TextMeshProUGUI jobotIntroStage1Section1c;
        public TextMeshProUGUI jobotIntroStage1Section1d;
        public TextMeshProUGUI jobotIntroStage1Section1e;
        public TextMeshProUGUI jobotIntroStage1Section1f;
        public TextMeshProUGUI jobotIntroStage1Section1g;
        public TextMeshProUGUI jobotIntroStage1Section1h;
        public TextMeshProUGUI jobotIntroStage1Section1i;
        public TextMeshProUGUI jobotIntroStage1Section1j;
        public TextMeshProUGUI jobotIntroStage1Section1k;
        public TextMeshProUGUI jobotIntroStage1Section1l;
        public TextMeshProUGUI jobotIntroStage1Section1m;
        public TextMeshProUGUI jobotIntroStage1Section1n;
        public TextMeshProUGUI jobotIntroStage1Section1o;
        public TextMeshProUGUI jobotIntroStage1Section1p;
        public TextMeshProUGUI jobotIntroStage1Section1q;
        public TextMeshProUGUI jobotIntroStage1Section1r;

        public TextMeshProUGUI jobotIntroStage1Section1Rock;
        // public TextMeshProUGUI jobotIntroStage1Section1GreenHouse;
        // public TextMeshProUGUI jobotIntroStage1Section1Pond;
        public TextMeshProUGUI jobotIntroStage1Section1Tree;
        public TextMeshProUGUI stage1CompleteText;

        public Button progressText;
        public Button progressTextBack;

        public bool text1Read;
        public bool text2Read;
        public bool text3Read;
        public bool text4Read;
        public bool text5Read;
        public bool text6Read;
        public bool text7Read;
        public bool text8Read;
        public bool text9Read;
        public bool text10Read;
        public bool text11Read;
        public bool text12Read;
        public bool text13Read;
        public bool text14Read;
        public bool text15Read;
        public bool text16Read;
        public bool text17Read;
        public bool text18Read;
        public bool text19Read;
        public bool text20Read;
        public bool text21Read;
        public bool text22Read;
        public bool text23Read;
        public bool text24Read;


        public int currentStageOfText;

        private void Awake()
        {
            currentStageOfText = 0;
            progressText.onClick.AddListener(OnClick);
            endStage1PanalToHide.SetActive(false);
            progressTextBack.onClick.AddListener(OnClickBack);
            TTSJobot1.onClick.AddListener(JobotStage1Section1);
            TTSJobot2.onClick.AddListener(JobotStage1Section1a);
            TTSJobot3.onClick.AddListener(JobotStage1Section1b);
            TTSJobot4.onClick.AddListener(JobotStage1Section1c);
            TTSJobot5.onClick.AddListener(JobotStage1Section1d);
            TTSJobot6.onClick.AddListener(JobotStage1Section1e);
            TTSJobot7.onClick.AddListener(JobotStage1Section1f);
            TTSJobot8.onClick.AddListener(JobotStage1Section1g);
            TTSJobot9.onClick.AddListener(JobotStage1Section1h);
            TTSJobot10.onClick.AddListener(JobotStage1Section1i);
            TTSJobot11.onClick.AddListener(JobotStage1Section1j);
            TTSJobot12.onClick.AddListener(JobotStage1Section1k);
            TTSJobot13.onClick.AddListener(JobotStage1Section1l);
            TTSJobot14.onClick.AddListener(JobotStage1Section1m);
            TTSJobot15.onClick.AddListener(JobotStage1Section1n);
            TTSJobot16.onClick.AddListener(JobotStage1Section1o);
            TTSJobot17.onClick.AddListener(JobotStage1Section1p);
            TTSJobot18.onClick.AddListener(JobotStage1Section1q);
            TTSJobot19.onClick.AddListener(JobotStage1Section1r);
            TTSJobotRock.onClick.AddListener(JobotStage1Section1Rock);
            //  TTSJobotGreenHouse.onClick.AddListener(JobotStage1Section1GreenHouse);
            //  TTSJobotPond.onClick.AddListener(JobotStage1Section1Pond);
            TTSJobotTree.onClick.AddListener(JobotStage1Section1Tree);

        }
        // Start is called before the first frame update
        void Start()
        {
            if (rgMainData.currentGameStage == 1)
            {
                robotControl.enabled = false;
                textPanalToHide.SetActive(false);

            }

        }

        // Update is called once per frame
        void Update()
        {

            if (rgMainData.currentGameStage == 1)
            {
                if (currentStageOfText == 1)
                {
                    if (!text1Read)
                    {
                        textPanalToHide.SetActive(true);
                        if (!textBeenRead)
                        {
                            progressText.gameObject.SetActive(false);
                        }

                        jobotIntroStage1Section1.gameObject.SetActive(true);
                        jobotIntroStage1Section1a.gameObject.SetActive(false);

                        TTSJobot1.gameObject.SetActive(true);
                        TTSJobot2.gameObject.SetActive(false);

                        //   TTSJobotRock.gameObject.SetActive(false);
                        //   TTSJobotTree.gameObject.SetActive(false);
                        taskButton.gameObject.SetActive(true);
                        closeDoor.SetBool("closeDoor", true);
                        if (!progressTextIsShowing)
                        { // 3 second delay
                            StartCoroutine(DelayProgressButton());
                            progressTextIsShowing = true;
                        }
                        text1Read = true;
                    }
                }
                //  jobotIntroStage1


                if (currentStageOfText == 2)
                {
                    if (!text2Read)
                    {

                        //  jobotIntroStage1a
                        if (!textBeenRead)
                        {
                            progressText.gameObject.SetActive(false);
                        }
                        jobotIntroStage1Section1.gameObject.SetActive(false);
                        jobotIntroStage1Section1a.gameObject.SetActive(true);
                        jobotIntroStage1Section1b.gameObject.SetActive(false);

                        TTSJobot1.gameObject.SetActive(false);
                        TTSJobot2.gameObject.SetActive(true);
                        TTSJobot3.gameObject.SetActive(false);

                        progressTextBack.gameObject.SetActive(true);

                        if (!progressTextIsShowing)
                        { // 3 second delay
                            StartCoroutine(DelayProgressButton());
                            progressTextIsShowing = true;
                        }
                        StartCoroutine(ResetDoor());
                        text2Read = true;

                    }
                }



                if (currentStageOfText == 3)
                {
                    //  jobotIntroStage1b
                    if (!text3Read)
                    {
                        if (!textBeenRead)
                        {
                            progressText.gameObject.SetActive(false);
                        }

                        jobotIntroStage1Section1a.gameObject.SetActive(false);
                        jobotIntroStage1Section1b.gameObject.SetActive(true);
                        jobotIntroStage1Section1c.gameObject.SetActive(false);


                        TTSJobot2.gameObject.SetActive(false);
                        TTSJobot3.gameObject.SetActive(true);
                        TTSJobot4.gameObject.SetActive(false);

                        if (!progressTextIsShowing)
                        {  // 3 second delay
                            StartCoroutine(DelayProgressButtonVar2());
                            progressTextIsShowing = true;
                        }
                        text3Read = true;
                    }
                }


                if (currentStageOfText == 4)
                {
                    if (!text4Read)
                    {
                        //  jobotIntroStage1c
                        if (!textBeenRead)
                        {
                            progressText.gameObject.SetActive(false);
                        }

                        jobotIntroStage1Section1b.gameObject.SetActive(false);
                        jobotIntroStage1Section1c.gameObject.SetActive(true);
                        jobotIntroStage1Section1d.gameObject.SetActive(false);

                        TTSJobot3.gameObject.SetActive(false);
                        TTSJobot4.gameObject.SetActive(true);
                        TTSJobot5.gameObject.SetActive(false);

                        if (!progressTextIsShowing)
                        {   //delay 1 seconds
                            StartCoroutine(DelayProgressButtonVar1());
                            progressTextIsShowing = true;
                        }
                        text4Read = true;
                    }
                }


                if (currentStageOfText == 5)
                {
                    if (!text5Read)
                    {
                        //  jobotIntroStage1d
                        if (!textBeenRead)
                        {
                            progressText.gameObject.SetActive(false);
                        }

                        jobotIntroStage1Section1c.gameObject.SetActive(false);
                        jobotIntroStage1Section1d.gameObject.SetActive(true);
                        jobotIntroStage1Section1e.gameObject.SetActive(false);

                        TTSJobot4.gameObject.SetActive(false);
                        TTSJobot5.gameObject.SetActive(true);
                        TTSJobot6.gameObject.SetActive(false);

                        hint1ToEnable.gameObject.SetActive(true);

                        if (!progressTextIsShowing)
                        { // delay 1 sconds
                            StartCoroutine(DelayProgressButtonVar1());
                            progressTextIsShowing = true;
                        }
                        text5Read = true;
                    }
                }


                if (currentStageOfText == 6)
                {
                    if (!text6Read)
                    {
                        //  jobotIntroStage1e
                        if (!textBeenRead)
                        {
                            progressText.gameObject.SetActive(false);
                        }

                        jobotIntroStage1Section1d.gameObject.SetActive(false);
                        jobotIntroStage1Section1e.gameObject.SetActive(true);
                        jobotIntroStage1Section1f.gameObject.SetActive(false);

                        TTSJobot5.gameObject.SetActive(false);
                        TTSJobot6.gameObject.SetActive(true);
                        TTSJobot7.gameObject.SetActive(false);

                        if (!progressTextIsShowing)
                        { // delay 3 sconds
                            StartCoroutine(DelayProgressButton());
                            progressTextIsShowing = true;
                        }
                        text6Read = true;
                    }
                }




                if (currentStageOfText == 7)
                {
                    if (!text7Read)
                    {
                        //  jobotIntroStage1f
                        if (!textBeenRead)
                        {
                            progressText.gameObject.SetActive(false);
                        }

                        jobotIntroStage1Section1e.gameObject.SetActive(false);
                        jobotIntroStage1Section1f.gameObject.SetActive(true);
                        jobotIntroStage1Section1g.gameObject.SetActive(false);

                        TTSJobot6.gameObject.SetActive(false);
                        TTSJobot7.gameObject.SetActive(true);
                        TTSJobot8.gameObject.SetActive(false);

                        if (!progressTextIsShowing)
                        { // delay 1 sconds
                            StartCoroutine(DelayProgressButtonVar2());
                            progressTextIsShowing = true;
                        }
                        text7Read = true;
                    }
                }




                if (currentStageOfText == 8)
                {
                    if (!text8Read)
                    {
                        //  jobotIntroStage1g
                        if (!textBeenRead)
                        {
                            progressText.gameObject.SetActive(false);
                        }

                        jobotIntroStage1Section1f.gameObject.SetActive(false);
                        jobotIntroStage1Section1g.gameObject.SetActive(true);
                        jobotIntroStage1Section1h.gameObject.SetActive(false);

                        TTSJobot7.gameObject.SetActive(false);
                        TTSJobot8.gameObject.SetActive(true);
                        TTSJobot9.gameObject.SetActive(false);

                        if (!progressTextIsShowing)
                        { // delay 1 sconds
                            StartCoroutine(DelayProgressButton());
                            progressTextIsShowing = true;
                        }
                        text8Read = true;
                    }
                }


                if (currentStageOfText == 9)
                {
                    if (!text9Read)
                    {
                        //  jobotIntroStage1h
                        if (!textBeenRead)
                        {
                            progressText.gameObject.SetActive(false);
                        }
                        hint2ToEnable.gameObject.SetActive(true);
                        jobotIntroStage1Section1g.gameObject.SetActive(false);
                        jobotIntroStage1Section1h.gameObject.SetActive(true);
                        jobotIntroStage1Section1i.gameObject.SetActive(false);

                        TTSJobot8.gameObject.SetActive(false);
                        TTSJobot9.gameObject.SetActive(true);
                        TTSJobot10.gameObject.SetActive(false);

                        if (!progressTextIsShowing)
                        { // delay 1 sconds
                            StartCoroutine(DelayProgressButtonVar1());
                            progressTextIsShowing = true;
                        }
                        text9Read = true;
                    }
                }



                if (currentStageOfText == 10)
                { //  jobotIntroStage1i

                    if (!text10Read)
                    {
                        if (!textBeenRead)
                        {
                            progressText.gameObject.SetActive(false);
                        }

                        jobotIntroStage1Section1h.gameObject.SetActive(false);
                        jobotIntroStage1Section1i.gameObject.SetActive(true);
                        jobotIntroStage1Section1j.gameObject.SetActive(false);

                        TTSJobot9.gameObject.SetActive(false);
                        TTSJobot10.gameObject.SetActive(true);
                        TTSJobot11.gameObject.SetActive(false);

                        if (!progressTextIsShowing)
                        { // delay 1 sconds
                            StartCoroutine(DelayProgressButtonVar2());
                            progressTextIsShowing = true;
                        }
                        text10Read = true;
                    }
                }



                if (currentStageOfText == 11)
                {
                    if (!text11Read)
                    {
                        // Jobotintrostage1j
                        rgMainData.namePanalToHide.SetActive(true);

                        jobotIntroStage1Section1i.gameObject.SetActive(false);
                        jobotIntroStage1Section1j.gameObject.SetActive(true);
                        jobotIntroStage1Section1k.gameObject.SetActive(false);

                        TTSJobot10.gameObject.SetActive(false);
                        TTSJobot11.gameObject.SetActive(true);
                        TTSJobot12.gameObject.SetActive(false);

                        text11Read = true;
                    }

                }



                if (currentStageOfText == 12)
                {
                    if (!text12Read)
                    {
                        // Jobotintrostage1k
                        rgMainData.namePanalToHide.SetActive(false);

                        progressText.gameObject.SetActive(true);
                        jobotIntroStage1Section1j.gameObject.SetActive(false);
                        jobotIntroStage1Section1k.gameObject.SetActive(true);
                        jobotIntroStage1Section1l.gameObject.SetActive(false);


                        TTSJobot11.gameObject.SetActive(false);
                        TTSJobot12.gameObject.SetActive(true);
                        TTSJobot13.gameObject.SetActive(false);
                        text12Read = true;
                    }
                }



                if (currentStageOfText == 13)
                {
                    if (!text13Read)
                    {
                        jobotIntroStage1Section1k.gameObject.SetActive(false);
                        jobotIntroStage1Section1l.gameObject.SetActive(true);
                        jobotIntroStage1Section1m.gameObject.SetActive(false);

                        TTSJobot12.gameObject.SetActive(false);
                        TTSJobot13.gameObject.SetActive(true);
                        TTSJobot14.gameObject.SetActive(false);

                        progressTextBack.gameObject.SetActive(false);
                        camZoomOutAnim.SetBool("startStage1PlayerCamZoomOut", true);
                        StartCoroutine(DisableAllAnims());
                        forwardButtonToDisable.gameObject.SetActive(false);
                        text13Read = true;
                    }

                }



                if (currentStageOfText == 14)
                {
                    if (!text14Read)
                    {
                        // Jobotintrostage1m
                        if (!textBeenRead)
                        {
                            progressText.gameObject.SetActive(false);
                        }

                        jobotIntroStage1Section1l.gameObject.SetActive(false);
                        jobotIntroStage1Section1m.gameObject.SetActive(true);
                        jobotIntroStage1Section1n.gameObject.SetActive(false);

                        TTSJobot13.gameObject.SetActive(false);
                        TTSJobot14.gameObject.SetActive(true);
                        TTSJobot15.gameObject.SetActive(false);
                        progressTextBack.gameObject.SetActive(false);

                        if (!progressTextIsShowing)
                        { // delay 1 sconds
                            StartCoroutine(DelayProgressButtonVar2());
                            progressTextIsShowing = true;
                        }
                        text14Read = true;
                    }
                }



                if (currentStageOfText == 15)
                {
                    if (!text15Read)
                    {
                        // Jobotintrostage1n
                        if (!textBeenRead)
                        {
                            progressText.gameObject.SetActive(false);
                        }

                        jobotIntroStage1Section1m.gameObject.SetActive(false);
                        jobotIntroStage1Section1n.gameObject.SetActive(true);
                        jobotIntroStage1Section1o.gameObject.SetActive(false);

                        TTSJobot14.gameObject.SetActive(false);
                        TTSJobot15.gameObject.SetActive(true);
                        TTSJobot16.gameObject.SetActive(false);
                        progressTextBack.gameObject.SetActive(true);

                        if (!progressTextIsShowing)
                        { // delay 1 sconds
                            StartCoroutine(DelayProgressButtonVar2());
                            progressTextIsShowing = true;
                        }
                        text15Read = true;
                    }
                }



                if (currentStageOfText == 16)
                {
                    if (!text16Read)
                    {
                        if (!textBeenRead)
                        {
                            progressText.gameObject.SetActive(false);
                        }

                        jobotIntroStage1Section1n.gameObject.SetActive(false);
                        jobotIntroStage1Section1o.gameObject.SetActive(true);
                        jobotIntroStage1Section1p.gameObject.SetActive(false);

                        TTSJobot15.gameObject.SetActive(false);
                        TTSJobot16.gameObject.SetActive(true);
                        TTSJobot17.gameObject.SetActive(false);

                        taskPanal.SetActive(false);
                        if (!progressTextIsShowing)
                        { // delay 1 sconds
                            StartCoroutine(DelayProgressButtonVar2());
                            progressTextIsShowing = true;
                        }
                        text16Read = true;
                    }
                }



                if (currentStageOfText == 17)
                {
                    if (!text17Read)
                    {
                        // Jobotintrostage1p
                        if (!textBeenRead)
                        {
                            progressText.gameObject.SetActive(false);
                        }
                        progressTextBack.gameObject.SetActive(false);

                        jobotIntroStage1Section1o.gameObject.SetActive(false);
                        jobotIntroStage1Section1p.gameObject.SetActive(true);
                        jobotIntroStage1Section1q.gameObject.SetActive(false);

                        TTSJobot16.gameObject.SetActive(false);
                        TTSJobot17.gameObject.SetActive(true);
                        TTSJobot18.gameObject.SetActive(false);

                        camZoomOutAnim.keepAnimatorControllerStateOnDisable = false;
                        //  camZoomOutAnim.enabled = false;
                        camerToDisable.SetActive(false);
                        forwardButtonToDisable.gameObject.SetActive(false);
                        robotControl.enabled = true;
                        organicBoxesToHide.SetActive(true);

                        text17Read = true;
                    }
                }



                if (currentStageOfText == 18)
                {
                    if (!text18Read)
                    {
                        textPanalToHide.SetActive(true);
                        camerToDisable.SetActive(true);
                        if (!textBeenRead)
                        {
                            progressText.gameObject.SetActive(false);
                        }
                        // robotPlayerCam.enabled = false;

                        jobotIntroStage1Section1p.gameObject.SetActive(false);
                        jobotIntroStage1Section1q.gameObject.SetActive(true);
                        jobotIntroStage1Section1r.gameObject.SetActive(false);

                        TTSJobot17.gameObject.SetActive(false);
                        TTSJobot18.gameObject.SetActive(true);
                        TTSJobot19.gameObject.SetActive(false);

                        if (!progressTextIsShowing)
                        { // delay 1 sconds
                            StartCoroutine(DelayProgressButtonVar1());
                            progressTextIsShowing = true;
                        }
                        text18Read = true;
                    }
                }


                if (currentStageOfText == 19)
                {
                    if (!text19Read)
                    {
                        // Jobotintrostage1r
                        if (!textBeenRead)
                        {
                            progressText.gameObject.SetActive(false);
                        }

                        jobotIntroStage1Section1q.gameObject.SetActive(false);
                        jobotIntroStage1Section1r.gameObject.SetActive(true);

                        TTSJobot18.gameObject.SetActive(false);
                        TTSJobot19.gameObject.SetActive(true);

                        jobotIntroStage1Section1Rock.gameObject.SetActive(false);
                        jobotIntroStage1Section1Tree.gameObject.SetActive(false);

                        TTSJobotRock.gameObject.SetActive(false);
                        TTSJobotTree.gameObject.SetActive(false);

                        stage1CompleteButton.gameObject.SetActive(false);
                        stage1CompleteText.gameObject.SetActive(false);
                        camerToDisable.SetActive(false);
                        if (!progressTextIsShowing)
                        { // delay 1 sconds
                            StartCoroutine(DelayProgressButtonVar2());
                            progressTextIsShowing = true;
                        }
                        text19Read = true;
                    }
                }


                if (currentStageOfText == 20)
                {
                    if (!introReadyToBeCompleted)
                    {
                        rgMainData.stage1IntroComplete = true;
                        rgMainData.SaveIntroComplete();
                        setPeicesToDisable.SetActive(true);
                        robotPlayerCam.enabled = true;
                        robotControl.enabled = true;
                        currentStageOfText = 25;
                        organicBoxesToHide.gameObject.SetActive(false);
                        flowerCamera.enabled = false;
                        rgTextMan.enabled = false;
                        introReadyToBeCompleted = true;
                        Debug.Log("Intro Complete");
                    }
                }



                if (currentStageOfText == 21)
                {
                    if (!text21Read)
                    {
                        // --- Organic Rock item ---
                        textPanalToHide.SetActive(true);
                        camerToDisable.SetActive(true);
                        robotPlayerCam.enabled = false;


                        jobotIntroStage1Section1Rock.gameObject.SetActive(true);
                        jobotIntroStage1Section1Tree.gameObject.SetActive(false);

                        TTSJobotRock.gameObject.SetActive(true);
                        TTSJobotTree.gameObject.SetActive(false);

                        StartCoroutine(IncorrectGuess());
                        forwardButtonToDisable.gameObject.SetActive(false);

                    }
                }

                if (currentStageOfText == 22)
                {
                    if (!text22Read)
                    {
                        textPanalToHide.SetActive(true);
                        camerToDisable.SetActive(true);
                        robotPlayerCam.enabled = false;
 
                        jobotIntroStage1Section1Rock.enabled = false;
                        jobotIntroStage1Section1Tree.enabled = false;

                        TTSJobotRock.gameObject.SetActive(false);
                        TTSJobotTree.gameObject.SetActive(false);

                        forwardButtonToDisable.gameObject.SetActive(false);
                        StartCoroutine(IncorrectGuess());
                        text22Read = true;
                    }                   
                }

                if (currentStageOfText == 23)
                {
                    // --- Organic Pond item ---
                    textPanalToHide.SetActive(true);
                    camerToDisable.SetActive(true);
                    robotPlayerCam.enabled = false;
                    jobotIntroStage1Section1.enabled = false;
                    jobotIntroStage1Section1a.enabled = false;
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
                    jobotIntroStage1Section1n.enabled = false;
                    jobotIntroStage1Section1o.enabled = false;
                    jobotIntroStage1Section1p.enabled = false;
                    jobotIntroStage1Section1q.enabled = false;
                    jobotIntroStage1Section1r.enabled = false;

                    TTSJobot1.gameObject.SetActive(false);
                    TTSJobot2.gameObject.SetActive(false);
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
                    TTSJobot16.gameObject.SetActive(false);
                    TTSJobot17.gameObject.SetActive(false);
                    TTSJobot18.gameObject.SetActive(false);
                    TTSJobot19.gameObject.SetActive(false);

                    jobotIntroStage1Section1Rock.enabled = false;
                    //  jobotIntroStage1Section1GreenHouse.enabled = false;
                    //  jobotIntroStage1Section1Pond.enabled = true;
                    jobotIntroStage1Section1Tree.enabled = false;

                    TTSJobotRock.gameObject.SetActive(false);
                    //  TTSJobotGreenHouse.gameObject.SetActive(false);
                    //  TTSJobotPond.gameObject.SetActive(true);
                    TTSJobotTree.gameObject.SetActive(false); ;


                    forwardButtonToDisable.gameObject.SetActive(false);
                    StartCoroutine(IncorrectGuess());
                }


                if (currentStageOfText == 24)
                { 
                    if(!text24Read)
                    {
                        // --- Organic Tree item ---
                        camerToDisable.SetActive(true);
                        // robotPlayerCam.enabled = false;
                        textPanalToHide.gameObject.SetActive(true);
                        jobotIntroStage1Section1p.gameObject.SetActive(false);
                        TTSJobot17.gameObject.SetActive(false);

                        jobotIntroStage1Section1Tree.gameObject.SetActive(true);
                        TTSJobotTree.gameObject.SetActive(true);
                        robotPlayerCam.enabled = true;
                        robotControl.enabled = true;
                        StartCoroutine(CloseText());
                        text24Read = true;
                    }
                   
                }
                if (currentStageOfText == 25)
                {
                    // --- Organic Tree item ---
                    // textPanalToHide.SetActive(false);
                    textPanalToHide.SetActive(false);
                    endStage1PanalToHide.SetActive(false);
                    jobotIntroStage1Section1.enabled = false;
                    jobotIntroStage1Section1a.enabled = false;
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
                    jobotIntroStage1Section1n.enabled = false;
                    jobotIntroStage1Section1o.enabled = false;
                    jobotIntroStage1Section1p.enabled = false;
                    jobotIntroStage1Section1q.enabled = false;
                    jobotIntroStage1Section1r.enabled = false;

                    TTSJobot1.gameObject.SetActive(false);
                    TTSJobot2.gameObject.SetActive(false);
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
                    TTSJobot16.gameObject.SetActive(false);
                    TTSJobot17.gameObject.SetActive(false);
                    TTSJobot18.gameObject.SetActive(false);
                    TTSJobot19.gameObject.SetActive(false);

                    jobotIntroStage1Section1Rock.enabled = false;
                    jobotIntroStage1Section1Tree.enabled = false;
                    stage1CompleteButton.gameObject.SetActive(false);
                    stage1CompleteText.gameObject.SetActive(false);
                    TTSJobotRock.gameObject.SetActive(false);
                    TTSJobotTree.gameObject.SetActive(false);
                }

                if (currentStageOfText == 26)
                {
                    // --- Organic Tree item ---
                    //camerToDisable.SetActive(true);
                    // robotPlayerCam.enabled = false;
                    endStage1PanalToHide.SetActive(true);
                    // organicBoxesToHide.gameObject.SetActive(false);
                    jobotIntroStage1Section1.enabled = false;
                    jobotIntroStage1Section1a.enabled = false;
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
                    jobotIntroStage1Section1n.enabled = false;
                    jobotIntroStage1Section1o.enabled = false;
                    jobotIntroStage1Section1p.enabled = false;
                    jobotIntroStage1Section1q.enabled = false;
                    jobotIntroStage1Section1r.enabled = false;

                    TTSJobot1.gameObject.SetActive(false);
                    TTSJobot2.gameObject.SetActive(false);
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
                    TTSJobot16.gameObject.SetActive(false);
                    TTSJobot17.gameObject.SetActive(false);
                    TTSJobot18.gameObject.SetActive(false);
                    TTSJobot19.gameObject.SetActive(false);

                    jobotIntroStage1Section1Rock.enabled = false;
                    jobotIntroStage1Section1Tree.enabled = false;
                    stage1CompleteButton.gameObject.SetActive(true);
                    stage1CompleteText.gameObject.SetActive(true);
                    TTSJobotRock.gameObject.SetActive(false);
                    TTSJobotTree.gameObject.SetActive(false);


                    StartCoroutine(CloseText2());
                }

            }
        }






                void OnClick()
                {
                    textBeenRead = false;
                    progressTextIsShowing = false;
                    currentStageOfText++;
                    robotControl.NewNavmeshStop();
                }

                void OnClickBack()
                {
                    currentStageOfText--;
                    textBeenRead = false;
                    text1Read = false;
                    text2Read = false;
                    text3Read = false;
                    text4Read = false;
                    text5Read = false;
                    text6Read = false;
                    text7Read = false;
                    text8Read = false;
                    text9Read = false;
                    text10Read = false;
                    text11Read = false;
                    text12Read = false;
                    text13Read = false;
                    text14Read = false;
                    text15Read = false;
                    text16Read = false;
                    text17Read = false;
                    text18Read = false;
                    text19Read = false;
                    progressTextIsShowing = false;
                }

                void JobotStage1Section1()
                {
                    LOLSDK.Instance.SpeakText("jobotIntroStage1");
                    Debug.Log("Button is pressed");
                }

                void JobotStage1Section1a()
                {
                    LOLSDK.Instance.SpeakText("jobotIntroStage1a");
                }

                void JobotStage1Section1b()
                {
                    LOLSDK.Instance.SpeakText("jobotIntroStage1b");
                }

                void JobotStage1Section1c()
                {
                    LOLSDK.Instance.SpeakText("jobotIntroStage1c");
                }

                void JobotStage1Section1d()
                {
                    LOLSDK.Instance.SpeakText("jobotIntroStage1d");
                }

                void JobotStage1Section1e()
                {
                    LOLSDK.Instance.SpeakText("jobotIntroStage1e");
                }

                void JobotStage1Section1f()
                {
                    LOLSDK.Instance.SpeakText("jobotIntroStage1f");
                }

                void JobotStage1Section1g()
                {
                    LOLSDK.Instance.SpeakText("jobotIntroStage1g");
                }

                void JobotStage1Section1h()
                {
                    LOLSDK.Instance.SpeakText("jobotIntroStage1h");
                }
                void JobotStage1Section1i()
                {
                    LOLSDK.Instance.SpeakText("jobotIntroStage1i");
                }

                void JobotStage1Section1j()
                {
                    LOLSDK.Instance.SpeakText("jobotIntroStage1jChooseName");
                }

                void JobotStage1Section1k()
                {
                    LOLSDK.Instance.SpeakText("jobotIntroStage1k");
                }

                void JobotStage1Section1l()
                {
                    LOLSDK.Instance.SpeakText("jobotIntroStage1l");
                }

                void JobotStage1Section1m()
                {
                    LOLSDK.Instance.SpeakText("jobotIntroStage1m");
                }

                void JobotStage1Section1n()
                {
                    LOLSDK.Instance.SpeakText("jobotIntroStage1n");
                }
                void JobotStage1Section1o()
                {
                    LOLSDK.Instance.SpeakText("jobotIntroStage1o");
                }

                void JobotStage1Section1p()
                {
                    LOLSDK.Instance.SpeakText("jobotIntroStage1p");
                }

                void JobotStage1Section1q()
                {
                    LOLSDK.Instance.SpeakText("jobotIntroStage1q");
                }

                void JobotStage1Section1r()
                {
                    LOLSDK.Instance.SpeakText("jobotIntroStage1r");
                    Debug.Log("jobotIntroStage1r is playing");
                }

                void JobotStage1Section1Rock()
                {
                    LOLSDK.Instance.SpeakText("stage1NonOrganicItemRock");
                }



                void JobotStage1Section1Tree()
                {
                    LOLSDK.Instance.SpeakText("stage1OrganicItemTree");
                }




                public void StartTextProcessStage1()
                {
                    currentStageOfText = 1;
                }

                public IEnumerator EnablePond()
                {
                    yield return new WaitForSeconds(2);


                }

                public IEnumerator CloseText()
                {
                    yield return new WaitForSeconds(3);
                    currentStageOfText = 19;

                }

                public IEnumerator CloseText2()
                {
                    yield return new WaitForSeconds(3);
                    currentStageOfText = 25;

                }

                public IEnumerator IncorrectGuess()
                {
                    yield return new WaitForSeconds(1);
                    robotPlayerCam.enabled = true;
                    robotControl.enabled = true;
                    organicBoxesToHide.SetActive(true);
                    // textPanalToHide.SetActive(false);
                    currentStageOfText = 17;

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
                    closeDoor.SetBool("doorNeedsToBeOpen", false);
                    closeDoor.SetBool("closeDoor", false);
                    closeDoor.SetTrigger("resetDoorValues");

                }
    }
}
    
