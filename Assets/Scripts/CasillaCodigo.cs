using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CasillaCodigo : MonoBehaviour {

	public SpriteRenderer luz2;

	public Text textview;
	public Button b1;
	public Button b2;
	public Button b3;
	public Button b4;
	public Button b5;
	public Button b6;
	public Button b7;
	public Button b8;
	public Button b9;

	public Button borrar;
	// Use this for initialization
	void Start () {
		b1.GetComponent<Button>();
		b1.onClick.AddListener(PasanCosas1);

		b2.GetComponent<Button>();
		b2.onClick.AddListener(PasanCosas2);

		b3.GetComponent<Button>();
		b3.onClick.AddListener(PasanCosas3);

		b4.GetComponent<Button> ();
		b4.onClick.AddListener(PasanCosas4);

		b5.GetComponent<Button>();
		b5.onClick.AddListener(PasanCosas5);

		b6.GetComponent<Button>();
		b6.onClick.AddListener(PasanCosas6);

		b7.GetComponent<Button>();
		b7.onClick.AddListener(PasanCosas7);

		b8.GetComponent<Button>();
		b8.onClick.AddListener(PasanCosas8);

		b9.GetComponent<Button>();
		b9.onClick.AddListener(PasanCosas9);

		borrar.GetComponent<Button>();
		borrar.onClick.AddListener(Borrar);
	}


	void PasanCosas1(){
		if (textview.text.Length != 4) {
			textview.text = textview.text + "1";
		}
	}
	void PasanCosas2(){
		if (textview.text.Length != 4) {
			textview.text = textview.text + "2";
		}
	}
	void PasanCosas3(){
		if (textview.text.Length != 4) {
			textview.text = textview.text + "3";
		}
	}
	void PasanCosas4(){
		if (textview.text.Length != 4) {
			textview.text = textview.text + "4";
		}
	}
	void PasanCosas5(){
		if (textview.text.Length != 4) {
			textview.text = textview.text + "5";
		}
	}
	void PasanCosas6(){
		if (textview.text.Length != 4) {
			textview.text = textview.text + "6";
		}
	}
	void PasanCosas7(){
		if (textview.text.Length != 4) {
			textview.text = textview.text + "7";
		}
	}
	void PasanCosas8(){
		if (textview.text.Length != 4) {
			textview.text = textview.text + "8";
		}
	}
	void PasanCosas9(){
		if (textview.text.Length != 4) {
			textview.text = textview.text + "9";
		}
	}
	void Borrar(){
		textview.text = "";	
	}
	// Update is called once per frame
	void Update () {
		if (textview.text.Length == 4) {
			if (textview.text == "3627"){
				luz2.color = Color.green;
			}
			else{
					//aqui un sonido
					textview.text = "";		
			}
		}
	}
}
