using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AI;
using LoLSDK;
namespace Alpha.Phases.Robo.Grow
{
    public class RoboGrowWaterPlantsStagesAsses2 : MonoBehaviour
{

        //FOR LIMA BEAN 1

        public GameObject textPanal;
        public GameObject textPanalStage3;
        public GameObject textPanalStage4;
        public GameObject textPanalStage5;
        public GameObject stage5IntroPanal;
        public RoboGrowStage2PlantReset rgStage2PR;
        public RoboGrowStage5TextBoxManager stage5TextMan;
        public RobotController robCont;
        public GameObject robotNavMeshAgentToStop;
        public RoboGrowMain rgMain;
        public Camera playerCamera;
        public Camera flowerCam;
        public GameObject susanArrowToDisable;
        public GameObject susan2ArrowToDisable;
        public GameObject limaArrowToDisable;
        public GameObject lima2ArrowToDisable;
        public GameObject daisyArrowToDisable;
        public GameObject daisy2ArrowToDisable;
        public GameObject radishArrowToDisable;
        public GameObject radish2ArrowToDisable;
        // public Button returnToPlayerCam;
        //stage 2 stuff Lima 1
        #region "Stage2StuffToBeCollapsed
        public Button waterSeedsStage1;

        public Button TTSJobotPlantAsses1;
        public Button TTSJobotPlantAsses1a;
        public Button TTSJobotPlantAsses1b;
        public Button TTSJobotPlantAsses1c;
        public Button TTSJobotPlantAsses1d;
        public Button TTSJobotIncorrectGuess;

        public GameObject anagramBoard;

        public Button jobotCorrectGuess;
        public Button wrongGuess1;
        public Button wrongGuess2;
        public Button wrongGuess3;
        public Button wrongGuess4;
        public Button wrongGuess5;
        public Button wrongGuess6;
        public Button wrongGuess7;
        public Button wrongGuess8;
        public Button wrongGuess9;


        public TextMeshProUGUI jobotIntroStage2PlantAsses1;
        public TextMeshProUGUI jobotIntroStage2PlantAsses1a;
        public TextMeshProUGUI jobotIntroStage2PlantAsses1b;
        public TextMeshProUGUI jobotIntroStage2PlantAsses1c;
        public TextMeshProUGUI jobotIntroStage2PlantAsses1d;
        public TextMeshProUGUI jobotIntroStage2PlantAsses1IncorrectGuess;

#endregion


        public Renderer susanArrowToChangeColour;
        public Renderer susan2ArrowToChangeColour;
        public Renderer limaArrowToChangeColour;
        public Renderer lima2ArrowToChangeColour;
        public Renderer daisyArrowToChangeColour;
        public Renderer daisy2ArrowToChangeColour;
        public Renderer radishArrowToChangeColour;
        public Renderer radish2ArrowToChangeColour;

        public AudioSource waterSFX;
        public Material wateredColour;

        public Animator waterSusan;
     

        public Animator susan1WaterToReset;
    

        public BoxCollider susan1plantBoxToDisable;
        public BoxCollider susan2plantBoxToDisable;
        public BoxCollider limaBean1plantBoxToDisable;
        public BoxCollider limaBean2plantBoxToDisable;
        public BoxCollider daisy1plantBoxToDisable;
        public BoxCollider daisy2plantBoxToDisable;
        public BoxCollider radish1plantBoxToDisable;
        public BoxCollider radish2plantBoxToDisable;



        #region "Stage3StuffToBeCollapsed

        public bool playerAlreadyGuessedIncorrectStage3;
        public bool playerAlreadyGuessedIncorrectStage4;

        #region "Stage4StuffToBeCollapsed

        public Button waterSeedsStage4;
        public GameObject mazeGamePanal;

        public Button deathCorrectAnswerButton;
        public Button adulthoodIncorrectAnswerButton;
        public Button childhoodIncorrectAnswerButton;

        //  public GameObject deathCorrectAnswer;
        //   public GameObject adulthoodIncorrectAnswer;
        //   public GameObject childhoodIncorrectAnswer;


        public Button TTSJobotPlantAsses2Stage4;
        public Button TTSJobotPlantAsses2aStage4;
        public Button TTSJobotPlantAsses2bStage4;
        public Button TTSJobotPlantAsses2cCorrectStage4;
        public Button TTSJobotIncorrectGuessStage4;

        public TextMeshProUGUI jobotIntroStage2PlantAsses2Stage4;
        public TextMeshProUGUI jobotIntroStage2PlantAsses2aStage4;
        public TextMeshProUGUI jobotIntroStage2PlantAsses2bStage4;
        public TextMeshProUGUI jobotIntroStage2PlantAsses2cCorrectStage4;
        public TextMeshProUGUI jobotIntroStage2PlantAsses2IncorrectGuessStage4;


        #endregion

        public bool hasGameBeenCompleted;

        public AudioSource cheerSFX;
        public Button waterSeedsStage3;
        public GameObject hangmanGamePanal;

        public int amountOFGuesses;

        public GameObject leaf1;
        public GameObject leaf2;
        public GameObject leaf3;

        public bool hasLeaf1BeenPicked;
        public bool hasLeaf2BeenPicked;
        public bool hasLeaf3BeenPicked;

        public Button TTSJobotPlantAsses2Stage3;
        public Button TTSJobotPlantAsses2aStage3;
        public Button TTSJobotPlantAsses2bStage3;
        public Button TTSJobotPlantAsses2cStage3;
        public Button TTSJobotPlantAsses2dStage3;
        public Button TTSJobotIncorrectGuessStage3;

        public TextMeshProUGUI jobotIntroStage3PlantAsses2Stage3;
        public TextMeshProUGUI jobotIntroStage3PlantAsses2aStage3;
        public TextMeshProUGUI jobotIntroStage3PlantAsses2bStage3;
        public TextMeshProUGUI jobotIntroStage3PlantAsses2cStage3;
        public TextMeshProUGUI jobotIntroStage3PlantAsses2dStage3;
        public TextMeshProUGUI jobotIntroStage3PlantAsses2IncorrectGuessStage3;

        public TextMeshProUGUI correctLetterToShow1L;
        public TextMeshProUGUI correctLetterToShow2A;
        public TextMeshProUGUI correctLetterToShow3R;
        public TextMeshProUGUI correctLetterToShow4G;
        public TextMeshProUGUI correctLetterToShow5E;
        public TextMeshProUGUI correctLetterToShow6R;

        public GameObject correctLetterToShow1LImage;
        public GameObject correctLetterToShow2AImage;
        public GameObject correctLetterToShow3RImage;
        public GameObject correctLetterToShow4GImage;
        public GameObject correctLetterToShow5EImage;
        public GameObject correctLetterToShow6RImage;

        public Button letter1L;
        public Button letter2A;
        public Button letter3R;
        public Button letter4G;
        public Button letter5E;
        public Button letter6X;
        public Button letter7S;
        public Button letter8T;
        public Button letter9K;
        public Button letter10N;
        public Button letter11D;

        #endregion

        public bool letterLCorrect;
        public bool letterACorrect;
        public bool letterRCorrect;
        public bool letterGCorrect;
        public bool letterECorrect;


        #region "Stage5StuffToBeCollapsed

        public GameObject susanToDisable;
        public GameObject susan2ToDisable;
        public GameObject limaToDisable;
        public GameObject lima2ToDisable;
        public GameObject daisyToDisable;
        public GameObject daisy2ToDisable;
        public GameObject radishToDisable;
        public GameObject radish2ToDisable;

        public Button removeSeedsStage5;

        public Button TTSJobotPlantAsses2Stage5;

        public TextMeshProUGUI jobotIntroStage2PlantAsses2Stage5;


        #endregion

        public bool textBeenRead;
        public bool progressTextIsShowing;

        public bool textBeenReadStage3;
        public bool progressTextIsShowingStage3;

        public bool textBeenReadStage4;
        public bool progressTextIsShowingStage4;

        public Button progressText;
        public Button progressTextBack;

        public Button progressTextStage3;
        public Button progressTextBackStage3;

        public Button progressTextStage4;
        public Button progressTextBackStage4;


