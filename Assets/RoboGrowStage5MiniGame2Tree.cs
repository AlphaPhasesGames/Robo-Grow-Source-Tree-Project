using System.Collections;
using UnityEngine;
using LoLSDK;
using UnityEngine.UI;
using UnityEngine.AI;
using TMPro;

namespace Alpha.Phases.Robo.Grow
{
    public class RoboGrowStage5MiniGame2Tree : MonoBehaviour
    {
        public RobotController robCont;
        public RoboGrowMain rgMain;
        public ButterFlyPlayerController rgBFCont;
        public GameObject robotNavMeshAgentToStop;
        public Camera playerCamera;
        public Camera butterFlyCam;
       // public GameObject frogArrowToAppear;
        public Camera butterFlyAnimationCharachterCam;

        public GameObject robotCharacter;
        public GameObject butterflyCharacter;
        public GameObject butterFlyAnimationCharachterPlayer;
        public GameObject missionArrowTodisable;

        public GameObject levelItems;

        public GameObject targetButterfly1;

        public bool textBeenRead;
        public bool progressTextIsShowing;

        public GameObject susanArrowToReset;
        public GameObject susan2ArrowToReset;
        public GameObject limaArrowToReset;
        public GameObject lima2ArrowToReset;
        public GameObject daisyArrowToReset;
        public GameObject daisy2ArrowToReset;
        public GameObject radishArrowToReset;
        public GameObject radish2ArrowToReset;

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


        public bool hasSavingHappenBefore;
        public GameObject textPanal;
        public Button TTSJobotStage5Tree1;
        public Button TTSJobotStage5Tree1a;
        public Button TTSJobotStage5Tree1b;
        public Button TTSJobotStage5Tree1c;
        public Button TTSJobotStage5Tree1d;
        public Button TTSJobotStage5Tree1e;
        public Button TTSJobotStage5Tree1f;
        public Button TTSJobotStage5Tree1WellDone;
        public Button TTSJobotStage5Tree1g;
        public Button TTSJobotStage5Tree1h;
        public Button TTSJobotStage5Tree1i;
        public Button TTSJobotStage5Tree1j;
        public Button TTSJobotStage5Tree1k;

        public TextMeshProUGUI jobotIntroStage5Tree;
        public TextMeshProUGUI jobotIntroStage5Tree1a;
        public TextMeshProUGUI jobotIntroStage5Tree1b;
        public TextMeshProUGUI jobotIntroStage5Tree1c;
        public TextMeshProUGUI jobotIntroStage5Tree1d;
        public TextMeshProUGUI jobotIntroStage5Tree1e;
        public TextMeshProUGUI jobotIntroStage5Tree1f;
        public TextMeshProUGUI jobotIntroStage5Tree1WellDone;
        public TextMeshProUGUI jobotIntroStage5Tree1g;
        public TextMeshProUGUI jobotIntroStage5Tree1h;
        public TextMeshProUGUI jobotIntroStage5Tree1i;
        public TextMeshProUGUI jobotIntroStage5Tree1j;
        public TextMeshProUGUI jobotIntroStage5Tree1k;

        public Button progressText;
        public Button progressTextBack;

        public int currentStage5TreeText;

        private void Awake()
        {
            currentStage5TreeText = 0;
            progressText.onClick.AddListener(OnClick);
            progressTextBack.onClick.AddListener(OnClickBack);

            TTSJobotStage5Tree1.onClick.AddListener(JobotStage5Tree1);
            TTSJobotStage5Tree1a.onClick.AddListener(JobotStage5Tree2);
            TTSJobotStage5Tree1b.onClick.AddListener(JobotStage5Tree3);
            TTSJobotStage5Tree1c.onClick.AddListener(JobotStage5Tree4);
            TTSJobotStage5Tree1d.onClick.AddListener(JobotStage5Tree5);
            TTSJobotStage5Tree1e.onClick.AddListener(JobotStage5Tree6);
            TTSJobotStage5Tree1f.onClick.AddListener(JobotStage5Tree7);
            TTSJobotStage5Tree1WellDone.onClick.AddListener(JobotStage5TreeWellDone);
            TTSJobotStage5Tree1g.onClick.AddListener(JobotStage5Tree8);
            TTSJobotStage5Tree1h.onClick.AddListener(JobotStage5Tree9);
            TTSJobotStage5Tree1i.onClick.AddListener(JobotStage5Tree10);
            TTSJobotStage5Tree1j.onClick.AddListener(JobotStage5Tree11);
            TTSJobotStage5Tree1k.onClick.AddListener(JobotStage5Tree12);
        }

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            if (currentStage5TreeText == 1)
            {
                if (!textRead1)
                {
                    if (!textBeenRead)
                    {
                        progressText.gameObject.SetActive(false);
                    }
                    progressTextBack.gameObject.SetActive(false);
                    robCont.enabled = false;
                    playerCamera.enabled = false;
                    butterflyCharacter.SetActive(true);
                    butterFlyCam.enabled = true;
                    rgBFCont.enabled = false;
                    //frogArrowToAppear.gameObject.SetActive(false);
                    levelItems.gameObject.SetActive(true);
                    targetButterfly1.gameObject.SetActive(true);

                    textPanal.SetActive(true);
                    jobotIntroStage5Tree.gameObject.SetActive(true);
                    jobotIntroStage5Tree1a.gameObject.SetActive(false);

                    if (!progressTextIsShowing)
                    { // 3 second delay
                        StartCoroutine(DelayProgressButtonVar1());
                        progressTextIsShowing = true;
                    }

                    textRead1 = true;
                }
              
            }

