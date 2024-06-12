using System.Collections;
using UnityEngine;
using LoLSDK;
using UnityEngine.UI;
using UnityEngine.AI;
using TMPro;

namespace Alpha.Phases.Robo.Grow
{
    public class RoboGrowStage4ButterflyMG : MonoBehaviour
    {

        public RobotController robCont;
        public RoboGrowMain rgMain;
        public ButterFlyPlayerController rgBFCont;
        public GameObject robotNavMeshAgentToStop;
        public Camera playerCamera;
        public Camera butterFlyCam;
        public Image buttTargetImage;
        public GameObject robotCharacter;
        public GameObject butterflyCharacter;
        public GameObject pondArrow;
        public GameObject fakeButterfly1;
        public GameObject fakeButterfly2;
        public GameObject fakeButterfly3;
        public GameObject targetButterfly1;

        public BoxCollider susanArrowBoxToReset;
        public BoxCollider susan2ArrowBoxToReset;
        public BoxCollider limaArrowBoxToReset;
        public BoxCollider lima2ArrowBoxToReset;
        public BoxCollider daisyArrowBoxToReset;
        public BoxCollider daisy2ArrowBoxToReset;
        public BoxCollider radishArrowBoxToReset;
        public BoxCollider radish2ArrowBoxToReset;

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


        public bool hasSavingHappenBefore;
        public GameObject textPanal;
        public Button TTSJobotTree1;
        public Button TTSJobotTree1a;
        public Button TTSJobotTree1b;
     //   public Button TTSJobotTree1c;
     //   public Button TTSJobotTree1d;
        public Button TTSJobotTree1e;
        public Button TTSJobotTree1f;
     //   public Button TTSJobotTree1g;
        public Button TTSJobotTree1h;
        public Button TTSJobotTree1i;
        public Button TTSJobotTree1j;

        public TextMeshProUGUI jobotIntroStage4Tree;
        public TextMeshProUGUI jobotIntroStage4Tree1a;
        public TextMeshProUGUI jobotIntroStage4Tree1b;
     //   public TextMeshProUGUI jobotIntroStage4Tree1c;
     //   public TextMeshProUGUI jobotIntroStage4Tree1d;
        public TextMeshProUGUI jobotIntroStage4Tree1e;
        public TextMeshProUGUI jobotIntroStage4Tree1f;
    //    public TextMeshProUGUI jobotIntroStage4Tree1g;
        public TextMeshProUGUI jobotIntroStage4Tree1h;
        public TextMeshProUGUI jobotIntroStage4Tree1i;
        public TextMeshProUGUI jobotIntroStage4Tree1j;

        public bool textBeenRead;
        public bool progressTextIsShowing;

        public Button progressText;
        public Button progressTextBack;

        public int currentStage4BFText;

        private void Awake()
        {
            currentStage4BFText = 0;
            progressText.onClick.AddListener(OnClick);
            progressTextBack.onClick.AddListener(OnClickBack);

            TTSJobotTree1.onClick.AddListener(JobotStage4Tree1);
            TTSJobotTree1a.onClick.AddListener(JobotStage4Tree2);
            TTSJobotTree1b.onClick.AddListener(JobotStage4Tree3);
        //    TTSJobotTree1c.onClick.AddListener(JobotStage4Tree4);
        //    TTSJobotTree1d.onClick.AddListener(JobotStage4Tree5);
            TTSJobotTree1e.onClick.AddListener(JobotStage4Tree6);
            TTSJobotTree1f.onClick.AddListener(JobotStage4Tree7);
        //    TTSJobotTree1g.onClick.AddListener(JobotStage4Tree8);
            TTSJobotTree1h.onClick.AddListener(JobotStage4Tree9);
            TTSJobotTree1i.onClick.AddListener(JobotStage4Tree10);
            TTSJobotTree1j.onClick.AddListener(JobotStage4Tree11);
        }

        // Start is called before the first frame update
        void Start()
        {

         

        }

