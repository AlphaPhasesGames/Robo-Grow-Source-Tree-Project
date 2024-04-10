using LoLSDK;
using SimpleJSON;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;

namespace Alpha.Phases.Robo.Grow
{


    public class CatapillerController : MonoBehaviour
    {
        public CharacterController controller; // instantiate the CharachterController as controller
        public RoboGrowStage1MiniGameStart rgMGStart;
        public RoboGrowMG1EggItem rgMG1EggItem;
        public RoboGrowMG1LarvaItem rgMG1LarvaItem;
        public RoboGrowMG1PupaItem rgMG1PupaItem;
        public RoboGrowMG1AdultItem rgMG1AdultItem;

        public bool allCollectablesCollected;
        public bool collectablesTextShownAlready;
        public Vector3 velocity; // instantiate a vector3 called velocity, to move the player down, to simulate gravity
        public Vector3 v_Movement;
      // public Vector2 playerHeight; // float to hold the player height for crouching -- not currently in the game
       public Camera myCamera; // camera to hold player camera
        public bool isGrounded; // bool to check if grounded
        public float rotatespeed;
     ///   public Slider hungerSlider;
       public float speed; // speed to move by set to 12
        public float wallRunSpeed; // float for wall running speed
        public float gravity; // set gravity float as -9.8f;
        public float jumpHeight; // jump height
        public float climbSpeed; // Climb speed float
        public int playersLeavesCollected;

       // public GameObject eggCollectedOnScreenUI;
       // public GameObject larvaCollectedOnScreenUI;
       // public GameObject pupaCollectedOnScreenUI;
       // public GameObject adultCollectedOnScreenUI;

        //  public Animation catTurnAnimation;
        public Animator catTurnAnimator;

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
            controller.enabled = true; // charachter controler is enabled to allow player to move
        }
        float x = Input.GetAxis("Horizontal"); // declare float x and set it to the horizontal controls
        float z = Input.GetAxis("Vertical"); // declare float z and set it to the vertical controlls
      //  hungerSlider.value = playersLeavesCollected;
        controller.Move(velocity * Time.deltaTime); // characther controler move function velocity by time.deltatime
        velocity.y += gravity * Time.deltaTime; // set velocity of downward force as gravity variable by time.delta time.
        v_Movement = controller.transform.forward * z;
        controller.Move(v_Movement * speed * Time.deltaTime);
        controller.transform.Rotate(Vector3.up * x * (100f * Time.deltaTime));
        if (Input.GetButtonDown("Jump")) // if space is pressed and player is grounded
        {
            Jump(); // run jump function}
        }

            if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow))
            {
                catTurnAnimator.SetTrigger("catLeft");
            }

            if (Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.LeftArrow))
            {
                catTurnAnimator.ResetTrigger("catLeft");
                catTurnAnimator.SetTrigger("catReset");
            }


            if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow))
            {
                catTurnAnimator.SetTrigger("catRight");
              

            }
            if (Input.GetKeyUp(KeyCode.D) || Input.GetKeyUp(KeyCode.RightArrow))
            {
                catTurnAnimator.ResetTrigger("catRight");
                catTurnAnimator.SetTrigger("catReset");

            }
            if (!collectablesTextShownAlready)
            {
                if (rgMG1EggItem.eggItemCollected && rgMG1LarvaItem.larvaItemCollected && rgMG1PupaItem.pupaItemCollected && rgMG1AdultItem.adultItemCollected)
                {
                    allCollectablesCollected = true;
                    rgMGStart.currentStage1TreeText = 13;
                    collectablesTextShownAlready = true;
                }
            }
           
        }
        
        public void Jump()
        {
        velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity); // player velocity.y is mathf.sqrt (which returns the root value of f) multiplied by -2f and gravity value
        }

    }
}