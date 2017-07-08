using UnityEngine;

public class OwnedSkins : MonoBehaviour {

	public GameObject RedCubeOwn;
	public GameObject RedCubeOn;
	public GameObject RedCubeOff;
	public GameObject BlackoutOwn;
	public GameObject BlackoutOn;
	public GameObject BlackoutOff;

	void Update () 
		{
		if (RedCubeOwn.activeSelf == true) {
			RedCubeOn.SetActive (true);
			RedCubeOff.SetActive (false);
		} 
		else 
		{
			RedCubeOff.SetActive (true);
			RedCubeOn.SetActive (false);
		}

		if (BlackoutOwn.activeSelf == true) {
			BlackoutOn.SetActive (true);
			BlackoutOff.SetActive (false);
		} 
		else 
		{
			BlackoutOff.SetActive (true);
			BlackoutOn.SetActive (false);
		}
	}
}
