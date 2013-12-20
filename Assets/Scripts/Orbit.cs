using UnityEngine;
using System.Collections;

public class Orbit : MonoBehaviour
{
	public Transform center;
	public float speed;

	void Update()
	{
		transform.RotateAround(center.position, Vector3.up, Time.deltaTime * speed);
	}
}
