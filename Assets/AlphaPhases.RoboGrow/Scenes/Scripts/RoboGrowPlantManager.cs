using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using LoLSDK;
using SimpleJSON;
using System.IO;


namespace Alpha.Phases.Robo.Grow
{
    public class RoboGrowPlantManager : MonoBehaviour
    {
        public RoboGrowMain rGMain;
      //  public BoxCollider treeToEnable;
        public int removedFlowers;

        public bool saveOnlyOnce;

        public GameObject plant1ToUnHide;
        public GameObject plant2ToUnHide;
        public GameObject plant3ToUnHide;
        public GameObject plant4ToUnHide;
        public GameObject plant5ToUnHide;
        public GameObject plant6ToUnHide;
        public GameObject plant7ToUnHide;
        public GameObject plant8ToUnHide;


        public GameObject mudToHide;
        public GameObject mudToHide2;
        public GameObject mudToHide3;
        public GameObject mudToHide4;
        public GameObject mudToHide5;
        public GameObject mudToHide6;
        public GameObject mudToHide7;
        public GameObject mudToHide8;

        public GameObject germination;
        public GameObject growth;
        public GameObject vegetative;
        public GameObject vegetativeHeaded;
        public GameObject flowering;
        public GameObject seedingDying;


        public GameObject plant2Germination;
        public GameObject plant2Growth;
        public GameObject plant2Vegetative;
        public GameObject plant2VegetativeHeaded;
        public GameObject plant2Flowering;
        public GameObject plant2SeedingDying;

        public GameObject plant3Germination;
        public GameObject plant3Growth;
        public GameObject plant3Vegetative;
        public GameObject plant3VegetativeHeaded;
        public GameObject plant3Flowering;
        public GameObject plant3SeedingDying;

        public GameObject plant4Germination;
        public GameObject plant4Growth;
        public GameObject plant4Vegetative;
        public GameObject plant4VegetativeHeaded;
        public GameObject plant4Flowering;
        public GameObject plant4SeedingDying;

        public GameObject plant5Germination;
        public GameObject plant5Growth;
        public GameObject plant5Vegetative;
        public GameObject plant5VegetativeHeaded;
        public GameObject plant5Flowering;
        public GameObject plant5SeedingDying;

        public GameObject plant6Germination;
        public GameObject plant6Growth;
        public GameObject plant6Vegetative;
        public GameObject plant6VegetativeHeaded;
        public GameObject plant6Flowering;
        public GameObject plant6SeedingDying;

        public GameObject plant7Germination;
        public GameObject plant7Growth;
        public GameObject plant7Vegetative;
        public GameObject plant7VegetativeHeaded;
        public GameObject plant7Flowering;
        public GameObject plant7SeedingDying;

        public GameObject plant8Germination;
        public GameObject plant8Growth;
        public GameObject plant8Vegetative;
        public GameObject plant8VegetativeHeaded;
        public GameObject plant8Flowering;
        public GameObject plant8SeedingDying;

        public int stageNo;

        private void Awake()
        {
            rGMain.plantInGameStage = 3;
        }

        private void Update()
        {

            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                rGMain.plantInGameStage++;
                if(rGMain.plantInGameStage >= 8)
                {
                    rGMain.plantInGameStage = 0;
                }
            }
            if (rGMain.plantInGameStage == 0)
            {
                SeedingDying(); 
            }

            if (rGMain.plantInGameStage == 1)
            {
                NoPlants();
              
            }

            if (rGMain.plantInGameStage == 2)
            {
                SeedGerminated();
               
            }

            if (rGMain.plantInGameStage == 3)
            {
                GrowthStage();
                
            }

            if (rGMain.plantInGameStage == 4)
            {
                VegatativeStage();
                           
            }
            if (rGMain.plantInGameStage == 5)
            {
                VegatativeHeadedStage();
              
            }
            if (rGMain.plantInGameStage == 6)
            {
                FloweringStage();
            }
            if (rGMain.plantInGameStage == 7)
            {
                SeedingDying();
            }

            if (rGMain.plantInGameStage == 8)
            {
                stageNo = 0;
            }

            if(removedFlowers >3)
            {
                if (!saveOnlyOnce)
                {
                    rGMain.stage1PlantRemovalComplete = true;
                    rGMain.seedsSavedInInventory = true;
                    rGMain.SaveStage1TasksComplete();
                  
                   // treeToEnable.enabled = true;
                    rGMain.task1TextUITick1.SetActive(true);
                    saveOnlyOnce = true;
                }
               

            }
        }


