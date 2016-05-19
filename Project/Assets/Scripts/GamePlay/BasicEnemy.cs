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



	void OnCollisionEnter(Collision collision)
	{
		if (collision.collider.tag == "Bullet") {
			Health = Health - TowerUpgrader.GetGunBulletDmg();
			Destroy (collision.collider.gameObject);

		}
		else if (collision.collider.tag == "GunBullet") {
			Health = Health - TowerUpgrader.GetGunBulletDmg();
			Destroy (collision.collider.gameObject);
		}
		else if (collision.collider.tag == "Mortar") {
			Health = Health - TowerUpgrader.GetMortarDmg();
			//Don't destory the explosion
			Destroy (collision.collider.gameObject);
		}

		else if (collision.collider.tag == "LazerBullet") {
			Health = Health - TowerUpgrader.GetLazerDmg();
			Destroy (collision.collider.gameObject);
		}

		else if (collision.collider.tag == "MachineGunBullet") {
			Health = Health -TowerUpgrader.GetMgBulletDmg();
			Destroy (collision.collider.gameObject);
		}

		else if (collision.collider.tag == "SlowBullet") {
			Health = Health - TowerUpgrader.GetSlowDownBulletDmg();
			Destroy (collision.collider.gameObject);
		}
		else if (collision.collider.tag == "ExplosiveDmg") {
			Health = Health - TowerUpgrader.GetExplosiveDmg();
			//Destroy (collision.collider.gameObject)();
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
