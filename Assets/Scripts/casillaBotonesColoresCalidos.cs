using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class casillaBotonesColoresCalidos : MonoBehaviour {

	public SpriteRenderer luz1;
	public Button botonCorrecto;

	public GameObject casillaSiguiente;
	public GameObject casilla;

	// Use this for initialization

	void Start () {
		botonCorrecto.GetComponent<Button>();
		botonCorrecto.onClick.AddListener(OnClick);
		
	}

	void OnClick(){
		luz1.color = Color.green;
		casillaSiguiente.SetActive (true);
		casilla.SetActive (false);

	}
	// Update is called once per frame
	void Update () {
		
	}
}
