using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class readNote : MonoBehaviour {

    public Canvas canvas;
    bool enabledCanvas;

    void Start () {
        canvas.GetComponent<Canvas>().enabled = false;
        enabledCanvas = false;
    }

    void OnTriggerExit(Collider other)
    {
        if(other.gameObject.tag == "interactArea")
        {
            enabledCanvas = false;
            canvas.GetComponent<Canvas>().enabled = false;
        }
    }
	
	void OnTriggerStay (Collider other) {
		if(other.gameObject.tag == "interactArea" && Input.GetMouseButton(0) && !enabledCanvas)
        {
            enabledCanvas = true;
            canvas.GetComponent<Canvas>().enabled = true;
        } else
        {
            if (Input.GetMouseButton(1) && enabledCanvas)
            {
                enabledCanvas = false;
                canvas.GetComponent<Canvas>().enabled = false;
            }
        }
	}
}
