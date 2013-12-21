using UnityEngine;
using System.Collections;

public class Exposure : MonoBehaviour
{
	private Transform sun;
	private Player player;
	private int recover = 0;

	void Start()
	{
		sun = transform.parent;
		player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
	}

	void OnTriggerStay(Collider other)
	{
		if (other.gameObject.tag == "Player" && recover == 0) {
			Ray ray = new Ray(sun.transform.position, player.transform.position - sun.transform.position);
			RaycastHit hit = new RaycastHit();
			if (Physics.Raycast(ray, out hit)) {
				if (hit.collider.gameObject.GetInstanceID() == player.gameObject.GetInstanceID()) {
					player.exposure += 5;
					player.energy += 1;
					recover = 15;
				}
			}
		}
	}

	void FixedUpdate()
	{
		if (recover > 0) {
			--recover;
		}
	}
}
