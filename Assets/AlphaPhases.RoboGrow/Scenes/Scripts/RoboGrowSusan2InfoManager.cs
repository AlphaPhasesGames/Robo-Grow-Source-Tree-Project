using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AI;
using LoLSDK;
namespace Alpha.Phases.Robo.Grow
{
    public class RoboGrowSusan2InfoManager : MonoBehaviour
    {
        public GameObject textPanal;

        public RobotController robCont;
        public GameObject robotNavMeshAgentToStop;
        public RoboGrowMain rgMain;
        public Camera playerCamera;

        public GameObject susanArrowToDisable;
        public GameObject susan2ArrowToDisable;
        public GameObject limaArrowToDisable;
        public GameObject lima2ArrowToDisable;
        public GameObject daisyArrowToDisable;
        public GameObject daisy2ArrowToDisable;
        public GameObject radishArrowToDisable;
        public GameObject radish2ArrowToDisable;
        // public Button returnToPlayerCam;

        public Button waterSeedsStage1;

        public Button TTSJobotPlantAsses1;
        public Button TTSJobotPlantAsses1a;
        public Button TTSJobotPlantAsses1b;
        public Button TTSJobotPlantAsses1c;
        public Button TTSJobotPlantAsses1d;
        public Button TTSJobotIncorrectGuess;

        public Button jobotCorrectGuess;
        public Button wrongGuess1;
        public Button wrongGuess2;
        public Button wrongGuess3;
        public Button wrongGuess4;
        public Button wrongGuess5;
        public Button wrongGuess6;
        public Button wrongGuess7;
        public Button wrongGuess8;
        public Button wrongGuess9;


        public TextMeshProUGUI jobotIntroStage2PlantAsses1;
        public TextMeshProUGUI jobotIntroStage2PlantAsses1a;
        public TextMeshProUGUI jobotIntroStage2PlantAsses1b;
        public TextMeshProUGUI jobotIntroStage2PlantAsses1c;
        public TextMeshProUGUI jobotIntroStage2PlantAsses1d;
        public TextMeshProUGUI jobotIntroStage2PlantAsses1IncorrectGuess;


        public Renderer susanArrowToChangeColour;
        public Renderer susan2ArrowToChangeColour;
        public Renderer limaArrowToChangeColour;
        public Renderer lima2ArrowToChangeColour;
        public Renderer daisyArrowToChangeColour;
        public Renderer daisy2ArrowToChangeColour;
        public Renderer radishArrowToChangeColour;
        public Renderer radish2ArrowToChangeColour;

        public AudioSource waterSFX;
        public Material wateredColour;

        public Animator waterSusan;
        public Animator waterSusan2;
        public Animator waterLima;
        public Animator waterLima2;
        public Animator waterDaisy;
        public Animator waterDaisy2;
        public Animator waterRadish;
        public Animator waterRadish2;

        public Animator susan1WaterToReset;
        public Animator susan2WaterToReset;
        public Animator lima1WaterToReset;
        public Animator lima2WaterToReset;
        public Animator daisy1WaterToReset;
        public Animator daisy2WaterToReset;
        public Animator radish1WaterToReset;
        public Animator radish2WaterToReset;

        public BoxCollider susan1plantBoxToDisable;
        public BoxCollider susan2plantBoxToDisable;
        public BoxCollider limaBean1plantBoxToDisable;
        public BoxCollider limaBean2plantBoxToDisable;
        public BoxCollider daisy1plantBoxToDisable;
        public BoxCollider daisy2plantBoxToDisable;
        public BoxCollider radish1plantBoxToDisable;
        public BoxCollider radish2plantBoxToDisable;

        public bool textBeenRead;
        public bool progressTextIsShowing;

        public Button progressText;
        public Button progressTextBack;

        public bool plantswateredAlready;
        public bool treeAlreadyCompleted;
        public int currentStage2TreeText;

