using UnityEngine;

public class PlayerStatus : MonoBehaviour
{
    [Header("玩家狀態")]
    public int HP = 1;           // 生命值
    public Transform spawn;      // 復活點＆重生點

    [Header("隱身設定")]
    public KeyCode invisibleKey = KeyCode.Q;   // 隱身鍵（可在 Inspector 更改）
    public float invisibleTime = 3f;           // 隱身持續時間（秒）
    public bool isInvisible;                   // 是否隱身中

    private float timer;

    private Rigidbody2D rb;
    private SpriteRenderer sr;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        // 按下隱身鍵，而且目前不在隱身中，才開始隱身
        if (Input.GetKeyDown(invisibleKey) && isInvisible == false)
        {
            isInvisible = true;
            timer = invisibleTime;   // 設定倒數時間
            SetAlpha();
        }

        // 隱身中：倒數計時，時間到就現身
        if (isInvisible)
        {
            timer -= Time.deltaTime;

            if (timer <= 0)
            {
                isInvisible = false;
                SetAlpha();
            }
        }
    }


    // 隱身時透明度 10%，現身時 100%
    void SetAlpha()
    {
        Color c = sr.color;
        if (isInvisible)
        {
            c.a = 0.1f;
        }
        else
        {
            c.a = 1f;
        }
        sr.color = c;
    }

    public void isDead()
    {
        transform.position = spawn.position;
        rb.velocity = Vector2.zero;   // 把速度歸零，避免帶著掉落速度復活
    }
}
