using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

	float speed; 

	// Use this for initialization
	void Start () {
		speed = 8f;
	}
	
	// Update is called once per frame
	void Update () {
		//Get the current position
		while (Input.GetMouseButtonDown(1)) {
			Vector2 position = transform.position;

			//Compute the new position 
			position = new Vector2 (position.x, position.y + speed * Time.deltaTime);

			//Update the bullet's position
			transform.position = position; 

			//Top right position of the screen
			Vector2 max = Camera.main.ViewportToWorldPoint (new Vector2 (1, 1));

			//If it goes outside the screen on the top, it destroys it
			if (transform.position.y > max.y) {
				Destroy (gameObject);
			}
		}
	}
}
