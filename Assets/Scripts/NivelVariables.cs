using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NivelVariables : MonoBehaviour {

	[HideInInspector]
	public int contadorDelantero = 0;
	[HideInInspector]
	public int contadorTrasero = 0;
	[HideInInspector]
	public bool terminado = false;

	public string cursor;

	// Use this for initialization
	void Start () {
		terminado = false;
		cursor = "Nada";
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
