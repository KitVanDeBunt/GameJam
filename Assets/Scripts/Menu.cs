using UnityEngine;
using System.Collections;

public class Menu : MonoBehaviour {
	private int xStart = 480;
	private int yStart = -50;

	public bool startClick;
	public Fader fader;
	// Use this for initialization
	void Start () {
		yStart = 0;
		fader = this.gameObject.GetComponent<Fader>();
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
			fader.fade = true;
			if(yStart >= 1400){
				yStart = 1400;
				Application.LoadLevel("JustinSceneTest");
			}
		}
	}

	void OnGUI(){

		if (GUI.Button (new Rect (xStart,yStart,300,150), "START")) {
			GUI.color = Color.yellow;
			startClick = true;
		}
	}
}
