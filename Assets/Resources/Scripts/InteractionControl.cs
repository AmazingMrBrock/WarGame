using UnityEngine;
using System.Collections;

public class InteractionControl : MonoBehaviour {
	/// <summary>
	/// Controls interactions with the map and game pieces.
	/// </summary>

	public delegate void DSelect(GameObject tempObj);
	public static DSelect DSelected;

	int arrayIndex = 0;

	GameObject[] unitAndDest = new GameObject[2];

	void Awake () {
		DSelected = OnSelect;
	}

	void FixedUpdate () {
	
	}

	void OnSelect(GameObject tempObj){
		if(arrayIndex == 0){
			unitAndDest[0] = tempObj;
			arrayIndex++;
		}
		if(arrayIndex == 1){
			unitAndDest[1] = tempObj;
			arrayIndex = 0;
			UnitMove(unitAndDest[0], unitAndDest[1]);
		}
	}

	void UnitMove(GameObject tempUnit, GameObject tempDest){

	}
}
