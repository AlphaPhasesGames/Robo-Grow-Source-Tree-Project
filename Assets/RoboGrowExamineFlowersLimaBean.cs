using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AI;
using LoLSDK;
namespace Alpha.Phases.Robo.Grow
{
    public class RoboGrowExamineFlowersLimaBean : MonoBehaviour
    {
        public GameObject textPanal;
        public GameObject lima1Textpanal;
        //  public Button returnToPlayerCam;
        public RoboGrowPlant2Manager rgPlantMan2;
        public RobotController robCont;
        public RoboGrowMain rgMain;
        // public Camera flowerCam;
        public Camera playerCam;

       // public bool hasSaveHappened;
        public GameObject hint3;
        public BoxCollider susanFlowerBox;
        public BoxCollider limaFlowerBox;
        public BoxCollider radishFlowerBox;
        public BoxCollider daisyFlowerBox;

        public RoboGrowExamineFlowersRadish examRadish;
        public RoboGrowStage1FlowersStartTrigger examSusan;
        public RoboGrowExamineFlowersDaisy examDaisy;

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

       // public Material orangeMat;

        public Button TTSJobotFlower1;
        public Button TTSJobotFlower1a;
        public Button TTSJobotFlower1b;

        public bool textRead1;
        public bool textRead2;
        public bool textRead3;
        public bool textRead4;

        public TextMeshProUGUI jobotIntroStage1Flower;
        public TextMeshProUGUI jobotIntroStage1Flower1a;
        public TextMeshProUGUI jobotIntroStage1Flower1b;

        public Button progressText;
        public Button progressTextBack;

        public int currentStage1FlowerText;
        private void Awake()
        {
            currentStage1FlowerText = 0;
            /*stage1FlowerToDisable1.enabled = false;
            stage1FlowerToDisable1a.enabled = false;
            stage1FlowerToDisable1b.enabled = false;
            stage1FlowerToDisable1c.enabled = false;
            stage1FlowerToDisable1d.enabled = false;
            stage1FlowerToDisable1e.enabled = false;
            stage1FlowerToDisable1f.enabled = false;
            stage1FlowerToDisable1g.enabled = false;
            */

        }
        // Start is called before the first frame update
        void Start()
        {


            TTSJobotFlower1.onClick.AddListener(JobotStage1Flower1);
            TTSJobotFlower1a.onClick.AddListener(JobotStage1Flower2);
            TTSJobotFlower1b.onClick.AddListener(JobotStage1Flower3);
            progressText.onClick.AddListener(OnClick);
            progressTextBack.onClick.AddListener(OnClickBack);
            // progressTextBack.onClick.AddListener(OnClickBack);
            // returnToPlayerCam.gameObject.SetActive(false);
            //   flowerCam.enabled = false;
            textPanal.SetActive(false);

            susanFlowerBox.enabled = false;
            limaFlowerBox.enabled = false;
            daisyFlowerBox.enabled = false;
            radishFlowerBox.enabled = false;
            /*  jobotIntroStage1Flower.enabled = false;
              jobotIntroStage1Flower1a.enabled = false;
              jobotIntroStage1Flower1b.enabled = false;
              jobotIntroStage1Flower1c.enabled = false;
              jobotIntroStage1Flower1d.enabled = false;
              jobotIntroStage1Flower1e.enabled = false;
            */
        }

