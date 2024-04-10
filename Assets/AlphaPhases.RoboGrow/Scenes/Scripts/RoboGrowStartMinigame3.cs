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

        // Start is called before the first frame update
        void Start()
        {
            textPanal.SetActive(false);
            jobotJobotStage3TreeText.enabled = false;
            jobotJobotStage3TreeTexta.enabled = false;
        //    jobotJobotStage3TreeTextb.enabled = false;
            jobotJobotStage3TreeTextc.enabled = false;
            jobotJobotStage3TreeTextdControls.enabled = false;
            jobotJobotStage3TreeTextdGamePlayExplaination.enabled = false;
            jobotJobotStage3TreeTextd.enabled = false;
            jobotJobotStage3TreeTexte.enabled = false;
            jobotJobotStage3TreeTextf.enabled = false;
            jobotJobotStage3TreeTextg.enabled = false;
            jobotJobotStage3TreeTexth.enabled = false;
            jobotJobotStage3TreeTexti.enabled = false;
       //     jobotJobotStage3TreeTextj.enabled = false;
            jobotJobotStage3TreeTextk.enabled = false;
      //      jobotJobotStage3TreeTextl.enabled = false;
            jobotJobotStage3TreeTextm.enabled = false;
      //      jobotJobotStage3TreeTextn.enabled = false;
            jobotJobotStage3TreeTexto.enabled = false;
            jobotJobotStage3TreeTextp.enabled = false;
            jobotJobotStage3TreeTextq.enabled = false;
            jobotJobotStage3TreeTextr.enabled = false;
            jobotJobotStage3TreeTexts.enabled = false;
        }

        // Update is called once per frame
        void Update()
        {

            if (currentStage3TreeText == 1)
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
                jobotJobotStage3TreeText.enabled = true;
                jobotJobotStage3TreeTexta.enabled = false;
         //       jobotJobotStage3TreeTextb.enabled = false;
                jobotJobotStage3TreeTextc.enabled = false;
                jobotJobotStage3TreeTextd.enabled = false;
                jobotJobotStage3TreeTextdControls.enabled = false;
                jobotJobotStage3TreeTextdGamePlayExplaination.enabled = false;
                jobotJobotStage3TreeTexte.enabled = false;
                jobotJobotStage3TreeTextf.enabled = false;
                jobotJobotStage3TreeTextg.enabled = false;
                jobotJobotStage3TreeTexth.enabled = false;
                jobotJobotStage3TreeTexti.enabled = false;
         //       jobotJobotStage3TreeTextj.enabled = false;
                jobotJobotStage3TreeTextk.enabled = false;
        //        jobotJobotStage3TreeTextl.enabled = false;
                jobotJobotStage3TreeTextm.enabled = false;
        //        jobotJobotStage3TreeTextn.enabled = false;
                jobotJobotStage3TreeTexto.enabled = false;
                jobotJobotStage3TreeTextp.enabled = false;
                jobotJobotStage3TreeTextq.enabled = false;
                jobotJobotStage3TreeTextr.enabled = false;
                jobotJobotStage3TreeTexts.enabled = false;
                hint10.gameObject.SetActive(true);
                TTSJobotStage3Tree.gameObject.SetActive(true);
                TTSJobotStage3Treea.gameObject.SetActive(false);
       //         TTSJobotStage3Treeb.gameObject.SetActive(false);
                TTSJobotStage3Treec.gameObject.SetActive(false);
                TTSJobotStage3Treed.gameObject.SetActive(false);
                TTSJobotStage3TreedControls.gameObject.SetActive(false);
                TTSJobotStage3TreedGameplayExplaination.gameObject.SetActive(false);
                TTSJobotStage3Treee.gameObject.SetActive(false);
                TTSJobotStage3Treef.gameObject.SetActive(false);
                TTSJobotStage3Treeg.gameObject.SetActive(false);
                TTSJobotStage3Treeh.gameObject.SetActive(false);
                TTSJobotStage3Treei.gameObject.SetActive(false);
      //          TTSJobotStage3Treej.gameObject.SetActive(false);
                TTSJobotStage3Treek.gameObject.SetActive(false);
      //          TTSJobotStage3Treel.gameObject.SetActive(false);
                TTSJobotStage3Treem.gameObject.SetActive(false);
      //          TTSJobotStage3Treen.gameObject.SetActive(false);
                TTSJobotStage3Treeo.gameObject.SetActive(false);
                TTSJobotStage3Treep.gameObject.SetActive(false);
                TTSJobotStage3Treeq.gameObject.SetActive(false);
                TTSJobotStage3Treer.gameObject.SetActive(false);
                TTSJobotStage3Trees.gameObject.SetActive(false);

                susanPollenCollection1.gameObject.SetActive(true);
                //susanPollenCollection2.gameObject.SetActive(true);
                limaPollenCollection.gameObject.SetActive(true);
                daisyPollenCollection.gameObject.SetActive(true);
                radishPollenCollection.gameObject.SetActive(true);

                susanPollenArrows.gameObject.SetActive(true);
               // susanTargetnArrows.gameObject.SetActive(true);
                limaPollenArrows.gameObject.SetActive(true);
              //  limaTargetnArrows.gameObject.SetActive(true);
                daisyPollenArrows.gameObject.SetActive(true);
             //   daisyTargetnArrows.gameObject.SetActive(true);
                radishPollenArrows.gameObject.SetActive(true);
             //   radishTargetnArrows.gameObject.SetActive(true);

                if (!progressTextIsShowing)
                { // 3 second delay
                    StartCoroutine(DelayProgressButtonVar1());
                    progressTextIsShowing = true;
                }

            }

            if (currentStage3TreeText == 2)
            {
                if (!textBeenRead)
                {
                    progressText.gameObject.SetActive(false);
                }
                progressTextBack.gameObject.SetActive(true);
                textPanal.SetActive(true);
                jobotJobotStage3TreeText.enabled = false;
                jobotJobotStage3TreeTexta.enabled = true;
       //         jobotJobotStage3TreeTextb.enabled = false;
                jobotJobotStage3TreeTextc.enabled = false;
                jobotJobotStage3TreeTextd.enabled = false;
                jobotJobotStage3TreeTextdControls.enabled = false;
                jobotJobotStage3TreeTextdGamePlayExplaination.enabled = false;
                jobotJobotStage3TreeTexte.enabled = false;
                jobotJobotStage3TreeTextf.enabled = false;
                jobotJobotStage3TreeTextg.enabled = false;
                jobotJobotStage3TreeTexth.enabled = false;
                jobotJobotStage3TreeTexti.enabled = false;
          //      jobotJobotStage3TreeTextj.enabled = false;
                jobotJobotStage3TreeTextk.enabled = false;
          //      jobotJobotStage3TreeTextl.enabled = false;
                jobotJobotStage3TreeTextm.enabled = false;
          //      jobotJobotStage3TreeTextn.enabled = false;
                jobotJobotStage3TreeTexto.enabled = false;
                jobotJobotStage3TreeTextp.enabled = false;
                jobotJobotStage3TreeTextq.enabled = false;
                jobotJobotStage3TreeTextr.enabled = false;
                jobotJobotStage3TreeTexts.enabled = false;

                TTSJobotStage3Tree.gameObject.SetActive(false);
                TTSJobotStage3Treea.gameObject.SetActive(true);
           //     TTSJobotStage3Treeb.gameObject.SetActive(false);
                TTSJobotStage3Treec.gameObject.SetActive(false);
                TTSJobotStage3Treed.gameObject.SetActive(false);
                TTSJobotStage3TreedControls.gameObject.SetActive(false);
                TTSJobotStage3TreedGameplayExplaination.gameObject.SetActive(false);
                TTSJobotStage3Treee.gameObject.SetActive(false);
                TTSJobotStage3Treef.gameObject.SetActive(false);
                TTSJobotStage3Treeg.gameObject.SetActive(false);
                TTSJobotStage3Treeh.gameObject.SetActive(false);
                TTSJobotStage3Treei.gameObject.SetActive(false);
          //      TTSJobotStage3Treej.gameObject.SetActive(false);
                TTSJobotStage3Treek.gameObject.SetActive(false);
          //      TTSJobotStage3Treel.gameObject.SetActive(false);
                TTSJobotStage3Treem.gameObject.SetActive(false);
          //      TTSJobotStage3Treen.gameObject.SetActive(false);
                TTSJobotStage3Treeo.gameObject.SetActive(false);
                TTSJobotStage3Treep.gameObject.SetActive(false);
                TTSJobotStage3Treeq.gameObject.SetActive(false);
                TTSJobotStage3Treer.gameObject.SetActive(false);
                TTSJobotStage3Trees.gameObject.SetActive(false);
                if (!progressTextIsShowing)
                { // 3 second delay
                    StartCoroutine(DelayProgressButtonVar1());
                    progressTextIsShowing = true;
                }
            }
            /*
            if (currentStage3TreeText == 3)
            {
                if (!textBeenRead)
                {
                    progressText.gameObject.SetActive(false);
                }
                jobotJobotStage3TreeText.enabled = false;
                jobotJobotStage3TreeTexta.enabled = false;
          //      jobotJobotStage3TreeTextb.enabled = true;
                jobotJobotStage3TreeTextc.enabled = false;
                jobotJobotStage3TreeTextd.enabled = false;
                jobotJobotStage3TreeTextdControls.enabled = false;
                jobotJobotStage3TreeTextdGamePlayExplaination.enabled = false;
                jobotJobotStage3TreeTexte.enabled = false;
                jobotJobotStage3TreeTextf.enabled = false;
                jobotJobotStage3TreeTextg.enabled = false;
                jobotJobotStage3TreeTexth.enabled = false;
                jobotJobotStage3TreeTexti.enabled = false;
          //      jobotJobotStage3TreeTextj.enabled = false;
                jobotJobotStage3TreeTextk.enabled = false;
          //      jobotJobotStage3TreeTextl.enabled = false;
                jobotJobotStage3TreeTextm.enabled = false;
          //      jobotJobotStage3TreeTextn.enabled = false;
                jobotJobotStage3TreeTexto.enabled = false;
                jobotJobotStage3TreeTextp.enabled = false;
                jobotJobotStage3TreeTextq.enabled = false;
                jobotJobotStage3TreeTextr.enabled = false;
                jobotJobotStage3TreeTexts.enabled = false;

                TTSJobotStage3Tree.gameObject.SetActive(false);
                TTSJobotStage3Treea.gameObject.SetActive(false);
          //      TTSJobotStage3Treeb.gameObject.SetActive(true);
                TTSJobotStage3Treec.gameObject.SetActive(false);
                TTSJobotStage3Treed.gameObject.SetActive(false);
                TTSJobotStage3Treee.gameObject.SetActive(false);
                TTSJobotStage3Treef.gameObject.SetActive(false);
                TTSJobotStage3Treeg.gameObject.SetActive(false);
                TTSJobotStage3Treeh.gameObject.SetActive(false);
                TTSJobotStage3Treei.gameObject.SetActive(false);
          //      TTSJobotStage3Treej.gameObject.SetActive(false);
                TTSJobotStage3Treek.gameObject.SetActive(false);
         //       TTSJobotStage3Treel.gameObject.SetActive(false);
                TTSJobotStage3Treem.gameObject.SetActive(false);
         //       TTSJobotStage3Treen.gameObject.SetActive(false);
                TTSJobotStage3Treeo.gameObject.SetActive(false);
                TTSJobotStage3Treep.gameObject.SetActive(false);
                TTSJobotStage3Treeq.gameObject.SetActive(false);
                TTSJobotStage3Treer.gameObject.SetActive(false);
                TTSJobotStage3Trees.gameObject.SetActive(false);
                if (!progressTextIsShowing)
                { // 3 second delay
                    StartCoroutine(DelayProgressButtonVar1());
                    progressTextIsShowing = true;
                }
            }
            */
            if (currentStage3TreeText == 3)
            {
                if (!textBeenRead)
                {
                    progressText.gameObject.SetActive(false);
                }
                jobotJobotStage3TreeText.enabled = false;
                jobotJobotStage3TreeTexta.enabled = false;
         //       jobotJobotStage3TreeTextb.enabled = false;
                jobotJobotStage3TreeTextc.enabled = true;
                jobotJobotStage3TreeTextd.enabled = false;
                jobotJobotStage3TreeTextdControls.enabled = false;
                jobotJobotStage3TreeTextdGamePlayExplaination.enabled = false;
                jobotJobotStage3TreeTexte.enabled = false;
                jobotJobotStage3TreeTextf.enabled = false;
                jobotJobotStage3TreeTextg.enabled = false;
                jobotJobotStage3TreeTexth.enabled = false;
                jobotJobotStage3TreeTexti.enabled = false;
          //      jobotJobotStage3TreeTextj.enabled = false;
                jobotJobotStage3TreeTextk.enabled = false;
         //       jobotJobotStage3TreeTextl.enabled = false;
                jobotJobotStage3TreeTextm.enabled = false;
          //      jobotJobotStage3TreeTextn.enabled = false;
                jobotJobotStage3TreeTexto.enabled = false;
                jobotJobotStage3TreeTextp.enabled = false;
                jobotJobotStage3TreeTextq.enabled = false;
                jobotJobotStage3TreeTextr.enabled = false;
                jobotJobotStage3TreeTexts.enabled = false;

                TTSJobotStage3Tree.gameObject.SetActive(false);
                TTSJobotStage3Treea.gameObject.SetActive(false);
        //        TTSJobotStage3Treeb.gameObject.SetActive(false);
                TTSJobotStage3Treec.gameObject.SetActive(true);
                TTSJobotStage3Treed.gameObject.SetActive(false);
                TTSJobotStage3TreedControls.gameObject.SetActive(false);
                TTSJobotStage3TreedGameplayExplaination.gameObject.SetActive(false);
                TTSJobotStage3Treee.gameObject.SetActive(false);
                TTSJobotStage3Treef.gameObject.SetActive(false);
                TTSJobotStage3Treeg.gameObject.SetActive(false);
                TTSJobotStage3Treeh.gameObject.SetActive(false);
                TTSJobotStage3Treei.gameObject.SetActive(false);
        //        TTSJobotStage3Treej.gameObject.SetActive(false);
                TTSJobotStage3Treek.gameObject.SetActive(false);
        //        TTSJobotStage3Treel.gameObject.SetActive(false);
                TTSJobotStage3Treem.gameObject.SetActive(false);
        //        TTSJobotStage3Treen.gameObject.SetActive(false);
                TTSJobotStage3Treeo.gameObject.SetActive(false);
                TTSJobotStage3Treep.gameObject.SetActive(false);
                TTSJobotStage3Treeq.gameObject.SetActive(false);
                TTSJobotStage3Treer.gameObject.SetActive(false);
                TTSJobotStage3Trees.gameObject.SetActive(false);
                if (!progressTextIsShowing)
                { // 3 second delay
                    StartCoroutine(DelayProgressButtonVar1());
                    progressTextIsShowing = true;
                }
            }

            if (currentStage3TreeText == 4)
            {
                if (!textBeenRead)
                {
                    progressText.gameObject.SetActive(false);
                }
                jobotJobotStage3TreeText.enabled = false;
                jobotJobotStage3TreeTexta.enabled = false;
             //   jobotJobotStage3TreeTextb.enabled = false;
                jobotJobotStage3TreeTextc.enabled = false;
                jobotJobotStage3TreeTextd.enabled = true;
                jobotJobotStage3TreeTextdControls.enabled = false;
                jobotJobotStage3TreeTextdGamePlayExplaination.enabled = false;
                jobotJobotStage3TreeTexte.enabled = false;
                jobotJobotStage3TreeTextf.enabled = false;
                jobotJobotStage3TreeTextg.enabled = false;
                jobotJobotStage3TreeTexth.enabled = false;
                jobotJobotStage3TreeTexti.enabled = false;
            //    jobotJobotStage3TreeTextj.enabled = false;
                jobotJobotStage3TreeTextk.enabled = false;
            //    jobotJobotStage3TreeTextl.enabled = false;
                jobotJobotStage3TreeTextm.enabled = false;
            //    jobotJobotStage3TreeTextn.enabled = false;
                jobotJobotStage3TreeTexto.enabled = false;
                jobotJobotStage3TreeTextp.enabled = false;
                jobotJobotStage3TreeTextq.enabled = false;
                jobotJobotStage3TreeTextr.enabled = false;
                jobotJobotStage3TreeTexts.enabled = false;

                TTSJobotStage3Tree.gameObject.SetActive(false);
                TTSJobotStage3Treea.gameObject.SetActive(false);
          //      TTSJobotStage3Treeb.gameObject.SetActive(false);
                TTSJobotStage3Treec.gameObject.SetActive(false);
                TTSJobotStage3Treed.gameObject.SetActive(true);
                TTSJobotStage3TreedControls.gameObject.SetActive(false);
                TTSJobotStage3TreedGameplayExplaination.gameObject.SetActive(false);
                TTSJobotStage3Treee.gameObject.SetActive(false);
                TTSJobotStage3Treef.gameObject.SetActive(false);
                TTSJobotStage3Treeg.gameObject.SetActive(false);
                TTSJobotStage3Treeh.gameObject.SetActive(false);
                TTSJobotStage3Treei.gameObject.SetActive(false);
           //     TTSJobotStage3Treej.gameObject.SetActive(false);
                TTSJobotStage3Treek.gameObject.SetActive(false);
          //      TTSJobotStage3Treel.gameObject.SetActive(false);
                TTSJobotStage3Treem.gameObject.SetActive(false);
          //      TTSJobotStage3Treen.gameObject.SetActive(false);
                TTSJobotStage3Treeo.gameObject.SetActive(false);
                TTSJobotStage3Treep.gameObject.SetActive(false);
                TTSJobotStage3Treeq.gameObject.SetActive(false);
                TTSJobotStage3Treer.gameObject.SetActive(false);
                TTSJobotStage3Trees.gameObject.SetActive(false);
                if (!progressTextIsShowing)
                { // 3 second delay
                    StartCoroutine(DelayProgressButtonVar2());
                    progressTextIsShowing = true;
                }
            }

            if (currentStage3TreeText == 5)
            {
                
               
                    progressText.gameObject.SetActive(false);
               
                jobotJobotStage3TreeText.enabled = false;
                jobotJobotStage3TreeTexta.enabled = false;
         //       jobotJobotStage3TreeTextb.enabled = false;
                jobotJobotStage3TreeTextc.enabled = false;
                jobotJobotStage3TreeTextd.enabled = false;
                jobotJobotStage3TreeTextdControls.enabled = true;
                jobotJobotStage3TreeTextdGamePlayExplaination.enabled = false;
                jobotJobotStage3TreeTexte.enabled = false;
                jobotJobotStage3TreeTextf.enabled = false;
                jobotJobotStage3TreeTextg.enabled = false;
                jobotJobotStage3TreeTexth.enabled = false;
                jobotJobotStage3TreeTexti.enabled = false;
        //        jobotJobotStage3TreeTextj.enabled = false;
                jobotJobotStage3TreeTextk.enabled = false;
        //        jobotJobotStage3TreeTextl.enabled = false;
                jobotJobotStage3TreeTextm.enabled = false;
         //       jobotJobotStage3TreeTextn.enabled = false;
                jobotJobotStage3TreeTexto.enabled = false;
                jobotJobotStage3TreeTextp.enabled = false;
                jobotJobotStage3TreeTextq.enabled = false;
                jobotJobotStage3TreeTextr.enabled = false;
                jobotJobotStage3TreeTexts.enabled = false;

                TTSJobotStage3Tree.gameObject.SetActive(false);
                TTSJobotStage3Treea.gameObject.SetActive(false);
       //         TTSJobotStage3Treeb.gameObject.SetActive(false);
                TTSJobotStage3Treec.gameObject.SetActive(false);
                TTSJobotStage3Treed.gameObject.SetActive(false);
                TTSJobotStage3TreedControls.gameObject.SetActive(true);
                TTSJobotStage3TreedGameplayExplaination.gameObject.SetActive(false);
                TTSJobotStage3Treee.gameObject.SetActive(false);
                TTSJobotStage3Treef.gameObject.SetActive(false);
                TTSJobotStage3Treeg.gameObject.SetActive(false);
                TTSJobotStage3Treeh.gameObject.SetActive(false);
                TTSJobotStage3Treei.gameObject.SetActive(false);
       //         TTSJobotStage3Treej.gameObject.SetActive(false);
                TTSJobotStage3Treek.gameObject.SetActive(false);
       //         TTSJobotStage3Treel.gameObject.SetActive(false);
                TTSJobotStage3Treem.gameObject.SetActive(false);
     //           TTSJobotStage3Treen.gameObject.SetActive(false);
                TTSJobotStage3Treeo.gameObject.SetActive(false);
                TTSJobotStage3Treep.gameObject.SetActive(false);
                TTSJobotStage3Treeq.gameObject.SetActive(false);
                TTSJobotStage3Treer.gameObject.SetActive(false);
                TTSJobotStage3Trees.gameObject.SetActive(false);
                if (!disableAndEnablePause)
                {
                    StartCoroutine(HideTxtEnablePlayer());
                    disableAndEnablePause = true;
                }
               
                
               // if (!progressTextIsShowing)
               // { // 3 second delay
               //     StartCoroutine(DelayProgressButtonVar1());
               //     progressTextIsShowing = true;
              //  }
            }

            if (currentStage3TreeText == 6)
            {
                if (!textBeenRead)
                {
                    progressText.gameObject.SetActive(false);
                }
               // textPanal.SetActive(true);
                butterePlayerCont.enabled = false;
                jobotJobotStage3TreeText.enabled = false;
                jobotJobotStage3TreeTexta.enabled = false;
        //        jobotJobotStage3TreeTextb.enabled = false;
                jobotJobotStage3TreeTextc.enabled = false;
                jobotJobotStage3TreeTextd.enabled = false;
                jobotJobotStage3TreeTextdControls.enabled = false;
                jobotJobotStage3TreeTextdGamePlayExplaination.enabled = true;
                jobotJobotStage3TreeTexte.enabled = false;
                jobotJobotStage3TreeTextf.enabled = false;
                jobotJobotStage3TreeTextg.enabled = false;
                jobotJobotStage3TreeTexth.enabled = false;
                jobotJobotStage3TreeTexti.enabled = false;
        //        jobotJobotStage3TreeTextj.enabled = false;
                jobotJobotStage3TreeTextk.enabled = false;
        //        jobotJobotStage3TreeTextl.enabled = false;
                jobotJobotStage3TreeTextm.enabled = false;
       //         jobotJobotStage3TreeTextn.enabled = false;
                jobotJobotStage3TreeTexto.enabled = false;
                jobotJobotStage3TreeTextp.enabled = false;
                jobotJobotStage3TreeTextq.enabled = false;
                jobotJobotStage3TreeTextr.enabled = false;
                jobotJobotStage3TreeTexts.enabled = false;


                TTSJobotStage3Tree.gameObject.SetActive(false);
                TTSJobotStage3Treea.gameObject.SetActive(false);
         //       TTSJobotStage3Treeb.gameObject.SetActive(false);
                TTSJobotStage3Treec.gameObject.SetActive(false);
                TTSJobotStage3Treed.gameObject.SetActive(false);
                TTSJobotStage3TreedControls.gameObject.SetActive(false);
                TTSJobotStage3TreedGameplayExplaination.gameObject.SetActive(true);
                TTSJobotStage3Treee.gameObject.SetActive(false);
                TTSJobotStage3Treef.gameObject.SetActive(false);
                TTSJobotStage3Treeg.gameObject.SetActive(false);
                TTSJobotStage3Treeh.gameObject.SetActive(false);
                TTSJobotStage3Treei.gameObject.SetActive(false);
           //     TTSJobotStage3Treej.gameObject.SetActive(false);
                TTSJobotStage3Treek.gameObject.SetActive(false);
        //        TTSJobotStage3Treel.gameObject.SetActive(false);
                TTSJobotStage3Treem.gameObject.SetActive(false);
        //        TTSJobotStage3Treen.gameObject.SetActive(false);
                TTSJobotStage3Treeo.gameObject.SetActive(false);
                TTSJobotStage3Treep.gameObject.SetActive(false);
                TTSJobotStage3Treeq.gameObject.SetActive(false);
                TTSJobotStage3Treer.gameObject.SetActive(false);
                TTSJobotStage3Trees.gameObject.SetActive(false);
                if (!progressTextIsShowing)
                { // 3 second delay
                    StartCoroutine(DelayProgressButtonVar1());
                    progressTextIsShowing = true;
                }
            }


            if (currentStage3TreeText == 7)
            {
                if (!textBeenRead)
                {
                    progressText.gameObject.SetActive(false);
                }
                jobotJobotStage3TreeText.enabled = false;
                jobotJobotStage3TreeTexta.enabled = false;
          //      jobotJobotStage3TreeTextb.enabled = false;
                jobotJobotStage3TreeTextc.enabled = false;
                jobotJobotStage3TreeTextd.enabled = false;
                jobotJobotStage3TreeTextdControls.enabled = false;
                jobotJobotStage3TreeTextdGamePlayExplaination.enabled = false;
                jobotJobotStage3TreeTexte.enabled = true;
                jobotJobotStage3TreeTextf.enabled = false;
                jobotJobotStage3TreeTextg.enabled = false;
                jobotJobotStage3TreeTexth.enabled = false;
                jobotJobotStage3TreeTexti.enabled = false;
          //      jobotJobotStage3TreeTextj.enabled = false;
                jobotJobotStage3TreeTextk.enabled = false;
          //      jobotJobotStage3TreeTextl.enabled = false;
                jobotJobotStage3TreeTextm.enabled = false;
          //      jobotJobotStage3TreeTextn.enabled = false;
                jobotJobotStage3TreeTexto.enabled = false;
                jobotJobotStage3TreeTextp.enabled = false;
                jobotJobotStage3TreeTextq.enabled = false;
                jobotJobotStage3TreeTextr.enabled = false;
                jobotJobotStage3TreeTexts.enabled = false;


                TTSJobotStage3Tree.gameObject.SetActive(false);
                TTSJobotStage3Treea.gameObject.SetActive(false);
          //      TTSJobotStage3Treeb.gameObject.SetActive(false);
                TTSJobotStage3Treec.gameObject.SetActive(false);
                TTSJobotStage3Treed.gameObject.SetActive(false);
                TTSJobotStage3TreedControls.gameObject.SetActive(false);
                TTSJobotStage3TreedGameplayExplaination.gameObject.SetActive(false);
                TTSJobotStage3Treee.gameObject.SetActive(true);
                TTSJobotStage3Treef.gameObject.SetActive(false);
                TTSJobotStage3Treeg.gameObject.SetActive(false);
                TTSJobotStage3Treeh.gameObject.SetActive(false);
                TTSJobotStage3Treei.gameObject.SetActive(false);
          //      TTSJobotStage3Treej.gameObject.SetActive(false);
                TTSJobotStage3Treek.gameObject.SetActive(false);
          //      TTSJobotStage3Treel.gameObject.SetActive(false);
                TTSJobotStage3Treem.gameObject.SetActive(false);
          //      TTSJobotStage3Treen.gameObject.SetActive(false);
                TTSJobotStage3Treeo.gameObject.SetActive(false);
                TTSJobotStage3Treep.gameObject.SetActive(false);
                TTSJobotStage3Treeq.gameObject.SetActive(false);
                TTSJobotStage3Treer.gameObject.SetActive(false);
                TTSJobotStage3Trees.gameObject.SetActive(false);
                if (!progressTextIsShowing)
                { // 3 second delay
                    StartCoroutine(DelayProgressButtonVar2());
                    progressTextIsShowing = true;
                }
            }
            if (currentStage3TreeText == 8)
            {

                if (!textBeenRead)
                {
                    progressText.gameObject.SetActive(false);
                }
                jobotJobotStage3TreeText.enabled = false;
                jobotJobotStage3TreeTexta.enabled = false;
          //      jobotJobotStage3TreeTextb.enabled = false;
                jobotJobotStage3TreeTextc.enabled = false;
                jobotJobotStage3TreeTextd.enabled = false;
                jobotJobotStage3TreeTextdControls.enabled = false;
                jobotJobotStage3TreeTextdGamePlayExplaination.enabled = false;
                jobotJobotStage3TreeTexte.enabled = false;
                jobotJobotStage3TreeTextf.enabled = true;
                jobotJobotStage3TreeTextg.enabled = false;
                jobotJobotStage3TreeTexth.enabled = false;
                jobotJobotStage3TreeTexti.enabled = false;
         //       jobotJobotStage3TreeTextj.enabled = false;
                jobotJobotStage3TreeTextk.enabled = false;
         //       jobotJobotStage3TreeTextl.enabled = false;
                jobotJobotStage3TreeTextm.enabled = false;
         //       jobotJobotStage3TreeTextn.enabled = false;
                jobotJobotStage3TreeTexto.enabled = false;
                jobotJobotStage3TreeTextp.enabled = false;
                jobotJobotStage3TreeTextq.enabled = false;
                jobotJobotStage3TreeTextr.enabled = false;
                jobotJobotStage3TreeTexts.enabled = false;


                TTSJobotStage3Tree.gameObject.SetActive(false);
                TTSJobotStage3Treea.gameObject.SetActive(false);
           //     TTSJobotStage3Treeb.gameObject.SetActive(false);
                TTSJobotStage3Treec.gameObject.SetActive(false);
                TTSJobotStage3Treed.gameObject.SetActive(false);
                TTSJobotStage3TreedControls.gameObject.SetActive(false);
                TTSJobotStage3TreedGameplayExplaination.gameObject.SetActive(false);
                TTSJobotStage3Treee.gameObject.SetActive(false);
                TTSJobotStage3Treef.gameObject.SetActive(true);
                TTSJobotStage3Treeg.gameObject.SetActive(false);
                TTSJobotStage3Treeh.gameObject.SetActive(false);
                TTSJobotStage3Treei.gameObject.SetActive(false);
          //      TTSJobotStage3Treej.gameObject.SetActive(false);
                TTSJobotStage3Treek.gameObject.SetActive(false);
          //      TTSJobotStage3Treel.gameObject.SetActive(false);
                TTSJobotStage3Treem.gameObject.SetActive(false);
        //        TTSJobotStage3Treen.gameObject.SetActive(false);
                TTSJobotStage3Treeo.gameObject.SetActive(false);
                TTSJobotStage3Treep.gameObject.SetActive(false);
                TTSJobotStage3Treeq.gameObject.SetActive(false);
                TTSJobotStage3Treer.gameObject.SetActive(false);
                TTSJobotStage3Trees.gameObject.SetActive(false);
                if (!progressTextIsShowing)
                { // 3 second delay
                    StartCoroutine(DelayProgressButtonVar2());
                    progressTextIsShowing = true;
                }
            }

            if (currentStage3TreeText == 9)
            {
                if (!textBeenRead)
                {
                    progressText.gameObject.SetActive(false);
                }
                stamenStigmaDiagram.gameObject.SetActive(true);
                stamenStigmaDiagram.SetActive(true);
                jobotJobotStage3TreeText.enabled = false;
                jobotJobotStage3TreeTexta.enabled = false;
         //       jobotJobotStage3TreeTextb.enabled = false;
                jobotJobotStage3TreeTextc.enabled = false;
                jobotJobotStage3TreeTextd.enabled = false;
                jobotJobotStage3TreeTextdControls.enabled = false;
                jobotJobotStage3TreeTextdGamePlayExplaination.enabled = false;
                jobotJobotStage3TreeTexte.enabled = false;
                jobotJobotStage3TreeTextf.enabled = false;
                jobotJobotStage3TreeTextg.enabled = true;
                jobotJobotStage3TreeTexth.enabled = false;
                jobotJobotStage3TreeTexti.enabled = false;
         //       jobotJobotStage3TreeTextj.enabled = false;
                jobotJobotStage3TreeTextk.enabled = false;
        //        jobotJobotStage3TreeTextl.enabled = false;
                jobotJobotStage3TreeTextm.enabled = false;
        //        jobotJobotStage3TreeTextn.enabled = false;
                jobotJobotStage3TreeTexto.enabled = false;
                jobotJobotStage3TreeTextp.enabled = false;
                jobotJobotStage3TreeTextq.enabled = false;
                jobotJobotStage3TreeTextr.enabled = false;
                jobotJobotStage3TreeTexts.enabled = false;


                TTSJobotStage3Tree.gameObject.SetActive(false);
                TTSJobotStage3Treea.gameObject.SetActive(false);
       //         TTSJobotStage3Treeb.gameObject.SetActive(false);
                TTSJobotStage3Treec.gameObject.SetActive(false);
                TTSJobotStage3Treed.gameObject.SetActive(false);
                TTSJobotStage3TreedControls.gameObject.SetActive(false);
                TTSJobotStage3TreedGameplayExplaination.gameObject.SetActive(false);
                TTSJobotStage3Treee.gameObject.SetActive(false);
                TTSJobotStage3Treef.gameObject.SetActive(false);
                TTSJobotStage3Treeg.gameObject.SetActive(true);
                TTSJobotStage3Treeh.gameObject.SetActive(false);
                TTSJobotStage3Treei.gameObject.SetActive(false);
       //         TTSJobotStage3Treej.gameObject.SetActive(false);
                TTSJobotStage3Treek.gameObject.SetActive(false);
       //         TTSJobotStage3Treel.gameObject.SetActive(false);
                TTSJobotStage3Treem.gameObject.SetActive(false);
       //         TTSJobotStage3Treen.gameObject.SetActive(false);
                TTSJobotStage3Treeo.gameObject.SetActive(false);
                TTSJobotStage3Treep.gameObject.SetActive(false);
                TTSJobotStage3Treeq.gameObject.SetActive(false);
                TTSJobotStage3Treer.gameObject.SetActive(false);
                TTSJobotStage3Trees.gameObject.SetActive(false);
                if (!progressTextIsShowing)
                { // 3 second delay
                    StartCoroutine(DelayProgressButtonVar1());
                    progressTextIsShowing = true;
                }
            }

            if (currentStage3TreeText == 10)
            {
                if (!textBeenRead)
                {
                    progressText.gameObject.SetActive(false);
                }
               // minigamePanal.gameObject.SetActive(true);
                jobotJobotStage3TreeText.enabled = false;
                jobotJobotStage3TreeTexta.enabled = false;
        //        jobotJobotStage3TreeTextb.enabled = false;
                jobotJobotStage3TreeTextc.enabled = false;
                jobotJobotStage3TreeTextd.enabled = false;
                jobotJobotStage3TreeTextdControls.enabled = false;
                jobotJobotStage3TreeTextdGamePlayExplaination.enabled = false;
                jobotJobotStage3TreeTexte.enabled = false;
                jobotJobotStage3TreeTextf.enabled = false;
                jobotJobotStage3TreeTextg.enabled = false;
                jobotJobotStage3TreeTexth.enabled = true;
                jobotJobotStage3TreeTexti.enabled = false;
       //         jobotJobotStage3TreeTextj.enabled = false;
                jobotJobotStage3TreeTextk.enabled = false;
       //         jobotJobotStage3TreeTextl.enabled = false;
                jobotJobotStage3TreeTextm.enabled = false;
       //         jobotJobotStage3TreeTextn.enabled = false;
                jobotJobotStage3TreeTexto.enabled = false;
                jobotJobotStage3TreeTextp.enabled = false;
                jobotJobotStage3TreeTextq.enabled = false;
                jobotJobotStage3TreeTextr.enabled = false;
                jobotJobotStage3TreeTexts.enabled = false;


                TTSJobotStage3Tree.gameObject.SetActive(false);
                TTSJobotStage3Treea.gameObject.SetActive(false);
     //           TTSJobotStage3Treeb.gameObject.SetActive(false);
                TTSJobotStage3Treec.gameObject.SetActive(false);
                TTSJobotStage3Treed.gameObject.SetActive(false);
                TTSJobotStage3TreedControls.gameObject.SetActive(false);
                TTSJobotStage3TreedGameplayExplaination.gameObject.SetActive(false);
                TTSJobotStage3Treee.gameObject.SetActive(false);
                TTSJobotStage3Treef.gameObject.SetActive(false);
                TTSJobotStage3Treeg.gameObject.SetActive(false);
                TTSJobotStage3Treeh.gameObject.SetActive(true);
                TTSJobotStage3Treei.gameObject.SetActive(false);
    //            TTSJobotStage3Treej.gameObject.SetActive(false);
                TTSJobotStage3Treek.gameObject.SetActive(false);
     //           TTSJobotStage3Treel.gameObject.SetActive(false);
                TTSJobotStage3Treem.gameObject.SetActive(false);
    //            TTSJobotStage3Treen.gameObject.SetActive(false);
                TTSJobotStage3Treeo.gameObject.SetActive(false);
                TTSJobotStage3Treep.gameObject.SetActive(false);
                TTSJobotStage3Treeq.gameObject.SetActive(false);
                TTSJobotStage3Treer.gameObject.SetActive(false);
                TTSJobotStage3Trees.gameObject.SetActive(false);
                if (!progressTextIsShowing)
                { // 3 second delay
                    StartCoroutine(DelayProgressButtonVar2());
                    progressTextIsShowing = true;
                }
            }

            if (currentStage3TreeText == 11)
            {
                if (!textBeenRead)
                {
                    progressText.gameObject.SetActive(false);
                }
                jobotJobotStage3TreeText.enabled = false;
                jobotJobotStage3TreeTexta.enabled = false;
            //    jobotJobotStage3TreeTextb.enabled = false;
                jobotJobotStage3TreeTextc.enabled = false;
                jobotJobotStage3TreeTextd.enabled = false;
                jobotJobotStage3TreeTextdControls.enabled = false;
                jobotJobotStage3TreeTextdGamePlayExplaination.enabled = false;
                jobotJobotStage3TreeTexte.enabled = false;
                jobotJobotStage3TreeTextf.enabled = false;
                jobotJobotStage3TreeTextg.enabled = false;
                jobotJobotStage3TreeTexth.enabled = false;
                jobotJobotStage3TreeTexti.enabled = true;
            //    jobotJobotStage3TreeTextj.enabled = false;
                jobotJobotStage3TreeTextk.enabled = false;
           //     jobotJobotStage3TreeTextl.enabled = false;
                jobotJobotStage3TreeTextm.enabled = false;
           //     jobotJobotStage3TreeTextn.enabled = false;
                jobotJobotStage3TreeTexto.enabled = false;
                jobotJobotStage3TreeTextp.enabled = false;
                jobotJobotStage3TreeTextq.enabled = false;
                jobotJobotStage3TreeTextr.enabled = false;
                jobotJobotStage3TreeTexts.enabled = false;

               
                TTSJobotStage3Tree.gameObject.SetActive(false);
                TTSJobotStage3Treea.gameObject.SetActive(false);
          //      TTSJobotStage3Treeb.gameObject.SetActive(false);
                TTSJobotStage3Treec.gameObject.SetActive(false);
                TTSJobotStage3Treed.gameObject.SetActive(false);
                TTSJobotStage3TreedControls.gameObject.SetActive(false);
                TTSJobotStage3TreedGameplayExplaination.gameObject.SetActive(false);
                TTSJobotStage3Treee.gameObject.SetActive(false);
                TTSJobotStage3Treef.gameObject.SetActive(false);
                TTSJobotStage3Treeg.gameObject.SetActive(false);
                TTSJobotStage3Treeh.gameObject.SetActive(false);
                TTSJobotStage3Treei.gameObject.SetActive(true);
            //    TTSJobotStage3Treej.gameObject.SetActive(false);
                TTSJobotStage3Treek.gameObject.SetActive(false);
           //     TTSJobotStage3Treel.gameObject.SetActive(false);
                TTSJobotStage3Treem.gameObject.SetActive(false);
           //     TTSJobotStage3Treen.gameObject.SetActive(false);
                TTSJobotStage3Treeo.gameObject.SetActive(false);
                TTSJobotStage3Treep.gameObject.SetActive(false);
                TTSJobotStage3Treeq.gameObject.SetActive(false);
                TTSJobotStage3Treer.gameObject.SetActive(false);
                TTSJobotStage3Trees.gameObject.SetActive(false);
                if (!progressTextIsShowing)
                { // 3 second delay
                    StartCoroutine(DelayProgressButtonVar1());
                    progressTextIsShowing = true;
                }
            }
            /*
            if (currentStage3TreeText == 13)
            {
                if (!textBeenRead)
                {
                    progressText.gameObject.SetActive(false);
                }
                stamenStigmaDiagram.gameObject.SetActive(false);
                jobotJobotStage3TreeText.enabled = false;
                jobotJobotStage3TreeTexta.enabled = false;
           //     jobotJobotStage3TreeTextb.enabled = false;
                jobotJobotStage3TreeTextc.enabled = false;
                jobotJobotStage3TreeTextd.enabled = false;
                jobotJobotStage3TreeTextdControls.enabled = false;
                jobotJobotStage3TreeTextdGamePlayExplaination.enabled = false;
                jobotJobotStage3TreeTexte.enabled = false;
                jobotJobotStage3TreeTextf.enabled = false;
                jobotJobotStage3TreeTextg.enabled = false;
                jobotJobotStage3TreeTexth.enabled = false;
                jobotJobotStage3TreeTexti.enabled = false;
           //     jobotJobotStage3TreeTextj.enabled = true;
                jobotJobotStage3TreeTextk.enabled = false;
          //      jobotJobotStage3TreeTextl.enabled = false;
                jobotJobotStage3TreeTextm.enabled = false;
          //      jobotJobotStage3TreeTextn.enabled = false;
                jobotJobotStage3TreeTexto.enabled = false;
                jobotJobotStage3TreeTextp.enabled = false;
                jobotJobotStage3TreeTextq.enabled = false;
                jobotJobotStage3TreeTextr.enabled = false;
                jobotJobotStage3TreeTexts.enabled = false;

                if (!textBeenRead)
                {
                    progressText.gameObject.SetActive(false);
                }
                TTSJobotStage3Tree.gameObject.SetActive(false);
                TTSJobotStage3Treea.gameObject.SetActive(false);
                TTSJobotStage3Treeb.gameObject.SetActive(false);
                TTSJobotStage3Treec.gameObject.SetActive(false);
                TTSJobotStage3Treed.gameObject.SetActive(false);
                TTSJobotStage3TreedControls.gameObject.SetActive(false);
                TTSJobotStage3TreedGameplayExplaination.gameObject.SetActive(false);
                TTSJobotStage3Treee.gameObject.SetActive(false);
                TTSJobotStage3Treef.gameObject.SetActive(false);
                TTSJobotStage3Treeg.gameObject.SetActive(false);
                TTSJobotStage3Treeh.gameObject.SetActive(false);
                TTSJobotStage3Treei.gameObject.SetActive(false);
                TTSJobotStage3Treej.gameObject.SetActive(true);
                TTSJobotStage3Treek.gameObject.SetActive(false);
                TTSJobotStage3Treel.gameObject.SetActive(false);
                TTSJobotStage3Treem.gameObject.SetActive(false);
                TTSJobotStage3Treen.gameObject.SetActive(false);
                TTSJobotStage3Treeo.gameObject.SetActive(false);
                TTSJobotStage3Treep.gameObject.SetActive(false);
                TTSJobotStage3Treeq.gameObject.SetActive(false);
                TTSJobotStage3Treer.gameObject.SetActive(false);
                TTSJobotStage3Trees.gameObject.SetActive(false);
                if (!progressTextIsShowing)
                { // 3 second delay
                    StartCoroutine(DelayProgressButtonVar2());
                    progressTextIsShowing = true;
                }
            }
            */
            if (currentStage3TreeText == 12)
            {
                if (!textBeenRead)
                {
                    progressText.gameObject.SetActive(false);
                }
                jobotJobotStage3TreeText.enabled = false;
                jobotJobotStage3TreeTexta.enabled = false;
          //      jobotJobotStage3TreeTextb.enabled = false;
                jobotJobotStage3TreeTextc.enabled = false;
                jobotJobotStage3TreeTextd.enabled = false;
                jobotJobotStage3TreeTextdControls.enabled = false;
                jobotJobotStage3TreeTextdGamePlayExplaination.enabled = false;
                jobotJobotStage3TreeTexte.enabled = false;
                jobotJobotStage3TreeTextf.enabled = false;
                jobotJobotStage3TreeTextg.enabled = false;
                jobotJobotStage3TreeTexth.enabled = false;
                jobotJobotStage3TreeTexti.enabled = false;
          //      jobotJobotStage3TreeTextj.enabled = false;
                jobotJobotStage3TreeTextk.enabled = true;
          //      jobotJobotStage3TreeTextl.enabled = false;
                jobotJobotStage3TreeTextm.enabled = false;
         //       jobotJobotStage3TreeTextn.enabled = false;
                jobotJobotStage3TreeTexto.enabled = false;
                jobotJobotStage3TreeTextp.enabled = false;
                jobotJobotStage3TreeTextq.enabled = false;
                jobotJobotStage3TreeTextr.enabled = false;
                jobotJobotStage3TreeTexts.enabled = false;

                //if (!textBeenRead)
                //{
               //     progressText.gameObject.SetActive(false);
               // }
                TTSJobotStage3Tree.gameObject.SetActive(false);
                TTSJobotStage3Treea.gameObject.SetActive(false);
         //       TTSJobotStage3Treeb.gameObject.SetActive(false);
                TTSJobotStage3Treec.gameObject.SetActive(false);
                TTSJobotStage3Treed.gameObject.SetActive(false);
                TTSJobotStage3TreedControls.gameObject.SetActive(false);
                TTSJobotStage3TreedGameplayExplaination.gameObject.SetActive(false);
                TTSJobotStage3Treee.gameObject.SetActive(false);
                TTSJobotStage3Treef.gameObject.SetActive(false);
                TTSJobotStage3Treeg.gameObject.SetActive(false);
                TTSJobotStage3Treeh.gameObject.SetActive(false);
                TTSJobotStage3Treei.gameObject.SetActive(false);
        //        TTSJobotStage3Treej.gameObject.SetActive(false);
                TTSJobotStage3Treek.gameObject.SetActive(true);
        //        TTSJobotStage3Treel.gameObject.SetActive(false);
                TTSJobotStage3Treem.gameObject.SetActive(false);
         //       TTSJobotStage3Treen.gameObject.SetActive(false);
                TTSJobotStage3Treeo.gameObject.SetActive(false);
                TTSJobotStage3Treep.gameObject.SetActive(false);
                TTSJobotStage3Treeq.gameObject.SetActive(false);
                TTSJobotStage3Treer.gameObject.SetActive(false);
                TTSJobotStage3Trees.gameObject.SetActive(false);
                if (!progressTextIsShowing)
                { // 3 second delay
                    StartCoroutine(DelayProgressButtonVar2());
                    progressTextIsShowing = true;
                }

            }
            /*
            if (currentStage3TreeText == 15)
            {

                if (!textBeenRead)
                {
                    progressText.gameObject.SetActive(false);
                }
                jobotJobotStage3TreeText.enabled = false;
                jobotJobotStage3TreeTexta.enabled = false;
                jobotJobotStage3TreeTextb.enabled = false;
                jobotJobotStage3TreeTextc.enabled = false;
                jobotJobotStage3TreeTextd.enabled = false;
                jobotJobotStage3TreeTextdControls.enabled = false;
                jobotJobotStage3TreeTextdGamePlayExplaination.enabled = false;
                jobotJobotStage3TreeTexte.enabled = false;
                jobotJobotStage3TreeTextf.enabled = false;
                jobotJobotStage3TreeTextg.enabled = false;
                jobotJobotStage3TreeTexth.enabled = false;
                jobotJobotStage3TreeTexti.enabled = false;
                jobotJobotStage3TreeTextj.enabled = false;
                jobotJobotStage3TreeTextk.enabled = false;
                jobotJobotStage3TreeTextl.enabled = true;
                jobotJobotStage3TreeTextm.enabled = false;
                jobotJobotStage3TreeTextn.enabled = false;
                jobotJobotStage3TreeTexto.enabled = false;
                jobotJobotStage3TreeTextp.enabled = false;
                jobotJobotStage3TreeTextq.enabled = false;
                jobotJobotStage3TreeTextr.enabled = false;
                jobotJobotStage3TreeTexts.enabled = false;


                TTSJobotStage3Tree.gameObject.SetActive(false);
                TTSJobotStage3Treea.gameObject.SetActive(false);
                TTSJobotStage3Treeb.gameObject.SetActive(false);
                TTSJobotStage3Treec.gameObject.SetActive(false);
                TTSJobotStage3Treed.gameObject.SetActive(false);
                TTSJobotStage3TreedControls.gameObject.SetActive(false);
                TTSJobotStage3TreedGameplayExplaination.gameObject.SetActive(false);
                TTSJobotStage3Treee.gameObject.SetActive(false);
                TTSJobotStage3Treef.gameObject.SetActive(false);
                TTSJobotStage3Treeg.gameObject.SetActive(false);
                TTSJobotStage3Treeh.gameObject.SetActive(false);
                TTSJobotStage3Treei.gameObject.SetActive(false);
                TTSJobotStage3Treej.gameObject.SetActive(false);
                TTSJobotStage3Treek.gameObject.SetActive(false);
                TTSJobotStage3Treel.gameObject.SetActive(true);
                TTSJobotStage3Treem.gameObject.SetActive(false);
                TTSJobotStage3Treen.gameObject.SetActive(false);
                TTSJobotStage3Treeo.gameObject.SetActive(false);
                TTSJobotStage3Treep.gameObject.SetActive(false);
                TTSJobotStage3Treeq.gameObject.SetActive(false);
                TTSJobotStage3Treer.gameObject.SetActive(false);
                TTSJobotStage3Trees.gameObject.SetActive(false);
                if (!progressTextIsShowing)
                { // 3 second delay
                    StartCoroutine(DelayProgressButtonVar1());
                    progressTextIsShowing = true;
                }
            }
            */
            if (currentStage3TreeText == 13)
            {
                if (!textBeenRead)
                {
                    progressText.gameObject.SetActive(false);
                }
                stamenStigmaDiagram.gameObject.SetActive(false);
                butterePlayerCont.enabled = true;
                jobotJobotStage3TreeText.enabled = false;
                jobotJobotStage3TreeTexta.enabled = false;
          //      jobotJobotStage3TreeTextb.enabled = false;
                jobotJobotStage3TreeTextc.enabled = false;
                jobotJobotStage3TreeTextd.enabled = false;
                jobotJobotStage3TreeTextdControls.enabled = false;
                jobotJobotStage3TreeTextdGamePlayExplaination.enabled = false;
                jobotJobotStage3TreeTexte.enabled = false;
                jobotJobotStage3TreeTextf.enabled = false;
                jobotJobotStage3TreeTextg.enabled = false;
                jobotJobotStage3TreeTexth.enabled = false;
                jobotJobotStage3TreeTexti.enabled = false;
            //    jobotJobotStage3TreeTextj.enabled = false;
                jobotJobotStage3TreeTextk.enabled = false;
           //     jobotJobotStage3TreeTextl.enabled = false;
                jobotJobotStage3TreeTextm.enabled = true;
           //     jobotJobotStage3TreeTextn.enabled = false;
                jobotJobotStage3TreeTexto.enabled = false;
                jobotJobotStage3TreeTextp.enabled = false;
                jobotJobotStage3TreeTextq.enabled = false;
                jobotJobotStage3TreeTextr.enabled = false;
                jobotJobotStage3TreeTexts.enabled = false;


                TTSJobotStage3Tree.gameObject.SetActive(false);
                TTSJobotStage3Treea.gameObject.SetActive(false);
          //      TTSJobotStage3Treeb.gameObject.SetActive(false);
                TTSJobotStage3Treec.gameObject.SetActive(false);
                TTSJobotStage3Treed.gameObject.SetActive(false);
                TTSJobotStage3TreedControls.gameObject.SetActive(false);
                TTSJobotStage3TreedGameplayExplaination.gameObject.SetActive(false);
                TTSJobotStage3Treee.gameObject.SetActive(false);
                TTSJobotStage3Treef.gameObject.SetActive(false);
                TTSJobotStage3Treeg.gameObject.SetActive(false);
                TTSJobotStage3Treeh.gameObject.SetActive(false);
                TTSJobotStage3Treei.gameObject.SetActive(false);
           //     TTSJobotStage3Treej.gameObject.SetActive(false);
                TTSJobotStage3Treek.gameObject.SetActive(false);
           //     TTSJobotStage3Treel.gameObject.SetActive(false);
                TTSJobotStage3Treem.gameObject.SetActive(true);
          //      TTSJobotStage3Treen.gameObject.SetActive(false);
                TTSJobotStage3Treeo.gameObject.SetActive(false);
                TTSJobotStage3Treep.gameObject.SetActive(false);
                TTSJobotStage3Treeq.gameObject.SetActive(false);
                TTSJobotStage3Treer.gameObject.SetActive(false);
                TTSJobotStage3Trees.gameObject.SetActive(false);
                StartCoroutine(CloseTextPanal());

               // progressText.gameObject.SetActive(false);
            }
            
            if (currentStage3TreeText == 17)
            {
              
                textPanal.SetActive(false);
                jobotJobotStage3TreeText.enabled = false;
                jobotJobotStage3TreeTexta.enabled = false;
             //   jobotJobotStage3TreeTextb.enabled = false;
                jobotJobotStage3TreeTextc.enabled = false;
                jobotJobotStage3TreeTextd.enabled = false;
                jobotJobotStage3TreeTextdControls.enabled = false;
                jobotJobotStage3TreeTextdGamePlayExplaination.enabled = false;
                jobotJobotStage3TreeTexte.enabled = false;
                jobotJobotStage3TreeTextf.enabled = false;
                jobotJobotStage3TreeTextg.enabled = false;
                jobotJobotStage3TreeTexth.enabled = false;
                jobotJobotStage3TreeTexti.enabled = false;
          //      jobotJobotStage3TreeTextj.enabled = false;
                jobotJobotStage3TreeTextk.enabled = false;
          //      jobotJobotStage3TreeTextl.enabled = false;
                jobotJobotStage3TreeTextm.enabled = false;
         //       jobotJobotStage3TreeTextn.enabled = false;
                jobotJobotStage3TreeTexto.enabled = false;
                jobotJobotStage3TreeTextp.enabled = false;
                jobotJobotStage3TreeTextq.enabled = false;
                jobotJobotStage3TreeTextr.enabled = false;
                jobotJobotStage3TreeTexts.enabled = false;


                TTSJobotStage3Tree.gameObject.SetActive(false);
                TTSJobotStage3Treea.gameObject.SetActive(false);
         //       TTSJobotStage3Treeb.gameObject.SetActive(false);
                TTSJobotStage3Treec.gameObject.SetActive(false);
                TTSJobotStage3Treed.gameObject.SetActive(false);
                TTSJobotStage3TreedControls.gameObject.SetActive(false);
                TTSJobotStage3TreedGameplayExplaination.gameObject.SetActive(false);
                TTSJobotStage3Treee.gameObject.SetActive(false);
                TTSJobotStage3Treef.gameObject.SetActive(false);
                TTSJobotStage3Treeg.gameObject.SetActive(false);
                TTSJobotStage3Treeh.gameObject.SetActive(false);
                TTSJobotStage3Treei.gameObject.SetActive(false);
           //     TTSJobotStage3Treej.gameObject.SetActive(false);
                TTSJobotStage3Treek.gameObject.SetActive(false);
           //     TTSJobotStage3Treel.gameObject.SetActive(false);
                TTSJobotStage3Treem.gameObject.SetActive(false);
          //      TTSJobotStage3Treen.gameObject.SetActive(true);
                TTSJobotStage3Treeo.gameObject.SetActive(false);
                TTSJobotStage3Treep.gameObject.SetActive(false);
                TTSJobotStage3Treeq.gameObject.SetActive(false);
                TTSJobotStage3Treer.gameObject.SetActive(false);
                TTSJobotStage3Trees.gameObject.SetActive(false);
            }
            
            if (currentStage3TreeText == 18)
            {
                textPanal.SetActive(true);
                jobotJobotStage3TreeText.enabled = false;
                jobotJobotStage3TreeTexta.enabled = false;
           //     jobotJobotStage3TreeTextb.enabled = false;
                jobotJobotStage3TreeTextc.enabled = false;
                jobotJobotStage3TreeTextd.enabled = false;
                jobotJobotStage3TreeTextdControls.enabled = false;
                jobotJobotStage3TreeTextdGamePlayExplaination.enabled = false;
                jobotJobotStage3TreeTexte.enabled = false;
                jobotJobotStage3TreeTextf.enabled = false;
                jobotJobotStage3TreeTextg.enabled = false;
                jobotJobotStage3TreeTexth.enabled = false;
                jobotJobotStage3TreeTexti.enabled = false;
           //     jobotJobotStage3TreeTextj.enabled = false;
                jobotJobotStage3TreeTextk.enabled = false;
          //      jobotJobotStage3TreeTextl.enabled = false;
                jobotJobotStage3TreeTextm.enabled = false;
           //     jobotJobotStage3TreeTextn.enabled = false;
                jobotJobotStage3TreeTexto.enabled = true;
                jobotJobotStage3TreeTextp.enabled = false;
                jobotJobotStage3TreeTextq.enabled = false;
                jobotJobotStage3TreeTextr.enabled = false;
                jobotJobotStage3TreeTexts.enabled = false;


                TTSJobotStage3Tree.gameObject.SetActive(false);
                TTSJobotStage3Treea.gameObject.SetActive(false);
         //       TTSJobotStage3Treeb.gameObject.SetActive(false);
                TTSJobotStage3Treec.gameObject.SetActive(false);
                TTSJobotStage3Treed.gameObject.SetActive(false);
                TTSJobotStage3TreedControls.gameObject.SetActive(false);
                TTSJobotStage3TreedGameplayExplaination.gameObject.SetActive(false);
                TTSJobotStage3Treee.gameObject.SetActive(false);
                TTSJobotStage3Treef.gameObject.SetActive(false);
                TTSJobotStage3Treeg.gameObject.SetActive(false);
                TTSJobotStage3Treeh.gameObject.SetActive(false);
                TTSJobotStage3Treei.gameObject.SetActive(false);
         //       TTSJobotStage3Treej.gameObject.SetActive(false);
                TTSJobotStage3Treek.gameObject.SetActive(false);
         //       TTSJobotStage3Treel.gameObject.SetActive(false);
                TTSJobotStage3Treem.gameObject.SetActive(false);
        //        TTSJobotStage3Treen.gameObject.SetActive(false);
                TTSJobotStage3Treeo.gameObject.SetActive(true);
                TTSJobotStage3Treep.gameObject.SetActive(false);
                TTSJobotStage3Treeq.gameObject.SetActive(false);
                TTSJobotStage3Treer.gameObject.SetActive(false);
                TTSJobotStage3Trees.gameObject.SetActive(false);
                StartCoroutine(CloseTextPanal());
                progressText.gameObject.SetActive(false);
            }


        

            if (currentStage3TreeText == 19)
            {
                if (!hasLimaBeanPopped)
                {
                    textPanal.SetActive(true);
                    hasLimaBeanPopped = true;

                    jobotJobotStage3TreeText.enabled = false;
                    jobotJobotStage3TreeTexta.enabled = false;
          //          jobotJobotStage3TreeTextb.enabled = false;
                    jobotJobotStage3TreeTextc.enabled = false;
                    jobotJobotStage3TreeTextd.enabled = false;
                    jobotJobotStage3TreeTextdControls.enabled = false;
                    jobotJobotStage3TreeTextdGamePlayExplaination.enabled = false;
                    jobotJobotStage3TreeTexte.enabled = false;
                    jobotJobotStage3TreeTextf.enabled = false;
                    jobotJobotStage3TreeTextg.enabled = false;
                    jobotJobotStage3TreeTexth.enabled = false;
                    jobotJobotStage3TreeTexti.enabled = false;
           //         jobotJobotStage3TreeTextj.enabled = false;
                    jobotJobotStage3TreeTextk.enabled = false;
           //         jobotJobotStage3TreeTextl.enabled = false;
                    jobotJobotStage3TreeTextm.enabled = false;
           //         jobotJobotStage3TreeTextn.enabled = false;
                    jobotJobotStage3TreeTexto.enabled = false;
                    jobotJobotStage3TreeTextp.enabled = true;
                    jobotJobotStage3TreeTextq.enabled = false;
                    jobotJobotStage3TreeTextr.enabled = false;
                    jobotJobotStage3TreeTexts.enabled = false;


                    TTSJobotStage3Tree.gameObject.SetActive(false);
                    TTSJobotStage3Treea.gameObject.SetActive(false);
           //         TTSJobotStage3Treeb.gameObject.SetActive(false);
                    TTSJobotStage3Treec.gameObject.SetActive(false);
                    TTSJobotStage3Treed.gameObject.SetActive(false);
                    TTSJobotStage3TreedControls.gameObject.SetActive(false);
                    TTSJobotStage3TreedGameplayExplaination.gameObject.SetActive(false);
                    TTSJobotStage3Treee.gameObject.SetActive(false);
                    TTSJobotStage3Treef.gameObject.SetActive(false);
                    TTSJobotStage3Treeg.gameObject.SetActive(false);
                    TTSJobotStage3Treeh.gameObject.SetActive(false);
                    TTSJobotStage3Treei.gameObject.SetActive(false);
          //          TTSJobotStage3Treej.gameObject.SetActive(false);
                    TTSJobotStage3Treek.gameObject.SetActive(false);
           //         TTSJobotStage3Treel.gameObject.SetActive(false);
                    TTSJobotStage3Treem.gameObject.SetActive(false);
          //          TTSJobotStage3Treen.gameObject.SetActive(false);
                    TTSJobotStage3Treeo.gameObject.SetActive(false);
                    TTSJobotStage3Treep.gameObject.SetActive(true);
                    TTSJobotStage3Treeq.gameObject.SetActive(false);
                    TTSJobotStage3Treer.gameObject.SetActive(false);
                    TTSJobotStage3Trees.gameObject.SetActive(false);
                    StartCoroutine(CloseTextPanal());
                    progressText.gameObject.SetActive(false);
                }
               
            }

            if (currentStage3TreeText == 20)
            {
                if (!hasDiasyPopped)
                {
                    textPanal.SetActive(true);
                    hasDiasyPopped = true;
                    jobotJobotStage3TreeText.enabled = false;
                    jobotJobotStage3TreeTexta.enabled = false;
            //        jobotJobotStage3TreeTextb.enabled = false;
                    jobotJobotStage3TreeTextc.enabled = false;
                    jobotJobotStage3TreeTextd.enabled = false;
                    jobotJobotStage3TreeTextdControls.enabled = false;
                    jobotJobotStage3TreeTextdGamePlayExplaination.enabled = false;
                    jobotJobotStage3TreeTexte.enabled = false;
                    jobotJobotStage3TreeTextf.enabled = false;
                    jobotJobotStage3TreeTextg.enabled = false;
                    jobotJobotStage3TreeTexth.enabled = false;
                    jobotJobotStage3TreeTexti.enabled = false;
               //     jobotJobotStage3TreeTextj.enabled = false;
                    jobotJobotStage3TreeTextk.enabled = false;
                //    jobotJobotStage3TreeTextl.enabled = false;
                    jobotJobotStage3TreeTextm.enabled = false;
               //     jobotJobotStage3TreeTextn.enabled = false;
                    jobotJobotStage3TreeTexto.enabled = false;
                    jobotJobotStage3TreeTextp.enabled = false;
                    jobotJobotStage3TreeTextq.enabled = true;
                    jobotJobotStage3TreeTextr.enabled = false;
                    jobotJobotStage3TreeTexts.enabled = false;


                    TTSJobotStage3Tree.gameObject.SetActive(false);
                    TTSJobotStage3Treea.gameObject.SetActive(false);
              //      TTSJobotStage3Treeb.gameObject.SetActive(false);
                    TTSJobotStage3Treec.gameObject.SetActive(false);
                    TTSJobotStage3Treed.gameObject.SetActive(false);
                    TTSJobotStage3TreedControls.gameObject.SetActive(false);
                    TTSJobotStage3TreedGameplayExplaination.gameObject.SetActive(false);
                    TTSJobotStage3Treee.gameObject.SetActive(false);
                    TTSJobotStage3Treef.gameObject.SetActive(false);
                    TTSJobotStage3Treeg.gameObject.SetActive(false);
                    TTSJobotStage3Treeh.gameObject.SetActive(false);
                    TTSJobotStage3Treei.gameObject.SetActive(false);
             //       TTSJobotStage3Treej.gameObject.SetActive(false);
                    TTSJobotStage3Treek.gameObject.SetActive(false);
              //      TTSJobotStage3Treel.gameObject.SetActive(false);
                    TTSJobotStage3Treem.gameObject.SetActive(false);
             //       TTSJobotStage3Treen.gameObject.SetActive(false);
                    TTSJobotStage3Treeo.gameObject.SetActive(false);
                    TTSJobotStage3Treep.gameObject.SetActive(false);
                    TTSJobotStage3Treeq.gameObject.SetActive(true);
                    TTSJobotStage3Treer.gameObject.SetActive(false);
                    TTSJobotStage3Trees.gameObject.SetActive(false);
                    StartCoroutine(CloseTextPanal());
                    progressText.gameObject.SetActive(false);
                }
                
               
            }

            if (currentStage3TreeText == 21)
            {
                if (!hasradishPopped)
                {
                    textPanal.SetActive(true);
                    hasradishPopped = true;
                    jobotJobotStage3TreeText.enabled = false;
                    jobotJobotStage3TreeTexta.enabled = false;
             //       jobotJobotStage3TreeTextb.enabled = false;
                    jobotJobotStage3TreeTextc.enabled = false;
                    jobotJobotStage3TreeTextd.enabled = false;
                    jobotJobotStage3TreeTextdControls.enabled = false;
                    jobotJobotStage3TreeTextdGamePlayExplaination.enabled = false;
                    jobotJobotStage3TreeTexte.enabled = false;
                    jobotJobotStage3TreeTextf.enabled = false;
                    jobotJobotStage3TreeTextg.enabled = false;
                    jobotJobotStage3TreeTexth.enabled = false;
                    jobotJobotStage3TreeTexti.enabled = false;
             //       jobotJobotStage3TreeTextj.enabled = false;
                    jobotJobotStage3TreeTextk.enabled = false;
             //       jobotJobotStage3TreeTextl.enabled = false;
                    jobotJobotStage3TreeTextm.enabled = false;
             //       jobotJobotStage3TreeTextn.enabled = false;
                    jobotJobotStage3TreeTexto.enabled = false;
                    jobotJobotStage3TreeTextp.enabled = false;
                    jobotJobotStage3TreeTextq.enabled = false;
                    jobotJobotStage3TreeTextr.enabled = true;
                    jobotJobotStage3TreeTexts.enabled = false;


                    TTSJobotStage3Tree.gameObject.SetActive(false);
                    TTSJobotStage3Treea.gameObject.SetActive(false);
          //         TTSJobotStage3Treeb.gameObject.SetActive(false);
                    TTSJobotStage3Treec.gameObject.SetActive(false);
                    TTSJobotStage3Treed.gameObject.SetActive(false);
                    TTSJobotStage3TreedControls.gameObject.SetActive(false);
                    TTSJobotStage3TreedGameplayExplaination.gameObject.SetActive(false);
                    TTSJobotStage3Treee.gameObject.SetActive(false);
                    TTSJobotStage3Treef.gameObject.SetActive(false);
                    TTSJobotStage3Treeg.gameObject.SetActive(false);
                    TTSJobotStage3Treeh.gameObject.SetActive(false);
                    TTSJobotStage3Treei.gameObject.SetActive(false);
            //        TTSJobotStage3Treej.gameObject.SetActive(false);
                    TTSJobotStage3Treek.gameObject.SetActive(false);
            //        TTSJobotStage3Treel.gameObject.SetActive(false);
                    TTSJobotStage3Treem.gameObject.SetActive(false);
           //         TTSJobotStage3Treen.gameObject.SetActive(false);
                    TTSJobotStage3Treeo.gameObject.SetActive(false);
                    TTSJobotStage3Treep.gameObject.SetActive(false);
                    TTSJobotStage3Treeq.gameObject.SetActive(false);
                    TTSJobotStage3Treer.gameObject.SetActive(true);
                    TTSJobotStage3Trees.gameObject.SetActive(false);
                    StartCoroutine(CloseTextPanal());
                    progressText.gameObject.SetActive(false);
                }
              
                
            }

            if (currentStage3TreeText == 22)
            {
                textPanal.SetActive(true);
                jobotJobotStage3TreeText.enabled = false;
                jobotJobotStage3TreeTexta.enabled = false;
         //       jobotJobotStage3TreeTextb.enabled = false;
                jobotJobotStage3TreeTextc.enabled = false;
                jobotJobotStage3TreeTextd.enabled = false;
                jobotJobotStage3TreeTextdControls.enabled = false;
                jobotJobotStage3TreeTextdGamePlayExplaination.enabled = false;
                jobotJobotStage3TreeTexte.enabled = false;
                jobotJobotStage3TreeTextf.enabled = false;
                jobotJobotStage3TreeTextg.enabled = false;
                jobotJobotStage3TreeTexth.enabled = false;
                jobotJobotStage3TreeTexti.enabled = false;
         //       jobotJobotStage3TreeTextj.enabled = false;
                jobotJobotStage3TreeTextk.enabled = false;
         //       jobotJobotStage3TreeTextl.enabled = false;
                jobotJobotStage3TreeTextm.enabled = false;
          //      jobotJobotStage3TreeTextn.enabled = false;
                jobotJobotStage3TreeTexto.enabled = false;
                jobotJobotStage3TreeTextp.enabled = false;
                jobotJobotStage3TreeTextq.enabled = false;
                jobotJobotStage3TreeTextr.enabled = false;
                jobotJobotStage3TreeTexts.enabled = true;


                TTSJobotStage3Tree.gameObject.SetActive(false);
                TTSJobotStage3Treea.gameObject.SetActive(false);
        //        TTSJobotStage3Treeb.gameObject.SetActive(false);
                TTSJobotStage3Treec.gameObject.SetActive(false);
                TTSJobotStage3Treed.gameObject.SetActive(false);
                TTSJobotStage3TreedControls.gameObject.SetActive(false);
                TTSJobotStage3TreedGameplayExplaination.gameObject.SetActive(false);
                TTSJobotStage3Treee.gameObject.SetActive(false);
                TTSJobotStage3Treef.gameObject.SetActive(false);
                TTSJobotStage3Treeg.gameObject.SetActive(false);
                TTSJobotStage3Treeh.gameObject.SetActive(false);
                TTSJobotStage3Treei.gameObject.SetActive(false);
        //        TTSJobotStage3Treej.gameObject.SetActive(false);
                TTSJobotStage3Treek.gameObject.SetActive(false);
         //       TTSJobotStage3Treel.gameObject.SetActive(false);
                TTSJobotStage3Treem.gameObject.SetActive(false);
        //        TTSJobotStage3Treen.gameObject.SetActive(false);
                TTSJobotStage3Treeo.gameObject.SetActive(false);
                TTSJobotStage3Treep.gameObject.SetActive(false);
                TTSJobotStage3Treeq.gameObject.SetActive(false);
                TTSJobotStage3Treer.gameObject.SetActive(false);
                TTSJobotStage3Trees.gameObject.SetActive(true);
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
             
            }

            if (currentStage3TreeText == 23)
            {
                textPanal.SetActive(false);
                jobotJobotStage3TreeText.enabled = false;
                jobotJobotStage3TreeTexta.enabled = false;
                //       jobotJobotStage3TreeTextb.enabled = false;
                jobotJobotStage3TreeTextc.enabled = false;
                jobotJobotStage3TreeTextd.enabled = false;
                jobotJobotStage3TreeTextdControls.enabled = false;
                jobotJobotStage3TreeTextdGamePlayExplaination.enabled = false;
                jobotJobotStage3TreeTexte.enabled = false;
                jobotJobotStage3TreeTextf.enabled = false;
                jobotJobotStage3TreeTextg.enabled = false;
                jobotJobotStage3TreeTexth.enabled = false;
                jobotJobotStage3TreeTexti.enabled = false;
                //       jobotJobotStage3TreeTextj.enabled = false;
                jobotJobotStage3TreeTextk.enabled = false;
                //       jobotJobotStage3TreeTextl.enabled = false;
                jobotJobotStage3TreeTextm.enabled = false;
                //      jobotJobotStage3TreeTextn.enabled = false;
                jobotJobotStage3TreeTexto.enabled = false;
                jobotJobotStage3TreeTextp.enabled = false;
                jobotJobotStage3TreeTextq.enabled = false;
                jobotJobotStage3TreeTextr.enabled = false;
                jobotJobotStage3TreeTexts.enabled = false;


                TTSJobotStage3Tree.gameObject.SetActive(false);
                TTSJobotStage3Treea.gameObject.SetActive(false);
                //        TTSJobotStage3Treeb.gameObject.SetActive(false);
                TTSJobotStage3Treec.gameObject.SetActive(false);
                TTSJobotStage3Treed.gameObject.SetActive(false);
                TTSJobotStage3TreedControls.gameObject.SetActive(false);
                TTSJobotStage3TreedGameplayExplaination.gameObject.SetActive(false);
                TTSJobotStage3Treee.gameObject.SetActive(false);
                TTSJobotStage3Treef.gameObject.SetActive(false);
                TTSJobotStage3Treeg.gameObject.SetActive(false);
                TTSJobotStage3Treeh.gameObject.SetActive(false);
                TTSJobotStage3Treei.gameObject.SetActive(false);
                //        TTSJobotStage3Treej.gameObject.SetActive(false);
                TTSJobotStage3Treek.gameObject.SetActive(false);
                //       TTSJobotStage3Treel.gameObject.SetActive(false);
                TTSJobotStage3Treem.gameObject.SetActive(false);
                //        TTSJobotStage3Treen.gameObject.SetActive(false);
                TTSJobotStage3Treeo.gameObject.SetActive(false);
                TTSJobotStage3Treep.gameObject.SetActive(false);
                TTSJobotStage3Treeq.gameObject.SetActive(false);
                TTSJobotStage3Treer.gameObject.SetActive(false);
                TTSJobotStage3Trees.gameObject.SetActive(false);
               

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
