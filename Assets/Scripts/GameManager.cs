using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

	private bool avatarChoosed;
	private Button lastButton;

	void Awake(){
		avatarChoosed = false;
	}

	void Start () {
	}

	void Update () {
	}

	public void StartGame(){
		SceneManager.LoadScene ("Character Menu");
		//SceneManager.LoadScene ("Nivel1");
	}

	public void QuitGame(){
		Application.Quit ();
	}

	public void ChooseAvatar(Button button){
		Player.avatar = button.image;

		if (avatarChoosed) {
			lastButton.image.color = Color.white;
		}

		lastButton = button;
		button.image.color = Color.red;
		avatarChoosed = true;
	}

	public void GoToLevelMenu(){
		if (avatarChoosed) {
			//SceneManager.LoadScene ("Level Menu");
			SceneManager.LoadScene("Nivel1");
		}
	}

	public void ReturnToMenu(){
		SceneManager.LoadScene ("Initial Menu");
	}
}
