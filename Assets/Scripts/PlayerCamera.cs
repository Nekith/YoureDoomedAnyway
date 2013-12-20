using UnityEngine;
using System.Collections;

public class PlayerCamera : MonoBehaviour
{
	public Vector3 offset = new Vector3(0f, 0f, 5f);
	private Player player;

	void Start()
	{
		player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
	}

	void Update()
	{
		//transform.position = player.transform.position + transform.rotation * offset;
	}
}