        public bool plantswateredAlready;
        public bool plantswateredAlreadyStage3;
        public bool plantswateredAlreadyStage4;
        public bool plantRemovalAlreadyStage5;
        //  public bool treeAlreadyCompleted;
        public int currentStage2TreeText;
        public int currentStage3TreeText;
        public int currentStage4TreeText;
        public int currentStage5TreeText;

        public bool saveOnceFinal;
        private void Awake()
        {
            currentStage2TreeText = 0;
            currentStage3TreeText = 0;
            currentStage4TreeText = 0;
            currentStage5TreeText = 0;
            progressText.onClick.AddListener(OnClick);
            progressTextBack.onClick.AddListener(OnClickBack);
            TTSJobotPlantAsses1.onClick.AddListener(JobotStage2Plant1Asses);
            TTSJobotPlantAsses1a.onClick.AddListener(JobotStage2Plant1Asses2);
            TTSJobotPlantAsses1b.onClick.AddListener(JobotStage2Plant1Asses3);
            TTSJobotPlantAsses1c.onClick.AddListener(JobotStage2Plant1Asses4);
            TTSJobotPlantAsses1d.onClick.AddListener(JobotStage2Plant1Asses5);

            TTSJobotIncorrectGuess.onClick.AddListener(JobotStage2Plant1Asses6);
            jobotCorrectGuess.onClick.AddListener(ProgressToEndText);

            progressTextStage3.onClick.AddListener(OnClickStage3);
            progressTextBackStage3.onClick.AddListener(OnClickBackStage3);
            TTSJobotPlantAsses2Stage3.onClick.AddListener(JobotStage3Plant1Asses);
            TTSJobotPlantAsses2aStage3.onClick.AddListener(JobotStage3Plant1Asses2);
            TTSJobotPlantAsses2bStage3.onClick.AddListener(JobotStage3Plant1Asses3);
            TTSJobotPlantAsses2cStage3.onClick.AddListener(JobotStage3Plant1Asses4);
            TTSJobotPlantAsses2dStage3.onClick.AddListener(JobotStage3Plant1Asses5);

            TTSJobotIncorrectGuessStage3.onClick.AddListener(JobotStage3Plant1Asses6);

            progressTextStage4.onClick.AddListener(OnClickStage4);
            progressTextBackStage4.onClick.AddListener(OnClickBackStage4);
            TTSJobotPlantAsses2Stage4.onClick.AddListener(JobotStage4Plant1Asses);
            TTSJobotPlantAsses2aStage4.onClick.AddListener(JobotStage4Plant1Asses2);
            TTSJobotPlantAsses2bStage4.onClick.AddListener(JobotStage4Plant1Asses3);
            TTSJobotPlantAsses2cCorrectStage4.onClick.AddListener(JobotStage4Plant1Asses4);
            TTSJobotIncorrectGuessStage4.onClick.AddListener(JobotStage4Plant1Asses5);

            waterSeedsStage1.onClick.AddListener(WaterAllPlants);
            waterSeedsStage3.onClick.AddListener(WaterAllPlantsStage3);
            waterSeedsStage4.onClick.AddListener(WaterAllPlantsStage4);

            TTSJobotPlantAsses2Stage5.onClick.AddListener(JobotStage5Plant1Asses2);
            removeSeedsStage5.onClick.AddListener(PickFinalSeeds);



            amountOFGuesses = 3;
        }
        // Start is called before the first frame update
        void Start()
        {
            //returnToPlayerCam.gameObject.SetActive(false);
            // treeCamera.enabled = false;
            textPanal.SetActive(false);
            jobotIntroStage2PlantAsses1.enabled = false;
            jobotIntroStage2PlantAsses1a.enabled = false;
            jobotIntroStage2PlantAsses1b.enabled = false;
            jobotIntroStage2PlantAsses1c.enabled = false;
            jobotIntroStage2PlantAsses1d.enabled = false;
            jobotIntroStage2PlantAsses1IncorrectGuess.enabled = false;

            jobotIntroStage3PlantAsses2Stage3.enabled = false;
            jobotIntroStage3PlantAsses2aStage3.enabled = false;
            jobotIntroStage3PlantAsses2bStage3.enabled = false;
            jobotIntroStage3PlantAsses2cStage3.enabled = false;
            jobotIntroStage3PlantAsses2dStage3.enabled = false;
            jobotIntroStage3PlantAsses2IncorrectGuessStage3.enabled = false;

            jobotIntroStage2PlantAsses2Stage4.enabled = false;
            jobotIntroStage2PlantAsses2aStage4.enabled = false;
            jobotIntroStage2PlantAsses2bStage4.enabled = false;
            jobotIntroStage2PlantAsses2cCorrectStage4.enabled = false;
            jobotIntroStage2PlantAsses2IncorrectGuessStage4.enabled = false;

            hangmanGamePanal.gameObject.SetActive(false);
            mazeGamePanal.gameObject.SetActive(false);

            letter1L.onClick.AddListener(CorrectGuessLetterL);
            letter2A.onClick.AddListener(CorrectGuessLetterA);
            letter3R.onClick.AddListener(CorrectGuessLetterR);
            letter4G.onClick.AddListener(CorrectGuessLetterG);
            letter5E.onClick.AddListener(CorrectGuessLetterE);
            letter6X.onClick.AddListener(InCorrectGuessLetter1);
            letter7S.onClick.AddListener(InCorrectGuessLetter1);
            letter8T.onClick.AddListener(InCorrectGuessLetter1);
            letter9K.onClick.AddListener(InCorrectGuessLetter1);
            letter10N.onClick.AddListener(InCorrectGuessLetter1);
            letter11D.onClick.AddListener(InCorrectGuessLetter1);

            jobotIntroStage2PlantAsses2Stage5.enabled = false;
        }

