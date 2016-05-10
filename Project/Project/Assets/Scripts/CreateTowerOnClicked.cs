using UnityEngine;
using System.Collections;

public class CreateTowerOnClicked : MonoBehaviour
{
	public TowerSelector towerSelector;

	//Gives expact position of item that was clicked
	void Clicked(Vector3 position)
	{
		//Check if you got energy to buy
		if (EnergyManager.energy >= towerSelector.GetSelectedTowerCost ()) {
			GameObject tower = towerSelector.GetSelectedTower ();
			Instantiate (tower, position + Vector3.up * 0.5f, tower.transform.rotation);

			//subtract after buying
			EnergyManager.energy -= towerSelector.GetSelectedTowerCost ();
		}
	}

}
