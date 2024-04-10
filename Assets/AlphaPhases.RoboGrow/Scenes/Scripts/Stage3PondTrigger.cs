using System.Collections;
using UnityEngine;
using LoLSDK;
using UnityEngine.UI;
using UnityEngine.AI;
using TMPro;

namespace Alpha.Phases.Robo.Grow
{
    public class Stage3PondTrigger : MonoBehaviour
    {
        public BoxCollider pondCollideToDisable;
        public GameObject textPanal;
        public GameObject hint11;
        public Button returnToPlayerCam;
        public RobotController robCont;
        public GameObject robotNavMeshAgentToStop;
        public RoboGrowMain rgMain;
       // public Camera pondCam;
        public Camera playerCam;
       // public GameObject minigame2Stage2Canvas;
        public AudioSource musicSource;
        public AudioSource pondWater;

        public Button TTSJobotStage3Pond1;
        public Button TTSJobotStage3Pond1a;
        public Button TTSJobotStage3Pond1b;
        public Button TTSJobotStage3Pond1c;
        public Button TTSJobotStage3Pond1d;

        public TextMeshProUGUI jobotIntroStage3Pond;
        public TextMeshProUGUI jobotIntroStage3Pond1a;
        public TextMeshProUGUI jobotIntroStage3Pond1b;
        public TextMeshProUGUI jobotIntroStage3Pond1c;
        public TextMeshProUGUI jobotIntroStage3Pond1d;

        public bool textBeenRead;
        public bool progressTextIsShowing;

        public Button progressText;
        public Button progressTextBack;

        public bool pondalreadyCompleted;
        public int currentStage1PondText;
        private void Awake()
        {
            currentStage1PondText = 0;
            progressText.onClick.AddListener(OnClick);
            progressTextBack.onClick.AddListener(OnClickBack);
            TTSJobotStage3Pond1.onClick.AddListener(JobotStage3Pond1);
            TTSJobotStage3Pond1a.onClick.AddListener(JobotStage3Pond2);
            TTSJobotStage3Pond1b.onClick.AddListener(JobotStage3Pond3);
            TTSJobotStage3Pond1c.onClick.AddListener(JobotStage3Pond4);
            TTSJobotStage3Pond1d.onClick.AddListener(JobotStage3Pond5);
        }
        // Start is called before the first frame update
        void Start()
        {
            returnToPlayerCam.gameObject.SetActive(false);
         //   pondCam.enabled = false;
            textPanal.SetActive(false);
            jobotIntroStage3Pond.enabled = false;
            jobotIntroStage3Pond1a.enabled = false;
            jobotIntroStage3Pond1b.enabled = false;
            jobotIntroStage3Pond1c.enabled = false;
            jobotIntroStage3Pond1d.enabled = false;

        }

