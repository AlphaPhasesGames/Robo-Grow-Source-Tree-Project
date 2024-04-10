using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerController : MonoBehaviour
{/*
    [Header("Array for objects")]
    public ObjectArray obj_Array;

    [Space]
    [Header("Navmesh and cameras")]
    [SerializeField] // so we can access it in the inspector but keep it private
    public Camera mainCam; // declare camera to store our camera from the inspector
    public Camera overCamToEnable;
    public Ray cameraRay; // public ray to detect when the player is over ground/brick etc
    RaycastHit cameraRayHit; // raycasthit to detect when the ray has hit something
    RaycastHit hit; // = Physics.Raycast (Camera.main.ScreenPointToRay(Input.mousePosition));
    public Vector3 velocity; // instantiate a vector3 called velocity, to move the player down, to simulate gravity
                             // [Header("UI Canvas")]
                             // public GameObject helpCanvasToHide;

    [Space]
    [Header("Bools")]
    public bool isBuilding; // declare bool to detect when were building or not
    public bool isTransBrickShowing; // declare bool to detect when the transulcent brick is showing us where our bricks will be placed
    public bool brickForwardDirection; // declare bool to detect when  the brick is in the default position
    public bool transBrickForwardDirection; // declare bool to detect when the translucent brick is showing in the default rotation
    public bool playerBuildingLayer2; // Decalre bool to detect if were building above ground layer
    public bool halfBrickForwardDirection;
    public bool transHalfBrickForwardDirection;
    public bool buildingOtherBricks;
    public bool playerFirstPerson; // bool to detect wether the player is in First Person 
    public bool deleteBrickActive; // declare bool to detect when the destroy bricks mode is active
    public bool pickUpCollectableActive;
    public bool isHelpShowing;

    [Space]
    [Header("List of Bricks")]
    public List<GameObject> bricks = new List<GameObject>(); //  list to store bricks create in called bricks
    [Header("Game Objects - bricks and building stuff")]
    public GameObject brickToBuild; // gameobject to hold brick object
    public GameObject brickToBuildRotated; // gameobject to hold the brick when rotated object
    public GameObject brickHalfToBuild;
    public GameObject cementToBuild;

    public GameObject transBrick; // gameobject to hold the transparent brick icon 
    public GameObject transBrickRotated; // game object to hold the transparent brick icon when rotated
    public GameObject transHalfBrick; // gameobject to hold the transparent brick icon 
    public GameObject transCementBrick;


    private void Awake() // on awake of script
    {
        isBuilding = false; // player is not building on awake and can move
        brickForwardDirection = false; // Brick is in default position
        transBrickForwardDirection = false;   //Trasparent brick is in default position
        isTransBrickShowing = false; // trasparent brick is hideen 
        transBrick.SetActive(false); //set transparent brick to inactive
        transHalfBrick.SetActive(false);
        transBrickRotated.SetActive(false); // set trasparent brick rotated to inactive
                                            // transCementBrick.SetActive(false);
        playerBuildingLayer2 = false; // player is using ground bricks by default
        halfBrickForwardDirection = false;
        transHalfBrickForwardDirection = false;
        deleteBrickActive = false; // brick deleter is inactive
        isHelpShowing = true;
        buildingOtherBricks = false;
        pickUpCollectableActive = false;

        //testBrick.SetActive(true);
    }

    // Start is called before the first frame update
    void Start()
    {
        // agent = GetComponent<NavMeshAgent>(); // get NavMeshAgent component and apply it to agent .. this is redundant, we have set it in the inspector 
        //bricksThePlayerHasToBuildWith = builder.amountOfBricksCollected;
    }
    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.L))
        {

            halfBrickForwardDirection = !halfBrickForwardDirection;
            transHalfBrickForwardDirection = !transHalfBrickForwardDirection;
            buildingOtherBricks = !buildingOtherBricks;
            pickUpCollectableActive = !pickUpCollectableActive;
        }

        if (Input.GetKeyDown(KeyCode.Q)) // if RMB is pressed
        {
            isBuilding = !isBuilding; // building mode actived - and deactivated if clicked again 
        }

        if (Input.GetKeyDown(KeyCode.E)) // if E is pressed
        {
            brickForwardDirection = !brickForwardDirection; // change brick direction to and from the default and rotated brick
            transBrickForwardDirection = !transBrickForwardDirection;  // change transparent brick direction to and from the default and rotated brick
        }
        // 




        if (isBuilding)
        {
            overCamToEnable.enabled = true;
            //deleteBrickActive = false;
            cameraRay = Camera.main.ScreenPointToRay(Input.mousePosition); // cameraRay decalred as position and shoots our from the middle of the screen to the mouse position and is called once per frame
            if (Physics.Raycast(cameraRay, out cameraRayHit)) // if raycast hits something
            {
                //if (cameraRayHit.transform.CompareTag("Ground")) // if raycast hits the ground
               // {
                    if (obj_Array.arrayPos == 0) // if transpare brick in the default position 
                    {
                        transBrick.transform.position = cameraRayHit.point; // transparent brick position is where the raycast hits the ground -- this is important as if not set to the ground, the traparent brick can float anywhere between the two raycast position ( raycast location and the hit point)
                        transBrick.SetActive(true); // set traparent brick to active
                        transBrickRotated.SetActive(false); // disable the rotated traparent brick
                        transHalfBrick.SetActive(false); // set traparent brick to inactive
                        transCementBrick.SetActive(false); // set traparent brick to inactive transCementBrick.SetActive(true); // set traparent brick to inactive                           // brickHalfToBuild.SetActive(false); // set traparent brick to inactive
                    }

                    if (obj_Array.arrayPos == 1)  // if transpare brick in the rotated position 
                    {
                        transBrickRotated.transform.position = cameraRayHit.point; // Rotated transparent brick position is where the raycast hits the ground -- this is important as if not set to the ground, the traparent brick can float anywhere between the two raycast position ( raycast location and the hit point)
                        transBrickRotated.SetActive(true); // set traparent brick to inactive
                        transBrick.SetActive(false); // enable the rotated traparent brick
                        transHalfBrick.SetActive(false); // set traparent brick to inactive
                        transCementBrick.SetActive(false); // set traparent brick to inactive                                //  brickHalfToBuild.SetActive(false); // set traparent brick to inactive
                    }

                    if (obj_Array.arrayPos == 2)  // if transpare brick in the rotated position 
                    {
                        transHalfBrick.transform.position = cameraRayHit.point; // Rotated transparent brick position is where the raycast hits the ground -- this is important as if not set to the ground, the traparent brick can float anywhere between the two raycast position ( raycast location and the hit point)
                        transHalfBrick.SetActive(true); // set traparent brick to inactive
                        transBrickRotated.SetActive(false); // disable the rotated traparent brick
                        transBrick.SetActive(false); // enable the rotated traparent brick
                        transCementBrick.SetActive(false); // set traparent brick to inactive
                    }

                    if (obj_Array.arrayPos == 3)  // if transpare brick in the rotated position 
                    {
                        transCementBrick.transform.position = cameraRayHit.point; // Rotated transparent brick position is where the raycast hits the ground -- this is important as if not set to the ground, the traparent brick can float anywhere between the two raycast position ( raycast location and the hit point)
                        transCementBrick.SetActive(true); // set traparent brick to inactive
                        transHalfBrick.SetActive(false);
                        transBrickRotated.SetActive(false); // disable the rotated traparent brick
                        transBrick.SetActive(false); // enable the rotated traparent brick

                    }

               // }


            }


            if (obj_Array.arrayPos == 0) // if Brick is in the default postion 
            {
                // deleteBrickActive = false;
                if (Input.GetMouseButtonDown(0)) // on mouse click
                {

                    Ray position = mainCam.ScreenPointToRay(Input.mousePosition); // new RAY decalred as position and is set to the mouse position called once per frame
                    if (Physics.Raycast(position, out hit, 100f)) // if the raycast from position hits in distance of 100f
                    {
                        if (hit.transform.CompareTag("Ground")) // if raycast hits ground
                        {
                            Debug.Log(hit.point); // log the position it hits
                            Debug.Log(hit.transform.tag); // log the tag it hits
                            Instantiate(brickToBuild, hit.point, Quaternion.identity); // create brick at hitpoint(Ground) in its original rotation;
                            bricks.Add(brickToBuild); //  add brick to list of bricks
                                                      //builder.Remove1ToBrickAmount();
                        }


                    }
                    Debug.Log(hit.collider); // log the collider it hits
                }
            }
            if (obj_Array.arrayPos == 1) // if brick is in rotated position
            {
                // deleteBrickActive = false;
                if (Input.GetMouseButtonDown(0)) // on mouse click
                {
                    Ray position = mainCam.ScreenPointToRay(Input.mousePosition); // new RAY decalred as position and is set to the mouse position called once per frame
                    if (Physics.Raycast(position, out hit, 100f)) // if the raycast from position hits in distance of 100f
                    {
                        if (hit.transform.CompareTag("Ground")) // if raycst detects tag Ground
                        {
                            Debug.Log(hit.point); // log the position it hits
                            Debug.Log(hit.transform.tag); // log the Tag it hits                           
                            Instantiate(brickToBuildRotated, hit.point, Quaternion.identity); // create rotated brick at hitpoint ( The ground ) in its original rotation;
                            bricks.Add(brickToBuildRotated); // add this rotated brick to the list of bricks
                                                             //builder.Remove1ToBrickAmount();
                        }


                    }
                    Debug.Log(hit.collider); // log the collider it hits
                }
            }
            if (obj_Array.arrayPos == 2) // if Brick is in the default postion 
            {
                // brickForwardDirection = false;
                Debug.Log("This executes");
                // deleteBrickActive = false;
                if (Input.GetMouseButtonDown(0)) // on mouse click
                {
                    Debug.Log("This code exectues as wekk");
                    Ray position = mainCam.ScreenPointToRay(Input.mousePosition); // new RAY decalred as position and is set to the mouse position called once per frame
                    if (Physics.Raycast(position, out hit, 100f)) // if the raycast from position hits in distance of 100f
                    {
                        if (hit.transform.CompareTag("Ground")) // if raycast hits ground
                        {
                            Debug.Log(hit.point); // log the position it hits
                            Debug.Log(hit.transform.tag); // log the tag it hits
                            Instantiate(brickHalfToBuild, hit.point, Quaternion.identity); // create brick at hitpoint(Ground) in its original rotation;
                            bricks.Add(brickHalfToBuild); //  add brick to list of bricks
                                                          //builder.Remove1ToBrickAmount();

                        }

                    }
                    Debug.Log(hit.collider); // log the collider it hits
                }

            }
            if (obj_Array.arrayPos == 3) // if Brick is in the default postion 
            {
                // brickForwardDirection = false;
                Debug.Log("This executes");
                // deleteBrickActive = false;
                if (Input.GetMouseButtonDown(0)) // on mouse click
                {
                    Debug.Log("This code exectues as wekk");
                    Ray position = mainCam.ScreenPointToRay(Input.mousePosition); // new RAY decalred as position and is set to the mouse position called once per frame
                    if (Physics.Raycast(position, out hit, 100f)) // if the raycast from position hits in distance of 100f
                    {
                        if (hit.transform.CompareTag("Ground")) // if raycast hits ground
                        {
                            Debug.Log(hit.point); // log the position it hits
                            Debug.Log(hit.transform.tag); // log the tag it hits
                            Instantiate(cementToBuild, hit.point, Quaternion.identity); // create brick at hitpoint(Ground) in its original rotation;
                            bricks.Add(cementToBuild); //  add brick to list of bricks
                                                       //  builder.Remove1ToBrickAmount();

                        }


                    }
                    Debug.Log(hit.collider); // log the collider it hits
                }
            }



        }

    }*/
}



