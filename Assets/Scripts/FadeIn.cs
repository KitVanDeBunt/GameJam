using UnityEngine;
using System.Collections;

public class FadeIn : MonoBehaviour {
	private float alphaFadeValue = 1;
	public Texture aTexture;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
			alphaFadeValue -= 0.01f;
	}
	void OnGUI(){
		GUI.color = new Color(255, 255, 255, alphaFadeValue);
		GUI.Box(new Rect(0, 0, Screen.width, Screen.height), "");
		
		
		GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), aTexture, ScaleMode.ScaleToFit, true, -10.0F);
	}
}
