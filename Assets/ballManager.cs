using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballManager : MonoBehaviour {

    public int totalCount;
    public int dialogue;
    int dialogueNumber;
    public GameObject[] triggerDialogues;

    void Start()
    {
        totalCount = 0;
        dialogue = 0;
        dialogueNumber = 0;
    }

    void Update()
    {
        if (totalCount == 10)
        {
            //end puzzle
        }

        if(dialogue == 2)
        {
            triggerDialogues[dialogueNumber].SetActive(true);
            dialogueNumber++;
            dialogue = 0;
        }
    }
}
