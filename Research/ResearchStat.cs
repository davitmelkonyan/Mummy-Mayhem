using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
public class ResearchStat {
	[SerializeField]
	private ResearchHealthBar timebar;
	[SerializeField]
	private float maxVal;
	[SerializeField]
	private float currentVal;

	public float CurrentVal{
		get{
			return currentVal;
		}
		set{
			this.currentVal = Mathf.Clamp(value,0,MaxVal);
			timebar.Value = currentVal;
		}
	}

	public float MaxVal{
		get{
			return maxVal;
		}
		set{
			this.maxVal = value;
			timebar.MaxValue = maxVal;
		}
	}

	public void Initialize(){
		this.MaxVal = maxVal;
		this.CurrentVal = currentVal;
	}


	
}
