using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballManager : MonoBehaviour {

    public int totalCount;
    public int dialogue;

    void Start()
    {
        totalCount = 0;
        dialogue = 0;
    }

    void Update()
    {
        if (totalCount == 10)
        {
            //end puzzle
        }

        if(dialogue == 2)
        {
            //trigger dialogue every 2 balls activated
            dialogue = 0;
        }
    }
}
