using UnityEngine;

public class SkinEnable : MonoBehaviour {

	void Start () {
		if (print(PlayerPrefs.GetInt("RedCubeOwned")) == 1)
		{
			Debug.Log ("RedCubeOwned");
		}
		else
		{
			Debug.Log ("RedCubeNotOwned");
		}	
	}
}
