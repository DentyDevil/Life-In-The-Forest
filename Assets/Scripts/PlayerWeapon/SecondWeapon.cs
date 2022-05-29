using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondWeapon : PlayerWeaponConfig
{
    public GameObject firePoint;
    public GameObject bulletPrefab;
    public float fireRate;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0) || Input.GetKeyDown(KeyCode.Space))
        {
            Shoot(firePoint, bulletPrefab, fireRate);
        }
        ReloadWeapon();
    }
}
