using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class textAppear : MonoBehaviour {

    public string[] appearText;
    public Text myText;
    public int[] timeToWait;
    public AudioSource beep;

    public GameObject act;
    public GameObject background;
    public bool actObject;
    public GameObject objToAct;

    void Start()
    {
        background.SetActive(false);
        StartCoroutine(Typing());
    }

    IEnumerator Typing()
    {
        yield return new WaitForSeconds(2);
        background.SetActive(true);
        for (int i = 0; i < appearText.Length; i++) { 
        foreach (char letter in appearText[i].ToCharArray())
        {
            myText.text += letter;
            beep.Play();
            yield return new WaitForSeconds(0.03f);
        }

        if (myText.text == appearText[i])
        {
            yield return new WaitForSeconds(timeToWait[i]);
            myText.text = "";
            }  
        }
        background.SetActive(false);
        yield return new WaitForSeconds(0.5f);
        if (actObject == true)
        {
            objToAct.SetActive(true);
        }
        act.GetComponent<startManager>().act = true;
        
    }



}