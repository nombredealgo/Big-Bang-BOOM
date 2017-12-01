using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MartilloEnCaja : MonoBehaviour {

	public GameObject martilloEnCaja;
	public Button martilloCasilla;

	void Start () {
		martilloCasilla.GetComponent<Button>();
		martilloCasilla.onClick.AddListener(OnClick);
	}

	void OnClick(){
		martilloEnCaja.SetActive (true);
		martilloCasilla.GetComponent<Button> ().interactable = false;
	}
}