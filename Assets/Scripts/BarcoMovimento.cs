using UnityEngine;
using System.Collections;

public class BarcoMovimento : MonoBehaviour {

	public float velocity;

	private Vector3 move = Vector3.zero;

	private bool isMovingLeft;
	private bool isMovingRight;
	public Animator anim;
	
	void Start () {
		isMovingLeft = false;
		isMovingRight = false;
		move = transform.localPosition;
	}

	void Update () {

		if ((Input.GetKeyDown (KeyCode.A)) && move.x > -0.9f && !isMovingRight) {
			isMovingLeft = true;
			anim.SetBool ("dobrarEsquerda", true);
		}
		if ((Input.GetKeyDown (KeyCode.D)) && move.x < 0.9f && !isMovingLeft) {
			isMovingRight = true;
			anim.SetBool ("dobrarDireita", true);
		}

		if (isMovingRight && transform.localPosition.x < 1.02 && !isMovingLeft) {
			move.x += velocity;
		}
		if (isMovingLeft && transform.localPosition.x > -1.02 && !isMovingRight) {
			move.x -= velocity;
		}

		if (move.x > 0.9f || move.x < -0.9f) {
			isMovingRight = false;
			isMovingLeft = false;
		}

		if(move.x > 0f && move.x < 0.01f || move.x < 0f && move.x > -0.01f) {
			isMovingRight = false;
			isMovingLeft = false;
		}

		if(!isMovingLeft){
			anim.SetBool ("dobrarEsquerda", false);
		}
		if(!isMovingRight){
			anim.SetBool ("dobrarDireita", false);
		}


		transform.localPosition = move;
	}
}
