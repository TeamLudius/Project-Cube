using UnityEngine;

public class Coins : MonoBehaviour {

	public static int Money;

	void OnTriggerEnter ()
	{
		Money += 1;
	}
}