using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class activateObject : MonoBehaviour {
    public GameObject objToActivate;

    void OnTriggerStay(Collider other)
    {
        if (other.tag == "interactArea" && Input.GetMouseButton(0))
        {
            objToActivate.SetActive(true);
        }
    }
}
