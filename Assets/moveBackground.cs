using UnityEngine;
using System.Collections;

public class moveBackground : MonoBehaviour {
	//public float speed;
	private int counter = 0;
	// Update is called once per frame
	void FixedUpdate () {
		Vector3 movement = new Vector3(0, -10,-1); 
		rigidbody.velocity = movement;
		counter++;	
		Debug.Log (counter);
		if (counter == 45) {
			counter = 0;

		}
	}
}
