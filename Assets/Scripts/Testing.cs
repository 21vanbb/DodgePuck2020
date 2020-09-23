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
    public int speed = 10;
    public float xRange = 9.0f;
    public float yRange = 6.0f;
    public GameObject Puck; 
    public GameObject Blocky; 

    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log("Hello, World!");
        score += 2; 
        Debug.Log(score + highscore);
        //function: named set of instructions i.e. a recipe
        BrennaFunction();
    }

    void BrennaFunction()
    {
        Debug.Log("BrennaFunction has run");
        Instantiate(Puck,new Vector2(0,0), Quaternion.identity); 
    }

    // Update is called once per frame
    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        Debug.Log(moveHorizontal); 
        float moveVertical = Input.GetAxis("Vertical");
        Vector2 movement = new Vector2(moveHorizontal, moveVertical);
        transform.Translate(movement * speed * Time.deltaTime);
        //if (Input.GetKeyDown(KeyCode.D))
        //{
        //    Debug.Log(Input.GetAxis("Horizontal"));
        //    transform.Translate(Vector2.right * speed * Time.deltaTime);
        //}
        //if (Input.GetKeyDown(KeyCode.L))
        //{
            //Debug.Log("location: " + 0.5f);
        //}
    }

    private void LateUpdate()
    {
        //Keep player in bounds of xRange and yRange
        if (transform.position.x > xRange)
        {
            transform.position = new Vector2(xRange, transform.position.y); 
        }
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector2(-xRange, transform.position.y); 
        }
        if (transform.position.y > yRange)
        {
            transform.position = new Vector2(yRange, transform.position.x);
        }
        if (transform.position.y < -yRange)
        {
            transform.position = new Vector2(-yRange, transform.position.x);
        }
    }
}
