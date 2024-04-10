using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using LoLSDK;
namespace Alpha.Phases.Robo.Grow
{
    public class RoboGrowMainCamManager : MonoBehaviour
    {
        public Animator doorOpenAnim;
        public GameObject playerCamToEnable;
        public Camera mmCamToDisable;
        public RobotController robControl;
        public AudioSource musicToQuieten;

        private void Awake()
        {
            doorOpenAnim.keepAnimatorControllerStateOnDisable = false;
        }

        public void MoveCamToOpenDoor()
        {
            doorOpenAnim.SetBool("doorNeedsToBeOpen", true);
            musicToQuieten.volume = 0.026f;

            
        }

        private void Update()
        {
           
        }

        public void DisableCam()
        {
            playerCamToEnable.gameObject.SetActive(true);
            mmCamToDisable.enabled = false;
            robControl.enabled = true;
           
        }
    }
}
