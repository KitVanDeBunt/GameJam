using UnityEngine;
using System.Collections;

public class SpawnClouds : MonoBehaviour {
	public Transform clouds;
	private int first;
	private int second;
	private int third;

	// Use this for initialization
	void Start () {
		transform.position = new Vector3 (Random.seed = 20,Random.seed = 20,Random.seed = 20);
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position.x >= Screen.width) {
			Instantiate(clouds, this.transform.position, this.transform.rotation);
		}
	}
}
