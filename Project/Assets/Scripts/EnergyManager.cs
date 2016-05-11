using UnityEngine;
using System.Collections;

public class EnergyManager : MonoBehaviour {

	public float initialEnergy = 500;
	public GameObject energyDisplay;

	public static float energy;

	// Use this for initialization
	void Start () {

		energy = initialEnergy;

	
	}
	
	// Update is called once per frame
	void Update () {
		energyDisplay.GetComponent<TextMesh>().text ="Cash: " + energy.ToString();
	
	}
}
