using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class puzzleScript : MonoBehaviour {

	public Button b1,b2,b3,b4,b5,b6,b7,b8,b9,b10,b11,b12,volver;
	public GameObject puzzleCanvas;

	public Button puzzle;

	public GameObject casillaSiguiente;
	public GameObject casillaCerrada;

	Sprite aux = null ;
	int pulsado1 = 0;
	int pulsado2 = 0;


	// Use this for initialization
	void Start () {
		b1.GetComponent<Button>();
		b1.onClick.AddListener(PasanCosas1);

		b2.GetComponent<Button>();
		b2.onClick.AddListener(PasanCosas2);

		b3.GetComponent<Button>();
		b3.onClick.AddListener(PasanCosas3);

		b4.GetComponent<Button> ();
		b4.onClick.AddListener(PasanCosas4);

		b5.GetComponent<Button>();
		b5.onClick.AddListener(PasanCosas5);

		b6.GetComponent<Button>();
		b6.onClick.AddListener(PasanCosas6);

		b7.GetComponent<Button>();
		b7.onClick.AddListener(PasanCosas7);

		b8.GetComponent<Button>();
		b8.onClick.AddListener(PasanCosas8);

		b9.GetComponent<Button>();
		b9.onClick.AddListener(PasanCosas9);

		b10.GetComponent<Button>();
		b10.onClick.AddListener(PasanCosas10);

		b11.GetComponent<Button>();
		b11.onClick.AddListener(PasanCosas11);

		b12.GetComponent<Button>();
		b12.onClick.AddListener(PasanCosas12);

		volver.GetComponent<Button>();
		volver.onClick.AddListener(OnClick);
	}

	void OnClick(){
		puzzleCanvas.SetActive (false);
	}
	void PasanCosas1(){
		if (pulsado1 == 0) {
			pulsado1 = 1;
		} else if (pulsado2 == 0) {
			pulsado2 = 1;
			cambiaPiezas ();
		}
	}
	void PasanCosas2(){
		if (pulsado1 == 0) {
			pulsado1 = 2;
		} else if (pulsado2 == 0) {
			pulsado2 = 2;
			cambiaPiezas ();
		}
	}
	void PasanCosas3(){
		if (pulsado1 == 0) {
			pulsado1 = 3;
		} else if (pulsado2 == 0) {
			pulsado2 = 3;
			cambiaPiezas ();
		}
	}
	void PasanCosas4(){
		if (pulsado1 == 0) {
			pulsado1 = 4;
		} else if (pulsado2 == 0) {
			pulsado2 = 4;
			cambiaPiezas ();
		}
	}
	void PasanCosas5(){
		if (pulsado1 == 0) {
			pulsado1 = 5;
		} else if (pulsado2 == 0) {
			pulsado2 = 5;
			cambiaPiezas ();
		}
	}
	void PasanCosas6(){
		if (pulsado1 == 0) {
			pulsado1 = 6;
		} else if (pulsado2 == 0) {
			pulsado2 = 6;
			cambiaPiezas ();
		}
	}
	void PasanCosas7(){
		if (pulsado1 == 0) {
			pulsado1 = 7;
		} else if (pulsado2 == 0) {
			pulsado2 = 7;
			cambiaPiezas ();
		}
	}
	void PasanCosas8(){
		if (pulsado1 == 0) {
			pulsado1 = 8;
		} else if (pulsado2 == 0) {
			pulsado2 = 8;
			cambiaPiezas ();
		}
	}
	void PasanCosas9(){
		if (pulsado1 == 0) {
			pulsado1 = 9;
		} else if (pulsado2 == 0) {
			pulsado2 = 9;
			cambiaPiezas ();
		}
	}
	void PasanCosas10(){
		if (pulsado1 == 0) {
			pulsado1 = 10;
		} else if (pulsado2 == 0) {
			pulsado2 = 10;
			cambiaPiezas ();
		}
	}

	void PasanCosas11(){
		if (pulsado1 == 0) {
			pulsado1 = 11;
		} else if (pulsado2 == 0) {
			pulsado2 = 11;
			cambiaPiezas ();
		}
	}

	void PasanCosas12(){
		if (pulsado1 == 0) {
			pulsado1 = 12;
		} else if (pulsado2 == 0) {
			pulsado2 = 12;
			cambiaPiezas ();
		}
	}


	void cambiaPiezas(){
		aux = GameObject.Find("" + pulsado1).GetComponent<Button>().image.sprite;
		GameObject.Find("" + pulsado1).GetComponent<Button>().image.sprite = GameObject.Find("" + pulsado2).GetComponent<Button>().image.sprite;
		GameObject.Find("" + pulsado2).GetComponent<Button>().image.sprite = aux;
		aux = null;
		pulsado1 = 0;
		pulsado2 = 0;
		comprueba ();
	}
	void comprueba(){
		// hacer una tupla de bottones podria ser la solucion :D
		Debug.Log ("" + b1.image.sprite.name);
		if ((b1.image.sprite.name == "1") && (b2.image.sprite.name == "2") && (b3.image.sprite.name == "3")){
			if ((b4.image.sprite.name == "4") && (b5.image.sprite.name == "5") && (b6.image.sprite.name == "6")) {
				if ((b7.image.sprite.name == "7") && (b8.image.sprite.name == "8") && (b9.image.sprite.name == "9")) {
					if ((b10.image.sprite.name == "10") && (b11.image.sprite.name == "11") && (b12.image.sprite.name == "12")) {
						puzzleCanvas.SetActive (false);
						casillaCerrada.SetActive (false);
						casillaSiguiente.SetActive (true);
						puzzle.interactable = false;
					}
				}
			}
		} 
	}
	// Update is called once per frame
	void Update () {
		
	}
}
