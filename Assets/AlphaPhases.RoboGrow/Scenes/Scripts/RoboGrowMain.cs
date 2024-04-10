using System.Collections;
using System.Collections.Generic;
using System.IO;
using LoLSDK;
using SimpleJSON;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AI;
namespace Alpha.Phases.Robo.Grow
{
    // This is the main script that holds all the global variables and saved functions
    
    [System.Serializable] // serialize this save data
    public class GardenData
    {
        public int seeds; // int for amount of seeds in inventory
    
      
        public int current_stage; // int to hold the level number
        public string robot_first_name_save; // string to store the players name - this is called first_name_save but its actaully the whole name, not just the first name
        [Header("SaveLocation")] // header for the save location for the robot
        public Vector3 robot_location_save; // this is the postion of the player in the game world, saved after each event
        public int plant_stage = 0; // int for plant stage, this will keep track of what stage the plant is at at the start of each level and after watering

     
        // stage 1 save bools
        
        public bool stage_1_mini_game_complete; //  bool to store if stage 1 mini=game is complete
        public bool stage_1_plant_removal_complete; // bool to store if stage 1 plants are removed
        public bool stage_1_plants_examined; // bool to store if stage 1 plants are removed
        public bool stage_1_pond_examined; // bool to store if stage 1 pond event is observed.
        public bool is_stage_1_intro_complete; // bool to store if all stage 1 events are complete
        public bool all_seeds_saved_in_inventory; //  bool to store if all seeds are in the inventory

        // stage 2 save bools

        public bool stage_2_mini_game_complete; //  bool to store if stage 2 mini=game is complete;
        public bool stage_2_seeds_planted_complete; //  bool to store if stage 2 seeds planting is complete;
        public bool stage_2_tree_examined; //  bool to store if stage 2 tree event observed;
        public bool is_stage_2_intro_complete; // bool to store if stage 2 intro is complete
        public bool all_plants_watered_stage_2; // bool to store if stage 2 plants are watered;

        // stage 3 save bools

        public bool stage_3_pond_examined; // bool to store if stage 3 pond event has been examined
        public bool stage_3_tree_minigame_Complete; // bool to store if stage 3 tree minigame complete
        public bool stage_3_flowers_watered; // bool to store if stage 3 flowers are watered 
        public bool all_stage_3_tasks_complete; // bool to store if stage 3 tasks are complete
        public bool is_stage_3_intro_complete; // bool to store if stage 2 intro is complete
        // stage 4 save bools

        public bool stage_4_plants_watered; // bool to store if stage 4 flowers are watered 
        public bool stage_4_butterfly_minigame_complete ;// bool to store if stage 4 tree minigame complete
        public bool stage_4_frog_minigame_complete; // bool to store if stage 4 pond minigame complete
        public bool is_stage_4_intro_complete; // bool to store if stage 2 intro is complete
        public bool all_stage_4_tasks_complete; // bool to store if all stage 4 tasks are complete

        public bool stage_5_plants_removed; // bool to store if stage 4 flowers are watered 
        public bool stage_5_butterfly_minigame_complete;// bool to store if stage 4 tree minigame complete
        public bool stage_5_frog_minigame_complete; // bool to store if stage 4 pond minigame complete
        public bool is_stage_5_intro_complete; // bool to store if stage 2 intro is complete
        public bool all_stage_5_tasks_complete; // bool to store if all stage 4 tasks are complete

        // stage 5 save bools


        public Vector3 susan_one_location; // vector to store the locations of the 1st black eyes susan plant after being planted
        public Vector3 susan_two_location; // vector to store the locations of the 2nd black eyes susan plant after being planted
        public Vector3 lima_bean_one_location; // vector to store the locations of the 1st Lima Bean plant after being planted
        public Vector3 lima_bean_two_location; // vector to store the locations of the 2nd Lima Bean plant after being planted
        public Vector3 daisy_one_location;  // vector to store the locations of the 1st daisy plant after being planted
        public Vector3 daisy_two_location; // vector to store the locations of the 2nd daisy plant after being planted
        public Vector3 radish_location; // vector to store the locations of the 1st radish plant after being planted
        public Vector3 radish_two_location; // vector to store the locations of the 2nd radish plant after being planted
    }

    public class RoboGrowMain : MonoBehaviour
    {
        #region global code
        [SerializeField, Header("Initial State Data")]

        GardenData gardenData; // get access to save section of this script
        public RoboGrowLanguageManager rgLang;
        public GameObject stage1taskItems; // declare gameobject to hold the events/activities on stage 1 - so we can enable and disable the items from appearing on other stages
        public GameObject stage2taskItems; // declare gameobject to hold the events/activities on stage 2 - so we can enable and disable the items from appearing on other stages
        public GameObject stage3taskItems; // declare gameobject to hold the events/activities on stage 3 - so we can enable and disable the items from appearing on other stages
        public GameObject stage4taskItems; // declare gameobject to hold the events/activities on stage 4 - so we can enable and disable the items from appearing on other stages

        public int playerScore;
       // public Camera pondCam;
        public RoboGrowPlantManager rGPlantMan; // declare access to RoboGrowPlantManager - so we can change the plant stage and update the plants
        public RoboGrowTextBoxManager rGTxtMan; // declare access to RoboGrowTextBoxManager - this is the text box manager for the intro text of stage 1
        public RoboGrowStage1EndMG stage1MG; // declare access to RoboGrowStage1EndMG - end of minigame for stage 1 script
        public RobotController robControl; // declare access to RobotController - so we can change values on the  player robot
        public GameObject playerRobot;  // declare gameobject to hold the player game object
                
        public BoxCollider miniGame1BoxToDisableIsSavesLocated; // box collider for stage 1 - this will be disabled on load once the mini game for stage 1 is complete
        public BoxCollider pondToDisable; // box collider for the pond of stage 1 - so it cant be repeated
        public BoxCollider endOfStage1Box;
        public GameObject mainCameraToDisable; // declare gameobject for the main camera, so we can disable and enable it
        public GameObject playerCameraToEnable; // declare gameobject for the player camera, so we can disable and enable it

        public Button remindersButton;

        public GameObject overCanvas;

        public GameObject hint1;
        public GameObject hint2;
        public GameObject hint3;
        public GameObject hint4;
        public GameObject hint5;
        public GameObject hint6;
        public GameObject hint7;
        public GameObject hint8;
        public GameObject hint9;
        public GameObject hint10;
        public GameObject hint11;
        public GameObject hint12;
        public GameObject hint13;

        public GameObject hintsList;
        public GameObject hintsList2;
        public GameObject hintsList3;
        public GameObject hintsList4;
        public GameObject hintsList5;

        public Button list1Button;
        public Button list2Button;
        public Button list3Button;
        public Button list4Button;
        public Button list5Button;

        public bool isHintsListOpen;

        public GameObject autoSavingMessage;
        public AudioSource hooraySFX;
        public Canvas mgCanvasToHide; // declare canvas for the UI for the main game
        public GameObject taskList; // declare gameobject to hold the UI image for tasks on stage 1
        public GameObject taskList2; // declare gameobject to hold the UI image for tasks on stage 2
        public GameObject taskList3; // declare gameobject to hold the UI image for tasks on stage 3
        public GameObject taskList4; // declare gameobject to hold the UI image for tasks on stage 4


      
        public GameObject seedBagPanal; // dcclare gameobject of the panal for the seed bag

        public Button blackEyedSusanSeedButton;  // declare button to be pressed to plant susan seeds
        public Button limaBeanSeed;  // declare button to be pressed to plant lima bean seeds
        public Button daisySeedButton; // declare button to be pressed to plant daisy seeds
        public Button radishSeedButton; // declare button to be pressed to plant radish seeds

        public Material waterBlueMaterial;

        public Camera flowerCamToMove;
        public GameObject susan1FlowerCamHolder;
        public GameObject susan2FlowerCamHolder;

        public GameObject lima1FlowerCamHolder;
        public GameObject lima2FlowerCamHolder;

        public GameObject daisy1FlowerCamHolder;
        public GameObject daisy2FlowerCamHolder;

        public GameObject radish1FlowerCamHolder;
        public GameObject radish2FlowerCamHolder;

        public GameObject susan1FlowerOrganicCamHolder;
        public GameObject limaBean1FlowerOrganicCamHolder;
        public GameObject daisy1FlowerOrganicCamHolder;
        public GameObject radish1FlowerOrganicCamHolder;

        public GameObject rock1OrganicCamHolder;
        public GameObject rock2OrganicCamHolder;
        public GameObject rock3OrganicCamHolder;
        public GameObject treeOrganicCamHolder;

        public GameObject stage1PondCamHolder;
        public GameObject stage2TreeCamHolder;
        public GameObject stage3PondCamHolder;


        public Renderer susanArrowToReset;
        public Renderer susan2ArrowToReset;
        public Renderer limaArrowToReset;
        public Renderer lima2ArrowToReset;
        public Renderer daisyArrowToReset;
        public Renderer daisy2ArrowToReset;
        public Renderer radishArrowToReset;
        public Renderer radish2ArrowToReset;

        public bool seedsSavedInInventory; // bool to check if seeds are saved in the inventory 
        public bool seedBagOpen; // bool to check is seed bag is open or not 

        public Vector3 playerLocation; // this is the players position, it updates constantly and can be saved on command or after events.
        public Vector3 playerStartPosition; // this is the positon of the player on start of each stage

        public Button seedBagButton; // button to open the seeds bag
        public Button taskListButton; // button to open the task list button

        public GameObject logoTohide; // declare gameobject for the main game logo to hide after starting

        public Animator roboGrowLogoFade; // animator for the MM logo to fade
        public Animator startGameAnim; // animator for the camera animation to start each stage
        public Animator doorOpenAnim; // animator for the lab door, to open and close on start of each stage
        public Animator stage1IntroLogo; // this is the animtor for the stage 1 text on intro of stage 1


        public bool plantsAlreadySownOnce; // bool to check if plants are sown so we cant  replant them by mistake
        public bool isTaskListOpen; // bool to check if the task list is open or not
        public int currentGameStage; // this int keeps track of the current game stage, we can save this on end of each level and loaded on start of saved game
        public int seeds_sown_in_garden; // this holds the amount of seeds sown in garden, we can save this after all plants are planted
        public int plantInGameStage; // this keeps tracks of the plants growth stage, we can save this

        public TextMeshProUGUI robot_first_name; // this is the textmeshpro for the players name, we will move this and add to this later

        [SerializeField] Button continueButton, newGameButton; // declare two buttons for the start new game and continue game options
              
        public TextMeshProUGUI newGameText; // TMP for the new game button
        public TextMeshProUGUI continueText; // TMP for the continue game button
        public TextMeshProUGUI jobotText; // TMP for the continue game button

        public TextMeshProUGUI stageNumber; // TMP for the robots name on screen
        //public TextMeshProUGUI playerScoreText; // TMP for the robots name on screen
        #endregion
        // stage one stuff
        #region "stage1stufftobecollapsed"
        [SerializeField, Header("Stage 1 Code")]

        public bool testBool;
        public GameObject task1TextUITick1; // declare UI object for the tick for task 1
        public GameObject task1TextUITick2; // declare UI object for the tick for task 2
        public GameObject task1TextUITick3; // declare UI object for the tick for task 3
        public BoxCollider stage1EndBoxToEnable; // end of stage 1 collider to disable after stage 1 is complete and player has been in the trigger