        // Update is called once per frame
        void Update()
        {

            if(rgMain.currentGameStage == 2)
            {
                if (currentStage2TreeText == 1)
                {
                    if (!textBeenRead)
                    {
                        progressText.gameObject.SetActive(false);
                    }
                    progressTextBack.gameObject.SetActive(false);
                    robCont.enabled = false;
                    textPanal.SetActive(true);
                    // lima1.enabled = false;
                    jobotIntroStage2PlantAsses1.enabled = true;
                    jobotIntroStage2PlantAsses1a.enabled = false;
                    jobotIntroStage2PlantAsses1b.enabled = false;
                    jobotIntroStage2PlantAsses1c.enabled = false;
                    jobotIntroStage2PlantAsses1d.enabled = false;


                    TTSJobotPlantAsses1.gameObject.SetActive(true);
                    TTSJobotPlantAsses1a.gameObject.SetActive(false);
                    TTSJobotPlantAsses1b.gameObject.SetActive(false);
                    TTSJobotPlantAsses1c.gameObject.SetActive(false);
                    TTSJobotPlantAsses1d.gameObject.SetActive(false);

                    TTSJobotIncorrectGuess.gameObject.SetActive(false);
                    jobotIntroStage2PlantAsses1IncorrectGuess.enabled = false;
                    if (!progressTextIsShowing)
                    { // 3 second delay
                        StartCoroutine(DelayProgressButtonVar1());
                        progressTextIsShowing = true;
                    }
                }

                if (currentStage2TreeText == 2)
                {
                    //  pondFrogspawnIntro2
                    if (!textBeenRead)
                    {
                        progressText.gameObject.SetActive(false);
                    }
                    //   robCont.enabled = false;
                    jobotIntroStage2PlantAsses1.enabled = false;
                    jobotIntroStage2PlantAsses1a.enabled = true;
                    jobotIntroStage2PlantAsses1b.enabled = false;
                    jobotIntroStage2PlantAsses1c.enabled = false;
                    jobotIntroStage2PlantAsses1d.enabled = false;


                    TTSJobotPlantAsses1.gameObject.SetActive(false);
                    TTSJobotPlantAsses1a.gameObject.SetActive(true);
                    TTSJobotPlantAsses1b.gameObject.SetActive(false);
                    TTSJobotPlantAsses1c.gameObject.SetActive(false);
                    TTSJobotPlantAsses1d.gameObject.SetActive(false);

                    TTSJobotIncorrectGuess.gameObject.SetActive(false);
                    jobotIntroStage2PlantAsses1IncorrectGuess.enabled = false;

                    if (!progressTextIsShowing)
                    { // 3 second delay
                        StartCoroutine(DelayProgressButtonVar2());
                        progressTextIsShowing = true;
                    }
                }

                if (currentStage2TreeText == 3)
                {
                    //  pondFrogspawnIntro3
                    if (!textBeenRead)
                    {
                        progressText.gameObject.SetActive(false);
                    }
                    //    robCont.enabled = false;
                    jobotIntroStage2PlantAsses1.enabled = false;
                    jobotIntroStage2PlantAsses1a.enabled = false;
                    jobotIntroStage2PlantAsses1b.enabled = true;
                    jobotIntroStage2PlantAsses1c.enabled = false;
                    jobotIntroStage2PlantAsses1d.enabled = false;


                    TTSJobotPlantAsses1.gameObject.SetActive(false);
                    TTSJobotPlantAsses1a.gameObject.SetActive(false);
                    TTSJobotPlantAsses1b.gameObject.SetActive(true);
                    TTSJobotPlantAsses1c.gameObject.SetActive(false);
                    TTSJobotPlantAsses1d.gameObject.SetActive(false);

                    TTSJobotIncorrectGuess.gameObject.SetActive(false);
                    jobotIntroStage2PlantAsses1IncorrectGuess.enabled = false;

                    if (!progressTextIsShowing)
                    { // 3 second delay
                        StartCoroutine(DelayProgressButtonVar2());
                        progressTextIsShowing = true;
                    }
                }

                if (currentStage2TreeText == 4)
                {
                    //  pondFrogspawnIntro4
                    progressText.gameObject.SetActive(false);
                    //   robCont.enabled = false;
                    jobotIntroStage2PlantAsses1.enabled = false;
                    jobotIntroStage2PlantAsses1a.enabled = false;
                    jobotIntroStage2PlantAsses1b.enabled = false;
                    jobotIntroStage2PlantAsses1c.enabled = true;
                    jobotIntroStage2PlantAsses1d.enabled = false;


                    TTSJobotPlantAsses1.gameObject.SetActive(false);
                    TTSJobotPlantAsses1a.gameObject.SetActive(false);
                    TTSJobotPlantAsses1b.gameObject.SetActive(false);
                    TTSJobotPlantAsses1c.gameObject.SetActive(true);
                    TTSJobotPlantAsses1d.gameObject.SetActive(false);
                    anagramBoard.gameObject.SetActive(true);
                    TTSJobotIncorrectGuess.gameObject.SetActive(false);
                    jobotIntroStage2PlantAsses1IncorrectGuess.enabled = false;

                    wrongGuess1.onClick.AddListener(ProgressToWrongGuess);
                    wrongGuess2.onClick.AddListener(ProgressToWrongGuess);
                    wrongGuess3.onClick.AddListener(ProgressToWrongGuess);
                    wrongGuess4.onClick.AddListener(ProgressToWrongGuess);
                    wrongGuess5.onClick.AddListener(ProgressToWrongGuess);
                    wrongGuess6.onClick.AddListener(ProgressToWrongGuess);
                    wrongGuess7.onClick.AddListener(ProgressToWrongGuess);
                    wrongGuess8.onClick.AddListener(ProgressToWrongGuess);
                    wrongGuess9.onClick.AddListener(ProgressToWrongGuess);

                }

                if (currentStage2TreeText == 5)
                {
                    // progressText.gameObject.SetActive(false);
                    //robCont.enabled = false;
                    jobotIntroStage2PlantAsses1.enabled = false;
                    jobotIntroStage2PlantAsses1a.enabled = false;
                    jobotIntroStage2PlantAsses1b.enabled = false;
                    jobotIntroStage2PlantAsses1c.enabled = false;
                    jobotIntroStage2PlantAsses1d.enabled = true;


                    TTSJobotPlantAsses1.gameObject.SetActive(false);
                    TTSJobotPlantAsses1a.gameObject.SetActive(false);
                    TTSJobotPlantAsses1b.gameObject.SetActive(false);
                    TTSJobotPlantAsses1c.gameObject.SetActive(false);
                    TTSJobotPlantAsses1d.gameObject.SetActive(true);

                    waterSeedsStage1.gameObject.SetActive(true);
                    waterSeedsStage1.enabled = true;
                    anagramBoard.gameObject.SetActive(false);
                    TTSJobotIncorrectGuess.gameObject.SetActive(false);
                    jobotIntroStage2PlantAsses1IncorrectGuess.enabled = false;
                }

                if (currentStage2TreeText == 6)
                {
                    //  jobotIntroStage1e
                    if (!textBeenRead)
                    {
                        progressText.gameObject.SetActive(false);
                    }
                    //  robCont.enabled = true;
                    jobotIntroStage2PlantAsses1.enabled = false;
                    jobotIntroStage2PlantAsses1a.enabled = false;
                    jobotIntroStage2PlantAsses1b.enabled = false;
                    jobotIntroStage2PlantAsses1c.enabled = false;
                    jobotIntroStage2PlantAsses1d.enabled = false;

                    currentStage2TreeText = 0;
                    TTSJobotPlantAsses1.gameObject.SetActive(false);
                    TTSJobotPlantAsses1a.gameObject.SetActive(false);
                    TTSJobotPlantAsses1b.gameObject.SetActive(false);
                    TTSJobotPlantAsses1c.gameObject.SetActive(false);
                    TTSJobotPlantAsses1d.gameObject.SetActive(false);

                    TTSJobotIncorrectGuess.gameObject.SetActive(false);
                    jobotIntroStage2PlantAsses1IncorrectGuess.enabled = false;
                    anagramBoard.gameObject.SetActive(false);
                    ReturnToPlayerCamFromTree();
                    waterSeedsStage1.gameObject.SetActive(false);
                    waterSeedsStage1.enabled = false;

                }

                if (currentStage2TreeText == 7)
                {
                    //  jobotIntroStage1e

                    progressText.gameObject.SetActive(false);

                    //  robCont.enabled = true;
                    jobotIntroStage2PlantAsses1.enabled = false;
                    jobotIntroStage2PlantAsses1a.enabled = false;
                    jobotIntroStage2PlantAsses1b.enabled = false;
                    jobotIntroStage2PlantAsses1c.enabled = false;
                    jobotIntroStage2PlantAsses1d.enabled = false;


                    TTSJobotPlantAsses1.gameObject.SetActive(false);
                    TTSJobotPlantAsses1a.gameObject.SetActive(false);
                    TTSJobotPlantAsses1b.gameObject.SetActive(false);
                    TTSJobotPlantAsses1c.gameObject.SetActive(false);
                    TTSJobotPlantAsses1d.gameObject.SetActive(false);
                    anagramBoard.gameObject.SetActive(false);
                    TTSJobotIncorrectGuess.gameObject.SetActive(true);
                    jobotIntroStage2PlantAsses1IncorrectGuess.enabled = true;

                    StartCoroutine(ShowIncorrectGuess());

                }
            }

            if(rgMain.currentGameStage == 3)
            {
                if (currentStage3TreeText == 1)
                {
                    if (!textBeenReadStage3)
                    {
                        progressTextStage3.gameObject.SetActive(false);
                    }
                    progressTextBackStage3.gameObject.SetActive(false);
                    robCont.enabled = false;
                    textPanalStage3.SetActive(true);
                    limaBean1plantBoxToDisable.enabled = false;
                    jobotIntroStage3PlantAsses2Stage3.enabled = true;
                    jobotIntroStage3PlantAsses2aStage3.enabled = false;
                    jobotIntroStage3PlantAsses2bStage3.enabled = false;
                    jobotIntroStage3PlantAsses2cStage3.enabled = false;
                    jobotIntroStage3PlantAsses2dStage3.enabled = false;



                    TTSJobotPlantAsses2Stage3.gameObject.SetActive(true);
                    TTSJobotPlantAsses2aStage3.gameObject.SetActive(false);
                    TTSJobotPlantAsses2bStage3.gameObject.SetActive(false);
                    TTSJobotPlantAsses2cStage3.gameObject.SetActive(false);
                    TTSJobotPlantAsses2dStage3.gameObject.SetActive(false);

                    TTSJobotIncorrectGuessStage3.gameObject.SetActive(false);
                    jobotIntroStage3PlantAsses2IncorrectGuessStage3.enabled = false;
                    if (!progressTextIsShowingStage3)
                    { // 3 second delay
                        StartCoroutine(DelayProgressButtonVar1Stage3());
                        progressTextIsShowingStage3 = true;
                    }
                }

                if (currentStage3TreeText == 2)
                {
                    //  pondFrogspawnIntro2
                    if (!textBeenReadStage3)
                    {
                        progressTextStage3.gameObject.SetActive(false);
                    }
                    progressTextBackStage3.gameObject.SetActive(true);
                    //   robCont.enabled = false;
                    susan1plantBoxToDisable.enabled = false;
                    jobotIntroStage3PlantAsses2Stage3.enabled = false;
                    jobotIntroStage3PlantAsses2aStage3.enabled = true;
                    jobotIntroStage3PlantAsses2bStage3.enabled = false;
                    jobotIntroStage3PlantAsses2cStage3.enabled = false;
                    jobotIntroStage3PlantAsses2dStage3.enabled = false;


                    TTSJobotPlantAsses2Stage3.gameObject.SetActive(false);
                    TTSJobotPlantAsses2aStage3.gameObject.SetActive(true);
                    TTSJobotPlantAsses2bStage3.gameObject.SetActive(false);
                    TTSJobotPlantAsses2cStage3.gameObject.SetActive(false);
                    TTSJobotPlantAsses2dStage3.gameObject.SetActive(false);

                    TTSJobotIncorrectGuessStage3.gameObject.SetActive(false);
                    jobotIntroStage3PlantAsses2IncorrectGuessStage3.enabled = false;

                    if (!progressTextIsShowingStage3)
                    { // 3 second delay
                        StartCoroutine(DelayProgressButtonVar2Stage3());
                        progressTextIsShowingStage3 = true;
                    }
                }

                if (currentStage3TreeText == 3)
                {
                    //  pondFrogspawnIntro3
                    if (!textBeenReadStage3)
                    {
                        progressTextStage3.gameObject.SetActive(false);
                    }
                    //    robCont.enabled = false;
                    jobotIntroStage3PlantAsses2Stage3.enabled = false;
                    jobotIntroStage3PlantAsses2aStage3.enabled = false;
                    jobotIntroStage3PlantAsses2bStage3.enabled = true;
                    jobotIntroStage3PlantAsses2cStage3.enabled = false;
                    jobotIntroStage3PlantAsses2dStage3.enabled = false;


                    TTSJobotPlantAsses2Stage3.gameObject.SetActive(false);
                    TTSJobotPlantAsses2aStage3.gameObject.SetActive(false);
                    TTSJobotPlantAsses2bStage3.gameObject.SetActive(true);
                    TTSJobotPlantAsses2cStage3.gameObject.SetActive(false);
                    TTSJobotPlantAsses2dStage3.gameObject.SetActive(false);

                    TTSJobotIncorrectGuessStage3.gameObject.SetActive(false);
                    jobotIntroStage3PlantAsses2IncorrectGuessStage3.enabled = false;

                    if (!progressTextIsShowingStage3)
                    { // 3 second delay
                        StartCoroutine(DelayProgressButtonVar2Stage3());
                        progressTextIsShowingStage3 = true;
                    }
                }

                if (currentStage3TreeText == 4)
                {
                    //  pondFrogspawnIntro4
                    progressTextStage3.gameObject.SetActive(false);
                    //   robCont.enabled = false;
                    jobotIntroStage3PlantAsses2Stage3.enabled = false;
                    jobotIntroStage3PlantAsses2aStage3.enabled = false;
                    jobotIntroStage3PlantAsses2bStage3.enabled = false;
                    jobotIntroStage3PlantAsses2cStage3.enabled = true;
                    jobotIntroStage3PlantAsses2dStage3.enabled = false;
                    hangmanGamePanal.gameObject.SetActive(true);

                    TTSJobotPlantAsses2Stage3.gameObject.SetActive(false);
                    TTSJobotPlantAsses2aStage3.gameObject.SetActive(false);
                    TTSJobotPlantAsses2bStage3.gameObject.SetActive(false);
                    TTSJobotPlantAsses2cStage3.gameObject.SetActive(true);
                    TTSJobotPlantAsses2dStage3.gameObject.SetActive(false);

                    TTSJobotIncorrectGuessStage3.gameObject.SetActive(false);
                    jobotIntroStage3PlantAsses2IncorrectGuessStage3.enabled = false;

                }

                if (currentStage3TreeText == 5)
                {
                    progressText.gameObject.SetActive(false);
                    //robCont.enabled = false;
                    jobotIntroStage3PlantAsses2Stage3.enabled = false;
                    jobotIntroStage3PlantAsses2aStage3.enabled = false;
                    jobotIntroStage3PlantAsses2bStage3.enabled = false;
                    jobotIntroStage3PlantAsses2cStage3.enabled = false;
                    jobotIntroStage3PlantAsses2dStage3.enabled = true;
                    hangmanGamePanal.gameObject.SetActive(false);

                    TTSJobotPlantAsses2Stage3.gameObject.SetActive(false);
                    TTSJobotPlantAsses2aStage3.gameObject.SetActive(false);
                    TTSJobotPlantAsses2bStage3.gameObject.SetActive(false);
                    TTSJobotPlantAsses2cStage3.gameObject.SetActive(false);
                    TTSJobotPlantAsses2dStage3.gameObject.SetActive(true);

                    TTSJobotIncorrectGuessStage3.gameObject.SetActive(false);
                    jobotIntroStage3PlantAsses2IncorrectGuessStage3.enabled = false;

                    waterSeedsStage3.gameObject.SetActive(true);
                    waterSeedsStage3.enabled = true;

                }

                if (currentStage3TreeText == 6)
                {
                    //  jobotIntroStage1e
                    textPanalStage3.SetActive(false);
                    hasGameBeenCompleted = false;
                    //  robCont.enabled = true;
                    jobotIntroStage3PlantAsses2Stage3.enabled = false;
                    jobotIntroStage3PlantAsses2aStage3.enabled = false;
                    jobotIntroStage3PlantAsses2bStage3.enabled = false;
                    jobotIntroStage3PlantAsses2cStage3.enabled = false;
                    jobotIntroStage3PlantAsses2dStage3.enabled = false;


                    TTSJobotPlantAsses2Stage3.gameObject.SetActive(false);
                    TTSJobotPlantAsses2aStage3.gameObject.SetActive(false);
                    TTSJobotPlantAsses2bStage3.gameObject.SetActive(false);
                    TTSJobotPlantAsses2cStage3.gameObject.SetActive(false);
                    TTSJobotPlantAsses2dStage3.gameObject.SetActive(false);

                    TTSJobotIncorrectGuessStage3.gameObject.SetActive(false);
                    jobotIntroStage3PlantAsses2IncorrectGuessStage3.enabled = false;
                    currentStage3TreeText = 0;
                    ReturnToPlayerCamFromTree();
                    waterSeedsStage3.gameObject.SetActive(false);
                    waterSeedsStage3.enabled = false;
                    hasGameBeenCompleted = false;
                }

                if (currentStage3TreeText == 7)
                {
                    //  jobotIntroStage1e

                    progressTextStage3.gameObject.SetActive(false);
                    textPanalStage3.SetActive(true);
                    //  robCont.enabled = true;
                    jobotIntroStage3PlantAsses2Stage3.enabled = false;
                    jobotIntroStage3PlantAsses2aStage3.enabled = false;
                    jobotIntroStage3PlantAsses2bStage3.enabled = false;
                    jobotIntroStage3PlantAsses2cStage3.enabled = false;
                    jobotIntroStage3PlantAsses2dStage3.enabled = false;
                    //  Asses2AnagramBoard.gameObject.SetActive(false);

                    TTSJobotPlantAsses2Stage3.gameObject.SetActive(false);
                    TTSJobotPlantAsses2aStage3.gameObject.SetActive(false);
                    TTSJobotPlantAsses2bStage3.gameObject.SetActive(false);
                    TTSJobotPlantAsses2cStage3.gameObject.SetActive(false);
                    TTSJobotPlantAsses2dStage3.gameObject.SetActive(false);

                    TTSJobotIncorrectGuessStage3.gameObject.SetActive(true);
                    jobotIntroStage3PlantAsses2IncorrectGuessStage3.enabled = true;
                    if (!playerAlreadyGuessedIncorrectStage3)
                    {
                        StartCoroutine(ShowIncorrectGuessStage3());
                        playerAlreadyGuessedIncorrectStage3 = true;
                    }
                    else
                    {
                        currentStage3TreeText = 6;
                    }

                }

                if (amountOFGuesses == 2)
                {
                    leaf1.gameObject.SetActive(false);
                }

                if (amountOFGuesses == 1)
                {
                    leaf2.gameObject.SetActive(false);
                }

                if (amountOFGuesses == 0)
                {
                    leaf3.gameObject.SetActive(false);
                    currentStage3TreeText = 7;
                    hasGameBeenCompleted = true;
                }

                if (letterLCorrect && letterACorrect && letterRCorrect && letterGCorrect && letterECorrect)
                {

                    if (!hasGameBeenCompleted)
                    {
                        currentStage3TreeText = 5;
                        hasGameBeenCompleted = true;
                    }

                }

            }

            if (rgMain.currentGameStage == 4)
            {
                if (currentStage4TreeText == 1)
                {
                    if (!textBeenReadStage4)
                    {
                        progressTextStage4.gameObject.SetActive(false);
                    }
                    progressTextBackStage4.gameObject.SetActive(false);
                    robCont.enabled = false;
                    textPanalStage4.SetActive(true);
                    limaBean1plantBoxToDisable.enabled = false;
                    jobotIntroStage2PlantAsses2Stage4.enabled = true;
                    jobotIntroStage2PlantAsses2aStage4.enabled = false;
                    jobotIntroStage2PlantAsses2bStage4.enabled = false;
                    jobotIntroStage2PlantAsses2cCorrectStage4.enabled = false;

                    TTSJobotPlantAsses2Stage4.gameObject.SetActive(true);
                    TTSJobotPlantAsses2aStage4.gameObject.SetActive(false);
                    TTSJobotPlantAsses2bStage4.gameObject.SetActive(false);
                    TTSJobotPlantAsses2cCorrectStage4.gameObject.SetActive(false);

                    TTSJobotIncorrectGuessStage4.gameObject.SetActive(false);
                    jobotIntroStage2PlantAsses2IncorrectGuessStage4.enabled = false;
                    if (!progressTextIsShowingStage4)
                    { // 3 second delay
                        StartCoroutine(DelayProgressButtonVar1Stage4());
                        progressTextIsShowingStage4 = true;
                    }
                }

                if (currentStage4TreeText == 2)
                {
                    //  pondFrogspawnIntro2
                    if (!textBeenReadStage4)
                    {
                        progressTextStage4.gameObject.SetActive(false);
                    }
                    progressTextBackStage4.gameObject.SetActive(true);
                    //   robCont.enabled = false;
                    susan1plantBoxToDisable.enabled = false;
                    jobotIntroStage2PlantAsses2Stage4.enabled = false;
                    jobotIntroStage2PlantAsses2aStage4.enabled = true;
                    jobotIntroStage2PlantAsses2bStage4.enabled = false;
                    jobotIntroStage2PlantAsses2cCorrectStage4.enabled = false;
                    mazeGamePanal.gameObject.SetActive(true);
                    TTSJobotPlantAsses2Stage4.gameObject.SetActive(false);
                    TTSJobotPlantAsses2aStage4.gameObject.SetActive(true);
                    TTSJobotPlantAsses2bStage4.gameObject.SetActive(false);
                    TTSJobotPlantAsses2cCorrectStage4.gameObject.SetActive(false);

                    TTSJobotIncorrectGuessStage4.gameObject.SetActive(false);
                    jobotIntroStage2PlantAsses2IncorrectGuessStage4.enabled = false;

                    if (!progressTextIsShowingStage4)
                    { // 3 second delay
                        StartCoroutine(DelayProgressButtonVar2Stage4());
                        progressTextIsShowingStage4 = true;
                    }
                }

                if (currentStage4TreeText == 3)
                {
                    //  pondFrogspawnIntro3

                    progressTextStage4.gameObject.SetActive(false);

                    //    robCont.enabled = false;
                    jobotIntroStage2PlantAsses2Stage4.enabled = false;
                    jobotIntroStage2PlantAsses2aStage4.enabled = false;
                    jobotIntroStage2PlantAsses2bStage4.enabled = true;
                    jobotIntroStage2PlantAsses2cCorrectStage4.enabled = false;
                    mazeGamePanal.gameObject.SetActive(true);

                    TTSJobotPlantAsses2Stage4.gameObject.SetActive(false);
                    TTSJobotPlantAsses2aStage4.gameObject.SetActive(false);
                    TTSJobotPlantAsses2bStage4.gameObject.SetActive(true);
                    TTSJobotPlantAsses2cCorrectStage4.gameObject.SetActive(false);

                    TTSJobotIncorrectGuessStage4.gameObject.SetActive(false);
                    jobotIntroStage2PlantAsses2IncorrectGuessStage4.enabled = false;

                    // deathCorrectAnswerButton.onClick.AddListener(
                    deathCorrectAnswerButton.onClick.AddListener(CorrectAnswer);
                    adulthoodIncorrectAnswerButton.onClick.AddListener(IncorrectAnswer);
                    childhoodIncorrectAnswerButton.onClick.AddListener(IncorrectAnswer);
                    if (!progressTextIsShowingStage4)
                    { // 3 second delay
                        StartCoroutine(DelayProgressButtonVar2Stage4());
                        progressTextIsShowingStage4 = true;
                    }
                }

                if (currentStage4TreeText == 4)
                {
                    //  pondFrogspawnIntro4
                    //   robCont.enabled = false;
                    progressTextStage4.gameObject.SetActive(false);
                    jobotIntroStage2PlantAsses2Stage4.enabled = false;
                    jobotIntroStage2PlantAsses2aStage4.enabled = false;
                    jobotIntroStage2PlantAsses2bStage4.enabled = false;
                    jobotIntroStage2PlantAsses2cCorrectStage4.enabled = true;
                    mazeGamePanal.gameObject.SetActive(false);

                    TTSJobotPlantAsses2Stage4.gameObject.SetActive(false);
                    TTSJobotPlantAsses2aStage4.gameObject.SetActive(false);
                    TTSJobotPlantAsses2bStage4.gameObject.SetActive(false);
                    TTSJobotPlantAsses2cCorrectStage4.gameObject.SetActive(true);

                    TTSJobotIncorrectGuessStage4.gameObject.SetActive(false);
                    jobotIntroStage2PlantAsses2IncorrectGuessStage4.enabled = false;

                    waterSeedsStage4.gameObject.SetActive(true);
                    waterSeedsStage4.enabled = true;
                }

                if (currentStage4TreeText == 5)
                {
                    progressTextStage4.gameObject.SetActive(false);
                    progressTextBackStage4.gameObject.SetActive(false);
                    //robCont.enabled = false;
                    jobotIntroStage2PlantAsses2Stage4.enabled = false;
                    jobotIntroStage2PlantAsses2aStage4.enabled = false;
                    jobotIntroStage2PlantAsses2bStage4.enabled = false;
                    jobotIntroStage2PlantAsses2cCorrectStage4.enabled = false;

                    TTSJobotPlantAsses2Stage4.gameObject.SetActive(false);
                    TTSJobotPlantAsses2aStage4.gameObject.SetActive(false);
                    TTSJobotPlantAsses2bStage4.gameObject.SetActive(false);
                    TTSJobotPlantAsses2cCorrectStage4.gameObject.SetActive(false);

                    TTSJobotIncorrectGuessStage4.gameObject.SetActive(true);
                    jobotIntroStage2PlantAsses2IncorrectGuessStage4.enabled = true;

                    if (!playerAlreadyGuessedIncorrectStage4)
                    {
                        StartCoroutine(ShowIncorrectGuessStage4());
                        playerAlreadyGuessedIncorrectStage4 = true;
                    }
                   
                }

                if (currentStage4TreeText == 6)
                {
                    textPanalStage4.gameObject.SetActive(false);
                    //  robCont.enabled = true;
                    jobotIntroStage2PlantAsses2Stage4.enabled = false;
                    jobotIntroStage2PlantAsses2aStage4.enabled = false;
                    jobotIntroStage2PlantAsses2bStage4.enabled = false;
                    jobotIntroStage2PlantAsses2cCorrectStage4.enabled = false;


                    TTSJobotPlantAsses2Stage4.gameObject.SetActive(false);
                    TTSJobotPlantAsses2aStage4.gameObject.SetActive(false);
                    TTSJobotPlantAsses2bStage4.gameObject.SetActive(false);
                    TTSJobotPlantAsses2cCorrectStage4.gameObject.SetActive(false);

                    TTSJobotIncorrectGuessStage4.gameObject.SetActive(false);
                    jobotIntroStage2PlantAsses2IncorrectGuessStage4.enabled = false;
                    currentStage4TreeText = 0;
                    textBeenReadStage4 = false;
                    progressTextIsShowingStage4 = false;
                    ReturnToPlayerCamFromTree();
                    waterSeedsStage4.gameObject.SetActive(false);
                    waterSeedsStage4.enabled = false;

                }

            }

            if (rgMain.currentGameStage == 5)
            {
                if (currentStage5TreeText == 1)
                {
                    robCont.enabled = false;
                    textPanalStage5.SetActive(true);
                    limaBean1plantBoxToDisable.enabled = false;
                    jobotIntroStage2PlantAsses2Stage5.enabled = true;
                    TTSJobotPlantAsses2Stage5.gameObject.SetActive(true);
                }
            }

        }

