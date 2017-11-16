﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyController : MonoBehaviour {

    float NomalSpeed = 0.1f;
    float LowSpeed = 0.05f;
    float HighSpeed = 0.2f;

	// Update is called once per frame
	void Update () {
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
