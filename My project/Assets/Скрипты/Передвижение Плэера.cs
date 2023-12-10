using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ПередвижениеПлэера : MonoBehaviour
{
    public float speed;
    public float jumpForce;
    private float moveInput;

    private Rigidbody2D rb;

    private bool facingRight = true;

    private bool isGrounded;
    public Transform feetPos;
    public float checkRadius;
    public LayerMask whatIsGround;

    private int extraJumps;
    public int extraJumpsValue;

    int playerObject, collideObject;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        extraJumps = extraJumpsValue;

        playerObject = LayerMask.NameToLayer("Ground");
        collideObject = LayerMask.NameToLayer("Collide");
    }
    private void FixedUpdate()
    {
        isGrounded = Physics2D.OverlapCircle(feetPos.position, checkRadius, whatIsGround);

        moveInput = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);

        if(facingRight == false && moveInput > 0)
        {
            Flip();
        }
        else if (facingRight == true && moveInput < 0)
        {
            Flip();
        }
    }
    private void Update()
    {  
        isGrounded = Physics2D.OverlapCircle(feetPos.position, checkRadius, whatIsGround);
        
        if(isGrounded == true)
        {
            extraJumps = extraJumpsValue;
        }
        
        
        if(Input.GetKeyDown(KeyCode.UpArrow) && extraJumps > 0)
        {
            rb.velocity = Vector2.up * jumpForce;
            extraJumps--;
        }else if (Input.GetKeyDown(KeyCode.UpArrow) && extraJumps == 0 && isGrounded == true)
        {
            rb.velocity = Vector2.up * jumpForce;
        }

        if (rb.velocity.y > 0 )
        {
            Physics2D.IgnoreLayerCollision(playerObject, collideObject, true);
        }
        else
        {
            Physics2D.IgnoreLayerCollision(playerObject, collideObject, false);
        }
        
    }
    void Flip()
    {
        facingRight = !facingRight;
        Vector3 Scaler = transform.localScale;
        Scaler.x *= -1;
        transform.localScale = Scaler;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "вода")
        {
            rb.transform.position = new Vector3(58.92f, 6.53f, 0);

        }
    }
}
