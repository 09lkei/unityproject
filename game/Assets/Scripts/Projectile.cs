using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    float damage = 10f;
    public float speed = 4.5f;

    //void OnTriggerEnter2D(Collider2D other)
    //{
    //    other.gameObject.GetComponent<Player>().TakeDamage(amount);

    //}

    private void Update()
    {
        transform.position += -transform.right * Time.deltaTime * speed * transform.localScale.x;
    }


    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            collision.gameObject.GetComponent<Player>().TakeDamage(damage);
        }
        if (collision.gameObject.tag == "Enemy")
        {
            collision.gameObject.GetComponent<Player>().TakeDamage(20);
        }
        Destroy(gameObject);
    }


    //void OnTriggerStay2D(Collider2D other)
    //{
    //    other.gameObject.GetComponent<Player>().TakeDamage(1);
    //}
}
