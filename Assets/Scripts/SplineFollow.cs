using UnityEngine;
using System.Collections;

public class SplineFollow : MonoBehaviour {

	public Transform spline;

	private Transform[] path;
	public float speed = 4.0f;
	
	float t = 0;
	private SmoothQuaternion sr;
	Quaternion q;
	
	void Start() {
		sr = transform.rotation;
		sr.Duration = 0.5f;
		path = spline.gameObject.GetComponentsInChildren<Transform>();
	}

	// Update is called once per frame
	void Update () {
		transform.position = Spline.MoveOnPath(path, transform.position, ref t, ref q, speed, 50, EasingType.Sine, true, true);
		sr.Value = q;
		transform.rotation = sr;
	}
}
