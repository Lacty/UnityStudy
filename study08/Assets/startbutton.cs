
using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class startbutton : MonoBehaviour
{

  // Use this for initialization
  void Start ()
  {
    /* err
     * the name "UnityEditor" dose not exist in the current context

    UnityEditor
      .Events
      .UnityEventTools
      .AddObjectPersistentListener<GameObject>
      (GetComponent<Button>().onClick, OnClick, gameObject);
    */

    GetComponent<Button> ().onClick.AddListener (OnClick);
  }
	
  // Update is called once per frame
  void Update ()
  {
	
  }

  void OnClick() {
    SceneManager.LoadSceneAsync ("game");
    Debug.Log("click");
  }
}
