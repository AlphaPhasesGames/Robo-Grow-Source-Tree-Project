using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using LoLSDK;
using SimpleJSON;
using System.IO;
using UnityEngine.UI;
using TMPro;

namespace Alpha.Phases.Robo.Grow
{
    public class RoboGrowEggBreakerScript : MonoBehaviour
    {
       // public Animator eggMove;
        public int eggClickCounter;
        public RoboGrowStage1MiniGameStart rgMiniGameStart;
        public Animator eggShake;
        public bool hasEggBeenClicked;
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            if(eggClickCounter > 1)
            { if(!hasEggBeenClicked)
                rgMiniGameStart.currentStage1TreeText = 6;
               // this.gameObject.SetActive(false);
                eggShake.SetTrigger("eggCrack");
                hasEggBeenClicked = true;
            }
        }

        private void OnMouseDown()
        {
            eggClickCounter++;
            eggShake.SetBool("eggShake",true);
        }
    }
}
