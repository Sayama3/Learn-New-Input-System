using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class PlayerJump : MonoBehaviour
{
    [SerializeField] private float jumpIntensity = 200f; //en Newtons
    //[SerializeField] private string nameInputJump = "Jump";
    Rigidbody rb;

    public bool canJump = true;

    bool jump;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    
    private void Update()
    {

        if (jump && canJump)
        {
            Jump();
            //canJump = false;
        }

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("JumpableObject"))
        {
            canJump = true;
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        if (collision.collider.CompareTag("JumpableObject"))
        {
            canJump = false;
        }
    }

    public void OnJump(InputAction.CallbackContext context)
    {
        jump = (context.phase == InputActionPhase.Performed);
    }
    private void Jump()
    {
        rb.AddForce((Vector3.up * jumpIntensity), ForceMode.Impulse);
    }
}
