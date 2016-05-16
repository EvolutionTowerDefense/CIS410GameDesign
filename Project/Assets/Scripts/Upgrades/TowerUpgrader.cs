using UnityEngine;
using UnityEngine.UI;
using System.Collections;


public class TowerUpgrader : MonoBehaviour {


		public Text FireRate;
		public Text Dmg;
		public Text Range;
		public Text TowerSelected;
		//public GameObject[] TowerImage;
		public Text TowerLevel;
		

		private int towerNum;

		// Use this for initialization
		void Start () {

		towerNum = 1;

			TowerSelected.text = "";
			FireRate.text = "";
			Dmg.text = "";
			Range.text = "";

		}








	


		// Update is called once per frame
		void Update () {

		if (towerNum == 1) {
			TowerSelected.text = "Basic Gun";
			FireRate.text = "Fire Rate: " + GetGunFR ();
			Dmg.text = "Damage: " + GetGunBulletDmg();
			Range.text = "Range: " + GetGunRange();
			TowerLevel.text = "Tower Level: " + 	GetGunLevel ();


		}

		else if (towerNum == 2) {
			TowerSelected.text = "Mortar";
			FireRate.text = "Fire Rate: " + GetMortarFR();
			Dmg.text = "Damage: " + GetMortarDmg();
			Range.text = "Range: " + GetMortarRange();
			TowerLevel.text = "Tower Level: " + 	GetMortar();


		} 

		else if (towerNum == 3) {
			TowerSelected.text = "Slime";
			FireRate.text = "Fire Rate: " + GetSlowFR();
			Dmg.text = "Damage: " + GetSlowDownBulletDmg();
			Range.text = "Range: " + GetSlowRange();

			TowerLevel.text = "Tower Level: " +  GetSlowLevel();
		

		} 

		else if (towerNum == 4) {
			TowerSelected.text = "Machine Gun";
			FireRate.text = "Fire Rate: " + GetMgFR();
			Dmg.text = "Damage: " + GetMgBulletDmg();
			Range.text = "Range: " + GetMgRange();

			TowerLevel.text = "Tower Level: " + 	GetMgLevel();

		}

		else if (towerNum == 5) {
			TowerSelected.text = "Lazer";
			FireRate.text = "Fire Rate: " + GetLazerFR();
			Dmg.text = "Damage: " + GetLazerDmg();
			Range.text = "Range: " + GetLazerRange();
			TowerLevel.text = "Tower Level: " + 	GetLazerLevel();

		}

		else {
			TowerSelected.text = "Error";
			FireRate.text = "Error";
			Dmg.text = "Error";
			Range.text = "Error";

		}



		}



	public void ButtonMenu(Button button)
	{
		if (button.name == "Tower1") {

			towerNum = 1;
		}
		if (button.name == "Tower2") {
			towerNum = 2;

		}
		if (button.name == "Tower3") {
			towerNum = 3;

		}
		if (button.name == "Tower4") {
			towerNum = 4;

		}
		if (button.name == "Tower5") {
			towerNum = 5;

		}

		if (button.name == "Back") {
			Application.LoadLevel("mainMenu");

		}



	}



	public  int GetScore()
	{
		return PlayerPrefs.GetInt("score");
	}
		
	public  void SetScore(int score)
	{
		PlayerPrefs.SetInt("score", Mathf.Max(GetScore(), score));
	}

	public  int GetCash()
	{
		return PlayerPrefs.GetInt("cash");
	}

	public  void SetCash(int cash)
	{
		PlayerPrefs.SetInt("cash", Mathf.Max(GetCash(), cash));
	}


	// Bullet Damage Getters/Setters
	public float GetGunBulletDmg(){
		return PlayerPrefs.GetFloat("gunBulletDmg");
	}
	public float GetMgBulletDmg(){
		return PlayerPrefs.GetFloat("mgBulletDmg");
	}
	public float GetMortarDmg(){
		return PlayerPrefs.GetFloat("mortarDmg");
	}
	public float GetSlowDownBulletDmg(){
		return PlayerPrefs.GetFloat("slowDownBulletDmg");
	}
	public float GetLazerDmg(){
		return PlayerPrefs.GetFloat("lazerDmg");
	}

