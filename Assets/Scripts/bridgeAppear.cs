using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class bridgeAppear : MonoBehaviour {

    public Image[] bridgeParts;
    public float velocity;
    public float Fillvelocity;
    int bridgeInt;
    int deactBridgeInt;
    public bool play;
    public int ballCount;
    public int ballsActivated;

	void Start () {
		for(int i = 0; i <= bridgeParts.Length -1; i++)
        {
            bridgeParts[i].fillAmount = 0;
            bridgeParts[i].GetComponent<BoxCollider>().enabled = false;
        }
        bridgeInt = 0;
        ballsActivated = 0;
        deactBridgeInt = 0;
        if (play == true)
        {
            StartCoroutine(bridge());
        }
    }
	
    public void SpawnBridge()
    {
        StartCoroutine(bridge());
    }

    public IEnumerator bridge() {
        if(bridgeParts[bridgeInt].fillAmount != 1) { 
            bridgeParts[bridgeInt].fillAmount += velocity;
            bridgeParts[bridgeInt].GetComponent<BoxCollider>().enabled = true;
            yield return new WaitForSeconds(Fillvelocity);
            StartCoroutine(bridge());
        }
        else if (bridgeInt != bridgeParts.Length -1)
        {
            bridgeInt += 1;
            yield return new WaitForSeconds(Fillvelocity);
            StartCoroutine(bridge());
        } else if(bridgeInt == bridgeParts.Length -1 && play == true)
        {
            for(int i = 0; i < bridgeParts.Length; i++)
            {
                bridgeParts[i].GetComponent<Animation>().Play("rotateAndDisappearBridgePart");
            }
            bridgeInt = 0;
            deactBridgeInt = 0;
            StartCoroutine(bridge());
        }
    }
}

