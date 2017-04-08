using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

	public void loadLevel( string name){
		Debug.Log(name);
		SceneManager.LoadScene(name);
	}

	public void quitRequest(){
		Debug.Log("Quiting game");
		Application.Quit();
	}
}
