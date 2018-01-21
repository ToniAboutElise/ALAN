using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class actDeactOnTrigger : MonoBehaviour {

    public GameObject act;
    public GameObject deact;
    public string myTag;

    void Start()
    {
        deact.GetComponent<MeshRenderer>().enabled = true;
        act.GetComponent<MeshRenderer>().enabled = false;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == myTag)
        {
            act.GetComponent<MeshRenderer>().enabled = true;
            deact.GetComponent<MeshRenderer>().enabled = false;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if(other.tag == myTag)
        {
            deact.GetComponent<MeshRenderer>().enabled = true;
            act.GetComponent<MeshRenderer>().enabled = false;
        }
    }
}
