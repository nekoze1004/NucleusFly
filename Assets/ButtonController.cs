using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonController : MonoBehaviour {

    public GameObject goalButton;


    int goal = 100;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (GameObject.Find("Canvas").GetComponent<UIController>().ReturnScore() > goal)
        {
            goalButton.SetActiveRecursively(true);
        }
    }
}
