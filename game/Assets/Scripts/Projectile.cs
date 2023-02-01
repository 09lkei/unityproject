using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float speed = 10f;
    public float damage = 10f;


    private void Update()
    {
        transform.position -= -transform.right * Time.deltaTime * speed * transform.rotation.w;
    }


    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            float armour = collision.gameObject.GetComponent<Attributes>().armour;
            collision.gameObject.GetComponent<Attributes>().TakeDamage(damage);
        }
        Destroy(gameObject);
    }
}
