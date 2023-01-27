using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float health;
    public float maxHealth;
    public HealthBar healthBar;
    public bool alive;

    void Start()
    {
        Debug.Log("HELLO");
        healthBar.UpdateHealthBar();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.B))
        {
            TakeDamage(10);
        }
    }

    public void TakeDamage(float amount)
    {
        health -= amount;
        healthBar.UpdateHealthBar();
    }
}
