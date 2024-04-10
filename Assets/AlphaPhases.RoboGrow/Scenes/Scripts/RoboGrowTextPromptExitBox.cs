using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Alpha.Phases.Robo.Grow
{
    public class RoboGrowTextPromptExitBox : MonoBehaviour
    {
        public RoboGrowTextBoxManager roboTextMan;
        public BoxCollider colliderToDisable;
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }

        private void OnTriggerExit(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                roboTextMan.currentStageOfText = 14;
                colliderToDisable.enabled = false;
            }
        }
    }
}
