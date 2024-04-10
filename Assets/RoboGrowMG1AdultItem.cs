using LoLSDK;
using SimpleJSON;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Alpha.Phases.Robo.Grow
{
    public class RoboGrowMG1AdultItem : MonoBehaviour
    {
        //public int leafCount;
        public GameObject adultCollectedOnScreenUI;
        public AudioSource leafCrunchSFX;
        public bool adultItemCollected;
        // Start is called before the first frame update


        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Catapiller"))
            {
                leafCrunchSFX.Play();
                adultCollectedOnScreenUI.gameObject.SetActive(true);
                adultItemCollected = true;
                this.gameObject.SetActive(false);
            }
        }
    }
}
