    using UnityEngine;

    public class PlayerHealth : MonoBehaviour
    {
    [Header ("Health")]

    public int maxHealth = 100;
    public int currentHealth;
    public HealthBar healthBar;    
    public GameOverScreen gameOverScreen;
    void Start()
        {
            currentHealth = maxHealth;
            healthBar.SetMaxHealth(maxHealth);
        }

        void Update()
        {
            if (Input.GetKeyDown(KeyCode.F))
            {
                TakeDamage(20);
            }
            if (currentHealth <= 0)
            {
                FindFirstObjectByType<GameOver>().PlayerDied();
            }
        }
        void TakeDamage(int damage)
        {
            currentHealth -= damage;
            healthBar.SetHealth(currentHealth);
        }
    }
