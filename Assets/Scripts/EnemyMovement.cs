using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    Enemy enemy;

    private void Start()
    {
        enemy = GetComponent<Enemy>();
    }

    private void FixedUpdate()
    {
        transform.Translate(enemy.direction * enemy.enemySpeed * Time.fixedDeltaTime);

        if (transform.position.x <= -20)
        {
            Destroy(gameObject);
        }
    }
}
