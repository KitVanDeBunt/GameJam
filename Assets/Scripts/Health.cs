using UnityEngine;
using System.Collections;

public class Health : MonoBehaviour {

	public float enemyHealth = 100;
	public Transform explosion;

	
	public Sprite art1;
	public Sprite art2;
	public Sprite art3;
	
	void Start(){
		gameObject.GetComponent<SpriteRenderer> ().sprite = art1;
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if(other.gameObject.tag == "astroids")
		{
			//Debug.Log("Enemy Hit!");
			TakeDamage(10);
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
	}
	
	void EnemyDead()
	{
		Destroy(this.gameObject);
	}
	
}