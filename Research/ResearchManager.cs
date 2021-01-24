using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResearchManager : MonoBehaviour {
	private int maxEnergy;
	private int maxEnergyLevel;
	[SerializeField]
	private Text maxEnergyText;
	[SerializeField]
	private Text nextMaxEnergyText;
	[SerializeField]
	private Text maxEnergyLevelText;
	[SerializeField]
	private ResearchStat maxEnergyBar;
	[SerializeField]
	private Button maxEnergyButton;
	[SerializeField]
	private Button cancelMaxEnergy;

	private int tapEnergy;
	private int tapEnergyLevel;
	[SerializeField]
	private Text tapEnergyText;
	[SerializeField]
	private Text nextTapEnergyText;
	[SerializeField]
	private Text tapEnergyLevelText;
	[SerializeField]
	private ResearchStat tapEnergyBar;
	[SerializeField]
	private Button tapEnergyButton;
	[SerializeField]
	private Button cancelTapEnergy;

	private bool isResearchingMaxEnergy=false;
	private bool isResearchingTap = false;

	public void updateMaxEnergy(){
		MainMenu.Instance.AudioSource.PlayOneShot(SoundManager.Instance.Click4);
		tapEnergyButton.interactable = false;
		maxEnergyButton.gameObject.SetActive(false);
		cancelMaxEnergy.gameObject.SetActive(true);
		isResearchingMaxEnergy = true;
		TimeMaster.instance.SaveDateForLab();
	}

	public void updateTapEnergy(){
		MainMenu.Instance.AudioSource.PlayOneShot(SoundManager.Instance.Click4);
		maxEnergyButton.interactable = false;
		tapEnergyButton.gameObject.SetActive(false);
		cancelTapEnergy.gameObject.SetActive(true);
		isResearchingTap = true;
		TimeMaster.instance.SaveDateForLab();
	}

	public void cancelUpgrade(){
		MainMenu.Instance.AudioSource.PlayOneShot(SoundManager.Instance.Click9);
		zeroSpeedUpUsed();
		PlayerPrefs.SetInt("upgradingLab",0);
		if(isResearchingTap == true)
		{
			isResearchingTap = false;
			tapEnergyButton.gameObject.SetActive(true);
			tapEnergyBar.CurrentVal = tapEnergyBar.MaxVal;
			cancelTapEnergy.gameObject.SetActive(false);
			maxEnergyButton.interactable = true;
			timeLeft1.gameObject.SetActive(false);
			speedUpBtn1.gameObject.SetActive(false);
			Color c = upgradeWord2.GetComponent<Image>().color;
        	c.a = 1f;
			upgradeWord2.GetComponent<Image>().color = c;
		}
		else if(isResearchingMaxEnergy == true)
		{
			isResearchingMaxEnergy = false;
			maxEnergyButton.gameObject.SetActive(true);
			maxEnergyBar.CurrentVal = maxEnergyBar.MaxVal;
			cancelMaxEnergy.gameObject.SetActive(false);
			tapEnergyButton.interactable = true;
			timeLeft2.gameObject.SetActive(false);
			speedUpBtn2.gameObject.SetActive(false);
			Color c = upgradeWord1.GetComponent<Image>().color;
        	c.a = 1f;
			upgradeWord1.GetComponent<Image>().color = c;
		}
	}

	private int numOf5minUsed=0;
	private int numOf10minUsed=0;
	private int numOf15minUsed=0;
	private int numOf30minUsed=0;
	private int numOf60minUsed=0;
	private int numOf3hrsUsed=0;

	public void zeroSpeedUpUsed()
	{
		numOf5minUsed=0;
		numOf10minUsed=0;
		numOf15minUsed=0;
		numOf30minUsed=0;
		numOf60minUsed=0;
		numOf3hrsUsed=0;
		PlayerPrefs.SetInt("5minUsedLab",0);
		PlayerPrefs.SetInt("10minUsedLab",0);
		PlayerPrefs.SetInt("15minUsedLab",0);
		PlayerPrefs.SetInt("30minUsedLab",0);
		PlayerPrefs.SetInt("60minUsedLab",0);
		PlayerPrefs.SetInt("3hrsUsedLab",0);
	}

	private int timeMaxEnergy;
	private int timeMaxEnergyLvl2= 300;
	private int timeMaxEnergyLvl3= 660;
	private int timeMaxEnergyLvl4= 900;
	private int timeMaxEnergyLvl5= 1380;
	private int timeMaxEnergyLvl6= 1800;
	private int timeMaxEnergyLvl7= 2700;
	private int timeMaxEnergyLvl8= 3180;
	private int timeMaxEnergyLvl9= 4200;
	private int timeMaxEnergyLvl10= 6300;
	private int timeMaxEnergyLvl11= 9000;
	private int timeMaxEnergyLvl12= 12900;
	

	private int timeTapEnergy;
	private int timeTapEnergyLvl2 = 240;
	private int timeTapEnergyLvl3 = 840;
	private int timeTapEnergyLvl4 = 1800;
	private int timeTapEnergyLvl5 = 2700;
	private int timeTapEnergyLvl6 = 4200;
	private int timeTapEnergyLvl7 = 5400;
	private int timeTapEnergyLvl8 = 7800;
	private int timeTapEnergyLvl9 = 9000;
	private int timeTapEnergyLvl10 = 12900;
	
	[SerializeField]
	private ResearchStat bar;
	[SerializeField]
	private GameObject point;
	[SerializeField]
	private GameObject point2;
	[SerializeField]
	private Image pumpk;
	[SerializeField]
	private Button click;
	private bool isHolding = false;
	private Animator pumpkinAnimator;
	
	private int houseLevel=1;
	[SerializeField]
	private Text houseLevelText;
	private float housePoint = 1000;
	[SerializeField]
	private Text housePointText;
	private Animator houseLevelTextAnim;

	private Animator leveltxt;
	private Animator pointtxt;
	private Animator housik;
	[SerializeField]
	private GameObject housikk;
	
	

	[SerializeField]
	private Button buy02;
	[SerializeField]
	private Text buy02text;
	[SerializeField]
	private Image bought02;
	[SerializeField]
	private Button buy05;
	[SerializeField]
	private Text buy05text;
	[SerializeField]
	private Image bought05;
	[SerializeField]
	private Button buy1;
	[SerializeField]
	private Text buy1text;
	[SerializeField]
	private Image bought1;
	[SerializeField]
	private Text moneyOutside;


	[SerializeField]
	private Button houseTapToContinue;

	public void tapToContinueMethod()
	{
		directionsHouse.gameObject.SetActive(false);
		houseTapToContinue.gameObject.SetActive(false);
		PlayerPrefs.SetInt("labIntroDone",5);
	}


	
	private int money;

	public void buy2(){
		money = PlayerPrefs.GetInt("Money");
		if(money >=200){
			PlayerPrefs.SetInt("addedHousePoint",2);
			buy02.gameObject.SetActive(false);
			buy02text.gameObject.SetActive(false);
			bought02.gameObject.SetActive(true);
			buy05.interactable = true;
			money -=200;
			MainMenu.Instance.AudioSource.PlayOneShot(SoundManager.Instance.UseSpeedUp);
		}
		else{
			MainMenu.Instance.AudioSource.PlayOneShot(SoundManager.Instance.Click6);
		}
		PlayerPrefs.SetInt("Money", money);
		moneyOutside.text = money.ToString();
	}

	public void buy5(){
		money = PlayerPrefs.GetInt("Money");
		if(money >=400){
			PlayerPrefs.SetInt("addedHousePoint",5);
			buy05.gameObject.SetActive(false);
			buy05text.gameObject.SetActive(false);
			bought05.gameObject.SetActive(true);
			buy1.interactable = true;
			money -=400;
			MainMenu.Instance.AudioSource.PlayOneShot(SoundManager.Instance.UseSpeedUp);
		}
		else{
			MainMenu.Instance.AudioSource.PlayOneShot(SoundManager.Instance.Click6);
		}
		PlayerPrefs.SetInt("Money", money);
		moneyOutside.text = money.ToString();
	}

	public void buy11(){
		money = PlayerPrefs.GetInt("Money");
		if(money >=650){
			PlayerPrefs.SetInt("addedHousePoint",11);
			buy1.gameObject.SetActive(false);
			buy1text.gameObject.SetActive(false);
			bought1.gameObject.SetActive(true);
			money -=650;
			MainMenu.Instance.AudioSource.PlayOneShot(SoundManager.Instance.UseSpeedUp);
		}
		else{
			MainMenu.Instance.AudioSource.PlayOneShot(SoundManager.Instance.Click6);
		}
		PlayerPrefs.SetInt("Money", money);
		moneyOutside.text = money.ToString();
	}

	private int a=0;
	private bool oneTime = false;
	public void giveHousePoint()
	{
		MainMenu.Instance.AudioSource.PlayOneShot(SoundManager.Instance.Click3);
		pumpkinAnimator.SetTrigger("up");
		if(a==0)
		{	GameObject p = Instantiate(point,new Vector3(0, 0, 0), Quaternion.identity);
			p.transform.SetParent (GameObject.FindGameObjectWithTag("HOUSEK").transform, false);
			GameObject obj = p.transform.GetChild(0).gameObject;
			if(PlayerPrefs.GetInt("addedHousePoint")==1)
				{obj.GetComponent<Text>().text = "+0.1";
				bar.CurrentVal += 0.1f;
				}
			else if(PlayerPrefs.GetInt("addedHousePoint")==2)
				{obj.GetComponent<Text>().text = "+0.2";
				bar.CurrentVal += 0.2f;
				}
			else if(PlayerPrefs.GetInt("addedHousePoint")==5)
				{obj.GetComponent<Text>().text = "+0.5";
				bar.CurrentVal += 0.5f;
				}
			else if(PlayerPrefs.GetInt("addedHousePoint")==11)
				{obj.GetComponent<Text>().text = "+1.0";
				bar.CurrentVal += 1f;
				}
			StartCoroutine(dest(p,2.45f));
			a++;
		}
		else if(a==1){
			GameObject p2 = Instantiate(point2,new Vector3(0, 0, 0), Quaternion.identity);
			p2.transform.SetParent (GameObject.FindGameObjectWithTag("HOUSEK").transform, false);
			GameObject obj1 = p2.transform.GetChild(0).gameObject;
			if(PlayerPrefs.GetInt("addedHousePoint")==1)
				{obj1.GetComponent<Text>().text = "+0.1";
				bar.CurrentVal += 0.1f;
				}
			else if(PlayerPrefs.GetInt("addedHousePoint")==2)
				{obj1.GetComponent<Text>().text = "+0.2";
				bar.CurrentVal += 0.2f;
				}
			else if(PlayerPrefs.GetInt("addedHousePoint")==5)
				{obj1.GetComponent<Text>().text = "+0.5";
				bar.CurrentVal += 0.5f;
				}
			else if(PlayerPrefs.GetInt("addedHousePoint")==11)
				{obj1.GetComponent<Text>().text = "+1.0";
				bar.CurrentVal += 1f;
				}
			StartCoroutine(dest(p2,1.45f));
			a--;
		}
	}	

	private float Map(float value, float inMin, float inMax, float outMin, float outMax ){
		 return (value - inMin) * (outMax - outMin)/(inMax - inMin) +outMin;
	}

	IEnumerator dest(GameObject p, float delay)
 	{
     	yield return new WaitForSeconds(delay);
		Destroy(p);
 	}

	public void Awake()
	{
		bar.Initialize();
		maxEnergyBar.Initialize();
		tapEnergyBar.Initialize();
	}

	private float navigationTime=0;
	
	private Animator doorAnim;
	[SerializeField]
	private GameObject houseBckg;
	private Animator houseBckgAnim;

	[SerializeField]
	private Button tapToContinue;
	[SerializeField]
	private Image houseHealthPointer;


	[SerializeField]
	private GameObject labDirections;

	public void TapToContinue()
	{
		labDirections.gameObject.SetActive(false);
		houseHealthPointer.gameObject.SetActive(true);
		tapToContinue.gameObject.SetActive(false);
		PlayerPrefs.SetInt("labIntroDone", 1);
	}

	[SerializeField]
	private GameObject directionsHouse;
	[SerializeField]
	private Text directionsHouseText;
	private Animator directionsHouseAnim;

	[SerializeField]
	private Image notification;
	[SerializeField]
	private Text notificationText;

	private int gameLevel;
	void Start () {
		gameLevel = PlayerPrefs.GetInt("levelNum");
		houseLevelTextAnim = housePointText.GetComponent<Animator>();
		doorAnim = HealthLABmenu.GetComponent<Animator>();
		houseBckgAnim = houseBckg.GetComponent<Animator>();
		goldRain = GetComponentInChildren<ParticleSystem>();
		directionsHouseAnim = directionsHouse.GetComponent<Animator>();

		if(PlayerPrefs.HasKey("labIntroDone")==false)
			PlayerPrefs.SetInt("labIntroDone", 0);
		if(PlayerPrefs.GetInt("labIntroDone") == 0)
		{
			labDirections.gameObject.SetActive(true);
			tapToContinue.gameObject.SetActive(true);
		}
		if(PlayerPrefs.GetInt("labIntroDone")==2 || PlayerPrefs.GetInt("labIntroDone")==3)
		{
			doorAnim.SetTrigger("open");
			Invoke("houseikAppear",1.7f);
			
		}

		// PlayerPrefs.SetInt("HouseLevel",1);
		// PlayerPrefs.SetInt("HouseHealth",300);
		
		if(PlayerPrefs.GetInt("labIntroDone")>3 || PlayerPrefs.GetInt("HouseLevel")>1 || PlayerPrefs.GetInt("HouseHealth")>300)
		{
			directionsHouse.gameObject.SetActive(false);
		}

		numOf5minUsed = PlayerPrefs.GetInt("5minUsedLab");
		numOf10minUsed = PlayerPrefs.GetInt("10minUsedLab");
		numOf15minUsed = PlayerPrefs.GetInt("15minUsedLab");
		numOf30minUsed = PlayerPrefs.GetInt("30minUsedLab");
		numOf60minUsed = PlayerPrefs.GetInt("60minUsedLab");
		numOf3hrsUsed = PlayerPrefs.GetInt("3hrsUsedLab");

		timeMaxEnergy = PlayerPrefs.GetInt("timeMaxEnergy");
		maxEnergyBar.MaxVal = timeMaxEnergy;
		maxEnergyBar.CurrentVal = timeMaxEnergy;
		timeTapEnergy = PlayerPrefs.GetInt("timeTapEnergy");
		tapEnergyBar.MaxVal = timeTapEnergy;
		tapEnergyBar.CurrentVal = timeTapEnergy;

		if(PlayerPrefs.GetInt("upgradingLab")==1)
		{
			isResearchingTap = true;
			timeLeft1.gameObject.SetActive(true);
			speedUpBtn1.gameObject.SetActive(true);
			tapEnergyButton.gameObject.SetActive(false);
			maxEnergyButton.interactable = false;
			cancelTapEnergy.gameObject.SetActive(true);
			tapEnergyBar.CurrentVal -= TimeMaster.instance.CheckDateForLab()+(numOf5minUsed*300)+(numOf10minUsed*600)+(numOf15minUsed*900)+(numOf30minUsed*1800)+(numOf60minUsed*3600)+(numOf3hrsUsed*10800);
		}
		else if(PlayerPrefs.GetInt("upgradingLab")==2)
		{
			isResearchingMaxEnergy = true;
			timeLeft2.gameObject.SetActive(true);
			speedUpBtn2.gameObject.SetActive(true);
			maxEnergyButton.gameObject.SetActive(false);
			tapEnergyButton.interactable = false;
			cancelMaxEnergy.gameObject.SetActive(true);
			maxEnergyBar.CurrentVal -= TimeMaster.instance.CheckDateForLab()+(numOf5minUsed*300)+(numOf10minUsed*600)+(numOf15minUsed*900)+(numOf30minUsed*1800)+(numOf60minUsed*3600)+(numOf3hrsUsed*10800);
		}
		
		
		maxEnergy = PlayerPrefs.GetInt("Energy");
		maxEnergyLevel = PlayerPrefs.GetInt("MaxEnergyLevel");
		maxEnergyText.text = "Max Energy:" + maxEnergy.ToString();
		nextMaxEnergyText.text = "Next Level:" + (maxEnergy+30).ToString();
		if(maxEnergyLevel==12){
			nextTapEnergyText.text = "MAX";
			maxEnergyButton.gameObject.SetActive(false);
			max2.gameObject.SetActive(true);
		}
		maxEnergyLevelText.text = "Level:"+ maxEnergyLevel+"/12";

		tapEnergyLevel = PlayerPrefs.GetInt("TapEnergyLevel");
		if(tapEnergyLevel==1){
			tapEnergyText.text = "Full Energy bar empties in 10seconds";
			nextTapEnergyText.text = "Next Level: 12.4seconds";
		}
		else if(tapEnergyLevel==2){
			tapEnergyText.text = "Full Energy bar empties in 12.4seconds";
			nextTapEnergyText.text = "Next Level: 14.8seconds";
		}
		else if(tapEnergyLevel==3){
			tapEnergyText.text = "Full Energy bar empties in 14.8seconds";
			nextTapEnergyText.text = "Next Level: 17.2seconds";
		}
		else if(tapEnergyLevel==4){
			tapEnergyText.text = "Full Energy bar empties in 17.2seconds";
			nextTapEnergyText.text = "Next Level: 19.6seconds";
		}
		else if(tapEnergyLevel==5){
			tapEnergyText.text = "Full Energy bar empties in 19.6seconds";
			nextTapEnergyText.text = "Next Level: 22seconds";
		}
		else if(tapEnergyLevel==6){
			tapEnergyText.text = "Full Energy bar empties in 22seconds";
			nextTapEnergyText.text = "Next Level: 24.4seconds";
		}
		else if(tapEnergyLevel==7){
			tapEnergyText.text = "Full Energy bar empties in 24.4seconds";
			nextTapEnergyText.text = "Next Level: 26.8seconds";
		}
		else if(tapEnergyLevel==8){
			tapEnergyText.text = "Full Energy bar empties in 26.8seconds";
			nextTapEnergyText.text = "Next Level: 29.2seconds";
		}
		else if(tapEnergyLevel==9){
			tapEnergyText.text = "Full Energy bar empties in 29.2seconds";
			nextTapEnergyText.text = "Next Level: 32seconds";
		}
		else if(tapEnergyLevel==10){
			tapEnergyText.text = "Full Energy bar empties in 32seconds";
			nextTapEnergyText.text = "MAX";
			tapEnergyButton.gameObject.SetActive(false);
			max1.gameObject.SetActive(true);
		}
		tapEnergyLevelText.text = "Level:"+ tapEnergyLevel+"/10";

		//HOUSEEEEEEEEEEEEEEE
		pumpkinAnimator = pumpk.GetComponent<Animator>();
		houseLevel = PlayerPrefs.GetInt("HouseLevel");
		houseLevelText.text = houseLevel.ToString();
		housePoint = PlayerPrefs.GetInt("HouseHealth");
		housePointText.text = housePoint.ToString();
		
		leveltxt = houseLevelText.GetComponent<Animator>();
		pointtxt = housePointText.GetComponent<Animator>();
		housik = housikk.GetComponent<Animator>();
		bar.CurrentVal = 0;
		bar.MaxVal = 2;
		if(PlayerPrefs.GetInt("addedHousePoint")==1)
			{buy05.interactable = false;
			buy1.interactable = false;
			}
		else if(PlayerPrefs.GetInt("addedHousePoint")==2)
			{buy1.interactable = false;
			bought02.gameObject.SetActive(true);
			buy02.gameObject.SetActive(false);
			buy02text.gameObject.SetActive(false);
			}
		else if(PlayerPrefs.GetInt("addedHousePoint")==5)
			{
			bought02.gameObject.SetActive(true);
			buy02.gameObject.SetActive(false);
			buy02text.gameObject.SetActive(false);
			bought05.gameObject.SetActive(true);
			buy05.gameObject.SetActive(false);
			buy05text.gameObject.SetActive(false);
			}
		else if(PlayerPrefs.GetInt("addedHousePoint")==11)
		{	bought1.gameObject.SetActive(true);
			buy1.gameObject.SetActive(false);
			buy1text.gameObject.SetActive(false);
			bought05.gameObject.SetActive(true);
			buy05.gameObject.SetActive(false);
			buy05text.gameObject.SetActive(false);
			bought02.gameObject.SetActive(true);
			buy02.gameObject.SetActive(false);
			buy02text.gameObject.SetActive(false);
		}
		if(houseLevel == 25){
			click.gameObject.SetActive(false);
			nope.gameObject.SetActive(true);
			nopeText.text = "MAX";
		}
		else{
			click.gameObject.SetActive(true);
			nope.gameObject.SetActive(false);
		}

		if(gameLevel == 4 && houseLevel <=1)
			click.gameObject.SetActive(true);
		else if(gameLevel == 5 && houseLevel<=2)
			click.gameObject.SetActive(true);
		else if(gameLevel == 6 && houseLevel<=3)
			click.gameObject.SetActive(true);
		else if(gameLevel == 7 && houseLevel<=4)
			click.gameObject.SetActive(true);
		else if(gameLevel == 8 && houseLevel<=5)
			click.gameObject.SetActive(true);
		else if(gameLevel == 9 && houseLevel<=6)
			click.gameObject.SetActive(true);
		else if(gameLevel == 10 && houseLevel<=7)
			click.gameObject.SetActive(true);
		else if(gameLevel == 11 && houseLevel<=8)
			click.gameObject.SetActive(true);
		else if(gameLevel == 12 && houseLevel<=9)
			click.gameObject.SetActive(true);
		else if(gameLevel == 13 && houseLevel<=10)
			click.gameObject.SetActive(true);
		else if(gameLevel == 14 && houseLevel<=11)
			click.gameObject.SetActive(true);
		else if(gameLevel == 15 && houseLevel<=12)
			click.gameObject.SetActive(true);
		else if(gameLevel == 16 && houseLevel<=13)
			click.gameObject.SetActive(true);
		else if(gameLevel == 17 && houseLevel<=14)
			click.gameObject.SetActive(true);
		else if(gameLevel == 18 && houseLevel<=15)
			click.gameObject.SetActive(true);
		else if(gameLevel == 19 && houseLevel<=16)
			click.gameObject.SetActive(true);
		else if(gameLevel == 20 && houseLevel<=17)
			click.gameObject.SetActive(true);
		else if(gameLevel == 21 && houseLevel<=18)
			click.gameObject.SetActive(true);
		else if(gameLevel == 22 && houseLevel<=19)
			click.gameObject.SetActive(true);
		else if(gameLevel == 23 && houseLevel<=20)
			click.gameObject.SetActive(true);
		else if(gameLevel == 24 && houseLevel<=21)
			click.gameObject.SetActive(true);
		else if(gameLevel == 25 && houseLevel<=22)
			click.gameObject.SetActive(true);
		else if(gameLevel == 26 && houseLevel<=23)
			click.gameObject.SetActive(true);
		else if(gameLevel >= 27 && houseLevel<=24)
			click.gameObject.SetActive(true);
		else{
			nope.gameObject.SetActive(true);
			click.gameObject.SetActive(false);
		}
		
	}

	[SerializeField]
	private GameObject nope;

	[SerializeField]
	private Button speedUpBtn1;
	[SerializeField]
	private Button speedUpBtn2;
	[SerializeField]
	private Text timeLeft1;
	[SerializeField]
	private Text timeLeft2;
	[SerializeField]
	private Image upgradeWord1;
	[SerializeField]
	private Image upgradeWord2;
	[SerializeField]
	private Image max1;
	[SerializeField]
	private Image max2;


	public void turnOffNotification()
	{
		notification.gameObject.SetActive(false);
	}

	IEnumerator upgradeSound()
	{
		MainMenu.Instance.AudioSource.PlayOneShot(SoundManager.Instance.Upgrade);
		yield return new WaitForSeconds(0.7f);
		MainMenu.Instance.AudioSource.PlayOneShot(SoundManager.Instance.Upgrade);
		yield return new WaitForSeconds(0.7f);
		MainMenu.Instance.AudioSource.PlayOneShot(SoundManager.Instance.Upgrade);
	}
	
	void Update () {
		if (isResearchingTap == true){
			PlayerPrefs.SetInt("upgradingLab",1);
			if(tapEnergyBar.CurrentVal >0){
				timeLeft1.gameObject.SetActive(true);
				speedUpBtn1.gameObject.SetActive(true);
				Color c = upgradeWord2.GetComponent<Image>().color;
        		c.a = 0.5f;
				upgradeWord2.GetComponent<Image>().color = c;
				tapEnergyBar.CurrentVal -= Time.deltaTime;
			}
			else{
				StartCoroutine(upgradeSound());
				notification.gameObject.SetActive(true);
				notificationText.text = "Congratulations! You upgraded the energy bar.";
				Invoke("turnOffNotification",3.5f);
				PlayerPrefs.SetInt("upgradingLab",0);
				zeroSpeedUpUsed();
				timeLeft1.gameObject.SetActive(false);
				speedUpBtn1.gameObject.SetActive(false);
				Color c = upgradeWord2.GetComponent<Image>().color;
        		c.a = 1f;
				upgradeWord2.GetComponent<Image>().color = c;
				tapEnergyButton.gameObject.SetActive(true);
				cancelTapEnergy.gameObject.SetActive(false);
				maxEnergyButton.interactable = true;
				tapEnergyLevel++;
				PlayerPrefs.SetInt("TapEnergyLevel",tapEnergyLevel);
				tapEnergyLevelText.text = "Level: " + tapEnergyLevel +"/10";
				maxEnergyButton.interactable = true;
				tapEnergyButton.interactable = true;
				isResearchingTap = false;
				if(tapEnergyLevel==2){
					tapEnergyText.text = "Full Energy bar empties in 12.4seconds";
					nextTapEnergyText.text = "Next Level: 14.8seconds";
					tapEnergyBar.MaxVal = timeTapEnergyLvl3;
					tapEnergyBar.CurrentVal = timeTapEnergyLvl3;
					PlayerPrefs.SetInt("timeTapEnergy",timeTapEnergyLvl3);
				}
				else if(tapEnergyLevel==3){
					tapEnergyText.text = "Full Energy bar empties in 14.8seconds";
					nextTapEnergyText.text = "Next Level: 17.2seconds";
					tapEnergyBar.MaxVal = timeTapEnergyLvl4;
					tapEnergyBar.CurrentVal = timeTapEnergyLvl4;
					PlayerPrefs.SetInt("timeTapEnergy",timeTapEnergyLvl4);
				}
				else if(tapEnergyLevel==4){
					tapEnergyText.text = "Full Energy bar empties in 17.2seconds";
					nextTapEnergyText.text = "Next Level: 19.6seconds";
					tapEnergyBar.MaxVal = timeTapEnergyLvl5;
					tapEnergyBar.CurrentVal = timeTapEnergyLvl5;
					PlayerPrefs.SetInt("timeTapEnergy",timeTapEnergyLvl5);
				}
				else if(tapEnergyLevel==5){
					tapEnergyText.text = "Full Energy bar empties in 19.6seconds";
					nextTapEnergyText.text = "Next Level: 22seconds";
					tapEnergyBar.MaxVal = timeTapEnergyLvl6;
					tapEnergyBar.CurrentVal = timeTapEnergyLvl6;
					PlayerPrefs.SetInt("timeTapEnergy",timeTapEnergyLvl6);
				}
				else if(tapEnergyLevel==6){
					tapEnergyText.text = "Full Energy bar empties in 22seconds";
					nextTapEnergyText.text = "Next Level: 24.4seconds";
					tapEnergyBar.MaxVal = timeTapEnergyLvl7;
					tapEnergyBar.CurrentVal = timeTapEnergyLvl7;
					PlayerPrefs.SetInt("timeTapEnergy",timeTapEnergyLvl7);
				}
				else if(tapEnergyLevel==7){
					tapEnergyText.text = "Full Energy bar empties in 24.4seconds";
					nextTapEnergyText.text = "Next Level: 26.8seconds";
					tapEnergyBar.MaxVal = timeTapEnergyLvl8;
					tapEnergyBar.CurrentVal = timeTapEnergyLvl8;
					PlayerPrefs.SetInt("timeTapEnergy",timeTapEnergyLvl8);
				}
				else if(tapEnergyLevel==8){
					tapEnergyText.text = "Full Energy bar empties in 26.8seconds";
					nextTapEnergyText.text = "Next Level: 29.2seconds";
					tapEnergyBar.MaxVal = timeTapEnergyLvl9;
					tapEnergyBar.CurrentVal = timeTapEnergyLvl9;
					PlayerPrefs.SetInt("timeTapEnergy",timeTapEnergyLvl9);
				}
				else if(tapEnergyLevel==9){
					tapEnergyText.text = "Full Energy bar empties in 29.2seconds";
					nextTapEnergyText.text = "Next Level: 32seconds";
					tapEnergyBar.MaxVal = timeTapEnergyLvl10;
					tapEnergyBar.CurrentVal = timeTapEnergyLvl10;
					PlayerPrefs.SetInt("timeTapEnergy",timeTapEnergyLvl10);
				}
				else if(tapEnergyLevel==10){
					tapEnergyText.text = "Full Energy bar empties in 32seconds";
					nextTapEnergyText.text = "MAX";
					tapEnergyButton.gameObject.SetActive(false);
					max1.gameObject.SetActive(true);
				}
			}
		}
		else if(isResearchingMaxEnergy == true){
			PlayerPrefs.SetInt("upgradingLab",2);
			if(maxEnergyBar.CurrentVal >0){
				maxEnergyBar.CurrentVal -= Time.deltaTime;
				timeLeft2.gameObject.SetActive(true);
				speedUpBtn2.gameObject.SetActive(true);
				Color c = upgradeWord1.GetComponent<Image>().color;
        		c.a = 0.5f;
				upgradeWord1.GetComponent<Image>().color = c;
			}
			else{
				StartCoroutine(upgradeSound());
				PlayerPrefs.SetInt("upgradingLab",0);
				notification.gameObject.SetActive(true);
				notificationText.text = "Congratulations! You upgraded the energy bar.";
				Invoke("turnOffNotification",3.5f);
				zeroSpeedUpUsed();
				timeLeft2.gameObject.SetActive(false);
				Color c = upgradeWord1.GetComponent<Image>().color;
        		c.a = 1f;
				upgradeWord1.GetComponent<Image>().color = c;
				speedUpBtn2.gameObject.SetActive(false);
				maxEnergyButton.gameObject.SetActive(true);
				cancelMaxEnergy.gameObject.SetActive(false);
				tapEnergyButton.interactable = true;
				maxEnergyLevel++;
				PlayerPrefs.SetInt("MaxEnergyLevel",maxEnergyLevel);
				maxEnergy+=30;
				PlayerPrefs.SetInt("Energy",maxEnergy);
				maxEnergyText.text = "Max Energy:" + maxEnergy.ToString();
				nextMaxEnergyText.text = "Next Level:" + (maxEnergy+30).ToString();
				maxEnergyLevelText.text = "Level: " + maxEnergyLevel +"/12";
				maxEnergyButton.interactable = true;
				tapEnergyButton.interactable = true;
				isResearchingMaxEnergy = false;
				if(maxEnergyLevel==2){
					maxEnergyBar.MaxVal = timeMaxEnergyLvl3;
					maxEnergyBar.CurrentVal = timeMaxEnergyLvl3;
					PlayerPrefs.SetInt("timeMaxEnergy",timeMaxEnergyLvl3);
				}
				else if(maxEnergyLevel==3){
					maxEnergyBar.MaxVal = timeMaxEnergyLvl4;
					maxEnergyBar.CurrentVal = timeMaxEnergyLvl4;
					PlayerPrefs.SetInt("timeMaxEnergy",timeMaxEnergyLvl4);
				}
				else if(maxEnergyLevel==4){
					maxEnergyBar.MaxVal = timeMaxEnergyLvl5;
					maxEnergyBar.CurrentVal = timeMaxEnergyLvl5;
					PlayerPrefs.SetInt("timeMaxEnergy",timeMaxEnergyLvl5);
				}
				else if(maxEnergyLevel==5){
					maxEnergyBar.MaxVal = timeMaxEnergyLvl6;
					maxEnergyBar.CurrentVal = timeMaxEnergyLvl6;
					PlayerPrefs.SetInt("timeMaxEnergy",timeMaxEnergyLvl6);
				}
				else if(maxEnergyLevel==6){
					maxEnergyBar.MaxVal = timeMaxEnergyLvl7;
					maxEnergyBar.CurrentVal = timeMaxEnergyLvl7;
					PlayerPrefs.SetInt("timeMaxEnergy",timeMaxEnergyLvl7);
				}
				else if(maxEnergyLevel==7){
					maxEnergyBar.MaxVal = timeMaxEnergyLvl8;
					maxEnergyBar.CurrentVal = timeMaxEnergyLvl8;
					PlayerPrefs.SetInt("timeMaxEnergy",timeMaxEnergyLvl8);
				}
				else if(maxEnergyLevel==8){
					maxEnergyBar.MaxVal = timeMaxEnergyLvl9;
					maxEnergyBar.CurrentVal = timeMaxEnergyLvl9;
					PlayerPrefs.SetInt("timeMaxEnergy",timeMaxEnergyLvl9);
				}
				else if(maxEnergyLevel==9){
					maxEnergyBar.MaxVal = timeMaxEnergyLvl10;
					maxEnergyBar.CurrentVal = timeMaxEnergyLvl10;
					PlayerPrefs.SetInt("timeMaxEnergy",timeMaxEnergyLvl10);
				}
				else if(maxEnergyLevel==10){
					maxEnergyBar.MaxVal = timeMaxEnergyLvl11;
					maxEnergyBar.CurrentVal = timeMaxEnergyLvl11;
					PlayerPrefs.SetInt("timeMaxEnergy",timeMaxEnergyLvl11);
				}
				else if(maxEnergyLevel==11){
					maxEnergyBar.MaxVal = timeMaxEnergyLvl12;
					maxEnergyBar.CurrentVal = timeMaxEnergyLvl12;
					PlayerPrefs.SetInt("timeMaxEnergy",timeMaxEnergyLvl12);
				}
				else if(maxEnergyLevel==12){
					maxEnergyLevelText.text = "MAX";
					maxEnergyButton.gameObject.SetActive(false);
					max2.gameObject.SetActive(true);
				}
			}
		}
		if(houseLevel == 25){
			click.gameObject.SetActive(false);
			nope.gameObject.SetActive(true);
			nopeText.text = "MAX";
		}
		else{
			click.gameObject.SetActive(true);
			nope.gameObject.SetActive(false);
		}
		
		if(houseLevel == 1 && bar.CurrentVal-0.002>0  && bar.CurrentVal != 2)
		{bar.CurrentVal -=0.005f;}
		if(houseLevel == 2 && bar.CurrentVal-0.004>0  && bar.CurrentVal != 2)
		{bar.CurrentVal -=0.013f;}
		else if(houseLevel == 3 && bar.CurrentVal-0.006>0  && bar.CurrentVal != 2)
		{bar.CurrentVal -=0.0135f;}
		else if(houseLevel == 4 && bar.CurrentVal-0.007>0  && bar.CurrentVal != 2)
		{bar.CurrentVal -=0.0140f;}
		else if(houseLevel == 5 && bar.CurrentVal-0.0075>0  && bar.CurrentVal != 2)
		{bar.CurrentVal -=0.0145f;}
		else if(houseLevel == 6 && bar.CurrentVal-0.008>0  && bar.CurrentVal != 2)
		{bar.CurrentVal -=0.015f;}
		else if(houseLevel == 7 && bar.CurrentVal-0.0085>0  && bar.CurrentVal != 2)
		{bar.CurrentVal -=0.0155f;}
		else if(houseLevel == 8 && bar.CurrentVal-0.009>0  && bar.CurrentVal != 2)
		{bar.CurrentVal -=0.016f;}
		else if(houseLevel == 9 && bar.CurrentVal-0.0095>0  && bar.CurrentVal != 2)
		{bar.CurrentVal -=0.025f;}
		else if(houseLevel == 10 && bar.CurrentVal-0.01>0  && bar.CurrentVal != 2)
		{bar.CurrentVal -=0.027f;}
		else if(houseLevel == 11 && bar.CurrentVal-0.03>0  && bar.CurrentVal != 2)
		{bar.CurrentVal -=0.030f;}
		else if(houseLevel == 12 && bar.CurrentVal-0.03>0  && bar.CurrentVal != 2)
		{bar.CurrentVal -=0.032f;}
		else if(houseLevel == 13 && bar.CurrentVal-0.03>0  && bar.CurrentVal != 2)
		{bar.CurrentVal -=0.0335f;}
		else if(houseLevel == 14 && bar.CurrentVal-0.03>0  && bar.CurrentVal != 2)
		{bar.CurrentVal -=0.0343f;}
		else if(houseLevel == 15 && bar.CurrentVal-0.03>0  && bar.CurrentVal != 2)
		{bar.CurrentVal -=0.035f;}
		else if(houseLevel == 16 && bar.CurrentVal-0.03>0  && bar.CurrentVal != 2)
		{bar.CurrentVal -=0.043f;}
		else if(houseLevel == 17 && bar.CurrentVal-0.03>0  && bar.CurrentVal != 2)
		{bar.CurrentVal -=0.065f;}
		else if(houseLevel == 18 && bar.CurrentVal-0.03>0  && bar.CurrentVal != 2)
		{bar.CurrentVal -=0.075f;}
		else if(houseLevel == 19 && bar.CurrentVal-0.03>0  && bar.CurrentVal != 2)
		{bar.CurrentVal -=0.095f;}
		else if(houseLevel == 20 && bar.CurrentVal-0.03>0  && bar.CurrentVal != 2)
		{bar.CurrentVal -=0.1f;}
		else if(houseLevel == 21 && bar.CurrentVal-0.03>0  && bar.CurrentVal != 2)
		{bar.CurrentVal -=0.13f;}
		else if(houseLevel == 22 && bar.CurrentVal-0.03>0  && bar.CurrentVal != 2)
		{bar.CurrentVal -=0.16f;}
		else if(houseLevel == 23 && bar.CurrentVal-0.03>0  && bar.CurrentVal != 2)
		{bar.CurrentVal -=0.17f;}
		else if(houseLevel == 24 && bar.CurrentVal-0.03>0  && bar.CurrentVal != 2)
		{bar.CurrentVal -=0.176f;}
		else if(houseLevel == 25 && bar.CurrentVal-0.03>0  && bar.CurrentVal != 2)
		{click.gameObject.SetActive(false);
		nope.gameObject.SetActive(true);
		nopeText.text = "MAX";
		}

		if(bar.CurrentVal <= 0.01){
			pumpkinAnimator.SetTrigger("idle");
		}
		if(bar.CurrentVal>0.01 && navigationTime>=50 && navigationTime<65)
			{pumpkinAnimator.SetTrigger("down");
			}
		else if(navigationTime>65){
			navigationTime = 0;
		}
		else if(navigationTime<50)
		{
			navigationTime+=1;
		}

		if(bar.CurrentVal == 2 && isHolding == false){
			MainMenu.Instance.AudioSource.PlayOneShot(SoundManager.Instance.Win3);
			isHolding = true;
			houseLevel+=1;
			if(PlayerPrefs.GetInt("labIntroDone") == 2 || PlayerPrefs.GetInt("labIntroDone") == 3)
			{
				directionsHouseAnim.SetTrigger("next1");
				directionsHouseText.text = "";
				Invoke("changeToIdle",1.0f);
				PlayerPrefs.SetInt("labIntroDone",4);
				Invoke("turnOnBtn",1.5f);
			}
			houseLevelText.text = houseLevel.ToString();
			leveltxt.SetTrigger("increase");
			MainMenu.Instance.AudioSource.PlayOneShot(SoundManager.Instance.Hit2);
			housePoint+=120;
			housePointText.text = housePoint.ToString();
			//goldRain.Play();
			PlayerPrefs.SetInt("HouseLevel",houseLevel);
			PlayerPrefs.SetInt("HouseHealth",(int)housePoint);
			click.interactable = false;
			Invoke("startAgain",1.8f);
		}

		if(gameLevel <= 4 && houseLevel <=1)
			click.gameObject.SetActive(true);
		else if(gameLevel == 5 && houseLevel<=2)
			click.gameObject.SetActive(true);
		else if(gameLevel == 6 && houseLevel<=3)
			click.gameObject.SetActive(true);
		else if(gameLevel == 7 && houseLevel<=4)
			click.gameObject.SetActive(true);
		else if(gameLevel == 8 && houseLevel<=5)
			click.gameObject.SetActive(true);
		else if(gameLevel == 9 && houseLevel<=6)
			click.gameObject.SetActive(true);
		else if(gameLevel == 10 && houseLevel<=7)
			click.gameObject.SetActive(true);
		else if(gameLevel == 11 && houseLevel<=8)
			click.gameObject.SetActive(true);
		else if(gameLevel == 12 && houseLevel<=9)
			click.gameObject.SetActive(true);
		else if(gameLevel == 13 && houseLevel<=10)
			click.gameObject.SetActive(true);
		else if(gameLevel == 14 && houseLevel<=11)
			click.gameObject.SetActive(true);
		else if(gameLevel == 15 && houseLevel<=12)
			click.gameObject.SetActive(true);
		else if(gameLevel == 16 && houseLevel<=13)
			click.gameObject.SetActive(true);
		else if(gameLevel == 17 && houseLevel<=14)
			click.gameObject.SetActive(true);
		else if(gameLevel == 18 && houseLevel<=15)
			click.gameObject.SetActive(true);
		else if(gameLevel == 19 && houseLevel<=16)
			click.gameObject.SetActive(true);
		else if(gameLevel == 20 && houseLevel<=17)
			click.gameObject.SetActive(true);
		else if(gameLevel == 21 && houseLevel<=18)
			click.gameObject.SetActive(true);
		else if(gameLevel == 22 && houseLevel<=19)
			click.gameObject.SetActive(true);
		else if(gameLevel == 23 && houseLevel<=20)
			click.gameObject.SetActive(true);
		else if(gameLevel == 24 && houseLevel<=21)
			click.gameObject.SetActive(true);
		else if(gameLevel == 25 && houseLevel<=22)
			click.gameObject.SetActive(true);
		else if(gameLevel == 26 && houseLevel<=23)
			click.gameObject.SetActive(true);
		else if(gameLevel >= 27 && houseLevel<=24)
			click.gameObject.SetActive(true);
		else{
			nope.gameObject.SetActive(true);
			click.gameObject.SetActive(false);
		}
	}

	[SerializeField]
	private Text nopeText;

	public void changeToIdle()
	{
		directionsHouseText.text = "Later you can purchase stronger clicks to make it easier to fill the bar!";
		directionsHouseAnim.SetTrigger("idle3");
	}

	public void turnOnBtn()
	{
		houseTapToContinue.gameObject.SetActive(true);
		directionsHouseText.gameObject.SetActive(true);
	}

	private ParticleSystem goldRain;


	public void startAgain()
	{
		houseLevelTextAnim.SetTrigger("increase");
		MainMenu.Instance.AudioSource.PlayOneShot(SoundManager.Instance.Hit1);
		bar.CurrentVal = 0;
		click.interactable = true;
		isHolding = false;
	}

	[SerializeField]
	private GameObject HealthLABmenu;

	[SerializeField]
	private GameObject EnergyLABmenu;

	public void houseikAppear()
	{
		houseBckg.gameObject.SetActive(true);
		Invoke("idle",0.2f);
	}
	public void idle()
	{
		houseBckgAnim.SetTrigger("idle");
		
	}

	[SerializeField]
	private Image lockedDoor;
	[SerializeField]
	private Image angelInLab;

	public void LabHealth(){
		speedUpObj.SetActive(false);
		MainMenu.Instance.AudioSource.PlayOneShot(SoundManager.Instance.Click3);
		if(!HealthLABmenu.activeSelf && (EnergyLABmenu.activeSelf)){
			
			HealthLABmenu.SetActive(true);
			if(PlayerPrefs.GetInt("labIntroDone")==1)
			{
				lockedDoor.gameObject.SetActive(true);
				houseBckg.gameObject.SetActive(false);
				houseHealthPointer.gameObject.SetActive(false);
				angelInLab.gameObject.SetActive(true);
			}
			else if(PlayerPrefs.GetInt("labIntroDone")==2 || PlayerPrefs.GetInt("labIntroDone")==3 || PlayerPrefs.GetInt("labIntroDone")==4 || PlayerPrefs.GetInt("labIntroDone")==5)
			{
				lockedDoor.gameObject.SetActive(false);
				houseBckg.gameObject.SetActive(true);
				houseBckgAnim.SetTrigger("idle");
			}
			EnergyLABmenu.SetActive(false);
			
		}
	}

	public void LabEnergy(){
		houseBckg.gameObject.SetActive(false);
		MainMenu.Instance.AudioSource.PlayOneShot(SoundManager.Instance.Click3);
		if(!EnergyLABmenu.activeSelf && (HealthLABmenu.activeSelf)){
			HealthLABmenu.SetActive(false);
			EnergyLABmenu.SetActive(true);
		}
		else if(!EnergyLABmenu.activeSelf && speedUpObj.activeSelf)
		{
			EnergyLABmenu.SetActive(true);
			speedUpObj.SetActive(false);
		}
	}

	[SerializeField]
	private GameObject speedUpObj;

	[SerializeField]
	private Text numOf5min;
	private int min5;
	[SerializeField]
	private Text numOf10min;
	private int min10;
	[SerializeField]
	private Text numOf15min;
	private int min15;
	[SerializeField]
	private Text numOf30min;
	private int min30;
	[SerializeField]
	private Text numOf60min;
	private int min60;
	[SerializeField]
	private Text numOf3hrs;
	private int hrs3;


	public void openSpeedUp(){
		MainMenu.Instance.AudioSource.PlayOneShot(SoundManager.Instance.Click3);
		HealthLABmenu.SetActive(false);
		EnergyLABmenu.SetActive(true);
		speedUpObj.SetActive(true);

		numOf5min.text = "Have: "+PlayerPrefs.GetInt("5min").ToString();
		numOf10min.text = "Have: "+PlayerPrefs.GetInt("10min").ToString();
		numOf15min.text = "Have: "+PlayerPrefs.GetInt("15min").ToString();
		numOf30min.text = "Have: "+PlayerPrefs.GetInt("30min").ToString();
		numOf60min.text = "Have: "+PlayerPrefs.GetInt("60min").ToString();
		numOf3hrs.text = "Have: "+PlayerPrefs.GetInt("3hrs").ToString();

		min5 = PlayerPrefs.GetInt("5min");
		min10 = PlayerPrefs.GetInt("10min");
		min15 = PlayerPrefs.GetInt("15min");
		min30 = PlayerPrefs.GetInt("30min");
		min60 = PlayerPrefs.GetInt("60min");
		hrs3 = PlayerPrefs.GetInt("3hrs");
	}

	public void closeSpeedUp(){
		MainMenu.Instance.AudioSource.PlayOneShot(SoundManager.Instance.Click5);
		EnergyLABmenu.SetActive(true);
		speedUpObj.SetActive(false);
	}

	[SerializeField]
	private Image areYouSure;

	public void no()
	{
		areYouSure.gameObject.SetActive(false);
	}

	public void yes()
	{
		LoadingScreenManager.LoadScene(4);
	}


	public void use5Min()
	{
		if(min5 > 0)
		{	MainMenu.Instance.AudioSource.PlayOneShot(SoundManager.Instance.UseSpeedUp);
			numOf5minUsed+=1;
			PlayerPrefs.SetInt("5minUsedLab",numOf5minUsed);
			min5-=1;
			PlayerPrefs.SetInt("5min",min5);
			numOf5min.text = "Have: "+PlayerPrefs.GetInt("5min").ToString();
			if(isResearchingTap == true)
			{tapEnergyBar.CurrentVal -=300;}
			else if(isResearchingMaxEnergy == true)
			{maxEnergyBar.CurrentVal -=300;}
		}
		else{
			MainMenu.Instance.AudioSource.PlayOneShot(SoundManager.Instance.Click6);
			areYouSure.gameObject.SetActive(true);
		}
	}

	public void use10Min()
	{
		if(min10 > 0)
		{	MainMenu.Instance.AudioSource.PlayOneShot(SoundManager.Instance.UseSpeedUp);
			numOf10minUsed+=1;
			PlayerPrefs.SetInt("10minUsedLab",numOf10minUsed);
			min10-=1;
			PlayerPrefs.SetInt("10min",min10);
			numOf10min.text = "Have: "+PlayerPrefs.GetInt("10min").ToString();
			if(isResearchingTap == true)
			{tapEnergyBar.CurrentVal -=600;}
			else if(isResearchingMaxEnergy == true)
			{maxEnergyBar.CurrentVal -=600;}
		}
		else{
			MainMenu.Instance.AudioSource.PlayOneShot(SoundManager.Instance.Click6);
			areYouSure.gameObject.SetActive(true);
		}
	}

	public void use15Min()
	{
		if(min15 > 0)
		{	MainMenu.Instance.AudioSource.PlayOneShot(SoundManager.Instance.UseSpeedUp);
			numOf15minUsed+=1;
			PlayerPrefs.SetInt("15minUsedLab",numOf15minUsed);
			min15-=1;
			PlayerPrefs.SetInt("15min",min15);
			numOf15min.text = "Have: "+PlayerPrefs.GetInt("15min").ToString();
			if(isResearchingTap == true)
			{tapEnergyBar.CurrentVal -=900;}
			else if(isResearchingMaxEnergy == true)
			{maxEnergyBar.CurrentVal -=900;}
		}
		else{
			MainMenu.Instance.AudioSource.PlayOneShot(SoundManager.Instance.Click6);
			areYouSure.gameObject.SetActive(true);
		}
	}

	public void use30Min()
	{
		if(min30 > 0)
		{	MainMenu.Instance.AudioSource.PlayOneShot(SoundManager.Instance.UseSpeedUp);
			numOf30minUsed+=1;
			PlayerPrefs.SetInt("30minUsedLab",numOf30minUsed);
			min30-=1;
			PlayerPrefs.SetInt("30min",min30);
			numOf30min.text = "Have: "+PlayerPrefs.GetInt("30min").ToString();
			if(isResearchingTap == true)
			{tapEnergyBar.CurrentVal -=1800;}
			else if(isResearchingMaxEnergy == true)
			{maxEnergyBar.CurrentVal -=1800;}
		}
		else{
			MainMenu.Instance.AudioSource.PlayOneShot(SoundManager.Instance.Click6);
			areYouSure.gameObject.SetActive(true);
		}
	}

	public void use60Min()
	{
		if(min60 > 0)
		{	MainMenu.Instance.AudioSource.PlayOneShot(SoundManager.Instance.UseSpeedUp);
			numOf60minUsed+=1;
			PlayerPrefs.SetInt("60minUsedLab",numOf60minUsed);
			min60-=1;
			PlayerPrefs.SetInt("60min",min60);
			numOf60min.text = "Have: "+PlayerPrefs.GetInt("60min").ToString();
			if(isResearchingTap == true)
			{tapEnergyBar.CurrentVal -=3600;}
			else if(isResearchingMaxEnergy == true)
			{maxEnergyBar.CurrentVal -=3600;}
		}
		else{
			MainMenu.Instance.AudioSource.PlayOneShot(SoundManager.Instance.Click6);
			areYouSure.gameObject.SetActive(true);
		}
	}

	public void use3hrs()
	{
		if(hrs3 > 0)
		{	MainMenu.Instance.AudioSource.PlayOneShot(SoundManager.Instance.UseSpeedUp);
			numOf3hrsUsed+=1;
			PlayerPrefs.SetInt("3hrsUsedLab",numOf3hrsUsed);
			hrs3-=1;
			PlayerPrefs.SetInt("3hrs",hrs3);
			numOf3hrs.text = "Have: "+PlayerPrefs.GetInt("3hrs").ToString();
			if(isResearchingTap == true)
			{tapEnergyBar.CurrentVal -=10800;}
			else if(isResearchingMaxEnergy == true)
			{maxEnergyBar.CurrentVal -=10800;}
		}
		else{
			MainMenu.Instance.AudioSource.PlayOneShot(SoundManager.Instance.Click6);
			areYouSure.gameObject.SetActive(true);
		}
	}
		
}
