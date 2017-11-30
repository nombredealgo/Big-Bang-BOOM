using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using System;
using System.IO;
using UnityEngine.SceneManagement;
using System.Runtime.Serialization.Formatters.Binary;


public class GameManager : MonoBehaviour {

	public static GameManager gameManager;

	private String avatarRute;
	private String keepInRute;
	public string avatarName;
	public string keepInLevel;

	public GameObject EndingCanvas;

	void Awake(){
		avatarRute = Application.persistentDataPath + "/playerAvatar.txt";
		keepInRute = Application.persistentDataPath + "/stayInLevelMenu.txt";


		if (gameManager == null) {
			gameManager = this;
			DontDestroyOnLoad (transform.gameObject);

		} else if (gameManager != this){
			Destroy (gameObject);
		}
	}

	void Start () {
	}

	void Update () {
	}

	public void SetGameState(string name){
		gameManager.SaveGameState (name);
		keepInLevel = name;
	}

	public string GetGameState(){
		gameManager.ChargeGameState ();
		return keepInLevel;
	}

	public void SetAvatarName(string name){
		gameManager.SaveAvatar (name);
		avatarName = name;
	}

	public string GetAvatarName(){
		gameManager.ChargeAvatar ();
		return avatarName;
	}

		
	public void SaveAvatar(string name){
		BinaryFormatter bf = new BinaryFormatter ();
		FileStream file = File.Create (avatarRute);
		KeepData av = new KeepData (name);
		bf.Serialize (file, av);
		file.Close ();
	}

	public void ChargeAvatar(){
		if (File.Exists (avatarRute)) {
			BinaryFormatter bf = new BinaryFormatter ();
			FileStream file = File.Open (avatarRute, FileMode.Open);
			KeepData av = (KeepData)bf.Deserialize (file);
			avatarName = av.avatar;
			file.Close ();
		} else {
			avatarName = "";
		}
	}

	public void SaveGameState(string name){
		BinaryFormatter bf = new BinaryFormatter ();
		FileStream file = File.Create (keepInRute);
		KeepInLevelMenu stay = new KeepInLevelMenu (name);
		bf.Serialize (file, stay);
		file.Close ();
	}

	public void ChargeGameState(){
		if (File.Exists (keepInRute)) {
			BinaryFormatter bf = new BinaryFormatter ();
			FileStream file = File.Open (keepInRute, FileMode.Open);
			KeepInLevelMenu stay = (KeepInLevelMenu)bf.Deserialize (file);
			keepInLevel = stay.keepIn;
			file.Close ();
		} else {
			keepInLevel = "";
		}
	}

	IEnumerator LitlePause(){
		yield return new WaitForSeconds(3);

		SetGameState ("Stay");
		SceneManager.LoadScene ("Initial Menu");
	}

	public void EndOfLevel(bool passed){
		GameObject canvas = Instantiate (EndingCanvas);
		canvas.SetActive (true);

		if (passed) {
			canvas.GetComponentInChildren<Text> ().text = "You win!";
		} else {
			canvas.GetComponentInChildren<Text> ().text = "You lose!";
		}

		StartCoroutine ("LitlePause");
	}
}

[Serializable]
public class KeepInLevelMenu{
	public string keepIn;

	public KeepInLevelMenu(string keepIn){
		this.keepIn = keepIn;
	}
}

[Serializable]
public class KeepData{

	public string avatar;

	public KeepData(string avatar){
		this.avatar = avatar;
	}
}
