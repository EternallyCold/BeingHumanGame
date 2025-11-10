using UnityEngine;

public class Hazard : MonoBehaviour
{
    public int enemyDamage;



    void OnCollisionEnter2D(Collision2D collision)
    {
        Collider2D objectHit = collision.collider;

        PlayerHealth player = objectHit.GetComponent<PlayerHealth>();

        if (player != null)
        {
            player.ChangeHealth(-enemyDamage);
        }
    }


}
