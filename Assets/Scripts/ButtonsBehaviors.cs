using UnityEngine;
using System.Collections;

public class ButtonsBehaviors : MonoBehaviour {

	public GameObject text;
	public GameObject moviment;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

				if (Application.platform == RuntimePlatform.Android) {
						if (Input.GetKey (KeyCode.Escape)) {
								Application.Quit ();
				
								return;
						}
				}
	}

	public void showText(){
		text.SetActive (true);
		moviment.SetActive (false);
	}

	public void showMoviment(){
		text.SetActive (false);
		moviment.SetActive (true);
	}

	public void newGame(){
		Application.LoadLevel ("Cenario01"); 
	}

	public void exit(){
		Application.Quit(); 
	}

	public void toMenu(){
		Application.LoadLevel ("Menu");
	}

	public void toAbout(){
		Application.LoadLevel ("informacoes");
	}

	public void toCreditos(){
		Application.LoadLevel ("Creditos");
	}
}
