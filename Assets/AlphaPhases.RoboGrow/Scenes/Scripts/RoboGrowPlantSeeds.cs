using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using LoLSDK;
using SimpleJSON;
using System.IO;
using UnityEngine.UI;
using UnityEngine.AI;
using TMPro;

namespace Alpha.Phases.Robo.Grow
{
    public class RoboGrowPlantSeeds : MonoBehaviour
    {
        [Header("Array for objects")]
        public PlantArrayManager obj_Array;
        public RoboGrowMain rgMain;
        public RoboGrowTextBoxManagerStage2 rgTextMan2;
        [Space]
        [Header("Navmesh and cameras")]
        [SerializeField] // so we can access it in the inspector but keep it private
        public Camera mainCam; // declare camera to store our camera from the inspector
        public Camera overCamToEnable;
        public Camera robotCam;
        public Ray cameraRay; // public ray to detect when the player is over ground/brick etc
        RaycastHit cameraRayHit; // raycasthit to detect when the ray has hit something
        RaycastHit hit; // = Physics.Raycast (Camera.main.ScreenPointToRay(Input.mousePosition));
        public Vector3 velocity; // instantiate a vector3 called velocity, to move the player down, to simulate gravity
                                 // [Header("UI Canvas")]
                                 // public GameObject helpCanvasToHide;
        public Button seedsReplantButton;
        public RobotController robCont;
        public GameObject robotNavMeshAgentToStop;
        [Space]
        [Header("Bools")]
        public bool isBuilding; // declare bool to detect when were building or notlayer
        public bool allSusansPlanted;
        public bool saveDeetsOnce;
        public int amountOFSusans;
        public int amountOfLimaBeans;
        public int amountOfDaisies;
        public int amountOfRadishs;

        public bool susanEnable;
        public bool limaEnable;
        public bool daisyEnable;
        public bool radishEnable;

        public BoxCollider pondColliderToEnable;

        public bool hasSusan2Planted;
        public bool hasLima2Planted;
        public bool hasDaisy2Planted;
        public bool hasRadish2Planted;




        [Space]
        [Header("List of Bricks")]
        public List<GameObject> plants = new List<GameObject>(); //  list to store bricks create in called bricks
        [Header("Game Objects - bricks and building stuff")]
        public GameObject susanToPlant; // gameobject to hold brick object
        public GameObject susanToPlantFake;
        public GameObject limaBeanToPlant; // gameobject to hold the brick when rotated object
        public GameObject limaBeanToPlantFake;
        public GameObject daisyToPlant;
        public GameObject daisyToPlantFake;
        public GameObject RadishToPlant;
        public GameObject RadishToPlantToFake;
        public GameObject susan2ToPlant; // gameobject to hold brick object
        public GameObject limaBean2ToPlant; // gameobject to hold the brick when rotated object
        public GameObject daisy2ToPlant;
        public GameObject Radish2ToPlant;

        public GameObject susanArrowToEnableAfterPlanting;
        public GameObject susan2ArrowToEnableAfterPlanting;
        public GameObject limaArrowToEnableAfterPlanting;
        public GameObject lima2ArrowToEnableAfterPlanting;
        public GameObject daisyArrowToEnableAfterPlanting;
        public GameObject daisy2ArrowToEnableAfterPlanting;
        public GameObject radishArrowToEnableAfterPlanting;
        public GameObject radish2ArrowToEnableAfterPlanting;

        public GameObject susanToDisable;
        public GameObject limaBeanToDisable;
        public GameObject daisyToDisable;
        public GameObject radishToDisable;

        public GameObject seedPromptToDisable;
       // public GameObject seedBag;


        private void Awake() // on awake of script
        {
            isBuilding = false; // player is not building on awake and can move
//brickForwardDirection = false; // Brick is in default position
           // transBrickForwardDirection = false;   //Trasparent brick is in default position
            //isTransBrickShowing = false; // trasparent brick is hideen 



            //testBrick.SetActive(true);
        }

