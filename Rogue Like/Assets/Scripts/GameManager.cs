using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int key;
    public int coin;
    public int hanger;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void BreakHanger(int amount)
    {

    }

    public void AddCoin(int amount)
    {
        coin += amount;
        Debug.Log("You have " + coin + " chip(s).");
    }

    public void AddKey(int amount)
    {
        //Adding Key to key amount (key inventory)
        key += amount;
        Debug.Log("You have " + key + " plug(s).");
    }
}
