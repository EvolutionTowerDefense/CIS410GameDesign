using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class EnemySpawner : MonoBehaviour {

	public GameObject[] pathPoints;
	public GameObject graphicalPathObject;


	public int waveCount;

	private int spawnIndex=0;

	public GameObject[] spawnList; //List of enemies that spawn

	public float spawnTime; //time between enemies that spawn
	public float delayInitial;

	public TowerUpgrader gameController;
	//public EnergyManager energyManager;
	//public ScoreManager scoreManager;


	// Use this for initialization
	void Start () {

	
	

		GameObject gameControllerObject = GameObject.FindWithTag ("TowerUpgrader");
	

		//energyManager = energyManager.GetComponent <EnergyManager>();
		//scoreManager = scoreManager.GetComponent <ScoreManager>();


		if (gameControllerObject != null)
		{
			gameController = gameControllerObject.GetComponent <TowerUpgrader>();
		}
		if (gameController == null)
		{
			Debug.Log ("Cannot find 'GameController' script");
		}
	//	for (int i = 0; i < waves; i++) {
			//First spawn time is initial spawn time, and second one is eash spawn after
			InvokeRepeating ("Spawn", delayInitial, spawnTime);

			CreatGraphicalPathObjects ();
		//}
	
	}
	
	// Update is called once per frame
	void Update () {
		GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");
		int enemiesLeft = enemies.Length;
		if (enemiesLeft == 0)
		{ //print ("Triggered");
			
			if (waveCount <= 0)
			{

				//Have some check if there is a building still alive...



				if (SceneManager.GetActiveScene().name == "level1") {

					gameController.SetScore (ScoreManager.score);
					gameController.SetCash(EnergyManager.energy );

					SceneManager.LoadScene("level2");

				} 
				else if (SceneManager.GetActiveScene().name ==  "level2") {

					gameController.SetScore (ScoreManager.score);
					gameController.SetCash(EnergyManager.energy );

					SceneManager.LoadScene("level3");

				} 
				else if (SceneManager.GetActiveScene().name == "level3") {

					gameController.SetScore (ScoreManager.score);
					gameController.SetCash(EnergyManager.energy );

					SceneManager.LoadScene("level4");
					
				}
				else if (SceneManager.GetActiveScene().name == "level4") {

					gameController.SetScore (ScoreManager.score);
					gameController.SetCash(EnergyManager.energy );

					SceneManager.LoadScene("level5");

				} 
				else if (SceneManager.GetActiveScene().name == "level5") {

					gameController.SetScore (ScoreManager.score);
					gameController.SetCash(EnergyManager.energy );

					SceneManager.LoadScene("level1");

				}


			}

			// do something
		}
	}

	void Spawn()
	{


			//Spawn (instantiate) next enemy in spawnlist
			//Transform and quaterinan gives us an enemy where spawner is

			if (spawnIndex > spawnList.Length) {

				
				//LevelButtons.displayText (waveCount);
				waveCount = waveCount - 1;


			if (waveCount <= 0) {
				CancelInvoke ();
				} 
			else {
				spawnIndex = 0;
				}

			}
		GameObject reference = null;
		if (waveCount > 0) {
			 reference = Instantiate (spawnList [spawnIndex], transform.position, Quaternion.identity) as GameObject;
		} 
			
			spawnIndex++;

			if (spawnIndex >= spawnList.Length) {
				//LevelButtons.displayText (waveCount);
				
				waveCount = waveCount - 1;
				
				if (waveCount <= 0) {
						CancelInvoke ();

					}
			else {
				spawnIndex = 0;
			}
				//CancelInvoke ();
			
			}


			//Set enemy path information
		if(reference!=null)
			reference.SendMessage ("SetPathPoints", pathPoints);

			//Add delay between waves here


	}

	void CreatGraphicalPathObjects ()
	{

		//Create object between transform.position and first waypoint
		Vector3 pathObjectPosition = ((pathPoints[0].transform.position - transform.position)*0.5f) + transform.position;
		Quaternion pathObjectOrientation = Quaternion.LookRotation(pathPoints[0].transform.position - transform.position);
		GameObject pathObject = Instantiate(graphicalPathObject, pathObjectPosition, pathObjectOrientation) as GameObject;
		Vector3 newScale = Vector3.one;
		newScale.z = (pathPoints[0].transform.position - transform.position).magnitude;
		pathObject.transform.localScale = newScale;

		Vector2 newTextureScale = Vector2.one;
		newTextureScale.y = (pathPoints[0].transform.position - transform.position).magnitude;
		pathObject.GetComponent<Renderer>().material.mainTextureScale = newTextureScale;

		for(int i = 1; i < pathPoints.Length; i++)
		{
			pathObjectPosition = ((pathPoints[i].transform.position - pathPoints[i-1].transform.position)*0.5f) + pathPoints[i-1].transform.position;
			pathObjectOrientation = Quaternion.LookRotation(pathPoints[i].transform.position - pathPoints[i-1].transform.position);
			pathObject = Instantiate(graphicalPathObject, pathObjectPosition, pathObjectOrientation) as GameObject;
			newScale = Vector3.one;
			newScale.z = (pathPoints[i].transform.position - pathPoints[i-1].transform.position).magnitude;
			pathObject.transform.localScale = newScale;

			newTextureScale = Vector2.one;
			newTextureScale.y = (pathPoints[i].transform.position - pathPoints[i-1].transform.position).magnitude;
			pathObject.GetComponent<Renderer>().material.mainTextureScale = newTextureScale;
		}

	}

	void OnDrawGizmos()
	{
		Gizmos.DrawLine (transform.position, pathPoints [0].transform.position);

		for (int i = 1; i < pathPoints.Length; i++) {

			Gizmos.DrawLine (pathPoints[i-1].transform.position, pathPoints[i].transform.position);

		}
	}
}
