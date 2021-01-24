using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour {
	
	[SerializeField]
	private float navigationUpdate;
	[SerializeField]
	private int healthPoints;
	[SerializeField]
	private int currentHealthPoints;
	[SerializeField]
	private float attackStrenght;
	[SerializeField]
	private float speed;
	[SerializeField]
	private Stat healthBar;
	private Rigidbody2D rb;

	public float AttackStrenght{
		get{
			return attackStrenght;
		}
	}

	private Transform enemy;
	private Collider2D enemyCollider;
	private Animator anim;
	private float navigationTime = 0;
	private bool isDead = false;
	private bool attackingSoldier = false;
	private bool damagingHouse= false;

	private AudioSource audio;

	
	
	private SpriteRenderer mySprite;
	

	public bool IsDead{
		get{
			return isDead;
		}
	}

	private void Awake(){
		healthBar.Initialize();
	}

	private GameObject houseEndPoint;

	IEnumerator hitColor()
	{
		anim.enabled = false;
 		mySprite.color = Color.red;
		yield return new WaitForSeconds(0.5f);
		mySprite.color = Color.white;
		anim.enabled = true;
	}

	 private GameObject canv2;
	 private RectTransform rectTransform;
     private Vector2 uiOffset;
	// Use this for initialization
	void Start () {
		canv2 = GameObject.Find("Canvasna");
		rectTransform = canv2.GetComponent<RectTransform>();
        this.uiOffset = new Vector2((float)rectTransform.sizeDelta.x / 2f, (float)rectTransform.sizeDelta.y / 2f);
		if(this.name.Contains("Bloch"))
		{
			audio = this.GetComponent<AudioSource>();
			if(PlayerPrefs.GetInt("sound") ==1){
				audio.enabled = true;
			}
			else if(PlayerPrefs.GetInt("sound") ==0)
			{
				audio.enabled = false;
			}
		}
		
		healthBar.MaxVal = healthPoints;
		healthBar.CurrentVal = healthPoints;
		mySprite = this.GetComponent<SpriteRenderer>();
		rb = GetComponent<Rigidbody2D>();
		currentHealthPoints = healthPoints;
		enemy = GetComponent<Transform>();
		enemyCollider = GetComponent<Collider2D>();
		GameManager.Instance.RegisterEnemy(this);
		anim = GetComponent<Animator>();
		speed=0.4f;
		
		if(this.name == "Bloch(Clone)" || this.name == "Mummy(Clone)" || this.name == "Scorpion(Clone)" || this.name == "Wolf(Clone)"){
			houseEndPoint = GameObject.Find("HouseEndPoint1");
		}
		else if(this.name == "BlochTopLeft(Clone)" || this.name == "MummyUpLeft(Clone)" || this.name == "ScorpionUpLeft(Clone)" || this.name == "WolfLeftUp(Clone)"){
			houseEndPoint = GameObject.Find("HouseEndPoint2");
		}
		else if(this.name == "BlochButtomLeft(Clone)" || this.name == "MummyButtomLeft(Clone)" || this.name == "ScorpionButtonLeft(Clone)" || this.name == "WolfLeftButtom(Clone)"){
			houseEndPoint = GameObject.Find("HouseEndPoint3");
		}
		else if(this.name == "BlochFromRight(Clone)" || this.name == "MummyRight(Clone)" || this.name == "ScorpionFromRight(Clone)" || this.name == "WolfRight(Clone)"){
			houseEndPoint = GameObject.Find("HouseEndPoint4");
		}
		else if(this.name == "BlochButtomRight(Clone)" || this.name == "MummyButtomRight(Clone)" || this.name == "ScorpionButtonRight(Clone)" || this.name == "WolfRightButtom(Clone)"){
			houseEndPoint = GameObject.Find("HouseEndPoint5");
		}
		else if(this.name == "BlochTopRight(Clone)" || this.name == "MummyUpRight(Clone)" || this.name == "ScorpionUpRight(Clone)" || this.name == "WolfRightUp(Clone)"){
			houseEndPoint = GameObject.Find("HouseEndPoint6");
		}
	}
	
	// Update is called once per frame
	void Update () {
		if(this.name.Contains("Bloch"))
		{
			if(PlayerPrefs.GetInt("sound") ==1){
				audio.enabled = true;
			}
			else if(PlayerPrefs.GetInt("sound") ==0)
			{
				audio.enabled = false;
			}
		}
		
		if (houseEndPoint!= null && !isDead){
			navigationTime += Time.deltaTime;
			if (navigationTime > navigationUpdate ){
				if (!attackingSoldier){//!SoldierDead(not made)
					moveTowards();
				}
				else{
					rb.velocity = new Vector2(0,0);
					
				}
				navigationTime = 0;
			}
		}

		if(soldierCollider!=null)
		{
			if(enemyCollider.IsTouching(soldierCollider))
				attackingSoldier = true;
			else	
				attackingSoldier = false;
		}
		else{
			attackingSoldier = false;
		}
	
		
	}

	public void moveTowards()
	{
		enemy.position = Vector2.MoveTowards(enemy.position, houseEndPoint.transform.position,(float)speed*navigationTime);
	}

	

	void OnTriggerEnter2D(Collider2D other){
		if(other.tag == "Projectile"){
			Projectile newP = other.gameObject.GetComponent<Projectile>();
			enemyHit(newP.AttackStrenght);
			if(other.name !="Bullet2(Clone)" && other.name !="Bullet4(Clone)")
			{	
				Destroy(other.gameObject);
			}
		}
		else if(other.tag == "DestroyAllBomb"){
			BombPumpkin newB = other.gameObject.GetComponent<BombPumpkin>();
			enemyHit(newB.AttackStrength);
		}
		else if(other.tag == "Explosion"){
			Explosion newE = other.gameObject.GetComponent<Explosion>();
			int attack = PlayerPrefs.GetInt("s11Bullet");
			enemyHit(attack);
		}
		else if(other.tag == "Warning"){
			Invoke("adjustSpeed",6f);
		}
	}

	public void adjustSpeed(){
		if(this.name.Contains("Bloch")){
			speed=0.3f;
		}
		else if(this.name.Contains("Mummy")){
			speed= 0.45f;
		}
		else if(this.name.Contains("Scorp")){
			speed= 0.7f;
		}
		else if(this.name.Contains("Wolf")){
			speed= 1.2f;
		}
	}

	private Collider2D soldierCollider;

	void OnTriggerStay2D(Collider2D other){
		if(other.tag == "House"){
			damagingHouse = true;
			
			anim.Play("Attacking");
		}
		else if(other.tag == "Soldier"){
			soldierCollider = other.GetComponent<Collider2D>();
			attackingSoldier = true;
			anim.Play("Attacking");
			Soldier newS = other.gameObject.GetComponent<Soldier>();
			Soldier newS2 = other.gameObject.GetComponent<Soldier>();
			if(newS.IsDead == true || newS2.IsDead == true){
				attackingSoldier = false;
				//moveTowards();
			}
		}
	}

	public void enemyHit(int hitPoints){
		StartCoroutine(hitColor());
		if(currentHealthPoints-hitPoints >= 0){
			currentHealthPoints -= hitPoints;
			healthBar.CurrentVal -= hitPoints;
		}else if (currentHealthPoints-hitPoints<0 && enemyCollider.enabled == true){
			healthBar.CurrentVal =0;
			enemyCollider.enabled = false;
			GameManager.Instance.TotalKilled +=1;
			GameManager.Instance.isLevelOver();
			Invoke("die",0.6f);
		}
	}

	public void die(){
		anim.SetTrigger("didDie");
		if(this.name.Contains("Wolf")){
			GameManager.Instance.AudioSource.PlayOneShot(SoundManager.Instance.WolfDead);
		}
		else if(this.name.Contains("Mummy")){
			GameManager.Instance.AudioSource.PlayOneShot(SoundManager.Instance.MummyDead);
		}
		else if(this.name.Contains("Scorp")){
			GameManager.Instance.AudioSource.PlayOneShot(SoundManager.Instance.ScorpionDead);
		}
		else if(this.name.Contains("Bloch")){
			GameManager.Instance.AudioSource.PlayOneShot(SoundManager.Instance.MummyDead);
		}
		isDead = true;
		GameObject extra1 = null;
		if(this.name.Contains("Wolf"))
		{
			extra1 = Instantiate(extraHouseHealth) as GameObject;
		}
		else 
		{
			extra1 = Instantiate(extraSoldierHealth) as GameObject;
		}
		extra1.transform.SetParent(canv2.transform, false);
		Vector2 viewportpos = Camera.main.WorldToViewportPoint(this.transform.position);
		Vector2 proportionalPosition = new Vector2(viewportpos.x * rectTransform.sizeDelta.x, viewportpos.y * rectTransform.sizeDelta.y);
		extra1.transform.localPosition = proportionalPosition - uiOffset;
		Invoke("dest",2f);
	}

	[SerializeField]
	private GameObject extraHouseHealth;
	[SerializeField]
	private GameObject extraSoldierHealth;

	public void dest(){
		Destroy(this.gameObject);
		GameManager.Instance.UnregisterEnemy(this);
	}

	
}