        void OnMouseDown()
        {
            if (rgMain.currentGameStage == 2)
            {
                textPanal.SetActive(true);
                playerCamera.enabled = false;
                currentStage2TreeText = 1;
                robCont.NewNavmeshStop();
                rgMain.MoveCameraToLima1Position();
                robCont.enabled = false;
                robotNavMeshAgentToStop.GetComponent<NavMeshAgent>().isStopped = true;

                Debug.Log("Mouse Clicked");
                susan1plantBoxToDisable.enabled = false;
                susan2plantBoxToDisable.enabled = false;
                limaBean2plantBoxToDisable.enabled = false;
                daisy1plantBoxToDisable.enabled = false;
                daisy2plantBoxToDisable.enabled = false;
                radish1plantBoxToDisable.enabled = false;
                radish2plantBoxToDisable.enabled = false;
            }

            if (rgMain.currentGameStage == 3)
            {
                textPanalStage3.SetActive(true);
                playerCamera.enabled = false;
                currentStage3TreeText = 1;
                robCont.NewNavmeshStop();
                rgMain.MoveCameraToLima1Position();
                robCont.enabled = false;
                robotNavMeshAgentToStop.GetComponent<NavMeshAgent>().isStopped = true;

                Debug.Log("Mouse Clicked");
                susan1plantBoxToDisable.enabled = false;
                susan2plantBoxToDisable.enabled = false;
                limaBean2plantBoxToDisable.enabled = false;
                daisy1plantBoxToDisable.enabled = false;
                daisy2plantBoxToDisable.enabled = false;
                radish1plantBoxToDisable.enabled = false;
                radish2plantBoxToDisable.enabled = false;
            }
            if (rgMain.currentGameStage == 4)
            {
                textPanalStage4.SetActive(true);
                playerCamera.enabled = false;
                currentStage4TreeText = 1;
                robCont.NewNavmeshStop();
                rgMain.MoveCameraToLima1Position();
                robCont.enabled = false;
                robotNavMeshAgentToStop.GetComponent<NavMeshAgent>().isStopped = true;

                Debug.Log("Mouse Clicked");
                susan1plantBoxToDisable.enabled = false;
                susan2plantBoxToDisable.enabled = false;
                limaBean2plantBoxToDisable.enabled = false;
                daisy1plantBoxToDisable.enabled = false;
                daisy2plantBoxToDisable.enabled = false;
                radish1plantBoxToDisable.enabled = false;
                radish2plantBoxToDisable.enabled = false;
            }

            if (rgMain.currentGameStage == 5)
            {
                textPanalStage5.SetActive(true);
                currentStage5TreeText = 1;
                playerCamera.enabled = false;
                robCont.NewNavmeshStop();
                rgMain.MoveCameraToLima1Position();
                robCont.enabled = false;
                robotNavMeshAgentToStop.GetComponent<NavMeshAgent>().isStopped = true;
                removeSeedsStage5.gameObject.SetActive(true);
                Debug.Log("Mouse Clicked");
                susan1plantBoxToDisable.enabled = false;
                susan2plantBoxToDisable.enabled = false;
                limaBean2plantBoxToDisable.enabled = false;
                daisy1plantBoxToDisable.enabled = false;
                daisy2plantBoxToDisable.enabled = false;
                radish1plantBoxToDisable.enabled = false;
                radish2plantBoxToDisable.enabled = false;
            }
        }


