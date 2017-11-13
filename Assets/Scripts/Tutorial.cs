using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using System.Reflection;

public class Tutorial : MonoBehaviour
{
	public int cont;
	public Text TextInPanel;
	public Text TutorialTitle;

	private List<String> textList = new List<String> {
		"Bienvenid@ al tutorial de Big Bang BOOM!",
		"Voy a explicarte cómo funciona este entorno de juego.",
		"Este icono indica el número del nivel que estás jugando.",
		"Este es tu avatar.",
		"Y este es el contador que indica el tiempo que tienes para desarmar la bomba.",
		"Tranqui@, en este nivel estará desactivado.",
		"La bomba está compuesta por casillas.",
		"Cada casilla puede o no contener un puzzle.",
		"A medida que resuelvas los puzzles, nuevas casillas se desbloquearán.",
		"A la derecha tienes la caja de herramientas.",
		"Cada herramienta sirve para una función determinada.",
		"Haciendo click sobre una herramienta la seleccionarás.",
		"Continuemos."};
	
	//poner circulo

	void Start(){
		cont = 0;
		TextInPanel.text = textList[cont];
	}

	public void Next(){

		if (cont == 0) {
			TutorialTitle.gameObject.SetActive (false);
		}

		cont++;
		TextInPanel.text = textList[cont];
	}
}