        private void Awake()
        {
            currentStage2TreeText = 0;
            progressText.onClick.AddListener(OnClick);
            progressTextBack.onClick.AddListener(OnClickBack);
            TTSJobotPlantAsses1.onClick.AddListener(JobotStage2Plant1Asses);
            TTSJobotPlantAsses1a.onClick.AddListener(JobotStage2Plant1Asses2);
            TTSJobotPlantAsses1b.onClick.AddListener(JobotStage2Plant1Asses3);
            TTSJobotPlantAsses1c.onClick.AddListener(JobotStage2Plant1Asses4);
            TTSJobotPlantAsses1d.onClick.AddListener(JobotStage2Plant1Asses5);
            waterSeedsStage1.onClick.AddListener(WaterAllPlants);
            TTSJobotIncorrectGuess.onClick.AddListener(JobotStage2Plant1Asses6);
            jobotCorrectGuess.onClick.AddListener(ProgressToEndText);

            wrongGuess1.onClick.AddListener(ProgressToWrongGuess);
            wrongGuess2.onClick.AddListener(ProgressToWrongGuess);
            wrongGuess3.onClick.AddListener(ProgressToWrongGuess);
            wrongGuess4.onClick.AddListener(ProgressToWrongGuess);
            wrongGuess5.onClick.AddListener(ProgressToWrongGuess);
            wrongGuess6.onClick.AddListener(ProgressToWrongGuess);
            wrongGuess7.onClick.AddListener(ProgressToWrongGuess);
            wrongGuess8.onClick.AddListener(ProgressToWrongGuess);
            wrongGuess9.onClick.AddListener(ProgressToWrongGuess);


        }
        // Start is called before the first frame update
        void Start()
        {
            //returnToPlayerCam.gameObject.SetActive(false);
            // treeCamera.enabled = false;
            textPanal.SetActive(false);
            jobotIntroStage2PlantAsses1.enabled = false;
            jobotIntroStage2PlantAsses1a.enabled = false;
            jobotIntroStage2PlantAsses1b.enabled = false;
            jobotIntroStage2PlantAsses1c.enabled = false;
            jobotIntroStage2PlantAsses1d.enabled = false;
            jobotIntroStage2PlantAsses1IncorrectGuess.enabled = false;
        }

