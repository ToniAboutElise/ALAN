using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eyeChangeSize : MonoBehaviour {

    public int XRot;
    public int YRot;
    public int ZRot;

    public float Xsize;
    public float Ysize;
    public float Zsize;

    public bool makeSmall;
    public bool makeBig;
    public int resize;
    public float max;
    public float min;
    Vector3 refScale;

    public GameObject UI;

    public GameObject objResize;

    void Start()
    {
        refScale = objResize.transform.localScale;
    }

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
            if (other.tag == "interactArea" && Input.GetMouseButton(0) && makeBig)
            {
                objResize.transform.localScale += new Vector3(Xsize * Time.deltaTime, Ysize * Time.deltaTime, Zsize * Time.deltaTime);
                if(objResize.transform.localScale.x >= refScale.x + max)
                {
                    makeBig = false;
                    makeSmall = true;
                }
            } else if (other.tag == "interactArea" && Input.GetMouseButton(0) && makeSmall)
            {
                objResize.transform.localScale += new Vector3(Xsize * -Time.deltaTime, Ysize * -Time.deltaTime, Zsize * -Time.deltaTime);
                if(objResize.transform.localScale.x < refScale.x - min)
                {
                    makeSmall = false;
                    makeBig = true;
                }
            }
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
