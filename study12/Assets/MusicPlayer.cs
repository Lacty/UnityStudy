using UnityEngine;
using System.Collections;

public class MusicPlayer : MonoBehaviour {

  public AudioClip se_ = null;

	// Use this for initialization
	void Start () {
    se_ = Resources.Load<AudioClip> ("C1");
	}
	
	// Update is called once per frame
	void Update () {
    if (Input.GetKeyDown (KeyCode.A)) {
      GetComponent<AudioSource> ().PlayOneShot (se_);
    }
	}
}
