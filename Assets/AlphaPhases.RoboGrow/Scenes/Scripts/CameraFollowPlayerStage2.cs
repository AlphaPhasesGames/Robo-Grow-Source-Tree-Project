using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Alpha.Phases.Robo.Grow
{
    public class CameraFollowPlayerStage2 : MonoBehaviour
    {
        public GameObject robot; // declare gameobject for the robot for the camera to follow
        public bool camAlreadyMoved;
        public Transform treePosition; // declare postion for the camera to float too when asked
        public bool camFollowPond; // declare bool to check if the camera is following the tree

        // Start is called before the first frame update
        void Start()
        {
            robot = GameObject.Find("Robot"); // find object with tag robot and assign it to robot gameobject
            camFollowPond = false; // camera does not follow the tree on start
        }

        // Update is called once per frame
        void Update()
        {
            if (camFollowPond) // if camFollowTree bool is true
            {

                transform.position = Vector3.Lerp(transform.position, treePosition.position, Time.deltaTime); // move camera smoothly to the tree position
                Debug.Log("Tree cam initiated");
            }
            else
            {
                transform.position = new Vector3(robot.transform.position.x + 10, robot.transform.position.y + 8, robot.transform.position.z - 1); // camera is smoothly moved to the player
            }


            if (Input.GetKeyDown(KeyCode.K)) // if k key is press, exectute this function -- this is for testing purposes only and can be removed
            {
                camFollowPond = !camFollowPond;

            }


        }
    }
}
