using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class lucesScript : MonoBehaviour {

	public SpriteRenderer luz1;
	public SpriteRenderer luz2;

	public GameObject casillaSiguiente;

	// Update is called once per frame
	void Update () {
		if (luz1.color == Color.green && luz2.color == Color.green) {
			casillaSiguiente.SetActive (true);
			luz1.gameObject.SetActive (false);
			luz2.gameObject.SetActive (false);
			this.gameObject.SetActive (false);
		}
	}
}
