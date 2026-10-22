using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public float currentHealth;

    public float maxHealth;

    public Image healthImage;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if(healthImage)
        {
            healthImage.fillAmount = currentHealth / maxHealth;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Heal(float healAmount)
    {
        currentHealth += healAmount;

        currentHealth = Mathf.Clamp(currentHealth, 0, maxHealth);

        if (healthImage)
        {
            healthImage.fillAmount = currentHealth / maxHealth;
        }
    }

    public void TakeDamage(float damageAmount)
    {
        currentHealth -= damageAmount;

        currentHealth = Mathf.Clamp(currentHealth, 0, maxHealth);

        if (currentHealth <= 0)
        {
            Die();
        }

        if (healthImage)
        {
            healthImage.fillAmount = currentHealth / maxHealth;
        }
    }

    public void Die()
    {
        // Handle death logic
        Death death = GetComponent<Death>();

        if (death != null)
        {
            death.Die();
        }

        Debug.Log("Character has died.");
    }
}