	public  void SetGunBulletDmg(float gunBulletDmg){
		PlayerPrefs.SetFloat("gunBulletDmg", Mathf.Max(GetGunBulletDmg(), gunBulletDmg));
	}
	public void SetMgBulletDmg(float mgBulletDmg){
		PlayerPrefs.SetFloat("mgBulletDmg", Mathf.Max(GetMgBulletDmg(), mgBulletDmg));
	}
	public void SetMortarDmg(float mortarDmg){
		PlayerPrefs.SetFloat("mortarDmg", Mathf.Max(GetMortarDmg(), mortarDmg));
	}
	public void SetSlowDownBulletDmg(float slowDownBulletDmg){
		PlayerPrefs.SetFloat("slowDownBulletDmg", Mathf.Max(GetSlowDownBulletDmg(), slowDownBulletDmg));
	}
	public void SetLazerDmg(float lazerDmg){
		PlayerPrefs.SetFloat("lazerDmg", Mathf.Max(GetLazerDmg(), lazerDmg));
	}

	// Bullet Fire Rate Getters/Setters
	public float GetGunFR(){
		return PlayerPrefs.GetFloat("gunFR");
	}
	public float GetMgFR(){
		return PlayerPrefs.GetFloat("mgFR");
	}
	public float GetMortarFR(){
		return PlayerPrefs.GetFloat("mortarFR");
	}
	public  float GetSlowFR(){
		return PlayerPrefs.GetFloat("slowFR");
	}
	public float GetLazerFR(){
		return PlayerPrefs.GetFloat("lazerFR");
	}

	public void SetGunFR(float gunFR){
		PlayerPrefs.SetFloat("gunFR", Mathf.Max(GetGunFR(), gunFR));
	}
	public void SetMgFR(float mgFR){
		PlayerPrefs.SetFloat("mgFR", Mathf.Max(GetMgFR(), mgFR));
	}
	public void SetMortarFR(float mortarFR){
		PlayerPrefs.SetFloat("mortarFR", Mathf.Max(GetMortarFR(), mortarFR));
	}
	public void SetSlowFR(float slowFR){
		PlayerPrefs.SetFloat("slowFR", Mathf.Max(GetSlowFR(), slowFR));
	}
	public void SetLazerFR(float lazerFR){
		PlayerPrefs.SetFloat("lazerFR", Mathf.Max(GetLazerFR(), lazerFR));
	}

	// Bullet Range Getters/Setters
	public float GetGunRange(){
		return PlayerPrefs.GetFloat("gunRange");
	}
	public float GetMgRange(){
		return PlayerPrefs.GetFloat("mgRange");
	}
	public float GetMortarRange(){
		return PlayerPrefs.GetFloat("mortarRange");
	}
	public float GetSlowRange(){
		return PlayerPrefs.GetFloat("slowRange");
	}
	public float GetLazerRange(){
		return PlayerPrefs.GetFloat("lazerRange");
	}

	public void SetGunRange(float gunRange){
		PlayerPrefs.SetFloat("gunRange", Mathf.Max(GetGunRange(), gunRange));
	}
	public void SetMgRange(float mgRange){
		PlayerPrefs.SetFloat("mgRange", Mathf.Max(GetMgRange(), mgRange));
	}
	public void SetMortarRange(float mortarRange){
		PlayerPrefs.SetFloat("mortarRange", Mathf.Max(GetMortarRange(), mortarRange));
	}
	public void SetSlowRange(float slowRange){
		PlayerPrefs.SetFloat("slowRange", Mathf.Max(GetSlowRange(), slowRange));
	}
	public void SetLazerRange(float lazerRange){
		PlayerPrefs.SetFloat("lazerRange", Mathf.Max(GetLazerRange(), lazerRange));
	}


	public int GetGunLevel(){
		return PlayerPrefs.GetInt ("gunLevel");
	}
	public int GetMgLevel(){
		return PlayerPrefs.GetInt ("mgLevel");
	}
	public int GetMortar(){
		return PlayerPrefs.GetInt ("mortarLevel");
	}
	public int GetSlowLevel(){
		return PlayerPrefs.GetInt ("slowLevel");
	}
	public int GetLazerLevel(){
		return PlayerPrefs.GetInt ("lazerLevel");
	}


	public void SetGunLevel(){
		PlayerPrefs.SetInt("gunLevel",GetGunLevel() +1);
	}
	public void SetMgLevel(){
		PlayerPrefs.SetInt("mgLevel",GetMgLevel() +1);
	}
	public void SetMortar(){
		PlayerPrefs.SetInt("mortarLevel",GetMortar() +1);
	}
	public void SetSlowLevel(){
		PlayerPrefs.SetInt("slowLevel",GetSlowLevel()+1);
	}
	public void SetLazerLevel(){
		PlayerPrefs.SetInt("lazerLevel",GetLazerLevel()+1);
	}
}
