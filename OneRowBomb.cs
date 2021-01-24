using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OneRowBomb : MonoBehaviour {
	private float navigationTime = 0;
	private float navigationUpdate = 0.02f;
	private Animator explosionAnim;
	public float fallSpeed = 1;
    public float spinSpeed = 2;
	public Rigidbody2D rb;
	private bool exploded = false;
	[SerializeField]
	private int attackStrength;
	[SerializeField]
	private GameObject explos;
	private GameObject e1;
	private GameObject e2;
	private GameObject e3;
	private GameObject e4;
	private GameObject e5;
	private GameObject e6;
	public GameObject LeftButtom1;
	public GameObject LeftButtom2;
	public GameObject LeftButtom3;
	public GameObject LeftButtom4;
	public GameObject LeftButtom5;
	public GameObject LeftButtom6;

	public GameObject Left1;
	public GameObject Left2;
	public GameObject Left3;
	public GameObject Left4;
	public GameObject Left5;
	public GameObject Left6;

	public GameObject LeftUp1;
	public GameObject LeftUp2;
	public GameObject LeftUp3;
	public GameObject LeftUp4;
	public GameObject LeftUp5;
	public GameObject LeftUp6;

	public GameObject RightButtom1;
	public GameObject RightButtom2;
	public GameObject RightButtom3;
	public GameObject RightButtom4;
	public GameObject RightButtom5;
	public GameObject RightButtom6;

	public GameObject Right1;
	public GameObject Right2;
	public GameObject Right3;
	public GameObject Right4;
	public GameObject Right5;
	public GameObject Right6;

	public GameObject RightUp1;
	public GameObject RightUp2;
	public GameObject RightUp3;
	public GameObject RightUp4;
	public GameObject RightUp5;
	public GameObject RightUp6;

	public GameObject Dynamite1;
	public GameObject Dynamite2;
	public GameObject Dynamite3;
	public GameObject Dynamite4;

	public int AttackStrength{
		get{
			return attackStrength;
		}
	}
	
	// Use this for initialization
	void Start () {
		explosionAnim = GetComponent<Animator>();
		rb = GetComponent<Rigidbody2D>();
		
		Dynamite1 = GameObject.Find("1");
		Dynamite2 = GameObject.Find("2");
		Dynamite3 = GameObject.Find("3");
		Dynamite4 = GameObject.Find("4");

		LeftButtom1 = GameObject.Find("StoneLB1");
		LeftButtom2 = GameObject.Find("StoneLB2");
		LeftButtom3 = GameObject.Find("StoneLB3");
		LeftButtom4 = GameObject.Find("StoneLB4");
		LeftButtom5 = GameObject.Find("StoneLB5");
		LeftButtom6 = GameObject.Find("StoneLB6");

		Left1 = GameObject.Find("StoneL1");
		Left2 = GameObject.Find("StoneL2");
		Left3 = GameObject.Find("StoneL3");
		Left4 = GameObject.Find("StoneL4");
		Left5 = GameObject.Find("StoneL5");
		Left6 = GameObject.Find("StoneL6");

		LeftUp1 = GameObject.Find("StoneLU1");
		LeftUp2 = GameObject.Find("StoneLU2");
		LeftUp3 = GameObject.Find("StoneLU3");
		LeftUp4 = GameObject.Find("StoneLU4");
		LeftUp5 = GameObject.Find("StoneLU5");
		LeftUp6 = GameObject.Find("StoneLU6");

		RightButtom1 = GameObject.Find("StoneRB1");
		RightButtom2 = GameObject.Find("StoneRB2");
		RightButtom3 = GameObject.Find("StoneRB3");
		RightButtom4 = GameObject.Find("StoneRB4");
		RightButtom5 = GameObject.Find("StoneRB5");
		RightButtom6 = GameObject.Find("StoneRB6");

		Right1 = GameObject.Find("StoneR1");
		Right2 = GameObject.Find("StoneR2");
		Right3 = GameObject.Find("StoneR3");
		Right4 = GameObject.Find("StoneR4");
		Right5 = GameObject.Find("StoneR5");
		Right6 = GameObject.Find("StoneR6");

		RightUp1 = GameObject.Find("StoneUR1");
		RightUp2 = GameObject.Find("StoneUR2");
		RightUp3 = GameObject.Find("StoneUR3");
		RightUp4 = GameObject.Find("StoneUR4");
		RightUp5 = GameObject.Find("StoneUR5");
		RightUp6 = GameObject.Find("StoneUR6");

		e1 = Instantiate(explos) as GameObject;
		e1.SetActive(false);
		e2 = Instantiate(explos) as GameObject;
		e2.SetActive(false);
		e3 = Instantiate(explos) as GameObject;
		e3.SetActive(false);
		e4 = Instantiate(explos) as GameObject;
		e4.SetActive(false);
		e5 = Instantiate(explos) as GameObject;
		e5.SetActive(false);
		e6 = Instantiate(explos) as GameObject;
		e6.SetActive(false);
		if(this.name == "DestroyOneRowBombLeftButtom(Clone)"){
			GameManager.Instance.AudioSource.PlayOneShot(SoundManager.Instance.SkullySound);
			attackStrength = PlayerPrefs.GetInt("s11Bullet");
			e1.transform.position = new Vector2(LeftButtom1.transform.position.x,LeftButtom1.transform.position.y-2);
			e2.transform.position = new Vector2(LeftButtom2.transform.position.x,LeftButtom2.transform.position.y-2);
			e3.transform.position = new Vector2(LeftButtom3.transform.position.x,LeftButtom3.transform.position.y-2);
			e4.transform.position = new Vector2(LeftButtom4.transform.position.x,LeftButtom4.transform.position.y-2);
			e5.transform.position = new Vector2(LeftButtom5.transform.position.x,LeftButtom5.transform.position.y-2);
			e6.transform.position = new Vector2(LeftButtom6.transform.position.x,LeftButtom6.transform.position.y-2);
			Invoke("didExplode", 1f);
			Invoke("playExplosion",1f);
			Invoke("dest", 2.95f);
		}
		else if(this.name == "DestroyOneRowBombLeft(Clone)"){
			GameManager.Instance.AudioSource.PlayOneShot(SoundManager.Instance.SkullySound);
			attackStrength = PlayerPrefs.GetInt("s11Bullet");
			e1.transform.position = new Vector2(Left1.transform.position.x,Left1.transform.position.y-2);
			e2.transform.position = new Vector2(Left2.transform.position.x,Left2.transform.position.y-2);
			e3.transform.position = new Vector2(Left3.transform.position.x,Left3.transform.position.y-2);
			e4.transform.position = new Vector2(Left4.transform.position.x,Left4.transform.position.y-2);
			e5.transform.position = new Vector2(Left5.transform.position.x,Left5.transform.position.y-2);
			e6.transform.position = new Vector2(Left6.transform.position.x,Left6.transform.position.y-2);
			Invoke("didExplode", 1f);
			Invoke("playExplosion",1f);
			Invoke("dest", 2.95f);
		}
		else if(this.name == "DestroyOneRowBombLeftUp(Clone)"){
			GameManager.Instance.AudioSource.PlayOneShot(SoundManager.Instance.SkullySound,3f);
			attackStrength = PlayerPrefs.GetInt("s11Bullet");
			e1.transform.position = new Vector2(LeftUp1.transform.position.x,LeftUp1.transform.position.y-2);
			e2.transform.position = new Vector2(LeftUp2.transform.position.x,LeftUp2.transform.position.y-2);
			e3.transform.position = new Vector2(LeftUp3.transform.position.x,LeftUp3.transform.position.y-2);
			e4.transform.position = new Vector2(LeftUp4.transform.position.x,LeftUp4.transform.position.y-2);
			e5.transform.position = new Vector2(LeftUp5.transform.position.x,LeftUp5.transform.position.y-2);
			e6.transform.position = new Vector2(LeftUp6.transform.position.x,LeftUp6.transform.position.y-2);
			Invoke("didExplode", 1f);
			Invoke("playExplosion",1f);
			Invoke("dest", 2.95f);
		}
		else if(this.name == "DestroyOneRowBombRightButtom(Clone)"){
			GameManager.Instance.AudioSource.PlayOneShot(SoundManager.Instance.SkullySound,3f);
			attackStrength = PlayerPrefs.GetInt("s11Bullet");
			e1.transform.position = new Vector2(RightButtom1.transform.position.x,RightButtom1.transform.position.y-2);
			e2.transform.position = new Vector2(RightButtom2.transform.position.x,RightButtom2.transform.position.y-2);
			e3.transform.position = new Vector2(RightButtom3.transform.position.x,RightButtom3.transform.position.y-2);
			e4.transform.position = new Vector2(RightButtom4.transform.position.x,RightButtom4.transform.position.y-2);
			e5.transform.position = new Vector2(RightButtom5.transform.position.x,RightButtom5.transform.position.y-2);
			e6.transform.position = new Vector2(RightButtom6.transform.position.x,RightButtom6.transform.position.y-2);
			Invoke("didExplode", 1f);
			Invoke("playExplosion",1f);
			Invoke("dest", 2.95f);
		}
		else if(this.name == "DestroyOneRowBombRight(Clone)"){
			GameManager.Instance.AudioSource.PlayOneShot(SoundManager.Instance.SkullySound,3f);
			attackStrength = PlayerPrefs.GetInt("s11Bullet");
			e1.transform.position = new Vector2(Right1.transform.position.x,Right1.transform.position.y-2);
			e2.transform.position = new Vector2(Right2.transform.position.x,Right2.transform.position.y-2);
			e3.transform.position = new Vector2(Right3.transform.position.x,Right3.transform.position.y-2);
			e4.transform.position = new Vector2(Right4.transform.position.x,Right4.transform.position.y-2);
			e5.transform.position = new Vector2(Right5.transform.position.x,Right5.transform.position.y-2);
			e6.transform.position = new Vector2(Right6.transform.position.x,Right6.transform.position.y-2);
			Invoke("didExplode", 1f);
			Invoke("playExplosion",1f);
			Invoke("dest", 2.95f);
		}
		else if(this.name == "DestroyOneRowBombRightUp(Clone)"){
			GameManager.Instance.AudioSource.PlayOneShot(SoundManager.Instance.SkullySound,3f);
			attackStrength = PlayerPrefs.GetInt("s11Bullet");
			e1.transform.position = new Vector2(RightUp1.transform.position.x,RightUp1.transform.position.y-2);
			e2.transform.position = new Vector2(RightUp2.transform.position.x,RightUp2.transform.position.y-2);
			e3.transform.position = new Vector2(RightUp3.transform.position.x,RightUp3.transform.position.y-2);
			e4.transform.position = new Vector2(RightUp4.transform.position.x,RightUp4.transform.position.y-2);
			e5.transform.position = new Vector2(RightUp5.transform.position.x,RightUp5.transform.position.y-2);
			e6.transform.position = new Vector2(RightUp6.transform.position.x,RightUp6.transform.position.y-2);
			Invoke("didExplode", 1f);
			Invoke("playExplosion",1f);
			Invoke("dest", 2.95f);
			
		}
		else if(this.name == "DynamiteMerc1(Clone)"){
			GameManager.Instance.AudioSource.PlayOneShot(SoundManager.Instance.GranadeSound,3f);
			attackStrength = PlayerPrefs.GetInt("s9Bullet");
			Destroy(e2);
			Destroy(e3);
			Destroy(e4);
			Destroy(e5);
			Destroy(e6);
			e1.transform.position = new Vector2(Dynamite1.transform.position.x,Dynamite1.transform.position.y-2);
			Invoke("didExplode", 1.8f);
			Invoke("play",1.8f);
			Invoke("dest", 2.95f);
		}
		else if(this.name == "DynamiteMerc2(Clone)"){
			GameManager.Instance.AudioSource.PlayOneShot(SoundManager.Instance.GranadeSound,3f);
			attackStrength = PlayerPrefs.GetInt("s9Bullet");
			Destroy(e2);
			Destroy(e3);
			Destroy(e4);
			Destroy(e5);
			Destroy(e6);
			e1.transform.position = new Vector2(Dynamite2.transform.position.x,Dynamite2.transform.position.y-2);
			Invoke("didExplode", 1.8f);
			Invoke("play",1.8f);
			Invoke("dest", 2.95f);
		}
		else if(this.name == "DynamiteMerc3(Clone)"){
			GameManager.Instance.AudioSource.PlayOneShot(SoundManager.Instance.GranadeSound,3f);
			attackStrength = PlayerPrefs.GetInt("s9Bullet");
			Destroy(e2);
			Destroy(e3);
			Destroy(e4);
			Destroy(e5);
			Destroy(e6);
			e1.transform.position = new Vector2(Dynamite3.transform.position.x,Dynamite3.transform.position.y-2);
			Invoke("didExplode", 1.8f);
			Invoke("play",1.8f);
			Invoke("dest", 2.95f);
		}
		else if(this.name == "DynamiteMerc4(Clone)"){
			GameManager.Instance.AudioSource.PlayOneShot(SoundManager.Instance.GranadeSound,3f);
			attackStrength = PlayerPrefs.GetInt("s9Bullet");
			Destroy(e2);
			Destroy(e3);
			Destroy(e4);
			Destroy(e5);
			Destroy(e6);
			e1.transform.position = new Vector2(Dynamite4.transform.position.x,Dynamite4.transform.position.y-2);
			Invoke("didExplode", 1.8f);
			Invoke("play",1.8f);
			Invoke("dest", 2.95f);
		}

		
		
	}
	
	// Update is called once per frame
	void Update () {
		if(this.name.Contains("Destroy")){
			if (!exploded){
				transform.Translate(Vector3.down * fallSpeed * Time.deltaTime, Space.World);
        		transform.Rotate(Vector3.forward, spinSpeed * Time.deltaTime);
			}
			else{
				rb.velocity = new Vector2(0,0);
			}
		}
		else if(this.name == "DynamiteMerc1(Clone)"){
			if(!exploded){
				if (Dynamite1 != null){
					navigationTime += Time.deltaTime;
					if (navigationTime > navigationUpdate ){
						this.transform.position = Vector2.MoveTowards(this.transform.position, Dynamite1.transform.position,(float)2*navigationTime);
						navigationTime = 0;
					}
				}
			}
		}
		else if(this.name == "DynamiteMerc2(Clone)"){
			if(!exploded){
				if (Dynamite2 != null){
					navigationTime += Time.deltaTime;
					if (navigationTime > navigationUpdate ){
						this.transform.position = Vector2.MoveTowards(this.transform.position, Dynamite2.transform.position,(float)2*navigationTime);
						navigationTime = 0;
					}
				}
			}
		}
		else if(this.name == "DynamiteMerc3(Clone)"){
			if(!exploded){
				if (Dynamite3 != null){
					navigationTime += Time.deltaTime;
					if (navigationTime > navigationUpdate ){
						this.transform.position = Vector2.MoveTowards(this.transform.position, Dynamite3.transform.position,(float)2*navigationTime);
						navigationTime = 0;
					}
				}
			}
		}
		else if(this.name == "DynamiteMerc4(Clone)"){
			if(!exploded){
				if (Dynamite4 != null){
					navigationTime += Time.deltaTime;
					if (navigationTime > navigationUpdate ){
						this.transform.position = Vector2.MoveTowards(this.transform.position, Dynamite4.transform.position,(float)2*navigationTime);
						navigationTime = 0;
					}
				}
			}
		}
		
		
	}

	public void playExplosion(){
		this.gameObject.SetActive(false);
		Invoke("e1act",0.1f);
		Invoke("dest1",0.4f);
		Invoke("e2act",0.4f);
		Invoke("dest2",0.7f);
		Invoke("e3act",0.7f);
		Invoke("dest3",1f);
		Invoke("e4act",1f);
		Invoke("dest4",1.3f);
		Invoke("e5act",1.3f);
		Invoke("dest5",1.6f);
		Invoke("e6act",1.6f);
		Invoke("dest6",1.9f);
	}

	public void play(){
		this.gameObject.SetActive(false);
		e1.SetActive(true);
		Invoke("dest1",0.4f);
	}

	public void e1act()
	{
		e1.SetActive(true);
		GameManager.Instance.AudioSource.PlayOneShot(SoundManager.Instance.SkullySound,3f);
	}

	public void e2act()
	{
		e2.SetActive(true);
		GameManager.Instance.AudioSource.PlayOneShot(SoundManager.Instance.SkullySound,3f);
	}

	public void e3act()
	{
		e3.SetActive(true);
		GameManager.Instance.AudioSource.PlayOneShot(SoundManager.Instance.SkullySound,3f);
	}

	public void e4act()
	{
		e4.SetActive(true);
		GameManager.Instance.AudioSource.PlayOneShot(SoundManager.Instance.SkullySound,3f);
	}

	public void e5act()
	{
		e5.SetActive(true);
		GameManager.Instance.AudioSource.PlayOneShot(SoundManager.Instance.SkullySound,3f);
	}

	public void e6act()
	{
		e6.SetActive(true);
		GameManager.Instance.AudioSource.PlayOneShot(SoundManager.Instance.SkullySound,3f);
	}

	public void dest1()
	{
		Destroy(e1);
	}

	public void dest2()
	{
		Destroy(e2);
	}

	public void dest3()
	{
		Destroy(e3);
	}

	public void dest4()
	{
		Destroy(e4);
	}

	public void dest5()
	{
		Destroy(e5);
	}

	public void dest6()
	{
		Destroy(e6);
	}

	public void dest(){
		Destroy(this.gameObject);
	}

	public void didExplode(){
		exploded = true;
	}
}
