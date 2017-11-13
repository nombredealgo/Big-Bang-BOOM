using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Level	{

	private int number;
	private bool overcomed;
	private Sprite levelAvatar;

	public Level (int number, Sprite levelAvatar)
	{
		this.number = number;
		this.levelAvatar = levelAvatar;
		overcomed = false;
	}

	public int GetNumber(){ return number; }
	public bool GetOvercomed(){ return overcomed; }
	public void SetOvercomed(bool value){ overcomed = true; }
	public Sprite GetLevelAvatar(){ return levelAvatar; }
}

public class TotalityOfLevels{

	public List<Level> GetLevels(){
		return new List<Level> () {
			lev00, lev01, lev02, lev03, lev04, lev05,
			lev06, lev07, lev08, lev09, lev10, lev11,
			lev12, lev13, lev14, lev15, lev16, lev17,
		};
	}

	Level lev00, lev01, lev02, lev03, lev04, lev05;
	Level lev06, lev07, lev08, lev09, lev10, lev11;
	Level lev12, lev13, lev14, lev15, lev16, lev17;

	Sprite av00 = (Sprite) Resources.Load ("Textures/Level Menu/Level Avatars/level00.png");
	Sprite av01 = (Sprite) Resources.Load ("Textures/Level Menu/Level Avatars/Level01.png");
	Sprite av02 = (Sprite) Resources.Load ("Textures/Level Menu/Level Avatars/Level02.png");
	Sprite av03 = (Sprite) Resources.Load ("Textures/Level Menu/Level Avatars/Level03.png");
	Sprite av04 = (Sprite) Resources.Load ("Textures/Level Menu/Level Avatars/Level04.png");
	Sprite av05 = (Sprite) Resources.Load ("Textures/Level Menu/Level Avatars/Level05.png");

	Sprite av06 = (Sprite) Resources.Load ("Textures/Level Menu/Level Avatars/Level06.png");
	Sprite av07 = (Sprite) Resources.Load ("Textures/Level Menu/Level Avatars/Level07.png");
	Sprite av08 = (Sprite) Resources.Load ("Textures/Level Menu/Level Avatars/Level08.png");
	Sprite av09 = (Sprite) Resources.Load ("Textures/Level Menu/Level Avatars/Level09.png");
	Sprite av10 = (Sprite) Resources.Load ("Textures/Level Menu/Level Avatars/Level10.png");
	Sprite av11 = (Sprite) Resources.Load ("Textures/Level Menu/Level Avatars/Level11.png");

	Sprite av12 = (Sprite) Resources.Load ("Textures/Level Menu/Level Avatars/Level12.png");
	Sprite av13 = (Sprite) Resources.Load ("Textures/Level Menu/Level Avatars/Level13.png");
	Sprite av14 = (Sprite) Resources.Load ("Textures/Level Menu/Level Avatars/Level14.png");
	Sprite av15 = (Sprite) Resources.Load ("Textures/Level Menu/Level Avatars/Level15.png");
	Sprite av16 = (Sprite) Resources.Load ("Textures/Level Menu/Level Avatars/Level16.png");
	Sprite av17 = (Sprite) Resources.Load ("Textures/Level Menu/Level Avatars/Level17.png");

	public TotalityOfLevels(){
		lev00 = new Level (0, av00);
		lev01 = new Level (1, av01);
		lev02 = new Level (2, av02);
		lev03 = new Level (3, av03);
		lev04 = new Level (4, av04);
		lev05 = new Level (5, av05);

		lev06 = new Level (6, av06);
		lev07 = new Level (7, av07);
		lev08 = new Level (8, av08);
		lev09 = new Level (9, av09);
		lev10 = new Level (10, av10);
		lev11 = new Level (11, av11);

		lev12 = new Level (12, av12);
		lev13 = new Level (13, av13);
		lev14 = new Level (14, av14);
		lev15 = new Level (15, av15);
		lev16 = new Level (16, av16);
		lev17 = new Level (17, av17);

	}
}




