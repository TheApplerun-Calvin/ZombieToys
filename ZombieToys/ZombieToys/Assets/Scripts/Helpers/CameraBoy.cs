using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBoy : MonoBehaviour {

    public GameObject Boy;

    private Vector3 offset;

    // Use this for initialization
    void Start()
    {
        offset = transform.position - Boy.transform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = Boy.transform.position + offset;
    }
}
