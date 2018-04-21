using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class activateOnTriggerEnter : MonoBehaviour {

    public GameObject act;
    public bool actOnInteractArea;
	
	void OnTriggerEnter (Collider other)
    {
        if(other.tag == "Player")
        {
            act.gameObject.SetActive(true);
        }
        else if (other.tag == "interactArea" && actOnInteractArea == true)
        {
            act.gameObject.SetActive(true);
        }
    }
}
