
using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CreateCube : MonoBehaviour {

  GameObject cube_ = null;
  int count_ = 0;

  void Awake() {
    // GetComponent<Text> ().BroadcastMessage ("CreateCube");
    // this.GetComponent<Text>().text = "CreateCube";
    this.GetComponentInChildren<Text>().text = "CreateCube";
  }

	// Use this for initialization
	void Start () {
    cube_ = Resources.Load<GameObject> ("Cube");
    if (cube_ == null) {
      Debug.Log ("err : cube dose not loaded...");
    }
	}
	
	// Update is called once per frame
	void Update () {
	
	}

  // call if clicked button
  public void OnClick() {
    var obj = Instantiate (cube_);
    obj.name = "cube" + count_;
    obj.transform.SetParent (this.transform);
    obj.transform.position = new Vector3 (Random.Range(-5.0f, 5.0f),
                                          Random.Range(-5.0f, 5.0f),
                                          Random.Range(-5.0f, 5.0f));
    count_++;
  }
}
