using UnityEngine;

namespace Alpha.Phases.Robo.Grow
{
    public class RoboGrowSusanModelSave : MonoBehaviour
    {
        public RoboGrowMain rgMain;
        //GardenData gardenData;
        public bool playOnce;
      

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.U))
            {
                rgMain.susan1Location = this.gameObject.transform.position;
               // rgMain.SaveSusanSeedPlants();
            }
        }
    }
}
