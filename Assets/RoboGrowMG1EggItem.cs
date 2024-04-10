using LoLSDK;
using SimpleJSON;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Alpha.Phases.Robo.Grow
{
    public class RoboGrowMG1EggItem : MonoBehaviour
    {
        //public int leafCount;
        public GameObject eggCollectedOnScreenUI;
        public AudioSource leafCrunchSFX;
        public bool eggItemCollected;
        // Start is called before the first frame update
       

        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Catapiller"))
            {
                leafCrunchSFX.Play();
                eggCollectedOnScreenUI.gameObject.SetActive(true);
                eggItemCollected = true;
                this.gameObject.SetActive(false);
            }
        }
    }
}
