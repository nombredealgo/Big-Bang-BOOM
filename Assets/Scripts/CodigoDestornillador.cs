using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CodigoDestornillador : MonoBehaviour {

	public NivelVariables variables;
	public Button destornillador;

	// Use this for initialization
	void Start () {
		destornillador.GetComponent<Button>();
		destornillador.onClick.AddListener(OnClick);

	}
	void OnClick(){
		if (variables.cursor == "Nada") {
			variables.cursor = "Destornillador";
		}
	}
	// Update is called once per frame
	void Update () {
		
	}
}
