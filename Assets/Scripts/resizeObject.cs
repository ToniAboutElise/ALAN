using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class resizeObject : MonoBehaviour {

    public int Xsize;
    public int Ysize;
    public int Zsize;

    public int maxSize;
    float minSize;

    public GameObject UI;

    bool resize;

    void Start()
    {
        resize = true;
        minSize = transform.localScale.x;
    }

    void OnTriggerStay(Collider other)
    {
        if (other.tag == "interactArea")
        {
            UI.SetActive(true);
        }

        if (other.tag == "interactArea" && Input.GetMouseButton(0) && resize)
        {
                transform.localScale += new Vector3(Xsize * Time.deltaTime, Ysize * Time.deltaTime, Zsize * Time.deltaTime);
                if(transform.localScale.x > maxSize) {
                    resize = false;
            }
        }
        else if (other.tag == "interactArea" && Input.GetMouseButton(0) && !resize)
        {
            transform.localScale += new Vector3(-Xsize * Time.deltaTime, -Ysize * Time.deltaTime, -Zsize * Time.deltaTime);
            if (transform.localScale.x < minSize)
            {
                resize = true;
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
