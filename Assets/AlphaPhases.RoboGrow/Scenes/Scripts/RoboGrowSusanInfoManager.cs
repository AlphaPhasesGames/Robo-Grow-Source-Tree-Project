using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace Alpha.Phases.Robo.Grow
{
    public class RoboGrowSusanInfoManager : MonoBehaviour
    {
        public GameObject textPanal;
       // public Button returnToPlayeCam;
      //  public Button returnToPlayeCamToDisable;
        public Button waterSeedsStage1;
        public Button waterSeedsSusan1;
        public Button waterSeedsSusan2;
        public Button waterSeedsLimaBean;
        public Button waterSeedsLimaBean2;
        public Button waterSeedsDaisy;
        public Button waterSeedsDaisy2;
        public Button waterSeedsRadish;
        public Button waterSeedsRadish2;

        public Button destroyPlants;
        public Material wateredColour;
        public Renderer susanArrowToChangeColour;

        public RobotController robCont;
        public RoboGrowPlantManager rgPlantMan;
        public RoboGrowMain rgMain;

        public AudioSource waterSFX; 

        public Animator susan1WaterToReset;
        public Animator susan2WaterToReset;
        public Animator lima1WaterToReset;
        public Animator lima2WaterToReset;
        public Animator daisy1WaterToReset;
        public Animator daisy2WaterToReset;
        public Animator radish1WaterToReset;
        public Animator radish2WaterToReset;

       // public Camera flowerCam;
        public Camera playerCam;

        public GameObject plantToDestroy;

        public Animator waterSusan;
        public bool plantsAlreadyWatered;
        public bool plantsAlradyWateredstage3;
        public bool plantsAlradyWateredstage4;
        public BoxCollider susan2plantBoxToDisable;
        public BoxCollider limaBean1plantBoxToDisable;
        public BoxCollider limaBean2plantBoxToDisable;
        public BoxCollider daisy1plantBoxToDisable;
        public BoxCollider daisy2plantBoxToDisable;
        public BoxCollider radish1plantBoxToDisable;
        public BoxCollider radish2plantBoxToDisable;

        private void Awake()
        {
            waterSeedsStage1.gameObject.SetActive(false);
            waterSeedsSusan1.gameObject.SetActive(false);
            waterSeedsSusan2.gameObject.SetActive(false);
            waterSeedsLimaBean.gameObject.SetActive(false);
            waterSeedsLimaBean2.gameObject.SetActive(false);
            waterSeedsDaisy.gameObject.SetActive(false);
            waterSeedsDaisy2.gameObject.SetActive(false);
            waterSeedsRadish.gameObject.SetActive(false);
            waterSeedsRadish2.gameObject.SetActive(false);
            textPanal.SetActive(false);
           // returnToPlayeCam.gameObject.SetActive(false);
         //   flowerCam.enabled = false;
        }
    


        void OnMouseDown()
        {
            robCont.NewNavmeshStop();
            if (rgMain.currentGameStage == 2)
            {
             //   flowerCam.enabled = true;
             //   returnToPlayeCam.onClick.AddListener(ReturnToPlayerCam);
                waterSeedsStage1.onClick.AddListener(WaterTheSusan1);
                waterSeedsStage1.gameObject.SetActive(true);
                rgMain.MoveCameraToSusan1Position();
                playerCam.enabled = false;
                robCont.enabled = false;
                textPanal.SetActive(true);
               
             //   returnToPlayeCam.gameObject.SetActive(true);
                Debug.Log("Mouse Clicked");
                susan2plantBoxToDisable.enabled = false;
                limaBean1plantBoxToDisable.enabled = false;
                limaBean2plantBoxToDisable.enabled = false;
                daisy1plantBoxToDisable.enabled = false;
                daisy2plantBoxToDisable.enabled = false;
                radish1plantBoxToDisable.enabled = false;
                radish2plantBoxToDisable.enabled = false;





            }
            
            if (rgMain.currentGameStage == 3)
            {
                rgMain.MoveCameraToSusan1Position();
                //  returnToPlayeCam.onClick.AddListener(ReturnToPlayerCam);

                waterSeedsSusan1.onClick.AddListener(WaterTheSusan2);
                playerCam.enabled = false;
                robCont.enabled = false;
                textPanal.SetActive(true);
              //  returnToPlayeCam.gameObject.SetActive(true);
                waterSeedsSusan1.gameObject.SetActive(true);
                Debug.Log("Mouse Clicked");
                susan2plantBoxToDisable.enabled = false;
                limaBean1plantBoxToDisable.enabled = false;
                limaBean2plantBoxToDisable.enabled = false;
                daisy1plantBoxToDisable.enabled = false;
                daisy2plantBoxToDisable.enabled = false;
                radish1plantBoxToDisable.enabled = false;
                radish2plantBoxToDisable.enabled = false;
            }

            if (rgMain.currentGameStage == 4)
            {
                rgMain.MoveCameraToSusan1Position();
                //   returnToPlayeCam.onClick.AddListener(ReturnToPlayerCam);

                waterSeedsSusan1.onClick.AddListener(WaterTheSusan3);
                playerCam.enabled = false;
                robCont.enabled = false;
                textPanal.SetActive(true);
            //  returnToPlayeCam.gameObject.SetActive(true);
                waterSeedsSusan1.gameObject.SetActive(true);
                Debug.Log("Mouse Clicked");
                susan2plantBoxToDisable.enabled = false;
                limaBean1plantBoxToDisable.enabled = false;
                limaBean2plantBoxToDisable.enabled = false;
                daisy1plantBoxToDisable.enabled = false;
                daisy2plantBoxToDisable.enabled = false;
                radish1plantBoxToDisable.enabled = false;
                radish2plantBoxToDisable.enabled = false;
            }

            if (rgMain.currentGameStage == 5)
            {

                rgMain.MoveCameraToSusan1Position();
                // returnToPlayeCam.onClick.AddListener(ReturnToPlayerCam);
                destroyPlants.onClick.AddListener(RemoveDeadPlants);
                waterSeedsSusan1.gameObject.SetActive(true);
                destroyPlants.gameObject.SetActive(true);
                playerCam.enabled = false;
                robCont.enabled = false;
                textPanal.SetActive(true);

               // returnToPlayeCam.gameObject.SetActive(true);
                Debug.Log("Mouse Clicked");
                susan2plantBoxToDisable.enabled = false;
                limaBean1plantBoxToDisable.enabled = false;
                limaBean2plantBoxToDisable.enabled = false;
                daisy1plantBoxToDisable.enabled = false;
                daisy2plantBoxToDisable.enabled = false;
                radish1plantBoxToDisable.enabled = false;
                radish2plantBoxToDisable.enabled = false;
            }
            
        }

        public void ReturnToPlayerCam()
        {
            robCont.enabled = true;
           // returnToPlayeCam.gameObject.SetActive(false);
            playerCam.enabled = true;
            rgMain.HideCamera();
            //    waterSusan.ResetTrigger("waterSusans");
            // waterSusan.SetTrigger("resetSusans");
            destroyPlants.gameObject.SetActive(false);
            waterSeedsStage1.gameObject.SetActive(false);
            waterSeedsSusan1.gameObject.SetActive(false);
            waterSeedsSusan2.gameObject.SetActive(false);
            waterSeedsLimaBean.gameObject.SetActive(false);
            waterSeedsLimaBean2.gameObject.SetActive(false);
            waterSeedsDaisy.gameObject.SetActive(false);
            waterSeedsDaisy2.gameObject.SetActive(false);
            waterSeedsRadish.gameObject.SetActive(false);
            waterSeedsRadish2.gameObject.SetActive(false);

            textPanal.SetActive(false);

            susan2plantBoxToDisable.enabled = true;
            limaBean1plantBoxToDisable.enabled = true;
            limaBean2plantBoxToDisable.enabled = true;
            daisy1plantBoxToDisable.enabled = true;
            daisy2plantBoxToDisable.enabled = true;
            radish1plantBoxToDisable.enabled = true;
            radish2plantBoxToDisable.enabled = true;
        }




        public void WaterTheSusan1()
        {
            Debug.Log("watered plants");
            waterSusan.SetTrigger("waterSusans");
            waterSeedsStage1.gameObject.SetActive(false);
            ReturnToPlayerCam();
            if (!plantsAlreadyWatered)
                {
                    rgMain.amountofPlantsWateredStage2 = rgMain.amountofPlantsWateredStage2 + 1;
                    plantsAlreadyWatered = true;
                    susanArrowToChangeColour.material = wateredColour;
               
                    waterSFX.Play();
                }
            rgMain.HideCamera();

        }

   
        public void WaterTheSusan2()
        {
            Debug.Log("watered plants");
            waterSusan.SetTrigger("waterSusans");
            waterSeedsSusan1.gameObject.SetActive(false);
            ReturnToPlayerCam();
            if (!plantsAlradyWateredstage3)
                {
                    rgMain.amountofPlantsWateredStage3 = rgMain.amountofPlantsWateredStage3 + 1;
                    plantsAlradyWateredstage3 = true;
                    susanArrowToChangeColour.material = wateredColour;
                    waterSFX.Play();
                  
            }
            rgMain.HideCamera();
        }

        public void WaterTheSusan3()
        {
            Debug.Log("watered plants");
            waterSusan.SetTrigger("waterSusans");
            waterSeedsSusan1.gameObject.SetActive(false);
            ReturnToPlayerCam();
            if (!plantsAlradyWateredstage4)
            {
                // rgMain.amountofPlantsWateredStage3 = rgMain.amountofPlantsWateredStage3 + 1;
                rgMain.amountOfStage4FlowersWatered = rgMain.amountOfStage4FlowersWatered + 1;
                susanArrowToChangeColour.material = wateredColour;
                waterSFX.Play();
                plantsAlradyWateredstage4 = true;
               
            }
            rgMain.HideCamera();
        }

        public void WaterTheSusanStage4()
        {
            ReturnToPlayerCam();
            if (!plantsAlradyWateredstage4)
            {
                Debug.Log("watered plants");
                waterSusan.SetTrigger("waterSusans");
                waterSeedsStage1.gameObject.SetActive(false);
                plantsAlradyWateredstage4 = true;
                waterSFX.Play();
               

            }
            rgMain.HideCamera();

        }

        public void RemoveDeadPlants()
        {
            ReturnToPlayerCam();
            plantToDestroy.SetActive(false);
            // rgMain.amountOfRemovedFlowersStage5 = rgMain.amountOfRemovedFlowersStage5 + 1;
            rgMain.HideCamera();
            destroyPlants.gameObject.SetActive(false);
            playerCam.enabled = true;
            robCont.enabled = true;
            rgMain.amountOfRemovedFlowersStage5 = rgMain.amountOfRemovedFlowersStage5 + 1;
           // textPanal.SetActive(false);
        }

    }
}
