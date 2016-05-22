using UnityEngine;
using System.Collections;

public class AI : MonoBehaviour {

  [SerializeField]
  private float speed_ = 0.0f;

  [SerializeField]
  private Vector3 velocity_ = new Vector3();

  [SerializeField]
  private GameObject flags_ = null;
  private GameObject Flags {
    get { 
      if (flags_ == null) {
        flags_ = GameObject.Find ("Flags");
      }
      return flags_;
    }
  }

  private GameObject flag_ = null;

  [SerializeField]
  private uint count_ = 0;

	// Use this for initialization
	void Start () {
    flag_ = FindFlag (count_);
	}
	
	// Update is called once per frame
	void Update () {
    velocity_ = (flag_.transform.position - transform.position).normalized * speed_;
    gameObject.GetComponent<Rigidbody> ().velocity = velocity_;
	}

  void OnCollisionEnter(Collision collision) {
    count_++;
    if (Flags.GetComponent<Flags> ().Flag_Max == count_) {
      count_ = 0;
    }
    flag_ = FindFlag (count_);
  }

  // 現在のFlagを取得
  GameObject FindFlag(uint number) {
    if (Flags.GetComponent<Flags> ().Flag_Max == number) {
      return GameObject.Find ("Flags/Flag" + 0);
    }
    return GameObject.Find ("Flags/Flag" + number);
  }
}
