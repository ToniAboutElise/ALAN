using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveAlong : MonoBehaviour {

    public int Xrotation;
    public int Yrotation;
    public int Zrotation;

    public float Xmove;
    public float Ymove;
    public float Zmove;
    public float speed;



    public GameObject UI;

    public GameObject objToMove;
    public GameObject objToMoveInvert;
    bool theBool;

    Vector3 start;
    Vector3 max;

    void Start()
    {
        start = objToMove.transform.position;
        max = objToMove.transform.position;
    }

    void Update()
    {
        theBool = objToMove.GetComponent<setBool>().myBool;
        //Debug.Log(theBool);
    }

    void OnTriggerStay(Collider other)
    {
        if (other.tag == "interactArea")
        {
            UI.SetActive(true);
        }

        if (other.tag == "interactArea" && Input.GetMouseButton(0))
        {
            transform.Rotate(Xrotation * Time.deltaTime, Yrotation * Time.deltaTime, Zrotation * Time.deltaTime);
            

            if (!theBool)
            {
                objToMove.transform.position = new Vector3(objToMove.transform.position.x + Xmove, objToMove.transform.position.y + Ymove, objToMove.transform.position.z + Zmove);
            } else if (theBool)
            {
                objToMove.transform.position = new Vector3(objToMove.transform.position.x - Xmove, objToMove.transform.position.y - Ymove, objToMove.transform.position.z - Zmove);
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
