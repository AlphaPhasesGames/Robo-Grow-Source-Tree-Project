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
    public class RoboGrowStage4BFEndOfStage : MonoBehaviour
    {
        public RoboGrowStage4ButterflyMG rgBFMG;

        public GameObject butteflyImage;
        public GameObject susanArrowToReset;
        public GameObject susan2ArrowToReset;
        public GameObject limaArrowToReset;
        public GameObject lima2ArrowToReset;
        public GameObject daisyArrowToReset;
        public GameObject daisy2ArrowToReset;
        public GameObject radishArrowToReset;
        public GameObject radish2ArrowToReset;
      


        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                rgBFMG.currentStage4BFText = 10;
                butteflyImage.gameObject.SetActive(false);
                susanArrowToReset.gameObject.SetActive(true);
                susan2ArrowToReset.gameObject.SetActive(true);
                limaArrowToReset.gameObject.SetActive(true);
                lima2ArrowToReset.gameObject.SetActive(true);
                daisyArrowToReset.gameObject.SetActive(true);
                daisy2ArrowToReset.gameObject.SetActive(true);
                radish2ArrowToReset.gameObject.SetActive(true);
                radishArrowToReset.gameObject.SetActive(true);
                Debug.Log("Trigger for target BF triggered");
            }
        }
    }
}
