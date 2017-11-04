using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class casillaCables : MonoBehaviour {


	public Button cable1;
	public Button cable2;
	public Button cable3;

	bool terminado = false;
	// Use this for initialization
	void Start () {
		
		cable1.GetComponent<Button>();
		cable1.onClick.AddListener(CableCortado1);

		cable2.GetComponent<Button>();
		cable2.onClick.AddListener(CableCortado2);

		cable3.GetComponent<Button>();
		cable3.onClick.AddListener(CableCortado3);
	}

	void CableCortado1 (){
		AverQueCableHasCortado (1);
	}
	void CableCortado2 (){
		AverQueCableHasCortado (2);
	}
	void CableCortado3 (){
		AverQueCableHasCortado (3);
	}

	void AverQueCableHasCortado (int id){
		if (terminado == false) {
			if (id == 1) {
				Debug.Log ("Cortado cable rojo");
			}
			if (id == 2) {
				Debug.Log ("Cortado cable amarillo");
			}
			if (id == 3) {
				Debug.Log ("Cortado cable turquesamagico");
				terminado = true;
			}
		}
	}
	// Update is called once per frame
	void Update () {

	}
}
