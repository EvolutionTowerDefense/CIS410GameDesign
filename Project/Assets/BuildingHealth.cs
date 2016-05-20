using UnityEngine;
using System.Collections;


public class BuildingHealth : MonoBehaviour {

	private Camera myCamera;
	public Vector3 vec;
	public Texture redTexture;
	private float lifeRatio;
	private float lifeWidth;
	private float lifeHeight;
	private float lifeBackgroundWidth;
	private float maxLife;
	public static bool isQuitting;

	public float Health;
	public AudioClip expSound;
	public GameObject explosion;

	// Use this for initialization
	void Start () {
		lifeBackgroundWidth = 70.0f;
		lifeHeight = 10.0f;
		maxLife = Health;
		myCamera = Camera.main;
		isQuitting = false;

	}

	// Update is called once per frame
	void Update () {
		lifeRatio = Health / maxLife; //TODO:fix to represent max life
		lifeWidth = lifeRatio *lifeBackgroundWidth;
			

	}
	void OnGUI(){
		if (lifeRatio > 0.0f&& lifeRatio<1.0f) {
			vec = myCamera.WorldToScreenPoint (transform.position);
			GUI.DrawTexture (new Rect (vec.x - (lifeBackgroundWidth / 2.0f), Screen.height - (vec.y + 30.0f), lifeBackgroundWidth, lifeHeight), new RenderTexture(256, 255, 255, RenderTextureFormat.ARGB32));
			GUI.DrawTexture (new Rect (vec.x - (lifeBackgroundWidth / 2.0f), Screen.height - (vec.y + 30.0f), lifeWidth, lifeHeight), redTexture);

		}
	}



	void OnCollisionEnter(Collision collision)
	{
		//Debug.Log("sdfadfs");
		if (collision.collider.tag == "Enemy") {
			//Debug.Log("-1");
			Health = Health - 1.0f;
		
			Destroy (collision.collider.gameObject);
			//Do something that reloads the previous level, don't reset any points...


			//Do a message about you lose


		}

			

		if (Health <= 0) {


				GameObject clone = (GameObject)Instantiate (explosion, transform.position, transform.rotation);
				Destroy (clone, 2.0f);


			//Instantiate(explosion);

			//Add sound for explosion
			//			AudioSource.PlayClipAtPoint(expSound, explosion.transform.position);


			Destroy (collision.collider.gameObject);
			Destroy (gameObject);

		}

	}

	void OnApplicationQuit()
	{
		isQuitting = true;
	}

	void OnDestroy()
	{
		if (isQuitting == false) {
			GameObject clone = (GameObject)Instantiate (explosion, transform.position, transform.rotation);
			Destroy (clone, 2.0f);
		}

	}



}
