using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System;

public class Bot : MonoBehaviour
{
    float xSpeed = 0.0f;
    float ySpeed = 0.0f;
    float maxSpeed = 500.0f;
    float xMove = 0.0f;
    float yMove = 0.0f;
    private Rigidbody2D rb = null;
    
    // Start is called before the first frame update
    void Start()
    {   
        UnityEngine.Random.InitState(System.DateTime.Now.Millisecond + (int)(this.name[3]));
        Debug.Log(this.name[3]);

        rb = GetComponent<Rigidbody2D>();
        xSpeed = 100.0f;
        ySpeed = 100.0f;
        xMove = xSpeed * (UnityEngine.Random.Range(0, 2) * 2 - 1);  // -1 or 1
        yMove = ySpeed * (UnityEngine.Random.Range(0, 2) * 2 - 1);
        rb.velocity = new Vector2(xMove, yMove);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision){
        Debug.Log("clash");

        if(xSpeed<maxSpeed){
            xSpeed = xSpeed + UnityEngine.Random.Range(0f,100.0f);
        }
        else{
            xSpeed = maxSpeed;
        }
        if(ySpeed<maxSpeed){
            ySpeed = ySpeed + UnityEngine.Random.Range(0f,100.0f);
        }
        else{
            ySpeed = maxSpeed;
        }

        xMove = Math.Sign(xMove) * xSpeed * UnityEngine.Random.Range(0.1f,2.0f);
        yMove = Math.Sign(yMove) * ySpeed * UnityEngine.Random.Range(0.1f,2.0f);
        if(collision.gameObject.name == "bottom"){
            Debug.Log("bottom");
            yMove = ySpeed;
        }
        else if(collision.gameObject.name == "top"){
            Debug.Log("top");
            yMove = ySpeed * -1;
        }
        else if(collision.gameObject.name == "left"){
            Debug.Log("left");
            xMove = xSpeed;
        }
       else if(collision.gameObject.name == "right"){
            Debug.Log("right");
            xMove = xSpeed * -1;
        }

        rb.velocity = new Vector2(xMove, yMove);
        Debug.Log($"{xSpeed}, {ySpeed},{xMove}, {yMove}");
    }
}
