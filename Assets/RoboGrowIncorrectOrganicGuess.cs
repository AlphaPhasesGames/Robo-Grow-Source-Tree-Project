using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using LoLSDK;
namespace Alpha.Phases.Robo.Grow
{
    public class RoboGrowIncorrectOrganicGuess : MonoBehaviour
    {
        public RoboGrowTextBoxManager rgTextMan;
        public RobotController robCont;
        public RoboGrowOrganicItemManager rgOrganItemMan;
        //public Button returnToPlayerCam;
        //public Camera organicItemCam;
        public Camera playerCam;
        public RoboGrowMain rgMain;


        void OnMouseDown()
        {
            robCont.enabled = false;
            //   returnToPlayerCam.onClick.AddListener(ReturnToPlayerCam);
            // playerCam.enabled = false;
            //  organicItemCam.enabled = true;
            //  returnToPlayerCam.gameObject.SetActive(true);
            rgMain.MoveCameraToOrganicRock1Position();
            Debug.Log("Mouse Clicked");
            rgOrganItemMan.boxesDestroyed = true;
            rgTextMan.currentStageOfText = 21;
        }

        public void ReturnToPlayerCam()
        {
            robCont.enabled = true;
            //  returnToPlayerCam.gameObject.SetActive(false);
            playerCam.enabled = true;
            rgMain.HideCamera();
         //   organicItemCam.enabled = false;
            Debug.Log("return pressed Clicked");
        }
    }
}
