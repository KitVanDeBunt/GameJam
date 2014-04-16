using UnityEngine;
using System.Collections;

public class Menu : MonoBehaviour {
	private int xStart = 480;
	private int yStart = -50;

	public Texture startTexture;
	public GUIStyle style;

	public bool startClick;
	public Fader fader;

	public Transform explosion;

	void Start () {
		yStart = 0;
		fader = GetComponent<Fader> ();
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
			if(yStart >= 680){
				Fader.fade = true;
				Instantiate(explosion,new Vector3(xStart,yStart),this.transform.rotation);
			}
			if(yStart >= 1200){
				Application.LoadLevel("JustinTestScene");
			}
		}
	}

	void OnGUI(){
		GUI.skin.button = style;
		GUILayout.Button ("");
		GUI.color = new Color(255, 255, 255, 1);
		if (GUI.Button (new Rect (xStart,yStart,300,150), startTexture)) {
			GUI.color = Color.yellow;
			startClick = true;
		}
	}
}