        // Update is called once per frame
        void Update()
        {


            if (currentStage2TreeText == 1)
            {
                if (!textBeenRead)
                {
                    progressText.gameObject.SetActive(false);
                }
                progressTextBack.gameObject.SetActive(false);
                robCont.enabled = false;
                textPanal.SetActive(true);
                susan1plantBoxToDisable.enabled = false;
                jobotIntroStage2PlantAsses1.enabled = true;
                jobotIntroStage2PlantAsses1a.enabled = false;
                jobotIntroStage2PlantAsses1b.enabled = false;
                jobotIntroStage2PlantAsses1c.enabled = false;
                jobotIntroStage2PlantAsses1d.enabled = false;


                TTSJobotPlantAsses1.gameObject.SetActive(true);
                TTSJobotPlantAsses1a.gameObject.SetActive(false);
                TTSJobotPlantAsses1b.gameObject.SetActive(false);
                TTSJobotPlantAsses1c.gameObject.SetActive(false);
                TTSJobotPlantAsses1d.gameObject.SetActive(false);

                TTSJobotIncorrectGuess.gameObject.SetActive(false);
                jobotIntroStage2PlantAsses1IncorrectGuess.enabled = false;
                if (!progressTextIsShowing)
                { // 3 second delay
                    StartCoroutine(DelayProgressButtonVar1());
                    progressTextIsShowing = true;
                }
            }

            if (currentStage2TreeText == 2)
            {
                //  pondFrogspawnIntro2
                if (!textBeenRead)
                {
                    progressText.gameObject.SetActive(false);
                }
                progressTextBack.gameObject.SetActive(true);
                //   robCont.enabled = false;
                jobotIntroStage2PlantAsses1.enabled = false;
                jobotIntroStage2PlantAsses1a.enabled = true;
                jobotIntroStage2PlantAsses1b.enabled = false;
                jobotIntroStage2PlantAsses1c.enabled = false;
                jobotIntroStage2PlantAsses1d.enabled = false;


                TTSJobotPlantAsses1.gameObject.SetActive(false);
                TTSJobotPlantAsses1a.gameObject.SetActive(true);
                TTSJobotPlantAsses1b.gameObject.SetActive(false);
                TTSJobotPlantAsses1c.gameObject.SetActive(false);
                TTSJobotPlantAsses1d.gameObject.SetActive(false);

                TTSJobotIncorrectGuess.gameObject.SetActive(false);
                jobotIntroStage2PlantAsses1IncorrectGuess.enabled = false;

                if (!progressTextIsShowing)
                { // 3 second delay
                    StartCoroutine(DelayProgressButtonVar2());
                    progressTextIsShowing = true;
                }
            }

            if (currentStage2TreeText == 3)
            {
                //  pondFrogspawnIntro3
                if (!textBeenRead)
                {
                    progressText.gameObject.SetActive(false);
                }
                //    robCont.enabled = false;
                jobotIntroStage2PlantAsses1.enabled = false;
                jobotIntroStage2PlantAsses1a.enabled = false;
                jobotIntroStage2PlantAsses1b.enabled = true;
                jobotIntroStage2PlantAsses1c.enabled = false;
                jobotIntroStage2PlantAsses1d.enabled = false;


                TTSJobotPlantAsses1.gameObject.SetActive(false);
                TTSJobotPlantAsses1a.gameObject.SetActive(false);
                TTSJobotPlantAsses1b.gameObject.SetActive(true);
                TTSJobotPlantAsses1c.gameObject.SetActive(false);
                TTSJobotPlantAsses1d.gameObject.SetActive(false);

                TTSJobotIncorrectGuess.gameObject.SetActive(false);
                jobotIntroStage2PlantAsses1IncorrectGuess.enabled = false;

                if (!progressTextIsShowing)
                { // 3 second delay
                    StartCoroutine(DelayProgressButtonVar2());
                    progressTextIsShowing = true;
                }
            }

            if (currentStage2TreeText == 4)
            {
                //  pondFrogspawnIntro4
                progressText.gameObject.SetActive(false);
                //   robCont.enabled = false;
                jobotIntroStage2PlantAsses1.enabled = false;
                jobotIntroStage2PlantAsses1a.enabled = false;
                jobotIntroStage2PlantAsses1b.enabled = false;
                jobotIntroStage2PlantAsses1c.enabled = true;
                jobotIntroStage2PlantAsses1d.enabled = false;


                TTSJobotPlantAsses1.gameObject.SetActive(false);
                TTSJobotPlantAsses1a.gameObject.SetActive(false);
                TTSJobotPlantAsses1b.gameObject.SetActive(false);
                TTSJobotPlantAsses1c.gameObject.SetActive(true);
                TTSJobotPlantAsses1d.gameObject.SetActive(false);

                TTSJobotIncorrectGuess.gameObject.SetActive(false);
                jobotIntroStage2PlantAsses1IncorrectGuess.enabled = false;

            }

            if (currentStage2TreeText == 5)
            {
                // progressText.gameObject.SetActive(false);
                //robCont.enabled = false;
                jobotIntroStage2PlantAsses1.enabled = false;
                jobotIntroStage2PlantAsses1a.enabled = false;
                jobotIntroStage2PlantAsses1b.enabled = false;
                jobotIntroStage2PlantAsses1c.enabled = false;
                jobotIntroStage2PlantAsses1d.enabled = true;


                TTSJobotPlantAsses1.gameObject.SetActive(false);
                TTSJobotPlantAsses1a.gameObject.SetActive(false);
                TTSJobotPlantAsses1b.gameObject.SetActive(false);
                TTSJobotPlantAsses1c.gameObject.SetActive(false);
                TTSJobotPlantAsses1d.gameObject.SetActive(true);

                waterSeedsStage1.gameObject.SetActive(true);
                waterSeedsStage1.enabled = true;

                TTSJobotIncorrectGuess.gameObject.SetActive(false);
                jobotIntroStage2PlantAsses1IncorrectGuess.enabled = false;
            }

            if (currentStage2TreeText == 6)
            {
                //  jobotIntroStage1e
                if (!textBeenRead)
                {
                    progressText.gameObject.SetActive(false);
                }
                //  robCont.enabled = true;
                jobotIntroStage2PlantAsses1.enabled = false;
                jobotIntroStage2PlantAsses1a.enabled = false;
                jobotIntroStage2PlantAsses1b.enabled = false;
                jobotIntroStage2PlantAsses1c.enabled = false;
                jobotIntroStage2PlantAsses1d.enabled = false;


                TTSJobotPlantAsses1.gameObject.SetActive(false);
                TTSJobotPlantAsses1a.gameObject.SetActive(false);
                TTSJobotPlantAsses1b.gameObject.SetActive(false);
                TTSJobotPlantAsses1c.gameObject.SetActive(false);
                TTSJobotPlantAsses1d.gameObject.SetActive(false);

                TTSJobotIncorrectGuess.gameObject.SetActive(false);
                jobotIntroStage2PlantAsses1IncorrectGuess.enabled = false;

                ReturnToPlayerCamFromTree();
                waterSeedsStage1.gameObject.SetActive(false);
                waterSeedsStage1.enabled = false;

            }

            if (currentStage2TreeText == 7)
            {
                //  jobotIntroStage1e

                progressText.gameObject.SetActive(false);

                //  robCont.enabled = true;
                jobotIntroStage2PlantAsses1.enabled = false;
                jobotIntroStage2PlantAsses1a.enabled = false;
                jobotIntroStage2PlantAsses1b.enabled = false;
                jobotIntroStage2PlantAsses1c.enabled = false;
                jobotIntroStage2PlantAsses1d.enabled = false;


                TTSJobotPlantAsses1.gameObject.SetActive(false);
                TTSJobotPlantAsses1a.gameObject.SetActive(false);
                TTSJobotPlantAsses1b.gameObject.SetActive(false);
                TTSJobotPlantAsses1c.gameObject.SetActive(false);
                TTSJobotPlantAsses1d.gameObject.SetActive(false);

                TTSJobotIncorrectGuess.gameObject.SetActive(true);
                jobotIntroStage2PlantAsses1IncorrectGuess.enabled = true;

                StartCoroutine(ShowIncorrectGuess());

            }


        }

