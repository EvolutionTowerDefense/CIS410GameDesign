using UnityEngine;
using System.Collections;

public class TowerUpgrader : MonoBehaviour {




		public GameObject[] towerIcones;


		public float towerIconRotateRate = 1.0f;

		//only have 1 tower selected or in the game atm
		//Static means every instances shares this variable
		private int selectedTower = 0;

		// Use this for initialization
		void Start () {

		}

		// Update is called once per frame
		void Update () {

			if (gameObject.tag != "DontRotate") {
				towerIcones [selectedTower].transform.Rotate (Vector3.up, towerIconRotateRate * Time.deltaTime);
			}
		}



		void SetSelectedTower(GameObject inputTower)
		{
			int index =0;
			foreach (GameObject towerIcon in towerIcones) {
				if (inputTower == towerIcon) {
					selectedTower = index;
				}
				index++;

			}
		}


	public static int GetScore()
	{
		return PlayerPrefs.GetInt("score");
	}
		
	public static void SetScore(int score)
	{
		PlayerPrefs.SetInt("score", Mathf.Max(GetScore(), score));
	}

	public static int GetCash()
	{
		return PlayerPrefs.GetInt("cash");
	}

	public static void SetCash(int cash)
	{
		PlayerPrefs.SetInt("cash", Mathf.Max(GetCash(), cash));
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

	public static void SetGunBulletDmg(float gunBulletDmg){
		PlayerPrefs.SetFloat("gunBulletDmg", Mathf.Max(GetGunBulletDmg(), gunBulletDmg));
	}
	public static void SetMgBulletDmg(float mgBulletDmg){
		PlayerPrefs.SetFloat("mgBulletDmg", Mathf.Max(GetMgBulletDmg(), mgBulletDmg));
	}
	public static void SetMortarDmg(float mortarDmg){
		PlayerPrefs.SetFloat("mortarDmg", Mathf.Max(GetMortarDmg(), mortarDmg));
	}
	public static void SetSlowDownBulletDmg(float slowDownBulletDmg){
		PlayerPrefs.SetFloat("slowDownBulletDmg", Mathf.Max(GetSlowDownBulletDmg(), slowDownBulletDmg));
	}
	public static void SetLazerDmg(float lazerDmg){
		PlayerPrefs.SetFloat("lazerDmg", Mathf.Max(GetLazerDmg(), lazerDmg));
	}

	// Bullet Fire Rate Getters/Setters
	public static float GetGunFR(){
		return PlayerPrefs.GetFloat("gunFR");
	}
	public static float GetMgFR(){
		return PlayerPrefs.GetFloat("mgFR");
	}
	public static float GetMortarFR(){
		return PlayerPrefs.GetFloat("mortarFR");
	}
	public static float GetSlowFR(){
		return PlayerPrefs.GetFloat("slowFR");
	}
	public static float GetLazerFR(){
		return PlayerPrefs.GetFloat("lazerFR");
	}

	public static void SetGunFR(float gunFR){
		PlayerPrefs.SetFloat("gunFR", Mathf.Max(GetGunFR(), gunFR));
	}
	public static void SetMgFR(float mgFR){
		PlayerPrefs.SetFloat("mgFR", Mathf.Max(GetMgFR(), mgFR));
	}
	public static void SetMortarFR(float mortarFR){
		PlayerPrefs.SetFloat("mortarFR", Mathf.Max(GetMortarFR(), mortarFR));
	}
	public static void SetSlowFR(float slowFR){
		PlayerPrefs.SetFloat("slowFR", Mathf.Max(GetSlowFR(), slowFR));
	}
	public static void SetLazerFR(float lazerFR){
		PlayerPrefs.SetFloat("lazerFR", Mathf.Max(GetLazerFR(), lazerFR));
	}

	// Bullet Range Getters/Setters
	public static float GetGunRange(){
		return PlayerPrefs.GetFloat("gunRange");
	}
	public static float GetMgRange(){
		return PlayerPrefs.GetFloat("mgRange");
	}
	public static float GetMortarRange(){
		return PlayerPrefs.GetFloat("mortarRange");
	}
	public static float GetSlowRange(){
		return PlayerPrefs.GetFloat("slowRange");
	}
	public static float GetLazerRange(){
		return PlayerPrefs.GetFloat("lazerRange");
	}

	public static void SetGunRange(float gunRange){
		PlayerPrefs.SetFloat("gunRange", Mathf.Max(GetGunRange(), gunRange));
	}
	public static void SetMgRange(float mgRange){
		PlayerPrefs.SetFloat("mgRange", Mathf.Max(GetMgRange(), mgRange));
	}
	public static void SetMortarRange(float mortarRange){
		PlayerPrefs.SetFloat("mortarRange", Mathf.Max(GetMortarRange(), mortarRange));
	}
	public static void SetSlowRange(float slowRange){
		PlayerPrefs.SetFloat("slowRange", Mathf.Max(GetSlowRange(), slowRange));
	}
	public static void SetLazerRange(float lazerRange){
		PlayerPrefs.SetFloat("lazerRange", Mathf.Max(GetLazerRange(), lazerRange));
	}
}
