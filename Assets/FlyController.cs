using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyController : MonoBehaviour {
	
	// Update is called once per frame
	void Update () {
		Vector3 position = Input.mousePosition;
		// Z軸修正
		position.z = 10f;
		// マウス位置座標をスクリーン座標からワールド座標に変換する
		Vector3 screenToWorldPointPosition = Camera.main.ScreenToWorldPoint(position);
		// Debug.Log (screenToWorldPointPosition);
		transform.position = screenToWorldPointPosition;
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(-0.1f, 0, 0);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(0.1f, 0, 0);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(0, 0.1f, 0);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(0, -0.1f, 0);
        }


        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-0.1f, 0, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(0.1f, 0, 0);
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0, 0.1f, 0);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0, -0.1f, 0);
        }
    }

    void OnTriggerEnter2D(Collider2D coll)
    {
		if (coll.gameObject.tag == "Body_teController") {
			GameObject.Find ("Canvas").GetComponent<UIController> ().GameOver ();
			Destroy (coll.gameObject);
			Destroy (gameObject);
		} else if (coll.gameObject.tag == "reset_button_off") {
			GameObject.Find ("Canvas").GetComponent<UIController> ().GameClear ();
		}
    }

    public Vector3 FlyNow()
    {
        Vector3 tmp = GameObject.Find("fly").transform.position;
        return tmp;
    }
}
