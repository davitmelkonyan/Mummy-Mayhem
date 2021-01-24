using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI; 



public class MainMenu : Singleton<MainMenu> {

	[SerializeField]
	private GameObject InsideTheLab;

	[SerializeField]
	private GameObject mainMenu;

	[SerializeField]
	private GameObject HealthLABmenu;

	[SerializeField]
	private GameObject EnergyLABmenu;


	[SerializeField]
	private GameObject SoldierList;


	[SerializeField]
	private GameObject[] soldList;

	[SerializeField]
	private Image areyousure;

	private int levNum;
	void Awake(){
		//DontDestroyOnLoad(gameObject);
	}

	[SerializeField]
	private Image angel;
	private Animator angelAnim;

	[SerializeField]
	private Image zombie;
	private Animator zombieAnim;

	[SerializeField]
	private GameObject zombieTextPlace;
	[SerializeField]
	private Text zombieText;

	[SerializeField]
	private GameObject angelTextPlace;
	[SerializeField]
	private GameObject angelTextPlaceIsHeGone;
	[SerializeField]
	private GameObject angelTextPlaceFinal;
	[SerializeField]
	private Text angelTextIsHeGone;
	[SerializeField]
	private Text angelText;
	[SerializeField]
	private Text angelTextFinal;

	IEnumerator PlayIntro(){
		mainMenu.SetActive(false);
		angelTalkBtn.gameObject.SetActive(false);
		//SoundManager.Instance.BckgSource.enabled = false;
		playBtn.gameObject.SetActive(false);
		angel.gameObject.SetActive(true);
		yield return new WaitForSeconds(1.4f);
		angelTalkBtn.gameObject.SetActive(true);
		audioSource.PlayOneShot(SoundManager.Instance.Angel2);
		yield return new WaitForSeconds(0.9f);
		angelAnim.SetTrigger("anim");
		angelTextPlace.gameObject.SetActive(true);
		angelText.text = "Welcome to Mummy Mayhem!          This house holds a secret weapon that must not be in the wrong hands!";
		yield return new WaitForSeconds(3.5f);
		SoundManager.Instance.BckgSource.enabled = true;
	}
	[SerializeField]
	private Button zombieTalkBtn;
	[SerializeField]
	private Button angelTalkBtn;
	public void zombieTalk()
	{
		zombieTalkBtn.gameObject.SetActive(false);
		angelTalkBtn.gameObject.SetActive(true);
		zombieTextPlace.gameObject.SetActive(true);
		angelTextPlace.gameObject.SetActive(false);
		if(zombieText.text == "Finally!                                             I have been waiting for this moment for centuries.")
			zombieText.text = "Finally!                                             I have been waiting for this moment for centuries!";
		else if(zombieText.text == "Finally!                                             I have been waiting for this moment for centuries!")
			zombieText.text = "Prepare for a battle! It will be a tough one.";
		// else if(zombieText.text == "Prepare for a battle! It will be a tough one.")
		// 	zombieText.text = "Prepare for a battle! It will be a tough one.";
		// else if(zombieText.text == "Prepare for a battle! It will be a tough one.")
		// 	zombieText.text = "Here I come!";
	}

	public void angelTalk()
	{
		PlayerPrefs.SetInt("introDone", 1);
		zombieTalkBtn.gameObject.SetActive(false);
		angelTalkBtn.gameObject.SetActive(true);
		zombieTextPlace.gameObject.SetActive(false);
		angelTextPlace.gameObject.SetActive(true);
		if(angelText.text == "Welcome to Mummy Mayhem!          This house holds a secret weapon that must not be in the wrong hands!")
			{angelText.text = "The mission to protect the house has now been handed to you!";
			zombie.gameObject.SetActive(true);
			Invoke("chochorvi",2f);
			zombieTalkBtn.gameObject.SetActive(true);
			angelTalkBtn.gameObject.SetActive(false);
			}
		else if(angelText.text == "The mission to protect the house has now been handed to you!")
			{angelText.text = "This house will remain strong!";
			zombieTalkBtn.gameObject.SetActive(true);
			angelTalkBtn.gameObject.SetActive(false);
			}
		else if(angelText.text == "This house will remain strong!")
			{angelText.text = "Always prepared!      Go ahead and try your luck.";
			zombieTalkBtn.gameObject.SetActive(false);
			angelTalkBtn.gameObject.SetActive(true);
			//Invoke("b",3f);
			}
		else if(angelText.text == "Always prepared!      Go ahead and try your luck."){
			angelAnim.SetTrigger("close");
			zombieAnim.SetTrigger("close");
			zombieTalkBtn.gameObject.SetActive(false);
			angelTalkBtn.gameObject.SetActive(false);
			angelTextPlace.gameObject.SetActive(false);
			Invoke("kl",0.6f);
			Invoke("a",2f);
		}
		
	}