        public void ReturnToPlayerCamFromTree()
        {
            playerCamera.enabled = true;
            rgMain.HideCamera();
            textPanal.SetActive(false);
            textPanalStage3.SetActive(false);
            textPanalStage4.SetActive(false);
            robCont.enabled = true;
            amountOFGuesses = 3;
            playerAlreadyGuessedIncorrectStage4 = false;
            robotNavMeshAgentToStop.GetComponent<NavMeshAgent>().isStopped = false;
        }

        public void ReturnToPlayerCamFromTreeFinal()
        {
            //  returnToPlayerCam.gameObject.SetActive(false);
            playerCamera.enabled = true;
            rgMain.HideCamera();
            textPanalStage5.SetActive(false);
            robCont.enabled = true;
            removeSeedsStage5.gameObject.SetActive(false);
            robotNavMeshAgentToStop.GetComponent<NavMeshAgent>().isStopped = false;
            limaToDisable.gameObject.SetActive(false);
            // stage5TextMan.currentStageOfText = 19;

        }
        public void WaterAllPlants()
        {
            Debug.Log("Water all plants");
            //  robCont.NewNavmeshStop();
            if (!plantswateredAlready)
            {
                Debug.Log("Water all plants Executed");
                waterSusan.SetTrigger("waterSusans");
             //   waterSusan2.SetTrigger("waterSusanTwo");
             //   waterLima.SetTrigger("waterLima1");
             //   waterLima2.SetTrigger("waterLima2");
             //   waterDaisy.SetTrigger("waterDaisy1");
             //   waterDaisy2.SetTrigger("waterDaisy2");
            //    waterRadish.SetTrigger("waterRadish");
             //   waterRadish2.SetTrigger("waterRadish2");
                //   robCont.enabled = true;
                rgMain.amountofPlantsWateredStage2 = 8;
                robCont.NewNavmeshStop();
              

                waterSeedsStage1.gameObject.SetActive(false);
                waterSeedsStage1.enabled = false;

                susanArrowToDisable.gameObject.SetActive(false);
                susan2ArrowToDisable.gameObject.SetActive(false);
                limaArrowToDisable.gameObject.SetActive(false);
                lima2ArrowToDisable.gameObject.SetActive(false);
                daisyArrowToDisable.gameObject.SetActive(false);
                daisy2ArrowToDisable.gameObject.SetActive(false);
                radishArrowToDisable.gameObject.SetActive(false);
                radish2ArrowToDisable.gameObject.SetActive(false);



                susanArrowToChangeColour.material = wateredColour;
                susan2ArrowToChangeColour.material = wateredColour;
                limaArrowToChangeColour.material = wateredColour;
                lima2ArrowToChangeColour.material = wateredColour;
                daisyArrowToChangeColour.material = wateredColour;
                daisy2ArrowToChangeColour.material = wateredColour;
                radishArrowToChangeColour.material = wateredColour;
                radish2ArrowToChangeColour.material = wateredColour;

                limaBean1plantBoxToDisable.enabled = false;

                waterSFX.Play();


                rgMain.stage2AllSeedWateredStage2 = true;
                rgMain.SaveStagePlantsWatered();
                ReturnToPlayerCamFromTree();
                Debug.Log("Water all plants Coplete");
                plantswateredAlready = true;
            }
        }

