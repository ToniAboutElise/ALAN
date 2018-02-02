using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class activateOnTriggerEnter : MonoBehaviour {

    public GameObject act;

	
	void OnTriggerEnter (Collider other)
    {
        if(other.tag == "Player")
        {
            act.gameObject.SetActive(true);
        }
    }
}
