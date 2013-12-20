using UnityEngine;
using System.Collections;

public class Planet : MonoBehaviour
{
	private int timer = 240;

	void Start()
	{
	}

	void FixedUpdate()
	{
		--timer;
		if (timer == 0) {
			transform.localScale = new Vector3(transform.localScale.x - 3.0f, transform.localScale.y - 3.0f, transform.localScale.z - 3.0f);
			timer = 240;
		}
	}
}
