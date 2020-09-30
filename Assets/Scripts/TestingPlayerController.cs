using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestingPlayerController : MonoBehaviour
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
        SpawnPuck();
        SpawnBlocky(); 
    }

    void SpawnPuck()
    {
        Debug.Log(Random.Range(1.0f,10.0f)); 
        Instantiate(Puck,new Vector2(Random.Range(-9.0f,9.0f),Random.Range(-6.0f,6.0f)), Quaternion.identity); 
    }

    void SpawnBlocky()
    {
        Debug.Log(Random.Range(1.0f, 10.0f));
        Instantiate(Blocky, new Vector2(Random.Range(-9.0f, 9.0f), Random.Range(-6.0f, 6.0f)), Quaternion.identity);
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

    void OnCollisionEnter(Collision collision)
    {
        //if it's tagged as "blocky":
        if (collision.gameObject.tag == "Blocky")
        {
            //add 5 to score
            Debug.Log("Hit Blocky");
        }
        //if it's tagged as "puck":
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
