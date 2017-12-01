using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TurnButton : MonoBehaviour {

	public List<Button> boxesWithArrow;
	public NivelVariables variables;
	public GameObject arrow;
	public bool turning;

	void Start () {
		turning = false;
	}

	public void TurnArrows(){
		//El eje z en Vector3
		turning = !turning;
	}

	void Update(){

		if (turning) {
			for (int i = 0; i < boxesWithArrow.Count; i++) {
				GameObject currentArrow = boxesWithArrow [i].transform.GetChild (0).gameObject;
				Debug.Log (currentArrow.transform.rotation.z);
				Quaternion newRotation = Quaternion.Euler (new Vector3 (0, 0, currentArrow.transform.rotation.z - 90f));
				currentArrow.transform.rotation = Quaternion.Lerp (currentArrow.transform.rotation, newRotation, 0.1f);
			}
		}
	}

	public void AddArrow(Button button){
		if (variables.cursor == "Flecha") {

			if (!boxesWithArrow.Contains (button)) {
				boxesWithArrow.Add (button);

				GameObject newArrow = Instantiate (arrow);
				newArrow.transform.SetParent (button.gameObject.transform);

				newArrow.transform.localPosition = new Vector3 (0, 0, 0);

				Quaternion firstRotation = Quaternion.Euler (new Vector3 (0, 0, 0));
				newArrow.transform.localRotation = firstRotation;

				newArrow.SetActive (true);

				variables.cursor = "Nada";
			}
		}
	}
}
