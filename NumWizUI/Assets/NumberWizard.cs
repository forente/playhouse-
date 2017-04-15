using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NumberWizard : MonoBehaviour {

	// Use this for initialization
	int max;
	int min;
	int guess;

	public Text guessText;

	public int maxGuessesAllowed = 2;

	void Start () {
		startGame();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.UpArrow)){
			
			//print("Up arrow pressed");	
			guessHigher();

		}else if (Input.GetKeyDown(KeyCode.DownArrow)){
			
			//print("Down arrow pressed");
			guessLower();

		}
	}

	public void guessHigher(){
			min = guess;
			nextGuess();
	}

	public void guessLower(){
			max = guess;
			nextGuess();
	}
	void startGame(){
		 max = 1000;
		 min = 1;
		 guess = 500; 

		 max++;

	}

	void nextGuess(){
		guess  =  Random.Range(min, max);
		guessText.text = guess.ToString();
		maxGuessesAllowed--;
		Debug.Log("guess " + maxGuessesAllowed);
		if (maxGuessesAllowed <= 0 ){
			SceneManager.LoadScene("win");
			Debug.Log("you win");
		}
	}
}
