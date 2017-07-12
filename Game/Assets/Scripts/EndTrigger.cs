using UnityEngine;

public class EndTrigger : MonoBehaviour {

	public static int Money;

	public  GameManager gameManager;

	void OnTriggerEnter ()
	{
		gameManager.CompleteLevel ();
		Money += 1000;
	}

}
