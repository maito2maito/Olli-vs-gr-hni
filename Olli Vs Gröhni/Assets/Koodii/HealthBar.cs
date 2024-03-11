using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    // Public variables that can be adjusted in the Unity editor
    public float maxHealth = 100f;
    public float currentHealth;
    public Scrollbar healthBar;

    void Start()
    {
        // Set the current health to the maximum health at the start of the game
        currentHealth = maxHealth;
    }

    void Update()
    {
        // Check if the 'E' key is pressed or the Xbox controller's X button is pressed
        if (Input.GetKeyDown(KeyCode.E) || Input.GetButtonDown("XButton"))
        {
            // Decrease the current health by 10
            currentHealth -= 10f;

            // Make sure the current health doesn't go below zero
            if (currentHealth < 0)
            {
                currentHealth = 0;
            }

            // Adjust the health bar to reflect the current health
            healthBar.size = currentHealth / maxHealth;
        }
    }
}
