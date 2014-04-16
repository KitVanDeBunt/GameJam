using UnityEngine;
using System.Collections;

public class KilledBomb : MonoBehaviour {

	public Transform explosion;
	void OnTriggerEnter2D(Collider2D other)
	{
		if(other.gameObject.tag == "astroids")
		{
			Destroy (other.gameObject);
			Instantiate(explosion, other.transform.position, other.transform.rotation);
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
