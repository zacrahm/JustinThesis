using UnityEngine;
using System.Collections;

public class ModelViewer : MonoBehaviour {

	public WaypointController waypointController;

	public void goToModel(int index) {
		waypointController.goToWaypoint(index);
	}
}
