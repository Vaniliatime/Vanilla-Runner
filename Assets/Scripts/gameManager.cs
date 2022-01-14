
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameManager : MonoBehaviour
{

    public float score;
    public float highscore;
    public static gameManager inst;

    public Text scoreText;
    public Text highscoretext;

    public void IncrementScore()
    {
        score++;

    }

    private void Awake()
    {
        inst = this;
    }


    void Start()
    {
        highscore = PlayerPrefs.GetFloat("Highscore");
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score: " + score.ToString();
        highscoretext.text = "Highscore: " + highscore.ToString();

        if (score > highscore)
        {
            PlayerPrefs.SetFloat("Highscore", score);
        }
    }


}
