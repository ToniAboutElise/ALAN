using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class bridgeAppear : MonoBehaviour {

    public Image[] bridgeParts;
    public float velocity;
    public float Fillvelocity;
    int bridgeInt;
    public bool test;

	void Start () {
		for(int i = 0; i <= bridgeParts.Length -1; i++)
        {
            bridgeParts[i].fillAmount = 0;
        }
        bridgeInt = 0;
    }
	
    void Update()
    {
        if(test == true)
        {
            StartCoroutine(bridge());
            test = false;
        }
    }

    IEnumerator bridge() {
        if(bridgeParts[bridgeInt].fillAmount != 1) { 
            bridgeParts[bridgeInt].fillAmount += velocity;
            yield return new WaitForSeconds(Fillvelocity);
            StartCoroutine(bridge());
        }
        else if (bridgeInt != bridgeParts.Length)
        {
            bridgeInt += 1;
            yield return new WaitForSeconds(Fillvelocity);
            StartCoroutine(bridge());
        }
    }
}

