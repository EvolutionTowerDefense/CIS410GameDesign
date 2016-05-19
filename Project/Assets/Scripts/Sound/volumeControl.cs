using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.Audio;

public class volumeControl : MonoBehaviour {

	public AudioMixer masterMixer;

	public void SetSfxLvl(float sfxLvl)
	{
		masterMixer.SetFloat ("sfxVol",sfxLvl);
	}
	public void SetMusicLvl (float musicLvl)
	{
		masterMixer.SetFloat ("musicVol", musicLvl);
	}



}
