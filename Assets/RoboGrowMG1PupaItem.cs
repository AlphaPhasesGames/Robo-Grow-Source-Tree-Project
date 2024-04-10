using LoLSDK;
using SimpleJSON;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Alpha.Phases.Robo.Grow
{
    public class RoboGrowMG1PupaItem : MonoBehaviour
    {
        //public int leafCount;
        public GameObject pupaCollectedOnScreenUI;
        public AudioSource leafCrunchSFX;
        public bool pupaItemCollected;
        // Start is called before the first frame update


        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Catapiller"))
            {
                leafCrunchSFX.Play();
                pupaCollectedOnScreenUI.gameObject.SetActive(true);
                pupaItemCollected = true;
                this.gameObject.SetActive(false);
            }
        }
    }
}
