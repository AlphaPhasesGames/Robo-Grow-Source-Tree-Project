using System.Collections;
using UnityEngine;
using LoLSDK;
using UnityEngine.UI;
using UnityEngine.AI;
using TMPro;

namespace Alpha.Phases.Robo.Grow
{
    public class RoboGrowStage5MiniGame2Tree : MonoBehaviour
    {
        public RobotController robCont;
        public RoboGrowMain rgMain;
        public ButterFlyPlayerController rgBFCont;
        public GameObject robotNavMeshAgentToStop;
        public Camera playerCamera;
        public Camera butterFlyCam;
       // public GameObject frogArrowToAppear;
        public Camera butterFlyAnimationCharachterCam;

        public GameObject robotCharacter;
        public GameObject butterflyCharacter;
        public GameObject butterFlyAnimationCharachterPlayer;
        public GameObject missionArrowTodisable;

        public GameObject levelItems;

        public GameObject targetButterfly1;

        public bool textBeenRead;
        public bool progressTextIsShowing;

        public GameObject susanArrowToReset;
        public GameObject susan2ArrowToReset;
        public GameObject limaArrowToReset;
        public GameObject lima2ArrowToReset;
        public GameObject daisyArrowToReset;
        public GameObject daisy2ArrowToReset;
        public GameObject radishArrowToReset;
        public GameObject radish2ArrowToReset;

        public bool hasSavingHappenBefore;
        public GameObject textPanal;
        public Button TTSJobotStage5Tree1;
        public Button TTSJobotStage5Tree1a;
        public Button TTSJobotStage5Tree1b;
        public Button TTSJobotStage5Tree1c;
        public Button TTSJobotStage5Tree1d;
        public Button TTSJobotStage5Tree1e;
        public Button TTSJobotStage5Tree1f;
        public Button TTSJobotStage5Tree1WellDone;
        public Button TTSJobotStage5Tree1g;
        public Button TTSJobotStage5Tree1h;
        public Button TTSJobotStage5Tree1i;
        public Button TTSJobotStage5Tree1j;
        public Button TTSJobotStage5Tree1k;

        public TextMeshProUGUI jobotIntroStage5Tree;
        public TextMeshProUGUI jobotIntroStage5Tree1a;
        public TextMeshProUGUI jobotIntroStage5Tree1b;
        public TextMeshProUGUI jobotIntroStage5Tree1c;
        public TextMeshProUGUI jobotIntroStage5Tree1d;
        public TextMeshProUGUI jobotIntroStage5Tree1e;
        public TextMeshProUGUI jobotIntroStage5Tree1f;
        public TextMeshProUGUI jobotIntroStage5Tree1WellDone;
        public TextMeshProUGUI jobotIntroStage5Tree1g;
        public TextMeshProUGUI jobotIntroStage5Tree1h;
        public TextMeshProUGUI jobotIntroStage5Tree1i;
        public TextMeshProUGUI jobotIntroStage5Tree1j;
        public TextMeshProUGUI jobotIntroStage5Tree1k;

        public Button progressText;
        public Button progressTextBack;

        public int currentStage5TreeText;

        private void Awake()
        {
            currentStage5TreeText = 0;
            progressText.onClick.AddListener(OnClick);
            progressTextBack.onClick.AddListener(OnClickBack);

            TTSJobotStage5Tree1.onClick.AddListener(JobotStage5Tree1);
            TTSJobotStage5Tree1a.onClick.AddListener(JobotStage5Tree2);
            TTSJobotStage5Tree1b.onClick.AddListener(JobotStage5Tree3);
            TTSJobotStage5Tree1c.onClick.AddListener(JobotStage5Tree4);
            TTSJobotStage5Tree1d.onClick.AddListener(JobotStage5Tree5);
            TTSJobotStage5Tree1e.onClick.AddListener(JobotStage5Tree6);
            TTSJobotStage5Tree1f.onClick.AddListener(JobotStage5Tree7);
            TTSJobotStage5Tree1WellDone.onClick.AddListener(JobotStage5TreeWellDone);
            TTSJobotStage5Tree1g.onClick.AddListener(JobotStage5Tree8);
            TTSJobotStage5Tree1h.onClick.AddListener(JobotStage5Tree9);
            TTSJobotStage5Tree1i.onClick.AddListener(JobotStage5Tree10);
            TTSJobotStage5Tree1j.onClick.AddListener(JobotStage5Tree11);
            TTSJobotStage5Tree1k.onClick.AddListener(JobotStage5Tree12);
        }

