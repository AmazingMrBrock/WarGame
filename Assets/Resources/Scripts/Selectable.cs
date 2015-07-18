using UnityEngine;
using System.Collections;

public class Selectable : MonoBehaviour {

	/// <summary>
	/// Object is selectable
	/// </summary>


	
	void Awake () {
	
	}
	
	void FixedUpdate () {
	
	}

	void OnMouseDown(){
		GameObject tempObj = gameObject;
		InteractionControl.DSelected(tempObj);
	}
}
