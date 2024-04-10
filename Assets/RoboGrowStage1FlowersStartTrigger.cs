using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AI;
using LoLSDK;
namespace Alpha.Phases.Robo.Grow
{
    public class RoboGrowStage1FlowersStartTrigger : MonoBehaviour
    {

        public GameObject textPanal;
        public GameObject susan1TextPanal;
        //  public Button returnToPlayerCam;
        public RoboGrowPlant1Manager rgPlantMan1Susan;

        public RoboGrowExamineFlowersRadish examRadish;
        public RoboGrowExamineFlowersLimaBean examLima;
        public RoboGrowExamineFlowersDaisy examDaisy;
        
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
            //   progressTextBack.onClick.AddListener(OnClickBack);
            // returnToPlayerCam.gameObject.SetActive(false);
            //   flowerCam.enabled = false;
           // textPanal.SetActive(false);

        //    susanFlowerBox.enabled = false;
        //    limaFlowerBox.enabled = false;
        //    daisyFlowerBox.enabled = false;
        //    radishFlowerBox.enabled = false;
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

            if (currentStage1FlowerText == 1)
            {
                robCont.NewNavmeshStop();
                if (!textBeenRead)
                {
                    progressText.gameObject.SetActive(false);
                }
                progressTextBack.gameObject.SetActive(false);
                textPanal.SetActive(true);
                jobotIntroStage1Flower.enabled = true;
                jobotIntroStage1Flower1a.enabled = false;
                jobotIntroStage1Flower1b.enabled = false;
                playerCam.enabled = false;
                robCont.NewNavmeshStop();
                TTSJobotFlower1.gameObject.SetActive(true);
                TTSJobotFlower1a.gameObject.SetActive(false);
                TTSJobotFlower1b.gameObject.SetActive(false);

                if (!progressTextIsShowing)
                { // 3 second delay
                    StartCoroutine(DelayProgressButtonVar1());
                    progressTextIsShowing = true;
                }
            }

            if (currentStage1FlowerText == 2)
            {
                //  pondFrogspawnIntro2
                if (!textBeenRead)
                {
                    progressText.gameObject.SetActive(false);
                }
                jobotIntroStage1Flower.enabled = false;
                jobotIntroStage1Flower1a.enabled = true;
                jobotIntroStage1Flower1b.enabled = false;
                // robCont.enabled = false;
                progressTextBack.gameObject.SetActive(true);
                robCont.NewNavmeshStop();
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
                    StartCoroutine(DelayProgressButtonVar1());
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
            flowerArrowDaisy.enabled = false;
            flowerArrowLima.enabled = false;
            flowerArrowSusan.enabled = false;
            flowerArrowRadish.enabled = false;
            examDaisy.enabled = false;
            examLima.enabled = false;
            examRadish.enabled = false;

            Debug.Log("Mouse Clicked");
        }

        public void ReturnToPlayerCamFromPond()
        {
            // robCont.enabled = true;
            //returnToPlayerCam.gameObject.SetActive(false);
            // playerCam.enabled = true;
            // robCont.enabled = true;
            //  rgMain.HideCamera();
        

           // examDaisy.enabled = true;
          // / examLima.enabled = true;
           // examRadish.enabled = true;
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
            robCont.NewNavmeshStop();

        }

        void OnClickBack()
        {
            currentStage1FlowerText--;
        }

        void JobotStage1Flower1()
        {
            LOLSDK.Instance.SpeakText("stage1PlantIntroInfo");
            Debug.Log("stage1PlantIntroInfo is playing");
        }

        void JobotStage1Flower2()
        {
            LOLSDK.Instance.SpeakText("stage1PlantIntroInfoa");
            Debug.Log("stage1PlantIntroInfoa is playing");
        }

        void JobotStage1Flower3()
        {
            LOLSDK.Instance.SpeakText("stage1PlantIntroInfob");
            Debug.Log("stage1PlantIntroInfob is playing");
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
