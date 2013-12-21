using UnityEngine;
using System.Collections;

public class Look : MonoBehaviour
{
	public Transform look;

	void Update()
	{
		transform.LookAt(look.position);
	}
}
