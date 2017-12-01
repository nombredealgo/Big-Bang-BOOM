using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CasillaTornillos : MonoBehaviour {

	public NivelVariables variables;
	public GameObject casillaboton;
	public Button boton;

	void Start () {
		boton.GetComponent<Button>();
		boton.onClick.AddListener(OnClick);
		casillaboton.gameObject.SetActive (false);
	}

	void OnClick(){
		if (variables.cursor == "Destornillador") {
			casillaboton.gameObject.SetActive (true);
			boton.gameObject.SetActive (false);
			variables.cursor = "Nada";
		}
	}
}
