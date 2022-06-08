using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstWeapon : PlayerWeaponConfig
{
    public GameObject firePoint;
    public GameObject bulletPrefab;
    public float fireRate;
    public AudioClip shoot;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0) || Input.GetKeyDown(KeyCode.Space))
        {
            Shoot(firePoint, bulletPrefab, fireRate, PlayerController.playerAudio, shoot);
        }
        ReloadWeapon();
    }
}