        public GameObject hideEndOfStage1Panal; // declare gameobject for the end of stage 1 TTS TMP panal
        public GameObject stage1PeiceToEnable;
        public bool stage1PlantRemovalComplete; // bool to check if stage 1 plants are removed
        public bool stage1PondExamined; // bool to check if stage 1 pond examined
        public bool stage1FlowersExamined; // bool to check if stage 1 pond examined
        public bool stage1MinigameComplete; // bool to check if stage 1 mini game complete
        public bool stage1IntroComplete; // bool to check if stage 1 intro is complete
        public bool progressSentAlready;
        public bool areAllPlantsRemoved;
        public GameObject namePanalToHide; // declare gameobject for the UI for the player name choice panal

        public GameObject startPlant1ToRemove; //  declare a gameobject to hold the susan plant that appear at the start of stage 1, this object is disabled after stage 1 so they dont reappear
        public GameObject startPlant2ToRemove;  //  declare a gameobject to hold the Lima Bean plant that appear at the start of stage 1, this object is disabled after stage 1 so they dont reappear
        public GameObject startPlant3ToRemove;  //  declare a gameobject to hold the daisy plant that appear at the start of stage 1, this object is disabled after stage 1 so they dont reappear
        public GameObject startPlant4ToRemove;  //  declare a gameobject to hold the Radish plant that appear at the start of stage 1, this object is disabled after stage 1 so they dont reappear
        public GameObject triggerToRemove; // declare gameobject to hold the trigger for the TTS TMP that appears when the flowers are examined on stage 1

        public GameObject treeTriggerStage1;
        public GameObject pondTriggerStage1;
        public GameObject flowerArrow1;
        public GameObject flowerArrow2;
        public GameObject flowerArrow3;
        public GameObject flowerArrow4;
        public GameObject organicItemsToDisableOnLoad;
        public int flowersRemoved; // bool to check how many flowers are removed - so we know if all the flowers are removed

        // These are the buttons TTS Audio Buttons for the players names they can listen to each one before they choose in the intro text scrawl

        public Button nameChoice1TTS;
        public Button nameChoice2TTS;
        public Button nameChoice3TTS;
        public Button nameChoice4TTS;
        public Button nameChoice5TTS;
        public Button nameChoice6TTS;
        public Button nameChoice7TTS;
        public Button nameChoice8TTS;
        public Button nameChoice9TTS;
        public Button nameChoice10TTS;
        public Button nameChoice11TTS;
        public Button nameChoice12TTS;
        public Button nameChoice13TTS;
        public Button nameChoice14TTS;
        public Button nameChoice15TTS;
        public Button nameChoice16TTS;

        // These are the Buttons for the players names they can choose in the intro text scrawl

        public Button nameChoice1;
        public Button nameChoice2;
        public Button nameChoice3;
        public Button nameChoice4;
        public Button nameChoice5;
        public Button nameChoice6;
        public Button nameChoice7;
        public Button nameChoice8;
        public Button nameChoice9;
        public Button nameChoice10;
        public Button nameChoice11;
        public Button nameChoice12;
        public Button nameChoice13;
        public Button nameChoice14;
        public Button nameChoice15;
        public Button nameChoice16;

        // These are the TMP for the players names buttons in the intro text scrawl

        public TextMeshProUGUI nameChoice1Text;
        public TextMeshProUGUI nameChoice2Text;
        public TextMeshProUGUI nameChoice3Text;
        public TextMeshProUGUI nameChoice4Text;
        public TextMeshProUGUI nameChoice5Text;
        public TextMeshProUGUI nameChoice6Text;
        public TextMeshProUGUI nameChoice7Text;
        public TextMeshProUGUI nameChoice8Text;
        public TextMeshProUGUI nameChoice9Text;
        public TextMeshProUGUI nameChoice10Text;
        public TextMeshProUGUI nameChoice11Text;
        public TextMeshProUGUI nameChoice12Text;
        public TextMeshProUGUI nameChoice13Text;
        public TextMeshProUGUI nameChoice14Text;
        public TextMeshProUGUI nameChoice15Text;
        public TextMeshProUGUI nameChoice16Text;
        #endregion "stage1stufftobecollapsed"

        //this is stage 2 variables etc
        #region "stage2stufftobecollapsed"

        public RoboGrowTextBoxManagerStage2 rgTextMan2; // get access to RoboGrowTextBoxManagerStage2 for the start of stage 2 intro text
      
        public BoxCollider stage2TreeColliderToDisable; // declare box collider for the tree on stage 2, so we can disable it after its been completed
        //public GameObject treeStage3Arrow;
        public Vector3 susan1Location; // vector that checks where susan 1 plant is located so we can save its position
        public GameObject susas1Model; //  gameobject to hold the model for susan 1 plant
        public Vector3 susan2Location; // vector that checks where susan 2 plant is located so we can save its position
        public GameObject susas2Model;//  gameobject to hold the model for susan 2 plant
        public Vector3 limaBean1Location; // vector that checks where lima bean 1 plant is located so we can save its position
        public GameObject limaBean1Model; //  gameobject to hold the model for lima bean 1 plant
        public Vector3 limaBean2Location; // vector that checks where lima bean 2 plant is located so we can save its position
        public GameObject limaBean2Model; // gameobject to hold the model for lima bean 2 plant
        public Vector3 daisy1Location; // vector that checks where daisy 1 plant is located so we can save its position
        public GameObject daisy1Model; // gameobject to hold the model for daisy 1 plant
        public Vector3 daisy2Location; // vector that checks where daisy 2 plant is located so we can save its position
        public GameObject daisy2Model; // gameobject to hold the model for daisy 2 plant
        public Vector3 radish1Location; // vector that checks where radish 1 plant is located so we can save its position
        public GameObject radish1Model; // gameobject to hold the model for Radish 1 plant
        public Vector3 radish2Location; // vector that checks where radish 2 plant is located so we can save its position
        public GameObject radish2Model; // gameobject to hold the model for Radish 2 plant

        public int amountofPlantsWateredStage2; // int to check how many plants have been watered
        public bool plantsWateredAlready; // bool to check is plants are watered or not
        public bool stage2AllSeedWateredStage2; // bool to check is all seeds are watered stage 2
        public bool stage2MiniGameComplete; // bool to check if stage 2 mini game is complete
        public bool stage2SeedsPlantedComplete; // bools to check is stage 2 plants are planted
        public bool stage2TreeExamindComplete; // bool to check if stage 2 tree is examined
        public bool stage2IntroComplete; // bool to check is stage 2 intro is complete
        public bool seedsEnabledOnce; // bool to check is seeds have been enabled 
        public bool stage2CompleteAlready;

        public RoboGrowWaterPlantsStage2Asses stage2WaterplantsAsses; // susan 1
        public RoboGrowWaterplantsstageasses1 stage2WaterplantsAsses1; // susan 2
        public RoboGrowWaterPlantsStagesAsses2 stage2WaterplantsAsses2; // lima 1
        public RoboGrowWaterPlantsStagesAsses3 stage2WaterplantsAsses3; // lima2
        public RoboGrowWaterPlantsStagesAsses4 stage2WaterplantsAsses4; // daisy 2
        public RoboGrowWaterplantsstageasses5 stage2WaterplantsAsses5; // radish 1
        public RoboGrowWaterplantsstageasses6 stage2WaterplantsAsses6; // daisy  2
        public RoboGrowWaterplantsstageasses7 stage2WaterplantsAsses7; // radish  2

        public GameObject stage2CompleteTextBox;

        public BoxCollider endOfStage2BoxCollider; // box collider to enable at end of stage 2 and disable after stage 2

        public GameObject stage2TickOne; // UI tick for event 1 complete in stage 2
        public GameObject stage2TickTwo; // UI tick for event 2 complete in stage 2
        public GameObject stage2TickThree; // UI tick for event 3 complete in stage 2

        public GameObject stage2TreeArrowToDisable;
        public GameObject stage2PondArrowToDisable;
        #endregion "stage2stufftobecollapsed"
        // this is the tree cam on stage 2. we disable this on load to avoid any chance of the camera being moved to the tree position on laod of stage 2
       // public Camera treeCameraToDisable; 
        // this is stage 3 variables etc
        #region "stage3stufftobecollapsed"
        public RoboGrowTextBoxManagerStage3 textMan3; // declare access to RoboGrowTextBoxManagerStage -this is the text manager for the intro text for stage 3
        public GameObject rgStartMini3TextPanal;
        public GameObject textBoxToAppearAtEndOfStage3;
        public bool hasPlayerStartedMinigame3; // bool to check if player has started minigame 1 on stage 3
        public bool introStage3Complete;
        public bool stage3TreeminigGameComplete; // bool to check if minigame 1 on stage 3 is complete
        public bool stage3PondExamined;  // bool to check if pond examined on stage 3 is complete
        public bool stage3FlowersWatered; // bool to check is flowers have been watered on stage 3
        public bool stage3AllTasksComplete; // bool to check is all stage 3 tasks are complete - so we can enable the end of level collider

        public bool stage3CompletedAlready;
        public int amountofPlantsWateredStage3; // this int tracks amount of floweres watered on stage 3
        public bool onlySaveStage3WateredOnce; // this bool stops the flowers watered text from appearing more than once

        public BoxCollider stage3EndBoxToEnable; // this box collider is the end of stage 3, enabled once all tasks complete and disabled on stage 4 start

        public GameObject stage3TreeArrowToDisable;
        public GameObject stage3PondArrowToDisable;

        public GameObject susanPollenArrows;
        public GameObject susanTargetnArrows;

        public GameObject limaPollenArrows;
        public GameObject limaTargetnArrows;

        public GameObject daisyPollenArrows;
        public GameObject daisyTargetnArrows;

        public GameObject radishPollenArrows;
        public GameObject radishTargetnArrows;
        public bool showingArrowsOnce;


        public GameObject stage3TickOne; // UI tick for event 1 stage 3
        public GameObject stage3TickTwo; // ui tick for event 2 stage 3
        public GameObject stage3TickThree; // UI tick for even 3 stage 3

        public BoxCollider rgStage3MGCollider; // this is the box collider for stage 3 minigame, we can disable it after minigame is complete


        #endregion

        // this is stage 4 variables etc
        #region "Stage4StuffToBeCollapsed

        public bool stage4FlowersWatered; // bool to check if stage 4 floweres are watered
        public bool stage4ButterflyMiniGameComplete; // bool to check is stage 4 mini game 1 is complete
        public bool stage4FrogMiniGameComplete; // bool ot check is stage 4 minigame 2 is complete
        public bool allStage4TasksComplete; // bool to check is stage 4 tasks are complete, to enable the end of stage collider
        public bool introStage4Complete;
        public RoboGrowTextManagerStage4 textMan4; // get access to RoboGrowTextManagerStage4 -  this manages text on the start of stage 4

        public BoxCollider endOfStage4; // this box collider is enabled at the end of stage 4 and disabled on start of stage 5

        public GameObject stage4MiniGame1TrigerArrowTree;
        public GameObject stage4Minigame2TriggerArrowPond;

        public GameObject frogStage4levelItems;

        public bool hasStage4BeenCompleted;

        public GameObject stage4Task1TextUITick1; // UI tick for event 1 stage 4
        public GameObject stage4Task1TextUITick2; // UI tick for event 2 stage 4
        public GameObject stage4Task1TextUITick3; // UI tick for event 3 stage 4

        public bool stage4WateredAlready; // bool to check if the stage 4 plants are watered already to stop overwatering

        public int amountOfStage4FlowersWatered; // amount of plants watered on stage 4

        #endregion
        // this is stage 5 variables etc

        #region "stage 5 variables etc

