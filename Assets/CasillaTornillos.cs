using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CasillaTornillos : MonoBehaviour {

	public NivelVariables variables;
	public GameObject casillaboton;
	public Button boton;

	// Use this for initialization
	void Start () {

		boton.GetComponent<Button>();
		boton.onClick.AddListener(OnClick);
		casillaboton.gameObject.SetActive (false);
	}

	void OnClick(){
		if (variables.cursor == "Destornillador") {
			casillaboton.gameObject.SetActive (true);
			boton.gameObject.SetActive (false);
		}
	}
	// Update is called once per frame
	void Update () {
		
	}
}
