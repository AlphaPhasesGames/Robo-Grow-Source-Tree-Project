using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AI;
using LoLSDK;
namespace Alpha.Phases.Robo.Grow
{
    public class RoboGrowStage2TreeTrigger : MonoBehaviour
    {
        public GameObject textPanal;

        public RobotController robCont;
                public GameObject robotNavMeshAgentToStop;
        public RoboGrowMain rgMain;
       // public Camera treeCamera;
        public Camera playerCamera;
       // public Camera mainCamera;
       // public GameObject treeTriggerToDisable;
        public GameObject hint8;
        public Button returnToPlayerCam;

        public Button TTSJobotTree1;
        public Button TTSJobotTree1a;
     //   public Button TTSJobotTree1b;
     //   public Button TTSJobotTree1c;
        public Button TTSJobotTree1d;
        public Button TTSJobotTree1e;
        public Button TTSJobotTree1f;

        public bool textRead1;
        public bool textRead2;
        public bool textRead3;
        public bool textRead4;
        public bool textRead5;



        public TextMeshProUGUI jobotIntroStage2Tree;
        public TextMeshProUGUI jobotIntroStage2Tree1a;
      //  public TextMeshProUGUI jobotIntroStage2Tree1b;
      //  public TextMeshProUGUI jobotIntroStage2Tree1c;
        public TextMeshProUGUI jobotIntroStage2Tree1d;
        public TextMeshProUGUI jobotIntroStage2Tree1e;
        public TextMeshProUGUI jobotIntroStage2Tree1f;

        public bool textBeenRead;
        public bool progressTextIsShowing;

        public Button progressText;
        public Button progressTextBack;

        public bool hasTreeSavedAlready;
        public bool treeAlreadyCompleted;
        public int currentStage2TreeText;

        private void Awake()
        {
            currentStage2TreeText = 0;
            progressText.onClick.AddListener(OnClick);
            progressTextBack.onClick.AddListener(OnClickBack);
            TTSJobotTree1.onClick.AddListener(JobotStage2Tree1);
            TTSJobotTree1a.onClick.AddListener(JobotStage2Tree2);
        //    TTSJobotTree1b.onClick.AddListener(JobotStage2Tree3);
       //     TTSJobotTree1c.onClick.AddListener(JobotStage2Tree4);
            TTSJobotTree1d.onClick.AddListener(JobotStage2Tree5);
            TTSJobotTree1e.onClick.AddListener(JobotStage2Tree6);
            TTSJobotTree1f.onClick.AddListener(JobotStage2Tree7);
        }
        // Start is called before the first frame update
        void Start()
        {
            returnToPlayerCam.gameObject.SetActive(false);
           // treeCamera.enabled = false;
            textPanal.SetActive(false);
          //  jobotIntroStage2Tree.enabled = false;
         //   jobotIntroStage2Tree1a.enabled = false;
       //     jobotIntroStage2Tree1b.enabled = false;
      //      jobotIntroStage2Tree1c.enabled = false;
         //   jobotIntroStage2Tree1d.enabled = false;
        //    jobotIntroStage2Tree1e.enabled = false;
        //    jobotIntroStage2Tree1f.enabled = false;

        }

