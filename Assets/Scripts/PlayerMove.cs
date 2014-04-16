using UnityEngine;
using System.Collections;

public class PlayerMove : MonoBehaviour {

	[SerializeField]
	private float speed = 10;
	[SerializeField]
	private Transform forceTransform;

	void Update () {

		Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
		Vector2 mousePos = new Vector2(ray.origin.x,ray.origin.y);
		Vector2 thisPos2D = new Vector2(forceTransform.position.x,forceTransform.position.y);
		Vector2 dist = new Vector2(thisPos2D.x-mousePos.x,thisPos2D.y-mousePos.y);
		dist.Normalize();
		float distFloat = Vector2.Distance(mousePos,thisPos2D);
		dist = dist*-speed*distFloat;
		//move
		rigidbody2D.AddForceAtPosition(dist,forceTransform.position);
	}
}
