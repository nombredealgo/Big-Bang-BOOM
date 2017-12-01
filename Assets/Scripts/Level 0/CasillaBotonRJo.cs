using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CasillaBotonRJo : MonoBehaviour {

	public GameObject casillaCerrada;
	public Button botonRojo;
	public GameObject casillaBotoncitos;
	public GameObject HintPanel;

	void Start () {
		botonRojo.GetComponent<Button>();
		botonRojo.onClick.AddListener(OnClick);
		casillaBotoncitos.gameObject.SetActive (false);
	}

	void OnClick(){
		casillaCerrada.gameObject.SetActive (false);
		casillaBotoncitos.gameObject.SetActive (true);
		botonRojo.GetComponent<Button> ().interactable = false;

		HintPanel.gameObject.SetActive (true);
		HintPanel.GetComponentInChildren<Text> ().text = "Dejame darte una pista... esto va de letras, no de colores. ¡Adelate!";
	}
}
