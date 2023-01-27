using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DmgPlayer : MonoBehaviour
{
    float amount = 10f;

    //void OnTriggerEnter2D(Collider2D other)
    //{
    //    other.gameObject.GetComponent<Player>().TakeDamage(amount);

    //}


    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            collision.gameObject.GetComponent<Player>().TakeDamage(amount);
        }
        if (collision.gameObject.tag == "Enemy")
        {
            collision.gameObject.GetComponent<Player>().TakeDamage(20);
        }
    }


    //void OnTriggerStay2D(Collider2D other)
    //{
    //    other.gameObject.GetComponent<Player>().TakeDamage(1);
    //}
}
