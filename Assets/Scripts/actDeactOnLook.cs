using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class actDeactOnLook : MonoBehaviour {

    public GameObject objToAct;
    public GameObject objToDeact;
    bool done;
    public GameObject myCharacter;

    void Start()
    {
        done = false;
    }
    
    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "interactArea" && done == false && myCharacter.GetComponent<safeTrigger>().inSafeZone == true)
        {
            objToDeact.SetActive(false);
            objToAct.SetActive(true);
            done = true;
        }
    }

}
