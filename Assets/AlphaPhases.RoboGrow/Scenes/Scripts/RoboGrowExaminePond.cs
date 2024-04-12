using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using LoLSDK;
using SimpleJSON;
using System.IO;
using UnityEngine.UI;
using UnityEngine.AI;
using TMPro;

namespace Alpha.Phases.Robo.Grow
{
    public class RoboGrowExaminePond : MonoBehaviour
    {
      //  public BoxCollider pondCollideToDisable;
        public GameObject textPanal;

        public Button returnToPlayerCam;
        public RobotController robCont;

        public GameObject robotNavMeshAgentToStop;
        public RoboGrowMain rgMain;
       // public Camera pondCam;
        public Camera playerCam;
        public AudioSource musicSource;
        public AudioSource pondWater;

        public bool textBeenRead;
        public bool progressTextIsShowing;

        public Button TTSJobotPond1;
        public Button TTSJobotPond1a;
        public Button TTSJobotPond1b;
        public Button TTSJobotPond1e;

        public bool readText1;
        public bool readText2;
        public bool readText3;
        public bool readText4;
        public bool runOnce;


        public TextMeshProUGUI jobotIntroStage1Pond;
        public TextMeshProUGUI jobotIntroStage1Pond1a;
        public TextMeshProUGUI jobotIntroStage1Pond1b;
        public TextMeshProUGUI jobotIntroStage1Pond1e;

        public Button progressText;
        public Button progressTextBack;

        public bool pondalreadyCompleted;
        public int currentStage1PondText;
        private void Awake()
        {
            currentStage1PondText = 0;
            progressText.onClick.AddListener(OnClick);
            progressTextBack.onClick.AddListener(OnClickBack);
            TTSJobotPond1.onClick.AddListener(JobotStage1Pond1);
            TTSJobotPond1a.onClick.AddListener(JobotStage1Pond2);
            TTSJobotPond1b.onClick.AddListener(JobotStage1Pond3);
            TTSJobotPond1e.onClick.AddListener(JobotStage1Pond6);
        }
        // Start is called before the first frame update
        void Start()
        {
       //     returnToPlayerCam.gameObject.SetActive(false);
         //   pondCam.enabled = false;
       //     textPanal.SetActive(false);
       //     jobotIntroStage1Pond.enabled = false;
       //     jobotIntroStage1Pond1a.enabled = false;
        //    jobotIntroStage1Pond1b.enabled = false;
        //    jobotIntroStage1Pond1e.enabled = false;

        }

