using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretConfig : MonoBehaviour
{
    public Animator animator;
    public GameObject firePoint;
    float fireCountdown = 0;

    public void TurretAttack(int turretDamage, float FireRate, float attackDistance, Vector2 direction)
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, direction, attackDistance, LayerMask.GetMask("Enemy"));

        if (hit.collider != null)
        {
            Enemy e = hit.collider.GetComponent<Enemy>();

            if (fireCountdown <= 0)
            {
                animator.SetTrigger("Attack");
                e.TakeDamage(turretDamage);
                fireCountdown = 1f / FireRate;
                animator.speed = FireRate;
            }

        }
        fireCountdown -= Time.deltaTime;
        fireCountdown = Mathf.Clamp(fireCountdown, 0, fireCountdown);
    }
}
