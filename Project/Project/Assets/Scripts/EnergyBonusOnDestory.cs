using UnityEngine;
using System.Collections;

public class EnergyBonusOnDestory : MonoBehaviour {

	public float energyBonus = 100;

	void OnDestroy()
	{
		EnergyManager.energy += energyBonus;
	}

}
