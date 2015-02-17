using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public string keyUp;
	public string keyDown;
	public string keyRight;
	public string keyLeft;

	public float speed = 0.1f;

	private Rect boundaries = new Rect(-8f, -4.1f, 16f, 8.2f);

	private Vector2 pos;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		pos = this.transform.position;

		if (Input.GetKey (keyUp)) {
			pos = new Vector2(pos.x, pos.y + speed);
		}
		if (Input.GetKey (keyDown)) {
			pos = new Vector2(pos.x, pos.y - speed);
		}

		if (Input.GetKey (keyRight)) {
			pos = new Vector2(pos.x + speed, pos.y);
		}
		if (Input.GetKey (keyLeft)) {
			pos = new Vector2(pos.x - speed, pos.y);
		}

		if (pos.x > boundaries.xMax) {
			pos = new Vector2 (boundaries.xMax, pos.y);
		} else if (pos.x < boundaries.xMin) {
			pos = new Vector2(boundaries.xMin, pos.y);
		}

		if (pos.y > boundaries.yMax) {
			pos = new Vector2 (pos.x, boundaries.yMax);
		} else if (pos.y < boundaries.yMin) {
			pos = new Vector2(pos.x, boundaries.yMin);
		}

		this.transform.position = pos;
	}

	void onTriggerEnter(Collider2D col) {
		if (col.gameObject.name == "horiz_wall" || col.gameObject.name == "vert_wall") {

		}
	}
}
