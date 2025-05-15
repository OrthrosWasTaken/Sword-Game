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
        if (currentHealth <= 0 )
        {
            FindFirstObjectByType<GameOver>().PlayerDied();
        }
    }
    

    public override void TakeDamage(int damage)
    {
        base.TakeDamage(damage);
        healthBar.SetHealth(currentHealth);
    }
}
