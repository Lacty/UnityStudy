using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

  private GameObject cube_;
  private float speed_ = 0.1f;

  void Awake() {
    cube_ = GameObject.CreatePrimitive (PrimitiveType.Cube);
    cube_.transform.SetParent (this.transform);
    cube_.name = "Player";
  }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
    Move (cube_);
	}

  private void Move(GameObject obj) {
    if (Input.GetKey (KeyCode.A)) {
      obj.transform.Translate (-speed_, 0.0f, 0.0f);
    }
    if (Input.GetKey (KeyCode.D)) {
      obj.transform.Translate (speed_, 0.0f, 0.0f);
    }
  }
}