        void OnClick()
        {
            currentStage2TreeText++;
            textBeenRead = false;
            progressTextIsShowing = false;
            robCont.NewNavmeshStop();
        }

        void OnClickBack()
        {
            currentStage2TreeText--;
            robCont.NewNavmeshStop();
        }

        public void ProgressToEndText()
        {
            currentStage2TreeText = 5;
            robCont.NewNavmeshStop();
        }

        public void ProgressToWrongGuess()
        {
            currentStage2TreeText = 7;
            robCont.NewNavmeshStop();
        }

        public IEnumerator ShowIncorrectGuess()
        {
            wrongGuess1.onClick.RemoveListener(ProgressToWrongGuess);
            wrongGuess2.onClick.RemoveListener(ProgressToWrongGuess);
            wrongGuess3.onClick.RemoveListener(ProgressToWrongGuess);
            wrongGuess4.onClick.RemoveListener(ProgressToWrongGuess);
            wrongGuess5.onClick.RemoveListener(ProgressToWrongGuess);
            wrongGuess6.onClick.RemoveListener(ProgressToWrongGuess);
            wrongGuess7.onClick.RemoveListener(ProgressToWrongGuess);
            wrongGuess8.onClick.RemoveListener(ProgressToWrongGuess);
            wrongGuess9.onClick.RemoveListener(ProgressToWrongGuess);
            yield return new WaitForSeconds(3.5f);
            currentStage2TreeText = 6;
            ReturnToPlayerCamFromTree();
            limaBean1plantBoxToDisable.gameObject.SetActive(false);
            robCont.NewNavmeshStop();

            susan1plantBoxToDisable.enabled = true;
            susan2plantBoxToDisable.enabled = true;
            limaBean2plantBoxToDisable.enabled = true;
            daisy1plantBoxToDisable.enabled = true;
            daisy2plantBoxToDisable.enabled = true;
            radish1plantBoxToDisable.enabled = true;
            radish2plantBoxToDisable.enabled = true;
            rgStage2PR.amountOfFails++;
        }

