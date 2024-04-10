using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using LoLSDK;
namespace Alpha.Phases.Robo.Grow
{
    // This is the text manager for stage 1 of RoboGrow

    public class RoboGrowOrganicItemManager : MonoBehaviour
    {
        public BoxCollider organicBox1;
      //public BoxCollider organicBox2;
        public BoxCollider organicBox3;
        public BoxCollider organicBox4;

        public bool boxesDestroyed;
        public bool boxesClicked;



        // Update is called once per frame
        void Update()
        {
            if (boxesDestroyed)
            {
                DestroyBoxes();
            }
        }

        public void DestroyBoxes()
        {
           // organicBox1.enabled = false;
        //    organicBox2.enabled = false;
           // organicBox3.enabled = false;
           // organicBox4.enabled = false;

        }

    }
}
