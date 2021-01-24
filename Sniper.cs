using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sniper : MonoBehaviour {
	[SerializeField]
	private float navigationUpdate;
	[SerializeField]
	private float speed;

	[SerializeField]
	private float timeBetweenAttacks;
	[SerializeField]
	private int attackRadius;
	[SerializeField]
	private Projectile projectile;
	[SerializeField]
	private float healthPoints;
	private Soldier targetSoldier = null;
	private float attackCounter;
	private bool isAttacking = false;
	private Animator sniperAnim;
	private bool isDead = false;
	private Collider2D sniperCollider;
	private Transform sniper;
	private float navigationTime = 0;
	private bool reachedTheBush = false;

	[SerializeField]
	private Stat healthBar;

	private void Awake(){
		healthBar.Initialize();
	}
	

	public bool IsDead{
		get{
			return isDead;
		}
	}

	private GameObject bush1;
	private GameObject bush2;
	private GameObject bush3;
	private GameObject bush4;
	private GameObject bush5;
	private GameObject bush6;


	public Transform MainCamera;

	private float ratiox;
	private float ratioy;
	private float xdistance;
	private float ydistance;
	private float newxdistance;

	//private GameObject bushes;
	// Use this for initialization
	void Start () {
		sniperAnim = GetComponent<Animator>();
		sniperCollider = GetComponent<Collider2D>();
		sniper = GetComponent<Transform>();
 		ratiox=Screen.width*2f;
 		ratioy=Screen.height*3f;
		bush1 = GameObject.Find("Bush1Point");
		bush2 = GameObject.Find("Bush1Point (1)");
		bush3 = GameObject.Find("Bush1Point (2)");
		bush4 = GameObject.Find("Bush1Point (3)");
		bush5 = GameObject.Find("Bush1Point (4)");
		bush6 = GameObject.Find("Bush1Point (5)");

		healthBar.MaxVal = healthPoints;
		healthBar.CurrentVal = healthPoints;

	}
	

	void Update () {
		if (bush1!= null && bush2!= null && bush3!= null && bush4!= null && bush5!= null && bush6!= null && !isDead){
			navigationTime += Time.deltaTime;
			if (navigationTime > navigationUpdate ){	
				if(this.name == "Mercenery1(Clone)")
					sniper.position = Vector2.MoveTowards(sniper.position, bush1.transform.position ,(float)speed*navigationTime);
				else if(this.name == "Mercenery2(Clone)")
					sniper.position = Vector2.MoveTowards(sniper.position, bush2.transform.position ,(float)speed*navigationTime);
				else if(this.name == "Mercenery3(Clone)")
					sniper.position = Vector2.MoveTowards(sniper.position, bush3.transform.position ,(float)speed*navigationTime);
				else if(this.name == "Mercenery6(Clone)")
					sniper.position = Vector2.MoveTowards(sniper.position, bush4.transform.position ,(float)speed*navigationTime);
				else if(this.name == "Mercenery7(Clone)")
					sniper.position = Vector2.MoveTowards(sniper.position, bush5.transform.position ,(float)speed*navigationTime);
				else if(this.name == "Mercenery8(Clone)")
					sniper.position = Vector2.MoveTowards(sniper.position, bush6.transform.position ,(float)speed*navigationTime);
				navigationTime = 0;
			}
		}
		if(this.name == "Mercenery1(Clone)"){
			if(this.transform.position == bush1.transform.position && !isDead)
			{	
				sniperAnim.SetTrigger("MerceneryAiming");
				attackCounter -= Time.deltaTime;
				if (targetSoldier == null || targetSoldier.IsDead){
				
					if(GetNearestSoldier() != null)
						{targetSoldier = GetNearestSoldier();
						}
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
		else if(this.name == "Mercenery2(Clone)"){
			if(this.transform.position == bush2.transform.position && !isDead)
			{	
				sniperAnim.SetTrigger("MerceneryAiming");
				attackCounter -= Time.deltaTime;
				if (targetSoldier == null || targetSoldier.IsDead){
				
					if(GetNearestSoldier() != null)
						{targetSoldier = GetNearestSoldier();
						}
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
		else if(this.name == "Mercenery3(Clone)"){
			if(this.transform.position == bush3.transform.position && !isDead)
			{	
				sniperAnim.SetTrigger("MerceneryAiming");
				attackCounter -= Time.deltaTime;
				if (targetSoldier == null || targetSoldier.IsDead){
				
					if(GetNearestSoldier() != null)
						{targetSoldier = GetNearestSoldier();
						}
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
		else if(this.name == "Mercenery6(Clone)"){
			if(this.transform.position == bush4.transform.position && !isDead)
			{	
				sniperAnim.SetTrigger("MerceneryAiming");
				attackCounter -= Time.deltaTime;
				if (targetSoldier == null || targetSoldier.IsDead){
				
					if(GetNearestSoldier() != null)
						{targetSoldier = GetNearestSoldier();
						}
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
		else if(this.name == "Mercenery7(Clone)"){
			if(this.transform.position == bush5.transform.position && !isDead)
			{	
				sniperAnim.SetTrigger("MerceneryAiming");
				attackCounter -= Time.deltaTime;
				if (targetSoldier == null || targetSoldier.IsDead){
				
					if(GetNearestSoldier() != null)
						{targetSoldier = GetNearestSoldier();
						}
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
		else if(this.name == "Mercenery8(Clone)"){
			if(this.transform.position == bush6.transform.position && !isDead)
			{	
				sniperAnim.SetTrigger("MerceneryAiming");
				attackCounter -= Time.deltaTime;
				if (targetSoldier == null || targetSoldier.IsDead){
				
					if(GetNearestSoldier() != null)
						{targetSoldier = GetNearestSoldier();
						}
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
		
	}

	void FixedUpdate(){
		
		if(isAttacking && !isDead){
			sniperAnim.SetTrigger("MerceneryInBush");
			Shoot();
		}
			
	}

	public void Shoot(){
		GameManager.Instance.AudioSource.PlayOneShot(SoundManager.Instance.SniperBulletSound,1f);
		isAttacking = false;
		Projectile newProjectile = Instantiate(projectile) as Projectile;
		float xCord = (float)(transform.localPosition.x);
		float yCord = (float)(transform.localPosition.y);
		newProjectile.transform.position = new Vector2(xCord,yCord);
		if(targetSoldier == null){
			Destroy(newProjectile);
		} else {
			StartCoroutine(MoveProjectile(newProjectile));
		}
	}


	IEnumerator MoveProjectile(Projectile projectile){
		while(projectile != null && targetSoldier!= null){
			var dir = targetSoldier.transform.localPosition - transform.localPosition;
			var angleDirection = Mathf.Atan2(dir.y,dir.x)* Mathf.Rad2Deg;
			projectile.transform.rotation = Quaternion.AngleAxis(angleDirection, Vector3.forward);
			projectile.transform.localPosition = Vector2.MoveTowards(projectile.transform.localPosition,targetSoldier.transform.localPosition, 10f*Time.deltaTime);
			yield return null;
		}
		if (projectile != null || targetSoldier == null){
			Destroy(projectile);
		}
	}

	

	private List<Soldier> GetSoldiersInRange(){
		List<Soldier> soldierInRange = new List<Soldier>();
		foreach (Soldier soldier in SoldierManager.Instance.SoldierListUpLeft){
			soldierInRange.Add(soldier);
		}
		foreach (Soldier soldier in SoldierManager.Instance.SoldierListLeft){
			soldierInRange.Add(soldier);
		}
		foreach (Soldier soldier in SoldierManager.Instance.SoldierListButtomLeft){
			soldierInRange.Add(soldier);
		}
		foreach (Soldier soldier in SoldierManager.Instance.SoldierListUpRight){
			soldierInRange.Add(soldier);
		}
		foreach (Soldier soldier in SoldierManager.Instance.SoldierListRight){
			soldierInRange.Add(soldier);
		}
		foreach (Soldier soldier in SoldierManager.Instance.SoldierListButtomRight){
			soldierInRange.Add(soldier);
		}
		return soldierInRange;
	}

	private Soldier GetNearestSoldier(){
		Soldier nearestSoldier = null;
		float smallestDistance = float.PositiveInfinity;
		if(this.name == "Mercenery1(Clone)"){
			foreach(Soldier soldier in SoldierManager.Instance.SoldierListButtomLeft){
				if(Vector2.Distance(transform.localPosition,soldier.transform.localPosition)<smallestDistance){
					smallestDistance = Vector2.Distance(transform.localPosition,soldier.transform.localPosition);
					nearestSoldier = soldier;
				}
			}
		}
		else if(this.name == "Mercenery2(Clone)"){
			foreach(Soldier soldier in SoldierManager.Instance.SoldierListLeft){
				if(Vector2.Distance(transform.localPosition,soldier.transform.localPosition)<smallestDistance){
					smallestDistance = Vector2.Distance(transform.localPosition,soldier.transform.localPosition);
					nearestSoldier = soldier;
				}
			}
		}
		else if(this.name == "Mercenery3(Clone)"){
			foreach(Soldier soldier in SoldierManager.Instance.SoldierListUpLeft){
				if(Vector2.Distance(transform.localPosition,soldier.transform.localPosition)<smallestDistance){
					smallestDistance = Vector2.Distance(transform.localPosition,soldier.transform.localPosition);
					nearestSoldier = soldier;
				}
			}
		}
		else if(this.name == "Mercenery6(Clone)"){
			foreach(Soldier soldier in SoldierManager.Instance.SoldierListUpRight){
				if(Vector2.Distance(transform.localPosition,soldier.transform.localPosition)<smallestDistance){
					smallestDistance = Vector2.Distance(transform.localPosition,soldier.transform.localPosition);
					nearestSoldier = soldier;
				}
			}
		}
		else if(this.name == "Mercenery7(Clone)"){
			foreach(Soldier soldier in SoldierManager.Instance.SoldierListRight){
				if(Vector2.Distance(transform.localPosition,soldier.transform.localPosition)<smallestDistance){
					smallestDistance = Vector2.Distance(transform.localPosition,soldier.transform.localPosition);
					nearestSoldier = soldier;
				}
			}
		}
		else if(this.name == "Mercenery8(Clone)"){
			foreach(Soldier soldier in SoldierManager.Instance.SoldierListButtomRight){
				if(Vector2.Distance(transform.localPosition,soldier.transform.localPosition)<smallestDistance){
					smallestDistance = Vector2.Distance(transform.localPosition,soldier.transform.localPosition);
					nearestSoldier = soldier;
				}
			}
		}
		return nearestSoldier;

	}

	void OnTriggerEnter2D(Collider2D other){
		if(other.tag == "Bomb"){
			BombPumpkin newB = other.gameObject.GetComponent<BombPumpkin>();
			sniperHit(newB.AttackStrength);
			
		}	
		else if(other.tag == "DestroyAllBomb"){
			BombPumpkin newB = other.gameObject.GetComponent<BombPumpkin>();
			sniperHit(newB.AttackStrength);
		}
	}

	public void sniperHit(int hitPoints){
		if(healthPoints-hitPoints > 0){
			healthPoints -= hitPoints;
			healthBar.CurrentVal -= hitPoints;
		}else if (healthPoints-hitPoints<=0){
			healthBar.CurrentVal =0;
			die();
			sniperAnim.ResetTrigger("MerceneryAiming");
			sniperAnim.SetTrigger("MerceneryDied");
			
			Invoke("destorySniper",3f);
		}
	}

	public void die(){
		isDead = true;
		sniperCollider.enabled = false;
		// if(this.name == "Mercenery1(Clone)")
		// {
		// 	Destroy(bush1);
		// }
		// else if(this.name == "Mercenery2(Clone)")
		// {
		// 	Destroy(bush2);
		// }
		// else if(this.name == "Mercenery3(Clone)")
		// {
		// 	Destroy(bush3);
		// }
		// else if(this.name == "Mercenery6(Clone)")
		// {
		// 	Destroy(bush4);
		// }
		// else if(this.name == "Mercenery7(Clone)")
		// {
		// 	Destroy(bush5);
		// }
		// else if(this.name == "Mercenery8(Clone)")
		// {
		// 	Destroy(bush6);
		// }
	}

	public void destorySniper(){
		Destroy(this.gameObject);
	}
}
