using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraGirl : MonoBehaviour {

    public GameObject Girl;

    private Vector3 offset;

    // Use this for initialization
    void Start()
    {
        offset = transform.position - Girl.transform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = Girl.transform.position + offset;
    }
}
