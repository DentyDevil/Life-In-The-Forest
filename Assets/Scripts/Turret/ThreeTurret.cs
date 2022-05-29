using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThreeTurret : TurretConfig
{
    public static int turretDamage = 300;

    public Vector2 direction;
    public static float attackDistance = 7f;

    public static float fireRate = 2f;

    private void Update()
    {
        TurretAttack(turretDamage, fireRate, attackDistance, direction);
    }
}
