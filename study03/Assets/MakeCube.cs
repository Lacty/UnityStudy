﻿using UnityEngine;
using System.Collections;

public class MakeCube : MonoBehaviour {

	// Use this for initialization
	void Start () {
    var cube = GameObject.CreatePrimitive (PrimitiveType.Cube);
    cube.name = "とうふ";
	}
	
	// Update is called once per frame
	void Update () {
    var obj = GameObject.Find ("とうふ");
    Vector3 pos = obj.transform.position;
	}
}
