using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreTextScript: MonoBehaviour {

    int CurrentScore;
    Text ScoreText;

    void Awake()
    {
        CurrentScore = 0;
        ScoreText = this.GetComponent<Text>();
        printScore(CurrentScore);
    }

    // Use this for initialization
    void Start () {
    }

	// Update is called once per frame
	void Update () {
		
	}

    public void AddScore()
    {
        CurrentScore += 1;
        printScore(CurrentScore);
    }

    void printScore(int n)
    {
        ScoreText.text = "Score: " + n.ToString();
    }

}
