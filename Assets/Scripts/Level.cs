using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Level	{

	private int number;
	private bool overcomed;
	private Image levelAvatar;

	public Level (int number, Image levelAvatar)
	{
		this.number = number;
		this.levelAvatar = levelAvatar;
		overcomed = false;
	}

	public int GetNumber(){ return number; }
	public bool GetOvercomed(){ return overcomed; }
	public void SetOvercomed(bool value){ overcomed = true; }
	public Image GetLevelAvatar(){ return levelAvatar; }
}


