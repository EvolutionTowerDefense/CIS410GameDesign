using UnityEngine;
using System.Collections;

public class EnergyBonusOnDestory : MonoBehaviour {

	public float energyBonus = 100;

	void OnDestroy()
	{
		//Money
		EnergyManager.energy += (energyBonus/2);

		//Score
		ScoreManager.score += energyBonus;
	}



}
