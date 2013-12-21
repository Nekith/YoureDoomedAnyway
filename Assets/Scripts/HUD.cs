﻿using UnityEngine;
using System.Collections;

public class HUD : MonoBehaviour
{
	private Player player;
	private Font font;
	private float timer;

	void Start()
	{
		player = GetComponent<Player>();
		font = Resources.Load("moonhouse") as Font;
	}

	void Update()
	{
		timer += Time.deltaTime;
	}

	void OnGUI()
	{
		GUI.Label(new Rect(Screen.width - 140, 00, 130, 30), timer.ToString("F0"));
        if (player.energy > 0) {
			GUI.skin.label.font = font;
			GUI.Label(new Rect(Screen.width - 140, Screen.height - 60, 130, 30), "Energy");
			GUI.Label(new Rect(Screen.width - 140, Screen.height - 30, 130, 30), "Exposure");
			GUI.Label(new Rect(Screen.width - 210, Screen.height - 60, 70, 30), string.Format("{0}", player.energy));
			GUI.Label(new Rect(Screen.width - 210, Screen.height - 30, 70, 30), string.Format("{0}", player.exposure));
		}
	}
}
