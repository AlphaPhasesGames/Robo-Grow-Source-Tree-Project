using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LoLSDK;
using SimpleJSON;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Alpha.Phases.Robo.Grow
{
    public class RoboGrowStage2MGRespawner : MonoBehaviour
    {
        public TadpoleController tadCont;

        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("TadPole"))
            {
             
                tadCont.enabled = true;
                Debug.Log("The Fall trigge works");
              

            }
        }

        
    }
}
