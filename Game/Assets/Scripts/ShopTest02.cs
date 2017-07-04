using UnityEngine;

public class ShopTest02 : MonoBehaviour {

	public GameObject RedCube;
	public GameObject RedCubeOwned;
	public GameObject Blackout;
	public GameObject BlackoutOwned;

	void start ()
	{
		RedCubeOwned = GetComponent<GameObject> ();

	}
	public void Test ()
	{
		var RandomValue = Random.value;

		if(RandomValue > 0 && RandomValue <= 0.5)
		{
			RedCube.SetActive (true);
			RedCubeOwned.SetActive (true);
		}

		if (RandomValue > 0.5 && RandomValue <= 1)
		{
			Blackout.SetActive (true);
			BlackoutOwned.SetActive (true);
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