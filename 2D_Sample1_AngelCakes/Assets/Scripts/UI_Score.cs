using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Score : MonoBehaviour {

	private Text uiText;
	private int score;
	[SerializeField]
	private int pointsToNextLevel;
	[SerializeField]
	private GameObject gameOverScreen;
	

	// Use this for initialization
	void Start () {
		uiText = GetComponent<Text>();
		// sum all the cakes
		foreach (CollectableCake cake in FindObjectsOfType<CollectableCake>())
		{
			pointsToNextLevel += cake.cakeValue;
		}
	}
	
	public void IncreaseScore(int points){
		// increase points
		score += points;
		// if player collect all points
		if (score >= pointsToNextLevel){
			// show game over
			gameOverScreen.SetActive(true);
			// disable player controller
			FindObjectOfType<PlayerController>().enabled = false;
		}
		// update score display
		uiText.text = "Score: "+ score.ToString();
	}

	// Update is called once per frame
	void Update () {
		
	}
}
