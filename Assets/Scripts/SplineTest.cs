using UnityEngine;
using System.Collections;

public class SplineTest : MonoBehaviour {

	public Transform[] path;
	public float speed = 0.5f;
	
	float t = 0;
	private SmoothQuaternion sr;
	Quaternion q;
	
	void Start() {
		sr = transform.rotation;
		sr.Duration = 0.5f;
	}

	// Update is called once per frame
	void Update () {
		transform.position = Spline.MoveOnPath(path, transform.position, ref t, ref q, speed, 50, EasingType.Sine, true, true);
		sr.Value = q;
		transform.rotation = sr;
	}
}
