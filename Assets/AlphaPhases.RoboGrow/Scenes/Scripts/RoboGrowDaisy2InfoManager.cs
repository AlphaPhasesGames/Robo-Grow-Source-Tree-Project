using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using LoLSDK;
using SimpleJSON;
using System.IO;
using UnityEngine.UI;
using TMPro;

namespace Alpha.Phases.Robo.Grow
{
    public class RoboGrowDaisy2InfoManager : MonoBehaviour
    {
        public GameObject textPanal;
      //  public Button returnToPlayeCam;
        public Button waterSeedsDaisy2Stage2;
        public Button waterSeedsSusan1;
        public Button waterSeedsSusan2;
        public Button waterSeedsLimaBean;
        public Button waterSeedsLimaBean2;
        public Button waterSeedsDaisy;
        public Button waterSeedsDaisy2;
        public Button waterSeedsRadish;
        public Button waterSeedsRadish2;
        public RobotController robCont;
        public RoboGrowPlantManager rgPlantMan;
        public RoboGrowMain rgMain;

       // public Camera flowerCam;
        public Camera playerCam;


        public Material wateredColour;
        public Renderer daisyArrowToChangeColour;

        public AudioSource waterSFX;

        public Button destroyPlants;
        public GameObject plantToDestroy;


        public Animator waterDaisy;
        public bool plantsAlreadyWatered;
        public bool plantsAlreadyWateredStage3;
        public bool plantsAlreadyWateredStage4;
        public BoxCollider susan2plantBoxToDisable;
        public BoxCollider susan1plantBoxToDisable;
        public BoxCollider limaBean1plantBoxToDisable;
        public BoxCollider limaBean2plantBoxToDisable;
        public BoxCollider daisy1plantBoxToDisable;
        public BoxCollider radish1plantBoxToDisable;
        public BoxCollider radish2plantBoxToDisable;

        private void Awake()
        {
            waterSeedsDaisy2Stage2.gameObject.SetActive(false);
            waterSeedsSusan1.gameObject.SetActive(false);
            waterSeedsSusan2.gameObject.SetActive(false);
            waterSeedsLimaBean.gameObject.SetActive(false);
            waterSeedsLimaBean2.gameObject.SetActive(false);
            waterSeedsDaisy.gameObject.SetActive(false);
            waterSeedsDaisy2.gameObject.SetActive(false);
            waterSeedsRadish.gameObject.SetActive(false);
            waterSeedsRadish2.gameObject.SetActive(false);
            textPanal.SetActive(false);
        //    returnToPlayeCam.gameObject.SetActive(false);
           // flowerCam.enabled = false;
        }
        // Start is called before the first frame update
        void Start()
        {


        }

        // Update is called once per frame
        void Update()
        {

        }


        void OnMouseDown()
        {
            robCont.NewNavmeshStop();
            if (rgMain.currentGameStage == 2)
            {

                rgMain.MoveCameraToDaisy2Position();
         //       returnToPlayeCam.onClick.AddListener(ReturnToPlayerCam);
                waterSeedsDaisy2Stage2.onClick.AddListener(WaterTheDaisy2Stage2);

                playerCam.enabled = false;
                robCont.enabled = false;
                textPanal.SetActive(true);
                waterSeedsDaisy2Stage2.gameObject.SetActive(true);
          //      returnToPlayeCam.gameObject.SetActive(true);
                Debug.Log("Mouse Clicked");
                susan1plantBoxToDisable.enabled = false;
                susan2plantBoxToDisable.enabled = false;
                limaBean1plantBoxToDisable.enabled = false;
                limaBean2plantBoxToDisable.enabled = false;
                daisy1plantBoxToDisable.enabled = false;
                radish1plantBoxToDisable.enabled = false;
                radish2plantBoxToDisable.enabled = false;
            }
            if (rgMain.currentGameStage == 3)
            {
                rgMain.MoveCameraToDaisy2Position();
                //       returnToPlayeCam.onClick.AddListener(ReturnToPlayerCam);

                waterSeedsDaisy2.onClick.AddListener(WaterTheDaisy2Stage3);
                playerCam.enabled = false;
                robCont.enabled = false;
                textPanal.SetActive(true);
                waterSeedsDaisy2.gameObject.SetActive(true);
         //       returnToPlayeCam.gameObject.SetActive(true);
                Debug.Log("Mouse Clicked");
                susan1plantBoxToDisable.enabled = false;
                susan2plantBoxToDisable.enabled = false;
                limaBean1plantBoxToDisable.enabled = false;
                limaBean2plantBoxToDisable.enabled = false;
                daisy1plantBoxToDisable.enabled = false;
                radish1plantBoxToDisable.enabled = false;
                radish2plantBoxToDisable.enabled = false;
            }

            if (rgMain.currentGameStage == 4)
            {
                rgMain.MoveCameraToDaisy2Position();
                //      returnToPlayeCam.onClick.AddListener(ReturnToPlayerCam);

                waterSeedsDaisy2.onClick.AddListener(WaterTheDaisy2Stage4);
                playerCam.enabled = false;
                robCont.enabled = false;
                textPanal.SetActive(true);
                waterSeedsDaisy2.gameObject.SetActive(true);
          //      returnToPlayeCam.gameObject.SetActive(true);
                Debug.Log("Mouse Clicked");
                susan1plantBoxToDisable.enabled = false;
                susan2plantBoxToDisable.enabled = false;
                limaBean1plantBoxToDisable.enabled = false;
                limaBean2plantBoxToDisable.enabled = false;
                daisy1plantBoxToDisable.enabled = false;
                radish1plantBoxToDisable.enabled = false;
                radish2plantBoxToDisable.enabled = false;
            }

            if (rgMain.currentGameStage == 5)
            {

                rgMain.MoveCameraToDaisy2Position();
                //      returnToPlayeCam.onClick.AddListener(ReturnToPlayerCam);
                destroyPlants.onClick.AddListener(RemoveDeadPlants);
                waterSeedsLimaBean2.gameObject.SetActive(true);
                destroyPlants.gameObject.SetActive(true);
                playerCam.enabled = false;
                robCont.enabled = false;
                textPanal.SetActive(true);

          //      returnToPlayeCam.gameObject.SetActive(true);
                Debug.Log("Mouse Clicked");
                susan1plantBoxToDisable.enabled = false;
                susan2plantBoxToDisable.enabled = false;
                limaBean1plantBoxToDisable.enabled = false;
                limaBean2plantBoxToDisable.enabled = false;
                daisy1plantBoxToDisable.enabled = false;
                radish1plantBoxToDisable.enabled = false;
                radish2plantBoxToDisable.enabled = false;
            }

        }

