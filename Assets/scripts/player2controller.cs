using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class player2controller : MonoBehaviour
{

    private Rigidbody2D rb2;
    private float input;
    private float inputY;
    [SerializeField] private float speed, jumpForce, groundCheckRadius;
    [SerializeField] int numJumps;
    [SerializeField] bool canJump;
    [SerializeField] Transform groundCheck;
    [SerializeField] Transform goalCheck;
    public LayerMask isGround;
    public LayerMask isGoal;
    // Start is called before the first frame update
    void Start()
    {
        rb2 = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {




        if (canJump)
        {
            numJumps = 1;
        }
        if (Input.GetKeyDown(KeyCode.W) && numJumps > 0)
        {
            rb2.velocity = Vector2.up * jumpForce;
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
        input = Input.GetAxisRaw("Horizontal2");
        rb2.velocity = new Vector2(input * speed, rb2.velocity.y);
    }



}
