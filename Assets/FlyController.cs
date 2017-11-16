using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyController : MonoBehaviour {

    float NomalSpeed = 0.1f;
    float LowSpeed = 0.05f;
    float HighSpeed = 0.2f;

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
            transform.Translate(-1 * NomalSpeed, 0, 0);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(NomalSpeed, 0, 0);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(0, NomalSpeed, 0);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(0, -1 * NomalSpeed, 0);
        }

        if (Input.GetKey(KeyCode.LeftShift)){
            //LowSpeed 4方向 
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                transform.Translate(-1 * LowSpeed, 0, 0);
            }
            if (Input.GetKey(KeyCode.RightArrow))
            {
                transform.Translate(LowSpeed, 0, 0);
            }
            if (Input.GetKey(KeyCode.UpArrow))
            {
                transform.Translate(0, LowSpeed, 0);
            }
            if (Input.GetKey(KeyCode.DownArrow))
            {
                transform.Translate(0, -1 * LowSpeed, 0);
            }
        }
        else if (Input.GetKey(KeyCode.LeftControl)){
            //HighSpeed 4方向
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                transform.Translate(-1 * HighSpeed, 0, 0);
            }
            if (Input.GetKey(KeyCode.RightArrow))
            {
                transform.Translate(HighSpeed, 0, 0);
            }
            if (Input.GetKey(KeyCode.UpArrow))
            {
                transform.Translate(0, HighSpeed, 0);
            }
            if (Input.GetKey(KeyCode.DownArrow))
            {
                transform.Translate(0, -1 * HighSpeed, 0);
            }
        }
        else
        {
            //NomalSpeed 4方向
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                transform.Translate(-1 * NomalSpeed, 0, 0);
            }
            if (Input.GetKey(KeyCode.RightArrow))
            {
                transform.Translate(NomalSpeed, 0, 0);
            }
            if (Input.GetKey(KeyCode.UpArrow))
            {
                transform.Translate(0, NomalSpeed, 0);
            }
            if (Input.GetKey(KeyCode.DownArrow))
            {
                transform.Translate(0, -1 * NomalSpeed, 0);
            }
        }
    }

    void OnTriggerEnter2D(Collider2D coll)
    {
		Debug.Log (coll.gameObject.name);
		if (coll.gameObject.name == "body_tePrefab(Clone)") {
			GameObject.Find ("Canvas").GetComponent<UIController> ().GameOver ();
			Destroy (coll.gameObject);
			Destroy (gameObject);
		} else if (coll.gameObject.name == "reset_buttn_off") {
			UIController ui = GameObject.Find ("Canvas").GetComponent<UIController> ();
			if (ui.isClearable()) {
				ui.GameClear ();
			}
		}
    }

    public Vector3 FlyNow()
    {
        Vector3 tmp = GameObject.Find("fly").transform.position;
        return tmp;
    }
}
