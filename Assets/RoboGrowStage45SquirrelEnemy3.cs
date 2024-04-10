using UnityEngine;

namespace Alpha.Phases.Robo.Grow
{
    public class RoboGrowStage45SquirrelEnemy3 : MonoBehaviour
    {
        public AudioSource deathSFX;
        public GameObject frogPlayer;
        public Transform playerRespawnLocation;
        public Transform playerRespawnLocation2;
        public RoboGrowFrogController frogCont;
        public RoboGrowStage4FrogMiniGame rgMGStage4;
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
                    frogPlayer.transform.eulerAngles = new Vector3(0, 184, 0);
                    frogCont.enabled = false;
                    Debug.Log("The Fall trigge works");
                   
                    EatenStage4();
                }

              

            }
        }

        public void EatenStage4()
        {
            rgMGStage4.currentStage3FrogText = 12;

        }

       
    }
}