        // Start is called before the first frame update
        void Start()
        {
            // agent = GetComponent<NavMeshAgent>(); // get NavMeshAgent component and apply it to agent .. this is redundant, we have set it in the inspector 
            //bricksThePlayerHasToBuildWith = builder.amountOfBricksCollected;
            seedsReplantButton.onClick.AddListener(ResetPlants);
        }
        // Update is called once per frame
        void Update()
        {




            if (Input.GetKeyDown(KeyCode.Q)) // if RMB is pressed
            {
               // ResetPlants();
            }

            if (Input.GetKeyDown(KeyCode.E)) // if E is pressed
            {
              //  brickForwardDirection = !brickForwardDirection; // change brick direction to and from the default and rotated brick
              //  transBrickForwardDirection = !transBrickForwardDirection;  // change transparent brick direction to and from the default and rotated brick
            }
            // 




            if (isBuilding)
            {
               
                if (rgMain.currentGameStage == 2) 
                {
                   // robCont.NewNavmeshStop();
                   // robotNavMeshAgentToStop.GetComponent<NavMeshAgent>().isStopped = true;

                    susanArrowToEnableAfterPlanting.SetActive(false);
                susan2ArrowToEnableAfterPlanting.SetActive(false);
                limaArrowToEnableAfterPlanting.SetActive(false);
                lima2ArrowToEnableAfterPlanting.SetActive(false);
                daisyArrowToEnableAfterPlanting.SetActive(false);
                daisy2ArrowToEnableAfterPlanting.SetActive(false);
                radishArrowToEnableAfterPlanting.SetActive(false);
                radish2ArrowToEnableAfterPlanting.SetActive(false);

                robotCam.enabled = false;
                mainCam.gameObject.SetActive(false);
                overCamToEnable.gameObject.SetActive(true);
                cameraRay = Camera.main.ScreenPointToRay(Input.mousePosition); // cameraRay decalred as position and shoots our from the middle of the screen to the mouse position and is called once per frame
                if (Physics.Raycast(cameraRay, out cameraRayHit)) // if raycast hits something
                {
                    if (cameraRayHit.transform.CompareTag("Ground")) // if raycast hits the ground
                    {
                        if (obj_Array.arrayPos == 0) // if transpare brick in the default position 
                        {
                            susanToPlantFake.transform.position = cameraRayHit.point; // transparent brick position is where the raycast hits the ground -- this is important as if not set to the ground, the traparent brick can float anywhere between the two raycast position ( raycast location and the hit point)
                            susanToPlantFake.SetActive(true); // set traparent brick to active
                            daisyToPlantFake.SetActive(false); // disable the rotated traparent brick
                            limaBeanToPlantFake.SetActive(false); // set traparent brick to inactive
                            RadishToPlantToFake.SetActive(false);

                            if (amountOFSusans < 2)
                            {

                                if (amountOFSusans == 0)
                                {

                                    if (Input.GetMouseButtonUp(0))
                                    {
                                        //  StartCoroutine(DelayPlantingSusan());
                                        // if (susanEnable)
                                        // {

                                        // Instantiate(susanToPlant, cameraRayHit.point, Quaternion.identity); // create brick at hitpoint(Ground) in its original rotation;
                                        susanToPlant.transform.position = cameraRayHit.point;
                                        //MoveArrayOnce();
                                        amountOFSusans = 1;
                                            // rgMain.SaveSusanSeedPlants();
                                            //obj_Array.arrayPos = 1;
                                       // robCont.NewNavmeshStop();


                                            //   }

                                        }
                                }


                                if (amountOFSusans == 1)
                                {
                                     StartCoroutine(DelayPlanting());
                                    if (Input.GetMouseButtonDown(0) && hasSusan2Planted)
                                    {
                                        //Instantiate(susan2ToPlant, cameraRayHit.point, Quaternion.identity); // create brick at hitpoint(Ground) in its original rotation;
                                        susan2ToPlant.transform.position = cameraRayHit.point;
                                        //MoveArrayOnce();
                                      //  rgMain.SaveSusanSeed2Plant();
                                        amountOFSusans = 2;
                                        isBuilding = false;
                                        TurnBackOnCameras();
                                        susanToDisable.SetActive(false);
                                      //  robCont.NewNavmeshStop();
                                        }
                                }

                                
                            }
                                // brickHalfToBuild.SetActive(false); // set traparent brick to inactive
                            }
                            else 
                            { 
                              //  obj_Array.arrayPos++; 
                            }

                        if (obj_Array.arrayPos == 1)  // if transpare brick in the rotated position 
                        {
                            limaBeanToPlantFake.transform.position = cameraRayHit.point; // Rotated transparent brick position is where the raycast hits the ground -- this is important as if not set to the ground, the traparent brick can float anywhere between the two raycast position ( raycast location and the hit point)
                            limaBeanToPlantFake.SetActive(true); // set traparent brick to inactive
                            daisyToPlantFake.SetActive(false); // enable the rotated traparent brick
                            susanToPlantFake.SetActive(false); // set traparent brick to inactive
                            RadishToPlantToFake.SetActive(false); // set traparent brick to active

                            if (amountOfLimaBeans < 2)
                            {

                                if (amountOfLimaBeans == 0)
                                {
                                    if (Input.GetMouseButtonUp(0))
                                    {

                                        //StartCoroutine(DelayPlantingLimbean());
                                       // if (limaEnable)
                                       // {
                                        limaBeanToPlant.transform.position = cameraRayHit.point;
                                       // rgMain.SaveLimaBeanPlants();
                                            amountOfLimaBeans = 1;
                                      //  }
                                    }
                                }


                                if (amountOfLimaBeans == 1)
                                {
                                     StartCoroutine(DelayLimaPlanting());
                                    if (Input.GetMouseButtonDown(0) && hasLima2Planted)
                                    {
                                      //  Instantiate(limaBean2ToPlant, cameraRayHit.point, Quaternion.identity); // create brick at hitpoint(Ground) in its original rotation;
                                        limaBean2ToPlant.transform.position = cameraRayHit.point;
                                        //MoveArrayOnce();
                                       
                                        amountOfLimaBeans = 2;
                                        isBuilding = false;
                                        TurnBackOnCameras();
                                       // rgMain.SaveLimaBean2Plant();
                                        limaBeanToDisable.SetActive(false);
                                    }
                                }


                            }

                        }

                        if (obj_Array.arrayPos == 2)  // if transpare brick in the rotated position 
                        {
                            daisyToPlantFake.transform.position = cameraRayHit.point; // Rotated transparent brick position is where the raycast hits the ground -- this is important as if not set to the ground, the traparent brick can float anywhere between the two raycast position ( raycast location and the hit point)
                            daisyToPlantFake.SetActive(true); // set traparent brick to inactive
                            limaBeanToPlantFake.SetActive(false); // disable the rotated traparent brick
                            susanToPlantFake.SetActive(false); // enable the rotated traparent brick
                            RadishToPlantToFake.SetActive(false); // set traparent brick to active.SetActive(false); // set traparent brick to inactive

                            if (amountOfDaisies < 2)
                            {

                                if (amountOfDaisies == 0)
                                {
                                    if (Input.GetMouseButtonUp(0))
                                    {
                                       // StartCoroutine(DelayDaisyPlanting());
                                     //   if (daisyEnable)
                                       // {
                                            daisyToPlant.transform.position = cameraRayHit.point;
                                            amountOfDaisies = 1;
                                           // rgMain.SaveDaisyPlant();
                                     //   }
                                    }
                                }


                                if (amountOfDaisies == 1)
                                {
                                    StartCoroutine(DelayDaisyPlanting());
                                    if (Input.GetMouseButtonDown(0) && hasDaisy2Planted)
                                    {
                                      //  Instantiate(daisy2ToPlant, cameraRayHit.point, Quaternion.identity); // create brick at hitpoint(Ground) in its original rotation;
                                        daisy2ToPlant.transform.position = cameraRayHit.point;
                                        //MoveArrayOnce();
                                        amountOfDaisies = 2;
                                        isBuilding = false;
                                        TurnBackOnCameras();
                                       // rgMain.SaveDaisy2Plant();
                                        daisyToDisable.SetActive(false);
                                    }
                                }


                            }

                           

                        }

                        if (obj_Array.arrayPos == 3)  // if transpare brick in the rotated position 
                        {
                            RadishToPlantToFake.transform.position = cameraRayHit.point; // Rotated transparent brick position is where the raycast hits the ground -- this is important as if not set to the ground, the traparent brick can float anywhere between the two raycast position ( raycast location and the hit point)
                            RadishToPlantToFake.SetActive(true); // set traparent brick to inactive
                            limaBeanToPlantFake.SetActive(false);
                            daisyToPlantFake.SetActive(false); // disable the rotated traparent brick
                            susanToPlantFake.SetActive(false); // enable the rotated traparent brick

                            if (amountOfRadishs < 2)
                            {

                                if (amountOfRadishs == 0)
                                {
                                    if (Input.GetMouseButtonUp(0))
                                    {
                                        //StartCoroutine(DelayRadishPlanting());
                                       /// if (radishEnable)
                                       // {
                                         
                                        RadishToPlant.transform.position = cameraRayHit.point;
                                       // rgMain.SaveRadishPlant();
                                        amountOfRadishs = 1;
                                       // }
                                    }
                                }


                                if (amountOfRadishs == 1)
                                {
                                    StartCoroutine(DelayRadishPlanting());
                                    if (Input.GetMouseButtonDown(0) && hasRadish2Planted)
                                    {
                                       // Instantiate(Radish2ToPlant, cameraRayHit.point, Quaternion.identity); // create brick at hitpoint(Ground) in its original rotation;
                                        Radish2ToPlant.transform.position = cameraRayHit.point;
                                        //MoveArrayOnce();
                                        amountOfRadishs = 2;
                                        isBuilding = false;
                                        TurnBackOnCameras();
                                       // rgMain.SaveRadish2Plant();
                                        radishToDisable.SetActive(false);
                                    }
                                }


                            }


                        }

                    }

                    }

                }
                
            }   
            
            if(amountOFSusans >= 2 && amountOfLimaBeans >=2 && amountOfDaisies >= 2 && amountOfRadishs >= 2)
            {
                if (!rgMain.stage2SeedsPlantedComplete)
                {
                    if (!saveDeetsOnce)
                    {
                        
                      //  robotNavMeshAgentToStop.GetComponent<NavMeshAgent>().isStopped = false;
                        rgMain.stage2SeedsPlantedComplete = true;
                        rgMain.SaveAllPlants();
                        rgMain.SavePlantStage();
                        pondColliderToEnable.enabled = true;
                        StartCoroutine(MoveTextAlong());
                     
                        susanToPlantFake.SetActive(false); // set traparent brick to active
                        daisyToPlantFake.SetActive(false); // disable the rotated traparent brick
                        limaBeanToPlantFake.SetActive(false); // set traparent brick to inactive
                        RadishToPlantToFake.SetActive(false);
                       // seedBag.SetActive(false);
                        seedPromptToDisable.SetActive(false);
                        rgMain.seedBagOpen = false;
                        seedsReplantButton.gameObject.SetActive(false);
                        susanArrowToEnableAfterPlanting.SetActive(true);
                        susan2ArrowToEnableAfterPlanting.SetActive(true);
                        limaArrowToEnableAfterPlanting.SetActive(true);
                        lima2ArrowToEnableAfterPlanting.SetActive(true);
                        daisyArrowToEnableAfterPlanting.SetActive(true);
                        daisy2ArrowToEnableAfterPlanting.SetActive(true);
                        radishArrowToEnableAfterPlanting.SetActive(true);
                        radish2ArrowToEnableAfterPlanting.SetActive(true);
                        saveDeetsOnce = true;
                    }
                  
                }
               
            }
                        
        }
        public void MoveArrayOnce()
        {
            obj_Array.arrayPos++;
        }

