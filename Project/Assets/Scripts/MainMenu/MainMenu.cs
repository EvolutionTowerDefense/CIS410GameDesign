
using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {
	


	public TowerUpgrader gameController;


	void Start ()
	{
		GameObject gameControllerObject = GameObject.FindWithTag ("TowerUpgrader");


		if (gameControllerObject != null)
		{
			gameController = gameControllerObject.GetComponent <TowerUpgrader>();
		}
		if (gameController == null)
		{
			Debug.Log ("Cannot find 'GameController' script");
		}
	}
		





	public void Update(){

	
	}

	public void ButtonMenu(Button button)
	{




		if (button.name == "NewGame") {

				gameController.SetGunBulletDmg (1.0f);
				gameController.SetGunFR (0.5f);
				gameController.SetGunRange (10.0f);

			
			//print ("play");


	
			gameController.SetMgBulletDmg (0.25f);
			gameController.SetMgFR (0.2f);
			gameController.SetMgRange (5.0f);


			gameController.SetMortarDmg (2.0f);
			gameController.SetMortarFR(3.0f);
			gameController.SetMortarRange(10.0f);


			gameController.SetSlowDownBulletDmg (1.0f);
			gameController.SetSlowFR(2.0f);
			gameController.SetSlowRange(5.0f);


			gameController.SetLazerDmg (3.0f);
			gameController.SetLazerFR(0.4f);
			gameController.SetLazerRange(8.0f);


			gameController.SetGunLevel ();
			gameController.SetMgLevel ();
			gameController.SetMortar ();
			gameController.SetSlowLevel ();
			gameController.SetLazerLevel ();

		

		}

		if (button.name == "Continue") {
			SceneManager.LoadScene ("level1");
		}
		if (button.name == "Upgrades") {
			//print ("Upgrades");
			SceneManager.LoadScene ("Upgrades");
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