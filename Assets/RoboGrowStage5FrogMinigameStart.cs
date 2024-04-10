using System.Collections;
using UnityEngine;
using LoLSDK;
using UnityEngine.UI;
using UnityEngine.AI;
using TMPro;

namespace Alpha.Phases.Robo.Grow
{
    public class RoboGrowStage5FrogMinigameStart : MonoBehaviour
    {
        public RobotController robCont;
        public RoboGrowMain  rgMain;
        public RoboGrowFrogController rgFrogCont;
        public GameObject robotNavMeshAgentToStop;
        public Camera playerCamera;
        public Camera frogCam;

        public GameObject susanArrowToReset;
        public GameObject susan2ArrowToReset;
        public GameObject limaArrowToReset;
        public GameObject lima2ArrowToReset;
        public GameObject daisyArrowToReset;
        public GameObject daisy2ArrowToReset;
        public GameObject radishArrowToReset;
        public GameObject radish2ArrowToReset;

        public GameObject robotCharacter;
        public GameObject frogCharacter;

        public bool textBeenRead;
        public bool progressTextIsShowing;

        public Animator frogAnim;
        public GameObject frogLevelItems;

        public bool hasSavingHappenBefore;

        public GameObject textPanal;

        public Button progressText;
        public Button progressTextBack;

        public Button TTSJobotStage5Frog;
        public Button TTSJobotStage5Froga;
        public Button TTSJobotStage5Frogb;
        public Button TTSJobotStage5FrogcControls;
        public Button TTSJobotStage5FrogdWarning;
        public Button TTSJobotStage5FrogeEaten;
        public Button TTSJobotStage5Frogf;
        public Button TTSJobotStage5Frogg;
        public Button TTSJobotStage5Frogh;
        public Button TTSJobotStage5Frogi;
        public Button TTSJobotStage5Frogj;

        public TextMeshProUGUI jobotJobotStage5FrogText;
        public TextMeshProUGUI jobotJobotStage5FrogTexta;
        public TextMeshProUGUI jobotJobotStage5FrogTextb;
        public TextMeshProUGUI jobotJobotStage5FrogTextcControls;
        public TextMeshProUGUI jobotJobotStage5FrogTextdWarning;
        public TextMeshProUGUI jobotJobotStage5FrogTextrEaten;
        public TextMeshProUGUI jobotJobotStage5FrogTextf;
        public TextMeshProUGUI jobotJobotStage5FrogTextg;
        public TextMeshProUGUI jobotJobotStage5FrogTexth;
        public TextMeshProUGUI jobotJobotStage5FrogTexti;
        public TextMeshProUGUI jobotJobotStage5FrogTextj;

        public int currentStage3FrogText;

        private void Awake()
        {
            currentStage3FrogText = 0;
            progressText.onClick.AddListener(OnClick);
            progressTextBack.onClick.AddListener(OnClickBack);

            TTSJobotStage5Frog.onClick.AddListener(JobotStage4FrogMG1);
            TTSJobotStage5Froga.onClick.AddListener(JobotStage4FrogMG2);
            TTSJobotStage5Frogb.onClick.AddListener(JobotStage4FrogMG3);
            TTSJobotStage5FrogcControls.onClick.AddListener(JobotStage4FrogMG4);
            TTSJobotStage5FrogdWarning.onClick.AddListener(JobotStage4FrogMG5);
            TTSJobotStage5FrogeEaten.onClick.AddListener(JobotStage4FrogMG6);
            TTSJobotStage5Frogf.onClick.AddListener(JobotStage4FrogMG7);
            TTSJobotStage5Frogg.onClick.AddListener(JobotStage4FrogMG8);
            TTSJobotStage5Frogh.onClick.AddListener(JobotStage4FrogMG9);
            TTSJobotStage5Frogi.onClick.AddListener(JobotStage4FrogMG10);
            TTSJobotStage5Frogj.onClick.AddListener(JobotStage4FrogMG11);
        }

