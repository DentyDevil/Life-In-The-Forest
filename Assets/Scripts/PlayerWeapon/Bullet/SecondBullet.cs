using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondBullet : BulletConfig
{
    public int bulletDamage;
    public int bulletSpeed;
    public Vector2 bulletDirection;
    private void Start()
    {
        SetDamage(bulletDamage);
    }

    private void FixedUpdate()
    {
        BulletSettings(bulletDirection, bulletSpeed);
    }
}
