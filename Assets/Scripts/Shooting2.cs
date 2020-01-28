using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting2 : MonoBehaviour
{

    public Transform firePoint;
    public GameObject bulletPrefab;

    float bulletForce = 20f;

    public AudioSource bulletSound;

    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            bulletSound.Play();
            Shoot();
        }
    }

    void Shoot()
    {
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(firePoint.up * bulletForce, ForceMode2D.Impulse);

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "bullet")
        {
            GetComponent<ClickToMove>().Player2Die();
        }
    }
    
    

}
