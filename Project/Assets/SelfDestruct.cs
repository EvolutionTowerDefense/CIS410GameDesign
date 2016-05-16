using UnityEngine;
using System.Collections;

public class SelfDestruct : MonoBehaviour {

	public GameObject size;


	// Use this for initialization
	void Start () {
		float temp = size.GetComponent <gunTower>().fireRadius;
		temp = temp * 2.45f;
		transform.localScale += new Vector3(temp,temp,temp);
		Object.Destroy(gameObject, 30.5f);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