        public IEnumerator ShowIncorrectGuessStage3()
        {
            yield return new WaitForSeconds(3.5f);
            currentStage3TreeText = 6;
            ReturnToPlayerCamFromTree();
            limaBean1plantBoxToDisable.gameObject.SetActive(false);
            robCont.NewNavmeshStop();
            susan1plantBoxToDisable.enabled = true;
            susan2plantBoxToDisable.enabled = true;
            limaBean2plantBoxToDisable.enabled = true;
            daisy1plantBoxToDisable.enabled = true;
            daisy2plantBoxToDisable.enabled = true;
            radish1plantBoxToDisable.enabled = true;
            radish2plantBoxToDisable.enabled = true;
            rgStage2PR.amountOfFailsStage3++;
        }
        public IEnumerator ShowIncorrectGuessStage4()
        {
            yield return new WaitForSeconds(3.5f);
            currentStage4TreeText = 6;
            ReturnToPlayerCamFromTree();
            limaBean1plantBoxToDisable.gameObject.SetActive(false);
            robCont.NewNavmeshStop();
            susan1plantBoxToDisable.enabled = true;
            susan2plantBoxToDisable.enabled = true;
            limaBean2plantBoxToDisable.enabled = true;
            daisy1plantBoxToDisable.enabled = true;
            daisy2plantBoxToDisable.enabled = true;
            radish1plantBoxToDisable.enabled = true;
            radish2plantBoxToDisable.enabled = true;
            rgStage2PR.amountOfFailsStage4++;
        }

        void JobotStage2Plant1Asses()
        {
            LOLSDK.Instance.SpeakText("jobotStage2PlantWaterAssesmentText");
        }

        void JobotStage2Plant1Asses2()
        {
            LOLSDK.Instance.SpeakText("jobotStage2PlantWaterAssesmentText1");
        }

        void JobotStage2Plant1Asses3()
        {
            LOLSDK.Instance.SpeakText("jobotStage2PlantWaterAssesmentText2");
        }
        void JobotStage2Plant1Asses4()
        {
            LOLSDK.Instance.SpeakText("jobotStage2PlantWaterAssesmentText3");
        }

        void JobotStage2Plant1Asses5()
        {
            LOLSDK.Instance.SpeakText("jobotStage2PlantWaterAssesmentCorrectText");
        }

        void JobotStage2Plant1Asses6()
        {
            LOLSDK.Instance.SpeakText("jobotStage2PlantSeedExamineWaterplantWrong");
        }


        public void StartTextProcessStage1()
        {
            currentStage2TreeText = 1;
        }

        public IEnumerator DelayProgressButton()
        {
            yield return new WaitForSeconds(3);
            progressText.gameObject.SetActive(true);
            textBeenRead = true;

        }

        public IEnumerator DelayProgressButtonVar2()
        {
            yield return new WaitForSeconds(2);
            progressText.gameObject.SetActive(true);
            textBeenRead = true;

        }

        public IEnumerator DelayProgressButtonVar1()
        {
            yield return new WaitForSeconds(1);
            progressText.gameObject.SetActive(true);
            textBeenRead = true;

        }


        //stage 3 stuff


        public IEnumerator DelayProgressButtoNStage3()
        {
            yield return new WaitForSeconds(1);
            progressTextStage3.gameObject.SetActive(true);
            textBeenReadStage3 = true;

        }

        public IEnumerator DelayProgressButtonVar2Stage3()
        {
            yield return new WaitForSeconds(1);
            progressTextStage3.gameObject.SetActive(true);
            textBeenReadStage3 = true;

        }

        public IEnumerator DelayProgressButtonVar1Stage3()
        {
            yield return new WaitForSeconds(1);
            progressTextStage3.gameObject.SetActive(true);
            textBeenReadStage3 = true;

        }


        //stage 4 stuff


        public IEnumerator DelayProgressButtoNStage4()
        {
            yield return new WaitForSeconds(1);
            progressTextStage4.gameObject.SetActive(true);
            textBeenReadStage4 = true;

        }

        public IEnumerator DelayProgressButtonVar2Stage4()
        {
            yield return new WaitForSeconds(1);
            progressTextStage4.gameObject.SetActive(true);
            textBeenReadStage4 = true;

        }

        public IEnumerator DelayProgressButtonVar1Stage4()
        {
            yield return new WaitForSeconds(1);
            progressTextStage4.gameObject.SetActive(true);
            textBeenReadStage4 = true;

        }
        public void WaterAllPlantsStage3()
        {
            Debug.Log("Water all plants");
            //  robCont.NewNavmeshStop();
            if (!plantswateredAlreadyStage3)
            {
                Debug.Log("Water all plants Executed");
                waterSusan.SetTrigger("waterSusans");
             //   waterSusan2.SetTrigger("waterSusanTwo");
             //   waterLima.SetTrigger("waterLima1");
           //     waterLima2.SetTrigger("waterLima2");
           //     waterDaisy.SetTrigger("waterDaisy1");
            //    waterDaisy2.SetTrigger("waterDaisy2");
            //    waterRadish.SetTrigger("waterRadish");
           //     waterRadish2.SetTrigger("waterRadish2");
                //   robCont.enabled = true;
                rgMain.amountofPlantsWateredStage3 = 8;
                robCont.NewNavmeshStop();
               
                waterSeedsStage3.gameObject.SetActive(false);
                waterSeedsStage3.enabled = false;

                susanArrowToDisable.gameObject.SetActive(false);
                susan2ArrowToDisable.gameObject.SetActive(false);
                limaArrowToDisable.gameObject.SetActive(false);
                lima2ArrowToDisable.gameObject.SetActive(false);
                daisyArrowToDisable.gameObject.SetActive(false);
                daisy2ArrowToDisable.gameObject.SetActive(false);
                radishArrowToDisable.gameObject.SetActive(false);
                radish2ArrowToDisable.gameObject.SetActive(false);



                susanArrowToChangeColour.material = wateredColour;
                susan2ArrowToChangeColour.material = wateredColour;
                limaArrowToChangeColour.material = wateredColour;
                lima2ArrowToChangeColour.material = wateredColour;
                daisyArrowToChangeColour.material = wateredColour;
                daisy2ArrowToChangeColour.material = wateredColour;
                radishArrowToChangeColour.material = wateredColour;
                radish2ArrowToChangeColour.material = wateredColour;

                susan1plantBoxToDisable.enabled = false;
                susan2plantBoxToDisable.enabled = false;
                limaBean1plantBoxToDisable.enabled = false;
                limaBean2plantBoxToDisable.enabled = false;
                daisy1plantBoxToDisable.enabled = false;
                daisy2plantBoxToDisable.enabled = false;
                radish1plantBoxToDisable.enabled = false;
                radish2plantBoxToDisable.enabled = false;

                waterSFX.Play();


                rgMain.stage3FlowersWatered = true;
                rgMain.SaveStage3FLowersWatered();
                ReturnToPlayerCamFromTree();
                plantswateredAlreadyStage3 = true;

                Debug.Log("Water all plants Coplete");
            }
        }

