using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public string keyUp;
	public string keyDown;
	public string keyRight;
	public string keyLeft;

	public float speed = 0.1f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (keyUp)) {
			this.transform.position = new Vector2(this.transform.position.x, this.transform.position.y + speed);
		} else if (Input.GetKey (keyDown)) {
			this.transform.position = new Vector2(this.transform.position.x, this.transform.position.y - speed);
		}

		if (Input.GetKey (keyRight)) {
			this.transform.position = new Vector2(this.transform.position.x + speed, this.transform.position.y);
		} else if (Input.GetKey (keyLeft)) {
			this.transform.position = new Vector2(this.transform.position.x - speed, this.transform.position.y);
		}
	}
}
