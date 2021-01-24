using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class SoldierManager : Singleton<SoldierManager> {
	public SoldierBtn soldierBtnPressed;
	public SoldierBtn bombBtnPressed;
	private SpriteRenderer spriteRenderer;

	[SerializeField]
	private GameObject leage1Panel;
	[SerializeField]
	private GameObject leage2Panel;
	[SerializeField]
	private GameObject leage3Panel;

	[SerializeField]
	private Image leage1Chosen;
	[SerializeField]
	private Image leage2Chosen;
	[SerializeField]
	private Image leage3Chosen;

	[SerializeField]
	private Sprite chosen;
	[SerializeField]
	private Sprite notChosen;

	[SerializeField]
	private Image card;
	[SerializeField]
	private Image houseEffect;

	public void invokeHouseEffect()
	{
		houseEffect.gameObject.SetActive(false);
	}

	public void invokeSoldierEffect()
	{
		Transform child = null;
				foreach (Soldier soldier in SoldierListUpLeft){
					child = soldier.transform.GetChild(0).GetChild(1);
					child.gameObject.SetActive(false);
				}
				foreach (Soldier soldier in SoldierListLeft){
					child = soldier.transform.GetChild(0).GetChild(1);
					child.gameObject.SetActive(false);
				}
				foreach (Soldier soldier in SoldierListButtomLeft){
					child = soldier.transform.GetChild(0).GetChild(1);
					child.gameObject.SetActive(false);
				}
				foreach (Soldier soldier in SoldierListUpRight){
					child = soldier.transform.GetChild(0).GetChild(1);
					child.gameObject.SetActive(false);
				}
				foreach (Soldier soldier in SoldierListRight){
					child = soldier.transform.GetChild(0).GetChild(1);
					child.gameObject.SetActive(false);
				}
				foreach (Soldier soldier in SoldierListButtomRight){
					child = soldier.transform.GetChild(0).GetChild(1);
					child.gameObject.SetActive(false);
				}
				foreach (Soldier soldier in SoldierMiddle1){
					child = soldier.transform.GetChild(0).GetChild(1);
					child.gameObject.SetActive(false);
				}
				foreach (Soldier soldier in SoldierMiddle2){
					child = soldier.transform.GetChild(0).GetChild(1);
					child.gameObject.SetActive(false);
				}
				foreach (Soldier soldier in SoldierMiddle3){
					child = soldier.transform.GetChild(0).GetChild(1);
					child.gameObject.SetActive(false);
				}
				foreach (Soldier soldier in SoldierMiddle4){
					child = soldier.transform.GetChild(0).GetChild(1);
					child.gameObject.SetActive(false);
				}
	}

	private Transform cardsEffect;
	private Animator effectAnim;
	private GameObject canv2;

	public void useCard()
	{
		if(card.gameObject.activeSelf)
		{
			if(card.sprite.name == "HH")
			{
				houseEffect.gameObject.SetActive(true);
				int hh = PlayerPrefs.GetInt("currentHouseHealth");
				hh+=1000;
				PlayerPrefs.SetInt("currentHouseHealth",hh);
				Invoke("invokeHouseEffect",2f);
			}
			else if(card.sprite.name == "SH")
			{
				Transform child = null;
				foreach (Soldier soldier in SoldierListUpLeft){
					child = soldier.transform.GetChild(0).GetChild(1);
					child.gameObject.SetActive(true);
				}
				foreach (Soldier soldier in SoldierListLeft){
					child = soldier.transform.GetChild(0).GetChild(1);
					child.gameObject.SetActive(true);
				}
				foreach (Soldier soldier in SoldierListButtomLeft){
					child = soldier.transform.GetChild(0).GetChild(1);
					child.gameObject.SetActive(true);
				}
				foreach (Soldier soldier in SoldierListUpRight){
					child = soldier.transform.GetChild(0).GetChild(1);
					child.gameObject.SetActive(true);
				}
				foreach (Soldier soldier in SoldierListRight){
					child = soldier.transform.GetChild(0).GetChild(1);
					child.gameObject.SetActive(true);
				}
				foreach (Soldier soldier in SoldierListButtomRight){
					child = soldier.transform.GetChild(0).GetChild(1);
					child.gameObject.SetActive(true);
				}
				foreach (Soldier soldier in SoldierMiddle1){
					child = soldier.transform.GetChild(0).GetChild(1);
					child.gameObject.SetActive(true);
				}
				foreach (Soldier soldier in SoldierMiddle2){
					child = soldier.transform.GetChild(0).GetChild(1);
					child.gameObject.SetActive(true);
				}
				foreach (Soldier soldier in SoldierMiddle3){
					child = soldier.transform.GetChild(0).GetChild(1);
					child.gameObject.SetActive(true);
				}
				foreach (Soldier soldier in SoldierMiddle4){
					child = soldier.transform.GetChild(0).GetChild(1);
					child.gameObject.SetActive(true);
				}
				Invoke("invokeSoldierEffect",2f);
			}
		}
		
	}

	public void league1()
	{
		leage1Chosen.gameObject.GetComponent<Image>().sprite = chosen;
		leage2Chosen.gameObject.GetComponent<Image>().sprite = notChosen;
		leage3Chosen.gameObject.GetComponent<Image>().sprite = notChosen;
		leage2Panel.SetActive(false);
		leage3Panel.SetActive(false);
		leage1Panel.SetActive(true);
	}
	public void league2()
	{
		leage2Panel.SetActive(true);
		leage3Panel.SetActive(false);
		leage1Panel.SetActive(false);
		leage1Chosen.gameObject.GetComponent<Image>().sprite = notChosen;
		leage2Chosen.gameObject.GetComponent<Image>().sprite = chosen;
		leage3Chosen.gameObject.GetComponent<Image>().sprite = notChosen;
	}
	public void league3()
	{
		leage2Panel.SetActive(false);
		leage3Panel.SetActive(true);
		leage1Panel.SetActive(false);
		leage1Chosen.gameObject.GetComponent<Image>().sprite = notChosen;
		leage2Chosen.gameObject.GetComponent<Image>().sprite = notChosen;
		leage3Chosen.gameObject.GetComponent<Image>().sprite = chosen;
	}
	
	[SerializeField]
	private Image s1Bckg;
	[SerializeField]
	private Image s1scoreBar;
	[SerializeField]
	private Image s1energyPic;
	[SerializeField]
	private Image s1soldierPic;


	[SerializeField]
	private Image s2Bckg;
	[SerializeField]
	private Image s2scoreBar;
	[SerializeField]
	private Image s2energyPic;
	[SerializeField]
	private Image s2soldierPic;
	
	[SerializeField]
	private Image s3Bckg;
	[SerializeField]
	private Image s3scoreBar;
	[SerializeField]
	private Image s3energyPic;
	[SerializeField]
	private Image s3soldierPic;

	[SerializeField]
	private Image s4Bckg;
	[SerializeField]
	private Image s4scoreBar;
	[SerializeField]
	private Image s4energyPic;
	[SerializeField]
	private Image s4soldierPic;

	[SerializeField]
	private Image s5Bckg;
	[SerializeField]
	private Image s5scoreBar;
	[SerializeField]
	private Image s5energyPic;
	[SerializeField]
	private Image s5soldierPic;

	[SerializeField]
	private Image s6Bckg;
	[SerializeField]
	private Image s6scoreBar;
	[SerializeField]
	private Image s6energyPic;
	[SerializeField]
	private Image s6soldierPic;

	[SerializeField]
	private Image s7Bckg;
	[SerializeField]
	private Image s7scoreBar;
	[SerializeField]
	private Image s7energyPic;
	[SerializeField]
	private Image s7soldierPic;

	[SerializeField]
	private Image s8Bckg;
	[SerializeField]
	private Image s8scoreBar;
	[SerializeField]
	private Image s8energyPic;
	[SerializeField]
	private Image s8soldierPic;

	[SerializeField]
	private Stat energyS1;
	private const float coefS1 = 2f;

	[SerializeField]
	private Stat energyS2;
	private const float coefS2 = 1.7f;

	[SerializeField]
	private Stat energyS3;
	private const float coefS3 = 1.2f;

	[SerializeField]
	private Stat energyS4;
	private const float coefS4 = 0.8f;

	[SerializeField]
	private Stat energyS5;
	private const float coefS5 = 2.7f;

	[SerializeField]
	private Stat energyS6;
	private const float coefS6 = 2.3f;

	[SerializeField]
	private Stat energyS7;
	private const float coefS7 = 2.1f;

	[SerializeField]
	private Stat energyS8;
	private const float coefS8 = 2f;

	[SerializeField]
	private Stat mainEnergy;

	public Stat MainEnergy{
		get{
			return mainEnergy;
		}
		set{
			mainEnergy = value;
		}
	}
	[SerializeField]
	private Text mainEnergyText;
	private float coefMain = 3f;

	[SerializeField]
	private int numOfPumpkins;
	[SerializeField]
	private Text pumpkinText;
	[SerializeField]
	private Text pumpkinTextInside;
	
	[SerializeField]
	private int numOfDestroyAllBomb;
	[SerializeField]
	private Text DestroyAllBombText;
	[SerializeField]
	private Text DestroyAllBombTextInside;


	[SerializeField]
	private int numOfOneRowBomb;
	[SerializeField]
	private Text OneRowBombText;
	[SerializeField]
	private Text OneRowBombTextInside;

	[SerializeField]
	private int numOfGranade;
	[SerializeField]
	private Text granadeText;
	[SerializeField]
	private Text granadeTextInside;
	
	[SerializeField]
	private GameObject youDontHaveThisItemShop;
	[SerializeField]
	private GameObject getMorePumpkin;
	[SerializeField]
	private GameObject getMoreGranade;
	[SerializeField]
	private GameObject getMoreSkully;
	[SerializeField]
	private GameObject getMoreKnight;
	[SerializeField]
	private GameObject groundRaycast;

	[SerializeField]
	private Image granadeBlock;
	[SerializeField]
	private Image skullyBlock;
	[SerializeField]
	private Image knightBlock;
	public void getMoreOpen(){
		if(!youDontHaveThisItemShop.activeSelf){
			//Time.timeScale = 0;
			youDontHaveThisItemShop.SetActive(true);
			if(levelNumber>= 13)
			{	skullyBlock.gameObject.SetActive(false);}
			if(levelNumber >= 21)
			{	granadeBlock.gameObject.SetActive(false);}
			if(levelNumber >= 26 && PlayerPrefs.GetInt("knightUnlocked")==1){
				knightBlock.gameObject.SetActive(false);
			}

		}
		else{
			Time.timeScale = 1;
			shopAnimator.SetTrigger("close");
			youDontHaveThisItemShop.SetActive(false);
		}
		
	}

	private Animator shopAnimator;
	[SerializeField]
	private Button closeShop;
	

	

	
	
	public List<Soldier> SoldierListUpLeft = new List<Soldier>();
	public List<Soldier> SoldierListLeft = new List<Soldier>();
	public List<Soldier> SoldierListButtomLeft = new List<Soldier>();
	public List<Soldier> SoldierListUpRight = new List<Soldier>();
	public List<Soldier> SoldierListRight= new List<Soldier>();
	public List<Soldier> SoldierListButtomRight = new List<Soldier>();

	public List<Soldier> SoldierMiddle1 = new List<Soldier>();
	public List<Soldier> SoldierMiddle2 = new List<Soldier>();
	public List<Soldier> SoldierMiddle3 = new List<Soldier>();
	public List<Soldier> SoldierMiddle4 = new List<Soldier>();
	private Vector2 doorPos;
	private Animator soldierAnim;
	private Animator doorAnim;
	private Animator doorAnim2;
	public GameObject door1;
	public GameObject door2;
	public GameObject window1;
	public GameObject window2;

	private Animator s1Btn;
	private Animator s2Btn;
	private Animator s3Btn;
	private Animator s4Btn;
	private Animator s5Btn;
	private Animator s6Btn;
	private Animator s7Btn;
	private Animator s8Btn;


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

	private GameObject S5678Spot1;
	private GameObject S5678Spot2;
	private GameObject S5678Spot3;
	private GameObject S5678Spot4;
	private Collider2D S56781;
	private Collider2D S56782;
	private Collider2D S56783;
	private Collider2D S56784;

	[SerializeField]
	private Text s1EnergyRequired;
	[SerializeField]
	private Text s2EnergyRequired;
	[SerializeField]
	private Text s3EnergyRequired;
	[SerializeField]
	private Text s4EnergyRequired;
	[SerializeField]
	private Text s5EnergyRequired;
	[SerializeField]
	private Text s6EnergyRequired;
	[SerializeField]
	private Text s7EnergyRequired;
	[SerializeField]
	private Text s8EnergyRequired;

	private int levelNumber;
	// Use this for initialization
	void Start () {
		canv2 = GameObject.Find("ALLI");
		cardsEffect = canv2.transform.GetChild(27).GetChild(22).GetChild(3);
		effectAnim = cardsEffect.gameObject.GetComponent<Animator>();

		levelNumber = PlayerPrefs.GetInt("levelNum");
		angelAnim = angel.GetComponent<Animator>();
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
		
		mercIntroAnim = mercIntroSign.GetComponent<Animator>();
		stone = GameObject.Find("StoneL1");

		sniperIntroAnim = sniperIntroSign.GetComponent<Animator>();
		shopAnimator = youDontHaveThisItemShop.GetComponent<Animator>();

		s1Btn = s1Bckg.GetComponent<Animator>();
		s2Btn = s2Bckg.GetComponent<Animator>();
		s3Btn = s3Bckg.GetComponent<Animator>();
		s4Btn = s4Bckg.GetComponent<Animator>();
		s5Btn = s5Bckg.GetComponent<Animator>();
		s6Btn = s6Bckg.GetComponent<Animator>();
		s7Btn = s7Bckg.GetComponent<Animator>();
		s8Btn = s8Bckg.GetComponent<Animator>();

		currentS1Energy = PlayerPrefs.GetInt("s1Energy");
		currentS2Energy = PlayerPrefs.GetInt("s2Energy");
		currentS3Energy = PlayerPrefs.GetInt("s3Energy");
		currentS4Energy = PlayerPrefs.GetInt("s4Energy");
		currentS5Energy = PlayerPrefs.GetInt("s5Energy");
		currentS6Energy = PlayerPrefs.GetInt("s6Energy");
		currentS7Energy = PlayerPrefs.GetInt("s7Energy");
		currentS8Energy = PlayerPrefs.GetInt("s8Energy");

		energyS1.MaxVal = PlayerPrefs.GetInt("s1Energy");
		energyS1.CurrentVal = PlayerPrefs.GetInt("s1Energy");
		energyS2.MaxVal = PlayerPrefs.GetInt("s2Energy");
		energyS2.CurrentVal = PlayerPrefs.GetInt("s2Energy");
		energyS3.MaxVal = PlayerPrefs.GetInt("s3Energy");
		energyS3.CurrentVal = PlayerPrefs.GetInt("s3Energy");
		energyS4.MaxVal = PlayerPrefs.GetInt("s4Energy");
		energyS4.CurrentVal = PlayerPrefs.GetInt("s4Energy");
		energyS5.MaxVal = PlayerPrefs.GetInt("s5Energy");
		energyS5.CurrentVal = PlayerPrefs.GetInt("s5Energy");
		energyS6.MaxVal = PlayerPrefs.GetInt("s6Energy");
		energyS6.CurrentVal = PlayerPrefs.GetInt("s6Energy");
		energyS7.MaxVal = PlayerPrefs.GetInt("s7Energy");
		energyS7.CurrentVal = PlayerPrefs.GetInt("s7Energy");
		energyS8.MaxVal = PlayerPrefs.GetInt("s8Energy");
		energyS8.CurrentVal = PlayerPrefs.GetInt("s8Energy");

		mainEnergy.CurrentVal = 0;
		mainEnergy.MaxVal = PlayerPrefs.GetInt("Energy");
		numOfPumpkins = PlayerPrefs.GetInt("pumpkin");
		pumpkinText.text = "Have: "+numOfPumpkins.ToString();

		numOfGranade = PlayerPrefs.GetInt("granade");
		granadeText.text = "Have: "+numOfGranade.ToString();

		numOfOneRowBomb = PlayerPrefs.GetInt("skully");
		OneRowBombText.text = "Have: "+numOfOneRowBomb.ToString();

		numOfDestroyAllBomb = PlayerPrefs.GetInt("knight");
		DestroyAllBombText.text = "Have: "+numOfDestroyAllBomb.ToString();

		spriteRenderer = GetComponent<SpriteRenderer>();
		doorPos = new Vector2(-0.1f,-1.45f);
		door1 = GameObject.Find("Door (1)");
		door2 = GameObject.Find("Door (2)");
		window1 = GameObject.Find("Window1");
		window2 = GameObject.Find("Window2");
		doorAnim = door1.gameObject.GetComponent<Animator>();
		doorAnim2 = door2.gameObject.GetComponent<Animator>();

		numOfPumpkins = PlayerPrefs.GetInt("pumpkin");
		numOfGranade = PlayerPrefs.GetInt("granade");
		numOfOneRowBomb = PlayerPrefs.GetInt("skully");
		numOfDestroyAllBomb = PlayerPrefs.GetInt("knight");
		if(numOfPumpkins==0)
			{getMorePumpkin.SetActive(true);
			pumpkinText.enabled = false;
			}
		if(numOfGranade==0)
			{getMoreGranade.SetActive(true);
			granadeText.enabled = false;
			}
		if(numOfOneRowBomb==0)
			{getMoreSkully.SetActive(true);
			OneRowBombText.enabled = false;
			}
		if(numOfDestroyAllBomb==0)
			{getMoreKnight.SetActive(true);
			DestroyAllBombText.enabled = false;
			}

		if(PlayerPrefs.GetInt("mercIntro")==1)
		{
			energyS5.CurrentVal = energyS5.MaxVal;
			mainEnergy.CurrentVal = mainEnergy.MaxVal;
		}
	}

	[SerializeField]
	private Button btn1;
	[SerializeField]
	private Button btn2;
	[SerializeField]
	private Button btn3;
	[SerializeField]
	private Button btn4;
	[SerializeField]
	private Button btn5;
	[SerializeField]
	private Button btn6;
	[SerializeField]
	private Button btn7;
	[SerializeField]
	private Button btn8;
	[SerializeField]
	private Button btn9;
	[SerializeField]
	private Button btn10;
	[SerializeField]
	private Button btn11;
	[SerializeField]
	private Button btn12;
	[SerializeField]
	private Button btn13;
	[SerializeField]
	private Button btn14;
	[SerializeField]
	private Button btn15;
	[SerializeField]
	private Button btn16;
	[SerializeField]
	private Button btn17;
	[SerializeField]
	private Button btn18;
	[SerializeField]
	private Button btn19;
	[SerializeField]
	private Button btn20;
	[SerializeField]
	private Button btn21;
	[SerializeField]
	private Button btn22;
	[SerializeField]
	private Button btn23;
	[SerializeField]
	private Button btn24;
	[SerializeField]
	private Button btn25;
	[SerializeField]
	private Button btn26;
	[SerializeField]
	private Button btn27;
	[SerializeField]
	private Button btn28;
	[SerializeField]
	private Button btn29;
	[SerializeField]
	private Button btn30;
	[SerializeField]
	private Button btn31;
	[SerializeField]
	private Button btn32;
	[SerializeField]
	private Button btn33;
	[SerializeField]
	private Button btn34;
	[SerializeField]
	private Button btn35;
	[SerializeField]
	private Button btn36;
	[SerializeField]
	private List<GameObject> stonesList;

	[SerializeField]
	private Button mbtn1;
	[SerializeField]
	private Button mbtn2;
	[SerializeField]
	private Button mbtn3;
	[SerializeField]
	private Button mbtn4;
	[SerializeField]
	private List<GameObject> mstoneList;
	
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

	private void Awake(){
		energyS1.Initialize();
		energyS2.Initialize();
		energyS3.Initialize();
		energyS4.Initialize();
		energyS5.Initialize();
		energyS6.Initialize();
		energyS7.Initialize();
		energyS8.Initialize();
		mainEnergy.Initialize();
		
		mainEnergy.MaxVal = PlayerPrefs.GetInt("Energy");
		mainEnergy.CurrentVal = PlayerPrefs.GetInt("Energy");
	}

	public void addEnergy(int n){
		GameManager.Instance.AudioSource.PlayOneShot(SoundManager.Instance.Click4);
		mainEnergy.CurrentVal +=n;
	}

	private float currentS1Energy;
	private float currentS2Energy;
	private float currentS3Energy;
	private float currentS4Energy;
	private float currentS5Energy;
	private float currentS6Energy;
	private float currentS7Energy;
	private float currentS8Energy;

	[SerializeField]
	private Image kaycak1;
	private Animator kaycak1Anim;
	[SerializeField]
	private Image kaycak2;
	private Animator kaycak2Anim;
	[SerializeField]
	private Image kaycak3;
	private Animator kaycak3Anim;
	[SerializeField]
	private Image kaycak4;
	private Animator kaycak4Anim;
	[SerializeField]
	private Image kaycak5;
	private Animator kaycak5Anim;
	[SerializeField]
	private Image kaycak6;
	private Animator kaycak6Anim;
	[SerializeField]
	private Image kaycak7;
	private Animator kaycak7Anim;
	[SerializeField]
	private Image kaycak8;
	private Animator kaycak8Anim;

	
	

	
	// Update is called once per frame
	void Update () {
		s1EnergyRequired.text = currentS1Energy.ToString("0")+"/"+energyS1.MaxVal;
		s2EnergyRequired.text = currentS2Energy.ToString("0")+"/"+energyS2.MaxVal;
		s3EnergyRequired.text = currentS3Energy.ToString("0")+"/"+energyS3.MaxVal;
		s4EnergyRequired.text = currentS4Energy.ToString("0")+"/"+energyS4.MaxVal;
		s5EnergyRequired.text = currentS5Energy.ToString("0")+"/"+energyS5.MaxVal;
		s6EnergyRequired.text = currentS6Energy.ToString("0")+"/"+energyS6.MaxVal;
		s7EnergyRequired.text = currentS7Energy.ToString("0")+"/"+energyS7.MaxVal;
		s8EnergyRequired.text = currentS8Energy.ToString("0")+"/"+energyS8.MaxVal;
		if(PlayerPrefs.GetInt("mercIntro")==1)
		{
			energyS5.CurrentVal = energyS5.MaxVal;
			mainEnergy.CurrentVal = mainEnergy.MaxVal;
		}
		mainEnergyText.text = "Energy: " + mainEnergy.CurrentVal.ToString("F0");
		if(energyS1.CurrentVal==energyS1.MaxVal && mainEnergy.CurrentVal> energyS1.MaxVal )
			{s1Bckg.CrossFadeAlpha(1.0f, 1.0f, true);
			s1scoreBar.CrossFadeAlpha(1.0f, 1.0f, true);
			s1energyPic.CrossFadeAlpha(1.0f, 1.0f, true);
			s1soldierPic.CrossFadeAlpha(1.0f, 1.0f, true);
			s1Btn.SetTrigger("canUse");
			}
		else
			{s1Btn.SetTrigger("s2BtnMainGame");
			s1Bckg.CrossFadeAlpha(0.5f, 0.5f, true);
			s1scoreBar.CrossFadeAlpha(0.5f, 0.5f, true);
			s1energyPic.CrossFadeAlpha(0.5f, 0.5f, true);
			s1soldierPic.CrossFadeAlpha(0.5f, 0.5f, true);
			}

		if(energyS2.CurrentVal==energyS2.MaxVal && mainEnergy.CurrentVal> energyS2.MaxVal )
			{s2Bckg.CrossFadeAlpha(1.0f, 1.0f, true);
			s2scoreBar.CrossFadeAlpha(1.0f, 1.0f, true);
			s2energyPic.CrossFadeAlpha(1.0f, 1.0f, true);
			s2soldierPic.CrossFadeAlpha(1.0f, 1.0f, true);
			s2Btn.SetTrigger("canUse");
			}
		else
			{s2Btn.SetTrigger("s2BtnMainGame");
			s2Bckg.CrossFadeAlpha(0.5f, 0.5f, true);
			s2scoreBar.CrossFadeAlpha(0.5f, 0.5f, true);
			s2energyPic.CrossFadeAlpha(0.5f, 0.5f, true);
			s2soldierPic.CrossFadeAlpha(0.5f, 0.5f, true);
			}


		if(energyS3.CurrentVal==energyS3.MaxVal && mainEnergy.CurrentVal> energyS3.MaxVal )
			{s3Bckg.CrossFadeAlpha(1.0f, 1.0f, true);
			s3scoreBar.CrossFadeAlpha(1.0f, 1.0f, true);
			s3energyPic.CrossFadeAlpha(1.0f, 1.0f, true);
			s3soldierPic.CrossFadeAlpha(1.0f, 1.0f, true);
			s3Btn.SetTrigger("canUse");
			}
		else
			{s3Btn.SetTrigger("s2BtnMainGame");
			s3Bckg.CrossFadeAlpha(0.5f, 0.5f, true);
			s3scoreBar.CrossFadeAlpha(0.5f, 0.5f, true);
			s3energyPic.CrossFadeAlpha(0.5f, 0.5f, true);
			s3soldierPic.CrossFadeAlpha(0.5f, 0.5f, true);
			}

		if(energyS4.CurrentVal==energyS4.MaxVal && mainEnergy.CurrentVal> energyS4.MaxVal )
			{s4Bckg.CrossFadeAlpha(1.0f, 1.0f, true);
			s4scoreBar.CrossFadeAlpha(1.0f, 1.0f, true);
			s4energyPic.CrossFadeAlpha(1.0f, 1.0f, true);
			s4soldierPic.CrossFadeAlpha(1.0f, 1.0f, true);
			s4Btn.SetTrigger("canUse");
			}
		else
			{s4Btn.SetTrigger("s2BtnMainGame");
			s4Bckg.CrossFadeAlpha(0.5f, 0.5f, true);
			s4scoreBar.CrossFadeAlpha(0.5f, 0.5f, true);
			s4energyPic.CrossFadeAlpha(0.5f, 0.5f, true);
			s4soldierPic.CrossFadeAlpha(0.5f, 0.5f, true);
		}

		if(energyS5.CurrentVal==energyS5.MaxVal && mainEnergy.CurrentVal> energyS5.MaxVal )
			{s5Bckg.CrossFadeAlpha(1.0f, 1.0f, true);
			s5scoreBar.CrossFadeAlpha(1.0f, 1.0f, true);
			s5energyPic.CrossFadeAlpha(1.0f, 1.0f, true);
			s5soldierPic.CrossFadeAlpha(1.0f, 1.0f, true);
			s5Btn.SetTrigger("canUse");
			}
		else
			{s5Btn.SetTrigger("s2BtnMainGame");
			s5Bckg.CrossFadeAlpha(0.5f, 0.5f, true);
			s5scoreBar.CrossFadeAlpha(0.5f, 0.5f, true);
			s5energyPic.CrossFadeAlpha(0.5f, 0.5f, true);
			s5soldierPic.CrossFadeAlpha(0.5f, 0.5f, true);
			}

		if(energyS6.CurrentVal==energyS6.MaxVal && mainEnergy.CurrentVal> energyS6.MaxVal )
			{s6Bckg.CrossFadeAlpha(1.0f, 1.0f, true);
			s6scoreBar.CrossFadeAlpha(1.0f, 1.0f, true);
			s6energyPic.CrossFadeAlpha(1.0f, 1.0f, true);
			s6soldierPic.CrossFadeAlpha(1.0f, 1.0f, true);
			s6Btn.SetTrigger("canUse");
			}
		else
			{s6Btn.SetTrigger("s2BtnMainGame");
			s6Bckg.CrossFadeAlpha(0.5f, 0.5f, true);
			s6scoreBar.CrossFadeAlpha(0.5f, 0.5f, true);
			s6energyPic.CrossFadeAlpha(0.5f, 0.5f, true);
			s6soldierPic.CrossFadeAlpha(0.5f, 0.5f, true);
			}
		if(energyS7.CurrentVal==energyS7.MaxVal && mainEnergy.CurrentVal> energyS7.MaxVal )
			{s7Bckg.CrossFadeAlpha(1.0f, 1.0f, true);
			s7scoreBar.CrossFadeAlpha(1.0f, 1.0f, true);
			s7energyPic.CrossFadeAlpha(1.0f, 1.0f, true);
			s7soldierPic.CrossFadeAlpha(1.0f, 1.0f, true);
			s7Btn.SetTrigger("canUse");
			}
		else
			{s7Btn.SetTrigger("s2BtnMainGame");
			s7Bckg.CrossFadeAlpha(0.5f, 0.5f, true);
			s7scoreBar.CrossFadeAlpha(0.5f, 0.5f, true);
			s7energyPic.CrossFadeAlpha(0.5f, 0.5f, true);
			s7soldierPic.CrossFadeAlpha(0.5f, 0.5f, true);
			}
		if(energyS8.CurrentVal==energyS8.MaxVal && mainEnergy.CurrentVal> energyS8.MaxVal )
			{s8Bckg.CrossFadeAlpha(1.0f, 1.0f, true);
			s8scoreBar.CrossFadeAlpha(1.0f, 1.0f, true);
			s8energyPic.CrossFadeAlpha(1.0f, 1.0f, true);
			s8soldierPic.CrossFadeAlpha(1.0f, 1.0f, true);
			s8Btn.SetTrigger("canUse");
			}
		else
			{s8Btn.SetTrigger("s2BtnMainGame");
			s8Bckg.CrossFadeAlpha(0.5f, 0.5f, true);
			s8scoreBar.CrossFadeAlpha(0.5f, 0.5f, true);
			s8energyPic.CrossFadeAlpha(0.5f, 0.5f, true);
			s8soldierPic.CrossFadeAlpha(0.5f, 0.5f, true);
			}
	
		if(PlayerPrefs.GetInt("TapEnergyLevel")==1)
			coefMain = 10;
		else if(PlayerPrefs.GetInt("TapEnergyLevel")==2)
			coefMain = 9.222f;
		else if(PlayerPrefs.GetInt("TapEnergyLevel")==3)
			coefMain = 8.442f;
		else if(PlayerPrefs.GetInt("TapEnergyLevel")==4)
			coefMain = 7.662f;
		else if(PlayerPrefs.GetInt("TapEnergyLevel")==5)
			coefMain = 6.882f;
		else if(PlayerPrefs.GetInt("TapEnergyLevel")==6)
			coefMain = 6.102f;
		else if(PlayerPrefs.GetInt("TapEnergyLevel")==7)
			coefMain = 5.322f;
		else if(PlayerPrefs.GetInt("TapEnergyLevel")==8)
			coefMain = 4.542f;
		else if(PlayerPrefs.GetInt("TapEnergyLevel")==9)
			coefMain = 3.762f;
		else if(PlayerPrefs.GetInt("TapEnergyLevel")==10)
			coefMain = 3f;
		
		if(PlayerPrefs.GetInt("introduction") ==0 && mainEnergy.CurrentVal >=10)
		{	mainEnergy.CurrentVal = 15;
			energyPointer.gameObject.SetActive(false);
			greenBtnPointer.gameObject.SetActive(false);
		}
		else
			mainEnergy.CurrentVal -= coefMain * Time.deltaTime;

			
		energyS1.CurrentVal += 1.3f * Time.deltaTime;
		energyS2.CurrentVal += 1.3f * Time.deltaTime;
		energyS3.CurrentVal += 1.3f* Time.deltaTime;
		energyS4.CurrentVal += 1.3f * Time.deltaTime;
		energyS5.CurrentVal += 1.45f* Time.deltaTime;
		energyS6.CurrentVal += 1.45f* Time.deltaTime;
		energyS7.CurrentVal += 1.45f * Time.deltaTime;
		energyS8.CurrentVal += 1.45f * Time.deltaTime;

		currentS1Energy = energyS1.CurrentVal;
		currentS2Energy = energyS2.CurrentVal;
		currentS3Energy = energyS3.CurrentVal;
		currentS4Energy = energyS4.CurrentVal;
		currentS5Energy = energyS5.CurrentVal;
		currentS6Energy = energyS6.CurrentVal;
		currentS7Energy = energyS7.CurrentVal;
		currentS8Energy = energyS8.CurrentVal;

		//Invoke("changeKaycak",0.5f);
		if(energyS1.CurrentVal==energyS1.MaxVal){
			
		}
		else{
			
		}
		if(energyS2.CurrentVal==energyS2.MaxVal){
			
		}
		else{
			
		}
		if(energyS3.CurrentVal==energyS3.MaxVal){
			
		}
		else{
			
		}
		if(energyS4.CurrentVal==energyS4.MaxVal){
			
		}
		else{
			
		}
		if(energyS5.CurrentVal==energyS5.MaxVal){
			
		}
		else{
			
		}
		if(energyS6.CurrentVal==energyS6.MaxVal){
			
		}
		else{
			
		}
		if(energyS7.CurrentVal==energyS7.MaxVal){
			
		}
		else{
			
		}
		if(energyS8.CurrentVal==energyS8.MaxVal){
			
		}
		else{
			
		}
	

		
		numOfPumpkins = PlayerPrefs.GetInt("pumpkin");
		numOfGranade = PlayerPrefs.GetInt("granade");
		numOfOneRowBomb = PlayerPrefs.GetInt("skully");
		numOfDestroyAllBomb = PlayerPrefs.GetInt("knight");
		if(numOfPumpkins!=0)
			{getMorePumpkin.SetActive(false);
			pumpkinText.enabled = true;
			}
		if(numOfGranade!=0)
			{getMoreGranade.SetActive(false);
			granadeText.enabled = true;
			}
		if(numOfOneRowBomb!=0)
			{getMoreSkully.SetActive(false);
			OneRowBombText.enabled = true;
			}
		if(numOfDestroyAllBomb!=0)
			{getMoreKnight.SetActive(false);
			DestroyAllBombText.enabled = true;
			}
		 
		
		if(soldierBtnPressed!=null){
			if(soldierBtnPressed.SoldierObject.Length  == 6){
			turnOffBtns("a");
			mbtn1.gameObject.SetActive(false);
			mbtn2.gameObject.SetActive(false);
			mbtn3.gameObject.SetActive(false);
			mbtn4.gameObject.SetActive(false);
			}
			else if(soldierBtnPressed.SoldierObject.Length  == 4)
			{
				turnOffBtns("off");
				mbtn1.gameObject.SetActive(true);
				mbtn2.gameObject.SetActive(true);
				mbtn3.gameObject.SetActive(true);
				mbtn4.gameObject.SetActive(true);
			}
			turnOffBushes("off");
			turnOffPaths("off");
			tunrOffCrates("off");
			knightDropBtn.gameObject.SetActive(false);
			if (soldierBtnPressed.SoldierObject[1].name.Contains("Soldier1")){
					s1selected.gameObject.SetActive(true);
					s2selected.gameObject.SetActive(false);
					s3selected.gameObject.SetActive(false);
					s4selected.gameObject.SetActive(false);
					s5selected.gameObject.SetActive(false);
					s6selected.gameObject.SetActive(false);
					s7selected.gameObject.SetActive(false);
					s8selected.gameObject.SetActive(false);
			}
			else if (soldierBtnPressed.SoldierObject[1].name.Contains("Soldier2")){
					s1selected.gameObject.SetActive(false);
					s2selected.gameObject.SetActive(true);
					s3selected.gameObject.SetActive(false);
					s4selected.gameObject.SetActive(false);
					s5selected.gameObject.SetActive(false);
					s6selected.gameObject.SetActive(false);
					s7selected.gameObject.SetActive(false);
					s8selected.gameObject.SetActive(false);
			}else if (soldierBtnPressed.SoldierObject[1].name.Contains("Soldier3")){
					s1selected.gameObject.SetActive(false);
					s2selected.gameObject.SetActive(false);
					s3selected.gameObject.SetActive(true);
					s4selected.gameObject.SetActive(false);
					s5selected.gameObject.SetActive(false);
					s6selected.gameObject.SetActive(false);
					s7selected.gameObject.SetActive(false);
					s8selected.gameObject.SetActive(false);
			}
			else if (soldierBtnPressed.SoldierObject[1].name.Contains("Soldier4")){
					s1selected.gameObject.SetActive(false);
					s2selected.gameObject.SetActive(false);
					s3selected.gameObject.SetActive(false);
					s4selected.gameObject.SetActive(true);
					s5selected.gameObject.SetActive(false);
					s6selected.gameObject.SetActive(false);
					s7selected.gameObject.SetActive(false);
					s8selected.gameObject.SetActive(false);
			}
			else if (soldierBtnPressed.SoldierObject[1].name.Contains("Soldier5")){
					s1selected.gameObject.SetActive(false);
					s2selected.gameObject.SetActive(false);
					s3selected.gameObject.SetActive(false);
					s4selected.gameObject.SetActive(false);
					s5selected.gameObject.SetActive(true);
					s6selected.gameObject.SetActive(false);
					s7selected.gameObject.SetActive(false);
					s8selected.gameObject.SetActive(false);
			}
			else if (soldierBtnPressed.SoldierObject[1].name.Contains("Soldier6")){
					s1selected.gameObject.SetActive(false);
					s2selected.gameObject.SetActive(false);
					s3selected.gameObject.SetActive(false);
					s4selected.gameObject.SetActive(false);
					s5selected.gameObject.SetActive(false);
					s6selected.gameObject.SetActive(true);
					s7selected.gameObject.SetActive(false);
					s8selected.gameObject.SetActive(false);
			}
			else if (soldierBtnPressed.SoldierObject[1].name.Contains("Soldier7")){
					s1selected.gameObject.SetActive(false);
					s2selected.gameObject.SetActive(false);
					s3selected.gameObject.SetActive(false);
					s4selected.gameObject.SetActive(false);
					s5selected.gameObject.SetActive(false);
					s6selected.gameObject.SetActive(false);
					s7selected.gameObject.SetActive(true);
					s8selected.gameObject.SetActive(false);
			}
			else if (soldierBtnPressed.SoldierObject[1].name.Contains("Soldier8")){
					s1selected.gameObject.SetActive(false);
					s2selected.gameObject.SetActive(false);
					s3selected.gameObject.SetActive(false);
					s4selected.gameObject.SetActive(false);
					s5selected.gameObject.SetActive(false);
					s6selected.gameObject.SetActive(false);
					s7selected.gameObject.SetActive(false);
					s8selected.gameObject.SetActive(true);
			}
		}
		else if(bombBtnPressed!=null)
		{	turnOffBtns("off");
			mbtn1.gameObject.SetActive(false);
			mbtn2.gameObject.SetActive(false);
			mbtn3.gameObject.SetActive(false);
			mbtn4.gameObject.SetActive(false);

			s1selected.gameObject.SetActive(false);
			s2selected.gameObject.SetActive(false);
			s3selected.gameObject.SetActive(false);
			s4selected.gameObject.SetActive(false);
			s5selected.gameObject.SetActive(false);
			s6selected.gameObject.SetActive(false);
			s7selected.gameObject.SetActive(false);
			s8selected.gameObject.SetActive(false);
			if(bombBtnPressed.BombObject!=null){
				turnOffPaths("off");
				tunrOffCrates("off");
				if(bombBtnPressed.BombObject.name == "BombPumpk")
				{
					turnOffBushes("a");
					if(PlayerPrefs.GetInt("sniperIntro")==2){
						bush1.interactable = false;
						bush3.interactable = false;
						bush4.interactable = false;
						bush5.interactable = false;
						bush6.interactable = false;
					}
					else {
						bush1.interactable = true;
						bush2.interactable = true;
						bush3.interactable = true;
						bush4.interactable = true;
						bush5.interactable = true;
						bush6.interactable = true;
					}
					knightDropBtn.gameObject.SetActive(false);
				}
				else if(bombBtnPressed.BombObject.name=="DestroyAllBomb")
				{
					knightDropBtn.gameObject.SetActive(true);
					turnOffBushes("off");
				}
			}
			else if (bombBtnPressed.OneRowBombObject[0].name.Contains("Destroy"))
			{
				turnOffBushes("off");
				tunrOffCrates("off");
				knightDropBtn.gameObject.SetActive(false);
				turnOffPaths("a");
			}
			else if(bombBtnPressed.OneRowBombObject[0].name.Contains("Dynamite")){
				tunrOffCrates("a");
				turnOffBushes("off");
				turnOffPaths("off");
				knightDropBtn.gameObject.SetActive(false);
			}
		}
		else {
			turnOffBtns("off");
			mbtn1.gameObject.SetActive(false);
			mbtn2.gameObject.SetActive(false);
			mbtn3.gameObject.SetActive(false);
			mbtn4.gameObject.SetActive(false);
			
			s1selected.gameObject.SetActive(false);
			s2selected.gameObject.SetActive(false);
			s3selected.gameObject.SetActive(false);
			s4selected.gameObject.SetActive(false);
			s5selected.gameObject.SetActive(false);
			s6selected.gameObject.SetActive(false);
			s7selected.gameObject.SetActive(false);
			s8selected.gameObject.SetActive(false);
			turnOffBushes("off");
			turnOffPaths("off");
			tunrOffCrates("off");
			knightDropBtn.gameObject.SetActive(false);
		}

		if(soldierBtnPressed!=null){
			if(soldierBtnPressed.SoldierObject.Length  == 6){
				for (int i = 0; i < 36; i++)
				{
						if(stonesList[i].GetComponent<Collider2D>().tag.Contains("Full"))
						{
							if(i==0)
								btn1.gameObject.SetActive(false);
							else if(i==1)
								btn2.gameObject.SetActive(false);
							else if(i==2)
								btn3.gameObject.SetActive(false);
							else if(i==3)
								btn4.gameObject.SetActive(false);
							else if(i==4)
								btn5.gameObject.SetActive(false);
							else if(i==5)
								btn6.gameObject.SetActive(false);
							else if(i==6)
								btn7.gameObject.SetActive(false);
							else if(i==7)
								btn8.gameObject.SetActive(false);
							else if(i==8)
								btn9.gameObject.SetActive(false);
							else if(i==9)
								btn10.gameObject.SetActive(false);
							else if(i==10)
								btn11.gameObject.SetActive(false);
							else if(i==11)
								btn12.gameObject.SetActive(false);
							else if(i==12)
								btn13.gameObject.SetActive(false);
							else if(i==13)
								btn14.gameObject.SetActive(false);
							else if(i==14)
								btn15.gameObject.SetActive(false);
							else if(i==15)
								btn16.gameObject.SetActive(false);
							else if(i==16)
								btn17.gameObject.SetActive(false);
							else if(i==17)
								btn18.gameObject.SetActive(false);
							else if(i==18)
								btn19.gameObject.SetActive(false);
							else if(i==19)
								btn20.gameObject.SetActive(false);
							else if(i==20)
								btn21.gameObject.SetActive(false);
							else if(i==21)
								btn22.gameObject.SetActive(false);
							else if(i==22)
								btn23.gameObject.SetActive(false);
							else if(i==23)
								btn24.gameObject.SetActive(false);
							else if(i==24)
								btn25.gameObject.SetActive(false);
							else if(i==25)
								btn26.gameObject.SetActive(false);
							else if(i==26)
								btn27.gameObject.SetActive(false);
							else if(i==27)
								btn28.gameObject.SetActive(false);
							else if(i==28)
								btn29.gameObject.SetActive(false);
							else if(i==29)
								btn30.gameObject.SetActive(false);
							else if(i==30)
								btn31.gameObject.SetActive(false);
							else if(i==31)
								btn32.gameObject.SetActive(false);
							else if(i==32)
								btn33.gameObject.SetActive(false);
							else if(i==33)
								btn34.gameObject.SetActive(false);
							else if(i==34)
								btn35.gameObject.SetActive(false);
							else if(i==35)
								btn36.gameObject.SetActive(false);
						}
						else{
							if(i==0)
								btn1.gameObject.SetActive(true);
							else if(i==1)
								btn2.gameObject.SetActive(true);
							else if(i==2)
								btn3.gameObject.SetActive(true);
							else if(i==3)
								btn4.gameObject.SetActive(true);
							else if(i==4)
								btn5.gameObject.SetActive(true);
							else if(i==5)
								btn6.gameObject.SetActive(true);
							else if(i==6)
								btn7.gameObject.SetActive(true);
							else if(i==7)
								btn8.gameObject.SetActive(true);
							else if(i==8)
								btn9.gameObject.SetActive(true);
							else if(i==9)
								btn10.gameObject.SetActive(true);
							else if(i==10)
								btn11.gameObject.SetActive(true);
							else if(i==11)
								btn12.gameObject.SetActive(true);
							else if(i==12)
								btn13.gameObject.SetActive(true);
							else if(i==13)
								btn14.gameObject.SetActive(true);
							else if(i==14)
								btn15.gameObject.SetActive(true);
							else if(i==15)
								btn16.gameObject.SetActive(true);
							else if(i==16)
								btn17.gameObject.SetActive(true);
							else if(i==17)
								btn18.gameObject.SetActive(true);
							else if(i==18)
								btn19.gameObject.SetActive(true);
							else if(i==19)
								btn20.gameObject.SetActive(true);
							else if(i==20)
								btn21.gameObject.SetActive(true);
							else if(i==21)
								btn22.gameObject.SetActive(true);
							else if(i==22)
								btn23.gameObject.SetActive(true);
							else if(i==23)
								btn24.gameObject.SetActive(true);
							else if(i==24)
								btn25.gameObject.SetActive(true);
							else if(i==25)
								btn26.gameObject.SetActive(true);
							else if(i==26)
								btn27.gameObject.SetActive(true);
							else if(i==27)
								btn28.gameObject.SetActive(true);
							else if(i==28)
								btn29.gameObject.SetActive(true);
							else if(i==29)
								btn30.gameObject.SetActive(true);
							else if(i==30)
								btn31.gameObject.SetActive(true);
							else if(i==31)
								btn32.gameObject.SetActive(true);
							else if(i==32)
								btn33.gameObject.SetActive(true);
							else if(i==33)
								btn34.gameObject.SetActive(true);
							else if(i==34)
								btn35.gameObject.SetActive(true);
							else if(i==35)
								btn36.gameObject.SetActive(true);
						}
				}
			}
			else if(soldierBtnPressed.SoldierObject.Length  == 4){
				for (int i = 0; i < 4; i++)
				{
					if(mstoneList[i].GetComponent<Collider2D>().tag.Contains("Full"))
					{
						if(i==0)
							mbtn1.gameObject.SetActive(false);
						else if(i==1)
							mbtn2.gameObject.SetActive(false);
						else if(i==2)
							mbtn3.gameObject.SetActive(false);
						else if(i==3)
							mbtn4.gameObject.SetActive(false);
					}
					else{
						if(i==0)
							mbtn1.gameObject.SetActive(true);
						else if(i==1)
							mbtn2.gameObject.SetActive(true);
						else if(i==2)
							mbtn3.gameObject.SetActive(true);
						else if(i==3)
							mbtn4.gameObject.SetActive(true);
					}
				}
			}
		}
	}


	public void turnOffBtns(string s)
	{
		if(s=="off"){
			btn1.gameObject.SetActive(false);
			btn2.gameObject.SetActive(false);
			btn3.gameObject.SetActive(false);
			btn4.gameObject.SetActive(false);
			btn5.gameObject.SetActive(false);
			btn6.gameObject.SetActive(false);
			btn7.gameObject.SetActive(false);
			btn8.gameObject.SetActive(false);
			btn9.gameObject.SetActive(false);
			btn10.gameObject.SetActive(false);
			btn11.gameObject.SetActive(false);
			btn12.gameObject.SetActive(false);
			btn13.gameObject.SetActive(false);
			btn14.gameObject.SetActive(false);
			btn15.gameObject.SetActive(false);
			btn16.gameObject.SetActive(false);
			btn17.gameObject.SetActive(false);
			btn18.gameObject.SetActive(false);
			btn19.gameObject.SetActive(false);
			btn20.gameObject.SetActive(false);
			btn21.gameObject.SetActive(false);
			btn22.gameObject.SetActive(false);
			btn23.gameObject.SetActive(false);
			btn24.gameObject.SetActive(false);
			btn25.gameObject.SetActive(false);
			btn26.gameObject.SetActive(false);
			btn27.gameObject.SetActive(false);
			btn28.gameObject.SetActive(false);
			btn29.gameObject.SetActive(false);
			btn30.gameObject.SetActive(false);
			btn31.gameObject.SetActive(false);
			btn32.gameObject.SetActive(false);
			btn33.gameObject.SetActive(false);
			btn34.gameObject.SetActive(false);
			btn35.gameObject.SetActive(false);
			btn36.gameObject.SetActive(false);
		}
		else{
			btn1.gameObject.SetActive(true);
			btn2.gameObject.SetActive(true);
			btn3.gameObject.SetActive(true);
			btn4.gameObject.SetActive(true);
			btn5.gameObject.SetActive(true);
			btn6.gameObject.SetActive(true);
			btn7.gameObject.SetActive(true);
			btn8.gameObject.SetActive(true);
			btn9.gameObject.SetActive(true);
			btn10.gameObject.SetActive(true);
			btn11.gameObject.SetActive(true);
			btn12.gameObject.SetActive(true);
			btn13.gameObject.SetActive(true);
			btn14.gameObject.SetActive(true);
			btn15.gameObject.SetActive(true);
			btn16.gameObject.SetActive(true);
			btn17.gameObject.SetActive(true);
			btn18.gameObject.SetActive(true);
			btn19.gameObject.SetActive(true);
			btn20.gameObject.SetActive(true);
			btn21.gameObject.SetActive(true);
			btn22.gameObject.SetActive(true);
			btn23.gameObject.SetActive(true);
			btn24.gameObject.SetActive(true);
			btn25.gameObject.SetActive(true);
			btn26.gameObject.SetActive(true);
			btn27.gameObject.SetActive(true);
			btn28.gameObject.SetActive(true);
			btn29.gameObject.SetActive(true);
			btn30.gameObject.SetActive(true);
			btn31.gameObject.SetActive(true);
			btn32.gameObject.SetActive(true);
			btn33.gameObject.SetActive(true);
			btn34.gameObject.SetActive(true);
			btn35.gameObject.SetActive(true);
			btn36.gameObject.SetActive(true);
		}
	}

	public void turnOffPaths(string s)
	{
		if(s=="off"){
			path1.gameObject.SetActive(false);
			path2.gameObject.SetActive(false);
			path3.gameObject.SetActive(false);
			path4.gameObject.SetActive(false);
			path5.gameObject.SetActive(false);
			path6.gameObject.SetActive(false);
		}
		else{
			path1.gameObject.SetActive(true);
			path2.gameObject.SetActive(true);
			path3.gameObject.SetActive(true);
			path4.gameObject.SetActive(true);
			path5.gameObject.SetActive(true);
			path6.gameObject.SetActive(true);
		}
	}

	public void turnOffBushes(string s)
	{	if(s=="off"){
			bush1.gameObject.SetActive(false);
			bush2.gameObject.SetActive(false);
			bush3.gameObject.SetActive(false);
			bush4.gameObject.SetActive(false);
			bush5.gameObject.SetActive(false);
			bush6.gameObject.SetActive(false);
		}
		else {
			bush1.gameObject.SetActive(true);
			bush2.gameObject.SetActive(true);
			bush3.gameObject.SetActive(true);
			bush4.gameObject.SetActive(true);
			bush5.gameObject.SetActive(true);
			bush6.gameObject.SetActive(true);
		}
	}

	public void tunrOffCrates(string s)
	{
		if(s=="off"){
			crate1.gameObject.SetActive(false);
			crate2.gameObject.SetActive(false);
			crate3.gameObject.SetActive(false);
			crate4.gameObject.SetActive(false);
		}
		else {
			crate1.gameObject.SetActive(true);
			crate2.gameObject.SetActive(true);
			crate3.gameObject.SetActive(true);
			crate4.gameObject.SetActive(true);
		}
	}



	[SerializeField]
	private GameObject s1selected;
	[SerializeField]
	private GameObject s2selected;
	[SerializeField]
	private GameObject s3selected;
	[SerializeField]
	private GameObject s4selected;
	[SerializeField]
	private GameObject s5selected;
	[SerializeField]
	private GameObject s6selected;
	[SerializeField]
	private GameObject s7selected;
	[SerializeField]
	private GameObject s8selected;

	[SerializeField]
	private Image angel;
	[SerializeField]
	private Text angelText;
	private Animator angelAnim;

	[SerializeField]
	private Image greenBtnPointer;

	public void selectedsoldier(SoldierBtn soldierSelected){
		groundRaycast.SetActive(false);
		bombBtnPressed = null;
		float energyNeeded=0;
		if(soldierSelected.SoldierObject[0].name.Contains("Soldier1")){
			energyNeeded = energyS1.MaxVal;
			if(PlayerPrefs.GetInt("introduction")==0)
			{
				//angelAnim.SetTrigger("next2");
				angelText.text = "Tap on any position on 6 different paths, preferably near the house!";
				soldListPointer.gameObject.SetActive(false);
			}
		}
		else if(soldierSelected.SoldierObject[0].name.Contains("Soldier2"))
			energyNeeded = energyS2.MaxVal;
		else if(soldierSelected.SoldierObject[0].name.Contains("Soldier3"))
			energyNeeded = energyS3.MaxVal;
		else if(soldierSelected.SoldierObject[0].name.Contains("Soldier4"))
			energyNeeded = energyS4.MaxVal;
		else if(soldierSelected.SoldierObject[0].name.Contains("Soldier5"))
			energyNeeded = energyS5.MaxVal;
		else if(soldierSelected.SoldierObject[0].name.Contains("Soldier6"))
			energyNeeded = energyS6.MaxVal;
		else if(soldierSelected.SoldierObject[0].name.Contains("Soldier7"))
			energyNeeded = energyS7.MaxVal;
		else if(soldierSelected.SoldierObject[0].name.Contains("Soldier8"))
			energyNeeded = energyS8.MaxVal;

		if (mainEnergy.CurrentVal >= energyNeeded)//!!!CHANGE SO LETS USE SOLDIER ONLY HAVE ENOUGH ENERGY FOR CORRESPONDING SOLDIER!!!!!!
		{	
			if(soldierSelected.SoldierObject[0].name.Contains("Soldier1") && energyS1.CurrentVal==energyS1.MaxVal)
			{	GameManager.Instance.AudioSource.PlayOneShot(SoundManager.Instance.Click3);
				soldierBtnPressed = soldierSelected;
			}
			else if(soldierSelected.SoldierObject[0].name.Contains("Soldier1") && energyS1.CurrentVal!=energyS1.MaxVal)
				GameManager.Instance.AudioSource.PlayOneShot(SoundManager.Instance.Click7);

			if(soldierSelected.SoldierObject[0].name.Contains("Soldier2") && energyS2.CurrentVal==energyS2.MaxVal)
			{	GameManager.Instance.AudioSource.PlayOneShot(SoundManager.Instance.Click3);
				soldierBtnPressed = soldierSelected;
			}
			else if(soldierSelected.SoldierObject[0].name.Contains("Soldier2") && energyS2.CurrentVal!=energyS2.MaxVal)
				GameManager.Instance.AudioSource.PlayOneShot(SoundManager.Instance.Click7);

			if(soldierSelected.SoldierObject[0].name.Contains("Soldier3") && energyS3.CurrentVal==energyS3.MaxVal)
			{	GameManager.Instance.AudioSource.PlayOneShot(SoundManager.Instance.Click3);
				soldierBtnPressed = soldierSelected;
			}
			else if(soldierSelected.SoldierObject[0].name.Contains("Soldier3") && energyS3.CurrentVal!=energyS3.MaxVal)
				GameManager.Instance.AudioSource.PlayOneShot(SoundManager.Instance.Click7);

			if(soldierSelected.SoldierObject[0].name.Contains("Soldier4") && energyS4.CurrentVal==energyS4.MaxVal)
			{	GameManager.Instance.AudioSource.PlayOneShot(SoundManager.Instance.Click3);
				soldierBtnPressed = soldierSelected;
			}
			else if(soldierSelected.SoldierObject[0].name.Contains("Soldier4") && energyS4.CurrentVal!=energyS4.MaxVal)
				GameManager.Instance.AudioSource.PlayOneShot(SoundManager.Instance.Click7);

			if(soldierSelected.SoldierObject[0].name.Contains("Soldier5") && energyS5.CurrentVal==energyS5.MaxVal){
				GameManager.Instance.AudioSource.PlayOneShot(SoundManager.Instance.Click3);
				soldierBtnPressed = soldierSelected;
				if(PlayerPrefs.GetInt("mercIntro")==1)
				{
					mercIntroAnim.SetTrigger("next1");
					mercIntroText.text = "Place him on one of the 4 positions!";
					mercIntroPointers.gameObject.SetActive(true);
					Invoke("idle2",0.8f);
				}
			}
			else if(soldierSelected.SoldierObject[0].name.Contains("Soldier5") && energyS5.CurrentVal!=energyS5.MaxVal)
				GameManager.Instance.AudioSource.PlayOneShot(SoundManager.Instance.Click7);

			if(soldierSelected.SoldierObject[0].name.Contains("Soldier6") && energyS6.CurrentVal==energyS6.MaxVal){
				GameManager.Instance.AudioSource.PlayOneShot(SoundManager.Instance.Click3);
				soldierBtnPressed = soldierSelected;
			
			}
			else if(soldierSelected.SoldierObject[0].name.Contains("Soldier6") && energyS6.CurrentVal!=energyS6.MaxVal)
				GameManager.Instance.AudioSource.PlayOneShot(SoundManager.Instance.Click7);

			if(soldierSelected.SoldierObject[0].name.Contains("Soldier7") && energyS7.CurrentVal==energyS7.MaxVal){
				GameManager.Instance.AudioSource.PlayOneShot(SoundManager.Instance.Click3);
				soldierBtnPressed = soldierSelected;
			
			}
			else if(soldierSelected.SoldierObject[0].name.Contains("Soldier7") && energyS7.CurrentVal!=energyS7.MaxVal)
				GameManager.Instance.AudioSource.PlayOneShot(SoundManager.Instance.Click7);
			if(soldierSelected.SoldierObject[0].name.Contains("Soldier8") && energyS8.CurrentVal==energyS8.MaxVal){
				GameManager.Instance.AudioSource.PlayOneShot(SoundManager.Instance.Click3);
				soldierBtnPressed = soldierSelected;
			
			}
			else if(soldierSelected.SoldierObject[0].name.Contains("Soldier8") && energyS8.CurrentVal!=energyS8.MaxVal)
				GameManager.Instance.AudioSource.PlayOneShot(SoundManager.Instance.Click7);
		}
		else {
			GameManager.Instance.AudioSource.PlayOneShot(SoundManager.Instance.Click7);
		}
		//}
		//else{
		//	soldierBtnPressed = null;
		//}
		
	}

	public void idle2()
	{
		mercIntroAnim.SetTrigger("idle1");
	}
	[SerializeField]
	private Button bush1;
	[SerializeField]
	private Button bush2;
	[SerializeField]
	private Button bush3;
	[SerializeField]
	private Button bush4;
	[SerializeField]
	private Button bush5;
	[SerializeField]
	private Button bush6;

	[SerializeField]
	private Button path1;
	[SerializeField]
	private Button path2;
	[SerializeField]
	private Button path3;
	[SerializeField]
	private Button path4;
	[SerializeField]
	private Button path5;
	[SerializeField]
	private Button path6;

	[SerializeField]
	private Button crate1;
	[SerializeField]
	private Button crate2;
	[SerializeField]
	private Button crate3;
	[SerializeField]
	private Button crate4;

	[SerializeField]
	private Button knightDropBtn;

	IEnumerator addToList(){
		Soldier newS = Instantiate(Sold1) as Soldier;
		newS.transform.position = stone.transform.position;
		yield return new WaitForSeconds(1f);
		SoldierListLeft.Add(newS);
	}
	public void selectedBomb(SoldierBtn bombSelected){
		soldierBtnPressed = null;
		if(bombSelected.BombObject.name=="DestroyAllBomb"){
			if(!groundRaycast.activeSelf){
				groundRaycast.SetActive(true);
			}
			if (numOfDestroyAllBomb > 0)
			{	
				GameManager.Instance.AudioSource.PlayOneShot(SoundManager.Instance.Click3);
				bombBtnPressed = bombSelected;			
			}
			else{
				GameManager.Instance.AudioSource.PlayOneShot(SoundManager.Instance.Click7);
				youDontHaveThisItemShop.SetActive(true);
			}
		}
		else if(bombSelected.BombObject.name == "BombPumpk"){
			groundRaycast.SetActive(false);
			if (numOfPumpkins > 0)
			{	
				if(PlayerPrefs.GetInt("sniperIntro")==1)
				{
					sniperIntroAnim.SetTrigger("2");
					PlayerPrefs.SetInt("sniperIntro",2);
					sniperIntroText.text = "";
					Invoke("ch",0.6f);
					StartCoroutine(addToList());
				}
				GameManager.Instance.AudioSource.PlayOneShot(SoundManager.Instance.Click3);
				bombBtnPressed = bombSelected;			
			}
			else{
				GameManager.Instance.AudioSource.PlayOneShot(SoundManager.Instance.Click7);
				youDontHaveThisItemShop.SetActive(true);
			}
		}
		
		
	}

	public void ch()
	{
		sniperIntroText.text = "Drop on the sniper or he will kill your soldier!";
	}

	[SerializeField]
	private Soldier Sold1;
	private GameObject stone;
	

	[SerializeField]
	private Image sniperIntroSign;
	[SerializeField]
	private Text sniperIntroText;
	private Animator sniperIntroAnim;

	public void selectedOneRowBomb(SoldierBtn bombSelected){
		soldierBtnPressed = null;
		if (bombSelected.OneRowBombObject[0].name.Contains("DestroyOneRowBomb")){
			groundRaycast.SetActive(false);
			if(numOfOneRowBomb > 0){
				GameManager.Instance.AudioSource.PlayOneShot(SoundManager.Instance.Click3);
				bombBtnPressed = bombSelected;
			}
			else{
				GameManager.Instance.AudioSource.PlayOneShot(SoundManager.Instance.Click7);
				youDontHaveThisItemShop.SetActive(true);
			}
		}
		else if(bombSelected.OneRowBombObject[0].name.Contains("Dynamite")){
			groundRaycast.SetActive(false);
			if(numOfGranade > 0){
				GameManager.Instance.AudioSource.PlayOneShot(SoundManager.Instance.Click3);
				bombBtnPressed = bombSelected;
			}
			else{
				GameManager.Instance.AudioSource.PlayOneShot(SoundManager.Instance.Click7);
				youDontHaveThisItemShop.SetActive(true);
			}

		}
			
	}

	public void placeSoldier1(int n)
	{
		if(soldierBtnPressed!=null)
		{
			Soldier newSoldier = Instantiate(soldierBtnPressed.SoldierObject[0]) as Soldier;
			GameManager.Instance.AudioSource.PlayOneShot(SoundManager.Instance.Click9);
			if(soldierBtnPressed.SoldierObject[0].name.Contains("Soldier1"))
			{
				energyS1.CurrentVal-= energyS1.MaxVal;
				mainEnergy.CurrentVal-= energyS1.MaxVal;
				currentS1Energy -= energyS1.MaxVal;
			}
			else if (soldierBtnPressed.SoldierObject[0].name.Contains("Soldier2"))
			{
				energyS2.CurrentVal-= energyS2.MaxVal;
				mainEnergy.CurrentVal-= energyS2.MaxVal;
				currentS2Energy -= energyS2.MaxVal;
			}
			else if (soldierBtnPressed.SoldierObject[0].name.Contains("Soldier3")){
				energyS3.CurrentVal-= energyS3.MaxVal;
				mainEnergy.CurrentVal-= energyS3.MaxVal;
				currentS3Energy -= energyS3.MaxVal;
			}
			else if (soldierBtnPressed.SoldierObject[0].name.Contains("Soldier4")){
				energyS4.CurrentVal-= energyS4.MaxVal;
				mainEnergy.CurrentVal-= energyS4.MaxVal;
				currentS4Energy -= energyS4.MaxVal;
			}
			
			SoldierListLeft.Add(newSoldier);
			if(n==1)
			{
				newSoldier.transform.position = Left1.transform.position;
				l1.tag = "PathStraightLeftFull";
			}
			else if(n==2){
				newSoldier.transform.position = Left2.transform.position;
				l2.tag = "PathStraightLeftFull";
			}
			else if(n==3){
				newSoldier.transform.position = Left3.transform.position;
				l3.tag = "PathStraightLeftFull";
			}
			else if(n==4){
				newSoldier.transform.position = Left4.transform.position;
				l4.tag = "PathStraightLeftFull";
			}
			else if(n==5){
				newSoldier.transform.position = Left5.transform.position;
				l5.tag = "PathStraightLeftFull";
			}
			else if(n==6){
				newSoldier.transform.position = Left6.transform.position;
				l6.tag = "PathStraightLeftFull";
			}
			soldierBtnPressed = null;
			if(PlayerPrefs.GetInt("introduction")==0)
			{
				PlayerPrefs.SetInt("introduction",1);
				angelText.text = "Nice work! Also remember that soldiers have the ability to shoot backwards.";
				Enemy newE = Instantiate(enemy1) as Enemy;
				newE.transform.position = Left6.transform.position;
				GameManager.Instance.EnemyListLeft.Add(newE);
				GameManager.Instance.renameStones();
				StartCoroutine(destroyBloch(newE));
				Invoke("lateShowMenu",7.5f);
				Invoke("closeEverything",7.5f);
			}
		}
	}
	IEnumerator destroyBloch(Enemy e)
	{
		yield return new WaitForSeconds(7.5f);
		if(e!=null)
			Destroy(e.gameObject);
	}
	[SerializeField]
	private Image soldListPointer;
	[SerializeField]
	private Image energyPointer;


	public void closeEverything(){
		angel.gameObject.SetActive(false);
	}		
	

	public void placeSoldier2(int n)
	{
		if(soldierBtnPressed!=null)
		{
			Soldier newSoldier = Instantiate(soldierBtnPressed.SoldierObject[1]) as Soldier;
			GameManager.Instance.AudioSource.PlayOneShot(SoundManager.Instance.Click9);
			if(soldierBtnPressed.SoldierObject[1].name.Contains("Soldier1"))
			{
				energyS1.CurrentVal-= energyS1.MaxVal;
				mainEnergy.CurrentVal-= energyS1.MaxVal;
				currentS1Energy -= energyS1.MaxVal;
			}
			else if (soldierBtnPressed.SoldierObject[1].name.Contains("Soldier2"))
			{
				energyS2.CurrentVal-= energyS2.MaxVal;
				mainEnergy.CurrentVal-= energyS2.MaxVal;
				currentS2Energy -= energyS2.MaxVal;
			}
			else if (soldierBtnPressed.SoldierObject[1].name.Contains("Soldier3")){
				energyS3.CurrentVal-= energyS3.MaxVal;
				mainEnergy.CurrentVal-= energyS3.MaxVal;
				currentS3Energy -= energyS3.MaxVal;
			}
			else if (soldierBtnPressed.SoldierObject[1].name.Contains("Soldier4")){
				energyS4.CurrentVal-= energyS4.MaxVal;
				mainEnergy.CurrentVal-= energyS4.MaxVal;
				currentS4Energy -= energyS4.MaxVal;
			}

			
			SoldierListButtomLeft.Add(newSoldier);
			if(n==1)
			{
				newSoldier.transform.position = LeftB1.transform.position;
				lB1.tag = "PathButtomLeftFull";
			}
			else if(n==2){
				newSoldier.transform.position = LeftB2.transform.position;
				lB2.tag = "PathButtomLeftFull";
			}
			else if(n==3){
				newSoldier.transform.position = LeftB3.transform.position;
				lB3.tag = "PathButtomLeftFull";
			}
			else if(n==4){
				newSoldier.transform.position = LeftB4.transform.position;
				lB4.tag = "PathButtomLeftFull";
			}
			else if(n==5){
				newSoldier.transform.position = LeftB5.transform.position;
				lB5.tag = "PathButtomLeftFull";
			}
			else if(n==6){
				newSoldier.transform.position = LeftB6.transform.position;
				lB6.tag = "PathButtomLeftFull";
			}
			soldierBtnPressed = null;
			if(PlayerPrefs.GetInt("introduction")==0)
			{
				PlayerPrefs.SetInt("introduction",1);
				angelText.text = "Nice work! Also remember that soldiers have the ability to shoot backwards.";
				Enemy newE = Instantiate(enemy3) as Enemy;
				newE.transform.position = LeftB6.transform.position;
				GameManager.Instance.EnemyListButtomLeft.Add(newE);
				GameManager.Instance.renameStones();
				StartCoroutine(destroyBloch(newE));
				Invoke("lateShowMenu",7.5f);
				Invoke("closeEverything",7.5f);
			}
		}
	}

	public void placeSoldier3(int n)
	{
		if(soldierBtnPressed!=null)
		{
			Soldier newSoldier = Instantiate(soldierBtnPressed.SoldierObject[2]) as Soldier;
			GameManager.Instance.AudioSource.PlayOneShot(SoundManager.Instance.Click9);
			if(soldierBtnPressed.SoldierObject[2].name.Contains("Soldier1"))
			{
				energyS1.CurrentVal-= energyS1.MaxVal;
				mainEnergy.CurrentVal-= energyS1.MaxVal;
				currentS1Energy -= energyS1.MaxVal;
			}
			else if (soldierBtnPressed.SoldierObject[2].name.Contains("Soldier2"))
			{
				energyS2.CurrentVal-= energyS2.MaxVal;
				mainEnergy.CurrentVal-= energyS2.MaxVal;
				currentS2Energy -= energyS2.MaxVal;
			}
			else if (soldierBtnPressed.SoldierObject[2].name.Contains("Soldier3")){
				energyS3.CurrentVal-= energyS3.MaxVal;
				mainEnergy.CurrentVal-= energyS3.MaxVal;
				currentS3Energy -= energyS3.MaxVal;
			}
			else if (soldierBtnPressed.SoldierObject[2].name.Contains("Soldier4")){
				energyS4.CurrentVal-= energyS4.MaxVal;
				mainEnergy.CurrentVal-= energyS4.MaxVal;
				currentS4Energy -= energyS4.MaxVal;
			}
			
			SoldierListUpLeft.Add(newSoldier);
			if(n==1)
			{
				newSoldier.transform.position = LeftUp1.transform.position;
				lU1.tag = "PathUpLeftFull";
			}
			else if(n==2){
				newSoldier.transform.position = LeftUp2.transform.position;
				lU2.tag = "PathUpLeftFull";
			}
			else if(n==3){
				newSoldier.transform.position = LeftUp3.transform.position;
				lU3.tag = "PathUpLeftFull";
			}
			else if(n==4){
				newSoldier.transform.position = LeftUp4.transform.position;
				lU4.tag = "PathUpLeftFull";
			}
			else if(n==5){
				newSoldier.transform.position = LeftUp5.transform.position;
				lU5.tag = "PathUpLeftFull";
			}
			else if(n==6){
				newSoldier.transform.position = LeftUp6.transform.position;
				lU6.tag = "PathUpLeftFull";
			}
			soldierBtnPressed = null;
			if(PlayerPrefs.GetInt("introduction")==0)
			{
				PlayerPrefs.SetInt("introduction",1);
				angelText.text = "Nice work! Also remember that soldiers have the ability to shoot backwards.";
				Enemy newE = Instantiate(enemy2) as Enemy;
				newE.transform.position = LeftUp6.transform.position;
				GameManager.Instance.EnemyListUpLeft.Add(newE);
				GameManager.Instance.renameStones();
				StartCoroutine(destroyBloch(newE));
				Invoke("lateShowMenu",7.5f);
				Invoke("closeEverything",7.5f);
			}
		}
	}

	public void placeSoldier4(int n)
	{
		if(soldierBtnPressed!=null)
		{
			Soldier newSoldier = Instantiate(soldierBtnPressed.SoldierObject[3]) as Soldier;
			GameManager.Instance.AudioSource.PlayOneShot(SoundManager.Instance.Click9);
			if(soldierBtnPressed.SoldierObject[3].name.Contains("Soldier1"))
			{
				energyS1.CurrentVal-= energyS1.MaxVal;
				mainEnergy.CurrentVal-= energyS1.MaxVal;
				currentS1Energy -= energyS1.MaxVal;
			}
			else if (soldierBtnPressed.SoldierObject[3].name.Contains("Soldier2"))
			{
				energyS2.CurrentVal-= energyS2.MaxVal;
				mainEnergy.CurrentVal-= energyS2.MaxVal;
				currentS2Energy -= energyS2.MaxVal;
			}
			else if (soldierBtnPressed.SoldierObject[3].name.Contains("Soldier3")){
				energyS3.CurrentVal-= energyS3.MaxVal;
				mainEnergy.CurrentVal-= energyS3.MaxVal;
				currentS3Energy -= energyS3.MaxVal;
			}
			else if (soldierBtnPressed.SoldierObject[3].name.Contains("Soldier4")){
				energyS4.CurrentVal-= energyS4.MaxVal;
				mainEnergy.CurrentVal-= energyS4.MaxVal;
				currentS4Energy -= energyS4.MaxVal;
			}

			
			SoldierListRight.Add(newSoldier);
			if(n==1)
			{
				newSoldier.transform.position = Right1.transform.position;
				R1.tag = "PathStraightRightFull";
			}
			else if(n==2){
				newSoldier.transform.position = Right2.transform.position;
				R2.tag = "PathStraightRightFull";
			}
			else if(n==3){
				newSoldier.transform.position = Right3.transform.position;
				R3.tag = "PathStraightRightFull";
			}
			else if(n==4){
				newSoldier.transform.position = Right4.transform.position;
				R4.tag = "PathStraightRightFull";
			}
			else if(n==5){
				newSoldier.transform.position = Right5.transform.position;
				R5.tag = "PathStraightRightFull";
			}
			else if(n==6){
				newSoldier.transform.position = Right6.transform.position;
				R6.tag = "PathStraightRightFull";
			}
			soldierBtnPressed = null;
			if(PlayerPrefs.GetInt("introduction")==0)
			{
				PlayerPrefs.SetInt("introduction",1);
				angelText.text = "Nice work! Also remember that soldiers have the ability to shoot backwards.";
				Enemy newE = Instantiate(enemy4) as Enemy;
				newE.transform.position = Right6.transform.position;
				GameManager.Instance.EnemyListRight.Add(newE);
				GameManager.Instance.renameStones();
				StartCoroutine(destroyBloch(newE));
				Invoke("lateShowMenu",7.5f);
				Invoke("closeEverything",7.5f);
			}
		}
	}

	public void placeSoldier5(int n)
	{
		if(soldierBtnPressed!=null)
		{
			Soldier newSoldier = Instantiate(soldierBtnPressed.SoldierObject[4]) as Soldier;
			GameManager.Instance.AudioSource.PlayOneShot(SoundManager.Instance.Click9);
			if(soldierBtnPressed.SoldierObject[4].name.Contains("Soldier1"))
			{
				energyS1.CurrentVal-= energyS1.MaxVal;
				mainEnergy.CurrentVal-= energyS1.MaxVal;
				currentS1Energy -= energyS1.MaxVal;
			}
			else if (soldierBtnPressed.SoldierObject[4].name.Contains("Soldier2"))
			{
				energyS2.CurrentVal-= energyS2.MaxVal;
				mainEnergy.CurrentVal-= energyS2.MaxVal;
				currentS2Energy -= energyS2.MaxVal;
			}
			else if (soldierBtnPressed.SoldierObject[4].name.Contains("Soldier3")){
				energyS3.CurrentVal-= energyS3.MaxVal;
				mainEnergy.CurrentVal-= energyS3.MaxVal;
				currentS3Energy -= energyS3.MaxVal;
			}
			else if (soldierBtnPressed.SoldierObject[4].name.Contains("Soldier4")){
				energyS4.CurrentVal-= energyS4.MaxVal;
				mainEnergy.CurrentVal-= energyS4.MaxVal;
				currentS4Energy -= energyS4.MaxVal;
			}

			
			SoldierListButtomRight.Add(newSoldier);
			if(n==1)
			{
				newSoldier.transform.position = RightB1.transform.position;
				RB1.tag = "PathButtomRightFull";
			}
			else if(n==2){
				newSoldier.transform.position = RightB2.transform.position;
				RB2.tag = "PathButtomRightFull";
			}
			else if(n==3){
				newSoldier.transform.position = RightB3.transform.position;
				RB3.tag = "PathButtomRightFull";
			}
			else if(n==4){
				newSoldier.transform.position = RightB4.transform.position;
				RB4.tag = "PathButtomRightFull";
			}
			else if(n==5){
				newSoldier.transform.position = RightB5.transform.position;
				RB5.tag = "PathButtomRightFull";
			}
			else if(n==6){
				newSoldier.transform.position = RightB6.transform.position;
				RB6.tag = "PathButtomRightFull";
			}
			soldierBtnPressed = null;
			if(PlayerPrefs.GetInt("introduction")==0)
			{
				PlayerPrefs.SetInt("introduction",1);
				angelText.text = "Nice work! Also remember that soldiers have the ability to shoot backwards.";
				Enemy newE = Instantiate(enemy6) as Enemy;
				newE.transform.position = RightB6.transform.position;
				GameManager.Instance.EnemyListButtomRight.Add(newE);
				GameManager.Instance.renameStones();
				StartCoroutine(destroyBloch(newE));
				Invoke("lateShowMenu",7.5f);
				Invoke("closeEverything",7.5f);
			}
		}
	}

	public void placeSoldier6(int n)
	{
		if(soldierBtnPressed!=null)
		{
			Soldier newSoldier = Instantiate(soldierBtnPressed.SoldierObject[5]) as Soldier;
			GameManager.Instance.AudioSource.PlayOneShot(SoundManager.Instance.Click9);
			if(soldierBtnPressed.SoldierObject[5].name.Contains("Soldier1"))
			{
				energyS1.CurrentVal-= energyS1.MaxVal;
				mainEnergy.CurrentVal-= energyS1.MaxVal;
				currentS1Energy -= energyS1.MaxVal;
			}
			else if (soldierBtnPressed.SoldierObject[5].name.Contains("Soldier2"))
			{
				energyS2.CurrentVal-= energyS2.MaxVal;
				mainEnergy.CurrentVal-= energyS2.MaxVal;
				currentS2Energy -= energyS2.MaxVal;
			}
			else if (soldierBtnPressed.SoldierObject[5].name.Contains("Soldier3")){
				energyS3.CurrentVal-= energyS3.MaxVal;
				mainEnergy.CurrentVal-= energyS3.MaxVal;
				currentS3Energy -= energyS3.MaxVal;
			}
			else if (soldierBtnPressed.SoldierObject[5].name.Contains("Soldier4")){
				energyS4.CurrentVal-= energyS4.MaxVal;
				mainEnergy.CurrentVal-= energyS4.MaxVal;
				currentS4Energy -= energyS4.MaxVal;
			}

			
			SoldierListUpRight.Add(newSoldier);
			if(n==1)
			{
				newSoldier.transform.position = RightUp1.transform.position;
				RU1.tag = "PathUpRightFull";
			}
			else if(n==2){
				newSoldier.transform.position = RightUp2.transform.position;
				RU2.tag = "PathUpRightFull";
			}
			else if(n==3){
				newSoldier.transform.position = RightUp3.transform.position;
				RU3.tag = "PathUpRightFull";
			}
			else if(n==4){
				newSoldier.transform.position = RightUp4.transform.position;
				RU4.tag = "PathUpRightFull";
			}
			else if(n==5){
				newSoldier.transform.position = RightUp5.transform.position;
				RU5.tag = "PathUpRightFull";
			}
			else if(n==6){
				newSoldier.transform.position = RightUp6.transform.position;
				RU6.tag = "PathUpRightFull";
			}
			soldierBtnPressed = null;
			if(PlayerPrefs.GetInt("introduction")==0)
			{
				PlayerPrefs.SetInt("introduction",1);
				angelText.text = "Nice work! Also remember that soldiers have the ability to shoot backwards.";
				Enemy newE = Instantiate(enemy5) as Enemy;
				newE.transform.position = RightUp6.transform.position;
				GameManager.Instance.EnemyListUpRight.Add(newE);
				GameManager.Instance.renameStones();
				StartCoroutine(destroyBloch(newE));
				Invoke("lateShowMenu",7.5f);
				Invoke("closeEverything",7.5f);
			}
		}
	}

	[SerializeField]
	private Image mercIntroPointer;

	public void placeSoldierAgainstMercenery(int i){
		if (soldierBtnPressed!=null ){
			GameManager.Instance.AudioSource.PlayOneShot(SoundManager.Instance.Click9);
			Soldier newSoldier = Instantiate(soldierBtnPressed.SoldierObject[i]) as Soldier;
			soldierAnim = newSoldier.gameObject.GetComponent<Animator>();
			doorAnim.SetTrigger("openDoor");
			doorAnim2.SetTrigger("openDoor");
			soldierAnim.Play("S5WalkShoot");
			if (soldierBtnPressed.SoldierObject[i].name.Contains("Soldier5"))
			{
				energyS5.CurrentVal-= energyS5.MaxVal;
				mainEnergy.CurrentVal-= energyS5.MaxVal;
				currentS5Energy -= energyS5.MaxVal;
			}
			else if(soldierBtnPressed.SoldierObject[i].name.Contains("Soldier6"))
			{	
				energyS6.CurrentVal-= energyS6.MaxVal;
				mainEnergy.CurrentVal-= energyS6.MaxVal;
				currentS6Energy -= energyS6.MaxVal;
			}
			else if(soldierBtnPressed.SoldierObject[i].name.Contains("Soldier7"))
			{	
				energyS7.CurrentVal-= energyS7.MaxVal;
				mainEnergy.CurrentVal-= energyS7.MaxVal;
				currentS7Energy -= energyS7.MaxVal;
			}
			else if(soldierBtnPressed.SoldierObject[i].name.Contains("Soldier8"))
			{	
				energyS8.CurrentVal-= energyS8.MaxVal;
				mainEnergy.CurrentVal-= energyS8.MaxVal;
				currentS8Energy -= energyS8.MaxVal;
			}
			newSoldier.transform.position = doorPos;
			
			if(i==0)
				{StartCoroutine(MoveS5678(newSoldier,S5678Spot1));
				SoldierMiddle1.Add(newSoldier);
				S56781.tag = "MiddlePath1Full";
				if(PlayerPrefs.GetInt("mercIntro")==1)
				{
					PlayerPrefs.SetInt("mercIntro",2);
					s1btn.enabled = true;
					s2btn.enabled = true;
					s3btn.enabled = true;
					s4btn.enabled = true;
					pbtn.enabled = true;
					sbtn.enabled = true;
					pGetMore.enabled = true;
					sGetMore.enabled = true;
					mercIntroPointer.gameObject.SetActive(false);
					mercIntroAnim.SetTrigger("next4");
					mercIntroText.text = "Each position has its own line of attack.";
					Invoke("changeText",4f);
					mercIntroPointers.gameObject.SetActive(false);
					Merc2 newM = Instantiate(merc) as Merc2;
					newM.transform.position = spawnPoint2.transform.position;
					GameManager.Instance.MerceneryList1.Add(newM);
					S56781.tag = "MiddlePath1";
				}
				}
			else if(i==1)
			{	StartCoroutine(MoveS5678(newSoldier,S5678Spot2));
				SoldierMiddle2.Add(newSoldier);
				S56782.tag = "MiddlePath2Full";
				if(PlayerPrefs.GetInt("mercIntro")==1)
				{
					PlayerPrefs.SetInt("mercIntro",2);
					s1btn.enabled = true;
					s2btn.enabled = true;
					s3btn.enabled = true;
					s4btn.enabled = true;
					pbtn.enabled = true;
					sbtn.enabled = true;
					pGetMore.enabled = true;
					sGetMore.enabled = true;
					mercIntroPointer.gameObject.SetActive(false);
					mercIntroAnim.SetTrigger("next4");
					mercIntroText.text = "Each position has its own line of attack.";
					Invoke("changeText",4f);
					mercIntroPointers.gameObject.SetActive(false);
					Merc2 newM = Instantiate(merc4) as Merc2;
					newM.transform.position = spawnPoint4.transform.position;
					GameManager.Instance.MerceneryList4.Add(newM);
					S56782.tag = "MiddlePath2";
				}
				}
			else if(i==2)
			{	StartCoroutine(MoveS5678(newSoldier,S5678Spot3));
				SoldierMiddle3.Add(newSoldier);
				S56783.tag = "MiddlePath3Full";
				if(PlayerPrefs.GetInt("mercIntro")==1)
				{
					PlayerPrefs.SetInt("mercIntro",2);
					s1btn.enabled = true;
					s2btn.enabled = true;
					s3btn.enabled = true;
					s4btn.enabled = true;
					pbtn.enabled = true;
					sbtn.enabled = true;
					pGetMore.enabled = true;
					sGetMore.enabled = true;
					mercIntroPointer.gameObject.SetActive(false);
					mercIntroAnim.SetTrigger("next4");
					mercIntroText.text = "Each position has its own line of attack.";
					Invoke("changeText",4f);
					mercIntroPointers.gameObject.SetActive(false);
					Merc2 newM = Instantiate(merc2) as Merc2;
					newM.transform.position = spawnPoint1.transform.position;
					GameManager.Instance.MerceneryList2.Add(newM);
					S56783.tag = "MiddlePath3";
				}
				}
			else if(i==3)
			{	StartCoroutine(MoveS5678(newSoldier,S5678Spot4));
				SoldierMiddle4.Add(newSoldier);
				S56784.tag = "MiddlePath4Full";
				if(PlayerPrefs.GetInt("mercIntro")==1)
				{
					PlayerPrefs.SetInt("mercIntro",2);
					s1btn.enabled = true;
					s2btn.enabled = true;
					s3btn.enabled = true;
					s4btn.enabled = true;
					pbtn.enabled = true;
					sbtn.enabled = true;
					pGetMore.enabled = true;
					sGetMore.enabled = true;
					mercIntroPointer.gameObject.SetActive(false);
					mercIntroAnim.SetTrigger("next4");
					mercIntroText.text = "Each position has its own line of attack.";
					Invoke("changeText",4f);
					mercIntroPointers.gameObject.SetActive(false);
					Merc2 newM = Instantiate(merc3) as Merc2;
					newM.transform.position = spawnPoint3.transform.position;
					GameManager.Instance.MerceneryList3.Add(newM);
					S56784.tag = "MiddlePath4";
				}
			}
			soldierBtnPressed = null;
		}
	}

	public void changeText()
	{
		mercIntroText.text = "When there is no soldier in the corresponding position, the mercenery will shoot at the house.";
	}

	public void maximize()
	{
		currentS5Energy = energyS5.MaxVal;
		energyS5.CurrentVal = energyS5.MaxVal;
		mercIntroSign.gameObject.SetActive(false);
	}
	
	[SerializeField]
	private Image mercIntroSign;
	[SerializeField]
	private Text mercIntroText;
	[SerializeField]
	private GameObject mercIntroPointers;
	private Animator mercIntroAnim;

	public void lateShowMenu()
	{
		GameManager.Instance.totalMerceneriesKilled = 0;
		GameManager.Instance.TotalKilled = 0;
		GameManager.Instance.DestroyAllEnemies();
		GameManager.Instance.MerceneryList1.Clear();
		GameManager.Instance.MerceneryList2.Clear();
		GameManager.Instance.MerceneryList3.Clear();
		GameManager.Instance.MerceneryList4.Clear();

		GameManager.Instance.EnemyListLeft.Clear();
		GameManager.Instance.EnemyListUpLeft.Clear();
		GameManager.Instance.EnemyListButtomLeft.Clear();
		GameManager.Instance.EnemyListRight.Clear();
		GameManager.Instance.EnemyListUpRight.Clear();
		GameManager.Instance.EnemyListButtomRight.Clear();
		DestroyAllSoldiers();
		SoldierMiddle1.Clear();
		SoldierMiddle2.Clear();
		SoldierMiddle3.Clear();
		SoldierMiddle4.Clear();
		SoldierListUpLeft.Clear();
		SoldierListLeft.Clear();
		SoldierListButtomLeft.Clear();
		SoldierListUpRight.Clear();
		SoldierListRight.Clear();
		SoldierListButtomRight.Clear();
		GameManager.Instance.ShowMenu();
	}

	[SerializeField]
	private Merc2 merc;
	[SerializeField]
	private Merc2 merc2;
	[SerializeField]
	private Merc2 merc3;
	[SerializeField]
	private Merc2 merc4;

	[SerializeField]
	private Enemy enemy1;
	[SerializeField]
	private Enemy enemy2;
	[SerializeField]
	private Enemy enemy3;
	[SerializeField]
	private Enemy enemy4;
	[SerializeField]
	private Enemy enemy5;
	[SerializeField]
	private Enemy enemy6;

	[SerializeField]
	private GameObject spawnPoint1;
	[SerializeField]
	private GameObject spawnPoint2;
	[SerializeField]
	private GameObject spawnPoint3;
	[SerializeField]
	private GameObject spawnPoint4;

	[SerializeField]
	private GameObject spawnPoint1Enemy;
	[SerializeField]
	private GameObject spawnPoint2Enemy;
	[SerializeField]
	private GameObject spawnPoint3Enemy;
	[SerializeField]
	private GameObject spawnPoint4Enemy;
	[SerializeField]
	private GameObject spawnPoint5Enemy;
	[SerializeField]
	private GameObject spawnPoint6Enemy;


	IEnumerator MoveS5678(Soldier soldier,GameObject h){
		
		while(soldier!=null && h!=null && soldier.transform.position!=h.transform.position){
			soldier.transform.position = Vector2.MoveTowards(soldier.transform.position,h.transform.position,Time.deltaTime);	
			yield return null;
		}
		if (soldier!= null && soldier.transform.position==h.transform.position){
			soldierAnim.SetTrigger("S5678CrouchShoot");
		}
	}

	public void dropPumpkin(int i)
	{
		BombPumpkin newBomb = Instantiate(bombBtnPressed.BombObject) as BombPumpkin;
		if(i==1)
			newBomb.transform.position = bush1.transform.position;
		else if(i==2){
			if(PlayerPrefs.GetInt("sniperIntro")==2)
			{
				PlayerPrefs.SetInt("sniperIntro",3);
				BombPumpkin newBomb2 = Instantiate(bombBtnPressed.BombObject) as BombPumpkin;
				newBomb2.transform.position = bush2.transform.position;
				sniperIntroSign.gameObject.SetActive(false);
				DestroyAllSoldiers();
				SoldierListLeft.Clear();
			}
			newBomb.transform.position = bush2.transform.position;
		}
		else if(i==3)
			newBomb.transform.position = bush3.transform.position;
		else if(i==4)
			newBomb.transform.position = bush4.transform.position;
		else if(i==5)
			newBomb.transform.position = bush5.transform.position;
		else if(i==6)
			newBomb.transform.position = bush6.transform.position;
		numOfPumpkins-=1;
		PlayerPrefs.SetInt("pumpkin",numOfPumpkins);		
		pumpkinText.text = "Have: " + numOfPumpkins.ToString(); 
		pumpkinTextInside.text = "Have: " + numOfPumpkins.ToString(); 
		if (numOfPumpkins == 0){
			pumpkinText.enabled = false;
			getMorePumpkin.SetActive(true);
		}
		bombBtnPressed = null;

	}

	public void dropSkully(int i)
	{
		OneRowBomb newBomb = Instantiate(bombBtnPressed.OneRowBombObject[i]) as OneRowBomb;
		if(i==0)
			newBomb.transform.position = path2.transform.position;
		else if(i==1)
			newBomb.transform.position = path1.transform.position;
		else if(i==2)
			newBomb.transform.position = path3.transform.position;
		else if(i==3)
			newBomb.transform.position = path5.transform.position;
		else if(i==4)
			newBomb.transform.position = path6.transform.position;
		else if(i==5)
			newBomb.transform.position = path4.transform.position;
		numOfOneRowBomb-=1;
		PlayerPrefs.SetInt("skully",numOfOneRowBomb);
		OneRowBombText.text = "Have: " + numOfOneRowBomb.ToString();
		OneRowBombTextInside.text = "Have: " + numOfOneRowBomb.ToString();
		if (numOfOneRowBomb == 0){
			OneRowBombText.enabled = false;
			getMoreSkully.SetActive(true);
		}
		bombBtnPressed = null;

	}

	public void dropGranade(int i)
	{
		OneRowBomb newBomb = Instantiate(bombBtnPressed.OneRowBombObject[i]) as OneRowBomb;
		if(i==0)
			newBomb.transform.position = window1.transform.position;
		else if(i==1)
			newBomb.transform.position = window1.transform.position;
		else if(i==2)
			newBomb.transform.position = window2.transform.position;
		else if(i==3)
			newBomb.transform.position = window2.transform.position;
		numOfGranade-=1;
		PlayerPrefs.SetInt("granade",numOfGranade);
		granadeText.text = "Have: " + numOfGranade.ToString(); 
		granadeTextInside.text = "Have: " + numOfGranade.ToString(); 
		if (numOfGranade == 0){
			granadeText.enabled = false;
			getMoreGranade.SetActive(true);
		}
		bombBtnPressed = null;
	}

	public void dropKnight()
	{
		BombPumpkin newBomb = Instantiate(bombBtnPressed.BombObject) as BombPumpkin;
		newBomb.transform.position = knightDropBtn.transform.position;
		numOfDestroyAllBomb-=1;
		PlayerPrefs.SetInt("knight",numOfDestroyAllBomb);
		DestroyAllBombText.text = "Have: " + numOfDestroyAllBomb.ToString(); 
		DestroyAllBombTextInside.text = "Have: " + numOfDestroyAllBomb.ToString();
		if (numOfDestroyAllBomb == 0){
			DestroyAllBombText.enabled = false;
			getMoreKnight.SetActive(true);
		}
		bombBtnPressed = null;
	}


	public void unregisterSoldier(Soldier soldier){
		Destroy(soldier.gameObject);
	}


	public void DestroyAllSoldiers(){
		foreach (Soldier soldier in SoldierListUpLeft){
			Destroy(soldier.gameObject);
		}
		foreach (Soldier soldier in SoldierListLeft){
			Destroy(soldier.gameObject);
		}
		foreach (Soldier soldier in SoldierListButtomLeft){
			Destroy(soldier.gameObject);
		}
		foreach (Soldier soldier in SoldierListUpRight){
			Destroy(soldier.gameObject);
		}
		foreach (Soldier soldier in SoldierListRight){
			Destroy(soldier.gameObject);
		}
		foreach (Soldier soldier in SoldierListButtomRight){
			Destroy(soldier.gameObject);
		}
		foreach (Soldier soldier in SoldierMiddle1){
			Destroy(soldier.gameObject);
		}
		foreach (Soldier soldier in SoldierMiddle2){
			Destroy(soldier.gameObject);
		}
		foreach (Soldier soldier in SoldierMiddle3){
			Destroy(soldier.gameObject);
		}
		foreach (Soldier soldier in SoldierMiddle4){
			Destroy(soldier.gameObject);
		}
		SoldierListUpLeft.Clear();
		SoldierListLeft.Clear();
		SoldierListButtomLeft.Clear();
		SoldierListUpRight.Clear();
		SoldierListRight.Clear();
		SoldierListButtomRight.Clear();
		SoldierMiddle1.Clear();
		SoldierMiddle2.Clear();
		SoldierMiddle3.Clear();
		SoldierMiddle4.Clear();
		GameManager.Instance.AudioSource.Stop();
	}
}
