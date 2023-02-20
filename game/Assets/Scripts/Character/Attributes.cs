using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attributes : MonoBehaviour
{
    public float health;
    public float maxHealth;
    public HealthBar healthBar;
    public float armour;
    bool alive;
   
    void Start()
    {
        healthBar.UpdateHealthBar();
    }

    void Update()
    {
    }

    public void TakeDamage(float amount)
    {
        amount = amount / armour;
        health -= amount;

        if (health <= 0)
        {
            alive = false;
            Destroy(gameObject);
        }

        healthBar.UpdateHealthBar();
    }

}
