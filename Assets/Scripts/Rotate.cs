using UnityEngine;
using System.Collections;

public class Rotate : MonoBehaviour
{
	public float speed;

	void Update()
	{
		transform.Rotate(new Vector3(0f, speed * Time.deltaTime, 0f), Space.Self);
	}
}