        // Start is called before the first frame update
        void Start()
        {
            textPanal.SetActive(false);
            jobotJobotStage5FrogText.enabled = false;
            jobotJobotStage5FrogTexta.enabled = false;
            jobotJobotStage5FrogTextb.enabled = false;
            jobotJobotStage5FrogTextcControls.enabled = false;
            jobotJobotStage5FrogTextdWarning.enabled = false;
            jobotJobotStage5FrogTextrEaten.enabled = false;
            jobotJobotStage5FrogTextf.enabled = false;
            jobotJobotStage5FrogTextg.enabled = false;
            jobotJobotStage5FrogTexth.enabled = false;
            jobotJobotStage5FrogTexti.enabled = false;
            jobotJobotStage5FrogTextj.enabled = false;


            TTSJobotStage5Frog.gameObject.SetActive(false);
            TTSJobotStage5Froga.gameObject.SetActive(false);
            TTSJobotStage5Frogb.gameObject.SetActive(false);
            TTSJobotStage5FrogcControls.gameObject.SetActive(false);
            TTSJobotStage5FrogdWarning.gameObject.SetActive(false);
            TTSJobotStage5FrogeEaten.gameObject.SetActive(false);
            TTSJobotStage5Frogf.gameObject.SetActive(false);
            TTSJobotStage5Frogg.gameObject.SetActive(false);
            TTSJobotStage5Frogh.gameObject.SetActive(false);
            TTSJobotStage5Frogi.gameObject.SetActive(false);
            TTSJobotStage5Frogj.gameObject.SetActive(false);

        }

