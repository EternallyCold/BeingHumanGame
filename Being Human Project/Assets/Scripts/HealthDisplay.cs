using UnityEngine;
using UnityEngine.UI;

public class HealthDisplay : MonoBehaviour
{
    //acquired healthbars address
    Slider healthBar;
    public GameObject playerObject;

    //acquired players medical records
    PlayerHealth player;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //grabbing slider from the game object and storing it in the healthbar
        healthBar = GetComponent<Slider>();

        player = playerObject.GetComponent<PlayerHealth>();
    }

    // Update is called once per frame
    void Update()
    {
        float currentHealth = player.GetHealth();
        float maxHealth = player.startingHealth;

        healthBar.value = currentHealth / maxHealth;
    }
}
