using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Diagnostics;
using UnityEngine.Diagnostics;

public class TurnButton : MonoBehaviour {

	GameManager gameManager;

	// Combinación ganadora
	public List<ArrowInBox> winnerCombination;
	public List<GameObject> boxes;


	public int numberOfArrows;

	public List<GameObject> arrowsInToolBox;
	public List<Button> boxesWithArrow;
	public List<int> rotationIndex;

	public NivelVariables variables;
	public bool turning;
	public GameObject buttonPressed;

	public GameObject arrowPanel;
	public GameObject arrow;

	public Button redButton;

	int[] rotationPoints = new int[4] {-90, -180, -270, 0};

	Stopwatch timer;

	void Start () {

		gameManager = GameObject.Find ("Game Manager").GetComponent<GameManager> ();


		winnerCombination = new List<ArrowInBox> ();

		winnerCombination.Add(new ArrowInBox (boxes [0], -270));
		winnerCombination.Add(new ArrowInBox (boxes [1], -90));


		turning = false;
		timer = new Stopwatch ();
		arrowsInToolBox = new List<GameObject> ();

		for (int i = 0; i < numberOfArrows; i++) {
			GameObject newArrow = Instantiate (arrow);
			newArrow.transform.SetParent (arrowPanel.transform);
			newArrow.GetComponent<CodigoFlecha> ().variables = GameObject.Find ("Bomb").GetComponent<NivelVariables> ();
			arrowsInToolBox.Add (newArrow);
		}
	}

	public void TurnArrows(){
		//El eje z en Vector3
		if (turning) {

			buttonPressed.SetActive (false);
			if (isWinnerCombination ()) {
				// fin de juego
				UnityEngine.Debug.Log ("he ganao");
				gameManager.EndOfLevel (true, 3);

			}
		} else {
			buttonPressed.SetActive (true);
		}
		turning = !turning;
	}

	void Update(){
		if (turning) {
			TurnArrow ();
		}

	}

	private void NextPoint(int arrow){

		rotationIndex [arrow]++;

		if (rotationIndex[arrow] >= rotationPoints.Length) {
			rotationIndex[arrow] = 0;
		}
	}

	public void AddArrow(Button button){
		if (variables.cursor == "Flecha" && !turning) {


			if (!boxesWithArrow.Contains (button)) {
				boxesWithArrow.Add (button);

				GameObject newArrow = Instantiate (arrow);
				newArrow.transform.SetParent (button.gameObject.transform);

				newArrow.transform.localPosition = new Vector3 (0, 0, 0);

				Quaternion firstRotation = Quaternion.Euler (new Vector3 (0, 0, 0));
				newArrow.transform.localRotation = firstRotation;


				newArrow.GetComponent<CodigoFlecha> ().variables = GameObject.Find ("Bomb").GetComponent<NivelVariables> ();
				newArrow.GetComponent<CodigoFlecha> ().enabled = false;
				newArrow.SetActive (true);

				rotationIndex.Add (0);

				variables.cursor = "Nada";

				GameObject oldArrow = arrowsInToolBox [0];
				arrowsInToolBox.Remove (oldArrow);
				Destroy (oldArrow);
			}
		} else {
			if (!turning) {
				if (boxesWithArrow.Contains (button)) {


					int index = boxesWithArrow.IndexOf (button.GetComponent<Button> ());
					boxesWithArrow.RemoveAt (index);
					rotationIndex.RemoveAt (index);


					Destroy (button.transform.GetChild (0).gameObject);

					GameObject newArrow = Instantiate (arrow);
					newArrow.transform.SetParent (arrowPanel.transform);
					newArrow.GetComponent<CodigoFlecha> ().variables = GameObject.Find ("Bomb").GetComponent<NivelVariables> ();
					arrowsInToolBox.Add (newArrow);
				}
			}
		}
	}


	IEnumerator StopForSeconds(){
		yield return new WaitForSeconds (1);

			for (int i = 0; i < boxesWithArrow.Count; i++) {
				NextPoint (i);
			}
		UnityEngine.Debug.Log (redButton.enabled);

		timer.Reset ();
	}



	private void TurnArrow(){

		if (timer.IsRunning) {
			redButton.interactable = false;
			buttonPressed.GetComponent<Button>().interactable = false;

			if (timer.Elapsed.Seconds < 1) {
				Vector3 nextRotation;
				GameObject currentArrow;
				for (int i = 0; i < boxesWithArrow.Count; i++) {



					currentArrow = boxesWithArrow [i].transform.GetChild (0).gameObject;

					nextRotation = new Vector3 (0, 0, rotationPoints [rotationIndex [i]]);

					currentArrow.transform.rotation = Quaternion.Lerp (currentArrow.transform.rotation, Quaternion.Euler (nextRotation), 0.1f);
				}



			} else {
				timer.Stop ();
				redButton.interactable = true;
				buttonPressed.GetComponent<Button>().interactable = true;
				StartCoroutine ("StopForSeconds");
				
			}
		} else {

			if (timer.Elapsed.Seconds == 0) {
				timer.Start ();


			}
		}

	}


	private bool isWinnerCombination(){

		UnityEngine.Debug.Log ("entro");

		if (boxesWithArrow.Count < 2) {
			return false;
		}

		int index = boxesWithArrow.IndexOf (boxes [0].GetComponent<Button>());
		ArrowInBox first = new ArrowInBox (boxes [0], rotationPoints [rotationIndex [index]]);

		if (!(first.box == winnerCombination [0].box && first.rotation == winnerCombination[0].rotation)) {



			return false;
		}

		index = boxesWithArrow.IndexOf (boxes [1].GetComponent<Button>());
		ArrowInBox second = new ArrowInBox (boxes [1], rotationPoints [rotationIndex [index]]);

		if (!(second.box == winnerCombination [1].box && second.rotation == winnerCombination[1].rotation)) {
			return false;
		}

		return true;
	}
}


public class ArrowInBox{

	public int rotation;
	public GameObject box;

	public ArrowInBox(GameObject box, int rotation){
		this.box = box;
		this.rotation = rotation;
	}
}
