using Unity.VisualScripting.ReorderableList;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [Tooltip("ˆÚ“®")]
    [SerializeField]
    float SwitchTimer = 3f;
    [Tooltip("”½çzˆÚ“®•ûŒü")]
    public bool MovingRight = true;
    float AttackCooldown = 0f;

    SpriteRenderer sr;

    private void Start()
    {
        sr = GetComponent<SpriteRenderer>();
    }
    private void Update()
    {
        if (AttackCooldown > 0f) 
        { AttackCooldown -= Time.deltaTime; }

        Vector2 pos = transform.position;

        if (MovingRight) 
        {
            pos.x += 1f * Time.deltaTime;
        }
        else 
        {
            pos.x -= 1f * Time.deltaTime;
        }
        transform.position = pos;

        if (SwitchTimer <= 0f) 
        {
            SwitchTimer = 3f;
            MovingRight = !MovingRight;//if (MovingRight) { MovingRight = false; } else {MovingRight = true;}
            sr.flipX = !sr.flipX;
        }
        SwitchTimer -= Time.deltaTime;
    }

    //-----------‰Âˆ¤•ªŠ„üOuOb--------------------
    void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.name == "Player")
        {
            PlayerStatus status = other.gameObject.GetComponent<PlayerStatus>();

            // Ÿ“—LèªgË˜ğ€–S
            if (status.isInvisible == false && AttackCooldown <= 0) 
            {
                status.TakingDamage(1);
                AttackCooldown = 1f;
            }
        }
    }
}