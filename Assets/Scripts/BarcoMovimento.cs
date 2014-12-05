using UnityEngine;
using System.Collections;

public class BarcoMovimento : MonoBehaviour {
	
	public float velocity;

	private Vector3 move = Vector3.zero;

	private bool isMovingLeft;
	private bool isMovingRight;
	
	void Start () {
		isMovingLeft = false;
		isMovingRight = false;

		move = transform.localPosition;
	}

	void Update () {

		print (move.x);

		if (Input.GetKeyDown (KeyCode.A)) {
			isMovingLeft = true;
		}
		if (Input.GetKeyDown (KeyCode.D)) {
			isMovingRight = true;
		}

		if (isMovingRight && transform.localPosition.x < 1 && !isMovingLeft) {
			move.x += velocity;
		}
		if (isMovingLeft && transform.localPosition.x > -1 && !isMovingRight) {
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

		transform.localPosition = move;
	}
}
