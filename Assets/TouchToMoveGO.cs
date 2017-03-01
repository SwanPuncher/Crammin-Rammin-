using UnityEngine;
using System.Collections;

public class TouchToMoveGO : MonoBehaviour {

	/*The Purpose of this script is to move an object that the player has tapped on to a specific location
	 * This is done by finding the location of the mouse when the screen is touched ot the mouse is clicked (Fire1)
	 * The mouse location is then raycast back to the object the player has touched and moves it
	 */

	private Vector3 mousePosition;

	private Ray ray;
	private RaycastHit hit;

	private GameObject raycastObject;

	private Vector3 moveToPoint;

	// Use this for initialization
	void Start () {
		//Objects move to this location
		moveToPoint = new Vector3(0,0,0);
	}

	void Update()
	{
		if (Input.GetButton ("Fire1"))
			OnFire1 ();

		//Debug.Log ("MousePosition is " + Input.mousePosition);
	}

	void OnFire1()
	{
		//Function that runs when Mouse1 is clicked or Screen is tapped

		//Finds Current mouse Position in the world and raycasts back from the Screen
		mousePosition = Input.mousePosition;
	
		ray = Camera.main.ScreenPointToRay (mousePosition);

		Physics.Raycast (ray, out hit);

		//Checks You hit something
		if (hit.collider != null) {

			//Assign the hit object to raycastObject
			raycastObject = hit.collider.gameObject;

			//Check if hit object is moveable through tag check
			if (raycastObject.tag == "noodle1" || raycastObject.tag == "noodle2") {
				//Move Object to location set earlier
				raycastObject.transform.position = moveToPoint;
				//Disables Object's physics
				raycastObject.GetComponent<Rigidbody>().isKinematic = true;
			}
		}
	}
}