        // Update is called once per frame
        void Update()
        {
            //  pondFrogrpawnIntro1

            if (currentStage1FlowerText == 1)
            {
                if (!textRead1)
                {
                    if (!textBeenRead)
                    {
                        progressText.gameObject.SetActive(false);
                    }
                    progressTextBack.gameObject.SetActive(false);
                    LOLSDK.Instance.SpeakText("stage1PlantIntroInfo");

                    robCont.NewNavmeshStop();
                    textPanal.SetActive(true);
                    jobotIntroStage1Flower.gameObject.SetActive(true);
                    jobotIntroStage1Flower1a.gameObject.SetActive(false);
                    jobotIntroStage1Flower1b.gameObject.SetActive(false);
                    // robCont.enabled = false;
                    playerCam.enabled = false;

                    TTSJobotFlower1.gameObject.SetActive(true);
                    TTSJobotFlower1a.gameObject.SetActive(false);
                    TTSJobotFlower1b.gameObject.SetActive(false);
                    if (!progressTextIsShowing)
                    { // 3 second delay
                        StartCoroutine(DelayProgressButtonVar1());
                        progressTextIsShowing = true;
                    }
                    textRead1 = true;
                }
              
            }

            if (currentStage1FlowerText == 2)
            {
                if (!textRead2)
                {
                    if (!textBeenRead)
                    {
                        progressText.gameObject.SetActive(false);
                    }
                    progressTextBack.gameObject.SetActive(true);
                    //  pondFrogspawnIntro2
                    jobotIntroStage1Flower.gameObject.SetActive(false);
                    jobotIntroStage1Flower1a.gameObject.SetActive(true);
                    jobotIntroStage1Flower1b.gameObject.SetActive(false);
                    // robCont.enabled = false;
                    LOLSDK.Instance.SpeakText("stage1PlantIntroInfoa");


                    TTSJobotFlower1.gameObject.SetActive(false);
                    TTSJobotFlower1a.gameObject.SetActive(true);
                    TTSJobotFlower1b.gameObject.SetActive(false);
                    if (!progressTextIsShowing)
                    { // 3 second delay
                        StartCoroutine(DelayProgressButtonVar1());
                        progressTextIsShowing = true;
                    }
                    textRead2 = true;
                }
             
            }

            if (currentStage1FlowerText == 3)
            {
                if (!textRead3)
                {
                    //  pondFrogspawnIntro3
                    if (!textBeenRead)
                    {
                        progressText.gameObject.SetActive(false);
                    }
                    jobotIntroStage1Flower.gameObject.SetActive(false);
                    jobotIntroStage1Flower1a.gameObject.SetActive(false);
                    jobotIntroStage1Flower1b.gameObject.SetActive(true);
                    //  robCont.enabled = false;
                    LOLSDK.Instance.SpeakText("stage1PlantIntroInfob");


                    TTSJobotFlower1.gameObject.SetActive(false);
                    TTSJobotFlower1a.gameObject.SetActive(false);
                    TTSJobotFlower1b.gameObject.SetActive(true);
                    if (!progressTextIsShowing)
                    { // 3 second delay
                        StartCoroutine(DelayProgressButtonVar1());
                        progressTextIsShowing = true;
                    }

                    if (!plantProgressSaved)
                    {
                        hint3.gameObject.SetActive(true);
                        rgMain.stage1FlowersExamined = true;
                        rgMain.Stage1PlantsExamined();
                        plantProgressSaved = true;
                    }
                    textRead3 = true;
                }
              
            }

            if (currentStage1FlowerText == 4)
            {
                if (!textRead4)
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
                    textRead4 = true;
                }
               

            }



        }


        void OnMouseDown()
        {
            //StartTextProcessStage1();
            textPanal.SetActive(true);
            // robCont.enabled = false;
            rgMain.MoveCameraToOrganic1LimaPosition();
            // playerCam.enabled = false;
            //flowerCam.enabled = true;
            robotToStopNavmesh.GetComponent<NavMeshAgent>().isStopped = true;
            robCont.NewNavmeshStop();
            currentStage1FlowerText = 1;
            // onClickCollider.enabled = false;
            examDaisy.enabled = false;
            examSusan.enabled = false;
            examRadish.enabled = false;
            Debug.Log("Mouse Clicked");
        }

        public void ReturnToPlayerCamFromPond()
        {
            // robCont.enabled = true;
            //returnToPlayerCam.gameObject.SetActive(false);
           // playerCam.enabled = true;
            // robCont.enabled = true;
           // rgMain.HideCamera();
            textPanal.SetActive(false);
            lima1Textpanal.SetActive(true);
            rgPlantMan2.currentStage1FlowerLimaBeanText = 1;
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
            textRead1 = false;
            textRead2 = false;
            textRead3 = false;
            textRead4 = false;
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
