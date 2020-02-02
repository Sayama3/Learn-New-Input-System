using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    [SerializeField] private float jumpIntensity = 200f; //en Newtons
    [SerializeField] private string nameInputJump = "Jump";
    Rigidbody rb;

    public bool canJump = true;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    
    private void Update()
    {
        if (Input.GetButtonDown(nameInputJump) && canJump)
        {
            rb.AddForce((Vector3.up * jumpIntensity), ForceMode.Impulse);
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

}
