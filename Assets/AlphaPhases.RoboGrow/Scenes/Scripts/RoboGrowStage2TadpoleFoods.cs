using LoLSDK;
using SimpleJSON;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;

namespace Alpha.Phases.Robo.Grow
{
    public class RoboGrowStage2TadpoleFoods : MonoBehaviour
    {
        public TadpoleController tadControl;
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
            if (other.CompareTag("TadPole"))
            {
                leafCrunchSFX.Play();
                tadControl.playersAlgeaCollected++;
                this.gameObject.SetActive(false);
            }
        }
    }
}
