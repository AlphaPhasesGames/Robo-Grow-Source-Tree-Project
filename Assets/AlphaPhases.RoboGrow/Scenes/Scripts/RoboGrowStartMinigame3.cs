using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AI;
using LoLSDK;
namespace Alpha.Phases.Robo.Grow
{
    public class RoboGrowStartMinigame3 : MonoBehaviour
    {
        //public GameObject textPanal;

        public RobotController robCont;
        public GameObject navMeshRobotToStop;
        public RoboGrowMain rgMain;
        public GameObject stamenStigmaDiagram;
        public RoboGrowTextBoxManagerStage3 textMan3;
        public ButterFlyPlayerController butterePlayerCont;
        public GameObject hint10;
        public AudioSource wingFlapSFX; 

        public Camera treeCamera;
        public Camera playerCamera;
        public Camera butterflyCamera;

        public GameObject butterFlyCharacter;
        public GameObject robotCharacter;

        public bool hasSusanPopped;
        public bool hasLimaBeanPopped;
        public bool hasDiasyPopped;
        public bool hasradishPopped;

        public bool disableAndEnablePause;

        public bool hasSavingHappenBefore;

        public bool textBeenRead;
        public bool progressTextIsShowing;

        public GameObject textPanal;
        public GameObject textPanalTest;

        public GameObject susanPollenIndicatorArrows;
        public GameObject limaPollenIndicatorArrows;
        public GameObject daisyPollenIndicatorArrows;
        public GameObject radishPollenIndicatorArrows;

        public GameObject susanPollenCollection1;
      //  public GameObject susanPollenCollection2;
        public GameObject limaPollenCollection;
        public GameObject daisyPollenCollection;
        public GameObject radishPollenCollection;

        public GameObject treeTriggerArrow;

        public Button progressText;
        public Button progressTextBack;

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
        public bool textRead15;
        public bool textRead16;
        public bool textRead17;
        public bool textRead18;
        public bool textRead19;
        public bool textRead20;





        public Button TTSJobotStage3Tree;
        public Button TTSJobotStage3Treea;
     //   public Button TTSJobotStage3Treeb;
        public Button TTSJobotStage3Treec;
        public Button TTSJobotStage3Treed;
        public Button TTSJobotStage3TreedControls;
        public Button TTSJobotStage3TreedGameplayExplaination;
        public Button TTSJobotStage3Treee;
        public Button TTSJobotStage3Treef;
        public Button TTSJobotStage3Treeg;
        public Button TTSJobotStage3Treeh;
        public Button TTSJobotStage3Treei;
     //   public Button TTSJobotStage3Treej;
        public Button TTSJobotStage3Treek;
     //   public Button TTSJobotStage3Treel;
        public Button TTSJobotStage3Treem;
       // public Button TTSJobotStage3Treen;
        public Button TTSJobotStage3Treeo;
        public Button TTSJobotStage3Treep;
        public Button TTSJobotStage3Treeq;
        public Button TTSJobotStage3Treer;
        public Button TTSJobotStage3Trees;

        public TextMeshProUGUI jobotJobotStage3TreeText;
        public TextMeshProUGUI jobotJobotStage3TreeTexta;
    //    public TextMeshProUGUI jobotJobotStage3TreeTextb;
        public TextMeshProUGUI jobotJobotStage3TreeTextc;
        public TextMeshProUGUI jobotJobotStage3TreeTextd;
        public TextMeshProUGUI jobotJobotStage3TreeTextdControls;
        public TextMeshProUGUI jobotJobotStage3TreeTextdGamePlayExplaination;
        public TextMeshProUGUI jobotJobotStage3TreeTexte;
        public TextMeshProUGUI jobotJobotStage3TreeTextf;
        public TextMeshProUGUI jobotJobotStage3TreeTextg;
        public TextMeshProUGUI jobotJobotStage3TreeTexth;
        public TextMeshProUGUI jobotJobotStage3TreeTexti;
       // public TextMeshProUGUI jobotJobotStage3TreeTextj;
        public TextMeshProUGUI jobotJobotStage3TreeTextk;
     //   public TextMeshProUGUI jobotJobotStage3TreeTextl;
        public TextMeshProUGUI jobotJobotStage3TreeTextm;
     //   public TextMeshProUGUI jobotJobotStage3TreeTextn;
        public TextMeshProUGUI jobotJobotStage3TreeTexto;
        public TextMeshProUGUI jobotJobotStage3TreeTextp;
        public TextMeshProUGUI jobotJobotStage3TreeTextq;
        public TextMeshProUGUI jobotJobotStage3TreeTextr;
        public TextMeshProUGUI jobotJobotStage3TreeTexts;

