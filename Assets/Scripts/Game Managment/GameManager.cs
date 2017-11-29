using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using System;
using System.IO;
using UnityEngine.SceneManagement;
using System.Runtime.Serialization.Formatters.Binary;


public class GameManager : MonoBehaviour {

	private String avatarRute;
	public static GameManager gameManager;

    private bool avatarChoosed;
	public Sprite avatarIcon;
//	private Button lastButton;
//	public GameObject avatar;
	public string avatarName;

	public void SetAvatarName(string name){
		gameManager.SaveAvatar (name);
		avatarName = name;
	}
	public string GetAvatarName(){
		return avatarName;
	}

	void Awake(){
		avatarRute = Application.persistentDataPath + "/jorjor.txt";

		if (gameManager == null) {
			gameManager = this;
			DontDestroyOnLoad (transform.gameObject);

		} else if (gameManager != this){
			Destroy (gameObject);
		}
		avatarChoosed = false;

	}

	void Start () {
		//ChargeAvatar ();

	}

	void Update () {
	}

	public bool IsAvatarChoosed
	{
		get{ return avatarChoosed;}
		set{ avatarChoosed = value; }
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
			Debug.Log (av.avatar);



			file.Close ();
		} else {
			avatarIcon = null;
		}

	}

	public Sprite GetIcon(){
		return avatarIcon;
	}
		
}

[Serializable]
public class KeepData{

	public string avatar;

	public KeepData(string avatar){
		this.avatar = avatar;
	}
}
