using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI; 


public enum gameStatus{
	play, gameover, win, pause , next
}

public class GameManager : Singleton<GameManager> {
	[SerializeField]
	private int totalWaves = 30;

	public int levelNumber = 0;
	public int LevelNumber{
		get{
			return levelNumber;
		}
		set{
			levelNumber = value;
		}
	}

	private int totalMoney = 100;
	

	[SerializeField]
	private GameObject pauseMenu;
	[SerializeField]
	private Button pauseBtn;
	[SerializeField]
	private GameObject winningMenu;
	[SerializeField]
	private GameObject winningMenuNoNewSoldier;
	[SerializeField]
	private GameObject chooseSoldierMenu;
	[SerializeField]
	private GameObject gameOverMenu;
	[SerializeField]
	private Button playBtn;
	

	[SerializeField]
	private SoldierBtn s2Button;
	[SerializeField]
	private Image s2Lock;
	[SerializeField]
	private SoldierBtn s3Button;
	[SerializeField]
	private Image s3Lock;
	[SerializeField]
	private SoldierBtn s4Button;
	[SerializeField]
	private Image s4Lock;
	[SerializeField]
	private SoldierBtn s5Button;
	[SerializeField]
	private Image s5Lock;
	[SerializeField]
	private SoldierBtn s6Button;
	[SerializeField]
	private Image s6Lock;
	[SerializeField]
	private SoldierBtn s7Button;
	[SerializeField]
	private Image s7Lock;
	[SerializeField]
	private SoldierBtn s8Button;
	[SerializeField]
	private Image s8Lock;
	[SerializeField]
	private SoldierBtn pumpkButton;
	[SerializeField]
	private Image pumpkLock;
	[SerializeField]
	private SoldierBtn granadeButton;
	[SerializeField]
	private Image granadeLock;
	[SerializeField]
	private SoldierBtn skullyButton;
	[SerializeField]
	private Image skullyLock;
	[SerializeField]
	private SoldierBtn knightButton;
	[SerializeField]
	private Image knightLock;

	[SerializeField]
	private Text levelNumberText;
	[SerializeField]
	private Button unlock;

	[SerializeField]
	private Image dollarSign;
	[SerializeField]
	private Image gemSign;
	[SerializeField]
	private Text rewardMoneyWinningMenu;
	[SerializeField]
	private Text rewardGemWinningMeny;

	[SerializeField]
	private Image dollarSignNoNewSoldiers;
	[SerializeField]
	private Image gemSignnNoNewSoldier;
	[SerializeField]
	private Text rewardMoneyWinningMenuNoNewSoldiers;
	[SerializeField]
	private Text rewardGemWinningMenyNoNewSoldier;

	[SerializeField]
	private Image s2image;
	[SerializeField]
	private Text s2desc;
	private Animator s2unlockAnimator;
	[SerializeField]
	private Image s3image;
	[SerializeField]
	private Text s3desc;
	private Animator s3unlockAnimator;
	[SerializeField]
	private Image s4image;
	[SerializeField]
	private Text s4desc;
	private Animator s4unlockAnimator;
	[SerializeField]
	private Image s5image;
	[SerializeField]
	private Text s5desc;
	private Animator s5unlockAnimator;
	[SerializeField]
	private Image s6image;
	[SerializeField]
	private Text s6desc;
	private Animator s6unlockAnimator;
	[SerializeField]
	private Image s7image;
	[SerializeField]
	private Text s7desc;
	private Animator s7unlockAnimator;
	[SerializeField]
	private Image s8image;
	[SerializeField]
	private Text s8desc;
	private Animator s8unlockAnimator;
	[SerializeField]
	private Image pumpkImage;
	[SerializeField]
	private Text pumpkdesc;
	private Animator pumpkunlockAnimator;
	[SerializeField]
	private Image skullImage;
	[SerializeField]
	private Text skulldesc;
	private Animator skullunlockAnimator;
	[SerializeField]
	private Image granadeImage;
	[SerializeField]
	private Text granadedesc;
	private Animator granadeunlockAnimator;
	[SerializeField]
	private Image knightImage;
	[SerializeField]
	private Text knightdesc;
	


	public void unlockMethod(){
		next.interactable = true;
		homeBtn.interactable = true;
		audioSource.PlayOneShot(SoundManager.Instance.Win2);
		if(s2image.gameObject.activeSelf)
		{
			s2unlockAnimator.SetTrigger("s2moveaside");
			Invoke("a",0.8f);
			unlock.gameObject.SetActive(false);
			s2Button.gameObject.SetActive(true);
			s2Lock.gameObject.SetActive(false);
		}
		else if(s3image.gameObject.activeSelf)
		{
			s3unlockAnimator.SetTrigger("s3moveAside");
			Invoke("b",0.5f);
			unlock.gameObject.SetActive(false);
			s3Button.gameObject.SetActive(true);
			s3Lock.gameObject.SetActive(false);
		}
		else if(s4image.gameObject.activeSelf)
		{
			s4unlockAnimator.SetTrigger("s4moveAside");
			Invoke("c",0.35f);
			unlock.gameObject.SetActive(false);
			s4Button.gameObject.SetActive(true);
			s4Lock.gameObject.SetActive(false);
		}
		else if(s5image.gameObject.activeSelf)
		{
			s5unlockAnimator.SetTrigger("s5moveAside");
			Invoke("d",0.45f);
			unlock.gameObject.SetActive(false);
			s5Button.gameObject.SetActive(true);
			s5Lock.gameObject.SetActive(false);
		}
		else if(s6image.gameObject.activeSelf)
		{
			s6unlockAnimator.SetTrigger("s6moveAside");
			Invoke("e",0.40f);
			unlock.gameObject.SetActive(false);
			s6Button.gameObject.SetActive(true);
			s6Lock.gameObject.SetActive(false);
		}
		else if(s7image.gameObject.activeSelf)
		{
			s7unlockAnimator.SetTrigger("s7moveAside");
			Invoke("f",0.4f);
			unlock.gameObject.SetActive(false);
			s7Button.gameObject.SetActive(true);
			s7Lock.gameObject.SetActive(false);
		}
		else if(s8image.gameObject.activeSelf)
		{
			s8unlockAnimator.SetTrigger("s8moveAside");
			Invoke("g",0.45f);
			unlock.gameObject.SetActive(false);
			s8Button.gameObject.SetActive(true);
			s8Lock.gameObject.SetActive(false);
		}
		else if(pumpkImage.gameObject.activeSelf)
		{
			pumpkunlockAnimator.SetTrigger("pumpkmoveAside");
			Invoke("i",0.8f);
			unlock.gameObject.SetActive(false);
			pumpkButton.gameObject.SetActive(true);
			pumpkLock.gameObject.SetActive(false);
		}
		else if(skullImage.gameObject.activeSelf)
		{
			skullunlockAnimator.SetTrigger("skullmoveAside");
			Invoke("k",0.5f);
			unlock.gameObject.SetActive(false);
			skullyButton.gameObject.SetActive(true);
			skullyLock.gameObject.SetActive(false);
		}
		else if(granadeImage.gameObject.activeSelf)
		{
			granadeunlockAnimator.SetTrigger("granademoveAside");
			Invoke("j",0.5f);
			unlock.gameObject.SetActive(false);
			granadeButton.gameObject.SetActive(true);
			granadeLock.gameObject.SetActive(false);
		}
		
	}
	public void a(){
		s2desc.gameObject.SetActive(true);
		s2desc.text = "Health: " + PlayerPrefs.GetInt("s2Health").ToString()+"\n\n"+"Energy: "+ PlayerPrefs.GetInt("s2Energy").ToString()+"\n\n"+"Bullet: "+PlayerPrefs.GetInt("s2Bullet").ToString();
		s2unlockAnimator.SetTrigger("s2unlocked");
	}
	public void b(){
		s3desc.gameObject.SetActive(true);
		s3desc.text = "Health: " + PlayerPrefs.GetInt("s3Health").ToString()+"\n\n"+"Energy: "+ PlayerPrefs.GetInt("s3Energy").ToString()+"\n\n"+"Bullet: "+PlayerPrefs.GetInt("s3Bullet").ToString();
		s3unlockAnimator.SetTrigger("s3unlocked");
	}
	public void c(){
		s4desc.gameObject.SetActive(true);
		s4desc.text = "Health: " + PlayerPrefs.GetInt("s4Health").ToString()+"\n\n"+"Energy: "+ PlayerPrefs.GetInt("s4Energy").ToString()+"\n\n"+"Bullet: "+PlayerPrefs.GetInt("s4Bullet").ToString();
		s4unlockAnimator.SetTrigger("s4unlocked");
	}
	public void d(){
		s5desc.gameObject.SetActive(true);
		s5desc.text = "Health: " + PlayerPrefs.GetInt("s5Health").ToString()+"\n\n"+"Energy: "+ PlayerPrefs.GetInt("s5Energy").ToString()+"\n\n"+"Bullet: "+PlayerPrefs.GetInt("s5Bullet").ToString();
		s5unlockAnimator.SetTrigger("s5unlocked");
	}
	public void e(){
		s6desc.gameObject.SetActive(true);
		s6desc.text = "Health: " + PlayerPrefs.GetInt("s6Health").ToString()+"\n\n"+"Energy: "+ PlayerPrefs.GetInt("s6Energy").ToString()+"\n\n"+"Bullet: "+PlayerPrefs.GetInt("s6Bullet").ToString();
		s6unlockAnimator.SetTrigger("s6unlocked");
	}
	public void f(){
		s7desc.gameObject.SetActive(true);
		s7desc.text = "Health: " + PlayerPrefs.GetInt("s7Health").ToString()+"\n\n"+"Energy: "+ PlayerPrefs.GetInt("s7Energy").ToString()+"\n\n"+"Bullet: "+PlayerPrefs.GetInt("s7Bullet").ToString();
		s7unlockAnimator.SetTrigger("s7unlocked");
	}
	public void g(){
		s8desc.gameObject.SetActive(true);
		s8desc.text = "Health: " + PlayerPrefs.GetInt("s8Health").ToString()+"\n\n"+"Energy: "+ PlayerPrefs.GetInt("s8Energy").ToString()+"\n\n"+"Bullet: "+PlayerPrefs.GetInt("s8Bullet").ToString();
		s8unlockAnimator.SetTrigger("s8unlocked");
	}
	public void i(){
		pumpkdesc.gameObject.SetActive(true);
		pumpkdesc.text = "Attack: "+PlayerPrefs.GetInt("s10Bullet").ToString();
		pumpkunlockAnimator.SetTrigger("punlocked");
	}
	public void j(){
		granadedesc.gameObject.SetActive(true);
		granadedesc.text = "Attack: "+PlayerPrefs.GetInt("s9Bullet").ToString();
		granadeunlockAnimator.SetTrigger("gunlocked");
	}
	public void k(){
		skulldesc.gameObject.SetActive(true);
		skulldesc.text = "Bullet: "+PlayerPrefs.GetInt("s11Bullet").ToString();
		skullunlockAnimator.SetTrigger("sunlocked");
	}

	[SerializeField]
	private Text unlcokFromArmy;
	
	


	

	[SerializeField]
	private GameObject[] spawnPoint;
	[SerializeField]
	private GameObject[] sniperSpawnPoint;
	[SerializeField]
	private GameObject[] mercenerySpawnPoint;
	

	[SerializeField]
	private GameObject[] blochEnemies;
	[SerializeField]
	private GameObject[] mummyEnemies;
	[SerializeField]
	private GameObject[] scorpionEnemies;
	[SerializeField]
	private GameObject[] wolfEnemies;
	[SerializeField]
	private GameObject[] sniperEnemies;
	[SerializeField]
	private GameObject[] mercenery2Enemies;
	[SerializeField]
	private GameObject[] mercenery3Enemies;
	[SerializeField]
	private GameObject[] mercenery4Enemies;
	[SerializeField]
	private GameObject[] mercenery5Enemies;

	[SerializeField]
	private int totalEnemies;
	public int TotalEnemies{
		get{
			return totalEnemies;
		}
	}
	public int enemiesOnScreen=0;
	public int EnemiesOnScreen{
		get{
			return enemiesOnScreen;
		}
	}

	public int totalKilled = 0;
	public int TotalKilled{
		get{
			return totalKilled;
		}
		set{
			totalKilled = value;
		}
	}

	[SerializeField]
	private int totalMerceneries = 0;
	public int TotalMerceneries{
		get{
			return totalMerceneries;
		}
	}
	[SerializeField]
	public int merceneriesOnScreen = 0;

	public int totalMerceneriesKilled = 0;
	public int TotalMerceneriesKilled{
		get{
			return totalMerceneriesKilled;
		}
		set{
			totalMerceneriesKilled = value;
		}
	}
	

	[SerializeField]
	private int totalSnipers;
	[SerializeField]
	public int snipersOnScreen=0;
	

	


	
	private bool houseDown= false;

	public bool HouseDown{
		get{
			return houseDown;
		}
		set{
			houseDown = value;
		}
	}

	

	public void Home(){
		if(levelNumber == 1){
			PlayerPrefs.SetInt("armyOpen",1);
		}
		else if(levelNumber == 2){
			PlayerPrefs.SetInt("shopOpen",1);
		}
		else if(levelNumber == 3){
			PlayerPrefs.SetInt("labOpen",1);
		}
		else if(levelNumber == 4){
			PlayerPrefs.SetInt("labIntroDone",2);
		}
		else if(levelNumber == 7){
			PlayerPrefs.SetInt("sniperIntro",1);
		}
		else if(levelNumber == 15){
			PlayerPrefs.SetInt("mercIntro",1);
		}
		else if(levelNumber == 30){
			PlayerPrefs.SetInt("end",1);
		}
		LoadingScreenManager.LoadScene(1);
	}

	private gameStatus currentState = gameStatus.play;
	



	public List<Enemy> EnemyListLeft = new List<Enemy>();
	public List<Enemy> EnemyListUpLeft = new List<Enemy>();
	public List<Enemy> EnemyListButtomLeft = new List<Enemy>();
	public List<Enemy> EnemyListRight = new List<Enemy>();
	public List<Enemy> EnemyListUpRight = new List<Enemy>();
	public List<Enemy> EnemyListButtomRight = new List<Enemy>();

	public List<Merc2> MerceneryList1 = new List<Merc2>();
	public List<Merc2> MerceneryList2 = new List<Merc2>();
	public List<Merc2> MerceneryList3 = new List<Merc2>();
	public List<Merc2> MerceneryList4 = new List<Merc2>();

	

	const float spawnDelay=3f;

	public int TotalMoney{
		get{
			return totalMoney;
		}
		set{
			totalMoney = value;
			//Modify text 
		}
	}

	

	private GameObject Left1;
	private GameObject Left2;
	private GameObject Left3;
	private GameObject Left4;
	private GameObject Left5;
	private GameObject Left6;
	private Collider2D l1;
	private Collider2D l2;
	private Collider2D l3;
	private Collider2D l4;
	private Collider2D l5;
	private Collider2D l6;

	private GameObject LeftUp1;
	private GameObject LeftUp2;
	private GameObject LeftUp3;
	private GameObject LeftUp4;
	private GameObject LeftUp5;
	private GameObject LeftUp6;
	private Collider2D lU1;
	private Collider2D lU2;
	private Collider2D lU3;
	private Collider2D lU4;
	private Collider2D lU5;
	private Collider2D lU6;

	private GameObject LeftB1;
	private GameObject LeftB2;
	private GameObject LeftB3;
	private GameObject LeftB4;
	private GameObject LeftB5;
	private GameObject LeftB6;
	private Collider2D lB1;
	private Collider2D lB2;
	private Collider2D lB3;
	private Collider2D lB4;
	private Collider2D lB5;
	private Collider2D lB6;

	private GameObject Right1;
	private GameObject Right2;
	private GameObject Right3;
	private GameObject Right4;
	private GameObject Right5;
	private GameObject Right6;
	private Collider2D R1;
	private Collider2D R2;
	private Collider2D R3;
	private Collider2D R4;
	private Collider2D R5;
	private Collider2D R6;

	private GameObject RightUp1;
	private GameObject RightUp2;
	private GameObject RightUp3;
	private GameObject RightUp4;
	private GameObject RightUp5;
	private GameObject RightUp6;
	private Collider2D RU1;
	private Collider2D RU2;
	private Collider2D RU3;
	private Collider2D RU4;
	private Collider2D RU5;
	private Collider2D RU6;

	private GameObject RightB1;
	private GameObject RightB2;
	private GameObject RightB3;
	private GameObject RightB4;
	private GameObject RightB5;
	private GameObject RightB6;
	private Collider2D RB1;
	private Collider2D RB2;
	private Collider2D RB3;
	private Collider2D RB4;
	private Collider2D RB5;
	private Collider2D RB6;

	[SerializeField]
	private Image c1;
	[SerializeField]
	private Image c2;
	[SerializeField]
	private Image c3;
	private Animator chooseSMenu;

	[SerializeField]
	private Button energyButton;

	

	public void countdown(){
		soldierPanelAnim.SetTrigger("comeup");
		c1.gameObject.SetActive(true);
		audioSource.PlayOneShot(SoundManager.Instance.Star2,3f);
		Invoke("count2",1);
	}

	public void count2(){
		c1.gameObject.SetActive(false);
		c2.gameObject.SetActive(true);
		audioSource.PlayOneShot(SoundManager.Instance.Star2,3f);
		Invoke("count3",1);
	}

	public void count3(){
		c2.gameObject.SetActive(false);
		c3.gameObject.SetActive(true);
		audioSource.PlayOneShot(SoundManager.Instance.Star2,3f);
		Invoke("count4",1);
	}

	public void count4(){
		c3.gameObject.SetActive(false);
	}

	[SerializeField]
	private Text rewardMoneyText;
	[SerializeField]
	private Text rewardGemText;
	[SerializeField]
	private Text gameOverRewardMoneyText;
	[SerializeField]
	private Text gameOverRewardGemText;


	List<int> rewardMoneyList = new List<int>() { 60, 70, 80, 90, 100, 110, 120, 135, 150, 165, 180, 195, 210, 225, 240, 255, 270, 285, 300, 320, 340, 360, 380, 400, 420, 440, 460, 480, 500, 520,};
	List<int> rewardGemList = new List<int>() { 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 18, 20, 22, 24, 26, 28, 30, 32, 34, 36, 38, 40, 42, 44, 46, 48, 50, 52 };

	public void determineRewards()
	{
		for (int i = 0; i < 30; i++)
		{
			if(levelNumber == i)
			{
				rewardMoneyText.text = rewardMoneyList[i].ToString();
				rewardGemText.text = rewardGemList[i].ToString();
				gameOverRewardMoneyText.text = rewardMoneyList[i].ToString();
				gameOverRewardGemText.text = rewardGemList[i].ToString();
				rewardMoneyWinningMenu.text = rewardMoneyList[i].ToString();
				rewardGemWinningMeny.text = rewardGemList[i].ToString();
				rewardMoneyWinningMenuNoNewSoldiers.text = rewardMoneyList[i].ToString();
				rewardGemWinningMenyNoNewSoldier.text = rewardGemList[i].ToString();
			}
		}
	}

	private AudioSource audioSource;
	public AudioSource AudioSource
	{
		get{
			return audioSource;
		}
	}

	[SerializeField]
	private Button musicBtn;
	[SerializeField]
	private Sprite musicOnImage;
	[SerializeField]
	private Sprite musicOffImage;

	public void turnOffMusic()
	{
		if(SoundManager.Instance.BckgSource.enabled == true)
		{
			SoundManager.Instance.BckgSource.enabled = false;
			musicBtn.GetComponent<Image>().sprite = musicOffImage;
			PlayerPrefs.SetInt("music",0);
		}
		else{
			SoundManager.Instance.BckgSource.enabled = true;
			SoundManager.Instance.BckgSource.Stop();
			musicBtn.GetComponent<Image>().sprite = musicOnImage;
			PlayerPrefs.SetInt("music",1);
		}
	}

	[SerializeField]
	private Button soundBtn;
	[SerializeField]
	private Sprite soundOnImage;
	[SerializeField]
	private Sprite soundOffImage;

	public void turnOffSound()
	{
		if(audioSource.enabled == true)
		{
			audioSource.enabled = false;
			soundBtn.GetComponent<Image>().sprite = soundOffImage;
			PlayerPrefs.SetInt("sound",0);
		}
		else{
			audioSource.enabled = true;
			audioSource.Stop();
			soundBtn.GetComponent<Image>().sprite = soundOnImage;
			PlayerPrefs.SetInt("sound",1);
		}
	}

	[SerializeField]
	private GameObject number1;
	[SerializeField]
	private GameObject number2;
	[SerializeField]
	private GameObject number3;
	[SerializeField]
	private GameObject number4;
	[SerializeField]
	private GameObject number11;
	[SerializeField]
	private GameObject number22;
	[SerializeField]
	private GameObject number33;
	[SerializeField]
	private GameObject number44;

	private GameObject trees;


