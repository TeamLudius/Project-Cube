using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour {

	public void MainMenu ()
	{
		SceneManager.LoadScene (0);
	}

	public void LevelSelect ()
	{
		SceneManager.LoadScene (1);
	}

	public void Easy ()
	{
		SceneManager.LoadScene (4);
	}

	public void Medium ()
	{
		SceneManager.LoadScene (5);
	}

	public void Hard ()
	{
		SceneManager.LoadScene (6);
	}

	public void Shop ()
	{
		SceneManager.LoadScene (2);
	}

	public void Achievement ()
	{
		SceneManager.LoadScene (2);
	}

	public void Pause ()
	{
		SceneManager.LoadScene (3);
	}
		
	public void Options ()
	{
		SceneManager.LoadScene (2);
	}

	public void MyLooks ()
	{
		SceneManager.LoadScene (7);
	}

}
