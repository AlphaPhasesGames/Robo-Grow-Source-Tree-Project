using System.Collections;
using UnityEngine;
using LoLSDK;
using UnityEngine.UI;
using UnityEngine.AI;
using TMPro;

namespace Alpha.Phases.Robo.Grow
{
    public class RoboGrowStage4FrogMiniGame : MonoBehaviour
    {
        public RobotController robCont;
        public GameObject robotNavMeshAgentToStop;
        public RoboGrowMain rgMain;
        public RoboGrowFrogController rgFrogCont;

        public GameObject susanArrowToReset;
        public GameObject susan2ArrowToReset;
        public GameObject limaArrowToReset;
        public GameObject lima2ArrowToReset;
        public GameObject daisyArrowToReset;
        public GameObject daisy2ArrowToReset;
        public GameObject radishArrowToReset;
        public GameObject radish2ArrowToReset;

        public Camera playerCamera;
        public Camera frogCam;
        public Camera mainCam;

        public bool textBeenRead;
        public bool progressTextIsShowing;

        public AudioSource frogCroak;
        public AudioSource musicToStop;

        public GameObject robotCharacter;
        public GameObject frogCharacter;

        public GameObject frogLevelItems;

        public GameObject triggerArrow;

        public bool hasSavingHappenBefore;

        public GameObject textPanal;

        public Button progressText;
       public Button progressTextBack;

        public Button TTSJobotStage4Frog;
        public Button TTSJobotStage4Froga;
        public Button TTSJobotStage4FrogaControls;
        public Button TTSJobotStage4Frogb;
        public Button TTSJobotStage4Frogc;
        public Button TTSJobotStage4Frogd;
        public Button TTSJobotStage4FrogdCloser;
        public Button TTSJobotStage4Froge;
        public Button TTSJobotStage4Frogf;
        public Button TTSJobotStage4FrogEaten;

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

        public BoxCollider frogStopper1;
        public BoxCollider frogStopper2;
        public BoxCollider frogStopper3;
        public BoxCollider frogStopper4;
        public BoxCollider frogStopper5;
        public BoxCollider frogStopper6;
        public BoxCollider frogStopper7;
        public BoxCollider frogStopper8;

        public TextMeshProUGUI jobotJobotStage4FrogText;
        public TextMeshProUGUI jobotJobotStage4FrogTexta;
        public TextMeshProUGUI jobotJobotStage4FrogTextaControls;
        public TextMeshProUGUI jobotJobotStage4FrogTextb;
        public TextMeshProUGUI jobotJobotStage4FrogTextc;
        public TextMeshProUGUI jobotJobotStage4FrogTextd;
        public TextMeshProUGUI jobotJobotStage4FrogTextdCloser;
        public TextMeshProUGUI jobotJobotStage4FrogTexte;
        public TextMeshProUGUI jobotJobotStage4FrogTextf;
        public TextMeshProUGUI jobotJobotStage4Eaten;
        public int currentStage3FrogText;

        private void Awake()
        {
            currentStage3FrogText = 0;
            progressText.onClick.AddListener(OnClick);
            progressTextBack.onClick.AddListener(OnClickBack);

            TTSJobotStage4Frog.onClick.AddListener(JobotStage4FrogMG1);
            TTSJobotStage4Froga.onClick.AddListener(JobotStage4FrogMG2);
            TTSJobotStage4FrogaControls.onClick.AddListener(JobotStage4FrogMG3);
            TTSJobotStage4Frogb.onClick.AddListener(JobotStage4FrogMG4);
            TTSJobotStage4Frogc.onClick.AddListener(JobotStage4FrogMG5);
            TTSJobotStage4Frogd.onClick.AddListener(JobotStage4FrogMG6);
            TTSJobotStage4FrogdCloser.onClick.AddListener(JobotStage4FrogMG6Closer);
            TTSJobotStage4Froge.onClick.AddListener(JobotStage4FrogMG7);
            TTSJobotStage4Frogf.onClick.AddListener(JobotStage4FrogMG8);
            TTSJobotStage4FrogEaten.onClick.AddListener(JobotStage4FrogEaten);
        }

        // Start is called before the first frame update
        void Start()
        {
       

        }

