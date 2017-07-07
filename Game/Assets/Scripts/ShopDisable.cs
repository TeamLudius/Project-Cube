using UnityEngine;

public class ShopDisable : MonoBehaviour {

	public GameObject RedCube;
	public GameObject RedCubeOwned;
	public GameObject Blackout;
	public GameObject BlackoutOwned;

	public void RedCubeOff ()
	{
		RedCube.SetActive (false);
		RedCubeOwned.SetActive (false);
	}

	public void BlackoutOff ()
	{
		Blackout.SetActive (false);
		BlackoutOwned.SetActive (false);
	}
}