        // Update is called once per frame
        void Update()
        {
            if (currentStage4BFText == 1)
            {
                if (!textRead1)
                {
                    if (!textBeenRead)
                    {
                        progressText.gameObject.SetActive(false);
                    }
                    progressTextBack.gameObject.SetActive(false);
                    LOLSDK.Instance.SpeakText("jobotStage4BFlyMiniGame");

                    robCont.enabled = false;
                    playerCamera.enabled = false;
                    butterflyCharacter.SetActive(true);
                    butterFlyCam.enabled = true;
                    rgBFCont.enabled = false;

                    fakeButterfly1.gameObject.SetActive(true);
                    fakeButterfly2.gameObject.SetActive(true);
                    fakeButterfly3.gameObject.SetActive(true);
                    targetButterfly1.gameObject.SetActive(true);

                    textPanal.SetActive(true);
                    jobotIntroStage4Tree.gameObject.SetActive(true);
                    jobotIntroStage4Tree1a.gameObject.SetActive(false);

                    if (!progressTextIsShowing)
                    { // 3 second delay
                        StartCoroutine(DelayProgressButtonVar1());
                        progressTextIsShowing = true;
                    }
                    textRead1 = true;
                }

            }

            if (currentStage4BFText == 2)
            {
                if (!textRead2)
                {
                    if (!textBeenRead)
                    {
                        progressText.gameObject.SetActive(false);
                    }
                    progressTextBack.gameObject.SetActive(true);
                    LOLSDK.Instance.SpeakText("jobotStage4BFlyMiniGamea");

                    jobotIntroStage4Tree.gameObject.SetActive(false);
                    jobotIntroStage4Tree1a.gameObject.SetActive(true);
                    jobotIntroStage4Tree1b.gameObject.SetActive(false);

                    if (!progressTextIsShowing)
                    { // 3 second delay
                        StartCoroutine(DelayProgressButtonVar1());
                        progressTextIsShowing = true;
                    }
                    textRead2 = true;
                }
               
            }

            if (currentStage4BFText == 3)
            {
                if (!textRead3)
                {
                    if (!textBeenRead)
                    {
                        progressText.gameObject.SetActive(false);
                    }
                    LOLSDK.Instance.SpeakText("jobotStage4BFlyMiniGameb");

                    jobotIntroStage4Tree1a.gameObject.SetActive(false);
                    jobotIntroStage4Tree1b.gameObject.SetActive(true);
                    jobotIntroStage4Tree1e.gameObject.SetActive(false);

                    if (!progressTextIsShowing)
                    { // 3 second delay
                        StartCoroutine(DelayProgressButtonVar1());
                        progressTextIsShowing = true;
                    }
                    textRead3 = true;
                }

            }
     
            if (currentStage4BFText == 4)
            {
                if (!textRead4)
                {
                    if (!textBeenRead)
                    {
                        progressText.gameObject.SetActive(false);
                    }
                    LOLSDK.Instance.SpeakText("jobotStage4BFlyMiniGamee");

                    jobotIntroStage4Tree1b.gameObject.SetActive(false);
                    jobotIntroStage4Tree1e.gameObject.SetActive(true);
                    jobotIntroStage4Tree1f.gameObject.SetActive(false);
                    if (!progressTextIsShowing)
                    { // 3 second delay
                        StartCoroutine(DelayProgressButtonVar1());
                        progressTextIsShowing = true;
                    }
                    textRead4 = true;
                }

            }

            if (currentStage4BFText == 5)
            {
                if (!textRead5)
                {
                    if (!textBeenRead)
                    {
                        progressText.gameObject.SetActive(false);
                    }
                    LOLSDK.Instance.SpeakText("jobotStage4BFlyMiniGamef");

                    jobotIntroStage4Tree1e.gameObject.SetActive(false);
                    jobotIntroStage4Tree1f.gameObject.SetActive(true);
                    //     jobotIntroStage4Tree1g.enabled = false;
                    jobotIntroStage4Tree1h.gameObject.SetActive(false);
                    buttTargetImage.gameObject.SetActive(true);
                    rgBFCont.enabled = true;
                    progressText.gameObject.SetActive(false);
                    StartCoroutine(CloseTextPanal());
                    textRead5 = true;
                }
               
            }


            if (currentStage4BFText == 6)
            {
                if (!textRead6)
                {
                    textPanal.SetActive(true);

                    jobotIntroStage4Tree1f.gameObject.SetActive(false);
                    //         jobotIntroStage4Tree1g.enabled = false;
                    jobotIntroStage4Tree1h.gameObject.SetActive(true);
                    jobotIntroStage4Tree1i.gameObject.SetActive(false);
                    LOLSDK.Instance.SpeakText("jobotStage4BFlyMiniGameh");

                    StartCoroutine(CloseTextPanal());
                    textRead6 = true;
                }
  
            }


            if (currentStage4BFText == 10)
            {
                if (!textRead7)
                {
                    //  jobotIntroStage1e
                    if (!textBeenRead)
                    {
                        progressText.gameObject.SetActive(false);
                    }
                    textPanal.SetActive(true);
               
                    jobotIntroStage4Tree1h.gameObject.SetActive(false);
                    jobotIntroStage4Tree1i.gameObject.SetActive(true);
                    jobotIntroStage4Tree1j.gameObject.SetActive(false);
                    LOLSDK.Instance.SpeakText("jobotStage4BFlyMiniGamei");

                    progressText.gameObject.SetActive(true);

                    playerCamera.enabled = true;
                    butterflyCharacter.SetActive(false);
                    butterFlyCam.enabled = false;

                    susanArrowBoxToReset.gameObject.SetActive(true);
                    susan2ArrowBoxToReset.gameObject.SetActive(true);
                    limaArrowBoxToReset.gameObject.SetActive(true);
                    lima2ArrowBoxToReset.gameObject.SetActive(true);
                    daisyArrowBoxToReset.gameObject.SetActive(true);
                    daisy2ArrowBoxToReset.gameObject.SetActive(true);
                    radishArrowBoxToReset.gameObject.SetActive(true);
                    radish2ArrowBoxToReset.gameObject.SetActive(true);

                    susanArrowBoxToReset.enabled = true;
                    susan2ArrowBoxToReset.enabled = true;
                    limaArrowBoxToReset.enabled = true;
                    lima2ArrowBoxToReset.enabled = true;
                    daisyArrowBoxToReset.enabled = true;
                    daisy2ArrowBoxToReset.enabled = true;
                    radishArrowBoxToReset.enabled = true;
                    radish2ArrowBoxToReset.enabled = true;

                    fakeButterfly1.gameObject.SetActive(false);
                    fakeButterfly2.gameObject.SetActive(false);
                    fakeButterfly3.gameObject.SetActive(false);
                    targetButterfly1.gameObject.SetActive(false);
                    // progressText.gameObject.SetActive(false);
                    rgBFCont.enabled = false;
                    robCont.enabled = true;
                    if (!hasSavingHappenBefore)
                    {
                        rgMain.SaveStage4ButterlyMiniGameComplete();
                        rgMain.SavePlayerPos();

                        robotNavMeshAgentToStop.GetComponent<NavMeshAgent>().isStopped = false;
                        if (!rgMain.stage4FrogMiniGameComplete)
                        {
                            pondArrow.gameObject.SetActive(true);
                        }
                        hasSavingHappenBefore = true;
                    }
                    if (!progressTextIsShowing)
                    { // 3 second delay
                        StartCoroutine(DelayProgressButtonVar1());
                        progressTextIsShowing = true;
                    }
                    textRead7 = true;
                }
                

            }

            if (currentStage4BFText == 11)
            {

                if (!textRead8)
                {
                    jobotIntroStage4Tree1i.gameObject.SetActive(false);
                    jobotIntroStage4Tree1j.gameObject.SetActive(true);
                    LOLSDK.Instance.SpeakText("jobotStage4BFlyMiniGamej");


                    buttTargetImage.gameObject.SetActive(false);
                    progressText.gameObject.SetActive(false);

                    StartCoroutine(CloseTextPanal());
                    textRead8 = true;
                }
               

            }

            if (currentStage4BFText == 12)
            {
                if (!textRead9) 
                {
                    textPanal.SetActive(false);
                    jobotIntroStage4Tree.gameObject.SetActive(false);
                    jobotIntroStage4Tree1a.gameObject.SetActive(false);
                    jobotIntroStage4Tree1b.gameObject.SetActive(false);
                    jobotIntroStage4Tree1e.gameObject.SetActive(false);
                    jobotIntroStage4Tree1f.gameObject.SetActive(false);
                    //      jobotIntroStage4Tree1g.enabled = false;
                    jobotIntroStage4Tree1h.gameObject.SetActive(false);
                    jobotIntroStage4Tree1i.gameObject.SetActive(false);
                    jobotIntroStage4Tree1j.gameObject.SetActive(false);
                                    

                    progressText.gameObject.SetActive(false);
                    textRead9 = true;
                }               
            }
        }



