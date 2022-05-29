using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float bulletSpeed;
    public Vector2 direction;


    private void FixedUpdate()
    {
        transform.Translate(direction * bulletSpeed * Time.fixedDeltaTime);

        if (transform.position.x > 20f)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Enemy e = collision.GetComponent<Enemy>();
        if (e != null)
        {
            e.TakeDamage(PlayerStats.damage);
            Destroy(gameObject);
        }
    }
}
