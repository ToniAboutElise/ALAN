using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkEmissive : MonoBehaviour {

    public GameObject A;
    public GameObject B;
    public GameObject C;
    public GameObject act;
    public GameObject deact;
    bool checkA;
    bool checkB;
    bool checkC;

    void Update () {

        checkA = A.GetComponent<changeEmissive>().changedEmissive;
        checkB = B.GetComponent<changeEmissive>().changedEmissive;
        checkC = C.GetComponent<changeEmissive>().changedEmissive;
        if (checkA && checkB && checkC)
        {
            act.SetActive(true);
            deact.SetActive(false);
        }
	}
}
