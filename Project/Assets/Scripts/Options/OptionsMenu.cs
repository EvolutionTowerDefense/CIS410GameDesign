using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Audio;

public class OptionsMenu : MonoBehaviour {
	public Slider musicSilder;
	public Slider sfxSlider;
	public AudioMixer masterMixer;
	float musicVol;
	float sfxVol;
	void Start () {		
		masterMixer.GetFloat("musicVol", out( musicVol));
		masterMixer.GetFloat ("sfxVol", out(sfxVol));
		musicSilder.value = musicVol;
		sfxSlider.value = sfxVol;
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
			print ("Main");
			SceneManager.LoadScene ("MainMenu");
		}

	}

}