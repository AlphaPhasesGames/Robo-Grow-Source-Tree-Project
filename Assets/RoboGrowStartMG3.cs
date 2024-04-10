using UnityEngine;
using UnityEngine.AI;
using LoLSDK;
namespace Alpha.Phases.Robo.Grow
{
    public class RoboGrowStartMG3 : MonoBehaviour
    {
        public RoboGrowStartMinigame3 rgStartMini3;
        public RoboGrowMain rgMain;
        public RobotController robCont;
        public Camera playerCamera;
        public Camera butterflyCamera;
        public GameObject minigamepanal;
        public GameObject butterFlyCharacter;
        public GameObject robotNavMeshAgentToStop;
        public AudioSource wingFlapSFX;
        public MeshRenderer arrowMeshToHide;
        public GameObject susanArrowToReset;
        public GameObject susan2ArrowToReset;
        public GameObject limaArrowToReset;
        public GameObject lima2ArrowToReset;
        public GameObject daisyArrowToReset;
        public GameObject daisy2ArrowToReset;
        public GameObject radishArrowToReset;
        public GameObject radish2ArrowToReset;

        public GameObject susanPollenIndicatorArrows;
        public GameObject limaPollenIndicatorArrows;
        public GameObject daisyPollenIndicatorArrows;
        public GameObject radishPollenIndicatorArrows;

      
        // Start is called before the first frame update
        void Start()
        {
         
        }

        // Update is called once per frame
        void Update()
        {

        }

        void OnMouseDown()
        {
            if (rgMain.currentGameStage == 3)
            {
               rgStartMini3.currentStage3TreeText = 1;
                wingFlapSFX.Play();
                robCont.NewNavmeshStop();
                playerCamera.enabled = false;
                butterflyCamera.enabled = true;
                butterFlyCharacter.gameObject.SetActive(true);
                robCont.enabled = false;
                minigamepanal.gameObject.SetActive(true);
                arrowMeshToHide.enabled = false;
                //treeTriggerArrow.gameObject.SetActive(false);
                robotNavMeshAgentToStop.GetComponent<NavMeshAgent>().isStopped = true;
                susanArrowToReset.gameObject.SetActive(false);
                susan2ArrowToReset.gameObject.SetActive(false);
                limaArrowToReset.gameObject.SetActive(false);
                lima2ArrowToReset.gameObject.SetActive(false);
                daisyArrowToReset.gameObject.SetActive(false);
                daisy2ArrowToReset.gameObject.SetActive(false);
                radish2ArrowToReset.gameObject.SetActive(false);
                radishArrowToReset.gameObject.SetActive(false);

                susanPollenIndicatorArrows.gameObject.SetActive(true);
                limaPollenIndicatorArrows.gameObject.SetActive(true);
                daisyPollenIndicatorArrows.gameObject.SetActive(true);
                radishPollenIndicatorArrows.gameObject.SetActive(true);

            }


        }
    }
}
