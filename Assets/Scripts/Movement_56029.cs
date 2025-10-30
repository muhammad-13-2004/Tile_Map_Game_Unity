using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement_56029 : MonoBehaviour
{
    public float moveSpeed = 5f;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");

        Vector2 newPos = new Vector2(moveX, moveY).normalized;
        rb.velocity = newPos * moveSpeed;
    }
}
