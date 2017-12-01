using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CodigoMartillo : MonoBehaviour {

	public NivelVariables variables;
	public Button martillo;

	void Start () {
		martillo.GetComponent<Button>();
		martillo.onClick.AddListener(OnClick);
	}

	void OnClick(){
		if (variables.cursor == "Nada") {			
			variables.cursor = "Martillo";
			martillo.image.enabled = false;
		}
	}

	void Update(){
		if (Input.GetKeyDown(KeyCode.Mouse1)){
			if (variables.cursor == "Martillo"){
				variables.cursor = "Nada";
			}
		}

		if (variables.cursor == "Nada") {
			martillo.image.enabled = true;
		}
	}
}