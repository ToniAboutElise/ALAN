using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkEmissive : MonoBehaviour {

    public GameObject A;
    public GameObject B;
    public GameObject C;
    public GameObject act;
    public GameObject deact;
    public GameObject actDoor;
    public GameObject deactDoor;
    bool checkA;
    bool checkB;
    bool checkC;
    bool isPlaying;

    void Start()
    {
        isPlaying = false;
    }

    void Update () {

        checkA = A.GetComponent<changeEmissive>().changedEmissive;
        checkB = B.GetComponent<changeEmissive>().changedEmissive;
        checkC = C.GetComponent<changeEmissive>().changedEmissive;
        if (checkA && checkB && checkC && !isPlaying)
        {
            act.SetActive(true);
            deact.SetActive(false);
            actDoor.SetActive(true);
            deactDoor.SetActive(false);
            actDoor.GetComponent<Animation>().Play();
            isPlaying = true;
        }
	}
}
