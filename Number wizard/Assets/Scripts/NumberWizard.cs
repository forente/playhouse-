using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour {

	// Use this for initialization
	int max;
	int min;
	int guess;

	void Start () {
		startGame();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.UpArrow)){
			
			//print("Up arrow pressed");	
			min = guess;
			nextGuess();
		}else if (Input.GetKeyDown(KeyCode.DownArrow)){
			
			//print("Down arrow pressed");
			max = guess;
			nextGuess();
		}else if (Input.GetKeyDown(KeyCode.Return)){
			print("I have won!");	
			startGame();
		}
	}

	void startGame(){
		 max = 1000;
		 min = 1;
		 guess = 500; 
		 print("**************************");
		print("Welcome to Number wizard! ");
		print("Pick an number in your head and hold onto it.");

		 max = 1001;
		 min = 1;

		print("The highest number you can pick is " +max);
		print("The lowest number you can pick is " +min);

		print("Is the number higher of lower that 500?");
		print("Up = Higher, Down = Lower, return");
	}

	void nextGuess(){
		guess  =  Random.Range(min, max);
		print("higher or lower that " +guess);
		print("Up = Higher, Down = Lower, return");
	}
}
