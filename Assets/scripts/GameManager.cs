using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
	public int score = 0;
	public GameObject scoreObject;
	Text scoreText;
	
    // Start is called before the first frame update
    void Start()
    {
        scoreText = scoreObject.GetComponent<Text>();
		scoreText.text = "Score: " + score.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	
	public void addScore(int amount) {
		score += amount;
		scoreText.text = "Score: " + score.ToString();
	}
}
