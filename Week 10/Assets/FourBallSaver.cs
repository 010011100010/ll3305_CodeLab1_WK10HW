using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SimpleJSON;

public class FourBallSaver : MonoBehaviour {

	// Use this for initialization
	void Start () {
		GameObject[] As = GameObject.FindGameObjectsWithTag ("B");

		Vector3 pos = As [0].transform.position;
		Vector3 scale = As [0].transform.localScale;
		Vector3 pos2 = As [1].transform.position;
		Vector3 scale2 = As [1].transform.localScale;
		Vector3 pos3 = As [2].transform.position;
		Vector3 scale3 = As [2].transform.localScale;
		Vector3 pos4 = As [3].transform.position;
		Vector3 scale4 = As [3].transform.localScale;

		JSONArray jArray = new JSONArray();

		JSONNode ball1 = new JSONClass();
		ball1 ["xpos"].AsFloat = pos.x; 
		ball1 ["ypos"].AsFloat = pos.y;
		ball1 ["zpos"].AsFloat = pos.z;

		JSONNode ball2 = new JSONClass ();
		ball2 ["xpos"].AsFloat = pos2.x; 
		ball2 ["ypos"].AsFloat = pos2.y;
		ball2 ["zpos"].AsFloat = pos2.z;

		JSONNode ball3 = new JSONClass ();
		ball3 ["xpos"].AsFloat = pos3.x; 
		ball3 ["ypos"].AsFloat = pos3.y;
		ball3 ["zpos"].AsFloat = pos3.z;

		JSONNode ball4 = new JSONClass ();
		ball4 ["xpos"].AsFloat = pos4.x; 
		ball4 ["ypos"].AsFloat = pos4.y;
		ball4 ["zpos"].AsFloat = pos4.z;

		jArray.Add (ball1);
		jArray.Add (ball2);
		jArray.Add (ball3);
		jArray.Add (ball4);

		print(jArray); //print out jArray with all 3 JSONObjects as part of it
		//jArray.Save ("b.txt");
		UtilScript.WriteJSONtoFile (Application.dataPath, "c.txt", jArray);

		//AData loadAd = new AData ("b.txt");
		//print (loadAd.position);
	}

	// Update is called once per frame
	void Update () {

	}
}
