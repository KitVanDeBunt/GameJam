using UnityEngine;
using System.Collections;

public class Health : MonoBehaviour {

	public float enemyHealth = 100;
	public Transform explosion;

	private static float healthPoints = 100;
	public GUIText healthText;


	void Awake(){
		healthText = GameObject.FindGameObjectWithTag ("HealthTextUI").GetComponent<GUIText> ();
	}
	
	public Sprite art1;
	public Sprite art2;
	public Sprite art3;
	public Sprite art4;


	
	void Start(){
		gameObject.GetComponent<SpriteRenderer> ().sprite = art1;
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if(other.gameObject.tag == "astroids")
		{
			TakeDamage(2f);
			healthPoints -= 2;
			Destroy (other.gameObject);
			Instantiate(explosion, other.transform.position, other.transform.rotation);
		}
	}
	void TakeDamage (float dmg)
	{
		enemyHealth -= dmg;
		if(enemyHealth <= 70)
		{
			gameObject.GetComponent<SpriteRenderer> ().sprite = art2;
		}
		
		if(enemyHealth <= 40)
		{
			gameObject.GetComponent<SpriteRenderer> ().sprite = art3;
		}
		if (enemyHealth <= 5) {
			
			gameObject.GetComponent<SpriteRenderer> ().sprite = art4;
		}
		if(enemyHealth <= 0)
		{
			EnemyDead();
		}
	}
	
	void EnemyDead()
	{
		healthPoints = 101f;
		Destroy(this.gameObject);
		Application.LoadLevel("Main");
	}

	void Update(){
		healthText.text = "Health = " + healthPoints;
	}

	
}