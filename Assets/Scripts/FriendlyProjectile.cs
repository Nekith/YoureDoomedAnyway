using UnityEngine;
using System.Collections;

public class FriendlyProjectile : MonoBehaviour
{
	private SphereCollider planet;
	private int ttl = 150;

	void Start()
	{
		planet = GameObject.FindGameObjectWithTag("Planet").GetComponent<SphereCollider>();
	}

	void FixedUpdate()
	{
		--ttl;
		if (ttl == 0) {
			Destroy(gameObject);
		}
		transform.RotateAround(planet.transform.position, transform.TransformDirection(Vector3.up), 50.0f * Time.fixedDeltaTime);
	}
}
