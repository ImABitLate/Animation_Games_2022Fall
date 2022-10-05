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
