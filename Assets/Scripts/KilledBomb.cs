using UnityEngine;
using System.Collections;

public class KilledBomb : MonoBehaviour {

	public Transform explosion;

	private static float score = 0;
	public GUIText scoreText;


	void Awake(){
		scoreText = GameObject.FindGameObjectWithTag ("ScoreTextUI").GetComponent<GUIText> ();
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if(other.gameObject.tag == "astroids")
		{
			Destroy (other.gameObject);
			Instantiate(explosion, other.transform.position, other.transform.rotation);
			score += 5;
		}
	}

	void Update () {
		scoreText.text = "SCORE = " + score;

	}
}