        // Start is called before the first frame update
        void Start()
        {

            textPanal.SetActive(false);
            jobotIntroStage5Tree.enabled = false;
            jobotIntroStage5Tree1a.enabled = false;
            jobotIntroStage5Tree1b.enabled = false;
            jobotIntroStage5Tree1c.enabled = false;
            jobotIntroStage5Tree1d.enabled = false;
            jobotIntroStage5Tree1e.enabled = false;
            jobotIntroStage5Tree1f.enabled = false;
            jobotIntroStage5Tree1g.enabled = false;
            jobotIntroStage5Tree1h.enabled = false;
            jobotIntroStage5Tree1i.enabled = false;
            jobotIntroStage5Tree1j.enabled = false;
            jobotIntroStage5Tree1k.enabled = false;


            TTSJobotStage5Tree1.gameObject.SetActive(false);
            TTSJobotStage5Tree1a.gameObject.SetActive(false);
            TTSJobotStage5Tree1b.gameObject.SetActive(false);
            TTSJobotStage5Tree1c.gameObject.SetActive(false);
            TTSJobotStage5Tree1d.gameObject.SetActive(false);
            TTSJobotStage5Tree1e.gameObject.SetActive(false);
            TTSJobotStage5Tree1f.gameObject.SetActive(false);
            TTSJobotStage5Tree1g.gameObject.SetActive(false);
            TTSJobotStage5Tree1h.gameObject.SetActive(false);
            TTSJobotStage5Tree1i.gameObject.SetActive(false);
            TTSJobotStage5Tree1.gameObject.SetActive(false);
            TTSJobotStage5Tree1.gameObject.SetActive(false);

            jobotIntroStage5Tree1WellDone.enabled = false;
            TTSJobotStage5Tree1WellDone.gameObject.SetActive(false);
        }

