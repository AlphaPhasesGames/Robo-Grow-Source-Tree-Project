using UnityEngine;

namespace Alpha.Phases.Robo.Grow
{
    public class RoboGrowStage5RobotAnimation : MonoBehaviour
    {
        public Animator robotStage5Animator;
        //  public RoboGrowTextBoxManagerStage2 textMan2;
        public RoboGrowStage5TextBoxManager textMan5;


        public void ShowStage5Text()
        {
            // textMan2.enabled = false;
            textMan5.enabled = true;
            textMan5.currentStageOfText = 1;
            Debug.Log("This text should appear");
        }
    }
}
