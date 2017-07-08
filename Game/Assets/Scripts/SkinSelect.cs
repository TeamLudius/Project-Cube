using UnityEngine;

public class SkinSelect : MonoBehaviour {

	public GameObject Return;
	public GameObject Select;
	public GameObject Title;
	public GameObject RedCubeOn;
	public GameObject RedCubeText;
	public GameObject RedCubeOwn;
	public GameObject RedCubeButton;
	public GameObject BlackoutOn;
	public GameObject BlackoutText;
	public GameObject BlackoutOwn;
	public GameObject BlackoutButton;

	void Update ()
	{
		if (RedCubeOwn.activeSelf == true) 
		{
			RedCubeButton.SetActive (true);
		}

		if (BlackoutOwn.activeSelf == true) 
		{
			BlackoutButton.SetActive (true);
		} 
	}

	public void SelectClick ()
	{
		Return.SetActive (true);
		Select.SetActive (false);
		//add selecting system
		Debug.Log("Coming Soon!");
	}

	public void RedCubeClick ()
	{
		RedCubeText.SetActive (true);
		Return.SetActive (false);
		Select.SetActive (true);
		Title.SetActive (false);
	}

	public void BlackoutClick ()
	{
		BlackoutText.SetActive (true);
		Return.SetActive (false);
		Select.SetActive (true);
		Title.SetActive (false);
	}
}