        public int currentStage3TreeText;

        public GameObject susanArrowToReset;
        public GameObject susan2ArrowToReset;
        public GameObject limaArrowToReset;
        public GameObject lima2ArrowToReset;
        public GameObject daisyArrowToReset;
        public GameObject daisy2ArrowToReset;
        public GameObject radishArrowToReset;
        public GameObject radish2ArrowToReset;

        public GameObject susanPollenSlider;
        public GameObject limaBeannPollenSlider;
        public GameObject daisyPollenSlider;
        public GameObject radishPollenSlider;
        public GameObject minigamePanal;

        public GameObject susanPollenArrows;
        public GameObject susanTargetnArrows;

        public GameObject limaPollenArrows;
        public GameObject limaTargetnArrows;

        public GameObject daisyPollenArrows;
        public GameObject daisyTargetnArrows;

        public GameObject radishPollenArrows;
        public GameObject radishTargetnArrows;

        private void Awake()
        {
            //susanPollenSlider.SetActive(false);
            currentStage3TreeText = 0;
            minigamePanal.SetActive(false);
            stamenStigmaDiagram.SetActive(false);
            progressText.onClick.AddListener(OnClick);
            progressTextBack.onClick.AddListener(OnClickBack);
            butterflyCamera.enabled = false;
            TTSJobotStage3Tree.onClick.AddListener(JobotStage3TreeMG1);
            TTSJobotStage3Treea.onClick.AddListener(JobotStage3TreeMG2);
      //      TTSJobotStage3Treeb.onClick.AddListener(JobotStage3TreeMG3);
            TTSJobotStage3Treec.onClick.AddListener(JobotStage3TreeMG4);
            TTSJobotStage3Treed.onClick.AddListener(JobotStage3TreeMG5);
            TTSJobotStage3TreedControls.onClick.AddListener(JobotStage3TreeMG5a);
            TTSJobotStage3TreedGameplayExplaination.onClick.AddListener(JobotStage3TreeMG5b);
            TTSJobotStage3Treee.onClick.AddListener(JobotStage3TreeMG6);
            TTSJobotStage3Treef.onClick.AddListener(JobotStage3TreeMG7);
            TTSJobotStage3Treeg.onClick.AddListener(JobotStage3TreeMG8);
            TTSJobotStage3Treeh.onClick.AddListener(JobotStage3TreeMG9);
            TTSJobotStage3Treei.onClick.AddListener(JobotStage3TreeMG10);
        //    TTSJobotStage3Treej.onClick.AddListener(JobotStage3TreeMG11);
            TTSJobotStage3Treek.onClick.AddListener(JobotStage3TreeMG12);
      //      TTSJobotStage3Treel.onClick.AddListener(JobotStage3TreeMG13);
            TTSJobotStage3Treem.onClick.AddListener(JobotStage3TreeMG14);
        //    TTSJobotStage3Treen.onClick.AddListener(JobotStage3TreeMG14FirstPollenCollected);
            TTSJobotStage3Treeo.onClick.AddListener(JobotStage3Tree15SusanPollenCollected);
            TTSJobotStage3Treep.onClick.AddListener(JobotStage3TreeMG16LimaBeanCollected);
            TTSJobotStage3Treeq.onClick.AddListener(JobotStage3TreeMG17DaisyPollenCollected);
            TTSJobotStage3Treer.onClick.AddListener(JobotStage3Tree18RadishPollenCollected);
            TTSJobotStage3Trees.onClick.AddListener(JobotStage3TreeMG19AllPlantPollinated);

            susanPollenCollection1.gameObject.SetActive(false);
           // susanPollenCollection2.gameObject.SetActive(false);
            limaPollenCollection.gameObject.SetActive(false);
            daisyPollenCollection.gameObject.SetActive(false);
            radishPollenCollection.gameObject.SetActive(false);

    }