        void OnClick()
        {
            currentStage4BFText++;
            textBeenRead = false;
            progressTextIsShowing = false;
        }

        void OnClickBack()
        {
            currentStage4BFText--;
            textRead1 = false;
            textRead2 = false;
            textRead3 = false;
            textRead4 = false;
            textRead5 = false;
            textRead6 = false;
            textRead7 = false;
            textRead8 = false;
            textRead9 = false;

        }

     
        void JobotStage4Tree1()
        {
            LOLSDK.Instance.SpeakText("jobotStage4BFlyMiniGame");
        }

        void JobotStage4Tree2()
        {
            LOLSDK.Instance.SpeakText("jobotStage4BFlyMiniGamea");
        }

        void JobotStage4Tree3()
        {
            LOLSDK.Instance.SpeakText("jobotStage4BFlyMiniGameb");
        }
    ///    void JobotStage4Tree4()
   //     {
  //          LOLSDK.Instance.SpeakText("jobotStage4BFlyMiniGamec");
   //     }

   //     void JobotStage4Tree5()
   //     {
    //        LOLSDK.Instance.SpeakText("jobotStage4BFlyMiniGamed");
    //    }

        void JobotStage4Tree6()
        {
            LOLSDK.Instance.SpeakText("jobotStage4BFlyMiniGamee");

        }

        void JobotStage4Tree7()
        {
            LOLSDK.Instance.SpeakText("jobotStage4BFlyMiniGamef");
        }
   //     void JobotStage4Tree8()
  //      {
  //          LOLSDK.Instance.SpeakText("jobotStage4BFlyMiniGameg");
  //      }

        void JobotStage4Tree9()
        {
            LOLSDK.Instance.SpeakText("jobotStage4BFlyMiniGameh");
        }

        void JobotStage4Tree10()
        {
            LOLSDK.Instance.SpeakText("jobotStage4BFlyMiniGamei");

        }

        void JobotStage4Tree11()
        {
            LOLSDK.Instance.SpeakText("jobotStage4BFlyMiniGamej");

        }

        public IEnumerator CloseTextPanal()
        {
          
            yield return new WaitForSeconds(5);
            textRead9 = false;
            currentStage4BFText = 12;

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
