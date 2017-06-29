using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopTest : MonoBehaviour {

	public GameObject Test01;
	public GameObject Test02;
	public GameObject Test03;

	public void Test ()
	{
		if(Random.value > 0.5) //%50 percent chance
		{
			Debug.Log("Test01");
			Test01.SetActive (true);
			Invoke("TurnOff01", 1f);
		}

		void TurnOff03 ()
		{
			Test01.SetActive (false);
		}

		if(Random.value > 0.2) //%80 percent chance (1 - 0.2 is 0.8)
		{ 
			Debug.Log ("Test02");
			Test02.SetActive (true);
			Invoke("TurnOff02", 1f);
		}

		void TurnOff02 ()
		{
			Test02.SetActive (false);
		}

		if(Random.value > 0.7) //%30 percent chance (1 - 0.7 is 0.3)
		{ 
			Debug.Log ("Test03");
			Test03.SetActive (true);
			Invoke("TurnOff03", 1f);
		}

		void TurnOff03 ()
		{
			Test03.SetActive (false);
		}
	}
}