	// Use this for initialization
	void Start () {
		soldierPanelAnim = soldierPanel.GetComponent<Animator>();
		audioSource = GetComponent<AudioSource>();
		if(PlayerPrefs.GetInt("sound") ==1){
			audioSource.enabled = true;
			soundBtn.GetComponent<Image>().sprite = soundOnImage;
		}
		else{
			audioSource.enabled = false;
			soundBtn.GetComponent<Image>().sprite = soundOffImage;
		}
		chooseSMenu = chooseSoldierMenu.GetComponent<Animator>();
		PlayerPrefs.SetInt("knight",3);
		PlayerPrefs.SetInt("HouseHealth",10000);
		PlayerPrefs.SetInt("knightUnlocked",1);
		PlayerPrefs.SetInt("levelNum",1);
		levelNumber = PlayerPrefs.GetInt("levelNum");

		if(levelNumber>=15)
		{
			number1.gameObject.SetActive(true);
			number2.gameObject.SetActive(true);
			number3.gameObject.SetActive(true);
			number4.gameObject.SetActive(true);
			number11.gameObject.SetActive(true);
			number22.gameObject.SetActive(true);
			number33.gameObject.SetActive(true);
			number44.gameObject.SetActive(true);
		}
		if(levelNumber >= 1)
		{
			s2Button.gameObject.SetActive(true);
			s2Lock.gameObject.SetActive(false);
		}
		if(levelNumber >= 5)
		{
			s3Button.gameObject.SetActive(true);
			s3Lock.gameObject.SetActive(false);
		}
		if(levelNumber >= 7)
		{
			pumpkButton.gameObject.SetActive(true);
			pumpkLock.gameObject.SetActive(false);
		}
		if(levelNumber >= 10)
		{
			s4Button.gameObject.SetActive(true);
			s4Lock.gameObject.SetActive(false);
		}
		if(levelNumber >= 13)
		{
			skullyButton.gameObject.SetActive(true);
			skullyLock.gameObject.SetActive(false);
		}
		if(levelNumber >= 15)
		{
			s5Button.gameObject.SetActive(true);
			s5Lock.gameObject.SetActive(false);
		}
		if(levelNumber >= 19)
		{
			s6Button.gameObject.SetActive(true);
			s6Lock.gameObject.SetActive(false);
		}
		if(levelNumber >= 21)
		{
			granadeButton.gameObject.SetActive(true);
			granadeLock.gameObject.SetActive(false);
		}
		if(levelNumber >= 24)
		{
			s7Button.gameObject.SetActive(true);
			s7Lock.gameObject.SetActive(false);
		}
		if(levelNumber >= 27)
		{
			s8Button.gameObject.SetActive(true);
			s8Lock.gameObject.SetActive(false);
		}
		if(levelNumber >= 26 && PlayerPrefs.GetInt("knightUnlocked")==1)
		{
			knightButton.gameObject.SetActive(true);
			knightLock.gameObject.SetActive(false);
		}

		trees = GameObject.Find("Bush (1)Sniper");
		
		Left1 = GameObject.Find("StoneL1");
		l1 = Left1.GetComponent<Collider2D>();
		Left2 = GameObject.Find("StoneL2");
		l2 = Left2.GetComponent<Collider2D>();
		Left3 = GameObject.Find("StoneL3");
		l3 = Left3.GetComponent<Collider2D>();
		Left4 = GameObject.Find("StoneL4");
		l4 = Left4.GetComponent<Collider2D>();
		Left5 = GameObject.Find("StoneL5");
		l5 = Left5.GetComponent<Collider2D>();
		Left6 = GameObject.Find("StoneL6");
		l6 = Left6.GetComponent<Collider2D>();

		LeftUp1 = GameObject.Find("StoneLU1");
		lU1 = LeftUp1.GetComponent<Collider2D>();
		LeftUp2 = GameObject.Find("StoneLU2");
		lU2 = LeftUp2.GetComponent<Collider2D>();
		LeftUp3 = GameObject.Find("StoneLU3");
		lU3 = LeftUp3.GetComponent<Collider2D>();
		LeftUp4 = GameObject.Find("StoneLU4");
		lU4 = LeftUp4.GetComponent<Collider2D>();
		LeftUp5 = GameObject.Find("StoneLU5");
		lU5 = LeftUp5.GetComponent<Collider2D>();
		LeftUp6 = GameObject.Find("StoneLU6");
		lU6 = LeftUp6.GetComponent<Collider2D>();

		LeftB1 = GameObject.Find("StoneLB1");
		lB1 = LeftB1.GetComponent<Collider2D>();
		LeftB2 = GameObject.Find("StoneLB2");
		lB2 = LeftB2.GetComponent<Collider2D>();
		LeftB3 = GameObject.Find("StoneLB3");
		lB3 = LeftB3.GetComponent<Collider2D>();
		LeftB4 = GameObject.Find("StoneLB4");
		lB4 = LeftB4.GetComponent<Collider2D>();
		LeftB5 = GameObject.Find("StoneLB5");
		lB5 = LeftB5.GetComponent<Collider2D>();
		LeftB6 = GameObject.Find("StoneLB6");
		lB6 = LeftB6.GetComponent<Collider2D>();

		Right1 = GameObject.Find("StoneR1");
		R1 = Right1.GetComponent<Collider2D>();
		Right2 = GameObject.Find("StoneR2");
		R2 = Right2.GetComponent<Collider2D>();
		Right3 = GameObject.Find("StoneR3");
		R3 = Right3.GetComponent<Collider2D>();
		Right4 = GameObject.Find("StoneR4");
		R4 = Right4.GetComponent<Collider2D>();
		Right5 = GameObject.Find("StoneR5");
		R5 = Right5.GetComponent<Collider2D>();
		Right6 = GameObject.Find("StoneR6");
		R6 = Right6.GetComponent<Collider2D>();

		RightUp1 = GameObject.Find("StoneUR1");
		RU1 = RightUp1.GetComponent<Collider2D>();
		RightUp2 = GameObject.Find("StoneUR2");
		RU2 = RightUp2.GetComponent<Collider2D>();
		RightUp3 = GameObject.Find("StoneUR3");
		RU3 = RightUp3.GetComponent<Collider2D>();
		RightUp4 = GameObject.Find("StoneUR4");
		RU4 = RightUp4.GetComponent<Collider2D>();
		RightUp5 = GameObject.Find("StoneUR5");
		RU5 = RightUp5.GetComponent<Collider2D>();
		RightUp6 = GameObject.Find("StoneUR6");
		RU6 = RightUp6.GetComponent<Collider2D>();

		RightB1 = GameObject.Find("StoneRB1");
		RB1 = RightB1.GetComponent<Collider2D>();
		RightB2 = GameObject.Find("StoneRB2");
		RB2 = RightB2.GetComponent<Collider2D>();
		RightB3 = GameObject.Find("StoneRB3");
		RB3 = RightB3.GetComponent<Collider2D>();
		RightB4 = GameObject.Find("StoneRB4");
		RB4 = RightB4.GetComponent<Collider2D>();
		RightB5 = GameObject.Find("StoneRB5");
		RB5 = RightB5.GetComponent<Collider2D>();
		RightB6 = GameObject.Find("StoneRB6");
		RB6 = RightB6.GetComponent<Collider2D>();

		S5678Spot1 = GameObject.Find("S56781");
		S56781 = S5678Spot1.GetComponent<Collider2D>();
		S5678Spot2 = GameObject.Find("S56782");
		S56782 = S5678Spot2.GetComponent<Collider2D>();
		S5678Spot3 = GameObject.Find("S56783");
		S56783 = S5678Spot3.GetComponent<Collider2D>();
		S5678Spot4 = GameObject.Find("S56784");
		S56784 = S5678Spot4.GetComponent<Collider2D>();

		s2unlockAnimator = s2image.GetComponent<Animator>();
		s3unlockAnimator = s3image.GetComponent<Animator>();
		s4unlockAnimator = s4image.GetComponent<Animator>();
		s5unlockAnimator = s5image.GetComponent<Animator>();
		s6unlockAnimator = s6image.GetComponent<Animator>();
		s7unlockAnimator = s7image.GetComponent<Animator>();
		s8unlockAnimator = s8image.GetComponent<Animator>();
		pumpkunlockAnimator = pumpkImage.GetComponent<Animator>();
		skullunlockAnimator = skullImage.GetComponent<Animator>();
		granadeunlockAnimator = granadeImage.GetComponent<Animator>();
		kubokAnimator = kubok.GetComponent<Animator>();

		s1ImageChoosingMenuAnim = s1ImageChoosingMenu.GetComponent<Animator>();
		s2ImageChoosingMenuAnim = s2ImageChoosingMenu.GetComponent<Animator>();
		s3ImageChoosingMenuAnim = s3ImageChoosingMenu.GetComponent<Animator>();
		s4ImageChoosingMenuAnim = s4ImageChoosingMenu.GetComponent<Animator>();
		s5ImageChoosingMenuAnim = s5ImageChoosingMenu.GetComponent<Animator>();
		s6ImageChoosingMenuAnim = s6ImageChoosingMenu.GetComponent<Animator>();
		s7ImageChoosingMenuAnim = s7ImageChoosingMenu.GetComponent<Animator>();
		s8ImageChoosingMenuAnim = s8ImageChoosingMenu.GetComponent<Animator>();

		e1ImageChoosingMenuAnim = e1ImageChoosingMenu.GetComponent<Animator>();
		e2ImageChoosingMenuAnim = e2ImageChoosingMenu.GetComponent<Animator>();
		e3ImageChoosingMenuAnim = e3ImageChoosingMenu.GetComponent<Animator>();
		e4ImageChoosingMenuAnim = e4ImageChoosingMenu.GetComponent<Animator>();
		e5ImageChoosingMenuAnim = e5ImageChoosingMenu.GetComponent<Animator>();
		e6ImageChoosingMenuAnim = e6ImageChoosingMenu.GetComponent<Animator>();
		e7ImageChoosingMenuAnim = e7ImageChoosingMenu.GetComponent<Animator>();
		e8ImageChoosingMenuAnim = e8ImageChoosingMenu.GetComponent<Animator>();
		e9ImageChoosingMenuAnim = e9ImageChoosingMenu.GetComponent<Animator>();

		s1NameChoosingMenuAnim = s1NameChoosingMenu.GetComponent<Animator>();
		s2NameChoosingMenuAnim = s2NameChoosingMenu.GetComponent<Animator>();
		s3NameChoosingMenuAnim = s3NameChoosingMenu.GetComponent<Animator>();
		s4NameChoosingMenuAnim = s4NameChoosingMenu.GetComponent<Animator>();
		s5NameChoosingMenuAnim = s5NameChoosingMenu.GetComponent<Animator>();
		s6NameChoosingMenuAnim = s6NameChoosingMenu.GetComponent<Animator>();
		s7NameChoosingMenuAnim = s7NameChoosingMenu.GetComponent<Animator>();
		s8NameChoosingMenuAnim = s8NameChoosingMenu.GetComponent<Animator>();

		e1NameChoosingMenuAnim = e1NameChoosingMenu.GetComponent<Animator>();
		e2NameChoosingMenuAnim = e2NameChoosingMenu.GetComponent<Animator>();
		e3NameChoosingMenuAnim = e3NameChoosingMenu.GetComponent<Animator>();
		e4NameChoosingMenuAnim = e4NameChoosingMenu.GetComponent<Animator>();
		e5NameChoosingMenuAnim = e5NameChoosingMenu.GetComponent<Animator>();
		e6NameChoosingMenuAnim = e6NameChoosingMenu.GetComponent<Animator>();
		e7NameChoosingMenuAnim = e7NameChoosingMenu.GetComponent<Animator>();
		e8NameChoosingMenuAnim = e8NameChoosingMenu.GetComponent<Animator>();
		e9NameChoosingMenuAnim = e9NameChoosingMenu.GetComponent<Animator>();
		sniperIntroAnim = sniperIntroSign.GetComponent<Animator>();
		mercIntroAnim = mercIntroSign.GetComponent<Animator>();
		angelAnim = angel.GetComponent<Animator>();
		vsAnim = vs.GetComponent<Animator>();

		// PlayerPrefs.SetInt("introduction", 1);
		// PlayerPrefs.SetInt("sniperIntro",1);

		if(PlayerPrefs.HasKey("introduction")==false)
		 	PlayerPrefs.SetInt("introduction", 0);
		if(PlayerPrefs.HasKey("sniperIntro")==false)
		 	PlayerPrefs.SetInt("sniperIntro", 0);
		if(PlayerPrefs.HasKey("mercIntro")==false)
		 	PlayerPrefs.SetInt("mercIntro", 0);
		 if(PlayerPrefs.GetInt("introduction") == 0)
		 {	intr = StartCoroutine(PlayIntroduction());
		 }
		 else if(PlayerPrefs.GetInt("introduction") != 0 && PlayerPrefs.GetInt("sniperIntro")==1)
		 {PlayerPrefs.SetInt("pumpkin",9);
		 sniperIntroSign.gameObject.SetActive(true);
		// newSniperFunction(1);
		 GameObject newSniper = Instantiate(sniperEnemies[1]) as GameObject;
		 newSniper.transform.position = trees.transform.position;
		 sniperIntroText.text = "Your soldiers can now be attacked by snipers. Always watch out for snipers!";
		 sniperIntroBtn.gameObject.SetActive(true);
		 }
		 else if(PlayerPrefs.GetInt("introduction") != 0 && PlayerPrefs.GetInt("sniperIntro")!=1 && PlayerPrefs.GetInt("mercIntro")==1 )
		 {mercIntroSign.gameObject.SetActive(true);
		 mercIntroText.text = "In case of mercenery attack, you shall use your League 2 soldiers.";
		 mercIntroBtn.gameObject.SetActive(true);
		 }
		 else {
		 	ShowMenu();
		 }
		
		
	}

	[SerializeField]
	private Button s1btn;
	[SerializeField]
	private Button s2btn;
	[SerializeField]
	private Button s3btn;
	[SerializeField]
	private Button s4btn;
	[SerializeField]
	private Button pbtn;
	[SerializeField]
	private Button sbtn;
	[SerializeField]
	private Button pGetMore;
	[SerializeField]
	private Button sGetMore;


	Coroutine intr;
	[SerializeField]
	private Text mercTapToContinueText;
	[SerializeField]
	private Image mercIntroPointer;

	public void mercTapToContinue()
	{
		s1btn.enabled = false;
		s2btn.enabled = false;
		s3btn.enabled = false;
		s4btn.enabled = false;
		pbtn.enabled = false;
		sbtn.enabled = false;
		pGetMore.enabled = false;
		sGetMore.enabled = false;
		mercIntroPointer.gameObject.SetActive(true);
		mercTapToContinueText.gameObject.SetActive(false);
		mercIntroText.text = "Tap on Agent Lynch!";
		mercIntroBtn.gameObject.SetActive(false);
	}

	[SerializeField]
	private Image sniperIntroSign;
	[SerializeField]
	private Button sniperIntroBtn;
	[SerializeField]
	private Text sniperIntroText;
	private Animator sniperIntroAnim;

	[SerializeField]
	private Image mercIntroSign;
	[SerializeField]
	private Button mercIntroBtn;
	[SerializeField]
	private Text mercIntroText;
	private Animator mercIntroAnim;

	[SerializeField]
	private Text SniperTapToContinueText;

	public void ch()
	{
		sniperIntroText.text = "Tap on MR.Pumpkin!";
	}

	public void SniperTapToContinue()
	{
		sniperIntroAnim.SetTrigger("1");
		sniperIntroText.text = "";
		Invoke("ch",0.6f);
		sniperIntroBtn.gameObject.SetActive(false);
		GreenBtn.gameObject.SetActive(false);
		SniperTapToContinueText.gameObject.SetActive(false);
	}

	private bool mummyAlive = false;
	Coroutine mummyNoises;
	private bool inMummyNoiseCoroutine = false;
	IEnumerator mummySounds(){
		inMummyNoiseCoroutine = true;	
	 	GameManager.Instance.AudioSource.PlayOneShot(SoundManager.Instance.Mummy);
		yield return new WaitForSeconds(3.5f);
		GameManager.Instance.AudioSource.PlayOneShot(SoundManager.Instance.Mummy2);
		yield return new WaitForSeconds(3.5f);
		GameManager.Instance.AudioSource.PlayOneShot(SoundManager.Instance.Mummy3);
		yield return new WaitForSeconds(3.5f);
		GameManager.Instance.AudioSource.PlayOneShot(SoundManager.Instance.Mummy4);
		yield return new WaitForSeconds(3.5f);
		//inMummyNoiseCoroutine = false;
	}

	public void lateShowMena()
	{
		ShowMenu();
	}
	private bool once = false;

	void Update () {
		if(PlayerPrefs.GetInt("introduction")==0 && SoldierManager.Instance.MainEnergy.CurrentVal >= 10 && once ==false)
		{	once = true;
			angelAnim.SetTrigger("next2");
			angelText.text = "I froze the energy bar for you. You now have enough energy for Sergeant Johnson. Tap on him!";
			soldListPointer.gameObject.SetActive(true);
		}

		if(PlayerPrefs.GetInt("sniperIntro")==3){
			Invoke("ShowMenu",1.2f);
			GreenBtn.gameObject.SetActive(true);
			PlayerPrefs.SetInt("sniperIntro",4);
		}
		mummyAlive = false;
		foreach (Enemy enemy in EnemyListLeft){
			if(enemy.name.Contains("Mummy"))
				mummyAlive = true;
		}
		foreach (Enemy enemy in EnemyListUpLeft){
			if(enemy.name.Contains("Mummy"))
				mummyAlive = true;
		}
		foreach (Enemy enemy in EnemyListButtomLeft){
			if(enemy.name.Contains("Mummy"))
				mummyAlive = true;
		}
		foreach (Enemy enemy in EnemyListRight){
			if(enemy.name.Contains("Mummy"))
				mummyAlive = true;
		}
		foreach (Enemy enemy in EnemyListButtomRight){
			if(enemy.name.Contains("Mummy"))
				mummyAlive = true;
		}
		foreach (Enemy enemy in EnemyListUpRight){
			if(enemy.name.Contains("Mummy"))
				mummyAlive = true;
		}

		if(mummyAlive == true && inMummyNoiseCoroutine == false)
			mummyNoises = StartCoroutine(mummySounds());
		// else if(mummyAlive == false && inMummyNoiseCoroutine == true)
		// 	StopCoroutine(mummyNoises);
		

	}
	[SerializeField]
	private GameObject angel;
	[SerializeField]
	private Text angelText;
	private Animator angelAnim;

	[SerializeField]
	private Image healthPointer;
	[SerializeField]
	private Image energyPointer;
	[SerializeField]
	private Image soldListPointer;
	[SerializeField]
	private Image dzevakanGreenBtn;
	[SerializeField]
	private Image GreenBtn;
	[SerializeField]
	private Image greenBtnPointer;

	IEnumerator PlayIntroduction(){
		//dzevakanGreenBtn.gameObject.SetActive(true);
		GreenBtn.gameObject.SetActive(false);
		angel.SetActive(true);
		yield return new WaitForSeconds(1.1f);
		angelText.text = "Welcome to battleground!";
		yield return new WaitForSeconds(1.7f);
		angelText.text = "";
		angelAnim.SetTrigger("next1");
		yield return new WaitForSeconds(1.2f);
		angelText.text = "Do not let House health reach 0 or enemy will destroy your house!";
		healthPointer.gameObject.SetActive(true);	
		yield return new WaitForSeconds(4.5f);
		healthPointer.gameObject.SetActive(false);	
		energyPointer.gameObject.SetActive(true);
		greenBtnPointer.gameObject.SetActive(true);
		angelText.text = "Consecutively press the green button on the house to fill the energy bar!";
		//dzevakanGreenBtn.gameObject.SetActive(false);
		GreenBtn.gameObject.SetActive(true);
	}

	private int enemyNumber =0;
	private int merceneryNumber =0;

	public void newMummyEnemyFunction(int i)
	{
		GameObject newMummyEnemy = Instantiate(mummyEnemies[i]) as GameObject;
		newMummyEnemy.transform.position = spawnPoint[i].transform.position;
		enemyNumber+=1;
	}
	public void newBlochEnemyFunction(int i)
	{
		GameObject newBlochEnemy = Instantiate(blochEnemies[i]) as GameObject;
		newBlochEnemy.transform.position = spawnPoint[i].transform.position;
		enemyNumber+=1;
	}
	public void newScorpionEnemyFunction(int i)
	{
		GameObject newScorpionEnemy = Instantiate(scorpionEnemies[i]) as GameObject;
		newScorpionEnemy.transform.position = spawnPoint[i].transform.position;
		enemyNumber+=1;
	}

	public void newWolfEnemyFunction(int i)
	{
		GameObject newWolfEnemy = Instantiate(wolfEnemies[i]) as GameObject;
		newWolfEnemy.transform.position = spawnPoint[i].transform.position;
		enemyNumber+=1;
	}

	public void newSniperFunction(int i)
	{
		GameObject newSniper = Instantiate(sniperEnemies[i]) as GameObject;
		newSniper.transform.position = sniperSpawnPoint[i].transform.position;
	}

	public void newMercOneFunction(int i)
	{
		GameObject newMercenery = Instantiate(mercenery2Enemies[i]) as GameObject;
		newMercenery.transform.position = mercenerySpawnPoint[i].transform.position;
		merceneryNumber+=1;
	}

	public void newMercTwoFunction(int i)
	{
		GameObject newMercenery = Instantiate(mercenery3Enemies[i]) as GameObject;
		newMercenery.transform.position = mercenerySpawnPoint[i].transform.position;
		merceneryNumber+=1;
	}

	public void newMercThreeFunction(int i)
	{
		GameObject newMercenery = Instantiate(mercenery4Enemies[i]) as GameObject;
		newMercenery.transform.position = mercenerySpawnPoint[i].transform.position;
		merceneryNumber+=1;
	}

	public void newMercFourFunction(int i)
	{
		GameObject newMercenery = Instantiate(mercenery5Enemies[i]) as GameObject;
		newMercenery.transform.position = mercenerySpawnPoint[i].transform.position;
		merceneryNumber+=1;
	}
	

	IEnumerator spawnLevel1(){
		totalMerceneries=0;
		yield return new WaitForSeconds(1f);
		newBlochEnemyFunction(0);
		yield return new WaitForSeconds(5.5f);
		newBlochEnemyFunction(3);
		yield return new WaitForSeconds(5.5f);
		newBlochEnemyFunction(2);
		yield return new WaitForSeconds(5.5f);
		newBlochEnemyFunction(5);
		yield return new WaitForSeconds(5.5f);
		newBlochEnemyFunction(4);
		yield return new WaitForSeconds(5.5f);
		newBlochEnemyFunction(1);		
		if(enemyNumber < totalEnemies)
		{
			totalKilled += (totalEnemies-enemyNumber);
		}
		else if(enemyNumber > totalEnemies)
		{
			totalKilled -= (enemyNumber-totalEnemies);
		}	
	}

	IEnumerator spawnLevel2(){
		totalMerceneries=0;
		yield return new WaitForSeconds(2f);
		List<int> l = new List<int>();
		if (enemiesOnScreen<totalEnemies && totalEnemies%6 == 0){
			int rand = Random.Range(0,6);
			for (int a =0; a < spawnPoint.Length; a++){
				newMummyEnemyFunction(rand);
				yield return new WaitForSeconds(3f);
				newMummyEnemyFunction(rand);
				enemiesOnScreen+=2;
				l.Add(rand);
				if(l.Count!=6)
				{	while(l.Contains(rand))
					{rand = Random.Range(0,6);
					yield return null;
					}
				}	
				yield return new WaitForSeconds(spawnDelay);	
			}
			l.Clear();
		}
		if(enemyNumber < totalEnemies)
		{
			totalKilled += (totalEnemies-enemyNumber);
		}
		else if(enemyNumber > totalEnemies)
		{
			totalKilled -= (enemyNumber-totalEnemies);
		}
	}

	

	IEnumerator spawnLevel3(){
		totalMerceneries=0;
		yield return new WaitForSeconds(2f);
		List<int> l = new List<int>();
		if (enemiesOnScreen<totalEnemies && totalEnemies%6 == 0){
			int rand = Random.Range(0,6);
			while(enemiesOnScreen<totalEnemies){
				if(enemiesOnScreen >= 0 && enemiesOnScreen < 6){					
					newBlochEnemyFunction(rand);
					enemiesOnScreen+=1;
				}
				else if(enemiesOnScreen >= 6 && enemiesOnScreen <totalEnemies-1){
					newMummyEnemyFunction(rand);
					yield return new WaitForSeconds(3f);
					newBlochEnemyFunction(rand);
					enemiesOnScreen+=2;
				}
				l.Add(rand);
				if(l.Count!=6)
				{	while(l.Contains(rand))
					{rand = Random.Range(0,6);
					yield return null;
					}
				}
				else if(l.Count == 6)
				{
					l.Clear();
				}	
				yield return new WaitForSeconds(spawnDelay);	
			}
			
		}
		if(enemyNumber < totalEnemies)
		{
			totalKilled += (totalEnemies-enemyNumber);
		}
		else if(enemyNumber > totalEnemies)
		{
			totalKilled -= (enemyNumber-totalEnemies);
		}
	}

	IEnumerator spawnLevel4(){
		totalMerceneries=0;
		yield return new WaitForSeconds(2f);
		List<int> l = new List<int>();
		if (enemiesOnScreen<totalEnemies && totalEnemies%6 == 0){
			int rand = Random.Range(0,6);
			while(enemiesOnScreen<totalEnemies){
				newScorpionEnemyFunction(rand);
				yield return new WaitForSeconds(10f);
				newScorpionEnemyFunction(rand);
				enemiesOnScreen+=2;
				l.Add(rand);
				if(l.Count!=6)
				{	while(l.Contains(rand))
					{rand = Random.Range(0,6);
					yield return null;
					}
				}
				else if(l.Count == 6)
				{
					l.Clear();
				}	
				yield return new WaitForSeconds(5);	
			}
			
		}
		if(enemyNumber < totalEnemies)
		{
			totalKilled += (totalEnemies-enemyNumber);
		}
		else if(enemyNumber > totalEnemies)
		{
			totalKilled -= (enemyNumber-totalEnemies);
		}
	}


	IEnumerator spawnLevel5(){
		totalMerceneries=0;
		yield return new WaitForSeconds(2f);
		List<int> l = new List<int>();
		if (enemiesOnScreen<totalEnemies){
			int rand = Random.Range(0,6);
			while(enemiesOnScreen<totalEnemies && totalEnemies%6 == 0){
				if(enemiesOnScreen<13){
					newBlochEnemyFunction(rand);
					yield return new WaitForSeconds(4f);
					newMummyEnemyFunction(rand);
					enemiesOnScreen+=2;
				}
				else if(enemiesOnScreen>=13 && enemiesOnScreen<totalEnemies){
					newScorpionEnemyFunction(rand);
					enemiesOnScreen+=1;
				}
				l.Add(rand);
				if(l.Count!=6)
				{	while(l.Contains(rand))
					{rand = Random.Range(0,6);
					yield return null;
					}
				}
				else if(l.Count == 6)
				{
					l.Clear();
				}	
				yield return new WaitForSeconds(spawnDelay);	
			}
		}
		if(enemyNumber < totalEnemies)
		{
			totalKilled += (totalEnemies-enemyNumber);
		}
		else if(enemyNumber > totalEnemies)
		{
			totalKilled -= (enemyNumber-totalEnemies);
		}
	}

	IEnumerator spawnLevel6(){
		totalMerceneries=0;
		//38
		yield return new WaitForSeconds(2f);
		List<int> l = new List<int>();
		if (enemiesOnScreen<totalEnemies){
			int rand = Random.Range(0,6);
			while(enemiesOnScreen<totalEnemies){
				if(enemiesOnScreen<13){
					newBlochEnemyFunction(rand);
					yield return new WaitForSeconds(4f);
					newScorpionEnemyFunction(rand);
					enemiesOnScreen+=2;
				}
				else if(enemiesOnScreen>=13 && enemiesOnScreen<25){
					newScorpionEnemyFunction(rand);
					yield return new WaitForSeconds(2.5f);
					newMummyEnemyFunction(rand);
					enemiesOnScreen+=2;
				}
				else if(enemiesOnScreen>=25 && enemiesOnScreen<totalEnemies-1)
				{	
					newMummyEnemyFunction(rand);
					newMummyEnemyFunction(rand);
					enemiesOnScreen+=2;
				}
				l.Add(rand);
				if(l.Count!=6)
				{	while(l.Contains(rand))
					{rand = Random.Range(0,6);
					yield return null;
					}
				}
				else if(l.Count == 6)
				{
					l.Clear();
				}	
				yield return new WaitForSeconds(spawnDelay);	
			}
		}
		if(enemyNumber < totalEnemies)
		{
			totalKilled += (totalEnemies-enemyNumber);
		}
		else if(enemyNumber > totalEnemies)
		{
			totalKilled -= (enemyNumber-totalEnemies);
		}	
	}

