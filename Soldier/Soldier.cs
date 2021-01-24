using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Soldier : MonoBehaviour {
	[SerializeField]
	private float timeBetweenAttacks;
	[SerializeField]
	private int attackRadius;
	[SerializeField]
	private Projectile projectile;
	[SerializeField]
	private float healthPoints;
	private Enemy targetEnemy = null;
	private Merc2 targetMercenery = null;
	private float attackCounter;
	private float attackCounter1=1.5f;
	private float attackCounter2=5f;
	private float attackCounter3=2f;
	private float attackCounter4=2.3f;
	private float attackCounter5=5f;
	private bool isAttacking = false;
	private Animator soldierAnim;
	private Animator soldierAnim2;
	private bool isDead = false;
	private Collider2D soldierCollider;
	private Rigidbody rb;
	[SerializeField]
	private Stat healthBar;
	
	private GameObject S5678Spot1;
	private GameObject S5678Spot2;
	private GameObject S5678Spot3;
	private GameObject S5678Spot4;
	private Collider2D S56781;
	private Collider2D S56782;
	private Collider2D S56783;
	private Collider2D S56784;

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
	
	

	public bool IsDead{
		get{
			return isDead;
		}
	}

	private void Awake(){
		healthBar.Initialize();
	}

	// Use this for initialization
	void Start () {
		if(this.name.Contains("Soldier1")){
			healthPoints = PlayerPrefs.GetInt("s1Health");
			timeBetweenAttacks = attackCounter1;
		}
		else if(this.name.Contains("Soldier2")){
			healthPoints = PlayerPrefs.GetInt("s2Health");
			timeBetweenAttacks = attackCounter2;
		}
		else if(this.name.Contains("Soldier3")){
			healthPoints = PlayerPrefs.GetInt("s3Health");
			timeBetweenAttacks = attackCounter3;
		}
		else if(this.name.Contains("Soldier4")){
			healthPoints = PlayerPrefs.GetInt("s4Health");
			timeBetweenAttacks = attackCounter4;
		}
		else if(this.name.Contains("Soldier5")){
			healthPoints = PlayerPrefs.GetInt("s5Health");
		}
		else if(this.name.Contains("Soldier6")){
			healthPoints = PlayerPrefs.GetInt("s6Health");
		}
		else if(this.name.Contains("Soldier7")){
			healthPoints = PlayerPrefs.GetInt("s7Health");
		}
		else if(this.name.Contains("Soldier8")){
			healthPoints = PlayerPrefs.GetInt("s8Health");
		}
		healthBar.MaxVal = healthPoints;
		healthBar.CurrentVal = healthPoints;

		soldierAnim = GetComponent<Animator>();
		rb = GetComponent<Rigidbody>();
		soldierCollider = GetComponent<Collider2D>();
		S5678Spot1 = GameObject.Find("S56781");
		S56781 = S5678Spot1.GetComponent<Collider2D>();
		S5678Spot2 = GameObject.Find("S56782");
		S56782 = S5678Spot2.GetComponent<Collider2D>();
		S5678Spot3 = GameObject.Find("S56783");
		S56783 = S5678Spot3.GetComponent<Collider2D>();
		S5678Spot4 = GameObject.Find("S56784");
		S56784 = S5678Spot4.GetComponent<Collider2D>();

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

		cam = Camera.main;
	}
	
	private int currentLevel;

	public Transform targetPoint;	
	Camera cam;

	// Update is called once per frame
	void Update () {
		if(this.name.Contains("Soldier1") || this.name.Contains("Soldier2") || this.name.Contains("Soldier3") || this.name.Contains("Soldier4")){
			attackCounter -= Time.deltaTime;
			if (targetEnemy == null || targetEnemy.IsDead){
				if(GetNearestEnenemy() != null)
					targetEnemy = GetNearestEnenemy();
			} 
 			else{
				if(attackCounter <= 0 ){
					Vector3 screenPoint = cam.WorldToViewportPoint (targetEnemy.transform.position);
					if (screenPoint.z > 0 && screenPoint.x > 0 && screenPoint.x < 1 && screenPoint.y > 0 && screenPoint.y < 1) {	
						isAttacking = true;
						attackCounter = timeBetweenAttacks;
					}	
				}else{
					isAttacking = false;
				}
			}
		}
		else if (this.name.Contains("Soldier5") || this.name.Contains("Soldier6") || this.name.Contains("Soldier7") || this.name.Contains("Soldier8")){
			attackCounter -= Time.deltaTime;
			if (targetMercenery == null || targetMercenery.IsDead){
				if(GetNearestMercenery() != null)
					{
					targetMercenery = GetNearestMercenery();}
			} 
 			else{
				if(attackCounter <= 0 ){
					isAttacking = true;
					attackCounter = timeBetweenAttacks;
				}else{
					isAttacking = false;
				}
			}
		}

	}


	
	void FixedUpdate(){
		if (this.name.Contains("Soldier1") || this.name.Contains("Soldier2") || this.name.Contains("Soldier3") || this.name.Contains("Soldier4")){
			if(isAttacking && !isDead ){
				Shoot();
			}
			
		}
		else{
			if(isAttacking && !isDead && soldierAnim.GetCurrentAnimatorStateInfo(0).IsName("S5CrouchShoot")){
				Shoot();
			}
		}
		
			
	}

	

	public void Shoot(){
		if((this.name.Contains("Soldier1")||this.name.Contains("Soldier2")||this.name.Contains("Soldier3")||this.name.Contains("Soldier4")) || 
		   ((this.name.Contains("Soldier5")||this.name.Contains("Soldier6")||this.name.Contains("Soldier7")||this.name.Contains("Soldier8"))&&(targetMercenery.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("Merc2CrouchShoot") ||
		   targetMercenery.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("Merc3CrouchShoot") ||
		   targetMercenery.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("Merc4CrouchShoot") ||
		   targetMercenery.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("Merc5CrouchShoot"))))
		{
			isAttacking = false;
		    Projectile newProjectile = Instantiate(projectile) as Projectile;
			Transform child = this.transform.GetChild(1);
			newProjectile.transform.position = child.position;
			if (this.name == "Soldier1(Clone)"){
				if(GameManager.Instance.EnemyListLeft != null)
				{
					foreach(Enemy enemy in GameManager.Instance.EnemyListLeft){
						if(enemy != targetEnemy){
							Physics2D.IgnoreCollision(newProjectile.GetComponent<Collider2D>(), enemy.GetComponent<Collider2D>());
						}
					}
				}
				
			}
			else if (this.name == "Soldier1ButtomLeft(Clone)"){
				if(GameManager.Instance.EnemyListButtomLeft != null)
				{
					foreach(Enemy enemy in GameManager.Instance.EnemyListButtomLeft){
						if(enemy != targetEnemy){
							Physics2D.IgnoreCollision(newProjectile.GetComponent<Collider2D>(), enemy.GetComponent<Collider2D>());
						}
					}
				}
			}
			else if (this.name == "Soldier1Upleft(Clone)"){
				if(GameManager.Instance.EnemyListUpLeft != null)
				{
					foreach(Enemy enemy in GameManager.Instance.EnemyListUpLeft){
						if(enemy != targetEnemy){
							Physics2D.IgnoreCollision(newProjectile.GetComponent<Collider2D>(), enemy.GetComponent<Collider2D>());
						}
					}
				}
			}
			else if (this.name == "Soldier1Right(Clone)"){
				if(GameManager.Instance.EnemyListRight != null)
				{
					foreach(Enemy enemy in GameManager.Instance.EnemyListRight){
						if(enemy != targetEnemy){
							Physics2D.IgnoreCollision(newProjectile.GetComponent<Collider2D>(), enemy.GetComponent<Collider2D>());
						}
					}
				}
			}
			else if (this.name == "Soldier1ButtomRight(Clone)"){
				if(GameManager.Instance.EnemyListButtomRight != null)
				{
					foreach(Enemy enemy in GameManager.Instance.EnemyListButtomRight){
						if(enemy != targetEnemy){
							Physics2D.IgnoreCollision(newProjectile.GetComponent<Collider2D>(), enemy.GetComponent<Collider2D>());
						}
					}
				}
			}
			else if(this.name == "Soldier1UpRight(Clone)"){
				if(GameManager.Instance.EnemyListUpRight != null)
				{
					foreach(Enemy enemy in GameManager.Instance.EnemyListUpRight){
						if(enemy != targetEnemy){
							Physics2D.IgnoreCollision(newProjectile.GetComponent<Collider2D>(), enemy.GetComponent<Collider2D>());
						}
					}
				}
			}
			else if(this.name == "Soldier2(Clone)"){
				if(GameManager.Instance.EnemyListLeft != null)
				{
					foreach(Enemy enemy in GameManager.Instance.EnemyListLeft){
						if(enemy != targetEnemy && newProjectile.name != "Bullet2(Clone)"){
							Physics2D.IgnoreCollision(newProjectile.GetComponent<Collider2D>(), enemy.GetComponent<Collider2D>());
						}
					}
				}
			}
			else if(this.name == "Soldier2ButtomLeft(Clone)"){
				if(GameManager.Instance.EnemyListButtomLeft != null)
				{
					foreach(Enemy enemy in GameManager.Instance.EnemyListButtomLeft){
						if(enemy != targetEnemy && newProjectile.name != "Bullet2(Clone)"){
							Physics2D.IgnoreCollision(newProjectile.GetComponent<Collider2D>(), enemy.GetComponent<Collider2D>());
						}
					}
				}
			}
			else if(this.name == "Soldier2UpLeft(Clone)"){
				if(GameManager.Instance.EnemyListUpLeft != null)
				{
					foreach(Enemy enemy in GameManager.Instance.EnemyListUpLeft){
						if(enemy != targetEnemy && newProjectile.name != "Bullet2(Clone)"){
							Physics2D.IgnoreCollision(newProjectile.GetComponent<Collider2D>(), enemy.GetComponent<Collider2D>());
						}
					}
				}
			}
			else if(this.name == "Soldier2Right(Clone)"){
				if(GameManager.Instance.EnemyListRight != null)
				{
					foreach(Enemy enemy in GameManager.Instance.EnemyListRight){
						if(enemy != targetEnemy && newProjectile.name != "Bullet2(Clone)"){
							Physics2D.IgnoreCollision(newProjectile.GetComponent<Collider2D>(), enemy.GetComponent<Collider2D>());
						}
					}
				}
			}
			else if(this.name == "Soldier2ButtomRight(Clone)"){
				if(GameManager.Instance.EnemyListButtomRight != null)
				{
					foreach(Enemy enemy in GameManager.Instance.EnemyListButtomRight){
						if(enemy != targetEnemy && newProjectile.name != "Bullet2(Clone)"){
							Physics2D.IgnoreCollision(newProjectile.GetComponent<Collider2D>(), enemy.GetComponent<Collider2D>());
						}
					}
				}
			}
			else if(this.name == "Soldier2UpRight(Clone)"){
				if(GameManager.Instance.EnemyListUpRight != null)
				{
					foreach(Enemy enemy in GameManager.Instance.EnemyListUpRight){
						if(enemy != targetEnemy && newProjectile.name != "Bullet2(Clone)"){
							Physics2D.IgnoreCollision(newProjectile.GetComponent<Collider2D>(), enemy.GetComponent<Collider2D>());
						}
					}
				}
			}
			else if(this.name == "Soldier3(Clone)"){
				if(GameManager.Instance.EnemyListLeft != null)
				{
					foreach(Enemy enemy in GameManager.Instance.EnemyListLeft){
						if(enemy != targetEnemy){
							Physics2D.IgnoreCollision(newProjectile.GetComponent<Collider2D>(), enemy.GetComponent<Collider2D>());
						}
					}
				}
			}
			else if(this.name == "Soldier3ButtomLeft(Clone)"){
				if(GameManager.Instance.EnemyListButtomLeft != null)
				{
					foreach(Enemy enemy in GameManager.Instance.EnemyListButtomLeft){
						if(enemy != targetEnemy){
							Physics2D.IgnoreCollision(newProjectile.GetComponent<Collider2D>(), enemy.GetComponent<Collider2D>());
						}
					}
				}
			}
			else if(this.name == "Soldier3UpLeft(Clone)"){
				if(GameManager.Instance.EnemyListUpLeft != null)
				{
					foreach(Enemy enemy in GameManager.Instance.EnemyListUpLeft){
						if(enemy != targetEnemy){
							Physics2D.IgnoreCollision(newProjectile.GetComponent<Collider2D>(), enemy.GetComponent<Collider2D>());
						}
					}
				}
			}
			else if(this.name == "Soldier3Right(Clone)"){
				if(GameManager.Instance.EnemyListRight != null)
				{
					foreach(Enemy enemy in GameManager.Instance.EnemyListRight){
						if(enemy != targetEnemy){
							Physics2D.IgnoreCollision(newProjectile.GetComponent<Collider2D>(), enemy.GetComponent<Collider2D>());
						}
					}
				}
			}
			else if(this.name == "Soldier3ButtomRight(Clone)"){
				if(GameManager.Instance.EnemyListButtomRight != null)
				{
					foreach(Enemy enemy in GameManager.Instance.EnemyListButtomRight){
						if(enemy != targetEnemy){
							Physics2D.IgnoreCollision(newProjectile.GetComponent<Collider2D>(), enemy.GetComponent<Collider2D>());
						}
					}
				}
			}
			else if(this.name == "Soldier3UpRight(Clone)"){
				if(GameManager.Instance.EnemyListUpRight != null)
				{
					foreach(Enemy enemy in GameManager.Instance.EnemyListUpRight){
						if(enemy != targetEnemy){
							Physics2D.IgnoreCollision(newProjectile.GetComponent<Collider2D>(), enemy.GetComponent<Collider2D>());
						}
					}
				}
			}
			else if(this.name == "Soldier4(Clone)"){
				if(GameManager.Instance.EnemyListLeft != null)
				{
					foreach(Enemy enemy in GameManager.Instance.EnemyListLeft){
						if(enemy != targetEnemy){
							Physics2D.IgnoreCollision(newProjectile.GetComponent<Collider2D>(), enemy.GetComponent<Collider2D>());
						}
					}
				}
			}
			else if(this.name == "Soldier4ButtomLeft(Clone)"){
				if(GameManager.Instance.EnemyListButtomLeft != null)
				{
					foreach(Enemy enemy in GameManager.Instance.EnemyListButtomLeft){
						if(enemy != targetEnemy){
							Physics2D.IgnoreCollision(newProjectile.GetComponent<Collider2D>(), enemy.GetComponent<Collider2D>());
						}
					}
				}
			}
			else if(this.name == "Soldier4UpLeft(Clone)"){
				if(GameManager.Instance.EnemyListUpLeft != null)
				{
					foreach(Enemy enemy in GameManager.Instance.EnemyListUpLeft){
						if(enemy != targetEnemy){
							Physics2D.IgnoreCollision(newProjectile.GetComponent<Collider2D>(), enemy.GetComponent<Collider2D>());
						}
					}
				}
			}
			else if(this.name == "Soldier4Right(Clone)"){
				if(GameManager.Instance.EnemyListRight != null)
				{
					foreach(Enemy enemy in GameManager.Instance.EnemyListRight){
						if(enemy != targetEnemy){
							Physics2D.IgnoreCollision(newProjectile.GetComponent<Collider2D>(), enemy.GetComponent<Collider2D>());
						}
					}
				}
			}
			else if(this.name == "Soldier4ButtomRight(Clone)"){
				if(GameManager.Instance.EnemyListButtomRight != null)
				{
					foreach(Enemy enemy in GameManager.Instance.EnemyListButtomRight){
						if(enemy != targetEnemy){
							Physics2D.IgnoreCollision(newProjectile.GetComponent<Collider2D>(), enemy.GetComponent<Collider2D>());
						}
					}
				}
			}
			else if(this.name == "Soldier4UpRight(Clone)"){
				if(GameManager.Instance.EnemyListUpRight != null)
				{
					foreach(Enemy enemy in GameManager.Instance.EnemyListUpRight){
						if(enemy != targetEnemy){
							Physics2D.IgnoreCollision(newProjectile.GetComponent<Collider2D>(), enemy.GetComponent<Collider2D>());
						}
					}
				}
			}
			else if(this.name == "Soldier51(Clone)"){
				if(GameManager.Instance.MerceneryList1 != null)
				{
					foreach(Merc2 merc in GameManager.Instance.MerceneryList1){
						if(merc != targetMercenery){
							Physics2D.IgnoreCollision(newProjectile.GetComponent<Collider2D>(), merc.GetComponent<Collider2D>());
						}
					}
				}
			}
			else if(this.name == "Soldier52(Clone)"){
				if(GameManager.Instance.MerceneryList4 != null)
				{
					foreach(Merc2 merc in GameManager.Instance.MerceneryList4){
						if(merc != targetMercenery){
							Physics2D.IgnoreCollision(newProjectile.GetComponent<Collider2D>(), merc.GetComponent<Collider2D>());
						}
					}
				}
			}
			else if(this.name == "Soldier53(Clone)"){
				if(GameManager.Instance.MerceneryList2 != null)
				{
					foreach(Merc2 merc in GameManager.Instance.MerceneryList2){
						if(merc != targetMercenery){
							Physics2D.IgnoreCollision(newProjectile.GetComponent<Collider2D>(), merc.GetComponent<Collider2D>());
						}
					}
				}
			}
			else if(this.name == "Soldier54(Clone)"){
				if(GameManager.Instance.MerceneryList3 != null)
				{
					foreach(Merc2 merc in GameManager.Instance.MerceneryList3){
						if(merc != targetMercenery){
							Physics2D.IgnoreCollision(newProjectile.GetComponent<Collider2D>(), merc.GetComponent<Collider2D>());
						}
					}
				}
			}
			else if(this.name == "Soldier61(Clone)"){
				if(GameManager.Instance.MerceneryList1 != null)
				{
					foreach(Merc2 merc in GameManager.Instance.MerceneryList1){
						if(merc != targetMercenery){
							Physics2D.IgnoreCollision(newProjectile.GetComponent<Collider2D>(), merc.GetComponent<Collider2D>());
						}
					}
				}
			}
			else if(this.name == "Soldier62(Clone)"){
				if(GameManager.Instance.MerceneryList4 != null)
				{
					foreach(Merc2 merc in GameManager.Instance.MerceneryList4){
						if(merc != targetMercenery){
							Physics2D.IgnoreCollision(newProjectile.GetComponent<Collider2D>(), merc.GetComponent<Collider2D>());
						}
					}
				}
			}
			else if(this.name == "Soldier63(Clone)"){
				if(GameManager.Instance.MerceneryList2 != null)
				{
					foreach(Merc2 merc in GameManager.Instance.MerceneryList2){
						if(merc != targetMercenery){
							Physics2D.IgnoreCollision(newProjectile.GetComponent<Collider2D>(), merc.GetComponent<Collider2D>());
						}
					}
				}
			}
			else if(this.name == "Soldier64(Clone)"){
				if(GameManager.Instance.MerceneryList3 != null)
				{
					foreach(Merc2 merc in GameManager.Instance.MerceneryList3){
						if(merc != targetMercenery){
							Physics2D.IgnoreCollision(newProjectile.GetComponent<Collider2D>(), merc.GetComponent<Collider2D>());
						}
					}
				}
			}
			else if(this.name == "Soldier71(Clone)"){
				if(GameManager.Instance.MerceneryList1 != null)
				{
					foreach(Merc2 merc in GameManager.Instance.MerceneryList1){
						if(merc != targetMercenery){
							Physics2D.IgnoreCollision(newProjectile.GetComponent<Collider2D>(), merc.GetComponent<Collider2D>());
						}
					}
				}
			}
			else if(this.name == "Soldier72(Clone)"){
				if(GameManager.Instance.MerceneryList4 != null)
				{
					foreach(Merc2 merc in GameManager.Instance.MerceneryList4){
						if(merc != targetMercenery){
							Physics2D.IgnoreCollision(newProjectile.GetComponent<Collider2D>(), merc.GetComponent<Collider2D>());
						}
					}
				}
			}
			else if(this.name == "Soldier73(Clone)"){
				if(GameManager.Instance.MerceneryList2 != null)
				{
					foreach(Merc2 merc in GameManager.Instance.MerceneryList2){
						if(merc != targetMercenery){
							Physics2D.IgnoreCollision(newProjectile.GetComponent<Collider2D>(), merc.GetComponent<Collider2D>());
						}
					}
				}
			}
			else if(this.name == "Soldier74(Clone)"){
				if(GameManager.Instance.MerceneryList3 != null)
				{
					foreach(Merc2 merc in GameManager.Instance.MerceneryList3){
						if(merc != targetMercenery){
							Physics2D.IgnoreCollision(newProjectile.GetComponent<Collider2D>(), merc.GetComponent<Collider2D>());
						}
					}
				}
			}
			else if(this.name == "Soldier81(Clone)"){
				if(GameManager.Instance.MerceneryList1 != null)
				{
					foreach(Merc2 merc in GameManager.Instance.MerceneryList1){
						if(merc != targetMercenery){
							Physics2D.IgnoreCollision(newProjectile.GetComponent<Collider2D>(), merc.GetComponent<Collider2D>());
						}
					}
				}
			}
			else if(this.name == "Soldier82(Clone)"){
				if(GameManager.Instance.MerceneryList4 != null)
				{
					foreach(Merc2 merc in GameManager.Instance.MerceneryList4){
						if(merc != targetMercenery){
							Physics2D.IgnoreCollision(newProjectile.GetComponent<Collider2D>(), merc.GetComponent<Collider2D>());
						}
					}
				}
			}
			else if(this.name == "Soldier83(Clone)"){
				if(GameManager.Instance.MerceneryList2 != null)
				{
					foreach(Merc2 merc in GameManager.Instance.MerceneryList2){
						if(merc != targetMercenery){
							Physics2D.IgnoreCollision(newProjectile.GetComponent<Collider2D>(), merc.GetComponent<Collider2D>());
						}
					}
				}
			}
			else if(this.name == "Soldier84(Clone)"){
				if(GameManager.Instance.MerceneryList3 != null)
				{
					foreach(Merc2 merc in GameManager.Instance.MerceneryList3){
						if(merc != targetMercenery){
							Physics2D.IgnoreCollision(newProjectile.GetComponent<Collider2D>(), merc.GetComponent<Collider2D>());
						}
					}
				}
			}

			
			
			if(targetEnemy == null && targetMercenery == null){
				if(newProjectile.name !="Bullet2(Clone)" && newProjectile.name !="Bullet4(Clone)"){
					Destroy(newProjectile);
				}
			} 
			else {
				StartCoroutine(MoveProjectile(newProjectile));
				}
		}
	}

	private float s1ProjSpeed = 15f;
	private float s2ProjSpeed = 4f;
	private float s3ProjSpeed = 10f;
	private float s4ProjSpeed = 7f;

	IEnumerator MoveProjectile(Projectile projectile){
		if (this.name.Contains("Soldier1") || this.name.Contains("Soldier2") || this.name.Contains("Soldier3") || this.name.Contains("Soldier4")){
			while(projectile != null && targetEnemy!= null){
				var dir = targetEnemy.transform.localPosition - transform.localPosition;
				var angleDirection = Mathf.Atan2(dir.y,dir.x)* Mathf.Rad2Deg;
				projectile.transform.rotation = Quaternion.AngleAxis(angleDirection, Vector3.forward);
				if(this.name.Contains("Soldier1"))
				{projectile.transform.localPosition = Vector2.MoveTowards(projectile.transform.localPosition,targetEnemy.transform.localPosition, s1ProjSpeed*Time.deltaTime);}
				else if(this.name.Contains("Soldier2"))
				{projectile.transform.localPosition = Vector2.MoveTowards(projectile.transform.localPosition,targetEnemy.transform.localPosition, s2ProjSpeed*Time.deltaTime);}
				else if(this.name.Contains("Soldier3"))
				{projectile.transform.localPosition = Vector2.MoveTowards(projectile.transform.localPosition,targetEnemy.transform.localPosition, s3ProjSpeed*Time.deltaTime);}
				else if(this.name.Contains("Soldier4"))
				{projectile.transform.localPosition = Vector2.MoveTowards(projectile.transform.localPosition,targetEnemy.transform.localPosition, s4ProjSpeed*Time.deltaTime);}
				yield return null;
			}
			if (projectile != null || targetEnemy == null){
				Destroy(projectile);
			}
		}
		else{
			while(projectile != null && targetMercenery!= null){
				var dir = targetMercenery.transform.localPosition - transform.localPosition;
				var angleDirection = Mathf.Atan2(dir.y,dir.x)* Mathf.Rad2Deg;
				projectile.transform.rotation = Quaternion.AngleAxis(angleDirection, Vector3.forward);
				projectile.transform.localPosition = Vector2.MoveTowards(projectile.transform.localPosition,targetMercenery.transform.localPosition, 11.5f*Time.deltaTime);
				yield return null;
			}
			if (projectile != null || targetMercenery == null){
				Destroy(projectile);
			}
		}
		
	}

	private float getTargetDistance(Enemy thisEnemy){
		if(thisEnemy == null){
			thisEnemy = GetNearestEnenemy();
			if(thisEnemy == null){
				return 0f;
			}
		}
		return Mathf.Abs(Vector2.Distance(transform.localPosition, thisEnemy.transform.localPosition));
	}
	
	

	private List<Enemy> GetEnemiesInRange(){
		List<Enemy> enemiesInRange = new List<Enemy>();
		foreach (Enemy enemy in GameManager.Instance.EnemyListLeft){
			enemiesInRange.Add(enemy);
		}
		foreach (Enemy enemy in GameManager.Instance.EnemyListUpLeft){
			enemiesInRange.Add(enemy);
		}
		foreach (Enemy enemy in GameManager.Instance.EnemyListButtomLeft){
			enemiesInRange.Add(enemy);
		}
		foreach (Enemy enemy in GameManager.Instance.EnemyListRight){
			enemiesInRange.Add(enemy);
		}
		foreach (Enemy enemy in GameManager.Instance.EnemyListButtomRight){
			enemiesInRange.Add(enemy);
		}
		foreach (Enemy enemy in GameManager.Instance.EnemyListUpRight){
			enemiesInRange.Add(enemy);
		}
		
		return enemiesInRange;
	}

	private Enemy GetNearestEnenemy(){
		Enemy nearestEnemy = null;
		float smallestDistance = float.PositiveInfinity;
		
		if (this.name == "Soldier1(Clone)" || this.name == "Soldier2(Clone)" || this.name == "Soldier3(Clone)" || this.name == "Soldier4(Clone)"){
			foreach(Enemy enemy in GameManager.Instance.EnemyListLeft){
				if(Vector2.Distance(transform.localPosition,enemy.transform.localPosition)<smallestDistance){
					smallestDistance = Vector2.Distance(transform.localPosition,enemy.transform.localPosition);
					nearestEnemy = enemy;
				}
			}	
		}
		if (this.name == "Soldier1ButtomLeft(Clone)" || this.name == "Soldier2ButtomLeft(Clone)" || this.name == "Soldier3ButtomLeft(Clone)" || this.name == "Soldier4ButtomLeft(Clone)"){
			foreach(Enemy enemy in GameManager.Instance.EnemyListButtomLeft){
				if(Vector2.Distance(transform.localPosition,enemy.transform.localPosition)<smallestDistance){
					smallestDistance = Vector2.Distance(transform.localPosition,enemy.transform.localPosition);
					nearestEnemy = enemy;
				}
			}	
		}
		if (this.name == "Soldier1Upleft(Clone)" || this.name == "Soldier2UpLeft(Clone)" || this.name == "Soldier3UpLeft(Clone)" || this.name == "Soldier4UpLeft(Clone)"){
			foreach(Enemy enemy in GameManager.Instance.EnemyListUpLeft){
				if(Vector2.Distance(transform.localPosition,enemy.transform.localPosition)<smallestDistance){
					smallestDistance = Vector2.Distance(transform.localPosition,enemy.transform.localPosition);
					nearestEnemy = enemy;
				}
			}	
		}
		if (this.name == "Soldier1Right(Clone)" || this.name == "Soldier2Right(Clone)" || this.name == "Soldier3Right(Clone)" || this.name == "Soldier4Right(Clone)"){
			foreach(Enemy enemy in GameManager.Instance.EnemyListRight){
				if(Vector2.Distance(transform.localPosition,enemy.transform.localPosition)<smallestDistance){
					smallestDistance = Vector2.Distance(transform.localPosition,enemy.transform.localPosition);
					nearestEnemy = enemy;
				}	
			}
		}
		if (this.name == "Soldier1ButtomRight(Clone)" || this.name == "Soldier2ButtomRight(Clone)" || this.name == "Soldier3ButtomRight(Clone)" || this.name == "Soldier4ButtomRight(Clone)"){
			foreach(Enemy enemy in GameManager.Instance.EnemyListButtomRight){
				if(Vector2.Distance(transform.localPosition,enemy.transform.localPosition)<smallestDistance){
					smallestDistance = Vector2.Distance(transform.localPosition,enemy.transform.localPosition);
					nearestEnemy = enemy;
				}	
			}
		}
		if (this.name == "Soldier1UpRight(Clone)" || this.name == "Soldier2UpRight(Clone)" || this.name == "Soldier3UpRight(Clone)" || this.name == "Soldier4UpRight(Clone)"){
			foreach(Enemy enemy in GameManager.Instance.EnemyListUpRight){
				if(Vector2.Distance(transform.localPosition,enemy.transform.localPosition)<smallestDistance){
					smallestDistance = Vector2.Distance(transform.localPosition,enemy.transform.localPosition);
					nearestEnemy = enemy;
				}	
			}
		}

		
		
		return nearestEnemy;
	}

	private Merc2 GetNearestMercenery(){
		Merc2 nearestMercenery = null;
		float smallestDistance = float.PositiveInfinity;
		if (this.name == "Soldier51(Clone)" || this.name == "Soldier61(Clone)" || this.name == "Soldier71(Clone)" || this.name == "Soldier81(Clone)"){
			foreach(Merc2 merc in GameManager.Instance.MerceneryList1){
				if(merc!=null){
					if(Vector2.Distance(transform.localPosition,merc.transform.localPosition)<smallestDistance){
					smallestDistance = Vector2.Distance(transform.localPosition,merc.transform.localPosition);
					nearestMercenery = merc;
					}
				}
				
			}	
		}
		else if (this.name == "Soldier52(Clone)" || this.name == "Soldier62(Clone)" || this.name == "Soldier72(Clone)" || this.name == "Soldier82(Clone)"){
			foreach(Merc2 merc in GameManager.Instance.MerceneryList4){
				if(merc!=null){
					if(Vector2.Distance(transform.localPosition,merc.transform.localPosition)<smallestDistance){
					smallestDistance = Vector2.Distance(transform.localPosition,merc.transform.localPosition);
					nearestMercenery = merc;
					}
				}
			}	
		}
		else if (this.name == "Soldier53(Clone)" || this.name == "Soldier63(Clone)" || this.name == "Soldier73(Clone)" || this.name == "Soldier83(Clone)"){
			foreach(Merc2 merc in GameManager.Instance.MerceneryList2){
				if(merc!=null){
					if(Vector2.Distance(transform.localPosition,merc.transform.localPosition)<smallestDistance){
					smallestDistance = Vector2.Distance(transform.localPosition,merc.transform.localPosition);
					nearestMercenery = merc;
					}
				}
			}	
		}
		else if (this.name == "Soldier54(Clone)" || this.name == "Soldier64(Clone)" || this.name == "Soldier74(Clone)" || this.name == "Soldier84(Clone)"){
			foreach(Merc2 merc in GameManager.Instance.MerceneryList3){
				if(merc!=null){
					if(Vector2.Distance(transform.localPosition,merc.transform.localPosition)<smallestDistance){
					smallestDistance = Vector2.Distance(transform.localPosition,merc.transform.localPosition);
					nearestMercenery = merc;
					}
				}
			}	
		}
		return nearestMercenery;
	}
	
	private bool isTime = false;
	private float timeBetweenGettingAttacked;

	void OnTriggerStay2D(Collider2D other){
		if(other.tag == "Enemy"){
			if(other.name.Contains("Bloch"))
			{
				timeBetweenGettingAttacked = 2f;
			}
			else if(other.name.Contains("Mummy"))
			{
				timeBetweenGettingAttacked = 1.5f;
			}
			else if(other.name.Contains("Scorp"))
			{
				timeBetweenGettingAttacked = 3f;
			}
			else if(other.name.Contains("Wolf"))
			{
				timeBetweenGettingAttacked = 2.25f;
			}
		 	Enemy newEn = other.gameObject.GetComponent<Enemy>();
			if(isTime == false){
				isTime = true;
				StartCoroutine(enemyAttackFreq(timeBetweenGettingAttacked,newEn.AttackStrenght));
			} 
		 	//soldierHit(newEn.AttackStrenght);
		}	
	}

	void OnTriggerEnter2D(Collider2D other){
		if(other.tag == "SniperProjectile"){
			Projectile newP = other.gameObject.GetComponent<Projectile>();
			soldierHit(newP.AttackStrenght);
			Destroy(other.gameObject);
		}
		else if(other.tag == "MerceneryProjectile"){
			Projectile newP = other.gameObject.GetComponent<Projectile>();
			soldierHit(newP.AttackStrenght);
			Destroy(other.gameObject);
		}
	}

	IEnumerator enemyAttackFreq(float a, float attackStr)
	{
		soldierHit(attackStr);
		yield return new WaitForSeconds(a);
		isTime = false;
	}

	public void soldierHit(float hitPoints){
		if(healthPoints-hitPoints > 0){
			healthPoints -= hitPoints;
			healthBar.CurrentVal -= hitPoints;
		}
		else if (healthPoints-hitPoints<=0){
			GameManager.Instance.AudioSource.PlayOneShot(SoundManager.Instance.SoldierDied,2.5f);
			healthBar.CurrentVal =0;
			if(this.name.Contains("5")||this.name.Contains("6")||this.name.Contains("7")||this.name.Contains("8")){
				soldierAnim.SetTrigger("S5678didDie");
			}
			else{
				soldierAnim.SetTrigger("soldierDidDie");
			}
			die();
			if (this.name == "Soldier1(Clone)" || this.name == "Soldier2(Clone)" || this.name == "Soldier3(Clone)" || this.name == "Soldier4(Clone)"){
				SoldierManager.Instance.SoldierListLeft.Remove(this);
				if(this.transform.position == Left1.transform.position)
					l1.tag = "PathStraightLeft";
				else if(this.transform.position == Left2.transform.position)
					l2.tag = "PathStraightLeft";
				else if(this.transform.position == Left3.transform.position)
					l3.tag = "PathStraightLeft";
				else if(this.transform.position == Left4.transform.position)
					l4.tag = "PathStraightLeft";
				else if(this.transform.position == Left5.transform.position)
					l5.tag = "PathStraightLeft";
				else if(this.transform.position == Left6.transform.position)
					l6.tag = "PathStraightLeft";
			}
			else if (this.name == "Soldier1ButtomLeft(Clone)" || this.name == "Soldier2ButtomLeft(Clone)" || this.name == "Soldier3ButtomLeft(Clone)" || this.name == "Soldier4ButtomLeft(Clone)"){
				SoldierManager.Instance.SoldierListButtomLeft.Remove(this);
				if(this.transform.position == LeftB1.transform.position)
					lB1.tag = "PathButtomLeft";
				else if(this.transform.position == LeftB2.transform.position)
					lB2.tag = "PathButtomLeft";
				else if(this.transform.position == LeftB3.transform.position)
					lB3.tag = "PathButtomLeft";
				else if(this.transform.position == LeftB4.transform.position)
					lB4.tag = "PathButtomLeft";
				else if(this.transform.position == LeftB5.transform.position)
					lB5.tag = "PathButtomLeft";
				else if(this.transform.position == LeftB6.transform.position)
					lB6.tag = "PathButtomLeft";
			}
			else if (this.name == "Soldier1Upleft(Clone)" || this.name == "Soldier2UpLeft(Clone)" || this.name == "Soldier3UpLeft(Clone)" || this.name == "Soldier4UpLeft(Clone)"){
				SoldierManager.Instance.SoldierListUpLeft.Remove(this);
				if(this.transform.position == LeftUp1.transform.position)
					lU1.tag = "PathUpLeft";
				else if(this.transform.position == LeftUp2.transform.position)
					lU2.tag = "PathUpLeft";
				else if(this.transform.position == LeftUp3.transform.position)
					lU3.tag = "PathUpLeft";
				else if(this.transform.position == LeftUp4.transform.position)
					lU4.tag = "PathUpLeft";
				else if(this.transform.position == LeftUp5.transform.position)
					lU5.tag = "PathUpLeft";
				else if(this.transform.position == LeftUp6.transform.position)
					lU6.tag = "PathUpLeft";
			}	
		
			else if (this.name == "Soldier1Right(Clone)" || this.name == "Soldier2Right(Clone)" || this.name == "Soldier3Right(Clone)" || this.name == "Soldier4Right(Clone)"){
				SoldierManager.Instance.SoldierListRight.Remove(this);
				if(this.transform.position == Right1.transform.position)
					R1.tag = "PathStraightRight";
				else if(this.transform.position == Right2.transform.position)
					R2.tag = "PathStraightRight";
				else if(this.transform.position == Right3.transform.position)
					R3.tag = "PathStraightRight";
				else if(this.transform.position == Right4.transform.position)
					R4.tag = "PathStraightRight";
				else if(this.transform.position == Right5.transform.position)
					R5.tag = "PathStraightRight";
				else if(this.transform.position == Right6.transform.position)
					R6.tag = "PathStraightRight";
			}
		    else if (this.name == "Soldier1ButtomRight(Clone)" || this.name == "Soldier2ButtomRight(Clone)" || this.name == "Soldier3ButtomRight(Clone)" || this.name == "Soldier4ButtomRight(Clone)"){
				SoldierManager.Instance.SoldierListButtomRight.Remove(this);
				if(this.transform.position == RightB1.transform.position)
					RB1.tag = "PathButtomRight";
				else if(this.transform.position == RightB2.transform.position)
					RB2.tag = "PathButtomRight";
				else if(this.transform.position == RightB3.transform.position)
					RB3.tag = "PathButtomRight";
				else if(this.transform.position == RightB4.transform.position)
					RB4.tag = "PathButtomRight";
				else if(this.transform.position == RightB5.transform.position)
					RB5.tag = "PathButtomRight";
				else if(this.transform.position == RightB6.transform.position)
					RB6.tag = "PathButtomRight";
			}
			else if (this.name == "Soldier1UpRight(Clone)" || this.name == "Soldier2UpRight(Clone)" || this.name == "Soldier3UpRight(Clone)" || this.name == "Soldier4UpRight(Clone)"){
				SoldierManager.Instance.SoldierListUpRight.Remove(this);
				if(this.transform.position == RightUp1.transform.position)
					RU1.tag = "PathUpRight";
				else if(this.transform.position == RightUp2.transform.position)
					RU2.tag = "PathUpRight";
				else if(this.transform.position == RightUp3.transform.position)
					RU3.tag = "PathUpRight";
				else if(this.transform.position == RightUp4.transform.position)
					RU4.tag = "PathUpRight";
				else if(this.transform.position == RightUp5.transform.position)
					RU5.tag = "PathUpRight";
				else if(this.transform.position == RightUp6.transform.position)
					RU6.tag = "PathUpRight";
			}
			else if (this.name == "Soldier51(Clone)" || this.name == "Soldier61(Clone)" || this.name == "Soldier71(Clone)" || this.name == "Soldier81(Clone)"){
				SoldierManager.Instance.SoldierMiddle1.Remove(this);
				S56781.tag = "MiddlePath1";
			}
			else if (this.name == "Soldier52(Clone)" || this.name == "Soldier62(Clone)" || this.name == "Soldier72(Clone)" || this.name == "Soldier82(Clone)"){
				SoldierManager.Instance.SoldierMiddle2.Remove(this);
				S56782.tag = "MiddlePath2";
			}
			else if (this.name == "Soldier53(Clone)" || this.name == "Soldier63(Clone)" || this.name == "Soldier73(Clone)" || this.name == "Soldier83(Clone)"){
				SoldierManager.Instance.SoldierMiddle3.Remove(this);
				S56783.tag = "MiddlePath3";
			}
			else if (this.name == "Soldier54(Clone)" || this.name == "Soldier64(Clone)" || this.name == "Soldier74(Clone)" || this.name == "Soldier84(Clone)"){
				SoldierManager.Instance.SoldierMiddle4.Remove(this);
				S56784.tag = "MiddlePath4";
			}
			
			Invoke("destorySoldier",3f);
		}
	}

	public void die(){
		isDead = true;
		soldierCollider.enabled = false;
	}

	public void destorySoldier(){
		Destroy(this.gameObject);
	}

}
