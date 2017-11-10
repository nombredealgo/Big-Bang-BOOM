using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelStructure : MonoBehaviour {

	public int NumberOfLevels;
	public List<Level> levelStructure;

	void Awake(){
		levelStructure = new List<Level> (NumberOfLevels);
	}


	void Start () {
		
	}
	

	void Update () {
		
	}
}