	IEnumerator spawnLevel7(){
		totalMerceneries=0;
		yield return new WaitForSeconds(4f);
		newMummyEnemyFunction(0);
		newMummyEnemyFunction(1);	
		newMummyEnemyFunction(2);
		yield return new WaitForSeconds(4f);
		newScorpionEnemyFunction(3);
		newBlochEnemyFunction(5);
		yield return new WaitForSeconds(5f);
		newScorpionEnemyFunction(1);
		newScorpionEnemyFunction(4);
		yield return new WaitForSeconds(4.8f);
		newScorpionEnemyFunction(2);
		newScorpionEnemyFunction(5);
		yield return new WaitForSeconds(4.2f);
		newMummyEnemyFunction(0);
		newBlochEnemyFunction(3);
		yield return new WaitForSeconds(4.8f);
		newMummyEnemyFunction(4);
		newBlochEnemyFunction(5);
		yield return new WaitForSeconds(4.7f);
		newScorpionEnemyFunction(1);
		yield return new WaitForSeconds(4.5f);
		newBlochEnemyFunction(2);
		newMummyEnemyFunction(2);
		yield return new WaitForSeconds(4.5f);
		newBlochEnemyFunction(5);
		yield return new WaitForSeconds(4f);
		newScorpionEnemyFunction(3);
		yield return new WaitForSeconds(4.5f);
		newMummyEnemyFunction(1);
		newBlochEnemyFunction(0);
		yield return new WaitForSeconds(4.5f);
		newScorpionEnemyFunction(1);
		yield return new WaitForSeconds(4.8f);
		newMummyEnemyFunction(5);
		newBlochEnemyFunction(4);
		yield return new WaitForSeconds(5.0f);
		newScorpionEnemyFunction(2);
		yield return new WaitForSeconds(4.5f);
		newMummyEnemyFunction(3);
		newBlochEnemyFunction(0);
		yield return new WaitForSeconds(4.8f);
		newScorpionEnemyFunction(3);
		yield return new WaitForSeconds(4.5f);
		newMummyEnemyFunction(1);
		newBlochEnemyFunction(0);
		yield return new WaitForSeconds(4.9f);
		newScorpionEnemyFunction(4);
		yield return new WaitForSeconds(5f);
		newMummyEnemyFunction(5);
		yield return new WaitForSeconds(4.5f);
		newBlochEnemyFunction(1);
		newScorpionEnemyFunction(2);
		yield return new WaitForSeconds(4.7f);
		newMummyEnemyFunction(2);
		newBlochEnemyFunction(3);
		newScorpionEnemyFunction(4);
		yield return new WaitForSeconds(4.5f);
		newMummyEnemyFunction(0);
		newBlochEnemyFunction(5);
		yield return new WaitForSeconds(4.6f);
		newScorpionEnemyFunction(1);
		yield return new WaitForSeconds(4.5f);
		newMummyEnemyFunction(3);
		newBlochEnemyFunction(5);
		yield return new WaitForSeconds(4.5f);
		newScorpionEnemyFunction(2);
		Debug.Log(enemyNumber);
		if(enemyNumber < totalEnemies)
		{
			totalKilled += (totalEnemies-enemyNumber);
		}
		else if(enemyNumber > totalEnemies)
		{
			totalKilled -= (enemyNumber-totalEnemies);
		}
	}

	IEnumerator spawnLevel8(){
		totalMerceneries=0;
		yield return new WaitForSeconds(2f);
		newBlochEnemyFunction(0);
		newBlochEnemyFunction(4);
		yield return new WaitForSeconds(2.0f);
		newBlochEnemyFunction(5);
		newSniperFunction(0);
		yield return new WaitForSeconds(4.8f);
		newMummyEnemyFunction(1);
		newScorpionEnemyFunction(2);
		newBlochEnemyFunction(3);
		yield return new WaitForSeconds(4.4f);
		newMummyEnemyFunction(1);
		newMummyEnemyFunction(4);
		yield return new WaitForSeconds(4.8f);
		newScorpionEnemyFunction(2);
		newBlochEnemyFunction(5);
		newSniperFunction(3);
		yield return new WaitForSeconds(4.0f);
		newBlochEnemyFunction(0);
		yield return new WaitForSeconds(4.5f);
		newMummyEnemyFunction(4);
		newMummyEnemyFunction(5);
		yield return new WaitForSeconds(4.8f);
		newScorpionEnemyFunction(1);
		yield return new WaitForSeconds(5f);
		newBlochEnemyFunction(2);
		newScorpionEnemyFunction(2);
		newSniperFunction(2);
		yield return new WaitForSeconds(4.2f);
		newBlochEnemyFunction(5);
		yield return new WaitForSeconds(4.6f);
		newScorpionEnemyFunction(3);
		yield return new WaitForSeconds(4.3f);
		newMummyEnemyFunction(1);
		newScorpionEnemyFunction(0);
		newSniperFunction(1);
		yield return new WaitForSeconds(4.2f);
		newScorpionEnemyFunction(1);
		yield return new WaitForSeconds(4.5f);
		newMummyEnemyFunction(5);
		newScorpionEnemyFunction(4);
		yield return new WaitForSeconds(4.5f);
		newBlochEnemyFunction(2);
		yield return new WaitForSeconds(4.3f);
		newMummyEnemyFunction(3);
		newBlochEnemyFunction(0);
		yield return new WaitForSeconds(4.3f);
		newScorpionEnemyFunction(3);
		yield return new WaitForSeconds(5f);
		newMummyEnemyFunction(1);
		newMummyEnemyFunction(0);
		yield return new WaitForSeconds(4.7f);
		newScorpionEnemyFunction(4);
		yield return new WaitForSeconds(4.7f);
		newMummyEnemyFunction(5);
		yield return new WaitForSeconds(4.4f);
		newBlochEnemyFunction(1);
		newScorpionEnemyFunction(2);
		yield return new WaitForSeconds(4.2f);
		newMummyEnemyFunction(2);
		yield return new WaitForSeconds(4.2f);
		newScorpionEnemyFunction(3);
		newSniperFunction(4);
		yield return new WaitForSeconds(4.2f);
		newScorpionEnemyFunction(4);
		yield return new WaitForSeconds(4.5f);
		newBlochEnemyFunction(0);
		newBlochEnemyFunction(5);
		yield return new WaitForSeconds(3.5f);
		newMummyEnemyFunction(1);
		yield return new WaitForSeconds(4.3f);
		newMummyEnemyFunction(3);
		newScorpionEnemyFunction(5);
		yield return new WaitForSeconds(4.6f);
		newScorpionEnemyFunction(2);
		yield return new WaitForSeconds(4.3f);
		newScorpionEnemyFunction(0);
		newMummyEnemyFunction(1);
		newBlochEnemyFunction(2);
		yield return new WaitForSeconds(5f);
		newMummyEnemyFunction(3);
		newBlochEnemyFunction(4);
		newSniperFunction(0);
		newScorpionEnemyFunction(5);
		if(enemyNumber < totalEnemies)
		{
			totalKilled += (totalEnemies-enemyNumber);
		}
		else if(enemyNumber > totalEnemies)
		{
			totalKilled -= (enemyNumber-totalEnemies);
		}
		
	}

	IEnumerator spawnLevel9(){
		totalMerceneries=0;
		yield return new WaitForSeconds(3f);
		newMummyEnemyFunction(1);
		newMummyEnemyFunction(2);
		newBlochEnemyFunction(3);
		newSniperFunction(0);
		yield return new WaitForSeconds(4.5f);
		newScorpionEnemyFunction(4);
		newScorpionEnemyFunction(0);
		newBlochEnemyFunction(5);
		yield return new WaitForSeconds(4.2f);
		newScorpionEnemyFunction(1);
		newMummyEnemyFunction(4);
		yield return new WaitForSeconds(4.5f);
		newMummyEnemyFunction(3);
		newBlochEnemyFunction(0);
		newSniperFunction(5);
		yield return new WaitForSeconds(4.0f);
		newBlochEnemyFunction(1);
		newMummyEnemyFunction(2);
		yield return new WaitForSeconds(4.4f);
		newMummyEnemyFunction(5);
		newScorpionEnemyFunction(4);
		yield return new WaitForSeconds(4.6f);
		newScorpionEnemyFunction(3);
		newBlochEnemyFunction(0);
		yield return new WaitForSeconds(4.2f);
		newScorpionEnemyFunction(2);
		newSniperFunction(1);
		yield return new WaitForSeconds(4.0f);
		newBlochEnemyFunction(5);
		newScorpionEnemyFunction(4);
		yield return new WaitForSeconds(4.1f);
		newBlochEnemyFunction(0);
		newScorpionEnemyFunction(3);
		newSniperFunction(3);
		yield return new WaitForSeconds(4.7f);
		newScorpionEnemyFunction(1);
		newMummyEnemyFunction(2);
		newScorpionEnemyFunction(5);
		yield return new WaitForSeconds(4.7f);
		newScorpionEnemyFunction(0);
		newMummyEnemyFunction(4);
		yield return new WaitForSeconds(4f);
		newMummyEnemyFunction(5);
		newBlochEnemyFunction(1);
		yield return new WaitForSeconds(4.2f);
		newScorpionEnemyFunction(3);
		yield return new WaitForSeconds(4.2f);
		newMummyEnemyFunction(2);
		newMummyEnemyFunction(4);
		yield return new WaitForSeconds(4.4f);
		newScorpionEnemyFunction(3);
		yield return new WaitForSeconds(4.5f);
		newMummyEnemyFunction(3);
		newScorpionEnemyFunction(1);
		yield return new WaitForSeconds(4.2f);
		newBlochEnemyFunction(0);
		newScorpionEnemyFunction(2);
		yield return new WaitForSeconds(4.1f);
		newMummyEnemyFunction(4);
		newBlochEnemyFunction(5);
		newSniperFunction(4);
		yield return new WaitForSeconds(4.2f);
		newScorpionEnemyFunction(1);
		yield return new WaitForSeconds(4.8f);
		newScorpionEnemyFunction(5);
		newBlochEnemyFunction(5);
		yield return new WaitForSeconds(4.2f);
		newScorpionEnemyFunction(0);
		yield return new WaitForSeconds(4.6f);
		newMummyEnemyFunction(4);
		newBlochEnemyFunction(3);
		newScorpionEnemyFunction(2);
		yield return new WaitForSeconds(4.2f);
		newScorpionEnemyFunction(1);
		yield return new WaitForSeconds(4.1f);
		newScorpionEnemyFunction(1);
		newMummyEnemyFunction(4);
		newBlochEnemyFunction(0);
		yield return new WaitForSeconds(4.1f);
		newMummyEnemyFunction(2);
		newBlochEnemyFunction(5);
		yield return new WaitForSeconds(4.2f);
		newSniperFunction(2);
		newScorpionEnemyFunction(1);
		if(enemyNumber < totalEnemies)
		{
			totalKilled += (totalEnemies-enemyNumber);
		}
		else if(enemyNumber > totalEnemies)
		{
			totalKilled -= (enemyNumber-totalEnemies);
		}
	} 

	IEnumerator spawnLevel10(){
		totalMerceneries=0;
		yield return new WaitForSeconds(3f);
		newBlochEnemyFunction(0);
		newBlochEnemyFunction(1);
		yield return new WaitForSeconds(4f);
		newScorpionEnemyFunction(0);
		newMummyEnemyFunction(0);
		newScorpionEnemyFunction(1);
		yield return new WaitForSeconds(4.2f);
		newMummyEnemyFunction(4);
		newMummyEnemyFunction(5);
		yield return new WaitForSeconds(4f);
		newSniperFunction(0);
		newBlochEnemyFunction(2);
		newBlochEnemyFunction(3);
		yield return new WaitForSeconds(4.2f);
		newBlochEnemyFunction(0);
		newBlochEnemyFunction(2);
		yield return new WaitForSeconds(4f);
		newMummyEnemyFunction(2);
		newSniperFunction(1);
		newMummyEnemyFunction(3);
		yield return new WaitForSeconds(4f);
		newBlochEnemyFunction(3);
		newScorpionEnemyFunction(4);
		yield return new WaitForSeconds(4.2f);
		newScorpionEnemyFunction(5);
		newBlochEnemyFunction(4);
		newScorpionEnemyFunction(2);
		yield return new WaitForSeconds(4f);
		newMummyEnemyFunction(1);
		newScorpionEnemyFunction(3);
		yield return new WaitForSeconds(4.2f);
		newBlochEnemyFunction(5);
		newSniperFunction(2);
		newScorpionEnemyFunction(2);
		yield return new WaitForSeconds(4f);
		newScorpionEnemyFunction(3);
		newBlochEnemyFunction(0);
		yield return new WaitForSeconds(4.2f);
		newMummyEnemyFunction(2);
		newScorpionEnemyFunction(4);
		newMummyEnemyFunction(0);
		yield return new WaitForSeconds(4f);
		newSniperFunction(3);
		newMummyEnemyFunction(1);
		yield return new WaitForSeconds(4.2f);
		newScorpionEnemyFunction(5);
		newMummyEnemyFunction(3);
		newBlochEnemyFunction(4);
		yield return new WaitForSeconds(4.2f);
		newBlochEnemyFunction(5);
		newSniperFunction(4);
		yield return new WaitForSeconds(4.2f);
		newScorpionEnemyFunction(0);
		newScorpionEnemyFunction(1);
		newBlochEnemyFunction(1);
		yield return new WaitForSeconds(4.2f);
		newMummyEnemyFunction(3);
		newMummyEnemyFunction(4);
		yield return new WaitForSeconds(4.2f);
		newSniperFunction(5);
		newScorpionEnemyFunction(4);
		newBlochEnemyFunction(1);
		yield return new WaitForSeconds(4.2f);
		newScorpionEnemyFunction(5);
		newMummyEnemyFunction(2);
		yield return new WaitForSeconds(4.2f);
		newScorpionEnemyFunction(0);
		newSniperFunction(3);
		newMummyEnemyFunction(4);
		yield return new WaitForSeconds(4.2f);
		newMummyEnemyFunction(5);
		newScorpionEnemyFunction(1);
		yield return new WaitForSeconds(4.2f);
		newScorpionEnemyFunction(4);
		newScorpionEnemyFunction(5);
		newSniperFunction(1);
		yield return new WaitForSeconds(4.2f);
		newScorpionEnemyFunction(2);
		newScorpionEnemyFunction(3);
		yield return new WaitForSeconds(4.2f);
		newScorpionEnemyFunction(0);
		newScorpionEnemyFunction(1);
		newMummyEnemyFunction(0);
		yield return new WaitForSeconds(4.2f);
		newMummyEnemyFunction(1);
		newSniperFunction(1);
		yield return new WaitForSeconds(4.2f);
		newScorpionEnemyFunction(2);
		newScorpionEnemyFunction(3);
		newMummyEnemyFunction(5);
		if(enemyNumber < totalEnemies)
		{
			totalKilled += (totalEnemies-enemyNumber);
		}
		else if(enemyNumber > totalEnemies)
		{
			totalKilled -= (enemyNumber-totalEnemies);
		}
	}

	IEnumerator spawnLevel11(){
		totalMerceneries=0;
		yield return new WaitForSeconds(2f);
		List<int> l = new List<int>();
		if (enemiesOnScreen<totalEnemies){
			int rand = Random.Range(0,6);
			while(enemiesOnScreen<totalEnemies){
				if(enemiesOnScreen==0)
				{	newWolfEnemyFunction(rand);
					enemiesOnScreen+=1;
					yield return new WaitForSeconds(6f);
				}
				else if(enemiesOnScreen==1)
				{
					newWolfEnemyFunction(rand);
					yield return new WaitForSeconds(10f);
					newWolfEnemyFunction(rand);
					enemiesOnScreen+=2;
				}
				else if(enemiesOnScreen==3)
				{
					newWolfEnemyFunction(rand);
					yield return new WaitForSeconds(5f);
					newWolfEnemyFunction(rand);
					enemiesOnScreen+=2;
				}
				else if(enemiesOnScreen==5)
				{
					newWolfEnemyFunction(rand);
					yield return new WaitForSeconds(3f);
					newWolfEnemyFunction(rand);
					enemiesOnScreen+=2;
				}
				else if(enemiesOnScreen==7)
				{
					newWolfEnemyFunction(rand);
					yield return new WaitForSeconds(3f);
					newWolfEnemyFunction(rand);
					enemiesOnScreen+=2;
				}
				else if(enemiesOnScreen==9)
				{
					newWolfEnemyFunction(rand);
					yield return new WaitForSeconds(3f);
					newWolfEnemyFunction(rand);
					enemiesOnScreen+=2;
				}
				else if(enemiesOnScreen==11)
				{
					newWolfEnemyFunction(rand);
					enemiesOnScreen+=1;
				}
				l.Add(rand);
				if(l.Count!=6)
				{	while(l.Contains(rand))
					{rand = Random.Range(0,6);
					yield return null;
					}
				}
				else if(l.Count == 6)
				{
					l.Clear();
				}	
				yield return new WaitForSeconds(spawnDelay);	
			}
			
		}
		if(enemyNumber < totalEnemies)
		{
			totalKilled += (totalEnemies-enemyNumber);
		}
		else if(enemyNumber > totalEnemies)
		{
			totalKilled -= (enemyNumber-totalEnemies);
		}
	}

	IEnumerator spawnLevel12(){
		totalMerceneries=0;
		yield return new WaitForSeconds(2f);
		List<int> l = new List<int>();
		List<int> lsnipers = new List<int>();
		if (enemiesOnScreen<totalEnemies){
			int rand = Random.Range(0,6);
			int randSnipers = Random.Range(0,6);
			while(enemiesOnScreen<totalEnemies ){
				if(enemiesOnScreen<15){
					newMummyEnemyFunction(rand);
					yield return new WaitForSeconds(4f);
					newWolfEnemyFunction(rand);
					enemiesOnScreen+=2;
					if(snipersOnScreen==0)
					{
						newSniperFunction(randSnipers);
						snipersOnScreen+=1;
						lsnipers.Add(randSnipers);
					}
					else if(snipersOnScreen == 1)
					{	
						yield return new WaitForSeconds(8f);
						newSniperFunction(randSnipers);
						snipersOnScreen+=1;
						lsnipers.Add(randSnipers);
					}
					else if(snipersOnScreen == 2)
					{	
						yield return new WaitForSeconds(8f);
						newSniperFunction(randSnipers);
						snipersOnScreen+=1;
						lsnipers.Add(randSnipers);
					}
					else if(snipersOnScreen == 3)
					{	
						yield return new WaitForSeconds(8f);
						newSniperFunction(randSnipers);
						snipersOnScreen+=1;
						lsnipers.Add(randSnipers);
					}
				}
				else if(enemiesOnScreen>=15 && enemiesOnScreen<27){
					newWolfEnemyFunction(rand);
					yield return new WaitForSeconds(7f);
					newMummyEnemyFunction(rand);
					enemiesOnScreen+=2;
					if(snipersOnScreen==4)
					{	yield return new WaitForSeconds(8f);
						newSniperFunction(randSnipers);
						snipersOnScreen+=1;
						lsnipers.Add(randSnipers);
					}
					else if(snipersOnScreen == 5)
					{	yield return new WaitForSeconds(8f);
						newSniperFunction(randSnipers);
						snipersOnScreen+=1;
						lsnipers.Add(randSnipers);
					}
					else if(snipersOnScreen == 6)
					{	yield return new WaitForSeconds(8f);
						newSniperFunction(randSnipers);
						snipersOnScreen+=1;
						lsnipers.Add(randSnipers);
					}
					else if(snipersOnScreen == 7)
					{	
						yield return new WaitForSeconds(8f);
						newSniperFunction(randSnipers);
						snipersOnScreen+=1;
						lsnipers.Add(randSnipers);
					}
				}
				else if(enemiesOnScreen>=27 && enemiesOnScreen<totalEnemies-1)
				{	
					newMummyEnemyFunction(rand);
					newWolfEnemyFunction(rand);
					enemiesOnScreen+=2;
					if(snipersOnScreen==8)
					{	yield return new WaitForSeconds(8f);
						newSniperFunction(randSnipers);
						snipersOnScreen+=1;
						lsnipers.Add(randSnipers);
					}
					else if(snipersOnScreen == 9)
					{	yield return new WaitForSeconds(8f);
						newSniperFunction(randSnipers);
						snipersOnScreen+=1;
						lsnipers.Add(randSnipers);
					}
					else if(snipersOnScreen == 10)
					{	yield return new WaitForSeconds(8f);
						newSniperFunction(randSnipers);
						snipersOnScreen+=1;
						lsnipers.Add(randSnipers);
					}
					else if(snipersOnScreen == 11)
					{	
						yield return new WaitForSeconds(8f);
						newSniperFunction(randSnipers);
						snipersOnScreen+=1;
						lsnipers.Add(randSnipers);
					}
				}
				l.Add(rand);
				if(l.Count!=6)
				{	while(l.Contains(rand))
					{rand = Random.Range(0,6);
					yield return null;
					}
				}
				else if(l.Count == 6)
				{
					l.Clear();
				}	

				
				if(lsnipers.Count!=6)
				{	while(lsnipers.Contains(randSnipers))
					{randSnipers = Random.Range(0,6);
					yield return null;
					}
				}
				else if(lsnipers.Count == 6)
				{
					lsnipers.Clear();
				}	
				yield return new WaitForSeconds(spawnDelay);	
			}
		}
		if(enemyNumber < totalEnemies)
		{
			totalKilled += (totalEnemies-enemyNumber);
		}
		else if(enemyNumber > totalEnemies)
		{
			totalKilled -= (enemyNumber-totalEnemies);
		}	
	}

	public void randomEnemy(int i,int a)
	{
		if(i == 0)
			newBlochEnemyFunction(a);
		else if (i ==1)
			newMummyEnemyFunction(a);
		else if (i ==2)
			newScorpionEnemyFunction(a);
		else if (i ==3)
			newWolfEnemyFunction(a);
	}

	public void randomMercenery(int i,int a){
		if(i==1)
			newMercOneFunction(a);
		else if(i==2)
			newMercTwoFunction(a);
		else if(i==3)
			newMercThreeFunction(a);
		else if(i==4)
			newMercFourFunction(a);
	}
	public void randomMercenery2(int i,int a){
		if(i==0)
			newMercOneFunction(a);
		else if(i==1)
			newMercTwoFunction(a);
		else if(i==2)
			newMercThreeFunction(a);
		else if(i==3)
			newMercFourFunction(a);
	}

	IEnumerator spawnLevel13(){
		totalEnemies = 52;
		totalSnipers = 12;
		totalMerceneries=0;
		yield return new WaitForSeconds(2f);
		List<int> whichEnemy = new List<int>();
		List<int> l = new List<int>();
		List<int> lsnipers = new List<int>();	
		int rand = Random.Range(0,6);
		int randSnipers = Random.Range(0,6);
		int randEnemy = Random.Range(0,4);
		while(enemiesOnScreen<totalEnemies ){
			if(enemiesOnScreen<15){
				randomEnemy(randEnemy,rand);
				enemiesOnScreen+=1;	
				yield return new WaitForSeconds(3f);
				if(snipersOnScreen<4){
					newSniperFunction(randSnipers);
					snipersOnScreen+=1;
					lsnipers.Add(randSnipers);
				}
				yield return new WaitForSeconds(3f);
			}
			else if(enemiesOnScreen>=15 && enemiesOnScreen<27){
				randomEnemy(randEnemy,rand);
				enemiesOnScreen+=1;	
				yield return new WaitForSeconds(3f);
				if(snipersOnScreen>=4 && snipersOnScreen<8){
					newSniperFunction(randSnipers);
					snipersOnScreen+=1;
					lsnipers.Add(randSnipers);
				}
				yield return new WaitForSeconds(2f);
			}
			else if(enemiesOnScreen>=27 && enemiesOnScreen<totalEnemies)
			{	
				randomEnemy(randEnemy,rand);
				enemiesOnScreen+=1;	
				yield return new WaitForSeconds(2f);
				if(snipersOnScreen>=8 && snipersOnScreen<12){
					newSniperFunction(randSnipers);
					snipersOnScreen+=1;
					lsnipers.Add(randSnipers);
				}
				yield return new WaitForSeconds(1f);
			}
			l.Add(rand);
			if(l.Count!=6)
			{	while(l.Contains(rand))
				{rand = Random.Range(0,6);
				yield return null;}
			}
			else if(l.Count == 6)
			{	l.Clear();}	
	
			if(lsnipers.Count!=6)
			{	while(lsnipers.Contains(randSnipers))
				{randSnipers = Random.Range(0,6);
				yield return null;}
			}
			else if(lsnipers.Count == 6)
			{lsnipers.Clear();}	

			whichEnemy.Add(randEnemy);
			if(whichEnemy.Count!=4)
			{	while(whichEnemy.Contains(randEnemy))
				{randEnemy = Random.Range(0,4);
				yield return null;}
			}
			else if(whichEnemy.Count == 4)
			{whichEnemy.Clear();}		
		}
		if(enemyNumber < totalEnemies)
		{
			totalKilled += (totalEnemies-enemyNumber);
		}
		else if(enemyNumber > totalEnemies)
		{
			totalKilled -= (enemyNumber-totalEnemies);
		}
	}

