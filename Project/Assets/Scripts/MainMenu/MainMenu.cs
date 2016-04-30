using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour {

	public void ButtonMenu(Button button)
	{
		if (button.name == "Play") {
			print ("play");
			Application.LoadLevel("level1");
		}
		if (button.name == "Upgrades") {
			print ("Upgrades");
		}
		if (button.name == "Exit") {
			print ("Exit");
		}


	}
}
