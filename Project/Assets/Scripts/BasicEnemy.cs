using UnityEngine;
using System.Collections;

public class BasicEnemy : MonoBehaviour {

	public float Health;
	public AudioClip expSound;
	public GameObject explosion;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void newWave (float level) {

		if( level == 2)
			Health = Health * 2;
		if( level == 1)
			Health = Health * 4;

	}

	void OnCollisionEnter(Collision collision)
	{
		if (collision.collider.tag == "Bullet") {
			Health = Health - 1.0f;
			Destroy (collision.collider.gameObject);

		}
		else if (collision.collider.tag == "GunBullet") {
			Health = Health - 1.0f;
			Destroy (collision.collider.gameObject);
		}
		else if (collision.collider.tag == "Mortar") {
			Health = Health - 1.0f;
			Health = Health - 1.0f;			
			Health = Health - 1.0f;
			//Don't destory the explosion
			Destroy (collision.collider.gameObject);
		}

		else if (collision.collider.tag == "LazerBullet") {
			Health = Health - 1.0f;
			Destroy (collision.collider.gameObject);
		}

		else if (collision.collider.tag == "MachineGunBullet") {
			Health = Health - 1.0f;
			Destroy (collision.collider.gameObject);
		}

		else if (collision.collider.tag == "SlowBullet") {
			Health = Health - 1.0f;
			Destroy (collision.collider.gameObject);
		}



		if (Health <= 0) {
			GameObject clone = (GameObject)Instantiate(explosion, transform.position, transform.rotation);
			//Instantiate(explosion);

			//Add sound for explosion
//			AudioSource.PlayClipAtPoint(expSound, explosion.transform.position);
		

			Destroy (clone,2.0f);
			Destroy (collision.collider.gameObject);
			Destroy (gameObject);
		}

	}

}
