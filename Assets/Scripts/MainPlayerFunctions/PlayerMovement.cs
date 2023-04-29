using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace move_player
{
    public class PlayerMovement : MonoBehaviour
    {

        [Header("KeyBinds")]
        public KeyCode jumpKey = KeyCode.Space; 

        [Header("Movement")]
        public float moveSpeed;

        public float GroundDrag;

        public float JumpForce;
        public float jumpCoolDown;
        public float airMultiplier;
        bool readyToJump; 

        [Header("Ground Check")]
        public float PlayerHeight;
        public LayerMask whatIsGround;
        bool grounded; 

        public Transform orientation;

        float horizontalInput;
        float verticalInput;

        Vector3 moveDirection;

        Rigidbody rb;

        private void Start()
        {
            rb = GetComponent<Rigidbody>();
            rb.freezeRotation = true;
            ResetJump();
        }


        private void FixedUpdate()
        {
            MovePlayer();
        }

        private void Update()
        {
            grounded = Physics.Raycast(transform.position, Vector3.down, PlayerHeight * 0.5f + 0.2f, whatIsGround);
            MyInput();
            SpeedControl();
            if (grounded)
            {
                rb.drag = GroundDrag; 
            }
            else
            {
                rb.drag = 0;
            }
        }

        private void MyInput()
        {
            horizontalInput = Input.GetAxisRaw("Horizontal");
            verticalInput = Input.GetAxisRaw("Vertical");
            if (Input.GetKey(jumpKey) && readyToJump && grounded)
            {
                readyToJump = false;
                Jump();
                Invoke(nameof(ResetJump), jumpCoolDown);
            }
        }

        private void MovePlayer()
        {
            moveDirection = orientation.forward * verticalInput + orientation.right * horizontalInput;
            if (grounded)
                rb.AddForce(moveDirection.normalized * moveSpeed * 10f, ForceMode.Force);
            else if (!grounded) 
                rb.AddForce(moveDirection.normalized * moveSpeed * 10f * airMultiplier, ForceMode.Force); 
        }

        private void SpeedControl()
        {
            Vector3 flatVelocity = new Vector3(rb.velocity.x, 0f, rb.velocity.z);
            if (flatVelocity.magnitude > moveSpeed)
            {
                Vector3 limitedVelocity = flatVelocity.normalized * moveSpeed;
                rb.velocity = new Vector3(limitedVelocity.x, rb.velocity.y, limitedVelocity.z);
            }
        }

        private void Jump()
        {
            rb.velocity = new Vector3(rb.velocity.x, 0f, rb.velocity.z);
            rb.AddForce(transform.up * JumpForce, ForceMode.Impulse);
        }

        private void ResetJump()
        {
            readyToJump = true;
        }
    }
}
