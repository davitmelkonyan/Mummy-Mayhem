using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SoldierBtn : MonoBehaviour {
	
	[SerializeField]
	private Soldier[] soldierObject;
	[SerializeField]
	private int soldierPrice;
	[SerializeField]
	private BombPumpkin bombObject;
	[SerializeField]
	private int bombPrice;
	[SerializeField]
	private OneRowBomb[] oneRowBombObject;
	[SerializeField]
	private Sprite dragSprite;



	public Soldier[] SoldierObject{
		get {
			return soldierObject;
		}
	}

	public BombPumpkin BombObject{
		get{
			return bombObject;
		}
	}

	public OneRowBomb[] OneRowBombObject{
		get{
			return oneRowBombObject;
		}
	}

	public Sprite DragSprite{
		get{
			return dragSprite;
		}
	}

	public int SoldierPrice{
		get{
			return SoldierPrice;
		}
	}

	public int BombPrice{
		get{
			return BombPrice;
		}
	}
}
