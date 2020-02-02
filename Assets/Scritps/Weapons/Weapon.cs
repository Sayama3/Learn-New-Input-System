using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public virtual void Fire()
    {
        Debug.Log(this.name + " fire.");
    }

    public virtual void EndFire()
    {
        Debug.Log(this.name + " end the fire.");
    }
}
