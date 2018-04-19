using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tombManager : MonoBehaviour {

    public GameObject[] tomb;
    public bool tombsDone;
    int tombCount;
    public GameObject doorToOpen;
    bool opened;

    void Start()
    {
        opened = false;
        tombsDone = false;
        tombCount = 0;
    }

    void Update()
    {

        if(tombsDone == true && opened == false)
        {
            opened = true;
            doorToOpen.GetComponent<Animation>().Play();
        }

        for(int i = 0; i < tomb.Length; i++)
        {
            if(tomb[i].GetComponent<candleManager>().candlesDone == false)
            {
                tombsDone = false;
                tombCount = 0;
            }
            else
            {
                tombCount++;
            }

            if(tombCount == tomb.Length)
            {
                tombsDone = true;
            }
        }
    }
}
