using UnityEngine;
using System.Collections;

public class BallController : MonoBehaviour {

	public int speed = 2;

	// Use this for initialization
	void Start () {
		rigidbody2D.velocity = new Vector2 (2, 2);
	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter2D(Collider2D col) {
		Vector2 vel;

		if (col.gameObject.name == "horizWall") {
			vel = new Vector2(rigidbody2D.velocity.x, rigidbody2D.velocity.y * -1);
			rigidbody2D.velocity = vel;
		}

		if (col.gameObject.name == "vertWall") {
			vel = new Vector2(rigidbody2D.velocity.x * -1, rigidbody2D.velocity.y);
			rigidbody2D.velocity = vel;
		}
		print (col.gameObject.name);
		if (col.gameObject.name == "attackHitbox(Clone)") {
			speed++;
			Vector2 dir = new Vector2(this.transform.position.x - col.gameObject.transform.position.x, 
			                          this.transform.position.y - col.gameObject.transform.position.y);
			dir.Normalize ();
			dir.x *= speed;
			dir.y *= speed;
			this.rigidbody2D.velocity = dir;
		}
	}
}