        public void NoPlants()
        {
            mudToHide.SetActive(false);
            mudToHide2.SetActive(false);
            mudToHide3.SetActive(false);
            mudToHide4.SetActive(false);
            mudToHide5.SetActive(false);
            mudToHide6.SetActive(false);
            mudToHide8.SetActive(false);
            mudToHide8.SetActive(false);


            germination.SetActive(false);
            plant2Germination.SetActive(false);
            plant3Germination.SetActive(false);
            plant4Germination.SetActive(false);
            plant5Germination.SetActive(false);
            plant6Germination.SetActive(false);
            plant7Germination.SetActive(false);
            plant8Germination.SetActive(false);

            growth.SetActive(false);
            plant2Growth.SetActive(false);
            plant3Growth.SetActive(false);
            plant4Growth.SetActive(false);
            plant5Growth.SetActive(false);
            plant6Growth.SetActive(false);
            plant7Growth.SetActive(false);
            plant8Growth.SetActive(false);

            vegetative.SetActive(false);
            plant2Vegetative.SetActive(false);
            plant3Vegetative.SetActive(false);
            plant4Vegetative.SetActive(false);
            plant5Vegetative.SetActive(false);
            plant6Vegetative.SetActive(false);
            plant7Vegetative.SetActive(false);
            plant8Vegetative.SetActive(false);

            vegetativeHeaded.SetActive(false);
            plant2VegetativeHeaded.SetActive(false);
            plant3VegetativeHeaded.SetActive(false);
            plant4VegetativeHeaded.SetActive(false);
            plant5VegetativeHeaded.SetActive(false);
            plant6VegetativeHeaded.SetActive(false);
            plant7VegetativeHeaded.SetActive(false);
           plant8VegetativeHeaded.SetActive(false);

            flowering.SetActive(false);
            plant2Flowering.SetActive(false);
            plant3Flowering.SetActive(false);
            plant4Flowering.SetActive(false);
            plant5Flowering.SetActive(false);
            plant6Flowering.SetActive(false);
            plant7Flowering.SetActive(false);
            plant8Flowering.SetActive(false);

            seedingDying.SetActive(false);
            plant2SeedingDying.SetActive(false);
            plant3SeedingDying.SetActive(false);
            plant4SeedingDying.SetActive(false);
            plant5SeedingDying.SetActive(false);
            plant6SeedingDying.SetActive(false);
            plant7SeedingDying.SetActive(false);
            plant8SeedingDying.SetActive(false);
        }

        public void SeedGerminated()
        {

           // ReappearPlantsAfterRemovingDead();

            mudToHide.SetActive(true);
            mudToHide2.SetActive(true);
            mudToHide3.SetActive(true);
            mudToHide4.SetActive(true);
            mudToHide5.SetActive(true);
            mudToHide6.SetActive(true);
            mudToHide8.SetActive(true);
            mudToHide8.SetActive(true);

            germination.SetActive(true);
            plant2Germination.SetActive(true);
            plant3Germination.SetActive(true);
            plant4Germination.SetActive(true);
            plant5Germination.SetActive(true);
            plant6Germination.SetActive(true);
            plant7Germination.SetActive(true);
            plant8Germination.SetActive(true);

            growth.SetActive(false);
            plant2Growth.SetActive(false);
            plant3Growth.SetActive(false);
            plant4Growth.SetActive(false);
            plant5Growth.SetActive(false);
            plant6Growth.SetActive(false);
            plant7Growth.SetActive(false);
            plant8Growth.SetActive(false);

            vegetative.SetActive(false);
            plant2Vegetative.SetActive(false);
            plant3Vegetative.SetActive(false);
            plant4Vegetative.SetActive(false);
            plant5Vegetative.SetActive(false);
            plant6Vegetative.SetActive(false);
            plant7Vegetative.SetActive(false);
           plant8Vegetative.SetActive(false);

            vegetativeHeaded.SetActive(false);
            plant2VegetativeHeaded.SetActive(false);
            plant3VegetativeHeaded.SetActive(false);
            plant4VegetativeHeaded.SetActive(false);
            plant5VegetativeHeaded.SetActive(false);
            plant6VegetativeHeaded.SetActive(false);
            plant7VegetativeHeaded.SetActive(false);
            plant8VegetativeHeaded.SetActive(false);

            flowering.SetActive(false);
            plant2Flowering.SetActive(false);
            plant3Flowering.SetActive(false);
            plant4Flowering.SetActive(false);
            plant5Flowering.SetActive(false);
            plant6Flowering.SetActive(false);
            plant7Flowering.SetActive(false);
            plant8Flowering.SetActive(false);

            seedingDying.SetActive(false);
            plant2SeedingDying.SetActive(false);
            plant3SeedingDying.SetActive(false);
            plant4SeedingDying.SetActive(false);
            plant5SeedingDying.SetActive(false);
            plant6SeedingDying.SetActive(false);
            plant7SeedingDying.SetActive(false);
            plant8SeedingDying.SetActive(false);
        }

