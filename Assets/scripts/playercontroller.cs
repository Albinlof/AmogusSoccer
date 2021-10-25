using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class playercontroller : MonoBehaviour
{

    private Rigidbody2D rb;
    private float input;
    private float inputY;
    [SerializeField] private float speed, jumpForce, groundCheckRadius;
    [SerializeField] int numJumps;
    [SerializeField] bool canJump;
    [SerializeField] Transform groundCheck;
    public LayerMask isGround;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {




        if(canJump)
        {
            numJumps = 1;
        }
      if(Input.GetKeyDown(KeyCode.UpArrow) && numJumps > 0)
        {
            rb.velocity = Vector2.up * jumpForce;
            numJumps--;
        } 
    }

    private void FixedUpdate()
    {
        MoveAmogus();
    }
    void MoveAmogus()
    {

        canJump = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, isGround);
        input = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(input * speed, rb.velocity.y);
    }



}