        // Update is called once per frame
        void Update()
        {
            if (currentStage5TreeText == 1)
            {
                if (!textBeenRead)
                {
                    progressText.gameObject.SetActive(false);
                }
                progressTextBack.gameObject.SetActive(false);
                robCont.enabled = false;
                playerCamera.enabled = false;
                butterflyCharacter.SetActive(true);
                butterFlyCam.enabled = true;
                rgBFCont.enabled = false;
                //frogArrowToAppear.gameObject.SetActive(false);
                levelItems.gameObject.SetActive(true);
                targetButterfly1.gameObject.SetActive(true);

                textPanal.SetActive(true);
                jobotIntroStage5Tree.enabled = true;
                jobotIntroStage5Tree1a.enabled = false;
                jobotIntroStage5Tree1b.enabled = false;
                jobotIntroStage5Tree1c.enabled = false;
                jobotIntroStage5Tree1d.enabled = false;
                jobotIntroStage5Tree1e.enabled = false;
                jobotIntroStage5Tree1f.enabled = false;
                jobotIntroStage5Tree1g.enabled = false;
                jobotIntroStage5Tree1h.enabled = false;
                jobotIntroStage5Tree1i.enabled = false;
                jobotIntroStage5Tree1j.enabled = false;
                jobotIntroStage5Tree1k.enabled = false;


                TTSJobotStage5Tree1.gameObject.SetActive(true);
                TTSJobotStage5Tree1a.gameObject.SetActive(false);
                TTSJobotStage5Tree1b.gameObject.SetActive(false);
                TTSJobotStage5Tree1c.gameObject.SetActive(false);
                TTSJobotStage5Tree1d.gameObject.SetActive(false);
                TTSJobotStage5Tree1e.gameObject.SetActive(false);
                TTSJobotStage5Tree1f.gameObject.SetActive(false);
                TTSJobotStage5Tree1g.gameObject.SetActive(false);
                TTSJobotStage5Tree1h.gameObject.SetActive(false);
                TTSJobotStage5Tree1i.gameObject.SetActive(false);
                TTSJobotStage5Tree1j.gameObject.SetActive(false);
                TTSJobotStage5Tree1k.gameObject.SetActive(false);

                jobotIntroStage5Tree1WellDone.enabled = false;
                TTSJobotStage5Tree1WellDone.gameObject.SetActive(false);

                if (!progressTextIsShowing)
                { // 3 second delay
                    StartCoroutine(DelayProgressButtonVar1());
                    progressTextIsShowing = true;
                }
            }

            if (currentStage5TreeText == 2)
            {
                if (!textBeenRead)
                {
                    progressText.gameObject.SetActive(false);
                }
                progressTextBack.gameObject.SetActive(true);
                jobotIntroStage5Tree.enabled = false;
                jobotIntroStage5Tree1a.enabled = true;
                jobotIntroStage5Tree1b.enabled = false;
                jobotIntroStage5Tree1c.enabled = false;
                jobotIntroStage5Tree1d.enabled = false;
                jobotIntroStage5Tree1e.enabled = false;
                jobotIntroStage5Tree1f.enabled = false;
                jobotIntroStage5Tree1g.enabled = false;
                jobotIntroStage5Tree1h.enabled = false;
                jobotIntroStage5Tree1i.enabled = false;
                jobotIntroStage5Tree1j.enabled = false;
                jobotIntroStage5Tree1k.enabled = false;


                TTSJobotStage5Tree1.gameObject.SetActive(false);
                TTSJobotStage5Tree1a.gameObject.SetActive(true);
                TTSJobotStage5Tree1b.gameObject.SetActive(false);
                TTSJobotStage5Tree1c.gameObject.SetActive(false);
                TTSJobotStage5Tree1d.gameObject.SetActive(false);
                TTSJobotStage5Tree1e.gameObject.SetActive(false);
                TTSJobotStage5Tree1f.gameObject.SetActive(false);
                TTSJobotStage5Tree1g.gameObject.SetActive(false);
                TTSJobotStage5Tree1h.gameObject.SetActive(false);
                TTSJobotStage5Tree1i.gameObject.SetActive(false);
                TTSJobotStage5Tree1j.gameObject.SetActive(false);
                TTSJobotStage5Tree1k.gameObject.SetActive(false);

                jobotIntroStage5Tree1WellDone.enabled = false;
                TTSJobotStage5Tree1WellDone.gameObject.SetActive(false);

                if (!progressTextIsShowing)
                { // 3 second delay
                    StartCoroutine(DelayProgressButtonVar1());
                    progressTextIsShowing = true;
                }

            }

            if (currentStage5TreeText == 3)
            {
                if (!textBeenRead)
                {
                    progressText.gameObject.SetActive(false);
                }
                jobotIntroStage5Tree.enabled = false;
                jobotIntroStage5Tree1a.enabled = false;
                jobotIntroStage5Tree1b.enabled = true;
                jobotIntroStage5Tree1c.enabled = false;
                jobotIntroStage5Tree1d.enabled = false;
                jobotIntroStage5Tree1e.enabled = false;
                jobotIntroStage5Tree1f.enabled = false;
                jobotIntroStage5Tree1g.enabled = false;
                jobotIntroStage5Tree1h.enabled = false;
                jobotIntroStage5Tree1i.enabled = false;
                jobotIntroStage5Tree1j.enabled = false;
                jobotIntroStage5Tree1k.enabled = false;

                jobotIntroStage5Tree1WellDone.enabled = false;
                TTSJobotStage5Tree1WellDone.gameObject.SetActive(false);

                TTSJobotStage5Tree1.gameObject.SetActive(false);
                TTSJobotStage5Tree1a.gameObject.SetActive(false);
                TTSJobotStage5Tree1b.gameObject.SetActive(true);
                TTSJobotStage5Tree1c.gameObject.SetActive(false);
                TTSJobotStage5Tree1d.gameObject.SetActive(false);
                TTSJobotStage5Tree1e.gameObject.SetActive(false);
                TTSJobotStage5Tree1f.gameObject.SetActive(false);
                TTSJobotStage5Tree1g.gameObject.SetActive(false);
                TTSJobotStage5Tree1h.gameObject.SetActive(false);
                TTSJobotStage5Tree1i.gameObject.SetActive(false);
                TTSJobotStage5Tree1j.gameObject.SetActive(false);
                TTSJobotStage5Tree1k.gameObject.SetActive(false);
                if (!progressTextIsShowing)
                { // 3 second delay
                    StartCoroutine(DelayProgressButtonVar1());
                    progressTextIsShowing = true;
                }
            }

            if (currentStage5TreeText == 4)
            {
                jobotIntroStage5Tree1WellDone.enabled = false;
                TTSJobotStage5Tree1WellDone.gameObject.SetActive(false);
                if (!textBeenRead)
                {
                    progressText.gameObject.SetActive(false);
                }
                jobotIntroStage5Tree.enabled = false;
                jobotIntroStage5Tree1a.enabled = false;
                jobotIntroStage5Tree1b.enabled = false;
                jobotIntroStage5Tree1c.enabled = true;
                jobotIntroStage5Tree1d.enabled = false;
                jobotIntroStage5Tree1e.enabled = false;
                jobotIntroStage5Tree1f.enabled = false;
                jobotIntroStage5Tree1g.enabled = false;
                jobotIntroStage5Tree1h.enabled = false;
                jobotIntroStage5Tree1i.enabled = false;
                jobotIntroStage5Tree1j.enabled = false;
                jobotIntroStage5Tree1k.enabled = false;

                jobotIntroStage5Tree1WellDone.enabled = false;
                TTSJobotStage5Tree1WellDone.gameObject.SetActive(false);

                TTSJobotStage5Tree1.gameObject.SetActive(false);
                TTSJobotStage5Tree1a.gameObject.SetActive(false);
                TTSJobotStage5Tree1b.gameObject.SetActive(false);
                TTSJobotStage5Tree1c.gameObject.SetActive(true);
                TTSJobotStage5Tree1d.gameObject.SetActive(false);
                TTSJobotStage5Tree1e.gameObject.SetActive(false);
                TTSJobotStage5Tree1f.gameObject.SetActive(false);
                TTSJobotStage5Tree1g.gameObject.SetActive(false);
                TTSJobotStage5Tree1h.gameObject.SetActive(false);
                TTSJobotStage5Tree1i.gameObject.SetActive(false);
                TTSJobotStage5Tree1j.gameObject.SetActive(false);
                TTSJobotStage5Tree1k.gameObject.SetActive(false);
                if (!progressTextIsShowing)
                { // 3 second delay
                    StartCoroutine(DelayProgressButtonVar1());
                    progressTextIsShowing = true;
                }
            }

            if (currentStage5TreeText == 5)
            {
                jobotIntroStage5Tree1WellDone.enabled = false;
                TTSJobotStage5Tree1WellDone.gameObject.SetActive(false);
                if (!textBeenRead)
                {
                    progressText.gameObject.SetActive(false);
                }
                jobotIntroStage5Tree.enabled = false;
                jobotIntroStage5Tree1a.enabled = false;
                jobotIntroStage5Tree1b.enabled = false;
                jobotIntroStage5Tree1c.enabled = false;
                jobotIntroStage5Tree1d.enabled = true;
                jobotIntroStage5Tree1e.enabled = false;
                jobotIntroStage5Tree1f.enabled = false;
                jobotIntroStage5Tree1g.enabled = false;
                jobotIntroStage5Tree1h.enabled = false;
                jobotIntroStage5Tree1i.enabled = false;
                jobotIntroStage5Tree1j.enabled = false;
                jobotIntroStage5Tree1k.enabled = false;

                jobotIntroStage5Tree1WellDone.enabled = false;
                TTSJobotStage5Tree1WellDone.gameObject.SetActive(false);

                TTSJobotStage5Tree1.gameObject.SetActive(false);
                TTSJobotStage5Tree1a.gameObject.SetActive(false);
                TTSJobotStage5Tree1b.gameObject.SetActive(false);
                TTSJobotStage5Tree1c.gameObject.SetActive(false);
                TTSJobotStage5Tree1d.gameObject.SetActive(true);
                TTSJobotStage5Tree1e.gameObject.SetActive(false);
                TTSJobotStage5Tree1f.gameObject.SetActive(false);
                TTSJobotStage5Tree1g.gameObject.SetActive(false);
                TTSJobotStage5Tree1h.gameObject.SetActive(false);
                TTSJobotStage5Tree1i.gameObject.SetActive(false);
                TTSJobotStage5Tree1j.gameObject.SetActive(false);
                TTSJobotStage5Tree1k.gameObject.SetActive(false);
                if (!progressTextIsShowing)
                { // 3 second delay
                    StartCoroutine(DelayProgressButtonVar2());
                    progressTextIsShowing = true;
                }


            }


            if (currentStage5TreeText == 6)
            {

                jobotIntroStage5Tree.enabled = false;
                jobotIntroStage5Tree1a.enabled = false;
                jobotIntroStage5Tree1b.enabled = false;
                jobotIntroStage5Tree1c.enabled = false;
                jobotIntroStage5Tree1d.enabled = false;
                jobotIntroStage5Tree1e.enabled = true;
                jobotIntroStage5Tree1f.enabled = false;
                jobotIntroStage5Tree1g.enabled = false;
                jobotIntroStage5Tree1h.enabled = false;
                jobotIntroStage5Tree1i.enabled = false;
                jobotIntroStage5Tree1j.enabled = false;
                jobotIntroStage5Tree1k.enabled = false;

                jobotIntroStage5Tree1WellDone.enabled = false;
                TTSJobotStage5Tree1WellDone.gameObject.SetActive(false);

                TTSJobotStage5Tree1.gameObject.SetActive(false);
                TTSJobotStage5Tree1a.gameObject.SetActive(false);
                TTSJobotStage5Tree1b.gameObject.SetActive(false);
                TTSJobotStage5Tree1c.gameObject.SetActive(false);
                TTSJobotStage5Tree1d.gameObject.SetActive(false);
                TTSJobotStage5Tree1e.gameObject.SetActive(true);
                TTSJobotStage5Tree1f.gameObject.SetActive(false);
                TTSJobotStage5Tree1g.gameObject.SetActive(false);
                TTSJobotStage5Tree1h.gameObject.SetActive(false);
                TTSJobotStage5Tree1i.gameObject.SetActive(false);
                TTSJobotStage5Tree1j.gameObject.SetActive(false);
                TTSJobotStage5Tree1k.gameObject.SetActive(false);

                rgBFCont.enabled = true;
                progressText.gameObject.SetActive(false);
               // StartCoroutine(CloseTextPanal());
            }

            if (currentStage5TreeText == 7)
            {
                textPanal.SetActive(true);
                jobotIntroStage5Tree.enabled = false;
                jobotIntroStage5Tree1a.enabled = false;
                jobotIntroStage5Tree1b.enabled = false;
                jobotIntroStage5Tree1c.enabled = false;
                jobotIntroStage5Tree1d.enabled = false;
                jobotIntroStage5Tree1e.enabled = false;
                jobotIntroStage5Tree1f.enabled = true;
                jobotIntroStage5Tree1g.enabled = false;
                jobotIntroStage5Tree1h.enabled = false;
                jobotIntroStage5Tree1i.enabled = false;
                jobotIntroStage5Tree1j.enabled = false;
                jobotIntroStage5Tree1k.enabled = false;

                jobotIntroStage5Tree1WellDone.enabled = false;
                TTSJobotStage5Tree1WellDone.gameObject.SetActive(false);

                TTSJobotStage5Tree1.gameObject.SetActive(false);
                TTSJobotStage5Tree1a.gameObject.SetActive(false);
                TTSJobotStage5Tree1b.gameObject.SetActive(false);
                TTSJobotStage5Tree1c.gameObject.SetActive(false);
                TTSJobotStage5Tree1d.gameObject.SetActive(false);
                TTSJobotStage5Tree1e.gameObject.SetActive(false);
                TTSJobotStage5Tree1f.gameObject.SetActive(true);
                TTSJobotStage5Tree1g.gameObject.SetActive(false);
                TTSJobotStage5Tree1h.gameObject.SetActive(false);
                TTSJobotStage5Tree1i.gameObject.SetActive(false);
                TTSJobotStage5Tree1j.gameObject.SetActive(false);
                TTSJobotStage5Tree1k.gameObject.SetActive(false);
                StartCoroutine(ShowQuestion());

            }


            if (currentStage5TreeText == 8)
            {
                if (!textBeenRead)
                {
                    progressText.gameObject.SetActive(false);
                }
                //levelItems.gameObject.SetActive(false);
                textPanal.SetActive(true);
                jobotIntroStage5Tree.enabled = false;
                jobotIntroStage5Tree1a.enabled = false;
                jobotIntroStage5Tree1b.enabled = false;
                jobotIntroStage5Tree1c.enabled = false;
                jobotIntroStage5Tree1d.enabled = false;
                jobotIntroStage5Tree1e.enabled = false;
                jobotIntroStage5Tree1f.enabled = false;
                jobotIntroStage5Tree1g.enabled = true;
                jobotIntroStage5Tree1h.enabled = false;
                jobotIntroStage5Tree1i.enabled = false;
                jobotIntroStage5Tree1j.enabled = false;
                jobotIntroStage5Tree1k.enabled = false;

                jobotIntroStage5Tree1WellDone.enabled = false;
                TTSJobotStage5Tree1WellDone.gameObject.SetActive(false);

                TTSJobotStage5Tree1.gameObject.SetActive(false);
                TTSJobotStage5Tree1a.gameObject.SetActive(false);
                TTSJobotStage5Tree1b.gameObject.SetActive(false);
                TTSJobotStage5Tree1c.gameObject.SetActive(false);
                TTSJobotStage5Tree1d.gameObject.SetActive(false);
                TTSJobotStage5Tree1e.gameObject.SetActive(false);
                TTSJobotStage5Tree1f.gameObject.SetActive(false);
                TTSJobotStage5Tree1g.gameObject.SetActive(true);
                TTSJobotStage5Tree1h.gameObject.SetActive(false);
                TTSJobotStage5Tree1i.gameObject.SetActive(false);
                TTSJobotStage5Tree1j.gameObject.SetActive(false);
                TTSJobotStage5Tree1k.gameObject.SetActive(false);
                progressText.gameObject.SetActive(true);
                if (!progressTextIsShowing)
                { // 3 second delay
                    StartCoroutine(DelayProgressButtonVar1());
                    progressTextIsShowing = true;
                }
                Debug.Log("Section 8 showed itself");
            }


            if (currentStage5TreeText == 9)
            {
                if (!textBeenRead)
                {
                    progressText.gameObject.SetActive(false);
                }
                jobotIntroStage5Tree.enabled = false;
                jobotIntroStage5Tree1a.enabled = false;
                jobotIntroStage5Tree1b.enabled = false;
                jobotIntroStage5Tree1c.enabled = false;
                jobotIntroStage5Tree1d.enabled = false;
                jobotIntroStage5Tree1e.enabled = false;
                jobotIntroStage5Tree1f.enabled = false;
                jobotIntroStage5Tree1g.enabled = false;
                jobotIntroStage5Tree1h.enabled = true;
                jobotIntroStage5Tree1i.enabled = false;
                jobotIntroStage5Tree1j.enabled = false;
                jobotIntroStage5Tree1k.enabled = false;

                jobotIntroStage5Tree1WellDone.enabled = false;
                TTSJobotStage5Tree1WellDone.gameObject.SetActive(false);

                TTSJobotStage5Tree1.gameObject.SetActive(false);
                TTSJobotStage5Tree1a.gameObject.SetActive(false);
                TTSJobotStage5Tree1b.gameObject.SetActive(false);
                TTSJobotStage5Tree1c.gameObject.SetActive(false);
                TTSJobotStage5Tree1d.gameObject.SetActive(false);
                TTSJobotStage5Tree1e.gameObject.SetActive(false);
                TTSJobotStage5Tree1f.gameObject.SetActive(false);
                TTSJobotStage5Tree1g.gameObject.SetActive(false);
                TTSJobotStage5Tree1h.gameObject.SetActive(true);
                TTSJobotStage5Tree1i.gameObject.SetActive(false);
                TTSJobotStage5Tree1j.gameObject.SetActive(false);
                TTSJobotStage5Tree1k.gameObject.SetActive(false);
                if (!progressTextIsShowing)
                { // 3 second delay
                    StartCoroutine(DelayProgressButtonVar2());
                    progressTextIsShowing = true;
                }
            }


            if (currentStage5TreeText == 10)
            {

                //  jobotIntroStage1e
                if (!textBeenRead)
                {
                    progressText.gameObject.SetActive(false);
                }
                jobotIntroStage5Tree.enabled = false;
                jobotIntroStage5Tree1a.enabled = false;
                jobotIntroStage5Tree1b.enabled = false;
                jobotIntroStage5Tree1c.enabled = false;
                jobotIntroStage5Tree1d.enabled = false;
                jobotIntroStage5Tree1e.enabled = false;
                jobotIntroStage5Tree1f.enabled = false;
                jobotIntroStage5Tree1g.enabled = false;
                jobotIntroStage5Tree1h.enabled = false;
                jobotIntroStage5Tree1i.enabled = true;
                jobotIntroStage5Tree1j.enabled = false;
                jobotIntroStage5Tree1k.enabled = false;

                jobotIntroStage5Tree1WellDone.enabled = false;
                TTSJobotStage5Tree1WellDone.gameObject.SetActive(false);

                TTSJobotStage5Tree1.gameObject.SetActive(false);
                TTSJobotStage5Tree1a.gameObject.SetActive(false);
                TTSJobotStage5Tree1b.gameObject.SetActive(false);
                TTSJobotStage5Tree1c.gameObject.SetActive(false);
                TTSJobotStage5Tree1d.gameObject.SetActive(false);
                TTSJobotStage5Tree1e.gameObject.SetActive(false);
                TTSJobotStage5Tree1f.gameObject.SetActive(false);
                TTSJobotStage5Tree1g.gameObject.SetActive(false);
                TTSJobotStage5Tree1h.gameObject.SetActive(false);
                TTSJobotStage5Tree1i.gameObject.SetActive(true);
                TTSJobotStage5Tree1j.gameObject.SetActive(false);
                TTSJobotStage5Tree1k.gameObject.SetActive(false);

                if (!progressTextIsShowing)
                { // 3 second delay
                    StartCoroutine(DelayProgressButtonVar2());
                    progressTextIsShowing = true;
                }

            }

            if (currentStage5TreeText == 11)
            {
                if (!textBeenRead)
                {
                    progressText.gameObject.SetActive(false);
                }
                jobotIntroStage5Tree.enabled = false;
                jobotIntroStage5Tree1a.enabled = false;
                jobotIntroStage5Tree1b.enabled = false;
                jobotIntroStage5Tree1c.enabled = false;
                jobotIntroStage5Tree1d.enabled = false;
                jobotIntroStage5Tree1e.enabled = false;
                jobotIntroStage5Tree1f.enabled = false;
                jobotIntroStage5Tree1g.enabled = false;
                jobotIntroStage5Tree1h.enabled = false;
                jobotIntroStage5Tree1i.enabled = false;
                jobotIntroStage5Tree1j.enabled = true;
                jobotIntroStage5Tree1k.enabled = false;

                jobotIntroStage5Tree1WellDone.enabled = false;
                TTSJobotStage5Tree1WellDone.gameObject.SetActive(false);

                TTSJobotStage5Tree1.gameObject.SetActive(false);
                TTSJobotStage5Tree1a.gameObject.SetActive(false);
                TTSJobotStage5Tree1b.gameObject.SetActive(false);
                TTSJobotStage5Tree1c.gameObject.SetActive(false);
                TTSJobotStage5Tree1d.gameObject.SetActive(false);
                TTSJobotStage5Tree1e.gameObject.SetActive(false);
                TTSJobotStage5Tree1f.gameObject.SetActive(false);
                TTSJobotStage5Tree1g.gameObject.SetActive(false);
                TTSJobotStage5Tree1h.gameObject.SetActive(false);
                TTSJobotStage5Tree1i.gameObject.SetActive(false);
                TTSJobotStage5Tree1j.gameObject.SetActive(true);
                TTSJobotStage5Tree1k.gameObject.SetActive(false);
                if (!progressTextIsShowing)
                { // 3 second delay
                    StartCoroutine(DelayProgressButtonVar2());
                    progressTextIsShowing = true;
                }

            }

            if (currentStage5TreeText == 12)
            {
                jobotIntroStage5Tree.enabled = false;
                jobotIntroStage5Tree1a.enabled = false;
                jobotIntroStage5Tree1b.enabled = false;
                jobotIntroStage5Tree1c.enabled = false;
                jobotIntroStage5Tree1d.enabled = false;
                jobotIntroStage5Tree1e.enabled = false;
                jobotIntroStage5Tree1f.enabled = false;
                jobotIntroStage5Tree1g.enabled = false;
                jobotIntroStage5Tree1h.enabled = false;
                jobotIntroStage5Tree1i.enabled = false;
                jobotIntroStage5Tree1j.enabled = false;
                jobotIntroStage5Tree1k.enabled = true;

                jobotIntroStage5Tree1WellDone.enabled = false;
                TTSJobotStage5Tree1WellDone.gameObject.SetActive(false);

                TTSJobotStage5Tree1.gameObject.SetActive(false);
                TTSJobotStage5Tree1a.gameObject.SetActive(false);
                TTSJobotStage5Tree1b.gameObject.SetActive(false);
                TTSJobotStage5Tree1c.gameObject.SetActive(false);
                TTSJobotStage5Tree1d.gameObject.SetActive(false);
                TTSJobotStage5Tree1e.gameObject.SetActive(false);
                TTSJobotStage5Tree1f.gameObject.SetActive(false);
                TTSJobotStage5Tree1g.gameObject.SetActive(false);
                TTSJobotStage5Tree1h.gameObject.SetActive(false);
                TTSJobotStage5Tree1i.gameObject.SetActive(false);
                TTSJobotStage5Tree1j.gameObject.SetActive(false);
                TTSJobotStage5Tree1k.gameObject.SetActive(true);

                progressText.gameObject.SetActive(false);
               
                playerCamera.enabled = true;
                butterflyCharacter.SetActive(false);
                butterFlyCam.enabled = false;
                butterFlyAnimationCharachterCam.enabled = false;
                targetButterfly1.gameObject.SetActive(false);
                butterFlyAnimationCharachterPlayer.gameObject.SetActive(false);
                rgBFCont.enabled = false;
                robCont.enabled = true;

                susanArrowToReset.gameObject.SetActive(true);
                susan2ArrowToReset.gameObject.SetActive(true);
                lima2ArrowToReset.gameObject.SetActive(true);
                limaArrowToReset.gameObject.SetActive(true);
                daisyArrowToReset.gameObject.SetActive(true);
                daisy2ArrowToReset.gameObject.SetActive(true);
                radishArrowToReset.gameObject.SetActive(true);
                radish2ArrowToReset.gameObject.SetActive(true);
                if (!hasSavingHappenBefore)
                {
                    rgMain.SaveStage5ButterlyMiniGameComplete();
                    rgMain.SavePlayerPos();
                    hasSavingHappenBefore = true;
                    StartCoroutine(CloseTextPanal());
                    missionArrowTodisable.gameObject.SetActive(false);
                    robotNavMeshAgentToStop.GetComponent<NavMeshAgent>().isStopped = false;
                }


            }



            if (currentStage5TreeText == 13)
            {
                textPanal.SetActive(false);
                jobotIntroStage5Tree.enabled = false;
                jobotIntroStage5Tree1a.enabled = false;
                jobotIntroStage5Tree1b.enabled = false;
                jobotIntroStage5Tree1c.enabled = false;
                jobotIntroStage5Tree1d.enabled = false;
                jobotIntroStage5Tree1e.enabled = false;
                jobotIntroStage5Tree1f.enabled = false;
                jobotIntroStage5Tree1g.enabled = false;
                jobotIntroStage5Tree1h.enabled = false;
                jobotIntroStage5Tree1i.enabled = false;
                jobotIntroStage5Tree1j.enabled = false;
                jobotIntroStage5Tree1k.enabled = false;


                TTSJobotStage5Tree1.gameObject.SetActive(false);
                TTSJobotStage5Tree1a.gameObject.SetActive(false);
                TTSJobotStage5Tree1b.gameObject.SetActive(false);
                TTSJobotStage5Tree1c.gameObject.SetActive(false);
                TTSJobotStage5Tree1d.gameObject.SetActive(false);
                TTSJobotStage5Tree1e.gameObject.SetActive(false);
                TTSJobotStage5Tree1f.gameObject.SetActive(false);
                TTSJobotStage5Tree1g.gameObject.SetActive(false);
                TTSJobotStage5Tree1h.gameObject.SetActive(false);
                TTSJobotStage5Tree1i.gameObject.SetActive(false);
                TTSJobotStage5Tree1j.gameObject.SetActive(false);
                TTSJobotStage5Tree1k.gameObject.SetActive(false);


            }

            if (currentStage5TreeText == 14)
            {
                textPanal.SetActive(true);
                jobotIntroStage5Tree.enabled = false;
                jobotIntroStage5Tree1a.enabled = false;
                jobotIntroStage5Tree1b.enabled = false;
                jobotIntroStage5Tree1c.enabled = false;
                jobotIntroStage5Tree1d.enabled = false;
                jobotIntroStage5Tree1e.enabled = false;
                jobotIntroStage5Tree1f.enabled = false;
                jobotIntroStage5Tree1g.enabled = false;
                jobotIntroStage5Tree1h.enabled = false;
                jobotIntroStage5Tree1i.enabled = false;
                jobotIntroStage5Tree1j.enabled = false;
                jobotIntroStage5Tree1k.enabled = false;

                jobotIntroStage5Tree1WellDone.enabled = true;
                TTSJobotStage5Tree1WellDone.gameObject.SetActive(true);

                TTSJobotStage5Tree1.gameObject.SetActive(false);
                TTSJobotStage5Tree1a.gameObject.SetActive(false);
                TTSJobotStage5Tree1b.gameObject.SetActive(false);
                TTSJobotStage5Tree1c.gameObject.SetActive(false);
                TTSJobotStage5Tree1d.gameObject.SetActive(false);
                TTSJobotStage5Tree1e.gameObject.SetActive(false);
                TTSJobotStage5Tree1f.gameObject.SetActive(false);
                TTSJobotStage5Tree1g.gameObject.SetActive(false);
                TTSJobotStage5Tree1h.gameObject.SetActive(false);
                TTSJobotStage5Tree1i.gameObject.SetActive(false);
                TTSJobotStage5Tree1j.gameObject.SetActive(false);
                TTSJobotStage5Tree1k.gameObject.SetActive(false);

                StartCoroutine(CloseTextPanal());
            }
        }



