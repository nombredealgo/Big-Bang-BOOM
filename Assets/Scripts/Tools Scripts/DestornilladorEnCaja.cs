using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DestornilladorEnCaja : MonoBehaviour {

	public GameObject destornilladorCaja;
	public Button destornilladorCasilla;

	// Use this for initialization
	void Start () {
		destornilladorCasilla.GetComponent<Button>();
		destornilladorCasilla.onClick.AddListener(OnClick);
	}

	void OnClick(){
		destornilladorCaja.SetActive (true);
		destornilladorCasilla.GetComponent<Button> ().interactable = false;
	}
	// Update is called once per frame
	void Update () {
		
	}
}
