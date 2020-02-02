using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class PlayerMovement : MonoBehaviour
{
    //[SerializeField] string nameInputMovementHorizontal = "HorizontalPlayer";
    //[SerializeField] string nameInputMovementVertical = "VerticalPlayer";
    [SerializeField] float speedMovement = 20f; //Vitesse du personnage en m/s
    private Rigidbody rb;

    Vector2 movementDirection;
    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        //float h = Input.GetAxisRaw(nameInputMovementHorizontal);
        //float v = Input.GetAxisRaw(nameInputMovementVertical);
        float h = movementDirection.x;//h = horizontal
        float v = movementDirection.y;//v = vertical

        Vector3 groundVelecity = (transform.forward * v + transform.right * h).normalized * speedMovement;

        Vector3 velocity = groundVelecity + new Vector3(0, rb.velocity.y, 0);

        rb.velocity = velocity;

    }

    public void OnMove(InputAction.CallbackContext context)
    {
        movementDirection = context.ReadValue<Vector2>();
        Debug.Log("movementDirection = " + movementDirection);
    }
}
