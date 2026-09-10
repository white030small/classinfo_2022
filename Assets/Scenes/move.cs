using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    [Header("角色移動")]
    public float moveInputX;
    public Rigidbody2D rb;
    public float speed = 0.5f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        moveInputX = Input.GetAxisRaw("Horizontal");//左是-1，右是1

        rb.velocity = new Vector2(moveInputX * speed ,rb.velocity.y);

    }
}
