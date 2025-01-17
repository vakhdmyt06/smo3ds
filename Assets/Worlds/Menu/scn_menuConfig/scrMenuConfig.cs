﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scrMenuConfig : MonoBehaviour
{
	public GameObject[] buttons;

	void Start()
	{
		OnMenu();
	}
	public void OnMenu()
	{
		scr_manButton.s.SetMenu(buttons, gameObject, 0, new Vector2(0, 0));
		scr_manButton.s.SetActive(true);
	}

	public void OnButtonPress(int button)
	{
		switch (button)
		{
			case 0:
				break;
			case 1:
				break;
		}
	}
	void Update()
	{
		if (
#if !UNITY_EDITOR
			UnityEngine.N3DS.GamePad.GetButtonHold(N3dsButton.B)
#else
			Input.GetKey(KeyCode.Escape)
#endif
		) {
			scr_manButton.s.SwitchPrevMenu();
			SceneManager.UnloadSceneAsync("scn_menuConfig");
			this.enabled = false;
		}
	}
}
