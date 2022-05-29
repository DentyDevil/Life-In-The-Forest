using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    

    public float topBound;
    public float bottomBound;

    public GameObject bulletPrefab;
    public GameObject firePoint;

    float fireCountdown = 0;

    float vertical;

    public GameOver gameOver;

    private void Start()
    {
       
    }

    private void Update()
    {
        vertical = Input.GetAxis("Vertical");

        Shoot(firePoint);
    }

    private void FixedUpdate()
    {
        Bound();
        transform.Translate(Vector2.up * vertical * PlayerStats.speed * Time.fixedDeltaTime, Space.World);
    }

    void Bound()
    {
        if (transform.position.y > topBound)
        {
            transform.position = new Vector2(transform.position.x, topBound);
        }
        if (transform.position.y < -bottomBound)
        {
            transform.position = new Vector2(transform.position.x, -bottomBound);
        }
    }

    void Shoot(GameObject firePoint)
    {
        if (Input.GetKeyDown(KeyCode.Mouse0) || Input.GetKeyDown(KeyCode.Space))
        {
            if (fireCountdown <= 0)
            {
                Instantiate(bulletPrefab, firePoint.transform.position, Quaternion.identity);
                fireCountdown = 1f / PlayerStats.fireRate;
            }
        }
        fireCountdown -= Time.deltaTime;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Enemy e = collision.GetComponent<Enemy>();
        PlayerStats p = GetComponent<PlayerStats>();
        if (e != null)
        {
            p.ChangePlayerHealth(-1);
            Destroy(collision.gameObject);
            Debug.Log("HP: " + PlayerStats.Health + "/" + p.startHealth);

            if (PlayerStats.Health == 0)
            {
                gameOver.gameEnd();
            }
        }
    }
}
