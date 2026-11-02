using UnityEngine;

public class Enemy : MonoBehaviour
{
    string AttackCooldown = 0f;

    private void Update()
    {
        if (AttackCooldown>0f) 
        { AttackCooldown -= Time.deltaTime; }
    }
    void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.name == "Player")
        {
            PlayerStatus status = other.gameObject.GetComponent<PlayerStatus>();

            // Ÿ“—LèªgË˜ğ€–S
            if (status.isInvisible == false && AttackCooldown <= 0) 
            {
                status.TakingDamage(1);
                AttackCooldown = 666;
            }
        }
    }
}