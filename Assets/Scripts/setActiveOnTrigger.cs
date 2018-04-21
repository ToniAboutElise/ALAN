using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class setActiveOnTrigger : MonoBehaviour {

    public GameObject objToAct;

    void Start()
    {
        objToAct.SetActive(false);
    }

	void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            objToAct.SetActive(true);
        }
    }
}
