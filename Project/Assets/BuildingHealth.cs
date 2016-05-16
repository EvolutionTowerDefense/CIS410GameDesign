using UnityEngine;
using System.Collections;

public class BuildingHealth : MonoBehaviour {


	public float Health;
	public AudioClip expSound;
	public GameObject explosion;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}



	void OnCollisionEnter(Collision collision)
	{
		if (collision.collider.tag == "Enemy") {
			Health = Health - 1.0f;
			Destroy (collision.collider.gameObject);

		}

			

		if (Health <= 0) {
			GameObject clone = (GameObject)Instantiate (explosion, transform.position, transform.rotation);
			//Instantiate(explosion);

			//Add sound for explosion
			//			AudioSource.PlayClipAtPoint(expSound, explosion.transform.position);

			Destroy (clone, 2.0f);
			Destroy (collision.collider.gameObject);
			Destroy (gameObject);
		}

	}

}
