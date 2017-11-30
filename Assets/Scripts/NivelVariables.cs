using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NivelVariables : MonoBehaviour {

	private GameManager gameManger;
	public Image avatar;

	public Texture2D Dest;
	public Texture2D Alic;

	public Text delante;
	public Text detras;
	//[HideInInspector]
	public float contadorDelantero = 10;
	//[HideInInspector]
	public float contadorTrasero = 59;
	[HideInInspector]
	public bool terminado = false;

	public string cursor;

	// Use this for initialization
	void Start () {
//
//		delante.text = contadorDelantero + ":";
//		detras.text = "" + contadorTrasero;
		gameManger = GameObject.Find ("Game Manager").GetComponent<GameManager> ();
		gameManger.ChargeAvatar ();

		string name = gameManger.GetAvatarName();

		switch (name) {
		case "Avatar 01 Button":
			avatar.sprite = Resources.Load<Sprite> ("Textures/Avatars/Avatar01");
			break;
		case "Avatar 02 Button":
			avatar.sprite = Resources.Load<Sprite> ("Textures/Avatars/Avatar02");
			break;
		case "Avatar 03 Button":
			avatar.sprite = Resources.Load<Sprite> ("Textures/Avatars/Avatar03");
			break;
		case "Avatar 04 Button":
			avatar.sprite = Resources.Load<Sprite> ("Textures/Avatars/Avatar04");
			break;
		case "Avatar 05 Button":
			avatar.sprite = Resources.Load<Sprite> ("Textures/Avatars/Avatar05");
			break;
		case "Avatar 06 Button":
			avatar.sprite = Resources.Load<Sprite> ("Textures/Avatars/Avatar06");
			break;
		}
		terminado = false;
		cursor = "Nada";
	}
	
	// Update is called once per frame
	void Update () {
//		CodigoContador ();
//		CodigoCursor ();			
	}

	void CodigoCursor(){
		if (cursor == "Nada") {
			
			Cursor.SetCursor(null,new Vector2(180,200),CursorMode.Auto);
		} else {
			//Cursor.visible = false;
			if (cursor == "Destornillador") {
				
				Cursor.SetCursor(Dest,new Vector2(16,20),CursorMode.ForceSoftware);
			}
			if (cursor == "Alicates") {

				Cursor.SetCursor(Alic,new Vector2(16,20),CursorMode.ForceSoftware);
			}

		}
	}
	void CodigoContador(){
		
		if (contadorTrasero >= 0){
			contadorTrasero -= Time.deltaTime;
		}
		if (contadorTrasero == 0) {
			if (contadorDelantero != 0) {
				contadorDelantero--;
				contadorTrasero = 59;
			}
		}
		if (contadorDelantero < 10) {
			delante.text = "0" + contadorDelantero + ":";
		} else {
			delante.text = contadorDelantero + ":";
		}
		if (contadorTrasero < 10 && contadorTrasero > -1) {
			detras.text = "0" + contadorTrasero;
		} 
		if (contadorTrasero < 0) {
			detras.text = "00";
		}
		if (contadorTrasero >=10) {
			detras.text = "" + contadorTrasero;
		}
	}

}
