using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Keys : MonoBehaviour {

	public float speed;
	public Text countText;
	public Text winText;

	private Rigidbody rb;
	private int count;

	void Start ()
	{
		rb = GetComponent<Rigidbody>();
		count = 0;
		winText.text = "";
	}
		
	public Vector3 CalculateDirection()
	{
		Vector3 direction = Vector3.zero;
		if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
		{
			direction.y += 1.0f;
		}
		if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
		{
			direction.x -= 1.0f;
		}
		if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
		{
			direction.y -= 1.0f;
		}
		if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
		{
			direction.x += 1.0f;
		}
		ThroughHoop ();
		return direction.normalized;
	}

	void ThroughHoop (){
		if (transform.position.x == -0.342273 || transform.position.y == 0.5470079) {
			count++;
			countText.text = "Score: " + count.ToString ();
			if (count >= 12)
			{
				winText.text = "You Win!";
			}
		}
	}
	
	public float MovementSpeed;

	void Update()
	{
		Vector3 direction = CalculateDirection();
		transform.Translate(direction * MovementSpeed * Time.deltaTime);
	}

}


