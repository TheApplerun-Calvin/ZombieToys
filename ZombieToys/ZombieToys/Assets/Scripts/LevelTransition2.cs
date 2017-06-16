using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelTransition2 : MonoBehaviour {

    // Update is called once per frame
    void OnTriggerEnter(Collider other)
    {
        Application.LoadLevel("Level 2");
            }
        }
    
