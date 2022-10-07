using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : PickUp
{

    private GameManager gm;

    // Start is called before the first frame update
    void Start()
    {
        gm = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            gm.AddKey(amount);
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddKey(int amount)
    {
        //Adding Key to key amount (key inventory)
        key += amount;
        Debug.Log("You have " + key + " key(s).");
    }
}
