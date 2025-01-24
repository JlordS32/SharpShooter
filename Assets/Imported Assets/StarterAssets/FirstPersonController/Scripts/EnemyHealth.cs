using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] private int startingHealth = 3;

    private int health;

    private void Awake()
    {
        health = startingHealth;
    }

    private void Die()
    {
        Destroy(this.gameObject);
    }

    public void TakeDamage(int damage)
    {
        health -= damage;
        
        if (health < 0)
        {
            Die();
        }

    }
}
