using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float topBound;
    public float bottomBound;
    public static AudioSource playerAudio;

    public GameObject spawnPointWeapon;
    public static GameObject playerWeapon;

    float vertical;

    public GameOver gameOver;

    private void Start()
    {
        playerAudio = GetComponent<AudioSource>();
        Instantiate(playerWeapon, spawnPointWeapon.transform.parent);

    }

    private void Update()
    {
        vertical = Input.GetAxis("Vertical");
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
