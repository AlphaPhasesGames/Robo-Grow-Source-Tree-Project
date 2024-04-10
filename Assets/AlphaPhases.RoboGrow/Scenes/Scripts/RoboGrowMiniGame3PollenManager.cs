using System.Collections;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using LoLSDK;
namespace Alpha.Phases.Robo.Grow
{
    public class RoboGrowMiniGame3PollenManager : MonoBehaviour
    {
       // public Slider susanPollenSlider;
       // public Slider limeBeanPollenSlider;
       // public Slider daisyPollenSlider;
      //  public Slider radishPollenSlider;
        public float amountOfSusansPollenCollected;
        public float amountOfLimaBeanCollected;
        public float amountOfDaisyPollenCollected;
        public float amountOfRadishPollenCollected;
        public RoboGrowStartMinigame3 rgStartMiniG3;
        public ButterFlyPlayerController buttCont;
        public RoboGrowMain rgMain;
        public GameObject susanPollenCollection1;
       // public GameObject susanPollenCollection2;
        public GameObject limaPollenCollection;
        public GameObject daisyPollenCollection;
        public GameObject radishPollenCollection;

        public GameObject susanTick;
        public GameObject limaTick;
        public GameObject daisyTick;
        public GameObject radishTick;

        public GameObject susanPollenArrows;
        public GameObject susanTargetnArrows;

        public GameObject limaPollenArrows;
        public GameObject limaTargetnArrows;

        public GameObject daisyPollenArrows;
        public GameObject daisyTargetnArrows;

        public GameObject radishPollenArrows;
        public GameObject radishTargetnArrows;

        public bool susanPollenTaskCompleted;
        public bool limaBeanPollenTaskCompleted;
        public bool daisyPollenTaskCompleted;
        public bool radishPollenTaskCompleted;

        public bool hasSusanPopped;
        public bool hasLimaBeanPopped;
        public bool hasDiasyPopped;
        public bool hasradishPopped;

        public bool hasAllPollenBeenCollected;
        // Start is called before the first frame update
        void Start()
        {
            susanPollenArrows.gameObject.SetActive(false);
            susanTargetnArrows.gameObject.SetActive(false);
            limaPollenArrows.gameObject.SetActive(false);
            limaTargetnArrows.gameObject.SetActive(false);
            daisyPollenArrows.gameObject.SetActive(false);
            daisyTargetnArrows.gameObject.SetActive(false);
            radishPollenArrows.gameObject.SetActive(false);
            radishTargetnArrows.gameObject.SetActive(false);
        }

        // Update is called once per frame
        void Update()
        {
           // susanPollenSlider.value = amountOfSusansPollenCollected;
           // limeBeanPollenSlider.value = amountOfLimaBeanCollected;
          //  daisyPollenSlider.value = amountOfDaisyPollenCollected;
          //  radishPollenSlider.value = amountOfRadishPollenCollected;

            if (rgMain.stage3FlowersWatered && rgMain.currentGameStage == 3)
            {

                if (!hasSusanPopped)
                {

                    if (buttCont.pollenAttached == 0)
                    {
                     //   susanPollenArrows.gameObject.SetActive(true);
                        susanTargetnArrows.gameObject.SetActive(false);
                    }

                    if (buttCont.pollenAttached != 0)
                    {
                        susanTargetnArrows.gameObject.SetActive(true);
                        susanPollenArrows.gameObject.SetActive(false);
                    }

                    if (amountOfSusansPollenCollected >= 1)
                    {
                        rgStartMiniG3.currentStage3TreeText = 18;
                        //StartCoroutine(rgStartMiniG3.PollenSusanCollected());
                        susanPollenTaskCompleted = true;
                        hasSusanPopped = true;
                        susanPollenCollection1.gameObject.SetActive(false);
                        //susanPollenCollection2.gameObject.SetActive(false);
                        susanTick.gameObject.SetActive(true);
                        susanTargetnArrows.gameObject.SetActive(false);
                        susanPollenArrows.gameObject.SetActive(false);
                    }

                }

                if (!hasLimaBeanPopped)
                {

                    if (buttCont.limaBeanPollenAttached == 0)
                    {
                      //  limaPollenArrows.gameObject.SetActive(true);
                        limaTargetnArrows.gameObject.SetActive(false);
                    }

                    if (buttCont.limaBeanPollenAttached != 0)
                    {
                        limaPollenArrows.gameObject.SetActive(false);
                        limaTargetnArrows.gameObject.SetActive(true);
                    }

                    if (amountOfLimaBeanCollected >= 1)
                    {

                        rgStartMiniG3.currentStage3TreeText = 19;
                        limaBeanPollenTaskCompleted = true;
                        hasLimaBeanPopped = true;
                        limaPollenCollection.gameObject.SetActive(false);
                        limaPollenArrows.gameObject.SetActive(false);
                        limaTargetnArrows.gameObject.SetActive(false);
                        limaTick.gameObject.SetActive(true);

                    }
                }
                if (!hasDiasyPopped)
                {

                    if (buttCont.daisyPollenAttached == 0)
                    {
                    //    daisyPollenArrows.gameObject.SetActive(true);
                        daisyTargetnArrows.gameObject.SetActive(false);
                    }

                    if (buttCont.daisyPollenAttached != 0)
                    {
                        daisyTargetnArrows.gameObject.SetActive(true);
                        daisyPollenArrows.gameObject.SetActive(false);
                    }

                    if (amountOfDaisyPollenCollected >= 1)
                    {

                        rgStartMiniG3.currentStage3TreeText = 20;
                        daisyPollenTaskCompleted = true;
                        hasDiasyPopped = true;
                        daisyPollenCollection.gameObject.SetActive(false);
                        daisyTargetnArrows.gameObject.SetActive(false);
                        daisyPollenArrows.gameObject.SetActive(false);
                        daisyTick.gameObject.SetActive(true);
                    }

                }
                if (!hasradishPopped)
                {
                    if (buttCont.radishPollenAttached == 0)
                    {
                   //     radishPollenArrows.gameObject.SetActive(true);
                        radishTargetnArrows.gameObject.SetActive(false);
                    }

                    if (buttCont.radishPollenAttached != 0)
                    {
                        radishTargetnArrows.gameObject.SetActive(true);
                        radishPollenArrows.gameObject.SetActive(false);
                    }

                    if (amountOfRadishPollenCollected >= 1)
                    {

                        rgStartMiniG3.currentStage3TreeText = 21;
                        radishPollenTaskCompleted = true;
                        hasradishPopped = true;
                        radishPollenCollection.gameObject.SetActive(false);
                        radishPollenArrows.gameObject.SetActive(false);
                        radishTargetnArrows.gameObject.SetActive(false);
                        radishTick.gameObject.SetActive(true);
                    }

                }
            }
          

            if(susanPollenTaskCompleted && limaBeanPollenTaskCompleted && daisyPollenTaskCompleted && radishPollenTaskCompleted)
            {
                if (!hasAllPollenBeenCollected)
                {
                    rgStartMiniG3.currentStage3TreeText = 22;
                    hasAllPollenBeenCollected = true;
                    susanTick.gameObject.SetActive(false);
                    limaTick.gameObject.SetActive(false);
                    daisyTick.gameObject.SetActive(false);
                    radishTick.gameObject.SetActive(false);
                }
              
            }

        }
    }
}
