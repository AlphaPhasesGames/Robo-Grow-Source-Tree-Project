using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using LoLSDK;
namespace Alpha.Phases.Robo.Grow
{
    public class RoboGrowStage2MiniGameEnd : MonoBehaviour
    {
        public RoboGrowStartMiniGame2 rgstartMiniGame;
        public TadpoleController tadControl;
        public Camera mainCamToEnable;
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }

        private void OnTriggerEnter(Collider other)
        {
            if(other.CompareTag ("TadPole"))
            {
                if(tadControl.playersAlgeaCollected < 20)
                {
                    rgstartMiniGame.currentStage2PondText = 11;
                }

                if(tadControl.playersAlgeaCollected >= 20)
                {
                    rgstartMiniGame.currentStage2PondText = 8;
                }
               
            }
        }
    }
}
