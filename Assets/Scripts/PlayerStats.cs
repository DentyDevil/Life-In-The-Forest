using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public int startHealth;
    public static int Health;

    public static float money = 10000000;

    public static float speed = 10f;

    public static float fireRate = 1;

    public static int damage = 50;

    [HideInInspector]
    public int enemyKill = 0;

    private void Start()
    {
        Health = startHealth;
    }

    public void ChangePlayerHealth(int amount)
    {
        Health = Mathf.Clamp(Health + amount, 0, startHealth);
    }
}