        public bool stage5FlowersRemoved; // bool to check if stage 5 floweres are watered
        public bool stage5ButterflyMiniGameComplete; // bool to check is stage 5 mini game 1 is complete
    //    public bool stage5FrogMiniGameComplete; // bool ot check is stage 5 minigame 2 is complete
        public bool stage5IntroComplete; // bool to check if stage 5 intro complete
        public bool allStage5TasksComplete; // bool to check is stage 5 tasks are complete, to enable the end of stage collider

        public GameObject taskList5;
        public RoboGrowStage5TextBoxManager textMan5; // get access to RoboGrowStage5TextBoxManager -  this manages text on the start of stage 5

        public BoxCollider endOfStage5; // this box collider is enabled at the end of stage 5 
        public int amountOfRemovedFlowersStage5;
        public GameObject stage5Task1TextUITick1; // UI tick for event 1 stage 5
     //   public GameObject stage5Task1TextUITick2; // UI tick for event 2 stage 5
        public GameObject stage5Task1TextUITick3; // UI tick for event 3 stage 5

    //    public GameObject missionArrowToDisableStage5;
        public GameObject mission2ArrowToDisableStage5;
        public GameObject susan1ToDisableStage5;
        public GameObject susan2ToDisableStage5;
        public GameObject lima1ToDisableStage5;
        public GameObject lima2ToDisableStage5;
        public GameObject daisy1ToDisableStage5;
        public GameObject daisy2ToDisableStage5;
        public GameObject radish1ToDisableStage5;
        public GameObject radish2ToDisableStage5;

        public bool havePlantsRemovedSave;
        public bool havePlantsRemovedONLoad;

        public GameObject stage5TaskItems;
        #endregion
        JSONNode _langNode; // declare lanuage code for this game so we know if its spanish or english
        public string _langCode = "en"; // declare string for english text
        string _langCodeSpanish = "es"; // declare string for spanish text


        private void Awake() // on awake of script
        {

            list1Button.onClick.AddListener(ShowHintsOne);
            list2Button.onClick.AddListener(ShowHintsTwo);
            list3Button.onClick.AddListener(ShowHintsThree);
            list4Button.onClick.AddListener(ShowHintsFour);
            list5Button.onClick.AddListener(ShowHintsFive);
            #region stage 1 awake code
            //stage 1 code
            daisySeedButton.gameObject.SetActive(false); // on awake disable the daisy seeds buttons so we dont have access to them outside of stage 2
            blackEyedSusanSeedButton.gameObject.SetActive(false); // on awake disable the susans seeds buttons so we dont have access to them outside of stage 2
            radishSeedButton.gameObject.SetActive(false); // on awake disable the radish seeds buttons so we dont have access to them outside of stage 2
            limaBeanSeed.gameObject.SetActive(false); // on awake disable the lima bean seeds buttons so we dont have access to them outside of stage 2

            // assign button player name choice actions for functions at the bottom of the script

            nameChoice1TTS.onClick.AddListener(SpeakChosenName1);
            nameChoice2TTS.onClick.AddListener(SpeakChosenName2);
            nameChoice3TTS.onClick.AddListener(SpeakChosenName3);
            nameChoice4TTS.onClick.AddListener(SpeakChosenName4);
            nameChoice5TTS.onClick.AddListener(SpeakChosenName5);
            nameChoice6TTS.onClick.AddListener(SpeakChosenName6);
            nameChoice7TTS.onClick.AddListener(SpeakChosenName7);
            nameChoice8TTS.onClick.AddListener(SpeakChosenName8);
            nameChoice9TTS.onClick.AddListener(SpeakChosenName9);
            nameChoice10TTS.onClick.AddListener(SpeakChosenName10);
            nameChoice11TTS.onClick.AddListener(SpeakChosenName11);
            nameChoice12TTS.onClick.AddListener(SpeakChosenName12);
            nameChoice13TTS.onClick.AddListener(SpeakChosenName13);
            nameChoice14TTS.onClick.AddListener(SpeakChosenName14);
            nameChoice15TTS.onClick.AddListener(SpeakChosenName15);
            nameChoice16TTS.onClick.AddListener(SpeakChosenName16);
            nameChoice1.onClick.AddListener(ChooseName1);
            nameChoice2.onClick.AddListener(ChooseName2);
            nameChoice3.onClick.AddListener(ChooseName3);
            nameChoice4.onClick.AddListener(ChooseName4);
            nameChoice5.onClick.AddListener(ChooseName5);
            nameChoice6.onClick.AddListener(ChooseName6);
            nameChoice7.onClick.AddListener(ChooseName7);
            nameChoice8.onClick.AddListener(ChooseName8);
            nameChoice9.onClick.AddListener(ChooseName9);
            nameChoice10.onClick.AddListener(ChooseName10);
            nameChoice11.onClick.AddListener(ChooseName11);
            nameChoice12.onClick.AddListener(ChooseName12);
            nameChoice13.onClick.AddListener(ChooseName13);
            nameChoice14.onClick.AddListener(ChooseName14);
            nameChoice15.onClick.AddListener(ChooseName15);
            nameChoice16.onClick.AddListener(ChooseName16);


            namePanalToHide.SetActive(false); // on awake set the name panal to false
            mgCanvasToHide.enabled = false; // on awake hide the stage 1 mingame 1 canvas

            task1TextUITick1.SetActive(false); // set tick 1 stage 1 false
            task1TextUITick2.SetActive(false); // set tick 2 stage 1 false
            task1TextUITick3.SetActive(false); // set tick 3 stage 1 false

            #endregion
            // Main Code
         //   pondCam.enabled = false;
            plantInGameStage = 2; // on awake set the plants to stage 2 - this is just past seeding. This is because we miscounted the amount of stages needed and start it on plant stage 2 now
            Application.runInBackground = false;
        }

        void Start()
        {
          
            newGameButton.onClick.AddListener(RemoveMainMenuUINewGame); // new game button after pressing, hides the button - see script at the bottom of the script
            continueButton.onClick.AddListener(RemoveMainMenuUIContinue); // continune saved game button after pressing, hides the button - see script at the bottom of the script
            taskListButton.onClick.AddListener(OpenTaskList); // task list button opens task list from function at the bottom of the script
            seedBagButton.onClick.AddListener(OpenSeedBag); // Seed bagt button opens seed bag from function at the bottom of the script
            remindersButton.onClick.AddListener(OpenRemindersList); // Seed bagt button opens seed bag from function at the bottom of the script

#if UNITY_EDITOR 
            ILOLSDK sdk = new LoLSDK.MockWebGL();
#elif UNITY_WEBGL
	    ILOLSDK sdk = new LoLSDK.WebGL();
#endif

            Helper.StateButtonInitialize<GardenData>(newGameButton, continueButton, OnLoad); // initialise LOLSDK helper function and attached both new game and continue buttons to it
        }

