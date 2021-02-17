﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{
	[SerializeField] Canvas canvas;
	[SerializeField] string restartLevelPath;
	[SerializeField] public static bool isPaused;
	// Start is called before the first frame update
	void Start()
	{
		canvas.enabled = false;
	}

	// Update is called once per frame
	void Update()
	{
		if (Input.GetKeyDown(KeyCode.Escape)) {
			isPaused = true;
			Time.timeScale = 0;
			canvas.enabled = true;
        }
	}

	public void Restart () {
		SceneManager.LoadScene(restartLevelPath);
    }

	public void Menu() {
		SceneManager.LoadScene("Scenes/Menu");
	}

	public void Resume () {
		isPaused = false;
		Time.timeScale = 1;
		canvas.enabled = false;
    }
}
