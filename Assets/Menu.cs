using UnityEngine;
using System.Collections;

public class Menu : MonoBehaviour {
	private int xStart = 240;
	private int yStart = -50;

	public bool startClick;

	// Use this for initialization
	void Start () {
		yStart = 0;
	}
	
	// Update is called once per frame
	void Update () {
		yStart += 5;
		if (startClick == false) {
			if (yStart >= 100) {
				yStart = 100;
			}
		}
		if (startClick == true) {
			yStart += 5;
			if(yStart >= 500){
				yStart = 500;
				print(yStart);
			}
		}
	}

	void OnGUI(){

		if (GUI.Button (new Rect (xStart,yStart,100,50), "START")) {
			GUI.color = Color.yellow;
			startClick = true;
		}
	}
}