        // Update is called once per frame
        void Update()
        {

            if (currentStage3FrogText == 1)
            {
                if (!textBeenRead)
                {
                    progressText.gameObject.SetActive(false);
                }
                progressTextBack.gameObject.SetActive(false);
                frogLevelItems.SetActive(true);
                textPanal.SetActive(true);
                frogCharacter.gameObject.SetActive(true);
                rgFrogCont.enabled = false;
                robCont.enabled = false;
                playerCamera.enabled = false;
                jobotJobotStage5FrogText.enabled = true;
                jobotJobotStage5FrogTexta.enabled = false;
                jobotJobotStage5FrogTextb.enabled = false;
                jobotJobotStage5FrogTextcControls.enabled = false;
                jobotJobotStage5FrogTextdWarning.enabled = false;
                jobotJobotStage5FrogTextrEaten.enabled = false;
                jobotJobotStage5FrogTextf.enabled = false;
                jobotJobotStage5FrogTextg.enabled = false;
                jobotJobotStage5FrogTexth.enabled = false;
                jobotJobotStage5FrogTexti.enabled = false;
                jobotJobotStage5FrogTextj.enabled = false;


                TTSJobotStage5Frog.gameObject.SetActive(true);
                TTSJobotStage5Froga.gameObject.SetActive(false);
                TTSJobotStage5Frogb.gameObject.SetActive(false);
                TTSJobotStage5FrogcControls.gameObject.SetActive(false);
                TTSJobotStage5FrogdWarning.gameObject.SetActive(false);
                TTSJobotStage5FrogeEaten.gameObject.SetActive(false);
                TTSJobotStage5Frogf.gameObject.SetActive(false);
                TTSJobotStage5Frogg.gameObject.SetActive(false);
                TTSJobotStage5Frogh.gameObject.SetActive(false);
                TTSJobotStage5Frogi.gameObject.SetActive(false);
                TTSJobotStage5Frogj.gameObject.SetActive(false);
                if (!progressTextIsShowing)
                { // 3 second delay
                    StartCoroutine(DelayProgressButtonVar1());
                    progressTextIsShowing = true;
                }
            }

            if (currentStage3FrogText == 2)
            {
                if (!textBeenRead)
                {
                    progressText.gameObject.SetActive(false);
                }
                progressTextBack.gameObject.SetActive(true);

                jobotJobotStage5FrogText.enabled = false;
                jobotJobotStage5FrogTexta.enabled = true;
                jobotJobotStage5FrogTextb.enabled = false;
                jobotJobotStage5FrogTextcControls.enabled = false;
                jobotJobotStage5FrogTextdWarning.enabled = false;
                jobotJobotStage5FrogTextrEaten.enabled = false;
                jobotJobotStage5FrogTextf.enabled = false;
                jobotJobotStage5FrogTextg.enabled = false;
                jobotJobotStage5FrogTexth.enabled = false;
                jobotJobotStage5FrogTexti.enabled = false;
                jobotJobotStage5FrogTextj.enabled = false;


                TTSJobotStage5Frog.gameObject.SetActive(false);
                TTSJobotStage5Froga.gameObject.SetActive(true);
                TTSJobotStage5Frogb.gameObject.SetActive(false);
                TTSJobotStage5FrogcControls.gameObject.SetActive(false);
                TTSJobotStage5FrogdWarning.gameObject.SetActive(false);
                TTSJobotStage5FrogeEaten.gameObject.SetActive(false);
                TTSJobotStage5Frogf.gameObject.SetActive(false);
                TTSJobotStage5Frogg.gameObject.SetActive(false);
                TTSJobotStage5Frogh.gameObject.SetActive(false);
                TTSJobotStage5Frogi.gameObject.SetActive(false);
                TTSJobotStage5Frogj.gameObject.SetActive(false);
                if (!progressTextIsShowing)
                { // 3 second delay
                    StartCoroutine(DelayProgressButtonVar2());
                    progressTextIsShowing = true;
                }
            }

            if (currentStage3FrogText == 3)
            {

                if (!textBeenRead)
                {
                    progressText.gameObject.SetActive(false);
                }
                jobotJobotStage5FrogText.enabled = false;
                jobotJobotStage5FrogTexta.enabled = false;
                jobotJobotStage5FrogTextb.enabled = true;
                jobotJobotStage5FrogTextcControls.enabled = false;
                jobotJobotStage5FrogTextdWarning.enabled = false;
                jobotJobotStage5FrogTextrEaten.enabled = false;
                jobotJobotStage5FrogTextf.enabled = false;
                jobotJobotStage5FrogTextg.enabled = false;
                jobotJobotStage5FrogTexth.enabled = false;
                jobotJobotStage5FrogTexti.enabled = false;
                jobotJobotStage5FrogTextj.enabled = false;


                TTSJobotStage5Frog.gameObject.SetActive(false);
                TTSJobotStage5Froga.gameObject.SetActive(false);
                TTSJobotStage5Frogb.gameObject.SetActive(true);
                TTSJobotStage5FrogcControls.gameObject.SetActive(false);
                TTSJobotStage5FrogdWarning.gameObject.SetActive(false);
                TTSJobotStage5FrogeEaten.gameObject.SetActive(false);
                TTSJobotStage5Frogf.gameObject.SetActive(false);
                TTSJobotStage5Frogg.gameObject.SetActive(false);
                TTSJobotStage5Frogh.gameObject.SetActive(false);
                TTSJobotStage5Frogi.gameObject.SetActive(false);
                TTSJobotStage5Frogj.gameObject.SetActive(false);

                if (!progressTextIsShowing)
                { // 3 second delay
                    StartCoroutine(DelayProgressButtonVar1());
                    progressTextIsShowing = true;
                }

            }

            if (currentStage3FrogText == 4)
            {

                if (!textBeenRead)
                {
                    progressText.gameObject.SetActive(false);
                }
                jobotJobotStage5FrogText.enabled = false;
                jobotJobotStage5FrogTexta.enabled = false;
                jobotJobotStage5FrogTextb.enabled = false;
                jobotJobotStage5FrogTextcControls.enabled = true;
                jobotJobotStage5FrogTextdWarning.enabled = false;
                jobotJobotStage5FrogTextrEaten.enabled = false;
                jobotJobotStage5FrogTextf.enabled = false;
                jobotJobotStage5FrogTextg.enabled = false;
                jobotJobotStage5FrogTexth.enabled = false;
                jobotJobotStage5FrogTexti.enabled = false;
                jobotJobotStage5FrogTextj.enabled = false;


                TTSJobotStage5Frog.gameObject.SetActive(false);
                TTSJobotStage5Froga.gameObject.SetActive(false);
                TTSJobotStage5Frogb.gameObject.SetActive(false);
                TTSJobotStage5FrogcControls.gameObject.SetActive(true);
                TTSJobotStage5FrogdWarning.gameObject.SetActive(false);
                TTSJobotStage5FrogeEaten.gameObject.SetActive(false);
                TTSJobotStage5Frogf.gameObject.SetActive(false);
                TTSJobotStage5Frogg.gameObject.SetActive(false);
                TTSJobotStage5Frogh.gameObject.SetActive(false);
                TTSJobotStage5Frogi.gameObject.SetActive(false);
                TTSJobotStage5Frogj.gameObject.SetActive(false);
                if (!progressTextIsShowing)
                { // 3 second delay
                    StartCoroutine(DelayProgressButtonVar1());
                    progressTextIsShowing = true;
                }
            }

            if (currentStage3FrogText == 5)
            {

               
                jobotJobotStage5FrogText.enabled = false;
                jobotJobotStage5FrogTexta.enabled = false;
                jobotJobotStage5FrogTextb.enabled = false;
                jobotJobotStage5FrogTextcControls.enabled = false;
                jobotJobotStage5FrogTextdWarning.enabled = true;
                jobotJobotStage5FrogTextrEaten.enabled = false;
                jobotJobotStage5FrogTextf.enabled = false;
                jobotJobotStage5FrogTextg.enabled = false;
                jobotJobotStage5FrogTexth.enabled = false;
                jobotJobotStage5FrogTexti.enabled = false;
                jobotJobotStage5FrogTextj.enabled = false;


                TTSJobotStage5Frog.gameObject.SetActive(false);
                TTSJobotStage5Froga.gameObject.SetActive(false);
                TTSJobotStage5Frogb.gameObject.SetActive(false);
                TTSJobotStage5FrogcControls.gameObject.SetActive(false);
                TTSJobotStage5FrogdWarning.gameObject.SetActive(true);
                TTSJobotStage5FrogeEaten.gameObject.SetActive(false);
                TTSJobotStage5Frogf.gameObject.SetActive(false);
                TTSJobotStage5Frogg.gameObject.SetActive(false);
                TTSJobotStage5Frogh.gameObject.SetActive(false);
                TTSJobotStage5Frogi.gameObject.SetActive(false);
                TTSJobotStage5Frogj.gameObject.SetActive(false);
                rgFrogCont.enabled = true;
                progressText.gameObject.SetActive(false);
                StartCoroutine(CloseTextPanal());
            }

            if (currentStage3FrogText == 6)
            {

                textPanal.SetActive(true);
                jobotJobotStage5FrogText.enabled = false;
                jobotJobotStage5FrogTexta.enabled = false;
                jobotJobotStage5FrogTextb.enabled = false;
                jobotJobotStage5FrogTextcControls.enabled = false;
                jobotJobotStage5FrogTextdWarning.enabled = false;
                jobotJobotStage5FrogTextrEaten.enabled = true;
                jobotJobotStage5FrogTextf.enabled = false;
                jobotJobotStage5FrogTextg.enabled = false;
                jobotJobotStage5FrogTexth.enabled = false;
                jobotJobotStage5FrogTexti.enabled = false;
                jobotJobotStage5FrogTextj.enabled = false;


                TTSJobotStage5Frog.gameObject.SetActive(false);
                TTSJobotStage5Froga.gameObject.SetActive(false);
                TTSJobotStage5Frogb.gameObject.SetActive(false);
                TTSJobotStage5FrogcControls.gameObject.SetActive(false);
                TTSJobotStage5FrogdWarning.gameObject.SetActive(false);
                TTSJobotStage5FrogeEaten.gameObject.SetActive(true);
                TTSJobotStage5Frogf.gameObject.SetActive(false);
                TTSJobotStage5Frogg.gameObject.SetActive(false);
                TTSJobotStage5Frogh.gameObject.SetActive(false);
                TTSJobotStage5Frogi.gameObject.SetActive(false);
                TTSJobotStage5Frogj.gameObject.SetActive(false);
                StartCoroutine(CloseTextPanal());
            }

            if (currentStage3FrogText == 7)
            {
                if (!textBeenRead)
                {
                    progressText.gameObject.SetActive(false);
                }
                textPanal.SetActive(true);
                rgFrogCont.enabled = false;
                jobotJobotStage5FrogText.enabled = false;
                jobotJobotStage5FrogTexta.enabled = false;
                jobotJobotStage5FrogTextb.enabled = false;
                jobotJobotStage5FrogTextcControls.enabled = false;
                jobotJobotStage5FrogTextdWarning.enabled = false;
                jobotJobotStage5FrogTextrEaten.enabled = false;
                jobotJobotStage5FrogTextf.enabled = true;
                jobotJobotStage5FrogTextg.enabled = false;
                jobotJobotStage5FrogTexth.enabled = false;
                jobotJobotStage5FrogTexti.enabled = false;
                jobotJobotStage5FrogTextj.enabled = false;


                TTSJobotStage5Frog.gameObject.SetActive(false);
                TTSJobotStage5Froga.gameObject.SetActive(false);
                TTSJobotStage5Frogb.gameObject.SetActive(false);
                TTSJobotStage5FrogcControls.gameObject.SetActive(false);
                TTSJobotStage5FrogdWarning.gameObject.SetActive(false);
                TTSJobotStage5FrogeEaten.gameObject.SetActive(false);
                TTSJobotStage5Frogf.gameObject.SetActive(true);
                TTSJobotStage5Frogg.gameObject.SetActive(false);
                TTSJobotStage5Frogh.gameObject.SetActive(false);
                TTSJobotStage5Frogi.gameObject.SetActive(false);
                TTSJobotStage5Frogj.gameObject.SetActive(false);
                progressText.gameObject.SetActive(true);
                if (!progressTextIsShowing)
                { // 3 second delay
                    StartCoroutine(DelayProgressButtonVar2());
                    progressTextIsShowing = true;
                }
            }

            if (currentStage3FrogText == 8)
            {
                if (!textBeenRead)
                {
                    progressText.gameObject.SetActive(false);
                }
                jobotJobotStage5FrogText.enabled = false;
                jobotJobotStage5FrogTexta.enabled = false;
                jobotJobotStage5FrogTextb.enabled = false;
                jobotJobotStage5FrogTextcControls.enabled = false;
                jobotJobotStage5FrogTextdWarning.enabled = false;
                jobotJobotStage5FrogTextrEaten.enabled = false;
                jobotJobotStage5FrogTextf.enabled = false;
                jobotJobotStage5FrogTextg.enabled = true;
                jobotJobotStage5FrogTexth.enabled = false;
                jobotJobotStage5FrogTexti.enabled = false;
                jobotJobotStage5FrogTextj.enabled = false;


                TTSJobotStage5Frog.gameObject.SetActive(false);
                TTSJobotStage5Froga.gameObject.SetActive(false);
                TTSJobotStage5Frogb.gameObject.SetActive(false);
                TTSJobotStage5FrogcControls.gameObject.SetActive(false);
                TTSJobotStage5FrogdWarning.gameObject.SetActive(false);
                TTSJobotStage5FrogeEaten.gameObject.SetActive(false);
                TTSJobotStage5Frogf.gameObject.SetActive(false);
                TTSJobotStage5Frogg.gameObject.SetActive(true);
                TTSJobotStage5Frogh.gameObject.SetActive(false);
                TTSJobotStage5Frogi.gameObject.SetActive(false);
                TTSJobotStage5Frogj.gameObject.SetActive(false);
                if (!progressTextIsShowing)
                { // 3 second delay
                    StartCoroutine(DelayProgressButtonVar2());
                    progressTextIsShowing = true;
                }
            }

            if (currentStage3FrogText == 9)
            {

                if (!textBeenRead)
                {
                    progressText.gameObject.SetActive(false);
                }
                jobotJobotStage5FrogText.enabled = false;
                jobotJobotStage5FrogTexta.enabled = false;
                jobotJobotStage5FrogTextb.enabled = false;
                jobotJobotStage5FrogTextcControls.enabled = false;
                jobotJobotStage5FrogTextdWarning.enabled = false;
                jobotJobotStage5FrogTextrEaten.enabled = false;
                jobotJobotStage5FrogTextf.enabled = false;
                jobotJobotStage5FrogTextg.enabled = true;
                jobotJobotStage5FrogTexth.enabled = false;
                jobotJobotStage5FrogTexti.enabled = false;
                jobotJobotStage5FrogTextj.enabled = false;


                TTSJobotStage5Frog.gameObject.SetActive(false);
                TTSJobotStage5Froga.gameObject.SetActive(false);
                TTSJobotStage5Frogb.gameObject.SetActive(false);
                TTSJobotStage5FrogcControls.gameObject.SetActive(false);
                TTSJobotStage5FrogdWarning.gameObject.SetActive(false);
                TTSJobotStage5FrogeEaten.gameObject.SetActive(false);
                TTSJobotStage5Frogf.gameObject.SetActive(false);
                TTSJobotStage5Frogg.gameObject.SetActive(true);
                TTSJobotStage5Frogh.gameObject.SetActive(false);
                TTSJobotStage5Frogi.gameObject.SetActive(false);
                TTSJobotStage5Frogj.gameObject.SetActive(false);
                if (!progressTextIsShowing)
                { // 3 second delay
                    StartCoroutine(DelayProgressButton());
                    progressTextIsShowing = true;
                }
            }

            if (currentStage3FrogText == 10)
            {
                if (!textBeenRead)
                {
                    progressText.gameObject.SetActive(false);
                }
                jobotJobotStage5FrogText.enabled = false;
                jobotJobotStage5FrogTexta.enabled = false;
                jobotJobotStage5FrogTextb.enabled = false;
                jobotJobotStage5FrogTextcControls.enabled = false;
                jobotJobotStage5FrogTextdWarning.enabled = false;
                jobotJobotStage5FrogTextrEaten.enabled = false;
                jobotJobotStage5FrogTextf.enabled = false;
                jobotJobotStage5FrogTextg.enabled = false;
                jobotJobotStage5FrogTexth.enabled = true;
                jobotJobotStage5FrogTexti.enabled = false;
                jobotJobotStage5FrogTextj.enabled = false;


                TTSJobotStage5Frog.gameObject.SetActive(false);
                TTSJobotStage5Froga.gameObject.SetActive(false);
                TTSJobotStage5Frogb.gameObject.SetActive(false);
                TTSJobotStage5FrogcControls.gameObject.SetActive(false);
                TTSJobotStage5FrogdWarning.gameObject.SetActive(false);
                TTSJobotStage5FrogeEaten.gameObject.SetActive(false);
                TTSJobotStage5Frogf.gameObject.SetActive(false);
                TTSJobotStage5Frogg.gameObject.SetActive(false);
                TTSJobotStage5Frogh.gameObject.SetActive(true);
                TTSJobotStage5Frogi.gameObject.SetActive(false);
                TTSJobotStage5Frogj.gameObject.SetActive(false);
                if (!progressTextIsShowing)
                { // 3 second delay
                    StartCoroutine(DelayProgressButtonVar2());
                    progressTextIsShowing = true;
                }
            }


            if (currentStage3FrogText == 11)
            {
                if (!textBeenRead)
                {
                    progressText.gameObject.SetActive(false);
                }
                jobotJobotStage5FrogText.enabled = false;
                jobotJobotStage5FrogTexta.enabled = false;
                jobotJobotStage5FrogTextb.enabled = false;
                jobotJobotStage5FrogTextcControls.enabled = false;
                jobotJobotStage5FrogTextdWarning.enabled = false;
                jobotJobotStage5FrogTextrEaten.enabled = false;
                jobotJobotStage5FrogTextf.enabled = false;
                jobotJobotStage5FrogTextg.enabled = false;
                jobotJobotStage5FrogTexth.enabled = false;
                jobotJobotStage5FrogTexti.enabled = true;
                jobotJobotStage5FrogTextj.enabled = false;


                TTSJobotStage5Frog.gameObject.SetActive(false);
                TTSJobotStage5Froga.gameObject.SetActive(false);
                TTSJobotStage5Frogb.gameObject.SetActive(false);
                TTSJobotStage5FrogcControls.gameObject.SetActive(false);
                TTSJobotStage5FrogdWarning.gameObject.SetActive(false);
                TTSJobotStage5FrogeEaten.gameObject.SetActive(false);
                TTSJobotStage5Frogf.gameObject.SetActive(false);
                TTSJobotStage5Frogg.gameObject.SetActive(false);
                TTSJobotStage5Frogh.gameObject.SetActive(false);
                TTSJobotStage5Frogi.gameObject.SetActive(true);
                TTSJobotStage5Frogj.gameObject.SetActive(false);
                if (!progressTextIsShowing)
                { // 3 second delay
                    StartCoroutine(DelayProgressButtonVar2());
                    progressTextIsShowing = true;
                }

            }

            if (currentStage3FrogText == 12)
            {

                jobotJobotStage5FrogText.enabled = false;
                jobotJobotStage5FrogTexta.enabled = false;
                jobotJobotStage5FrogTextb.enabled = false;
                jobotJobotStage5FrogTextcControls.enabled = false;
                jobotJobotStage5FrogTextdWarning.enabled = false;
                jobotJobotStage5FrogTextrEaten.enabled = false;
                jobotJobotStage5FrogTextf.enabled = false;
                jobotJobotStage5FrogTextg.enabled = false;
                jobotJobotStage5FrogTexth.enabled = false;
                jobotJobotStage5FrogTexti.enabled = false;
                jobotJobotStage5FrogTextj.enabled = true;


                TTSJobotStage5Frog.gameObject.SetActive(false);
                TTSJobotStage5Froga.gameObject.SetActive(false);
                TTSJobotStage5Frogb.gameObject.SetActive(false);
                TTSJobotStage5FrogcControls.gameObject.SetActive(false);
                TTSJobotStage5FrogdWarning.gameObject.SetActive(false);
                TTSJobotStage5FrogeEaten.gameObject.SetActive(false);
                TTSJobotStage5Frogf.gameObject.SetActive(false);
                TTSJobotStage5Frogg.gameObject.SetActive(false);
                TTSJobotStage5Frogh.gameObject.SetActive(false);
                TTSJobotStage5Frogi.gameObject.SetActive(false);
                TTSJobotStage5Frogj.gameObject.SetActive(true);
                progressText.gameObject.SetActive(false);
                frogCharacter.gameObject.SetActive(false);
                rgFrogCont.enabled = false;
                robCont.enabled = true;
                playerCamera.enabled = true;
                //frogLevelItems.SetActive(false);
                StartCoroutine(CloseTextPanal());
                frogAnim.enabled = false;
                susanArrowToReset.SetActive(true);
                susan2ArrowToReset.SetActive(true);
                lima2ArrowToReset.SetActive(true);
                limaArrowToReset.SetActive(true);
                daisyArrowToReset.SetActive(true);
                daisy2ArrowToReset.SetActive(true);
                radishArrowToReset.SetActive(true);
                radish2ArrowToReset.SetActive(true);
                if (!hasSavingHappenBefore)
                {
                    rgMain.SaveStage5FrogMiniGameComplete();
                    rgMain.SavePlayerPos();
                    hasSavingHappenBefore = true;
                    robotNavMeshAgentToStop.GetComponent<NavMeshAgent>().isStopped = false;
                    // StartCoroutine(CloseTextPanal());
                }

            }

            if (currentStage3FrogText == 13)
            {
                textPanal.gameObject.SetActive(false);
                jobotJobotStage5FrogText.enabled = false;
                jobotJobotStage5FrogTexta.enabled = false;
                jobotJobotStage5FrogTextb.enabled = false;
                jobotJobotStage5FrogTextcControls.enabled = false;
                jobotJobotStage5FrogTextdWarning.enabled = false;
                jobotJobotStage5FrogTextrEaten.enabled = false;
                jobotJobotStage5FrogTextf.enabled = false;
                jobotJobotStage5FrogTextg.enabled = false;
                jobotJobotStage5FrogTexth.enabled = false;
                jobotJobotStage5FrogTexti.enabled = false;
                jobotJobotStage5FrogTextj.enabled = false;


                TTSJobotStage5Frog.gameObject.SetActive(false);
                TTSJobotStage5Froga.gameObject.SetActive(false);
                TTSJobotStage5Frogb.gameObject.SetActive(false);
                TTSJobotStage5FrogcControls.gameObject.SetActive(false);
                TTSJobotStage5FrogdWarning.gameObject.SetActive(false);
                TTSJobotStage5FrogeEaten.gameObject.SetActive(false);
                TTSJobotStage5Frogf.gameObject.SetActive(false);
                TTSJobotStage5Frogg.gameObject.SetActive(false);
                TTSJobotStage5Frogh.gameObject.SetActive(false);
                TTSJobotStage5Frogi.gameObject.SetActive(false);
                TTSJobotStage5Frogj.gameObject.SetActive(false);

                // StartCoroutine(CloseTextFinalTime());
            }


        }

     

