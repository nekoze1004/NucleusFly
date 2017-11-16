using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Body_teGenR : MonoBehaviour
{

    public GameObject body_tePrefab;
    // Use this for initialization
    void Start()
    {
        InvokeRepeating("GenTe", 0.01f, 3);
    }

    // Update is called once per frame
    void GenTe()
    {
        Instantiate(body_tePrefab, new Vector3(-8.0f + 16 * Random.value, -6, 0), Quaternion.identity);
    }
}
