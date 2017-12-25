using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateColumns : MonoBehaviour
{
    public int Xrotation;
    public int Yrotation;
    public int Zrotation;

    public GameObject[] columnToRotate;
    public GameObject columnToRotateInvert;

    public bool invert;

    void OnTriggerStay(Collider other)
    {
        if (other.name == "collisionDoor")
        {
            GetComponent<BoxCollider>().enabled = false;
            other.GetComponent<BoxCollider>().enabled = false;
        }

        if (other.tag == "interactArea" && Input.GetMouseButton(0) && invert)
        {
            transform.Rotate(Xrotation * Time.deltaTime, Yrotation * Time.deltaTime, Zrotation * Time.deltaTime);
            for(int i = 0; i <= columnToRotate.Length; i++) { 
            columnToRotate[i].transform.Rotate(Xrotation * Time.deltaTime, -Yrotation * Time.deltaTime, Zrotation * Time.deltaTime);
            columnToRotateInvert.transform.Rotate(Xrotation * Time.deltaTime, -Yrotation * Time.deltaTime, -Zrotation * Time.deltaTime);

            }


        }

        if (other.tag == "interactArea" && Input.GetMouseButton(0) && !invert)
        {
            transform.Rotate(Xrotation * Time.deltaTime, Yrotation * Time.deltaTime, Zrotation * Time.deltaTime);
            for (int i = 0; i <= columnToRotate.Length; i++)
            {
                columnToRotate[i].transform.Rotate(Xrotation * Time.deltaTime, -Yrotation * Time.deltaTime, Zrotation * Time.deltaTime);

            }
            columnToRotateInvert.transform.Rotate(Xrotation * Time.deltaTime, -Yrotation * Time.deltaTime, -Zrotation * Time.deltaTime);

        }

    }
}

