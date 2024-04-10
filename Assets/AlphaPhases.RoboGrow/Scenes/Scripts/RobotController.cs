using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.EventSystems;


namespace Alpha.Phases.Robo.Grow
{
    public class RobotController : MonoBehaviour
    {
        [Header("Array for objects")]
        //public ObjectArray obj_Array;

        [Space]
        [Header("Controller Scripts")]
        public static RobotController instance;
        public CharacterController charControl;
        public bool canPlayerMove;
        [Space]
        [Header("Navmesh and cameras")]
        [SerializeField] // so we can access it in the inspector but keep it private
        private NavMeshAgent agent; // declare NavMeshAgent for player called agent
        public Camera mainCam; // declare camera to store our camera from the inspector
        public Vector3 currentPostition; // a vector 3 to hold the players current position - for the navemesh
                                         // public Vector3 transBrickposition;
        public Ray cameraRay; // public ray to detect when the player is over ground/brick etc
        RaycastHit cameraRayHit; // raycasthit to detect when the ray has hit something
        RaycastHit hit; // = Physics.Raycast (Camera.main.ScreenPointToRay(Input.mousePosition));
        public Vector3 velocity; // instantiate a vector3 called velocity, to move the player down, to simulate gravity
                                 // Start is called before the first frame update

        [Header("Textures")]
        public Texture2D cursorHammerTexture;
        public CursorMode cursorMode = CursorMode.Auto;
        public Vector2 hotSpot = Vector2.zero;

        [Space]
        [Header("List of Plants")]
        public List<GameObject> bricks = new List<GameObject>(); //  list to store bricks create in called bricks


        void Start()
        {
            agent = GetComponent<NavMeshAgent>(); // get NavMeshAgent component and apply it to agent .. this is redundant, we have set it in the inspector 
            canPlayerMove = true;
        }

        // Update is called once per frame
        void Update()
        {
           

            if(Input.GetKeyDown(KeyCode.Alpha6))
            {
                StartPlayerMoving();
            }
            if (Input.GetMouseButtonDown(0)) // on mouse click
            {
               
                    if (EventSystem.current.IsPointerOverGameObject() &&
                                   EventSystem.current.currentSelectedGameObject != null &&
                                   !EventSystem.current.currentSelectedGameObject.CompareTag("UI"))
                    {
                        Debug.Log("clickedTheUI");
                        return;
                    }

                    else
                    {
                        Ray position = mainCam.ScreenPointToRay(Input.mousePosition); // new RAY decalred as position and is set to the mouse position called once per frame
                        RaycastHit hitInfo; // get a raycast variable to detect what we hit
                        if (Physics.Raycast(position, out hit, 100f)) // if the raycast from position hits in distance of 100f
                        {
                            Debug.Log(hit.point); // log the position it hits
                            agent.destination = hit.point; // move agent (player) to the hit position.
                        }

                        if (Physics.Raycast(position, out hitInfo, 100f)) // if the raycast from position hits in distance of 100f
                        {
                            Debug.Log("We Hit: " + hitInfo.collider); // log the position it hits
                        }

                        Debug.Log(hit.collider); // log the collider it hits
                    }
               
            }
        }

        public void StopPlayerMoving() 
        {

            this.gameObject.GetComponent<NavMeshAgent>().enabled = false;

        }

        public void StartPlayerMoving()
        {

            this.gameObject.GetComponent<NavMeshAgent>().enabled = true;

        }

        public void NewNavmeshStop()
        {
            agent.ResetPath();
        }


    }
}