        void OnMouseDown()
        {
            if (rgMain.currentGameStage == 2)
            {
                textPanal.SetActive(true);
                playerCamera.enabled = false;
                currentStage2TreeText = 1;
                robCont.NewNavmeshStop();
                rgMain.MoveCameraToSusan2Position();
                robCont.enabled = false;
                robotNavMeshAgentToStop.GetComponent<NavMeshAgent>().isStopped = true;

                Debug.Log("Mouse Clicked");
                susan1plantBoxToDisable.enabled = false;
                limaBean1plantBoxToDisable.enabled = false;
                limaBean2plantBoxToDisable.enabled = false;
                daisy1plantBoxToDisable.enabled = false;
                daisy2plantBoxToDisable.enabled = false;
                radish1plantBoxToDisable.enabled = false;
                radish2plantBoxToDisable.enabled = false;
            }


        }


        public void ReturnToPlayerCamFromTree()
        {
            //  returnToPlayerCam.gameObject.SetActive(false);
            playerCamera.enabled = true;
            rgMain.HideCamera();
            textPanal.SetActive(false);
            robotNavMeshAgentToStop.GetComponent<NavMeshAgent>().isStopped = false;
        }
        public void WaterAllPlants()
        {
            Debug.Log("Water all plants");
            //  robCont.NewNavmeshStop();
            if (!plantswateredAlready)
            {
                Debug.Log("Water all plants Executed");
                waterSusan.SetTrigger("waterSusans");
                waterSusan2.SetTrigger("waterSusanTwo");
                waterLima.SetTrigger("waterLima1");
                waterLima2.SetTrigger("waterLima2");
                waterDaisy.SetTrigger("waterDaisy1");
                waterDaisy2.SetTrigger("waterDaisy2");
                waterRadish.SetTrigger("waterRadish");
                waterRadish2.SetTrigger("waterRadish2");
                //   robCont.enabled = true;
                rgMain.amountofPlantsWateredStage2 = 8;
                robCont.NewNavmeshStop();
                plantswateredAlready = true;

                waterSeedsStage1.gameObject.SetActive(false);
                waterSeedsStage1.enabled = false;

                susanArrowToDisable.gameObject.SetActive(false);
                susan2ArrowToDisable.gameObject.SetActive(false);
                limaArrowToDisable.gameObject.SetActive(false);
                lima2ArrowToDisable.gameObject.SetActive(false);
                daisyArrowToDisable.gameObject.SetActive(false);
                daisy2ArrowToDisable.gameObject.SetActive(false);
                radishArrowToDisable.gameObject.SetActive(false);
                radish2ArrowToDisable.gameObject.SetActive(false);



                susanArrowToChangeColour.material = wateredColour;
                susan2ArrowToChangeColour.material = wateredColour;
                limaArrowToChangeColour.material = wateredColour;
                lima2ArrowToChangeColour.material = wateredColour;
                daisyArrowToChangeColour.material = wateredColour;
                daisy2ArrowToChangeColour.material = wateredColour;
                radishArrowToChangeColour.material = wateredColour;
                radish2ArrowToChangeColour.material = wateredColour;

                susan1plantBoxToDisable.enabled = false;

                waterSFX.Play();


                rgMain.stage2AllSeedWateredStage2 = true;
                rgMain.SaveStagePlantsWatered();
                ReturnToPlayerCamFromTree();
                Debug.Log("Water all plants Coplete");
            }
        }



