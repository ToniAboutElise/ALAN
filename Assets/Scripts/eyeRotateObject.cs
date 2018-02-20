using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eyeRotateObject : MonoBehaviour {

    public int XRot;
    public int YRot;
    public int ZRot;

    public float XobjRot;
    public float YobjRot;
    public float ZobjRot;

    public GameObject UI;

    public GameObject objRotate;

    void OnTriggerStay(Collider other)
    {
        if (other.tag == "interactArea")
        {
            UI.SetActive(true);
        }

        if (other.name == "collisionDoor")
        {
            GetComponent<BoxCollider>().enabled = false;
            other.GetComponent<BoxCollider>().enabled = false;
        }

        if (other.tag == "interactArea" && Input.GetMouseButton(0))
        {
            transform.Rotate(XRot * Time.deltaTime, YRot * Time.deltaTime, ZRot * Time.deltaTime);

            objRotate.transform.Rotate(XobjRot * Time.deltaTime, YobjRot * Time.deltaTime, ZobjRot * Time.deltaTime);

        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "interactArea")
        {
            UI.SetActive(false);
        }
    }
}
