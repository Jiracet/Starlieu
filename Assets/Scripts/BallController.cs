using UnityEngine;
using System.Collections;

public class BallController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		rigidbody2D.velocity = new Vector2 (2, 2);
	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter2D(Collider2D col) {
		Vector2 vel;

		if (col.gameObject.name == "horiz_wall") {
			vel = new Vector2(rigidbody2D.velocity.x, rigidbody2D.velocity.y * -1);
			rigidbody2D.velocity = vel;
		}

		if (col.gameObject.name == "vert_wall") {
			vel = new Vector2(rigidbody2D.velocity.x * -1, rigidbody2D.velocity.y);
			rigidbody2D.velocity = vel;
		}
	}
}
