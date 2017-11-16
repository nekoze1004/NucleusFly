using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Body_teGenerator : MonoBehaviour {

    public GameObject body_tePrefab;
	int width = Screen.width;
	int height = Screen.height;

	// Use this for initialization
	void Start () {
        InvokeRepeating("GenTeToDown", 1, 1);
		InvokeRepeating("GenTeToUp", 1, 1);
		InvokeRepeating("GenTeToLeft", 1, 1);
		InvokeRepeating("GenTeToRight", 1, 1);
	}	
	// Update is called once per frame
	void GenTeToDown () {
		Vector3 handPosition = Camera.main.ViewportToWorldPoint(new Vector3(Random.value, 1, Camera.main.nearClipPlane));
		handPosition.z = 0;
		GameObject te = Instantiate(body_tePrefab, handPosition, Quaternion.identity);
		Body_teController todown = te.GetComponent<Body_teController> ();
		todown.mode = 0;
    }

	void GenTeToUp () {
		Vector3 handPosition = Camera.main.ViewportToWorldPoint(new Vector3(Random.value, 0, Camera.main.nearClipPlane));
		handPosition.z = 0;
		GameObject te = Instantiate(body_tePrefab, handPosition, Quaternion.identity);
		Body_teController toup = te.GetComponent<Body_teController> ();
		toup.mode = 1;
	}

	void GenTeToLeft () {
		Vector3 handPosition = Camera.main.ViewportToWorldPoint(new Vector3(1, Random.value, Camera.main.nearClipPlane));
		handPosition.z = 0;
		GameObject te = Instantiate(body_tePrefab, handPosition, Quaternion.identity);
		Body_teController toleft = te.GetComponent<Body_teController> ();
		toleft.mode = 2;
	}

	void GenTeToRight () {
		Vector3 handPosition = Camera.main.ViewportToWorldPoint(new Vector3(0, Random.value, Camera.main.nearClipPlane));
		handPosition.z = 0;
		GameObject te = Instantiate(body_tePrefab, handPosition, Quaternion.identity);
		Body_teController toright = te.GetComponent<Body_teController> ();
		toright.mode = 3;
	}
}