        public void GrowthStage()
        {
            mudToHide.SetActive(true);
            mudToHide2.SetActive(true);
            mudToHide3.SetActive(true);
            mudToHide4.SetActive(true);
            mudToHide5.SetActive(true);
            mudToHide6.SetActive(true);
            mudToHide8.SetActive(true);
            mudToHide8.SetActive(true);

            germination.SetActive(false);
            plant2Germination.SetActive(false);
            plant3Germination.SetActive(false);
            plant4Germination.SetActive(false);
            plant5Germination.SetActive(false);
            plant6Germination.SetActive(false);
            plant7Germination.SetActive(false);
            plant8Germination.SetActive(false);

            growth.SetActive(true);
            plant2Growth.SetActive(true);
            plant3Growth.SetActive(true);
            plant4Growth.SetActive(true);
            plant5Growth.SetActive(true);
            plant6Growth.SetActive(true);
            plant7Growth.SetActive(true);
            plant8Growth.SetActive(true);

            vegetative.SetActive(false);
            plant2Vegetative.SetActive(false);
            plant3Vegetative.SetActive(false);
            plant4Vegetative.SetActive(false);
            plant5Vegetative.SetActive(false);
            plant6Vegetative.SetActive(false);
            plant7Vegetative.SetActive(false);
            plant8Vegetative.SetActive(false);

            vegetativeHeaded.SetActive(false);
            plant2VegetativeHeaded.SetActive(false);
            plant3VegetativeHeaded.SetActive(false);
            plant4VegetativeHeaded.SetActive(false);
            plant5VegetativeHeaded.SetActive(false);
            plant6VegetativeHeaded.SetActive(false);
            plant7VegetativeHeaded.SetActive(false);
            plant8VegetativeHeaded.SetActive(false);

            flowering.SetActive(false);
            plant2Flowering.SetActive(false);
            plant3Flowering.SetActive(false);
            plant4Flowering.SetActive(false);
            plant5Flowering.SetActive(false);
            plant6Flowering.SetActive(false);
            plant7Flowering.SetActive(false);
            plant8Flowering.SetActive(false);

            seedingDying.SetActive(false);
            plant2SeedingDying.SetActive(false);
            plant3SeedingDying.SetActive(false);
            plant4SeedingDying.SetActive(false);
            plant5SeedingDying.SetActive(false);
            plant6SeedingDying.SetActive(false);
            plant7SeedingDying.SetActive(false);
            plant8SeedingDying.SetActive(false);
        }

        public void VegatativeStage()
        {
            mudToHide.SetActive(true);
            mudToHide2.SetActive(true);
            mudToHide3.SetActive(true);
            mudToHide4.SetActive(true);
            mudToHide5.SetActive(true);
            mudToHide6.SetActive(true);
            mudToHide8.SetActive(true);
            mudToHide8.SetActive(true);

            germination.SetActive(false);
            plant2Germination.SetActive(false);
            plant3Germination.SetActive(false);
            plant4Germination.SetActive(false);
            plant5Germination.SetActive(false);
            plant6Germination.SetActive(false);
            plant7Germination.SetActive(false);
            plant8Germination.SetActive(false);

            growth.SetActive(false);
            plant2Growth.SetActive(false);
            plant3Growth.SetActive(false);
            plant4Growth.SetActive(false);
            plant5Growth.SetActive(false);
            plant6Growth.SetActive(false);
            plant7Growth.SetActive(false);
            plant8Growth.SetActive(false);

            vegetative.SetActive(true);
            plant2Vegetative.SetActive(true);
            plant3Vegetative.SetActive(true);
            plant4Vegetative.SetActive(true);
            plant5Vegetative.SetActive(true);
            plant6Vegetative.SetActive(true);
            plant7Vegetative.SetActive(true);
            plant8Vegetative.SetActive(true);

            vegetativeHeaded.SetActive(false);
            plant2VegetativeHeaded.SetActive(false);
            plant3VegetativeHeaded.SetActive(false);
            plant4VegetativeHeaded.SetActive(false);
            plant5VegetativeHeaded.SetActive(false);
            plant6VegetativeHeaded.SetActive(false);
            plant7VegetativeHeaded.SetActive(false);
            plant8VegetativeHeaded.SetActive(false);

            flowering.SetActive(false);
            plant2Flowering.SetActive(false);
            plant3Flowering.SetActive(false);
            plant4Flowering.SetActive(false);
            plant5Flowering.SetActive(false);
            plant6Flowering.SetActive(false);
            plant7Flowering.SetActive(false);
            plant8Flowering.SetActive(false);

            seedingDying.SetActive(false);
            plant2SeedingDying.SetActive(false);
            plant3SeedingDying.SetActive(false);
            plant4SeedingDying.SetActive(false);
            plant5SeedingDying.SetActive(false);
            plant6SeedingDying.SetActive(false);
            plant7SeedingDying.SetActive(false);
            plant8SeedingDying.SetActive(false);
        }

