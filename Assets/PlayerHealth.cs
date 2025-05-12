using UnityEngine;

public class PlayerHealth : HP
{
    public HealthBar healthBar;
    public GameOverScreen gameOverScreen;

   
    void Awake()
    {
        base.Start(); 
        healthBar.SetMaxHealth(maxHealth);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            TakeDamage(20);
        }

        Death(); 
    }

    
    public override void TakeDamage(int damage)
    {
        base.TakeDamage(damage); 
        healthBar.SetHealth(currentHealth);
    }
}
