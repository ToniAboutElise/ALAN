using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class textAppear : MonoBehaviour {

    public string[] appearText;
    public Text[] myText;
    public int[] timeToWait;
    public AudioSource beep;

    public GameObject act;
    public GameObject background;

    void Start()
    {
        background.SetActive(false);
        StartCoroutine(Typing());
    }

    IEnumerator Typing()
    {
        yield return new WaitForSeconds(2);
        background.SetActive(true);
        for (int i = 0; i < myText.Length; i++) { 
        foreach (char letter in appearText[i].ToCharArray())
        {
            myText[i].text += letter;
            beep.Play();
            yield return new WaitForSeconds(0.04f);
        }

        if (myText[i].text == appearText[i])
        {
            yield return new WaitForSeconds(timeToWait[i]);
            myText[i].text = "";
            }  
        }
        background.SetActive(false);
        yield return new WaitForSeconds(0.5f);
        act.GetComponent<startManager>().act = true;
    }



}