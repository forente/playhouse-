using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class TextController : MonoBehaviour {

	public Text text;
	private enum States{ }
	private States myState; 
	// Use this for initialization
	void Start () {
		text.text = "Are you ready to continue on your adventure?";
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Space))
		{
			text.text = "You find yourslef on the coast of the sea town of Moleno. "+
						"The inhabittance of the town seem to be concerned about your sudden appearance. \n\n" +
						" What do you do?";
		}
	}
}
