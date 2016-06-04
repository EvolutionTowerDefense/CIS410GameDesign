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

		if (button.name == "SuperEasy") {
			TowerUpgrader.SetDifficulty (1.5f);
		}

		if (button.name == "Easy") {
			TowerUpgrader.SetDifficulty (1.2f);
		}

		if (button.name == "Med") {
			
			TowerUpgrader.SetDifficulty (1.0f);
		}

		if (button.name == "Hard") {
			TowerUpgrader.SetDifficulty (0.8f);
		}

		if (button.name == "SuperHard") {
			TowerUpgrader.SetDifficulty (0.5f);
		}
	}

}