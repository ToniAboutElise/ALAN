using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateOnClick : MonoBehaviour {

    public int Xrotation;
    public int Yrotation;
    public int Zrotation;
	
    void OnTriggerStay(Collider other)
    {
        if(other.tag == "interactArea" && Input.GetMouseButton(0))
        {
            Debug.Log("a");
            transform.Rotate(Xrotation * Time.deltaTime, Yrotation * Time.deltaTime, Zrotation * Time.deltaTime);
        }
    }
}
