using UnityEngine;
using System.Collections;

public class MoveCamera : MonoBehaviour {

	public Transform cameraPosition;
	public Vector3[] positions = new Vector3[18];

	// Use this for initialization
	void Start () {
		GameObject first = GameObject.Find ("CameraPosition");
		positions[0] = first.transform.position;
	}
	
	// Update is called once per frame
	void Update () {

	}

	void moveCameraToPosition(Transform theCamera, Vector3 newPosition) {
		Debug.Log ("Moving camera");
		theCamera.transform.position = newPosition;
	}
}