        // Update is called once per frame
        void Update()
        {

            if (currentStage3TreeText == 1)
            {
                if (!textRead1)
                {
                    if (!textBeenRead)
                    {
                        progressText.gameObject.SetActive(false);
                    }
                    minigamePanal.gameObject.SetActive(true);

                    progressTextBack.gameObject.SetActive(false);
                    textPanal.SetActive(true);
                    butterFlyCharacter.gameObject.SetActive(true);
                    butterePlayerCont.enabled = false;
                    jobotJobotStage3TreeText.gameObject.SetActive(true);
                    jobotJobotStage3TreeTexta.gameObject.SetActive(false);

                    susanPollenCollection1.gameObject.SetActive(true);
                    limaPollenCollection.gameObject.SetActive(true);
                    daisyPollenCollection.gameObject.SetActive(true);
                    radishPollenCollection.gameObject.SetActive(true);

                    susanPollenArrows.gameObject.SetActive(true);
                    limaPollenArrows.gameObject.SetActive(true);
                    daisyPollenArrows.gameObject.SetActive(true);
                    radishPollenArrows.gameObject.SetActive(true);

                    if (!progressTextIsShowing)
                    { // 3 second delay
                        StartCoroutine(DelayProgressButtonVar1());
                        progressTextIsShowing = true;
                    }
                    textRead1 = true;
                } 

            }

            if (currentStage3TreeText == 2)
            {
                if (!textRead2)
                {
                    if (!textBeenRead)
                    {
                        progressText.gameObject.SetActive(false);
                    }
                    progressTextBack.gameObject.SetActive(true);
                    textPanal.SetActive(true);
                    jobotJobotStage3TreeText.gameObject.SetActive(false);
                    jobotJobotStage3TreeTexta.gameObject.SetActive(true);
                    //         jobotJobotStage3TreeTextb.enabled = false;
                    jobotJobotStage3TreeTextc.gameObject.SetActive(false);
                    if (!progressTextIsShowing)
                    { // 3 second delay
                        StartCoroutine(DelayProgressButtonVar1());
                        progressTextIsShowing = true;
                    }
                    textRead2 = true;
                }
           
            }

            if (currentStage3TreeText == 3)
            {
                if (!textRead3)
                {
                    if (!textBeenRead)
                    {
                        progressText.gameObject.SetActive(false);
                    }

                    jobotJobotStage3TreeTexta.gameObject.SetActive(false);
                    //       jobotJobotStage3TreeTextb.enabled = false;
                    jobotJobotStage3TreeTextc.gameObject.SetActive(true);
                    jobotJobotStage3TreeTextd.gameObject.SetActive(false);

                    if (!progressTextIsShowing)
                    { // 3 second delay
                        StartCoroutine(DelayProgressButtonVar1());
                        progressTextIsShowing = true;
                    }
                    textRead3 = true;
                }
              
            }

            if (currentStage3TreeText == 4)
            {
                if (!textRead4)
                {
                    if (!textBeenRead)
                    {
                        progressText.gameObject.SetActive(false);
                    }
                   // jobotJobotStage3TreeTexta.gameObject.SetActive(false);
                    jobotJobotStage3TreeTextc.gameObject.SetActive(false);
                    jobotJobotStage3TreeTextd.gameObject.SetActive(true);
                    jobotJobotStage3TreeTextdControls.gameObject.SetActive(false);

                    if (!progressTextIsShowing)
                    { // 3 second delay
                        StartCoroutine(DelayProgressButtonVar2());
                        progressTextIsShowing = true;
                    }
                    textRead4 = true;
                }
               
            }

            if (currentStage3TreeText == 5)
            {

                if (!textRead5)
                {
                    progressText.gameObject.SetActive(false);

                    jobotJobotStage3TreeTextd.gameObject.SetActive(false);
                    jobotJobotStage3TreeTextdControls.gameObject.SetActive(true);
                    jobotJobotStage3TreeTextdGamePlayExplaination.gameObject.SetActive(false);

                    if (!disableAndEnablePause)
                    {
                        StartCoroutine(HideTxtEnablePlayer());
                        disableAndEnablePause = true;
                    }
                    textRead5 = true;
                } 
            }

            if (currentStage3TreeText == 6)
            {
                if (!textRead6)
                {
                    if (!textBeenRead)
                    {
                        progressText.gameObject.SetActive(false);
                    }
                    // textPanal.SetActive(true);
                    butterePlayerCont.enabled = false;

                    jobotJobotStage3TreeTextdControls.gameObject.SetActive(false);
                    jobotJobotStage3TreeTextdGamePlayExplaination.gameObject.SetActive(true);
                    jobotJobotStage3TreeTexte.gameObject.SetActive(false);

                    if (!progressTextIsShowing)
                    { // 3 second delay
                        StartCoroutine(DelayProgressButtonVar1());
                        progressTextIsShowing = true;
                    }
                    textRead6 = true;
                }
             
            }


            if (currentStage3TreeText == 7)
            {
                if (!textRead7)
                {
                    if (!textBeenRead)
                    {
                        progressText.gameObject.SetActive(false);
                    }

                    jobotJobotStage3TreeTextdGamePlayExplaination.gameObject.SetActive(false);
                    jobotJobotStage3TreeTexte.gameObject.SetActive(true);
                    jobotJobotStage3TreeTextf.gameObject.SetActive(false);

                    if (!progressTextIsShowing)
                    { // 3 second delay
                        StartCoroutine(DelayProgressButtonVar2());
                        progressTextIsShowing = true;
                    }
                    textRead7 = true;
                }

            }
            if (currentStage3TreeText == 8)
            {
                if (!textRead8)
                {
                    if (!textBeenRead)
                    {
                        progressText.gameObject.SetActive(false);
                    }

                    jobotJobotStage3TreeTexte.gameObject.SetActive(false);
                    jobotJobotStage3TreeTextf.gameObject.SetActive(true);
                    jobotJobotStage3TreeTextg.gameObject.SetActive(false);

                    if (!progressTextIsShowing)
                    { // 3 second delay
                        StartCoroutine(DelayProgressButtonVar2());
                        progressTextIsShowing = true;
                    }
                    textRead8 = true;
                }
                
            }

            if (currentStage3TreeText == 9)
            {
                if (!textRead9)
                {
                    if (!textBeenRead)
                    {
                        progressText.gameObject.SetActive(false);
                    }
                    stamenStigmaDiagram.gameObject.SetActive(true);
                    stamenStigmaDiagram.SetActive(true);

                    jobotJobotStage3TreeTextf.gameObject.SetActive(false);
                    jobotJobotStage3TreeTextg.gameObject.SetActive(true);
                    jobotJobotStage3TreeTexth.gameObject.SetActive(false);

                    if (!progressTextIsShowing)
                    { // 3 second delay
                        StartCoroutine(DelayProgressButtonVar1());
                        progressTextIsShowing = true;
                    }
                    textRead9 = true;
                }
              
            }

            if (currentStage3TreeText == 10)
            {
                if (!textRead10)
                {
                    if (!textBeenRead)
                    {
                        progressText.gameObject.SetActive(false);
                    }
                    // minigamePanal.gameObject.SetActive(true);

                    jobotJobotStage3TreeTextg.gameObject.SetActive(false);
                    jobotJobotStage3TreeTexth.gameObject.SetActive(true);
                    jobotJobotStage3TreeTexti.gameObject.SetActive(false);

                    if (!progressTextIsShowing)
                    { // 3 second delay
                        StartCoroutine(DelayProgressButtonVar2());
                        progressTextIsShowing = true;
                    }
                    textRead10 = true;
                }
              
            }

            if (currentStage3TreeText == 11)
            {
                if (!textRead11)
                {
                    if (!textBeenRead)
                    {
                        progressText.gameObject.SetActive(false);
                    }

                    jobotJobotStage3TreeTexth.gameObject.SetActive(false);
                    jobotJobotStage3TreeTexti.gameObject.SetActive(true);
                    //    jobotJobotStage3TreeTextj.enabled = false;
                    jobotJobotStage3TreeTextk.gameObject.SetActive(false);

                    if (!progressTextIsShowing)
                    { // 3 second delay
                        StartCoroutine(DelayProgressButtonVar1());
                        progressTextIsShowing = true;
                    }
                    textRead11 = true;
                }
               
            }
          
            if (currentStage3TreeText == 12)
            {
                if (!textRead12)
                {
                    if (!textBeenRead)
                    {
                        progressText.gameObject.SetActive(false);
                    }

                    jobotJobotStage3TreeTexti.gameObject.SetActive(false);
                    jobotJobotStage3TreeTextk.gameObject.SetActive(true);
                    jobotJobotStage3TreeTextm.gameObject.SetActive(false);
                    if (!progressTextIsShowing)
                    { // 3 second delay
                        StartCoroutine(DelayProgressButtonVar2());
                        progressTextIsShowing = true;
                    }
                    textRead12 = true;
                }
             

            }
    
            if (currentStage3TreeText == 13)
            {
                if (!textRead13)
                {
                    if (!textBeenRead)
                    {
                        progressText.gameObject.SetActive(false);
                    }
                    stamenStigmaDiagram.gameObject.SetActive(false);
                    butterePlayerCont.enabled = true;

                    jobotJobotStage3TreeTextk.gameObject.SetActive(false);
                    jobotJobotStage3TreeTextm.gameObject.SetActive(true);
                    jobotJobotStage3TreeTexto.gameObject.SetActive(false);

                    StartCoroutine(CloseTextPanal());
                    textRead13 = true;
                }
            }
            
            if (currentStage3TreeText == 17)
            {
                if (!textRead14)
                {
                    textPanal.SetActive(false);
                    jobotJobotStage3TreeText.gameObject.SetActive(false);
                    jobotJobotStage3TreeTexta.gameObject.SetActive(false);
                    //   jobotJobotStage3TreeTextb.enabled = false;
                    jobotJobotStage3TreeTextc.gameObject.SetActive(false);
                    jobotJobotStage3TreeTextd.gameObject.SetActive(false);
                    jobotJobotStage3TreeTextdControls.gameObject.SetActive(false);
                    jobotJobotStage3TreeTextdGamePlayExplaination.gameObject.SetActive(false);
                    jobotJobotStage3TreeTexte.gameObject.SetActive(false);
                    jobotJobotStage3TreeTextf.gameObject.SetActive(false);
                    jobotJobotStage3TreeTextg.gameObject.SetActive(false);
                    jobotJobotStage3TreeTexth.gameObject.SetActive(false);
                    jobotJobotStage3TreeTexti.gameObject.SetActive(false);
                    //      jobotJobotStage3TreeTextj.enabled = false;
                    jobotJobotStage3TreeTextk.gameObject.SetActive(false);
                    //      jobotJobotStage3TreeTextl.enabled = false;
                    jobotJobotStage3TreeTextm.gameObject.SetActive(false);
                    //       jobotJobotStage3TreeTextn.enabled = false;
                    jobotJobotStage3TreeTexto.gameObject.SetActive(false);
                    jobotJobotStage3TreeTextp.gameObject.SetActive(false);
                    jobotJobotStage3TreeTextq.gameObject.SetActive(false);
                    jobotJobotStage3TreeTextr.gameObject.SetActive(false);
                    jobotJobotStage3TreeTexts.gameObject.SetActive(false);

                    textRead14 = true;
                }
              
            }
            
            if (currentStage3TreeText == 18)
            {
                if (!textRead15)
                {
                    textPanal.SetActive(true);

                    jobotJobotStage3TreeTextm.gameObject.SetActive(false);
                    jobotJobotStage3TreeTexto.gameObject.SetActive(true);
                    jobotJobotStage3TreeTextp.gameObject.SetActive(false);

                    StartCoroutine(CloseTextPanal());
                    progressText.gameObject.SetActive(false);
                    textRead15 = true;
                }
             
            }


        

            if (currentStage3TreeText == 19)
            {
                if (textRead16)
                {
                    if (!hasLimaBeanPopped)
                    {
                        textPanal.SetActive(true);
                        hasLimaBeanPopped = true;

                        jobotJobotStage3TreeTexto.gameObject.SetActive(false);
                        jobotJobotStage3TreeTextp.gameObject.SetActive(true);
                        jobotJobotStage3TreeTextq.gameObject.SetActive(false);

                        StartCoroutine(CloseTextPanal());
                        progressText.gameObject.SetActive(false);
                        textRead16 = true;
                    }
                }
            }

            if (currentStage3TreeText == 20)
            {
                if (!textRead17)
                {
                    if (!hasDiasyPopped)
                    {
                        textPanal.SetActive(true);
                        hasDiasyPopped = true;
                  
                        jobotJobotStage3TreeTextp.gameObject.SetActive(false);
                        jobotJobotStage3TreeTextq.gameObject.SetActive(true);
                        jobotJobotStage3TreeTextr.gameObject.SetActive(false);

                        StartCoroutine(CloseTextPanal());
                        progressText.gameObject.SetActive(false);
                        textRead17 = true;
                    }
                }
            }

            if (currentStage3TreeText == 21)
            {
                if (!textRead18)
                {
                    if (!hasradishPopped)
                    {
                        textPanal.SetActive(true);
                        hasradishPopped = true;
                     
                        jobotJobotStage3TreeTextq.gameObject.SetActive(false);
                        jobotJobotStage3TreeTextr.gameObject.SetActive(true);
                        jobotJobotStage3TreeTexts.gameObject.SetActive(false);

                        StartCoroutine(CloseTextPanal());
                        progressText.gameObject.SetActive(false);
                        textRead18 = true;
                    }
                }
            }

            if (currentStage3TreeText == 22)
            {
                if (!textRead19)
                {
                    textPanal.SetActive(true);
               
                    jobotJobotStage3TreeTextr.gameObject.SetActive(false);
                    jobotJobotStage3TreeTexts.gameObject.SetActive(true);

                    butterFlyCharacter.SetActive(false);

                    wingFlapSFX.Stop();
                    butterePlayerCont.enabled = false;
                    playerCamera.enabled = true;

                    progressText.gameObject.SetActive(false);
                    robCont.enabled = true;
                    // susanPollenSlider.SetActive(false);
                    // limaBeannPollenSlider.SetActive(false);
                    //  daisyPollenSlider.SetActive(false);
                    //  radishPollenSlider.SetActive(false);
                    minigamePanal.gameObject.SetActive(false);
                    susanPollenIndicatorArrows.gameObject.SetActive(false);
                    limaPollenIndicatorArrows.gameObject.SetActive(false);
                    daisyPollenIndicatorArrows.gameObject.SetActive(false);
                    radishPollenIndicatorArrows.gameObject.SetActive(false);

                    susanArrowToReset.gameObject.SetActive(true);
                    susan2ArrowToReset.gameObject.SetActive(true);
                    limaArrowToReset.gameObject.SetActive(true);
                    lima2ArrowToReset.gameObject.SetActive(true);
                    daisyArrowToReset.gameObject.SetActive(true);
                    daisy2ArrowToReset.gameObject.SetActive(true);
                    radish2ArrowToReset.gameObject.SetActive(true);
                    radishArrowToReset.gameObject.SetActive(true);
                    navMeshRobotToStop.GetComponent<NavMeshAgent>().isStopped = false;

                    if (!hasSavingHappenBefore)
                    {
                        StartCoroutine(CloseTextPanalFinal());
                        hasSavingHappenBefore = true;
                    }
                    textRead19 = true;

                }

            }

            if (currentStage3TreeText == 23)
            {
                if (!textRead20)
                {
                    textPanal.SetActive(false);

                    jobotJobotStage3TreeTextp.gameObject.SetActive(false);
                    jobotJobotStage3TreeTextq.gameObject.SetActive(false);
                    jobotJobotStage3TreeTextr.gameObject.SetActive(false);
                    jobotJobotStage3TreeTexts.gameObject.SetActive(false);

                    textRead20 = true;
                }
               
               

            }
        }


       


