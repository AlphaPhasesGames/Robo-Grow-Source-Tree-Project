using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using LoLSDK;
namespace Alpha.Phases.Robo.Grow
{
    public class ButterFlyPlayerController : MonoBehaviour
    {

        public CharacterController controller; // instantiate the CharachterController as controller
        public Vector3 velocity; // instantiate a vector3 called velocity, to move the player down, to simulate gravity
        public Vector3 v_Movement; // vertical vector 3 for butterfly
        public Vector2 playerHeight; // float to hold the player height for crouching -- not currently in the game
        public Camera myCamera; // camera to hold player camera
        public bool isGrounded; // bool to check if grounded
        public float rotatespeed; // float for the rotate speed for the butterfly
        public float speed; // speed to move by set to 12
        public float wallRunSpeed; // float for wall running speed
        public float gravity; // set gravity float as -9.8f;
        public float jumpHeight; // jump height
        public float climbSpeed; // Climb speed float
        public float pollenAttached; // float to tell how many susan pollen is attached to the butterfly, so we dont get too many attaching 
        public float limaBeanPollenAttached;  // float to tell how many Lima bean pollen is attached to the butterfly, so we dont get too many attaching 
        public float daisyPollenAttached;  // float to tell how many Daisy pollen is attached to the butterfly, so we dont get too many attaching 
        public float radishPollenAttached;  // float to tell how many Radish pollen is attached to the butterfly, so we dont get too many attaching 
        private void Awake()  // before scene starts
        {
            controller = this.GetComponent<CharacterController>(); // get the fps player controller and assign it to controller
            rotatespeed = 0.1f; // set rotate speed
        }

        // Update is called once per frame
        void Update()
        {
            /*
                        if (velocity.y < -2f) // if the player is grounded and the players y velocity is less that -2f
                        {
                            velocity.y = -2f; // velocity.x equals -2 - this pushes the player towards the ground
                            velocity.x = 0f; // x Velocity is 0f
                            velocity.z = 0f; // z Velocity is 0f
                            gravity = -0.5f; // gravity is - 9.8f;
                            controller.enabled = true; // charachter controler is enabled to allow player to move
                        }
            */
            float x = Input.GetAxis("Horizontal"); // declare float x and set it to the horizontal controls
            float z = Input.GetAxis("Vertical"); // declare float z and set it to the vertical controlls

            controller.Move(velocity * Time.deltaTime); // characther controler move function velocity by time.deltatime
                                                        // velocity.y += gravity * Time.deltaTime; // set velocity of downward force as gravity variable by time.delta time.
            v_Movement = controller.transform.forward * z; // the vertical movement of the butterfly is forward key by the z axiz
            controller.Move(v_Movement * speed * Time.deltaTime); // controller move is v_Movement by speed by time.delta time
            controller.transform.Rotate(Vector3.up * x * (100f * Time.deltaTime));
            if (Input.GetKey(KeyCode.Space)) // if space is pressed and player is grounded
            {
                //Jump(); // run jump function}
                this.transform.Translate(Vector3.up * wallRunSpeed * Time.fixedDeltaTime);
            }

            if (Input.GetKey(KeyCode.C))
            {
                this.transform.Translate(Vector3.up * -wallRunSpeed * Time.fixedDeltaTime);
            }
        }
    }
}