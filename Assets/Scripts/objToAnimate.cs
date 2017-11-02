using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objToAnimate : MonoBehaviour
{
    public GameObject triggerObject;
    public bool isClosed;
    public bool playsAnim;
    public AnimationClip anim1;
    public AnimationClip anim2;
    private Animation anim;

    void Awake()
    {
        triggerObject.GetComponent<BoxCollider>().enabled = false;
        playsAnim = false;
        isClosed = true;
        anim = GetComponent<Animation>();
        anim.AddClip(anim1, "open");
        anim.AddClip(anim2, "close");
    }

    IEnumerator waitAnim()
    {
        playsAnim = true;
        yield return new WaitForSeconds(1.2f);
        playsAnim = false;
        if (!isClosed)
        {
            triggerObject.GetComponent<BoxCollider>().enabled = true;
        } else {
            triggerObject.GetComponent<BoxCollider>().enabled = false;
        }
    }

    public void playAnimation()
    {
        if (!isClosed && !playsAnim)
        {
            anim.Play("close");
            triggerObject.GetComponent<BoxCollider>().enabled = false;
            StartCoroutine(waitAnim());

        }
        else if (isClosed && !playsAnim)
        {
            anim.Play("open");
            triggerObject.GetComponent<BoxCollider>().enabled = false;
            StartCoroutine(waitAnim());
        }isClosed = !isClosed;
    }
}

