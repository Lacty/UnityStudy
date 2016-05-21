using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Player : MonoBehaviour {

  [SerializeField]
  private float SPEED = 0.0f;

  [SerializeField]
  private float MAX_SPEED = 0.0f;

  [SerializeField]
  private float REDUCTION_RATE = 0.0f;

  [SerializeField]
  private Vector3 velocity_ = new Vector3 ();

  // Use this for initialization
  void Start ()
  {
  }
	
  // Update is called once per frame
  void Update ()
  {
    Move ();
  }

  // receive an Input to move the player
  void Move()
  {
    // up
    if (Input.GetKey (KeyCode.W)) {
      velocity_.z += SPEED;
      velocity_.z = Mathf.Min (velocity_.z, MAX_SPEED);
    }

    // down
    if (Input.GetKey (KeyCode.S)) {
      velocity_.z += -SPEED;
      velocity_.z = Mathf.Max (velocity_.z, -MAX_SPEED);
    }

    // right
    if (Input.GetKey (KeyCode.D)) {
      velocity_.x += SPEED;
      velocity_.x = Mathf.Min (velocity_.x, MAX_SPEED);
    }

    // left
    if (Input.GetKey (KeyCode.A)) {
      velocity_.x += -SPEED;
      velocity_.x = Mathf.Max (velocity_.x, -MAX_SPEED);
    }

    // set velocity
    gameObject.GetComponent<Rigidbody>().velocity = velocity_;

    Vector3 vel = gameObject.GetComponent<Rigidbody> ().velocity;

    velocity_.x = vel.x * REDUCTION_RATE;
    velocity_.z = vel.z * REDUCTION_RATE;

    gameObject.GetComponent<Rigidbody>().velocity = velocity_;
  }
}
