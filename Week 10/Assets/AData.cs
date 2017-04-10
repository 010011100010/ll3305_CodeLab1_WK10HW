/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SimpleJSON;

public class AData {

	public Vector3 position;
	public Vector3 scale;

	private const string POS_X = "xpos";
	private const string POS_Y = "ypos";
	private const string POS_Z = "zpos";

	public AData(string fileName){
		JSONNode jason = UtilScript.ReadJSONFromFile (Application.dataPath, fileName);
		position = new Vector3(jason[POS_X].AsFloat, jason[POS_Y].AsFloat, jason[POS_Z].AsFloat);

	}
		
	public AData(Vector3 position, Vector3 scale){
		this.position = position;
		this.scale = scale;
	}

	public JSONClass toJSON(){
		JSONClass json = new JSONClass ();
		json [POS_X].AsFloat = position.x;
		json [POS_Y].AsFloat = position.y;
		json [POS_Z].AsFloat = position.z;
		return json;
	}

	public void Save(string fileName) {
	
		JSONClass json = toJSON ();
		UtilScript.WriteJSONtoFile (Application.dataPath, fileName, json);
	
	}

}*/

