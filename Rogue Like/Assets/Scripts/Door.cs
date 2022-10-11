using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    private GameManager gm; //Gamemanager script
    public float doorDelay = 0.5f; // How long it will take the door to open

    // Start is called before the first frame update
    void Start()
    {
        gm = GameObject.Find("GameManager").GetComponent<GameManager>(); //Finding gamemanager object and referencing component
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player") && gm.key >= 1)
        {
            Destroy(gameObject, doorDelay);
            gm.key--;
            Debug.Log("Keys = " + gm.key);
            Debug.Log("Door is open!");
        }
        else
        {
            Debug.Log("Door is locked. You need a key");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
