using UnityEngine;

public class ShopTest02 : MonoBehaviour {

	public GameObject RedCube;
	public GameObject Blackout;

	public void Test ()
	{
		var RandomValue = Random.value;

		if(RandomValue > 0 && RandomValue <= 0.5)
			{
			RedCube.SetActive (true);
			Invoke("TurnOff01", 10f);
		}

		if (RandomValue > 0.5 && RandomValue <= 1)
		{
			Blackout.SetActive (true);
			Invoke("TurnOff02", 10f);
		}

	}

	void TurnOff01 ()
	{
		RedCube.SetActive (false);
	}

	void TurnOff02 ()
	{
		Blackout.SetActive (false);
	}
}