        public void TurnBackOnCameras()
        {
            overCamToEnable.gameObject.SetActive(false);
            robotCam.gameObject.SetActive(true);
            robotCam.enabled = true;
        }

      

        public IEnumerator MoveTextAlong()
        {
            rgTextMan2.currentStageOfText = 15;
            yield return new WaitForSeconds(3);
            rgTextMan2.currentStageOfText = 16;
        }

        public IEnumerator DelayPlanting()
        {
            yield return new WaitForSeconds(1f);
            hasSusan2Planted = true;
        }

        public IEnumerator DelayLimaPlanting()
        {
            yield return new WaitForSeconds(1f);
            hasLima2Planted = true;
        }

        public IEnumerator DelayDaisyPlanting()
        {
            yield return new WaitForSeconds(1f);
            hasDaisy2Planted = true;
        }

        public IEnumerator DelayRadishPlanting()
        {
            yield return new WaitForSeconds(1f);
            hasRadish2Planted = true;
        }

        public void ResetPlants()
        {
            amountOFSusans = 0;
            amountOfLimaBeans = 0;
            amountOfDaisies = 0;
            amountOfRadishs = 0;
            susanToDisable.SetActive(true);
            limaBeanToDisable.SetActive(true);
            daisyToDisable.SetActive(true);
            radishToDisable.SetActive(true);
            hasSusan2Planted = false;
            hasLima2Planted = false;
            hasDaisy2Planted = false;
            hasRadish2Planted = false;
        }

    }
  
}

