using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using LoLSDK;
namespace Alpha.Phases.Robo.Grow
{
    public class Stage4PlantWaterer : MonoBehaviour
    {
        public RoboGrowMain rgMain;
        public Stage4PlantWaterer stageWater;
        public bool plantWatered;
        public bool plantsRemoved;

        public Renderer plantArrowToChangeMaterial;
        public Material water;
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

            if (rgMain.currentGameStage == 4)
            {
                if (!plantWatered)
                {
                 //   rgMain.amountOfStage4FlowersWatered = rgMain.amountOfStage4FlowersWatered + 1;
                 //   stageWater.enabled = false;
                 //   plantWatered = true;
                 //   plantArrowToChangeMaterial.material = water;
                }
                
            }


            if (rgMain.currentGameStage == 5)
            {
                if (!plantsRemoved)
                {
                  //  rgMain.amountOfRemovedFlowersStage5 = rgMain.amountOfRemovedFlowersStage5 + 1;
                  //  plantsRemoved = true;

                }
                   

            }


        }



    }
}    
