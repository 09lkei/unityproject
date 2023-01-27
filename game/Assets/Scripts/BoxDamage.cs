using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxDamage : MonoBehaviour
{
    float amount = 5f;

    void OnTriggerEnter2D(Collider2D other)
    {
        other.gameObject.GetComponent<Player>().TakeDamage(amount);

    }
}
