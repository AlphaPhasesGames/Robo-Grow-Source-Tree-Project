using LoLSDK;
using SimpleJSON;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Alpha.Phases.Robo.Grow
{
    public class RoboGrowRespawnControllerIgniter : MonoBehaviour
    {
        public GameObject player;
        public CatapillerController catControl;
        // Start is called before the first frame update

        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Catapiller"))
            {
                catControl.enabled = true;
                Debug.Log("Enabled catapiller controller");

            }
        }
    }
}
