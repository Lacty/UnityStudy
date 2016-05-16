using UnityEngine;
using System.Collections;

public class Scroll : MonoBehaviour
{

  private float speed_x_ = 0.1f;

  // Use this for initialization
  void Start ()
  {
	
  }
	
  // Update is called once per frame
  void Update ()
  {
    var x = Mathf.Repeat (Time.time * speed_x_, 1);

    var offset = new Vector2 (x, 0);

    GetComponent<Renderer> ().sharedMaterial.SetTextureOffset ("_MainTex", offset);
  }
}
