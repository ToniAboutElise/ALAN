using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class setBool : MonoBehaviour {

    public bool myBool;
	void Start () {
        myBool = true;
	}
	
	void OnTriggerEnter(Collider other)
    {
        if(other.name == "left")
        {
            myBool = true;
        } else if(other.name == "right")
        {
            myBool = false;
        }
    }
}
