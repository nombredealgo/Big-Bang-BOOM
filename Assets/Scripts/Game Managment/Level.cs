using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Level	{

	private int number;
	private bool overcomed;
	private bool aviable;
	private Sprite levelAvatar;

	public Level (int number, Sprite levelAvatar)
	{
		this.number = number;
		this.levelAvatar = levelAvatar;
		overcomed = false;
		aviable = false;
	}

	public int GetNumber(){ return number; }
	public bool GetOvercomed(){ return overcomed; }
	public void SetOvercomed(bool value){ overcomed = true; }
	public bool GetAviable(){ return aviable; }
	public void SetAviable(bool value){ aviable = true; }
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

	public TotalityOfLevels(){
		lev00 = new Level (0, Resources.Load<Sprite> ("Textures/Level Menu/Level Avatars/AvtLevel00"));
		lev01 = new Level (1, Resources.Load<Sprite> ("Textures/Level Menu/Level Avatars/AvtLevel01"));
		lev02 = new Level (2, Resources.Load<Sprite> ("Textures/Level Menu/Level Avatars/AvtLevel02"));
		lev03 = new Level (3, Resources.Load<Sprite> ("Textures/Level Menu/Level Avatars/AvtLevel03"));
		lev04 = new Level (4, Resources.Load<Sprite> ("Textures/Level Menu/Level Avatars/AvtLevel04"));
		lev05 = new Level (5, Resources.Load<Sprite> ("Textures/Level Menu/Level Avatars/AvtLevel05"));

		lev06 = new Level (6, Resources.Load<Sprite> ("Textures/Level Menu/Level Avatars/AvtLevel06"));
		lev07 = new Level (7, Resources.Load<Sprite> ("Textures/Level Menu/Level Avatars/AvtLevel07"));
		lev08 = new Level (8, Resources.Load<Sprite> ("Textures/Level Menu/Level Avatars/AvtLevel08"));
		lev09 = new Level (9, Resources.Load<Sprite> ("Textures/Level Menu/Level Avatars/AvtLevel09"));
		lev10 = new Level (10,Resources.Load<Sprite> ("Textures/Level Menu/Level Avatars/AvtLevel10"));
		lev11 = new Level (11,Resources.Load<Sprite> ("Textures/Level Menu/Level Avatars/AvtLevel11"));

		lev12 = new Level (12,Resources.Load<Sprite> ("Textures/Level Menu/Level Avatars/AvtLevel12"));
		lev13 = new Level (13,Resources.Load<Sprite> ("Textures/Level Menu/Level Avatars/AvtLevel13"));
		lev14 = new Level (14,Resources.Load<Sprite> ("Textures/Level Menu/Level Avatars/AvtLevel14"));
		lev15 = new Level (15,Resources.Load<Sprite> ("Textures/Level Menu/Level Avatars/AvtLevel15"));
		lev16 = new Level (16,Resources.Load<Sprite> ("Textures/Level Menu/Level Avatars/AvtLevel16"));
		lev17 = new Level (17,Resources.Load<Sprite> ("Textures/Level Menu/Level Avatars/AvtLevel17"));

		Resources.UnloadUnusedAssets ();
	}
}




