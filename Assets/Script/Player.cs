using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{   
    [SerializeField] public GameObject gameOver;
    private bool canPlay = true;
    private bool right = false;
    private bool jumpNow = false;
    private Rigidbody2D rb = null;
    private float jumpStart = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        gameOver.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        float xSpeed = 0.0f;
        float ySpeed = 0.0f;
        float jumpMax = 200.0f;

        if(canPlay == true){
            if(jumpMax < transform.position.y - jumpStart){
                jumpNow = false;
            }

            if(jumpNow){
                if(right){
                    xSpeed = 50.0f;
                }
                else{
                    xSpeed = -50.0f;
                }
                ySpeed = 300.0f;
            }
            else{
                if(right){
                    xSpeed = 200.0f;
                }
                else{
                    xSpeed = -200.0f;
                }
                ySpeed = -200.0f;
            }
        }

        rb.velocity = new Vector2(xSpeed, ySpeed);
    }

    public void Press(){
        Debug.Log("press jump");
        right = !right;
        jumpNow = true;
        jumpStart = transform.position.y;
    }

    private void OnTriggerEnter2D(Collider2D collision){
        gameOver.SetActive(true);
        Debug.Log("game over");
        canPlay = false;
    }
}
