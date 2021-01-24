using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResearchHealthBar : MonoBehaviour {
	
	
	
	public bool isResearching= false;

	[SerializeField]
	private Image currentResearchBar;
	[SerializeField]
	private float lerpSpeed;
	[SerializeField]
	public Text timeText;

	private float fillAmount;

	[SerializeField]
	private Color fullColor;
	[SerializeField]
	private Color lowColor;
	[SerializeField]
	private bool lerpColors;

	public float MaxValue { get; set; }

	public float Value{
		set{
			string[] temp = timeText.text.Split(':');
			string hours = Mathf.Floor(value/3600).ToString("00");
			string minutes = Mathf.Floor((value % 3600)/60).ToString("00");
			string seconds = Mathf.Floor(value % 60).ToString("00");
			timeText.text = "Time Left: "+hours+":"+minutes +":" + seconds;
			fillAmount = Map(value,0,MaxValue,0,1);
		}
	}
	
	void Awake()
	{
		DontDestroyOnLoad(gameObject);
	}
	
	// Use this for initialization
	void Start () {
		
		
	}
	
	// Update is called once per frame
	void Update () {
		if (fillAmount != currentResearchBar.fillAmount){
			currentResearchBar.fillAmount = Mathf.Lerp(currentResearchBar.fillAmount, fillAmount, Time.deltaTime * lerpSpeed);
		}
		else{
			isResearching = false;
		}
			
		
		
		
	}

	private float Map(float value, float inMin, float inMax, float outMin, float outMax ){
		 return (value - inMin) * (outMax - outMin)/(inMax - inMin) +outMin;
	}
}