        // Update is called once per frame
        void Update()
        {

            if (currentStage3FrogText == 1)
            {
                if (!textRead1)
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
                    frogCroak.Play();
                    musicToStop.Stop();
                    robCont.enabled = false;
                    playerCamera.enabled = false;
                    jobotJobotStage4FrogText.gameObject.SetActive(true);
                    jobotJobotStage4FrogTexta.gameObject.SetActive(false);


                    if (!progressTextIsShowing)
                    { // 3 second delay
                        StartCoroutine(DelayProgressButtonVar2());
                        progressTextIsShowing = true;
                    }
                    textRead1 = true;
                }
  
            }

            if (currentStage3FrogText == 2)
            {
                if (!textRead2)
                {
                    if (!textBeenRead)
                    {
                        progressText.gameObject.SetActive(false);
                    }
                    progressTextBack.gameObject.SetActive(true);

                    jobotJobotStage4FrogText.gameObject.SetActive(false);
                    jobotJobotStage4FrogTexta.gameObject.SetActive(true);
                    jobotJobotStage4FrogTextaControls.gameObject.SetActive(false);

                    if (!progressTextIsShowing)
                    { // 3 second delay
                        StartCoroutine(DelayProgressButtonVar1());
                        progressTextIsShowing = true;
                    }

                    textRead2 = true;
                }
               
            }

            if (currentStage3FrogText == 3)
            {
                if (!textRead3) 
                {
                    if (!textBeenRead)
                    {
                        progressText.gameObject.SetActive(false);
                    }

                    jobotJobotStage4FrogTexta.gameObject.SetActive(false);
                    jobotJobotStage4FrogTextaControls.gameObject.SetActive(true);
                    jobotJobotStage4FrogTextb.gameObject.SetActive(false);

                    if (!progressTextIsShowing)
                    { // 3 second delay
                        StartCoroutine(DelayProgressButtonVar2());
                        progressTextIsShowing = true;
                    }
                    textRead3 = true;
                }
               
            }

            if (currentStage3FrogText == 4)
            {
                if (!textRead4)
                {
                    if (!textBeenRead)
                    {
                        progressText.gameObject.SetActive(false);
                    }

                    jobotJobotStage4FrogTextaControls.gameObject.SetActive(false);
                    jobotJobotStage4FrogTextb.gameObject.SetActive(true);
                    jobotJobotStage4FrogTextc.gameObject.SetActive(false);

                    if (!progressTextIsShowing)
                    { // 3 second delay
                        StartCoroutine(DelayProgressButton());
                        progressTextIsShowing = true;
                    }

                    textRead4 = true;
                }
           
            }

            if (currentStage3FrogText == 5)
            {
                if (!textRead5)
                {

                    jobotJobotStage4FrogTextb.gameObject.SetActive(false);
                    jobotJobotStage4FrogTextc.gameObject.SetActive(true);
                    jobotJobotStage4FrogTextd.gameObject.SetActive(false);

                    rgFrogCont.enabled = true;
                    progressTextBack.gameObject.SetActive(false);
                    progressText.gameObject.SetActive(false);
                    // StartCoroutine(CloseTextPanal());

                    textRead5 = true;
                }

            }

            if (currentStage3FrogText == 6)
            {
                if (!textRead6)
                {
                    textPanal.SetActive(true);

                    jobotJobotStage4FrogTextc.gameObject.SetActive(false);
                    jobotJobotStage4FrogTextd.gameObject.SetActive(true);
                    jobotJobotStage4FrogTextdCloser.gameObject.SetActive(false);

                    textRead6 = true;
                    // StartCoroutine(CloseTextPanal());
                }

            }

            if (currentStage3FrogText == 7)
            {
                if (!textRead7)
                {
                    textPanal.SetActive(true);
                    jobotJobotStage4FrogText.enabled = false;

                    jobotJobotStage4FrogTextc.gameObject.SetActive(true);
                    jobotJobotStage4FrogTextd.gameObject.SetActive(false);
                    jobotJobotStage4FrogTextdCloser.gameObject.SetActive(true);
                    jobotJobotStage4FrogTexte.gameObject.SetActive(false);

                    StartCoroutine(CloseTextPanal());
                    textRead7 = true;
                }
              

            }

