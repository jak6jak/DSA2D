using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    
    public float speed =5;
    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.D)){
             rb.AddForce(new Vector2(speed,0));
        } else if(Input.GetKey(KeyCode.A)){
            rb.AddForce(new Vector2(-speed,0));
        }
       
    }
}
