using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Testing : MonoBehaviour
{
    public int score = 7;
    public int highscore = 10;
    private int temp = 70;
    public float location = 0.0f;
    public float loc2 = 1.5f; 

    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log("Hello, World!");
        score += 2; 
        Debug.Log(score + highscore);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            Debug.Log("D was pressed"); 
        }
        if (Input.GetKeyDown(KeyCode.L))
        {
            Debug.Log("location: " + 0.5f);
        }
    }
}
