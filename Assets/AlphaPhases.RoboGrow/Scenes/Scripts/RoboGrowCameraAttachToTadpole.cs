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
    public class RoboGrowCameraAttachToTadpole : MonoBehaviour
{
        // this is the controller for setting the camera on the player and keeping it there

        public GameObject robot; // declare gameobject for the robot for the camera to follow
        public bool camAlreadyMoved;
        public Transform treePosition; // declare postion for the camera to float too when asked
        public bool camFollowTree; // declare bool to check if the camera is following the tree

        // Start is called before the first frame update
        void Start()
        {
            robot = GameObject.Find("TadpoleRigged"); // find object with tag robot and assign it to robot gameobject
        }

        // Update is called once per frame
        void Update()
        {

           
                transform.position = new Vector3(robot.transform.position.x + 10, robot.transform.position.y + 8, robot.transform.position.z - 1); // camera is smoothly moved to the player
           


           

        }

    }
}
