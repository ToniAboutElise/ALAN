using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objectInteraction : MonoBehaviour {

    bool isInteracting;
    public Canvas canvas;

    void OnTriggerStay(Collider other)
    {

        //Start interacting
        if (other.tag == "interactArea" && Input.GetMouseButton(0) && !isInteracting)
        {
            Debug.Log("left mouse");
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            canvas.enabled = true;
            isInteracting = true;
        }

        //Stop interacting
        if (other.tag == "interactArea" && Input.GetMouseButton(1) && isInteracting)
        {
            Debug.Log("right mouse");
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
            canvas.enabled = false;
            isInteracting = false;
        }



    }
	
	
}
