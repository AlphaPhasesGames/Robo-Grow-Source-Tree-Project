using UnityEngine;
using UnityEngine.AI;

namespace Alpha.Phases.Robo.Grow
{
    public class RoboGrowStage5FrogMGTrigger : MonoBehaviour
    {
        public RoboGrowMain rgMain;
        public RoboGrowStage5FrogMinigameStart rgStage5FrogMG;
        public RobotController robCont;
        public Camera playerCamera;
        public GameObject frogCharacter;
        public GameObject stageItems;

        public GameObject susanArrowToReset;
        public GameObject susan2ArrowToReset;
        public GameObject limaArrowToReset;
        public GameObject lima2ArrowToReset;
        public GameObject daisyArrowToReset;
        public GameObject daisy2ArrowToReset;
        public GameObject radishArrowToReset;
        public GameObject radish2ArrowToReset;

        public GameObject robotNavMeshAgentToStop;
        void OnMouseDown()
        {
            if (rgMain.currentGameStage == 5)
            {
                rgStage5FrogMG.currentStage3FrogText = 1;
                robotNavMeshAgentToStop.GetComponent<NavMeshAgent>().isStopped = true;
                robCont.NewNavmeshStop();
                playerCamera.enabled = false;
                frogCharacter.gameObject.SetActive(true);
                robCont.enabled = false;
                stageItems.SetActive(true);
                susanArrowToReset.SetActive(false);
                susan2ArrowToReset.SetActive(false);
                lima2ArrowToReset.SetActive(false);
                limaArrowToReset.SetActive(false);
                daisyArrowToReset.SetActive(false);
                daisy2ArrowToReset.SetActive(false);
                radishArrowToReset.SetActive(false);
                radish2ArrowToReset.SetActive(false);
            }


        }
    }
}
