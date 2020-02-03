using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerShoot : MonoBehaviour
{
    private Weapon[] weapons; 
    private int activeIndex = 0;
    bool shoot;
    bool stopShoot;

    private void Start()
    {
        weapons = GetComponentsInChildren<Weapon>();
    }
    private void Update()
    {
        if (shoot)
        {
            weapons[activeIndex].Fire();
            shoot = !shoot;
        }
        if (stopShoot)
        {
            weapons[activeIndex].EndFire();
        }
    }
    public void OnShoot(InputAction.CallbackContext context)
    {
        shoot = (context.phase == InputActionPhase.Started);
        stopShoot = (context.phase == InputActionPhase.Performed);
        Debug.Log("la phase du bouton shot est " + context.phase);
    }
}
