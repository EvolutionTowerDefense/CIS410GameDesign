using UnityEngine;
using System.Collections;

public class BasicEnemy : MonoBehaviour {

	public int Health;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter(Collision collision)
	{
		if (collision.collider.tag == "Bullet") {
			Health--;
			Destroy (collision.collider.gameObject);
		}
		if (collision.collider.tag == "Explosion") {
			Health--;
			Health--;
			Health--;
			//Don't destory the explosion
			//Destroy (collision.collider.gameObject);
		}

		if (Health <= 0) {
			Destroy (collision.collider.gameObject);
			Destroy (gameObject);
		}

	}

}
