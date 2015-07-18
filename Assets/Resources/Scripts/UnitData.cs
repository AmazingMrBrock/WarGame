using UnityEngine;
using System.Collections;

[System.Serializable]
public class UnitData {

	public string unitID;
	public string unitSide;
	public bool unitActive;
	public Vector3 unitPos;


	public UnitData(string ID, string side, bool active, Vector3 position){
		this.unitID = ID;
		this.unitSide = side;
		this.unitActive = active;
		this.unitPos = position;
	}
}
