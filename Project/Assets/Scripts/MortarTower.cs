using UnityEngine;
using System.Collections;

public class MortarTower : MonoBehaviour {

	public GameObject bullet;
	public float fireRate = 1.0f; //How fast a tower fires
	public float fireRadius = 5.0f; //radius that tower detects and fires at enemy
	public float lobAmount = 10.0f;

	public float bulletSpeed = 1.0f;

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
				movementDirection = (col.transform.position - transform.position).normalized;
				transform.rotation = Quaternion.LookRotation(movementDirection);
	

				break;
			}

		}
	}


	void SpawnBullet()

	{


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

			//Make the bullet
			GameObject newBullet = Instantiate (bullet, transform.position, bullet.transform.rotation) as GameObject;

			//Add vertical and horizontal force vectors togeather
			//Vector3 verticleForce = new Vector3(0,lobAmount,0);

			//Vector3 horizontalDirection = (target.transform.position - transform.position).normalized;
			//float speed = lobAmount / -Physics.gravity.y;


			//Add for in direct of unity (whoever is at the top of list of enemies)
			//newBullet.GetComponent<Rigidbody> ().AddForce (verticleForce+(horizontalDirection*speed), ForceMode.VelocityChange);
		
			Vector3 distance = (target.transform.position-transform.position);                        
			Vector3 launchForce = new Vector3(distance.x * bulletSpeed, lobAmount, distance.z * bulletSpeed);                        
			newBullet.GetComponent<Rigidbody>().AddForce(launchForce, ForceMode.VelocityChange);
		
		}
	}


}