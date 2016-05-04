using UnityEngine;
using System.Collections;

public class DestoryOnTouch : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

	// Update is called once per frame
	void Update () {

	}


	void OnCollisionEnter(Collision collision)
	{
		if (collision.collider.tag == "Bullet") {
			Destroy (collision.collider.gameObject);
		}
	}

	void OnTriggerEnter(){

		if (gameObject.name == "Bullet") {
			Destroy (gameObject);
		}

	}

}
