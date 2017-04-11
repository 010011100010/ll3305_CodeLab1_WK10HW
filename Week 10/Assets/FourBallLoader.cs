using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SimpleJSON;

public class FourBallLoader : MonoBehaviour {
	public Vector3 ball;
	// Use this for initialization
	void Start () {
		JSONArray ballPositions = UtilScript.ReadJSONFromFile (Application.dataPath, "c.txt") as JSONArray;
		print (ballPositions);

		//GameObject ball1 = GameObject.CreatePrimitive (PrimitiveType.Sphere);
		for (int i = 0; i<ballPositions.Count; i++){
			ball = new Vector3 (ballPositions [i] ["xpos"].AsFloat, ballPositions [i] ["ypos"].AsFloat, ballPositions [i] ["zpos"].AsFloat);
			GameObject sphere = GameObject.CreatePrimitive (PrimitiveType.Sphere);
			sphere.transform.position = ball;
		}
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
