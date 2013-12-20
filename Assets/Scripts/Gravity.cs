using UnityEngine;
using System.Collections;

public class Gravity : MonoBehaviour
{
	private SphereCollider planet;
	
	void Start()
	{
		planet = GameObject.FindGameObjectWithTag("Planet").GetComponent<SphereCollider>();
	}

	void FixedUpdate()
	{
		Vector3 center = transform.position - planet.transform.position;
		center.Normalize();
		rigidbody.AddForce(center * -1 * Time.fixedDeltaTime);
	}
}
