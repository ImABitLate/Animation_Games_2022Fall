using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balloon : MonoBehaviour
{
    //public int scoreToGive = 100; // Score give for popped balloon

    public float clickToPop = 3; //How many clicks before balloon pops

    public float scaleToIncrease = 0.0f; //Scale increase each time the ballon is clicked

    //public ScoreManager ScoreManager; //A variable to reference the Score Manager
    // Start is called before the first frame update


    void Start()
    {
        //Reference ScoreManager Component
        //scoreManager = GameObject.Find("ScoreManager").
        
    }

    void OnMouseDown()
    {
        //reduce clicks by one
        clickToPop -= 1;

        //Increase balloon volume
        transform.localScale += Vector3.one * scaleToIncrease;

        if(clickToPop == 0)
        {
            //ScoreManager.IncreaseScoreText(scoreToGive);

            Destroy(gameObject);
        }
    }
}
