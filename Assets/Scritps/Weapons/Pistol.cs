using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pistol : Weapon
{
    public GameObject bullet;
    [SerializeField] private float bulletPower = 1000f; //En newtons
    [SerializeField] private float bulletLifeTime = 2f; //En secondes
    private Rigidbody rbBullet;

    private void Start()
    {
        rbBullet = bullet.GetComponent<Rigidbody>();
    }

    public override void Fire()
    {
        base.Fire();
        ShootBullet();
    }

    private void ShootBullet()
    {
        var bulletFired = Instantiate(bullet, transform.position, bullet.transform.rotation);
        bulletFired.GetComponent<Rigidbody>().AddForce(bulletFired.transform.forward * bulletPower);
        Destroy(bulletFired, bulletLifeTime);
    }
}
