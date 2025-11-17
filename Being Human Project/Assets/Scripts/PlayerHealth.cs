using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    //starting health for player
    public int startingHealth;
    //current health for player
    private int currentHealth;
    //the players medical records
    public Slider slider;


    public void Start()
    {
        slider.maxValue = startingHealth;
        slider.value = currentHealth;
    }

    public void Awake()
    {
        //initialize current health to be equal to starting health
        currentHealth = startingHealth;
    }

    public void ChangeHealth(int changeAmount)
    {
        //adding changeamount to current health
        currentHealth = currentHealth + changeAmount;
        slider.value = currentHealth;

        //keeping current health between 0 and starting value
        currentHealth = Mathf.Clamp(currentHealth, 0, startingHealth);

        if (currentHealth <= 0)
        {
            Kill();
        }
    }

    //player object gets destroyed
    public void Kill()
    {
        Destroy(gameObject);
    }

    public int GetHealth()
    {
        return currentHealth;
    }
}
