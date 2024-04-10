using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AI;
using LoLSDK;
namespace Alpha.Phases.Robo.Grow
{
    public class RoboGrowExamineFlowersRadish : MonoBehaviour
    {
        public GameObject textPanal;
        public GameObject radish1TextPanal;
        public RoboGrowPlant4Manager rgPlant4Manager;
        public RobotController robCont;
        public RoboGrowMain rgMain;

        public GameObject hint3;
        // public Camera flowerCam;
        public Camera playerCam;

        public RoboGrowExamineFlowersLimaBean examLima;
        public RoboGrowStage1FlowersStartTrigger examSusan;
        public RoboGrowExamineFlowersDaisy examDaisy;

        public BoxCollider susanFlowerBox;
        public BoxCollider limaFlowerBox;
        public BoxCollider radishFlowerBox;
        public BoxCollider daisyFlowerBox;

        public GameObject susanArrowToDisable;
        public GameObject limaArrowToDisable;
        public GameObject daisyArrowToDisable;
        public GameObject radishArrowToDisable;

        public bool plantProgressSaved;
        public bool textBeenRead;
        public bool progressTextIsShowing;

        public GameObject robotToStopNavmesh;

        public Renderer flowerArrowSusan;
        public Renderer flowerArrowLima;
        public Renderer flowerArrowRadish;
        public Renderer flowerArrowDaisy;

        public Button TTSJobotFlower1;
        public Button TTSJobotFlower1a;
        public Button TTSJobotFlower1b;


        public TextMeshProUGUI jobotIntroStage1Flower;
        public TextMeshProUGUI jobotIntroStage1Flower1a;
        public TextMeshProUGUI jobotIntroStage1Flower1b;

        public Button progressText;
        public Button progressTextBack;

        public int currentStage1FlowerText;
        private void Awake()
        {
            currentStage1FlowerText = 0;
        }
        // Start is called before the first frame update
        void Start()
        {


            TTSJobotFlower1.onClick.AddListener(JobotStage1Flower1);
            TTSJobotFlower1a.onClick.AddListener(JobotStage1Flower2);
            TTSJobotFlower1b.onClick.AddListener(JobotStage1Flower3);
            progressText.onClick.AddListener(OnClick);
            textPanal.SetActive(false);

            susanFlowerBox.enabled = false;
            limaFlowerBox.enabled = false;
            daisyFlowerBox.enabled = false;
            radishFlowerBox.enabled = false;
        }