            if (currentStage5TreeText == 2)
            {
                if (!textRead2)
                {
                    if (!textBeenRead)
                    {
                        progressText.gameObject.SetActive(false);
                    }
                    progressTextBack.gameObject.SetActive(true);

                    jobotIntroStage5Tree.gameObject.SetActive(false);
                    jobotIntroStage5Tree1a.gameObject.SetActive(true);
                    jobotIntroStage5Tree1b.gameObject.SetActive(false);

                    if (!progressTextIsShowing)
                    { // 3 second delay
                        StartCoroutine(DelayProgressButtonVar1());
                        progressTextIsShowing = true;
                    }
                    textRead2 = true;
                }
            }

            if (currentStage5TreeText == 3)
            {
                if (!textRead3)
                {
                    if (!textBeenRead)
                    {
                        progressText.gameObject.SetActive(false);
                    }

                    jobotIntroStage5Tree1a.gameObject.SetActive(false);
                    jobotIntroStage5Tree1b.gameObject.SetActive(true);
                    jobotIntroStage5Tree1c.gameObject.SetActive(false);

                    if (!progressTextIsShowing)
                    { // 3 second delay
                        StartCoroutine(DelayProgressButtonVar1());
                        progressTextIsShowing = true;
                    }
                    textRead3 = true;
                }
 
            }

            if (currentStage5TreeText == 4)
            {
                if (!textRead4) 
                {
                    //jobotIntroStage5Tree1WellDone.enabled = false;
                    //TTSJobotStage5Tree1WellDone.gameObject.SetActive(false);
                    if (!textBeenRead)
                    {
                        progressText.gameObject.SetActive(false);
                    }

                    jobotIntroStage5Tree1b.gameObject.SetActive(false);
                    jobotIntroStage5Tree1c.gameObject.SetActive(true);
                    jobotIntroStage5Tree1d.gameObject.SetActive(false);
                    if (!progressTextIsShowing)
                    { // 3 second delay
                        StartCoroutine(DelayProgressButtonVar1());
                        progressTextIsShowing = true;
                    }
                    textRead4 = true;
                }
            }

            if (currentStage5TreeText == 5)
            {
                if (!textRead5)
                {
                    if (!textBeenRead)
                    {
                        progressText.gameObject.SetActive(false);
                    }

                    jobotIntroStage5Tree1c.gameObject.SetActive(false);
                    jobotIntroStage5Tree1d.gameObject.SetActive(true);
                    jobotIntroStage5Tree1e.gameObject.SetActive(false);

                    if (!progressTextIsShowing)
                    { // 3 second delay
                        StartCoroutine(DelayProgressButtonVar2());
                        progressTextIsShowing = true;
                    }
                    textRead5 = true;
                }
            }


            if (currentStage5TreeText == 6)
            {
                if (!textRead6)
                {
                    
                    jobotIntroStage5Tree1d.gameObject.SetActive(false);
                    jobotIntroStage5Tree1e.gameObject.SetActive(true);
                    jobotIntroStage5Tree1f.gameObject.SetActive(false);

                    rgBFCont.enabled = true;
                    progressText.gameObject.SetActive(false);
                    // StartCoroutine(CloseTextPanal());
                    textRead6 = true;
                }

            }