	//A LOT OF ENEMIES FROM ONE SIDE
	IEnumerator spawnLevel14(){
		totalEnemies = 48;
		totalSnipers = 12;
		totalMerceneries=0;
		yield return new WaitForSeconds(2f);
		List<int> l = new List<int>();
		List<int> lsnipers = new List<int>();	
		int rand = Random.Range(0,6);
		int randSnipers = Random.Range(0,6);
		int randEnemy = Random.Range(0,4);
		while(enemiesOnScreen<totalEnemies ){
			if(enemiesOnScreen<25){
				newBlochEnemyFunction(rand);
				yield return new WaitForSeconds(3f);
				newMummyEnemyFunction(rand);
				yield return new WaitForSeconds(3f);
				newScorpionEnemyFunction(rand);
				yield return new WaitForSeconds(3f);
				newWolfEnemyFunction(rand);
				yield return new WaitForSeconds(6f);
				enemiesOnScreen+=4;	
				if(snipersOnScreen<4){
					newSniperFunction(randSnipers);
					snipersOnScreen+=1;
					lsnipers.Add(randSnipers);
				}
			}
			else if(enemiesOnScreen>=25 && enemiesOnScreen<totalEnemies-3)
			{	
				newBlochEnemyFunction(rand);
				yield return new WaitForSeconds(2f);
				newMummyEnemyFunction(rand);
				yield return new WaitForSeconds(2f);
				newScorpionEnemyFunction(rand);
				yield return new WaitForSeconds(2f);
				newWolfEnemyFunction(rand);
				yield return new WaitForSeconds(3f);
				enemiesOnScreen+=4;	
				if(snipersOnScreen>4 && snipersOnScreen<totalSnipers){
					newSniperFunction(randSnipers);
					snipersOnScreen+=1;
					lsnipers.Add(randSnipers);
				}
			}
			l.Add(rand);
			if(l.Count!=6)
			{	while(l.Contains(rand))
				{rand = Random.Range(0,6);
				yield return null;}
			}
			else if(l.Count == 6)
			{	l.Clear();}	
	
			if(lsnipers.Count!=6)
			{	while(lsnipers.Contains(randSnipers))
				{randSnipers = Random.Range(0,6);
				yield return null;}
			}
			else if(lsnipers.Count == 6)
			{lsnipers.Clear();}		
		}
		if(enemyNumber < totalEnemies)
		{
			totalKilled += (totalEnemies-enemyNumber);
		}
		else if(enemyNumber > totalEnemies)
		{
			totalKilled -= (enemyNumber-totalEnemies);
		}
	}

	//SAME ENEMY FROM ALL SIDES AT THE SAME TIME
	IEnumerator spawnLevel15(){
		totalEnemies = 48;
		totalSnipers = 18;
		totalMerceneries=0;
		yield return new WaitForSeconds(2f);
		List<int> l = new List<int>();
		List<int> lsnipers = new List<int>();	
		int rand = Random.Range(0,6);
		int randSnipers = Random.Range(0,6);
		int randEnemy = Random.Range(0,4);
		while(enemiesOnScreen<totalEnemies ){
			if(enemiesOnScreen<6)
				{newBlochEnemyFunction(rand);
				if(snipersOnScreen<2){
					newSniperFunction(randSnipers);
					}
				}
			else if(enemiesOnScreen>=6 && enemiesOnScreen<12)
				{newScorpionEnemyFunction(rand);
				if(snipersOnScreen<4){
					newSniperFunction(randSnipers);
					}
				}
			else if(enemiesOnScreen>=12 && enemiesOnScreen<18)
				{newMummyEnemyFunction(rand);
				if(snipersOnScreen<6){
					newSniperFunction(randSnipers);
					}
				}
			else if(enemiesOnScreen>=18 && enemiesOnScreen<24)
				{newWolfEnemyFunction(rand);
				if(snipersOnScreen<9){
					newSniperFunction(randSnipers);
					}
				}
			else if(enemiesOnScreen>=24 && enemiesOnScreen<30)
				{newScorpionEnemyFunction(rand);
				if(snipersOnScreen<11){
					newSniperFunction(randSnipers);
					}
				}
			else if(enemiesOnScreen>=30 && enemiesOnScreen<36)
				{newMummyEnemyFunction(rand);
				if(snipersOnScreen<14){
					newSniperFunction(randSnipers);
					}
				}
			else if(enemiesOnScreen>=36 && enemiesOnScreen<42)
				{newBlochEnemyFunction(rand);
				if(snipersOnScreen<16){
					newSniperFunction(randSnipers);
					}
				}
			else if(enemiesOnScreen>=42 && enemiesOnScreen<48)
				{newWolfEnemyFunction(rand);
				if(snipersOnScreen<18){
					newSniperFunction(randSnipers);
					}
				}
			enemiesOnScreen+=1;
			snipersOnScreen+=1;	
			if(enemiesOnScreen==6)
				yield return new WaitForSeconds(8f);
			else if(enemiesOnScreen==12)
				yield return new WaitForSeconds(8f);
			else if(enemiesOnScreen==18)
				yield return new WaitForSeconds(8f);
			else if(enemiesOnScreen==24 )
				yield return new WaitForSeconds(8f);
			else if(enemiesOnScreen==30)
				yield return new WaitForSeconds(8f);
			else if(enemiesOnScreen==36)
				yield return new WaitForSeconds(8f);
			if(snipersOnScreen<4){
				
			}
			
			
			l.Add(rand);
			if(l.Count!=6)
			{	while(l.Contains(rand))
				{rand = Random.Range(0,6);
				yield return null;}
			}
			else if(l.Count == 6)
			{	l.Clear();}	
	
			lsnipers.Add(randSnipers);
			if(lsnipers.Count!=6)
			{	while(lsnipers.Contains(randSnipers))
				{randSnipers = Random.Range(0,6);
				yield return null;}
			}
			else if(lsnipers.Count == 6)
			{lsnipers.Clear();}		
		}
		if(enemyNumber < totalEnemies)
		{
			totalKilled += (totalEnemies-enemyNumber);
		}
		else if(enemyNumber > totalEnemies)
		{
			totalKilled -= (enemyNumber-totalEnemies);
		}
	}

	IEnumerator spawnLevel16(){
		totalMerceneries=8;
		totalEnemies=0;
		yield return new WaitForSeconds(3f);
		newMercOneFunction(0);
		yield return new WaitForSeconds(14f);
		newMercOneFunction(3);
		yield return new WaitForSeconds(15f);
		newMercOneFunction(1);
		yield return new WaitForSeconds(14f);
		newMercOneFunction(2);
		if(merceneryNumber < totalMerceneries )
		{
			totalMerceneriesKilled+= (totalMerceneries-merceneryNumber);
		}
		else if(merceneryNumber > totalMerceneries){
			totalMerceneriesKilled -= (merceneryNumber - totalMerceneries);
		}
	}

	IEnumerator spawnLevel17(){
		totalEnemies = 48;
		totalSnipers = 12;
		totalMerceneries=24;
		yield return new WaitForSeconds(5f);
		newMummyEnemyFunction(1);
		yield return new WaitForSeconds(5f);
		newMummyEnemyFunction(3);
		newMercOneFunction(0);
		yield return new WaitForSeconds(5f);
		newMummyEnemyFunction(5);
		yield return new WaitForSeconds(5f);
		yield return new WaitForSeconds(5f);
		newMercOneFunction(3);
		newMummyEnemyFunction(2);
		yield return new WaitForSeconds(5f);
		newMummyEnemyFunction(0);
		yield return new WaitForSeconds(5f);
		yield return new WaitForSeconds(5f);
		newMercOneFunction(1);
		yield return new WaitForSeconds(5f);
		newMummyEnemyFunction(2);
		newSniperFunction(2);
		yield return new WaitForSeconds(5f);
		newMummyEnemyFunction(5);
		yield return new WaitForSeconds(5f);
		newMercOneFunction(2);
		newMummyEnemyFunction(5);
		yield return new WaitForSeconds(5f);
		newMummyEnemyFunction(2);
		newMummyEnemyFunction(4);
		yield return new WaitForSeconds(5f);
		newMercOneFunction(2);
		yield return new WaitForSeconds(4f);
		newMummyEnemyFunction(1);
		yield return new WaitForSeconds(4f);
		newSniperFunction(1);
		yield return new WaitForSeconds(4f);
		newMercOneFunction(3);
		yield return new WaitForSeconds(4f);
		newMummyEnemyFunction(2);
		yield return new WaitForSeconds(4f);
		newMummyEnemyFunction(5);
		yield return new WaitForSeconds(4f);
		newMercOneFunction(1);
		yield return new WaitForSeconds(3.5f);
		newMummyEnemyFunction(0);
		yield return new WaitForSeconds(3.5f);
		newMummyEnemyFunction(2);
		newMercOneFunction(2);
		yield return new WaitForSeconds(3.5f);
		newMummyEnemyFunction(5);
		newMercOneFunction(3);
		yield return new WaitForSeconds(3.5f);
		newMummyEnemyFunction(1);
		newMummyEnemyFunction(4);
		newMercOneFunction(3);
		yield return new WaitForSeconds(3.5f);
		newMummyEnemyFunction(2);
		yield return new WaitForSeconds(3.5f);
		newMummyEnemyFunction(0);
		newMercOneFunction(0);
		yield return new WaitForSeconds(3.5f);
		newMummyEnemyFunction(5);
		yield return new WaitForSeconds(3.5f);
		newMummyEnemyFunction(4);
		newMercOneFunction(3);
		newMummyEnemyFunction(1);
		yield return new WaitForSeconds(3.5f);
		newMummyEnemyFunction(2);
		newMercOneFunction(1);
		yield return new WaitForSeconds(3.5f);
		newMummyEnemyFunction(5);
		yield return new WaitForSeconds(3.5f);
		newMummyEnemyFunction(4);
		newMummyEnemyFunction(0);
		yield return new WaitForSeconds(3.5f);
		newMummyEnemyFunction(1);
		newMercOneFunction(2);
		yield return new WaitForSeconds(3.5f);
		newMummyEnemyFunction(5);
		newMercOneFunction(0);
		yield return new WaitForSeconds(3.5f);
		newMummyEnemyFunction(3);
		yield return new WaitForSeconds(3.5f);
		newMummyEnemyFunction(2);
		newMercOneFunction(1);
		newMummyEnemyFunction(1);
		yield return new WaitForSeconds(3.5f);
		newMummyEnemyFunction(4);
		yield return new WaitForSeconds(3.5f);
		newMummyEnemyFunction(0);
		newMercOneFunction(3);
		yield return new WaitForSeconds(3.5f);
		newMummyEnemyFunction(1);
		yield return new WaitForSeconds(3.5f);
		newMummyEnemyFunction(2);
		newMercOneFunction(2);
		yield return new WaitForSeconds(3.5f);
		newMummyEnemyFunction(4);
		newMummyEnemyFunction(5);
		newMercOneFunction(0);
		newMummyEnemyFunction(0);
		yield return new WaitForSeconds(3.5f);
		newMummyEnemyFunction(1);
		newMercOneFunction(3);
		yield return new WaitForSeconds(3.5f);
		newMummyEnemyFunction(3);
		newMercOneFunction(3);
		yield return new WaitForSeconds(3.5f);
		newMummyEnemyFunction(2);
		newMummyEnemyFunction(3);
		newMummyEnemyFunction(0);
		newMercOneFunction(0);
		newMercOneFunction(2);
		yield return new WaitForSeconds(3.5f);
		newMummyEnemyFunction(1);
		yield return new WaitForSeconds(3.5f);
		newMummyEnemyFunction(4);
		newMercOneFunction(3);
		yield return new WaitForSeconds(3.5f);
		newMummyEnemyFunction(5);
		newScorpionEnemyFunction(2);
		newMummyEnemyFunction(1);
		if(enemyNumber < totalEnemies)
		{
			totalKilled += (totalEnemies-enemyNumber);
		}
		else if(enemyNumber > totalEnemies)
		{
			totalKilled -= (enemyNumber-totalEnemies);
		}

		if(merceneryNumber < totalMerceneries )
		{
			totalMerceneriesKilled+= (totalMerceneries-merceneryNumber);
		}
		else if(merceneryNumber > totalMerceneries){
			totalMerceneriesKilled -= (merceneryNumber - totalMerceneries);
		}
	}

	IEnumerator spawnLevel18(){
		totalEnemies = 48;
		totalSnipers = 18;
		totalMerceneries=24;
		yield return new WaitForSeconds(2f);
		List<int> l = new List<int>();
		List<int> lsnipers = new List<int>();
		List<int> lmerc = new List<int>();	
		int rand = Random.Range(0,6);
		int randSnipers = Random.Range(0,6);
		int randMerc = Random.Range(0,4);
		while(enemiesOnScreen<totalEnemies){	
			if(enemiesOnScreen<17){
				yield return new WaitForSeconds(6f);
				newBlochEnemyFunction(rand);
				yield return new WaitForSeconds(4f);
				if(merceneriesOnScreen<9){
					newMercOneFunction(randMerc);
					merceneriesOnScreen+=1;	
					lmerc.Add(randMerc);
				}
				yield return new WaitForSeconds(6f);
				newScorpionEnemyFunction(rand);
				if(snipersOnScreen<7){
					newSniperFunction(randSnipers);
					snipersOnScreen+=1;
					lsnipers.Add(randSnipers);
				}
				enemiesOnScreen+=2;
			}
			else if(enemiesOnScreen>=17 && enemiesOnScreen<33)
			{	yield return new WaitForSeconds(5f);
				newScorpionEnemyFunction(rand);
				yield return new WaitForSeconds(5f);
				if(merceneriesOnScreen<18){
					newMercOneFunction(randMerc);
					merceneriesOnScreen+=1;	
					lmerc.Add(randMerc);
				}
				yield return new WaitForSeconds(3f);
				newMummyEnemyFunction(rand);
				if(snipersOnScreen<13){
					newSniperFunction(randSnipers);
					snipersOnScreen+=1;
					lsnipers.Add(randSnipers);
				}
				enemiesOnScreen+=2;
			}
			else if(enemiesOnScreen>=33 && enemiesOnScreen<totalEnemies-1)
			{	yield return new WaitForSeconds(4f);
				newBlochEnemyFunction(rand);
				yield return new WaitForSeconds(5f);
				if(merceneriesOnScreen<totalMerceneries){
					newMercOneFunction(randMerc);
					merceneriesOnScreen+=1;	
					lmerc.Add(randMerc);
				}
				yield return new WaitForSeconds(3f);
				newMummyEnemyFunction(rand);
				if(snipersOnScreen<totalSnipers){
					newSniperFunction(randSnipers);
					snipersOnScreen+=1;
					lsnipers.Add(randSnipers);
				}
				enemiesOnScreen+=2;
			}
			
			l.Add(rand);
			if(l.Count!=6)
			{	while(l.Contains(rand))
				{rand = Random.Range(0,6);
				yield return null;}
			}
			else if(l.Count == 6)
			{	l.Clear();}	
	
			if(lsnipers.Count!=6)
			{	while(lsnipers.Contains(randSnipers))
				{randSnipers = Random.Range(0,6);
				yield return null;}
			}
			else if(lsnipers.Count == 6)
			{lsnipers.Clear();}	

			if(lmerc.Count!=4)
			{	while(lmerc.Contains(randMerc))
				{randMerc = Random.Range(0,4);
				yield return null;}
			}
			else if(lmerc.Count == 4)
			{	lmerc.Clear();}		
		}

		if(enemyNumber < totalEnemies)
		{
			totalKilled += (totalEnemies-enemyNumber);
		}
		else if(enemyNumber > totalEnemies)
		{
			totalKilled -= (enemyNumber-totalEnemies);
		}

		if(merceneryNumber < totalMerceneries )
		{
			totalMerceneriesKilled+= (totalMerceneries-merceneryNumber);
		}
		else if(merceneryNumber > totalMerceneries){
			totalMerceneriesKilled -= (merceneryNumber - totalMerceneries);
		}
	}

	IEnumerator spawnLevel19(){
		totalEnemies = 48;
		totalMerceneries=24;
		yield return new WaitForSeconds(2f);
		List<int> l = new List<int>();
		List<int> lmerc = new List<int>();	
		int rand = Random.Range(0,6);
		int randSnipers = Random.Range(0,6);
		int randMerc = Random.Range(0,4);
		while(enemiesOnScreen<totalEnemies){	
			if(enemiesOnScreen<17){
				yield return new WaitForSeconds(6f);
				newWolfEnemyFunction(rand);
				yield return new WaitForSeconds(4f);
				if(merceneriesOnScreen<9){
					newMercOneFunction(randMerc);
					merceneriesOnScreen+=1;	
					lmerc.Add(randMerc);
				}
				yield return new WaitForSeconds(6f);
				newBlochEnemyFunction(rand);
				enemiesOnScreen+=2;
			}
			else if(enemiesOnScreen>=17 && enemiesOnScreen<33)
			{	yield return new WaitForSeconds(5f);
				newBlochEnemyFunction(rand);
				yield return new WaitForSeconds(5f);
				if(merceneriesOnScreen<18){
					newMercOneFunction(randMerc);
					merceneriesOnScreen+=1;	
					lmerc.Add(randMerc);
				}
				yield return new WaitForSeconds(3f);
				newWolfEnemyFunction(rand);
				enemiesOnScreen+=2;
			}
			else if(enemiesOnScreen>=33 && enemiesOnScreen<totalEnemies-1)
			{	yield return new WaitForSeconds(4f);
				newWolfEnemyFunction(rand);
				yield return new WaitForSeconds(5f);
				if(merceneriesOnScreen<totalMerceneries){
					newMercOneFunction(randMerc);
					merceneriesOnScreen+=1;	
					lmerc.Add(randMerc);
				}
				yield return new WaitForSeconds(3f);
				newWolfEnemyFunction(rand);
				enemiesOnScreen+=2;
			}
			
			l.Add(rand);
			if(l.Count!=6)
			{	while(l.Contains(rand))
				{rand = Random.Range(0,6);
				yield return null;}
			}
			else if(l.Count == 6)
			{	l.Clear();}	

			if(lmerc.Count!=4)
			{	while(lmerc.Contains(randMerc))
				{randMerc = Random.Range(0,4);
				yield return null;}
			}
			else if(lmerc.Count == 4)
			{	lmerc.Clear();}		
		}
		if(enemyNumber < totalEnemies)
		{
			totalKilled += (totalEnemies-enemyNumber);
		}
		else if(enemyNumber > totalEnemies)
		{
			totalKilled -= (enemyNumber-totalEnemies);
		}

		if(merceneryNumber < totalMerceneries )
		{
			totalMerceneriesKilled+= (totalMerceneries-merceneryNumber);
		}
		else if(merceneryNumber > totalMerceneries){
			totalMerceneriesKilled -= (merceneryNumber - totalMerceneries);
		}
	}

	IEnumerator spawnLevel20(){
		totalEnemies = 48;
		totalSnipers = 18;
		totalMerceneries=24;
		yield return new WaitForSeconds(2f);
		List<int> l = new List<int>();
		List<int> lsnipers = new List<int>();
		List<int> lmerc = new List<int>();	
		int rand = Random.Range(0,6);
		int randSnipers = Random.Range(0,6);
		int randMerc = Random.Range(0,4);
		while(enemiesOnScreen<totalEnemies){	
			if(enemiesOnScreen<17){
				yield return new WaitForSeconds(6f);
				newScorpionEnemyFunction(rand);
				yield return new WaitForSeconds(4f);
				if(merceneriesOnScreen<9){
					newMercTwoFunction(randMerc);
					merceneriesOnScreen+=1;	
					lmerc.Add(randMerc);
				}
				yield return new WaitForSeconds(6f);
				newBlochEnemyFunction(rand);
				if(snipersOnScreen<7){
					newSniperFunction(randSnipers);
					snipersOnScreen+=1;
					lsnipers.Add(randSnipers);
				}
				enemiesOnScreen+=2;
			}
			else if(enemiesOnScreen>=17 && enemiesOnScreen<33)
			{	yield return new WaitForSeconds(5f);
				newMummyEnemyFunction(rand);
				yield return new WaitForSeconds(5f);
				if(merceneriesOnScreen<18){
					newMercOneFunction(randMerc);
					merceneriesOnScreen+=1;	
					lmerc.Add(randMerc);
				}
				yield return new WaitForSeconds(3f);
				newWolfEnemyFunction(rand);
				if(snipersOnScreen<13){
					newSniperFunction(randSnipers);
					snipersOnScreen+=1;
					lsnipers.Add(randSnipers);
				}
				enemiesOnScreen+=2;
			}
			else if(enemiesOnScreen>=33 && enemiesOnScreen<totalEnemies-1)
			{	yield return new WaitForSeconds(4f);
				newMummyEnemyFunction(rand);
				yield return new WaitForSeconds(5f);
				if(merceneriesOnScreen<totalMerceneries-1){
					newMercOneFunction(randMerc);
					newMercTwoFunction(Mathf.Abs(randMerc-3));
					merceneriesOnScreen+=2;	
					lmerc.Add(randMerc);
				}
				yield return new WaitForSeconds(3f);
				newScorpionEnemyFunction(rand);
				if(snipersOnScreen<totalSnipers){
					newSniperFunction(randSnipers);
					snipersOnScreen+=1;
					lsnipers.Add(randSnipers);
				}
				enemiesOnScreen+=2;
			}
			
			l.Add(rand);
			if(l.Count!=6)
			{	while(l.Contains(rand))
				{rand = Random.Range(0,6);
				yield return null;}
			}
			else if(l.Count == 6)
			{	l.Clear();}	
	
			if(lsnipers.Count!=6)
			{	while(lsnipers.Contains(randSnipers))
				{randSnipers = Random.Range(0,6);
				yield return null;}
			}
			else if(lsnipers.Count == 6)
			{lsnipers.Clear();}	

			if(lmerc.Count!=4)
			{	while(lmerc.Contains(randMerc))
				{randMerc = Random.Range(0,4);
				yield return null;}
			}
			else if(lmerc.Count == 4)
			{	lmerc.Clear();}		
		}
		newMercTwoFunction(3);

		if(enemyNumber < totalEnemies)
		{
			totalKilled += (totalEnemies-enemyNumber);
		}
		else if(enemyNumber > totalEnemies)
		{
			totalKilled -= (enemyNumber-totalEnemies);
		}

		if(merceneryNumber < totalMerceneries )
		{
			totalMerceneriesKilled+= (totalMerceneries-merceneryNumber);
		}
		else if(merceneryNumber > totalMerceneries){
			totalMerceneriesKilled -= (merceneryNumber - totalMerceneries);
		}
	}

	IEnumerator spawnLevel21(){
		totalEnemies = 12;
		totalSnipers = 0;
		totalMerceneries=48;
		yield return new WaitForSeconds(2f);
		List<int> l = new List<int>();
		List<int> lmerc = new List<int>();	
		int rand = Random.Range(0,6);
		int randMerc = Random.Range(0,4);
		for(int i =0;i<6;i++){
			int m = (i+1)*8;
			while(merceneriesOnScreen<m)
			{
				yield return new WaitForSeconds(7f);
				randomMercenery(1,randMerc);
				yield return new WaitForSeconds(5.5f);
				randomMercenery(2,Mathf.Abs(randMerc-3));
				merceneriesOnScreen+=2;
				lmerc.Add(randMerc);
				if(lmerc.Count!=4)
				{	while(lmerc.Contains(randMerc))
					{randMerc = Random.Range(0,4);
					yield return null;}
				}
				else if(lmerc.Count == 4)
				{	lmerc.Clear();
					randMerc = Random.Range(0,4);
				}	
			}
			newWolfEnemyFunction(i);
			newWolfEnemyFunction(Mathf.Abs(i-5));
		}
		if(enemyNumber < totalEnemies)
		{
			totalKilled += (totalEnemies-enemyNumber);
		}
		else if(enemyNumber > totalEnemies)
		{
			totalKilled -= (enemyNumber-totalEnemies);
		}

		if(merceneryNumber < totalMerceneries )
		{
			totalMerceneriesKilled+= (totalMerceneries-merceneryNumber);
		}
		else if(merceneryNumber > totalMerceneries){
			totalMerceneriesKilled -= (merceneryNumber - totalMerceneries);
		}
	}

