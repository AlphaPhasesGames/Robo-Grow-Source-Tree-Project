using LoLSDK;
using SimpleJSON;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Alpha.Phases.Robo.Grow
{
    public class RoboGrowFallTrigger : MonoBehaviour
    {
        public GameObject player;
        public Transform playerRespawnLocation;
        public CatapillerController catControl;
        // Start is called before the first frame update
        void Start()
        {
            player.transform.position = playerRespawnLocation.transform.position;
        }

        // Update is called once per frame
        void Update()
        {
        
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Catapiller"))
            {
                catControl.enabled = false;
                player.transform.position = playerRespawnLocation.transform.position;
                player.transform.eulerAngles = new Vector3(0, 58, 0);
                Debug.Log("The Fall trigge works");
                //catControl.enabled = true;

            }
        }
    }
}
