using System.Collections;
using UnityEngine;
using LoLSDK;
using UnityEngine.UI;
using UnityEngine.AI;
using TMPro;

namespace Alpha.Phases.Robo.Grow
{
    public class RoboGrowStartMiniGame2 : MonoBehaviour
    {
        public RoboGrowMain rgMain;
        public TadpoleController tadControl;
        public Camera playerToCamDisable;
        public Camera mainCam;
        public GameObject pondCamAndPlayer;
       // public GameObject pondStage2Food;
      //  public Canvas stage2MiniGameCanvas;
        public RobotController robCont;
        public GameObject robotNavMeshAgentToStop;
        public GameObject textPanal;

        public AudioSource waterPondSFX;
        public AudioSource music;

        public GameObject hint7;
        public Button progressText;
        public Button progressTextBack;

        public bool textBeenRead;
        public bool progressTextIsShowing;

        public Button TTSJobotStagePond2;
        public Button TTSJobotStagePond2a;
        public Button TTSJobotStagePond2b;
        public Button TTSJobotStagePond2c;
        public Button TTSJobotStagePond2d;
        public Button TTSJobotStagePond2e;
        public Button TTSJobotStagePond2f;
        public Button TTSJobotStagePond2Eaten;
        public Button TTSJobotNotLargeEnough;

        public TextMeshProUGUI jobotIntroStage2Pond;
        public TextMeshProUGUI jobotIntroStage2Pond1a;
        public TextMeshProUGUI jobotIntroStage2Pond1b;
        public TextMeshProUGUI jobotIntroStage2Pond1c;
        public TextMeshProUGUI jobotIntroStage2Pond1d;
        public TextMeshProUGUI jobotIntroStage2Pond1e;
        public TextMeshProUGUI jobotIntroStage2Pond1f;
        public TextMeshProUGUI jobotIntroStage2Pond1Eaten;
        public TextMeshProUGUI jobotNotLargeEnough;

        public bool hasEndOfGameHappenedBefore;
        public bool hasTextAppearedYet;
        public bool hasTheGameAlreadySaved;
        public bool pondAlreadyCompleted;

        public int currentStage2PondText;

        private void Awake()
        {
            pondCamAndPlayer.SetActive(false);
            //stage2MiniGameCanvas.enabled = false;
            currentStage2PondText = 0;
            progressText.onClick.AddListener(OnClick);
            progressTextBack.onClick.AddListener(OnClickBack);
            TTSJobotStagePond2.onClick.AddListener(JobotStage2Pond1);
            TTSJobotStagePond2a.onClick.AddListener(JobotStage2Pond2);
            TTSJobotStagePond2b.onClick.AddListener(JobotStage2Pond3);
            TTSJobotStagePond2c.onClick.AddListener(JobotStage2Pond4);
            TTSJobotStagePond2d.onClick.AddListener(JobotStage2Pond5);
            TTSJobotStagePond2e.onClick.AddListener(JobotStage2Pond6);
            TTSJobotStagePond2f.onClick.AddListener(JobotStage2Pond7);
            TTSJobotStagePond2Eaten.onClick.AddListener(JobotStage2PondEaten);
            TTSJobotNotLargeEnough.onClick.AddListener(JobotStage2PondNotEatenEnough);
        }
        // Start is called before the first frame update
        void Start()
        {
            //returnToPlayerCam.gameObject.SetActive(false);
            pondCamAndPlayer.SetActive(false);
            textPanal.SetActive(false);
            jobotIntroStage2Pond.enabled = false;
            jobotIntroStage2Pond1a.enabled = false;
            jobotIntroStage2Pond1b.enabled = false;
            jobotIntroStage2Pond1c.enabled = false;
            jobotIntroStage2Pond1d.enabled = false;
            jobotIntroStage2Pond1e.enabled = false;
            jobotIntroStage2Pond1f.enabled = false;
            jobotIntroStage2Pond1Eaten.enabled = false;
            jobotNotLargeEnough.enabled = false;
        }

