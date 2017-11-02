using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class introManager : MonoBehaviour {

    public GameObject[] text;
    public GameObject[] button;
    public GameObject panelToDis;
    public GameObject panelToAct;
    public Animation anim;
    public AnimationClip inAnim;
    public AnimationClip outAnim;

    IEnumerator disablePanel()
    {
        yield return new WaitForSeconds(1.2f);
    }

    void fadeInText(GameObject[] target)
    {
        for(int i = 0; i < text.Length; i++)
        {
            anim.Play("inText");
        }
    }

    void fadeOutText(GameObject[] target)
    {
        for (int i = 0; i < text.Length; i++)
        {
            anim.Play("outText");
        }
    }

    void fadeInButton(GameObject[] target)
    {
        for (int i = 0; i < text.Length; i++)
        {
            anim.Play("inButton");
        }
    }

    void fadeOutButton(GameObject[] target)
    {
        for (int i = 0; i < text.Length; i++)
        {
            anim.Play("outButton");
        }
    }

	void Awake () {
        anim = GetComponent<Animation>();
        anim.AddClip(inAnim, "inText");
        anim.AddClip(outAnim, "outText");
        anim.AddClip(inAnim, "inButton");
        anim.AddClip(outAnim, "outButton");
    }

}
