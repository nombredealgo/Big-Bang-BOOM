using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelStructure : MonoBehaviour {

	private TotalityOfLevels levels;
	public List<Level> levelStructure;
	public List<GameObject> buttonStructure;

	private int currentPage;
	private int totalPages;
	public Text pageLabel;

	public GameObject LevelGridPanel;
	public Button nextPage;
	public Button previousPage;

	void Awake(){
		levels = new TotalityOfLevels ();
	}

	void Start () {
		levelStructure = levels.GetLevels ();

		for (int i = 0; i < 6; i++) {
			buttonStructure.Add (LevelGridPanel.transform.GetChild (i).gameObject);
			Debug.Log (levelStructure [i].GetLevelAvatar ());
			buttonStructure [i].GetComponent<Image> ().sprite = levelStructure [i].GetLevelAvatar ();
			buttonStructure [i].GetComponentInChildren<Text> ().text = "Level " + levelStructure [i].GetNumber ();
		}
			
		currentPage = 0;
		totalPages = 3;
		pageLabel.text = currentPage + "/" + totalPages;

		previousPage.interactable = false;
	}
	

	void Update () {
		
	}

	public void NextPage(){
		if (currentPage != totalPages) {
			if (currentPage == totalPages - 1) {
				nextPage.interactable = false;
			} else if (currentPage == 0) {
				previousPage.interactable = true;
			}
			currentPage++;
		}

		ActualizePage ();
	}

	public void PreviousPage(){
		if (currentPage != 0) {
			if (currentPage == 1) {
				previousPage.interactable = false;
			} else if (currentPage == totalPages){
				nextPage.interactable = true;
			}
			currentPage--;
		}

		ActualizePage ();
	}

	private void ActualizePage(){

		for (int i = 6 * currentPage, j = 0; i < 6 * currentPage + 6; i++, j++) {
			buttonStructure [j].GetComponent<Image> ().sprite = levelStructure [i].GetLevelAvatar ();
			buttonStructure [j].GetComponentInChildren<Text> ().text = "Level " + levelStructure [i].GetNumber ();
		}
	}

	public void ChargeLevel(){
		
	}
}