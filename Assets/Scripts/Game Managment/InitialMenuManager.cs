using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using System;
using System.IO;
using UnityEngine.SceneManagement;
using System.Runtime.Serialization.Formatters.Binary;

public class InitialMenuManager : MonoBehaviour {



	public void StartGame(){
		SceneManager.LoadScene ("Character Menu");
		//SceneManager.LoadScene ("Nivel1");
	}

	public void QuitGame(){
		Application.Quit ();
	}
}
