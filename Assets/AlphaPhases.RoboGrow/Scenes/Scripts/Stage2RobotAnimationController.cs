using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using LoLSDK;
namespace Alpha.Phases.Robo.Grow
{
    public class Stage2RobotAnimationController : MonoBehaviour
    {
        public Animator robotStage2Animator;
        public RoboGrowTextBoxManagerStage2 textMan2;
        public RoboGrowTextBoxManager textMan1;
        private void Awake()
        {
            robotStage2Animator.keepAnimatorControllerStateOnDisable = false;
        }
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }

        public void showStage2Text()
        {
            textMan1.enabled = false;
            textMan2.enabled = true;
            textMan2.currentStageOfText = 1;
        }
    }
}