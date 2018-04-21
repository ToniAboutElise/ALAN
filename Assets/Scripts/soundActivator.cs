using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundActivator : MonoBehaviour {
    bool activated;
    public int currInt;
    public int maxInt;
    public GameObject objToAct;

	// Use this for initialization
	void Start () {
        activated = false;
        currInt = 0;

    }
	
	// Update is called once per frame
	void Update () {
		if(activated == false && currInt == maxInt)
        {
            activated = true;
            objToAct.SetActive(true);
        }
	}
}