        private void Update()
        {
            //Reminders data outside of level specific code becasue we want it to be availalbe when loading from a save
            // Stage 1 Hints
            if (gardenData.is_stage_1_intro_complete)
            {               
                hint1.gameObject.SetActive(true);
                hint2.gameObject.SetActive(true);
            }
            if (gardenData.stage_1_plants_examined)
            {
                hint3.gameObject.SetActive(true);
            }
            if (gardenData.stage_1_pond_examined)
            {               
                hint4.gameObject.SetActive(true);
            }
            if (gardenData.stage_1_mini_game_complete)
            {
                hint5.gameObject.SetActive(true);
            }
            // Stage 2 Hints
            if (gardenData.stage_2_seeds_planted_complete) // if all seeds planted on stage 2
            {               
                hint6.gameObject.SetActive(true);
            }
            if (gardenData.stage_2_mini_game_complete)
            {
                hint7.gameObject.SetActive(true);
            }
            if (gardenData.stage_2_tree_examined)
            {
                hint8.gameObject.SetActive(true);
            }
            // Stage 3 Hints
            if (gardenData.is_stage_3_intro_complete)
            {
                hint9.gameObject.SetActive(true);
            }
            if (gardenData.stage_3_tree_minigame_Complete)
            {
                hint10.gameObject.SetActive(true);
            }
            // Stage 4 Hints
            if (gardenData.is_stage_4_intro_complete)
            {
                hint11.gameObject.SetActive(true);
                hint12.gameObject.SetActive(true);
            }
            // Stage 5 Hints
            if (gardenData.is_stage_5_intro_complete)
            {
                hint13.gameObject.SetActive(true);
            }
            //global save settings for hints page. This is setup so we can see all hints availaible on loading the game
            //if save data current stage is 1
            if (gardenData.current_stage == 1)
            {
                seedBagButton.gameObject.SetActive(false);
                // Show the stage 1 intro and disable it after completion
                StartCoroutine(DisableStage1IntroLogo());
                // enable and disable the level items (Events) according to what stage is stored in current_stage
                stage1taskItems.SetActive(true);
                stage2taskItems.SetActive(false);
                stage3taskItems.SetActive(false);
                stage4taskItems.SetActive(false);
                stage5TaskItems.SetActive(false);

                if (gardenData.stage_1_mini_game_complete && gardenData.stage_1_plant_removal_complete &&  gardenData.stage_1_pond_examined) // if all stage 1 tasks are complete
                {
                    doorOpenAnim.SetTrigger("resetDoorValues");
                    doorOpenAnim.SetBool("doorNeedsToBeOpen", true); // open the end of level door
                    doorOpenAnim.SetBool("closeDoor", false); // open the end of level door
                    rGTxtMan.currentStageOfText = 26;

                    endOfStage1Box.enabled = true;
                }

                if (gardenData.stage_1_plants_examined)
                {
                    hint3.gameObject.SetActive(true);
                }

                if (gardenData.stage_1_mini_game_complete)
                {
                    miniGame1BoxToDisableIsSavesLocated.enabled = false;
                    task1TextUITick2.SetActive(true);
                    treeTriggerStage1.SetActive(false);
                    hint5.gameObject.SetActive(true);
                }
                if (gardenData.is_stage_1_intro_complete)
                {
                    if (!testBool)
                    {
                        stage1taskItems.SetActive(true);
                        stage1PeiceToEnable.SetActive(true);
                        organicItemsToDisableOnLoad.gameObject.SetActive(false);
                        hint1.gameObject.SetActive(true);
                        hint2.gameObject.SetActive(true);
                        testBool = true;
                    }
                  
                }
                if (stage1PlantRemovalComplete)
                {
                    if (!progressSentAlready)
                    {
                        LOLSDK.Instance.SubmitProgress(0, 10, 100);
                        
                        flowerArrow1.SetActive(false);
                        flowerArrow2.SetActive(false);
                        flowerArrow3.SetActive(false);
                        flowerArrow4.SetActive(false);
                        progressSentAlready = true;
                    }
                }
                if (gardenData.stage_1_plant_removal_complete)
                {
                    if (!areAllPlantsRemoved)
                    {
                        Destroy(startPlant1ToRemove);
                        Destroy(startPlant2ToRemove);
                        Destroy(startPlant3ToRemove);
                        Destroy(startPlant4ToRemove);
                        treeTriggerStage1.SetActive(true);


                        Destroy(triggerToRemove);
                        task1TextUITick1.SetActive(true);

                        //  stage1PlantRemovalComplete = true;
                        //plantInGameStage = 2;
                        Debug.Log("This should have enabled the tree collider");
                        areAllPlantsRemoved = true;
                    }
                 
                }

                if (gardenData.stage_1_pond_examined)
                {
                    pondToDisable.enabled = false;
                    stage1PondExamined = true;
                    task1TextUITick3.SetActive(true);
                    hint4.gameObject.SetActive(true);
                    pondTriggerStage1.SetActive(false);

                }
            }
            //if save data current stage is 2
            if (gardenData.current_stage == 2)
            {
                 hideEndOfStage1Panal.SetActive(false); // hide stage 1 UI panal
                stage1EndBoxToEnable.enabled = false;
                currentGameStage = 2; // current game stage is 2 - we do this because some of the functions on these scripts use currentGameStage and not Gardendata current_stage
                stage1taskItems.SetActive(false); // disable task 1 event items
                stage2taskItems.SetActive(true); // enable stage 2 event items
               // seedBagButton.gameObject.SetActive(true);
                if (!gardenData.stage_2_seeds_planted_complete) // if all seeds planted on stage 2
                {
                    plantInGameStage = 3; // set plant stage to 3 - we actually skip stage 1 becuase we need to keep the plants approriate stage accorind to level
                    hint6.gameObject.SetActive(true);
                    seedBagButton.gameObject.SetActive(true);
                }

                else
                {
                    seedBagButton.gameObject.SetActive(false);
                }
                stage3taskItems.SetActive(false); // disable stage 3 event items
                stage4taskItems.SetActive(false); // disable stage 4 event items
                stage5TaskItems.SetActive(false); // disable stage 5 event items

                if (amountofPlantsWateredStage2 == 8) // if all the plants are watered
                {
                    stage2AllSeedWateredStage2 = true; // set stage2AllSeedWateredStage2 to true so we know all the plants are watered 

                   
                    if (!plantsWateredAlready) // if the plants are not already watered
                    {
                        gardenData.all_plants_watered_stage_2 = stage2AllSeedWateredStage2; // set gardenData.all_plants_watered_stage_2 value is value of stage2AllSeedWateredStage2 
                                                                                            // LOLSDK.Instance.SaveState(gardenData); // save gardenData save data
                        stage2TickOne.gameObject.SetActive(true); // enable stage 2 tick two on the stage 2 task list
                        rgTextMan2.currentStageOfText = 21; // set rgTextMan2 currentstageoftext to step 21 - to show the text that all plants are watered
                        plantInGameStage = 4; // set plant in game stage to 4
                        LOLSDK.Instance.SubmitProgress(0, 30, 100);
                        plantsWateredAlready = true; // plants already watered to true so we dont repeat this function
                        
                        SavePlantStage();
                    }
                   // plantInGameStage = 4; // make sure plant stage is 4 after watering
                }
                if (gardenData.stage_2_mini_game_complete && gardenData.all_plants_watered_stage_2 && gardenData.stage_2_tree_examined) // if all stage 2 tasks are complete
                {
                    doorOpenAnim.SetTrigger("resetDoorValues");
                    doorOpenAnim.SetBool("doorNeedsToBeOpen", true); // open the end of level door
                    doorOpenAnim.SetBool("closeDoor", false); // open the end of level door
                                                                     // mainCameraToDisable.SetActive(true);
                    if (!stage2CompleteAlready)
                    {
                        rgTextMan2.currentStageOfText = 18;
                       // stage2CompleteTextBox.gameObject.SetActive(true);
                        stage2CompleteAlready = true;
                    }
                   
                    endOfStage2BoxCollider.enabled = true; // enable end of level 2 collider
                }

                if (gardenData.is_stage_2_intro_complete)
                {
                    hint8.gameObject.SetActive(true);
                }

                // if stage 2 mini game complete 
                if (gardenData.stage_2_mini_game_complete)
                {
                    stage2TickThree.SetActive(true); // enable the tick for task 3 stage 2
                    stage2PondArrowToDisable.SetActive(false);
                    hint7.gameObject.SetActive(true);
                }

              
                //if stage 2 tree examined
                if (gardenData.stage_2_tree_examined)
                {
                    stage2TreeColliderToDisable.enabled = false; // disable tree trigger so we can click it again
                    stage2TickTwo.SetActive(true); // enable the UI tick for task 2 stage 2
                    stage2TreeArrowToDisable.SetActive(false);
                    hint8.gameObject.SetActive(true);
                //    treeCameraToDisable.enabled = false;
                  
                }
                if (gardenData.all_plants_watered_stage_2)
                {
                    susanArrowToReset.material = waterBlueMaterial;
                    susan2ArrowToReset.material = waterBlueMaterial;
                    limaArrowToReset.material = waterBlueMaterial;
                    lima2ArrowToReset.material = waterBlueMaterial;
                    daisyArrowToReset.material = waterBlueMaterial;
                    daisy2ArrowToReset.material = waterBlueMaterial;
                    radishArrowToReset.material = waterBlueMaterial;
                    radish2ArrowToReset.material = waterBlueMaterial;

                    stage2WaterplantsAsses.susanArrowToDisable.gameObject.SetActive(false);
                    stage2WaterplantsAsses1.susan2ArrowToDisable.gameObject.SetActive(false);
                    stage2WaterplantsAsses2.limaArrowToDisable.gameObject.SetActive(false);
                    stage2WaterplantsAsses3.lima2ArrowToDisable.gameObject.SetActive(false);
                    stage2WaterplantsAsses4.daisy2ArrowToDisable.gameObject.SetActive(false);
                    stage2WaterplantsAsses5.radishArrowToDisable.gameObject.SetActive(false);
                    stage2WaterplantsAsses6.daisyArrowToDisable.gameObject.SetActive(false);
                    stage2WaterplantsAsses7.radish2ArrowToDisable.gameObject.SetActive(false);

                   //.3
                   //+
                   //hint6.gameObject.SetActive(true);
                }

            }
            //if save data current stage is 3
            if (gardenData.current_stage == 3)
            {
               // stage2CompleteTextBox.gameObject.SetActive(false);
                hideEndOfStage1Panal.SetActive(false); // hide stage 1 UI panal
                plantInGameStage = 5; // set plant stage to 5 on stage 3
                endOfStage2BoxCollider.enabled = false;
                stage1EndBoxToEnable.enabled = false;
                currentGameStage = 3; // current game stage is 3 - we do this because some of the functions on these scripts use currentGameStage and not Gardendata current_stage
                stage1taskItems.SetActive(false);// disable task 1 event items
                stage2taskItems.SetActive(false); // disable task 2 event items
                stage3taskItems.SetActive(true); // enable task 3 event items
                stage4taskItems.SetActive(false); // disable task 4 event items
                stage5TaskItems.SetActive(false); // disable task 5 event items
                seedBagButton.gameObject.SetActive(false);
                if (amountofPlantsWateredStage3 > 7) // if amountofPlantsWateredStage3 is greater than 7
                {
                    plantInGameStage = 6; // set plantInGameStage to 6
                    stage3FlowersWatered = true; // set stage3FlowerWatered is true so we can save it 
                }

                if (gardenData.stage_3_flowers_watered) // if gardenData stage 3 flowers watered - we do this so when we load it sets the plants to the approriate stage
                {
                    plantInGameStage = 6; // set plantInGameStage = 6;
                    stage3TreeArrowToDisable.gameObject.SetActive(true); // enable MG trigger to start mini game - we do this because we cant start the pollenation minigame until the plants start producing pollen
                    susanArrowToReset.material = waterBlueMaterial;
                    susan2ArrowToReset.material = waterBlueMaterial;
                    limaArrowToReset.material = waterBlueMaterial;
                    lima2ArrowToReset.material = waterBlueMaterial;
                    daisyArrowToReset.material = waterBlueMaterial;
                    daisy2ArrowToReset.material = waterBlueMaterial;
                    radishArrowToReset.material = waterBlueMaterial;
                    radish2ArrowToReset.material = waterBlueMaterial;
                    if (!showingArrowsOnce)
                    {
                        susanPollenArrows.gameObject.SetActive(false);
                        susanTargetnArrows.gameObject.SetActive(false);
                        limaPollenArrows.gameObject.SetActive(false);
                        limaTargetnArrows.gameObject.SetActive(false);
                        daisyPollenArrows.gameObject.SetActive(false);
                        daisyTargetnArrows.gameObject.SetActive(false);
                        radishPollenArrows.gameObject.SetActive(false);
                        radishTargetnArrows.gameObject.SetActive(false);
                        showingArrowsOnce = true;
                    }
                  
                }
             

                if (stage3FlowersWatered) // if stage3FlowersWatered run function -  we use this becasue some functions work off the non gardendata stage3FlowersWatered
                {
                    if (!onlySaveStage3WateredOnce) // if onlySaveStage3WateredOnce is false
                    {
                        plantInGameStage = 6; // set plant stage to stage 6
                        textMan3.currentStageOfText = 11; // enable the text panal and set to 16 so we know that the task is complete
                        stage3FlowersWatered = true; // set stage3FlowersWatered to true to stop this function repeating
                        SaveStage3FLowersWatered(); // run SaveStage3FLowersWatered function and save the flowers watered state
                        stage3TickOne.SetActive(true); //  enable UI tick on stage 3 task list
                        rgStage3MGCollider.enabled = true; // enable the box collider for the tree minigame
                        onlySaveStage3WateredOnce = true; // set onlySaveStage3WateredOnce to true to stop this function repeating
                        LOLSDK.Instance.SubmitProgress(0, 50, 100);
                        stage3TreeArrowToDisable.gameObject.SetActive(true);

                        stage3TreeArrowToDisable.SetActive(true);

                        susanPollenArrows.gameObject.SetActive(false);
                        susanTargetnArrows.gameObject.SetActive(false);
                        limaPollenArrows.gameObject.SetActive(false);
                        limaTargetnArrows.gameObject.SetActive(false);
                        daisyPollenArrows.gameObject.SetActive(false);
                        daisyTargetnArrows.gameObject.SetActive(false);
                        radishPollenArrows.gameObject.SetActive(false);
                        radishTargetnArrows.gameObject.SetActive(false);
                       
                    }
                }

                if (gardenData.stage_3_pond_examined)
                {
                    stage3PondArrowToDisable.SetActive(false);
                   
                }


                if (gardenData.stage_3_tree_minigame_Complete)
                {
                    stage3TreeArrowToDisable.SetActive(false);
                    susanPollenArrows.gameObject.SetActive(false);
                    susanTargetnArrows.gameObject.SetActive(false);
                    limaPollenArrows.gameObject.SetActive(false);
                    limaTargetnArrows.gameObject.SetActive(false);
                    daisyPollenArrows.gameObject.SetActive(false);
                    daisyTargetnArrows.gameObject.SetActive(false);
                    radishPollenArrows.gameObject.SetActive(false);
                    radishTargetnArrows.gameObject.SetActive(false);
                }

                if (gardenData.stage_3_tree_minigame_Complete && gardenData.stage_3_pond_examined && gardenData.stage_3_flowers_watered) // if all stage 3 tasks complete
                {
                    doorOpenAnim.SetBool("doorNeedsToBeOpen", true); // open end of level door
                    stage3EndBoxToEnable.enabled = true; // enable end of stage 3 box collider
                    if (!stage3CompletedAlready)
                    {
                        rgStartMini3TextPanal.gameObject.SetActive(true);
                        textBoxToAppearAtEndOfStage3.gameObject.SetActive(true);
                          stage3CompletedAlready = true;
                    }
                  
                }

                if (gardenData.is_stage_3_intro_complete)
                {
                    hint9.gameObject.SetActive(true);
                }

                //if stage 3 pond has been examined
                if (gardenData.stage_3_pond_examined)
                {
                    stage3PondExamined = true; // set stage3PondExamined to true to save later
                    stage3TickTwo.SetActive(true); //enable UI tick for task 2 stage 3
                }
                //if stage 3 floweres watered
                if (gardenData.stage_3_flowers_watered)
                {
                    stage3FlowersWatered = true; //  set stage3FlowersWatered to true to save later
                    stage3TickOne.SetActive(true); // enable UI tick for task 1 stage 3
                    rgStage3MGCollider.enabled = true; // enable end of stage 3 collider
                    plantInGameStage = 6; // set plant in game stage to 6
                   
                }
                //if stage 3 tree minigame is complete
                if (gardenData.stage_3_tree_minigame_Complete)
                {
                    stage3TreeminigGameComplete = true; // set stage3TreeminigGameComplete to true, to save later
                    stage3TickThree.SetActive(true); // set UI tick for stage 3 task 3 
                    hint10.gameObject.SetActive(true);
                }
            }
            //if save data current stage is 4
            if (gardenData.current_stage == 4)
            {
                hideEndOfStage1Panal.SetActive(false); // hide stage 1 UI panal
                //hideEndOfStage1Panal.SetActive(false);
                stage1taskItems.SetActive(false); // disable task 1 event items
                stage2taskItems.SetActive(false); // disable task 2 event items
                stage3taskItems.SetActive(false); // disable task 3 event items
                stage4taskItems.SetActive(true);// enable task 4 event items
                stage5TaskItems.SetActive(false);// disable task 5 event items
                plantInGameStage = 6; //  set plant stage to 6
                // disable previous end of level box colliders - so we dont accidentally start a previous levle
                endOfStage2BoxCollider.enabled = false;
                stage1EndBoxToEnable.enabled = false;  
                stage3EndBoxToEnable.enabled = false;
                seedBagButton.gameObject.SetActive(false);
                if (gardenData.is_stage_4_intro_complete)
                {
                    hint11.gameObject.SetActive(true);
                    hint12.gameObject.SetActive(true);
                }

                if (gardenData.stage_4_plants_watered || amountOfStage4FlowersWatered >= 8) // if 8 plants watered on stage 4 run function 
                {
                    susanArrowToReset.gameObject.SetActive(false);
                    susan2ArrowToReset.gameObject.SetActive(false);
                    limaArrowToReset.gameObject.SetActive(false);
                    lima2ArrowToReset.gameObject.SetActive(false);
                    daisyArrowToReset.gameObject.SetActive(false);
                    daisy2ArrowToReset.gameObject.SetActive(false);
                    radishArrowToReset.gameObject.SetActive(false);
                    radish2ArrowToReset.gameObject.SetActive(false);

                    if (!stage4WateredAlready) // if the flowers have not already been watered
                        {
                           // plantInGameStage = 6; //  set plant stage to 6
                            textMan4.currentStageOfText = 12; //  enable UI text box from textMan4 to show all plants watered
                            Debug.Log("currentStageOfText is 12");
                            SaveStage4FlowersWatered(); // save stage of floweres watered stage 4
                            SavePlayerPos(); // save the players position
                            stage4Task1TextUITick1.SetActive(true); // enable UI tick on stage 4 task list
                            stage4WateredAlready = true; // set stage4WateredAlready to true so this function doesnt repeat
                            LOLSDK.Instance.SubmitProgress(0, 70, 100);
                    }
                }
                // if all stage 4 tasks are complete
                if (gardenData.stage_4_plants_watered && gardenData.stage_4_butterfly_minigame_complete && gardenData.stage_4_frog_minigame_complete) 
                {
                    doorOpenAnim.SetBool("doorNeedsToBeOpen", true); // open end of level door
                    endOfStage4.enabled = true; // enable the end of stage 4 collider
                    if (!hasStage4BeenCompleted)
                    {
                        textMan4.currentStageOfText = 14;
                        hasStage4BeenCompleted = true;
                    }
                }

                if (gardenData.stage_4_butterfly_minigame_complete)
                {
                    stage4MiniGame1TrigerArrowTree.SetActive(false);
                    stage4Task1TextUITick3.SetActive(true);
                }

                if (gardenData.stage_4_frog_minigame_complete)
                {
                    stage4Minigame2TriggerArrowPond.SetActive(false);
                    stage4Task1TextUITick2.SetActive(true);
                    frogStage4levelItems.gameObject.SetActive(false);
                }

                if (gardenData.stage_4_plants_watered)
                {
                    stage4Task1TextUITick1.SetActive(true);
                   
                }

            }
            //if save data current stage is 5
            if (gardenData.current_stage == 5)
            {
                // hideEndOfStage1Panal.SetActive(false);
                // StartCoroutine(DisableStage1IntroLogo());
                hideEndOfStage1Panal.SetActive(false); // hide stage 1 UI panal
                stage1taskItems.SetActive(false); // disable task 1 event items
                stage2taskItems.SetActive(false); // disable task 2 event items
                stage3taskItems.SetActive(false); // disable task 3 event items
                stage4taskItems.SetActive(false); // disable task 4 event items
                stage5TaskItems.SetActive(true); // enable task 5 event items

                /* susanArrowToReset.gameObject.SetActive(true);
                 susan2ArrowToReset.gameObject.SetActive(true);
                 limaArrowToReset.gameObject.SetActive(true);
                 lima2ArrowToReset.gameObject.SetActive(true);
                 daisyArrowToReset.gameObject.SetActive(true);
                 daisy2ArrowToReset.gameObject.SetActive(true);
                 radishArrowToReset.gameObject.SetActive(true);
                 radish2ArrowToReset.gameObject.SetActive(true);
                */ //disable end of level colliders from previous stages
                endOfStage2BoxCollider.enabled = false;
                stage1EndBoxToEnable.enabled = false;
                stage3EndBoxToEnable.enabled = false;
                endOfStage4.enabled = false;
                seedBagButton.gameObject.SetActive(false);
                plantInGameStage = 7; // set plant stage to 7 - dying seeding plants
                //if all stage 5 tasks complete
                if (gardenData.stage_5_butterfly_minigame_complete && gardenData.stage_5_plants_removed)
                {

                    doorOpenAnim.SetBool("doorNeedsToBeOpen", true); // open end of stage 4 door
                    endOfStage5.enabled = true; // enable the end of game collider
                    if (!allStage5TasksComplete)
                    {
                        textMan5.currentStageOfText = 24;
                        allStage5TasksComplete = true;
                    }
                   
                    
                }

                if (gardenData.is_stage_5_intro_complete)
                {
                    hint13.gameObject.SetActive(true);
                }
                
              if (amountOfRemovedFlowersStage5 >= 8)
              {
                  if (!havePlantsRemovedSave)
                  {
                      gardenData.stage_5_plants_removed = true;

                      //SaveStage5FlowersRemoved();
                      //stage5FlowersRemoved = true;
                   
                      playerCameraToEnable.SetActive(true);
                      textMan5.currentStageOfText = 19;
                      textMan5.textPanalToHide.SetActive(true);
                      havePlantsRemovedSave = true;
                      LOLSDK.Instance.SubmitProgress(0, 90, 100);
                  }

              }

              if (gardenData.stage_5_plants_removed == true)
              {
                  stage5Task1TextUITick1.SetActive(true);

                  if (!havePlantsRemovedONLoad)
                  {

                      susan1ToDisableStage5.SetActive(false);
                      susan2ToDisableStage5.SetActive(false);
                      lima1ToDisableStage5.SetActive(false);
                      lima2ToDisableStage5.SetActive(false);
                      daisy1ToDisableStage5.SetActive(false);
                      daisy2ToDisableStage5.SetActive(false);
                      radish1ToDisableStage5.SetActive(false);
                      radish2ToDisableStage5.SetActive(false);
                      havePlantsRemovedONLoad = true;
                  }


              }
              


                if (gardenData.stage_5_butterfly_minigame_complete)
                {
                    stage5Task1TextUITick3.gameObject.SetActive(true);
                    stage5ButterflyMiniGameComplete = true;
                    mission2ArrowToDisableStage5.gameObject.SetActive(false);
                }
            }

           // if (gardenData.all_seeds_saved_in_inventory) // if gardenData all seeds in inventory save is positive
           // {
                if (!gardenData.stage_2_seeds_planted_complete) // if the player has no planted all the seeds
                {
                    if (!seedsEnabledOnce) // if seedsEnabledOnce is false - we do this so we dont run this function more than once
                    {
                        EnableSeedStage2(); // run EnableSeedStage2 function, this is so all the seeds appear in the seed bag 
                        seedsEnabledOnce = true; // set seedsEnabledOnce to true
                    }
                }
            //  }

            if (Input.GetKeyDown(KeyCode.O))
            {
                isHintsListOpen = !isHintsListOpen;
                
            }

            if (Input.GetKeyDown(KeyCode.I)) // if I is pressed
            {
                isTaskListOpen = !isTaskListOpen; // task list is open if closed, or closed if open

            }
           if (Input.GetKeyDown(KeyCode.P)) // if P is pressed
            {
               seedBagOpen = !seedBagOpen; // open the seed bag is closed and close the seed bag if open

            }

            if (isHintsListOpen)
            {
                overCanvas.gameObject.SetActive(true);
                hintsList.gameObject.SetActive(true);
                
            }

            else
            {
                hintsList.gameObject.SetActive(false);
                overCanvas.gameObject.SetActive(false);
            }
            if (seedBagOpen) // if seedBagOpen is true
            {
                seedBagPanal.SetActive(true); //  enable the seed panal for the player
            }
            else { seedBagPanal.SetActive(false); } // else close the seed bag

            if (isTaskListOpen) // if the task list is showing
            {
                if (gardenData.current_stage == 1) // if current_stage is 1
                {
                    taskList.SetActive(true); // show stage 1 task list
                    taskList2.SetActive(false); // hide stage 2 task list
                    taskList3.SetActive(false); // hide stage 3 task list
                    taskList4.SetActive(false); // hide stage 4 task list
                    taskList5.SetActive(false); // hide stage 5 task list
                }
                if (gardenData.current_stage == 2)  // if current_stage is 2
                {
                    taskList.SetActive(false); // hide stage 1 task list
                    taskList2.SetActive(true); // show stage 2 task list
                    taskList3.SetActive(false); // hide stage 3 task list
                    taskList4.SetActive(false); // hide stage 4 task list
                    taskList5.SetActive(false); // hide stage 5 task list
                }
                if (gardenData.current_stage == 3) // if current_stage is 3
                {
                    taskList.SetActive(false);// hide stage 1 task list
                    taskList2.SetActive(false);// hide stage 2 task list
                    taskList3.SetActive(true); // show stage 3 task list
                    taskList4.SetActive(false);// hide stage 4 task list
                    taskList5.SetActive(false);// hide stage 5 task list
                }
                if (gardenData.current_stage == 4) // if current_stage is 4
                {
                    taskList.SetActive(false);// hide stage 1 task list
                    taskList2.SetActive(false);// hide stage 2 task list
                    taskList3.SetActive(false);// hide stage 3 task list
                    taskList4.SetActive(true); // show stage 4 task list
                    taskList5.SetActive(false); // hide stage 5 task list
                }
                if (gardenData.current_stage == 5) // if current_stage is 5
                {
                    taskList.SetActive(false);// hide stage 1 task list
                    taskList2.SetActive(false);// hide stage 2 task list
                    taskList3.SetActive(false); // hide stage 3 task list
                    taskList4.SetActive(false); // hide stage 4 task list
                    taskList5.SetActive(true); // show stage 5 task list
                }
            }

            else
            {
                taskList.SetActive(false);  // hide stage 1 task list
                taskList2.SetActive(false); // hide stage 2 task list
                taskList3.SetActive(false); // hide stage 3 task list
                taskList4.SetActive(false); // hide stage 4 task list
                taskList5.SetActive(false); // hide stage 5 task list
            }

             // Debug key to finish stage 1 after removing the plants
/*
            if (Input.GetKeyDown(KeyCode.Y)) // press Y to debug stage 1 complete
            {
                stage1MinigameComplete = true;
                stage1PlantRemovalComplete = true;
                stage1PondExamined = true;
                SaveStage1MiniGameComplete();
                SaveStage1Pond();
                SavePlantStage();
                // seedsSavedInInventory = true;
                // SaveStage1TasksComplete();


            }

            // Debug key to finish stage 2 after placing and watering the plants

            if (Input.GetKeyDown(KeyCode.E))
            {
                stage2MiniGameComplete = true;
                stage2TreeExamindComplete = true;
                SaveStage2TreeComplete();
                SaveStage2MiniGameComplete();
            }

            // Debug key to finish stage 3 after placing and watering the plants

            if (Input.GetKeyDown(KeyCode.R))
            {
                stage3TreeminigGameComplete = true;
                stage3PondExamined = true;
                SaveStage3MiniGameComplete();
                SaveStage2MiniGameComplete();
            }
*/
            
        

          


            JSONNode langs = SharedState.LanguageDefs;
            // force these variables to be the value of the saved data - This is a mess and needs to be sorted but the reasoning is that some scripts cant access
            // the gardendata data and needs to grab data from the main game script instead. We force these values so we dont have incorrect stage setup when we load 
          //  stage1MinigameComplete = gardenData.stage_1_mini_game_complete;
            stage1PlantRemovalComplete = gardenData.stage_1_plant_removal_complete;
           stage1PondExamined = gardenData.stage_1_pond_examined;
            seedsSavedInInventory = gardenData.all_seeds_saved_in_inventory;
            robot_first_name.text = langs["robotID"] + gardenData.robot_first_name_save;
            stageNumber.text = langs["stage"] + gardenData.current_stage.ToString();
           // playerScoreText.text = langs["score"] + playerScore.ToString();
            playerLocation = playerRobot.transform.position;
           // plantInGameStage = gardenData.plant_stage;
         ////   susan1Location = gardenData.susan_one_location;
//limaBean1Location = limaBean1Model.transform.position;
         //   daisy1Location = daisy1Model.transform.position;
         //   radish1Location = radish1Model.transform.position;
         //   susan2Location = gardenData.susan_two_location;
         //   limaBean2Location = limaBean2Model.transform.position;
          //  daisy2Location = daisy2Model.transform.position;
          //  radish2Location = radish2Model.transform.position;
          //  stage2SeedsPlantedComplete = gardenData.stage_2_seeds_planted_complete;
           // stage2AllSeedWateredStage2 = gardenData.all_plants_watered_stage_2;
           // stage3FlowersWatered = gardenData.stage_3_flowers_watered;
           // stage3PondExamined = gardenData.stage_3_pond_examined;
            //stage3TreeminigGameComplete = gardenData.stage_3_tree_minigame_Complete;
            currentGameStage = gardenData.current_stage;
        }
        //save function - not actually used much
         void Save()
        {
            LOLSDK.Instance.SaveState(gardenData);
        }

       



