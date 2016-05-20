using UnityEngine;
using System.Collections;

public class EnemyHealth : MonoBehaviour {
	private Camera myCamera;
	public Vector3 vec;
	public Texture redTexture;
	private float lifeRatio;
	private float lifeWidth;
	private float lifeHeight;
	private float lifeBackgroundWidth;
	private float maxLife;



	void Start () {

		lifeBackgroundWidth = 30.0f;
		lifeHeight = 3.0f;
		maxLife = GetComponentInParent<BasicEnemy> ().Health;
		myCamera = Camera.main;
	}

	void Update () {

		lifeRatio = GetComponentInParent<BasicEnemy>().Health / maxLife; //TODO:fix to represent max life
		lifeWidth = lifeRatio *lifeBackgroundWidth;
	}

	void OnGUI(){
		if (lifeRatio > 0.0f&& lifeRatio<1.0f) {
			vec = myCamera.WorldToScreenPoint (transform.position);
			GUI.DrawTexture (new Rect (vec.x - (lifeBackgroundWidth / 2.0f), Screen.height - (vec.y + 30.0f), lifeBackgroundWidth, lifeHeight), new RenderTexture(256, 255, 255, RenderTextureFormat.ARGB32));
			GUI.DrawTexture (new Rect (vec.x - (lifeBackgroundWidth / 2.0f), Screen.height - (vec.y + 30.0f), lifeWidth, lifeHeight), redTexture);

		}
	}
}
