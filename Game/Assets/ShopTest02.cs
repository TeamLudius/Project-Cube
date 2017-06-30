using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopTest02 : MonoBehaviour {

	public GameObject Test01;
	public GameObject Test02;
	public GameObject Test03;

	public void Test ()
	{
		var theRandomValue = Random.value;
		//o til .5
		//.5 til 0.7
		//.7 til 1

		if(theRandomValue > 0 && theRandomValue <= 0.5) //%50 percent chance
			{
			Debug.Log ("Test01");
			Debug.Log (theRandomValue);
			Test01.SetActive (true);
			Invoke("TurnOff01", 1f);
		}

		if (theRandomValue > 0.5 && theRandomValue <= 0.7) //%80 percent chance (1 - 0.2 is 0.8)
		{
			Debug.Log ("Test02");
			Debug.Log (theRandomValue);
			Test02.SetActive (true);
			Invoke("TurnOff02", 1f);
		}

		if(theRandomValue > 0.7 && theRandomValue <= 1) //%30 percent chance (1 - 0.7 is 0.3)
		{ 
			Debug.Log ("Test03");
			Debug.Log (theRandomValue);
			Test03.SetActive (true);
			Invoke("TurnOff03", 1f);
		}

	}

	void TurnOff01 ()
	{
		Test01.SetActive (false);
	}

	void TurnOff02 ()
	{
		Test02.SetActive (false);
	}

	void TurnOff03 ()
	{
		Test03.SetActive (false);
	}
}