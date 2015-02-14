#pragma strict

private var startLane = 0.0;
private var lane = 0.0;
private var duration = 0.25;
private var elapsedTime = 0.0;
private var axis = 0.0;
 
function Update() {

	if(elapsedTime > duration){
		axis = Input.GetAxis("Horizontal"); 
				
		if(lane >= 0.0 && axis < 0){
			Debug.Log("esquerda");
			startLane = lane;
			lane -= 1;
			elapsedTime = 0.0;
		}
		if(lane <= 0.0 && axis > 0){
			Debug.Log("direita");
			startLane = lane;
			lane += 1;
			elapsedTime = 0.0;		
		}

	}

	transform.localPosition.x = lane;
	//transform.position.x = Interpolate.EaseOutSine(startLane, lane, elapsedTime, duration);
	elapsedTime += Time.deltaTime;
	
    
    Debug.Log("elapsedTime: " + elapsedTime);
    Debug.Log("startLane: " + startLane);
	Debug.Log("lane: " + lane);
	
}
