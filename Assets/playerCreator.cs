using UnityEngine;
using System.Collections;

public class playerCreator : MonoBehaviour {

	void Awake () {
		GameObject player = GameObject.Instantiate(Menu.playerLoad,new Vector3(0,0,0),Quaternion.identity) as GameObject;
		GameObject.Find("Camera").GetComponent<CameraFollow>().cameraTarget = GameObject.Find("aplayer");
	}
}
