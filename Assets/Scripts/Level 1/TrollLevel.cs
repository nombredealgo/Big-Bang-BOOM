using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class TrollLevel : MonoBehaviour {

	public NivelVariables variables;
	public Button boton;

	public List<Button> openedBoxes;

	// Use this for initialization
	void Start () {

		boton.GetComponent<Button>();
		boton.onClick.AddListener(OnClick);

	}

	void OnClick(){
		//if (variables.cursor == "Martillo") && 
		if (variables.cursor == "Destornillador") {
			boton.gameObject.SetActive (false);
			variables.cursor = "Nada";
		}
	}
	// Update is called once per frame
	void Update () {

	}
}
