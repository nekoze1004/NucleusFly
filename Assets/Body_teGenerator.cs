using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Body_teGenerator : MonoBehaviour {

    public GameObject body_tePrefab;
	int width = Screen.width;
	int height = Screen.height;

	// Use this for initialization
	void Start () {
        InvokeRepeating("GenTe", 1, 2);
		InvokeRepeating("GenTeR", 1, 2);
	}	
	// Update is called once per frame
	void GenTe () {
		Vector3 handPosition = Camera.main.ViewportToWorldPoint(new Vector3(Random.value, 1, Camera.main.nearClipPlane));
		handPosition.z = 0;
		GameObject te = Instantiate(body_tePrefab, handPosition, Quaternion.identity);
		Body_teController updown = te.GetComponent<Body_teController> ();
		updown.direction = 1;
    }

	void GenTeR () {
		Vector3 handPosition = Camera.main.ViewportToWorldPoint(new Vector3(Random.value, 0, Camera.main.nearClipPlane));
		handPosition.z = 0;
		GameObject te = Instantiate(body_tePrefab, handPosition, Quaternion.identity);
		Body_teController downup = te.GetComponent<Body_teController> ();
		downup.direction = -1;
	}
}
