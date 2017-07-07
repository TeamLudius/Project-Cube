using UnityEngine;

public class ShopTest02 : MonoBehaviour {

	public GameObject MySkins; 
	public GameObject RedCube;
	public GameObject RedCubeOwned;
	public GameObject RedCubeOwn;
	public GameObject Blackout;
	public GameObject BlackoutOwned;
	public GameObject BlackoutOwn;

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

	public void Shop ()
	{
		var RandomValue = Random.value;

		if(RandomValue > 0 && RandomValue <= 0.5)
		{
			if (RedCubeOwn.activeSelf == false) {
				RedCube.SetActive (true);
				RedCubeOwn.SetActive (true);
			} else 
			{
				RedCubeOwned.SetActive (true);
			}	
		}

		if (RandomValue > 0.5 && RandomValue <= 1)
		{
			if (BlackoutOwn.activeSelf == false) {
				Blackout.SetActive (true);
				BlackoutOwn.SetActive (true);
			} else 
			{
				BlackoutOwned.SetActive (true);
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
}