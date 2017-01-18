using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum GameState{
	menu,
	inGame,
	gameOver
}

public class GameManager : MonoBehaviour {

	public static GameManager instance;
	public GameState currentGameState = GameState.menu;

	void Awake(){
		instance = this;
	}

	void Update(){
		if(Input.GetButtonDown("s")){
			startGame ();
		}
	}


	// called when the game starts 
	public void startGame(){
		setGameState(GameState.inGame);
	}

	// called when failure condition is met
	public void gameOver(){
		setGameState(GameState.gameOver);
	}

	// called to take player back to main menu
	public void backToMenu(){
		setGameState(GameState.menu);
	}

	void setGameState(GameState newGameState){
		if (newGameState == GameState.menu) {

		}

		else if(newGameState == GameState.inGame){
			
		}

		else if(newGameState == GameState.gameOver){
			
		}

		currentGameState = newGameState;
	}
}
