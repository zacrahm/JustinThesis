using UnityEngine;
using System.Collections;

public class WaypointController : MonoBehaviour {
	public Transform mainCamera;
	public GameObject[] texts;
	public GameObject[] waypoints;
	public int waypointIndex = 0;



	// Use this for initialization
	void Start () {
		moveCameraToPosition (mainCamera, waypoints[0].transform.position);
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown("x")) {
			Debug.Log("x was pressed");
			toggleActive (texts[waypointIndex], false);
			waypointIndex++;
			if (waypointIndex == waypoints.Length) {
				waypointIndex = 0;
			} 
			toggleActive (texts[waypointIndex], true);
			moveCameraToPosition (mainCamera, waypoints[waypointIndex].transform.position);
		}
	}

	public void goToWaypoint(int index) {
		toggleActive (texts[waypointIndex], false);
		moveToWaypoint (index);

	}

	public void moveToWaypoint (int index) {
		waypointIndex = index;
		toggleActive (texts[waypointIndex], true);
		moveCameraToPosition (mainCamera, waypoints[index].transform.position); 
	}

	private void moveCameraToPosition(Transform moveTransform, Vector3 newPosition) {
		Debug.Log ("Moving camera");
		moveTransform.position = newPosition;
	}

	private void toggleActive(GameObject obj, bool state) {
		obj.SetActive(state);
	}

	public void showText() {
		toggleActive (texts[waypointIndex], true);
	}

	public void hideText() {
		toggleActive (texts[waypointIndex], false);
	}

}
