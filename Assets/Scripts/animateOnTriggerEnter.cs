using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animateOnTriggerEnter : MonoBehaviour {

    public GameObject objToAnimate;
    public GameObject objToAct;
    public GameObject objToDeact;
    public GameObject wallToAct;
    public GameObject activatorToAct;
    bool hasEntered;
    public bool afterTrigger;
    public string animToPlay;

    void Start()
    {
        hasEntered = false;
    }

	void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player" && hasEntered == false)
        {
            hasEntered = true;
            objToAnimate.GetComponent<Animation>().Play(animToPlay);
            if (afterTrigger)
            {
                objToAct.SetActive(true);
                objToDeact.SetActive(false);
                wallToAct.SetActive(true);
                activatorToAct.SetActive(true);
            }
        }
    }
}
