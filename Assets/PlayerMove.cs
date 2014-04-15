using UnityEngine;
using System.Collections;

public class PlayerMove : MonoBehaviour {

	[SerializeField]
	private float speed = 10;
	public GameObject arrow;

	void Update () {

		Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
		Vector2 mousePos = new Vector2(ray.origin.x,ray.origin.y);
		Vector2 thisPos2D = new Vector2(transform.position.x,transform.position.y);
		Vector2 dist = new Vector2(thisPos2D.x-mousePos.x,thisPos2D.y-mousePos.y);
		dist.Normalize();
		float distFloat = Vector2.Distance(mousePos,thisPos2D);
		dist = dist*-speed*distFloat;
		//move
		rigidbody2D.AddForce(dist);

		//rotate
		float angle = Vector2.Angle(mousePos,thisPos2D);
		//Debug.Log("\n"+angle);
		Quaternion ang = new Quaternion();
		ang.eulerAngles = new Vector3(0,0,angle);
		arrow.transform.rotation = ang;
		//rigidbody2D.AddTorque();
	}
}
