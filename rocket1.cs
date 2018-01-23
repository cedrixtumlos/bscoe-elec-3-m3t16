using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rocket1 : MonoBehaviour {
	Rigidbody rg;

	// Use this for initialization
	void Start () {
		rg = GetComponent<Rigidbody> ();


	}

	// Update is called once per frame
	void Update () {
		ProcessInput ();

	}
	public void ProcessInput(){
		if (Input.GetKey (KeyCode.Space)) {
			rg.AddRelativeForce (Vector3.up*20);
		}
		if (Input.GetKey (KeyCode.A)) {
			transform.Rotate(Vector3.forward*5);
		}
		if (Input.GetKey (KeyCode.D)) {
			transform.Rotate(-Vector3.forward*5);
		}
		if (Input.GetKey (KeyCode.O)) {
			Application.LoadLevel (Application.loadedLevel);
		}
	}
	void OnCollisionEnter(Collision col){
		if (col.gameObject.name == "targetpad") {
			Application.LoadLevel ("level2");
		} else if (col.gameObject.name == "launchpad")  {

		}/*else if (col.gameObject.name == "targetpad")  {

		}
		else if (col.gameObject.name == "wall1")  {

		}
		else if (col.gameObject.name == "wall2")  {

		}*/
		else if (col.gameObject.name == "Bat")  {
			Application.LoadLevel ("level1");

		}
		else if (col.gameObject.name == "Rabbit")  {
			Application.LoadLevel ("level1");

		}
		else if (col.gameObject.name == "Ghost")  {
			Application.LoadLevel ("level1");

		}
		else   {
			Application.LoadLevel (Application.loadedLevel);
		}

	}
}