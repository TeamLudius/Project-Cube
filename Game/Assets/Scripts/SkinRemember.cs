using UnityEngine;

public class SkinRemember : MonoBehaviour {

	public GameObject RedCube;
	public GameObject Blackout;

	void Update () {
		if (RedCube.activeSelf == true) 
		{
		//	PlayerPrefs.SetInt ("RedCubeOwned", 1);
		//	Debug.Log ("RedCubeIsOwned");
		}
		else
		{
		//	PlayerPrefs.SetInt ("RedCubeOwned", 0);
		//	Debug.Log ("RedCubeIsNotOwned");
		}	

		if (Blackout.activeSelf == true) 
		{
		//	PlayerPrefs.SetInt ("BlackoutOwned", 1);
		//	Debug.Log ("BlackoutIsOwned");
		}
		else
		{
		//	PlayerPrefs.SetInt ("BlackoutOwned", 0);
		//	Debug.Log ("BlackoutIsNotOwned");
		}	
	}
}
