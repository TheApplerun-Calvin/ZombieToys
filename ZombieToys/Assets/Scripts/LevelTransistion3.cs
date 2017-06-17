using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelTransistion3 : MonoBehaviour {



    // Update is called once per frame
    void OnTriggerEnter(Collider other)
    {
        Application.LoadLevel("Credits");
    }
}