        // Update is called once per frame
        void Update()
        {
            //  pondFrogrpawnIntro1

            if (currentStage1FlowerText == 1)
            {
                if (!textBeenRead)
                {
                    progressText.gameObject.SetActive(false);
                }
                progressTextBack.gameObject.SetActive(false);
                robCont.NewNavmeshStop();
                textPanal.SetActive(true);
                jobotIntroStage1Flower.enabled = true;
                jobotIntroStage1Flower1a.enabled = false;
                jobotIntroStage1Flower1b.enabled = false;
                // robCont.enabled = false;
                playerCam.enabled = false;

                TTSJobotFlower1.gameObject.SetActive(true);
                TTSJobotFlower1a.gameObject.SetActive(false);
                TTSJobotFlower1b.gameObject.SetActive(false);

                if (!progressTextIsShowing)
                { // 3 second delay
                    StartCoroutine(DelayProgressButtonVar2());
                    progressTextIsShowing = true;
                }

            }

            if (currentStage1FlowerText == 2)
            {
                if (!textBeenRead)
                {
                    progressText.gameObject.SetActive(false);
                }
                progressTextBack.gameObject.SetActive(true);
                //  pondFrogspawnIntro2
                jobotIntroStage1Flower.enabled = false;
                jobotIntroStage1Flower1a.enabled = true;
                jobotIntroStage1Flower1b.enabled = false;
                // robCont.enabled = false;


                TTSJobotFlower1.gameObject.SetActive(false);
                TTSJobotFlower1a.gameObject.SetActive(true);
                TTSJobotFlower1b.gameObject.SetActive(false);

                if (!progressTextIsShowing)
                { // 3 second delay
                    StartCoroutine(DelayProgressButton());
                    progressTextIsShowing = true;
                }

            }

            if (currentStage1FlowerText == 3)
            {
                //  pondFrogspawnIntro3
                if (!textBeenRead)
                {
                    progressText.gameObject.SetActive(false);
                }
                jobotIntroStage1Flower.enabled = false;
                jobotIntroStage1Flower1a.enabled = false;
                jobotIntroStage1Flower1b.enabled = true;
                //  robCont.enabled = false;


                TTSJobotFlower1.gameObject.SetActive(false);
                TTSJobotFlower1a.gameObject.SetActive(false);
                TTSJobotFlower1b.gameObject.SetActive(true);

                if (!plantProgressSaved)
                {
                    hint3.gameObject.SetActive(true);
                    rgMain.stage1FlowersExamined = true;
                    rgMain.Stage1PlantsExamined();
                    plantProgressSaved = true;
                }

                if (!progressTextIsShowing)
                { // 3 second delay
                    StartCoroutine(DelayProgressButtonVar2());
                    progressTextIsShowing = true;
                }
            }


            if (currentStage1FlowerText == 4)
            {
                //  jobotIntroStage1e
                //   robCont.enabled = false;
                jobotIntroStage1Flower.enabled = false;
                jobotIntroStage1Flower1a.enabled = false;
                jobotIntroStage1Flower1b.enabled = false;
                TTSJobotFlower1.gameObject.SetActive(false);
                TTSJobotFlower1a.gameObject.SetActive(false);
                TTSJobotFlower1b.gameObject.SetActive(false);
                ReturnToPlayerCamFromPond();
                robCont.NewNavmeshStop();

                susanArrowToDisable.gameObject.SetActive(false);
                limaArrowToDisable.gameObject.SetActive(false);
                daisyArrowToDisable.gameObject.SetActive(false);
                radishArrowToDisable.gameObject.SetActive(false);

                susanFlowerBox.enabled = true;
                limaFlowerBox.enabled = true;
                daisyFlowerBox.enabled = true;
                radishFlowerBox.enabled = true;
                this.gameObject.SetActive(false);

            }
        }


        void OnMouseDown()
        {
            //StartTextProcessStage1();
            textPanal.SetActive(true);
            // robCont.enabled = false;
            rgMain.MoveCameraToOrganic1RadishPosition();
            // playerCam.enabled = false;
            //flowerCam.enabled = true;
            robotToStopNavmesh.GetComponent<NavMeshAgent>().isStopped = true;
            robCont.NewNavmeshStop();
            currentStage1FlowerText = 1;
            // onClickCollider.enabled = false;
            examLima.enabled = false;
            examSusan.enabled = false;
            examDaisy.enabled = false;
            Debug.Log("Mouse Clicked");
        }

        public void ReturnToPlayerCamFromPond()
        {
            // robCont.enabled = true;
            //returnToPlayerCam.gameObject.SetActive(false);
            //playerCam.enabled = true;
            // robCont.enabled = true;
            //rgMain.HideCamera();
            radish1TextPanal.SetActive(true);
            rgPlant4Manager.currentStage1FlowerRadishPlantText = 1;
            textPanal.SetActive(false);
            robotToStopNavmesh.GetComponent<NavMeshAgent>().isStopped = false;
        }


        void OnClick()
        {
            currentStage1FlowerText++;
            textBeenRead = false;
            progressTextIsShowing = false;
            robCont.NewNavmeshStop();
        }

        void OnClickBack()
        {
            currentStage1FlowerText--;
        }

        void JobotStage1Flower1()
        {
            LOLSDK.Instance.SpeakText("stage1PlantIntroInfo");
        }

        void JobotStage1Flower2()
        {
            LOLSDK.Instance.SpeakText("stage1PlantIntroInfoa");
        }

        void JobotStage1Flower3()
        {
            LOLSDK.Instance.SpeakText("stage1PlantIntroInfob");
        }
        void JobotStage1Flower4()
        {
            LOLSDK.Instance.SpeakText("stage1PlantIntroInfoc");
        }

        void JobotStage1flower5()
        {
            LOLSDK.Instance.SpeakText("stage1PlantIntroInfod");
        }

        void JobotStage1Flower6()
        {
            LOLSDK.Instance.SpeakText("stage1PlantIntroInfoe");

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
            currentStage1FlowerText++;
        }
    }
}
