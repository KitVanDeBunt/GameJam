using UnityEngine;
using System.Collections;

public class KilledBomb : MonoBehaviour {

	public Transform explosion;

	private string textScore;
	private static float score = 0;
	public GUIText scoreText;

	void Awake(){
		scoreText = GameObject.FindGameObjectWithTag ("ScoreTextUI").GetComponent<GUIText> ();
		textScore = score.ToString ();
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
