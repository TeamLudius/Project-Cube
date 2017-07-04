using UnityEngine;

public class ShopDisable : MonoBehaviour {

	public GameObject RedCube;
	public GameObject Blackout;

	public void RedCubeOff ()
	{
		RedCube.SetActive (false);
	}

	public void BlackoutOff ()
	{
		Blackout.SetActive (false);
	}
}