        // Update is called once per frame
        void Update()
        {
            //  pondFrogrpawnIntro1

            if (currentStage1PondText == 1)
            {
                if (!textBeenRead)
                {
                    progressText.gameObject.SetActive(false);
                }
                progressTextBack.gameObject.SetActive(false);
                textPanal.SetActive(true);
                jobotIntroStage3Pond.enabled = true;
                jobotIntroStage3Pond1a.enabled = false;
                jobotIntroStage3Pond1b.enabled = false;
                jobotIntroStage3Pond1c.enabled = false;
                jobotIntroStage3Pond1d.enabled = false;
                hint11.gameObject.SetActive(true);


                TTSJobotStage3Pond1.gameObject.SetActive(true);
                TTSJobotStage3Pond1a.gameObject.SetActive(false);
                TTSJobotStage3Pond1b.gameObject.SetActive(false);
                TTSJobotStage3Pond1c.gameObject.SetActive(false);
                TTSJobotStage3Pond1d.gameObject.SetActive(false);
                if (!progressTextIsShowing)
                { // 3 second delay
                    StartCoroutine(DelayProgressButtonVar1());
                    progressTextIsShowing = true;
                }
            }

            if (currentStage1PondText == 2)
            {
                //  pondFrogspawnIntro2
                if (!textBeenRead)
                {
                    progressText.gameObject.SetActive(false);
                }
                progressTextBack.gameObject.SetActive(true);
                jobotIntroStage3Pond.enabled = false;
                jobotIntroStage3Pond1a.enabled = true;
                jobotIntroStage3Pond1b.enabled = false;
                jobotIntroStage3Pond1c.enabled = false;
                jobotIntroStage3Pond1d.enabled = false;



                TTSJobotStage3Pond1.gameObject.SetActive(false);
                TTSJobotStage3Pond1a.gameObject.SetActive(true);
                TTSJobotStage3Pond1b.gameObject.SetActive(false);
                TTSJobotStage3Pond1c.gameObject.SetActive(false);
                TTSJobotStage3Pond1d.gameObject.SetActive(false);
                if (!progressTextIsShowing)
                { // 3 second delay
                    StartCoroutine(DelayProgressButtonVar1());
                    progressTextIsShowing = true;
                }
            }

            if (currentStage1PondText == 3)
            {
                //  pondFrogspawnIntro3
                if (!textBeenRead)
                {
                    progressText.gameObject.SetActive(false);
                }
                jobotIntroStage3Pond.enabled = false;
                jobotIntroStage3Pond1a.enabled = false;
                jobotIntroStage3Pond1b.enabled = true;
                jobotIntroStage3Pond1c.enabled = false;
                jobotIntroStage3Pond1d.enabled = false;



                TTSJobotStage3Pond1.gameObject.SetActive(false);
                TTSJobotStage3Pond1a.gameObject.SetActive(false);
                TTSJobotStage3Pond1b.gameObject.SetActive(true);
                TTSJobotStage3Pond1c.gameObject.SetActive(false);
                TTSJobotStage3Pond1d.gameObject.SetActive(false);
                if (!progressTextIsShowing)
                { // 3 second delay
                    StartCoroutine(DelayProgressButtonVar2());
                    progressTextIsShowing = true;
                }
            }

            if (currentStage1PondText == 4)
            {
                //  pondFrogspawnIntro4
                if (!textBeenRead)
                {
                    progressText.gameObject.SetActive(false);
                }
                jobotIntroStage3Pond.enabled = false;
                jobotIntroStage3Pond1a.enabled = false;
                jobotIntroStage3Pond1b.enabled = false;
                jobotIntroStage3Pond1c.enabled = true;
                jobotIntroStage3Pond1d.enabled = false;



                TTSJobotStage3Pond1.gameObject.SetActive(false);
                TTSJobotStage3Pond1a.gameObject.SetActive(false);
                TTSJobotStage3Pond1b.gameObject.SetActive(false);
                TTSJobotStage3Pond1c.gameObject.SetActive(true);
                TTSJobotStage3Pond1d.gameObject.SetActive(false);
                if (!progressTextIsShowing)
                { // 3 second delay
                    StartCoroutine(DelayProgressButtonVar1());
                    progressTextIsShowing = true;
                }
            }

            if (currentStage1PondText == 5)
            {
                //  pondFrogspawnIntro5
                if (!textBeenRead)
                {
                    progressText.gameObject.SetActive(false);
                }
                jobotIntroStage3Pond.enabled = false;
                jobotIntroStage3Pond1a.enabled = false;
                jobotIntroStage3Pond1b.enabled = false;
                jobotIntroStage3Pond1c.enabled = false;
                jobotIntroStage3Pond1d.enabled = true;



                TTSJobotStage3Pond1.gameObject.SetActive(false);
                TTSJobotStage3Pond1a.gameObject.SetActive(false);
                TTSJobotStage3Pond1b.gameObject.SetActive(false);
                TTSJobotStage3Pond1c.gameObject.SetActive(false);
                TTSJobotStage3Pond1d.gameObject.SetActive(true);
                if (!progressTextIsShowing)
                { // 3 second delay
                    StartCoroutine(DelayProgressButtonVar1());
                    progressTextIsShowing = true;
                }
            }

       

            if (currentStage1PondText == 6)
            {
                //  jobotIntroStage1e

                jobotIntroStage3Pond.enabled = false;
                jobotIntroStage3Pond1a.enabled = false;
                jobotIntroStage3Pond1b.enabled = false;
                jobotIntroStage3Pond1c.enabled = false;
                jobotIntroStage3Pond1d.enabled = false;



                TTSJobotStage3Pond1.gameObject.SetActive(false);
                TTSJobotStage3Pond1a.gameObject.SetActive(false);
                TTSJobotStage3Pond1b.gameObject.SetActive(false);
                TTSJobotStage3Pond1c.gameObject.SetActive(false);
                TTSJobotStage3Pond1d.gameObject.SetActive(false);
                rgMain.stage3PondExamined = true;
                rgMain.SaveStage3PondExamined();
                Debug.Log("This saved");
                ReturnToPlayerCamFromPond();
                // returnToPlayerCam.gameObject.SetActive(true);

                

                if (rgMain.stage3PondExamined == true)
                {
                    robotNavMeshAgentToStop.GetComponent<NavMeshAgent>().isStopped = false;
                    musicSource.volume = 0.036f;
                    pondWater.Stop();
                    this.gameObject.SetActive(false);
                }

            }
        }


        void OnMouseDown()
        {
            // StartTextProcessStage1();
            textPanal.SetActive(true);
            //robCont.enabled = false;
            robCont.NewNavmeshStop();
            robotNavMeshAgentToStop.GetComponent<NavMeshAgent>().isStopped = true;
            returnToPlayerCam.onClick.AddListener(ReturnToPlayerCamFromPond);
            playerCam.enabled = false;
            rgMain.MoveCameraToStage3PondPosition();
            rgMain.task1TextUITick3.SetActive(true);
            currentStage1PondText = 1;
        //    minigame2Stage2Canvas.SetActive(true);
            pondWater.Play();
            musicSource.volume = 0.002f;

            Debug.Log("Mouse Clicked");
        }

        public void ReturnToPlayerCamFromPond()
        {
            // robCont.enabled = true;
            returnToPlayerCam.gameObject.SetActive(false);
            playerCam.enabled = true;
            rgMain.HideCamera();
            textPanal.SetActive(false);
        //    minigame2Stage2Canvas.SetActive(false);
            pondCollideToDisable.enabled = false;
            pondWater.Stop();
            musicSource.volume = 0.0036f;
        }


        void OnClick()
        {
            currentStage1PondText++;
            textBeenRead = false;
            progressTextIsShowing = false;

        }

        void OnClickBack()
        {
            currentStage1PondText--;
        }

        void JobotStage3Pond1()
        {
            LOLSDK.Instance.SpeakText("jobotStage3Pond1");
        }

        void JobotStage3Pond2()
        {
            LOLSDK.Instance.SpeakText("jobotStage3Pond1a");
        }

        void JobotStage3Pond3()
        {
            LOLSDK.Instance.SpeakText("jobotStage3Pond1b");
        }
        void JobotStage3Pond4()
        {
            LOLSDK.Instance.SpeakText("jobotStage3Pond1c");
        }

        void JobotStage3Pond5()
        {
            LOLSDK.Instance.SpeakText("jobotStage3Pond1d");
        }

        


        public void StartTextProcessStage1()
        {
            currentStage1PondText = 1;
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
