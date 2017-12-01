using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class TrollLevel : MonoBehaviour {

	private GameManager gameManager;
	public NivelVariables variables;
	public List<Button> openedBoxes;
	public Button BotonMartillo;

	void Start () {
		gameManager = GameObject.Find ("Game Manager").GetComponent<GameManager> ();
	}

	public void BreakBomb(){
		if (variables.cursor == "Martillo" && openedBoxes.Count == 0) {
			Debug.Log ("entro");
			variables.cursor = "Nada";
			gameManager.EndOfLevel (true, 1);
		}
	}

	public void AddOpened(Button b){
		if (variables.cursor == "Destornillador") {
			openedBoxes.Remove (b);
			Debug.Log (openedBoxes.Count);
		}

		if (openedBoxes.Count == 0) {
			BotonMartillo.gameObject.SetActive (true);
		}
	}
}
