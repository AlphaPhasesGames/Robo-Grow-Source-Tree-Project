using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using LoLSDK;
using SimpleJSON;
using System.IO;
using UnityEngine.UI;

namespace Alpha.Phases.Robo.Grow
{
    public class RoboGrowCanvasManager : MonoBehaviour
    {
        public GameObject logoTohide;
        public GardenData gardenData;
        // Start is called before the first frame update
        void Start()
        {
            logoTohide.gameObject.SetActive(true);
        }

        // Update is called once per frame
        void Update()
        {
            if(gardenData.current_stage > 0)
            {
               logoTohide.gameObject.SetActive(false);
            }

           
        }
    }
}
