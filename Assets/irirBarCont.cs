using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class irirBarCont : MonoBehaviour {

    Slider slider;
    float score = 0;

	// Use this for initialization
	void Start () {
        slider = GameObject.Find("Slider").GetComponent<Slider>();
        slider.maxValue = GameObject.Find("Canvas").GetComponent<UIController>().ReturnGoal();
	}
	
	// Update is called once per frame
	void Update () {
        score = GameObject.Find("Canvas").GetComponent<UIController>().ReturnScore();
        slider.value = score;
	}
}