        void OnClick()
        {
            currentStage5TreeText++;
            textBeenRead = false;
            progressTextIsShowing = false;
        }

        void OnClickBack()
        {
            currentStage5TreeText--;
        }


        void JobotStage5Tree1()
        {
            LOLSDK.Instance.SpeakText("jobotStage5ButterflyMiniGame");
        }

        void JobotStage5Tree2()
        {
            LOLSDK.Instance.SpeakText("jobotStage5ButterflyMiniGamea");
        }

        void JobotStage5Tree3()
        {
            LOLSDK.Instance.SpeakText("jobotStage5ButterflyMiniGameb");
        }
        void JobotStage5Tree4()
        {
            LOLSDK.Instance.SpeakText("jobotStage5ButterflyMiniGamec");
        }

        void JobotStage5Tree5()
        {
            LOLSDK.Instance.SpeakText("jobotStage5ButterflyMiniGamed");
        }

        void JobotStage5Tree6()
        {
            LOLSDK.Instance.SpeakText("jobotStage5ButterflyMiniGamee");

        }

        void JobotStage5Tree7()
        {
            LOLSDK.Instance.SpeakText("jobotStage5ButterflyMiniGamef");
        }
        void JobotStage5TreeWellDone()
        {
            LOLSDK.Instance.SpeakText("jobotStage5ButterflyMiniGameWellDone");
        }

