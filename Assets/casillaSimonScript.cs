using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class casillaSimonScript : MonoBehaviour {

	public AudioSource rojo;
	public AudioSource verde;
	public AudioSource azul;
	public AudioSource amarillo;

	public AudioSource todosenOrden;
	public Button todosSounds;

	public Button brojo;
	public Button bazul;
	public Button bverde;
	public Button bamarillo;

	public GameObject casillaSiguiente;
	public GameObject casillaCerrada;

	bool p1,p2,p3,p4 = false;//esto para calcular si ha tocado bien los cosos;

	void Start(){


		brojo.GetComponent<Button>();
		brojo.onClick.AddListener(ClickRojo);

		bazul.GetComponent<Button>();
		bazul.onClick.AddListener(ClickAzul);

		bamarillo.GetComponent<Button>();
		bamarillo.onClick.AddListener(ClickAmarillo);

		bverde.GetComponent<Button> ();
		bverde.onClick.AddListener(ClickVerde);

		todosSounds.GetComponent<Button>();
		todosSounds.onClick.AddListener(ClickTodos);
	}

	void ClickRojo(){
		rojo.Play();
		if (p1 == false) {
			p1 = true;
		} 
	}
	void ClickAzul(){
		azul.Play();
		if (p1 == true) {
			if (p2 == false) {
				p2 = true; 
			}
		}
		else{
			reinicia ();
		}
	}
	void ClickVerde(){
		verde.Play();

		if (p2 == true) {
			if (p3 == false) {
				p3 = true;
			} else if (p4 == true) {				
				Debug.Log ("terminado");
				casillaCerrada.SetActive (false);
				casillaSiguiente.SetActive (true);
				brojo.interactable = false;
				bazul.interactable = false;
				bverde.interactable = false;
				bamarillo.interactable = false;
				todosSounds.interactable = false;
			}
		}

		
	}
	void ClickAmarillo(){
		amarillo.Play();

		if (p3 == true) {
			if (p4 == false) {
				p4 = true;
			}
		} else {
			reinicia ();
		}

	}

	void reinicia(){
		p1 = false;
		p2 = false;
		p3 = false;
		p4 = false;

	}
	void ClickTodos(){
		
		todosenOrden.Play();
	}
		
}
