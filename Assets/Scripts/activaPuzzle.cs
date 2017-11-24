using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class activaPuzzle : MonoBehaviour {

	public Button activalo;
	public GameObject puzzleCanvas;

	// Use this for initialization
	void Start () {
		activalo.GetComponent<Button>();
		activalo.onClick.AddListener(OnClick);
	}
	void OnClick(){
		puzzleCanvas.SetActive (true);
	}
}
