using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class DistanceJointBuild : MonoBehaviour {


	[SerializeField]
	private Transform anchorPoint;
	
	[SerializeField]
	private Transform conAnchorPoint;
	
	[SerializeField]
	private Rigidbody2D connectedBody;
	
	[SerializeField]
	private bool collideWithConected;
	
	[SerializeField]
	private float distence;

	void Start () {
		SpringJoint2D joint = gameObject.AddComponent<SpringJoint2D>();

		joint.frequency = 9;

		joint.dampingRatio = 0;

		joint.connectedBody = connectedBody;

		joint.collideConnected = false;

		joint.distance = distence;

		joint.anchor = new Vector2(anchorPoint.localPosition.x
		                           ,anchorPoint.localPosition.y);
		joint.connectedAnchor = new Vector2(conAnchorPoint.localPosition.x
		                           ,conAnchorPoint.localPosition.y);
	}
}
