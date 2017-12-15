using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class casillaCablesComplicada : MonoBehaviour {

	GameManager gameManager;

	public Button verdadero;
	public NivelVariables variables;

	// Use this for initialization
	void Start () {
		verdadero.onClick.AddListener (terminado);
		gameManager = GameObject.Find ("Game Manager").GetComponent<GameManager> ();

	}

	void terminado(){
		if (variables.cursor == "Alicates") {
			variables.cursor = "Nada";
			gameManager.EndOfLevel (true, 2);
		}
	}

}
