using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class introManager : MonoBehaviour {

    public bool playUp;
    public GameObject text;
    public GameObject buttonContainer;
    public GameObject[] button;
    public GameObject panelToDis;
    public GameObject panelToAct;
    public Animation anim;
    public Animation animButton;
    public AnimationClip inText;
    public AnimationClip outText;
    public AnimationClip inButton;
    public AnimationClip outButton;
    public AnimationClip buttonsDown;
    public bool beginning;
    

    public IEnumerator disablePanel()
    {
        yield return new WaitForSeconds(6);
        panelToDis.SetActive(false);
        panelToAct.SetActive(true);
        text.GetComponent<Animation>().enabled = true;
        buttonContainer.GetComponent<Animation>().enabled = true;
        panelToDis.SetActive(false);
        foreach (GameObject go in button)
        {
            go.GetComponent<Button>().enabled = false;
        }
        anim.Play("buttonsUp");
    }

    public void buttonsGoDown()
    {
        animButton.Play("buttonsDown");
        StartCoroutine(disablePanel());
    }


    public void fadeInText(GameObject target)
    {
            anim.Play("inText");
        
    }



    public void fadeOutText(GameObject target)
    {
            anim.Play("outText");
        
    }
 
    public IEnumerator destroyThis()
    {
        yield return new WaitForSeconds(8);
        Destroy(this);
    }

    public void startText()
    {
        if(beginning == true)
        {
            anim.Play("start");
            beginning = false;
            StartCoroutine(destroyThis());
        }
    }

    public void buttonsUp()
    {
        animButton.Play("buttonsUp");
    }

	public void Awake () {
        anim.AddClip(inText, "inText");
        anim.AddClip(outText, "outText");
        anim.AddClip(inButton, "inButton");
        anim.AddClip(outButton, "outButton");
        animButton.AddClip(buttonsDown, "buttonsDown");
        text.GetComponent<Animation>().enabled = false;
        buttonContainer.GetComponent<Animation>().enabled = true;
        foreach (GameObject go in button) { 
            go.GetComponent<Button>().enabled = false;
        }

    }


}