        void OnClick()
        {
            currentStage3TreeText++;
            textBeenRead = false;
            progressTextIsShowing = false;
        }

        void OnClickBack()
        {
            currentStage3TreeText--;
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
            textRead15 = false;
            textRead16 = false;
            textRead17 = false;
            textRead18 = false;
            textRead19 = false;
            textRead20 = false;





        }

        void JobotStage3TreeMG1()
        {
            LOLSDK.Instance.SpeakText("jobotStage3Butterfly1");
        }

        void JobotStage3TreeMG2()
        {
            LOLSDK.Instance.SpeakText("jobotStage3Butterfly1a");
        }

        void JobotStage3TreeMG3()
        {
            LOLSDK.Instance.SpeakText("jobotStage3Butterfly1b");
        }
        void JobotStage3TreeMG4()
        {
            LOLSDK.Instance.SpeakText("jobotStage3Butterfly1c");
        }

        void JobotStage3TreeMG5()
        {
            LOLSDK.Instance.SpeakText("jobotStage3Butterfly1d");
        }

        void JobotStage3TreeMG5a()
        {
            LOLSDK.Instance.SpeakText("jobotStage3Butterfly1dControls");
        }

        void JobotStage3TreeMG5b()
        {
            
            LOLSDK.Instance.SpeakText("jobotStage3Butterfly1dGameplay");
        }

