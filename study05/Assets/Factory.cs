using UnityEngine;
using System.Collections;

public class Factory : MonoBehaviour {

  GameObject prefab_ = null;

	// Use this for initialization
	void Start () {
    prefab_ = Resources.Load<GameObject> ("Cube");
    var obj = GameObject.Instantiate (prefab_);
    obj.transform.SetParent (this.transform);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
