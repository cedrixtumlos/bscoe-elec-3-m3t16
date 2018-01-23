using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rocket2 : MonoBehaviour {
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
			Application.LoadLevel ("level1");
		}
	}
	void OnCollisionEnter(Collision col){
		if (col.gameObject.name == "targetpad") {
			Application.LoadLevel ("level3");
		} else if (col.gameObject.name == "launchpad")  {

		}/*else if (col.gameObject.name == "targetpad")  {

		}
		else if (col.gameObject.name == "wall1")  {

		}
		else if (col.gameObject.name == "wall2")  {

		}*/
	else if (col.gameObject.name == "Rabbit1")  {
		Application.LoadLevel ("level1");

	}
		else if (col.gameObject.name == "Ghost")  {
			Application.LoadLevel ("level1");

		}
		else if (col.gameObject.name == "Bat")  {
			Application.LoadLevel ("level1");

		}
		else if (col.gameObject.name == "Bat2")  {
			Application.LoadLevel ("level1");

		}
		else if (col.gameObject.name == "Rabbit2")  {
			Application.LoadLevel ("level1");

		}
		else   {
			Application.LoadLevel ("level1");
		}

	}
}