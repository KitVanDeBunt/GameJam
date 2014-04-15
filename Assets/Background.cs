using UnityEngine;
using System.Collections;

public class Background : MonoBehaviour {

	public float speed = 0;
	public float offscreen;
	public float highest;
	public float lowest;


	void Update () 
	{
		transform.Translate(Vector2.right * speed);

		while (transform.position.x < offscreen)
		{
			transform.position = new Vector3(12,Random.Range(highest, lowest),0);
		}
	}
}