            if (currentStage5TreeText == 7)
            {
                if (!textRead8)
                {
                    textPanal.SetActive(true);
                    jobotIntroStage5Tree1e.gameObject.SetActive(false);
                    jobotIntroStage5Tree1f.gameObject.SetActive(true);
                    jobotIntroStage5Tree1g.gameObject.SetActive(false);

                    StartCoroutine(ShowQuestion());
                    textRead8 = true;
                }
              

            }


            if (currentStage5TreeText == 8)
            {
                if (!textRead8)
                {
                    if (!textBeenRead)
                    {
                        progressText.gameObject.SetActive(false);
                    }
                    //levelItems.gameObject.SetActive(false);
                    textPanal.SetActive(true);

                    jobotIntroStage5Tree1f.gameObject.SetActive(false);
                    jobotIntroStage5Tree1g.gameObject.SetActive(true);
                    jobotIntroStage5Tree1h.gameObject.SetActive(false);

                    progressText.gameObject.SetActive(true);
                    if (!progressTextIsShowing)
                    { // 3 second delay
                        StartCoroutine(DelayProgressButtonVar1());
                        progressTextIsShowing = true;
                    }
                    Debug.Log("Section 8 showed itself");
                    textRead8 = true;
                }
              
            }


            if (currentStage5TreeText == 9)
            {
                if (!textRead9)
                {
                    if (!textBeenRead)
                    {
                        progressText.gameObject.SetActive(false);
                    }
                
                    jobotIntroStage5Tree1g.gameObject.SetActive(false);
                    jobotIntroStage5Tree1h.gameObject.SetActive(true);
                    jobotIntroStage5Tree1i.gameObject.SetActive(false);

                    if (!progressTextIsShowing)
                    { // 3 second delay
                        StartCoroutine(DelayProgressButtonVar2());
                        progressTextIsShowing = true;
                    }
                    textRead9 = true;
                }
            
            }


            if (currentStage5TreeText == 10)
            {
                if (!textRead10)
                {
                    //  jobotIntroStage1e
                    if (!textBeenRead)
                    {
                        progressText.gameObject.SetActive(false);
                    }

                    jobotIntroStage5Tree1h.gameObject.SetActive(false);
                    jobotIntroStage5Tree1i.gameObject.SetActive(true);
                    jobotIntroStage5Tree1j.gameObject.SetActive(false);

                    if (!progressTextIsShowing)
                    { // 3 second delay
                        StartCoroutine(DelayProgressButtonVar2());
                        progressTextIsShowing = true;
                    }
                    textRead10 = true;
                }
          

            }

            if (currentStage5TreeText == 11)
            {
                if (!textRead11)
                {
                    if (!textBeenRead)
                    {
                        progressText.gameObject.SetActive(false);
                    }

                    jobotIntroStage5Tree1i.gameObject.SetActive(false);
                    jobotIntroStage5Tree1j.gameObject.SetActive(true);
                    jobotIntroStage5Tree1k.gameObject.SetActive(false);


                    if (!progressTextIsShowing)
                    { // 3 second delay
                        StartCoroutine(DelayProgressButtonVar2());
                        progressTextIsShowing = true;
                    }
                    textRead11 = true;
                }

            }

            if (currentStage5TreeText == 12)
            {
                if (!textRead12)
                {
                    jobotIntroStage5Tree1j.gameObject.SetActive(false);
                    jobotIntroStage5Tree1k.gameObject.SetActive(true);

                    progressText.gameObject.SetActive(false);

                    playerCamera.enabled = true;
                    butterflyCharacter.SetActive(false);
                    butterFlyCam.enabled = false;
                    butterFlyAnimationCharachterCam.enabled = false;
                    targetButterfly1.gameObject.SetActive(false);
                    butterFlyAnimationCharachterPlayer.gameObject.SetActive(false);
                    rgBFCont.enabled = false;
                    robCont.enabled = true;

                    susanArrowToReset.gameObject.SetActive(true);
                    susan2ArrowToReset.gameObject.SetActive(true);
                    lima2ArrowToReset.gameObject.SetActive(true);
                    limaArrowToReset.gameObject.SetActive(true);
                    daisyArrowToReset.gameObject.SetActive(true);
                    daisy2ArrowToReset.gameObject.SetActive(true);
                    radishArrowToReset.gameObject.SetActive(true);
                    radish2ArrowToReset.gameObject.SetActive(true);
                    if (!hasSavingHappenBefore)
                    {
                        rgMain.SaveStage5ButterlyMiniGameComplete();
                        rgMain.SavePlayerPos();
                        hasSavingHappenBefore = true;
                        StartCoroutine(CloseTextPanal());
                        missionArrowTodisable.gameObject.SetActive(false);
                        robotNavMeshAgentToStop.GetComponent<NavMeshAgent>().isStopped = false;
                    }
                    textRead12 = true;
                }
            }



