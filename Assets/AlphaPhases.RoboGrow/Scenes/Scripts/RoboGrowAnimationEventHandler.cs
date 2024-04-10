using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using LoLSDK;
namespace Alpha.Phases.Robo.Grow
{
    public class RoboGrowAnimationEventHandler : MonoBehaviour
    {
       
        public RoboGrowTextBoxManager roboGrowTextBoxManager;

        public void AnimationEventHandler1()
        {
            roboGrowTextBoxManager.StartTextProcessStage1();
        }

        
    }
}
