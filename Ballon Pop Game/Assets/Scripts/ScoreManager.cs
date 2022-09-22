using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public int score; //keep track of the score
    public TextMeshProUGUI scoreText; //Text UI object to be modified

    // Start is called before the first frame update
    void Start()
    {
        UpdateScoreText(); //Call UpdateScoreText function
    }

    public void IncreaseScoreText(int amount)
    {
        score += amount; //Increase score by amount
        UpdateScoreText(); //Update score UI text
    }

    public void DecreaseScoreText(int amount)
    {
        score -= amount;
        UpdateScoreText();
    }

    public void UpdateScoreText()
    {
        scoreText.text = "Score: " + score;
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
