using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using LoLSDK;
namespace Alpha.Phases.Robo.Grow
{
    public class RoboGrowFrogJump : MonoBehaviour
    {


        public Animator jumpAnim;
      
        // Start is called before the first frame update
        void Start()
        {
            jumpAnim.GetComponent<Animator>();
        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                jumpAnim.SetTrigger("jump");
               
            }
        }



        public void MovePlayerAfterJumping()
        {
            jumpAnim.SetTrigger("jumpReset");
            Debug.Log("Animation reset");
        }


        public void StopJumping()
        {
            jumpAnim.StopPlayback();
            Debug.Log("Animation reset");
        }

    }
}
