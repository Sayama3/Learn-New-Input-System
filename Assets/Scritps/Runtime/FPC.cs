using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class FPC : MonoBehaviour
{
    //Taken Variable from Editor
    [SerializeField] Transform camera;
    [SerializeField] float walkSpeed = 2f;
    [SerializeField] float runSpeed = 10f;
    [SerializeField] float angularSpeed = 60;

    CharacterController controller;
    Transform trans;
    Vector2 Move;
    float fallVelocity;
    float g;
    float vertical;
    bool strife;
    bool run;

    // Start is called before the first frame update
    private void Awake()
    {
        trans = transform;
        controller = GetComponent<CharacterController>();
        g = Physics.gravity.y / 2f;
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        Move = context.ReadValue<Vector2>();
    }

    public void OnStrife(InputAction.CallbackContext context)
    {
        strife = (context.phase == InputActionPhase.Performed);
    }

    public void OnRun(InputAction.CallbackContext context)
    {
        run = (context.phase == InputActionPhase.Performed);
    }

    private void Update()
    {
        float deltaTime = Time.deltaTime;
        fallVelocity += g * deltaTime * deltaTime;
        float oldY = trans.position.y;
        float speed = run ? runSpeed : walkSpeed;
        if (strife)
        {
            if (Move.y != 0)
            {
                vertical = Mathf.Clamp(vertical - Move.y * deltaTime * angularSpeed, -90f, 90f);
                camera.localRotation = Quaternion.Euler(vertical, 0f, 0f);
            }
            controller.Move(trans.right * Move.x * speed * deltaTime + Vector3.up * fallVelocity);
        }
        else
        {
            if (Move.x != 0 )
            {
                trans.Rotate(Vector3.up * Move.x * deltaTime * angularSpeed);
            }
            controller.Move(trans.forward * Move.y * speed * deltaTime + Vector3.up * fallVelocity);
        }

        if (oldY == trans.position.y)
        {
            fallVelocity = 0f;
        }
    }
}
