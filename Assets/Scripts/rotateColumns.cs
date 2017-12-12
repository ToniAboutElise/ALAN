using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateColumns : MonoBehaviour
{

    public int Xrotation;
    public int Yrotation;
    public int Zrotation;

    public GameObject[] columnToRotate;

    void OnTriggerStay(Collider other)
    {

        if (other.tag == "interactArea" && Input.GetMouseButton(0))
        {
            transform.Rotate(Xrotation * Time.deltaTime, Yrotation * Time.deltaTime, Zrotation * Time.deltaTime);
            for(int i = 0; i <= columnToRotate.Length; i++) { 
            columnToRotate[i].transform.Rotate(Xrotation * Time.deltaTime, -Yrotation * Time.deltaTime, Zrotation * Time.deltaTime);
            }

        }
    }
}

