using UnityEngine;
using System.Collections;

public class Intro : MonoBehaviour {
	public string introText = "Hello \n This is a Intro";
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI(){
		introText = GUI.TextArea(new Rect(10, 10, 200, 20), introText, 25);
	}
}
