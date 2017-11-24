using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class casillaCablesComplicada : MonoBehaviour {

	public Button verdadero;

	// Use this for initialization
	void Start () {
		verdadero.onClick.AddListener (terminado);
	}

	void terminado(){
		Debug.Log ("terminado");
	}

}