	public void kl()
	{
		zombie.gameObject.SetActive(false);
	}
	
	public void a()
	{
		mainMenu.SetActive(true);
		angelAnim.SetTrigger("isHeGone");
		Invoke("c",1.2f);
	}

	public void c()
	{
		angelTextPlaceIsHeGone.gameObject.SetActive(true);
		angelTextIsHeGone.text = "Did he leave?";
	}

	public void allClean()
	{
		angelAnim.SetTrigger("flip");
		angelTextPlaceIsHeGone.gameObject.SetActive(false);
		angelTextPlaceFinal.gameObject.SetActive(true);
		angelTextFinal.text = "That guy has no idea what is waiting for him!";
		Invoke("changeAgain",3f);
	}

	public void changeAgain()
	{
		angelTextFinal.text = "Press play button below and start protecting your house!";
		playBtn.gameObject.SetActive(true);
		playBtn.interactable = true;
	}

	public void chochorvi()
	{
		zombieAnim.SetTrigger("anim");
	}

	[SerializeField]
	private Button openArmy;
	[SerializeField]
	private Button anotherOpenArmy;
	[SerializeField]
	private Image armyBlock;
	private Animator armyBlockAnim;

	[SerializeField]
	private Button openShop;
	[SerializeField]
	private Button anotherOpenShop;
	[SerializeField]
	private Image shopBlock;
	private Animator shopBlockAnim;

	[SerializeField]
	private Button openLab;
	[SerializeField]
	private Image labBlock;
	private Animator labBlockAnim;

	[SerializeField]
	private Button coinOpenShop;
	[SerializeField]
	private Button gemOpenShop;

	[SerializeField]
	private Button playBtn;

	private int gameLevel;


