﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour {
    public int forceConst = 50;
    private bool canJump;
    private Rigidbody selfRigidbody;

     void Start()
    {
        selfRigidbody = GetComponent<Rigidbody>();
    }


     void FixedUpdate()
    {
     if(canJump) {
            canJump = false;
            selfRigidbody.AddForce(0, forceConst, 0, ForceMode.Impulse);
     }
    }

    void Update () {
	if (Input.GetMouseButtonDown(1)){
            canJump = true; 
    }
	}
}
