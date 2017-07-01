using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopTest02 : MonoBehaviour {

	public GameObject RedCube;
	public GameObject Test02;
	public GameObject Test03;

	public void Test ()
	{
		var RandomValue = Random.value;
		//0 - .5
		//.5 - .7
		//.7 - 1

		if(RandomValue > 0 && RandomValue <= 0.5) //%50 percent chance
			{
			RedCube.SetActive (true);
			Invoke("TurnOff01", 10f);
		}

		if (RandomValue > 0.5 && RandomValue <= 0.7) //%80 percent chance (1 - 0.2 is 0.8)
		{
			Test02.SetActive (true);
			Invoke("TurnOff02", 10f);
		}

		if(RandomValue > 0.7 && RandomValue <= 1) //%30 percent chance (1 - 0.7 is 0.3)
		{ 
			Test03.SetActive (true);
			Invoke("TurnOff03", 10f);
		}

	}

	void TurnOff01 ()
	{
		RedCube.SetActive (false);
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