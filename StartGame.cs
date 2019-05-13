﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour {

	// Use this for initialization
	public void PlayGame () {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
	}
	
	// Update is called once per frame
	public void QuitGame () {
        Debug.Log("Quit");
        Application.Quit();
	}
}
