using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

	public void ButtonMenu(Button button)
	{
		if (button.name == "Play") {
			print ("play");
			SceneManager.LoadScene("level1");
		

		}
		if (button.name == "Upgrades") {
			print ("Upgrades");
		}
		if (button.name == "Exit") {
			print ("Exit");
		}


	}
}
