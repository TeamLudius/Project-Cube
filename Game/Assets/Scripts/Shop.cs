using UnityEngine;

public class Shop : MonoBehaviour {

	public GameObject NotEnoughMoney;
	public GameObject MySkins; 
	public GameObject RedCube;
	public GameObject RedCubeOwned;
	public GameObject RedCubeOwn;
	public GameObject Blackout;
	public GameObject BlackoutOwned;
	public GameObject BlackoutOwn;

	public int StartingMoney;

	void Start ()
	{
		Coins.Money = StartingMoney;
	}

	public void MyLooks ()
	{
		MySkins.SetActive (true);
	}

	public void MyLooksOff ()
	{
		MySkins.SetActive (false);
	}

	void start ()
	{
		RedCubeOwned = GetComponent<GameObject> ();
	}

	public void Buy ()
	{
		var RandomValue = Random.value;

		if (Coins.Money < 1000) {
			NotEnoughMoney.SetActive (true);
			Invoke ("NoMoney", 1.5f);
		} 
		else 
		{
			Coins.Money -= 1000;
			if(RandomValue > 0 && RandomValue <= 0.5)
			{
				if (RedCubeOwn.activeSelf == false) {
					RedCube.SetActive (true);
					RedCubeOwn.SetActive (true);
				}
				else 
				{
					RedCubeOwned.SetActive (true);
				}	
			}

			if (RandomValue > 0.5 && RandomValue <= 1)
			{
				if (BlackoutOwn.activeSelf == false) {
					Blackout.SetActive (true);
					BlackoutOwn.SetActive (true);
				}
				else 
				{
					BlackoutOwned.SetActive (true);
				}	
		}
		


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

	void NoMoney ()
	{
		NotEnoughMoney.SetActive (false);
	}
}