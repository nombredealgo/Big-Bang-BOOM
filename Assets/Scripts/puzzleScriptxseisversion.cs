using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class puzzleScriptxseisversion : MonoBehaviour {

	public Button b1,b2,b3,b4,b5,b6;

    GameManager GM;
	Sprite aux = null ;
	int pulsado1 = 0;
	int pulsado2 = 0;


	// Use this for initialization
	void Start () {
        GM = GameObject.Find("Game Manager").GetComponent<GameManager>();
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


	void cambiaPiezas(){
		aux = GameObject.Find("d" + pulsado1).GetComponent<Button>().image.sprite;
		GameObject.Find("d" + pulsado1).GetComponent<Button>().image.sprite = GameObject.Find("d" + pulsado2).GetComponent<Button>().image.sprite;
		GameObject.Find("d" + pulsado2).GetComponent<Button>().image.sprite = aux;
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
                GM.EndOfLevel(true, 5);	
				Debug.Log ("Terminas el nivel");
              
			}
		}

		 
	}

}
