 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HouseHealthBar : MonoBehaviour {
	[SerializeField]
	private Image currentHealthBar;
	[SerializeField]
	private float lerpSpeed;
	[SerializeField]
	public Text ratioText;
	private float fillAmount=1;
	[SerializeField]
	private Color fullColor;
	[SerializeField]
	private Color lowColor;
	[SerializeField]
	private bool lerpColors;

	public float MaxValue { get; set; }

	public float Value{
		set{
//			string[] temp = ratioText.text.Split(':');
//			ratioText.text = temp[0]+": " + value.ToString("0");
			
			fillAmount = Map(value,0,MaxValue,0,1);
		}
	}
	
	
	// Use this for initialization
	private void Start () {
		if(lerpColors)
		{
			currentHealthBar.color = fullColor;
		}
	}

	void Update()
	{	
		UpdateHealthBar();
	}
	
	private void UpdateHealthBar(){
		if (fillAmount != currentHealthBar.fillAmount){	
			currentHealthBar.fillAmount = Mathf.Lerp(currentHealthBar.fillAmount, fillAmount, Time.deltaTime * lerpSpeed);	
		}
		if (lerpColors){
			currentHealthBar.color = Color.Lerp(lowColor,fullColor,fillAmount);
		}
		
		
	
	}

	private float Map(float value, float inMin, float inMax, float outMin, float outMax ){
		 return (value - inMin) * (outMax - outMin)/(inMax - inMin) +outMin;
	}
	

	
	
}
