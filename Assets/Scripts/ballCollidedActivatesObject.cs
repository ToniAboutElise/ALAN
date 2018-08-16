using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballCollidedActivatesObject : MonoBehaviour {

    public GameObject act;
    public GameObject deact;
    public GameObject mybridge;

   void OnCollisionEnter(Collision other)
    {
        if(other.collider.tag == "ball")
        {
            act.SetActive(true);
            deact.SetActive(false);
            mybridge.GetComponent<bridgeAppear>().SpawnBridge();
        }
    }

}