        void JobotStage3TreeMG6()
        {
            LOLSDK.Instance.SpeakText("jobotStage3Butterfly1e");

        }
        void JobotStage3TreeMG7()
        {
            LOLSDK.Instance.SpeakText("jobotStage3Butterfly1f");

        }

        void JobotStage3TreeMG8()
        {
            LOLSDK.Instance.SpeakText("jobotStage3Butterfly1fa");

        }

        void JobotStage3TreeMG9()
        {
            LOLSDK.Instance.SpeakText("jobotStage3Butterfly1g");

        }

        void JobotStage3TreeMG10()
        {
            LOLSDK.Instance.SpeakText("jobotStage3Butterfly1h");
        }

        void JobotStage3TreeMG11()
        {
            LOLSDK.Instance.SpeakText("jobotStage3Butterfly1ha");
        }
        void JobotStage3TreeMG12()
        {
            LOLSDK.Instance.SpeakText("jobotStage3Butterfly1i");
        }

        void JobotStage3TreeMG13()
        {
            LOLSDK.Instance.SpeakText("jobotStage3Butterfly1j");
        }
        void JobotStage3TreeMG14()
        {
            LOLSDK.Instance.SpeakText("jobotStage3Butterfly1k");
        }

        void JobotStage3TreeMG14FirstPollenCollected()
        {
            LOLSDK.Instance.SpeakText("jobotStage3Butterfly1WellDone");

        }
        void JobotStage3Tree15SusanPollenCollected()
        {
            LOLSDK.Instance.SpeakText("jobotStage3Butterfly1WellDoneSusanPollen");

        }

