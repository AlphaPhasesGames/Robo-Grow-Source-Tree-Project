
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using LoLSDK;
using SimpleJSON;
using System.IO;
using UnityEngine.UI;

namespace Alpha.Phases.Robo.Grow
{
    public class RoboGrowOpenSeedBag : MonoBehaviour
    {
        public Button speakSeedListStage1;
        public GameObject seedBagPanal;
        public RoboGrowMain rgMain;
        public RoboGrowTextBoxManagerStage2 rgTextMan;
        public bool onlyShowTextOnce;
        // Start is called before the first frame update
        void Start()
        {
            speakSeedListStage1.onClick.AddListener(SpeakTaskList1);
        }

        // Update is called once per frame
        void Update()
        {

        }

        public void SpeakTaskList1()
        {
           
           // LOLSDK.Instance.SpeakText("seedBag");
            if(rgMain.currentGameStage == 2)
            {
                if (!onlyShowTextOnce)
                {
                    rgTextMan.currentStageOfText = 13;
                    onlyShowTextOnce = true;
                }
               
            }

        }
    }
}
