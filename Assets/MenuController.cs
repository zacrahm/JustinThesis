using UnityEngine;
using System.Collections;

public class MenuController : MonoBehaviour {

	public GameObject menu;
	public WaypointController waypointController;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown ("c")) {
			if (menu.activeSelf == false) {
				waypointController.hideText();
				toggleActive(true);
			}
			else {
				toggleActive (false);
				waypointController.showText();
			}
		}
	}

	void toggleActive(bool state) {
		menu.SetActive(state);
	}
}
