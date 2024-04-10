using LoLSDK;
using SimpleJSON;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Alpha.Phases.Robo.Grow
{
    public class RoboGrowLeafItem : MonoBehaviour
    {
        //public int leafCount;
        public CatapillerController catControl;
        public AudioSource leafCrunchSFX;
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
            if (other.CompareTag("Catapiller"))
            {
                leafCrunchSFX.Play();
                catControl.playersLeavesCollected++;
                this.gameObject.SetActive(false);
            }
        }
    } 
}

