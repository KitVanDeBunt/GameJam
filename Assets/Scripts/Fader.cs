using UnityEngine;
using System.Collections;

public class Fader : MonoBehaviour {
	private float alphaFadeValue = 0;
	public bool fade = false;
	public Texture aTexture;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (fade == true) {
			alphaFadeValue += 0.01f;
		}
	}
	void OnGUI(){
		GUI.color = new Color(255, 255, 255, alphaFadeValue);
		GUI.Box(new Rect(0, 0, Screen.width, Screen.height), "");


		GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), aTexture, ScaleMode.ScaleToFit, true, -10.0F);
		print ("screen height:" + Screen.height);
	}
}
