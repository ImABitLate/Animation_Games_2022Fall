using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hanger : PickUp
{
    private GameManager gm;//set up game manager

    // Start is called before the first frame update
    void Start()
    {
        gm = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
