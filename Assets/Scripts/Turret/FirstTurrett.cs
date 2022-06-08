using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstTurrett : TurretConfig
{
    public AudioClip shoot;

    public static int turretDamage = 100;

    public Vector2 direction;
    public static float attackDistance = 5f;

    public static float fireRate = 1f;

    private void Update()
    {
        TurretAttack(turretDamage, fireRate, attackDistance, direction, PlayerController.playerAudio, shoot);
    }
}
