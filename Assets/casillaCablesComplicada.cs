using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class casillaCablesComplicada : MonoBehaviour {

	public Button verdadero;
	public NivelVariables variables;

	// Use this for initialization
	void Start () {
		verdadero.onClick.AddListener (terminado);
	}

	void terminado(){
		if (variables.cursor == "Alicates") {
			Debug.Log ("terminado");
		}
	}

}
