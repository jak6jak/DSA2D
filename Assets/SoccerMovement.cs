using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoccerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float rotateAmount = -1 * Input.GetAxis("Horizontal");
        Vector3 rotation3D = new Vector3(0,0,rotateAmount);
        this.transform.Rotate(rotation3D);
        if(Input.GetMouseButton(0)){
            Rigidbody2D rb = this.GetComponent<Rigidbody2D>();
            rb.AddForce(this.transform.right * speed);
        }
    }
}