        public void WaterAllPlantsStage4()
        {
            Debug.Log("Water all plants");
            //  robCont.NewNavmeshStop();
            if (!plantswateredAlreadyStage4)
            {
                Debug.Log("Water all plants Executed");
                waterSusan.SetTrigger("waterSusans");
            //    waterSusan2.SetTrigger("waterSusanTwo");
          //      waterLima.SetTrigger("waterLima1");
           //     waterLima2.SetTrigger("waterLima2");
          //      waterDaisy.SetTrigger("waterDaisy1");
         //       waterDaisy2.SetTrigger("waterDaisy2");
         //       waterRadish.SetTrigger("waterRadish");
         //       waterRadish2.SetTrigger("waterRadish2");
                //   robCont.enabled = true;
                rgMain.amountOfStage4FlowersWatered = 8;
                robCont.NewNavmeshStop();
              

                waterSeedsStage4.gameObject.SetActive(false);
                waterSeedsStage4.enabled = false;

                susanArrowToDisable.gameObject.SetActive(false);
                susan2ArrowToDisable.gameObject.SetActive(false);
                limaArrowToDisable.gameObject.SetActive(false);
                lima2ArrowToDisable.gameObject.SetActive(false);
                daisyArrowToDisable.gameObject.SetActive(false);
                daisy2ArrowToDisable.gameObject.SetActive(false);
                radishArrowToDisable.gameObject.SetActive(false);
                radish2ArrowToDisable.gameObject.SetActive(false);



                susanArrowToChangeColour.material = wateredColour;
                susan2ArrowToChangeColour.material = wateredColour;
                limaArrowToChangeColour.material = wateredColour;
                lima2ArrowToChangeColour.material = wateredColour;
                daisyArrowToChangeColour.material = wateredColour;
                daisy2ArrowToChangeColour.material = wateredColour;
                radishArrowToChangeColour.material = wateredColour;
                radish2ArrowToChangeColour.material = wateredColour;

                susan1plantBoxToDisable.enabled = false;
                susan2plantBoxToDisable.enabled = false;
                limaBean1plantBoxToDisable.enabled = false;
                limaBean2plantBoxToDisable.enabled = false;
                daisy1plantBoxToDisable.enabled = false;
                daisy2plantBoxToDisable.enabled = false;
                radish1plantBoxToDisable.enabled = false;
                radish2plantBoxToDisable.enabled = false;

                waterSFX.Play();


                rgMain.stage4FlowersWatered = true;
                rgMain.SaveStage4FlowersWatered();
                ReturnToPlayerCamFromTree();
                Debug.Log("Water all plants Coplete");
                plantswateredAlreadyStage4 = true;
            }
        }

        void OnClickStage3()
        {
            currentStage3TreeText++;
            textBeenReadStage3 = false;
            progressTextIsShowingStage3 = false;
            robCont.NewNavmeshStop();
        }

        void OnClickBackStage3()
        {
            currentStage3TreeText--;
            robCont.NewNavmeshStop();
        }

        void OnClickStage4()
        {
            currentStage4TreeText++;
            textBeenReadStage4= false;
            progressTextIsShowingStage4 = false;
            robCont.NewNavmeshStop();
        }

        void OnClickBackStage4()
        {
            currentStage4TreeText--;
            robCont.NewNavmeshStop();
        }


        public void CorrectGuessLetterL()
        {
            correctLetterToShow1L.gameObject.SetActive(true);
            letterLCorrect = true;
            cheerSFX.Play();
        }

        public void CorrectGuessLetterA()
        {
            correctLetterToShow2A.gameObject.SetActive(true);
            letterACorrect = true;
            cheerSFX.Play();
        }

        public void CorrectGuessLetterR()
        {
            correctLetterToShow3R.gameObject.SetActive(true);
            correctLetterToShow6R.gameObject.SetActive(true);
            letterRCorrect = true;
            cheerSFX.Play();
        }

        public void CorrectGuessLetterG()
        {
            correctLetterToShow4G.gameObject.SetActive(true);
            letterGCorrect = true;
            cheerSFX.Play();
        }

        public void CorrectGuessLetterE()
        {
            correctLetterToShow5E.gameObject.SetActive(true);
            letterECorrect = true;
            cheerSFX.Play();
        }
        public void InCorrectGuessLetter1()
        {
            amountOFGuesses = amountOFGuesses - 1;
        }




        void JobotStage3Plant1Asses()
        {
            LOLSDK.Instance.SpeakText("jobotStage3PlantWaterAssesmentText");
        }

        void JobotStage3Plant1Asses2()
        {
            LOLSDK.Instance.SpeakText("jobotStage3PlantWaterAssesmentText1");
        }

        void JobotStage3Plant1Asses3()
        {
            LOLSDK.Instance.SpeakText("jobotStage3PlantWaterAssesmentText2");
        }
        void JobotStage3Plant1Asses4()
        {
            LOLSDK.Instance.SpeakText("jobotStage3PlantWaterAssesmentTextClue");
        }

        void JobotStage3Plant1Asses5()
        {
            LOLSDK.Instance.SpeakText("jobotStage2PlantWaterAssesmentCorrectText");
        }

        void JobotStage3Plant1Asses6()
        {
            LOLSDK.Instance.SpeakText("jobotStage3PlantWaterAssesmentLeavesGone");
        }

        //stage 4 functions

        public void CorrectAnswer()
        {
            currentStage4TreeText = 4;
        }

        public void IncorrectAnswer()
        {
            currentStage4TreeText = 5;
        }

        void JobotStage4Plant1Asses()
        {
            LOLSDK.Instance.SpeakText("jobotStage4WaterPlantsAsessement");
        }

        void JobotStage4Plant1Asses2()
        {
            LOLSDK.Instance.SpeakText("jobotStage4WaterPlantsAsessement1");
        }

        void JobotStage4Plant1Asses3()
        {
            LOLSDK.Instance.SpeakText("jobotStage4WaterPlantsAsessement2");
        }
        void JobotStage4Plant1Asses4()
        {
            LOLSDK.Instance.SpeakText("jobotStage4WaterPlantsAsessement3Correct");
        }

        void JobotStage4Plant1Asses5()
        {
            LOLSDK.Instance.SpeakText("jobotStage4WaterPlantsAsessement3Incorrect");
        }


        public void PickFinalSeeds()
        {
            if (!saveOnceFinal)
            {
                Debug.Log("Water all plants Executed");
                //   robCont.enabled = true;
                rgMain.amountOfRemovedFlowersStage5 = 8;
                robCont.NewNavmeshStop();
                flowerCam.enabled = false;
                flowerCam.gameObject.SetActive(false);
                plantRemovalAlreadyStage5 = true;
                currentStage5TreeText = 0;
                // stage5TextMan.gameObject.SetActive(true);
                stage5IntroPanal.SetActive(true);
                stage5TextMan.currentStageOfText = 19;
                textPanalStage5.SetActive(false);
               
                //removeSeedsStage5.gameObject.SetActive(false);
                removeSeedsStage5.enabled = false;

                /*
                                susanArrowToDisable.gameObject.SetActive(false);
                                susan2ArrowToDisable.gameObject.SetActive(false);
                                limaArrowToDisable.gameObject.SetActive(false);
                                lima2ArrowToDisable.gameObject.SetActive(false);
                                daisyArrowToDisable.gameObject.SetActive(false);
                                daisy2ArrowToDisable.gameObject.SetActive(false);
                                radishArrowToDisable.gameObject.SetActive(false);
                                radish2ArrowToDisable.gameObject.SetActive(false);
                */
                rgMain.stage5FlowersRemoved = true;
                rgMain.SaveStage5FlowersRemoved();
                ReturnToPlayerCamFromTreeFinal();
                Debug.Log("Water all plants Coplete");
                saveOnceFinal = true;
            }
           
        }

        void JobotStage5Plant1Asses2()
        {
            LOLSDK.Instance.SpeakText("jobotStage5PlantAsses5");
        }


    }
}
