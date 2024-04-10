using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using LoLSDK;
namespace Alpha.Phases.Robo.Grow
{
    public class RoboGrowOrganicTreeBox : MonoBehaviour
    {
        public RoboGrowTextBoxManager rgTextMan;
        public RobotController robCont;
        public RoboGrowMain rgMain;
        public RoboGrowOrganicItemManager rgOrganItemMan;
        //public Button returnToPlayerCam;
       // public Camera organicItemCam;
        public Camera playerCam;

        // Start is called before the first frame update
        void Start()
        {
        //    organicItemCam.enabled = false;
        }

        // Update is called once per frame
        void Update()
        {

        }

        void OnMouseDown()
        {
            robCont.enabled = false;
            //   returnToPlayerCam.onClick.AddListener(ReturnToPlayerCam);
             playerCam.enabled = false;
            rgMain.MoveCameraToOrganicTreePosition();
          //  organicItemCam.enabled = true;
            //  returnToPlayerCam.gameObject.SetActive(true);
            Debug.Log("Mouse Clicked");
            rgOrganItemMan.boxesDestroyed = true;
            rgTextMan.currentStageOfText = 24;
        }

        public void ReturnToPlayerCam()
        {
            robCont.enabled = true;
            //  returnToPlayerCam.gameObject.SetActive(false);
            playerCam.enabled = true;
            rgMain.HideCamera();
            Debug.Log("return pressed Clicked");
        }
    }
}
