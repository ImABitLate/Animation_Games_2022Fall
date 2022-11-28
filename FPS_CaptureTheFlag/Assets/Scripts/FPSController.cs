using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPSController : MonoBehaviour
{
    //Global Variable
    [Header("Player Stats")]
    public float moveSpeed; // movement speed in units per second
    public float jumpForce; // force  applied to the y axis to make the player jump up

    [Header("Camera Info")]
    public float lookSensitivity; // mouse look sensitivity
    public float maxLooksx; // lowest point we can look down
    public float minLooksx; // highest point we can look up
    public float rotX; // Current x rotation of the camera

    [Header("Pirvate Variables")]
    private Camera camera; // reference the main camera
    private Rigidbody rb; // reference the rigidbody component

    void Awake()
    {
        //Get Components
        camera = Camera.main;
        rb = GetComponent<Rigidbody>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMove();
    }

    void PlayerMove()
    {
        float x = Input.GetAxis("Horizontal") * moveSpeed; // Get left and right input
        float z = Input.GetAxis("Vertical") * moveSpeed; // Get forward and back input

        rb.velocity = new Vector3(x, rb.velocity.y, z); //Applys velocity on x and z axises. It makes the player move.
    }

    void CameraLook()
    {
        float y = Input.GetAxis("Mouse X") * lookSensitivity;
        rotX += Input.GetAxis("Mouse Y") * lookSensitivity;
    }
}
