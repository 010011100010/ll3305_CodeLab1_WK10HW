using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loader  {

	public float temp;
	public string name;
	public GameObject gameObject;
	public int mattParker;
	public bool isCool;
	public Wk10Manager Manager;

	public Loader(){
		Debug.Log ("Make a loader");
		temp = 10;
		name = "No Name";
		mattParker = 11;
		isCool = false;
	}//This is an empty function without type called default constructor
	//An empty default constructor will be automatically created when a new object of its class is called
	//It is recommanded to manully build a default constructor

	public Loader (float temp, string name){//"This" refers to the object that is currently inside of
		this.temp = temp;
		this.name = name;
	}
}
