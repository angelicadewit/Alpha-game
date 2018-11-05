using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravitySwitch : MonoBehaviour {

    private Rigidbody2D rb;
    private bool top;
    private PlayerController player;


    private void Start()
    {
        player = GetComponent<PlayerController>();
        rb = GetComponent<Rigidbody2D>();
    }


    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)){
            rb.gravityScale *= -1;
            Rotation();
        }
    }



    void Rotation(){
        if (top == false) {
            transform.eulerAngles = new Vector3(0, 0, 180f);
        } else {
            transform.eulerAngles = Vector3.zero;
        }
        player.facingRight = !player.facingRight; 
        top = !top;
    }


}


