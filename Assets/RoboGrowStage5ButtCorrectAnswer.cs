using UnityEngine;

namespace Alpha.Phases.Robo.Grow
{
    public class RoboGrowStage5ButtCorrectAnswer : MonoBehaviour
    {

        public RoboGrowStage5MiniGame2Tree buttMinigame;
        public GameObject buttlevelItems;
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                buttMinigame.currentStage5TreeText = 14;
                buttlevelItems.gameObject.SetActive(false);
            }
              
            
        }
    }
}
