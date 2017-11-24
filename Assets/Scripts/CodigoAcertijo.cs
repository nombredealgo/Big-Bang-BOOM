using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CodigoAcertijo: MonoBehaviour {

	public Canvas acertijo;
	public Button volver;
	public InputField entrada;
	public GameObject casilla;
	// Use this for initialization

	void Start () {
		volver.GetComponent<Button>();
		volver.onClick.AddListener(OnClick);
		entrada.onEndEdit.AddListener (delegate {OnEndEdit(entrada);});
	}

	void OnClick(){
		acertijo.gameObject.SetActive (false);
	}

	void OnEndEdit(InputField ent){
		
			if (ent.text == "piojo") {
				acertijo.gameObject.SetActive (false);
				casilla.SetActive (false);
			}
	}
	// Update is called once per frame
	void Update () {
		
	}
}
