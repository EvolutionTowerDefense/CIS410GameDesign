using UnityEngine;
using System.Collections;

public class SelfDestruct : MonoBehaviour {

	public GameObject size;


	// Use this for initialization
	void Start () {
		float temp = size.GetComponent <gunTower>().fireRadius;
		//Scales
		temp = temp * 4.275f;//was 2.45f
		transform.localScale += new Vector3(temp,temp,temp);
		Object.Destroy(gameObject, 2.5f);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
