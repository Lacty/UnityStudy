using UnityEngine;
using System.Collections;

public class Flags : MonoBehaviour {

  [SerializeField]
  private uint FLAG_MAX = 0;
  public uint Flag_Max {
    get{ return FLAG_MAX; }
  }

  [SerializeField]
  private float RADIUS = 0.0f;

  // Use this for initialization
  void Start ()
  {
    for (int i = 0; i < FLAG_MAX; i++) {
      var obj = GameObject.CreatePrimitive (PrimitiveType.Cube);
      obj.name = "Flag" + i;
      obj.transform.SetParent (this.transform);
      obj.transform.position = new Vector3 (Mathf.Sin((Mathf.PI * 2 / FLAG_MAX) * i) * RADIUS,
                                            0,
                                            Mathf.Cos((Mathf.PI * 2 / FLAG_MAX) * i) * RADIUS);
    }
  }
	
  // Update is called once per frame
  void Update ()
  {
  }
}