            if (currentStage3FrogText == 8)
            {
                if (!textRead8)
                {
                    if (!textBeenRead)
                    {
                        progressText.gameObject.SetActive(false);
                    }
                    textPanal.SetActive(true);
                    rgFrogCont.enabled = false;
                    jobotJobotStage4FrogTextc.gameObject.SetActive(true);
                    jobotJobotStage4FrogTextdCloser.gameObject.SetActive(false);
                    jobotJobotStage4FrogTexte.gameObject.SetActive(true);
                    jobotJobotStage4FrogTextf.gameObject.SetActive(false);

                    progressText.gameObject.SetActive(true);
                    textRead8 = true;
                }
              
            }

            if (currentStage3FrogText == 9)
            {
                if (!textRead9)
                {
                    if (!textBeenRead)
                    {
                        progressText.gameObject.SetActive(false);
                    }
                    jobotJobotStage4FrogTextc.gameObject.SetActive(true);
                    jobotJobotStage4FrogTexte.gameObject.SetActive(false);
                    jobotJobotStage4FrogTextf.gameObject.SetActive(true);

                    StartCoroutine(CloseTextFinalTime());
                    textRead9 = true;
                }
            
            }

            if (currentStage3FrogText == 10)
            {
                if (!textRead10)
                {
                    textPanal.SetActive(false);
                    jobotJobotStage4FrogText.gameObject.SetActive(false);
                    jobotJobotStage4FrogTexta.gameObject.SetActive(false);
                    jobotJobotStage4FrogTextaControls.gameObject.SetActive(false);
                    jobotJobotStage4FrogTextb.gameObject.SetActive(false);
                    jobotJobotStage4FrogTextc.gameObject.SetActive(false);
                    jobotJobotStage4FrogTextd.gameObject.SetActive(false);
                    jobotJobotStage4FrogTextdCloser.gameObject.SetActive(false);
                    jobotJobotStage4FrogTexte.gameObject.SetActive(false);
                    jobotJobotStage4FrogTextf.gameObject.SetActive(false);

                    TTSJobotStage4Frog.gameObject.SetActive(false);
                    TTSJobotStage4Froga.gameObject.SetActive(false);
                    TTSJobotStage4FrogaControls.gameObject.SetActive(false);
                    TTSJobotStage4Frogb.gameObject.SetActive(false);
                    TTSJobotStage4Frogc.gameObject.SetActive(false);
                    TTSJobotStage4Frogd.gameObject.SetActive(false);
                    TTSJobotStage4FrogdCloser.gameObject.SetActive(false);
                    TTSJobotStage4Froge.gameObject.SetActive(false);
                    TTSJobotStage4Frogf.gameObject.SetActive(false);

                    jobotJobotStage4Eaten.gameObject.SetActive(false);
                    TTSJobotStage4FrogEaten.gameObject.SetActive(false);

                    textRead10 = true;
                }
             
            }


            if (currentStage3FrogText == 11)
            {
                if (!textRead11)
                {
                    textPanal.SetActive(false);
                    jobotJobotStage4FrogText.gameObject.SetActive(false);
                    jobotJobotStage4FrogTexta.gameObject.SetActive(false);
                    jobotJobotStage4FrogTextaControls.gameObject.SetActive(false);
                    jobotJobotStage4FrogTextb.gameObject.SetActive(false);
                    jobotJobotStage4FrogTextc.gameObject.SetActive(false);
                    jobotJobotStage4FrogTextd.gameObject.SetActive(false);
                    jobotJobotStage4FrogTextdCloser.gameObject.SetActive(false);
                    jobotJobotStage4FrogTexte.gameObject.SetActive(false);
                    jobotJobotStage4FrogTextf.gameObject.SetActive(false);


                    jobotJobotStage4Eaten.gameObject.SetActive(false);


                    frogCharacter.gameObject.SetActive(false);
                    rgFrogCont.enabled = false;
                    frogCroak.Stop();
                    musicToStop.Play();

                    susanArrowToReset.SetActive(true);
                    susan2ArrowToReset.SetActive(true);
                    lima2ArrowToReset.SetActive(true);
                    limaArrowToReset.SetActive(true);
                    daisyArrowToReset.SetActive(true);
                    daisy2ArrowToReset.SetActive(true);
                    radishArrowToReset.SetActive(true);
                    radish2ArrowToReset.SetActive(true);
                    // playerCamera.enabled = true;
                    frogLevelItems.SetActive(false);
                    if (!hasSavingHappenBefore)
                    {
                        playerCamera.gameObject.SetActive(true);
                        playerCamera.enabled = true;
                        robCont.enabled = true;
                        rgMain.SaveStage4FrogMiniGameComplete();
                        rgMain.SavePlayerPos();
                        hasSavingHappenBefore = true;
                        mainCam.enabled = false;
                        triggerArrow.SetActive(false);
                        robotNavMeshAgentToStop.GetComponent<NavMeshAgent>().isStopped = false;
                    }
                    textRead11 = true;
                }
  
               
            }

