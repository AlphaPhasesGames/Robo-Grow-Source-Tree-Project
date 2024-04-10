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
    public class RoboGrowZoomInOnFlower : MonoBehaviour
    {
        public Button returnToPlayeCam;
        public Button collectSeeds;
        public Button removeDeadPlants;
        public GameObject plantToHide;


        public RoboGrowMain rgMain;

        public Camera flowerCam;
        public Camera playerCam;
        // Start is called before the first frame update
        void Start()
        {
            returnToPlayeCam.gameObject.SetActive(false);
            collectSeeds.gameObject.SetActive(false);
            removeDeadPlants.gameObject.SetActive(false);


            returnToPlayeCam.onClick.AddListener(ReturnToPlayerCam);
            collectSeeds.onClick.AddListener(CollectSeeds);
            removeDeadPlants.onClick.AddListener(RemoveDeadPlants);
            flowerCam.enabled = false;
        }

        // Update is called once per frame
        void Update()
        {

        }


        void OnMouseDown()
        {
            playerCam.enabled = false;
            flowerCam.enabled = true;
            returnToPlayeCam.gameObject.SetActive(true);
            collectSeeds.gameObject.SetActive(true);
            removeDeadPlants.gameObject.SetActive(true);
            Debug.Log("Mouse Clicked");
        }

        public void ReturnToPlayerCam()
        {
            returnToPlayeCam.gameObject.SetActive(false);
            playerCam.enabled = true;
            flowerCam.enabled = false;
        }

        public void RemoveDeadPlants()
        {
            plantToHide.SetActive(false);
            removeDeadPlants.gameObject.SetActive(false);
            playerCam.enabled = true;
            flowerCam.enabled = false;
        }

        public void CollectSeeds()
        {
            rgMain.SaveSeeds();
            collectSeeds.gameObject.SetActive(false);
        }
    }
}


