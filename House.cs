using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class House : MonoBehaviour {
	[SerializeField]
	private Stat health;

	
	[SerializeField]
	private Text houseHealthText;

	
	void Start () {
		health.MaxVal = PlayerPrefs.GetInt("HouseHealth");
		health.CurrentVal = PlayerPrefs.GetInt("HouseHealth");
		PlayerPrefs.SetInt("currentHouseHealth",(int)health.MaxVal);
	}

	public void setHealthToMax(){
		health.MaxVal = PlayerPrefs.GetInt("HouseHealth");
		health.CurrentVal = PlayerPrefs.GetInt("HouseHealth");
	}

	private void Awake(){
		health.Initialize();
	}
	
	// Update is called once per frame
	void Update () {
		health.CurrentVal = (float)(PlayerPrefs.GetInt("currentHouseHealth"));
		houseHealthText.text = "Health: " + health.CurrentVal.ToString("F0");
		PlayerPrefs.SetInt("currentHouseHealth",(int)health.CurrentVal);
		if(GameManager.Instance.IsFinished==true){
			health.MaxVal = PlayerPrefs.GetInt("HouseHealth");
			health.CurrentVal = PlayerPrefs.GetInt("HouseHealth");
		}
	}

	void OnTriggerEnter2D(Collider2D other){
		
		if(other.tag == "MerceneryProjectile"){
			Projectile newP = other.gameObject.GetComponent<Projectile>();
			health.CurrentVal -= newP.AttackStrenght;
			PlayerPrefs.SetInt("currentHouseHealth",(int)health.CurrentVal);
			if (health.CurrentVal<=0){
				GameManager.Instance.HouseDown = true;
				GameManager.Instance.isLevelOver();
			}
			

		}
	}

	

	void OnTriggerStay2D(Collider2D other){
		
		if(other.tag == "Enemy"){
			Enemy newEn = other.gameObject.GetComponent<Enemy>();
			health.CurrentVal -= newEn.AttackStrenght;
			PlayerPrefs.SetInt("currentHouseHealth",(int)health.CurrentVal);
			if (health.CurrentVal<=0){
				GameManager.Instance.HouseDown = true;
				GameManager.Instance.isLevelOver();
			}
		}
		
	}

	



	
}
