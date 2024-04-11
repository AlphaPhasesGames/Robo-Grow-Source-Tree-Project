using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LoLSDK;
using SimpleJSON;
using TMPro;
using UnityEngine.UI;

namespace Alpha.Phases.Robo.Grow
{
    public class RoboGrowFrogReactivator : MonoBehaviour
    {
        public RoboGrowFrogController frogCont;

        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("FrogPlayer"))
            {

                frogCont.enabled = true;
                Debug.Log("The Fall trigge works");


            }
        }
    }
}