        // Update is called once per frame
        void Update()
        {


            if (currentStage2PondText == 1)
            {
                if (!textBeenRead)
                {
                    progressText.gameObject.SetActive(false);
                }
                //stage2MiniGameCanvas.enabled = true;
               // stage2MiniGameCanvas.gameObject.SetActive(true);
                tadControl.enabled = false;
                textPanal.SetActive(true);
                jobotIntroStage2Pond.enabled = true;
                jobotIntroStage2Pond1a.enabled = false;
                jobotIntroStage2Pond1b.enabled = false;
                jobotIntroStage2Pond1c.enabled = false;
                jobotIntroStage2Pond1d.enabled = false;
                jobotIntroStage2Pond1e.enabled = false;
                jobotIntroStage2Pond1f.enabled = false;
                jobotIntroStage2Pond1Eaten.enabled = false;
                jobotNotLargeEnough.enabled = false;

                TTSJobotStagePond2.gameObject.SetActive(true);
                TTSJobotStagePond2a.gameObject.SetActive(false);
                TTSJobotStagePond2b.gameObject.SetActive(false);
                TTSJobotStagePond2c.gameObject.SetActive(false);
                TTSJobotStagePond2d.gameObject.SetActive(false);
                TTSJobotStagePond2e.gameObject.SetActive(false);
                TTSJobotStagePond2f.gameObject.SetActive(false);
                TTSJobotStagePond2Eaten.gameObject.SetActive(false);
                TTSJobotNotLargeEnough.gameObject.SetActive(false);
                hint7.gameObject.SetActive(true);
                progressTextBack.gameObject.SetActive(false);
                if (!progressTextIsShowing)
                { // 3 second delay
                    StartCoroutine(DelayProgressButtonVar2());
                    progressTextIsShowing = true;
                }
            }

            if (currentStage2PondText == 2)
            {
                //  pondFrogspawnIntro2
                tadControl.enabled = false;
                if (!textBeenRead)
                {
                    progressText.gameObject.SetActive(false);
                }
                progressTextBack.gameObject.SetActive(true);
                jobotIntroStage2Pond.enabled = false;
                jobotIntroStage2Pond1a.enabled = true;
                jobotIntroStage2Pond1b.enabled = false;
                jobotIntroStage2Pond1c.enabled = false;
                jobotIntroStage2Pond1d.enabled = false;
                jobotIntroStage2Pond1e.enabled = false;
                jobotIntroStage2Pond1f.enabled = false;
                jobotIntroStage2Pond1Eaten.enabled = false;
                jobotNotLargeEnough.enabled = false;

                TTSJobotStagePond2.gameObject.SetActive(false);
                TTSJobotStagePond2a.gameObject.SetActive(true);
                TTSJobotStagePond2b.gameObject.SetActive(false);
                TTSJobotStagePond2c.gameObject.SetActive(false);
                TTSJobotStagePond2d.gameObject.SetActive(false);
                TTSJobotStagePond2e.gameObject.SetActive(false);
                TTSJobotStagePond2f.gameObject.SetActive(false);
                TTSJobotStagePond2Eaten.gameObject.SetActive(false);
                TTSJobotNotLargeEnough.gameObject.SetActive(false);
                if (!progressTextIsShowing)
                { // 3 second delay
                    StartCoroutine(DelayProgressButtonVar2());
                    progressTextIsShowing = true;
                }
            }

            if (currentStage2PondText == 3)
            {
                //  pondFrogspawnIntro3
                tadControl.enabled = false;
                if (!textBeenRead)
                {
                    progressText.gameObject.SetActive(false);
                }
                jobotIntroStage2Pond.enabled = false;
                jobotIntroStage2Pond1a.enabled = false;
                jobotIntroStage2Pond1b.enabled = true;
                jobotIntroStage2Pond1c.enabled = false;
                jobotIntroStage2Pond1d.enabled = false;
                jobotIntroStage2Pond1e.enabled = false;
                jobotIntroStage2Pond1f.enabled = false;
                jobotIntroStage2Pond1Eaten.enabled = false;
                jobotNotLargeEnough.enabled = false;

                TTSJobotStagePond2.gameObject.SetActive(false);
                TTSJobotStagePond2a.gameObject.SetActive(false);
                TTSJobotStagePond2b.gameObject.SetActive(true);
                TTSJobotStagePond2c.gameObject.SetActive(false);
                TTSJobotStagePond2d.gameObject.SetActive(false);
                TTSJobotStagePond2e.gameObject.SetActive(false);
                TTSJobotStagePond2f.gameObject.SetActive(false);
                TTSJobotStagePond2Eaten.gameObject.SetActive(false);
                TTSJobotNotLargeEnough.gameObject.SetActive(false);
                if (!progressTextIsShowing)
                { // 3 second delay
                    StartCoroutine(DelayProgressButtonVar1());
                    progressTextIsShowing = true;
                }
            }

            if (currentStage2PondText == 4)
            {
                //  pondFrogspawnIntro4
                if (!textBeenRead)
                {
                    progressText.gameObject.SetActive(false);
                }
                tadControl.enabled = false;
                jobotIntroStage2Pond.enabled = false;
                jobotIntroStage2Pond1a.enabled = false;
                jobotIntroStage2Pond1b.enabled = false;
                jobotIntroStage2Pond1c.enabled = true;
                jobotIntroStage2Pond1d.enabled = false;
                jobotIntroStage2Pond1e.enabled = false;
                jobotIntroStage2Pond1f.enabled = false;
                jobotIntroStage2Pond1Eaten.enabled = false;
                jobotNotLargeEnough.enabled = false;

                TTSJobotStagePond2.gameObject.SetActive(false);
                TTSJobotStagePond2a.gameObject.SetActive(false);
                TTSJobotStagePond2b.gameObject.SetActive(false);
                TTSJobotStagePond2c.gameObject.SetActive(true);
                TTSJobotStagePond2d.gameObject.SetActive(false);
                TTSJobotStagePond2e.gameObject.SetActive(false);
                TTSJobotStagePond2f.gameObject.SetActive(false);
                TTSJobotStagePond2Eaten.gameObject.SetActive(false);
                TTSJobotNotLargeEnough.gameObject.SetActive(false);
                if (!progressTextIsShowing)
                { // 3 second delay
                    StartCoroutine(DelayProgressButton());
                    progressTextIsShowing = true;
                }
            }

            if (currentStage2PondText == 5)
            {
                //  pondFrogspawnIntro5
                if (!textBeenRead)
                {
                    progressText.gameObject.SetActive(false);
                }
                tadControl.enabled = false;
                jobotIntroStage2Pond.enabled = false;
                jobotIntroStage2Pond1a.enabled = false;
                jobotIntroStage2Pond1b.enabled = false;
                jobotIntroStage2Pond1c.enabled = false;
                jobotIntroStage2Pond1d.enabled = true;
                jobotIntroStage2Pond1e.enabled = false;
                jobotIntroStage2Pond1f.enabled = false;
                jobotIntroStage2Pond1Eaten.enabled = false;
                jobotNotLargeEnough.enabled = false;

                TTSJobotStagePond2.gameObject.SetActive(false);
                TTSJobotStagePond2a.gameObject.SetActive(false);
                TTSJobotStagePond2b.gameObject.SetActive(false);
                TTSJobotStagePond2c.gameObject.SetActive(false);
                TTSJobotStagePond2d.gameObject.SetActive(true);
                TTSJobotStagePond2e.gameObject.SetActive(false);
                TTSJobotStagePond2f.gameObject.SetActive(false);
                TTSJobotStagePond2Eaten.gameObject.SetActive(false);
                TTSJobotNotLargeEnough.gameObject.SetActive(false);
                if (!progressTextIsShowing)
                { // 3 second delay
                    StartCoroutine(DelayProgressButtonVar2());
                    progressTextIsShowing = true;
                }
            }

          /*  if (currentStage2PondText == 6)
            {
                //  pondFrogspawnIntro5

                tadControl.enabled = true;
                textPanal.SetActive(false);
                jobotIntroStage2Pond.enabled = false;
                jobotIntroStage2Pond1a.enabled = false;
                jobotIntroStage2Pond1b.enabled = false;
                jobotIntroStage2Pond1c.enabled = false;
                jobotIntroStage2Pond1d.enabled = false;
                jobotIntroStage2Pond1e.enabled = false;
                jobotIntroStage2Pond1f.enabled = false;
                jobotIntroStage2Pond1Eaten.enabled = false;
                jobotNotLargeEnough.enabled = false;

                TTSJobotStagePond2.gameObject.SetActive(false);
                TTSJobotStagePond2a.gameObject.SetActive(false);
                TTSJobotStagePond2b.gameObject.SetActive(false);
                TTSJobotStagePond2c.gameObject.SetActive(false);
                TTSJobotStagePond2d.gameObject.SetActive(false);
                TTSJobotStagePond2e.gameObject.SetActive(false);
                TTSJobotStagePond2f.gameObject.SetActive(false);
                TTSJobotStagePond2Eaten.gameObject.SetActive(false);
                TTSJobotNotLargeEnough.gameObject.SetActive(false);
            }
          */
            if (currentStage2PondText == 6)
            {
              
                tadControl.enabled = true;
                textPanal.SetActive(true);
                jobotIntroStage2Pond.enabled = false;
                jobotIntroStage2Pond1a.enabled = false;
                jobotIntroStage2Pond1b.enabled = false;
                jobotIntroStage2Pond1c.enabled = false;
                jobotIntroStage2Pond1d.enabled = false;
                jobotIntroStage2Pond1e.enabled = true;
                jobotIntroStage2Pond1f.enabled = false;
                jobotIntroStage2Pond1Eaten.enabled = false;
                jobotNotLargeEnough.enabled = false;

                TTSJobotStagePond2.gameObject.SetActive(false);
                TTSJobotStagePond2a.gameObject.SetActive(false);
                TTSJobotStagePond2b.gameObject.SetActive(false);
                TTSJobotStagePond2c.gameObject.SetActive(false);
                TTSJobotStagePond2d.gameObject.SetActive(false);
                TTSJobotStagePond2e.gameObject.SetActive(true);
                TTSJobotStagePond2f.gameObject.SetActive(false);
                TTSJobotStagePond2Eaten.gameObject.SetActive(false);
                TTSJobotNotLargeEnough.gameObject.SetActive(false);
                progressTextBack.gameObject.SetActive(false);
                progressText.gameObject.SetActive(false);

            }

            if (currentStage2PondText == 7)
            {
                if (!hasEndOfGameHappenedBefore)
                {
                    //  jobotIntroStage1e
                    progressTextBack.gameObject.SetActive(false);
                    tadControl.enabled = false;
                    textPanal.SetActive(true);
                    jobotIntroStage2Pond.enabled = false;
                    jobotIntroStage2Pond1a.enabled = false;
                    jobotIntroStage2Pond1b.enabled = false;
                    jobotIntroStage2Pond1c.enabled = false;
                    jobotIntroStage2Pond1d.enabled = false;
                    jobotIntroStage2Pond1e.enabled = false;
                    jobotIntroStage2Pond1f.enabled = true;
                    jobotIntroStage2Pond1Eaten.enabled = false;
                    jobotNotLargeEnough.enabled = false;

                    TTSJobotStagePond2.gameObject.SetActive(false);
                    TTSJobotStagePond2a.gameObject.SetActive(false);
                    TTSJobotStagePond2b.gameObject.SetActive(false);
                    TTSJobotStagePond2c.gameObject.SetActive(false);
                    TTSJobotStagePond2d.gameObject.SetActive(false);
                    TTSJobotStagePond2e.gameObject.SetActive(false);
                    TTSJobotStagePond2f.gameObject.SetActive(true);
                    TTSJobotStagePond2Eaten.gameObject.SetActive(false);
                    TTSJobotNotLargeEnough.gameObject.SetActive(false);
                    StartCoroutine(MoveTextPanal());
                    hasEndOfGameHappenedBefore = true;
                    progressText.gameObject.SetActive(false);
                }


            }

            if (currentStage2PondText == 9)
            {
                //  jobotIntroStage1e
                //tadControl.enabled = false;

                textPanal.SetActive(true);
                jobotIntroStage2Pond.enabled = false;
                jobotIntroStage2Pond1a.enabled = false;
                jobotIntroStage2Pond1b.enabled = false;
                jobotIntroStage2Pond1c.enabled = false;
                jobotIntroStage2Pond1d.enabled = false;
                jobotIntroStage2Pond1e.enabled = false;
                jobotIntroStage2Pond1f.enabled = false;
                jobotIntroStage2Pond1Eaten.enabled = true;
                jobotNotLargeEnough.enabled = false;

                TTSJobotStagePond2.gameObject.SetActive(false);
                TTSJobotStagePond2a.gameObject.SetActive(false);
                TTSJobotStagePond2b.gameObject.SetActive(false);
                TTSJobotStagePond2c.gameObject.SetActive(false);
                TTSJobotStagePond2d.gameObject.SetActive(false);
                TTSJobotStagePond2e.gameObject.SetActive(false);
                TTSJobotStagePond2f.gameObject.SetActive(false);
                TTSJobotStagePond2Eaten.gameObject.SetActive(true);
                TTSJobotNotLargeEnough.gameObject.SetActive(false);
                progressText.gameObject.SetActive(false);
                StartCoroutine(CloseTextPanal());
            }

            if (currentStage2PondText == 10)
            {
                //  End of Pond Stage
                tadControl.enabled = false;
                jobotIntroStage2Pond.enabled = false;
                jobotIntroStage2Pond1a.enabled = false;
                jobotIntroStage2Pond1b.enabled = false;
                jobotIntroStage2Pond1c.enabled = false;
                jobotIntroStage2Pond1d.enabled = false;
                jobotIntroStage2Pond1e.enabled = false;
                jobotIntroStage2Pond1f.enabled = false;
                jobotIntroStage2Pond1Eaten.enabled = false;
                jobotNotLargeEnough.enabled = false;

                TTSJobotStagePond2.gameObject.SetActive(false);
                TTSJobotStagePond2a.gameObject.SetActive(false);
                TTSJobotStagePond2b.gameObject.SetActive(false);
                TTSJobotStagePond2c.gameObject.SetActive(false);
                TTSJobotStagePond2d.gameObject.SetActive(false);
                TTSJobotStagePond2e.gameObject.SetActive(false);
                TTSJobotStagePond2f.gameObject.SetActive(false);
                TTSJobotStagePond2Eaten.gameObject.SetActive(false);
                TTSJobotNotLargeEnough.gameObject.SetActive(false);
                if (!hasTheGameAlreadySaved)
                {
                    rgMain.task1TextUITick2.SetActive(true);
                    rgMain.stage2MiniGameComplete = true;
                    rgMain.SaveStage2MiniGameComplete();
                    Debug.Log("This saved");
                    mainCam.enabled = false;
                    playerToCamDisable.enabled = true;
                    // currentStage2PondText = 8;
                    textPanal.SetActive(false);
                    //stage2MiniGameCanvas.enabled = false;
                    ReturnToPlayerCamFromPond();
                    hasTheGameAlreadySaved = true;
                 
                    waterPondSFX.Stop();
                    music.volume = 0.036f;
                    robotNavMeshAgentToStop.GetComponent<NavMeshAgent>().isStopped = false;
                }






            }

            if (currentStage2PondText == 11)
            {
                if (!hasTextAppearedYet)
               {
                    //  End of Pond Stage
                    textPanal.SetActive(true);
                    jobotIntroStage2Pond.enabled = false;
                    jobotIntroStage2Pond1a.enabled = false;
                    jobotIntroStage2Pond1b.enabled = false;
                    jobotIntroStage2Pond1c.enabled = false;
                    jobotIntroStage2Pond1d.enabled = false;
                    jobotIntroStage2Pond1e.enabled = false;
                    jobotIntroStage2Pond1f.enabled = false;
                    jobotIntroStage2Pond1Eaten.enabled = false;
                    jobotNotLargeEnough.enabled = true;

                    TTSJobotStagePond2.gameObject.SetActive(false);
                    TTSJobotStagePond2a.gameObject.SetActive(false);
                    TTSJobotStagePond2b.gameObject.SetActive(false);
                    TTSJobotStagePond2c.gameObject.SetActive(false);
                    TTSJobotStagePond2d.gameObject.SetActive(false);
                    TTSJobotStagePond2e.gameObject.SetActive(false);
                    TTSJobotStagePond2f.gameObject.SetActive(false);
                    TTSJobotStagePond2Eaten.gameObject.SetActive(false);
                    TTSJobotNotLargeEnough.gameObject.SetActive(true);
                    StartCoroutine(CloseTextPanal());
                    progressText.gameObject.SetActive(false);
                    hasTextAppearedYet = true;
                   // returnToPlayerCam.gameObject.SetActive(true);

               

            }

                if (currentStage2PondText == 20)
                {
                    //  End of Pond Stage
                    textPanal.SetActive(false);
                    jobotIntroStage2Pond.enabled = false;
                    jobotIntroStage2Pond1a.enabled = false;
                    jobotIntroStage2Pond1b.enabled = false;
                    jobotIntroStage2Pond1c.enabled = false;
                    jobotIntroStage2Pond1d.enabled = false;
                    jobotIntroStage2Pond1e.enabled = false;
                    jobotIntroStage2Pond1f.enabled = false;
                    jobotIntroStage2Pond1Eaten.enabled = false;
                    jobotNotLargeEnough.enabled = false;

                    TTSJobotStagePond2.gameObject.SetActive(false);
                    TTSJobotStagePond2a.gameObject.SetActive(false);
                    TTSJobotStagePond2b.gameObject.SetActive(false);
                    TTSJobotStagePond2c.gameObject.SetActive(false);
                    TTSJobotStagePond2d.gameObject.SetActive(false);
                    TTSJobotStagePond2e.gameObject.SetActive(false);
                    TTSJobotStagePond2f.gameObject.SetActive(false);
                    TTSJobotStagePond2Eaten.gameObject.SetActive(false);
                    TTSJobotNotLargeEnough.gameObject.SetActive(false);


                }
            }
        }
        void OnMouseDown()
        {
            robCont.NewNavmeshStop();
            robotNavMeshAgentToStop.GetComponent<NavMeshAgent>().isStopped = true;
            if (rgMain.currentGameStage == 2)
            {
            
                playerToCamDisable.enabled = false;
                mainCam.enabled = false;
                pondCamAndPlayer.SetActive(true);
                currentStage2PondText = 1;
                Debug.Log("Mouse Clicked");
                waterPondSFX.Play();
                music.volume = 0.002f;
            }


        }

