using UnityEngine;
using System.Collections;

public class BasicTower : MonoBehaviour {

	public GameObject bullet;
	public float bulletSpeed = 1.0f; //How fast a bullet is shot
	public float fireRate = 1.0f; //How fast a tower fires
	public float fireRadius = 5.0f; //radius that tower detects and fires at enemy

	private Vector3 movementDirection;



	// Use this for initialization
	void Start ()
	{
		InvokeRepeating("SpawnBullet",fireRate,fireRate);
	}

	void Update()
	{

		foreach (Collider col in Physics.OverlapSphere (transform.position, fireRadius))
		{


			if (col.tag == "Enemy") {
				if (gameObject.tag != "DontRotate") {
					movementDirection = (col.transform.position - transform.position).normalized;
					transform.rotation = Quaternion.LookRotation (movementDirection);
				}

				break;
			}

		}



	}


	void SpawnBullet()

	{
		/////////////////////////////////
		//Add code here to make it recoil
		//
		//
		//
		//
		//
		////////////////////////////


		GameObject target = null;
		//Loop for each enemy in area - 
		foreach (Collider col in Physics.OverlapSphere (transform.position, fireRadius))
		{
			

			if (col.tag == "Enemy") {
				target = col.gameObject;

				break;
			}
		}

		//This is used to shoot first object anywhere
		//GameObject target = GameObject.FindGameObjectWithTag("Enemy");

		if (target != null) {

			GameObject newBullet = Instantiate (bullet, transform.position, bullet.transform.rotation) as GameObject;
			newBullet.GetComponent<Rigidbody> ().AddForce ((target.transform.position - transform.position).normalized * bulletSpeed, ForceMode.VelocityChange);
		}
	}


}
