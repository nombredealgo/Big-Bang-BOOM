using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CodigoCasillaBotones : MonoBehaviour {

	public GameObject casillaCerrada;
	public GameObject casillaCables;

	public Button bton1;
	public Button bton2;
	public Button bton3;
	public Button bton4;
	public Button bton5;
	public Button bton6;

	string pulsado1 = null;
	string pulsado2 = null;
	int idpulsado1 = 0;
	string primero = null;
	string segundo = null;
	bool terminado = false;
	int contador;

	public GameObject HintPanel;

	void Start () {
		pulsado1 = null;
		pulsado2 = null;
		contador = 0;

		bton1.GetComponent<Button>();
		bton1.onClick.AddListener(PasanCosas1);

		bton2.GetComponent<Button>();
		bton2.onClick.AddListener(PasanCosas2);

		bton3.GetComponent<Button>();
		bton3.onClick.AddListener(PasanCosas3);

		bton4.GetComponent<Button> ();
		bton4.onClick.AddListener(PasanCosas4);

		bton5.GetComponent<Button>();
		bton5.onClick.AddListener(PasanCosas5);

		bton6.GetComponent<Button>();
		bton6.onClick.AddListener(PasanCosas6);

		casillaCables.gameObject.SetActive (false);
	}

	void PasanCosas1(){
		magia (1);
	}
	void PasanCosas2(){
		magia (2);
	}
	void PasanCosas3(){
		magia (3);
	}
	void PasanCosas4(){
		magia (4);
	}
	void PasanCosas5(){
		magia (5);
	}
	void PasanCosas6(){
		magia (6);
	}
		
	void magia(int id){
		
		if (terminado == false) { // si no se han pulsado bien todas las parejas el juego sigue
			
			if (pulsado1 == null) { //comprobamos cual es el primer boton pulsado
				
				if ((id == 1) || (id == 6)) {  // si se pulsa el verde o el violeta  
					pulsado1 = "v";
					idpulsado1 = id;
				}
				if ((id == 3) || (id == 4)) { // si se pulsa el rojo o el rosa
					pulsado1 = "r";
					idpulsado1 = id;
				}
				if ((id == 2) || (id == 5)) { // si se pulsa el amarillo o el azul
					pulsado1 = "a";
					idpulsado1 = id;
				}
			} else {
				if ((pulsado2 == null) && (id != idpulsado1)) { // comprobamos el segundo bton pulsado (que no sea el mismo que el primero)
					
					if ((id == 1) || (id == 6)) {   // si se pulsa el verde o el violeta    
						pulsado2 = "v";
					}
					if ((id == 3) || (id == 4)) {  // si se pulsa el rojo o el rosa
						pulsado2 = "r";
					}
					if ((id == 2) || (id == 5)) { // si se pulsa el amarillo o el azul
						pulsado2 = "a";
					}
				} else {
					if (id == idpulsado1) {// si es el mismo que el primero la pareja no es valida, reiniciamos
						pulsado1 = null;
						pulsado2 = null;
					}
				}
			}
			if ((pulsado1 != null) && (pulsado2 != null)) {// cuando tenemos dos botones pulsados validos
				Debug.Log(pulsado1 + "+" + pulsado2);

				if (pulsado1 == pulsado2) { //comprobamos si empiezan igual: si empiezan igual una pareja encontrada 
					
					if (primero == null) { // si es la primera pareja
						primero = pulsado1; // guardamos la letra de la primera pareja
						contador++; // pareja encontrada
					} 
					else { // si no es la primera pareja

						if (pulsado1 != primero) { // si no esta repitiendo la primera pareja

							if (segundo == null) { // si es la segunda pareja
								segundo = pulsado1; // guardamos letra de la segunda pareja
								contador++; // pareja encontrada
							} 
							else { // si no es ni la primera ni la segunda

								if (pulsado1 != segundo) {// si no esta repitiendo la segunda (ni la primera, lo hemos comprobado antes)
									contador++; // ultima pareja encontrada
								}
							}
						}
					}
					pulsado1 = null; // en cualquier caso reiniciamos botones
					pulsado2 = null;

				} else { // si no, pareja no valida
					pulsado1 = null;
					pulsado2 = null;
				}
			}

		}
	}

	void Update () {
		if (contador >= 3) {
			terminado = true;
			casillaCerrada.gameObject.SetActive (false);
			casillaCables.gameObject.SetActive (true);

			HintPanel.gameObject.SetActive (false);
		}
	}
}
