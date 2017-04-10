using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SimpleJSON;

public class FourBallLoader : MonoBehaviour {

	// Use this for initialization
	void Start () {
		JSONArray position = JSON.Parse (UtilScript.ReadStringFromFile (Application.dataPath, "c.txt"));
		print (position);

		//GameObject ball1 = GameObject.CreatePrimitive (PrimitiveType.Sphere);

		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
