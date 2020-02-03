using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    protected Transform cam;

    protected virtual void Start()
    {
        cam = Camera.main.transform;
    }
    public virtual void Fire()
    {
        Debug.Log(this.name + " fire.");
    }

    public virtual void EndFire()
    {
        Debug.Log(this.name + " end the fire.");
    }
}
