using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondTurret : TurretConfig
{
    public AudioClip shoot;

    public static int turretDamage = 200;

    public Vector2 direction;
    public static float attackDistance = 7f;

    public static float fireRate = 1.5f;

    private void Update()
    {
        TurretAttack(turretDamage, fireRate, attackDistance, direction, PlayerController.playerAudio, shoot);
    }

}
