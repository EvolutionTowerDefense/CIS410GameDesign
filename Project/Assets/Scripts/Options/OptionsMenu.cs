using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class OptionsMenu : MonoBehaviour {
	public GameObject options;
	private int musicVol;
	private int sfxVol;
	void Start () {
		//musicVol = 
		//sfxVol = 
	}
	public void ButtonMenu(Button button)
	{
		/*
		if (button.name == "Apply") {
			print ("Apply");


			SceneManager.LoadScene("MainMenu");
		}

		*/
		if (button.name == "MainMenu") {
//			print ("Main");
			SceneManager.LoadScene ("MainMenu");
		}

		if (button.name == "Easy") {
			TowerUpgrader.SetDifficulty (0.0f);
		}

		if (button.name == "Med") {
			
			TowerUpgrader.SetDifficulty (-200.0f);
		}

		if (button.name == "Hard") {
			TowerUpgrader.SetDifficulty (-400.0f);
		}
	}

}