	IEnumerator spawnLevel22(){
		totalEnemies = 14;
		totalSnipers = 0;
		totalMerceneries=56;
		yield return new WaitForSeconds(2f);
		List<int> l = new List<int>();
		List<int> lmerc = new List<int>();	
		int rand = Random.Range(0,6);
		int randMerc = Random.Range(0,4);
		for(int i =0;i<7;i++){
			int m = (i+1)*8;
			while(merceneriesOnScreen<m)
			{
				yield return new WaitForSeconds(6.8f);
				randomMercenery(1,randMerc);
				yield return new WaitForSeconds(5.6f);
				randomMercenery(2,Mathf.Abs(randMerc-3));
				merceneriesOnScreen+=2;
				lmerc.Add(randMerc);
				if(lmerc.Count!=4)
				{	while(lmerc.Contains(randMerc))
					{randMerc = Random.Range(0,4);
					yield return null;}
				}
				else if(lmerc.Count == 4)
				{	lmerc.Clear();
					randMerc = Random.Range(0,4);
				}	
			}
			if(i==0 || i==2 || i==4){
				newScorpionEnemyFunction(i);
				yield return new WaitForSeconds(1f);
				newWolfEnemyFunction(Mathf.Abs(i-5));
			}
			else if(i==1 || i==3 || i==5)
			{
				newScorpionEnemyFunction(i);
				yield return new WaitForSeconds(0.5f);
				newMummyEnemyFunction(Mathf.Abs(i-5));
			}
			else if(i==6)
			{
				newWolfEnemyFunction(1);
				newMummyEnemyFunction(4);
			}
		}
		
		if(enemyNumber < totalEnemies)
		{
			totalKilled += (totalEnemies-enemyNumber);
		}
		else if(enemyNumber > totalEnemies)
		{
			totalKilled -= (enemyNumber-totalEnemies);
		}

		if(merceneryNumber < totalMerceneries )
		{
			totalMerceneriesKilled+= (totalMerceneries-merceneryNumber);
		}
		else if(merceneryNumber > totalMerceneries){
			totalMerceneriesKilled -= (merceneryNumber - totalMerceneries);
		}
	}
	
	IEnumerator spawnLevel23(){
		totalEnemies = 32;
		totalSnipers = 12;
		totalMerceneries=48;
		yield return new WaitForSeconds(2f);
		List<int> l = new List<int>();
		List<int> lsnipers = new List<int>();
		List<int> lmerc = new List<int>();	
		List<int> whichEnemy = new List<int>();
		int rand = Random.Range(0,6);
		int randSnipers = Random.Range(0,6);
		int randMerc = Random.Range(0,4);
		int randEnemy = Random.Range(0,4);
		for(int i =0;i<6;i++){
			int m = (i+1)*8;
			newSniperFunction(i);
			snipersOnScreen+=1;
			while(merceneriesOnScreen<m)
			{
				yield return new WaitForSeconds(7f);
				randomMercenery(1,randMerc);
				yield return new WaitForSeconds(5.5f);
				randomMercenery(2,Mathf.Abs(randMerc-3));
				merceneriesOnScreen+=2;

				if(enemiesOnScreen<totalEnemies)
				{
					randomEnemy(randEnemy,rand);
					yield return new WaitForSeconds(1f);
					randomEnemy(Mathf.Abs(randEnemy-3),Mathf.Abs(rand-5));
					enemiesOnScreen+=2;
				}
				//RANDOMIZING AND CLEANING BLOCK
				lmerc.Add(randMerc);
				if(lmerc.Count!=4)
				{	while(lmerc.Contains(randMerc))
					{randMerc = Random.Range(0,4);
					yield return null;}
				}
				else if(lmerc.Count == 4)
				{	lmerc.Clear();
					randMerc = Random.Range(0,4);
				}
				lsnipers.Add(randSnipers);
				if(lsnipers.Count!=6)
				{	while(lsnipers.Contains(randSnipers))
					{randSnipers = Random.Range(0,6);
					yield return null;}
				}
				else if(lsnipers.Count == 6)
				{lsnipers.Clear();
				randSnipers = Random.Range(0,6);}	

				whichEnemy.Add(randEnemy);
				if(whichEnemy.Count!=4)
				{	while(whichEnemy.Contains(randEnemy))
					{randEnemy = Random.Range(0,4);
					yield return null;}
				}
				else if(whichEnemy.Count == 4)
				{whichEnemy.Clear();
				randEnemy = Random.Range(0,4);}	

				l.Add(rand);
				if(l.Count!=6)
				{	while(l.Contains(rand))
					{rand = Random.Range(0,6);
					yield return null;}
				}
				else if(l.Count == 6)
				{l.Clear();
				rand = Random.Range(0,6);}		
			}
			newSniperFunction(Mathf.Abs(i-5));
			snipersOnScreen+=1;
		}

		if(enemyNumber < totalEnemies)
		{
			totalKilled += (totalEnemies-enemyNumber);
		}
		else if(enemyNumber > totalEnemies)
		{
			totalKilled -= (enemyNumber-totalEnemies);
		}

		if(merceneryNumber < totalMerceneries )
		{
			totalMerceneriesKilled+= (totalMerceneries-merceneryNumber);
		}
		else if(merceneryNumber > totalMerceneries){
			totalMerceneriesKilled -= (merceneryNumber - totalMerceneries);
		}
	}

	IEnumerator spawnLevel24(){
		totalEnemies = 48;
		totalSnipers = 18;
		totalMerceneries=48;
		yield return new WaitForSeconds(6f);
		newMummyEnemyFunction(1);
		yield return new WaitForSeconds(6f);
		newWolfEnemyFunction(3);
		yield return new WaitForSeconds(6f);
		newBlochEnemyFunction(5);
		yield return new WaitForSeconds(6f);
		newMercOneFunction(0);
		yield return new WaitForSeconds(6f);
		newMercTwoFunction(3);
		yield return new WaitForSeconds(6f);
		newSniperFunction(4);
		newSniperFunction(1);
		yield return new WaitForSeconds(6f);
		newWolfEnemyFunction(2);
		yield return new WaitForSeconds(6f);
		newScorpionEnemyFunction(0);
		yield return new WaitForSeconds(6.5f);
		newMercTwoFunction(2);
		yield return new WaitForSeconds(6.5f);
		newMercOneFunction(1);
		yield return new WaitForSeconds(6.5f);
		newScorpionEnemyFunction(2);
		newSniperFunction(2);
		yield return new WaitForSeconds(6f);
		newSniperFunction(5);
		newBlochEnemyFunction(5);
		yield return new WaitForSeconds(6f);
		newBlochEnemyFunction(5);
		yield return new WaitForSeconds(6f);
		newWolfEnemyFunction(2);
		newMummyEnemyFunction(4);
		yield return new WaitForSeconds(6.5f);
		newMercTwoFunction(2);
		yield return new WaitForSeconds(6f);
		newBlochEnemyFunction(1);
		newMercOneFunction(0);
		yield return new WaitForSeconds(6f);
		newSniperFunction(1);
		yield return new WaitForSeconds(5f);
		newMercTwoFunction(3);
		yield return new WaitForSeconds(5f);
		newMercOneFunction(2);
		yield return new WaitForSeconds(5f);
		newScorpionEnemyFunction(2);
		yield return new WaitForSeconds(5f);
		newMercTwoFunction(0);
		yield return new WaitForSeconds(4f);
		newMercOneFunction(3);
		newWolfEnemyFunction(5);
		newSniperFunction(5);
		yield return new WaitForSeconds(5f);
		newMercOneFunction(0);
		newMercOneFunction(1);
		newMercOneFunction(2);
		yield return new WaitForSeconds(5.5f);
		newWolfEnemyFunction(0);
		newMercOneFunction(3);
		yield return new WaitForSeconds(5.5f);
		newBlochEnemyFunction(2);
		newMercTwoFunction(1);
		yield return new WaitForSeconds(5.5f);
		newScorpionEnemyFunction(5);
		newMercOneFunction(3);
		yield return new WaitForSeconds(5.5f);
		newWolfEnemyFunction(1);
		newMummyEnemyFunction(4);
		newMercTwoFunction(3);
		yield return new WaitForSeconds(4.5f);
		newBlochEnemyFunction(2);
		newMercTwoFunction(0);
		yield return new WaitForSeconds(4.5f);
		newWolfEnemyFunction(0);
		newMercOneFunction(0);
		yield return new WaitForSeconds(4.5f);
		newScorpionEnemyFunction(5);
		newMercTwoFunction(2);
		yield return new WaitForSeconds(4.5f);
		newWolfEnemyFunction(4);
		newMercOneFunction(3);
		yield return new WaitForSeconds(3.5f);
		newBlochEnemyFunction(1);
		newMercTwoFunction(1);
		yield return new WaitForSeconds(4.5f);
		newScorpionEnemyFunction(2);
		newMercTwoFunction(1);
		yield return new WaitForSeconds(4.5f);
		newMummyEnemyFunction(5);
		newMercOneFunction(0);
		yield return new WaitForSeconds(4.5f);
		newMummyEnemyFunction(4);
		newBlochEnemyFunction(0);
		newMercTwoFunction(1);
		yield return new WaitForSeconds(4.5f);
		newScorpionEnemyFunction(1);
		newMercOneFunction(2);
		yield return new WaitForSeconds(4.5f);
		newMummyEnemyFunction(5);
		newMercOneFunction(0);
		yield return new WaitForSeconds(4.5f);
		newWolfEnemyFunction(3);
		newMercTwoFunction(1);
		yield return new WaitForSeconds(4.5f);
		newBlochEnemyFunction(2);
		newMercOneFunction(1);
		newScorpionEnemyFunction(1);
		yield return new WaitForSeconds(5.5f);
		newMummyEnemyFunction(4);
		newMercOneFunction(1);
		yield return new WaitForSeconds(5.5f);
		newBlochEnemyFunction(0);
		newMercOneFunction(3);
		yield return new WaitForSeconds(5.5f);
		newWolfEnemyFunction(1);
		newMercTwoFunction(0);
		yield return new WaitForSeconds(4.5f);
		newMummyEnemyFunction(2);
		newMercOneFunction(2);
		yield return new WaitForSeconds(5.5f);
		newBlochEnemyFunction(4);
		yield return new WaitForSeconds(2.5f);
		newMummyEnemyFunction(5);
		newMercOneFunction(2);
		yield return new WaitForSeconds(4.5f);
		newMercTwoFunction(0);
		newScorpionEnemyFunction(0);
		yield return new WaitForSeconds(4.5f);
		newWolfEnemyFunction(1);
		newMercTwoFunction(3);
		yield return new WaitForSeconds(5.5f);
		newBlochEnemyFunction(3);
		newMercTwoFunction(3);
		yield return new WaitForSeconds(4.5f);
		newScorpionEnemyFunction(2);
		newBlochEnemyFunction(3);
		yield return new WaitForSeconds(3.5f);
		newBlochEnemyFunction(3);
		newMercOneFunction(0);
		newMercOneFunction(1);
		yield return new WaitForSeconds(8f);
		newMercOneFunction(2);
		newMercOneFunction(3);
		yield return new WaitForSeconds(4.5f);
		newScorpionEnemyFunction(1);
		newMercTwoFunction(3);
		yield return new WaitForSeconds(4.5f);
		newBlochEnemyFunction(4);
		newMercTwoFunction(2);
		yield return new WaitForSeconds(3f);
		newMercTwoFunction(1);
		yield return new WaitForSeconds(3.5f);
		newMercTwoFunction(3);
		yield return new WaitForSeconds(4.5f);
		newWolfEnemyFunction(5);
		newScorpionEnemyFunction(2);
		newMercTwoFunction(3);
		yield return new WaitForSeconds(4.5f);
		newMercOneFunction(2);
		yield return new WaitForSeconds(4.5f);
		newMercTwoFunction(2);
		if(enemyNumber < totalEnemies)
		{
			totalKilled += (totalEnemies-enemyNumber);
		}
		else if(enemyNumber > totalEnemies)
		{
			totalKilled -= (enemyNumber-totalEnemies);
		}

		if(merceneryNumber < totalMerceneries )
		{
			totalMerceneriesKilled+= (totalMerceneries-merceneryNumber);
		}
		else if(merceneryNumber > totalMerceneries){
			totalMerceneriesKilled -= (merceneryNumber - totalMerceneries);
		}
	}

	IEnumerator spawnLevel25(){
		totalEnemies = 52;
		totalSnipers = 22;
		totalMerceneries=50;
		yield return new WaitForSeconds(6.5f);
		newWolfEnemyFunction(1);
		yield return new WaitForSeconds(6f);
		newBlochEnemyFunction(3);
		yield return new WaitForSeconds(6f);
		newMummyEnemyFunction(5);
		yield return new WaitForSeconds(6f);
		newMercOneFunction(0);
		yield return new WaitForSeconds(6f);
		newMercTwoFunction(3);
		newSniperFunction(4);
		yield return new WaitForSeconds(6f);
		newSniperFunction(1);
		yield return new WaitForSeconds(6f);
		newScorpionEnemyFunction(2);
		yield return new WaitForSeconds(5f);
		newBlochEnemyFunction(0);
		newSniperFunction(0);
		yield return new WaitForSeconds(5f);
		newMercOneFunction(2);
		yield return new WaitForSeconds(5f);
		newMercThreeFunction(1);
		yield return new WaitForSeconds(5.7f);
		newWolfEnemyFunction(2);
		newSniperFunction(2);
		yield return new WaitForSeconds(5.7f);
		newSniperFunction(5);
		newMummyEnemyFunction(5);
		yield return new WaitForSeconds(5f);
		newScorpionEnemyFunction(5);
		yield return new WaitForSeconds(5.5f);
		newWolfEnemyFunction(2);
		newMummyEnemyFunction(4);
		yield return new WaitForSeconds(5.6f);
		newMercThreeFunction(2);
		yield return new WaitForSeconds(4.4f);
		newBlochEnemyFunction(1);
		newMercOneFunction(0);
		yield return new WaitForSeconds(5f);
		newSniperFunction(1);
		yield return new WaitForSeconds(5.4f);
		newMercTwoFunction(3);
		yield return new WaitForSeconds(5f);
		newMercThreeFunction(2);
		yield return new WaitForSeconds(5f);
		newScorpionEnemyFunction(2);
		newSniperFunction(2);
		yield return new WaitForSeconds(5f);
		newMercThreeFunction(0);
		newMercOneFunction(3);
		yield return new WaitForSeconds(3.5f);
		newWolfEnemyFunction(5);
		newSniperFunction(5);
		yield return new WaitForSeconds(6f);
		newMercOneFunction(0);
		newMercThreeFunction(1);
		yield return new WaitForSeconds(6f);
		newMercOneFunction(2);
		newWolfEnemyFunction(0);
		newSniperFunction(0);
		newMercOneFunction(3);
		yield return new WaitForSeconds(5f);
		newMummyEnemyFunction(2);
		newMercTwoFunction(1);
		yield return new WaitForSeconds(4.5f);
		newScorpionEnemyFunction(5);
		newMercOneFunction(2);
		yield return new WaitForSeconds(4.5f);
		newBlochEnemyFunction(1);
		newMummyEnemyFunction(4);
		newMercTwoFunction(3);
		yield return new WaitForSeconds(3.5f);
		newBlochEnemyFunction(2);
		newMercThreeFunction(0);
		yield return new WaitForSeconds(3.5f);
		newWolfEnemyFunction(0);
		newMercOneFunction(0);
		yield return new WaitForSeconds(4.5f);
		newScorpionEnemyFunction(5);
		newSniperFunction(5);
		newMercThreeFunction(2);
		yield return new WaitForSeconds(4.5f);
		newWolfEnemyFunction(4);
		newMercOneFunction(3);
		yield return new WaitForSeconds(3.5f);
		newWolfEnemyFunction(1);
		newMercTwoFunction(1);
		yield return new WaitForSeconds(3.5f);
		newScorpionEnemyFunction(2);
		newMercTwoFunction(1);
		yield return new WaitForSeconds(5.5f);
		newMummyEnemyFunction(5);
		newMercThreeFunction(0);
		yield return new WaitForSeconds(4.5f);
		newMummyEnemyFunction(4);
		newBlochEnemyFunction(0);
		newMercTwoFunction(1);
		yield return new WaitForSeconds(3.5f);
		newMummyEnemyFunction(1);
		newMercOneFunction(2);
		yield return new WaitForSeconds(5.5f);
		newWolfEnemyFunction(5);
		newMercOneFunction(0);
		yield return new WaitForSeconds(4.5f);
		newWolfEnemyFunction(3);
		newMercThreeFunction(1);
		yield return new WaitForSeconds(4.5f);
		newScorpionEnemyFunction(2);
		newMercOneFunction(1);
		newBlochEnemyFunction(1);
		yield return new WaitForSeconds(4.5f);
		newWolfEnemyFunction(4);
		newMercOneFunction(1);
		yield return new WaitForSeconds(5.5f);
		newBlochEnemyFunction(0);
		newMercThreeFunction(3);
		yield return new WaitForSeconds(6.5f);
		newScorpionEnemyFunction(1);
		newMercTwoFunction(0);
		yield return new WaitForSeconds(4.5f);
		newMummyEnemyFunction(2);
		newMercOneFunction(2);
		yield return new WaitForSeconds(3.5f);
		newWolfEnemyFunction(4);
		newMummyEnemyFunction(5);
		newMercOneFunction(2);
		yield return new WaitForSeconds(4.5f);
		newMercThreeFunction(0);
		newScorpionEnemyFunction(0);
		yield return new WaitForSeconds(4.5f);
		newBlochEnemyFunction(1);
		newMercTwoFunction(3);
		yield return new WaitForSeconds(3.5f);
		newBlochEnemyFunction(3);
		newMercThreeFunction(3);
		yield return new WaitForSeconds(4.5f);
		newScorpionEnemyFunction(2);
		yield return new WaitForSeconds(3.5f);
		newBlochEnemyFunction(3);
		newWolfEnemyFunction(3);
		newMercTwoFunction(0);
		yield return new WaitForSeconds(3.5f);
		newMercOneFunction(1);
		yield return new WaitForSeconds(5.5f);
		newScorpionEnemyFunction(1);
		newMercTwoFunction(3);
		yield return new WaitForSeconds(3.5f);
		newMercThreeFunction(2);
		yield return new WaitForSeconds(3f);
		newMercOneFunction(3);
		yield return new WaitForSeconds(4.5f);
		newScorpionEnemyFunction(4);
		newMercTwoFunction(2);
		yield return new WaitForSeconds(3.5f);
		newMercThreeFunction(1);
		yield return new WaitForSeconds(1.5f);
		newMercTwoFunction(3);
		yield return new WaitForSeconds(3.5f);
		newWolfEnemyFunction(5);
		newMummyEnemyFunction(2);
		yield return new WaitForSeconds(3.5f);
		newMercTwoFunction(3);
		yield return new WaitForSeconds(2.5f);
		newMercOneFunction(2);
		yield return new WaitForSeconds(6.5f);
		newMercTwoFunction(2);
		newScorpionEnemyFunction(1);
		yield return new WaitForSeconds(3.5f);
		newMummyEnemyFunction(0);
		yield return new WaitForSeconds(4.5f);
		newMercThreeFunction(0);
		newBlochEnemyFunction(4);
		yield return new WaitForSeconds(3.5f);
		newMercTwoFunction(3);
		newMummyEnemyFunction(5);
		if(enemyNumber < totalEnemies)
		{
			totalKilled += (totalEnemies-enemyNumber);
		}
		else if(enemyNumber > totalEnemies)
		{
			totalKilled -= (enemyNumber-totalEnemies);
		}

		if(merceneryNumber < totalMerceneries )
		{
			totalMerceneriesKilled+= (totalMerceneries-merceneryNumber);
		}
		else if(merceneryNumber > totalMerceneries){
			totalMerceneriesKilled -= (merceneryNumber - totalMerceneries);
		}
	} 

	IEnumerator spawnLevel26(){
		totalEnemies = 52;
		totalSnipers = 21;
		totalMerceneries=56;
		List<int> l = new List<int>();
		List<int> lsnipers = new List<int>();
		List<int> lmerc = new List<int>();	
		List<int> whichEnemy = new List<int>();
		int rand = Random.Range(0,6);
		int randSnipers = Random.Range(0,6);
		int randMerc = Random.Range(0,4);
		int randEnemy = Random.Range(0,4);
		for(int i =0;i<7;i++){
			int m = (i+1)*8;
			if(i<6){
			newSniperFunction(i);
			yield return new WaitForSeconds(6f);
			newSniperFunction(Mathf.Abs(i-5));
			snipersOnScreen+=2;
			}
			else if(i==6)
			{
			newSniperFunction(0);
			yield return new WaitForSeconds(4f);
			newSniperFunction(5);
			snipersOnScreen+=2;
			}
			while(merceneriesOnScreen<m)
			{
				if(i==0 || i==1){
					yield return new WaitForSeconds(6f);
					randomMercenery(1,randMerc);
					yield return new WaitForSeconds(6f);
					randomMercenery(2,Mathf.Abs(randMerc-3));
					merceneriesOnScreen+=2;
				}
				else if(i==2 || i==3 | i==4)
				{
					yield return new WaitForSeconds(5f);
					randomMercenery(3,randMerc);
					yield return new WaitForSeconds(5.5f);
					randomMercenery(1,Mathf.Abs(randMerc-3));
					merceneriesOnScreen+=2;
				}
				else if(i==5 || i==6)
				{
					yield return new WaitForSeconds(5f);
					randomMercenery(2,randMerc);
					yield return new WaitForSeconds(4.5f);
					randomMercenery(3,Mathf.Abs(randMerc-3));
					merceneriesOnScreen+=2;
				}
				

				if(enemiesOnScreen<totalEnemies)
				{
					randomEnemy(randEnemy,rand);
					yield return new WaitForSeconds(1f);
					randomEnemy(Mathf.Abs(randEnemy-3),Mathf.Abs(rand-5));
					enemiesOnScreen+=2;
				}
				//RANDOMIZING AND CLEANING BLOCK
				lmerc.Add(randMerc);
				if(lmerc.Count!=4)
				{	while(lmerc.Contains(randMerc))
					{randMerc = Random.Range(0,4);
					yield return null;}
				}
				else if(lmerc.Count == 4)
				{	lmerc.Clear();
					randMerc = Random.Range(0,4);
				}
				lsnipers.Add(randSnipers);
				if(lsnipers.Count!=6)
				{	while(lsnipers.Contains(randSnipers))
					{randSnipers = Random.Range(0,6);
					yield return null;}
				}
				else if(lsnipers.Count == 6)
				{lsnipers.Clear();
				randSnipers = Random.Range(0,6);}	

				whichEnemy.Add(randEnemy);
				if(whichEnemy.Count!=4)
				{	while(whichEnemy.Contains(randEnemy))
					{randEnemy = Random.Range(0,4);
					yield return null;}
				}
				else if(whichEnemy.Count == 4)
				{whichEnemy.Clear();
				randEnemy = Random.Range(0,4);}	

				l.Add(rand);
				if(l.Count!=6)
				{	while(l.Contains(rand))
					{rand = Random.Range(0,6);
					yield return null;}
				}
				else if(l.Count == 6)
				{l.Clear();
				rand = Random.Range(0,6);}		
			}
			if(i<6){
				newSniperFunction(Mathf.Abs(i-5));
				snipersOnScreen+=1;
			}
			else if(i==6)
			{
				newSniperFunction(3);
				snipersOnScreen+=1;
			}
		}

		if(enemyNumber < totalEnemies)
		{
			totalKilled += (totalEnemies-enemyNumber);
		}
		else if(enemyNumber > totalEnemies)
		{
			totalKilled -= (enemyNumber-totalEnemies);
		}

		if(merceneryNumber < totalMerceneries )
		{
			totalMerceneriesKilled+= (totalMerceneries-merceneryNumber);
		}
		else if(merceneryNumber > totalMerceneries){
			totalMerceneriesKilled -= (merceneryNumber - totalMerceneries);
		}
	}

