using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CodigoFlecha : MonoBehaviour {

	public NivelVariables variables;
	public Button flecha;

	void Start () {
		flecha.GetComponent<Button>();
		flecha.onClick.AddListener(OnClick);
	}

	void OnClick(){
		if (variables.cursor == "Nada") {			
			variables.cursor = "Flecha";
			flecha.image.enabled = false;
		}
	}

	void Update(){
		if (Input.GetKeyDown(KeyCode.Mouse1)){
			if (variables.cursor == "Flecha"){
				variables.cursor = "Nada";
			}
		}

		if (variables.cursor == "Nada") {
			flecha.image.enabled = true;
		}
	}
}
