using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
	Vector2 rotation = Vector2.zero;
	public float turnSpeed = 90;

	private Transform myTransform;

	void Update()
	{
		myTransform = transform;

		myTransform.Rotate(Input.GetAxis("Mouse Y") * turnSpeed * Time.deltaTime * -1, 0, 0);
		
		// rotation.x += -Input.GetAxis("Mouse Y");
		// transform.eulerAngles = (Vector2)rotation * speed;
	}
}
