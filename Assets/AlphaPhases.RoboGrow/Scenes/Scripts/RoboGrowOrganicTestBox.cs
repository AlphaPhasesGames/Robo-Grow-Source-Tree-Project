using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using LoLSDK;
namespace Alpha.Phases.Robo.Grow
{
    public class RoboGrowOrganicTestBox : MonoBehaviour
    {
        public RoboGrowTextBoxManager rgTextMan;
        public RobotController robCont;
        public RoboGrowMain rgMain;
        public RoboGrowOrganicItemManager rgOrganItemMan;
        //public Button returnToPlayerCam;
       // public Camera organicItemCam;
        public Camera playerCam;
    
        void OnMouseDown()
        {
            robCont.enabled = false;
         //   returnToPlayerCam.onClick.AddListener(ReturnToPlayerCam);
            playerCam.enabled = false;
            rgMain.MoveCameraToOrganic1SusanPosition();
          //  organicItemCam.enabled = true;
          //  returnToPlayerCam.gameObject.SetActive(true);
            Debug.Log("Mouse Clicked");
            rgOrganItemMan.boxesDestroyed = true;
            rgTextMan.currentStageOfText = 18;
        }

        public void ReturnToPlayerCam()
        {
            robCont.enabled = true;
            rgMain.HideCamera();
          //  returnToPlayerCam.gameObject.SetActive(false);
            playerCam.enabled = true;
          //  organicItemCam.enabled = false;
            Debug.Log("return pressed Clicked");
        }
    }
}
