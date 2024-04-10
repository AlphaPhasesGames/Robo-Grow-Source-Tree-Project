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
    public class Stage3RobotAnimationManager : MonoBehaviour
    {
        public Animator robotStage2Animator;
      //  public RoboGrowTextBoxManagerStage2 textMan2;
        public RoboGrowTextBoxManagerStage3 textMan3;
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

        public void ShowStage3Text()
        {
           // textMan2.enabled = false;
            textMan3.enabled = true;
            textMan3.currentStageOfText = 1;
            Debug.Log("This text should appear");
        }
    }
}