            if (currentStage3FrogText == 12)
            {
                if (!textRead12)
                {
                    textPanal.SetActive(true);

                    progressText.gameObject.SetActive(false);
                    //rgFrogCont.enabled = false;
                    jobotJobotStage4Eaten.gameObject.SetActive(true);
                    TTSJobotStage4FrogEaten.gameObject.SetActive(true);


                    StartCoroutine(CloseTextPanal());
                    textRead12 = true;
                }
              
            }

        }

        void OnMouseDown()
        {
            if (rgMain.currentGameStage == 4)
            {
                currentStage3FrogText = 1;

                robCont.NewNavmeshStop();
                playerCamera.enabled = false;
                playerCamera.gameObject.SetActive(false);
                frogCharacter.gameObject.SetActive(true);
                robCont.enabled = false;
                robotNavMeshAgentToStop.GetComponent<NavMeshAgent>().isStopped = true;
                susanArrowToReset.SetActive(false);
                susan2ArrowToReset.SetActive(false);
                lima2ArrowToReset.SetActive(false);
                limaArrowToReset.SetActive(false);
                daisyArrowToReset.SetActive(false);
                daisy2ArrowToReset.SetActive(false);
                radishArrowToReset.SetActive(false);
                radish2ArrowToReset.SetActive(false);

                frogStopper1.enabled = false;
                frogStopper2.enabled = false;
                frogStopper3.enabled = false;
                frogStopper4.enabled = false;
                frogStopper5.enabled = false;
                frogStopper6.enabled = false;
                frogStopper7.enabled = false;
                frogStopper8.enabled = false;

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

        }

        void JobotStage4FrogMG1()
        {
            LOLSDK.Instance.SpeakText("jobotStage4FrogMiniGame");
        }

        void JobotStage4FrogMG2()
        {
            LOLSDK.Instance.SpeakText("jobotStage4FrogMiniGamea");
        }

        void JobotStage4FrogMG3()
        {
            LOLSDK.Instance.SpeakText("jobotStage4FrogMiniGameaControls");
        }
        void JobotStage4FrogMG4()
        {
            LOLSDK.Instance.SpeakText("jobotStage4FrogMiniGameb");
        }

        void JobotStage4FrogMG5()
        {
            LOLSDK.Instance.SpeakText("jobotStage4FrogMiniGamec");
        }

        void JobotStage4FrogMG6()
        {
            LOLSDK.Instance.SpeakText("jobotStage4FrogMiniGamed");
        }

        void JobotStage4FrogMG6Closer()
        {
            LOLSDK.Instance.SpeakText("jobotStage4FrogMiniGamedCloser");
        }

        void JobotStage4FrogMG7()
        {

            LOLSDK.Instance.SpeakText("jobotStage4FrogMiniGamee");
        }

        void JobotStage4FrogMG8()
        {
            LOLSDK.Instance.SpeakText("jobotStage4FrogMiniGamef");

        }
        void JobotStage4FrogEaten()
        {
            LOLSDK.Instance.SpeakText("jobotStage4FrogMiniGameEaten");

        }



        public IEnumerator CloseTextPanal()
        {
            yield return new WaitForSeconds(3);
            textRead5 = false;
            currentStage3FrogText = 5;

        }

        public IEnumerator CloseTextFinalTime()
        {
            yield return new WaitForSeconds(5);
            textRead11 = false;
            currentStage3FrogText = 11;

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
