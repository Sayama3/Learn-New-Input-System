using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pistol : Weapon
{
    public GameObject bullet;
    [SerializeField] private float bulletPower = 1000f; //En newtons
    [SerializeField] private float bulletLifeTime = 2f; //En secondes
    private Rigidbody rbBullet;

    protected override void Start()
    {
        base.Start();
        rbBullet = bullet.GetComponent<Rigidbody>();
    }

    public override void Fire()
    {
        base.Fire();
        ShootBullet();
    }

    private void ShootBullet()
    {
        var bulletFired = Instantiate(bullet, cam.position, cam.rotation);
        bulletFired.GetComponent<Rigidbody>().AddForce(cam.forward * bulletPower);
        Destroy(bulletFired, bulletLifeTime);
    }
}
