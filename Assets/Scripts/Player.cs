using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour
{
	public SphereCollider layer;
	public Transform test;
	public float translateSpeed = 50.0f;
	public float rotateSpeed = 7.0f;
	public float gravity = 5.0f;

	void FixedUpdate()
	{
		Rotate();
		Translate();
	}

	void Rotate()
	{
		transform.Rotate(new Vector3(0f, 0f, -Input.GetAxis("Mouse X")) * rotateSpeed);
	}

	void Translate()
	{
		Vector3 center = transform.position - layer.transform.position;
		center.Normalize();
		rigidbody.AddForce(center * -gravity * Time.fixedDeltaTime);
		transform.RotateAround(layer.transform.position, transform.TransformDirection(Vector3.down), Input.GetAxis("Horizontal") * translateSpeed * Time.fixedDeltaTime);
		transform.RotateAround(layer.transform.position, transform.TransformDirection(Vector3.right), Input.GetAxis("Vertical") * translateSpeed * Time.fixedDeltaTime);
		Transform cannon = transform.FindChild("Cannon");
		if (Input.GetAxis("Horizontal") != 0 || Input.GetAxis("Vertical") != 0) {
			cannon.localEulerAngles = new Vector3(Input.GetAxis("Vertical") * 9.0f, -Input.GetAxis("Horizontal") * 9.0f, 0f);
		} else {
			cannon.localEulerAngles = new Vector3();
		}
	}
}
