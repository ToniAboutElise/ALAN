using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class resizeObject : MonoBehaviour {

    public int Xsize;
    public int Ysize;
    public int Zsize;

    bool resize;

    void Start()
    {
        resize = true;
    }

    void OnTriggerStay(Collider other)
    {
        if (other.tag == "interactArea" && Input.GetMouseButton(0) && resize)
        {
                transform.localScale += new Vector3(Xsize * Time.deltaTime, Ysize * Time.deltaTime, Zsize * Time.deltaTime);
                if(transform.localScale.x > 8) {
                    resize = false;
            }
        }
        else if (other.tag == "interactArea" && Input.GetMouseButton(0) && !resize)
        {
            transform.localScale += new Vector3(-Xsize * Time.deltaTime, -Ysize * Time.deltaTime, -Zsize * Time.deltaTime);
            if (transform.localScale.x < 3)
            {
                resize = true;
            }
        }


    }
}
