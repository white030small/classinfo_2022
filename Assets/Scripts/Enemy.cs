using UnityEngine;

public class Enemy : MonoBehaviour
{
    void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.name == "Player")
        {
            PlayerStatus status = other.gameObject.GetComponent<PlayerStatus>();

            // Ÿ“—LèªgË˜ğ€–S
            if (status.isInvisible == false)
            {
                status.isDead();
            }
        }
    }
}