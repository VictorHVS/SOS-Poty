 using UnityEngine;
using System.Collections;

public class CharacterMotor : MonoBehaviour {

	public float velocity;
//	private Vector3 moveForward = Vector3.zero;
	private Vector3 moveLeft = Vector3.zero;
	private Vector3 moveRight = Vector3.zero;
	public float side;
	public int NumberTracks;
	private int currentTrack;
	public float a;


	void Start () {
		currentTrack = (NumberTracks/2)+1;
		a = -1;
	}
	
	// Update is called once per frame
	void Update () {

		//transform.rigidbody.velocity = moveLeft;

		//moveForward.z = velocity;

		//Refatorar isso!
		//transform.Translate(moveForward * Time.deltaTime);

		while (a < 1) {
			print(a + " a ");
			a += 0.001f;
		}

		if (Input.GetKeyDown(KeyCode.A)) {
			moveLeft = transform.localPosition;
			while (transform.localPosition.x > -1f) {
				moveLeft.x -= side;
				transform.localPosition = moveLeft;
				print("Position: " + moveLeft.x);
			}
			currentTrack -= 1;

		}
		if (Input.GetKeyDown(KeyCode.D) && currentTrack < NumberTracks) {
			moveRight = transform.position;
			//moveRight.x += side;
			transform.position = moveRight;
			currentTrack += 1;
		}
	
	}

}
