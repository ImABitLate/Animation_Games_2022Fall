using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : PickUp
{

    private GameManager gm;//set up game manager


    // Start is called before the first frame update
    void Start()
    {
        gm = GameObject.Find("GameManager").GetComponent<GameManager>();
    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            gm.AddCoin(amount);
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
