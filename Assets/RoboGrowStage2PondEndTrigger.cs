using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LoLSDK;
using SimpleJSON;
using TMPro;
using UnityEngine.UI;

namespace Alpha.Phases.Robo.Grow
{
    public class RoboGrowStage2PondEndTrigger : MonoBehaviour
    {

        public RoboGrowStartMiniGame2 rgMG2TextScript;
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
            if (other.CompareTag("TadPole"))
            {
                rgMG2TextScript.currentStage2PondText = 7;
            }
        }
    }
}
