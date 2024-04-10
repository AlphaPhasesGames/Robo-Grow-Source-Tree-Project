using UnityEngine;

namespace Alpha.Phases.Robo.Grow
{
    public class RoboGrowStage4RobotAnimationManager : MonoBehaviour
    {
        public Animator robotStage2Animator;
        //  public RoboGrowTextBoxManagerStage2 textMan2;
        public RoboGrowTextManagerStage4 textMan4;
       

        public void ShowStage4Text()
        {
            // textMan2.enabled = false;
            textMan4.enabled = true;
            textMan4.currentStageOfText = 1;
            Debug.Log("This text should appear");
        }
    }
}
