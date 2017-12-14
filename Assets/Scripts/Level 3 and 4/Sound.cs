using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;


public class Sound : MonoBehaviour {

	public TurnButton levelScript;

	public AudioSource effects;
	public AudioSource music;

	public Button[] redButton;

	public AudioClip redButtonClip;

	private bool stopMusic = false;
	// Use this for initialization
	void Start () {

		levelScript = GameObject.Find ("Boton de Giro").GetComponent<TurnButton> ();

		redButton[0].onClick.AddListener (redButtonSoundStart);
		redButton[1].onClick.AddListener (redButtonSoundFinish);


	}
	
	// Update is called once per frame
	void Update () {
	}

	public void redButtonSoundStart (){
		effects.pitch = 1f;
		effects.PlayOneShot (redButtonClip);

		if (levelScript.turning && levelScript.boxesWithArrow.Count > 0) {
			music.Play ();
			stopMusic = false;
		}
	}

	public void redButtonSoundFinish(){
		effects.pitch = 0.4f;
		effects.PlayOneShot (redButtonClip);
		stopMusic = true;

		if (levelScript.turning) {
			music.Stop ();
		}

	}

	public void StopMusic(){
		if (!stopMusic) {
			music.Stop ();
		}
	}

	public void ReStartMusic(){
		if (!stopMusic) {
			music.Play ();
		}
	}


}