        /// <summary>
        /// This is the setting of your initial state when the scene loads.
        /// The state can be set from your default editor settings or from the
        /// users saved data after a valid save is called.
        /// </summary>
        /// <param name="loadedGardenData"></param>

        void OnLoad(GardenData loadedGardenData)
        {
            JSONNode langs = SharedState.LanguageDefs;
            // Overrides serialized state data or continues with editor serialized values.
            if (loadedGardenData != null) 
                gardenData = loadedGardenData;

                robot_first_name.text = langs["robotID"] + gardenData.robot_first_name_save;
                stageNumber.text = langs["stage"] + gardenData.current_stage.ToString();
                playerRobot.transform.position = gardenData.robot_location_save;
                plantInGameStage = gardenData.plant_stage;
               // stage1MinigameComplete = gardenData.stage_1_mini_game_complete;
                stage1PlantRemovalComplete = gardenData.stage_1_plant_removal_complete;
                seedsSavedInInventory = gardenData.all_seeds_saved_in_inventory;
                stage1IntroComplete = gardenData.is_stage_1_intro_complete;
                susan1Location = gardenData.susan_one_location;
                limaBean1Location = gardenData.lima_bean_one_location;
                daisy1Location = gardenData.daisy_one_location;
                radish1Location = gardenData.radish_location;
                susan2Location = gardenData.susan_two_location;
                limaBean2Location = gardenData.lima_bean_two_location;
                daisy2Location = gardenData.daisy_two_location;
                radish2Location = gardenData.radish_two_location;
                stage2AllSeedWateredStage2 = gardenData.all_plants_watered_stage_2;
              //  robControl.enabled = true;
            susas1Model.transform.position = susan1Location;
            limaBean1Model.transform.position = limaBean1Location;
            daisy1Model.transform.position = daisy1Location;
            radish1Model.transform.position = radish1Location;
            susas2Model.transform.position = susan2Location;
            limaBean2Model.transform.position = limaBean2Location;
            daisy2Model.transform.position = daisy2Location;
            radish2Model.transform.position = radish2Location;
            stage2SeedsPlantedComplete = gardenData.stage_2_seeds_planted_complete;
            stage2TreeExamindComplete = gardenData.stage_2_tree_examined;
            
            //susan1Location = gardenData.susan_One_Location;
         

          



        }