	IEnumerator spawnLevel27(){
		totalEnemies = 52;
		totalSnipers = 21;
		totalMerceneries=56;
		List<int> l = new List<int>();
		List<int> lsnipers = new List<int>();
		List<int> lmerc = new List<int>();	
		List<int> whichEnemy = new List<int>();
		int rand = Random.Range(0,6);
		int randSnipers = Random.Range(0,6);
		int randMerc = Random.Range(0,4);
		int randEnemy = Random.Range(0,4);
		for(int i =0;i<7;i++){
			int m = (i+1)*8;
			if(i<6){
			newSniperFunction(i);
			yield return new WaitForSeconds(5f);
			newSniperFunction(Mathf.Abs(i-5));
			snipersOnScreen+=2;
			}
			else if(i==6)
			{
			newSniperFunction(1);
			yield return new WaitForSeconds(5f);
			newSniperFunction(4);
			snipersOnScreen+=2;
			}
			while(merceneriesOnScreen<m)
			{
				if(i==0 || i==1){
					yield return new WaitForSeconds(4.5f);
					randomMercenery(1,randMerc);
					yield return new WaitForSeconds(4.5f);
					randomMercenery(1,Mathf.Abs(randMerc-3));
					merceneriesOnScreen+=2;
				}
				else if(i==2 || i==3 | i==4)
				{
					yield return new WaitForSeconds(5f);
					randomMercenery(2,randMerc);
					yield return new WaitForSeconds(5.5f);
					randomMercenery(2,Mathf.Abs(randMerc-3));
					merceneriesOnScreen+=2;
				}
				else if(i==5 || i==6)
				{
					yield return new WaitForSeconds(6f);
					randomMercenery(3,randMerc);
					yield return new WaitForSeconds(4f);
					randomMercenery(3,Mathf.Abs(randMerc-3));
					merceneriesOnScreen+=2;
				}
				

				if(enemiesOnScreen<totalEnemies)
				{
					randomEnemy(randEnemy,rand);
					yield return new WaitForSeconds(0.3f);
					randomEnemy(Mathf.Abs(randEnemy-3),Mathf.Abs(rand-5));
					enemiesOnScreen+=2;
				}
				//RANDOMIZING AND CLEANING BLOCK
				lmerc.Add(randMerc);
				if(lmerc.Count!=4)
				{	while(lmerc.Contains(randMerc))
					{randMerc = Random.Range(0,4);
					yield return null;}
				}
				else if(lmerc.Count == 4)
				{	lmerc.Clear();
					randMerc = Random.Range(0,4);
				}
				lsnipers.Add(randSnipers);
				if(lsnipers.Count!=6)
				{	while(lsnipers.Contains(randSnipers))
					{randSnipers = Random.Range(0,6);
					yield return null;}
				}
				else if(lsnipers.Count == 6)
				{lsnipers.Clear();
				randSnipers = Random.Range(0,6);}	

				whichEnemy.Add(randEnemy);
				if(whichEnemy.Count!=4)
				{	while(whichEnemy.Contains(randEnemy))
					{randEnemy = Random.Range(0,4);
					yield return null;}
				}
				else if(whichEnemy.Count == 4)
				{whichEnemy.Clear();
				randEnemy = Random.Range(0,4);}	

				l.Add(rand);
				if(l.Count!=6)
				{	while(l.Contains(rand))
					{rand = Random.Range(0,6);
					yield return null;}
				}
				else if(l.Count == 6)
				{l.Clear();
				rand = Random.Range(0,6);}		
			}
			if(i<6){
				newSniperFunction(Mathf.Abs(i-5));
				snipersOnScreen+=1;
			}
			else if(i==6)
			{
				newSniperFunction(5);
				snipersOnScreen+=1;
			}
		}
		if(enemyNumber < totalEnemies)
		{
			totalKilled += (totalEnemies-enemyNumber);
		}
		else if(enemyNumber > totalEnemies)
		{
			totalKilled -= (enemyNumber-totalEnemies);
		}

		if(merceneryNumber < totalMerceneries )
		{
			totalMerceneriesKilled+= (totalMerceneries-merceneryNumber);
		}
		else if(merceneryNumber > totalMerceneries){
			totalMerceneriesKilled -= (merceneryNumber - totalMerceneries);
		}
	}

	IEnumerator spawnLevel28(){
		totalEnemies = 52;
		totalSnipers = 21;
		totalMerceneries=56;
		List<int> l = new List<int>();
		List<int> lsnipers = new List<int>();
		List<int> lmerc = new List<int>();	
		List<int> whichEnemy = new List<int>();
		List<int> whichMerc = new List<int>();
		int rand = Random.Range(0,6);
		int randSnipers = Random.Range(0,6);
		int randMerc = Random.Range(0,4);
		int randEnemy = Random.Range(0,4);
		int randMercenery = Random.Range(0,4); 
		for(int i =0;i<7;i++){
			int m = (i+1)*8;
			if(i<6){
			newSniperFunction(i);
			snipersOnScreen+=1;
			}
			else if(i==6)
			{
			newSniperFunction(2);
			snipersOnScreen+=1;
			}
			while(merceneriesOnScreen<m)
			{
				yield return new WaitForSeconds(5f);
				randomMercenery2(randMercenery,randMerc);
				yield return new WaitForSeconds(4.5f);
				randomMercenery2(Mathf.Abs(randMercenery-3),Mathf.Abs(randMerc-3));
				merceneriesOnScreen+=2;
				

				if(enemiesOnScreen<totalEnemies)
				{
					randomEnemy(randEnemy,rand);
					randomEnemy(Mathf.Abs(randEnemy-3),Mathf.Abs(rand-5));
					enemiesOnScreen+=2;
				}
				//RANDOMIZING AND CLEANING BLOCK
				lmerc.Add(randMerc);
				if(lmerc.Count!=4)
				{	while(lmerc.Contains(randMerc))
					{randMerc = Random.Range(0,4);
					yield return null;}
				}
				else if(lmerc.Count == 4)
				{	lmerc.Clear();
					randMerc = Random.Range(0,4);
				}
				lsnipers.Add(randSnipers);
				if(lsnipers.Count!=6)
				{	while(lsnipers.Contains(randSnipers))
					{randSnipers = Random.Range(0,6);
					yield return null;}
				}
				else if(lsnipers.Count == 6)
				{lsnipers.Clear();
				randSnipers = Random.Range(0,6);}	

				whichEnemy.Add(randEnemy);
				if(whichEnemy.Count!=4)
				{	while(whichEnemy.Contains(randEnemy))
					{randEnemy = Random.Range(0,4);
					yield return null;}
				}
				else if(whichEnemy.Count == 4)
				{whichEnemy.Clear();
				randEnemy = Random.Range(0,4);}	

				l.Add(rand);
				if(l.Count!=6)
				{	while(l.Contains(rand))
					{rand = Random.Range(0,6);
					yield return null;}
				}
				else if(l.Count == 6)
				{l.Clear();
				rand = Random.Range(0,6);}

				whichMerc.Add(randMercenery);
				if(whichMerc.Count!=4)
				{	while(whichMerc.Contains(randMercenery))
					{randMercenery = Random.Range(0,4);
					yield return null;}
				}
				else if(whichMerc.Count == 4)
				{whichMerc.Clear();
				randMercenery = Random.Range(0,4);}			
			}
			if(i<6){
				newSniperFunction(Mathf.Abs(i-5));
				yield return new WaitForSeconds(2.5f);
				newSniperFunction(i);
				snipersOnScreen+=2;
			}
			else if(i==6)
			{
				newSniperFunction(5);
				yield return new WaitForSeconds(3.5f);
				newSniperFunction(4);
				snipersOnScreen+=2;
			}
		}
		if(enemyNumber < totalEnemies)
		{
			totalKilled += (totalEnemies-enemyNumber);
		}
		else if(enemyNumber > totalEnemies)
		{
			totalKilled -= (enemyNumber-totalEnemies);
		}

		if(merceneryNumber < totalMerceneries )
		{
			totalMerceneriesKilled+= (totalMerceneries-merceneryNumber);
		}
		else if(merceneryNumber > totalMerceneries){
			totalMerceneriesKilled -= (merceneryNumber - totalMerceneries);
		}
	}

	IEnumerator spawnLevel29(){
		totalEnemies = 60;
		totalSnipers = 24;
		totalMerceneries=64;
		List<int> l = new List<int>();
		List<int> lsnipers = new List<int>();
		List<int> lmerc = new List<int>();	
		List<int> whichEnemy = new List<int>();
		List<int> whichMerc = new List<int>();
		int rand = Random.Range(0,6);
		int randSnipers = Random.Range(0,6);
		int randMerc = Random.Range(0,4);
		int randEnemy = Random.Range(0,4);
		int randMercenery = Random.Range(0,4); 
		for(int i =0;i<8;i++){
			int m = (i+1)*8;
			newSniperFunction(randSnipers);
			snipersOnScreen+=1;
			
			while(merceneriesOnScreen<m)
			{
				yield return new WaitForSeconds(4.5f);
				randomMercenery2(randMercenery,randMerc);
				yield return new WaitForSeconds(4f);
				randomMercenery2(Mathf.Abs(randMercenery-3),Mathf.Abs(randMerc-3));
				merceneriesOnScreen+=2;
				

				if(enemiesOnScreen<totalEnemies)
				{
					randomEnemy(randEnemy,rand);
					randomEnemy(Mathf.Abs(randEnemy-3),Mathf.Abs(rand-5));
					enemiesOnScreen+=2;
				}
				//RANDOMIZING AND CLEANING BLOCK
				lmerc.Add(randMerc);
				if(lmerc.Count!=4)
				{	while(lmerc.Contains(randMerc))
					{randMerc = Random.Range(0,4);
					yield return null;}
				}
				else if(lmerc.Count == 4)
				{	lmerc.Clear();
					randMerc = Random.Range(0,4);
				}
				lsnipers.Add(randSnipers);
				if(lsnipers.Count!=6)
				{	while(lsnipers.Contains(randSnipers))
					{randSnipers = Random.Range(0,6);
					yield return null;}
				}
				else if(lsnipers.Count == 6)
				{lsnipers.Clear();
				randSnipers = Random.Range(0,6);}	

				whichEnemy.Add(randEnemy);
				if(whichEnemy.Count!=4)
				{	while(whichEnemy.Contains(randEnemy))
					{randEnemy = Random.Range(0,4);
					yield return null;}
				}
				else if(whichEnemy.Count == 4)
				{whichEnemy.Clear();
				randEnemy = Random.Range(0,4);}	

				l.Add(rand);
				if(l.Count!=6)
				{	while(l.Contains(rand))
					{rand = Random.Range(0,6);
					yield return null;}
				}
				else if(l.Count == 6)
				{l.Clear();
				rand = Random.Range(0,6);}

				whichMerc.Add(randMercenery);
				if(whichMerc.Count!=4)
				{	while(whichMerc.Contains(randMercenery))
					{randMercenery = Random.Range(0,4);
					yield return null;}
				}
				else if(whichMerc.Count == 4)
				{whichMerc.Clear();
				randMercenery = Random.Range(0,4);}			
			}
			newSniperFunction(Mathf.Abs(randSnipers-5));
			yield return new WaitForSeconds(2f);
			newSniperFunction(randSnipers);
			snipersOnScreen+=2;
		}
		if(enemyNumber < totalEnemies)
		{
			totalKilled += (totalEnemies-enemyNumber);
		}
		else if(enemyNumber > totalEnemies)
		{
			totalKilled -= (enemyNumber-totalEnemies);
		}

		if(merceneryNumber < totalMerceneries )
		{
			totalMerceneriesKilled+= (totalMerceneries-merceneryNumber);
		}
		else if(merceneryNumber > totalMerceneries){
			totalMerceneriesKilled -= (merceneryNumber - totalMerceneries);
		}
	}
	
	IEnumerator spawnLevel30(){
		totalEnemies = 64;
		totalSnipers = 32;
		totalMerceneries=64;
		List<int> l = new List<int>();
		List<int> lsnipers = new List<int>();
		List<int> lmerc = new List<int>();	
		List<int> whichEnemy = new List<int>();
		List<int> whichMerc = new List<int>();
		int rand = Random.Range(0,6);
		int randSnipers = Random.Range(0,6);
		int randMerc = Random.Range(0,4);
		int randEnemy = Random.Range(0,4);
		int randMercenery = Random.Range(0,4); 
		for(int i =0;i<8;i++){
			int m = (i+1)*8;
			newSniperFunction(randSnipers);
			yield return new WaitForSeconds(1.5f);
			newSniperFunction(Mathf.Abs(randSnipers-5));
			snipersOnScreen+=2;
			
			while(merceneriesOnScreen<m)
			{
				yield return new WaitForSeconds(3f);
				randomMercenery2(randMercenery,randMerc);
				yield return new WaitForSeconds(3.5f);
				randomMercenery2(Mathf.Abs(randMercenery-3),Mathf.Abs(randMerc-3));
				merceneriesOnScreen+=2;
				
				if(enemiesOnScreen<totalEnemies)
				{
					randomEnemy(randEnemy,rand);
					yield return new WaitForSeconds(1f);
					randomEnemy(Mathf.Abs(randEnemy-3),Mathf.Abs(rand-5));
					enemiesOnScreen+=2;
				}
				//RANDOMIZING AND CLEANING BLOCK
				lmerc.Add(randMerc);
				if(lmerc.Count!=4)
				{	while(lmerc.Contains(randMerc))
					{randMerc = Random.Range(0,4);
					yield return null;}
				}
				else if(lmerc.Count == 4)
				{	lmerc.Clear();
					randMerc = Random.Range(0,4);
				}
				lsnipers.Add(randSnipers);
				if(lsnipers.Count!=6)
				{	while(lsnipers.Contains(randSnipers))
					{randSnipers = Random.Range(0,6);
					yield return null;}
				}
				else if(lsnipers.Count == 6)
				{lsnipers.Clear();
				randSnipers = Random.Range(0,6);}	

				whichEnemy.Add(randEnemy);
				if(whichEnemy.Count!=4)
				{	while(whichEnemy.Contains(randEnemy))
					{randEnemy = Random.Range(0,4);
					yield return null;}
				}
				else if(whichEnemy.Count == 4)
				{whichEnemy.Clear();
				randEnemy = Random.Range(0,4);}	

				l.Add(rand);
				if(l.Count!=6)
				{	while(l.Contains(rand))
					{rand = Random.Range(0,6);
					yield return null;}
				}
				else if(l.Count == 6)
				{l.Clear();
				rand = Random.Range(0,6);}

				whichMerc.Add(randMercenery);
				if(whichMerc.Count!=4)
				{	while(whichMerc.Contains(randMercenery))
					{randMercenery = Random.Range(0,4);
					yield return null;}
				}
				else if(whichMerc.Count == 4)
				{whichMerc.Clear();
				randMercenery = Random.Range(0,4);}			
			}
			newSniperFunction(Mathf.Abs(randSnipers-5));
			yield return new WaitForSeconds(2f);
			newSniperFunction(randSnipers);
			snipersOnScreen+=2;
		}
		if(enemyNumber < totalEnemies)
		{
			totalKilled += (totalEnemies-enemyNumber);
		}
		else if(enemyNumber > totalEnemies)
		{
			totalKilled -= (enemyNumber-totalEnemies);
		}
		
		if(merceneryNumber < totalMerceneries )
		{
			totalMerceneriesKilled+= (totalMerceneries-merceneryNumber);
		}
		else if(merceneryNumber > totalMerceneries){
			totalMerceneriesKilled -= (merceneryNumber - totalMerceneries);
		}
		
	}
	//READYYYYYYYY

	public void RegisterEnemy(Enemy enemy){
		if (enemy.transform.position == spawnPoint[0].transform.position)
			EnemyListLeft.Add(enemy);
		else if(enemy.transform.position == spawnPoint[1].transform.position)
			EnemyListUpLeft.Add(enemy);
		else if(enemy.transform.position == spawnPoint[2].transform.position)
			EnemyListButtomLeft.Add(enemy);
		else if(enemy.transform.position == spawnPoint[3].transform.position)
			EnemyListRight.Add(enemy);
		else if(enemy.transform.position == spawnPoint[4].transform.position)
			EnemyListButtomRight.Add(enemy);
		else if(enemy.transform.position == spawnPoint[5].transform.position)
			EnemyListUpRight.Add(enemy);
	
	}

	public void RegisterMercenery(Merc2 merc){
		if(merc.transform.position == mercenerySpawnPoint[0].transform.position)
			MerceneryList1.Add(merc);
		else if(merc.transform.position == mercenerySpawnPoint[1].transform.position)
			MerceneryList2.Add(merc);
		else if(merc.transform.position == mercenerySpawnPoint[2].transform.position)
			MerceneryList3.Add(merc);
		else if(merc.transform.position == mercenerySpawnPoint[3].transform.position)
			MerceneryList4.Add(merc);
	}


	public void pause(){
		audioSource.PlayOneShot(SoundManager.Instance.Click4);
		
		if(pauseMenu.activeSelf && Time.timeScale == 0){
			SoundManager.Instance.BckgSource.Play();
			Time.timeScale = 1;
			pauseMenu.SetActive(false);
			pauseBtn.interactable = true;
		}
		else{
			SoundManager.Instance.BckgSource.Stop();
			Time.timeScale = 0;
			pauseMenu.SetActive(true);
			pauseBtn.interactable = false;
		}
	}
	Coroutine colvl1;
	Coroutine colvl2;
	Coroutine colvl3;
	Coroutine colvl4;
	Coroutine colvl5;
	Coroutine colvl6;
	Coroutine colvl7;
	Coroutine colvl8;
	Coroutine colvl9;
	Coroutine colvl10;
	Coroutine colvl11;
	Coroutine colvl12;
	Coroutine colvl13;
	Coroutine colvl14;
	Coroutine colvl15;
	Coroutine colvl16;
	Coroutine colvl17;
	Coroutine colvl18;
	Coroutine colvl19;
	Coroutine colvl20;
	Coroutine colvl21;
	Coroutine colvl22;
	Coroutine colvl23;
	Coroutine colvl24;
	Coroutine colvl25;
	Coroutine colvl26;
	Coroutine colvl27;
	Coroutine colvl28;
	Coroutine colvl29;
	Coroutine colvl30;
			
	public void restart(){
		Time.timeScale =1;
		SoundManager.Instance.BckgSource.enabled = true;
		SoundManager.Instance.BckgSource.clip = SoundManager.Instance.AnotherBckgMusic;
		audioSource.PlayOneShot(SoundManager.Instance.Click3);
		housePoints = PlayerPrefs.GetInt("currentHouseHealth");
		houseDown = false;
		setCurrentState();
		energyButton.gameObject.SetActive(false);
		SoldierManager.Instance.MainEnergy.CurrentVal = PlayerPrefs.GetInt("Energy");
		Time.timeScale = 1;
		pauseMenu.SetActive(false);
		gameOverMenu.SetActive(false);
		pauseBtn.interactable = true;
		if(levelNumber == 0)
			StopCoroutine(colvl1);
		else if(levelNumber == 1)
			StopCoroutine(colvl2);
		else if(levelNumber == 2)
			StopCoroutine(colvl3);
		else if(levelNumber==3)
			StopCoroutine(colvl4);
		else if(levelNumber==4)
			StopCoroutine(colvl5);
		else if(levelNumber==5)
			StopCoroutine(colvl6);
		else if(levelNumber==6)
			StopCoroutine(colvl7);
		else if(levelNumber==7)
			StopCoroutine(colvl8);
		else if(levelNumber==8)
			StopCoroutine(colvl9);
		else if(levelNumber == 9)
			StopCoroutine(colvl10);
		else if(levelNumber == 10)
			StopCoroutine(colvl11);
		else if(levelNumber == 11)
			StopCoroutine(colvl12);
		else if(levelNumber==12)
			StopCoroutine(colvl13);
		else if(levelNumber==13)
			StopCoroutine(colvl14);
		else if(levelNumber==14)
			StopCoroutine(colvl15);
		else if(levelNumber==15)
			StopCoroutine(colvl16);
		else if(levelNumber==16)
			StopCoroutine(colvl17);
		else if(levelNumber==17)
			StopCoroutine(colvl18);
		else if(levelNumber == 18)
			StopCoroutine(colvl19);
		else if(levelNumber == 19)
			StopCoroutine(colvl20);
		else if(levelNumber == 20)
			StopCoroutine(colvl21);
		else if(levelNumber==21)
			StopCoroutine(colvl22);
		else if(levelNumber==22)
			StopCoroutine(colvl23);
		else if(levelNumber==23)
			StopCoroutine(colvl24);
		else if(levelNumber==24)
			StopCoroutine(colvl25);
		else if(levelNumber==25)
			StopCoroutine(colvl26);
		else if(levelNumber==26)
			StopCoroutine(colvl27);
		else if(levelNumber==27)
			StopCoroutine(colvl28);
		else if(levelNumber==28)
			StopCoroutine(colvl29);
		else if(levelNumber==29)
			StopCoroutine(colvl30);
		//chooseSoldierMenu.SetActive(true);
		determineRewards();
		DestroyAllEnemies();
		SoldierManager.Instance.DestroyAllSoldiers();
		totalKilled = 0;
		totalMerceneriesKilled = 0;
		LoadingScreenManager.LoadScene(2);
	}

	public void exit(){
		audioSource.PlayOneShot(SoundManager.Instance.Click3);
		energyButton.gameObject.SetActive(false);
		SoldierManager.Instance.MainEnergy.CurrentVal = PlayerPrefs.GetInt("Energy");
		Time.timeScale = 0;
		pauseMenu.SetActive(false);
		pauseBtn.interactable = true;
		if(levelNumber == 0)
			StopCoroutine(colvl1);
		else if(levelNumber == 1)
			StopCoroutine(colvl2);
		else if(levelNumber == 2)
			StopCoroutine(colvl3);
		else if(levelNumber==3)
			StopCoroutine(colvl4);
		else if(levelNumber==4)
			StopCoroutine(colvl5);
		else if(levelNumber==5)
			StopCoroutine(colvl6);
		else if(levelNumber==6)
			StopCoroutine(colvl7);
		else if(levelNumber==7)
			StopCoroutine(colvl8);
		else if(levelNumber==8)
			StopCoroutine(colvl9);
		else if(levelNumber == 9)
			StopCoroutine(colvl10);
		else if(levelNumber == 10)
			StopCoroutine(colvl11);
		else if(levelNumber == 11)
			StopCoroutine(colvl12);
		else if(levelNumber==12)
			StopCoroutine(colvl13);
		else if(levelNumber==13)
			StopCoroutine(colvl14);
		else if(levelNumber==14)
			StopCoroutine(colvl15);
		else if(levelNumber==15)
			StopCoroutine(colvl16);
		else if(levelNumber==16)
			StopCoroutine(colvl17);
		else if(levelNumber==17)
			StopCoroutine(colvl18);
		else if(levelNumber == 18)
			StopCoroutine(colvl19);
		else if(levelNumber == 19)
			StopCoroutine(colvl20);
		else if(levelNumber == 20)
			StopCoroutine(colvl21);
		else if(levelNumber==21)
			StopCoroutine(colvl22);
		else if(levelNumber==22)
			StopCoroutine(colvl23);
		else if(levelNumber==23)
			StopCoroutine(colvl24);
		else if(levelNumber==24)
			StopCoroutine(colvl25);
		else if(levelNumber==25)
			StopCoroutine(colvl26);
		else if(levelNumber==26)
			StopCoroutine(colvl27);
		else if(levelNumber==27)
			StopCoroutine(colvl28);
		else if(levelNumber==28)
			StopCoroutine(colvl29);
		else if(levelNumber==29)
			StopCoroutine(colvl30);
		DestroyAllEnemies();
		SoldierManager.Instance.DestroyAllSoldiers();
		totalKilled = 0;
		totalMerceneriesKilled = 0;
		LoadingScreenManager.LoadScene(1);
	}

	
	private bool isFinsihed = false;

	public bool IsFinished{
		get{
			return isFinsihed;
		}
	}
	IEnumerator winningSound()
	{
		audioSource.PlayOneShot(SoundManager.Instance.Win,3.5f);
		yield return new WaitForSeconds(4.3f);
		audioSource.PlayOneShot(SoundManager.Instance.Win3,1f);
	}

	[SerializeField]
	private Image kubok;
	private Animator kubokAnimator;
	private int money;
	private int gem;

	[SerializeField]
	private GameObject youDontHaveThisItemShop;

