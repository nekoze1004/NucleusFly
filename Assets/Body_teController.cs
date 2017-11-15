using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Body_teController : MonoBehaviour {

    float fallSpeed;

	// Use this for initialization
	void Start () {
        this.fallSpeed = 0.01f + 0.1f * Random.value;
        transform.Rotate(0, 0, -90);
    }
	
	// Update is called once per frame
	void Update () {
        transform.Translate(0, -fallSpeed, 0, Space.World);

        if(transform.position.y < -5.5f)
        {
            GameObject.Find("Canvas").GetComponent<UIController>().AddScore();
            Destroy(gameObject);
        }
	}
}
