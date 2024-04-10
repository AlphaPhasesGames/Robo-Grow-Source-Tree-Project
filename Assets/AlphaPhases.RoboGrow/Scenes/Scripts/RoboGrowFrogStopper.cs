using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using LoLSDK;
namespace Alpha.Phases.Robo.Grow
{
    public class RoboGrowFrogStopper : MonoBehaviour
    {
        public RoboGrowFrogJump rgFrog;
        public bool isFrogIsCollider;
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            if (isFrogIsCollider)
            {
                rgFrog.jumpAnim.StopPlayback();
            }
        }


        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("FrogStopper"))
            {
                isFrogIsCollider = true;
            }
        }

        private void OnTriggerExit(Collider other)
        {
            if (other.CompareTag("FrogStopper"))
            {
                isFrogIsCollider = false;
            }
        }
    }
}
