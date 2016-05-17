
using UnityEngine;
using System.Collections;


public class Player : MonoBehaviour {

  [SerializeField]
  private float speed_ = 0.01f;

  private float acceleration_ = 0.0f;

  private float rot_speed_ = 1.0f;

  private GameObject camera_;

	// Use this for initialization
	void Start () {
    camera_ = GameObject.Find ("Main Camera");
	}
	
	// Update is called once per frame
	void Update () {
    if (Input.GetKey (KeyCode.W)) {
      acceleration_ += speed_;
    } else {
      acceleration_ *= 0.98f;
    }

    if (Input.GetKey (KeyCode.D)) {
      transform.Rotate (0, rot_speed_, 0);
    } else if (Input.GetKey(KeyCode.A)) {
      transform.Rotate(0, -rot_speed_, 0);
    }

    transform.Translate (0, 0, acceleration_);

    camera_.transform.position = new Vector3 (transform.position.x, camera_.transform.position.y, transform.position.z);
	}
}
