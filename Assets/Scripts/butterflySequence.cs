using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class butterflySequence : MonoBehaviour {

    public GameObject ButterflyController;
    public GameObject ButterflyBody;
    public GameObject Alan;

    IEnumerator StartDelay()
    {
        yield return new WaitForSeconds(5);
        StartCoroutine(ButterflyFlies());
    }

    IEnumerator ButterflyFlies()
    {
        ButterflyController.GetComponent<Animator>().enabled = true;
        ButterflyBody.GetComponent<Animator>().enabled = true;
        yield return new WaitForSeconds(4.5f);
        ButterflyBody.GetComponent<Animator>().SetBool("sitting", true);
        yield return new WaitForSeconds(3);
        ButterflyController.GetComponent<Animator>().SetBool("UpAgain", true);
        ButterflyBody.GetComponent<Animator>().SetBool("sitting", false);
        ButterflyBody.GetComponent<Animator>().SetBool("flyAgain", true);
        //yield return new WaitForSeconds(0.7f);
        //Alan.GetComponent<Animator>().SetBool("handsUp", true);
    }


    void Start () {
        ButterflyController.GetComponent<Animator>().enabled = false;
        ButterflyBody.GetComponent<Animator>().enabled = false;
        StartCoroutine(StartDelay());
        
	}
	
}
