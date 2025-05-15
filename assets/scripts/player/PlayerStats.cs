using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public float health = 100;
    public float hunger = 100;
    public float thirst = 100;
    public float stamina = 100;

    void Update()
    {
        hunger -= Time.deltaTime * 0.5f;
        thirst -= Time.deltaTime * 0.8f;
        stamina = Mathf.Min(100, stamina + Time.deltaTime * 5f); // regen stamina

        if (hunger <= 0 || thirst <= 0)
        {
            health -= Time.deltaTime * 2f;
        }

        if (health <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        Debug.Log("You DIED in the wilds.");
        // Reload scene or trigger game over
    }
}
