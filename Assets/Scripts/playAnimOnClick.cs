using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playAnimOnClick : MonoBehaviour {

    public GameObject triggerObject;
    public bool playsAnim;
    public AnimationClip anim1;
    private Animation anim;

    void Awake()
    {
        triggerObject.GetComponent<BoxCollider>().enabled = false;
        playsAnim = false;
        anim = GetComponent<Animation>();
        anim.AddClip(anim1, "animToPlay");
    }

    IEnumerator waitAnim()
    {
        playsAnim = true;
        yield return new WaitForSeconds(0.4f);
        playsAnim = false;
        
    }

    public void Update()
    {
        if(Input.GetMouseButtonDown(0) && !playsAnim)
        {
            anim.Play("animToPlay");
            triggerObject.GetComponent<BoxCollider>().enabled = true;
            StartCoroutine(waitAnim());
        } else if (!playsAnim)
        {
            triggerObject.GetComponent<BoxCollider>().enabled = false;
        }
        {

        }
    }

    }
