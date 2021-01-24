using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventorySoldier : MonoBehaviour {
	private RectTransform inventoryRect;

	private float inventoryWidth, inventoryHeight;

	public int slots;

	public int rows;

	public float slotPaddingLeft, slotPaddingTop;

	public float slotSize;

	public GameObject slotPrefab;

	private List<GameObject> allSlots;
	// Use this for initialization
	//void Start () {
	//	createList();
	//}
	
	// Update is called once per frame
	void Update () {
		
	}

	//private void createList(){
	//	allSlots = new List<GameObject>();
	//	int cols = slots/rows;
	//	for (int y =0; y< rows; y++){
	//		for (int x = 0; x< cols; x++){
	//			GameObject newSlot = (GameObject)Instantiate(slotPrefab);
	//			newSlot.name = "Slot";
	//			newSlot.transform.SetParent(this.transform.parent);
	//			allSlots.Add(newSlot);
	//		}
	//	}
	//}
}
