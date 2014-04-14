using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour
{
	public GameObject cameraTarget;
	
	public float smoothTime = 0.1f;
	public bool cameraFollowX = true;
	public bool cameraFollowY = true;
	
	private Vector2 velocity;
	private Vector3 newPos;
	private float newXPos;
	private float newYPos;
	private Vector3 targetPos;
	
	public float maxXpos;
	public float minXpos;
	public float maxYpos;
	public float minYpos;

	private float size;
	public float maxSizeDelta = 0.1f;
	
	void LateUpdate()
	{
		//camera size
		float currentSize = gameObject.GetComponent<Camera>().orthographicSize;
		float targetCamSize = 10+velocity.magnitude/10;
		float deltaSize = targetCamSize-currentSize;
		float camSize;
		if(deltaSize<maxSizeDelta&&deltaSize>-maxSizeDelta){
			camSize = currentSize+deltaSize;
		}if(deltaSize>0){
			camSize = currentSize+maxSizeDelta;
		}else{
			camSize = currentSize-maxSizeDelta;
		}
		Debug.Log(camSize);

		gameObject.GetComponent<Camera>().orthographicSize = camSize;


		newPos = transform.position;
		targetPos = cameraTarget.transform.position;
		
		if (cameraFollowX)
		{
			newXPos = Mathf.SmoothDamp(newPos.x, targetPos.x, ref velocity.x, smoothTime);
		}
		if (cameraFollowY)
		{
			newYPos = Mathf.SmoothDamp(newPos.y, targetPos.y, ref velocity.y, smoothTime);
		}
		if(newXPos>maxXpos){
			newXPos = maxXpos;
		}else if(newXPos<minXpos){
			newXPos = minXpos;
		}
		if(newYPos>maxYpos){
			newYPos = maxYpos;
		}else if(newYPos<minYpos){
			newYPos = minYpos;
		}
		//Update camera position
		newPos = new Vector3(newXPos,newYPos,newPos.z);
		transform.position = newPos;
	}
}
