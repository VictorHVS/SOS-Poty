using UnityEngine;
using System.Collections;

public class ButtonsBehaviors : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void newGame(){
		Application.LoadLevel ("Rio"); 
	}

	public void exit(){
		Application.Quit(); 
	}
}
