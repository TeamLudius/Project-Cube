using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

	bool gameHasEnded = false;

	public GameObject completeLevelUI;
	public GameObject pause;

	public void CompleteLevel ()
	{
		completeLevelUI.SetActive (true);
		pause.SetActive (false);
	}
		
	public void EndGame ()
	{
		if (gameHasEnded == false) 
		{
			gameHasEnded = true;
			Invoke("Restart", 1f);
		}
	}
		
	void Restart ()
	{
		SceneManager.LoadScene (SceneManager.GetActiveScene ().name);
	}

}
