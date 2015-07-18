using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ObjectGrabber : MonoBehaviour {
	/// <summary>
	/// Creates a dictionary of units for each team and makes the dictionaries available for copy.
	/// </summary>

	public static Dictionary<string, UnitData> whiteUnitDic = new Dictionary<string, UnitData>();
	public static Dictionary<string, UnitData> blackUnitDic = new Dictionary<string, UnitData>();
	public static Dictionary<string, Vector3> spotVectDic = new Dictionary<string, Vector3>();

	void Start () {
	
	}

	void Update () {
	
	}

	void SpotGrabber(){
		GameObject[] tempSpot = GameObject.FindGameObjectsWithTag("TouchSpots");
		
		for(int i = 0; i < tempSpot.Length; i++){
			string tempID = tempSpot[i].transform.name + i;
			Vector3 tempVec = tempSpot[i].transform.position;
			spotVectDic.Add(tempID, tempVec);
		}
	}

	void UnitGrabber(){
		GameObject[] tempUnit = GameObject.FindGameObjectsWithTag("Unit");

		for(int i = 0; i < tempUnit.Length; i++){
			string tempID = tempUnit[i].transform.name + i;
			tempUnit[i].transform.name = tempID;
			Transform unitParent = tempUnit[i].GetComponentInParent<Transform>();
			string tempSide = unitParent.transform.name;
			Vector3 tempVec = tempUnit[i].transform.position;
			UnitData tempData = new UnitData(tempID, tempSide, false, tempVec);
			if(tempSide == "White"){
				whiteUnitDic.Add(tempID, tempData);
			}
			else if(tempSide == "Black"){
				blackUnitDic.Add(tempID, tempData);
			}
		}
	}
}
