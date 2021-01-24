using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoldierUpgradeTimer : MonoBehaviour {
	/*private int gameLevel;

	[SerializeField]
	private GameObject soldierList;
	[SerializeField]
	private GameObject soldierInventory;
	[SerializeField]
	private GameObject speedUpObj;
	[SerializeField]
	private Button closeBtn;
	[SerializeField]
	private Button s1SpeedUp;
	[SerializeField]
	private Button s2SpeedUp;
	[SerializeField]
	private Button s3SpeedUp;
	[SerializeField]
	private Button s4SpeedUp;
	[SerializeField]
	private Button s5SpeedUp;
	[SerializeField]
	private Button s6SpeedUp;
	[SerializeField]
	private Button s7SpeedUp;
	[SerializeField]
	private Button s8SpeedUp;
	[SerializeField]
	private Button s9SpeedUp;
	[SerializeField]
	private Button s10SpeedUp;
	[SerializeField]
	private Button s11SpeedUp;
	[SerializeField]
	private Button s12SpeedUp;

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


	private int s1Level;
	[SerializeField]
	private Text s1LevelText;
	[SerializeField]
	private ResearchStat s1lvl1;
	[SerializeField]
	private ResearchHealthBar s1bar;
	[SerializeField]
	private Button s1button;
	private bool isUpgradingS1= false;
	[SerializeField]
	private Image s1LevelInidcator;
	[SerializeField]
	private Text s1health;
	[SerializeField]
	private Text s1healthNextLevel;
	[SerializeField]
	private Text s1energy;
	[SerializeField]
	private Text s1energyNextLevel;
	[SerializeField]
	private Text s1bullet;
	[SerializeField]
	private Text s1bulletNextLevel;
	[SerializeField]
	private Image s1HealthBar;
	[SerializeField]
	private Image s1EnergyBar;
	[SerializeField]
	private Image s1BulletBar;
	List<int> health1 = new List<int>() { 50,62,74,87,100};
	List<int> energy1 = new List<int>() { 10,9,8,7,6};
	List<int> bullet1 = new List<int>() { 40,45,50,55,60};
	List<int> time1 = new List<int>() { 300,1200,2400,3600};
	private int health;
	private int energy;
	private int bullet;
	private int healthNextLevel;
	private int energyNextLevel;
	private int bulletNextLevel;


	private int s2Level;
	[SerializeField]
	private Text s2LevelText;
	[SerializeField]
	private ResearchStat s2lvl2;
	[SerializeField]
	private ResearchHealthBar s2bar;
	[SerializeField]
	private Button s2button;
	private bool isUpgradingS2= false;
	[SerializeField]
	private Image s2LevelInidcator;
	
	
	List<int> time2List = new List<int>() { 600,1500,3000,6000};
	private int health2;
	private int energy2;
	private int bullet2;
	private int health2NextLevel;
	private int energy2NextLevel;
	private int bullet2NextLevel;

	private int s3Level;
	[SerializeField]
	private Text s3LevelText;
	[SerializeField]
	private ResearchStat s3lvl2;
	[SerializeField]
	private ResearchHealthBar s3bar;
	[SerializeField]
	private Button s3button;
	private bool isUpgradingS3= false;
	[SerializeField]
	private Image s3LevelInidcator;
	
	
	List<int> time3List = new List<int>() { 720,1320,2880,4680,6300,8400};
	private int health3;
	private int energy3;
	private int bullet3;
	private int health3NextLevel;
	private int energy3NextLevel;
	private int bullet3NextLevel;

	private int s4Level;
	[SerializeField]
	private Text s4LevelText;
	[SerializeField]
	private ResearchStat s4lvl2;
	[SerializeField]
	private ResearchHealthBar s4bar;
	[SerializeField]
	private Button s4button;
	private bool isUpgradingS4= false;
	[SerializeField]
	private Image s4LevelInidcator;
	
	
	List<int> time4List = new List<int>() { 600,1380,2700,4320,5700,7200,8580,10200,23100};
	private int health4;
	private int energy4;
	private int bullet4;
	private int health4NextLevel;
	private int energy4NextLevel;
	private int bullet4NextLevel;

	private int s5Level;
	[SerializeField]
	private Text s5LevelText;
	[SerializeField]
	private ResearchStat s5lvl2;
	[SerializeField]
	private ResearchHealthBar s5bar;
	[SerializeField]
	private Button s5button;
	private bool isUpgradingS5= false;
	[SerializeField]
	private Image s5LevelInidcator;
	
	List<int> time5List = new List<int>() { 900,1560,3600,6300};
	private int health5;
	private int energy5;
	private int bullet5;
	private int health5NextLevel;
	private int energy5NextLevel;
	private int bullet5NextLevel;

	private int s6Level;
	[SerializeField]
	private Text s6LevelText;
	[SerializeField]
	private ResearchStat s6lvl2;
	[SerializeField]
	private ResearchHealthBar s6bar;
	[SerializeField]
	private Button s6button;
	private bool isUpgradingS6= false;
	[SerializeField]
	private Image s6LevelInidcator;
	
	List<int> time6List = new List<int>() { 900,1920,4380,7200};
	private int health6;
	private int energy6;
	private int bullet6;
	private int health6NextLevel;
	private int energy6NextLevel;
	private int bullet6NextLevel;

	private int s7Level;
	[SerializeField]
	private Text s7LevelText;
	[SerializeField]
	private ResearchStat s7lvl2;
	[SerializeField]
	private ResearchHealthBar s7bar;
	[SerializeField]
	private Button s7button;
	private bool isUpgradingS7= false;
	[SerializeField]
	private Image s7LevelInidcator;

	List<int> time7List = new List<int>() { 720,1380,2880,4800,6300,15900};
	private int health7;
	private int energy7;
	private int bullet7;
	private int health7NextLevel;
	private int energy7NextLevel;
	private int bullet7NextLevel;

	private int s8Level;
	[SerializeField]
	private Text s8LevelText;
	[SerializeField]
	private ResearchStat s8lvl2;
	[SerializeField]
	private ResearchHealthBar s8bar;
	[SerializeField]
	private Button s8button;
	private bool isUpgradingS8= false;
	[SerializeField]
	private Image s8LevelInidcator;
	
	List<int> time8List = new List<int>() { 600,1260,2200,3600,5100,7200,900,10800,12600};
	private int health8;
	private int energy8;
	private int bullet8;
	private int health8NextLevel;
	private int energy8NextLevel;
	private int bullet8NextLevel;

	private int s9Level;
	[SerializeField]
	private Text s9LevelText;
	[SerializeField]
	private ResearchStat s9lvl2;
	[SerializeField]
	private ResearchHealthBar s9bar;
	[SerializeField]
	private Button s9button;
	private bool isUpgradingS9= false;
	[SerializeField]
	private Image s9LevelInidcator;
	
	List<int> time9List = new List<int>() { 7200,12600};
	private int bullet9;
	private int bullet9NextLevel;

//Pumpkin
	private int s10Level;
	[SerializeField]
	private Text s10LevelText;
	[SerializeField]
	private ResearchStat s10lvl2;
	[SerializeField]
	private ResearchHealthBar s10bar;
	[SerializeField]
	private Button s10button;
	private bool isUpgradingS10= false;
	[SerializeField]
	private Image s10LevelInidcator;
	
	List<int> time10List = new List<int>() { 19800};
	private int bullet10;
	private int bullet10NextLevel;
//Skully
	private int s11Level;
	[SerializeField]
	private Text s11LevelText;
	[SerializeField]
	private ResearchStat s11lvl2;
	[SerializeField]
	private ResearchHealthBar s11bar;
	[SerializeField]
	private Button s11button;
	private bool isUpgradingS11= false;
	[SerializeField]
	private Image s11LevelInidcator;
	
	List<int> time11List = new List<int>() { 8100,12600};
	private int bullet11;
	private int bullet11NextLevel;

	[SerializeField]
	private ResearchStat s12;
	[SerializeField]
	private ResearchHealthBar s12bar;
	[SerializeField]
	private Button s12button;
	private bool isUpgradingS12= false;

	private Animator s1healthAnim;
	private Animator s1energyAnim;
	private Animator s1bulletAnim;
	private Animator s2healthAnim;
	private Animator s2energyAnim;
	private Animator s2bulletAnim;
	private Animator s3healthAnim;
	private Animator s3energyAnim;
	private Animator s3bulletAnim;
	private Animator s4healthAnim;
	private Animator s4energyAnim;
	private Animator s4bulletAnim;
	private Animator s5healthAnim;
	private Animator s5energyAnim;
	private Animator s5bulletAnim;
	private Animator s6healthAnim;
	private Animator s6energyAnim;
	private Animator s6bulletAnim;
	private Animator s7healthAnim;
	private Animator s7energyAnim;
	private Animator s7bulletAnim;
	private Animator s8healthAnim;
	private Animator s8energyAnim;
	private Animator s8bulletAnim;
	private Animator s9bulletAnim;
	private Animator s10bulletAnim;
	private Animator s11bulletAnim;

	private Animator nexts1healthAnim;
	private Animator nexts1energyAnim;
	private Animator nexts1bulletAnim;
	private Animator nexts2healthAnim;
	private Animator nexts2energyAnim;
	private Animator nexts2bulletAnim;
	private Animator nexts3healthAnim;
	private Animator nexts3energyAnim;
	private Animator nexts3bulletAnim;
	private Animator nexts4healthAnim;
	private Animator nexts4energyAnim;
	private Animator nexts4bulletAnim;
	private Animator nexts5healthAnim;
	private Animator nexts5energyAnim;
	private Animator nexts5bulletAnim;
	private Animator nexts6healthAnim;
	private Animator nexts6energyAnim;
	private Animator nexts6bulletAnim;
	private Animator nexts7healthAnim;
	private Animator nexts7energyAnim;
	private Animator nexts7bulletAnim;
	private Animator nexts8healthAnim;
	private Animator nexts8energyAnim;
	private Animator nexts8bulletAnim;
	private Animator nexts9bulletAnim;
	private Animator nexts10bulletAnim;
	private Animator nexts11bulletAnim;

	private Animator s1LevelTextAnim;
	private Animator s2LevelTextAnim;
	private Animator s3LevelTextAnim;
	private Animator s4LevelTextAnim;
	private Animator s5LevelTextAnim;
	private Animator s6LevelTextAnim;
	private Animator s7LevelTextAnim;
	private Animator s8LevelTextAnim;
	private Animator s9LevelTextAnim;
	private Animator s10LevelTextAnim;
	private Animator s11LevelTextAnim;

	[SerializeField]
	private Text s1LevelInidcatorText;
	[SerializeField]
	private Text s2LevelInidcatorText;
	[SerializeField]
	private Text s3LevelInidcatorText;
	[SerializeField]
	private Text s4LevelInidcatorText;
	[SerializeField]
	private Text s5LevelInidcatorText;
	[SerializeField]
	private Text s6LevelInidcatorText;
	[SerializeField]
	private Text s7LevelInidcatorText;
	[SerializeField]
	private Text s8LevelInidcatorText;
	[SerializeField]
	private Text s9LevelInidcatorText;
	[SerializeField]
	private Text s10LevelInidcatorText;
	[SerializeField]
	private Text s11LevelInidcatorText;

	[SerializeField]
	private Image s1Max;
	[SerializeField]
	private Image s2Max;
	[SerializeField]
	private Image s3Max;
	[SerializeField]
	private Image s4Max;
	[SerializeField]
	private Image s5Max;
	[SerializeField]
	private Image s6Max;
	[SerializeField]
	private Image s7Max;
	[SerializeField]
	private Image s8Max;
	[SerializeField]
	private Image s9Max;
	[SerializeField]
	private Image s10Max;
	[SerializeField]
	private Image s11Max;

	[SerializeField]
	private Image s1rotator;
	[SerializeField]
	private Image s2rotator;
	[SerializeField]
	private Image s3rotator;
	[SerializeField]
	private Image s4rotator;
	[SerializeField]
	private Image s5rotator;
	[SerializeField]
	private Image s6rotator;
	[SerializeField]
	private Image s7rotator;
	[SerializeField]
	private Image s8rotator;
	[SerializeField]
	private Image s9rotator;
	[SerializeField]
	private Image s10rotator;
	[SerializeField]
	private Image s11rotator;
	[SerializeField]
	private Image s12rotator;

	[SerializeField]
	private Button s3OpenButton;
	[SerializeField]
	private Image s3OpenImage;
	[SerializeField]
	private GameObject s3LvlBar;

	[SerializeField]
	private Button s4OpenButton;
	[SerializeField]
	private Image s4OpenImage;
	[SerializeField]
	private GameObject s4LvlBar;

	[SerializeField]
	private Button s5OpenButton;
	[SerializeField]
	private Image s5OpenImage;
	[SerializeField]
	private GameObject s5LvlBar;

	[SerializeField]
	private Button s6OpenButton;
	[SerializeField]
	private Image s6OpenImage;
	[SerializeField]
	private GameObject s6LvlBar;

	[SerializeField]
	private Button s7OpenButton;
	[SerializeField]
	private Image s7OpenImage;
	[SerializeField]
	private GameObject s7LvlBar;
	
	[SerializeField]
	private Button s8OpenButton;
	[SerializeField]
	private Image s8OpenImage;
	[SerializeField]
	private GameObject s8LvlBar;

	[SerializeField]
	private Button s9OpenButton;
	[SerializeField]
	private Image s9OpenImage;
	[SerializeField]
	private GameObject s9LvlBar;

	[SerializeField]
	private Button s10OpenButton;
	[SerializeField]
	private Image s10OpenImage;
	[SerializeField]
	private GameObject s10LvlBar;

	[SerializeField]
	private Button s11OpenButton;
	[SerializeField]
	private Image s11OpenImage;
	[SerializeField]
	private GameObject s11LvlBar;

	[SerializeField]
	private Button s12OpenButton;
	[SerializeField]
	private Image s12OpenImage;

	[SerializeField]
	private GameObject soldierPage;
	private Animator soldierPageAnim;

	private void Awake(){
		//DontDestroyOnLoad(gameObject);
		s1lvl1.Initialize();
		s2lvl2.Initialize();
		s3lvl2.Initialize();
		s4lvl2.Initialize();
		s5lvl2.Initialize();
		s6lvl2.Initialize();
		s7lvl2.Initialize();
		s8lvl2.Initialize();
		s9lvl2.Initialize();
		s10lvl2.Initialize();
		s11lvl2.Initialize();
		s12.Initialize();
		s3OpenButton.interactable = false;
		s4OpenButton.interactable = false;
		s5OpenButton.interactable = false;
		s6OpenButton.interactable = false;
		s7OpenButton.interactable = false;
		s8OpenButton.interactable = false;
		s9OpenButton.interactable = false;
		s10OpenButton.interactable = false;
		s11OpenButton.interactable = false;
		s12OpenButton.interactable = false;
		s3LvlBar.SetActive(false);
		s4LvlBar.SetActive(false);
		s5LvlBar.SetActive(false);
		s6LvlBar.SetActive(false);
		s7LvlBar.SetActive(false);
		s8LvlBar.SetActive(false);
		s9LvlBar.SetActive(false);
		s10LvlBar.SetActive(false);
		s11LvlBar.SetActive(false);
	}

	[SerializeField]
	private Button s2Btn;
	[SerializeField]
	private Button cancelBtn;
	[SerializeField]
	private Button closeSpeedUpBtn;

	[SerializeField]
	private Image s12Max;

	void Start () {
		soldierPageAnim = soldierPage.GetComponent<Animator>();
		directionsAnim = directions.GetComponent<Animator>();
		//PlayerPrefs.SetInt("armyIntroDone", 0);
		if(PlayerPrefs.HasKey("armyIntroDone")==false)
			PlayerPrefs.SetInt("armyIntroDone", 0);
		if(PlayerPrefs.GetInt("armyIntroDone") == 0)
		{
			directions.SetActive(true);
			directionsText.text = "Press Upgrade!";
			s2Btn.interactable = false;
			cancelBtn.interactable = false;
			closeSpeedUpBtn.interactable = false;
			closeBtn.interactable = false;
			PlayerPrefs.SetInt("5min",2);
		}
		
		
		
		
		if(PlayerPrefs.HasKey("knightUnlocked")==false)
			PlayerPrefs.SetInt("knightUnlocked",0);
		if(PlayerPrefs.GetInt("knightUnlocked")==1)
		{
			s12button.gameObject.SetActive(false);
			s12Max.gameObject.SetActive(true);
		}


		if(PlayerPrefs.GetInt("end")==1){
			PlayerPrefs.SetInt("s1level",1);
			PlayerPrefs.SetInt("time1Lvl2",time1[0]);
			PlayerPrefs.SetInt("s1Health",health1[0]);
			PlayerPrefs.SetInt("s1Energy",energy1[0]);
			PlayerPrefs.SetInt("s1Bullet",bullet1[0]);
			PlayerPrefs.SetInt("s1HealthNext",health1[1]);
			PlayerPrefs.SetInt("s1EnergyNext",energy1[1]);
			PlayerPrefs.SetInt("s1BulletNext",bullet1[1]);

			PlayerPrefs.SetInt("s2level",1);
			PlayerPrefs.SetInt("time2Lvl2",time2List[0]);
			PlayerPrefs.SetInt("s2Health",health2List[0]);
			PlayerPrefs.SetInt("s2Energy",energy2List[0]);
			PlayerPrefs.SetInt("s2Bullet",bullet2List[0]);
			PlayerPrefs.SetInt("s2HealthNext",health2List[1]);
			PlayerPrefs.SetInt("s2EnergyNext",energy2List[1]);
			PlayerPrefs.SetInt("s2BulletNext",bullet2List[1]);

			PlayerPrefs.SetInt("s3level",1);
			PlayerPrefs.SetInt("time3Lvl2",time3List[0]);
			PlayerPrefs.SetInt("s3Health",health3List[0]);
			PlayerPrefs.SetInt("s3Energy",energy3List[0]);
			PlayerPrefs.SetInt("s3Bullet",bullet3List[0]);
			PlayerPrefs.SetInt("s3HealthNext",health3List[1]);
			PlayerPrefs.SetInt("s3EnergyNext",energy3List[1]);
			PlayerPrefs.SetInt("s3BulletNext",bullet3List[1]);

			PlayerPrefs.SetInt("s4level",1);
			PlayerPrefs.SetInt("time4Lvl2",time4List[0]);
			PlayerPrefs.SetInt("s4Health",health4List[0]);
			PlayerPrefs.SetInt("s4Energy",energy4List[0]);
			PlayerPrefs.SetInt("s4Bullet",bullet4List[0]);
			PlayerPrefs.SetInt("s4HealthNext",health4List[1]);
			PlayerPrefs.SetInt("s4EnergyNext",energy4List[1]);
			PlayerPrefs.SetInt("s4BulletNext",bullet4List[1]);

			PlayerPrefs.SetInt("s5level",1);
			PlayerPrefs.SetInt("time5Lvl2",time5List[0]);
			PlayerPrefs.SetInt("s5Health",health5List[0]);
			PlayerPrefs.SetInt("s5Energy",energy5List[0]);
			PlayerPrefs.SetInt("s5Bullet",bullet5List[0]);
			PlayerPrefs.SetInt("s5HealthNext",health5List[1]);
			PlayerPrefs.SetInt("s5EnergyNext",energy5List[1]);
			PlayerPrefs.SetInt("s5BulletNext",bullet5List[1]);

			PlayerPrefs.SetInt("s6level",1);
			PlayerPrefs.SetInt("time6Lvl2",time6List[0]);
			PlayerPrefs.SetInt("s6Health",health6List[0]);
			PlayerPrefs.SetInt("s6Energy",energy6List[0]);
			PlayerPrefs.SetInt("s6Bullet",bullet6List[0]);
			PlayerPrefs.SetInt("s6HealthNext",health6List[1]);
			PlayerPrefs.SetInt("s6EnergyNext",energy6List[1]);
			PlayerPrefs.SetInt("s6BulletNext",bullet6List[1]);

			PlayerPrefs.SetInt("s7level",1);
			PlayerPrefs.SetInt("time7Lvl2",time7List[0]);
			PlayerPrefs.SetInt("s7Health",health7List[0]);
			PlayerPrefs.SetInt("s7Energy",energy7List[0]);
			PlayerPrefs.SetInt("s7Bullet",bullet7List[0]);
			PlayerPrefs.SetInt("s7HealthNext",health7List[1]);
			PlayerPrefs.SetInt("s7EnergyNext",energy7List[1]);
			PlayerPrefs.SetInt("s7BulletNext",bullet7List[1]);

			PlayerPrefs.SetInt("s8level",1);
			PlayerPrefs.SetInt("time8Lvl2",time8List[0]);
			PlayerPrefs.SetInt("s8Health",health8List[0]);
			PlayerPrefs.SetInt("s8Energy",energy8List[0]);
			PlayerPrefs.SetInt("s8Bullet",bullet8List[0]);
			PlayerPrefs.SetInt("s8HealthNext",health8List[1]);
			PlayerPrefs.SetInt("s8EnergyNext",energy8List[1]);
			PlayerPrefs.SetInt("s8BulletNext",bullet8List[1]);

			PlayerPrefs.SetInt("s9level",1);
			PlayerPrefs.SetInt("time9Lvl2",time9List[0]);
			PlayerPrefs.SetInt("s9Bullet",bullet9List[0]);
			PlayerPrefs.SetInt("s9BulletNext",bullet9List[1]);

			PlayerPrefs.SetInt("s10level",1);
			PlayerPrefs.SetInt("time10Lvl2",time10List[0]);
			PlayerPrefs.SetInt("s10Bullet",bullet10List[0]);
			PlayerPrefs.SetInt("s10BulletNext",bullet10List[1]);

			PlayerPrefs.SetInt("s11level",1);
			PlayerPrefs.SetInt("time11Lvl2",time11List[0]);
			PlayerPrefs.SetInt("s11Bullet",bullet11List[0]);
			PlayerPrefs.SetInt("s11BulletNext",bullet11List[1]);
		}
		
		s1Level = PlayerPrefs.GetInt("s1level");
		s2Level = PlayerPrefs.GetInt("s2level");
		s3Level = PlayerPrefs.GetInt("s3level");
		s4Level = PlayerPrefs.GetInt("s4level");
		s5Level = PlayerPrefs.GetInt("s5level");
		s6Level = PlayerPrefs.GetInt("s6level");
		s7Level = PlayerPrefs.GetInt("s7level");
		s8Level = PlayerPrefs.GetInt("s8level");
		s9Level = PlayerPrefs.GetInt("s9level");
		s10Level = PlayerPrefs.GetInt("s10level");
		s11Level = PlayerPrefs.GetInt("s11level");

		s1LevelText.text = "Level\n"+ s1Level.ToString();
		s2LevelText.text = "Level\n"+ s2Level.ToString();
		s3LevelText.text = "Level\n"+ s3Level.ToString();
		s4LevelText.text = "Level\n"+ s4Level.ToString();
		s5LevelText.text = "Level\n"+ s5Level.ToString();
		s6LevelText.text = "Level\n"+ s6Level.ToString();
		s7LevelText.text = "Level\n"+ s7Level.ToString();
		s8LevelText.text = "Level\n"+ s8Level.ToString();
		s9LevelText.text = "Level\n"+ s9Level.ToString();
		s10LevelText.text = "Level\n"+ s10Level.ToString();
		s11LevelText.text = "Level\n"+ s11Level.ToString();

		s1lvl1.MaxVal = PlayerPrefs.GetInt("time1Lvl2");
		s2lvl2.MaxVal = PlayerPrefs.GetInt("time2Lvl2");
		s3lvl2.MaxVal = PlayerPrefs.GetInt("time3Lvl2");
		s4lvl2.MaxVal = PlayerPrefs.GetInt("time4Lvl2");
		s5lvl2.MaxVal = PlayerPrefs.GetInt("time5Lvl2");
		s6lvl2.MaxVal = PlayerPrefs.GetInt("time6Lvl2");
		s7lvl2.MaxVal = PlayerPrefs.GetInt("time7Lvl2");
		s8lvl2.MaxVal = PlayerPrefs.GetInt("time8Lvl2");
		s9lvl2.MaxVal = PlayerPrefs.GetInt("time9Lvl2");
		s10lvl2.MaxVal = PlayerPrefs.GetInt("time10Lvl2");
		s11lvl2.MaxVal = PlayerPrefs.GetInt("time11Lvl2");
		s12.MaxVal = 28800;
		s1lvl1.CurrentVal = PlayerPrefs.GetInt("time1Lvl2");
		s2lvl2.CurrentVal = PlayerPrefs.GetInt("time2Lvl2");
		s3lvl2.CurrentVal = PlayerPrefs.GetInt("time3Lvl2");
		s4lvl2.CurrentVal = PlayerPrefs.GetInt("time4Lvl2");
		s5lvl2.CurrentVal = PlayerPrefs.GetInt("time5Lvl2");
		s6lvl2.CurrentVal = PlayerPrefs.GetInt("time6Lvl2");
		s7lvl2.CurrentVal = PlayerPrefs.GetInt("time7Lvl2");
		s8lvl2.CurrentVal = PlayerPrefs.GetInt("time8Lvl2");
		s9lvl2.CurrentVal = PlayerPrefs.GetInt("time9Lvl2");
		s10lvl2.CurrentVal = PlayerPrefs.GetInt("time10Lvl2");
		s11lvl2.CurrentVal = PlayerPrefs.GetInt("time11Lvl2");	
		s12.CurrentVal = 28800;

		numOf5minUsed = PlayerPrefs.GetInt("5minUsed");
		numOf10minUsed = PlayerPrefs.GetInt("10minUsed");
		numOf15minUsed = PlayerPrefs.GetInt("15minUsed");
		numOf30minUsed = PlayerPrefs.GetInt("30minUsed");
		numOf60minUsed = PlayerPrefs.GetInt("60minUsed");
		numOf3hrsUsed = PlayerPrefs.GetInt("3hrsUsed");
		if(PlayerPrefs.GetInt("upgrading") == 1)
		{
			isUpgradingS1 = true;
			s1button.gameObject.SetActive(false);
			s1bar.gameObject.SetActive(true);
			s1lvl1.CurrentVal -= TimeMaster.instance.CheckDate()+(numOf5minUsed*300)+(numOf10minUsed*600)+(numOf15minUsed*900)+(numOf30minUsed*1800)+(numOf60minUsed*3600)+(numOf3hrsUsed*10800);
		}
		else if(PlayerPrefs.GetInt("upgrading") == 2)
		{
			isUpgradingS2 = true;
			s2button.gameObject.SetActive(false);
			s2bar.gameObject.SetActive(true);
			s2lvl2.CurrentVal -= TimeMaster.instance.CheckDate()+(numOf5minUsed*300)+(numOf10minUsed*600)+(numOf15minUsed*900)+(numOf30minUsed*1800)+(numOf60minUsed*3600)+(numOf3hrsUsed*10800);
		}
		else if(PlayerPrefs.GetInt("upgrading") == 3)
		{
			isUpgradingS3 = true;
			s3button.gameObject.SetActive(false);
			s3bar.gameObject.SetActive(true);
			s3lvl2.CurrentVal -= TimeMaster.instance.CheckDate()+(numOf5minUsed*300)+(numOf10minUsed*600)+(numOf15minUsed*900)+(numOf30minUsed*1800)+(numOf60minUsed*3600)+(numOf3hrsUsed*10800);
		}
		else if(PlayerPrefs.GetInt("upgrading") == 4)
		{
			isUpgradingS4 = true;
			s4button.gameObject.SetActive(false);
			s4bar.gameObject.SetActive(true);
			s4lvl2.CurrentVal -= TimeMaster.instance.CheckDate()+(numOf5minUsed*300)+(numOf10minUsed*600)+(numOf15minUsed*900)+(numOf30minUsed*1800)+(numOf60minUsed*3600)+(numOf3hrsUsed*10800);
		}
		else if(PlayerPrefs.GetInt("upgrading") == 5)
		{
			isUpgradingS5 = true;
			s5button.gameObject.SetActive(false);
			s5bar.gameObject.SetActive(true);
			s5lvl2.CurrentVal -= TimeMaster.instance.CheckDate()+(numOf5minUsed*300)+(numOf10minUsed*600)+(numOf15minUsed*900)+(numOf30minUsed*1800)+(numOf60minUsed*3600)+(numOf3hrsUsed*10800);
		}
		else if(PlayerPrefs.GetInt("upgrading") == 6)
		{
			isUpgradingS6 = true;
			s6button.gameObject.SetActive(false);
			s6bar.gameObject.SetActive(true);
			s6lvl2.CurrentVal -= TimeMaster.instance.CheckDate()+(numOf5minUsed*300)+(numOf10minUsed*600)+(numOf15minUsed*900)+(numOf30minUsed*1800)+(numOf60minUsed*3600)+(numOf3hrsUsed*10800);
		}
		else if(PlayerPrefs.GetInt("upgrading") == 7)
		{
			isUpgradingS7 = true;
			s7button.gameObject.SetActive(false);
			s7bar.gameObject.SetActive(true);
			s7lvl2.CurrentVal -= TimeMaster.instance.CheckDate()+(numOf5minUsed*300)+(numOf10minUsed*600)+(numOf15minUsed*900)+(numOf30minUsed*1800)+(numOf60minUsed*3600)+(numOf3hrsUsed*10800);
		}
		else if(PlayerPrefs.GetInt("upgrading") == 8)
		{
			isUpgradingS8 = true;
			s8button.gameObject.SetActive(false);
			s8bar.gameObject.SetActive(true);
			s8lvl2.CurrentVal -= TimeMaster.instance.CheckDate()+(numOf5minUsed*300)+(numOf10minUsed*600)+(numOf15minUsed*900)+(numOf30minUsed*1800)+(numOf60minUsed*3600)+(numOf3hrsUsed*10800);
		}
		else if(PlayerPrefs.GetInt("upgrading") == 9)
		{
			isUpgradingS9 = true;
			s9button.gameObject.SetActive(false);
			s9bar.gameObject.SetActive(true);
			s9lvl2.CurrentVal -= TimeMaster.instance.CheckDate()+(numOf5minUsed*300)+(numOf10minUsed*600)+(numOf15minUsed*900)+(numOf30minUsed*1800)+(numOf60minUsed*3600)+(numOf3hrsUsed*10800);
		}
		else if(PlayerPrefs.GetInt("upgrading") == 10)
		{
			isUpgradingS10 = true;
			s10button.gameObject.SetActive(false);
			s10bar.gameObject.SetActive(true);
			s10lvl2.CurrentVal -= TimeMaster.instance.CheckDate()+(numOf5minUsed*300)+(numOf10minUsed*600)+(numOf15minUsed*900)+(numOf30minUsed*1800)+(numOf60minUsed*3600)+(numOf3hrsUsed*10800);
		}
		else if(PlayerPrefs.GetInt("upgrading") == 11)
		{
			isUpgradingS11 = true;
			s11button.gameObject.SetActive(false);
			s11bar.gameObject.SetActive(true);
			s11lvl2.CurrentVal -= TimeMaster.instance.CheckDate()+(numOf5minUsed*300)+(numOf10minUsed*600)+(numOf15minUsed*900)+(numOf30minUsed*1800)+(numOf60minUsed*3600)+(numOf3hrsUsed*10800);
		}	
		else if(PlayerPrefs.GetInt("upgrading") == 12)
		{
			isUpgradingS12 = true;
			s12button.gameObject.SetActive(false);
			s12bar.gameObject.SetActive(true);
			s12.CurrentVal -= TimeMaster.instance.CheckDate()+(numOf5minUsed*300)+(numOf10minUsed*600)+(numOf15minUsed*900)+(numOf30minUsed*1800)+(numOf60minUsed*3600)+(numOf3hrsUsed*10800);
		}	

		health = PlayerPrefs.GetInt("s1Health");
		energy = PlayerPrefs.GetInt("s1Energy");
		bullet = PlayerPrefs.GetInt("s1Bullet");
		health2 = PlayerPrefs.GetInt("s2Health");
		energy2 = PlayerPrefs.GetInt("s2Energy");
		bullet2 = PlayerPrefs.GetInt("s2Bullet");
		health3 = PlayerPrefs.GetInt("s3Health");
		energy3 = PlayerPrefs.GetInt("s3Energy");
		bullet3 = PlayerPrefs.GetInt("s3Bullet");
		health4 = PlayerPrefs.GetInt("s4Health");
		energy4 = PlayerPrefs.GetInt("s4Energy");
		bullet4 = PlayerPrefs.GetInt("s4Bullet");
		health5 = PlayerPrefs.GetInt("s5Health");
		energy5 = PlayerPrefs.GetInt("s5Energy");
		bullet5 = PlayerPrefs.GetInt("s5Bullet");
		health6 = PlayerPrefs.GetInt("s6Health");
		energy6 = PlayerPrefs.GetInt("s6Energy");
		bullet6 = PlayerPrefs.GetInt("s6Bullet");
		health7 = PlayerPrefs.GetInt("s7Health");
		energy7 = PlayerPrefs.GetInt("s7Energy");
		bullet7 = PlayerPrefs.GetInt("s7Bullet");
		health8 = PlayerPrefs.GetInt("s8Health");
		energy8 = PlayerPrefs.GetInt("s8Energy");
		bullet8 = PlayerPrefs.GetInt("s8Bullet");
		bullet9 = PlayerPrefs.GetInt("s9Bullet");
		bullet10 = PlayerPrefs.GetInt("s10Bullet");
		bullet11 = PlayerPrefs.GetInt("s11Bullet");

		healthNextLevel = PlayerPrefs.GetInt("s1HealthNext");
		energyNextLevel = PlayerPrefs.GetInt("s1EnergyNext");
		bulletNextLevel = PlayerPrefs.GetInt("s1BulletNext");
		health2NextLevel = PlayerPrefs.GetInt("s2HealthNext");
		energy2NextLevel = PlayerPrefs.GetInt("s2EnergyNext");
		bullet2NextLevel = PlayerPrefs.GetInt("s2BulletNext");
		health3NextLevel = PlayerPrefs.GetInt("s3HealthNext");
		energy3NextLevel = PlayerPrefs.GetInt("s3EnergyNext");
		bullet3NextLevel = PlayerPrefs.GetInt("s3BulletNext");
		health4NextLevel = PlayerPrefs.GetInt("s4HealthNext");
		energy4NextLevel = PlayerPrefs.GetInt("s4EnergyNext");
		bullet4NextLevel = PlayerPrefs.GetInt("s4BulletNext");
		health5NextLevel = PlayerPrefs.GetInt("s5HealthNext");
		energy5NextLevel = PlayerPrefs.GetInt("s5EnergyNext");
		bullet5NextLevel = PlayerPrefs.GetInt("s5BulletNext");
		health6NextLevel = PlayerPrefs.GetInt("s6HealthNext");
		energy6NextLevel = PlayerPrefs.GetInt("s6EnergyNext");
		bullet6NextLevel = PlayerPrefs.GetInt("s6BulletNext");
		health7NextLevel = PlayerPrefs.GetInt("s7HealthNext");
		energy7NextLevel = PlayerPrefs.GetInt("s7EnergyNext");
		bullet7NextLevel = PlayerPrefs.GetInt("s7BulletNext");
		health8NextLevel = PlayerPrefs.GetInt("s8HealthNext");
		energy8NextLevel = PlayerPrefs.GetInt("s8EnergyNext");
		bullet8NextLevel = PlayerPrefs.GetInt("s8BulletNext");
		bullet9NextLevel = PlayerPrefs.GetInt("s9BulletNext");
		bullet10NextLevel = PlayerPrefs.GetInt("s10BulletNext");
		bullet11NextLevel = PlayerPrefs.GetInt("s11BulletNext");

		s1health.text = health.ToString();
		s1energy.text = energy.ToString();
		s1bullet.text = bullet.ToString();
		s1healthNextLevel.text = healthNextLevel.ToString();
		s1energyNextLevel.text = energyNextLevel.ToString();
		s1bulletNextLevel.text = bulletNextLevel.ToString();
		s1HealthBar.fillAmount = (float)(health)/(float)(healthNextLevel+30);
		s1EnergyBar.fillAmount = (float)(energyNextLevel)/(float)(energy+4);
		s1BulletBar.fillAmount = (float)(bullet)/(float)(bulletNextLevel+8);

		s2health.text = health2.ToString();
		s2energy.text = energy2.ToString();
		s2bullet.text = bullet2.ToString();
		s2healthNextLevel.text = health2NextLevel.ToString();
		s2energyNextLevel.text = energy2NextLevel.ToString();
		s2bulletNextLevel.text = bullet2NextLevel.ToString();
		s2HealthBar.fillAmount = (float)(health2)/(float)(health2NextLevel+40);
		s2EnergyBar.fillAmount = (float)(energy2NextLevel)/(float)(energy2+9);
		s2BulletBar.fillAmount = (float)(bullet2)/(float)(bullet2NextLevel+10);
		
		s3health.text = health3.ToString();
		s3energy.text = energy3.ToString();
		s3bullet.text = bullet3.ToString();
		s3healthNextLevel.text = health3NextLevel.ToString();
		s3energyNextLevel.text = energy3NextLevel.ToString();
		s3bulletNextLevel.text = bullet3NextLevel.ToString();
		s3HealthBar.fillAmount = (float)(health3)/(float)(health3NextLevel+50);
		s3EnergyBar.fillAmount = (float)(energy3NextLevel)/(float)(energy3+15);
		s3BulletBar.fillAmount = (float)(bullet3)/(float)(bullet3NextLevel+12);
		
		s4health.text = health4.ToString();
		s4energy.text = energy4.ToString();
		s4bullet.text = bullet4.ToString();
		s4healthNextLevel.text = health4NextLevel.ToString();
		s4energyNextLevel.text = energy4NextLevel.ToString();
		s4bulletNextLevel.text = bullet4NextLevel.ToString();
		s4HealthBar.fillAmount = (float)(health4)/(float)(health4NextLevel+55);
		s4EnergyBar.fillAmount = (float)(energy4NextLevel)/(float)(energy4+20);
		s4BulletBar.fillAmount = (float)(bullet4)/(float)(bullet4NextLevel+16);
		
		s5health.text = health5.ToString();
		s5energy.text = energy5.ToString();
		s5bullet.text = bullet5.ToString();
		s5healthNextLevel.text = health5NextLevel.ToString();
		s5energyNextLevel.text = energy5NextLevel.ToString();
		s5bulletNextLevel.text = bullet5NextLevel.ToString();
		s5HealthBar.fillAmount = (float)(health5)/(float)(health5NextLevel+65);
		s5EnergyBar.fillAmount = (float)(energy5NextLevel)/(float)(energy5+25);
		s5BulletBar.fillAmount = (float)(bullet5)/(float)(bullet5NextLevel+20);

		s6health.text = health6.ToString();
		s6energy.text = energy6.ToString();
		s6bullet.text = bullet6.ToString();
		s6healthNextLevel.text = health6NextLevel.ToString();
		s6energyNextLevel.text = energy6NextLevel.ToString();
		s6bulletNextLevel.text = bullet6NextLevel.ToString();
		s6HealthBar.fillAmount = (float)(health6)/(float)(health6NextLevel+75);
		s6EnergyBar.fillAmount = (float)(energy6NextLevel)/(float)(energy6+30);
		s6BulletBar.fillAmount = (float)(bullet6)/(float)(bullet6NextLevel+25);

		s7health.text = health7.ToString();
		s7energy.text = energy7.ToString();
		s7bullet.text = bullet7.ToString();
		s7healthNextLevel.text = health7NextLevel.ToString();
		s7energyNextLevel.text = energy7NextLevel.ToString();
		s7bulletNextLevel.text = bullet7NextLevel.ToString();
		s7HealthBar.fillAmount = (float)(health7)/(float)(health7NextLevel+80);
		s7EnergyBar.fillAmount = (float)(energy7NextLevel)/(float)(energy7+35);
		s7BulletBar.fillAmount = (float)(bullet7)/(float)(bullet7NextLevel+28);
		
		s8health.text = health8.ToString();
		s8energy.text = energy8.ToString();
		s8bullet.text = bullet8.ToString();
		s8healthNextLevel.text = health8NextLevel.ToString();
		s8energyNextLevel.text = energy8NextLevel.ToString();
		s8bulletNextLevel.text = bullet8NextLevel.ToString();
		s8HealthBar.fillAmount = (float)(health8)/(float)(health8NextLevel+90);
		s8EnergyBar.fillAmount = (float)(energy8NextLevel)/(float)(energy8+40);
		s8BulletBar.fillAmount = (float)(bullet8)/(float)(bullet8NextLevel+31);

		
		s9bullet.text = bullet9.ToString();
		s9bulletNextLevel.text = bullet9NextLevel.ToString();
		s9BulletBar.fillAmount = (float)(bullet9)/(float)(bullet9NextLevel+20);

		s10bullet.text = bullet10.ToString();
		s10bulletNextLevel.text = bullet10NextLevel.ToString();
		s10BulletBar.fillAmount = (float)(bullet10)/(float)(bullet10NextLevel+5);

		s11bullet.text = bullet11.ToString();
		s11bulletNextLevel.text = bullet11NextLevel.ToString();
		s11BulletBar.fillAmount = (float)(bullet11)/(float)(bullet11NextLevel+15);
		

		s1healthAnim = s1health.GetComponent<Animator>();
		s1energyAnim = s1energy.GetComponent<Animator>();
		s1bulletAnim = s1bullet.GetComponent<Animator>();
		s2healthAnim = s2health.GetComponent<Animator>();
		s2energyAnim = s2energy.GetComponent<Animator>();
		s2bulletAnim = s2bullet.GetComponent<Animator>();
		s3healthAnim = s3health.GetComponent<Animator>();
		s3energyAnim = s3energy.GetComponent<Animator>();
		s3bulletAnim = s3bullet.GetComponent<Animator>();
		s4healthAnim = s4health.GetComponent<Animator>();
		s4energyAnim = s4energy.GetComponent<Animator>();
		s4bulletAnim = s4bullet.GetComponent<Animator>();
		s5healthAnim = s5health.GetComponent<Animator>();
		s5energyAnim = s5energy.GetComponent<Animator>();
		s5bulletAnim = s5bullet.GetComponent<Animator>();
		s6healthAnim = s6health.GetComponent<Animator>();
		s6energyAnim = s6energy.GetComponent<Animator>();
		s6bulletAnim = s6bullet.GetComponent<Animator>();
		s7healthAnim = s7health.GetComponent<Animator>();
		s7energyAnim = s7energy.GetComponent<Animator>();
		s7bulletAnim = s7bullet.GetComponent<Animator>();
		s8healthAnim = s8health.GetComponent<Animator>();
		s8energyAnim = s8energy.GetComponent<Animator>();
		s8bulletAnim = s8bullet.GetComponent<Animator>();
		s9bulletAnim = s9bullet.GetComponent<Animator>();
		s10bulletAnim = s10bullet.GetComponent<Animator>();
		s11bulletAnim = s11bullet.GetComponent<Animator>();

		nexts1healthAnim = s1healthNextLevel.GetComponent<Animator>();
		nexts1energyAnim = s1energyNextLevel.GetComponent<Animator>();
		nexts1bulletAnim = s1bulletNextLevel.GetComponent<Animator>();
		nexts2healthAnim = s2healthNextLevel.GetComponent<Animator>();
		nexts2energyAnim = s2energyNextLevel.GetComponent<Animator>();
		nexts2bulletAnim = s2bulletNextLevel.GetComponent<Animator>();
		nexts3healthAnim = s3healthNextLevel.GetComponent<Animator>();
		nexts3energyAnim = s3energyNextLevel.GetComponent<Animator>();
		nexts3bulletAnim = s3bulletNextLevel.GetComponent<Animator>();
		nexts4healthAnim = s4healthNextLevel.GetComponent<Animator>();
		nexts4energyAnim = s4energyNextLevel.GetComponent<Animator>();
		nexts4bulletAnim = s4bulletNextLevel.GetComponent<Animator>();
		nexts5healthAnim = s5healthNextLevel.GetComponent<Animator>();
		nexts5energyAnim = s5energyNextLevel.GetComponent<Animator>();
		nexts5bulletAnim = s5bulletNextLevel.GetComponent<Animator>();
		nexts6healthAnim = s6healthNextLevel.GetComponent<Animator>();
		nexts6energyAnim = s6energyNextLevel.GetComponent<Animator>();
		nexts6bulletAnim = s6bulletNextLevel.GetComponent<Animator>();
		nexts7healthAnim = s7healthNextLevel.GetComponent<Animator>();
		nexts7energyAnim = s7energyNextLevel.GetComponent<Animator>();
		nexts7bulletAnim = s7bulletNextLevel.GetComponent<Animator>();
		nexts8healthAnim = s8healthNextLevel.GetComponent<Animator>();
		nexts8energyAnim = s8energyNextLevel.GetComponent<Animator>();
		nexts8bulletAnim = s8bulletNextLevel.GetComponent<Animator>();
		nexts9bulletAnim = s9bulletNextLevel.GetComponent<Animator>();
		nexts10bulletAnim = s10bulletNextLevel.GetComponent<Animator>();
		nexts11bulletAnim = s11bulletNextLevel.GetComponent<Animator>();

		s1LevelInidcatorText.text = "LVL:\n"+s1Level+"/5";
		s2LevelInidcatorText.text = "LVL:\n"+s2Level+"/5";
		s3LevelInidcatorText.text = "LVL:\n"+s3Level+"/7";
		s4LevelInidcatorText.text = "LVL:\n"+s4Level+"/10";
		s5LevelInidcatorText.text = "LVL:\n"+s5Level+"/5";
		s6LevelInidcatorText.text = "LVL:\n"+s6Level+"/5";
		s7LevelInidcatorText.text = "LVL:\n"+s7Level+"/7";
		s8LevelInidcatorText.text = "LVL:\n"+s8Level+"/10";
		s9LevelInidcatorText.text = "LVL:\n"+s9Level+"/3";
		s10LevelInidcatorText.text = "LVL:\n"+s10Level+"/2";
		s11LevelInidcatorText.text = "LVL:\n"+s11Level+"/3";

		s1LevelInidcator.fillAmount=s1Level * 0.2f;
		s2LevelInidcator.fillAmount=s2Level * 0.2f;
		s3LevelInidcator.fillAmount=s3Level * 0.14285714f;
		s4LevelInidcator.fillAmount=s4Level * 0.1f;
		s5LevelInidcator.fillAmount=s5Level * 0.2f;
		s6LevelInidcator.fillAmount=s6Level * 0.2f;
		s7LevelInidcator.fillAmount=s7Level * 0.14285714f;
		s8LevelInidcator.fillAmount=s8Level * 0.1f;
		s9LevelInidcator.fillAmount=s9Level * 0.33333f;
		s10LevelInidcator.fillAmount=s10Level * 0.5f;
		s11LevelInidcator.fillAmount=s11Level * 0.33333f;



		s1LevelTextAnim = s1LevelText.GetComponent<Animator>();
		s2LevelTextAnim = s2LevelText.GetComponent<Animator>();
		s3LevelTextAnim = s3LevelText.GetComponent<Animator>();
		s4LevelTextAnim = s4LevelText.GetComponent<Animator>();
		s5LevelTextAnim = s5LevelText.GetComponent<Animator>();
		s6LevelTextAnim = s6LevelText.GetComponent<Animator>();
		s7LevelTextAnim = s7LevelText.GetComponent<Animator>();
		s8LevelTextAnim = s8LevelText.GetComponent<Animator>();
		s9LevelTextAnim = s9LevelText.GetComponent<Animator>();
		s10LevelTextAnim = s10LevelText.GetComponent<Animator>();
		s11LevelTextAnim = s11LevelText.GetComponent<Animator>();

		if(s1Level==5)
		{
			s1button.gameObject.SetActive(false);
			s1bar.gameObject.SetActive(false);
			s1Max.gameObject.SetActive(true);
			s1healthNextLevel.text = "MAX";
			s1energyNextLevel.text = "MAX";
			s1bulletNextLevel.text = "MAX";
			s1HealthBar.fillAmount = 1;
			s1EnergyBar.fillAmount = 1;
			s1BulletBar.fillAmount = 1;	
		}
		if(s2Level==5){
			s2button.gameObject.SetActive(false);
			s2bar.gameObject.SetActive(false);
			s2Max.gameObject.SetActive(true);
			s2HealthBar.fillAmount = 1;
			s2EnergyBar.fillAmount = 1;
			s2BulletBar.fillAmount = 1;
			s2healthNextLevel.text = "MAX";
			s2energyNextLevel.text = "MAX";
			s2bulletNextLevel.text = "MAX";
		}
		if(s3Level==7){
			s3button.gameObject.SetActive(false);
			s3bar.gameObject.SetActive(false);
			s3Max.gameObject.SetActive(true);
			s3HealthBar.fillAmount = 1;
			s3EnergyBar.fillAmount = 1;
			s3BulletBar.fillAmount = 1;
			s3healthNextLevel.text = "MAX";
			s3energyNextLevel.text = "MAX";
			s3bulletNextLevel.text = "MAX";
		}
		if(s4Level==10){
			s4button.gameObject.SetActive(false);
			s4bar.gameObject.SetActive(false);
			s4Max.gameObject.SetActive(true);
			s4HealthBar.fillAmount = 1;
			s4EnergyBar.fillAmount = 1;
			s4BulletBar.fillAmount = 1;
			s4healthNextLevel.text = "MAX";
			s4energyNextLevel.text = "MAX";
			s4bulletNextLevel.text = "MAX";
		}
		if(s5Level==5){
			s5button.gameObject.SetActive(false);
			s5bar.gameObject.SetActive(false);
			s5Max.gameObject.SetActive(true);
			s5HealthBar.fillAmount = 1;
			s5EnergyBar.fillAmount = 1;
			s5BulletBar.fillAmount = 1;
			s5healthNextLevel.text = "MAX";
			s5energyNextLevel.text = "MAX";
			s5bulletNextLevel.text = "MAX";
		}
		if(s6Level==5){
			s6button.gameObject.SetActive(false);
			s6bar.gameObject.SetActive(false);
			s6Max.gameObject.SetActive(true);
			s6HealthBar.fillAmount = 1;
			s6EnergyBar.fillAmount = 1;
			s6BulletBar.fillAmount = 1;
			s6healthNextLevel.text = "MAX";
			s6energyNextLevel.text = "MAX";
			s6bulletNextLevel.text = "MAX";
		}
		if(s7Level==7){
			s7button.gameObject.SetActive(false);
			s7bar.gameObject.SetActive(false);
			s7Max.gameObject.SetActive(true);
			s7HealthBar.fillAmount = 1;
			s7EnergyBar.fillAmount = 1;
			s7BulletBar.fillAmount = 1;
			s7healthNextLevel.text = "MAX";
			s7energyNextLevel.text = "MAX";
			s7bulletNextLevel.text = "MAX";
		}
		if(s8Level==10){
			s8button.gameObject.SetActive(false);
			s8bar.gameObject.SetActive(false);
			s8Max.gameObject.SetActive(true);
			s8HealthBar.fillAmount = 1;
			s8EnergyBar.fillAmount = 1;
			s8BulletBar.fillAmount = 1;
			s8healthNextLevel.text = "MAX";
			s8energyNextLevel.text = "MAX";
			s8bulletNextLevel.text = "MAX";
		}
		if(s9Level==3){
			s9button.gameObject.SetActive(false);
			s9bar.gameObject.SetActive(false);
			s9Max.gameObject.SetActive(true);
			s9BulletBar.fillAmount = 1;
			s9bulletNextLevel.text = "MAX";
		}
		if(s10Level==2){
			s10button.gameObject.SetActive(false);
			s10bar.gameObject.SetActive(false);
			s10Max.gameObject.SetActive(true);
			s10BulletBar.fillAmount = 1;
			s10bulletNextLevel.text = "MAX";
		}
		if(s11Level==3){
			s11button.gameObject.SetActive(false);
			s11bar.gameObject.SetActive(false);
			s11Max.gameObject.SetActive(true);
			s11BulletBar.fillAmount = 1;
			s11bulletNextLevel.text = "MAX";
		}
		if(PlayerPrefs.GetInt("knightUnlocked")==1)
		{
			s12button.gameObject.SetActive(false);
			s12Max.gameObject.SetActive(true);
			s12bar.gameObject.SetActive(false);
		}
	}
	
	[SerializeField]
	private GameObject closeSpeedUpDirections;

	[SerializeField]
	private Image notification;
	[SerializeField]
	private Text notificationText;

	public void turnOffNotification()
	{
		notification.gameObject.SetActive(false);
	}

	IEnumerator playS1UpgradeAnim()
	{
		yield return new WaitForSeconds(1.2f);
		s1LevelTextAnim.SetTrigger("upgrade");
		yield return new WaitForSeconds(2f);
		MainMenu.Instance.AudioSource.PlayOneShot(SoundManager.Instance.Hit2);
		s1health.text = health.ToString();
		s1energy.text = energy.ToString();
		s1bullet.text = bullet.ToString();
		s1healthAnim.SetTrigger("increase");
		s1energyAnim.SetTrigger("increase");
		s1bulletAnim.SetTrigger("increase");
		yield return new WaitForSeconds(1.6f);
		MainMenu.Instance.AudioSource.PlayOneShot(SoundManager.Instance.Hit2);
		if(s1Level!=5){
			s1healthNextLevel.text = healthNextLevel.ToString();
			s1energyNextLevel.text = energyNextLevel.ToString();
			s1bulletNextLevel.text = bulletNextLevel.ToString();
		}
		else{
			s1healthNextLevel.text = "MAX";
			s1energyNextLevel.text = "MAX";
			s1bulletNextLevel.text = "MAX";
		}
		nexts1healthAnim.SetTrigger("increase");
		nexts1energyAnim.SetTrigger("increase");
		nexts1bulletAnim.SetTrigger("increase");
	}

	IEnumerator playS2UpgradeAnim()
	{
		yield return new WaitForSeconds(1.2f);
		s2LevelTextAnim.SetTrigger("upgrade");
		yield return new WaitForSeconds(2f);
		MainMenu.Instance.AudioSource.PlayOneShot(SoundManager.Instance.Hit2);
		s2health.text = health2.ToString();
		s2energy.text = energy2.ToString();
		s2bullet.text = bullet2.ToString();
		s2healthAnim.SetTrigger("increase");
		s2energyAnim.SetTrigger("increase");
		s2bulletAnim.SetTrigger("increase");
		yield return new WaitForSeconds(1.6f);
		MainMenu.Instance.AudioSource.PlayOneShot(SoundManager.Instance.Hit1);
		if(s2Level!=5){
			s2healthNextLevel.text = health2NextLevel.ToString();
			s2energyNextLevel.text = energy2NextLevel.ToString();
			s2bulletNextLevel.text = bullet2NextLevel.ToString();
		}
		else{
			s2healthNextLevel.text = "MAX";
			s2energyNextLevel.text = "MAX";
			s2bulletNextLevel.text = "MAX";
		}
		nexts2healthAnim.SetTrigger("increase");
		nexts2energyAnim.SetTrigger("increase");
		nexts2bulletAnim.SetTrigger("increase");
	}

	IEnumerator playS3UpgradeAnim()
	{
		yield return new WaitForSeconds(1.2f);
		s3LevelTextAnim.SetTrigger("upgrade");
		yield return new WaitForSeconds(2f);
		MainMenu.Instance.AudioSource.PlayOneShot(SoundManager.Instance.Hit2);
		s3health.text = health3.ToString();
		s3energy.text = energy3.ToString();
		s3bullet.text = bullet3.ToString();
		s3healthAnim.SetTrigger("increase");
		s3energyAnim.SetTrigger("increase");
		s3bulletAnim.SetTrigger("increase");
		yield return new WaitForSeconds(1.6f);
		MainMenu.Instance.AudioSource.PlayOneShot(SoundManager.Instance.Hit1);
		if(s3Level!=7){
			s3healthNextLevel.text = health3NextLevel.ToString();
			s3energyNextLevel.text = energy3NextLevel.ToString();
			s3bulletNextLevel.text = bullet3NextLevel.ToString();
		}
		else{
			s3healthNextLevel.text = "MAX";
			s3energyNextLevel.text = "MAX";
			s3bulletNextLevel.text = "MAX";
		}
		nexts3healthAnim.SetTrigger("increase");
		nexts3energyAnim.SetTrigger("increase");
		nexts3bulletAnim.SetTrigger("increase");
	}

	IEnumerator playS4UpgradeAnim()
	{
		yield return new WaitForSeconds(1.2f);
		s4LevelTextAnim.SetTrigger("upgrade");
		yield return new WaitForSeconds(2f);
		MainMenu.Instance.AudioSource.PlayOneShot(SoundManager.Instance.Hit2);
		s4health.text = health4.ToString();
		s4energy.text = energy4.ToString();
		s4bullet.text = bullet4.ToString();
		s4healthAnim.SetTrigger("increase");
		s4energyAnim.SetTrigger("increase");
		s4bulletAnim.SetTrigger("increase");
		yield return new WaitForSeconds(1.6f);
		MainMenu.Instance.AudioSource.PlayOneShot(SoundManager.Instance.Hit1);
		if(s4Level!=10){
			s4healthNextLevel.text = health4NextLevel.ToString();
			s4energyNextLevel.text = energy4NextLevel.ToString();
			s4bulletNextLevel.text = bullet4NextLevel.ToString();
		}
		else{
			s4healthNextLevel.text = "MAX";
			s4energyNextLevel.text = "MAX";
			s4bulletNextLevel.text = "MAX";
		}
		nexts4healthAnim.SetTrigger("increase");
		nexts4energyAnim.SetTrigger("increase");
		nexts4bulletAnim.SetTrigger("increase");
	}

	IEnumerator playS5UpgradeAnim()
	{
		yield return new WaitForSeconds(1.2f);
		s5LevelTextAnim.SetTrigger("upgrade");
		yield return new WaitForSeconds(2f);
		MainMenu.Instance.AudioSource.PlayOneShot(SoundManager.Instance.Hit2);
		s5health.text = health5.ToString();
		s5energy.text = energy5.ToString();
		s5bullet.text = bullet5.ToString();
		s5healthAnim.SetTrigger("increase");
		s5energyAnim.SetTrigger("increase");
		s5bulletAnim.SetTrigger("increase");
		yield return new WaitForSeconds(1.6f);
		MainMenu.Instance.AudioSource.PlayOneShot(SoundManager.Instance.Hit1);
		if(s5Level!=5){
			s5healthNextLevel.text = health5NextLevel.ToString();
			s5energyNextLevel.text = energy5NextLevel.ToString();
			s5bulletNextLevel.text = bullet5NextLevel.ToString();
		}
		else{
			s5healthNextLevel.text = "MAX";
			s5energyNextLevel.text = "MAX";
			s5bulletNextLevel.text = "MAX";
		}
		nexts5healthAnim.SetTrigger("increase");
		nexts5energyAnim.SetTrigger("increase");
		nexts5bulletAnim.SetTrigger("increase");
	}

	IEnumerator playS6UpgradeAnim()
	{
		yield return new WaitForSeconds(1.2f);
		s6LevelTextAnim.SetTrigger("upgrade");
		yield return new WaitForSeconds(2f);
		MainMenu.Instance.AudioSource.PlayOneShot(SoundManager.Instance.Hit2);
		s6health.text = health6.ToString();
		s6energy.text = energy6.ToString();
		s6bullet.text = bullet6.ToString();
		s6healthAnim.SetTrigger("increase");
		s6energyAnim.SetTrigger("increase");
		s6bulletAnim.SetTrigger("increase");
		yield return new WaitForSeconds(1.6f);
		MainMenu.Instance.AudioSource.PlayOneShot(SoundManager.Instance.Hit1);
		if(s6Level!=5){
			s6healthNextLevel.text = health6NextLevel.ToString();
			s6energyNextLevel.text = energy6NextLevel.ToString();
			s6bulletNextLevel.text = bullet6NextLevel.ToString();
		}
		else{
			s6healthNextLevel.text = "MAX";
			s6energyNextLevel.text = "MAX";
			s6bulletNextLevel.text = "MAX";
		}
		nexts6healthAnim.SetTrigger("increase");
		nexts6energyAnim.SetTrigger("increase");
		nexts6bulletAnim.SetTrigger("increase");
	}

	IEnumerator playS7UpgradeAnim()
	{
		yield return new WaitForSeconds(1.2f);
		s7LevelTextAnim.SetTrigger("upgrade");
		yield return new WaitForSeconds(2f);
		MainMenu.Instance.AudioSource.PlayOneShot(SoundManager.Instance.Hit2);
		s7health.text = health7.ToString();
		s7energy.text = energy7.ToString();
		s7bullet.text = bullet7.ToString();
		s7healthAnim.SetTrigger("increase");
		s7energyAnim.SetTrigger("increase");
		s7bulletAnim.SetTrigger("increase");
		yield return new WaitForSeconds(1.6f);
		MainMenu.Instance.AudioSource.PlayOneShot(SoundManager.Instance.Hit1);
		if(s7Level!=7){
			s7healthNextLevel.text = health7NextLevel.ToString();
			s7energyNextLevel.text = energy7NextLevel.ToString();
			s7bulletNextLevel.text = bullet7NextLevel.ToString();
		}
		else{
			s7healthNextLevel.text = "MAX";
			s7energyNextLevel.text = "MAX";
			s7bulletNextLevel.text = "MAX";
		}
		nexts7healthAnim.SetTrigger("increase");
		nexts7energyAnim.SetTrigger("increase");
		nexts7bulletAnim.SetTrigger("increase");
	}

	IEnumerator playS8UpgradeAnim()
	{
		yield return new WaitForSeconds(1.2f);
		s8LevelTextAnim.SetTrigger("upgrade");
		yield return new WaitForSeconds(2f);
		MainMenu.Instance.AudioSource.PlayOneShot(SoundManager.Instance.Hit2);
		s8health.text = health8.ToString();
		s8energy.text = energy8.ToString();
		s8bullet.text = bullet8.ToString();
		s8healthAnim.SetTrigger("increase");
		s8energyAnim.SetTrigger("increase");
		s8bulletAnim.SetTrigger("increase");
		yield return new WaitForSeconds(1.6f);
		MainMenu.Instance.AudioSource.PlayOneShot(SoundManager.Instance.Hit1);
		if(s8Level!=10){
			s8healthNextLevel.text = health8NextLevel.ToString();
			s8energyNextLevel.text = energy8NextLevel.ToString();
			s8bulletNextLevel.text = bullet8NextLevel.ToString();
		}
		else{
			s8healthNextLevel.text = "MAX";
			s8energyNextLevel.text = "MAX";
			s8bulletNextLevel.text = "MAX";
		}
		nexts8healthAnim.SetTrigger("increase");
		nexts8energyAnim.SetTrigger("increase");
		nexts8bulletAnim.SetTrigger("increase");
	}

	IEnumerator playS9UpgradeAnim()
	{
		yield return new WaitForSeconds(1.2f);
		s9LevelTextAnim.SetTrigger("upgrade");
		yield return new WaitForSeconds(2f);
		MainMenu.Instance.AudioSource.PlayOneShot(SoundManager.Instance.Hit2);
		s9bullet.text = bullet9.ToString();
		s9bulletAnim.SetTrigger("increase");
		yield return new WaitForSeconds(1.6f);
		MainMenu.Instance.AudioSource.PlayOneShot(SoundManager.Instance.Hit1);
		if(s9Level!=3){
			s9bulletNextLevel.text = bullet9NextLevel.ToString();
		}
		else{
			s9bulletNextLevel.text = "MAX";
		}
		nexts9bulletAnim.SetTrigger("increase");
	}

	IEnumerator playS10UpgradeAnim()
	{
		yield return new WaitForSeconds(1.2f);
		s10LevelTextAnim.SetTrigger("upgrade");
		yield return new WaitForSeconds(2f);
		MainMenu.Instance.AudioSource.PlayOneShot(SoundManager.Instance.Hit2);
		s10bullet.text = bullet10.ToString();
		s10bulletAnim.SetTrigger("increase");
		yield return new WaitForSeconds(1.6f);
		MainMenu.Instance.AudioSource.PlayOneShot(SoundManager.Instance.Hit1);
		if(s10Level!=2){
			s10bulletNextLevel.text = bullet10NextLevel.ToString();
		}
		else{
			s10bulletNextLevel.text = "MAX";
		}
		nexts10bulletAnim.SetTrigger("increase");
	}

	IEnumerator playS11UpgradeAnim()
	{
		yield return new WaitForSeconds(1.2f);
		s11LevelTextAnim.SetTrigger("upgrade");
		yield return new WaitForSeconds(2f);
		MainMenu.Instance.AudioSource.PlayOneShot(SoundManager.Instance.Hit2);
		s11bullet.text = bullet11.ToString();
		s11bulletAnim.SetTrigger("increase");
		yield return new WaitForSeconds(1.6f);
		MainMenu.Instance.AudioSource.PlayOneShot(SoundManager.Instance.Hit1);
		if(s11Level!=3){
			s11bulletNextLevel.text = bullet11NextLevel.ToString();
		}
		else{
			s11bulletNextLevel.text = "MAX";
		}
		nexts11bulletAnim.SetTrigger("increase");
	}

	public void changeText2()
	{
		directionsText.text = "Soldier now has higher health, stronger attack and requires lower energy.";
	}
	
	// Update is called once per frame
	void Update () {
		if(PlayerPrefs.GetInt("armyIntroDone") == 1)
		{
			directions.SetActive(false);
			closeSpeedUpDirections.SetActive(false);
		}
		if(PlayerPrefs.GetInt("armyIntroDone") == 0 && s1Level ==2 && !directionsAnim.GetCurrentAnimatorStateInfo(0).IsName("ArmyFinalDirections"))
		{
			directionsAnim.SetTrigger("next3");
			closeBtn.interactable = true;
			Invoke("changeText2",1.3f);
		}

		if (isUpgradingS1 == true){
			PlayerPrefs.SetInt("upgrading",1);
			s1rotator.gameObject.SetActive(true);
			s2button.interactable = false;
			s3button.interactable = false;
			s4button.interactable = false;
			s5button.interactable = false;
			s6button.interactable = false;
			s7button.interactable = false;
			s8button.interactable = false;
			s9button.interactable = false;
			s10button.interactable = false;
			s11button.interactable = false;
			s12button.interactable = false;
			if(s1Level==1 && PlayerPrefs.GetInt("armyIntroDone") == 0 && directionsAnim.GetCurrentAnimatorStateInfo(0).IsName("leftRight"))
			{
				directionsAnim.SetTrigger("next1");
				directionsText.text = "Fastforward the upgrading process!";
			}

			if(s1lvl1.CurrentVal >0){
				s1lvl1.CurrentVal -= Time.deltaTime;
			}
			else{
				StartCoroutine(upgradeSound());
				soldierPageAnim.SetTrigger("upgrade");
				if(PlayerPrefs.GetInt("armyIntroDone") == 0 && s1Level == 1)
				{
					directionsAnim.SetTrigger("next3");
					directionsText.text = "";
					Invoke("changeText2",1.3f);
					if(speedUpObj.activeSelf){
						closeSpeedUp();
						//closeSpeedUpDirections.SetActive(true);
					}
					//directions.gameObject.SetActive(true);
					s2Btn.interactable = true;
					cancelBtn.interactable = true;
					closeSpeedUpBtn.interactable = true;
				}
				notification.gameObject.SetActive(true);
				notificationText.text = "Congratulations! Sergeant Johnson is now upgraded!";
				Invoke("turnOffNotification",3.5f);
				PlayerPrefs.SetInt("upgrading",0);
				zeroSpeedUpUsed();
				s1rotator.gameObject.SetActive(false);
				s1Level ++;
				PlayerPrefs.SetInt("s1level",s1Level);
				s1LevelText.text = "Level\n"+ s1Level.ToString();
				for(int i = 1; i <= 5; i++)
				{
					if(s1Level == i && i!=5)
					{
						health = health1[i-1];
						energy = energy1[i-1];
						bullet = bullet1[i-1];					
						healthNextLevel = health1[i];					
						energyNextLevel = energy1[i];					
						bulletNextLevel = bullet1[i];
						s1lvl1.MaxVal = time1[i-1];
						s1lvl1.CurrentVal = time1[i-1];
						PlayerPrefs.SetInt("time1Lvl2",time1[i-1]);

						s1button.gameObject.SetActive(true);
						s1bar.gameObject.SetActive(false);
						
					}
					else if(s1Level == i && i==5)
					{
						health = health1[i-1];
						energy = energy1[i-1];
						bullet = bullet1[i-1];

						s1button.gameObject.SetActive(false);
						s1bar.gameObject.SetActive(false);
						s1Max.gameObject.SetActive(true);
						s1healthNextLevel.text = "MAX";
						s1energyNextLevel.text = "MAX";
						s1bulletNextLevel.text = "MAX";
						s1HealthBar.fillAmount = 1;
						s1EnergyBar.fillAmount = 1;
						s1BulletBar.fillAmount = 1;
					}
				}
				PlayerPrefs.SetInt("s1Health",health);
				PlayerPrefs.SetInt("s1Energy",energy);
				PlayerPrefs.SetInt("s1Bullet",bullet);
				PlayerPrefs.SetInt("s1HealthNext",healthNextLevel);
				PlayerPrefs.SetInt("s1EnergyNext",energyNextLevel);
				PlayerPrefs.SetInt("s1BulletNext",bulletNextLevel);

				s1LevelInidcatorText.text = "LVL:\n"+s1Level+"/5";
				isUpgradingS1 = false;

				s2button.interactable = true;
				s3button.interactable = true;
				s4button.interactable = true;
				s5button.interactable = true;
				s6button.interactable = true;
				s7button.interactable = true;
				s8button.interactable = true;
				s9button.interactable = true;
				s10button.interactable = true;
				s11button.interactable = true;
				s12button.interactable = true;
				s1LevelInidcator.fillAmount+=0.2f;
				StartCoroutine(playS1UpgradeAnim());
				
			} 
		}

		else if (isUpgradingS2 == true){
			PlayerPrefs.SetInt("upgrading",2);
			s2rotator.gameObject.SetActive(true);
			s1button.interactable = false;
			s3button.interactable = false;
			s4button.interactable = false;
			s5button.interactable = false;
			s6button.interactable = false;
			s7button.interactable = false;
			s8button.interactable = false;
			s9button.interactable = false;
			s10button.interactable = false;
			s11button.interactable = false;
			s12button.interactable = false;
			if(s2lvl2.CurrentVal >0){
				s2lvl2.CurrentVal -= Time.deltaTime;
			}
			else{
				StartCoroutine(upgradeSound());
				soldierPageAnim.SetTrigger("upgrade");
				PlayerPrefs.SetInt("upgrading",0);
				zeroSpeedUpUsed();
				notification.gameObject.SetActive(true);
				notificationText.text = "Congratulations! Miss Mroot is now upgraded!";
				Invoke("turnOffNotification",3.5f);
				s2rotator.gameObject.SetActive(false);
				s2Level ++;
				PlayerPrefs.SetInt("s2level",s2Level);
				s2LevelText.text = "Level\n"+ s2Level.ToString();
				for(int i = 1; i <= 5; i++)
				{
					if(s2Level == i && i!=5)
					{
						health2 = health2List[i-1];
						energy2 = energy2List[i-1];
						bullet2 = bullet2List[i-1];					
						health2NextLevel = health2List[i];					
						energy2NextLevel = energy2List[i];					
						bullet2NextLevel = bullet2List[i];
						s2lvl2.MaxVal = time2List[i-1];
						s2lvl2.CurrentVal = time2List[i-1];
						PlayerPrefs.SetInt("time2Lvl2",time2List[i-1]);

						s2button.gameObject.SetActive(true);
						s2bar.gameObject.SetActive(false);
					}
					else if(s2Level == i && i==5)
					{
						health2 = health2List[i-1];
						energy2 = energy2List[i-1];
						bullet2 = bullet2List[i-1];	

						s2button.gameObject.SetActive(false);
						s2bar.gameObject.SetActive(false);
						s2Max.gameObject.SetActive(true);
						s2HealthBar.fillAmount = 1;
						s2EnergyBar.fillAmount = 1;
						s2BulletBar.fillAmount = 1;
					}
				}
				PlayerPrefs.SetInt("s2Health",health2);
				PlayerPrefs.SetInt("s2Energy",energy2);
				PlayerPrefs.SetInt("s2Bullet",bullet2);
				PlayerPrefs.SetInt("s2HealthNext",health2NextLevel);
				PlayerPrefs.SetInt("s2EnergyNext",energy2NextLevel);
				PlayerPrefs.SetInt("s2BulletNext",bullet2NextLevel);

				s2LevelInidcatorText.text = "LVL:\n"+s2Level+"/10";
				isUpgradingS2 = false;

				s1button.interactable = true;
				s3button.interactable = true;
				s4button.interactable = true;
				s5button.interactable = true;
				s6button.interactable = true;
				s7button.interactable = true;
				s8button.interactable = true;
				s9button.interactable = true;
				s10button.interactable = true;
				s11button.interactable = true;
				s12button.interactable = true;
				s2LevelInidcator.fillAmount+=0.2f;
				
				s2healthAnim.SetTrigger("increase");
				s2energyAnim.SetTrigger("increase");
				s2bulletAnim.SetTrigger("increase");
				nexts2healthAnim.SetTrigger("increase");
				nexts2energyAnim.SetTrigger("increase");
				nexts2bulletAnim.SetTrigger("increase");
				StartCoroutine(playS2UpgradeAnim());
			} 
		}

		else if (isUpgradingS3 == true){
			PlayerPrefs.SetInt("upgrading",3);
			s3rotator.gameObject.SetActive(true);
			s1button.interactable = false;
			s2button.interactable = false;
			s4button.interactable = false;
			s5button.interactable = false;
			s6button.interactable = false;
			s7button.interactable = false;
			s8button.interactable = false;
			s9button.interactable = false;
			s10button.interactable = false;
			s11button.interactable = false;
			s12button.interactable = false;
			if(s3lvl2.CurrentVal >0){
				s3lvl2.CurrentVal -= Time.deltaTime;
			}
			else{
				StartCoroutine(upgradeSound());
				soldierPageAnim.SetTrigger("upgrade");
				PlayerPrefs.SetInt("upgrading",0);
				zeroSpeedUpUsed();
				notification.gameObject.SetActive(true);
				notificationText.text = "Congratulations! Gunner is now upgraded!";
				Invoke("turnOffNotification",3.5f);
				s3rotator.gameObject.SetActive(false);
				s3Level ++;
				PlayerPrefs.SetInt("s3level",s3Level);
				s3LevelText.text = "Level\n"+ s3Level.ToString();
				for(int i = 1; i <= 7; i++)
				{
					if(s3Level == i && i!=7)
					{
						health3 = health3List[i-1];
						energy3 = energy3List[i-1];
						bullet3 = bullet3List[i-1];					
						health3NextLevel = health3List[i];					
						energy3NextLevel = energy3List[i];					
						bullet3NextLevel = bullet3List[i];
						s3lvl2.MaxVal = time3List[i-1];
						s3lvl2.CurrentVal = time3List[i-1];
						PlayerPrefs.SetInt("time3Lvl2",time3List[i-1]);

						s3button.gameObject.SetActive(true);
						s3bar.gameObject.SetActive(false);
					}
					else if(s3Level == i && i==7)
					{
						health3 = health3List[i-1];
						energy3 = energy3List[i-1];
						bullet3 = bullet3List[i-1];	

						s3button.gameObject.SetActive(false);
						s3bar.gameObject.SetActive(false);
						s3Max.gameObject.SetActive(true);
						s3HealthBar.fillAmount = 1;
						s3EnergyBar.fillAmount = 1;
						s3BulletBar.fillAmount = 1;
					}
				}
				PlayerPrefs.SetInt("s3Health",health3);
				PlayerPrefs.SetInt("s3Energy",energy3);
				PlayerPrefs.SetInt("s3Bullet",bullet3);
				PlayerPrefs.SetInt("s3HealthNext",health3NextLevel);
				PlayerPrefs.SetInt("s3EnergyNext",energy3NextLevel);
				PlayerPrefs.SetInt("s3BulletNext",bullet3NextLevel);

				s3LevelInidcatorText.text = "LVL:\n"+s3Level+"/7";
				isUpgradingS3 = false;

				s1button.interactable = true;
				s2button.interactable = true;
				s4button.interactable = true;
				s5button.interactable = true;
				s6button.interactable = true;
				s7button.interactable = true;
				s8button.interactable = true;
				s9button.interactable = true;
				s10button.interactable = true;
				s11button.interactable = true;
				s12button.interactable = true;
				s3LevelInidcator.fillAmount+=0.14285714f;
				
				StartCoroutine(playS3UpgradeAnim());
			} 
		}

		else if (isUpgradingS4 == true){
			PlayerPrefs.SetInt("upgrading",4);
			s4rotator.gameObject.SetActive(true);
			s1button.interactable = false;
			s2button.interactable = false;
			s3button.interactable = false;
			s5button.interactable = false;
			s6button.interactable = false;
			s7button.interactable = false;
			s8button.interactable = false;
			s9button.interactable = false;
			s10button.interactable = false;
			s11button.interactable = false;
			s12button.interactable = false;
			if(s4lvl2.CurrentVal >0){
				s4lvl2.CurrentVal -= Time.deltaTime;
			}
			else{
				StartCoroutine(upgradeSound());
				soldierPageAnim.SetTrigger("upgrade");
				PlayerPrefs.SetInt("upgrading",0);
				zeroSpeedUpUsed();
				notification.gameObject.SetActive(true);
				notificationText.text = "Congratulations! Steelshot is now upgraded!";
				Invoke("turnOffNotification",3.5f);
				s4rotator.gameObject.SetActive(false);
				s4Level ++;
				PlayerPrefs.SetInt("s4level",s4Level);
				s4LevelText.text = "Level\n"+ s4Level.ToString();
				for(int i = 1; i <= 10; i++)
				{
					if(s4Level == i && i!=10)
					{
						health4 = health4List[i-1];
						energy4 = energy4List[i-1];
						bullet4 = bullet4List[i-1];					
						health4NextLevel = health4List[i];					
						energy4NextLevel = energy4List[i];					
						bullet4NextLevel = bullet4List[i];
						s4lvl2.MaxVal = time4List[i-1];
						s4lvl2.CurrentVal = time4List[i-1];
						PlayerPrefs.SetInt("time4Lvl2",time4List[i-1]);

						s4button.gameObject.SetActive(true);
						s4bar.gameObject.SetActive(false);
						s4healthNextLevel.text = health4NextLevel.ToString();
						s4energyNextLevel.text = energy4NextLevel.ToString();
						s4bulletNextLevel.text = bullet4NextLevel.ToString();
					}
					else if(s4Level == i && i==10)
					{
						health4 = health4List[i-1];
						energy4 = energy4List[i-1];
						bullet4 = bullet4List[i-1];	

						s4button.gameObject.SetActive(false);
						s4bar.gameObject.SetActive(false);
						s4Max.gameObject.SetActive(true);
						s4HealthBar.fillAmount = 1;
						s4EnergyBar.fillAmount = 1;
						s4BulletBar.fillAmount = 1;
					}
				}
				PlayerPrefs.SetInt("s4Health",health4);
				PlayerPrefs.SetInt("s4Energy",energy4);
				PlayerPrefs.SetInt("s4Bullet",bullet4);
				PlayerPrefs.SetInt("s4HealthNext",health4NextLevel);
				PlayerPrefs.SetInt("s4EnergyNext",energy4NextLevel);
				PlayerPrefs.SetInt("s4BulletNext",bullet4NextLevel);

				s4LevelInidcatorText.text = "LVL:\n"+s4Level+"/10";
				isUpgradingS4 = false;

				s1button.interactable = true;
				s2button.interactable = true;
				s3button.interactable = true;
				s5button.interactable = true;
				s6button.interactable = true;
				s7button.interactable = true;
				s8button.interactable = true;
				s9button.interactable = true;
				s10button.interactable = true;
				s11button.interactable = true;
				s12button.interactable = true;
				s4LevelInidcator.fillAmount+=0.1f;
				StartCoroutine(playS4UpgradeAnim());
			} 
		}

		else if (isUpgradingS5 == true){
			PlayerPrefs.SetInt("upgrading",5);
			s5rotator.gameObject.SetActive(true);
			s1button.interactable = false;
			s2button.interactable = false;
			s3button.interactable = false;
			s4button.interactable = false;
			s6button.interactable = false;
			s7button.interactable = false;
			s8button.interactable = false;
			s9button.interactable = false;
			s10button.interactable = false;
			s11button.interactable = false;
			s12button.interactable = false;
			if(s5lvl2.CurrentVal >0){
				s5lvl2.CurrentVal -= Time.deltaTime;
			}
			else{
				StartCoroutine(upgradeSound());
				soldierPageAnim.SetTrigger("upgrade");
				PlayerPrefs.SetInt("upgrading",0);
				zeroSpeedUpUsed();
				notification.gameObject.SetActive(true);
				notificationText.text = "Congratulations! Agent Lunch is now upgraded!";
				Invoke("turnOffNotification",3.5f);
				s5rotator.gameObject.SetActive(false);
				s5Level ++;
				PlayerPrefs.SetInt("s5level",s5Level);
				s5LevelText.text = "Level\n"+ s5Level.ToString();
				for(int i = 1; i <= 5; i++)
				{
					if(s5Level == i && i!=5)
					{
						health5 = health5List[i-1];
						energy5 = energy5List[i-1];
						bullet5 = bullet5List[i-1];					
						health5NextLevel = health5List[i];					
						energy5NextLevel = energy5List[i];					
						bullet5NextLevel = bullet5List[i];
						s5lvl2.MaxVal = time5List[i-1];
						s5lvl2.CurrentVal = time5List[i-1];
						PlayerPrefs.SetInt("time5Lvl2",time5List[i-1]);

						s5button.gameObject.SetActive(true);
						s5bar.gameObject.SetActive(false);
					}
					else if(s5Level == i && i==5)
					{
						health5 = health5List[i-1];
						energy5 = energy5List[i-1];
						bullet5 = bullet5List[i-1];		

						s5button.gameObject.SetActive(false);
						s5bar.gameObject.SetActive(false);
						s5Max.gameObject.SetActive(true);
						s5HealthBar.fillAmount = 1;
						s5EnergyBar.fillAmount = 1;
						s5BulletBar.fillAmount = 1;
					}
				}
				PlayerPrefs.SetInt("s5Health",health5);
				PlayerPrefs.SetInt("s5Energy",energy5);
				PlayerPrefs.SetInt("s5Bullet",bullet5);
				PlayerPrefs.SetInt("s5HealthNext",health5NextLevel);
				PlayerPrefs.SetInt("s5EnergyNext",energy5NextLevel);
				PlayerPrefs.SetInt("s5BulletNext",bullet5NextLevel);

				s5LevelInidcatorText.text = "LVL:\n"+s5Level+"/5";
				isUpgradingS5 = false;

				s1button.interactable = true;
				s2button.interactable = true;
				s3button.interactable = true;
				s4button.interactable = true;
				s6button.interactable = true;
				s7button.interactable = true;
				s8button.interactable = true;
				s9button.interactable = true;
				s10button.interactable = true;
				s11button.interactable = true;
				s12button.interactable = true;
				s5LevelInidcator.fillAmount+=0.2f;
				StartCoroutine(playS5UpgradeAnim());
			} 
		}

		else if (isUpgradingS6 == true){
			PlayerPrefs.SetInt("upgrading",6);
			s6rotator.gameObject.SetActive(true);
			s1button.interactable = false;
			s2button.interactable = false;
			s3button.interactable = false;
			s4button.interactable = false;
			s5button.interactable = false;
			s7button.interactable = false;
			s8button.interactable = false;
			s9button.interactable = false;
			s10button.interactable = false;
			s11button.interactable = false;
			s12button.interactable = false;
			if(s6lvl2.CurrentVal >0){
				s6lvl2.CurrentVal -= Time.deltaTime;
			}
			else{
				StartCoroutine(upgradeSound());
				soldierPageAnim.SetTrigger("upgrade");
				PlayerPrefs.SetInt("upgrading",0);
				zeroSpeedUpUsed();
				notification.gameObject.SetActive(true);
				notificationText.text = "Congratulations! Commando is now upgraded!";
				Invoke("turnOffNotification",3.5f);
				s6rotator.gameObject.SetActive(false);
				s6Level ++;
				PlayerPrefs.SetInt("s6level",s6Level);
				s6LevelText.text = "Level\n"+ s6Level.ToString();
				for(int i = 1; i <= 5; i++)
				{
					if(s6Level == i && i!=5)
					{
						health6 = health6List[i-1];
						energy6 = energy6List[i-1];
						bullet6 = bullet6List[i-1];					
						health6NextLevel = health6List[i];					
						energy6NextLevel = energy6List[i];					
						bullet6NextLevel = bullet6List[i];
						s6lvl2.MaxVal = time6List[i-1];
						s6lvl2.CurrentVal = time6List[i-1];
						PlayerPrefs.SetInt("time6Lvl2",time6List[i-1]);

						s6button.gameObject.SetActive(true);
						s6bar.gameObject.SetActive(false);
					}
					else if(s6Level == i && i==5)
					{
						health6 = health6List[i-1];
						energy6 = energy6List[i-1];
						bullet6 = bullet6List[i-1];			

						s6button.gameObject.SetActive(false);
						s6bar.gameObject.SetActive(false);
						s6Max.gameObject.SetActive(true);
						s6HealthBar.fillAmount = 1;
						s6EnergyBar.fillAmount = 1;
						s6BulletBar.fillAmount = 1;
					}
				}
				PlayerPrefs.SetInt("s6Health",health6);
				PlayerPrefs.SetInt("s6Energy",energy6);
				PlayerPrefs.SetInt("s6Bullet",bullet6);
				PlayerPrefs.SetInt("s6HealthNext",health6NextLevel);
				PlayerPrefs.SetInt("s6EnergyNext",energy6NextLevel);
				PlayerPrefs.SetInt("s6BulletNext",bullet6NextLevel);

				s6LevelInidcatorText.text = "LVL:\n"+s6Level+"/5";
				isUpgradingS6 = false;

				s1button.interactable = true;
				s2button.interactable = true;
				s3button.interactable = true;
				s4button.interactable = true;
				s5button.interactable = true;
				s7button.interactable = true;
				s8button.interactable = true;
				s9button.interactable = true;
				s10button.interactable = true;
				s11button.interactable = true;
				s12button.interactable = true;
				s6LevelInidcator.fillAmount+=0.2f;
				StartCoroutine(playS6UpgradeAnim());
			} 
		}

		else if (isUpgradingS7 == true){
			PlayerPrefs.SetInt("upgrading",7);
			s7rotator.gameObject.SetActive(true);
			s1button.interactable = false;
			s2button.interactable = false;
			s3button.interactable = false;
			s4button.interactable = false;
			s5button.interactable = false;
			s6button.interactable = false;
			s8button.interactable = false;
			s9button.interactable = false;
			s10button.interactable = false;
			s11button.interactable = false;
			s12button.interactable = false;
			if(s7lvl2.CurrentVal >0){
				s7lvl2.CurrentVal -= Time.deltaTime;
			}
			else{
				StartCoroutine(upgradeSound());
				soldierPageAnim.SetTrigger("upgrade");
				PlayerPrefs.SetInt("upgrading",0);
				zeroSpeedUpUsed();
				notification.gameObject.SetActive(true);
				notificationText.text = "Congratulations! Night Strike is now upgraded!";
				Invoke("turnOffNotification",3.5f);
				s7rotator.gameObject.SetActive(false);
				s7Level ++;
				PlayerPrefs.SetInt("s7level",s7Level);
				s7LevelText.text = "Level\n"+ s7Level.ToString();
				for(int i = 1; i <= 7; i++)
				{
					if(s7Level == i && i!=7)
					{
						health7 = health7List[i-1];
						energy7 = energy7List[i-1];
						bullet7 = bullet7List[i-1];					
						health7NextLevel = health7List[i];					
						energy7NextLevel = energy7List[i];					
						bullet7NextLevel = bullet7List[i];
						s7lvl2.MaxVal = time7List[i-1];
						s7lvl2.CurrentVal = time7List[i-1];
						PlayerPrefs.SetInt("time7Lvl2",time7List[i-1]);

						s7button.gameObject.SetActive(true);
						s7bar.gameObject.SetActive(false);
					}
					else if(s7Level == i && i==7)
					{
						health7 = health7List[i-1];
						energy7 = energy7List[i-1];
						bullet7 = bullet7List[i-1];			

						s7button.gameObject.SetActive(false);
						s7bar.gameObject.SetActive(false);
						s7Max.gameObject.SetActive(true);
						s7HealthBar.fillAmount = 1;
						s7EnergyBar.fillAmount = 1;
						s7BulletBar.fillAmount = 1;
					}
				}
				PlayerPrefs.SetInt("s7Health",health7);
				PlayerPrefs.SetInt("s7Energy",energy7);
				PlayerPrefs.SetInt("s7Bullet",bullet7);
				PlayerPrefs.SetInt("s7HealthNext",health7NextLevel);
				PlayerPrefs.SetInt("s7EnergyNext",energy7NextLevel);
				PlayerPrefs.SetInt("s7BulletNext",bullet7NextLevel);

				s7LevelInidcatorText.text = "LVL:\n"+s7Level+"/7";
				isUpgradingS7 = false;

				s1button.interactable = true;
				s2button.interactable = true;
				s3button.interactable = true;
				s4button.interactable = true;
				s5button.interactable = true;
				s6button.interactable = true;
				s8button.interactable = true;
				s9button.interactable = true;
				s10button.interactable = true;
				s11button.interactable = true;
				s12button.interactable = true;
				s7LevelInidcator.fillAmount+=0.14285714f;
				StartCoroutine(playS7UpgradeAnim());
			} 
		}

		else if (isUpgradingS8 == true){
			PlayerPrefs.SetInt("upgrading",8);
			s8rotator.gameObject.SetActive(true);
			s1button.interactable = false;
			s2button.interactable = false;
			s3button.interactable = false;
			s4button.interactable = false;
			s5button.interactable = false;
			s6button.interactable = false;
			s7button.interactable = false;
			s9button.interactable = false;
			s10button.interactable = false;
			s11button.interactable = false;
			s12button.interactable = false;
			if(s8lvl2.CurrentVal >0){
				s8lvl2.CurrentVal -= Time.deltaTime;
			}
			else{
				StartCoroutine(upgradeSound());
				soldierPageAnim.SetTrigger("upgrade");
				PlayerPrefs.SetInt("upgrading",0);
				zeroSpeedUpUsed();
				notification.gameObject.SetActive(true);
				notificationText.text = "Congratulations! Wraith is now upgraded!";
				Invoke("turnOffNotification",3.5f);
				s8rotator.gameObject.SetActive(false);
				s8Level ++;
				PlayerPrefs.SetInt("s8level",s8Level);
				s8LevelText.text = "Level\n"+ s8Level.ToString();
				for(int i = 1; i <= 10; i++)
				{
					if(s8Level == i && i!=10)
					{
						health8 = health8List[i-1];
						energy8 = energy8List[i-1];
						bullet8 = bullet8List[i-1];					
						health8NextLevel = health8List[i];					
						energy8NextLevel = energy8List[i];					
						bullet8NextLevel = bullet8List[i];
						s8lvl2.MaxVal = time8List[i-1];
						s8lvl2.CurrentVal = time8List[i-1];
						PlayerPrefs.SetInt("time8Lvl2",time8List[i-1]);

						s8button.gameObject.SetActive(true);
						s8bar.gameObject.SetActive(false);
					}
					else if(s8Level == i && i==10)
					{
						health8 = health8List[i-1];
						energy8 = energy8List[i-1];
						bullet8 = bullet8List[i-1];		

						s8button.gameObject.SetActive(false);
						s8bar.gameObject.SetActive(false);
						s8Max.gameObject.SetActive(true);
						s8HealthBar.fillAmount = 1;
						s8EnergyBar.fillAmount = 1;
						s8BulletBar.fillAmount = 1;
					}
				}
				PlayerPrefs.SetInt("s8Health",health8);
				PlayerPrefs.SetInt("s8Energy",energy8);
				PlayerPrefs.SetInt("s8Bullet",bullet8);
				PlayerPrefs.SetInt("s8HealthNext",health8NextLevel);
				PlayerPrefs.SetInt("s8EnergyNext",energy8NextLevel);
				PlayerPrefs.SetInt("s8BulletNext",bullet8NextLevel);

				s8LevelInidcatorText.text = "LVL:\n"+s8Level+"/10";
				isUpgradingS8 = false;

				s1button.interactable = true;
				s2button.interactable = true;
				s3button.interactable = true;
				s4button.interactable = true;
				s5button.interactable = true;
				s6button.interactable = true;
				s7button.interactable = true;
				s9button.interactable = true;
				s10button.interactable = true;
				s11button.interactable = true;
				s12button.interactable = true;
				s8LevelInidcator.fillAmount+=0.1f;
				
				StartCoroutine(playS8UpgradeAnim());
			} 
		}

		else if (isUpgradingS9 == true){
			PlayerPrefs.SetInt("upgrading",9);
			s9rotator.gameObject.SetActive(true);
			s1button.interactable = false;
			s2button.interactable = false;
			s3button.interactable = false;
			s4button.interactable = false;
			s5button.interactable = false;
			s6button.interactable = false;
			s7button.interactable = false;
			s8button.interactable = false;
			s10button.interactable = false;
			s11button.interactable = false;
			if(s9lvl2.CurrentVal >0){
				s9lvl2.CurrentVal -= Time.deltaTime;
			}
			else{
				StartCoroutine(upgradeSound());
				soldierPageAnim.SetTrigger("upgrade");
				PlayerPrefs.SetInt("upgrading",0);
				zeroSpeedUpUsed();
				notification.gameObject.SetActive(true);
				notificationText.text = "Congratulations! Grenade is now upgraded!";
				Invoke("turnOffNotification",3.5f);
				s9rotator.gameObject.SetActive(false);
				s9Level ++;
				PlayerPrefs.SetInt("s9level",s9Level);
				s9LevelText.text = "Level\n"+ s9Level.ToString();
				for(int i = 1; i <= 3; i++)
				{
					if(s9Level == i && i!=3)
					{
						bullet9 = bullet9List[i-1];										
						bullet9NextLevel = bullet9List[i];
						s9lvl2.MaxVal = time9List[i-1];
						s9lvl2.CurrentVal = time9List[i-1];
						PlayerPrefs.SetInt("time9Lvl2",time9List[i-1]);
						s9button.gameObject.SetActive(true);
						s9bar.gameObject.SetActive(false);
					}
					else if(s9Level == i && i==3)
					{
						bullet9 = bullet9List[i-1];		
						s9button.gameObject.SetActive(false);
						s9bar.gameObject.SetActive(false);
						s9Max.gameObject.SetActive(true);
						s9BulletBar.fillAmount = 1;
					}
				}
				PlayerPrefs.SetInt("s9Bullet",bullet9);
				PlayerPrefs.SetInt("s9BulletNext",bullet9NextLevel);

				s9LevelInidcatorText.text = "LVL:\n"+s9Level+"/3";
				isUpgradingS9 = false;

				s1button.interactable = true;
				s2button.interactable = true;
				s3button.interactable = true;
				s4button.interactable = true;
				s5button.interactable = true;
				s6button.interactable = true;
				s7button.interactable = true;
				s8button.interactable = true;
				s10button.interactable = true;
				s11button.interactable = true;
				s12button.interactable = true;
				s9LevelInidcator.fillAmount+=0.33333f;
				StartCoroutine(playS9UpgradeAnim());
			} 
		}

		else if (isUpgradingS10 == true){
			PlayerPrefs.SetInt("upgrading",10);
			s10rotator.gameObject.SetActive(true);
			s1button.interactable = false;
			s2button.interactable = false;
			s3button.interactable = false;
			s4button.interactable = false;
			s5button.interactable = false;
			s6button.interactable = false;
			s7button.interactable = false;
			s8button.interactable = false;
			s9button.interactable = false;
			s11button.interactable = false;
			s12button.interactable = false;
			if(s10lvl2.CurrentVal >0){
				s10lvl2.CurrentVal -= Time.deltaTime;
			}
			else{
				StartCoroutine(upgradeSound());
				soldierPageAnim.SetTrigger("upgrade");
				PlayerPrefs.SetInt("upgrading",0);
				zeroSpeedUpUsed();
				notification.gameObject.SetActive(true);
				notificationText.text = "Congratulations! Mr. Pumpkin is now upgraded!";
				Invoke("turnOffNotification",3.5f);
				s10rotator.gameObject.SetActive(false);
				s10Level ++;
				PlayerPrefs.SetInt("s10level",s10Level);
				s10LevelText.text = "Level\n"+ s10Level.ToString();
				for(int i = 1; i <= 2; i++)
				{
					if(s10Level == i && i!=2)
					{
						bullet10 = bullet10List[i-1];										
						bullet10NextLevel = bullet10List[i];
						s10lvl2.MaxVal = time10List[i-1];
						s10lvl2.CurrentVal = time10List[i-1];
						PlayerPrefs.SetInt("time10Lvl2",time10List[i-1]);
						s10button.gameObject.SetActive(true);
						s10bar.gameObject.SetActive(false);
					}
					else if(s10Level == i && i==2)
					{
						bullet10 = bullet10List[i-1];	
						s10button.gameObject.SetActive(false);
						s10bar.gameObject.SetActive(false);
						s10Max.gameObject.SetActive(true);
						s10BulletBar.fillAmount = 1;
					}
				}
				PlayerPrefs.SetInt("s10Bullet",bullet10);
				PlayerPrefs.SetInt("s10BulletNext",bullet10NextLevel);

				s10LevelInidcatorText.text = "LVL:\n"+s10Level+"/2";
				isUpgradingS10 = false;

				s1button.interactable = true;
				s2button.interactable = true;
				s3button.interactable = true;
				s4button.interactable = true;
				s5button.interactable = true;
				s6button.interactable = true;
				s7button.interactable = true;
				s8button.interactable = true;
				s9button.interactable = true;
				s11button.interactable = true;
				s12button.interactable = true;
				s10LevelInidcator.fillAmount+=0.5f;
				StartCoroutine(playS10UpgradeAnim());
			} 
		}

		else if (isUpgradingS11 == true){
			PlayerPrefs.SetInt("upgrading",11);
			s11rotator.gameObject.SetActive(true);
			s1button.interactable = false;
			s2button.interactable = false;
			s3button.interactable = false;
			s4button.interactable = false;
			s5button.interactable = false;
			s6button.interactable = false;
			s7button.interactable = false;
			s8button.interactable = false;
			s9button.interactable = false;
			s10button.interactable = false;
			s12button.interactable = false;
			if(s11lvl2.CurrentVal >0){
				s11lvl2.CurrentVal -= Time.deltaTime;
			}
			else{
				StartCoroutine(upgradeSound());
				soldierPageAnim.SetTrigger("upgrade");
				PlayerPrefs.SetInt("upgrading",0);
				zeroSpeedUpUsed();
				notification.gameObject.SetActive(true);
				notificationText.text = "Congratulations! Skull Boy is now upgraded!";
				Invoke("turnOffNotification",3.5f);
				s11rotator.gameObject.SetActive(false);
				s11Level ++;
				PlayerPrefs.SetInt("s11level",s11Level);
				s11LevelText.text = "Level\n"+ s11Level.ToString();
				for(int i = 1; i <= 3; i++)
				{
					if(s11Level == i && i!=3)
					{
						bullet11 = bullet11List[i-1];										
						bullet11NextLevel = bullet11List[i];
						s11lvl2.MaxVal = time11List[i-1];
						s11lvl2.CurrentVal = time11List[i-1];
						PlayerPrefs.SetInt("time11Lvl2",time11List[i-1]);
						s11button.gameObject.SetActive(true);
						s11bar.gameObject.SetActive(false);
					}
					else if(s11Level == i && i==3)
					{
						bullet11 = bullet11List[i-1];		
						s11button.gameObject.SetActive(false);
						s11bar.gameObject.SetActive(false);
						s11Max.gameObject.SetActive(true);
						s11BulletBar.fillAmount = 1;
					}
				}
				PlayerPrefs.SetInt("s11Bullet",bullet11);
				PlayerPrefs.SetInt("s11BulletNext",bullet11NextLevel);

				s11LevelInidcatorText.text = "LVL:\n"+s11Level+"/3";

				isUpgradingS11 = false;
				s1button.interactable = true;
				s2button.interactable = true;
				s3button.interactable = true;
				s4button.interactable = true;
				s5button.interactable = true;
				s6button.interactable = true;
				s7button.interactable = true;
				s8button.interactable = true;
				s9button.interactable = true;
				s10button.interactable = true;
				s12button.interactable = true;
				s11LevelInidcator.fillAmount+=0.33333f;
				StartCoroutine(playS11UpgradeAnim());
			} 
		}
		else if (isUpgradingS12 == true){
			PlayerPrefs.SetInt("upgrading",12);
			s12rotator.gameObject.SetActive(true);
			s1button.interactable = false;
			s2button.interactable = false;
			s3button.interactable = false;
			s4button.interactable = false;
			s5button.interactable = false;
			s6button.interactable = false;
			s7button.interactable = false;
			s8button.interactable = false;
			s9button.interactable = false;
			s10button.interactable = false;
			s11button.interactable = false;
			if(s12.CurrentVal >0){
				s12.CurrentVal -= Time.deltaTime;
			}
			else{
				PlayerPrefs.SetInt("knightUnlocked",1);
				StartCoroutine(upgradeSound());
				soldierPageAnim.SetTrigger("upgrade");
				notification.gameObject.SetActive(true);
				notificationText.text = "Congratulations! You unlocked G'Venik the Defender!";
				Invoke("turnOffNotification",3.5f);
				PlayerPrefs.SetInt("upgrading",0);
				zeroSpeedUpUsed();
				s12rotator.gameObject.SetActive(false);
				s12button.gameObject.SetActive(false);
				s12Max.gameObject.SetActive(true);
				s12bar.gameObject.SetActive(false);
				isUpgradingS12 = false;

				s2button.interactable = true;
				s3button.interactable = true;
				s4button.interactable = true;
				s5button.interactable = true;
				s6button.interactable = true;
				s7button.interactable = true;
				s8button.interactable = true;
				s9button.interactable = true;
				s10button.interactable = true;
				s11button.interactable = true;
			} 
		}
		
	}

	IEnumerator upgradeSound()
	{
		MainMenu.Instance.AudioSource.PlayOneShot(SoundManager.Instance.Upgrade);
		yield return new WaitForSeconds(0.7f);
		MainMenu.Instance.AudioSource.PlayOneShot(SoundManager.Instance.Upgrade);
		yield return new WaitForSeconds(0.7f);
		MainMenu.Instance.AudioSource.PlayOneShot(SoundManager.Instance.Upgrade);
	}

	public void zeroSpeedUpUsed()
	{
		numOf5minUsed=0;
		numOf10minUsed=0;
		numOf15minUsed=0;
		numOf30minUsed=0;
		numOf60minUsed=0;
		numOf3hrsUsed=0;
		PlayerPrefs.SetInt("5minUsed",0);
		PlayerPrefs.SetInt("10minUsed",0);
		PlayerPrefs.SetInt("15minUsed",0);
		PlayerPrefs.SetInt("30minUsed",0);
		PlayerPrefs.SetInt("60minUsed",0);
		PlayerPrefs.SetInt("3hrsUsed",0);
	}

	public void cancelUpgrade(){
		MainMenu.Instance.AudioSource.PlayOneShot(SoundManager.Instance.Click9);
		zeroSpeedUpUsed();
		PlayerPrefs.SetInt("upgrading",0);
		s1button.interactable = true;
		s2button.interactable = true;
		s3button.interactable = true;
		s4button.interactable = true;
		s5button.interactable = true;
		s6button.interactable = true;
		s7button.interactable = true;
		s8button.interactable = true;
		s9button.interactable = true;
		s10button.interactable = true;
		s11button.interactable = true;
		s12button.interactable = true;
		if(isUpgradingS1 == true)
		{
			isUpgradingS1 = false;
			s1button.gameObject.SetActive(true);
			s1bar.gameObject.SetActive(false);
			s1lvl1.CurrentVal = s1lvl1.MaxVal;
			s1rotator.gameObject.SetActive(false);
		}
		else if(isUpgradingS2 == true)
		{
			isUpgradingS2 = false;
			s2button.gameObject.SetActive(true);
			s2bar.gameObject.SetActive(false);
			s2lvl2.CurrentVal = s2lvl2.MaxVal;
			s2rotator.gameObject.SetActive(false);
		}
		else if(isUpgradingS3 == true)
		{
			isUpgradingS3 = false;
			s3button.gameObject.SetActive(true);
			s3bar.gameObject.SetActive(false);
			s3lvl2.CurrentVal = s3lvl2.MaxVal;
			s3rotator.gameObject.SetActive(false);
		}
		else if(isUpgradingS4 == true)
		{
			isUpgradingS4 = false;
			s4button.gameObject.SetActive(true);
			s4bar.gameObject.SetActive(false);
			s4lvl2.CurrentVal = s4lvl2.MaxVal;
			s4rotator.gameObject.SetActive(false);
		}
		else if(isUpgradingS5 == true)
		{
			isUpgradingS5 = false;
			s5button.gameObject.SetActive(true);
			s5bar.gameObject.SetActive(false);
			s5lvl2.CurrentVal = s5lvl2.MaxVal;
			s5rotator.gameObject.SetActive(false);
		}
		else if(isUpgradingS6 == true)
		{
			isUpgradingS6 = false;
			s6button.gameObject.SetActive(true);
			s6bar.gameObject.SetActive(false);
			s6lvl2.CurrentVal = s6lvl2.MaxVal;
			s6rotator.gameObject.SetActive(false);
		}
		else if(isUpgradingS7 == true)
		{
			isUpgradingS7 = false;
			s7button.gameObject.SetActive(true);
			s7bar.gameObject.SetActive(false);
			s7lvl2.CurrentVal = s7lvl2.MaxVal;
			s7rotator.gameObject.SetActive(false);
		}
		else if(isUpgradingS8 == true)
		{
			isUpgradingS8 = false;
			s8button.gameObject.SetActive(true);
			s8bar.gameObject.SetActive(false);
			s8lvl2.CurrentVal = s8lvl2.MaxVal;
			s8rotator.gameObject.SetActive(false);
		}
		else if(isUpgradingS9 == true)
		{
			isUpgradingS9 = false;
			s9button.gameObject.SetActive(true);
			s9bar.gameObject.SetActive(false);
			s9lvl2.CurrentVal = s9lvl2.MaxVal;
			s9rotator.gameObject.SetActive(false);
		}
		else if(isUpgradingS10 == true)
		{
			isUpgradingS10 = false;
			s10button.gameObject.SetActive(true);
			s10bar.gameObject.SetActive(false);
			s10lvl2.CurrentVal = s10lvl2.MaxVal;
			s10rotator.gameObject.SetActive(false);
		}
		else if(isUpgradingS11 == true)
		{
			isUpgradingS11 = false;
			s11button.gameObject.SetActive(true);
			s11bar.gameObject.SetActive(false);
			s11lvl2.CurrentVal = s11lvl2.MaxVal;
			s11rotator.gameObject.SetActive(false);
		}
		else if(isUpgradingS12 == true)
		{
			isUpgradingS12 = false;
			s12button.gameObject.SetActive(true);
			s12bar.gameObject.SetActive(false);
			s12.CurrentVal = s12.MaxVal;
			s12rotator.gameObject.SetActive(false);
		}
	}
	[SerializeField]
	private Image areYouSure;

	private int numOf5minUsed=0;
	private int numOf10minUsed=0;
	private int numOf15minUsed=0;
	private int numOf30minUsed=0;
	private int numOf60minUsed=0;
	private int numOf3hrsUsed=0;

	public void use5Min()
	{
		if(min5 > 0)
		{	MainMenu.Instance.AudioSource.PlayOneShot(SoundManager.Instance.UseSpeedUp);
			numOf5minUsed+=1;
			PlayerPrefs.SetInt("5minUsed",numOf5minUsed);
			min5-=1;
			PlayerPrefs.SetInt("5min",min5);
			numOf5min.text = "Have: "+PlayerPrefs.GetInt("5min").ToString();
			if(isUpgradingS1 == true)
			{s1lvl1.CurrentVal -=300;}
			else if(isUpgradingS2 == true)
			{s2lvl2.CurrentVal -=300;}
			else if(isUpgradingS3 == true)
			{s3lvl2.CurrentVal -=300;}
			else if(isUpgradingS4 == true)
			{s4lvl2.CurrentVal -=300;}
			else if(isUpgradingS5 == true)
			{s5lvl2.CurrentVal -=300;}
			else if(isUpgradingS6 == true)
			{s6lvl2.CurrentVal -=300;}
			else if(isUpgradingS7 == true)
			{s7lvl2.CurrentVal -=300;}
			else if(isUpgradingS8 == true)
			{s8lvl2.CurrentVal -=300;}
			else if(isUpgradingS9 == true)
			{s9lvl2.CurrentVal -=300;}
			else if(isUpgradingS10 == true)
			{s10lvl2.CurrentVal -=300;}
			else if(isUpgradingS11 == true)
			{s11lvl2.CurrentVal -=300;}
			else if(isUpgradingS12 == true)
			{s12.CurrentVal -=300;}
		}
		else{
			if(PlayerPrefs.GetInt("shopOpen")==0)
			{
				MainMenu.Instance.AudioSource.PlayOneShot(SoundManager.Instance.Click7);
			}
			else{
				MainMenu.Instance.AudioSource.PlayOneShot(SoundManager.Instance.Click6);
				areYouSure.gameObject.SetActive(true);
			}
			
		}
	}

	public void use10Min()
	{
		if(min10 > 0)
		{	MainMenu.Instance.AudioSource.PlayOneShot(SoundManager.Instance.UseSpeedUp);
			numOf10minUsed+=1;
			PlayerPrefs.SetInt("10minUsed",numOf10minUsed);
			min10-=1;
			PlayerPrefs.SetInt("10min",min10);
			numOf10min.text = "Have: "+PlayerPrefs.GetInt("10min").ToString();
			if(isUpgradingS1 == true)
			{s1lvl1.CurrentVal -=600;}
			else if(isUpgradingS2 == true)
			{s2lvl2.CurrentVal -=600;}
			else if(isUpgradingS3 == true)
			{s3lvl2.CurrentVal -=600;}
			else if(isUpgradingS4 == true)
			{s4lvl2.CurrentVal -=600;}
			else if(isUpgradingS5 == true)
			{s5lvl2.CurrentVal -=600;}
			else if(isUpgradingS6 == true)
			{s6lvl2.CurrentVal -=600;}
			else if(isUpgradingS7 == true)
			{s7lvl2.CurrentVal -=600;}
			else if(isUpgradingS8 == true)
			{s8lvl2.CurrentVal -=600;}
			else if(isUpgradingS9 == true)
			{s9lvl2.CurrentVal -=600;}
			else if(isUpgradingS10 == true)
			{s10lvl2.CurrentVal -=600;}
			else if(isUpgradingS11 == true)
			{s11lvl2.CurrentVal -=600;}
			else if(isUpgradingS12 == true)
			{s12.CurrentVal -=600;}
		}
		else{
			if(PlayerPrefs.GetInt("shopOpen")==0)
			{
				MainMenu.Instance.AudioSource.PlayOneShot(SoundManager.Instance.Click7);
			}
			else{
				MainMenu.Instance.AudioSource.PlayOneShot(SoundManager.Instance.Click6);
				areYouSure.gameObject.SetActive(true);
			}
		}
	}

	public void use15Min()
	{
		if(min15 > 0)
		{	MainMenu.Instance.AudioSource.PlayOneShot(SoundManager.Instance.UseSpeedUp);
			numOf15minUsed+=1;
			PlayerPrefs.SetInt("15minUsed",numOf15minUsed);
			min15-=1;
			PlayerPrefs.SetInt("15min",min15);
			numOf15min.text = "Have: "+PlayerPrefs.GetInt("15min").ToString();
			if(isUpgradingS1 == true)
			{s1lvl1.CurrentVal -=900;}
			else if(isUpgradingS2 == true)
			{s2lvl2.CurrentVal -=900;}
			else if(isUpgradingS3 == true)
			{s3lvl2.CurrentVal -=900;}
			else if(isUpgradingS4 == true)
			{s4lvl2.CurrentVal -=900;}
			else if(isUpgradingS5 == true)
			{s5lvl2.CurrentVal -=900;}
			else if(isUpgradingS6 == true)
			{s6lvl2.CurrentVal -=900;}
			else if(isUpgradingS7 == true)
			{s7lvl2.CurrentVal -=900;}
			else if(isUpgradingS8 == true)
			{s8lvl2.CurrentVal -=900;}
			else if(isUpgradingS9 == true)
			{s9lvl2.CurrentVal -=900;}
			else if(isUpgradingS10 == true)
			{s10lvl2.CurrentVal -=900;}
			else if(isUpgradingS11 == true)
			{s11lvl2.CurrentVal -=900;}
			else if(isUpgradingS12 == true)
			{s12.CurrentVal -=900;}
		}
		else{
			if(PlayerPrefs.GetInt("shopOpen")==0)
			{
				MainMenu.Instance.AudioSource.PlayOneShot(SoundManager.Instance.Click7);
			}
			else{
				MainMenu.Instance.AudioSource.PlayOneShot(SoundManager.Instance.Click6);
				areYouSure.gameObject.SetActive(true);
			}
		}
	}

	public void use30Min()
	{
		if(min30 > 0)
		{	MainMenu.Instance.AudioSource.PlayOneShot(SoundManager.Instance.UseSpeedUp);
			numOf30minUsed+=1;
			PlayerPrefs.SetInt("30minUsed",numOf30minUsed);
			min30-=1;
			PlayerPrefs.SetInt("30min",min30);
			numOf30min.text = "Have: "+PlayerPrefs.GetInt("30min").ToString();
			if(isUpgradingS1 == true)
			{s1lvl1.CurrentVal -=1800;}
			else if(isUpgradingS2 == true)
			{s2lvl2.CurrentVal -=1800;}
			else if(isUpgradingS3 == true)
			{s3lvl2.CurrentVal -=1800;}
			else if(isUpgradingS4 == true)
			{s4lvl2.CurrentVal -=1800;}
			else if(isUpgradingS5 == true)
			{s5lvl2.CurrentVal -=1800;}
			else if(isUpgradingS6 == true)
			{s6lvl2.CurrentVal -=1800;}
			else if(isUpgradingS7 == true)
			{s7lvl2.CurrentVal -=1800;}
			else if(isUpgradingS8 == true)
			{s8lvl2.CurrentVal -=1800;}
			else if(isUpgradingS9 == true)
			{s9lvl2.CurrentVal -=1800;}
			else if(isUpgradingS10 == true)
			{s10lvl2.CurrentVal -=1800;}
			else if(isUpgradingS11 == true)
			{s11lvl2.CurrentVal -=1800;}
			else if(isUpgradingS12 == true)
			{s12.CurrentVal -=1800;}
		}
		else{
			if(PlayerPrefs.GetInt("shopOpen")==0)
			{
				MainMenu.Instance.AudioSource.PlayOneShot(SoundManager.Instance.Click7);
			}
			else{
				MainMenu.Instance.AudioSource.PlayOneShot(SoundManager.Instance.Click6);
				areYouSure.gameObject.SetActive(true);
			}
		}
	}

	public void use60()
	{
		if(min60 > 0)
		{	MainMenu.Instance.AudioSource.PlayOneShot(SoundManager.Instance.UseSpeedUp);
			numOf60minUsed+=1;
			PlayerPrefs.SetInt("60minUsed",numOf60minUsed);
			min60-=1;
			PlayerPrefs.SetInt("60min",min60);
			numOf60min.text = "Have: "+PlayerPrefs.GetInt("60min").ToString();
			if(isUpgradingS1 == true)
			{s1lvl1.CurrentVal -=3600;}
			else if(isUpgradingS2 == true)
			{s2lvl2.CurrentVal -=3600;}
			else if(isUpgradingS3 == true)
			{s3lvl2.CurrentVal -=3600;}
			else if(isUpgradingS4 == true)
			{s4lvl2.CurrentVal -=3600;}
			else if(isUpgradingS5 == true)
			{s5lvl2.CurrentVal -=3600;}
			else if(isUpgradingS6 == true)
			{s6lvl2.CurrentVal -=3600;}
			else if(isUpgradingS7 == true)
			{s7lvl2.CurrentVal -=3600;}
			else if(isUpgradingS8 == true)
			{s8lvl2.CurrentVal -=3600;}
			else if(isUpgradingS9 == true)
			{s9lvl2.CurrentVal -=3600;}
			else if(isUpgradingS10 == true)
			{s10lvl2.CurrentVal -=3600;}
			else if(isUpgradingS11 == true)
			{s11lvl2.CurrentVal -=3600;}
			else if(isUpgradingS12 == true)
			{s12.CurrentVal -=3600;}
		}
		else{
			if(PlayerPrefs.GetInt("shopOpen")==0)
			{
				MainMenu.Instance.AudioSource.PlayOneShot(SoundManager.Instance.Click7);
			}
			else{
				MainMenu.Instance.AudioSource.PlayOneShot(SoundManager.Instance.Click6);
				areYouSure.gameObject.SetActive(true);
			}
		}
	}

	public void use3hrs()
	{
		if(hrs3 > 0)
		{	MainMenu.Instance.AudioSource.PlayOneShot(SoundManager.Instance.UseSpeedUp);
			numOf3hrsUsed+=1;
			PlayerPrefs.SetInt("3hrsUsed",numOf3hrsUsed);
			hrs3-=1;
			PlayerPrefs.SetInt("3hrs",hrs3);
			numOf3hrs.text = "Have: "+PlayerPrefs.GetInt("3hrs").ToString();
			if(isUpgradingS1 == true)
			{s1lvl1.CurrentVal -=10800;}
			else if(isUpgradingS2 == true)
			{s2lvl2.CurrentVal -=10800;}
			else if(isUpgradingS3 == true)
			{s3lvl2.CurrentVal -=10800;}
			else if(isUpgradingS4 == true)
			{s4lvl2.CurrentVal -=10800;}
			else if(isUpgradingS5 == true)
			{s5lvl2.CurrentVal -=10800;}
			else if(isUpgradingS6 == true)
			{s6lvl2.CurrentVal -=10800;}
			else if(isUpgradingS7 == true)
			{s7lvl2.CurrentVal -=10800;}
			else if(isUpgradingS8 == true)
			{s8lvl2.CurrentVal -=10800;}
			else if(isUpgradingS9 == true)
			{s9lvl2.CurrentVal -=10800;}
			else if(isUpgradingS10 == true)
			{s10lvl2.CurrentVal -=10800;}
			else if(isUpgradingS11 == true)
			{s11lvl2.CurrentVal -=10800;}
			else if(isUpgradingS12 == true)
			{s12.CurrentVal -=10800;}
		}
		else{
			if(PlayerPrefs.GetInt("shopOpen")==0)
			{
				MainMenu.Instance.AudioSource.PlayOneShot(SoundManager.Instance.Click7);
			}
			else{
				MainMenu.Instance.AudioSource.PlayOneShot(SoundManager.Instance.Click6);
				areYouSure.gameObject.SetActive(true);
			}
		}
	}

	public void openSpeedUp(){
		MainMenu.Instance.AudioSource.PlayOneShot(SoundManager.Instance.Click3);
		soldierInventory.SetActive(false);
		closeBtn.gameObject.SetActive(false);
		s1SpeedUp.gameObject.SetActive(false);
		s2SpeedUp.gameObject.SetActive(false);
		s3SpeedUp.gameObject.SetActive(false);
		s4SpeedUp.gameObject.SetActive(false);
		s5SpeedUp.gameObject.SetActive(false);
		s6SpeedUp.gameObject.SetActive(false);
		s7SpeedUp.gameObject.SetActive(false);
		s8SpeedUp.gameObject.SetActive(false);
		s9SpeedUp.gameObject.SetActive(false);
		s10SpeedUp.gameObject.SetActive(false);
		s11SpeedUp.gameObject.SetActive(false);
		s12SpeedUp.gameObject.SetActive(false);
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
		speedUpObj.SetActive(true);
		if(PlayerPrefs.GetInt("armyIntroDone") == 0 && s1Level == 1)
		{
			directionsAnim.SetTrigger("next2");
			directionsText.text = "";
			Invoke("changeText",1.0f);
		}
	}

	public void changeText()
	{
		directionsText.text = "Here is a small gift for you: 5min x2. Use one of them now!";
	}


	public void closeSpeedUp(){
		MainMenu.Instance.AudioSource.PlayOneShot(SoundManager.Instance.Click5);
		if(PlayerPrefs.GetInt("armyIntroDone") == 0)
		{
			directions.SetActive(false);
			closeBtn.interactable = true;
			closeSpeedUpDirections.SetActive(false);
			PlayerPrefs.SetInt("armyIntroDone",1);
		}
		soldierInventory.SetActive(true);
		closeBtn.gameObject.SetActive(true);
		s1SpeedUp.gameObject.SetActive(true);
		s2SpeedUp.gameObject.SetActive(true);
		s3SpeedUp.gameObject.SetActive(true);
		s4SpeedUp.gameObject.SetActive(true);
		s5SpeedUp.gameObject.SetActive(true);
		s6SpeedUp.gameObject.SetActive(true);
		s7SpeedUp.gameObject.SetActive(true);
		s8SpeedUp.gameObject.SetActive(true);
		s9SpeedUp.gameObject.SetActive(true);
		s10SpeedUp.gameObject.SetActive(true);
		s11SpeedUp.gameObject.SetActive(true);
		s12SpeedUp.gameObject.SetActive(true);
		speedUpObj.SetActive(false);
	}

	public void goToShop(){
		soldierInventory.SetActive(true);
		closeBtn.gameObject.SetActive(true);
		s1SpeedUp.gameObject.SetActive(true);
		s2SpeedUp.gameObject.SetActive(true);
		s3SpeedUp.gameObject.SetActive(true);
		s4SpeedUp.gameObject.SetActive(true);
		s5SpeedUp.gameObject.SetActive(true);
		s6SpeedUp.gameObject.SetActive(true);
		s7SpeedUp.gameObject.SetActive(true);
		s8SpeedUp.gameObject.SetActive(true);
		s9SpeedUp.gameObject.SetActive(true);
		s10SpeedUp.gameObject.SetActive(true);
		s11SpeedUp.gameObject.SetActive(true);
		s12SpeedUp.gameObject.SetActive(true);
		speedUpObj.SetActive(false);
		soldierList.SetActive(false);
		
	}

	[SerializeField]
	private GameObject directions;
	[SerializeField]
	private Text directionsText;
	private Animator directionsAnim;

	public void cha()
	{
		directionsText.text = "Fastforward the upgrading process!";
	}

	public void updateS1Lvl2(){
		if(s1Level==1 && PlayerPrefs.GetInt("armyIntroDone") == 0)
		{
			directionsAnim.SetTrigger("next1");
			directionsText.text = "";
			Invoke("cha",0.5f);
		}
		MainMenu.Instance.AudioSource.PlayOneShot(SoundManager.Instance.Click4);
		s1button.gameObject.SetActive(false);
		s1bar.gameObject.SetActive(true);
		isUpgradingS1 = true;
		TimeMaster.instance.SaveDate();
	}

	public void updateS2(){
		MainMenu.Instance.AudioSource.PlayOneShot(SoundManager.Instance.Click4);
		s2button.gameObject.SetActive(false);
		s2bar.gameObject.SetActive(true);
		isUpgradingS2 = true;
		TimeMaster.instance.SaveDate();
	}

	public void updateS3(){
		MainMenu.Instance.AudioSource.PlayOneShot(SoundManager.Instance.Click4);
		s3button.gameObject.SetActive(false);
		s3bar.gameObject.SetActive(true);
		isUpgradingS3 = true;
		TimeMaster.instance.SaveDate();
	}
	public void updateS4(){
		MainMenu.Instance.AudioSource.PlayOneShot(SoundManager.Instance.Click4);
		s4button.gameObject.SetActive(false);
		s4bar.gameObject.SetActive(true);
		isUpgradingS4 = true;
		TimeMaster.instance.SaveDate();
	}
	public void updateS5(){
		MainMenu.Instance.AudioSource.PlayOneShot(SoundManager.Instance.Click4);
		s5button.gameObject.SetActive(false);
		s5bar.gameObject.SetActive(true);
		isUpgradingS5 = true;
		TimeMaster.instance.SaveDate();
	}
	public void updateS6(){
		MainMenu.Instance.AudioSource.PlayOneShot(SoundManager.Instance.Click4);
		s6button.gameObject.SetActive(false);
		s6bar.gameObject.SetActive(true);
		isUpgradingS6 = true;
		TimeMaster.instance.SaveDate();
	}
	public void updateS7(){
		MainMenu.Instance.AudioSource.PlayOneShot(SoundManager.Instance.Click4);
		s7button.gameObject.SetActive(false);
		s7bar.gameObject.SetActive(true);
		isUpgradingS7 = true;
		TimeMaster.instance.SaveDate();
	}
	public void updateS8(){
		MainMenu.Instance.AudioSource.PlayOneShot(SoundManager.Instance.Click4);
		s8button.gameObject.SetActive(false);
		s8bar.gameObject.SetActive(true);
		isUpgradingS8 = true;
		TimeMaster.instance.SaveDate();
	}
	public void updateS9(){
		MainMenu.Instance.AudioSource.PlayOneShot(SoundManager.Instance.Click4);
		s9button.gameObject.SetActive(false);
		s9bar.gameObject.SetActive(true);
		isUpgradingS9 = true;
		TimeMaster.instance.SaveDate();
	}
	public void updateS10(){
		MainMenu.Instance.AudioSource.PlayOneShot(SoundManager.Instance.Click4);
		s10button.gameObject.SetActive(false);
		s10bar.gameObject.SetActive(true);
		isUpgradingS10 = true;
		TimeMaster.instance.SaveDate();
	}
	public void updateS11(){
		MainMenu.Instance.AudioSource.PlayOneShot(SoundManager.Instance.Click4);
		s11button.gameObject.SetActive(false);
		s11bar.gameObject.SetActive(true);
		isUpgradingS11 = true;
		TimeMaster.instance.SaveDate();
	}

	public void updateS12(){
		MainMenu.Instance.AudioSource.PlayOneShot(SoundManager.Instance.Click4);
		s12button.gameObject.SetActive(false);
		s12bar.gameObject.SetActive(true);
		isUpgradingS12 = true;
		TimeMaster.instance.SaveDate(); 
	}*/
	
}
