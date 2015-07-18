using UnityEngine;
using System.Collections;

public class InteractionControl : MonoBehaviour {
	/// <summary>
	/// Controls interactions with the map and game pieces.
	/// </summary>

	public delegate void DSelected(GameObject tempObj);


	void Awake () {
		DSelected = OnSelect;
	}

	void FixedUpdate () {
	
	}

	void OnSelect(GameObject tempObj){

	}

	void UnitMove(){

	}
}
