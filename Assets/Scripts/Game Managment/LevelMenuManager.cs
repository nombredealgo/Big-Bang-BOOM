using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using System;
using System.IO;
using UnityEngine.SceneManagement;
using System.Runtime.Serialization.Formatters.Binary;

public class LevelMenuManager : MonoBehaviour {

	private GameManager gameManager;

	private TotalityOfLevels levels;
	public List<Level> levelStructure;
	public List<GameObject> buttonStructure;

	private int currentPage;
	private int totalPages;
	public Text pageLabel;

	public GameObject LevelGridPanel;
	public Button nextPage;
	public Button previousPage;

	private Button currentButton;
	private Button lastButton;

	void Awake(){
		//DontDestroyOnLoad (transform.gameObject);


	}

	void Start () {

		levels = new TotalityOfLevels ();
		levelStructure = levels.GetLevels ();

		for (int i = 0; i < 6; i++) {
			buttonStructure.Add (LevelGridPanel.transform.GetChild (i).gameObject);
			buttonStructure [i].GetComponent<Image> ().sprite = levelStructure [i].GetLevelAvatar ();

			if (getButtonColor (levelStructure [i]).Equals (Color.grey)) {
				buttonStructure [i].GetComponent<Button> ().interactable = false;
			}

			buttonStructure [i].GetComponentInChildren<Text> ().text = "Level " + levelStructure [i].GetNumber ();
		}

		levelStructure [0].SetAviable (true); //first level is always aviable
		buttonStructure [0].GetComponent<Button>().interactable = true;
		buttonStructure [0].GetComponent<Image> ().color = Color.yellow;

		currentPage = 1;
		totalPages = 3;
		pageLabel.text = currentPage + "/" + totalPages;

		previousPage.interactable = false;

		currentButton = null;
		lastButton = null;
	}
	

	void Update () {
		
	}

	public void ChangeToPassedLevel(Level level){
		level.SetOvercomed (true);
		levelStructure [level.GetNumber () + 1].SetAviable (true);
	}

	public void NextPage(){
		if (currentPage != totalPages) {
			if (currentPage == totalPages - 1) {
				nextPage.interactable = false;
			} else if (currentPage == 1) {
				previousPage.interactable = true;
			}
			currentPage++;
		}

		ActualizePage ();
	}

	public void ChoosedLevel(Button b){
		if (currentButton == null) {
			b.GetComponent<Image> ().color = Color.red;
			currentButton = b;
		} else {
			lastButton = currentButton;
			lastButton.GetComponent<Image> ().color = Color.white;
			currentButton = b;
			b.GetComponent<Image> ().color = Color.red;

		}
	}

	public Button GetCurrentButton(){
			return currentButton;
	}

	public void PreviousPage(){
		if (currentPage != 1) {
			if (currentPage == 2) {
				previousPage.interactable = false;
			} else if (currentPage == totalPages){
				nextPage.interactable = true;
			}
			currentPage--;
		}

		ActualizePage ();
	}

	private void ActualizePage(){
		for (int i = 0; i < 6; i++) {
			buttonStructure [i].GetComponent<Button> ().interactable = true;
		}

		for (int i = 6 * (currentPage - 1), j = 0; i < 6 * (currentPage - 1) + 6; i++, j++) {
			buttonStructure [j].GetComponent<Image> ().sprite = levelStructure [i].GetLevelAvatar ();
			buttonStructure [j].GetComponent<Image> ().color = getButtonColor (levelStructure [i]);

			if (getButtonColor (levelStructure [i]).Equals (Color.grey)) {
				buttonStructure [j].GetComponent<Button> ().interactable = false;
			}

			buttonStructure [j].GetComponentInChildren<Text> ().text = "Level " + levelStructure [i].GetNumber ();
		}

		pageLabel.text = currentPage + "/" + totalPages;
	}

	private Color getButtonColor(Level level){
		if (level.GetAviable ()) {
			if (level.GetOvercomed ())
				return Color.white;
			else
				return Color.yellow;
		} else
			return Color.grey;
	}

	public void GoToLevel(){
		
		if (currentButton!= null) {
			SceneManager.LoadScene("Level 0");
		}
	}
}