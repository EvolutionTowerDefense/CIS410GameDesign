
using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

	public void ButtonMenu(Button button)
	{
		if (button.name == "NewGame") {
			//print ("play");
			SceneManager.LoadScene("level1");
		}
		if (button.name == "Continue") {
			SceneManager.LoadScene ("level2");
		}
		if (button.name == "Upgrades") {
			//print ("Upgrades");
			//SceneManager.LoadScene ("Upgrades");
		}
		if (button.name == "Options") {
			SceneManager.LoadScene("Options");
		}
		if (button.name == "Exit") {
			print ("Exit");
			Application.Quit();
		}


	}
}