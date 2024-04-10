using LoLSDK;
using SimpleJSON;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Alpha.Phases.Robo.Grow
{
    public class RoboGrowMG1LarvaItem : MonoBehaviour
    {
        //public int leafCount;
        public GameObject larvaCollectedOnScreenUI;
        public AudioSource leafCrunchSFX;
        public bool larvaItemCollected;
        // Start is called before the first frame update
      
        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Catapiller"))
            {
                leafCrunchSFX.Play();
                larvaCollectedOnScreenUI.gameObject.SetActive(true);
                larvaItemCollected = true;
                this.gameObject.SetActive(false);
            }
        }
    }
}
