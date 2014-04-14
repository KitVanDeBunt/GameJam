using UnityEngine;
using System.Collections;

public class Health : MonoBehaviour {

	public float enemyHealth = 100f;

	//void OnCollisionEnter2D(Collider2D other){

		//}
	void OnTriggerEnter2D(Collider2D other)
	{
		if(other.gameObject.tag == "astroids")
		{
			Debug.Log("Enemy Hit!");
			TakeDamage(50f);
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