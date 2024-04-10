using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AI;
using LoLSDK;
namespace Alpha.Phases.Robo.Grow
{
    public class RoboGrowStage2BillBoardCards : MonoBehaviour
    {
        public Camera m_Camera;

        //Orient the camera after all movement is completed this frame to avoid jittering
        private void Update()
        {
            //this.transform.LookAt(this.transform.position + m_Camera.transform.rotation * Vector3.forward);
            this.transform.rotation = Quaternion.LookRotation(m_Camera.transform.rotation * Vector3.up);
        }
    }
}
