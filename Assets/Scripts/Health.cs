using UnityEngine;
using System.Collections;

public class Health : MonoBehaviour {

	public float enemyHealth = 100f;
	public Transform explosion;

	void OnTriggerEnter2D(Collider2D other)
	{
		if(other.gameObject.tag == "astroids")
		{
			//Debug.Log("Enemy Hit!");
			TakeDamage(1f);
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
		Destroy(this.gameObject);
	}
	
}