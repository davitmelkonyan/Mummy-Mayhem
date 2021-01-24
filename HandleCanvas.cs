using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HandleCanvas : MonoBehaviour {
	private CanvasScaler scaler;
	private float ratio;

	void Start () {
		ratio = (float)((float)(Screen.width)/(float)(Screen.height));
		Debug.Log(Screen.width);
		Debug.Log(Screen.height);
		Debug.Log(ratio.ToString("#.###"));
		Debug.Log((16f/9f).ToString("#.###"));
		if(ratio.ToString("#.###") == (16f/9f).ToString("#.###"))
		{
			Debug.Log("1");
			transform.localScale -= new Vector3(0, 0.14f, 0);
		}
		else if(ratio.ToString("#.###") == (0.66666667).ToString("#.###"))
		{
			Debug.Log("2");
			transform.localScale -= new Vector3(1.006f, 1.430156f, 0);
		}
		else if(ratio.ToString("#.###") == (4f/3f).ToString("#.###"))
		{
			Debug.Log("3");
			transform.localScale += new Vector3(0, 0.125006f, 0);
		}
		

		// ratiox=Screen.width*WorkingYorRatio;
 		// ratioy=Screen.height*WorkingXorRatio;
		// scaler = GetComponent<CanvasScaler>();

		// scaler.uiScaleMode = CanvasScaler.ScaleMode.ScaleWithScreenSize;
		// transform.localScale.x=transform.localScale.x*ratiox/ratioy;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
