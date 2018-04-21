using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class safeTrigger : MonoBehaviour {

    public bool inSafeZone;

    void Start()
    {
        inSafeZone = false;
    }

	void OnTriggerEnter(Collider other)
    {
        if(other.name == "safezone")
        {
            inSafeZone = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.name == "safezone")
        {
            inSafeZone = false;
        }
    }

}
