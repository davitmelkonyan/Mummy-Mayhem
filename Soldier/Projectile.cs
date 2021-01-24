using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum proType{
	bullet, bullet2, bullet3 , bullet4, bullet5, bullet6, bullet7, bullet8, SniperBullet
};

public class Projectile : MonoBehaviour {
	[SerializeField]
	private int attackStrenght;
	[SerializeField]
	private proType projectileType;
	private Animator bulletAnim;
	private Rigidbody2D rb;
	private Vector2 v;
	

	
	void Start(){
		if(PlayerPrefs.HasKey("bullet3Sound")==true)
			PlayerPrefs.DeleteKey("bullet3Sound");

		if(this.name == "Bullet1(Clone)")
		{	attackStrenght=PlayerPrefs.GetInt("s1Bullet");;
			GameManager.Instance.AudioSource.PlayOneShot(SoundManager.Instance.S1Shooting,0.2f);
		}
		else if(this.name == "Bullet2(Clone)")
		{
			attackStrenght = PlayerPrefs.GetInt("s2Bullet");
			GameManager.Instance.AudioSource.PlayOneShot(SoundManager.Instance.RocketLuncher2,0.8f);
		}
		else if(this.name == "Bullet3(Clone)")
		{
			attackStrenght = PlayerPrefs.GetInt("s3Bullet");
			GameManager.Instance.AudioSource.PlayOneShot(SoundManager.Instance.S3BulletSound,1f);	
		}
			
		else if(this.name == "Bullet4(Clone)")
		{
			attackStrenght = PlayerPrefs.GetInt("s4Bullet");
			GameManager.Instance.AudioSource.PlayOneShot(SoundManager.Instance.S4BulletSound,1f);	
		}
		else if(this.name == "Bullet5(Clone)")
		{
			attackStrenght = PlayerPrefs.GetInt("s5Bullet");
			GameManager.Instance.AudioSource.PlayOneShot(SoundManager.Instance.S5BulletSound,1f);
		}
		else if(this.name == "Bullet6(Clone)"){
			attackStrenght = PlayerPrefs.GetInt("s6Bullet");
			GameManager.Instance.AudioSource.PlayOneShot(SoundManager.Instance.S6BulletSound,1f);
		}
		else if(this.name == "Bullet7(Clone)"){
			attackStrenght = PlayerPrefs.GetInt("s7Bullet");
			GameManager.Instance.AudioSource.PlayOneShot(SoundManager.Instance.S7BulletSound,1f);
		}
		else if(this.name == "Bullet8(Clone)"){
			attackStrenght = PlayerPrefs.GetInt("s8Bullet");
			GameManager.Instance.AudioSource.PlayOneShot(SoundManager.Instance.S8BulletSound,1f);
		}
		else if(this.name == "MercProj(Clone)"){
			GameManager.Instance.AudioSource.PlayOneShot(SoundManager.Instance.Merc1Bullet,1f);
		}
		else if(this.name == "MercProj2(Clone)"){
			GameManager.Instance.AudioSource.PlayOneShot(SoundManager.Instance.S3BulletSound,1f);
		}
		else if(this.name == "MercProj3(Clone)"){
			GameManager.Instance.AudioSource.PlayOneShot(SoundManager.Instance.S4BulletSound,1f);
		}
		else if(this.name == "MercProj4(Clone)"){
			GameManager.Instance.AudioSource.PlayOneShot(SoundManager.Instance.S7BulletSound,1f);
		}
		else if(this.name == "SniperBullet(Clone)"){
			GameManager.Instance.AudioSource.PlayOneShot(SoundManager.Instance.SniperBullet,1f);
		}
		v = new Vector2(0,0);
		bulletAnim = GetComponent<Animator>();
		rb = GetComponent<Rigidbody2D>();
	}

	void Update(){
		Invoke("check",0.5f);
		
	}
	public int AttackStrenght{
		get{
			return attackStrenght;
		}
	}

	public proType ProjectileType{
		get{
			return projectileType;
		}
	}

	public void exp()
	{
		bulletAnim.SetTrigger("explode");
		this.transform.localScale = new Vector3(transform.localScale.x/2, transform.localScale.y/2, transform.localScale.z/2);
	}

	void OnTriggerEnter2D(Collider2D other){
		if((this.name=="MercProj(Clone)" || this.name=="MercProj2(Clone)" || this.name=="MercProj3(Clone)" || this.name=="MercProj4(Clone)") && other.tag == "a"){
			bulletAnim.SetTrigger("explosion");
			Invoke("dest",2.2f);
		}
		else if((this.name.Contains("Merc") && other.tag == "SoldAgainstM") || (this.name.Contains("Bullet") && (other.tag == "Enemy" || other.tag == "Mercenery")))
		{	
			if(this.name == "Bullet2(Clone)")
			{
				bulletAnim.SetTrigger("explode");
				Invoke("dest",1f);
			}
			else if(this.name == "Bullet4(Clone)")
			{
				Invoke("exp",0.5f);
				Invoke("dest",1.2f);
			}
			else
			{
			    Invoke("dest",0.05f);
			}
		}
	
	}

	public void dest(){
		Destroy(this.gameObject);
	}

	public void check(){
		if(rb.velocity == v && (this.name !="Bullet2(Clone)" && this.name !="Bullet4(Clone)")){
			dest();
		}
	}

	


}