        public void VegatativeHeadedStage()
        {

            mudToHide.SetActive(true);
            mudToHide2.SetActive(true);
            mudToHide3.SetActive(true);
            mudToHide4.SetActive(true);
            mudToHide5.SetActive(true);
            mudToHide6.SetActive(true);
            mudToHide8.SetActive(true);
            mudToHide8.SetActive(true);

            germination.SetActive(false);
            plant2Germination.SetActive(false);
            plant3Germination.SetActive(false);
            plant4Germination.SetActive(false);
            plant5Germination.SetActive(false);
            plant6Germination.SetActive(false);
            plant7Germination.SetActive(false);
            plant8Germination.SetActive(false);

            growth.SetActive(false);
            plant2Growth.SetActive(false);
            plant3Growth.SetActive(false);
            plant4Growth.SetActive(false);
            plant5Growth.SetActive(false);
            plant6Growth.SetActive(false);
            plant7Growth.SetActive(false);
            plant8Growth.SetActive(false);

            vegetative.SetActive(false);
            plant2Vegetative.SetActive(false);
            plant3Vegetative.SetActive(false);
            plant4Vegetative.SetActive(false);
            plant5Vegetative.SetActive(false);
            plant6Vegetative.SetActive(false);
            plant7Vegetative.SetActive(false);
            plant8Vegetative.SetActive(false);

            vegetativeHeaded.SetActive(true);
            plant2VegetativeHeaded.SetActive(true);
            plant3VegetativeHeaded.SetActive(true);
            plant4VegetativeHeaded.SetActive(true);
            plant5VegetativeHeaded.SetActive(true);
            plant6VegetativeHeaded.SetActive(true);
            plant7VegetativeHeaded.SetActive(true);
            plant8VegetativeHeaded.SetActive(true);
//
            flowering.SetActive(false);
            plant2Flowering.SetActive(false);
            plant3Flowering.SetActive(false);
            plant4Flowering.SetActive(false);
            plant5Flowering.SetActive(false);
            plant6Flowering.SetActive(false);
            plant7Flowering.SetActive(false);
            plant8Flowering.SetActive(false);

            seedingDying.SetActive(false);
            plant2SeedingDying.SetActive(false);
            plant3SeedingDying.SetActive(false);
            plant4SeedingDying.SetActive(false);
            plant5SeedingDying.SetActive(false);
            plant6SeedingDying.SetActive(false);
            plant7SeedingDying.SetActive(false);
            plant8SeedingDying.SetActive(false);
        }

