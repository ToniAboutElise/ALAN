using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startManager : MonoBehaviour {

    public GameObject[] sqA;
    public GameObject FPS_Prefab;
    public GameObject cameraDeact;
    public bool act;


    void Start() {
        FPS_Prefab.SetActive(false);
        cameraDeact.SetActive(true);
        act = false;
    }

    void Update()
    {
        if (act)
        {
            for (int i = 0; i < sqA.Length; i++)
            {
                sqA[i].GetComponent<Animation>().Play("squareStartPosition");
            }
            FPS_Prefab.SetActive(true);
            cameraDeact.SetActive(false);
            act = false;
        }

    }
}
