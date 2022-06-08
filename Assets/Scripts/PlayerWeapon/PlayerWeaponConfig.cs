using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWeaponConfig : MonoBehaviour
{
    float fireCountdown = 0;

    public void Shoot(GameObject firePoint, GameObject bulletPrefab, float fireRate, AudioSource AudioSource, AudioClip shootSound)
    {
        if (fireCountdown <= 0)
        {
            Instantiate(bulletPrefab, firePoint.transform.position, Quaternion.identity);
            AudioSource.PlayOneShot(shootSound);
            fireCountdown = 1f / fireRate;
        }
    }
    public void ReloadWeapon()
    {
        fireCountdown -= Time.deltaTime;
    }
}