        // Update is called once per frame
        void Update()
        {
            //  pondFrogrpawnIntro1
            
            if (currentStage1PondText == 1)
            {
                if (!readText1)
                {
                    if (!textBeenRead)
                    {
                        progressText.gameObject.SetActive(false);
                    }
                    progressTextBack.gameObject.SetActive(false);
                    LOLSDK.Instance.SpeakText("stage1PondFrogSpawnInfo");
                    textPanal.SetActive(true);
                    jobotIntroStage1Pond.gameObject.SetActive(true);
                    jobotIntroStage1Pond1a.gameObject.SetActive(false);

                    TTSJobotPond1.gameObject.SetActive(true);
                    TTSJobotPond1a.gameObject.SetActive(false);

                    if (!progressTextIsShowing)
                    { // 3 second delay
                        StartCoroutine(DelayProgressButton());
                        progressTextIsShowing = true;
                    }
                    readText1 = true;
                }
              

            }

            if (currentStage1PondText == 2)
            {
                //  pondFrogspawnIntro2
                if (!readText2)
                {
                    if (!textBeenRead)
                    {
                        progressText.gameObject.SetActive(false);
                    }
                    progressTextBack.gameObject.SetActive(true);
                    LOLSDK.Instance.SpeakText("stage1PondFrogSpawnInfoa");

                    jobotIntroStage1Pond.gameObject.SetActive(false);
                    jobotIntroStage1Pond1a.gameObject.SetActive(true);
                    jobotIntroStage1Pond1b.gameObject.SetActive(false);

                    TTSJobotPond1.gameObject.SetActive(false);
                    TTSJobotPond1a.gameObject.SetActive(true);
                    TTSJobotPond1b.gameObject.SetActive(false);
                    if (!progressTextIsShowing)
                    { // 3 second delay
                        StartCoroutine(DelayProgressButton());
                        progressTextIsShowing = true;
                    }
                    readText2 = true;
                }

            }

            if (currentStage1PondText == 3)
            {
                //  pondFrogspawnIntro3
                if (!readText3)
                {
                    if (!textBeenRead)
                    {
                        progressText.gameObject.SetActive(false);
                    }
                    LOLSDK.Instance.SpeakText("stage1PondFrogSpawnInfob");

                    jobotIntroStage1Pond1a.gameObject.SetActive(false);
                    jobotIntroStage1Pond1b.gameObject.SetActive(true);
                    jobotIntroStage1Pond1e.gameObject.SetActive(false);



                    TTSJobotPond1a.gameObject.SetActive(false);
                    TTSJobotPond1b.gameObject.SetActive(true);
                    TTSJobotPond1e.gameObject.SetActive(false);

                    if (!progressTextIsShowing)
                    { // 3 second delay
                        StartCoroutine(DelayProgressButton());
                        progressTextIsShowing = true;
                    }
                    readText3 = true;
                }
               
            }

           

            if (currentStage1PondText == 4)
            {
                //  jobotIntroStage1e
                if (!readText4)
                {
                    if (!textBeenRead)
                    {
                        progressText.gameObject.SetActive(false);
                    }

                    LOLSDK.Instance.SpeakText("stage1PondFrogSpawnInfoe");

                    jobotIntroStage1Pond1b.gameObject.SetActive(false);
                    jobotIntroStage1Pond1e.gameObject.SetActive(true);


                    TTSJobotPond1b.gameObject.SetActive(false);
                    TTSJobotPond1e.gameObject.SetActive(true);
                    if (!progressTextIsShowing)
                    { // 3 second delay
                        StartCoroutine(DelayProgressButton());
                        progressTextIsShowing = true;
                    }
                    readText4 = true;
                }
         
            }

            if (currentStage1PondText == 5)
            {
                //  jobotIntroStage1e

                jobotIntroStage1Pond.enabled = false;
                jobotIntroStage1Pond1a.enabled = false;
                jobotIntroStage1Pond1b.enabled = false;
                jobotIntroStage1Pond1e.enabled = false;



                TTSJobotPond1.gameObject.SetActive(false);
                TTSJobotPond1a.gameObject.SetActive(false);
                TTSJobotPond1b.gameObject.SetActive(false);
                TTSJobotPond1e.gameObject.SetActive(false);
                rgMain.stage1PondExamined = true;
                rgMain.SaveStage1Pond();
                Debug.Log("This saved");
                ReturnToPlayerCamFromPond();
               // returnToPlayerCam.gameObject.SetActive(true);

              
              
                if (rgMain.stage1PondExamined == true)
                {
                  
                    this.gameObject.SetActive(false);
                }
                
            }
        }


        void OnMouseDown()
        {
            robCont.NewNavmeshStop();
            // StartTextProcessStage1();
            textPanal.SetActive(true);
            robCont.NewNavmeshStop();
            robotNavMeshAgentToStop.GetComponent<NavMeshAgent>().isStopped = true;
            returnToPlayerCam.onClick.AddListener(ReturnToPlayerCamFromPond);
            playerCam.gameObject.SetActive(false);
            //   pondCam.enabled = true;
            rgMain.MoveCameraToStage1PondPosition();
            rgMain.task1TextUITick3.SetActive(true);
            currentStage1PondText = 1;
            musicSource.volume = 0.002f;
            pondWater.Play();

            Debug.Log("Mouse Clicked");
        }

        public void ReturnToPlayerCamFromPond()
        {
           // robCont.enabled = true;
            returnToPlayerCam.gameObject.SetActive(false);
            robotNavMeshAgentToStop.GetComponent<NavMeshAgent>().isStopped = false;
            playerCam.gameObject.SetActive(true);
            rgMain.HideCamera();
            textPanal.SetActive(false);
           // pondCollideToDisable.enabled = false;
            musicSource.volume = 0.036f;
            pondWater.Stop();
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
            readText1 = false;
            readText2 = false;
            readText3 = false;
            readText4 = false;
        }

        void JobotStage1Pond1()
        {
            LOLSDK.Instance.SpeakText("stage1PondFrogSpawnInfo");
        }

        void JobotStage1Pond2()
        {
            LOLSDK.Instance.SpeakText("stage1PondFrogSpawnInfoa");
        }

        void JobotStage1Pond3()
        {
            LOLSDK.Instance.SpeakText("stage1PondFrogSpawnInfob");
        }
        void JobotStage1Pond4()
        {
            LOLSDK.Instance.SpeakText("stage1PondFrogSpawnInfoc");
        }

        void JobotStage1Pond5()
        {
            LOLSDK.Instance.SpeakText("stage1PondFrogSpawnInfod");
        }

        void JobotStage1Pond6()
        {
            LOLSDK.Instance.SpeakText("stage1PondFrogSpawnInfoe");

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
        public void StartTextProcessStage1()
        {
            currentStage1PondText = 1;
        }

      
    }
}

