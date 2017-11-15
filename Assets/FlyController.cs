using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyController : MonoBehaviour {
	
	// Update is called once per frame
	void Update () {
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
        GameObject.Find("Canvas").GetComponent<UIController>().GameOver();
        Destroy(coll.gameObject);
        Destroy(gameObject);
    }

    public Vector3 FlyNow()
    {
        Vector3 tmp = GameObject.Find("fly").transform.position;
        return tmp;
    }
}
