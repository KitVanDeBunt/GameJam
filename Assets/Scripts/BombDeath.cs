using UnityEngine;
using System.Collections;

public class BombDeath : MonoBehaviour {

	public void OnDeath(){
		Destroy (this.gameObject);
	}
}
