using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletConfig : MonoBehaviour
{
    int damage;
   public void BulletSettings(Vector2 direction, float bulletSpeed)
    {
        transform.Translate(direction * bulletSpeed * Time.fixedDeltaTime);

        if (transform.position.x > 20f)
        {
            Destroy(gameObject);
        }
    }

    public void SetDamage(int damageCount)
    {
        damage = damageCount;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Enemy e = collision.GetComponent<Enemy>();
        if (e != null)
        {
            e.TakeDamage(damage);
            Destroy(gameObject);
        }
    }
}
