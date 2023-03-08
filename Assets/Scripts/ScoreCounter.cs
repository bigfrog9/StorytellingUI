using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreCounter : MonoBehaviour
{
    
    public int Score;

    public TextMeshProUGUI countScore;


    // Start is called before the first frame update
    void Start()
    {
        Score = 0;
        writeScore();
    }

    public void writeScore()
    {
        

        countScore.text = Score.ToString();
    }

    public void plusFive()
    {
        Score = Score + 5;
        writeScore();
    }

    public void minusFive()
    {
        Score=Score - 5;

        if (Score < 0) { Score = 0; }

        writeScore();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
