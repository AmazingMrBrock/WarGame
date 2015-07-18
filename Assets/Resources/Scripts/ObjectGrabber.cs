using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ObjectGrabber : MonoBehaviour {
	/// <summary>
	/// Creates a dictionary of units for each team and makes the dictionaries available for copy.
	/// </summary>

	Dictionary<string, UnitData> whiteUnitDic = new Dictionary<string, UnitData>();
	Dictionary<string, UnitData> blackUnitDic = new Dictionary<string, UnitData>();
	Dictionary<string, Vector3> spotVectDic = new Dictionary<string, Vector3>();

	public int unitCache;
	public int spotCache;

	void Start () {
	
	}

	void Update () {
	
	}

	void SpotGrabber(){

	}

	void UnitGrabber(){
		GameObject[] tempUnit = GameObject.FindGameObjectsWithTag("Unit");


		for(int i = 0; i < tempUnit.Length; i++){

			UnitData tempData;
			string tempID = tempUnit[i].transform.name + i;
			tempData.unitID = tempID;
			Transform unitParent = tempUnit[i].GetComponentInParent<Transform>();
			string tempSide = unitParent.transform.name;
			tempData.unitSide = tempSide;
			Vector3 tempVec = tempUnit[i].transform.position;
			tempData.unitPos = tempVec;
			if(tempSide == "White"){
				whiteUnitDic.Add(tempID, tempData)
			}
			else if(tempSide == "Black"){
				blackUnitDic.Add(tempID, tempData);
			}
		}
	}
}
