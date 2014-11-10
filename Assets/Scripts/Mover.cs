using UnityEngine;
using System.Collections;

public class Mover : MonoBehaviour {
	public float speed;
	void Start() {
		//transform.forward is just z axis
		rigidbody.velocity = transform.forward * speed;
	}
}