        void RemoveMainMenuUINewGame()
        {                        
            roboGrowLogoFade.SetBool("logoFadeTrue", true);
            startGameAnim.SetBool("gameStarted", true);
           // logoTohide.SetActive(false);
            gardenData.current_stage = 1;
            currentGameStage = 1;
          
        
        }
        void RemoveMainMenuUIContinue()
        {
            roboGrowLogoFade.SetBool("logoFadeTrue", true);
            robControl.enabled = true;
            playerCameraToEnable.SetActive(true);
            taskListButton.gameObject.SetActive(true);
            seedBagButton.gameObject.SetActive(true);
            //  startGameAnim.SetBool("gameContined", true);
            //  doorOpenAnim.SetBool("doorNeedsToBeOpenContinue", true);
            mainCameraToDisable.SetActive(false);
           

        }


        public void MoveCameraToSusan1Position()
        {
            flowerCamToMove.gameObject.SetActive(true);
            flowerCamToMove.enabled = true;
            flowerCamToMove.transform.position = susan1FlowerCamHolder.transform.position;
            flowerCamToMove.transform.eulerAngles = new Vector3(40, 269, 359);
        }

        public void MoveCameraToSusan2Position()
        {
            flowerCamToMove.gameObject.SetActive(true);
            flowerCamToMove.enabled = true;
            flowerCamToMove.transform.position = susan2FlowerCamHolder.transform.position;
            flowerCamToMove.transform.eulerAngles = new Vector3(40, 269, 359);
        }

        public void MoveCameraToLima1Position()
        {
            flowerCamToMove.gameObject.SetActive(true);
            flowerCamToMove.enabled = true;
            flowerCamToMove.transform.position = lima1FlowerCamHolder.transform.position;
            flowerCamToMove.transform.eulerAngles = new Vector3(40, 269, 359);
        }

        public void MoveCameraToLima2Position()
        {
            flowerCamToMove.gameObject.SetActive(true);
            flowerCamToMove.enabled = true;
            flowerCamToMove.transform.position = lima2FlowerCamHolder.transform.position;
            flowerCamToMove.transform.eulerAngles = new Vector3(40, 269, 359);
        }

        public void MoveCameraToDaisy1Position()
        {
            flowerCamToMove.gameObject.SetActive(true);
            flowerCamToMove.enabled = true;
            flowerCamToMove.transform.position = daisy1FlowerCamHolder.transform.position;
            flowerCamToMove.transform.eulerAngles = new Vector3(40, 269, 359);
        }

        public void MoveCameraToDaisy2Position()
        {
            flowerCamToMove.gameObject.SetActive(true);
            flowerCamToMove.enabled = true;
            flowerCamToMove.transform.position = daisy2FlowerCamHolder.transform.position;
            flowerCamToMove.transform.eulerAngles = new Vector3(40, 269, 359);
        }

        public void MoveCameraToRadish1Position()
        {
            flowerCamToMove.gameObject.SetActive(true);
            flowerCamToMove.enabled = true;
            flowerCamToMove.transform.position = radish1FlowerCamHolder.transform.position;
            flowerCamToMove.transform.eulerAngles = new Vector3(40, 269, 359);
        }

        public void MoveCameraToRadish2Position()
        {
            flowerCamToMove.gameObject.SetActive(true);
            flowerCamToMove.enabled = true;
            flowerCamToMove.transform.position = radish2FlowerCamHolder.transform.position;
            flowerCamToMove.transform.eulerAngles = new Vector3(40, 269, 359);
        }


        public void MoveCameraToOrganic1SusanPosition()
        {
            flowerCamToMove.gameObject.SetActive(true);
            flowerCamToMove.enabled = true;
            flowerCamToMove.transform.position = susan1FlowerOrganicCamHolder.transform.position;
            flowerCamToMove.transform.eulerAngles = new Vector3(40, 269, 359);
        }

        public void MoveCameraToOrganic1LimaPosition()
        {
            flowerCamToMove.gameObject.SetActive(true);
            flowerCamToMove.enabled = true;
            flowerCamToMove.transform.position = limaBean1FlowerOrganicCamHolder.transform.position;
            flowerCamToMove.transform.eulerAngles = new Vector3(40, 269, 359);
        }

        public void MoveCameraToOrganic1DaisyPosition()
        {
            flowerCamToMove.gameObject.SetActive(true);
            flowerCamToMove.enabled = true;
            flowerCamToMove.transform.position = daisy1FlowerOrganicCamHolder.transform.position;
            flowerCamToMove.transform.eulerAngles = new Vector3(40, 269, 359);
        }

        public void MoveCameraToOrganic1RadishPosition()
        {
            flowerCamToMove.gameObject.SetActive(true);
            flowerCamToMove.enabled = true;
            flowerCamToMove.transform.position = radish1FlowerOrganicCamHolder.transform.position;
            flowerCamToMove.transform.eulerAngles = new Vector3(40, 269, 359);
        }

        public void MoveCameraToOrganicRock1Position()
        {
            flowerCamToMove.gameObject.SetActive(true);
            flowerCamToMove.enabled = true;
            flowerCamToMove.transform.position = rock1OrganicCamHolder.transform.position;
            flowerCamToMove.transform.eulerAngles = new Vector3(40, 269, 359);
        }

        public void MoveCameraToOrganicRock2Position()
        {
            flowerCamToMove.gameObject.SetActive(true);
            flowerCamToMove.enabled = true;
            flowerCamToMove.transform.position = rock2OrganicCamHolder.transform.position;
            flowerCamToMove.transform.eulerAngles = new Vector3(40, 269, 359);
        }

        public void MoveCameraToOrganicRock3Position()
        {
            flowerCamToMove.gameObject.SetActive(true);
            flowerCamToMove.enabled = true;
            flowerCamToMove.transform.position = rock3OrganicCamHolder.transform.position;
            flowerCamToMove.transform.eulerAngles = new Vector3(40, 269, 359);
        }

        public void MoveCameraToOrganicTreePosition()
        {
            flowerCamToMove.gameObject.SetActive(true);
            flowerCamToMove.enabled = true;
            flowerCamToMove.transform.position = treeOrganicCamHolder.transform.position;
            flowerCamToMove.transform.eulerAngles = new Vector3(40, 269, 359);
        }

        public void MoveCameraToStage1PondPosition()
        {
            flowerCamToMove.gameObject.SetActive(true);
            flowerCamToMove.enabled = true;
            flowerCamToMove.transform.position = stage1PondCamHolder.transform.position;
            flowerCamToMove.transform.eulerAngles = new Vector3(28, 168, 0);
        }

