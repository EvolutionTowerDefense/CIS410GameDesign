using UnityEngine;
using System.Collections;

public class MortarAI : MonoBehaviour {

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
		//When collide - might need to readjust 
		//Qu.idy -- means 000 all around


		GameObject clone = (GameObject)	Instantiate(explosion, transform.position, transform.rotation);
		//Instantiate(explosion);



		AudioSource.PlayClipAtPoint(expSound, explosion.transform.position);

		Destroy(clone, 2.0f);

		//Destroy (explosion,2.0f);

	}



}