        // Update is called once per frame
        void Update()
        {
            

            if (currentStage2TreeText == 1)
            {
                if (!textRead1)
                {
                    if (!textBeenRead)
                    {
                        progressText.gameObject.SetActive(false);
                    }
                    LOLSDK.Instance.SpeakText("jobotStage2PlantSeedExamineCocoon");
                    progressTextBack.gameObject.SetActive(false);
                    robCont.enabled = false;
                    textPanal.SetActive(true);
                    jobotIntroStage2Tree.gameObject.SetActive(true);
                    jobotIntroStage2Tree1a.gameObject.SetActive(false);
                    hint8.gameObject.SetActive(true);

                   // TTSJobotTree1.gameObject.SetActive(true);
                   // TTSJobotTree1a.gameObject.SetActive(false);
                    //       TTSJobotTree1b.gameObject.SetActive(false);
                    //       TTSJobotTree1c.gameObject.SetActive(false);
                  //  TTSJobotTree1d.gameObject.SetActive(false);
                   // TTSJobotTree1e.gameObject.SetActive(false);
                  //  TTSJobotTree1f.gameObject.SetActive(false);
                    if (!progressTextIsShowing)
                    { // 3 second delay
                        StartCoroutine(DelayProgressButtonVar1());
                        progressTextIsShowing = true;
                    }
                    textRead1 = true;
                }
              
            }

            if (currentStage2TreeText == 2)
            {
                if (!textRead2)
                {
                    //  pondFrogspawnIntro2
                    if (!textBeenRead)
                    {
                        progressText.gameObject.SetActive(false);
                    }
                    progressTextBack.gameObject.SetActive(true);
                    LOLSDK.Instance.SpeakText("jobotStage2PlantSeedExamineCocoona");

                    // robCont.enabled = false;
                    jobotIntroStage2Tree.gameObject.SetActive(false);
                    jobotIntroStage2Tree1a.gameObject.SetActive(true);
                    //        jobotIntroStage2Tree1b.enabled = false;
                    //        jobotIntroStage2Tree1c.enabled = false;
                    jobotIntroStage2Tree1d.gameObject.SetActive(false);
                    // jobotIntroStage2Tree1e.enabled = false;
                    // jobotIntroStage2Tree1f.enabled = false;


                    //  TTSJobotTree1.gameObject.SetActive(false);
                    //  TTSJobotTree1a.gameObject.SetActive(true);
                    //     TTSJobotTree1b.gameObject.SetActive(false);
                    //      TTSJobotTree1c.gameObject.SetActive(false);
                    //   TTSJobotTree1d.gameObject.SetActive(false);
                    //   TTSJobotTree1e.gameObject.SetActive(false);
                    //   TTSJobotTree1f.gameObject.SetActive(false);
                    if (!progressTextIsShowing)
                    { // 3 second delay
                        StartCoroutine(DelayProgressButtonVar2());
                        progressTextIsShowing = true;
                    }
                    textRead2 = true;
                }
               
            }

            if (currentStage2TreeText == 3)
            {
                if (!textRead3)
                {
                    //  pondFrogspawnIntro5
                    if (!textBeenRead)
                    {
                        progressText.gameObject.SetActive(false);
                    }
                    LOLSDK.Instance.SpeakText("jobotStage2PlantSeedExamineCocoond");

                    //   robCont.enabled = false;
                    jobotIntroStage2Tree1a.gameObject.SetActive(false);
                    jobotIntroStage2Tree1d.gameObject.SetActive(true);
                    jobotIntroStage2Tree1e.gameObject.SetActive(false);

                    { // 3 second delay
                        StartCoroutine(DelayProgressButton());
                        progressTextIsShowing = true;
                    }

                    textRead3 = true;

                }

            }

            if (currentStage2TreeText == 4)
            {
                if (!textRead4)
                {
                    //  jobotIntroStage1e
                    if (!textBeenRead)
                    {
                        progressText.gameObject.SetActive(false);
                    }
                    // robCont.enabled = false;
                    LOLSDK.Instance.SpeakText("jobotStage2PlantSeedExamineCocoone");

                    jobotIntroStage2Tree1d.gameObject.SetActive(false);
                    jobotIntroStage2Tree1e.gameObject.SetActive(true);
                    jobotIntroStage2Tree1f.gameObject.SetActive(false);

                    if (!progressTextIsShowing)
                    { // 3 second delay
                        StartCoroutine(DelayProgressButtonVar2());
                        progressTextIsShowing = true;
                    }

                    textRead4 = true;
                }
               
            }

            if (currentStage2TreeText == 5)
            {
                if (!textRead5)
                {
                    //  jobotIntroStage1e
                    if (!textBeenRead)
                    {
                        progressText.gameObject.SetActive(false);
                    }
                    LOLSDK.Instance.SpeakText("jobotStage2PlantSeedExamineCocoonf");

                    jobotIntroStage2Tree1e.gameObject.SetActive(false);
                    jobotIntroStage2Tree1f.gameObject.SetActive(true);


                    if (!progressTextIsShowing)
                    { // 3 second delay
                        StartCoroutine(DelayProgressButtonVar1());
                        progressTextIsShowing = true;
                    }

                    textRead5 = true;

                }
            }

            if (currentStage2TreeText == 6)
            {
                //  jobotIntroStage1e
                robCont.enabled = true;
        
                jobotIntroStage2Tree1f.gameObject.SetActive(false);

                if (!hasTreeSavedAlready)
                {
                    rgMain.stage2TreeExamindComplete = true;
                    rgMain.SaveStage2TreeComplete();
                    hasTreeSavedAlready = true;
                    Debug.Log("This saved");
                    robotNavMeshAgentToStop.GetComponent<NavMeshAgent>().isStopped = false;
                }


                ReturnToPlayerCamFromTree();
                // returnToPlayerCam.gameObject.SetActive(true);



               

            }
        }

        void OnMouseDown()
        {
            if (rgMain.currentGameStage == 2)
            {
                //treeTriggerCollisionBox.enabled = true;
                playerCamera.enabled = false;
                //  treeCamera.enabled = true;
                rgMain.MoveCameraToStage2TreePosition();
                currentStage2TreeText = 1;
                // treeTriggerToDisable.gameObject.SetActive(false);
                robCont.NewNavmeshStop();
                robotNavMeshAgentToStop.GetComponent<NavMeshAgent>().isStopped = true;
            }


        }


        public void ReturnToPlayerCamFromTree()
        {
            // robCont.enabled = true;
            returnToPlayerCam.gameObject.SetActive(false);
            playerCamera.enabled = true;
            rgMain.HideCamera();
           // mainCamera.enabled = false;
            textPanal.SetActive(false);
        }


        void OnClick()
        {
            currentStage2TreeText++;
            textBeenRead = false;
            progressTextIsShowing = false;
        }

        void OnClickBack()
        {
            currentStage2TreeText--;
            textRead1 = false;
            textRead2 = false;
            textRead3 = false;
            textRead4 = false;
            textRead5 = false;
        }

        void JobotStage2Tree1()
        {
            LOLSDK.Instance.SpeakText("jobotStage2PlantSeedExamineCocoon");
        }

        void JobotStage2Tree2()
        {
            LOLSDK.Instance.SpeakText("jobotStage2PlantSeedExamineCocoona");
        }

        void JobotStage2Tree3()
        {
            LOLSDK.Instance.SpeakText("jobotStage2PlantSeedExamineCocoonb");
        }
        void JobotStage2Tree4()
        {
            LOLSDK.Instance.SpeakText("jobotStage2PlantSeedExamineCocoonc");
        }

        void JobotStage2Tree5()
        {
            LOLSDK.Instance.SpeakText("jobotStage2PlantSeedExamineCocoond");
        }

        void JobotStage2Tree6()
        {
            LOLSDK.Instance.SpeakText("jobotStage2PlantSeedExamineCocoone");

        }
        void JobotStage2Tree7()
        {
            LOLSDK.Instance.SpeakText("jobotStage2PlantSeedExamineCocoonf");

        }


        public void StartTextProcessStage1()
        {
            currentStage2TreeText = 1;
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