	private int maxEnergyLevelBefore;
	private int maxEnergyLevelAfter;

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
			soundBtn.GetComponent<Image>().sprite = soundOnImage;
			PlayerPrefs.SetInt("sound",1);
		}
	}

	[SerializeField]
	private Text lvl;
	[SerializeField]
	private Text money;
	[SerializeField]
	private Text gem;

	void Update()
	{
		if(PlayerPrefs.GetInt("s1level") == 2){
			armyOpened.gameObject.SetActive(false);
			armyBlock.gameObject.SetActive(false);
			PlayerPrefs.SetInt("armyOpen",2);
		}
	}

	[SerializeField]
	private GameObject researchManager;
	public void turnOnResearchManager()
	{
		researchManager.gameObject.SetActive(true);
	}
	[SerializeField]
	private GameObject chooseMission;
	private Animator chooseMissionAnim;

	[SerializeField]
	private GameObject chooseDiff;
	private Animator chooseDiffAnim;

	void Start()
	{
		chooseMissionAnim = chooseMission.GetComponent<Animator>();
		chooseDiffAnim = chooseDiff.GetComponent<Animator>();
		money.text = PlayerPrefs.GetInt("Money").ToString();
		gem.text = PlayerPrefs.GetInt("Gem").ToString();
		audioSource = GetComponent<AudioSource>();
		if(PlayerPrefs.GetInt("sound") ==1){
			audioSource.enabled = true;
			soundBtn.GetComponent<Image>().sprite = soundOnImage;
		}
		else{
			audioSource.enabled = false;
			soundBtn.GetComponent<Image>().sprite = soundOffImage;
		}
		
		armyBlockAnim = armyBlock.GetComponent<Animator>();
		shopBlockAnim = shopBlock.GetComponent<Animator>();
		labBlockAnim = labBlock.GetComponent<Animator>();
		gameLevel=  PlayerPrefs.GetInt("levelNum");
		lvl.text = "Lvl: "+(gameLevel+1).ToString();
		playBtn.interactable = false;
		openArmy.gameObject.GetComponent<Button>().enabled = false;
		anotherOpenArmy.gameObject.GetComponent<Button>().enabled = false;

		openLab.gameObject.GetComponent<Button>().enabled = false;

		openShop.gameObject.GetComponent<Button>().enabled = false;
		anotherOpenShop.gameObject.GetComponent<Button>().enabled = false;

		coinOpenShop.interactable = false;
		gemOpenShop.interactable = false;

		angelAnim = angel.GetComponent<Animator>();
		zombieAnim = zombie.GetComponent<Animator>();		

		if(PlayerPrefs.HasKey("introDone")==false)
			PlayerPrefs.SetInt("introDone", 0);
		if(PlayerPrefs.GetInt("introDone") == 0)
		{
			StartCoroutine(PlayIntro());
			//PlayerPrefs.SetInt("introDone", 1);
		}
		else {
			mainMenu.SetActive(true);
			playBtn.interactable = true;
			zombieTalkBtn.gameObject.SetActive(false);
			angelTalkBtn.gameObject.SetActive(false);
		}

		if(PlayerPrefs.GetInt("s1level") == 2)
			PlayerPrefs.SetInt("armyOpen",2);


		if(PlayerPrefs.HasKey("armyOpen")==false)
			PlayerPrefs.SetInt("armyOpen",0);
		if(PlayerPrefs.GetInt("armyOpen") == 1)
		{
			StartCoroutine(PlayArmyOpenIntro());
		}
		if(gameLevel>=1 && PlayerPrefs.GetInt("armyOpen") == 2)
		{
			openArmy.gameObject.GetComponent<Button>().enabled = true;
			anotherOpenArmy.gameObject.GetComponent<Button>().enabled = true;
			armyBlock.gameObject.SetActive(false);
			armyOpened.gameObject.SetActive(false);
		}

		if(PlayerPrefs.HasKey("shopOpen")==false)
			PlayerPrefs.SetInt("shopOpen",0);
		if(PlayerPrefs.GetInt("shopOpen") == 1)
		{
			StartCoroutine(PlayShopOpenIntro());
		}
		if(gameLevel>=2 && (PlayerPrefs.GetInt("shopOpen") == 2 || PlayerPrefs.GetInt("shopOpen") == 3) )
		{
			openShop.gameObject.GetComponent<Button>().enabled = true;
			anotherOpenShop.gameObject.GetComponent<Button>().enabled = true;
			shopBlock.gameObject.SetActive(false);
			coinOpenShop.interactable = true;
			gemOpenShop.interactable = true;
			shopOpened.gameObject.SetActive(false);
			shopOpened1.gameObject.SetActive(false);
			shopOpened2.gameObject.SetActive(false);
		}
		
		if(PlayerPrefs.HasKey("labOpen")==false)
			PlayerPrefs.SetInt("labOpen",0);
		if(PlayerPrefs.GetInt("labOpen") == 1)
		{
			StartCoroutine(PlayLabOpenIntro());
		}
		if(PlayerPrefs.GetInt("labOpen") == 2)
		{
			openLab.gameObject.GetComponent<Button>().enabled = true;
			labBlock.gameObject.SetActive(false);
			labOpened.gameObject.SetActive(false);
			labOpened1.gameObject.SetActive(false);
			labOpened2.gameObject.SetActive(false);
		}

		//PlayerPrefs.SetInt("labIntroDone",2);
		if(PlayerPrefs.GetInt("labIntroDone") == 2)
		{
			researchManager.gameObject.SetActive(false);
			mainMenu.SetActive(false);
			InsideTheLab.SetActive(true);
			houseMenu.gameObject.SetActive(true);
			energyMenu.gameObject.SetActive(false);
			PlayerPrefs.SetInt("labIntroDone",3);
			Invoke("turnOnResearchManager",0.3f);
		}

		if(PlayerPrefs.HasKey("end")==false)
			PlayerPrefs.SetInt("end", 0);
		if(PlayerPrefs.GetInt("end") == 1)
		{
			restart.gameObject.SetActive(true);
			mainMenu.gameObject.SetActive(false);
			StartCoroutine(PlayEnd());
		}
		
		
		Time.timeScale =1;
	}

	[SerializeField]
	private GameObject houseMenu;
	[SerializeField]
	private GameObject energyMenu;

	IEnumerator PlayEnd()
	{
		angel.gameObject.SetActive(true);
		yield return new WaitForSeconds(0.6f);
		zombie.gameObject.SetActive(true);
		yield return new WaitForSeconds(2.3f);
		angelAnim.SetTrigger("shoot");
		zombieTextPlace.gameObject.SetActive(true);
		zombieText.text = "Noooo!";
		//yield return new WaitForSeconds(1.6f);
		arrow.gameObject.SetActive(true);
		yield return new WaitForSeconds(1f);
		angelAnim.SetTrigger("anim");
		zombieAnim.SetTrigger("die");
		zombieTextPlace.gameObject.SetActive(false);
		yield return new WaitForSeconds(0.6f);
		arrow.gameObject.SetActive(false);
	}

	public void restartTheGame()
	{
		PlayerPrefs.DeleteKey("levelNum");
		PlayerPrefs.DeleteKey("introDone");
		PlayerPrefs.DeleteKey("armyOpen");
		PlayerPrefs.DeleteKey("shopOpen");
		PlayerPrefs.DeleteKey("labOpen");
		PlayerPrefs.DeleteKey("armyIntroDone");
		PlayerPrefs.DeleteKey("introduction");
		PlayerPrefs.DeleteKey("labIntroDone");
		PlayerPrefs.DeleteKey("end");

		PlayerPrefs.DeleteKey("rewardDone");
		

		PlayerPrefs.DeleteKey("Energy");
		PlayerPrefs.DeleteKey("MaxEnergyLevel");
		PlayerPrefs.DeleteKey("timeMaxEnergy");

		PlayerPrefs.DeleteKey("TapEnergyLevel");
		PlayerPrefs.DeleteKey("TapEnergy");
		PlayerPrefs.DeleteKey("timeTapEnergy");

		PlayerPrefs.DeleteKey("upgradingLab");

		PlayerPrefs.DeleteKey("addedHousePoint");
		PlayerPrefs.DeleteKey("HouseHealth");
		PlayerPrefs.DeleteKey("HouseLevel");
		PlayerPrefs.DeleteKey("researching");
		

		PlayerPrefs.DeleteKey("Money");
		PlayerPrefs.DeleteKey("Gem");

		PlayerPrefs.DeleteKey("5min");
		PlayerPrefs.DeleteKey("10min");
		PlayerPrefs.DeleteKey("15min");
		PlayerPrefs.DeleteKey("30min");
		PlayerPrefs.DeleteKey("60min");
		PlayerPrefs.DeleteKey("3hrs");

		PlayerPrefs.DeleteKey("pumpkin");
		PlayerPrefs.DeleteKey("granade");
		PlayerPrefs.DeleteKey("skully");
		PlayerPrefs.DeleteKey("knight");
		
		PlayerPrefs.DeleteKey("5minUsed");	
		PlayerPrefs.DeleteKey("10minUsed");	
		PlayerPrefs.DeleteKey("15minUsed");	
		PlayerPrefs.DeleteKey("30minUsed");	
		PlayerPrefs.DeleteKey("60minUsed");	
		PlayerPrefs.DeleteKey("3hrsUsed");	

		PlayerPrefs.DeleteKey("s1level");		
	 	PlayerPrefs.DeleteKey("s2level");
	 	PlayerPrefs.DeleteKey("s3level");	
	 	PlayerPrefs.DeleteKey("s4level");
	 	PlayerPrefs.DeleteKey("s5level");
		PlayerPrefs.DeleteKey("s6level");
	 	PlayerPrefs.DeleteKey("s7level");
	 	PlayerPrefs.DeleteKey("s8level");
	 	PlayerPrefs.DeleteKey("s9level");
	 	PlayerPrefs.DeleteKey("s10level");
		PlayerPrefs.DeleteKey("s11level");

		PlayerPrefs.DeleteKey("s1Health");		
	 	PlayerPrefs.DeleteKey("s1Energy");	
	 	PlayerPrefs.DeleteKey("s1Bullet");
	 	PlayerPrefs.DeleteKey("s2Health");
	 	PlayerPrefs.DeleteKey("s2Energy");
	 	PlayerPrefs.DeleteKey("s2Bullet");
	 	PlayerPrefs.DeleteKey("s3Health");	
	 	PlayerPrefs.DeleteKey("s3Energy");
	 	PlayerPrefs.DeleteKey("s3Bullet");
	 	PlayerPrefs.DeleteKey("s4Health");
		PlayerPrefs.DeleteKey("s4Energy");
		PlayerPrefs.DeleteKey("s4Bullet");
	 	PlayerPrefs.DeleteKey("s5Health");
		PlayerPrefs.DeleteKey("s5Energy");
		PlayerPrefs.DeleteKey("s5Bullet");
		PlayerPrefs.DeleteKey("s6Health");
		PlayerPrefs.DeleteKey("s6Energy");
		PlayerPrefs.DeleteKey("s6Bullet");
	 	PlayerPrefs.DeleteKey("s7Health");
	 	PlayerPrefs.DeleteKey("s7Energy");
		PlayerPrefs.DeleteKey("s7Bullet");
	 	PlayerPrefs.DeleteKey("s8Health");
	 	PlayerPrefs.DeleteKey("s8Energy");
		PlayerPrefs.DeleteKey("s8Bullet");
	 	PlayerPrefs.DeleteKey("s9Bullet");
	 	PlayerPrefs.DeleteKey("s10Bullet");
		PlayerPrefs.DeleteKey("s11Bullet");

		PlayerPrefs.DeleteKey("s1HealthNext");		
	 	PlayerPrefs.DeleteKey("s1EnergyNext");	
	 	PlayerPrefs.DeleteKey("s1BulletNext");
	 	PlayerPrefs.DeleteKey("s2HealthNext");
	 	PlayerPrefs.DeleteKey("s2EnergyNext");
	 	PlayerPrefs.DeleteKey("s2BulletNext");
	 	PlayerPrefs.DeleteKey("s3HealthNext");	
	 	PlayerPrefs.DeleteKey("s3EnergyNext");
	 	PlayerPrefs.DeleteKey("s3BulletNext");
	 	PlayerPrefs.DeleteKey("s4HealthNext");
		PlayerPrefs.DeleteKey("s4EnergyNext");
		PlayerPrefs.DeleteKey("s4BulletNext");
	 	PlayerPrefs.DeleteKey("s5HealthNext");
		PlayerPrefs.DeleteKey("s5EnergyNext");
		PlayerPrefs.DeleteKey("s5BulletNext");
		PlayerPrefs.DeleteKey("s6HealthNext");
		PlayerPrefs.DeleteKey("s6EnergyNext");
		PlayerPrefs.DeleteKey("s6BulletNext");
	 	PlayerPrefs.DeleteKey("s7HealthNext");
	 	PlayerPrefs.DeleteKey("s7EnergyNext");
		PlayerPrefs.DeleteKey("s7BulletNext");
	 	PlayerPrefs.DeleteKey("s8HealthNext");
	 	PlayerPrefs.DeleteKey("s8EnergyNext");
		PlayerPrefs.DeleteKey("s8BulletNext");
	 	PlayerPrefs.DeleteKey("s9BulletNext");
	 	PlayerPrefs.DeleteKey("s10BulletNext");
		PlayerPrefs.DeleteKey("s11BulletNext");

		PlayerPrefs.DeleteKey("knightUnlocked");

	 	PlayerPrefs.DeleteKey("time1Lvl2");
	 	PlayerPrefs.DeleteKey("time2Lvl2");
		PlayerPrefs.DeleteKey("time3Lvl2");
		PlayerPrefs.DeleteKey("time4Lvl2");
		PlayerPrefs.DeleteKey("time5Lvl2");
		PlayerPrefs.DeleteKey("time6Lvl2");
		PlayerPrefs.DeleteKey("time7Lvl2");
		PlayerPrefs.DeleteKey("time8Lvl2");
		PlayerPrefs.DeleteKey("time9Lvl2");
		PlayerPrefs.DeleteKey("time10Lvl2");
		PlayerPrefs.DeleteKey("time11Lvl2");

		PlayerPrefs.SetInt("sound",1);
		PlayerPrefs.SetInt("music",1);

	 	PlayerPrefs.DeleteKey("sniperIntro");
		PlayerPrefs.DeleteKey("mercIntro");
		LoadingScreenManager.LoadScene(1);
	}
	[SerializeField]
	private GameObject restart;
	[SerializeField]
	private GameObject arrow;

	[SerializeField]
	private Image armyOpened;
	[SerializeField]
	private Image labOpened;
	[SerializeField]
	private Image labOpened1;
	[SerializeField]
	private Image labOpened2;
	[SerializeField]
	private Image shopOpened;
	[SerializeField]
	private Image shopOpened1;
	[SerializeField]
	private Image shopOpened2;

	IEnumerator PlayArmyOpenIntro()
	{	armyOpened.gameObject.SetActive(true);
		yield return new WaitForSeconds(1.0f);
		armyBlockAnim.SetTrigger("open");
		openArmy.gameObject.GetComponent<Button>().enabled = true;
		anotherOpenArmy.gameObject.GetComponent<Button>().enabled = true;
		yield return new WaitForSeconds(1.3f);
		armyBlock.gameObject.SetActive(false);
	}

	IEnumerator PlayShopOpenIntro()
	{
		shopOpened.gameObject.SetActive(true);
		shopOpened1.gameObject.SetActive(true);
		shopOpened2.gameObject.SetActive(true);
		yield return new WaitForSeconds(1.3f);
		shopBlockAnim.SetTrigger("open");
		openShop.gameObject.GetComponent<Button>().enabled = true;
		anotherOpenShop.gameObject.GetComponent<Button>().enabled = true;
		yield return new WaitForSeconds(4.7f);
		shopBlock.gameObject.SetActive(false);
	}

	IEnumerator PlayLabOpenIntro()
	{
		labOpened.gameObject.SetActive(true);
		labOpened1.gameObject.SetActive(true);
		labOpened2.gameObject.SetActive(true);
		yield return new WaitForSeconds(1.0f);
		labBlockAnim.SetTrigger("open");
		openLab.gameObject.GetComponent<Button>().enabled = true;
		yield return new WaitForSeconds(3f);
		labBlock.gameObject.SetActive(false);
	}

	public void Play(){
		chooseMission.gameObject.SetActive(true);
		//LoadingScreenManager.LoadScene(2);
	}

	public void protect()
	{
		chooseMissionAnim.SetTrigger("go");
		chooseDiff.gameObject.SetActive(true);
	}

	public void attack()
	{
		chooseMissionAnim.SetTrigger("go");
		chooseDiff.gameObject.SetActive(true);
	}

	public void Lab(){
		if(InsideTheLab.activeSelf){
			audioSource.PlayOneShot(SoundManager.Instance.Click5);
			InsideTheLab.SetActive(false);
			mainMenu.SetActive(true);
		}
		else{
			audioSource.PlayOneShot(SoundManager.Instance.Click2);
			mainMenu.SetActive(false);
			InsideTheLab.SetActive(true);
			if(PlayerPrefs.GetInt("labOpen") ==1)
			{
				labOpened.gameObject.SetActive(false);
				labOpened1.gameObject.SetActive(false);
				labOpened2.gameObject.SetActive(false);
				PlayerPrefs.SetInt("labOpen",2);
			}
		}
	}

	[SerializeField]
	private GameObject directions;

	public void Soldiers(){
		if(SoldierList.activeSelf){
			audioSource.PlayOneShot(SoundManager.Instance.Click5);
			SoldierList.SetActive(false);
			mainMenu.SetActive(true);
			PlayerPrefs.SetInt("armyOpen",2);
			if(PlayerPrefs.GetInt("s1level") == 2 && PlayerPrefs.GetInt("armyIntroDone") == 0 && directions.activeSelf )
			{
				directions.gameObject.SetActive(false);
				PlayerPrefs.SetInt("armyIntroDone",1);
			}
		}
		else{
			audioSource.PlayOneShot(SoundManager.Instance.Click2);
			SoldierList.SetActive(true);
			mainMenu.SetActive(false);
			if(PlayerPrefs.GetInt("armyOpen") ==1)
			{
				armyOpened.gameObject.SetActive(false);
			}
		}
	}

	public void s1inSoldierList(){
		audioSource.PlayOneShot(SoundManager.Instance.Click3);
		foreach (GameObject i in soldList){
			if(i.activeSelf)
				i.SetActive(false);
		}
		soldList[0].SetActive(true);
	}
	public void s2inSoldierList(){
		audioSource.PlayOneShot(SoundManager.Instance.Click3);
		foreach (GameObject i in soldList){
			if(i.activeSelf)
				i.SetActive(false);
		}
		soldList[1].SetActive(true);
	}

	public void s3inSoldierList(){
		audioSource.PlayOneShot(SoundManager.Instance.Click3);
		foreach (GameObject i in soldList){
			if(i.activeSelf)
				i.SetActive(false);
		}
		soldList[2].SetActive(true);
	}
	public void s4inSoldierList(){
		audioSource.PlayOneShot(SoundManager.Instance.Click3);
		foreach (GameObject i in soldList){
			if(i.activeSelf)
				i.SetActive(false);
		}
		soldList[3].SetActive(true);
	}

	public void s5inSoldierList(){
		audioSource.PlayOneShot(SoundManager.Instance.Click3);
		foreach (GameObject i in soldList){
			if(i.activeSelf)
				i.SetActive(false);
		}
		soldList[4].SetActive(true);
	}
	public void s6inSoldierList(){
		audioSource.PlayOneShot(SoundManager.Instance.Click3);
		foreach (GameObject i in soldList){
			if(i.activeSelf)
				i.SetActive(false);
		}
		soldList[5].SetActive(true);
	}

	public void s7inSoldierList(){
		audioSource.PlayOneShot(SoundManager.Instance.Click3);
		foreach (GameObject i in soldList){
			if(i.activeSelf)
				i.SetActive(false);
		}
		soldList[6].SetActive(true);
	}
	public void s8inSoldierList(){
		audioSource.PlayOneShot(SoundManager.Instance.Click3);
		foreach (GameObject i in soldList){
			if(i.activeSelf)
				i.SetActive(false);
		}
		soldList[7].SetActive(true);
	}

	public void s9inSoldierList(){
		audioSource.PlayOneShot(SoundManager.Instance.Click3);
		foreach (GameObject i in soldList){
			if(i.activeSelf)
				i.SetActive(false);
		}
		soldList[8].SetActive(true);
	}
	public void s10inSoldierList(){
		audioSource.PlayOneShot(SoundManager.Instance.Click3);
		foreach (GameObject i in soldList){
			if(i.activeSelf)
				i.SetActive(false);
		}
		soldList[9].SetActive(true);
	}

	public void s11inSoldierList(){
		audioSource.PlayOneShot(SoundManager.Instance.Click3);
		foreach (GameObject i in soldList){
			if(i.activeSelf)
				i.SetActive(false);
		}
		soldList[10].SetActive(true);
	}
	public void s12inSoldierList(){
		audioSource.PlayOneShot(SoundManager.Instance.Click3);
		foreach (GameObject i in soldList){
			if(i.activeSelf)
				i.SetActive(false);
		}
		soldList[11].SetActive(true);
	}

	public void Shop(){
		if (areyousure.gameObject.activeSelf){
			audioSource.PlayOneShot(SoundManager.Instance.Click5);
			mainMenu.SetActive(true);
			areyousure.gameObject.SetActive(false);
		}
		else{
			audioSource.PlayOneShot(SoundManager.Instance.Click2);
			mainMenu.SetActive(false);
			areyousure.gameObject.SetActive(true);
		}
	}

	

	public void ShopMenu(){
		audioSource.PlayOneShot(SoundManager.Instance.Click2);
		if(PlayerPrefs.GetInt("shopOpen") ==1)
		{
			shopOpened.gameObject.SetActive(false);
			shopOpened1.gameObject.SetActive(false);
			shopOpened2.gameObject.SetActive(false);
			PlayerPrefs.SetInt("shopOpen",2);
		}
		LoadingScreenManager.LoadScene(4);
	}

	

	


}
