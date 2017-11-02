using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animateOnTrigger : MonoBehaviour {

    public Canvas interact;

    void Start()
    {
        interact.GetComponent<Canvas>().enabled = false;
    }

    void OnTriggerStay(Collider other)
    {
       

        if (other.gameObject.tag == "interact" && Input.GetMouseButtonDown(0) && !other.GetComponent<objToAnimate>().playsAnim)
        {
            
            other.GetComponent<objToAnimate>().playAnimation();
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "interact")
        {
            interact.GetComponent<Canvas>().enabled = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "interact")
        {
            interact.GetComponent<Canvas>().enabled = false;
        }
    }

}