using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] string nameInputMovementHorizontal = "HorizontalPlayer";
    [SerializeField] string nameInputMovementVertical = "VerticalPlayer";
    [SerializeField] float speedMovement = 20f; //Vitesse du personnage en m/s
    private Rigidbody rb;


    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        float h = Input.GetAxisRaw(nameInputMovementHorizontal);
        float v = Input.GetAxisRaw(nameInputMovementVertical);

        Vector3 groundVelecity = (transform.forward * v + transform.right * h).normalized * speedMovement;

        Vector3 velocity = groundVelecity + new Vector3(0, rb.velocity.y, 0);

        rb.velocity = velocity;


    }

}
