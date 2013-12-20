using UnityEngine;
using System.Collections;

public class Follow : MonoBehaviour
{
	public Transform center;
	public Transform target;
	public float distance = 0.5f;

	void FixedUpdate()
	{
		Vector3 relative = target.position - center.position;
		transform.position = target.position + relative * distance;
		transform.LookAt(target.position);
	}
}
