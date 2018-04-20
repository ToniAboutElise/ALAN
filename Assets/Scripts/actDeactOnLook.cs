using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class actDeactOnLook : MonoBehaviour {

    public GameObject objToAct;
    public GameObject objToDeact;
    bool done;

    void Start()
    {
        done = false;
    }
    
    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "interactArea" && done == false)
        {
            objToDeact.SetActive(false);
            objToAct.SetActive(true);
            done = true;
        }
    }

}
