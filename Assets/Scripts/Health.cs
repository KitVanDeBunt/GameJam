using UnityEngine;
using System.Collections;

public class Health : MonoBehaviour {

	public float enemyHealth = 100f;
	public Transform explosion;

	private static float healthPoints = 100;
	public GUIText healthText;

	void Awake(){
		healthText = GameObject.FindGameObjectWithTag ("HealthTextUI").GetComponent<GUIText> ();
	}
	void OnTriggerEnter2D(Collider2D other)
	{
		if(other.gameObject.tag == "astroids")
		{
			//Debug.Log("Enemy Hit!");
			TakeDamage(1f);
			healthPoints -= 1;
			Destroy (other.gameObject);
			Instantiate(explosion, other.transform.position, other.transform.rotation);
		}
	}
	void TakeDamage (float dmg)
	{
		enemyHealth -= dmg;
		
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