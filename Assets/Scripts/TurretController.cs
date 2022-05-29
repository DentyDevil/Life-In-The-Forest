using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretController : MonoBehaviour
{
    public Animator animator;

    public GameObject firePoint;

    public static int turretDamage = 100;

    public Vector2 direction;
    public static float attackDistance = 5f;

    public static float fireRate = 1f;
    float fireCountdown = 0;

    private void Start()
    {
    }

    private void Update()
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, direction, attackDistance, LayerMask.GetMask("Enemy"));

        if (hit.collider != null)
        {
            Enemy e = hit.collider.GetComponent<Enemy>();

            if (fireCountdown <= 0)
            {
                animator.SetTrigger("Attack");
                e.TakeDamage(turretDamage);
                fireCountdown = 1f / fireRate;
                animator.speed = fireRate;
            }

        }
        fireCountdown -= Time.deltaTime;
        fireCountdown = Mathf.Clamp(fireCountdown, 0, fireCountdown);
    }
}
