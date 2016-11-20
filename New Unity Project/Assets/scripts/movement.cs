using UnityEngine;
using System.Collections;

public class movement : MonoBehaviour {

	public float speed; 
	private Rigidbody rb;

	void Start (){
		rb = GetComponent<Rigidbody>();
		Debug.Log (rb);
	}
	

	void FixedUpdate () {
		 
		float moveHorizontal = Input.GetAxis ("Horizontal2");
		float moveVertical = Input.GetAxis ("Vertical2");

		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);

		rb.AddForce(movement * speed);
	}
}
