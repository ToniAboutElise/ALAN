using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class textAppear : MonoBehaviour {

    public string[] appearText;
    public Text[] myText;
    public int[] timeToWait;

    public GameObject act;

    void Start()
    {
        StartCoroutine(Typing());
    }

    IEnumerator Typing()
    {
        for(int i = 0; i < myText.Length; i++) { 
        foreach (char letter in appearText[i].ToCharArray())
        {
            myText[i].text += letter;
            yield return new WaitForSeconds(0.01f);
        }

        if (myText[i].text == appearText[i])
        {
            yield return new WaitForSeconds(timeToWait[i]);
            myText[i].text = "";
            yield return new WaitForSeconds(2);
        }
    }
        act.GetComponent<startManager>().act = true;

    }



}