	public void isLevelOver()
	{	
		if (totalKilled == totalEnemies && totalMerceneriesKilled == totalMerceneries){
			SoldierManager.Instance.soldierBtnPressed = null;
			SoldierManager.Instance.bombBtnPressed = null;
			
			money = PlayerPrefs.GetInt("Money");
			money+= rewardMoneyList[levelNumber];
			PlayerPrefs.SetInt("Money",money);

			gem = PlayerPrefs.GetInt("Gem");
			gem+= rewardGemList[levelNumber];
			PlayerPrefs.SetInt("Gem",gem);
			if(levelNumber == 25){
				next.interactable = true;
				homeBtn.interactable = true;
			}
			levelNumber+=1;
			PlayerPrefs.SetInt("levelNum",levelNumber);
			energyButton.gameObject.SetActive(false);
			StartCoroutine(winningSound());
			SoundManager.Instance.BckgSource.clip = SoundManager.Instance.AnotherBckgMusic;
			SoundManager.Instance.BckgSource.Play();
			SoundManager.Instance.BckgSource.volume = 0.5f;
			kubok.gameObject.SetActive(true);
			kubokAnimator.SetTrigger("start");
			youDontHaveThisItemShop.SetActive(false);
			Invoke("playKubokOpen",3.5f);
			Invoke("disableKubok",5f);
			Invoke("setCurrentState",4f);
			Invoke("ShowMenu",4.3f);
		}
		else if(houseDown){
			SoundManager.Instance.BckgSource.clip = SoundManager.Instance.AnotherBckgMusic;
			SoundManager.Instance.BckgSource.Play();
			SoldierManager.Instance.soldierBtnPressed = null;
			SoldierManager.Instance.bombBtnPressed = null;
			youDontHaveThisItemShop.SetActive(false);
			if(levelNumber == 0)
				StopCoroutine(colvl1);
			else if(levelNumber == 1)
				StopCoroutine(colvl2);
			else if(levelNumber == 2)
				StopCoroutine(colvl3);
			else if(levelNumber==3)
				StopCoroutine(colvl4);
			else if(levelNumber==4)
				StopCoroutine(colvl5);
			else if(levelNumber==5)
				StopCoroutine(colvl6);
			else if(levelNumber==6)
				StopCoroutine(colvl7);
			else if(levelNumber==7)
				StopCoroutine(colvl8);
			else if(levelNumber==8)
				StopCoroutine(colvl9);
			else if(levelNumber == 9)
				StopCoroutine(colvl10);
			else if(levelNumber == 10)
				StopCoroutine(colvl11);
			else if(levelNumber == 11)
				StopCoroutine(colvl12);
			else if(levelNumber==12)
				StopCoroutine(colvl13);
			else if(levelNumber==13)
				StopCoroutine(colvl14);
			else if(levelNumber==14)
				StopCoroutine(colvl15);
			else if(levelNumber==15)
				StopCoroutine(colvl16);
			else if(levelNumber==16)
				StopCoroutine(colvl17);
			else if(levelNumber==17)
				StopCoroutine(colvl18);
			else if(levelNumber == 18)
				StopCoroutine(colvl19);
			else if(levelNumber == 19)
				StopCoroutine(colvl20);
			else if(levelNumber == 20)
				StopCoroutine(colvl21);
			else if(levelNumber==21)
				StopCoroutine(colvl22);
			else if(levelNumber==22)
				StopCoroutine(colvl23);
			else if(levelNumber==23)
				StopCoroutine(colvl24);
			else if(levelNumber==24)
				StopCoroutine(colvl25);
			else if(levelNumber==25)
				StopCoroutine(colvl26);
			else if(levelNumber==26)
				StopCoroutine(colvl27);
			else if(levelNumber==27)
				StopCoroutine(colvl28);
			else if(levelNumber==28)
				StopCoroutine(colvl29);
			else if(levelNumber==29)
				StopCoroutine(colvl30);
			
			setCurrentState();
			ShowMenu();
			isFinsihed = true;
			audioSource.PlayOneShot(SoundManager.Instance.Lose,1f);
		}
	}
	public void playKubokOpen()
	{
		kubokAnimator.SetTrigger("open");
	}
	public void disableKubok()
	{
		kubok.gameObject.SetActive(false);
	}

	public void setCurrentState(){
		if (houseDown == true)
		{   
			currentState = gameStatus.gameover;
		}   
		else if(totalKilled == totalEnemies && totalMerceneriesKilled == totalMerceneries)
		{
			housePoints = PlayerPrefs.GetInt("currentHouseHealth");
			currentState = gameStatus.next;
		}
		else if(totalKilled == 0 && totalMerceneriesKilled == 0){
			currentState = gameStatus.play;
		}    
		
	}

	public float housePoints;
	[SerializeField]
	private Image star1;
	[SerializeField]
	private Image star2;
	[SerializeField]
	private Image star3;

	[SerializeField]
	private Image star1NoNewSoldier;
	[SerializeField]
	private Image star2NoNewSoldier;
	[SerializeField]
	private Image star3NoNewSoldier;

	IEnumerator star1ShowNoNewSoldier()
	{
		star1NoNewSoldier.gameObject.SetActive(true);
		yield return new WaitForSeconds(0.25f);
		audioSource.PlayOneShot(SoundManager.Instance.Star1,5.5f);
		yield return null;
	}

	IEnumerator star2ShowNoNewSoldier()
	{
		star1NoNewSoldier.gameObject.SetActive(true);
		yield return new WaitForSeconds(0.25f);
		audioSource.PlayOneShot(SoundManager.Instance.Star1,5.5f);
		yield return new WaitForSeconds(0.6f);
		star2NoNewSoldier.gameObject.SetActive(true);
		yield return new WaitForSeconds(0.25f);
		audioSource.PlayOneShot(SoundManager.Instance.Star2,5.5f);
	}

	IEnumerator star3ShowNoNewSoldier()
	{
		star1NoNewSoldier.gameObject.SetActive(true);
		yield return new WaitForSeconds(0.25f);
		audioSource.PlayOneShot(SoundManager.Instance.Star1,5.5f);
		yield return new WaitForSeconds(0.6f);
		star2NoNewSoldier.gameObject.SetActive(true);
		yield return new WaitForSeconds(0.25f);
		audioSource.PlayOneShot(SoundManager.Instance.Star2,5.5f);
		yield return new WaitForSeconds(0.6f);
		star3NoNewSoldier.gameObject.SetActive(true);
		yield return new WaitForSeconds(0.25f);
		audioSource.PlayOneShot(SoundManager.Instance.Star3,5.5f);
	}

	IEnumerator star1Show()
	{
		star1.gameObject.SetActive(true);
		yield return new WaitForSeconds(0.25f);
		audioSource.PlayOneShot(SoundManager.Instance.Star1,5.5f);
		yield return null;
	}

	IEnumerator star2Show()
	{
		star1.gameObject.SetActive(true);
		yield return new WaitForSeconds(0.25f);
		audioSource.PlayOneShot(SoundManager.Instance.Star1,5.5f);
		yield return new WaitForSeconds(0.6f);
		star2.gameObject.SetActive(true);
		yield return new WaitForSeconds(0.25f);
		audioSource.PlayOneShot(SoundManager.Instance.Star2,5.5f);
	}

	IEnumerator star3Show()
	{
		star1.gameObject.SetActive(true);
		yield return new WaitForSeconds(0.25f);
		audioSource.PlayOneShot(SoundManager.Instance.Star1,5.5f);
		yield return new WaitForSeconds(0.6f);
		star2.gameObject.SetActive(true);
		yield return new WaitForSeconds(0.25f);
		audioSource.PlayOneShot(SoundManager.Instance.Star2,5.5f);
		yield return new WaitForSeconds(0.6f);
		star3.gameObject.SetActive(true);
		yield return new WaitForSeconds(0.25f);
		audioSource.PlayOneShot(SoundManager.Instance.Star3,5.5f);
	}

	[SerializeField]
	private Button next;
	[SerializeField]
	private Button homeBtn;

	public void ShowMenu(){
		pauseBtn.interactable = false;
		switch(currentState){
			case gameStatus.gameover:
				gameOverMenu.SetActive(true);
				DestroyAllEnemies();
				SoldierManager.Instance.DestroyAllSoldiers();
				Time.timeScale = 0;
				break;
			case gameStatus.next:
				DestroyAllEnemies();
				SoldierManager.Instance.DestroyAllSoldiers();
				if(levelNumber == 1 || levelNumber == 5 || levelNumber == 7 || levelNumber == 10 || levelNumber == 13 || levelNumber == 15 || levelNumber==19 || levelNumber == 21 || levelNumber ==24 || levelNumber ==26 || levelNumber ==27)
					{
						next.interactable = false;
						homeBtn.interactable = false;
						if(levelNumber == 26){
							next.interactable = true;
							homeBtn.interactable = true;
						}
						winningMenu.SetActive(true);
						dollarSign.gameObject.SetActive(true);
						rewardMoneyWinningMenu.gameObject.SetActive(true);
						Invoke("gemSignn",1);
						unlock.gameObject.SetActive(true);
						int houseHealh = PlayerPrefs.GetInt("HouseHealth");
						if(housePoints<houseHealh/3)
							StartCoroutine(star1Show());
						else if(housePoints>=houseHealh/3 && housePoints<(2*houseHealh)/3)
							StartCoroutine(star2Show());
						else if(housePoints>=(2*houseHealh)/3 && housePoints<=houseHealh)
						{
							StartCoroutine(star3Show());
						}
					}
				if(levelNumber == 1)	
					{
					s2image.gameObject.SetActive(true);
					}
				else if(levelNumber == 5)
					{
					s3image.gameObject.SetActive(true);
					}
				else if(levelNumber == 7)
					{
					pumpkImage.gameObject.SetActive(true);
					}
				else if(levelNumber == 10)
					{
					s4image.gameObject.SetActive(true);
					}
				else if(levelNumber == 13)
					{
					skullImage.gameObject.SetActive(true);
					}
				else if(levelNumber == 15)
					{
					s5image.gameObject.SetActive(true);
					}
				else if(levelNumber == 19)
					{
					s6image.gameObject.SetActive(true);
					}
				else if(levelNumber == 21)
					{
					granadeImage.gameObject.SetActive(true);
					}
				else if(levelNumber == 24)
					{
					s7image.gameObject.SetActive(true);
					}
				else if(levelNumber == 26)
					{
					knightImage.gameObject.SetActive(true);
					knightdesc.gameObject.SetActive(true);
					unlcokFromArmy.gameObject.SetActive(true);
					unlock.gameObject.SetActive(false);
					}
				else if(levelNumber == 27)
					{
					s8image.gameObject.SetActive(true);
					}
				else 
					{winningMenuNoNewSoldier.SetActive(true);
					dollarSignNoNewSoldiers.gameObject.SetActive(true);
					rewardMoneyWinningMenuNoNewSoldiers.gameObject.SetActive(true);
					Invoke("gemSignNoNewSoldier",1);
					int houseHealh = PlayerPrefs.GetInt("HouseHealth");
					if(housePoints<houseHealh/3)
					{	
						StartCoroutine(star1ShowNoNewSoldier());}
					else if(housePoints>=houseHealh/3 && housePoints<(2*houseHealh)/3)
					{	
						StartCoroutine(star2ShowNoNewSoldier());}
					else if(housePoints>=(2*houseHealh)/3 && housePoints<=houseHealh)
					{	
						StartCoroutine(star3ShowNoNewSoldier());
					}

					}
				break;
			case gameStatus.play:
				
				chooseSoldierMenu.SetActive(true);
				determineRewards();
				levelNumberText.text = "LeVel: "+(levelNumber+1).ToString();
				charctersShowed = StartCoroutine(charcterShow());
				break;
			
			
		}
	}

	Coroutine charctersShowed;

	public void gemSignNoNewSoldier()
	{
		gemSignnNoNewSoldier.gameObject.SetActive(true);
		rewardGemWinningMenyNoNewSoldier.gameObject.SetActive(true);
	}

	public void closeChooseSoldierMenu(){
		chooseSoldierMenu.SetActive(false);
	}

	[SerializeField]
	private Image s1ImageChoosingMenu;
	[SerializeField]
	private Image s2ImageChoosingMenu;
	[SerializeField]
	private Image s3ImageChoosingMenu;
	[SerializeField]
	private Image s4ImageChoosingMenu;
	[SerializeField]
	private Image s5ImageChoosingMenu;
	[SerializeField]
	private Image s6ImageChoosingMenu;
	[SerializeField]
	private Image s7ImageChoosingMenu;
	[SerializeField]
	private Image s8ImageChoosingMenu;

	[SerializeField]
	private Text s1NameChoosingMenu;
	[SerializeField]
	private Text s2NameChoosingMenu;
	[SerializeField]
	private Text s3NameChoosingMenu;
	[SerializeField]
	private Text s4NameChoosingMenu;
	[SerializeField]
	private Text s5NameChoosingMenu;
	[SerializeField]
	private Text s6NameChoosingMenu;
	[SerializeField]
	private Text s7NameChoosingMenu;
	[SerializeField]
	private Text s8NameChoosingMenu;

	[SerializeField]
	private Image s1BlockChoosingMenu;
	[SerializeField]
	private Image s2BlockChoosingMenu;
	[SerializeField]
	private Image s3BlockChoosingMenu;
	[SerializeField]
	private Image s4BlockChoosingMenu;
	[SerializeField]
	private Image s5BlockChoosingMenu;
	[SerializeField]
	private Image s6BlockChoosingMenu;
	[SerializeField]
	private Image s7BlockChoosingMenu;
	[SerializeField]
	private Image s8BlockChoosingMenu;

	private Animator s1ImageChoosingMenuAnim;
	private Animator s2ImageChoosingMenuAnim;
	private Animator s3ImageChoosingMenuAnim;
	private Animator s4ImageChoosingMenuAnim;
	private Animator s5ImageChoosingMenuAnim;
	private Animator s6ImageChoosingMenuAnim;
	private Animator s7ImageChoosingMenuAnim;
	private Animator s8ImageChoosingMenuAnim;
	private Animator s1NameChoosingMenuAnim;
	private Animator s2NameChoosingMenuAnim;
	private Animator s3NameChoosingMenuAnim;
	private Animator s4NameChoosingMenuAnim;
	private Animator s5NameChoosingMenuAnim;
	private Animator s6NameChoosingMenuAnim;
	private Animator s7NameChoosingMenuAnim;
	private Animator s8NameChoosingMenuAnim;

	[SerializeField]
	private Image e1ImageChoosingMenu;
	[SerializeField]
	private Image e2ImageChoosingMenu;
	[SerializeField]
	private Image e3ImageChoosingMenu;
	[SerializeField]
	private Image e4ImageChoosingMenu;
	[SerializeField]
	private Image e5ImageChoosingMenu;
	[SerializeField]
	private Image e6ImageChoosingMenu;
	[SerializeField]
	private Image e7ImageChoosingMenu;
	[SerializeField]
	private Image e8ImageChoosingMenu;
	[SerializeField]
	private Image e9ImageChoosingMenu;

	[SerializeField]
	private Text e1NameChoosingMenu;
	[SerializeField]
	private Text e2NameChoosingMenu;
	[SerializeField]
	private Text e3NameChoosingMenu;
	[SerializeField]
	private Text e4NameChoosingMenu;
	[SerializeField]
	private Text e5NameChoosingMenu;
	[SerializeField]
	private Text e6NameChoosingMenu;
	[SerializeField]
	private Text e7NameChoosingMenu;
	[SerializeField]
	private Text e8NameChoosingMenu;
	[SerializeField]
	private Text e9NameChoosingMenu;

	[SerializeField]
	private Image e1BlockChoosingMenu;
	[SerializeField]
	private Image e2BlockChoosingMenu;
	[SerializeField]
	private Image e3BlockChoosingMenu;
	[SerializeField]
	private Image e4BlockChoosingMenu;
	[SerializeField]
	private Image e5BlockChoosingMenu;
	[SerializeField]
	private Image e6BlockChoosingMenu;
	[SerializeField]
	private Image e7BlockChoosingMenu;
	[SerializeField]
	private Image e8BlockChoosingMenu;
	[SerializeField]
	private Image e9BlockChoosingMenu;

	private Animator e1ImageChoosingMenuAnim;
	private Animator e2ImageChoosingMenuAnim;
	private Animator e3ImageChoosingMenuAnim;
	private Animator e4ImageChoosingMenuAnim;
	private Animator e5ImageChoosingMenuAnim;
	private Animator e6ImageChoosingMenuAnim;
	private Animator e7ImageChoosingMenuAnim;
	private Animator e8ImageChoosingMenuAnim;
	private Animator e9ImageChoosingMenuAnim;
	private Animator e1NameChoosingMenuAnim;
	private Animator e2NameChoosingMenuAnim;
	private Animator e3NameChoosingMenuAnim;
	private Animator e4NameChoosingMenuAnim;
	private Animator e5NameChoosingMenuAnim;
	private Animator e6NameChoosingMenuAnim;
	private Animator e7NameChoosingMenuAnim;
	private Animator e8NameChoosingMenuAnim;
	private Animator e9NameChoosingMenuAnim;

	[SerializeField]
	private Text vs;
	private Animator vsAnim;

	IEnumerator s1Show(){
		s1ImageChoosingMenuAnim.SetTrigger("fra");
		audioSource.PlayOneShot(SoundManager.Instance.Hit2);
		yield return new WaitForSeconds(0.8f);
		s1NameChoosingMenu.gameObject.SetActive(true);
		s1NameChoosingMenuAnim.SetTrigger("mec");
		audioSource.PlayOneShot(SoundManager.Instance.Hit1);
		yield return new WaitForSeconds(2f);
		s1NameChoosingMenu.gameObject.SetActive(false);
	}

	IEnumerator s2Show(){
		s2ImageChoosingMenuAnim.SetTrigger("fra");
		audioSource.PlayOneShot(SoundManager.Instance.Hit2);
		yield return new WaitForSeconds(0.8f);
		s2NameChoosingMenu.gameObject.SetActive(true);
		s2NameChoosingMenuAnim.SetTrigger("mec");
		audioSource.PlayOneShot(SoundManager.Instance.Hit1);
		yield return new WaitForSeconds(2f);
		s2NameChoosingMenu.gameObject.SetActive(false);
	}

	IEnumerator s3Show(){
		s3ImageChoosingMenuAnim.SetTrigger("fra");
		audioSource.PlayOneShot(SoundManager.Instance.Hit2);
		yield return new WaitForSeconds(0.8f);
		s3NameChoosingMenu.gameObject.SetActive(true);
		s3NameChoosingMenuAnim.SetTrigger("mec");
		audioSource.PlayOneShot(SoundManager.Instance.Hit1);
		yield return new WaitForSeconds(2f);
		s3NameChoosingMenu.gameObject.SetActive(false);
	}

	IEnumerator s4Show(){
		s4ImageChoosingMenuAnim.SetTrigger("fra");
		audioSource.PlayOneShot(SoundManager.Instance.Hit2);
		yield return new WaitForSeconds(0.8f);
		s4NameChoosingMenu.gameObject.SetActive(true);
		s4NameChoosingMenuAnim.SetTrigger("mec");
		audioSource.PlayOneShot(SoundManager.Instance.Hit1);
		yield return new WaitForSeconds(2f);
		s4NameChoosingMenu.gameObject.SetActive(false);
	}

	IEnumerator s5Show(){
		s5ImageChoosingMenuAnim.SetTrigger("fra");
		audioSource.PlayOneShot(SoundManager.Instance.Hit2);
		yield return new WaitForSeconds(0.8f);
		s5NameChoosingMenu.gameObject.SetActive(true);
		s5NameChoosingMenuAnim.SetTrigger("mec");
		audioSource.PlayOneShot(SoundManager.Instance.Hit1);
		yield return new WaitForSeconds(2f);
		s5NameChoosingMenu.gameObject.SetActive(false);
	}

	IEnumerator s6Show(){
		s6ImageChoosingMenuAnim.SetTrigger("fra");
		audioSource.PlayOneShot(SoundManager.Instance.Hit2);
		yield return new WaitForSeconds(0.8f);
		s6NameChoosingMenu.gameObject.SetActive(true);
		s6NameChoosingMenuAnim.SetTrigger("mec");
		audioSource.PlayOneShot(SoundManager.Instance.Hit1);
		yield return new WaitForSeconds(2f);
		s6NameChoosingMenu.gameObject.SetActive(false);
	}

	IEnumerator s7Show(){
		s7ImageChoosingMenuAnim.SetTrigger("fra");
		audioSource.PlayOneShot(SoundManager.Instance.Hit2);
		yield return new WaitForSeconds(0.8f);
		s7NameChoosingMenu.gameObject.SetActive(true);
		s7NameChoosingMenuAnim.SetTrigger("mec");
		audioSource.PlayOneShot(SoundManager.Instance.Hit1);
		yield return new WaitForSeconds(2f);
		s7NameChoosingMenu.gameObject.SetActive(false);
	}

	IEnumerator s8Show(){
		s8ImageChoosingMenuAnim.SetTrigger("fra");
		audioSource.PlayOneShot(SoundManager.Instance.Hit2);
		yield return new WaitForSeconds(0.8f);
		s8NameChoosingMenu.gameObject.SetActive(true);
		s8NameChoosingMenuAnim.SetTrigger("mec");
		audioSource.PlayOneShot(SoundManager.Instance.Hit1);
		yield return new WaitForSeconds(2f);
		s8NameChoosingMenu.gameObject.SetActive(false);
	}

	IEnumerator e1Show(){
		e1ImageChoosingMenuAnim.SetTrigger("fra");
		audioSource.PlayOneShot(SoundManager.Instance.Hit2);
		yield return new WaitForSeconds(0.8f);
		e1NameChoosingMenu.gameObject.SetActive(true);
		e1NameChoosingMenuAnim.SetTrigger("mec");
		audioSource.PlayOneShot(SoundManager.Instance.Hit1);
		yield return new WaitForSeconds(2f);
		e1NameChoosingMenu.gameObject.SetActive(false);
	}

	IEnumerator e2Show(){
		e2ImageChoosingMenuAnim.SetTrigger("fra");
		audioSource.PlayOneShot(SoundManager.Instance.Hit2);
		yield return new WaitForSeconds(0.8f);
		e2NameChoosingMenu.gameObject.SetActive(true);
		e2NameChoosingMenuAnim.SetTrigger("mec");
		audioSource.PlayOneShot(SoundManager.Instance.Hit1);
		yield return new WaitForSeconds(2f);
		e2NameChoosingMenu.gameObject.SetActive(false);
	}

	IEnumerator e3Show(){
		e3ImageChoosingMenuAnim.SetTrigger("fra");
		audioSource.PlayOneShot(SoundManager.Instance.Hit2);
		yield return new WaitForSeconds(0.8f);
		e3NameChoosingMenu.gameObject.SetActive(true);
		e3NameChoosingMenuAnim.SetTrigger("mec");
		audioSource.PlayOneShot(SoundManager.Instance.Hit1);
		yield return new WaitForSeconds(2f);
		e3NameChoosingMenu.gameObject.SetActive(false);
	}

	IEnumerator e4Show(){
		e4ImageChoosingMenuAnim.SetTrigger("fra");
		audioSource.PlayOneShot(SoundManager.Instance.Hit2);
		yield return new WaitForSeconds(0.8f);
		e4NameChoosingMenu.gameObject.SetActive(true);
		e4NameChoosingMenuAnim.SetTrigger("mec");
		audioSource.PlayOneShot(SoundManager.Instance.Hit1);
		yield return new WaitForSeconds(2f);
		e4NameChoosingMenu.gameObject.SetActive(false);
	}

	IEnumerator e5Show(){
		e5ImageChoosingMenuAnim.SetTrigger("fra");
		audioSource.PlayOneShot(SoundManager.Instance.Hit2);
		yield return new WaitForSeconds(0.8f);
		e5NameChoosingMenu.gameObject.SetActive(true);
		e5NameChoosingMenuAnim.SetTrigger("mec");
		audioSource.PlayOneShot(SoundManager.Instance.Hit1);
		yield return new WaitForSeconds(2f);
		e5NameChoosingMenu.gameObject.SetActive(false);
	}

	IEnumerator e6Show(){
		e6ImageChoosingMenuAnim.SetTrigger("fra");
		audioSource.PlayOneShot(SoundManager.Instance.Hit2);
		yield return new WaitForSeconds(0.8f);
		e6NameChoosingMenu.gameObject.SetActive(true);
		e6NameChoosingMenuAnim.SetTrigger("mec");
		audioSource.PlayOneShot(SoundManager.Instance.Hit1);
		yield return new WaitForSeconds(2f);
		e6NameChoosingMenu.gameObject.SetActive(false);
	}

	IEnumerator e7Show(){
		e7ImageChoosingMenuAnim.SetTrigger("fra");
		audioSource.PlayOneShot(SoundManager.Instance.Hit2);
		yield return new WaitForSeconds(0.8f);
		e7NameChoosingMenu.gameObject.SetActive(true);
		e7NameChoosingMenuAnim.SetTrigger("mec");
		audioSource.PlayOneShot(SoundManager.Instance.Hit1);
		yield return new WaitForSeconds(2f);
		e7NameChoosingMenu.gameObject.SetActive(false);
	}

