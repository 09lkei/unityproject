using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float health;
    public float maxHealth;
    public HealthBar healthBar;
    public void TakeDamage()
    {
        // Use your own damage handling code, or this example one.
        health -= Mathf.Min(Random.value, health / 4f);
        healthBar.UpdateHealthBar();
    }
    void Update()
    {
        // Example so we can test the Health Bar functionality
        if (Input.GetKeyDown(KeyCode.B))
        {
            TakeDamage();
        }
    }
}
