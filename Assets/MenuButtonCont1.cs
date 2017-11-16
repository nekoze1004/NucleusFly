using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButtonCont1 : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void ButtonPush()
    {
        //Debug.Log("unk");
		SceneManager.LoadScene ("Main");
    }
}
