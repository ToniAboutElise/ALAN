using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tombManager : MonoBehaviour {

    public GameObject[] tomb;
    bool tombsDone;
    int tombCount;

    void Start()
    {
        tombsDone = false;
        tombCount = 0;
    }

    void Update()
    {
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
