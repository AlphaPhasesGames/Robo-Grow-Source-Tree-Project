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
    public class RoboGrowStartPlantingSusans : MonoBehaviour
    {
        public Button buttonForSusans;
        public Button buttonForLimaBeans;
        public Button buttonForDaisies;
        public Button buttonForRadish;
        public RoboGrowPlantSeeds rgPlantSeeds;
        public PlantArrayManager plantManager;
        public RobotController robControl;
        public RoboGrowMain rgMain;
    // Start is called before the first frame update
             void Start()
        {
            buttonForSusans.onClick.AddListener(StartPlantingSusans);
            buttonForLimaBeans.onClick.AddListener(StartPlantingLimaBean);
            buttonForDaisies.onClick.AddListener(StartPlantingDaisies);
            buttonForRadish.onClick.AddListener(StartPlantingRadish);
        }

        // Update is called once per frame
        void Update()
        {

        }

         void StartPlantingSusans()
        {
            if(rgMain.currentGameStage == 1)
            {
                robControl.NewNavmeshStop();
            }
            if (rgMain.currentGameStage == 2)
            {
                plantManager.arrayPos = 0;
                rgPlantSeeds.isBuilding = true;
            }
        }

        void StartPlantingLimaBean()
        {
            if (rgMain.currentGameStage == 1)
            {
                robControl.NewNavmeshStop();
            }
            if (rgMain.currentGameStage == 2)
            {
                rgPlantSeeds.isBuilding = true;
                plantManager.arrayPos = 1;
            }
           
        }

        void StartPlantingDaisies()
        {
            if (rgMain.currentGameStage == 1)
            {
                robControl.NewNavmeshStop();
            }
            if (rgMain.currentGameStage == 2)
            {
                rgPlantSeeds.isBuilding = true;
                plantManager.arrayPos = 2;
            }     
           
        }

        void StartPlantingRadish()
        {
            if (rgMain.currentGameStage == 1)
            {
                robControl.NewNavmeshStop();
            }
            if (rgMain.currentGameStage == 2)
            {
                rgPlantSeeds.isBuilding = true;
                plantManager.arrayPos = 3;
            }
            
        }
       

    }
}