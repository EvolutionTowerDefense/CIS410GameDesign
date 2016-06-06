using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CreateTowerOnClicked : MonoBehaviour
{
	public TowerSelector towerSelector;


	public MeshCollider planeMesh;
	public GameObject rangeObject;
	public RectTransform ParentPanel;
	public GameObject cancel;
	public GameObject confirm;
	public Camera camera2;


	//Gives exact position of item that was clicked
	public void Clicked(Vector3 towerPosition)
	{
		//Check if you got energy to buy
		if (EnergyManager.energy >= towerSelector.GetSelectedTowerCost ()) 
		{
			GameObject tower = towerSelector.GetSelectedTower ();


			//Instantiate Tower
			GameObject t = Instantiate (tower, towerPosition + Vector3.up * 0.5f, tower.transform.rotation) as GameObject;
			t.GetComponent<gunTower>().enabled = false;

			//SetActive (false);
			string Tag = tower.tag;
			float temp = 0;
		
			//Find Fire Radius
			if(Tag == "MortarTower")
				temp = tower.GetComponent <MortarTower>().fireRadius;
			else if (Tag == "machinegun1" )
				temp = tower.GetComponent <machinegunTower>().fireRadius;
			else if (Tag == "lazer1")
				temp = tower.GetComponent <lazerTower>().fireRadius;
			else if (Tag == "gun1")
				temp = tower.GetComponent <gunTower>().fireRadius;
			else if (Tag == "gunslow")
				temp = tower.GetComponent <gunSlowTower>().fireRadius;

			//Create Range Object
			GameObject range = Instantiate (rangeObject, towerPosition + Vector3.up * 0.5f, tower.transform.rotation) as GameObject;
			temp = temp * 1.875f; // New Scale
			range.transform.localScale += new Vector3(temp,temp,temp);//Set Size of range



			//Set Location for Cancel Button
			Vector3 screenPos = camera2.WorldToScreenPoint(towerPosition);
			screenPos.x = screenPos.x - 40;
			//Cancel Button
			GameObject cancelButton = (GameObject)Instantiate(cancel);
			cancelButton.transform.SetParent(ParentPanel, false);
			cancelButton.transform.position = screenPos;
			Button tempButton1 = cancelButton.GetComponent<Button>();


			//Set Location for Confirm Button
			screenPos.x += 80;
			//Confirm Button
			GameObject confirmButton = (GameObject)Instantiate(confirm);
			confirmButton.transform.SetParent(ParentPanel, false);
			confirmButton.transform.position = screenPos;
			Button tempButton2 = confirmButton.GetComponent<Button>();

			//Add Listener to buttons
			tempButton1.onClick.AddListener(() => CancelTower(range, cancelButton, confirmButton, t ));
			tempButton2.onClick.AddListener(() => ConfirmTower(range, cancelButton, confirmButton, t));


			//Turn off placing towers until yes or no
			planeMesh.enabled = false;
		}
	}

	void CancelTower(GameObject r, GameObject b1, GameObject b2, GameObject t){
		Destroy (t);
		endProcess (r, b1, b2);
	}
	void ConfirmTower(GameObject r, GameObject b1, GameObject b2, GameObject t){
		EnergyManager.energy -= towerSelector.GetSelectedTowerCost ();
		t.GetComponent<gunTower>().enabled = true;
		endProcess (r, b1, b2);
	}

	void endProcess(GameObject r, GameObject b1, GameObject b2){
		//Destroy range
		Destroy(b1);
		Destroy (b2);
		planeMesh.enabled = true;
		Destroy (r);

	}
}
