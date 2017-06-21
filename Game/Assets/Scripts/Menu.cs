﻿using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour {

	public void LevelSelect ()
	{
		SceneManager.LoadScene (1);
	}

	public void Shop ()
	{
		SceneManager.LoadScene (3);
	}

	public void Achievement ()
	{
		SceneManager.LoadScene (2);
	}

}