            if (currentStage5TreeText == 13)
            {
                if (!textRead13)
                {
                    textPanal.SetActive(false);
                    jobotIntroStage5Tree.gameObject.SetActive(false);
                    jobotIntroStage5Tree1a.gameObject.SetActive(false);
                    jobotIntroStage5Tree1b.gameObject.SetActive(false);
                    jobotIntroStage5Tree1c.gameObject.SetActive(false);
                    jobotIntroStage5Tree1d.gameObject.SetActive(false);
                    jobotIntroStage5Tree1e.gameObject.SetActive(false);
                    jobotIntroStage5Tree1f.gameObject.SetActive(false);
                    jobotIntroStage5Tree1g.gameObject.SetActive(false);
                    jobotIntroStage5Tree1h.gameObject.SetActive(false);
                    jobotIntroStage5Tree1i.gameObject.SetActive(false);
                    jobotIntroStage5Tree1j.gameObject.SetActive(false);
                    jobotIntroStage5Tree1k.gameObject.SetActive(false);


                    textRead13 = true;
                }
            }

            if (currentStage5TreeText == 14)
            {
                if (!textRead14)
                {
                    textPanal.SetActive(true);

                    jobotIntroStage5Tree1k.enabled = false;

                    jobotIntroStage5Tree1WellDone.gameObject.SetActive(true);



                    StartCoroutine(CloseTextPanal());
                    textRead14 = true;
                }
               
            }
        }



        void OnClick()
        {
            currentStage5TreeText++;
            textBeenRead = false;
            progressTextIsShowing = false;
        }

        void OnClickBack()
        {
            currentStage5TreeText--;
            textRead1 = true;
            textRead2 = true;
            textRead3 = true;
            textRead4 = true;
            textRead5 = true;
            textRead6 = true;
            textRead7 = true;
            textRead8 = true;
            textRead9 = true;
            textRead10 = true;
            textRead11 = true;
            textRead12 = true;
            textRead13 = true;
            textRead14 = true;


        }


        void JobotStage5Tree1()
        {
            LOLSDK.Instance.SpeakText("jobotStage5ButterflyMiniGame");
        }

        void JobotStage5Tree2()
        {
            LOLSDK.Instance.SpeakText("jobotStage5ButterflyMiniGamea");
        }

        void JobotStage5Tree3()
        {
            LOLSDK.Instance.SpeakText("jobotStage5ButterflyMiniGameb");
        }
        void JobotStage5Tree4()
        {
            LOLSDK.Instance.SpeakText("jobotStage5ButterflyMiniGamec");
        }

        void JobotStage5Tree5()
        {
            LOLSDK.Instance.SpeakText("jobotStage5ButterflyMiniGamed");
        }

        void JobotStage5Tree6()
        {
            LOLSDK.Instance.SpeakText("jobotStage5ButterflyMiniGamee");

        }

        void JobotStage5Tree7()
        {
            LOLSDK.Instance.SpeakText("jobotStage5ButterflyMiniGamef");
        }
        void JobotStage5TreeWellDone()
        {
            LOLSDK.Instance.SpeakText("jobotStage5ButterflyMiniGameWellDone");
        }

        void JobotStage5Tree8()
        {
            LOLSDK.Instance.SpeakText("jobotStage5ButterflyMiniGameg");
        }

        void JobotStage5Tree9()
        {
            LOLSDK.Instance.SpeakText("jobotStage5ButterflyMiniGameh");
        }

        void JobotStage5Tree10()
        {
            LOLSDK.Instance.SpeakText("jobotStage5ButterflyMiniGamei");

        }

        void JobotStage5Tree11()
        {
            LOLSDK.Instance.SpeakText("jobotStage5ButterflyMiniGamej");

        }

        void JobotStage5Tree12()
        {
            LOLSDK.Instance.SpeakText("jobotStage5ButterflyMiniGamek");

        }

        public IEnumerator CloseTextPanal()
        {
            yield return new WaitForSeconds(3);
            textRead13 = false;
            currentStage5TreeText = 13;

        }

        public IEnumerator ShowQuestion()
        {
            yield return new WaitForSeconds(2);
            currentStage5TreeText = 6;

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
