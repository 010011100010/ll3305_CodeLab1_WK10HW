using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wk10Manager : MonoBehaviour {
	Loader myLoader; //Declare varible "myLoader" as Loader type
	// Use this for initialization
	void Start () {
		myLoader = new Loader (0.123f, "Hey");//initialize "myLoader" as a new object of class Loader
		//Constructors should only be used when it is not extending from MonoBehaviour

		//myLoader.temp = 0.123F;
		myLoader.Manager = this;
		print(myLoader.name);
		print (this);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
