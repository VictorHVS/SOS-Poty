using UnityEngine;
using System.Collections;

public class TouchBarcoScript : MonoBehaviour{

	public float velocity;	
	private Vector3 move = Vector3.zero;
	private bool isMovingLeft;
	private bool isMovingRight;
	public Animator anim;
	public float minSwipeDistY;
	public float minSwipeDistX;
	private Vector2 startPos;

	void Start(){
		isMovingLeft = false;
		isMovingRight = false;
		move = transform.localPosition;
	}
	
	void Update(){
		//#if UNITY_ANDROID
		if (Input.touchCount > 0){	
			Touch touch = Input.touches[0];
			switch (touch.phase){
				
				case TouchPhase.Began:
				
					startPos = touch.position;
				
					break;
				case TouchPhase.Ended:
				
					float swipeDistVertical = (new Vector3(0, touch.position.y, 0) - new Vector3(0, startPos.y, 0)).magnitude;
				
					if (swipeDistVertical > minSwipeDistY){
					
						float swipeValue = Mathf.Sign(touch.position.y - startPos.y);
					
					if (swipeValue > 0){//up swipe
						//Jump ();
						}else if (swipeValue < 0){//down swipe
							//Shrink ();
						}
					}
				
					float swipeDistHorizontal = (new Vector3(touch.position.x,0, 0) - new Vector3(startPos.x, 0, 0)).magnitude;
				
					if (swipeDistHorizontal > minSwipeDistX){
					
						float swipeValue = Mathf.Sign(touch.position.x - startPos.x);
					
					if (swipeValue > 0 && move.x < 0.9f && !isMovingLeft) {
						isMovingRight = true;
						anim.SetBool ("dobrarDireita", true);
					}
					if (swipeValue < 0 && move.x > -0.9f && !isMovingRight) {
							isMovingLeft = true;
							anim.SetBool ("dobrarEsquerda", true);
					}		
					}
				break;
			}
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