using UnityEngine;
using System.Collections;

public class Camera : MonoBehaviour {

  [SerializeField]
  private GameObject player_ = null;
  private GameObject Player {
    get {
      if (player_ == null) {
        player_ = GameObject.Find ("Player");
      }
      return player_;
    }
  }

  // Use this for initialization
  void Start ()
  {
  }
	
  // Update is called once per frame
  void Update ()
  {
    Move ();
  }

  void Move() {
    transform.position = new Vector3 (Player.transform.position.x,
                                      transform.position.y,
                                      Player.transform.position.z);
  }
}
