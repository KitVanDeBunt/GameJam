using UnityEngine;
using System.Collections;

public class Bombscript : MonoBehaviour {
	
	public float spawnTime = 0;
	public float spawnDelay = 0;

	public Transform spawn1;
	public Transform spawn2;

	public Vector3 spawnPos1;
	public Vector3 spawnPos2;
	public GameObject[] enemies;
	
	void Start ()
	{
		InvokeRepeating("Spawn", spawnDelay, spawnTime);

		spawnPos1 = spawn1.position;
		spawnPos2 = spawn2.position;
	}
	
	void Spawn ()
	{

		Vector3 disSpawn = new Vector3 (spawnPos2.x - Random.Range(-5,5), spawnPos1.y - spawnPos1.y, 0);
		Vector3 spawnPos = spawnPos1 + disSpawn;
		int enemyIndex = Random.Range(0, enemies.Length);
		Instantiate(enemies[enemyIndex], spawnPos, transform.rotation);
	}
}