using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DmgPlayer : MonoBehaviour
{
    float amount = 10f;

    void OnTriggerEnter2D(Collider2D other)
    {
        other.gameObject.GetComponent<Player>().TakeDamage(amount);

    }
}
