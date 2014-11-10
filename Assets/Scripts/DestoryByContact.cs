using UnityEngine;
using System.Collections;

public class DestoryByContact : MonoBehaviour {
	public GameObject explosion;
	public GameObject playerExplostion;
	public int scorevalue;
	private GameController gameController;

	void Start() {
		GameObject gameControllerObject = GameObject.FindWithTag ("GameController");
		if (gameControllerObject != null) {
			gameController = gameControllerObject.GetComponent<GameController>();
		}
		if (gameController == null) {
			Debug.Log ("Cannot find 'GameController' script");
		}
	}
	void OnTriggerEnter(Collider other) {
		if (other.tag == "Boundary") {
			return;
		}
		Instantiate(explosion, transform.position, transform.rotation);
		if (other.tag == "Player") {
			Instantiate (playerExplostion, other.transform.position, other.transform.rotation);
			gameController.GameOver ();
		}
		gameController.AddScore(scorevalue);
		Destroy (other.gameObject);
		Destroy (gameObject);
	}
}
	