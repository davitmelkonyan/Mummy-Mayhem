using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Merc2 : MonoBehaviour {
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
	private Animator mercAnim;
	private bool isDead = false;
	private Collider2D mercCollider;
	private Transform Merc;
	private float navigationTime = 0;
	private bool reachedTheBush = false;
	public GameObject house;

	[SerializeField]
	private Stat healthBar;
	

	public bool IsDead{
		get{
			return isDead;
		}
	}

	private GameObject point1;
	private GameObject point2;
	private GameObject point3;
	private GameObject point4;

	private void Awake(){
		healthBar.Initialize();
	}
	// Use this for initialization
	void Start () {
		mercAnim = GetComponent<Animator>();
		mercCollider = GetComponent<Collider2D>();
		Merc = GetComponent<Transform>();
		house = GameObject.Find("House 1");
		GameManager.Instance.RegisterMercenery(this);

		healthBar.MaxVal = healthPoints;
		healthBar.CurrentVal = healthPoints;

		point1 = GameObject.Find("1");
		point2 = GameObject.Find("2");
		point3 = GameObject.Find("3");
		point4 = GameObject.Find("4");
	}
	

	
	
	void Update () {
		if (point1!= null && point2!=null && point3!=null && point4!=null && !isDead){
			navigationTime += Time.deltaTime;
			if (navigationTime > navigationUpdate ){
				if(this.name == "Merc21(Clone)" || this.name == "Merc31(Clone)" || this.name == "Merc41(Clone)" || this.name == "Merc51(Clone)" )
					Merc.position = Vector2.MoveTowards(Merc.position, point1.transform.position,(float)speed*navigationTime);
				else if(this.name == "Merc22(Clone)" || this.name == "Merc32(Clone)" || this.name == "Merc42(Clone)" || this.name == "Merc52(Clone)" )
					Merc.position = Vector2.MoveTowards(Merc.position, point2.transform.position,(float)speed*navigationTime);
				else if(this.name == "Merc23(Clone)" || this.name == "Merc33(Clone)" || this.name == "Merc43(Clone)" || this.name == "Merc53(Clone)" )
					Merc.position = Vector2.MoveTowards(Merc.position, point3.transform.position,(float)speed*navigationTime);
				else if(this.name == "Merc24(Clone)" || this.name == "Merc34(Clone)" || this.name == "Merc44(Clone)" || this.name == "Merc54(Clone)" )
					Merc.position = Vector2.MoveTowards(Merc.position, point4.transform.position,(float)speed*navigationTime);
				navigationTime = 0;
			}
		}
		if(this.name == "Merc21(Clone)" || this.name == "Merc31(Clone)" || this.name == "Merc41(Clone)" || this.name == "Merc51(Clone)" )
		{
			if(this.transform.position == point1.transform.position && !isDead)
			{
				
				mercAnim.SetTrigger("CrouchShoot");
				attackCounter -= Time.deltaTime;
				if (!GameManager.Instance.HouseDown){
					if(attackCounter <= 0 ){
						isAttacking = true;
						attackCounter = timeBetweenAttacks;
					}else{
						isAttacking = false;
					}
					
				} 
			
			}
		}
		else if(this.name == "Merc22(Clone)" || this.name == "Merc32(Clone)" || this.name == "Merc42(Clone)" || this.name == "Merc52(Clone)" )
		{
			if(this.transform.position == point2.transform.position && !isDead)
			{
				
				mercAnim.SetTrigger("CrouchShoot");
				attackCounter -= Time.deltaTime;
				if (!GameManager.Instance.HouseDown){
					if(attackCounter <= 0 ){
						isAttacking = true;
						attackCounter = timeBetweenAttacks;
					}else{
						isAttacking = false;
					}
					
				} 
			
			}
		}
		else if(this.name == "Merc23(Clone)" || this.name == "Merc33(Clone)" || this.name == "Merc43(Clone)" || this.name == "Merc53(Clone)" )
		{
			if(this.transform.position == point3.transform.position && !isDead)
			{
				
				mercAnim.SetTrigger("CrouchShoot");
				attackCounter -= Time.deltaTime;
				if (!GameManager.Instance.HouseDown){
					if(attackCounter <= 0 ){
						isAttacking = true;
						attackCounter = timeBetweenAttacks;
					}else{
						isAttacking = false;
					}
					
				} 
			
			}
		}
		else if(this.name == "Merc24(Clone)" || this.name == "Merc34(Clone)" || this.name == "Merc44(Clone)" || this.name == "Merc54(Clone)" )
		{
			if(this.transform.position == point4.transform.position && !isDead)
			{
				
				mercAnim.SetTrigger("CrouchShoot");
				attackCounter -= Time.deltaTime;
				if (!GameManager.Instance.HouseDown){
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
			
			mercAnim.SetTrigger("CrouchShoot");
			Shoot();
		}
			
	}

	public void Shoot(){
		isAttacking = false;
		Projectile newProjectile = Instantiate(projectile) as Projectile;
		if (this.name == "Merc21(Clone)" || this.name == "Merc31(Clone)" || this.name == "Merc41(Clone)" || this.name == "Merc51(Clone)"){
			float xCord = (float)(transform.localPosition.x+0.1);
			float yCord = (float)(transform.localPosition.y);
			newProjectile.transform.position = new Vector2(xCord,yCord);
			if(SoldierManager.Instance.SoldierMiddle2.Count!=0)	
				Physics2D.IgnoreCollision(newProjectile.GetComponent<Collider2D>(), SoldierManager.Instance.SoldierMiddle2[0].GetComponent<Collider2D>());
			if(SoldierManager.Instance.SoldierMiddle3.Count!=0)	
				Physics2D.IgnoreCollision(newProjectile.GetComponent<Collider2D>(), SoldierManager.Instance.SoldierMiddle3[0].GetComponent<Collider2D>());
			if(SoldierManager.Instance.SoldierMiddle4.Count!=0)	
				Physics2D.IgnoreCollision(newProjectile.GetComponent<Collider2D>(), SoldierManager.Instance.SoldierMiddle4[0].GetComponent<Collider2D>());	
		}
		else if (this.name == "Merc22(Clone)" || this.name == "Merc32(Clone)" || this.name == "Merc42(Clone)" || this.name == "Merc52(Clone)"){
			float xCord = (float)(transform.localPosition.x+0.3);
			float yCord = (float)(transform.localPosition.y+0.2);
			newProjectile.transform.position = new Vector2(xCord,yCord);
			if(SoldierManager.Instance.SoldierMiddle1.Count!=0)	
				Physics2D.IgnoreCollision(newProjectile.GetComponent<Collider2D>(), SoldierManager.Instance.SoldierMiddle1[0].GetComponent<Collider2D>());
			if(SoldierManager.Instance.SoldierMiddle2.Count!=0)	
				Physics2D.IgnoreCollision(newProjectile.GetComponent<Collider2D>(), SoldierManager.Instance.SoldierMiddle2[0].GetComponent<Collider2D>());
			if(SoldierManager.Instance.SoldierMiddle4.Count!=0)	
				Physics2D.IgnoreCollision(newProjectile.GetComponent<Collider2D>(), SoldierManager.Instance.SoldierMiddle4[0].GetComponent<Collider2D>());	
		}
		else if (this.name == "Merc23(Clone)" || this.name == "Merc33(Clone)" || this.name == "Merc43(Clone)" || this.name == "Merc53(Clone)"){
			float xCord = (float)(transform.localPosition.x-0.35);
			float yCord = (float)(transform.localPosition.y+0.2);
			newProjectile.transform.position = new Vector2(xCord,yCord);
			if(SoldierManager.Instance.SoldierMiddle1.Count!=0)	
				Physics2D.IgnoreCollision(newProjectile.GetComponent<Collider2D>(), SoldierManager.Instance.SoldierMiddle1[0].GetComponent<Collider2D>());
			if(SoldierManager.Instance.SoldierMiddle2.Count!=0)	
				Physics2D.IgnoreCollision(newProjectile.GetComponent<Collider2D>(), SoldierManager.Instance.SoldierMiddle2[0].GetComponent<Collider2D>());
			if(SoldierManager.Instance.SoldierMiddle3.Count!=0)	
				Physics2D.IgnoreCollision(newProjectile.GetComponent<Collider2D>(), SoldierManager.Instance.SoldierMiddle3[0].GetComponent<Collider2D>());	
		}
		else if (this.name == "Merc24(Clone)" || this.name == "Merc34(Clone)" || this.name == "Merc44(Clone)" || this.name == "Merc54(Clone)"){
			float xCord = (float)(transform.localPosition.x-0.4);
			float yCord = (float)(transform.localPosition.y+0.2);
			newProjectile.transform.position = new Vector2(xCord,yCord);
			if(SoldierManager.Instance.SoldierMiddle1.Count!=0)	
				Physics2D.IgnoreCollision(newProjectile.GetComponent<Collider2D>(), SoldierManager.Instance.SoldierMiddle1[0].GetComponent<Collider2D>());
			if(SoldierManager.Instance.SoldierMiddle3.Count!=0)	
				Physics2D.IgnoreCollision(newProjectile.GetComponent<Collider2D>(), SoldierManager.Instance.SoldierMiddle3[0].GetComponent<Collider2D>());
			if(SoldierManager.Instance.SoldierMiddle4.Count!=0)	
				Physics2D.IgnoreCollision(newProjectile.GetComponent<Collider2D>(), SoldierManager.Instance.SoldierMiddle4[0].GetComponent<Collider2D>());	
		}

		if(GameManager.Instance.HouseDown){
			Destroy(newProjectile);
		} else {
			StartCoroutine(MoveProjectile(newProjectile));
		}
	}


	IEnumerator MoveProjectile(Projectile projectile){
		if(((this.name == "Merc21(Clone)" || this.name == "Merc31(Clone)" || this.name == "Merc41(Clone)" || this.name == "Merc51(Clone)") && SoldierManager.Instance.SoldierMiddle1.Count ==0) ||
		   ((this.name == "Merc22(Clone)" || this.name == "Merc32(Clone)" || this.name == "Merc42(Clone)" || this.name == "Merc52(Clone)") && SoldierManager.Instance.SoldierMiddle3.Count ==0) ||
		   ((this.name == "Merc23(Clone)" || this.name == "Merc33(Clone)" || this.name == "Merc43(Clone)" || this.name == "Merc53(Clone)") && SoldierManager.Instance.SoldierMiddle4.Count ==0) ||
		   ((this.name == "Merc24(Clone)" || this.name == "Merc34(Clone)" || this.name == "Merc44(Clone)" || this.name == "Merc54(Clone)") && SoldierManager.Instance.SoldierMiddle2.Count ==0)){
			while(projectile != null && !GameManager.Instance.HouseDown){
				var dir = house.transform.localPosition - transform.localPosition;
				var angleDirection = Mathf.Atan2(dir.y,dir.x)* Mathf.Rad2Deg;
				projectile.transform.rotation = Quaternion.AngleAxis(angleDirection, Vector3.forward);
				projectile.transform.localPosition = Vector2.MoveTowards(projectile.transform.localPosition,house.transform.localPosition, 7f*Time.deltaTime);
				yield return null;
			}
		}
		else{
			while(projectile != null && GetNearestSoldier()!= null){
				var dir = GetNearestSoldier().transform.localPosition - transform.localPosition;
				var angleDirection = Mathf.Atan2(dir.y,dir.x)* Mathf.Rad2Deg;
				projectile.transform.rotation = Quaternion.AngleAxis(angleDirection, Vector3.forward);
				projectile.transform.localPosition = Vector2.MoveTowards(projectile.transform.localPosition,GetNearestSoldier().transform.localPosition, 10f*Time.deltaTime);
				yield return null;
			}
			if (projectile != null || GetNearestSoldier() == null){
				Destroy(projectile);
			}
		}
		
		if (projectile != null){
			Destroy(projectile);
		}
	}

	private Soldier GetNearestSoldier(){
		Soldier nearestSoldier = null;
		if (this.name == "Merc21(Clone)" || this.name == "Merc31(Clone)" || this.name == "Merc41(Clone)" || this.name == "Merc51(Clone)")
		{	if(SoldierManager.Instance.SoldierMiddle1.Count!=0)
				nearestSoldier = SoldierManager.Instance.SoldierMiddle1[0];
		}
		if (this.name == "Merc22(Clone)" || this.name == "Merc32(Clone)" || this.name == "Merc42(Clone)" || this.name == "Merc52(Clone)")
		{	if(SoldierManager.Instance.SoldierMiddle3.Count!=0)
				nearestSoldier = SoldierManager.Instance.SoldierMiddle3[0];
		}
		if (this.name == "Merc23(Clone)" || this.name == "Merc33(Clone)" || this.name == "Merc43(Clone)" || this.name == "Merc53(Clone)")
		{	if(SoldierManager.Instance.SoldierMiddle4.Count!=0)
				nearestSoldier = SoldierManager.Instance.SoldierMiddle4[0];
		}
		if (this.name == "Merc24(Clone)" || this.name == "Merc34(Clone)" || this.name == "Merc44(Clone)" || this.name == "Merc54(Clone)")
		{	if(SoldierManager.Instance.SoldierMiddle2.Count!=0)
				nearestSoldier = SoldierManager.Instance.SoldierMiddle2[0];
		}
		return nearestSoldier;
	}
		

	void OnTriggerEnter2D(Collider2D other){
		if(other.tag == "Projectile"){
			Projectile newP = other.gameObject.GetComponent<Projectile>();
			mercHit(newP.AttackStrenght);
		}
		else if(other.tag == "DestroyAllBomb"){
			BombPumpkin newB = other.gameObject.GetComponent<BombPumpkin>();
			mercHit(newB.AttackStrength);
		}
		else if(other.tag == "Explosion"){
			Explosion newE = other.gameObject.GetComponent<Explosion>();
			int attack = PlayerPrefs.GetInt("s9Bullet");
			mercHit(attack);
		}
	}

	public void mercHit(int hitPoints){
		if(healthPoints-hitPoints > 0){
			healthPoints -= hitPoints;
			healthBar.CurrentVal -= hitPoints;
		}else if (healthPoints-hitPoints<=0){
			healthBar.CurrentVal =0;
			GameManager.Instance.TotalMerceneriesKilled +=1;
			GameManager.Instance.AudioSource.PlayOneShot(SoundManager.Instance.MercDead,2.5f);
			die();
			mercAnim.SetTrigger("M2Dead");
			if((this.name == "Merc21(Clone)" || this.name == "Merc22(Clone)" || this.name == "Merc23(Clone)" || this.name == "Merc24(Clone)") && PlayerPrefs.GetInt("mercIntro")==2)
			{
				Invoke("a",2f);
			}
			Invoke("destoryMerc",3f);
		}
	}

	public void a()
	{
		SoldierManager.Instance.lateShowMenu();
		SoldierManager.Instance.maximize();
		PlayerPrefs.SetInt("mercIntro",3);
	}

	public void die(){
		isDead = true;
		mercCollider.enabled = false;
		GameManager.Instance.isLevelOver();
		Invoke("destoryMerc",2.5f);
	}

	public void destoryMerc(){
		GameManager.Instance.UnregisterMercenery(this);
		Destroy(this.gameObject);
	}
}