        public void ReturnToPlayerCamFromPond()
        {
            // robCont.enabled = true;
          
            //mainCam.SetActive(true);
            pondCamAndPlayer.SetActive(false);
            playerToCamDisable.enabled = true;
            mainCam.enabled = false;
            textPanal.SetActive(false);
            //stage2MiniGameCanvas.enabled = false;
           // stage2MiniGameCanvas.gameObject.SetActive(false);
            music.volume = 0.036f;
            waterPondSFX.Stop();
        }


        void OnClick()
        {
            currentStage2PondText++;
            textBeenRead = false;
            progressTextIsShowing = false;
        }

        void OnClickBack()
        {
            currentStage2PondText--;
        }

        void JobotStage2Pond1()
        {
            LOLSDK.Instance.SpeakText("jobotStage2Pond");
        }

        void JobotStage2Pond2()
        {
            LOLSDK.Instance.SpeakText("jobotStage2Ponda");
        }

        void JobotStage2Pond3()
        {
            LOLSDK.Instance.SpeakText("jobotStage2Pondb");
        }
        void JobotStage2Pond4()
        {
            LOLSDK.Instance.SpeakText("jobotStage2Pondc");
        }

        void JobotStage2Pond5()
        {
            LOLSDK.Instance.SpeakText("jobotStage2Pondd");
        }

        void JobotStage2Pond6()
        {
            LOLSDK.Instance.SpeakText("jobotStage2PondeClue");

        }
        void JobotStage2Pond7()
        {
            LOLSDK.Instance.SpeakText("jobotStage2Pondf");

        }

        void JobotStage2PondEaten()
        {
            LOLSDK.Instance.SpeakText("jobotStage2PondgEaten");

        }

        void JobotStage2PondNotEatenEnough()
        {
            LOLSDK.Instance.SpeakText("jobotStage2PondgNotBigEnough");

        }


        public void StartTextProcessStage1()
        {
            currentStage2PondText = 1;
        }

        public IEnumerator CloseTextPanal()
        {
          
            yield return new WaitForSeconds(2);
            currentStage2PondText = 6;
        }

        public IEnumerator MoveTextPanal()
        {
          
            yield return new WaitForSeconds(6);
            currentStage2PondText = 10;

        }

        public IEnumerator EatenByEnemy()
        {
            currentStage2PondText = 9;
            yield return new WaitForSeconds(2);
            currentStage2PondText = 6;
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
