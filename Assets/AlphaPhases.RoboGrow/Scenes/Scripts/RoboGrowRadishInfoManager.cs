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
    public class RoboGrowRadishInfoManager : MonoBehaviour
    {
        public GameObject textPanal;
       // public Button returnToPlayeCam;
        public Button waterSeeds;
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

    
        public Camera playerCam;
        public bool plantsAlreadyWatered;
        public bool plantsAlreadyWateredStage3;
        public bool plantsAlreadyWateredStage4;
        public Animator waterRadish;

        public Material wateredColour;
        public Renderer radishArrowToChangeColour;

        public AudioSource waterSFX;

        public Button destroyPlants;
        public GameObject plantToDestroy;

        public BoxCollider susan2plantBoxToDisable;
        public BoxCollider susan1plantBoxToDisable;
        public BoxCollider limaBean1plantBoxToDisable;
        public BoxCollider limaBean2plantBoxToDisable;
        public BoxCollider daisy2plantBoxToDisable;
        public BoxCollider daisy1plantBoxToDisable;
        public BoxCollider radish2plantBoxToDisable;

        private void Awake()
        {
           // waterSeeds.gameObject.SetActive(false);
            waterSeedsSusan1.gameObject.SetActive(false);
            waterSeedsSusan2.gameObject.SetActive(false);
            waterSeedsLimaBean.gameObject.SetActive(false);
            waterSeedsLimaBean2.gameObject.SetActive(false);
            waterSeedsDaisy.gameObject.SetActive(false);
            waterSeedsDaisy2.gameObject.SetActive(false);
            waterSeedsRadish.gameObject.SetActive(false);
            waterSeedsRadish2.gameObject.SetActive(false);
            textPanal.SetActive(false);
         //   returnToPlayeCam.gameObject.SetActive(false);
       //     flowerCam.enabled = false;
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

                rgMain.MoveCameraToRadish1Position();
           //     returnToPlayeCam.onClick.AddListener(ReturnToPlayerCam);
                waterSeeds.onClick.AddListener(WaterTheRadishesStage2);

                playerCam.enabled = false;
                robCont.enabled = false;
                textPanal.SetActive(true);
                waterSeeds.gameObject.SetActive(true);
            //    returnToPlayeCam.gameObject.SetActive(true);
                Debug.Log("Mouse Clicked");
                susan1plantBoxToDisable.enabled = false;
                susan2plantBoxToDisable.enabled = false;
                limaBean1plantBoxToDisable.enabled = false;
                limaBean2plantBoxToDisable.enabled = false;
                daisy1plantBoxToDisable.enabled = false;
                daisy2plantBoxToDisable.enabled = false;
                radish2plantBoxToDisable.enabled = false;
            }
            if (rgMain.currentGameStage == 3)
            {
                rgMain.MoveCameraToRadish1Position();
                //     returnToPlayeCam.onClick.AddListener(ReturnToPlayerCam);

                waterSeedsRadish.onClick.AddListener(WaterTheRadishStage3);
                playerCam.enabled = false;
                robCont.enabled = false;
                textPanal.SetActive(true);
                waterSeedsRadish.gameObject.SetActive(true);
             //   returnToPlayeCam.gameObject.SetActive(true);
                Debug.Log("Mouse Clicked");
                susan1plantBoxToDisable.enabled = false;
                susan2plantBoxToDisable.enabled = false;
                limaBean1plantBoxToDisable.enabled = false;
                limaBean2plantBoxToDisable.enabled = false;
                daisy1plantBoxToDisable.enabled = false;
                daisy2plantBoxToDisable.enabled = false;
                radish2plantBoxToDisable.enabled = false;
            }

            if (rgMain.currentGameStage == 4)
            {
                rgMain.MoveCameraToRadish1Position();
                //   returnToPlayeCam.onClick.AddListener(ReturnToPlayerCam);

                waterSeedsRadish.onClick.AddListener(WaterTheRadishStage4);
                playerCam.enabled = false;
                robCont.enabled = false;
                textPanal.SetActive(true);
                waterSeedsRadish.gameObject.SetActive(true);
             //   returnToPlayeCam.gameObject.SetActive(true);
                Debug.Log("Mouse Clicked");
                susan1plantBoxToDisable.enabled = false;
                susan2plantBoxToDisable.enabled = false;
                limaBean1plantBoxToDisable.enabled = false;
                limaBean2plantBoxToDisable.enabled = false;
                daisy1plantBoxToDisable.enabled = false;
                daisy2plantBoxToDisable.enabled = false;
                radish2plantBoxToDisable.enabled = false;
            }

            if (rgMain.currentGameStage == 5)
            {

                rgMain.MoveCameraToRadish1Position();
                //   returnToPlayeCam.onClick.AddListener(ReturnToPlayerCam);
                destroyPlants.onClick.AddListener(RemoveDeadPlants);
                waterSeedsLimaBean2.gameObject.SetActive(true);
                destroyPlants.gameObject.SetActive(true);
                playerCam.enabled = false;
                robCont.enabled = false;
                textPanal.SetActive(true);

              //  returnToPlayeCam.gameObject.SetActive(true);
                Debug.Log("Mouse Clicked");
                susan1plantBoxToDisable.enabled = false;
                susan2plantBoxToDisable.enabled = false;
                limaBean1plantBoxToDisable.enabled = false;
                limaBean2plantBoxToDisable.enabled = false;
                daisy1plantBoxToDisable.enabled = false;
                daisy2plantBoxToDisable.enabled = false;
                radish2plantBoxToDisable.enabled = false;
            }

        }

        public void ReturnToPlayerCam()
        {
            robCont.enabled = true;
          //  returnToPlayeCam.gameObject.SetActive(false);
            playerCam.enabled = true;
            rgMain.HideCamera();
            waterSeeds.gameObject.SetActive(false);
            destroyPlants.gameObject.SetActive(false);
            textPanal.SetActive(false);


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
            daisy2plantBoxToDisable.enabled = true;
            daisy1plantBoxToDisable.enabled = true;
            radish2plantBoxToDisable.enabled = true;
        }




        public void WaterTheRadishesStage2()
        {
            Debug.Log("watered plants");
            waterRadish.SetTrigger("waterRadish");
            waterSeeds.gameObject.SetActive(false);
            ReturnToPlayerCam();
            if (!plantsAlreadyWatered)
            {
                waterRadish.SetTrigger("resetRadish");
                waterSeeds.onClick.RemoveListener(WaterTheRadishesStage2);
                rgMain.amountofPlantsWateredStage2 = rgMain.amountofPlantsWateredStage2 + 1;
                plantsAlreadyWatered = true;
                radishArrowToChangeColour.material = wateredColour;
                waterSFX.Play();
               
            }
            rgMain.HideCamera();

        }
        public void WaterTheRadishStage3()
        {
            Debug.Log("watered plants");
            waterRadish.SetTrigger("waterRadish");
            waterSeedsRadish.gameObject.SetActive(false);
            ReturnToPlayerCam();
            if (!plantsAlreadyWateredStage3)
            {   waterRadish.SetTrigger("resetRadish");
                rgMain.amountofPlantsWateredStage3 = rgMain.amountofPlantsWateredStage3 + 1;
                plantsAlreadyWateredStage3 = true;
                radishArrowToChangeColour.material = wateredColour;
                waterSFX.Play();
             
            }
            rgMain.HideCamera();
        }

        public void WaterTheRadishStage4()
        {
            Debug.Log("watered plants");
            waterRadish.SetTrigger("waterRadish");
            waterSeedsRadish.gameObject.SetActive(false);
            ReturnToPlayerCam();
            if (!plantsAlreadyWateredStage4)
            {
                //rgMain.amountofPlantsWateredStage3 = rgMain.amountofPlantsWateredStage3 + 1;
                plantsAlreadyWateredStage4 = true;
                radishArrowToChangeColour.material = wateredColour;
                waterSFX.Play();
                rgMain.amountOfStage4FlowersWatered = rgMain.amountOfStage4FlowersWatered + 1;
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
            ReturnToPlayerCam();
            //extPanal.SetActive(false);

        }
    }
}
