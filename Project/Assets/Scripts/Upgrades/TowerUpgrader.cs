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




}
