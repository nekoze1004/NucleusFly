using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Body_teGenR : MonoBehaviour
{

    public GameObject body_tePrefab;
    // Use this for initialization
    void Start()
    {
        InvokeRepeating("GenTe", 1, 3);
    }

    // Update is called once per frame
    void GenTe()
    {

        Instantiate(body_tePrefab, new Vector3(-2.5f + 5 * Random.value, -6, 0), Quaternion.identity);
    }
}
