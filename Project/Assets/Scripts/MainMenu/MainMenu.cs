
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


			TowerUpgrader.SetLevel (1.0f);

			gameController.SetScore (0);

			//Due to extra cash at start of each level
			gameController.SetCash(0);

			// With no cash at start of each level
			//gameController.SetCash(0);

			TowerUpgrader.SetGunBulletDmg (1.0f);
			gameController.SetGunFR (0.5f);
			gameController.SetGunRange (10.0f);

			TowerUpgrader.SetMgBulletDmg (0.25f);
			gameController.SetMgFR (0.2f);
			gameController.SetMgRange (5.0f);


			TowerUpgrader.SetMortarDmg (2.0f);
			TowerUpgrader.SetExplosiveDmg (2.0f);
			gameController.SetMortarFR(3.0f);
			gameController.SetMortarRange(10.0f);


			TowerUpgrader.SetSlowDownBulletDmg (1.0f);
			gameController.SetSlowFR(2.0f);
			gameController.SetSlowRange(5.0f);


			TowerUpgrader.SetLazerDmg (3.0f);
			gameController.SetLazerFR(0.4f);
			gameController.SetLazerRange(5.0f);


			gameController.SetGunLevel (1);
			gameController.SetMgLevel (1);
			gameController.SetMortarLevel (1);
			gameController.SetSlowLevel (1);
			gameController.SetLazerLevel (1);

		

			SceneManager.LoadScene ("level1");

		}

		if (button.name == "Continue") {
			float temp = TowerUpgrader.GetLevel();

			if(temp==1.0)
				SceneManager.LoadScene ("level1");
			if(temp==2.0)
				SceneManager.LoadScene ("level2");
			if(temp==3.0)
				SceneManager.LoadScene ("level3");
			if(temp==4.0)
				SceneManager.LoadScene ("level4");
			if(temp==5.0)
				SceneManager.LoadScene ("level5");
			
			
			
			
			
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