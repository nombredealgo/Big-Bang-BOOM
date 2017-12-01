using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using System;
using System.IO;
using UnityEngine.SceneManagement;
using System.Runtime.Serialization.Formatters.Binary;

public class MenuManagment : MonoBehaviour {

	private GameManager gameManager;

	public GameObject MainCanvas;
	public GameObject AvatarCanvas;
	public GameObject LevelCanvas;

	private Sprite icon;
	private TotalityOfLevels levels;
	private List<Level> levelStructure;
	private List<GameObject> buttonStructure;
	private int currentPage;
	private int totalPages;
	public Text pageLabel;
	public GameObject LevelGridPanel;
	public Button nextPage;
	public Button previousPage;
	private Button currentButton;
	private Button lastButton;
	private string[] passedLevels;

	public void ReturnToMenu(){
		if (AvatarCanvas.activeSelf)
			AvatarCanvas.SetActive (false);

		if (LevelCanvas.activeSelf)
			LevelCanvas.SetActive (false);

		MainCanvas.SetActive (true);
	}

	void Start(){
		gameManager = GameObject.Find ("Game Manager").GetComponent<GameManager> ();

		if (gameManager.ReturnToLevelMenu.Equals ("Stay")) {
			AvatarCanvas.SetActive (false);
			LevelCanvas.SetActive (true);
	
			gameManager.ReturnToLevelMenu = "";
		}

		BuildLevelScene ();
	}

	//MAIN MENU
	public void SelectAvatar(){
		MainCanvas.SetActive (false);
		AvatarCanvas.SetActive (true);
	}

	public void QuitGame(){
		Application.Quit ();
	}

	//AVATAR MENU
	public void ChooseLevel(){
		if (gameManager.avatarName != "") {
			AvatarCanvas.SetActive (false);
			LevelCanvas.SetActive (true);

			BuildLevelScene ();
		}
	}
		
	public void ChooseAvatar(Button button){
		lastButton = button;
		gameManager.AvatarName = button.name;
	}

	//LEVEL MENU
	public void PlayLevel(){
		if (currentButton!= null) {
			SceneManager.LoadScene(currentButton.GetComponentInChildren<Text>().text);
		}
	}
		
	private void BuildLevelScene(){
		levels = new TotalityOfLevels ();
		levelStructure = levels.GetLevels ();
		buttonStructure = new List<GameObject> ();

		for (int i = 0; i < 6; i++) {
			buttonStructure.Add (LevelGridPanel.transform.GetChild (i).gameObject);
			buttonStructure [i].GetComponent<Image> ().sprite = levelStructure [i].GetLevelAvatar ();
			buttonStructure [i].GetComponentInChildren<Text> ().text = "Level " + levelStructure [i].GetNumber ();
		}
				
		levelStructure [0].SetAviable (true); //first level is always aviable
		buttonStructure [0].GetComponent<Button>().interactable = true;
		buttonStructure [0].GetComponent<Image> ().color = Color.white;

		currentPage = 1;
		totalPages = 3;
		pageLabel.text = currentPage + "/" + totalPages;

		previousPage.interactable = false;

		currentButton = null;
		lastButton = null;

		ActualizePage ();
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
		
	private void ActualizePage(){
		//actualizando pag
		for (int i = 0; i < 6; i++) {
			buttonStructure [i].GetComponent<Button> ().interactable = true;
		}
			
		//Determinar qué niveles están disponibles, bloqueados o superados
		for (int i = 0; i < gameManager.GetPassedLevels().Length; i++) {
			levelStructure [i].SetAviable (true);
			levelStructure [i].SetOvercomed (true);
		}

		levelStructure [gameManager.GetPassedLevels().Length].SetAviable (true);

		for (int i = gameManager.GetPassedLevels().Length + 1; i < levelStructure.Count; i++) {
			levelStructure [i].SetAviable (false);
		}

		//Construir los botones de la página
		for (int i = 6 * (currentPage - 1), j = 0; i < 6 * (currentPage - 1) + 6; i++, j++) {
			buttonStructure [j].GetComponent<Image> ().sprite = levelStructure [i].GetLevelAvatar ();
			buttonStructure [j].GetComponent<Image> ().color = getButtonColor (levelStructure [i]);

			if (getButtonColor (levelStructure [i]).Equals (Color.grey)) {
				buttonStructure [j].GetComponent<Button> ().interactable = false;
			}

			buttonStructure [j].GetComponentInChildren<Text> ().text = "Level " + levelStructure [i].GetNumber ();
		}

		//Página actual
		pageLabel.text = currentPage + "/" + totalPages;
	}
		
	private Color getButtonColor(Level level){
		if (level.GetAviable ()) {
			if (level.GetOvercomed ())
				return Color.yellow;
			else
				return Color.white;
		} else
			return Color.grey;
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


}
