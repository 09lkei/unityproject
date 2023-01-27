using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float health;
    public float maxHealth;
    public HealthBar healthBar;
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
        health -= amount;
        healthBar.UpdateHealthBar();
    }
}
