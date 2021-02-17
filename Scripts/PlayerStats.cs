using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : CharacterStats
{
    PlayerUI playerUI;
    
    // Start is called before the first frame update
    void Start()
    {
        playerUI = GetComponent<PlayerUI>();
        maxHealth = 100;
        currentHealth = maxHealth;

        maxStamina = 100;
        currentStamina = maxStamina;

        SetStats();
        
    }

    public override void Die() {
        Debug.Log("You died!");
    }

    void SetStats() {
        playerUI.healthAmount.text = currentHealth.ToString();
        playerUI.staminaAmount.text = currentStamina.ToString();


    }

    public override void CheckHealth() {
        base.CheckHealth();
        SetStats();

    }

    public override void CheckStamina() {
        base.CheckHealth();
        SetStats();
    }
}
