using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using LoLSDK;
namespace Alpha.Phases.Robo.Grow
{
    public class RoboGrowLimaBeanPollen : MonoBehaviour
    {
        public GameObject butterflyModel;
        // public GameObject pollenToDestroy;
        public bool isPollenOnPlayer;
        public bool pollenAttached;
        public AudioSource pickupPollenSFX;
        public AudioSource dropOffPollen;
        public bool pollenTouchingKillCollider;
        public RoboGrowMiniGame3PollenManager rgPollenCount;
        public ButterFlyPlayerController bController;
        public float amountOFPollenAttached;
        // Start is called before the first frame updatef
        void Start()
        {
            isPollenOnPlayer = false;
        }

        // Update is called once per frame
        void FixedUpdate()
        {
            if (isPollenOnPlayer)
            {
                if (!pollenAttached)
                {
                    if (bController.limaBeanPollenAttached < 10)
                    {
                        this.gameObject.transform.parent = butterflyModel.transform;
                        bController.limaBeanPollenAttached = bController.daisyPollenAttached + 1;
                        pollenAttached = true;
                        pickupPollenSFX.Play();
                    }

                }

            }

            if (pollenTouchingKillCollider)
            {
                rgPollenCount.amountOfLimaBeanCollected = rgPollenCount.amountOfLimaBeanCollected + 1;
                this.gameObject.transform.parent = null;
                Destroy(this.gameObject);
                bController.limaBeanPollenAttached = 0;
                Debug.Log("Detected stigam destroyed stuff");
                dropOffPollen.Play();
            }

        }

        private void OnTriggerEnter(Collider other)
        {


            if (other.CompareTag("ButterflyController"))
            {
                isPollenOnPlayer = true;
               // bController.limaBeanPollenAttached = bController.limaBeanPollenAttached + 1;
            }

            if (other.CompareTag("LimaStigma"))
            {
                pollenTouchingKillCollider = true;
                Debug.Log("Detected stigam");
            }
        }

        private void OnTriggerExit(Collider other)
        {
            if (other.CompareTag("ButterflyController"))
            {
                isPollenOnPlayer = false;

            }
        }
    }
}
