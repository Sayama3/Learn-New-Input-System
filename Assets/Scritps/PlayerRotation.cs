using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRotation : MonoBehaviour
{

    [SerializeField] string nameInputMovementHorizontal = "HorizontalCamera";
    [SerializeField] string nameInputMovementVertical = "VerticalCamera";
    [SerializeField] private float speedVerticalCameraRotation = 20; // en degrée par seconde
    [SerializeField] private float speedHorizontalCameraRotation = 20; // en degrée par seconde

    private GameObject TheCamera;

    private void Start()
    {
        TheCamera = GetComponentInChildren<Camera>().gameObject;
    }
    void Update()
    {
        float h = Input.GetAxisRaw(nameInputMovementHorizontal);
        float v = Input.GetAxisRaw(nameInputMovementVertical);

        this.transform.Rotate(new Vector3(0, h * speedHorizontalCameraRotation * Time.deltaTime, 0));
        TheCamera.transform.Rotate(new Vector3(v * speedVerticalCameraRotation * Time.deltaTime, 0, 0));
    }
}
