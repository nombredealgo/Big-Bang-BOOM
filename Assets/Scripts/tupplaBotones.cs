using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class tupplaBotones : MonoBehaviour {

	[HideInInspector]
	public Button p1;
	[HideInInspector]
	public Button p2;

	public tupplaBotones(){
		p1 = null;
		p2 = null;
	}
	// Use this for initialization
	public void AddPulsado1( Button pul1){
		this.p1 = pul1;
	}
	public void AddPulsado2( Button pul2){
		this.p2 = pul2;

	}
}
