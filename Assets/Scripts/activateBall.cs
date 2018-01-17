﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class activateBall : MonoBehaviour {

    bool t1;
    bool t2;
    bool t3;
    bool t4;
    public GameObject act;
    public GameObject deact;

    void Start()
    {
        t1 = false;
        t2 = false;
        t3 = false;
        t4 = false;
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "trigger1")
        {
            t1 = true;
            Debug.Log("entra1");
        }

        if (other.tag == "trigger2")
        {
            t2 = true;
            Debug.Log("entra2");
        }

        if (other.tag == "trigger3")
        {
            t3 = true;
            Debug.Log("entra3");
        }

        if (other.tag == "trigger4")
        {
            t4 = true;
            Debug.Log("entra4");
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "trigger1")
        {
            t1 = false;
        }

        if (other.tag == "trigger2")
        {
            t2 = false;
        }

        if (other.tag == "trigger3")
        {
            t3 = false;
        }

        if (other.tag == "trigger4")
        {
            t4 = false;
        }
    }


    void Update () {
		if(t1 && t2 && t3 & t4)
        {
            act.SetActive(true);
            deact.SetActive(false);
        }
	}
}
