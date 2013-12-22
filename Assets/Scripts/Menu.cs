using UnityEngine;
using System.Collections;

public class Menu : MonoBehaviour
{
	private Font font;

	void Start()
	{
		font = Resources.Load("moonhouse") as Font;
	}

	void Update()
	{
		if (Input.anyKey == true) {
			Application.LoadLevel("Planet");
		}
	}

	void OnGUI()
	{
		GUI.skin.label.font = font;
		GUI.skin.label.alignment = TextAnchor.MiddleCenter;
		GUI.Label(new Rect(Screen.width / 2 - 100, Screen.height / 2 - 60, 200, 30), "Press any key");
	}
}