	IEnumerator e8Show(){
		e8ImageChoosingMenuAnim.SetTrigger("fra");
		audioSource.PlayOneShot(SoundManager.Instance.Hit2);
		yield return new WaitForSeconds(0.8f);
		e8NameChoosingMenu.gameObject.SetActive(true);
		e8NameChoosingMenuAnim.SetTrigger("mec");
		audioSource.PlayOneShot(SoundManager.Instance.Hit1);
		yield return new WaitForSeconds(2f);
		e8NameChoosingMenu.gameObject.SetActive(false);
	}

	IEnumerator e9Show(){
		e9ImageChoosingMenuAnim.SetTrigger("fra");
		audioSource.PlayOneShot(SoundManager.Instance.Hit2);
		yield return new WaitForSeconds(0.8f);
		e9NameChoosingMenu.gameObject.SetActive(true);
		e9NameChoosingMenuAnim.SetTrigger("mec");
		audioSource.PlayOneShot(SoundManager.Instance.Hit1);
		yield return new WaitForSeconds(2f);
		e9NameChoosingMenu.gameObject.SetActive(false);
	}




	IEnumerator charcterShow(){
		if(levelNumber >=0)
		{
			s1BlockChoosingMenu.gameObject.SetActive(false);
			s1ImageChoosingMenu.gameObject.SetActive(true);
			e1BlockChoosingMenu.gameObject.SetActive(false);
			e1ImageChoosingMenu.gameObject.SetActive(true);
		}
		if(levelNumber >= 1)
		{
			s2ImageChoosingMenu.gameObject.SetActive(true);
			s2BlockChoosingMenu.gameObject.SetActive(false);
			e2BlockChoosingMenu.gameObject.SetActive(false);
			e2ImageChoosingMenu.gameObject.SetActive(true);	
		}
		if(levelNumber >= 3)
		{
			e3BlockChoosingMenu.gameObject.SetActive(false);
			e3ImageChoosingMenu.gameObject.SetActive(true);	
		}
		if(levelNumber >= 5)
		{
			s3ImageChoosingMenu.gameObject.SetActive(true);
			s3BlockChoosingMenu.gameObject.SetActive(false);
		}
		if(levelNumber >= 7)
		{
			e5BlockChoosingMenu.gameObject.SetActive(false);
			e5ImageChoosingMenu.gameObject.SetActive(true);	
		}
		if(levelNumber >= 10)
		{
			s4ImageChoosingMenu.gameObject.SetActive(true);
			s4BlockChoosingMenu.gameObject.SetActive(false);
			e4BlockChoosingMenu.gameObject.SetActive(false);
			e4ImageChoosingMenu.gameObject.SetActive(true);	
		}
		if(levelNumber >= 15)
		{
			s5ImageChoosingMenu.gameObject.SetActive(true);
			s5BlockChoosingMenu.gameObject.SetActive(false);
			e6BlockChoosingMenu.gameObject.SetActive(false);
			e6ImageChoosingMenu.gameObject.SetActive(true);	
		}
		if(levelNumber >= 19)
		{
			s6ImageChoosingMenu.gameObject.SetActive(true);
			s6BlockChoosingMenu.gameObject.SetActive(false);
			e7BlockChoosingMenu.gameObject.SetActive(false);
			e7ImageChoosingMenu.gameObject.SetActive(true);	
		}
		if(levelNumber >= 24)
		{
			s7ImageChoosingMenu.gameObject.SetActive(true);
			s7BlockChoosingMenu.gameObject.SetActive(false);
			e8BlockChoosingMenu.gameObject.SetActive(false);
			e8ImageChoosingMenu.gameObject.SetActive(true);	
		}
		if(levelNumber >= 27)
		{
			s8ImageChoosingMenu.gameObject.SetActive(true);
			s8BlockChoosingMenu.gameObject.SetActive(false);
			e9BlockChoosingMenu.gameObject.SetActive(false);
			e9ImageChoosingMenu.gameObject.SetActive(true);	
		}


		if(levelNumber >=0)
		{
			yield return new WaitForSeconds(1.3f);
			StartCoroutine(s1Show());
		}
		if(levelNumber >= 1)
		{
			yield return new WaitForSeconds(1.3f);
			StartCoroutine(s2Show());
		}
		if(levelNumber >= 5)
		{
			yield return new WaitForSeconds(1.3f);
			StartCoroutine(s3Show());
		}
		if(levelNumber >= 10)
		{
			yield return new WaitForSeconds(1.3f);
			StartCoroutine(s4Show());
		}
		if(levelNumber >= 15)
		{
			yield return new WaitForSeconds(1.3f);
			StartCoroutine(s5Show());
		}
		if(levelNumber >= 19)
		{
			yield return new WaitForSeconds(1.3f);
			StartCoroutine(s6Show());
		}
		if(levelNumber >= 24)
		{
			yield return new WaitForSeconds(1.3f);
			StartCoroutine(s7Show());
		}
		if(levelNumber >= 27)
		{
			yield return new WaitForSeconds(1.3f);
			StartCoroutine(s8Show());
		}

		yield return new WaitForSeconds(1f);
		vsAnim.SetTrigger("mec");
		yield return new WaitForSeconds(1f);

		if(levelNumber >=0)
		{
			StartCoroutine(e1Show());
			yield return new WaitForSeconds(1.3f);
		}
		if(levelNumber >= 1)
		{
			StartCoroutine(e2Show());
			yield return new WaitForSeconds(1.3f);
		}
		if(levelNumber >= 3)
		{
			StartCoroutine(e3Show());
			yield return new WaitForSeconds(1.3f);
		}
		if(levelNumber >= 7)
		{
			StartCoroutine(e5Show());
			yield return new WaitForSeconds(1.3f);
		}
		if(levelNumber >= 10)
		{
			StartCoroutine(e4Show());
			yield return new WaitForSeconds(1.3f);
		}
		if(levelNumber >= 15)
		{
			StartCoroutine(e6Show());
			yield return new WaitForSeconds(1.3f);
		}
		if(levelNumber >= 19)
		{
			StartCoroutine(e7Show());
			yield return new WaitForSeconds(1.3f);
		}
		if(levelNumber >= 24)
		{
			StartCoroutine(e8Show());
			yield return new WaitForSeconds(1.3f);
		}
		if(levelNumber >= 27)
		{
			StartCoroutine(e9Show());
		}
		
		
	}

	public void gemSignn(){
		gemSign.gameObject.SetActive(true);
		rewardGemWinningMeny.gameObject.SetActive(true);
	}

	public void nextBtnPressed(){
		SoundManager.Instance.BckgSource.clip = SoundManager.Instance.AnotherBckgMusic;
		SoundManager.Instance.BckgSource.Play();
		if (winningMenu.activeSelf)
		{
			winningMenu.SetActive(false);
			dollarSign.gameObject.SetActive(false);
			rewardMoneyWinningMenu.gameObject.SetActive(false);
			gemSign.gameObject.SetActive(false);
			rewardGemWinningMeny.gameObject.SetActive(false);
			star1.gameObject.SetActive(false);
			star2.gameObject.SetActive(false);
			star3.gameObject.SetActive(false);

			dollarSignNoNewSoldiers.gameObject.SetActive(false);
			rewardMoneyWinningMenuNoNewSoldiers.gameObject.SetActive(false);
			gemSignnNoNewSoldier.gameObject.SetActive(false);
			rewardGemWinningMenyNoNewSoldier.gameObject.SetActive(false);
			star1NoNewSoldier.gameObject.SetActive(false);
			star2NoNewSoldier.gameObject.SetActive(false);
			star3NoNewSoldier.gameObject.SetActive(false);
			if(s2image.gameObject.activeSelf){
				s2image.gameObject.SetActive(false);
				s2desc.gameObject.SetActive(false);
			}
			else if(s3image.gameObject.activeSelf)
			{
				
				s3image.gameObject.SetActive(false);
				s3desc.gameObject.SetActive(false);
			}
			else if(pumpkImage.gameObject.activeSelf)
			{
				pumpkImage.gameObject.SetActive(false);
				pumpkdesc.gameObject.SetActive(false);
			}
			else if(s4image.gameObject.activeSelf)
			{
				s4image.gameObject.SetActive(false);
				s4desc.gameObject.SetActive(false);
			}
			else if(s5image.gameObject.activeSelf)
			{	s5image.gameObject.SetActive(false);
				s5desc.gameObject.SetActive(false);
			}
			else if(s6image.gameObject.activeSelf)
			{	
				s6image.gameObject.SetActive(false);
				s6desc.gameObject.SetActive(false);
			}
			else if(granadeImage.gameObject.activeSelf)
			{	
				granadeImage.gameObject.SetActive(false);
				granadedesc.gameObject.SetActive(false);
			}
			else if(s7image.gameObject.activeSelf)
			{
				s7image.gameObject.SetActive(false);
				s7desc.gameObject.SetActive(false);
			}
			else if(s8image.gameObject.activeSelf)
			{
				s8image.gameObject.SetActive(false);
				s8desc.gameObject.SetActive(false);
			}
			else if(skullImage.gameObject.activeSelf)
			{	
				skullImage.gameObject.SetActive(false);
				skulldesc.gameObject.SetActive(false);
			}
			else if(knightImage.gameObject.activeSelf)
			{
				knightImage.gameObject.SetActive(false);
				knightdesc.gameObject.SetActive(false);
				unlcokFromArmy.gameObject.SetActive(false);
			}
		}
		else if(winningMenuNoNewSoldier.activeSelf)
		{
			winningMenuNoNewSoldier.SetActive(false);
		}
		PlayerPrefs.SetInt("levelNum",levelNumber);
		SoundManager.Instance.BckgSource.volume = 0.5f;
		totalKilled=0;
		totalMerceneriesKilled=0;
		enemyNumber=0;
		merceneryNumber=0;
		isFinsihed = true;
		Debug.Log(levelNumber);
		if(levelNumber == 1){
			PlayerPrefs.SetInt("armyOpen",1);
			LoadingScreenManager.LoadScene(1);
		}
		else if(levelNumber == 2){
			PlayerPrefs.SetInt("shopOpen",1);
			LoadingScreenManager.LoadScene(1);
		}
		else if(levelNumber == 3){
			PlayerPrefs.SetInt("labOpen",1);
			LoadingScreenManager.LoadScene(1);
		}
		else if(levelNumber == 4){
			PlayerPrefs.SetInt("labIntroDone",2);
			LoadingScreenManager.LoadScene(1);
		}
		else if(levelNumber == 7){
			PlayerPrefs.SetInt("sniperIntro",1);
			LoadingScreenManager.LoadScene(2);
		}
		else if(levelNumber == 15){
			PlayerPrefs.SetInt("mercIntro",1);
			LoadingScreenManager.LoadScene(2);
		}
		else if(levelNumber == 30){
			PlayerPrefs.SetInt("end",1);
			LoadingScreenManager.LoadScene(1);
		}
		else{
			LoadingScreenManager.LoadScene(2);
			//setCurrentState();
			//ShowMenu();
		}
		
		
	}

	public void playy(){
		SoundManager.Instance.BckgSource.enabled = false;
		audioSource.PlayOneShot(SoundManager.Instance.Click);
		isFinsihed = false;
		Time.timeScale =1;
		StopCoroutine(charctersShowed);
		s1ImageChoosingMenuAnim.Play("nothingScale");
		s2ImageChoosingMenuAnim.Play("nothingScale");
		s3ImageChoosingMenuAnim.Play("nothingScale");
		s4ImageChoosingMenuAnim.Play("nothingScale");
		s5ImageChoosingMenuAnim.Play("nothingScale");
		s6ImageChoosingMenuAnim.Play("nothingScale");
		s7ImageChoosingMenuAnim.Play("nothingScale");
		s8ImageChoosingMenuAnim.Play("nothingScale");
		s1NameChoosingMenu.gameObject.SetActive(false);
		s2NameChoosingMenu.gameObject.SetActive(false);
		s3NameChoosingMenu.gameObject.SetActive(false);
		s4NameChoosingMenu.gameObject.SetActive(false);
		s5NameChoosingMenu.gameObject.SetActive(false);
		s6NameChoosingMenu.gameObject.SetActive(false);
		s7NameChoosingMenu.gameObject.SetActive(false);
		s8NameChoosingMenu.gameObject.SetActive(false);

		vsAnim.Play("nothingScale");

		e1ImageChoosingMenuAnim.Play("nothingScale");
		e2ImageChoosingMenuAnim.Play("nothingScale");
		e3ImageChoosingMenuAnim.Play("nothingScale");
		e4ImageChoosingMenuAnim.Play("nothingScale");
		e5ImageChoosingMenuAnim.Play("nothingScale");
		e6ImageChoosingMenuAnim.Play("nothingScale");
		e7ImageChoosingMenuAnim.Play("nothingScale");
		e8ImageChoosingMenuAnim.Play("nothingScale");
		e9ImageChoosingMenuAnim.Play("nothingScale");
		e1NameChoosingMenu.gameObject.SetActive(false);
		e2NameChoosingMenu.gameObject.SetActive(false);
		e3NameChoosingMenu.gameObject.SetActive(false);
		e4NameChoosingMenu.gameObject.SetActive(false);
		e5NameChoosingMenu.gameObject.SetActive(false);
		e6NameChoosingMenu.gameObject.SetActive(false);
		e7NameChoosingMenu.gameObject.SetActive(false);
		e8NameChoosingMenu.gameObject.SetActive(false);
		e9NameChoosingMenu.gameObject.SetActive(false);
		
		// s1ImageChoosingMenu.gameObject.SetActive(false);
		// s2ImageChoosingMenu.gameObject.SetActive(false);
		// s3ImageChoosingMenu.gameObject.SetActive(false);
		// s4ImageChoosingMenu.gameObject.SetActive(false);
		// s5ImageChoosingMenu.gameObject.SetActive(false);
		// s6ImageChoosingMenu.gameObject.SetActive(false);
		// s7ImageChoosingMenu.gameObject.SetActive(false);
		// s8ImageChoosingMenu.gameObject.SetActive(false);
		// e1ImageChoosingMenu.gameObject.SetActive(false);
		// e2ImageChoosingMenu.gameObject.SetActive(false);
		// e3ImageChoosingMenu.gameObject.SetActive(false);
		// e4ImageChoosingMenu.gameObject.SetActive(false);
		// e5ImageChoosingMenu.gameObject.SetActive(false);
		// e6ImageChoosingMenu.gameObject.SetActive(false);
		// e7ImageChoosingMenu.gameObject.SetActive(false);
		// e8ImageChoosingMenu.gameObject.SetActive(false);
		Invoke("countdown",0.4f);
		Invoke("playBtnPressed",4);
		Debug.Log(levelNumber);
		
		if(chooseSoldierMenu.activeSelf)
			{
			setCurrentState();
			chooseSMenu.SetTrigger("close");
			Invoke("closeChooseSoldierMenu",2);}
	}

	[SerializeField]
	private GameObject soldierPanel;
	private Animator soldierPanelAnim;
	

	public void playBtnPressed(){
		if(PlayerPrefs.GetInt("music")==1){
			SoundManager.Instance.BckgSource.enabled = true;
			SoundManager.Instance.BckgSource.clip = SoundManager.Instance.BackgroundMusic;
			SoundManager.Instance.BckgSource.Play();
		}
		
		
		pauseBtn.interactable = true;
		energyButton.gameObject.SetActive(true);
		switch (currentState){
			case gameStatus.play:
				renameStones();
				//levelNumber+=1;
				//if(levelNumber == 1)
				//	StopCoroutine(colvl1);
				//else if(levelNumber == 2)
				//	StopCoroutine(colvl2);
				//else if(levelNumber==3)
				//	StopCoroutine(colvl3);
				//else if(levelNumber==4)
				//	StopCoroutine(colvl4);
				//else if(levelNumber==5)
				//	StopCoroutine(colvl5);
				//else if(levelNumber==6)
				//	StopCoroutine(colvl6);
				//else if(levelNumber==7)
				//	StopCoroutine(colvl7);
				//else if(levelNumber==8)
				//	StopCoroutine(colvl8);
				//else if(levelNumber==9)
				//	StopCoroutine(colvl9);
				break;
			case gameStatus.next:
				
				break;
			default:
				totalEnemies = 6;
				totalSnipers = 6;
				TotalMoney = 100;
				break;

			}
	
		
		//totalKilled = 0;
		enemiesOnScreen = 0;
		snipersOnScreen = 0;
		merceneriesOnScreen = 0;
		if(levelNumber == 0)
			{ totalEnemies = 6;
			colvl1 = StartCoroutine(spawnLevel1());
			}
		else if(levelNumber==1)
			{	totalEnemies = 12;
				colvl2 = StartCoroutine(spawnLevel2());
			
			}
		else if(levelNumber==2)
			{
			totalEnemies = 18;
			colvl3 = StartCoroutine(spawnLevel3());
			}
		else if(levelNumber ==3)
			{
			totalEnemies = 12;
			colvl4 = StartCoroutine(spawnLevel4());
			}
		else if(levelNumber == 4)
			{
			totalEnemies = 24;
			colvl5 = StartCoroutine(spawnLevel5());
			}
		else if(levelNumber == 5)
			{colvl6 = StartCoroutine(spawnLevel6());
			totalEnemies = 38;
			}
		else if(levelNumber == 6)
			{colvl7 = StartCoroutine(spawnLevel7());
			totalEnemies = 42;
			}
		else if(levelNumber == 7)
			{colvl8 = StartCoroutine(spawnLevel8());
			totalEnemies = 48;
			totalSnipers = 6;
			}
		else if(levelNumber == 8)
			{colvl9 = StartCoroutine(spawnLevel9());
			totalEnemies = 52;
			totalSnipers = 6;
			}
		else if(levelNumber == 9)
			{colvl10 = StartCoroutine(spawnLevel10());
			totalEnemies = 56;
			totalSnipers = 9;
			}
		else if(levelNumber == 10)
			{colvl11 = StartCoroutine(spawnLevel11());
			totalEnemies = 12;
			}
		else if(levelNumber == 11)
			{colvl12 = StartCoroutine(spawnLevel12());
			totalEnemies = 46;
			totalSnipers = 12;
			}
		else if(levelNumber == 12)
			{colvl13 = StartCoroutine(spawnLevel13());
			}
		else if(levelNumber == 13)
			{colvl14 = StartCoroutine(spawnLevel14());
			}
		else if(levelNumber == 14)
			{colvl15 = StartCoroutine(spawnLevel15());
			}
		else if(levelNumber == 15)
			{colvl16 = StartCoroutine(spawnLevel16());
			}
		else if(levelNumber == 16)
			{colvl17 = StartCoroutine(spawnLevel17());
			
			}
		else if(levelNumber == 17)
			{colvl18 = StartCoroutine(spawnLevel18());
			
			}
		else if(levelNumber == 18)
			{colvl19 = StartCoroutine(spawnLevel19());
			
			}
		else if(levelNumber == 19)
			{colvl20 = StartCoroutine(spawnLevel20());
			
			}
		else if(levelNumber == 20)
			{colvl21 = StartCoroutine(spawnLevel21());
			
			}
		else if(levelNumber == 21)
			{colvl22 = StartCoroutine(spawnLevel22());
			
			}
		else if(levelNumber == 22)
			{colvl23 = StartCoroutine(spawnLevel23());
			
			}
		else if(levelNumber == 23)
			{colvl24 = StartCoroutine(spawnLevel24());
			
			}
		else if(levelNumber == 24)
			{colvl25 = StartCoroutine(spawnLevel25());
			
			}
		else if(levelNumber == 25)
			{colvl26 = StartCoroutine(spawnLevel26());
			
			}
		else if(levelNumber == 26)
			{colvl27 = StartCoroutine(spawnLevel27());
			
			}
		else if(levelNumber == 27)
			{colvl28 = StartCoroutine(spawnLevel28());
			
			}
		else if(levelNumber == 28)
			{colvl29 = StartCoroutine(spawnLevel29());
			
			}
		else if(levelNumber == 29)
			{colvl30 = StartCoroutine(spawnLevel30());
			
			}

	}
	private GameObject S5678Spot1;
	private GameObject S5678Spot2;
	private GameObject S5678Spot3;
	private GameObject S5678Spot4;
	private Collider2D S56781;
	private Collider2D S56782;
	private Collider2D S56783;
	private Collider2D S56784;

	public void renameStones(){
		l1.tag = "PathStraightLeft";
		l2.tag = "PathStraightLeft";
		l3.tag = "PathStraightLeft";
		l4.tag = "PathStraightLeft";
		l5.tag = "PathStraightLeft";
		l6.tag = "PathStraightLeft";
		lB1.tag = "PathButtomLeft";	
		lB2.tag = "PathButtomLeft";
		lB3.tag = "PathButtomLeft";
		lB4.tag = "PathButtomLeft";
		lB5.tag = "PathButtomLeft";
		lB6.tag = "PathButtomLeft";
		lU1.tag = "PathUpLeft";
		lU2.tag = "PathUpLeft";
		lU3.tag = "PathUpLeft";
		lU4.tag = "PathUpLeft";
		lU5.tag = "PathUpLeft";
		lU6.tag = "PathUpLeft";
		R1.tag = "PathStraightRight";
		R2.tag = "PathStraightRight";
		R3.tag = "PathStraightRight";
		R4.tag = "PathStraightRight";
		R5.tag = "PathStraightRight";
		R6.tag = "PathStraightRight";
		RB1.tag = "PathButtomRight";
		RB2.tag = "PathButtomRight";
		RB3.tag = "PathButtomRight";
		RB4.tag = "PathButtomRight";
		RB5.tag = "PathButtomRight";
		RB6.tag = "PathButtomRight";
		RU1.tag = "PathUpRight";
		RU2.tag = "PathUpRight";
		RU3.tag = "PathUpRight";
		RU4.tag = "PathUpRight";
		RU5.tag = "PathUpRight";
		RU6.tag = "PathUpRight";
		S56781.tag = "MiddlePath1";
		S56782.tag = "MiddlePath2";
		S56783.tag = "MiddlePath3";
		S56784.tag = "MiddlePath4";
	}

	public void UnregisterEnemy(Enemy enemy){
		if(EnemyListButtomLeft.Contains(enemy)){
			EnemyListButtomLeft.Remove(enemy);
		}
		else if(EnemyListLeft.Contains(enemy)){
			EnemyListLeft.Remove(enemy);
		}
		else if(EnemyListUpLeft.Contains(enemy)){
			EnemyListUpLeft.Remove(enemy);
		}
		else if(EnemyListRight.Contains(enemy)){
			EnemyListRight.Remove(enemy);
		}
		else if(EnemyListUpRight.Contains(enemy)){
			EnemyListUpRight.Remove(enemy);
		}
		else if(EnemyListButtomRight.Contains(enemy)){
			EnemyListButtomRight.Remove(enemy);
		}
		
		Destroy(enemy.gameObject);
	}

	public void UnregisterMercenery(Merc2 merc){
		if(MerceneryList1.Contains(merc))
			MerceneryList1.Remove(merc);
		else if(MerceneryList2.Contains(merc))
			MerceneryList2.Remove(merc);
		else if(MerceneryList3.Contains(merc))
			MerceneryList3.Remove(merc);
		else if(MerceneryList4.Contains(merc))
			MerceneryList4.Remove(merc);
		Destroy(merc.gameObject);
	}



	public void DestroyAllEnemies(){
		foreach (Enemy enemy in EnemyListLeft){
			Destroy(enemy.gameObject);
		}
		foreach (Enemy enemy in EnemyListUpLeft){
			Destroy(enemy.gameObject);
		}
		foreach (Enemy enemy in EnemyListButtomLeft){
			Destroy(enemy.gameObject);
		}
		foreach (Enemy enemy in EnemyListRight){
			Destroy(enemy.gameObject);
		}
		foreach (Enemy enemy in EnemyListButtomRight){
			Destroy(enemy.gameObject);
		}
		foreach (Enemy enemy in EnemyListUpRight){
			Destroy(enemy.gameObject);
		}
		EnemyListLeft.Clear();
		EnemyListUpLeft.Clear();
		EnemyListButtomLeft.Clear();
		EnemyListRight.Clear();
		EnemyListButtomRight.Clear();
		EnemyListUpRight.Clear();

		foreach (Merc2 enemy in MerceneryList1){
			Destroy(enemy.gameObject);
		}
		foreach (Merc2 enemy in MerceneryList2){
			Destroy(enemy.gameObject);
		}
		foreach (Merc2 enemy in MerceneryList3){
			Destroy(enemy.gameObject);
		}
		foreach (Merc2 enemy in MerceneryList4){
			Destroy(enemy.gameObject);
		}

		MerceneryList1.Clear();
		MerceneryList2.Clear();
		MerceneryList3.Clear();
		MerceneryList4.Clear();
	}

}
