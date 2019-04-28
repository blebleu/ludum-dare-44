using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Highscore : MonoBehaviour{


    TextMeshProUGUI highScoreText;
    float highScore;
    public GameObject currentScore;
    float score;


    // Start is called before the first frame update
    void Start()
    {
        highScoreText = GetComponent<TextMeshProUGUI>();
        highScore = PlayerPrefs.GetFloat("HighScore", 0);
    }

    // Update is called once per frame
    void Update()
    {
        score = currentScore.GetComponent<Score>().moneyTotal;
        if (score > highScore)
        {
            PlayerPrefs.SetFloat("HighScore", score);
        }
        highScore = PlayerPrefs.GetFloat("HighScore", 0);

        highScoreText.text = "$" + highScore.ToString("f2");
    }
}