        void OnClick()
        {
            currentStage2TreeText++;
            textBeenRead = false;
            progressTextIsShowing = false;
            robCont.NewNavmeshStop();
        }

        void OnClickBack()
        {
            currentStage2TreeText--;
            robCont.NewNavmeshStop();
        }

        public void ProgressToEndText()
        {
            currentStage2TreeText = 5;
            robCont.NewNavmeshStop();
        }

        public void ProgressToWrongGuess()
        {
            currentStage2TreeText = 7;
            robCont.NewNavmeshStop();
        }

        public IEnumerator ShowIncorrectGuess()
        {

            yield return new WaitForSeconds(2);
            currentStage2TreeText = 6;
            ReturnToPlayerCamFromTree();
            susanArrowToDisable.gameObject.SetActive(false);
            robCont.NewNavmeshStop();
        }

        void JobotStage2Plant1Asses()
        {
            LOLSDK.Instance.SpeakText("jobotStage2PlantWaterAssesmentText");
        }

        void JobotStage2Plant1Asses2()
        {
            LOLSDK.Instance.SpeakText("jobotStage2PlantWaterAssesmentText1");
        }

        void JobotStage2Plant1Asses3()
        {
            LOLSDK.Instance.SpeakText("jobotStage2PlantWaterAssesmentText2");
        }
        void JobotStage2Plant1Asses4()
        {
            LOLSDK.Instance.SpeakText("jobotStage2PlantWaterAssesmentText3");
        }

        void JobotStage2Plant1Asses5()
        {
            LOLSDK.Instance.SpeakText("jobotStage2PlantWaterAssesmentCorrectText");
        }

        void JobotStage2Plant1Asses6()
        {
            LOLSDK.Instance.SpeakText("jobotStage2PlantSeedExamineWaterplantWrong");
        }


        public void StartTextProcessStage1()
        {
            currentStage2TreeText = 1;
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
