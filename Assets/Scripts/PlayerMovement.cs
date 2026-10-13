using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [Header("移動設定")]
    public float moveSpeed = 5f;
    public KeyCode SprintKey = KeyCode.LeftShift;
    public float sprintSpeed = 8f;//衝刺速度

    [Header("跳躍設定")]
    public KeyCode jumpKey = KeyCode.Space;//跳躍鍵（預設空白鍵）
    public float jumpForce = 12f;//跳躍力道

    [Header("地面偵測")]
    public LayerMask groundLayer;    // 設成地板的 Layer
    bool isGrounded;//偵測是否碰觸地板

    private Rigidbody2D rb;
    private Collider2D coll;
    private float moveInput;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        coll = GetComponent<Collider2D>();
        rb.freezeRotation = true; // 避免角色碰撞後翻倒
    }

    void Update()
    {
        moveInput = Input.GetAxisRaw("Horizontal");

        isGrounded = coll.IsTouchingLayers(groundLayer);

        // 當空白鍵被按下時跳躍
        if (Input.GetKeyDown(jumpKey) && isGrounded)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
        }

        // E：互動
        if (Input.GetKeyDown(KeyCode.E))
        {
            Interact();
        }
    }

    void FixedUpdate()
    {
        float speed;
        if (Input.GetKey(SprintKey)) 
        {
            speed = sprintSpeed;
        }
        else 
        {
            speed = moveSpeed;
        }
        rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);
    }
    void Interact()
    {
        Debug.Log("按下 E 互動");
    }
}