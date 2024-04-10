using UnityEngine;

namespace Alpha.Phases.Robo.Grow
{
    public class RoboGrowStage45SquirrelEnemy2 : MonoBehaviour
    {
        public AudioSource deathSFX;
        public GameObject frogPlayer;
        public Transform playerRespawnLocation;
        public Transform playerRespawnLocation2;
        public RoboGrowFrogController frogCont;
        public RoboGrowStage4FrogMiniGame rgMGStage4;
       // public RoboGrowStage5FrogMinigameStart rgMGStage5;
        public bool hasPlayerBeenEatenBefore;
        public RoboGrowMain rgMain;
        // public GameObject inGameCanvas;

        // Start is called before the first frame update
        void Start()
        {

        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("FrogPlayer"))
            {

                if (rgMain.currentGameStage == 4)
                {

                    deathSFX.Play();
                    frogPlayer.transform.position = playerRespawnLocation.transform.position;
                    frogPlayer.transform.eulerAngles = new Vector3(0, 90, 0);
                    frogCont.enabled = false;
                    Debug.Log("The Fall trigge works");
                   
                    EatenStage4();
                }

                if (rgMain.currentGameStage == 5)
                {
                    deathSFX.Play();
                    frogPlayer.transform.position = playerRespawnLocation2.transform.position;
                    frogPlayer.transform.eulerAngles = new Vector3(0, 8, 0);
                    frogCont.enabled = false;
                   
                    EatenStage5();

                }

            }
        }

        public void EatenStage4()
        {
            rgMGStage4.currentStage3FrogText = 12;

        }

        public void EatenStage5()
        {
            //rgMGStage5.currentStage3FrogText = 6;

        }
    }
}
