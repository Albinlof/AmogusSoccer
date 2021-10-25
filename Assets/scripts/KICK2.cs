using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KICK2 : MonoBehaviour
{

    public Rigidbody2D rigidBody2D;
    private bool input;
    private int counter = 0;
    public float speed;
    float x, y;
    bool dash;
    float dasher = 0;
    void Start()
    {
        rigidBody2D = GetComponentInParent<Rigidbody2D>();
        x = rigidBody2D.position.x;
        y = rigidBody2D.position.y;
        rigidBody2D.rotation = 0f;
    }


    private void Update()
    {
        x = rigidBody2D.position.x;
        y = rigidBody2D.position.y;
    }
    void FixedUpdate()
    {
        input = Input.GetKeyDown("-");
        if (input == true)
        {
            rigidBody2D.rotation = -10f;
            transform.localRotation = Quaternion.Euler(0, 0, -45);
            Vector3 move = new Vector3(x - 0.5f, y + (-0.119f), 0);
            rigidBody2D.MovePosition(move);

            counter = 0;
        }
        else
        {
            counter++;
        }
        if (counter == 20)
        {
            transform.localRotation = Quaternion.Euler(0, 0, 0);
            Vector3 move = new Vector3(x, y, 0);
            rigidBody2D.MovePosition(move);
            rigidBody2D.rotation = 0f;
        }

        if (Input.GetKeyDown(KeyCode.RightShift))
        {
            dash = true;
        }

        if (dash == true)
        {
            dasher += 0.5f;
            Vector3 dash = new Vector3(x - dasher, y + (-0.119f), 0);
            rigidBody2D.MovePosition(dash);
        }
        if (dasher == 2.0f)
        {
            dash = false;
            dasher = 0.0f;
        }

    }

}


