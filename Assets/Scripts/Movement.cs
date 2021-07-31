using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private float speed;
    private bool isFacingRight = false;
    private Rigidbody2D rb;
    private Animator animator;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float verticalInput = Input.GetAxisRaw("Vertical");
        float horizontalInput = Input.GetAxisRaw("Horizontal");

        rb.velocity =
            new Vector2(horizontalInput * speed, verticalInput * speed);

        if (
            (isFacingRight && horizontalInput < 0) ||
            (!isFacingRight && horizontalInput > 0)
        ) Flip();

        animator.SetBool("isMoving", CheckIsMoving());
        
        ClientSend.PlayerMovement();
    }

    void Flip()
    {
        isFacingRight = !isFacingRight;
        Vector3 Scaler = transform.localScale;
        Scaler.x *= -1;
        transform.localScale = Scaler;
    }

    bool CheckIsMoving()
    {
        if (rb.velocity.x == 0 && rb.velocity.y == 0) 
            return false;
        return true;
    }
}
