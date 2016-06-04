using UnityEngine;
using System.Collections;

public class EnergyBonusOnDestory : MonoBehaviour {

	public float energyBonus = 100;

	void OnDestroy()
	{
		//Money
		EnergyManager.energy += (energyBonus/2)*TowerUpgrader.GetDifficulty();

		//Score
		ScoreManager.score += energyBonus;
	}



}
