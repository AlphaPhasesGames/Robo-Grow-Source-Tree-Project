using LoLSDK;
using SimpleJSON;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;

namespace Alpha.Phases.Robo.Grow
{
    public class RoboGrowDaisy2Save : MonoBehaviour
    {
        public RoboGrowMain rgMain;
        //GardenData gardenData;
        public bool playOnce;
        private void Awake()
        {



        }

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.U))
            {
                rgMain.daisy2Location = this.gameObject.transform.position;
               // rgMain.SaveDaisy2Plant();
            }
        }
    }
}
