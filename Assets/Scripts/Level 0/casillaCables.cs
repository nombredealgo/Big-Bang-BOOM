using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class casillaCables : MonoBehaviour {

	GameManager gameManager;

	public Button cable3;
	public NivelVariables variables;

	void Start () {
		gameManager = GameObject.Find ("Game Manager").GetComponent<GameManager> ();
		
	
		cable3.GetComponent<Button>();
		cable3.onClick.AddListener(CableCortado3);
	}


	void CableCortado3 (){
		if (variables.cursor == "Alicates") {
			variables.cursor = "Nada";
			gameManager.EndOfLevel (true, 0);
		}
	}



				


}