        void OnClick()
        {
            currentStage3FrogText++;
            textBeenRead = false;
            progressTextIsShowing = false;
        }

        void OnClickBack()
        {
            currentStage3FrogText--;
        }

        void JobotStage4FrogMG1()
        {
            LOLSDK.Instance.SpeakText("jobotStage5FrogMiniGame");
        }

        void JobotStage4FrogMG2()
        {
            LOLSDK.Instance.SpeakText("jobotStage5FrogMiniGamea");
        }

        void JobotStage4FrogMG3()
        {
            LOLSDK.Instance.SpeakText("jobotStage5FrogMiniGameb");
        }
        void JobotStage4FrogMG4()
        {
            LOLSDK.Instance.SpeakText("jobotStage5FrogMiniGameControls");
        }

        void JobotStage4FrogMG5()
        {
            LOLSDK.Instance.SpeakText("jobotStage5FrogMiniGameDwarning");
        }

        void JobotStage4FrogMG6()
        {
            LOLSDK.Instance.SpeakText("jobotStage5FrogMiniGameEaten");
        }

        void JobotStage4FrogMG7()
        {
            LOLSDK.Instance.SpeakText("jobotStage5FrogMiniGamef");
        }

        void JobotStage4FrogMG8()
        {

            LOLSDK.Instance.SpeakText("jobotStage5FrogMiniGameg");
        }

        void JobotStage4FrogMG9()
        {
            LOLSDK.Instance.SpeakText("jobotStage5FrogMiniGameh");

        }


        void JobotStage4FrogMG10()
        {

            LOLSDK.Instance.SpeakText("jobotStage5FrogMiniGamei");
        }

        void JobotStage4FrogMG11()
        {
            LOLSDK.Instance.SpeakText("jobotStage5FrogMiniGamej");

        }


        public IEnumerator CloseTextPanal()
        {
            yield return new WaitForSeconds(5);
            currentStage3FrogText = 13;

        }

        public IEnumerator CloseTextFinalTime()
        {
            yield return new WaitForSeconds(5);
            currentStage3FrogText = 13;

        }


        public IEnumerator DelayProgressButton()
        {
            yield return new WaitForSeconds(3);
            progressText.gameObject.SetActive(true);
            textBeenRead = true;

        }

        public IEnumerator DelayProgressButtonVar2()
        {
            yield return new WaitForSeconds(2);
            progressText.gameObject.SetActive(true);
            textBeenRead = true;

        }

        public IEnumerator DelayProgressButtonVar1()
        {
            yield return new WaitForSeconds(1);
            progressText.gameObject.SetActive(true);
            textBeenRead = true;

        }
    }
}
