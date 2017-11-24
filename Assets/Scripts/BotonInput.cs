using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BotonInput : MonoBehaviour {

	public Button pulsa;
	public Canvas acertijo;

	// Use this for initialization
	void Start () {
		pulsa.GetComponent<Button>();
		pulsa.onClick.AddListener(OnClick);

	}

	void OnClick(){
		acertijo.gameObject.SetActive (true);
	}
	// Update is called once per frame
	void Update () {
		
	}
}
