using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelButtons : MonoBehaviour {

	public Text UIWave;
	void Start(){
		UIWave.text = "";
	
	}
	public static void displayText(int wave){
		UIWave.text = "Waves to go  " + wave.ToString();
	}
	public void LevelButton(Button button)
	{
		if (button.name == "Back") {
			SceneManager.LoadScene ("mainMenu");
		}
	}
}
