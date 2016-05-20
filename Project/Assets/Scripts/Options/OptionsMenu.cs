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

		if (musicVol != GetMusicVol ()) {
			musicSilder.value = GetMusicVol ();
		} 
		else {
			musicSilder.value = musicVol;
		}

		if (sfxVol != GetSFXVol()) {

			sfxSlider.value = GetSFXVol();
		} 
		else {
			sfxSlider.value = sfxVol;
		}
	}

	public void ButtonMenu(Button button)
	{

		if (button.name == "MainMenu") {
			print ("Main");
			SetSFXVol (sfxVol);
			SetMusicVol(musicVol);
			SceneManager.LoadScene ("MainMenu");
		}

	}

	public void SetMusicVol(float temp){
		PlayerPrefs.SetFloat ("musicVol", temp);
	}
	public float GetMusicVol(){
		return PlayerPrefs.GetFloat ("musicVol");
	}

	public void SetSFXVol(float temp){
		PlayerPrefs.SetFloat ("sfxVol", temp);
	}
	public float GetSFXVol(){
		return PlayerPrefs.GetFloat ("SfxVol");
	}

}