using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundDestroy : MonoBehaviour
{

    private GameObject point;

    void Start()
    {
        point = GameObject.Find("GroundEndPoint");
    }

    void Update()
    {
        if (transform.position.x < point.transform.position.x)
            gameObject.SetActive(false);
    }
}