        public void MoveCameraToStage2TreePosition()
        {
            flowerCamToMove.gameObject.SetActive(true);
            flowerCamToMove.enabled = true;
            flowerCamToMove.transform.position = stage2TreeCamHolder.transform.position;
            flowerCamToMove.transform.eulerAngles = new Vector3(3, 333, 7);
        }

        public void MoveCameraToStage3PondPosition()
        {
            flowerCamToMove.gameObject.SetActive(true);
            flowerCamToMove.enabled = true;
            flowerCamToMove.transform.position = stage3PondCamHolder.transform.position;
            flowerCamToMove.transform.eulerAngles = new Vector3(9, 262, 4);
        }

        public void HideCamera()
        {
            flowerCamToMove.gameObject.SetActive(false);
            flowerCamToMove.enabled = false;
        }
        public void EnableStage1Hint5() 
        {
            hint5.gameObject.SetActive(true);
        }


        #region global Save stuff
        public void SavePlayerPos()
        {

            gardenData.robot_location_save = playerLocation;
            StartCoroutine(ShowAutoSaveMessage());
            LOLSDK.Instance.SaveState(gardenData);

        }
        public void SavePlantStage()
        {
            gardenData.robot_location_save = playerLocation;
            gardenData.plant_stage = plantInGameStage;
            StartCoroutine(ShowAutoSaveMessage());
            LOLSDK.Instance.SaveState(gardenData);
        }

        public void SaveSeeds()
        {
            gardenData.seeds = gardenData.seeds + 2;
            StartCoroutine(ShowAutoSaveMessage());
            LOLSDK.Instance.SaveState(gardenData);
        }

        public void OpenTaskList()
        {
            isTaskListOpen = !isTaskListOpen;
            robControl.NewNavmeshStop();
        }

        public void OpenRemindersList()
        {
            isHintsListOpen = !isHintsListOpen;
            robControl.NewNavmeshStop();
        }

        public void OpenSeedBag()
        {
            seedBagOpen = !seedBagOpen;
            if(currentGameStage != 2)
            {
                robControl.NewNavmeshStop();
            }
          
        }

        public void MoveToLevel2()
        {
            gardenData.current_stage = 2;
            currentGameStage = 2;
            StartCoroutine(ShowAutoSaveMessage());
            LOLSDK.Instance.SaveState(gardenData);

        }

        public void MoveToLevel3()
        {
            gardenData.current_stage = 3;
            currentGameStage = 3;
            plantInGameStage = 5;
            StartCoroutine(ShowAutoSaveMessage());
            LOLSDK.Instance.SaveState(gardenData);

        }

        public void MoveToLevel4()
        {
            gardenData.current_stage = 4;
            currentGameStage = 4;
            plantInGameStage = 6;
            StartCoroutine(ShowAutoSaveMessage());
            LOLSDK.Instance.SaveState(gardenData);

        }

        public void MoveToLevel5()
        {
            gardenData.current_stage = 5;
            currentGameStage = 5;
            plantInGameStage = 7;
            StartCoroutine(ShowAutoSaveMessage());
            LOLSDK.Instance.SaveState(gardenData);

        }

        #endregion

        #region stage1savestuff    
        /// <summary>
        /// Stage 1 save Functions
        /// </summary>



        public void SaveStage1MiniGameComplete()
        {
            gardenData.robot_location_save = playerLocation;
            gardenData.stage_1_mini_game_complete = stage1MinigameComplete;
            StartCoroutine(ShowAutoSaveMessage());
            hooraySFX.Play();
            LOLSDK.Instance.SaveState(gardenData);
        }


        public void SaveIntroComplete() 
        {
            gardenData.robot_location_save = playerLocation;
            gardenData.is_stage_1_intro_complete = stage1IntroComplete;
            StartCoroutine(ShowAutoSaveMessage());
            Debug.Log("Save intro Completed");
            hooraySFX.Play();
            LOLSDK.Instance.SaveState(gardenData);
        }

       public void SaveStage1TasksComplete()
        {
            gardenData.robot_location_save = playerLocation;
            gardenData.stage_1_plant_removal_complete = stage1PlantRemovalComplete;
            gardenData.all_seeds_saved_in_inventory = seedsSavedInInventory;
            StartCoroutine(ShowAutoSaveMessage());
            gardenData.plant_stage = 0;
            Debug.Log("Save Tasks Completed");
            LOLSDK.Instance.SaveState(gardenData);
        }

        public IEnumerator DisableStage1IntroLogo()
        {

            stage1IntroLogo.SetBool("stage1LogoIntro", true);
            yield return new WaitForSeconds(3);
            stage1IntroLogo.gameObject.SetActive(false);

        }

        public void AssignDefaultNameToPlayer()
        {
            gardenData.robot_first_name_save = "Super Bot";
        }
       
        void SpeakChosenName1()
        {
            LOLSDK.Instance.SpeakText("jobotNameChoice1");

        }

        void SpeakChosenName2()
        {
            LOLSDK.Instance.SpeakText("jobotNameChoice2");
            Debug.Log("Micro Sparkle");
        }

        void SpeakChosenName3()
        {
            LOLSDK.Instance.SpeakText("jobotNameChoice3");
          
            Debug.Log("Electric Shrimp");
        }

        void SpeakChosenName4()
        {
            LOLSDK.Instance.SpeakText("jobotNameChoice4");
            Debug.Log("Jarvis Robotman");
        }

        void SpeakChosenName5()
        {
            LOLSDK.Instance.SpeakText("jobotNameChoice5");
            Debug.Log("Proto Bolt");
        }

        void SpeakChosenName6()
        {
            LOLSDK.Instance.SpeakText("jobotNameChoice6");
            Debug.Log("Copper Chip");
        }

        void SpeakChosenName7()
        {
            LOLSDK.Instance.SpeakText("jobotNameChoice7");
            Debug.Log("Super Matrix");
        }

        void SpeakChosenName8()
        {
            LOLSDK.Instance.SpeakText("jobotNameChoice8");
            Debug.Log("Alpha Wire");
        }

        void SpeakChosenName9()
        {
            LOLSDK.Instance.SpeakText("jobotNameChoice9");
            Debug.Log("Mega Droid");
        }

        void SpeakChosenName10()
        {
            LOLSDK.Instance.SpeakText("jobotNameChoice10");
            Debug.Log("Mecha Tech");
        }

        void SpeakChosenName11()
        {
            LOLSDK.Instance.SpeakText("jobotNameChoice11");
            Debug.Log("Ultra Android");
        }

        void SpeakChosenName12()
        {
            LOLSDK.Instance.SpeakText("jobotNameChoice12");
            Debug.Log("Beta Prime");
        }

        void SpeakChosenName13()
        {
            LOLSDK.Instance.SpeakText("jobotNameChoice13");
            Debug.Log("Flower Bot");
        }

        void SpeakChosenName14()
        {
            LOLSDK.Instance.SpeakText("jobotNameChoice14");
            Debug.Log("Gold Ranger");
        }

        void SpeakChosenName15()
        {
            LOLSDK.Instance.SpeakText("jobotNameChoice15");
            Debug.Log("Ratchet Gigabit");
        }

        void SpeakChosenName16()
        {
            LOLSDK.Instance.SpeakText("jobotNameChoice16");
            Debug.Log("Tracker Spanner");
        }
        JSONNode langs = SharedState.LanguageDefs;
        public void ChooseName1()
        {
           
            gardenData.robot_first_name_save = langs["jobotNameChoice1"];
            LOLSDK.Instance.SaveState(gardenData);
            StartCoroutine(ShowAutoSaveMessage());
            rGTxtMan.currentStageOfText = 12;
            Debug.Log("Silver Sparkey");
        }

        public void ChooseName2()
        {
            gardenData.robot_first_name_save = langs["jobotNameChoice2"];
            LOLSDK.Instance.SaveState(gardenData);
            StartCoroutine(ShowAutoSaveMessage());
            rGTxtMan.currentStageOfText = 12;
            Debug.Log("Silver Sparkey");
        }

        public void ChooseName3()
        {
            gardenData.robot_first_name_save = langs["jobotNameChoice3"];
            LOLSDK.Instance.SaveState(gardenData);
            StartCoroutine(ShowAutoSaveMessage());
            rGTxtMan.currentStageOfText = 12;
            Debug.Log("Electric Shrimp");
        }

        public void ChooseName4()
        {
            gardenData.robot_first_name_save = langs["jobotNameChoice4"];
            LOLSDK.Instance.SaveState(gardenData);
            StartCoroutine(ShowAutoSaveMessage());
            rGTxtMan.currentStageOfText = 12;
            Debug.Log("Jarvis Robotman");
        }

        public void ChooseName5()
        {
            gardenData.robot_first_name_save = langs["jobotNameChoice5"];
            LOLSDK.Instance.SaveState(gardenData);
            StartCoroutine(ShowAutoSaveMessage());
            rGTxtMan.currentStageOfText = 12;
            Debug.Log("Proto Bolt");
        }

        public void ChooseName6()
        {
            gardenData.robot_first_name_save = langs["jobotNameChoice6"];
            LOLSDK.Instance.SaveState(gardenData);
            StartCoroutine(ShowAutoSaveMessage());
            rGTxtMan.currentStageOfText = 12;
            Debug.Log("Copper Chip");
        }

        public void ChooseName7()
        {
            gardenData.robot_first_name_save = langs["jobotNameChoice7"];
            LOLSDK.Instance.SaveState(gardenData);
            StartCoroutine(ShowAutoSaveMessage());
            rGTxtMan.currentStageOfText = 12;
            Debug.Log("Super Matrix");
        }

        public void ChooseName8()
        {
            gardenData.robot_first_name_save = langs["jobotNameChoice8"];
            LOLSDK.Instance.SaveState(gardenData);
            StartCoroutine(ShowAutoSaveMessage());
            rGTxtMan.currentStageOfText = 12;
            Debug.Log("Daisy Moon");
        }

        public void ChooseName9()
        {
            gardenData.robot_first_name_save = langs["jobotNameChoice9"];
            LOLSDK.Instance.SaveState(gardenData);
            StartCoroutine(ShowAutoSaveMessage());
            rGTxtMan.currentStageOfText = 12;
            Debug.Log("Mega Droid");
        }

        public void ChooseName10()
        {
            gardenData.robot_first_name_save = langs["jobotNameChoice10"];
            LOLSDK.Instance.SaveState(gardenData);
            StartCoroutine(ShowAutoSaveMessage());
            rGTxtMan.currentStageOfText = 12;
            Debug.Log("Jarvis Robotman");
        }

        public void ChooseName11()
        {
            gardenData.robot_first_name_save = langs["jobotNameChoice11"];
            LOLSDK.Instance.SaveState(gardenData);
            StartCoroutine(ShowAutoSaveMessage());
            rGTxtMan.currentStageOfText = 12;
            Debug.Log("Glitter Bot");
        }

        public void ChooseName12()
        {
            gardenData.robot_first_name_save = langs["jobotNameChoice12"];
            LOLSDK.Instance.SaveState(gardenData);
            StartCoroutine(ShowAutoSaveMessage());
            rGTxtMan.currentStageOfText = 12;
            Debug.Log("Beta Prime");
        }

        public void ChooseName13()
        {
            gardenData.robot_first_name_save = langs["jobotNameChoice13"];
            LOLSDK.Instance.SaveState(gardenData);
            StartCoroutine(ShowAutoSaveMessage());
            rGTxtMan.currentStageOfText = 12;
            Debug.Log("Electric Shrimp");
        }

