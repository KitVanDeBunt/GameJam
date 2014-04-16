using UnityEngine;
using System.Collections;
using System.Collections.Generic;


[System.Serializable]
public class PlayerHolder{
	public GameObject player;
	public Texture playerImg;
}

public class Menu : MonoBehaviour {
	private float native_width = 768;
	private float native_height = 1280;
	
	private int xStart = 768/2-150;
	private int yStart = -50;
	
	public Texture startTexture;
	public Texture nextTexture;
	public Texture backTexture;
	public GUIStyle style;
	
	public bool startClick;
	public Fader fader;
	
	public Transform explosion;

	public List<PlayerHolder> playerList;

	public int currentPlayer;
	
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
				Application.LoadLevel("GameTester");
			}
		}
	}
	
	void OnGUI(){
		float rx = Screen.width / native_width;
		float ry = Screen.height / native_height;
		GUI.matrix = Matrix4x4.TRS (new Vector3(0, 0, 0), Quaternion.identity, new Vector3 (rx, ry, 1)); 
		GUI.skin.button = style;
		GUILayout.Button ("");
		GUI.color = new Color(255, 255, 255, 1);
		if (GUI.Button (new Rect (xStart,yStart,300,150), startTexture)) {
			GUI.color = Color.yellow;
			startClick = true;
		}

		if (GUI.Button (new Rect (100,500,nextTexture.width/10,nextTexture.height/10), nextTexture)) {
			GUI.color = Color.yellow;
			currentPlayer++;
			if(currentPlayer>playerList.Count-1){
				currentPlayer = 0;
			}
		}
		if (GUI.Button (new Rect (600,500,backTexture.width/10,backTexture.width/10), backTexture)) {
			GUI.color = Color.yellow;
			currentPlayer--;
			if(currentPlayer<0){
				currentPlayer = playerList.Count-1;
			}
		}

		GUI.Box(new Rect(768/2-(playerList[currentPlayer].playerImg.width/2),300
		                 ,playerList[currentPlayer].playerImg.width
		                 ,playerList[currentPlayer].playerImg.height)
		        ,playerList[currentPlayer].playerImg);
		//playerList
	}
}
