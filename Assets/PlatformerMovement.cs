using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformerMovement : MonoBehaviour
{
    Rigidbody2D rb;
    public float speed;
    public float JumpHeight = 50;
    public int MaxJumps = 2;
    private int jumpLeft= 2;
    public int score = 0;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }


    bool Grounded(){
        return Physics2D.Raycast(transform.position,Vector2.down,.5f, LayerMask.GetMask("UI"));
    }
    // Update is called once per frame
    void Update()
    {
        if(Grounded()){
            jumpLeft = MaxJumps;
        }
        Vector2 move = new Vector2(0,0);
        move.x = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        rb.position += move;

        if(Input.GetButtonDown("Jump") && jumpLeft > 0){
            rb.AddForce(new Vector2(0,JumpHeight), ForceMode2D.Impulse);
            jumpLeft--;
        }
    }

     private void OnTriggerEnter2D(Collider2D other){
        if(other.CompareTag("PickUp")){
            score ++;
        }
    }
}
