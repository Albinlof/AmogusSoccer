using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;



public class goaldetection : MonoBehaviour
{

    public LayerMask isGoal;
    [SerializeField] Transform goalCheck;
    [SerializeField] float goalCheckRadius;
    private bool goal;
    private int goal1 = 0, goal2 = 0;
    private Rigidbody2D ball;
    [SerializeField] public GameObject score;
    private string poangen;

    // Start is called before the first frame update
    void Start()
    {
        ball = GetComponent<Rigidbody2D>();

        GameObject texten = GameObject.Find("gamescore");
        goaltext scorescript = texten.GetComponent<goaltext>();
    }

    // Update is called once per frame
    void Update()
    {
       

        if ((ball.position.x < -13.5 && ball.position.y < 4) || (ball.position.x > 13.35 && ball.position.y < 4))
            {
            Vector3 reset = new Vector3(0, 5, 0);
            ball.MovePosition(reset);
            ball.velocity = new Vector3(0, 0);
            if (ball.position.x < -13.5)
            {
                goal1++;
               
            }
            else if(ball.position.x > 13.35 && ball.position.y < 4)
            {
                goal2++;
               
            }
               
                
            poangen = goal2 + " - " + goal1;
            GameObject gamescore = GameObject.Find("gamescore");
            goaltext goaltext = gamescore.GetComponent<goaltext>();
            goaltext.score = poangen;

            
        }
   
    }
}

