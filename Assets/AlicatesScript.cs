using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class AlicatesScript : MonoBehaviour {

	public NivelVariables variables;
	public Button alicates;

	// Use this for initialization
	void Start () {
		
		alicates.onClick.AddListener(OnClick);

	}
	void OnClick(){
		if (variables.cursor == "Nada") {
			variables.cursor = "Alicates";
			alicates.image.enabled = false;
		}
	}
	// Update is called once per frame
	void Update(){
		if (Input.GetKeyDown(KeyCode.Mouse1)){
			if (variables.cursor == "Alicates"){
				variables.cursor = "Nada";

			}

		}
		if (variables.cursor == "Nada") {
			alicates.image.enabled = true;
		}
	}

}
