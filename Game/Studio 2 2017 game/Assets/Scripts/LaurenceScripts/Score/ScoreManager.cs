using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {

    //crated by laurence peat

    public Text ScoreText;
    public Text HighScoreText;

    public float scorecount;
    public float highscorecount;

    public float pointspersec;

    public bool scoreincresing;

	// Use this for initialization
	void Start ()
    {
		// gettign previous game score
        if(PlayerPrefs.HasKey("HighScore"))
        {
            highscorecount = PlayerPrefs.GetFloat("HighScore");
        }
	}

    // Update is called once per frame



    void Update ()
    {
        
        //setting the score to increase over time
        if (scoreincresing)
        {
            scorecount += pointspersec * Time.deltaTime;
        }
       
        //setting a high score
        if (scorecount > highscorecount)
        {
            highscorecount = scorecount;
            //saves value onto computor
            PlayerPrefs.SetFloat("HighScore", highscorecount);
        }
        //"death" / "reset" mechanic for resetting scorecount
        if (Input.GetKeyDown(KeyCode.Space))
        {
            scoreincresing = false;
            scorecount = 0;
            scoreincresing = true;
        }

        // stting the score & highscore to be displayed
        ScoreText.text = "Score: " + Mathf.Round(scorecount);

        HighScoreText.text = "High Score: " + Mathf.Round (highscorecount);
	}
}
