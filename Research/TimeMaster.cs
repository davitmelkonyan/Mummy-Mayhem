using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class TimeMaster : MonoBehaviour {

	DateTime currentDate;
	DateTime oldDate;

	DateTime currentDateForLab;
	DateTime oldDateForLab;

	DateTime currentDateForRewards;
	DateTime oldDateForRewards;

	public string saveLocation;
	public string saveLocationForLab;
	public string saveLocationForRewards;
	public static TimeMaster instance;
	
	void Awake()
	{
		instance = this;
		saveLocation = "lastSavedDate1";
		saveLocationForLab = "lastSavedDate2";
		saveLocationForRewards = "lastSavedDate3";

	}
	// Update is called once per frame
	public float CheckDate()
	{
		currentDate = System.DateTime.Now;
		string tempString = PlayerPrefs.GetString(saveLocation,"1");
		long tempLong = Convert.ToInt64(tempString);
		DateTime oldDate = DateTime.FromBinary(tempLong);
		TimeSpan differance = currentDate.Subtract(oldDate);
		return (float)differance.TotalSeconds;
	}

	public void SaveDate(){
		PlayerPrefs.SetString(saveLocation,System.DateTime.Now.ToBinary().ToString());
	}

	public void SaveDateForLab(){
		PlayerPrefs.SetString(saveLocationForLab,System.DateTime.Now.ToBinary().ToString());
	}

	public void SaveDateForRewards(){
		PlayerPrefs.SetString(saveLocationForRewards,System.DateTime.Now.ToBinary().ToString());
	}

	public float CheckDateForLab()
	{
		currentDateForLab = System.DateTime.Now;
		string tempStringForLab = PlayerPrefs.GetString(saveLocationForLab,"1");
		long tempLongForLab = Convert.ToInt64(tempStringForLab);
		DateTime oldDateForLab = DateTime.FromBinary(tempLongForLab);
		TimeSpan differanceForLab = currentDateForLab.Subtract(oldDateForLab);
		return (float)differanceForLab.TotalSeconds;
	}

	public float CheckDateForRewards()
	{
		currentDateForRewards = System.DateTime.Now;
		string tempStringForRewards = PlayerPrefs.GetString(saveLocationForRewards,"1");
		long tempLongForRewards = Convert.ToInt64(tempStringForRewards);
		DateTime oldDateForRewards = DateTime.FromBinary(tempLongForRewards);
		TimeSpan differanceForRewards = currentDateForRewards.Subtract(oldDateForRewards);
		return (float)differanceForRewards.TotalSeconds;
	}

	
}
