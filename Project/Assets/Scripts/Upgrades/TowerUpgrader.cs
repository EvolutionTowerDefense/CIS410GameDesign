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
		public GameObject[] images;

		public Image Spawn;
		

		private int towerNum;

		// Use this for initialization
		void Start () {
		GameObject go = (GameObject)Instantiate( images[1], Spawn.transform.position, Quaternion.identity );
		go.transform.localScale += new Vector3(10.1F, 10.1F, 10.1F);
	


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


		//	GameObject go = Instantiate( images[1], Spawn.transform.position, Spawn.transform.rotation );
		//	go.transform.parent = transform.parent;
			//Destroy( gameObject );


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



	public static float GetScore()
	{
		return PlayerPrefs.GetFloat("score");
	}
		
	public  void SetScore(float score)
	{
		PlayerPrefs.SetFloat("score",  score);
	}

	public static float GetCash()
	{
		return PlayerPrefs.GetFloat("cash");
	}

	public  void SetCash(float cash)
	{
		PlayerPrefs.SetFloat("cash",  cash);
	}


	// Bullet Damage Getters/Setters
	public static float GetGunBulletDmg(){
		return PlayerPrefs.GetFloat("gunBulletDmg");
	}
	public static float GetMgBulletDmg(){
		return PlayerPrefs.GetFloat("mgBulletDmg");
	}
	public static float GetMortarDmg(){
		return PlayerPrefs.GetFloat("mortarDmg");
	}
	public static float GetSlowDownBulletDmg(){
		return PlayerPrefs.GetFloat("slowDownBulletDmg");
	}
	public static float GetLazerDmg(){
		return PlayerPrefs.GetFloat("lazerDmg");
	}
	public static float GetExplosiveDmg(){
		return PlayerPrefs.GetFloat("exploDMG");
	}

	public static void SetGunBulletDmg(float gunBulletDmg){
		PlayerPrefs.SetFloat("gunBulletDmg",  gunBulletDmg);
	}
	public static void SetMgBulletDmg(float mgBulletDmg){
		PlayerPrefs.SetFloat("mgBulletDmg", mgBulletDmg);
	}
	public static void SetMortarDmg(float mortarDmg){
		PlayerPrefs.SetFloat("mortarDmg",  mortarDmg);
	}
	public static void SetSlowDownBulletDmg(float slowDownBulletDmg){
		PlayerPrefs.SetFloat("slowDownBulletDmg", slowDownBulletDmg);
	}
	public static void SetLazerDmg(float lazerDmg){
		PlayerPrefs.SetFloat("lazerDmg",lazerDmg);
	}
	public static void SetExplosiveDmg(float exploDMG){
		PlayerPrefs.SetFloat("exploDMG",exploDMG);
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
		PlayerPrefs.SetFloat("gunFR",  gunFR);
	}
	public void SetMgFR(float mgFR){
		PlayerPrefs.SetFloat("mgFR",  mgFR);
	}
	public void SetMortarFR(float mortarFR){
		PlayerPrefs.SetFloat("mortarFR",  mortarFR);
	}
	public void SetSlowFR(float slowFR){
		PlayerPrefs.SetFloat("slowFR",  slowFR);
	}
	public void SetLazerFR(float lazerFR){
		PlayerPrefs.SetFloat("lazerFR",lazerFR);
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
		PlayerPrefs.SetFloat("gunRange",gunRange);
	}
	public void SetMgRange(float mgRange){
		PlayerPrefs.SetFloat("mgRange", mgRange);
	}
	public void SetMortarRange(float mortarRange){
		PlayerPrefs.SetFloat("mortarRange", mortarRange);
	}
	public void SetSlowRange(float slowRange){
		PlayerPrefs.SetFloat("slowRange", slowRange);
	}
	public void SetLazerRange(float lazerRange){
		PlayerPrefs.SetFloat("lazerRange",  lazerRange);
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


	public void SetGunLevel(int temp){
		PlayerPrefs.SetInt("gunLevel",temp);
	}
	public void SetMgLevel(int temp){
		PlayerPrefs.SetInt("mgLevel",temp);
	}
	public void SetMortar(int temp){
		PlayerPrefs.SetInt("mortarLevel",temp);
	}
	public void SetSlowLevel(int temp){
		PlayerPrefs.SetInt("slowLevel",temp);
	}
	public void SetLazerLevel(int temp){
		PlayerPrefs.SetInt("lazerLevel",temp);
	}
}
