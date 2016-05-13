using UnityEngine;
using System.Collections;

public class Factory : MonoBehaviour {

  GameObject prefab_ = null;
  GameObject object_ = null;

	// Use this for initialization
	void Start () {
    prefab_ = Resources.Load<GameObject> ("Cube");
    object_ = Instantiate (prefab_);
    object_.transform.SetParent (this.transform);
	}
	
	// Update is called once per frame
	void Update () {
    const float speed = 0.1f;
    Move (object_, speed);
	}

  void Move(GameObject obj, float speed) {
    if (Input.GetKey (KeyCode.A)) {
      obj.transform.Translate (-speed, 0, 0);
    }
    if (Input.GetKey (KeyCode.D)) {
      obj.transform.Translate (speed, 0, 0);
    }
  }
}
