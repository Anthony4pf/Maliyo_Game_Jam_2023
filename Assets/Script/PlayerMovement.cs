using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    private SpriteRenderer sprite;
    private BoxCollider2D boxCollider;

    //[SerializeField] private LayerMask jumpableGround;
    private float faceDirectionX;
    [SerializeField] private float moveSpeed = 7f;
    [SerializeField] private float jumpForce = 14f;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sprite = GetComponent<SpriteRenderer>();
        boxCollider = GetComponent<BoxCollider2D>();
    }

    void Update()
    {
        faceDirectionX = Input.GetAxis("Horizontal");
        HandleMovement();
        if (Input.GetButtonDown("Jump"))
        {
            rb.velocity = new Vector3(rb.velocity.x, jumpForce);
        }

    }

    private void HandleMovement()
    {
        rb.velocity = new Vector2(faceDirectionX * moveSpeed, rb.velocity.y);
    }

    public void Jump()
    {
        rb.velocity = new Vector3(rb.velocity.x, jumpForce);

    }

}