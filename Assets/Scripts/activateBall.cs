using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class activateBall : MonoBehaviour {

    bool t1;
    bool t2;
    bool t3;
    bool t4;
    public GameObject act;
    public GameObject deact;
    public GameObject doorAct;
    public GameObject doorDeact;
    public GameObject soundActivator;

    public bool openDoor;

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
            Debug.Log("exit1");
        }

        if (other.tag == "trigger2")
        {
            t2 = false;
            Debug.Log("exit2");
        }

        if (other.tag == "trigger3")
        {
            t3 = false;
            Debug.Log("exit3");
        }

        if (other.tag == "trigger4")
        {
            t4 = false;
            Debug.Log("exit4");
        }
    }


    void Update () {
		if(t1 && t2 && t3 & t4)
        {
            act.SetActive(true);
            deact.SetActive(false);
            if (openDoor)
            {
                doorDeact.SetActive(false);
                doorAct.SetActive(true);
                doorAct.GetComponent<Animation>().Play();
                openDoor = false;
                soundActivator.SetActive(true);
            }
        }
	}
}
