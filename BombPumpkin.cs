using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombPumpkin : MonoBehaviour {
	private Animator explosionAnim;
	public float fallSpeed = 1;
    public float spinSpeed = 2;
	public Rigidbody2D rb;
	private bool exploded = false;
	[SerializeField]
	private int attackStrength;
	[SerializeField]
	private GameObject explos;
	private GameObject e;

	public int AttackStrength{
		get{
			return attackStrength;
		}
	}
	
	// Use this for initialization
	void Start () {

		explosionAnim = GetComponent<Animator>();
		rb = GetComponent<Rigidbody2D>();

		if(this.name == "BombPumpk(Clone)"){
			GameManager.Instance.AudioSource.PlayOneShot(SoundManager.Instance.PumpkinSound,5f);
			attackStrength = PlayerPrefs.GetInt("s10Bullet");
			Invoke("playExplosion",1f);
			Invoke("didExplode", 1.1f);
			Invoke("des", 1.45f);
		}
		else if(this.name == "DestroyAllBomb(Clone)"){
			GameManager.Instance.AudioSource.PlayOneShot(SoundManager.Instance.KnightSound,4f);
			attackStrength = 1000000;
			e = Instantiate(explos) as GameObject;
			float xCord = (float)(transform.position.x +4);
			float yCord = (float)(transform.position.y + 2.7);
			e.transform.position = new Vector2(xCord,yCord);
			e.SetActive(false);
			Invoke("didExplode", 0.59f);
			Invoke("playExplosion2", 1.15f);
			Invoke("dest", 1.7f);
		}
		

		
		
	}
	
	// Update is called once per frame
	void Update () {
		if (!exploded){
			transform.Translate(Vector3.down * fallSpeed * Time.deltaTime, Space.World);
        	transform.Rotate(Vector3.forward, spinSpeed * Time.deltaTime);
		}
		else{
			rb.velocity = new Vector2(0,0);
		}
		
	}

	public void playExplosion2(){
		e.SetActive(true);
	}

	public void playExplosion(){
		explosionAnim.SetTrigger("Explosion");
	}

	public void des(){
		Destroy(this.gameObject);
	}

	public void dest(){
		Destroy(this.gameObject);
		e.SetActive(false);
		Destroy(e);
	}

	public void didExplode(){
		exploded = true;
	}

	 
}