        void JobotStage3TreeMG16LimaBeanCollected()
        {
            LOLSDK.Instance.SpeakText("jobotStage3Butterfly1WellDoneLimaBeanPollen");

        }

        void JobotStage3TreeMG17DaisyPollenCollected()
        {
            LOLSDK.Instance.SpeakText("jobotStage3Butterfly1WellDoneDaisyPollen");

        }

        void JobotStage3Tree18RadishPollenCollected()
        {
            LOLSDK.Instance.SpeakText("jobotStage3Butterfly1WellDoneRadishPollen");

        }

        void JobotStage3TreeMG19AllPlantPollinated()
        {
            LOLSDK.Instance.SpeakText("jobotStage3ButterflyPlantsPollinated");

        }


        public IEnumerator CloseTextPanal()
        {
            textRead14 = false;
            yield return new WaitForSeconds(3);
            currentStage3TreeText = 17;
           
        }
  
        public void CloseTextPanalText()
        {

            textPanal.gameObject.SetActive(false);


        }
        

        public IEnumerator CloseTextPanalFinal()
        {
           // CloseTextPanalText();
            yield return new WaitForSeconds(5f);
         //   textPanalTest.gameObject.SetActive(true);
            currentStage3TreeText = 23;
           // textMan3.currentStageOfText = 17;
            //textPanalTest.gameObject.SetActive(false);
            textPanal.gameObject.SetActive(false);
            rgMain.stage3TreeminigGameComplete = true;
            rgMain.SaveStage3MiniGameComplete();
    


        }
        

        public IEnumerator PollenSusanCollected()
        {
            currentStage3TreeText = 17;
            textPanalTest.SetActive(true);
            // inGameCanvas.SetActive(true);
            yield return new WaitForSeconds(5);
            textPanalTest.SetActive(false);


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

        public IEnumerator HideTxtEnablePlayer()
        {
           
            butterePlayerCont.enabled = true;
           // textPanal.SetActive(false);
            yield return new WaitForSeconds(10);
            currentStage3TreeText = 6;
        }
    }
}
