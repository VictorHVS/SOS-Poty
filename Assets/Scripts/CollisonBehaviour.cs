using UnityEngine;
using System.Collections;

public class CollisonBehaviour : MonoBehaviour {

	public GameObject plataform;
	public float distanceNewPlatform;
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter(Collision hit) {
		if(hit.transform.tag == "Plataform"){
			Vector3 aux = hit.transform.position;
			aux.z += distanceNewPlatform;
			Instantiate(plataform, aux, Quaternion.identity);
		}
		
	}
		
		



}
