using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public static PlayerController instance;
	public float jumpForce = 25f;
	public float runningSpeed = 1.5f;
	public LayerMask groundLayer; 
	private Rigidbody2D rigidbody;
	public Animator animator; 
	private Vector3 startingPosition; 


	void Awake(){
		rigidbody = GetComponent<Rigidbody2D>();
		instance = this;
		startingPosition = this.transform.position;
	}
		
	
	// Update is called once per frame
	void Update () {
		if(GameManager.instance.currentGameState == GameState.inGame){
			if (Input.GetMouseButtonDown (0)) {
				jump ();
			}
			animator.SetBool ("isGrounded", isGrounded());
		}
	}

	void FixedUpdate(){
		if(GameManager.instance.currentGameState == GameState.inGame){
			if(rigidbody.velocity.x < runningSpeed){
				rigidbody.velocity = new Vector2 (runningSpeed , rigidbody.velocity.y);
			}
		}
	}

	public void StartGame(){
		animator.SetBool ("isAlive", true);
		this.transform.position = startingPosition;
	}

	void jump(){
		if(isGrounded()){
			rigidbody.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
		}
	}

	bool isGrounded(){
		if(Physics2D.Raycast(this.transform.position, Vector2.down, 0.2f, groundLayer)){
			return true;
		}
		else {
			return false;
		}
	}

		public void kill(){
		GameManager.instance.gameOver();
		animator.SetBool("isAlive", false);
	}
}
