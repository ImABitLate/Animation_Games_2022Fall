using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    // Access Mod, Data Type, Name ;
    public int speed; //set speed
    public float rotSpeed; // Rotation speed
    public float hInput; // horizontal input
    public float vInput; // vertical input
    public float jumpForce; // jump hight
    public Rigidbody playerRB; // reference Rigidbody component
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Collect input value from keyboard
        hInput = Input.GetAxis("Horizontal");
        vInput = Input.GetAxis("Vertical");

        //move the character around

        transform.Rotate(Vector3.up, rotSpeed * hInput * Time.deltaTime); //Rotate Left and Right

        transform.Translate(Vector3.forward * speed * vInput * Time.deltaTime); //Forward and Backward Movement

        if (Input.GetKeyDown(KeyCode.Space)) //if player hits the spacebar
            playerRB.AddForce(Vector3.up * jumpForce, ForceMode.Impulse); //Makes player jump
      
    }
}
