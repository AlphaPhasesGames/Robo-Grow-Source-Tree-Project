using LoLSDK;
using SimpleJSON;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Alpha.Phases.Robo.Grow
{
    public class RoboGrowFrogController : MonoBehaviour
    {
     
      //  public CharacterController controller; // instantiate the CharachterController as controller
        public Vector3 velocity; // instantiate a vector3 called velocity, to move the player down, to simulate gravity
        public Vector3 v_Movement;
        // public Vector2 playerHeight; // float to hold the player height for crouching -- not currently in the game
        public Camera myCamera; // camera to hold player camera
        public bool isGrounded; // bool to check if grounded
        public float rotatespeed;
       // public Slider hungerSlider;
        public float speed; // speed to move by set to 12
        //public float wallRunSpeed; // float for wall running speed
        public float gravity; // set gravity float as -9.8f;
       // public float jumpHeight; // jump height
       // public float climbSpeed; // Climb speed float
       // public int playersLeavesCollected;
        private void Awake()  // before scene starts
        {
            // controller = this.GetComponent<CharacterController>(); // get the fps player controller and assign it to controller
            rotatespeed = 0.1f;
            // controller.detectCollisions = false;
        }

        // Update is called once per frame
        void Update()
        {

          

            if (velocity.y < -4f) // if the player is grounded and the players y velocity is less that -2f
            {
                velocity.y = -2f; // velocity.x equals -2 - this pushes the player towards the ground
                velocity.x = 0f; // x Velocity is 0f
                velocity.z = 0f; // z Velocity is 0f
                gravity = -9.8f; // gravity is - 9.8f;
               // controller.enabled = true; // charachter controler is enabled to allow player to move
            }
            float x = Input.GetAxis("Horizontal"); // declare float x and set it to the horizontal controls
          //  float z = Input.GetAxis("Vertical"); // declare float z and set it to the vertical controlls
          
          //  controller.Move(velocity * Time.deltaTime); // characther controler move function velocity by time.deltatime
          //  velocity.y += gravity * Time.deltaTime; // set velocity of downward force as gravity variable by time.delta time.
          //  v_Movement = controller.transform.forward * z;
           // controller.Move(v_Movement * speed * Time.deltaTime);
            this.gameObject.transform.Rotate(Vector3.up * x * (100f * Time.deltaTime));
          
        }

      

    }
}


