using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

  [SerializeField]
  private float SPEED = 0.0f;

  [SerializeField]
  private float MAX_SPEED = 0.0f;

  [SerializeField]
  private float REDUCTION_RATE = 0.0f;

  [SerializeField]
  private Vector3 velocity_ = new Vector3();

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
  // 共通化できまくりだから後で修正かけろ
  void Move()
  {
    // up
    if (Input.GetKey (KeyCode.W)) {
      velocity_.z += SPEED;
      velocity_.z = Mathf.Min (velocity_.z, MAX_SPEED);
    }
    else {
      velocity_.z *= REDUCTION_RATE;
    }
    // down
    if (Input.GetKey (KeyCode.S)) {
      velocity_.z += -SPEED;
      velocity_.z = Mathf.Max (velocity_.z, -MAX_SPEED);
    }
    else {
      velocity_.z *= REDUCTION_RATE;
    }
    // right
    if (Input.GetKey (KeyCode.D)) {
      velocity_.x += SPEED;
      velocity_.x = Mathf.Min (velocity_.x, MAX_SPEED);
    }
    else {
      velocity_.x *= REDUCTION_RATE;
    }
    // left
    if (Input.GetKey (KeyCode.A)) {
      velocity_.x += -SPEED;
      velocity_.x = Mathf.Max (velocity_.x, -MAX_SPEED);
    }
    else {
      velocity_.x *= REDUCTION_RATE;
    }

    // move the player
    transform.position += velocity_;
  }
}