        void JobotStage5Tree8()
        {
            LOLSDK.Instance.SpeakText("jobotStage5ButterflyMiniGameg");
        }

        void JobotStage5Tree9()
        {
            LOLSDK.Instance.SpeakText("jobotStage5ButterflyMiniGameh");
        }

        void JobotStage5Tree10()
        {
            LOLSDK.Instance.SpeakText("jobotStage5ButterflyMiniGamei");

        }

        void JobotStage5Tree11()
        {
            LOLSDK.Instance.SpeakText("jobotStage5ButterflyMiniGamej");

        }

        void JobotStage5Tree12()
        {
            LOLSDK.Instance.SpeakText("jobotStage5ButterflyMiniGamek");

        }

        public IEnumerator CloseTextPanal()
        {
            yield return new WaitForSeconds(3);
            currentStage5TreeText = 13;

        }

        public IEnumerator ShowQuestion()
        {
            yield return new WaitForSeconds(2);
            currentStage5TreeText = 6;

        }


        public IEnumerator DelayProgressButton()
        {
            yield return new WaitForSeconds(4);
            progressText.gameObject.SetActive(true);
            textBeenRead = true;

        }

        public IEnumerator DelayProgressButtonVar2()
        {
            yield return new WaitForSeconds(3);
            progressText.gameObject.SetActive(true);
            textBeenRead = true;

        }

        public IEnumerator DelayProgressButtonVar1()
        {
            yield return new WaitForSeconds(2);
            progressText.gameObject.SetActive(true);
            textBeenRead = true;

        }

    }
}
