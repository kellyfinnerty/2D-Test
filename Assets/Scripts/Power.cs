using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Power : MonoBehaviour {

	public float time = 0.0F;
	public Vector3 direction = Vector3.zero;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame

	public float MovementSpeed;

	void Update () {
		if (Input.GetButtonDown("1")) {
			time += Time.deltaTime;
		}
		if (Input.GetButtonUp("1")){
			direction.x -= 1.0f;
			direction.y += 1.0f;
			transform.Translate(direction * MovementSpeed *  time);
		}
	}
}