        public void FloweringStage()
        {
            mudToHide.SetActive(true);
            mudToHide2.SetActive(true);
            mudToHide3.SetActive(true);
            mudToHide4.SetActive(true);
            mudToHide5.SetActive(true);
            mudToHide6.SetActive(true);
            mudToHide8.SetActive(true);
            mudToHide8.SetActive(true);

            germination.SetActive(false);
            plant2Germination.SetActive(false);
            plant3Germination.SetActive(false);
            plant4Germination.SetActive(false);
            plant5Germination.SetActive(false);
            plant6Germination.SetActive(false);
            plant7Germination.SetActive(false);
            plant8Germination.SetActive(false);

            growth.SetActive(false);
            plant2Growth.SetActive(false);
            plant3Growth.SetActive(false);
            plant4Growth.SetActive(false);
            plant5Growth.SetActive(false);
            plant6Growth.SetActive(false);
            plant7Growth.SetActive(false);
            plant8Growth.SetActive(false);

            vegetative.SetActive(false);
            plant2Vegetative.SetActive(false);
            plant3Vegetative.SetActive(false);
            plant4Vegetative.SetActive(false);
            plant5Vegetative.SetActive(false);
            plant6Vegetative.SetActive(false);
            plant7Vegetative.SetActive(false);
            plant8Vegetative.SetActive(false);

            vegetativeHeaded.SetActive(false);
            plant2VegetativeHeaded.SetActive(false);
            plant3VegetativeHeaded.SetActive(false);
            plant4VegetativeHeaded.SetActive(false);
            plant5VegetativeHeaded.SetActive(false);
            plant6VegetativeHeaded.SetActive(false);
            plant7VegetativeHeaded.SetActive(false);
            plant8VegetativeHeaded.SetActive(false);

            flowering.SetActive(true);
            plant2Flowering.SetActive(true);
            plant3Flowering.SetActive(true);
            plant4Flowering.SetActive(true);
            plant5Flowering.SetActive(true);
            plant6Flowering.SetActive(true);
            plant7Flowering.SetActive(true);
            plant8Flowering.SetActive(true);

            seedingDying.SetActive(false);
            plant2SeedingDying.SetActive(false);
            plant3SeedingDying.SetActive(false);
            plant4SeedingDying.SetActive(false);
            plant5SeedingDying.SetActive(false);
            plant6SeedingDying.SetActive(false);
            plant7SeedingDying.SetActive(false);
            plant8SeedingDying.SetActive(false);
        }

        public void SeedingDying()
        {
            mudToHide.SetActive(true);
            mudToHide2.SetActive(true);
            mudToHide3.SetActive(true);
            mudToHide4.SetActive(true);
            mudToHide5.SetActive(true);
            mudToHide6.SetActive(true);
            mudToHide8.SetActive(true);
            mudToHide8.SetActive(true);

            germination.SetActive(false);
            plant2Germination.SetActive(false);
            plant3Germination.SetActive(false);
            plant4Germination.SetActive(false);
            plant5Germination.SetActive(false);
            plant6Germination.SetActive(false);
            plant7Germination.SetActive(false);
            plant8Germination.SetActive(false);

            growth.SetActive(false);
            plant2Growth.SetActive(false);
            plant3Growth.SetActive(false);
            plant4Growth.SetActive(false);
            plant5Growth.SetActive(false);
            plant6Growth.SetActive(false);
            plant7Growth.SetActive(false);
            plant8Growth.SetActive(false);

            vegetative.SetActive(false);
            plant2Vegetative.SetActive(false);
            plant3Vegetative.SetActive(false);
            plant4Vegetative.SetActive(false);
            plant5Vegetative.SetActive(false);
            plant6Vegetative.SetActive(false);
            plant7Vegetative.SetActive(false);
            plant8Vegetative.SetActive(false);

            vegetativeHeaded.SetActive(false);
            plant2VegetativeHeaded.SetActive(false);
            plant3VegetativeHeaded.SetActive(false);
            plant4VegetativeHeaded.SetActive(false);
            plant5VegetativeHeaded.SetActive(false);
            plant6VegetativeHeaded.SetActive(false);
            plant7VegetativeHeaded.SetActive(false);
            plant8VegetativeHeaded.SetActive(false);

            flowering.SetActive(false);
            plant2Flowering.SetActive(false);
            plant3Flowering.SetActive(false);
            plant4Flowering.SetActive(false);
            plant5Flowering.SetActive(false);
            plant6Flowering.SetActive(false);
            plant7Flowering.SetActive(false);
            plant8Flowering.SetActive(false);

            seedingDying.SetActive(true);
            plant2SeedingDying.SetActive(true);
            plant3SeedingDying.SetActive(true);
            plant4SeedingDying.SetActive(true);
            plant5SeedingDying.SetActive(true);
            plant6SeedingDying.SetActive(true);
            plant7SeedingDying.SetActive(true);
            plant8SeedingDying.SetActive(true);
        }

/*
        public void ReappearPlantsAfterRemovingDead()
        {
            plant1ToUnHide.SetActive(true);
            plant2ToUnHide.SetActive(true);
            plant3ToUnHide.SetActive(true);
            plant4ToUnHide.SetActive(true);
            plant5ToUnHide.SetActive(true);
            plant6ToUnHide.SetActive(true);
            plant7ToUnHide.SetActive(true);
            plant8ToUnHide.SetActive(true);
        }

        */
    }
}
