using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using System.Reflection;

public class Tutorial : MonoBehaviour
{
	public int cont;
	public Text TutorialText;
	public GameObject CoverPage;
	public GameObject TutorialTools;
	public Image AvatarIcon;
	public Button LevelButton;
	public Image TargetIcon;
	public GameObject TutorialCanvas;

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
		"Haciendo click derecho dejas la herramienta.",
		"Y ahora te toca experimentar :D"};
	
	public void StartTutorial(){
		CoverPage.SetActive (false);
		TutorialTools.SetActive (true);
		AvatarIcon.gameObject.SetActive (true);
		LevelButton.gameObject.SetActive (true);
	}

	void Start(){
		cont = 0;
		TutorialText.text = textList[cont];	
	}

	public void Next(){

		if (cont < textList.Count - 1) {
			cont++;
			TutorialText.text = textList [cont];

			if (cont == 2) {
				TargetIcon.gameObject.SetActive (true);
				TargetIcon.transform.position = LevelButton.transform.position;
			}

			if (cont == 3) {
				TargetIcon.transform.position = AvatarIcon.transform.position;
			}

			if (cont == 4) {
				TargetIcon.gameObject.SetActive (false);
			}
		} else {
			TutorialCanvas.SetActive (false);
		}

	}
}


