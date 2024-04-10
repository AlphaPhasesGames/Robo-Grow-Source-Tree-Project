using UnityEngine;
using UnityEngine.AI;

namespace Alpha.Phases.Robo.Grow
{
    public class RoboGrowStartBGMGStage4 : MonoBehaviour
    {


        public RobotController robCont;
        public GameObject robotNavMeshAgentToStop;
        public RoboGrowMain rgMain;
        public ButterFlyPlayerController rgBFCont;
        public RoboGrowStage4ButterflyMG rgBFTextCont;
        public GameObject pondArrow;
        public Camera playerCamera;
        public Camera butterFlyCam;
        public MeshRenderer arrowMeshToHide;
        public GameObject robotCharacter;
        public GameObject butterflyCharacter;

        public GameObject fakeButterfly1;
        public GameObject fakeButterfly2;
        public GameObject fakeButterfly3;
        public GameObject targetButterfly1;

        public GameObject susanArrowToReset;
        public GameObject susan2ArrowToReset;
        public GameObject limaArrowToReset;
        public GameObject lima2ArrowToReset;
        public GameObject daisyArrowToReset;
        public GameObject daisy2ArrowToReset;
        public GameObject radishArrowToReset;
        public GameObject radish2ArrowToReset;

        public BoxCollider susanArrowBoxToReset;
        public BoxCollider susan2ArrowBoxToReset;
        public BoxCollider limaArrowBoxToReset;
        public BoxCollider lima2ArrowBoxToReset;
        public BoxCollider daisyArrowBoxToReset;
        public BoxCollider daisy2ArrowBoxToReset;
        public BoxCollider radishArrowBoxToReset;
        public BoxCollider radish2ArrowBoxToReset;
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
            robCont.NewNavmeshStop();
            if (rgMain.currentGameStage == 4)
            {
                robotNavMeshAgentToStop.GetComponent<NavMeshAgent>().isStopped = true;
                rgBFTextCont.currentStage4BFText = 1;
                robCont.enabled = false;
                pondArrow.gameObject.SetActive(false);
                susanArrowBoxToReset.gameObject.SetActive(false);
                susan2ArrowBoxToReset.gameObject.SetActive(false);
                limaArrowBoxToReset.gameObject.SetActive(false);
                lima2ArrowBoxToReset.gameObject.SetActive(false);
                daisyArrowBoxToReset.gameObject.SetActive(false);
                daisy2ArrowBoxToReset.gameObject.SetActive(false);
                radishArrowBoxToReset.gameObject.SetActive(false);
                radish2ArrowBoxToReset.gameObject.SetActive(false);
                arrowMeshToHide.enabled = false;
                susanArrowBoxToReset.enabled = false;
                susan2ArrowBoxToReset.enabled = false;
                limaArrowBoxToReset.enabled = false;
                lima2ArrowBoxToReset.enabled = false;
                daisyArrowBoxToReset.enabled = false;
                daisy2ArrowBoxToReset.enabled = false;
                radishArrowBoxToReset.enabled = false;
                radish2ArrowBoxToReset.enabled = false;
            }
        }
    }
}
