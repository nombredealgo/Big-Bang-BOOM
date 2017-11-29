using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using System;
using System.IO;
using UnityEngine.SceneManagement;
using System.Runtime.Serialization.Formatters.Binary;

public class CharacterMenuManager : MonoBehaviour {

	private GameManager gameManager;

	private Button lastButton;


	void Start(){
		gameManager = GameObject.Find ("Game Manager").GetComponent<GameManager> ();
	}

	public void ChooseAvatar(Button button){
//		Player.avatar = button.image;
//
//		if (gameManager.IsAvatarChoosed) {
//			lastButton.image.color = Color.white;
//		}
//
//		lastButton = button;
//		//		avatarIcon = button.image.sprite;
//		avatar.GetComponent<Image>().sprite = button.image.sprite;
//		button.image.color = Color.red;
//		avatarChoosed = true;
		lastButton = button;
		gameManager.SetAvatarName (button.name);
		gameManager.IsAvatarChoosed = true;
	}

	public void GoToLevelMenu(){
		if (gameManager.IsAvatarChoosed) {
			SceneManager.LoadScene ("Level Menu");
		}
	}

	public void ReturnToMenu(){
		SceneManager.LoadScene ("Initial Menu");
	}
}
