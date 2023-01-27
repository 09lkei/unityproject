using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxDamage : MonoBehaviour
{
    float amount = 5f;

    //private void OnTriggerEnter(Collider other)
    //{
    //    Debug.Log("Hello");
    //    other.gameObject.GetComponent<Player> ().TakeDamage (amount);


    //}

    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("AAAAHHHH");

        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("Hello");
            collision.gameObject.GetComponent<Player>().TakeDamage(amount);
        }

    }

}
