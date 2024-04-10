using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace alpha.phases.robo.grow
{
    public class RoboGrowIntroCharacterMover : MonoBehaviour
    {
        public Animator doorOpenAnim;


        public void MovePlayerIntoScene()
        {
            doorOpenAnim.SetBool("cameraInPosition", true);
        }
    }
}