        public void ReturnToPlayerCam()
        {
            robCont.enabled = true;
       //     returnToPlayeCam.gameObject.SetActive(false);
            playerCam.enabled = true;
            rgMain.HideCamera();
            waterSeedsDaisy2Stage2.gameObject.SetActive(false);
            textPanal.SetActive(false);
            destroyPlants.gameObject.SetActive(false);
            waterSeedsSusan1.gameObject.SetActive(false);
            waterSeedsSusan2.gameObject.SetActive(false);
            waterSeedsLimaBean.gameObject.SetActive(false);
            waterSeedsLimaBean2.gameObject.SetActive(false);
            waterSeedsDaisy.gameObject.SetActive(false);
            waterSeedsDaisy2.gameObject.SetActive(false);
            waterSeedsRadish.gameObject.SetActive(false);
            waterSeedsRadish2.gameObject.SetActive(false);

            susan2plantBoxToDisable.enabled = true;
            susan1plantBoxToDisable.enabled = true;
            limaBean1plantBoxToDisable.enabled = true;
            limaBean2plantBoxToDisable.enabled = true;
            daisy1plantBoxToDisable.enabled = true;
            radish1plantBoxToDisable.enabled = true;
            radish2plantBoxToDisable.enabled = true;
        }


               

        public void WaterTheDaisy2Stage2()
        {
            Debug.Log("watered plants");
            waterDaisy.SetTrigger("waterDaisy2");
            waterSeedsDaisy2Stage2.gameObject.SetActive(false);
            ReturnToPlayerCam();
            if (!plantsAlreadyWatered)
            {
                rgMain.amountofPlantsWateredStage2 = rgMain.amountofPlantsWateredStage2 + 1;
                plantsAlreadyWatered = true;
                daisyArrowToChangeColour.material = wateredColour;
                waterSFX.Play();
                rgMain.amountOfStage4FlowersWatered = rgMain.amountOfStage4FlowersWatered + 1;
            }
            rgMain.HideCamera();

        }
        public void WaterTheDaisy2Stage3()
        {
            Debug.Log("watered plants");
            waterDaisy.SetTrigger("waterDaisy2");
            waterSeedsDaisy2.gameObject.SetActive(false);
            ReturnToPlayerCam();
            if (!plantsAlreadyWateredStage3)
            {
                rgMain.amountofPlantsWateredStage3 = rgMain.amountofPlantsWateredStage3 + 1;
                plantsAlreadyWateredStage3 = true;
                daisyArrowToChangeColour.material = wateredColour;
                waterSFX.Play();
              
            }
            rgMain.HideCamera();
        }

        public void WaterTheDaisy2Stage4()
        {
            Debug.Log("watered plants");
            waterDaisy.SetTrigger("waterDaisy2");
            waterSeedsDaisy2.gameObject.SetActive(false);
            ReturnToPlayerCam();
            if (!plantsAlreadyWateredStage4)
            {
                rgMain.amountOfStage4FlowersWatered = rgMain.amountOfStage4FlowersWatered + 1;
                plantsAlreadyWateredStage4 = true;
                daisyArrowToChangeColour.material = wateredColour;
                waterSFX.Play();
               
            }
            rgMain.HideCamera();
        }


        public void RemoveDeadPlants()
        {
          
            plantToDestroy.SetActive(false);
            // rgMain.amountOfRemovedFlowersStage5 = rgMain.amountOfRemovedFlowersStage5 + 1;
            rgMain.amountOfRemovedFlowersStage5 = rgMain.amountOfRemovedFlowersStage5 + 1;
            rgMain.HideCamera();
            destroyPlants.gameObject.SetActive(false);
            playerCam.enabled = true;
            robCont.enabled = true;
            //extPanal.SetActive(false);
            ReturnToPlayerCam();
        }
    }
}
