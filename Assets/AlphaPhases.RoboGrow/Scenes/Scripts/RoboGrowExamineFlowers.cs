using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AI;
using LoLSDK;
namespace Alpha.Phases.Robo.Grow
{
    public class RoboGrowExamineFlowers : MonoBehaviour
    {

        public GameObject textPanal;
        public GameObject susan1TextPanal;
        //  public Button returnToPlayerCam;
        public RoboGrowPlant1Manager rgPlantMan1Susan;
        public RobotController robCont;
        public RoboGrowMain rgMain;
       // public Camera flowerCam;
        public Camera playerCam;
        public GameObject hint3;
        public BoxCollider susanFlowerBox;
        public BoxCollider limaFlowerBox;
        public BoxCollider radishFlowerBox;
        public BoxCollider daisyFlowerBox;

        public GameObject susanArrowToDisable;
        public GameObject limaArrowToDisable;
        public GameObject daisyArrowToDisable;
        public GameObject radishArrowToDisable;

        public bool textRead1;
        public bool textRead2;
        public bool textRead3;
        public bool textRead4;
        public bool textRead5;

        public GameObject robotToStopNavmesh;
        public bool plantProgressSaved;
        public bool textBeenRead;
        public bool progressTextIsShowing;

        public Renderer flowerArrowSusan;
        public Renderer flowerArrowLima;
        public Renderer flowerArrowRadish;
        public Renderer flowerArrowDaisy;

        //public Material orangeMat;

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

            progressTextBack.gameObject.SetActive(false);
            TTSJobotFlower1.onClick.AddListener(JobotStage1Flower1);
            TTSJobotFlower1a.onClick.AddListener(JobotStage1Flower2);
            TTSJobotFlower1b.onClick.AddListener(JobotStage1Flower3);
            progressText.onClick.AddListener(OnClick);
            progressTextBack.onClick.AddListener(OnClickBack);
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
                    robCont.NewNavmeshStop();
                    if (!textBeenRead)
                    {
                        progressText.gameObject.SetActive(false);
                    }
                    progressTextBack.gameObject.SetActive(false);
                    textPanal.SetActive(true);
                    jobotIntroStage1Flower.gameObject.SetActive(true);
                    jobotIntroStage1Flower1a.gameObject.SetActive(false);
                    jobotIntroStage1Flower1b.gameObject.SetActive(false);
                    playerCam.enabled = false;

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
                    //  pondFrogspawnIntro2
                    if (!textBeenRead)
                    {
                        progressText.gameObject.SetActive(false);
                    }
                    jobotIntroStage1Flower.gameObject.SetActive(false);
                    jobotIntroStage1Flower1a.gameObject.SetActive(true);
                    jobotIntroStage1Flower1b.gameObject.SetActive(false);
                    // robCont.enabled = false;
                    progressTextBack.gameObject.SetActive(true);


                    if (!progressTextIsShowing)
                    { // 3 second delay
                        StartCoroutine(DelayProgressButton());
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


                    if (!plantProgressSaved)
                    {
                        hint3.gameObject.SetActive(true);
                        rgMain.stage1FlowersExamined = true;
                        rgMain.Stage1PlantsExamined();
                        plantProgressSaved = true;
                    }

                    if (!progressTextIsShowing)
                    { // 3 second delay
                        StartCoroutine(DelayProgressButtonVar1());
                        progressTextIsShowing = true;
                    }
                    textRead3 = true;
                }
               
            }

           
           

            if (currentStage1FlowerText == 5)
            {
                if (!textRead4)
                {
                    //  jobotIntroStage1e
                    //   robCont.enabled = false;
                    jobotIntroStage1Flower.gameObject.SetActive(false);
                    jobotIntroStage1Flower1a.gameObject.SetActive(false);
                    jobotIntroStage1Flower1b.gameObject.SetActive(false);

                    TTSJobotFlower1.gameObject.SetActive(false);
                    TTSJobotFlower1a.gameObject.SetActive(false);
                    TTSJobotFlower1b.gameObject.SetActive(false);
                    ReturnToPlayerCamFromPond();
                    robCont.NewNavmeshStop();
                    // stage1FlowerBoxToDisable1.enabled = true;
                    //  stage1FlowerBoxToDisable2.enabled = true;
                    // stage1FlowerBoxToDisable3.enabled = true;
                    // stage1FlowerBoxToDisable4.enabled = true;

                    susanArrowToDisable.gameObject.SetActive(false);
                    limaArrowToDisable.gameObject.SetActive(false);
                    daisyArrowToDisable.gameObject.SetActive(false);
                    radishArrowToDisable.gameObject.SetActive(false);

                    // flowerArrowSusan.material = orangeMat;
                    // flowerArrowLima.material = orangeMat;
                    // flowerArrowDaisy.material = orangeMat;
                    //  flowerArrowRadish.material = orangeMat;
                    // stage1FlowerToDisable1.enabled = true;
                    // stage1FlowerToDisable1a.enabled = true;
                    // stage1FlowerToDisable1b.enabled = true;
                    // stage1FlowerToDisable1c.enabled = true;
                    //   stage1FlowerToDisable1d.enabled = true;
                    //   stage1FlowerToDisable1e.enabled = true;
                    ////  stage1FlowerToDisable1f.enabled = true;
                    //  stage1FlowerToDisable1g.enabled = true;
                    //   returnToPlayerCam.gameObject.SetActive(true);
                    // this.gameObject.SetActive(false);
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
            rgMain.MoveCameraToOrganic1SusanPosition();
            // playerCam.enabled = false;
            //flowerCam.enabled = true;
            robotToStopNavmesh.GetComponent<NavMeshAgent>().isStopped = true;
            robCont.NewNavmeshStop();
            currentStage1FlowerText = 1;
           // onClickCollider.enabled = false;

            Debug.Log("Mouse Clicked");
        }

        public void ReturnToPlayerCamFromPond()
        {
            // robCont.enabled = true;
            //returnToPlayerCam.gameObject.SetActive(false);
            // playerCam.enabled = true;
            // robCont.enabled = true;
            //  rgMain.HideCamera();
            susan1TextPanal.SetActive(true);
            rgPlantMan1Susan.currentStage1FlowerBlackEyedSusanText = 1;
            textPanal.SetActive(false);
            robotToStopNavmesh.GetComponent<NavMeshAgent>().isStopped = false;
        }


        void OnClick()
        {
            currentStage1FlowerText++;
            textBeenRead = false;
            progressTextIsShowing = false;
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
        public void StartTextProcessStage1()
        {
            currentStage1FlowerText++;
        }



    }
}
