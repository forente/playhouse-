using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour {

	public static LevelGenerator instance;
	//blueprint level pieces 
	public List<LevelPiece> levelPrefabs = new List<LevelPiece>();
	//starting point of the level piece 
	public Transform levelStartPoint;
	//current level pieces in the level
	public List<LevelPiece> pieces = new List<LevelPiece>();

	void Awake(){
		instance = this;
	}

	public void addPiece(){
		// generate random int 
		int randomIndex = Random.Range(1,levelPrefabs.Count);
		// Instantiate copy of a random level prefab 
		LevelPiece piece = (LevelPiece)Instantiate(levelPrefabs[randomIndex]);
		piece.transform.SetParent(this.transform,false);

		Vector3 spawnPosition = Vector3.zero;

		if(pieces.Count == 0){
			spawnPosition  = levelStartPoint.position;
		}
		else{
			spawnPosition = pieces[pieces.Count].exitPoint.position;
		}

		piece.transform.position = spawnPosition;
		pieces.Add(piece);

	}
}
