using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class goaltext : MonoBehaviour
{
    public string score = "0 - 0";
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        GetComponent<Text>().text = score;
    }
}
