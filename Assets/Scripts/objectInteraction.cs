using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objectInteraction : MonoBehaviour {

    bool isInteracting;
    public GameObject FPSCharacter;
    public Camera FPSCamera;
    public GameObject FPSCharPos;
    public Canvas canvas;
    Vector3 storedPos;
    Vector3 storedRot;
    Vector3 cameraRot;

    void Start ()
    {
        canvas.enabled = false;
        isInteracting = false;
        cameraRot.x = FPSCamera.transform.rotation.x;
        cameraRot.y = FPSCamera.transform.rotation.y;
        cameraRot.z = FPSCamera.transform.rotation.z;

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "interactArea" && !isInteracting)
        {
            Debug.Log("ha entrado");
            storedPos = FPSCamera.transform.position;
            storedRot.x = FPSCamera.transform.rotation.x;
            storedRot.y = FPSCamera.transform.rotation.y;
            storedRot.z = FPSCamera.transform.rotation.z;
        }
    }

    void OnTriggerStay(Collider other)
    {

        //if it enters inside the trigger, it'll start storing the position of the FPSCamera
        

        //Start interacting
        if (other.tag == "interactArea" && Input.GetMouseButton(0) && !isInteracting)
        {
            Debug.Log("left mouse");
            //FPSCharacter.SetActive(false);
            FPSCamera.transform.eulerAngles = FPSCharPos.transform.position;
            //FPSCamera.transform.rotation = FPSCharPos.transform.rotation;
            canvas.enabled = true;
            isInteracting = true;
        }

        //Stop interacting
        //Go back to the first state, activate FPS controller and deactivate canvas
        if (other.tag == "interactArea" && Input.GetMouseButton(1) && isInteracting)
        {
            Debug.Log("right mouse");
            canvas.enabled = false;
            FPSCamera.transform.position = storedPos;
            cameraRot.x = storedRot.x;
            cameraRot.y = storedRot.y;
            cameraRot.z = storedRot.z;
            //FPSCharacter.SetActive(true);
            isInteracting = false;
        }



    }
	
	
}
