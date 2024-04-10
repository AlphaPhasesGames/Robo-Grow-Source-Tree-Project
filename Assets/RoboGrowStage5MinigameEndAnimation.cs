using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using LoLSDK;
namespace Alpha.Phases.Robo.Grow
{
    public class RoboGrowStage5MinigameEndAnimation : MonoBehaviour
    {
        public Animator wingAnim;
        public GameObject egg1;
        public GameObject egg2;
        public GameObject egg3;

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }

       

        public IEnumerator SpawnEggs()
        {
            yield return new WaitForSeconds(1);
            egg1.gameObject.SetActive(true);
            yield return new WaitForSeconds(1);
            egg2.gameObject.SetActive(true);
            yield return new WaitForSeconds(1);
            egg3.gameObject.SetActive(true);
            yield return new WaitForSeconds(1);
            wingAnim.SetTrigger("endLifeOfButterfly");
        }
    }
}
