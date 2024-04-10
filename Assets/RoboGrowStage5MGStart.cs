using UnityEngine;
using UnityEngine.AI;

namespace Alpha.Phases.Robo.Grow
{
    public class RoboGrowStage5MGStart : MonoBehaviour
    {
        public RoboGrowMain rgMain;
        public RobotController robCont;
        public RoboGrowStage5MiniGame2Tree rgTree;

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
                robCont.NewNavmeshStop();
                rgTree.currentStage5TreeText = 1;
                robCont.enabled = false;
                susanArrowToReset.SetActive(false);
                susan2ArrowToReset.SetActive(false);
                lima2ArrowToReset.SetActive(false);
                limaArrowToReset.SetActive(false);
                daisyArrowToReset.SetActive(false);
                daisy2ArrowToReset.SetActive(false);
                radishArrowToReset.SetActive(false);
                radish2ArrowToReset.SetActive(false);
                robotNavMeshAgentToStop.GetComponent<NavMeshAgent>().isStopped = true;
            }
        }
    }
}
