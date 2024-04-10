using System.Collections;
using UnityEngine;
using LoLSDK;
using UnityEngine.UI;
using TMPro;
using UnityEngine.AI;

namespace Alpha.Phases.Robo.Grow
{
    public class RoboGrowResetAsses1 : MonoBehaviour
    {
        public RoboGrowPlant1Manager plant1BES;
        public RoboGrowPlant2Manager plant2Lima;
        public RoboGrowPlant3Manager plant3Daisy;
        public RoboGrowPlant4Manager plant4Radish;

        public GameObject triggerArrow;
        public GameObject stage1FlowerArrow1;
        public GameObject stage1FlowerArrow2;
        public GameObject stage1FlowerArrow3;

        public Renderer triggerArrowRenderer;
        public Renderer stage1FlowerArrow1Renderer;
        public Renderer stage1FlowerArrow2Renderer;
        public Renderer stage1FlowerArrow3Renderer;

        public bool resetGuessAlready;
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            if (plant1BES.amountOfGuesses >= 1 && plant2Lima.amountOfGuesses >= 1 && plant3Daisy.amountOfGuesses >= 1 && plant4Radish.amountOfGuesses >=1)
            {
                if (!resetGuessAlready)
                {
                      triggerArrow.gameObject.SetActive(true);
                      stage1FlowerArrow1.gameObject.SetActive(true);
                      stage1FlowerArrow2.gameObject.SetActive(true);
                      stage1FlowerArrow3.gameObject.SetActive(true);

                      triggerArrowRenderer.enabled = true;
                      stage1FlowerArrow1Renderer.enabled = true;
                      stage1FlowerArrow2Renderer.enabled = true;
                      stage1FlowerArrow3Renderer.enabled = true;

                    resetGuessAlready = true;
                    StartCoroutine(ResetGuessBool());
                }


            }
        }

        public IEnumerator ResetGuessBool()
        {
            yield return new WaitForSeconds(2);
            resetGuessAlready = false;
        
        }
    }
}
