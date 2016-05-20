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
		if (button.name == "Apply") {
			print ("Apply");


			SceneManager.LoadScene("MainMenu");
		}
		if (button.name == "MainMenu") {
			print ("Main");
			SceneManager.LoadScene ("MainMenu");
		}

	}

}