using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour
{
	public GameObject cameraTarget;
	
	public float smoothTimeSize = 0.1f;
	public float smoothTimeMove = 0.01f;

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

	private float sizeVelocity;
	private float size;
	public float maxSizeDelta = 0.1f;
	public float maxCamSize = 20f;
	
	void LateUpdate()
	{
		//camera size
		float currentSize = gameObject.GetComponent<Camera>().orthographicSize;
		float targetCamSize = 12+velocity.magnitude/10;
		float deltaSize = targetCamSize-currentSize;
		float camSize;

		/*
		if(deltaSize<maxSizeDelta&&deltaSize>-maxSizeDelta){
			camSize = currentSize+deltaSize;
			print(deltaSize);
		}if(deltaSize>0){
			camSize = currentSize+maxSizeDelta;
			print("------------------------");
		}else{
			camSize = currentSize-maxSizeDelta;
			print("++++++++++++++++++++++++");
		}*/

		//Debug.Log(camSize);
		if(targetCamSize<maxCamSize){
			camSize = Mathf.SmoothDamp(currentSize,targetCamSize,ref sizeVelocity,smoothTimeMove);
			gameObject.GetComponent<Camera>().orthographicSize = camSize;
		}


		newPos = transform.position;
		targetPos = cameraTarget.transform.position;

		if(targetPos.x>maxXpos){
			targetPos.x = maxXpos;
		}else if(targetPos.x<minXpos){
			targetPos.x = minXpos;
		}
		if (cameraFollowX)
		{
			newXPos = Mathf.SmoothDamp(newPos.x, targetPos.x, ref velocity.x, smoothTimeMove);
		}

		if(targetPos.y>maxYpos){
			targetPos.y = maxYpos;
		}else if(targetPos.y<minYpos){
			targetPos.y = minYpos;
		}
		if (cameraFollowY)
		{
			newYPos = Mathf.SmoothDamp(newPos.y, targetPos.y, ref velocity.y, smoothTimeMove);
		}

		//Update camera position
		newPos = new Vector3(newXPos,newYPos,newPos.z);
		transform.position = newPos;
	}
}
