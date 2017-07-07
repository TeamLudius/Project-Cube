using UnityEngine;

public class SkinSelect : MonoBehaviour {

	public GameObject Return;
	public GameObject Select;
	public GameObject RedCubeOn;
	public GameObject RedCubeText;
	public GameObject RedCubeOwn;
	public GameObject RedCubeButton;
	public GameObject BlackoutOn;
	public GameObject BlackoutText;
	public GameObject BlackoutOwn;
	public GameObject BlackoutButton;

	public void SelectClick ()
	{
		Return.SetActive (true);
		Select.SetActive (false);
		//add selecting system
	}




	public void RedCubeClick ()
	{
		RedCubeText.SetActive (true);
		Return.SetActive (false);
		Select.SetActive (true);
	}

	void update ()
	{
		
	if (RedCubeOn.activeSelf == true) 
		{
			RedCubeButton.SetActive (true);
		} 
	else
		{				
			RedCubeButton.SetActive (false);
		}
	}
}
