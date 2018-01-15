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
	private String stayAtLevelMenu;
	private String levelsInfoRute;

	private string returnToLevelMenu;
	public string avatarName;
	public int[] passedLevels;

	public GameObject EndingCanvas;
    public GameObject CanvasWin;

	void Awake(){

		//Establece las rutas de donde se guardan los distintos ratos.
		avatarRute = Application.persistentDataPath + "/playerAvatar.txt";
		stayAtLevelMenu = Application.persistentDataPath + "/stayAtLevelMenu.txt";
		levelsInfoRute = Application.persistentDataPath + "/passedLevels.text.bytes";

		//Mantiene que haya solo un GameManager por escena. Si ya existe uno, elimina
		//el nuevo.
		if (gameManager == null) {
			gameManager = this;
			DontDestroyOnLoad (transform.gameObject);

			AvatarName = "";
			ReturnToLevelMenu = "";

			ChargeLevelsInfo ();
			passedLevels = new int[0];
			SaveLevelInformation ();

		} else if (gameManager != this){
			Destroy (gameObject);
		}
	}

	//Para la información referente al estado del juego 
	//(volver al menú de niveles dentro de la escena inicial)
	//después de finalizar un nivel, por ejemplo.
	public string ReturnToLevelMenu{
		set{ 
			SaveGameState (value);
			returnToLevelMenu = value;
		}
		get {
			ChargeGameState ();
			return returnToLevelMenu; }
	}

	public void SaveGameState(string name){
		BinaryFormatter bf = new BinaryFormatter ();
		FileStream file = File.Create (stayAtLevelMenu);
		GoToLevelMenu stay = new GoToLevelMenu (name);
		bf.Serialize (file, stay);
		file.Close ();
	}

	public void ChargeGameState(){
		if (File.Exists (stayAtLevelMenu)) {
			BinaryFormatter bf = new BinaryFormatter ();
			FileStream file = File.Open (stayAtLevelMenu, FileMode.Open);
			GoToLevelMenu stay = (GoToLevelMenu) bf.Deserialize (file);
			returnToLevelMenu = stay.stay;
			file.Close ();
		} else {
			returnToLevelMenu = "";
		}
	}
		

	//Para la información referente al avatar escogido
	//por el jugador en el menú de avatares (escena inicial)
	public string AvatarName{
		set{
			SaveAvatar (value);
			avatarName = value; 
		}
		get{
			ChargeAvatar ();
			return avatarName;
		}
	}

	public void SaveAvatar(string name){
		BinaryFormatter bf = new BinaryFormatter ();
		FileStream file = File.Create (avatarRute);
		KeepAvatar av = new KeepAvatar (name);
		bf.Serialize (file, av);
		file.Close ();
	}

	public void ChargeAvatar(){
		if (File.Exists (avatarRute)) {
			BinaryFormatter bf = new BinaryFormatter ();
			FileStream file = File.Open (avatarRute, FileMode.Open);
			KeepAvatar av = (KeepAvatar)bf.Deserialize (file);
			avatarName = av.avatar;
			file.Close ();
		} else {
			avatarName = "";
		}
	}
		

	//Para la información sobre el estado actuald de los niveles	
	//accesible-superado-bloqueado.
	public void SetPassedLevels(int value){
		ChargeLevelsInfo ();

		//Ya se ha superado el nivel?
		bool alreadyPassed = false;
		for (int i = 0; i < passedLevels.Length; i++) {
			if (value == passedLevels [i]) {
				alreadyPassed = true;
				break;
			}
		}

		if (!alreadyPassed) {

			int[] aux = new int[passedLevels.Length + 1];
			for (int i = 0; i < passedLevels.Length; i++) {
				aux [i] = passedLevels [i];
			}
			aux [passedLevels.Length] = value;
			passedLevels = aux;
		}
		SaveLevelInformation ();

	}

	public int[] GetPassedLevels(){
		ChargeLevelsInfo ();
		return passedLevels;
	}
		
	public void SaveLevelInformation(){
		BinaryFormatter bf = new BinaryFormatter ();
		FileStream file = File.Create (levelsInfoRute);
		LevelInformation info = new LevelInformation (passedLevels);
		bf.Serialize (file, info);
		file.Close ();
	}

	public void ChargeLevelsInfo(){
		if (File.Exists (levelsInfoRute)) {
			BinaryFormatter bf = new BinaryFormatter ();
			FileStream file = File.Open (levelsInfoRute, FileMode.Open);
			LevelInformation info = (LevelInformation)bf.Deserialize (file);
			passedLevels = info.passedLevels;
			file.Close ();
		} else {
			passedLevels = new int[0];
		}
	}

	IEnumerator LitlePause(){
		yield return new WaitForSeconds(3);

		ReturnToLevelMenu = "Stay";

		SceneManager.LoadScene ("Initial Menu");
	}

	public void EndOfLevel(bool passed, int level){
		GameObject canvas1 = Instantiate (EndingCanvas);
        GameObject canvas2 = Instantiate(CanvasWin);

		if (passed) {
            canvas2.SetActive(true);
			SetPassedLevels(level);
		} else {
            canvas1.SetActive(true);
		}
			
		StartCoroutine ("LitlePause");
	}
}

[Serializable]
public class GoToLevelMenu{
	public string stay;
	public GoToLevelMenu(string stay){
		this.stay = stay;
	}
}

[Serializable]
public class KeepAvatar{
	public string avatar;
	public KeepAvatar(string avatar){
		this.avatar = avatar;
	}
}

[Serializable]
public class LevelInformation{
	public int[] passedLevels;
	public LevelInformation(int[] passedLevels){
		this.passedLevels = passedLevels;
	}
}
