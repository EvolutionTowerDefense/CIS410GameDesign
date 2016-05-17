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
		public Text Cash;
		public Text UpgradeCost;
		public RawImage[] images;

		

		private int towerNum;

		// Use this for initialization
		void Start () {

		//GameObject go = (GameObject)Instantiate( images[1], Spawn.transform.position, Quaternion.identity );
		//go.transform.localScale += new Vector3(10.1F, 10.1F, 10.1F);

		towerNum = 1;

			TowerSelected.text = "";
			FireRate.text = "";
			Dmg.text = "";
			Range.text = "";
			Cash.text = "";
			UpgradeCost.text = "";
		}

	void SetToFalse()
	{
		int i;
		int temp = images.Length;
		for (i =0 ; i < temp; i++) {
			images [i].gameObject.SetActive (false);
		}
	}
		// Update is called once per frame
		void Update () {

		Cash.text = "Cash: " + GetCash ();

		if (towerNum == 1) {
			SetToFalse ();
			images [0].gameObject.SetActive (true);


			TowerSelected.text = "Basic Gun";
			FireRate.text = "Fire Rate: " + GetGunFR ();
			Dmg.text = "Damage: " + GetGunBulletDmg ();
			Range.text = "Range: " + GetGunRange ();
			TowerLevel.text = "Tower Level: " + GetGunLevel ();


			UpgradeCost.text = "Upgarde Cost: " + (100 * GetGunLevel ()).ToString();

			//	GameObject go = Instantiate( images[1], Spawn.transform.position, Spawn.transform.rotation );
			//	go.transform.parent = transform.parent;
			//Destroy( gameObject );

		} else if (towerNum == 2) {
			SetToFalse ();
			images [1].gameObject.SetActive (true);

			TowerSelected.text = "Mortar";
			FireRate.text = "Fire Rate: " + GetMortarFR ();
			Dmg.text = "Damage: " + GetMortarDmg ();
			Range.text = "Range: " + GetMortarRange ();
			TowerLevel.text = "Tower Level: " + GetMortarLevel ();
			UpgradeCost.text = "Upgarde Cost: " + (100 * GetMortarLevel ()).ToString();
		} else if (towerNum == 3) {
			SetToFalse ();
			images [2].gameObject.SetActive (true);
			TowerSelected.text = "Slime";
			FireRate.text = "Fire Rate: " + GetSlowFR ();
			Dmg.text = "Damage: " + GetSlowDownBulletDmg ();
			Range.text = "Range: " + GetSlowRange ();
			TowerLevel.text = "Tower Level: " + GetSlowLevel ();
			UpgradeCost.text = "Upgarde Cost: " + (100 * GetSlowLevel ()).ToString();
		} else if (towerNum == 4) {
			SetToFalse ();
			images [3].gameObject.SetActive (true);
			TowerSelected.text = "Machine Gun";
			FireRate.text = "Fire Rate: " + GetMgFR ();
			Dmg.text = "Damage: " + GetMgBulletDmg ();
			Range.text = "Range: " + GetMgRange ();
			TowerLevel.text = "Tower Level: " + GetMgLevel ();
			UpgradeCost.text = "Upgarde Cost: " + (100 * GetMgLevel ()).ToString();
		} else if (towerNum == 5) {
			SetToFalse ();
			images [4].gameObject.SetActive (true);
			TowerSelected.text = "Lazer";
			FireRate.text = "Fire Rate: " + GetLazerFR ();
			Dmg.text = "Damage: " + GetLazerDmg ();
			Range.text = "Range: " + GetLazerRange ();
			TowerLevel.text = "Tower Level: " + GetLazerLevel ();
			UpgradeCost.text = "Upgarde Cost: " + (100 * GetLazerLevel ()).ToString();

		} else {
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
			Application.LoadLevel ("mainMenu");
		}

		if (button.name == "Upgrade") {
			if (towerNum == 1) {

				if (GetCash () > 100 * GetGunLevel ()) {
					SetCash (GetCash () - (100 * GetGunLevel ()));
					SetGunLevel (GetGunLevel () + 1);
					SetGunBulletDmg (GetGunBulletDmg () + 1.0f);
					SetGunFR (GetGunFR () - 0.1f);
					SetGunRange (GetGunRange () + 1.0f);


				}
			}
			if (towerNum == 2) {
				if (GetCash () > 100 * GetMortarLevel ()) {
					SetCash (GetCash () - (100 * GetMortarLevel ()));
					SetMortarLevel (GetMortarLevel () + 1);
					SetMortarDmg (GetMortarDmg () + 1.0f);
					SetMortarFR (GetMortarFR () - 0.1f);
					SetMortarRange (GetMortarRange () + 1.0f);

				}
			}
			if (towerNum == 3) {
				if (GetCash () > 100 * GetSlowLevel ()) {
					SetCash (GetCash () - (100 * GetSlowLevel ()));
					SetSlowLevel (GetSlowLevel () + 1);
					SetSlowDownBulletDmg (GetSlowDownBulletDmg () + 1.0f);
					SetSlowFR (GetSlowFR () - 0.1f);
					SetSlowRange (GetSlowRange () + 1.0f);

				}
			}
			if (towerNum == 4) {
				if (GetCash () > 100 * GetMgLevel ()) {
					SetCash (GetCash () - (100 * GetMgLevel ()));
					SetMgLevel (GetMgLevel () + 1);
					SetMgBulletDmg (GetMgBulletDmg () + 1.0f);
					SetMgFR (GetMgFR () - 0.1f);
					SetMgRange (GetMgRange () + 1.0f);

				}
			}
			if (towerNum == 5) {
				if (GetCash () > 100 * GetLazerLevel ()) {
					SetCash (GetCash () - (100 * GetLazerLevel ()));
					SetLazerLevel (GetLazerLevel () + 1);
					SetLazerDmg (GetLazerDmg () + 1.0f);
					SetLazerFR (GetLazerFR () - 0.1f);
					SetLazerRange (GetLazerRange () + 1.0f);

				}
			}
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
	public int GetMortarLevel(){
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
	public void SetMortarLevel(int temp){
		PlayerPrefs.SetInt("mortarLevel",temp);
	}
	public void SetSlowLevel(int temp){
		PlayerPrefs.SetInt("slowLevel",temp);
	}
	public void SetLazerLevel(int temp){
		PlayerPrefs.SetInt("lazerLevel",temp);
	}
}
