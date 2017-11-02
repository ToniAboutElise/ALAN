using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class introManager : MonoBehaviour {

    public GameObject text;
    public GameObject[] button;
    public GameObject panelToDis;
    public GameObject panelToAct;
    public Animation anim;
    public AnimationClip inText;
    public AnimationClip outText;
    public AnimationClip inButton;
    public AnimationClip outButton;
    public bool beginning;
    

    public IEnumerator disablePanel()
    {
        yield return new WaitForSeconds(1.2f);
    }

    public void fadeInText(GameObject target)
    {
            anim.Play("inText");
        
    }

    public void fadeOutText(GameObject target)
    {
            anim.Play("outText");
        
    }

    public void fadeInButton(GameObject[] target)
    {
        for (int i = 0; i < button.Length; i++)
        {
            anim.Play("inButton");
        }
    }

    public void fadeOutButton(GameObject[] target)
    {
        for (int i = 0; i < button.Length; i++)
        {
            anim.Play("outButton");
        }
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

	public void Awake () {
        //anim = GetComponent<Animation>();
        anim.AddClip(inText, "inText");
        anim.AddClip(outText, "outText");
        anim.AddClip(inButton, "inButton");
        anim.AddClip(outButton, "outButton");

    }

}
