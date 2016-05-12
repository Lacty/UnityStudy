using UnityEngine;
using System.Collections;

public class MakeCube : MonoBehaviour {

	// Use this for initialization
	void Start () {
    var cube = GameObject.CreatePrimitive (PrimitiveType.Cube);
    cube.transform.parent = this.transform;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