        public void ChooseName14()
        {
            gardenData.robot_first_name_save = langs["jobotNameChoice14"];
            LOLSDK.Instance.SaveState(gardenData);
            StartCoroutine(ShowAutoSaveMessage());
            rGTxtMan.currentStageOfText = 12;
            Debug.Log("Jarvis Robotman");
        }

        public void ChooseName15()
        {
            gardenData.robot_first_name_save = langs["jobotNameChoice15"];
            LOLSDK.Instance.SaveState(gardenData);
            StartCoroutine(ShowAutoSaveMessage());
            rGTxtMan.currentStageOfText = 12;
            Debug.Log("Ratchet Gigabit");
        }

        public void ChooseName16()
        {
            gardenData.robot_first_name_save = langs["jobotNameChoice16"];
            LOLSDK.Instance.SaveState(gardenData);
            StartCoroutine(ShowAutoSaveMessage());
            rGTxtMan.currentStageOfText = 12;
            Debug.Log("Tracker Spanner");
        }
        #endregion

        #region stage 2 stuff


        public void SaveAllPlants()
        {
            gardenData.stage_2_seeds_planted_complete = stage2SeedsPlantedComplete;
            gardenData.susan_one_location = susas1Model.transform.position;
            gardenData.lima_bean_one_location = limaBean1Model.transform.position; //SaveSusanSeed2Plant();
            gardenData.daisy_one_location = daisy1Model.transform.position;
            gardenData.radish_location = radish1Model.transform.position;
            gardenData.susan_two_location = susas2Model.transform.position;
            gardenData.lima_bean_two_location = limaBean2Model.transform.position;
            gardenData.daisy_two_location = daisy2Model.transform.position;
            gardenData.radish_two_location = radish2Model.transform.position;
            LOLSDK.Instance.SubmitProgress(0, 25, 100);
            hooraySFX.Play();
            StartCoroutine(ShowAutoSaveMessage());
            LOLSDK.Instance.SaveState(gardenData);
            Debug.Log("Save Plants");

        }
        public void SaveStage1Pond()
        {
            gardenData.robot_location_save = playerLocation;
            gardenData.stage_1_pond_examined = stage1PondExamined;
            StartCoroutine(ShowAutoSaveMessage());
            Debug.Log("Save Pond Completed");
            hooraySFX.Play();
            LOLSDK.Instance.SaveState(gardenData);
        }

        public void Stage1PlantsExamined()
        {
            gardenData.stage_1_plants_examined = stage1FlowersExamined;
            Debug.Log("FLowers examined and hint enabled");
          
            LOLSDK.Instance.SaveState(gardenData);
        }

        public void EnableSeedStage2()
        {
            daisySeedButton.enabled = true;
            blackEyedSusanSeedButton.enabled = true;
            radishSeedButton.enabled = true;
            limaBeanSeed.enabled = true;
            daisySeedButton.gameObject.SetActive(true);
            blackEyedSusanSeedButton.gameObject.SetActive(true);
            radishSeedButton.gameObject.SetActive(true);
            limaBeanSeed.gameObject.SetActive(true);
        }

        public void DisableSeedsStage2()
        {
            daisySeedButton.enabled = true;
            blackEyedSusanSeedButton.enabled = true;
            radishSeedButton.enabled = true;
            limaBeanSeed.enabled = true;
            daisySeedButton.gameObject.SetActive(true);
            blackEyedSusanSeedButton.gameObject.SetActive(true);
            radishSeedButton.gameObject.SetActive(true);
            limaBeanSeed.gameObject.SetActive(true);
        }


        public void SaveStage2MiniGameComplete()
        {
            gardenData.stage_2_mini_game_complete = stage2MiniGameComplete;
            StartCoroutine(ShowAutoSaveMessage());
            hooraySFX.Play();
            LOLSDK.Instance.SaveState(gardenData);
        }
        public void SaveStagePlantsWatered()
        {
            gardenData.stage_2_seeds_planted_complete = stage2AllSeedWateredStage2;
            hooraySFX.Play();
            LOLSDK.Instance.SaveState(gardenData);
        }



        public void SaveIntro2Complete()
        {
            gardenData.robot_location_save = playerLocation;
            gardenData.is_stage_2_intro_complete = stage2IntroComplete;
            StartCoroutine(ShowAutoSaveMessage());

            Debug.Log("Save intro Completed");
            LOLSDK.Instance.SaveState(gardenData);
        }

        public void SaveStage2TasksComplete()
        {
            gardenData.robot_location_save = playerLocation;
            gardenData.stage_2_seeds_planted_complete = stage2SeedsPlantedComplete;
            StartCoroutine(ShowAutoSaveMessage());
            hooraySFX.Play();
            gardenData.plant_stage = 1;
            Debug.Log("Save Tasks Completed");
            LOLSDK.Instance.SaveState(gardenData);
        }

        public void SaveStage2TreeComplete()
        {
            gardenData.robot_location_save = playerLocation;
            gardenData.stage_2_tree_examined = stage2TreeExamindComplete;
            StartCoroutine(ShowAutoSaveMessage());
            hooraySFX.Play();
            Debug.Log("Save Tree Completed");
            LOLSDK.Instance.SaveState(gardenData);
        }
        #endregion

        #region stage 3 stuff

        public void SaveStage3MiniGameComplete()
        {
            gardenData.robot_location_save = playerLocation;
            gardenData.stage_3_tree_minigame_Complete = stage3TreeminigGameComplete;
            StartCoroutine(ShowAutoSaveMessage());
            hooraySFX.Play();
            LOLSDK.Instance.SaveState(gardenData);
        }


        public void SaveStage3PondExamined()
        {
            gardenData.robot_location_save = playerLocation;
            gardenData.stage_3_pond_examined = stage3PondExamined;
            StartCoroutine(ShowAutoSaveMessage());
            hooraySFX.Play();
            Debug.Log("Save Pond Examined Completed");
            LOLSDK.Instance.SaveState(gardenData);
        }

        public void SaveStage3FLowersWatered()
        {
            gardenData.robot_location_save = playerLocation;
            gardenData.stage_3_flowers_watered = stage3FlowersWatered;
            Debug.Log("Save Tasks Completed");
            hooraySFX.Play();
            LOLSDK.Instance.SaveState(gardenData);
        }

        public void Stage3AllTasksComplete()
        {
            gardenData.robot_location_save = playerLocation;
            gardenData.stage_3_flowers_watered = stage3FlowersWatered;
            StartCoroutine(ShowAutoSaveMessage());
            Debug.Log("Save Tasks Completed");
            hooraySFX.Play();
            LOLSDK.Instance.SaveState(gardenData);
        }

        public void Stage3IntoComplete()
        {
            gardenData.robot_location_save = playerLocation;
            StartCoroutine(ShowAutoSaveMessage());
            Debug.Log("Save stage 3 intro Completed");
            LOLSDK.Instance.SaveState(gardenData);
            gardenData.is_stage_3_intro_complete = true;
            introStage3Complete = true;

        }



        #endregion


        #region stage 4 saves


      
        public void SaveStage4FlowersWatered()
        {
            gardenData.stage_4_plants_watered = true;
            amountOfStage4FlowersWatered = 8;
            Debug.Log("Save stage 4 flowers watered");
            StartCoroutine(ShowAutoSaveMessage());
            hooraySFX.Play();
            LOLSDK.Instance.SaveState(gardenData);
        }

        public void SaveStage4FrogMiniGameComplete()
        {
            gardenData.stage_4_frog_minigame_complete = true;
            Debug.Log("Save stage 4 flowers watered");
            StartCoroutine(ShowAutoSaveMessage());
            hooraySFX.Play();
            LOLSDK.Instance.SaveState(gardenData);
        }

        public void SaveStage4ButterlyMiniGameComplete()
        {
            gardenData.stage_4_butterfly_minigame_complete = true;
            Debug.Log("Save stage 4 flowers watered");
            StartCoroutine(ShowAutoSaveMessage());
            hooraySFX.Play();
            LOLSDK.Instance.SaveState(gardenData);
        }

        public void SaveIntroCompleteStage4()
        {
            gardenData.robot_location_save = playerLocation;
            gardenData.is_stage_4_intro_complete = true;
            Debug.Log("Save Tasks Completed");
            StartCoroutine(ShowAutoSaveMessage());
            LOLSDK.Instance.SaveState(gardenData);
        }

        #endregion

        public void SaveStage5FlowersRemoved()
        {
            gardenData.stage_5_plants_removed = true;
            Debug.Log("Save stage 4 flowers watered");
            StartCoroutine(ShowAutoSaveMessage());
            hooraySFX.Play();
            LOLSDK.Instance.SaveState(gardenData);
        }

        public void SaveStage5FrogMiniGameComplete()
        {
            gardenData.stage_5_frog_minigame_complete = true;
            Debug.Log("Save stage 5 Frog Mingame Complete");
            StartCoroutine(ShowAutoSaveMessage());
            hooraySFX.Play();
            LOLSDK.Instance.SaveState(gardenData);
        }

        public void SaveStage5ButterlyMiniGameComplete()
        {
            gardenData.stage_5_butterfly_minigame_complete = true;
            Debug.Log("Save stage 5 Buttefly Mingame Complete");
            StartCoroutine(ShowAutoSaveMessage());
            hooraySFX.Play();
            LOLSDK.Instance.SaveState(gardenData);
        }

        public void SaveIntroCompleteStage5()
        {
            gardenData.robot_location_save = playerLocation;
            gardenData.is_stage_5_intro_complete = true;
            Debug.Log("Save Tasks Completed");
            hooraySFX.Play();
            StartCoroutine(ShowAutoSaveMessage());
            LOLSDK.Instance.SaveState(gardenData);
        }

        #region stage 4 stuff



        #endregion

        

           public IEnumerator DisbleTxtMan1()
        {
           
            yield return new WaitForSeconds(5);
           // rGTxtMan.enabled = false;
        }

        public IEnumerator ShowAutoSaveMessage()
        {
            autoSavingMessage.gameObject.SetActive(true);
            yield return new WaitForSeconds(3);
            autoSavingMessage.gameObject.SetActive(false);
        }

        public void ShowHintsOne()
        {
            hintsList.gameObject.SetActive(true);
            hintsList2.gameObject.SetActive(false);
            hintsList3.gameObject.SetActive(false);
            hintsList4.gameObject.SetActive(false);
            hintsList5.gameObject.SetActive(false);
        }

        public void ShowHintsTwo()
        {
            hintsList.gameObject.SetActive(false);
            hintsList2.gameObject.SetActive(true);
            hintsList3.gameObject.SetActive(false);
            hintsList4.gameObject.SetActive(false);
            hintsList5.gameObject.SetActive(false);
        }

        public void ShowHintsThree()
        {
            hintsList.gameObject.SetActive(false);
            hintsList2.gameObject.SetActive(false);
            hintsList3.gameObject.SetActive(true);
            hintsList4.gameObject.SetActive(false);
            hintsList5.gameObject.SetActive(false);
        }

        public void ShowHintsFour()
        {
            hintsList.gameObject.SetActive(false);
            hintsList2.gameObject.SetActive(false);
            hintsList3.gameObject.SetActive(false);
            hintsList4.gameObject.SetActive(true);
            hintsList5.gameObject.SetActive(false);
        }

        public void ShowHintsFive()
        {
            hintsList.gameObject.SetActive(false);
            hintsList2.gameObject.SetActive(false);
            hintsList3.gameObject.SetActive(false);
            hintsList4.gameObject.SetActive(false);
            hintsList5.gameObject.SetActive(true);
        }
    }
}
