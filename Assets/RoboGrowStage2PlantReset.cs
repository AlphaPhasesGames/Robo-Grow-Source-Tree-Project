using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AI;
using LoLSDK;
namespace Alpha.Phases.Robo.Grow
{
    public class RoboGrowStage2PlantReset : MonoBehaviour
    {

      //  public RoboGrowMain rgMain;
        public int amountOfFails;

        public int amountOfFailsStage3;
        public int amountOfFailsStage4;

        public bool hasPlayerRestPlantsStage2;
        public bool hasPlayerRestPlantsStage3;
        public bool hasPlayerRestPlantsStage4;

        public RoboGrowWaterPlantsStage2Asses stage2WaterplantsAsses; // susan 1
        public RoboGrowWaterplantsstageasses1 stage2WaterplantsAsses1; // susan 2
        public RoboGrowWaterPlantsStagesAsses2 stage2WaterplantsAsses2; // lima 1
        public RoboGrowWaterPlantsStagesAsses3 stage2WaterplantsAsses3; // lima2
        public RoboGrowWaterPlantsStagesAsses4 stage2WaterplantsAsses4; // daisy 2
        public RoboGrowWaterplantsstageasses5 stage2WaterplantsAsses5; // radish 1
        public RoboGrowWaterplantsstageasses6 stage2WaterplantsAsses6; // daisy  2
        public RoboGrowWaterplantsstageasses7 stage2WaterplantsAsses7; // radish  2

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
           
            if(amountOfFails > 7)
            {
                if (!hasPlayerRestPlantsStage2) 
                { 
                stage2WaterplantsAsses.susanArrowToDisable.gameObject.SetActive(true);
                stage2WaterplantsAsses1.susan2ArrowToDisable.gameObject.SetActive(true);
                stage2WaterplantsAsses2.limaArrowToDisable.gameObject.SetActive(true);
                stage2WaterplantsAsses3.lima2ArrowToDisable.gameObject.SetActive(true);
                stage2WaterplantsAsses4.daisy2ArrowToDisable.gameObject.SetActive(true);
                stage2WaterplantsAsses5.radishArrowToDisable.gameObject.SetActive(true);
                stage2WaterplantsAsses6.daisyArrowToDisable.gameObject.SetActive(true);
                stage2WaterplantsAsses7.radish2ArrowToDisable.gameObject.SetActive(true);
               // hasPlayerRestPlantsStage2 = true;
                }
            }

            if (amountOfFailsStage3 > 7)
            {
                if (!hasPlayerRestPlantsStage3)
                {
                    stage2WaterplantsAsses.susanArrowToDisable.gameObject.SetActive(true);
                    stage2WaterplantsAsses1.susan2ArrowToDisable.gameObject.SetActive(true);
                    stage2WaterplantsAsses2.limaArrowToDisable.gameObject.SetActive(true);
                    stage2WaterplantsAsses3.lima2ArrowToDisable.gameObject.SetActive(true);
                    stage2WaterplantsAsses4.daisy2ArrowToDisable.gameObject.SetActive(true);
                    stage2WaterplantsAsses5.radishArrowToDisable.gameObject.SetActive(true);
                    stage2WaterplantsAsses6.daisyArrowToDisable.gameObject.SetActive(true);
                    stage2WaterplantsAsses7.radish2ArrowToDisable.gameObject.SetActive(true);
                //    hasPlayerRestPlantsStage3 = true;
                }
            }

            if (amountOfFailsStage4 > 7)
            {
                if (!hasPlayerRestPlantsStage4)
                {
                    stage2WaterplantsAsses.susanArrowToDisable.gameObject.SetActive(true);
                    stage2WaterplantsAsses1.susan2ArrowToDisable.gameObject.SetActive(true);
                    stage2WaterplantsAsses2.limaArrowToDisable.gameObject.SetActive(true);
                    stage2WaterplantsAsses3.lima2ArrowToDisable.gameObject.SetActive(true);
                    stage2WaterplantsAsses4.daisy2ArrowToDisable.gameObject.SetActive(true);
                    stage2WaterplantsAsses5.radishArrowToDisable.gameObject.SetActive(true);
                    stage2WaterplantsAsses6.daisyArrowToDisable.gameObject.SetActive(true);
                    stage2WaterplantsAsses7.radish2ArrowToDisable.gameObject.SetActive(true);
                //    hasPlayerRestPlantsStage4 = true;
                }
            }
        }
    }
}
