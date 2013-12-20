using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour
{
	public float translateSpeed = 50.0f;
	public float rotateSpeed = 7.0f;
	public float hoverEffect = 6.0f;
	private SphereCollider planet;
	private int fireCooldown = 0;

	void Start()
	{
		planet = GameObject.FindGameObjectWithTag("Planet").GetComponent<SphereCollider>();
	}

	void FixedUpdate()
	{
		Fire();
		Movement();
	}

	void Fire()
	{
		if (fireCooldown > 0) {
			--fireCooldown;
		}
		if (Input.GetButton("Fire") == true && fireCooldown == 0) {
			Transform cannon = transform.FindChild("Cannon");
			GameObject projectile = Instantiate(Resources.Load("Prefabs/FriendlyProjectile"),
			                                    cannon.position + cannon.TransformDirection(Vector3.up) * 1.5f,
			                                    cannon.rotation * Quaternion.Euler(0, 0, -90)) as GameObject;
			projectile.transform.parent = planet.transform;
			fireCooldown = 40;
		}
	}

	void Movement()
	{
		transform.Rotate(new Vector3(0f, 0f, -Input.GetAxis("Mouse X")) * rotateSpeed);
		
		transform.RotateAround(planet.transform.position, transform.TransformDirection(Vector3.down), Input.GetAxis("Horizontal") * translateSpeed * Time.fixedDeltaTime);
		transform.RotateAround(planet.transform.position, transform.TransformDirection(Vector3.right), Input.GetAxis("Vertical") * translateSpeed * Time.fixedDeltaTime);
		Transform cannon = transform.FindChild("Cannon");
		if (Input.GetAxis("Horizontal") != 0 || Input.GetAxis("Vertical") != 0) {
			cannon.localEulerAngles = new Vector3(Input.GetAxis("Vertical") * hoverEffect, -Input.GetAxis("Horizontal") * hoverEffect, 0f);
		} else {
			cannon.localEulerAngles = new Vector3();
		}
	}
}
